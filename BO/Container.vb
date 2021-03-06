
Imports System.Data.SqlServerCe
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.DataAccess
Imports NWA.Safetrac.Scanner.WebReferences


Namespace NWA.Safetrac.Scanner.BO
    ''' <summary>
    ''' This business class encapsulates all the properties and functions related a Container
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Container

        Private _objFlight As Flight = Nothing
        Private _strContainerSheetNum As String = String.Empty
        Private _strContainerName As String = String.Empty
        Private _intRefCount As Integer = 10
        Private _blnIsHubType As Boolean = False
        Private _queLastScannedBags As New Queue(Of String)(_intRefCount)
        Private _queLastScannedMails As New Queue(Of String)(_intRefCount)
        Private _queLastScannedFreight As New Queue(Of String)(_intRefCount)

        Public ReadOnly Property Flight() As Flight
            Get
                Return _objFlight
            End Get
        End Property
        Public ReadOnly Property ContainerSheetNum() As String
            Get
                Return _strContainerSheetNum
            End Get
        End Property

        Public ReadOnly Property ContainerName() As String
            Get
                Try
                    If _strContainerName Is Nothing Or _strContainerName Is String.Empty Then
                        _strContainerName = FlightOperations.GetContainerName(_objFlight.FlightNum, _
                            _objFlight.DepartureDate, Me._strContainerSheetNum)
                    End If
                    Return _strContainerName
                Catch ex As Exception
                    Throw ex
                End Try
            End Get
        End Property

        Public ReadOnly Property Type() As String
            Get
                Try
                    Return FlightOperations.GetContainerType(_objFlight.FlightNum, _
                                    _objFlight.DepartureDate, _strContainerSheetNum)
                Catch ex As Exception
                    Throw ex
                End Try
            End Get
        End Property

        Public ReadOnly Property Position() As String
            Get
                Try
                    Return FlightOperations.GetContainerPosition(_objFlight.FlightNum, _
                                    _objFlight.DepartureDate, _strContainerSheetNum)
                Catch ex As Exception
                    Throw ex
                End Try
            End Get
        End Property

        Public ReadOnly Property Destination() As String
            Get
                Try
                    Return FlightOperations.GetContainerDestination(_objFlight.FlightNum, _
                                _objFlight.DepartureDate, _strContainerSheetNum)
                Catch ex As Exception
                    Throw ex
                End Try
            End Get
        End Property

        Public ReadOnly Property FinalDestination() As String
            Get
                Try
                    Return FlightOperations.GetContainerFinalDestination(_objFlight.FlightNum, _
                                    _objFlight.DepartureDate, _strContainerSheetNum)
                Catch ex As Exception
                    Throw ex
                End Try
            End Get
        End Property

        Public ReadOnly Property IsHubType() As Boolean
            Get
                If Type = ContainerTypes.Hub.ToString Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property

        Public ReadOnly Property IsLoaded() As Boolean
            Get
                Return FlightOperations.IsContainerLoaded(_objFlight.FlightNum, _
                        _objFlight.DepartureDate, _strContainerSheetNum)
            End Get
        End Property

        Public Function IsBagAlreadyLoaded(ByVal bagTagNum As String) As Boolean
            'is bag already loaded into this container
            Try
                Return FlightOperations.IsBagAlreadyLoadedIntoContainer(_objFlight.FlightNum, _
                            _objFlight.DepartureDate, _strContainerSheetNum, bagTagNum) = ReturnCodes.Ok
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public ReadOnly Property HasCapacityExceeded() As Boolean
            Get
                Return FlightOperations.HasContainerCapacityExceeded(_objFlight.FlightNum, _
                        _objFlight.DepartureDate, _strContainerSheetNum)
            End Get
        End Property

        Public ReadOnly Property IsClosed() As Boolean
            Get
                Return FlightOperations.IsContainerClosed(_objFlight.FlightNum, _
                        _objFlight.DepartureDate, _strContainerSheetNum)
            End Get
        End Property

        Public ReadOnly Property IsRegistered() As Boolean
            Get
                'pending - database call
                'Return True
                Return FlightOperations.IsContainerRegistered(_objFlight.FlightNum, _
                           _objFlight.DepartureDate, _strContainerSheetNum)
            End Get
        End Property

        Public ReadOnly Property BagCount() As Integer
            Get
                Return FlightOperations.GetBagCountOfContainer(_objFlight.FlightNum, _
                _objFlight.DepartureDate, _strContainerSheetNum)
            End Get
        End Property

        Public ReadOnly Property BagsWeight() As Integer
            Get
                'calculate weight from the database based on the bags
                Return FlightOperations.GetBagCountOfContainer(_objFlight.FlightNum, _
                                _objFlight.DepartureDate, _strContainerSheetNum)
            End Get
        End Property

        Public ReadOnly Property MailCount() As Integer
            Get
                'get mails count from database
                Return FlightOperations.GetMailCountOfContainer(_objFlight.FlightNum, _
                                _objFlight.DepartureDate, _strContainerSheetNum)
            End Get
        End Property

        Public ReadOnly Property MailsWeight() As Integer
            Get
                'calculate weight from the database based on the mails
                Return FlightOperations.GetMailsWeightOfContainer(_objFlight.FlightNum, _
                                _objFlight.DepartureDate, _strContainerSheetNum)
            End Get
        End Property

        Public ReadOnly Property FreightCount() As Integer
            Get
                'get freight count from the database
                Return FlightOperations.GetFreightCountOfContainer(_objFlight.FlightNum, _
                                _objFlight.DepartureDate, _strContainerSheetNum)
            End Get
        End Property

        Public ReadOnly Property FreightWeight() As Integer
            Get
                'calculate weight from the database based on freight
                Return FlightOperations.GetFreightWeightOfContainer(_objFlight.FlightNum, _
                                _objFlight.DepartureDate, _strContainerSheetNum)
            End Get
        End Property

        Public ReadOnly Property TotalWeight() As Integer
            Get
                'calculate total weight from the database
                Return FlightOperations.GetTotalWeightOfContainer(_objFlight.FlightNum, _
                                _objFlight.DepartureDate, _strContainerSheetNum)
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

        Public Sub New(ByVal flight As Flight, ByVal containerNum As String)
            _objFlight = flight
            _strContainerSheetNum = containerNum
            Dim strLog As String = String.Format("Container Bulk added, Flight Num = {0}, Flight Date = {1}, Container Num = {2}", _
                _objFlight.FlightNum, _objFlight.DepartureDate, _strContainerSheetNum)
            Logger.LogMessage(strLog, LogType.Trace, "Container.New")
        End Sub

        Public Sub New(ByVal flight As Flight, ByVal containerNum As String, ByVal containerName As String)
            _objFlight = flight
            _strContainerSheetNum = containerNum
            _strContainerName = containerName
            Dim strLog As String = String.Format("Container Bulk added, Flight Num = {0}, Flight Date = {1}, Container Num = {2}, Container Name = {3}", _
                _objFlight.FlightNum, _objFlight.DepartureDate, _strContainerSheetNum, _strContainerName)
            Logger.LogMessage(strLog, LogType.Trace, "Container.New")
        End Sub

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

        Public Function LoadDamagedBag(ByVal bagTagNum As String, ByVal weight As String) As ReturnCodes
            Return LoadBag(bagTagNum, weight, ScanModes.Damaged)
        End Function
        Public Function LoadBagOnAlert(ByVal bagTagNum As String) As ReturnCodes
            Try
                'FlightOperations.RemoveBagtagAlert(bagTagNum, _objFlight.FlightNum, _objFlight.DepartureDate)
                Dim retCode As ReturnCodes
                retCode = FlightOperations.LoadBagToContainer(_objFlight.FlightNum, _objFlight.DepartureDate, _strContainerSheetNum, bagTagNum)
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

            If Me.IsClosed Then
                Return ReturnCodes.ContainerClosed
            End If

            If Me.IsBagAlreadyLoaded(bagTagNum) Then
                Return ReturnCodes.BagtagAlreadyLoaded
            End If

            If Common.IsDuplicateBagtag(bagTagNum) Then
                Return ReturnCodes.BagtagDuplicatesFound
            End If

            Select Case returnCode
                Case ReturnCodes.BagtagInvalidForFlight
                    'update the record
                    retCode = FlightOperations.LoadExpediteBagToContainer(_objFlight.FlightNum, _
                                                _objFlight.DepartureDate, _strContainerSheetNum, bagTagNum, expediteCode)
                Case ReturnCodes.BagtagUnknown
                    retCode = FlightOperations.LoadUnknownBagToContainer(_objFlight.FlightNum, _
                                                _objFlight.DepartureDate, _strContainerSheetNum, bagTagNum, expediteCode)
            End Select
            Return retCode
        End Function

        Private Function LoadBag(ByVal bagtagNum As String, ByVal weight As String, ByVal scanMode As ScanModes) As ReturnCodes
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

                If Not Me.IsRegistered Then
                    Return ReturnCodes.ContainerNotRegistered
                End If

                If Me.IsClosed Then
                    Return ReturnCodes.ContainerClosed
                End If

                If _objFlight.IsBagTagValid(bagtagNum) <> ReturnCodes.Ok Then
                    If Common.IsBagtagValid(bagtagNum) = True Then
                        Return ReturnCodes.BagtagInvalidForFlight
                    Else
                        If _objFlight.IsPBMDisabled Then
                            'PBM is disabled - proceed for direct loading
                            retCode = FlightOperations.LoadUnknownBagToContainer(_objFlight.FlightNum, _
                            _objFlight.DepartureDate, _strContainerSheetNum, bagtagNum)
                            If retCode = ReturnCodes.Ok Then
                                SetLastScannedBag(bagtagNum)
                            End If
                            LoadBag = retCode
                        Else
                            'PBM is enabled
                            LoadBag = ReturnCodes.BagtagUnknown
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

                If Common.IsDuplicateBagtag(bagtagNum) Then
                    Return ReturnCodes.BagtagDuplicatesFound
                End If

                If _objFlight.IsBagOnAlert(bagtagNum) Then
                    Return ReturnCodes.BagtagOnAlert
                End If


                'world update flight error
                'all set proceed with loading of bag

                Select Case scanMode
                    Case ScanModes.Normal, ScanModes.Manual, ScanModes.Heavy, ScanModes.Planeside
                        retCode = FlightOperations.LoadBagToContainer(_objFlight.FlightNum, _
                                _objFlight.DepartureDate, _strContainerSheetNum, bagtagNum, weight)

                        'pending - check for this condition
                    Case ScanModes.Damaged
                        retCode = FlightOperations.LoadDamagedBagToContainer(_objFlight.FlightNum, _
                                _objFlight.DepartureDate, _strContainerSheetNum, bagtagNum, weight)

                End Select

                If retCode = ReturnCodes.Ok Then
                    SetLastScannedBag(bagtagNum)
                End If

                LoadBag = retCode

            Catch ex As Exception
                LoadBag = ReturnCodes.Unknown
            End Try

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

            If Not Me.IsRegistered Then
                Return ReturnCodes.ContainerNotRegistered
            End If

            If Me.IsClosed Then
                Return ReturnCodes.ContainerClosed
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
                    retCode = FlightOperations.LoadMailToContainer(_objFlight.FlightNum, _objFlight.DepartureDate, _
                     _strContainerSheetNum, mailNum)
                    If retCode = ReturnCodes.Ok Then
                        SetLastScannedMail(mailNum)
                    End If
                Else
                    retCode = FlightOperations.LoadMailToContainer(_objFlight.FlightNum, _objFlight.DepartureDate, _
                                        _strContainerSheetNum, mailNum, type, weight, pieces, finalDest)
                    If retCode = ReturnCodes.Ok Then
                        SetLastScannedMail(mailNum)
                    End If
                    Return retCode
                End If
            Else
                'manual indicator, mail number doesnt exist
                retCode = FlightOperations.LoadMailToContainer(_objFlight.FlightNum, _objFlight.DepartureDate, _
                                        _strContainerSheetNum, mailNum, type, weight, pieces, finalDest)
            End If

            Return retCode
        End Function
        Public Function IsMailAlreadyLoaded(ByVal mainNum As String) As Boolean
            Try
                Return FlightOperations.IsMailAlreadyLoadedIntoContainer(_objFlight.FlightNum, _objFlight.DepartureDate, _strContainerSheetNum, mainNum) = ReturnCodes.Ok
            Catch ex As Exception
                Throw ex
            End Try
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

            If Not Me.IsRegistered Then
                Return ReturnCodes.ContainerNotRegistered
            End If

            If Me.IsClosed Then
                Return ReturnCodes.ContainerClosed
            End If

            If _objFlight.IsMailValid(mailNum) Then
                Return FlightOperations.UnloadMailFromContainer(_objFlight.FlightNum, _objFlight.DepartureDate, _
                 _strContainerSheetNum, mailNum)
            Else
                Return ReturnCodes.MailNotFound
            End If

        End Function

        'check if line items can be positioned into containers
        Public Function PositionContainer(ByVal positionNum As String) As ReturnCodes

            'update the database with position number, return transaction result
            If _objFlight.IsClosed Then
                Return ReturnCodes.FlightClosed
            End If

            If _objFlight.IsDeparted Then
                Return ReturnCodes.FlightDeparted
            End If

            If Not Me.IsRegistered Then
                Return ReturnCodes.ContainerNotRegistered
            End If

            If Me.IsClosed Then
                Return ReturnCodes.ContainerClosed
            End If


            'pending - make the webservice call



            'if successful webservice, update local database also
            FlightOperations.PositionContainer(_strContainerSheetNum, _objFlight.FlightNum, _
                    _objFlight.DepartureDate, positionNum)

        End Function

        Public Function Reopen() As ReturnCodes
            'check the current status in the database. if closed then change to status to reopen

            If _objFlight.IsClosed Then
                Return ReturnCodes.FlightClosed
            End If

            If _objFlight.IsDeparted Then
                Return ReturnCodes.FlightDeparted
            End If

            If Not Me.IsClosed Then
                Return ReturnCodes.ContainerAlreadyOpened
            End If

            Dim retCode As ReturnCodes

            'pending - make the webservice call


            If retCode = ReturnCodes.Ok Then
                retCode = ReturnCodes.ContainerReopened
            ElseIf retCode = ReturnCodes.NotOk Or retCode = ReturnCodes.DatabaseError Or _
                retCode = ReturnCodes.Unknown Then

            End If

        End Function

        Public Function Close() As ReturnCodes
            'check the current status in the database. if its currently in opened or reopened status, close it

            If _objFlight.IsClosed Then
                Return ReturnCodes.FlightClosed
            End If

            If _objFlight.IsDeparted Then
                Return ReturnCodes.FlightDeparted
            End If

            If Me.IsClosed Then
                Return ReturnCodes.ContainerAlreadyClosed
            End If

            Dim retCode As ReturnCodes

            retCode = FlightOperations.CloseContainer(_objFlight.FlightNum, _
            _objFlight.DepartureDate, _strContainerSheetNum)

            If retCode = ReturnCodes.Ok Then
                Return ReturnCodes.ContainerClosed
            ElseIf retCode = ReturnCodes.NotOk Or retCode = ReturnCodes.DatabaseError Or _
            retCode = ReturnCodes.Unknown Then
            End If

        End Function

        Public Function ChangeDestination(ByVal newDestination As String) As ReturnCodes
            Return ChangeDefinition(newDestination, String.Empty)
        End Function

        Public Function ChangeType(ByVal newType As String) As ReturnCodes
            Return ChangeDefinition(String.Empty, newType)
        End Function

        Public Function ChangeDefinition(ByVal newDestination As String, ByVal newType As String) As ReturnCodes

            If _objFlight.IsClosed Then
                Return ReturnCodes.FlightClosed
            End If

            If _objFlight.IsDeparted Then
                Return ReturnCodes.FlightDeparted
            End If

            If Me.IsClosed Then
                Return ReturnCodes.ContainerClosed
            End If

            If Me.IsLoaded Then
                Return ReturnCodes.ContainerLoaded
            End If

            Dim retCode As ReturnCodes

            'make webservice call - performULDUploadDef - pending

            'if webservice call is successful - update loacal database also

            retCode = FlightOperations.ChangeContainerDefinition(_strContainerSheetNum, newDestination, newType)

            Return ReturnCodes.Ok

        End Function

        Public Function Register(ByVal containerName As String) As ReturnCodes

            If _objFlight.IsClosed Then
                Return ReturnCodes.FlightClosed
            End If

            If _objFlight.IsDeparted Then
                Return ReturnCodes.FlightDeparted
            End If

            If Me.IsClosed Then
                Return ReturnCodes.ContainerClosed
            End If

            If Me.IsRegistered Then
                Return ReturnCodes.ContainerNumAlreadyRegistered
            End If

            'pending - webservice call for performing uld registration
            Dim objresponse As ScannerServiceResponse = Nothing
            Try
                Dim _objWebServices As ScannerServices = ScannerServices.GetInstance()
                objresponse = _objWebServices.RegisterContainer("46", New NWADateTime("31OCT"), "67014", "AVE2135NW", "DTW")

                If objresponse.IsSuccessful Then
                    MsgBox("Success")
                    Debug.WriteLine("")
                Else
                    MsgBox(objresponse.ReturnMessage)
                End If
                Return objresponse.ReturnCode
            Catch ex As Exception
                objresponse = New ScannerServiceResponse(ex)
            End Try
        End Function
        Public Function ChangeContainerDef(ByVal conDest As String, ByVal conNum As String, _
        ByVal conName As String, ByVal conType As String, ByVal hubCode As String, ByVal hubFlightDest As String _
        , ByVal hubFlightNum As String, ByVal hubFlightSched As String) As ReturnCodes

            Dim objresponse As ScannerServiceResponse = Nothing
            Try
                Dim _objWebServices As ScannerServices = ScannerServices.GetInstance()
                objresponse = _objWebServices.ChangeContainerDefinition("MSP", "66996", _
            "AKE12346NW", "MIXED", hubCode, hubFlightDest, "0", hubFlightSched)

                If objResponse.IsSuccessful Then
                    MsgBox("Success")
                    Debug.WriteLine("")
                Else
                    MsgBox(objResponse.ReturnMessage)
                End If
                Return objResponse.ReturnCode
            Catch ex As Exception
                objresponse = New ScannerServiceResponse(ex)
            End Try
        End Function
        Public Function ChangeContainerDefLocal(ByVal conDest As String, ByVal conNum As String, _
        ByVal conName As String, ByVal conType As String, ByVal hubCode As String, ByVal hubFlightDest As String _
        , ByVal hubFlightNum As String, ByVal hubFlightSched As String) As ReturnCodes

            ' return 
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

        Public ReadOnly Property ContainerNum() As String
            Get
                'Pending - origin dest.
                Return _strContainerSheetNum & GetContainerOrigin("NW0044", _objFlight.DepartureDate, _
                _strContainerSheetNum) & _objFlight.DepartureDate.VBFormat.ToString("yy") & _
                _objFlight.DepartureDate.VBFormat.DayOfYear
            End Get
        End Property

    End Class

End Namespace