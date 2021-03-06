
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.DataAccess
Imports NWA.Safetrac.Scanner.WebReferences

Namespace NWA.Safetrac.Scanner.BO

    Public Class FlightsCollection

        Private _dtFlights As New Dictionary(Of String, Flight)
        Private _currentFlight As BO.Flight
        Private Shared _FlightsObj As FlightsCollection

        Private Sub New()
            Try
                InitializeConfiguredFlights()
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Public Shared Function GetInstance() As FlightsCollection
            If _FlightsObj Is Nothing Then
                _FlightsObj = New FlightsCollection
            End If
            Return _FlightsObj
        End Function

        Public Property CurrentFlight() As Flight
            Get
                Return _currentFlight
            End Get
            Set(ByVal value As BO.Flight)
                _currentFlight = value
            End Set
        End Property

        Public ReadOnly Property Flights(ByVal flightNum As String, ByVal departureDate As NWADateTime) As Flight
            Get
                Dim strKey As String = flightNum & "-" & departureDate.NWAFormat
                If (_dtFlights.ContainsKey(strKey)) Then
                    _currentFlight = Nothing
                    _currentFlight = _dtFlights(strKey)
                    Return _currentFlight
                Else
                    Throw New SafetracException(ReturnCodes.FlightInvalid, "InvalidFlight", "FlightsCollection.Flights")
                End If
            End Get
        End Property

        'Public Function GetConfiguredFlights() As List(Of NWAFlight)
        '    Dim diFlightKeys As New List(Of NWAFlight)()
        '    Dim objNWAFlight As NWAFlight
        '    Dim flightEntry As KeyValuePair(Of String, Flight)
        '    For Each flightEntry In _dtFlights
        '        diFlightKeys.Add(flightEntry.Key)
        '    Next
        '    Return diFlightKeys
        'End Function


        Public Function GetConfiguredFlightsList() As List(Of String)
            Dim diFlightKeys As New List(Of String)()
            Dim flightEntry As KeyValuePair(Of String, Flight)
            For Each flightEntry In _dtFlights
                diFlightKeys.Add(flightEntry.Key)
            Next
            Return diFlightKeys
        End Function

        Public Sub InitializeConfiguredFlights()
            Try
                Dim dsFlight As DataSet = FlightOperations.GetConfiguredFlights()
                Dim drFlight As DataRow
                For Each drFlight In dsFlight.Tables(0).Rows


                Next
            Catch ex As Exception

            End Try


        End Sub

        Public Function RemoveFlight(ByVal flightNum As String, ByVal departureDate As NWADateTime) As ReturnCodes

            Dim objSyncManager As SyncManager.SyncManager
            Dim lsTableList As List(Of String)
            Try
                objSyncManager = SyncManager.SyncManager.GetSyncInstance()
                lsTableList = objSyncManager.ListOfTablesToBeDeleted()
                If FlightOperations.RemoveFlight(flightNum, departureDate, lsTableList) = True Then
                    Return ReturnCodes.Ok
                Else
                    Return ReturnCodes.NotOk
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'test method for creating dummy database records - delete later - pending
        Public Shared Sub InsertRecords(ByVal no As Integer)
            NWA.Safetrac.Scanner.DataAccess.FlightOperations.InsertTables(no)
        End Sub

        

        Public Function AddFlight(ByVal flightNum As String, ByVal departureDate As NWADateTime) As ReturnCodes
            Try

                Dim strKey As String = flightNum & "-" & departureDate.NWAFormat

                If _dtFlights.ContainsKey(strKey) Then
                    Return ReturnCodes.FlightAlreadyExists
                End If

                Dim services As ScannerServices = ScannerServices.GetInstance()
                Dim flightResponse As ScannerServiceResponse = services.GetFlightToAdd(flightNum, departureDate)

                'get the flight details
                If flightResponse.IsSuccessful Then
                    'Debug.WriteLine(flightResponse.Response.Tables(0).TableName)
                    Dim flightRow As DataRow = flightResponse.Response.Tables("Flight").Rows(0)
                Else
                    Throw New SafetracException(ReturnCodes.FlightAddError, "Error in downloading Flight Info")
                End If

                'get the bin bulk objects through existing .NET webservice
                Dim binBulkResponse As ScannerServiceResponse = services.GetAircraftBins(flightNum, departureDate)

                If binBulkResponse.IsSuccessful Then
                    'If binBulkResponse.Response.Tables("POSITIONS") IsNot Nothing Then
                    '    Dim strBinBulkNum As String = String.Empty
                    '    Dim binBulkRow As DataRow
                    '    For Each binBulkRow In binBulkResponse.Response.Tables(1).Rows
                    '        strBinBulkNum = Convert.ToInt16(binBulkRow(0)).ToString
                    '        Debug.WriteLine("BinBulkNum - " & strBinBulkNum)
                    '    Next
                    'End If
                Else
                    Debug.WriteLine(binBulkResponse.ReturnMessage)
                    'Throw New SafetracException(ReturnCodes.FlightAddError, "Error in downloading Flight Info")
                End If

                Dim containersResponse As ScannerServiceResponse = services.GetAircraftContainers(flightNum, departureDate)

                If containersResponse.IsSuccessful Then

                    'Dim dr As DataRow
                    'Dim strContainerNum As String
                    'Dim strContainerName As String
                    'Dim strTemp As String = dtFlightDate.ToString("yy") & dtFlightDate.VBFormat.DayOfYear.ToString

                    'For Each dr In containersResponse.Response.Tables(0).Rows
                    '    If dr.Item("CNTNR_ID").ToString = Nothing Then
                    '        strContainerName = String.Empty
                    '    Else
                    '        strContainerName = dr("CNTNR_ID").ToString
                    '    End If
                    '    strContainerNum = dr("CNTNR_SEQ_NUM").ToString & dr("AP_CDE").ToString & strTemp
                    '    Debug.WriteLine(strContainerNum & " - " & strContainerName)
                    'Next
                Else
                    Throw New SafetracException(ReturnCodes.FlightAddError, "Error in downloading Flight Info")
                End If

                'download the aircraft config
                Dim configResponse As ScannerServiceResponse = services.GetAircraftPositions(flightNum, departureDate)

                If configResponse.IsSuccessful Then
                    'Debug.WriteLine(configResponse.Response.Tables(0).TableName)
                    Dim positionRow As DataRow
                    For Each positionRow In configResponse.Response.Tables("Aircraft").Rows
                        Debug.WriteLine("Position - " & positionRow("POS_NUM").ToString)
                    Next
                Else
                    Throw New SafetracException(ReturnCodes.FlightAddError, "Error in downloading Flight Info")
                End If


                Dim objFlight As New Flight(flightNum, departureDate, flightResponse.Response, _
                binBulkResponse.Response, configResponse.Response, configResponse.Response)

                _dtFlights.Add(strKey, objFlight)

                _currentFlight = objFlight

                Return ReturnCodes.FlightAdded

            Catch safetracExp As SafetracException
                Logger.LogException(safetracExp)
                Return safetracExp.ErrorCode
            Catch ex As Exception
                Logger.LogException(ex)
                Return ReturnCodes.Unknown
            End Try

        End Function

        Public Function IsFlightValid(ByVal flightNum As String, ByVal departureDate As NWADateTime) As Boolean
            Dim strKey As String = flightNum & "-" & departureDate.NWAFormat
            If _dtFlights.ContainsKey(strKey) Then
                _currentFlight = Nothing
                _currentFlight = _dtFlights(strKey)
                Return True
            Else
                Return False
            End If
        End Function

        Private Function GetFlightKey(ByVal flightNum As String, ByVal departureDate As NWADateTime) As String
            Return flightNum & "-" & departureDate.NWAFormat
        End Function

        Public Function GetFlightNum(ByVal key As String) As NWAFlight
            Dim nwaFlight As New NWAFlight
            Dim strKeys(2) As String
            strKeys = key.Split(CChar("-"))
            nwaFlight.Number = strKeys(1)
            nwaFlight.DepartureDate = New NWADateTime(strKeys(2))
            Return nwaFlight
        End Function

        Public Function AddTestFlight(ByVal flightNum As String, ByVal departureDate As NWADateTime) As ReturnCodes
            Try
                Dim strKey As String = flightNum & "-" & departureDate.NWAFormat
                If _dtFlights.ContainsKey(strKey) Then
                    Return ReturnCodes.FlightAlreadyExists
                End If
                Dim objFlight As New Flight(flightNum, departureDate)
                _dtFlights.Add(strKey, objFlight)
                _currentFlight = objFlight

            Catch ex As Exception

            End Try
        End Function

    End Class

End Namespace

