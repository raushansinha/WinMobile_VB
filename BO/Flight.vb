
Imports System
Imports System.Data
Imports System.Data.SqlServerCe
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.DataAccess
Imports NWA.Safetrac.Scanner.WebReferences

Namespace NWA.Safetrac.Scanner.BO

    Public Class Flight

        Private _strFlightNum As String
        Private _dtDepartureDate As NWADateTime
        Private _dtDepartureTime As NWADateTime
        Private _strDestination As String
        Private _strFinalDestination As String
        Private _blnIsWideBody As Boolean
        Private _blnIsInternational As Boolean
        Private _diContainers As New Dictionary(Of String, Container)
        Private _diBinBulks As New Dictionary(Of String, BinBulk)
        Private _blnIsClosed As Boolean
        Private _objCurrentContainer As Container
        Private _objCurrentBinBulk As BinBulk
        Private _blnIsPBMDisabled As Boolean
        Private _strGate As String
        Private _stationType As StationType
        Private _strAcNoseNum As String

        Public ReadOnly Property FlightNum() As String
            Get
                Return _strFlightNum
            End Get
        End Property
        Public ReadOnly Property DepartureDate() As NWADateTime
            Get
                Return _dtDepartureDate
            End Get
        End Property
        Public ReadOnly Property Destination() As String
            Get
                Return _strDestination
            End Get
        End Property
        Public ReadOnly Property FinalDestination() As String
            Get
                Return _strFinalDestination
            End Get
        End Property
        Public ReadOnly Property Gate() As String
            Get
                Return _strGate
            End Get
        End Property
        Public ReadOnly Property IsWideBody() As Boolean
            Get
                Return _blnIsWideBody
            End Get
        End Property
        Public ReadOnly Property IsInternational() As Boolean
            Get
                Return _blnIsInternational
            End Get
        End Property

        Public ReadOnly Property AcNoseNum() As String
            Get
                Return _strAcNoseNum
            End Get
        End Property

        Public ReadOnly Property IsClosed() As Boolean
            Get
                Return _blnIsClosed
            End Get
        End Property

        Public ReadOnly Property IsDeparted() As Boolean
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property AreLoadAllowed() As Boolean
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property BagsCount() As Integer
            Get
                'pending
            End Get
        End Property

        Public ReadOnly Property IsPBMDisabled() As Boolean
            Get
                Return _blnIsPBMDisabled
            End Get
        End Property

        Public Function DiablePBM(ByVal disable As Boolean) As ReturnCodes

            Dim objScanner As Scanner = Scanner.GetInstance

            If objScanner.StationType = StationType.Hub Then
                Return ReturnCodes.IsHubTypeStation
            End If

            If Me.IsInternational Then
                Return ReturnCodes.IsInternational
            End If

            _blnIsPBMDisabled = disable

            If _blnIsPBMDisabled Then
                Return ReturnCodes.PBMDisabled
            Else
                Return ReturnCodes.PBMEnabled
            End If

        End Function

        Public ReadOnly Property Containers() As Dictionary(Of String, Container)
            Get
                Return _diContainers
            End Get
        End Property

        Public ReadOnly Property Containers(ByVal containerNum As String) As Container
            Get
                If _diContainers.ContainsKey(containerNum) Then
                    CurrentContainer = _diContainers(containerNum)
                    Return CurrentContainer
                Else
                    If FlightOperations.IsContainerNumValid(_strFlightNum, _dtDepartureDate, containerNum) _
                 = ReturnCodes.Ok Then
                        Dim objCont As New Container(Me, containerNum)
                        _diContainers.Add(containerNum, objCont)
                        CurrentContainer = _diContainers(containerNum)
                        Return CurrentContainer
                    Else
                        Throw New SafetracException(ReturnCodes.ContainerNumInvalid)
                    End If
                End If
            End Get
        End Property
        Public Property CurrentContainer() As Container
            Get
                If Me.IsWideBody Then
                    Return _objCurrentContainer
                Else
                    Return Nothing
                    'Throw New SafetracException(ReturnCodes.NotAuthorized, "This Flight does not support containers", "")
                End If
            End Get
            Set(ByVal value As Container)
                If _objCurrentContainer Is Nothing Then
                    _objCurrentContainer = value
                Else
                    If _objCurrentContainer.ContainerSheetNum <> value.ContainerSheetNum Then
                        _objCurrentContainer = Nothing
                        _objCurrentContainer = value
                    End If
                End If
            End Set
        End Property

        Public ReadOnly Property BinBulks(ByVal binBulkNum As String) As BinBulk
            Get
                If _diBinBulks.ContainsKey(binBulkNum) Then
                    CurrentBinBulk = _diBinBulks(binBulkNum)
                    Return CurrentBinBulk
                Else
                    Return Nothing
                    Throw New SafetracException(ReturnCodes.BinBulkInvalid, "Invalid BinBulk Num", "BO.Flight")
                End If
            End Get
        End Property
        Public Property CurrentBinBulk() As BinBulk
            Get
                If _objCurrentBinBulk IsNot Nothing Then
                    Return _objCurrentBinBulk
                Else
                    Return Nothing
                    'Throw New SafetracException(ReturnCodes.Exception, "Current Bin Bulk not set", "")
                End If
            End Get
            Set(ByVal value As BinBulk)
                If _objCurrentBinBulk Is Nothing Then
                    _objCurrentBinBulk = value
                Else
                    If _objCurrentBinBulk.BinBulkNum <> value.BinBulkNum Then
                        _objCurrentBinBulk = Nothing
                        _objCurrentBinBulk = value
                    End If
                End If
            End Set
        End Property

        Public ReadOnly Property BinBulks() As Dictionary(Of String, BinBulk)
            Get
                Return _diBinBulks
            End Get
        End Property

        Public Function CreateContainerSheetNum(ByVal containerName As String, ByVal type As String, _
        ByVal destination As String) As ScannerServiceResponse
            Dim response As ScannerServiceResponse
            Dim objServices As ScannerServices = ScannerServices.GetInstance
            response = objServices.CreateContainerSheetNumber(_strFlightNum, _dtDepartureDate, containerName, _
            type, destination)
            Return response
        End Function

        Public Function CreateHubContainerSheetNum(ByVal containerName As String, ByVal type As String, _
        ByVal destination As String, ByVal hubFlightNum As String, ByVal hubFlightDate As NWADateTime, ByVal hubflightDest As String) As ScannerServiceResponse
            Dim response As ScannerServiceResponse
            Dim objServices As ScannerServices = ScannerServices.GetInstance
            response = objServices.CreateHubContainerSheetNumber(_strFlightNum, _dtDepartureDate, containerName, _
            type, destination, hubFlightNum, hubFlightDate, hubflightDest)
            Return response
        End Function

        Public Function SetBagtagAlert(ByVal bagTagNum As String) As ReturnCodes

            If Me.IsClosed Then
                Return ReturnCodes.FlightClosed
            End If

            If Me.IsDeparted Then
                Return ReturnCodes.FlightDeparted
            End If

            If Me.IsBagTagValid(bagTagNum) <> ReturnCodes.Ok Then
                Return ReturnCodes.BagtagUnknown
            End If

            If Me.IsBagOnAlert(bagTagNum) Then
                Return ReturnCodes.BagtagAlreadyOnAlert
            End If

            Dim retCode As ReturnCodes

            'all validations performed - proceed with setting of alert
            retCode = FlightOperations.SetBagtagAlert(bagTagNum, _strFlightNum, _dtDepartureDate)

            If retCode <> ReturnCodes.Ok Then
                retCode = ReturnCodes.NotOk
            End If

            Return retCode

        End Function
        Public Function RemoveBagAlert(ByVal bagTagNum As String) As ReturnCodes

            If Me.IsClosed Then
                Return ReturnCodes.FlightClosed
            End If

            If Me.IsDeparted Then
                Return ReturnCodes.FlightDeparted
            End If

            If Me.IsBagTagValid(bagTagNum) <> ReturnCodes.Ok Then
                Return ReturnCodes.BagtagUnknown
            End If

            If Not Me.IsBagOnAlert(bagTagNum) Then
                Return ReturnCodes.BagtagNotOnAlert
            End If

            'all validations performed - proceed with removing of alert
            Return FlightOperations.RemoveBagtagAlert(bagTagNum, _strFlightNum, _dtDepartureDate)

        End Function
        'pending  - aditya
        Public Function GetBagsOnAlert() As DataSet
            Return FlightOperations.GetBagsOnAlert(_strFlightNum, _dtDepartureDate)
        End Function
        Public Function GetBagsToUnload() As DataSet
            Try
                Return FlightOperations.GetBagsToUnload(_strFlightNum, _dtDepartureDate)
            Catch SqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError, "", "")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Public Function LoadBagToContainer(ByVal bagTagNum As Integer, _
        '            ByVal containerSheetNum As String, ByVal bagType As String, ByVal weight As String) As FunctionReturnCodes

        'End Function
        'Public Function LoadBagToBinBulk(ByVal bagTagNum As Integer, _
        '        ByVal binBulkNum As Integer, ByVal bagType As String) As FunctionReturnCodes

        'End Function
        'Public Function LoadMailToBinBulk(ByVal mailNum As String, _
        '        ByVal binBulkNum As Integer, _
        '        ByVal pieceNum As Integer, _
        '        ByVal weight As Integer, _
        '        ByVal mailType As String) As Boolean

        'End Function
        'Public Function CloseContainer(ByVal containerSheetNum As String) As FunctionReturnCodes

        'End Function

        'Public Function ReopenContainer(ByVal containerSheetNum As String) As FunctionReturnCodes

        'End Function

        Public Function PositionContainer(ByVal containerSheetNum As String, _
                ByVal positionOnAircraft As String) As ReturnCodes

        End Function

        Public Function ContainerInquiry(ByVal containerSheetNum As String) As Container
            Return Nothing
        End Function

        Public Function GetLineItems() As DataSet
            Try
                Return FlightOperations.GetLineItems(_strFlightNum, _dtDepartureDate)
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
            Return Nothing
        End Function
        Public Function VerifyClock(ByVal clockNumber As String) As ReturnCodes

        End Function

        Public Function Close(ByVal bOverride As Boolean) As ReturnCodes

            

        End Function
        Public Function GetAllBinBulksSummary() As DataSet
            Return FlightOperations.GetAllBinBulksSummary(_strFlightNum, _dtDepartureDate, True)
        End Function

        Public Function Reopen() As ReturnCodes
           
        End Function



        Public Function GetPassengerClass(ByVal bagTagNum As String) As String
            Return FlightOperations.GetPassengerClass(bagTagNum, _strFlightNum, _dtDepartureDate)
        End Function


        Public Function UnloadMail(ByVal mailNum As String, _
               ByVal location As Integer, ByVal mailType As String) As ReturnCodes

        End Function
        Public Function UnloadFreight(ByVal freightNum As String) As ReturnCodes

            Return FlightOperations.UnloadFreight(_strFlightNum, _dtDepartureDate, freightNum)
        End Function

        Public Function UnloadBag(ByVal bagtagNum As String) As ReturnCodes

            If Me.IsClosed Then
                Return ReturnCodes.FlightClosed
            End If

            If Me.IsDeparted Then
                Return ReturnCodes.FlightDeparted
            End If

            If Not Me.IsBagAlreadyLoaded(bagtagNum) Then
                Return ReturnCodes.BagtagOnNoLoad ' Bag not loaded at all
            End If

            Return FlightOperations.UnloadBag(bagtagNum, _strFlightNum, _dtDepartureDate)

        End Function


#Region "PROPERTIES"

        Public ReadOnly Property EstimatedDepartureTime() As String
            Get
                Return FlightOperations.ExpectedDepartureTime(_strFlightNum, _dtDepartureDate)
            End Get
        End Property

#End Region

#Region "PUBLIC METHODS"

        Public Sub PrecloseFlight()

        End Sub

        Public Function UnloadLineItem(ByVal lineItemSeqNum As String) As ReturnCodes

            If Me.IsClosed Then
                Return ReturnCodes.FlightClosed
            End If

            If Me.IsDeparted Then
                Return ReturnCodes.FlightDeparted
            End If

            Dim retCode As ReturnCodes

            'check whether it shud be "XX" or DBnull
            retCode = FlightOperations.PositionLineItem(_strFlightNum, _dtDepartureDate, "XX", lineItemSeqNum)

            Return retCode

        End Function

        Public Function UnloadLineItem(ByVal lineItemSeqNum As String, ByVal reason As String) As ReturnCodes

            If Me.IsClosed Then
                Return ReturnCodes.FlightClosed
            End If

            If Me.IsDeparted Then
                Return ReturnCodes.FlightDeparted
            End If

            Dim retCode As ReturnCodes

            'check whether it shud be "XX" or DBnull
            retCode = FlightOperations.PositionLineItem(_strFlightNum, _dtDepartureDate, "XX", lineItemSeqNum, reason)

            Return retCode

        End Function

#End Region

#Region "GET METHODS"

        'get container number based upon container name
        Public Function GetContainerNum(ByVal containerName As String) As String
            Dim strNum As String
            strNum = FlightOperations.GetContainerNum(_strFlightNum, _dtDepartureDate, containerName)
            Return strNum
        End Function

        'get container name based upon container number
        Public Function GetContainerName(ByVal containerNum As String) As String
            Dim strNum As String = String.Empty
            If _diContainers.ContainsKey(containerNum) Then
                strNum = _diContainers(containerNum).ContainerName
            Else
                If FlightOperations.IsContainerNumValid(containerNum) = ReturnCodes.Ok Then
                    strNum = FlightOperations.GetContainerName(_strFlightNum, _dtDepartureDate, containerNum)
                Else
                    Throw New SafetracException(ReturnCodes.ContainerNameInvalid)
                End If
            End If
            Return strNum
        End Function

        Public Function GetBagsToGoByDest() As DataSet
            Try
                Dim objScanner As Scanner = Scanner.GetInstance
                Return FlightOperations.BagsToGo(objScanner.Station, _strFlightNum, _dtDepartureDate, "DEST")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetBagsToGoByXFER() As DataSet
            Try
                Dim objScanner As Scanner = Scanner.GetInstance
                Return FlightOperations.BagsToGo(objScanner.Station, _strFlightNum, _dtDepartureDate, "XFER")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetBagsToGoByStatus() As DataSet
            Try
                Dim objScanner As Scanner = Scanner.GetInstance
                Return FlightOperations.BagsToGo(objScanner.Station, _strFlightNum, _dtDepartureDate, "STATUS")
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function GetLoadSummary() As DataSet

        End Function


#End Region

#Region "IS METHODS"

        Public Function IsBagOnAlert(ByVal bagtagNum As String) As Boolean
            Try
                Return FlightOperations.IsBagOnAlert(_strFlightNum, _dtDepartureDate, bagtagNum) = ReturnCodes.Ok
            Catch ex As Exception
                Throw ex
            End Try
            'Return True
            'Else
            'Return False
            'End If
        End Function


        Public Function IsBagOnNoLoad(ByVal bagTagNum As String) As Boolean
            Try
                Return FlightOperations.IsBagOnNoLoad(_strFlightNum, _dtDepartureTime, bagTagNum) = ReturnCodes.Ok
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function IsBagSecurityCleared(ByVal bagTagNum As String) As Boolean
            Return FlightOperations.IsBagSecurityCleared(_strFlightNum, _dtDepartureTime, bagTagNum) = ReturnCodes.Ok
        End Function

        Public Function IsPassengerOnStandBy(ByVal bagTagNum As String) As Boolean
            Try
                Return FlightOperations.IsPassengerOnStandBy(_strFlightNum, _dtDepartureTime, bagTagNum) = ReturnCodes.Ok
            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Function IsPassengerCheckedIn(ByVal bagTagNum As String) As Boolean
            Try
                Return FlightOperations.IsPassengerCheckedIn(_strFlightNum, _dtDepartureTime, bagTagNum) = ReturnCodes.Ok
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function IsBagAlreadyLoaded(ByVal bagTagNum As String) As Boolean
            Return FlightOperations.IsBagAlreadyLoaded(_strFlightNum, _dtDepartureDate, bagTagNum) = ReturnCodes.Ok
        End Function

        Public Function IsBagAlreadyUnloaded(ByVal bagTagNum As String) As Boolean
            Try
                Return FlightOperations.IsBagAlreadyUnloaded(_strFlightNum, _dtDepartureDate, bagTagNum) = ReturnCodes.Ok
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function IsBinBulkValid(ByVal binBulk As String) As ReturnCodes
            If _diBinBulks.ContainsKey(binBulk) Then
                CurrentBinBulk = _diBinBulks(binBulk)
                Return ReturnCodes.Ok
            Else
                Return ReturnCodes.NotOk
            End If
        End Function

        Public Function IsBagTagValid(ByVal bagtagNum As String) As ReturnCodes
            Dim retCode As ReturnCodes
            retCode = FlightOperations.IsBagTagValid(_strFlightNum, _dtDepartureDate, bagtagNum)
            If retCode = ReturnCodes.Ok Then
                retCode = ReturnCodes.Ok
            Else
                If Common.IsBagtagValid(bagtagNum) Then
                    retCode = ReturnCodes.BagtagInvalidForFlight
                Else
                    retCode = ReturnCodes.BagtagUnknown
                End If
            End If
            Return retCode
        End Function

        Public Function IsMailValid(ByVal mailNum As String) As Boolean
            Return FlightOperations.IsMailValid(_strFlightNum, _dtDepartureDate, mailNum)
        End Function

        Public Function IsAWBValid(ByVal freightNum As String) As Boolean
            If FlightOperations.IsFreightValid(_strFlightNum, _dtDepartureDate, freightNum) = ReturnCodes.Ok Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function IsFreightLoaded(ByVal freightNum As String) As ReturnCodes
            Return FlightOperations.UnloadFreight(_strFlightNum, _dtDepartureDate, freightNum)
        End Function

        Public Function IsContainerNumValid(ByVal containerNum As String) As Boolean
            If _diContainers.ContainsKey(containerNum) Then
                CurrentContainer = _diContainers(containerNum)
                Return True
            Else
                If DataAccess.FlightOperations.IsContainerNumValid(_strFlightNum, _dtDepartureDate, containerNum) _
                = ReturnCodes.Ok Then
                    Dim objCont As New Container(Me, containerNum)
                    _diContainers.Add(containerNum, objCont)
                    CurrentContainer = objCont
                    Return True
                Else
                    Return False
                End If
            End If
        End Function

        Public Function IsContainerNameValid(ByVal containerName As String) As Boolean
            If FlightOperations.IsContainerNameValid(_strFlightNum, _dtDepartureDate, containerName) = ReturnCodes.Ok Then
                Dim strContNum As String = FlightOperations.GetContainerNum(_strFlightNum, _dtDepartureDate, containerName)
                If _diContainers.ContainsKey(strContNum) Then
                    CurrentContainer = _diContainers(strContNum)
                Else
                    Dim objCont As New Container(Me, strContNum, containerName)
                    _diContainers.Add(strContNum, objCont)
                    CurrentContainer = _diContainers(strContNum)
                End If
                Return True
            Else
                Return False
            End If
        End Function

        Public Function GetListOfBinBulks() As List(Of String)

            Dim liBinBulks As New List(Of String)()
            Dim binBulkEntry As KeyValuePair(Of String, BinBulk)
            liBinBulks.Add("XX")
            For Each binBulkEntry In _diBinBulks
                liBinBulks.Add(binBulkEntry.Key)
            Next
            Return liBinBulks

        End Function

        Public Function GetListOfBinBulksForAddLateBag() As List(Of String)

            Dim liBinBulks As New List(Of String)()
            Dim binBulkEntry As KeyValuePair(Of String, BinBulk)
            For Each binBulkEntry In _diBinBulks
                liBinBulks.Add(binBulkEntry.Key)
            Next
            Return liBinBulks

        End Function

        Public Function GetBinBulksList() As String()

            Dim strBinBulks(_diBinBulks.Count) As String
            Dim binBulkEntry As KeyValuePair(Of String, BinBulk)
            For Each binBulkEntry In _diBinBulks
                'pending

            Next
            Return strBinBulks
        End Function


        'Public Function GetBinBulksNumbers() As String()

        '    Dim strBinBulks(_diBinBulks.Count) As String
        '    Dim binBulkEntry As KeyValuePair(Of String, BinBulk)
        '    For Each binBulkEntry In _diBinBulks
        '        strBinBulks(
        '        liBinBulks.Add(binBulkEntry.Key)
        '    Next
        '    Return liBinBulks

        'End Function

        Public Function ProcessFreight() As Boolean
            Try
                Dim services As ScannerServices = ScannerServices.GetInstance()
                Return services.ProcessFreight(_strFlightNum, _dtDepartureDate)
            Catch ex As Exception
                Return False
            End Try
        End Function

#End Region

#Region "OVERLOADED CONSTRUCTORS"


        'test flight - for tesing purposes
        Public Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime)
            Try
                _strFlightNum = flightNum
                _dtDepartureDate = flightDate
                _blnIsInternational = False
                _strDestination = "ORD"
                _strFinalDestination = "PHX"
                _strGate = "G12"
                _blnIsWideBody = True
                Dim i As Integer
                For i = BOConstants.BagtagBulkLow To BOConstants.BagtagBulkHigh
                    Dim objBinBulk As New BinBulk(Me, i.ToString)
                    _diBinBulks.Add(i.ToString, objBinBulk)
                Next

                Dim strLog As String = String.Format("Flight added, Flight Num = {0}, Flight Date = {1}", _
                _strFlightNum, _dtDepartureDate.VBFormat)
                Logger.LogMessage(strLog, LogType.Information, "Flight.New")
            Catch expSafetrac As SafetracException
                Logger.LogException(expSafetrac)
                Throw expSafetrac
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        'Public Sub New(ByVal existingFlight As DataRow)
        '    Try
        '        _strFlightNum = existingFlight("OP_AL_CDE").ToString & existingFlight("OP_FLT_NUM").ToString
        '        _dtDepartureDate = New NWADateTime(Date.Parse(existingFlight("FLT_SCHED_DTM").ToString))

        '        'get the existing bin bulk objects
        '        Dim dsBinBulks As DataSet = FlightOperations.GetConfiguredFlightBinBulks(_strFlightNum, _dtDepartureDate)
        '        Dim intBinBulkNum As Integer = 0
        '        Dim strBinBulkNum As String = String.Empty
        '        Dim binBulkRow As DataRow
        '        For Each binBulkRow In dsBinBulks.Tables(1).Rows
        '            intBinBulkNum = Convert.ToInt16(binBulkRow(0))
        '            strBinBulkNum = intBinBulkNum.ToString
        '            Dim objBinBulk As New BinBulk(Me, strBinBulkNum)
        '            _diBinBulks.Add(strBinBulkNum, objBinBulk)
        '            If intBinBulkNum < 10 Then
        '                _blnIsWideBody = False
        '            ElseIf intBinBulkNum > 50 Then
        '                _blnIsWideBody = True
        '            End If
        '            Debug.WriteLine("BinBulk added " & strBinBulkNum)
        '        Next

        '        Dim containers As DataSet = FlightOperations.GetConfiguredFlightContainers(_strFlightNum, _dtDepartureDate)
        '        If containers IsNot Nothing Then
        '            Dim dr As DataRow
        '            Dim strContainerNum As String
        '            Dim strContainerName As String
        '            Dim strTemp As String = _dtDepartureDate.ToString("yy") & _dtDepartureDate.VBFormat.DayOfYear.ToString

        '            For Each dr In containers.Tables(0).Rows
        '                If dr.Item("CNTNR_ID").ToString = Nothing Then
        '                    strContainerName = String.Empty
        '                Else
        '                    strContainerName = dr("CNTNR_ID").ToString
        '                End If
        '                strContainerNum = dr("CNTNR_SEQ_NUM").ToString & dr("AP_CDE").ToString & strTemp

        '                Dim objContainer As New Container(Me, strContainerNum, strContainerName)
        '                _diContainers.Add(strContainerNum, objContainer)
        '                Debug.WriteLine(strContainerNum & " - " & strContainerName)

        '            Next
        '        End If

        '        Dim strLog As String = String.Format("Flight added, Flight Num = {0}, Flight Date = {1}", _
        '       _strFlightNum, _dtDepartureDate.VBFormat)
        '        Logger.LogMessage(strLog, LogType.Information, "Flight.New")

        '    Catch expSafetrac As SafetracException
        '        Logger.LogException(expSafetrac)
        '        Throw expSafetrac
        '    Catch ex As Exception
        '        Logger.LogException(ex)
        '    End Try
        'End Sub

        Public Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime, _
        ByVal flightData As DataSet, ByVal binBulks As DataSet, ByVal containers As DataSet, _
        ByVal positions As DataSet)

            Try

                _strFlightNum = flightNum
                _dtDepartureDate = flightDate
                _blnIsInternational = False
                _strDestination = ""
                _strFinalDestination = ""
                _strGate = ""
                _strAcNoseNum = flightData.Tables(0).Rows(0)("AC_NOSE_NUM").ToString()

                If FlightOperations.AddFlight(flightData) Then
                    'LOG MESSAGE
                Else
                    Throw New SafetracException(ReturnCodes.FlightAddError)
                End If

                If FlightOperations.AddBinBulks(_strFlightNum, _dtDepartureDate, binBulks) Then
                    'LOG MESSAGE
                Else
                    Throw New SafetracException(ReturnCodes.FlightAddError)
                End If

                'populate the binbulks dictionary
                If binBulks.Tables("POSITIONS") IsNot Nothing Then
                    Try

                        Dim intBinBulkNum As Integer = 0
                        Dim strBinBulkNum As String = String.Empty
                        Dim binBulkRow As DataRow
                        For Each binBulkRow In binBulks.Tables(1).Rows
                            intBinBulkNum = Convert.ToInt16(binBulkRow(0))
                            strBinBulkNum = intBinBulkNum.ToString
                            Dim objBinBulk As New BinBulk(Me, strBinBulkNum)
                            _diBinBulks.Add(strBinBulkNum, objBinBulk)
                            If intBinBulkNum < 10 Then
                                _blnIsWideBody = False
                            ElseIf intBinBulkNum > 50 Then
                                _blnIsWideBody = True
                            End If
                            Debug.WriteLine("BinBulk added " & strBinBulkNum)
                        Next

                    Catch ex As Exception

                    End Try
                End If

                If FlightOperations.AddContainers(containers) Then
                    'LOG MESSAGE
                Else
                    Throw New SafetracException(ReturnCodes.FlightAddError)
                End If

                If containers IsNot Nothing Then
                    Dim dr As DataRow
                    Dim strContainerNum As String
                    Dim strContainerName As String
                    Dim strTemp As String = flightDate.ToString("yy") & flightDate.VBFormat.DayOfYear.ToString

                    For Each dr In containers.Tables(0).Rows
                        If dr.Item("CNTNR_ID").ToString = Nothing Then
                            strContainerName = String.Empty
                        Else
                            strContainerName = dr("CNTNR_ID").ToString
                        End If
                        strContainerNum = dr("CNTNR_SEQ_NUM").ToString & dr("AP_CDE").ToString & strTemp

                        Dim objContainer As New Container(Me, strContainerNum, strContainerName)
                        _diContainers.Add(strContainerNum, objContainer)
                        Debug.WriteLine(strContainerNum & " - " & strContainerName)

                    Next
                End If

                If FlightOperations.AddAircraftConfig(positions) Then
                    'LOG MESSAGE
                Else
                    Throw New SafetracException(ReturnCodes.FlightAddError)
                End If

                Dim strLog As String = String.Format("Flight added, Flight Num = {0}, Flight Date = {1}", _
               _strFlightNum, _dtDepartureDate.VBFormat)
                Logger.LogMessage(strLog, LogType.Information, "Flight.New")

            Catch expSafetrac As SafetracException
                Logger.LogException(expSafetrac)
                Throw expSafetrac
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        'Public Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime, _
        'ByVal flightData As DataSet, ByVal binBulks As DataSet, ByVal containers As DataSet)

        '    Try

        '        _strFlightNum = flightNum
        '        _dtDepartureDate = flightDate
        '        _blnIsInternational = False
        '        _strDestination = ""
        '        _strFinalDestination = ""
        '        _strGate = ""
        '        _strAcNoseNum = flightData.Tables(0).Rows(0)("AC_NOSE_NUM").ToString()

        '        If FlightOperations.AddFlight(flightData) Then
        '            'LOG MESSAGE
        '        Else
        '            Throw New SafetracException(ReturnCodes.Unknown)
        '        End If

        '        'populate the binbulks dictionary
        '        If binBulks.Tables("POSITIONS") IsNot Nothing Then
        '            Try

        '                Dim intBinBulkNum As Integer = 0
        '                Dim strBinBulkNum As String = String.Empty
        '                Dim binBulkRow As DataRow
        '                For Each binBulkRow In binBulks.Tables(1).Rows
        '                    intBinBulkNum = Convert.ToInt16(binBulkRow(0))
        '                    strBinBulkNum = intBinBulkNum.ToString
        '                    Dim objBinBulk As New BinBulk(Me, strBinBulkNum)
        '                    _diBinBulks.Add(strBinBulkNum, objBinBulk)
        '                    If intBinBulkNum < 10 Then
        '                        _blnIsWideBody = False
        '                    ElseIf intBinBulkNum > 50 Then
        '                        _blnIsWideBody = True
        '                    End If
        '                    Debug.WriteLine("BinBulk added " & strBinBulkNum)
        '                Next

        '            Catch ex As Exception

        '            End Try
        '        End If

        '        If FlightOperations.AddBinBulks(_strFlightNum, _dtDepartureDate, binBulks) Then
        '            'LOG MESSAGE
        '        Else
        '            Throw New SafetracException(ReturnCodes.Unknown)
        '        End If

        '        If containers IsNot Nothing Then
        '            Dim dr As DataRow
        '            Dim strContainerNum As String
        '            Dim strContainerName As String
        '            Dim strTemp As String = flightDate.ToString("yy") & flightDate.VBFormat.DayOfYear.ToString

        '            For Each dr In containers.Tables(0).Rows
        '                If dr.Item("CNTNR_ID").ToString = Nothing Then
        '                    strContainerName = String.Empty
        '                Else
        '                    strContainerName = dr("CNTNR_ID").ToString
        '                End If
        '                strContainerNum = dr("CNTNR_SEQ_NUM").ToString & dr("AP_CDE").ToString & strTemp

        '                Dim objContainer As New Container(Me, strContainerNum, strContainerName)
        '                _diContainers.Add(strContainerNum, objContainer)
        '                Debug.WriteLine(strContainerNum & " - " & strContainerName)

        '            Next
        '        End If

        '        If FlightOperations.AddContainers(containers) Then
        '            'LOG MESSAGE
        '        Else
        '            Throw New SafetracException(ReturnCodes.Unknown)
        '        End If

        '        Dim strLog As String = String.Format("Flight added, Flight Num = {0}, Flight Date = {1}", _
        '       _strFlightNum, _dtDepartureDate.VBFormat)
        '        Logger.LogMessage(strLog, LogType.Information, "Flight.New")

        '    Catch expSafetrac As SafetracException
        '        Logger.LogException(expSafetrac)
        '        Throw expSafetrac
        '    Catch ex As Exception
        '        Logger.LogException(ex)
        '    End Try
        'End Sub

        'Public Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime, _
        '        ByVal flightData As DataSet, ByVal binBulks As DataSet)

        '    Try

        '        _strFlightNum = flightNum
        '        _dtDepartureDate = flightDate
        '        _blnIsInternational = False
        '        _strDestination = ""
        '        _strFinalDestination = ""
        '        _strGate = ""
        '        _strAcNoseNum = flightData.Tables(0).Rows(0)("AC_NOSE_NUM").ToString()

        '        If FlightOperations.AddFlight(flightData) Then
        '            'LOG MESSAGE
        '        Else
        '            Throw New SafetracException(ReturnCodes.Unknown)
        '        End If

        '        'populate the binbulks dictionary
        '        If binBulks.Tables("POSITIONS") IsNot Nothing Then
        '            Try

        '                Dim intBinBulkNum As Integer = 0
        '                Dim strBinBulkNum As String = String.Empty
        '                Dim binBulkRow As DataRow
        '                For Each binBulkRow In binBulks.Tables(1).Rows
        '                    intBinBulkNum = Convert.ToInt16(binBulkRow(0))
        '                    strBinBulkNum = intBinBulkNum.ToString
        '                    Dim objBinBulk As New BinBulk(Me, strBinBulkNum)
        '                    _diBinBulks.Add(strBinBulkNum, objBinBulk)
        '                    If intBinBulkNum < 10 Then
        '                        _blnIsWideBody = False
        '                    ElseIf intBinBulkNum > 50 Then
        '                        _blnIsWideBody = True
        '                    End If
        '                    Debug.WriteLine("BinBulk added " & strBinBulkNum)
        '                Next

        '            Catch ex As Exception

        '            End Try
        '        End If

        '        Dim strLog As String = String.Format("Flight added, Flight Num = {0}, Flight Date = {1}", _
        '       _strFlightNum, _dtDepartureDate.VBFormat)
        '        Logger.LogMessage(strLog, LogType.Information, "Flight.New")

        '    Catch expSafetrac As SafetracException
        '        Logger.LogException(expSafetrac)
        '        Throw expSafetrac
        '    Catch ex As Exception
        '        Logger.LogException(ex)
        '    End Try
        'End Sub

#End Region

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub
    End Class
End Namespace