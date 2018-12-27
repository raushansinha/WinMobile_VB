
Imports System.Data.SqlServerCe
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.DataAccess

Namespace NWA.Safetrac.Scanner.BO
    Public Class BinBulk

        Private _objFlight As Flight = Nothing
        Private _intRefCount As Integer = 10
        Private _strBinBulkNo As String
        Private _queLastScannedBags As New Queue(Of String)(_intRefCount)
        Private _queLastScannedMails As New Queue(Of String)(_intRefCount)
        Private _queLastScannedFreight As New Queue(Of String)(_intRefCount)

        Public ReadOnly Property Flight() As Flight
            Get
                Return _objFlight
            End Get
        End Property

        Public ReadOnly Property BinBulkNum() As String
            Get
                Return _strBinBulkNo
            End Get
        End Property
        Public ReadOnly Property Destination() As String
            Get
                Return _objFlight.Destination
            End Get
        End Property
        Public ReadOnly Property BagCount() As Integer
            Get
                'get bags count from the database
                Return FlightOperations.GetBagCountOfBin(_objFlight.FlightNum, _objFlight.DepartureDate, Me._strBinBulkNo)
            End Get
        End Property
        Public ReadOnly Property BagsWeight() As Integer
            Get
                'calculate weight from the database based on the bags
                Return FlightOperations.GetBagsWeightOfBin(_objFlight.FlightNum, _objFlight.DepartureDate, Me._strBinBulkNo)
            End Get
        End Property
        Public ReadOnly Property MailCount() As Integer
            Get
                'get mails count from database
                Return FlightOperations.GetMailCountOfBin(_objFlight.FlightNum, _objFlight.DepartureDate, Me._strBinBulkNo)
            End Get
        End Property
        Public ReadOnly Property MailsWeight() As Integer
            Get
                'calculate weight from the database based on the mails
                Return FlightOperations.GetMailsWeightOfBin(_objFlight.FlightNum, _objFlight.DepartureDate, Me._strBinBulkNo)
            End Get
        End Property
        Public ReadOnly Property FreightCount() As Integer
            Get
                'get freight count from the database
                Return FlightOperations.GetFreightCountOfBin(_objFlight.FlightNum, _objFlight.DepartureDate, Me._strBinBulkNo)
            End Get
        End Property
        Public ReadOnly Property FreightWeight() As Integer
            Get
                'calculate weight from the database based on freight
                Return FlightOperations.GetFreightWeightOfBin(_objFlight.FlightNum, _objFlight.DepartureDate, Me._strBinBulkNo)
            End Get
        End Property
        Public ReadOnly Property TotalWeight() As Integer
            Get
                Return FlightOperations.GetTotalWeightOfBin(_objFlight.FlightNum, _objFlight.DepartureDate, Me._strBinBulkNo)
            End Get
        End Property

        Public ReadOnly Property HasCapacityExceeded() As Boolean
            Get
                Return FlightOperations.HasBinCapacityExceeded(_objFlight.FlightNum, _objFlight.DepartureDate, _strBinBulkNo)
            End Get
        End Property

        Public ReadOnly Property LastScannedBags() As Queue(Of String)
            Get
                Return _queLastScannedBags
            End Get
        End Property
        Public ReadOnly Property LastScannedMails() As Queue(Of String)
            Get
                Return _queLastScannedMails
            End Get
        End Property
        Public ReadOnly Property LastScannedFreight() As Queue(Of String)
            Get
                Return _queLastScannedFreight
            End Get
        End Property

        Public Sub New(ByVal flight As Flight, ByVal binBulkNo As String)
            Try
                _objFlight = flight
                _strBinBulkNo = binBulkNo
                Dim strLog As String = String.Format("Bin Bulk added, Flight Num = {0}, Flight Date = {1}, BinBulkNum = {2}", _
                _objFlight.FlightNum, _objFlight.DepartureDate, binBulkNo)
                Logger.LogMessage(strLog, LogType.Trace, "BinBulk.New")
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        'Public Function GetSummary() As DataSet
        '    Return FlightOperations.GetBinBulkSummary(_objFlight.FlightNum, _objFlight.DepartureDate, _strBinBulkNo)
        'End Function

        Public Function LoadNormalBag(ByVal bagTagNum As String) As ReturnCodes
            Return LoadBag(bagTagNum, BOConstants.NormalBagWeight.ToString, ScanModes.Normal)
        End Function

        Public Function LoadHeavyBag(ByVal bagTagNum As String) As ReturnCodes
            Return LoadBag(bagTagNum, BOConstants.HeavyBagWeight.ToString, ScanModes.Heavy)
        End Function

        Public Function LoadPlaneSideBag(ByVal bagTagNum As String) As ReturnCodes
            Return LoadBag(bagTagNum, BOConstants.PlanesideBagWeight.ToString, ScanModes.Planeside)
        End Function

        Public Function LoadManualBag(ByVal bagTagNum As String, ByVal weight As String) As ReturnCodes
            Return LoadBag(bagTagNum, weight, ScanModes.Manual)
        End Function

        Public Function LoadAnimal(ByVal animalNum As String, ByVal weight As String) As ReturnCodes
            Return LoadBag(animalNum, weight, ScanModes.Animal)
        End Function

        Public Function LoadDamagedBag(ByVal bagTagNum As String, ByVal weight As String) As ReturnCodes
            Return LoadBag(bagTagNum, weight, ScanModes.Damaged)
        End Function

        Private Function LoadBag(ByVal bagtagNum As String, ByVal weight As String, ByVal scanMode As ScanModes) As ReturnCodes
            Try

                Dim retCode As ReturnCodes
                Dim strLog As String = String.Empty

                'check if flight is closed
                If _objFlight.IsClosed Then
                    Return ReturnCodes.FlightClosed
                End If

                'check is flight has departed
                If _objFlight.IsDeparted Then
                    Return ReturnCodes.FlightDeparted
                End If

                If Common.IsDuplicateBagtag(bagtagNum) Then
                    Return ReturnCodes.BagtagDuplicatesFound
                End If

                If _objFlight.IsBagTagValid(bagtagNum) <> ReturnCodes.Ok Then
                    If Common.IsBagtagValid(bagtagNum) = True Then
                        Return ReturnCodes.BagtagInvalidForFlight
                    Else
                        If _objFlight.IsPBMDisabled Then
                            'PBM is disabled - proceed for direct loading
                            strLog = String.Format("Calling LoadUnknownBagToBinBulk, bagtagNum = {0}", bagtagNum)
                            Logger.LogMessage(strLog, LogType.Trace, "BinBulk.LoadBag")

                            retCode = FlightOperations.LoadUnknownBagToBinBulk(_objFlight.FlightNum, _
                            _objFlight.DepartureDate, _strBinBulkNo, bagtagNum)

                            strLog = String.Format("retCode = {0}", retCode)
                            Logger.LogMessage(strLog, LogType.Trace, "BinBulk.LoadBag")

                            If retCode = ReturnCodes.Ok Then
                                SetLastScannedBag(bagtagNum)
                            End If
                            Return retCode
                        Else
                            'PBM is enabled
                            Return ReturnCodes.BagtagUnknown
                        End If
                    End If
                End If

                If _objFlight.IsBagOnNoLoad(bagtagNum) Then
                    Return ReturnCodes.BagtagOnNoLoad
                End If

                If Not _objFlight.IsPassengerCheckedIn(bagtagNum) Then
                    Return ReturnCodes.PassengerNotCheckedIn
                End If

                If _objFlight.IsPassengerOnStandBy(bagtagNum) Then
                    Return ReturnCodes.PassengerOnStandBy
                End If

                If Me.IsBagAlreadyLoaded(bagtagNum) Then
                    Return ReturnCodes.BagtagAlreadyLoaded
                End If

                If _objFlight.IsBagOnAlert(bagtagNum) Then
                    Return ReturnCodes.BagtagOnAlert
                End If

                'world update flight error
                'all set proceed with loading of bag

                Select Case scanMode
                    Case ScanModes.Normal, ScanModes.Manual, ScanModes.Heavy, ScanModes.Planeside
                        retCode = FlightOperations.LoadBagToBinBulk(_objFlight.FlightNum, _
                                _objFlight.DepartureDate, _strBinBulkNo, bagtagNum, weight)

                    Case ScanModes.Damaged
                        retCode = FlightOperations.LoadDamagedBagToBinBulk(_objFlight.FlightNum, _
                                _objFlight.DepartureDate, _strBinBulkNo, bagtagNum, weight)

                    Case ScanModes.Animal
                        retCode = FlightOperations.LoadAnimalToBinBulk(_objFlight.FlightNum, _
                                _objFlight.DepartureDate, _strBinBulkNo, bagtagNum, weight)

                End Select

                If retCode = ReturnCodes.Ok Then
                    SetLastScannedBag(bagtagNum)
                End If

                Return retCode

            Catch ex As Exception
                LoadBag = ReturnCodes.Unknown
            End Try
        End Function

        Public Function LoadBagOnAlert(ByVal bagTagNum As String) As ReturnCodes
            Try
                'FlightOperations.RemoveBagtagAlert(bagTagNum, _objFlight.FlightNum, _objFlight.DepartureDate)
                Dim retCode As ReturnCodes
                retCode = FlightOperations.LoadBagToBinBulk(_objFlight.FlightNum, _objFlight.DepartureDate, _strBinBulkNo, bagTagNum)
                If retCode = ReturnCodes.Ok Then
                    If _queLastScannedBags.Count = _intRefCount Then
                        _queLastScannedBags.Clear()
                    End If
                    _queLastScannedBags.Enqueue(bagTagNum)
                End If
                LoadBagOnAlert = retCode
            Catch ex As Exception
                LoadBagOnAlert = ReturnCodes.Unknown
            End Try
        End Function

        Public Function LoadExpediteBag(ByVal bagTagNum As String, ByVal expediteCode As String, _
        ByVal returnCode As ReturnCodes) As ReturnCodes

            Dim retCode As ReturnCodes

            'check if flight is closed
            If _objFlight.IsClosed Then
                Return ReturnCodes.FlightClosed
            End If

            'check is flight has departed
            If _objFlight.IsDeparted Then
                Return ReturnCodes.FlightDeparted
            End If

            If _objFlight.IsBagAlreadyLoaded(bagTagNum) Then
                Return ReturnCodes.BagtagAlreadyLoaded
            End If

            If Common.IsDuplicateBagtag(bagTagNum) Then
                Return ReturnCodes.BagtagDuplicatesFound
            End If

            Select Case returnCode
                Case ReturnCodes.BagtagInvalidForFlight
                    'update the record
                    retCode = FlightOperations.LoadExpediteBag(_objFlight.FlightNum, _
                                                _objFlight.DepartureDate, _strBinBulkNo, bagTagNum, expediteCode)
                Case ReturnCodes.BagtagUnknown
                    retCode = FlightOperations.LoadUnknownBagToBinBulk(_objFlight.FlightNum, _
                                                _objFlight.DepartureDate, _strBinBulkNo, bagTagNum, expediteCode)
            End Select
            Return retCode
        End Function

        Public Function AddLateBag(ByVal count As String, ByVal weight As String, ByVal commdType As String, _
        ByVal finalDestination As String) As ReturnCodes
            Try
                Dim retCode As ReturnCodes

                'check if flight is closed

                If _objFlight.IsClosed Then
                    Return ReturnCodes.FlightClosed
                End If

                'check is flight has departed

                If _objFlight.IsDeparted Then
                    Return ReturnCodes.FlightDeparted
                End If

                retCode = FlightOperations.AddLateBag(_objFlight.FlightNum, _objFlight.DepartureDate, _strBinBulkNo, commdType, count, weight, finalDestination)
                Return retCode
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CreateNewAWBNumber(ByVal awbNum As String, ByVal pieces As Integer, ByVal weight As Integer, _
        ByVal type As String) As ReturnCodes
            'pending - webservice call




        End Function

        Public Function LoadMail(ByVal mailNum As String, ByVal type As String, ByVal destination As String, _
                ByVal finalDest As String, ByVal pieces As Integer, ByVal weight As Double, ByVal blnManual As Boolean) As ReturnCodes

            'check if flight is closed
            If _objFlight.IsClosed Then
                Return ReturnCodes.FlightClosed
            End If

            'check is flight has departed
            If _objFlight.IsDeparted Then
                Return ReturnCodes.FlightDeparted
            End If

            If Me.IsMailAlreadyLoaded(mailNum) Then
                Return ReturnCodes.MailAlreadyRegistered
            End If

            If Common.IsDestinationValid(finalDest) = False Then
                Return ReturnCodes.FinalDestinationInvalid
            End If

            Dim retCode As ReturnCodes

            If Not blnManual Then
                If Common.IsMailValid(mailNum) Then
                    retCode = FlightOperations.LoadMailToBinBulk(_objFlight.FlightNum, _objFlight.DepartureDate, _
                     _strBinBulkNo, mailNum)
                    If retCode = ReturnCodes.Ok Then
                        SetLastScannedMail(mailNum)
                    End If
                Else
                    retCode = FlightOperations.LoadMailToBinBulk(_objFlight.FlightNum, _objFlight.DepartureDate, _
                                        _strBinBulkNo, mailNum, type, weight, pieces, finalDest)
                    If retCode = ReturnCodes.Ok Then
                        SetLastScannedMail(mailNum)
                    End If
                    Return retCode
                End If
            Else
                'manual indicator, mail number doesnt exist
                retCode = FlightOperations.LoadMailToBinBulk(_objFlight.FlightNum, _objFlight.DepartureDate, _
                                        _strBinBulkNo, mailNum, type, weight, pieces, finalDest)
            End If

            Return retCode

        End Function

        Public Function UnloadMail(ByVal mailNum As String) As ReturnCodes

            'check if flight is closed
            If _objFlight.IsClosed Then
                Return ReturnCodes.FlightClosed
            End If

            'check is flight has departed
            If _objFlight.IsDeparted Then
                Return ReturnCodes.FlightDeparted
            End If

            If _objFlight.IsMailValid(mailNum) Then
                Return FlightOperations.UnloadMailFromBinBulk(_objFlight.FlightNum, _objFlight.DepartureDate, _
                 _strBinBulkNo, mailNum)
            Else
                Return ReturnCodes.MailNotFound
            End If

        End Function

        Public Function LoadFreight(ByVal freightNum As String) As ReturnCodes
            If Me.IsFreightAlreadyLoaded(freightNum) Then
                Return ReturnCodes.FreightAlreadyLoaded
            End If
            'update the freight record in the database with the container number
            Try
                Return FlightOperations.LoadFreightToBinBulk(_objFlight.FlightNum, _objFlight.DepartureDate, _strBinBulkNo, freightNum)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LoadFreight(ByVal freightNum As String, ByVal finalDest As String) As ReturnCodes
            'update the freight record in the database with the container number
            Try
                Return FlightOperations.LoadFreightToBinBulk(_objFlight.FlightNum, _objFlight.DepartureDate, _strBinBulkNo, freightNum, finalDest)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LoadExpediteFreight(ByVal freightNum As String, ByVal finalDest As String) As ReturnCodes
            Try
                Return FlightOperations.LoadExpediteFreight(_objFlight.FlightNum, _objFlight.DepartureDate, _strBinBulkNo, freightNum, finalDest)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LoadExpediteFreight(ByVal freightNum As String) As ReturnCodes
            Try
                Return FlightOperations.LoadExpediteFreight(_objFlight.FlightNum, _objFlight.DepartureDate, _strBinBulkNo, freightNum)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CreateNewAWB(ByVal pieces As Integer, ByVal weight As Integer, ByVal type As String, _
        ByVal destination As String, ByVal final As String) As ReturnCodes
            'pending - webservice call

            'intNewPieceCount = objDlgCreateNewAWB.Pieces
            'intNewPieceWgt = objDlgCreateNewAWB.Weight
            'strNewPieceType = objDlgCreateNewAWB.Type
            'strNewDest = objDlgCreateNewAWB.Destination
            'strNewFinal = objDlgCreateNewAWB.FinalDestination
        End Function

        Public Function PositionLineItem(ByVal lineItemSeqNum As String) As ReturnCodes

            If _objFlight.IsClosed Then
                Return ReturnCodes.FlightClosed
            End If

            If _objFlight.IsDeparted Then
                Return ReturnCodes.FlightDeparted
            End If

            Dim retCode As ReturnCodes

            retCode = FlightOperations.PositionLineItem(_objFlight.FlightNum, _objFlight.DepartureDate, _
            _strBinBulkNo, lineItemSeqNum)

            Return retCode

        End Function

        Public Function IsBagAlreadyLoaded(ByVal bagTagNum As String) As Boolean
            'is bag already loaded into this bin bulk number
            Try
                Return FlightOperations.IsBagAlreadyLoadedIntoBin(_objFlight.FlightNum, _
                            _objFlight.DepartureDate, _strBinBulkNo, bagTagNum) = ReturnCodes.Ok
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function IsFreightAlreadyLoaded(ByVal freightNum As String) As Boolean
            'is bag already loaded into this bin bulk number
            Try
                Return FlightOperations.IsFreightAlreadyLoadedIntoBin(_objFlight.FlightNum, _
                            _objFlight.DepartureDate, _strBinBulkNo, freightNum) = ReturnCodes.Ok
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function IsMailAlreadyLoaded(ByVal mailNum As String) As Boolean
            'is bag already loaded into this bin bulk number
            Try
                Return FlightOperations.IsMailAlreadyLoadedIntoBin(_objFlight.FlightNum, _
                            _objFlight.DepartureDate, _strBinBulkNo, mailNum) = ReturnCodes.Ok
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Sub SetLastScannedBag(ByVal bagtagNum As String)
            If _queLastScannedBags.Count = _intRefCount Then
                _queLastScannedBags.Dequeue()
            End If
            _queLastScannedBags.Enqueue(bagtagNum)
        End Sub

        Private Sub SetLastScannedMail(ByVal mailNum As String)
            If _queLastScannedMails.Count = _intRefCount Then
                _queLastScannedMails.Dequeue()
            End If
            _queLastScannedMails.Enqueue(mailNum)
        End Sub

        Private Sub SetLastScannedFreight(ByVal freightNum As String)
            If _queLastScannedFreight.Count = _intRefCount Then
                _queLastScannedFreight.Dequeue()
            End If
            _queLastScannedFreight.Enqueue(freightNum)
        End Sub

    End Class
End Namespace