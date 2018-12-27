
Imports System.IO
Imports System.Xml
Imports System.Data
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.WebReferences.NET
Imports NWA.Safetrac.Scanner.WebReferences.J2EE
Imports NWA.Safetrac.Scanner.WebReferences.Objects
Imports NWA.Safetrac.Scanner.WebReferences.J2EE.DataSync

Namespace NWA.Safetrac.Scanner.WebReferences

    Public Class ScannerServices

        Private Shared _intMessageID As Integer
        Private Shared _objWebServices As ScannerServices
        Private _objWS_GetDateTime As New GetDateTime.WS_GetDateTime()
        Private _objACConfig As New ACConfig.ACConfig()
        Private _objWS_Device_Admin As New DeviceAdmin.WS_Device_Admin()
        Private _objWS_FlightLD As New FlightLD.WS_FlightLD()
        Private _objWS_Freight_Load As New FreightLoad.WS_Freight_Load()
        Private _objWS_ReadDDSGLineItems As New ReadDDSG.WS_ReadDDSGLineItems()
        Private _objDataSyncService As New DataSyncService()
        Private _objInputSoapEnvelope As New SafetracSOAPEnvelope

        Public Shared Function GetInstance() As ScannerServices
            If _objWebServices Is Nothing Then
                _objWebServices = New ScannerServices()
            End If
            Return _objWebServices
        End Function

        Private Sub New()
            _objInputSoapEnvelope.header = New DataSync.MessageHeaderType()
            _intMessageID = 1
        End Sub

        Public Property UserID() As String
            Get
                Return _objInputSoapEnvelope.header.userID
            End Get
            Set(ByVal value As String)
                _objInputSoapEnvelope.header.userID = value
            End Set
        End Property


        Public Property DeviceID() As String
            Get
                Return _objInputSoapEnvelope.header.hhtID
            End Get
            Set(ByVal value As String)
                _objInputSoapEnvelope.header.hhtID = value
            End Set
        End Property

        Public Property Station() As String
            Get
                Return _objInputSoapEnvelope.header.deprStationCode
            End Get
            Set(ByVal value As String)
                _objInputSoapEnvelope.header.deprStationCode = value
            End Set
        End Property

        Private Sub AssignMessageID()
            _objInputSoapEnvelope.header.messageID = _intMessageID.ToString
            _intMessageID = _intMessageID + 1
        End Sub

        Public Property RequestType() As MessageHeaderTypeServiceType
            Get
                Return _objInputSoapEnvelope.header.serviceType
            End Get
            Set(ByVal value As MessageHeaderTypeServiceType)
                _objInputSoapEnvelope.header.serviceType = value
            End Set
        End Property

        Public Property TrainingMode() As Boolean
            Get
                If _objInputSoapEnvelope.header.isTrainingMode = "Y" Then
                    Return True
                Else
                    Return False
                End If
            End Get
            Set(ByVal value As Boolean)
                If value = True Then
                    _objInputSoapEnvelope.header.isTrainingMode = "Y"
                Else
                    _objInputSoapEnvelope.header.isTrainingMode = "N"
                End If
            End Set
        End Property

        Public Property RequestOperationType() As MessageHeaderTypeRequestedOperationType
            Get
                Return _objInputSoapEnvelope.header.requestedOperationType
            End Get
            Set(ByVal value As MessageHeaderTypeRequestedOperationType)
                _objInputSoapEnvelope.header.requestedOperationType = value
            End Set
        End Property

        Public Property Body() As String
            Get
                Return _objInputSoapEnvelope.body
            End Get
            Set(ByVal value As String)
                _objInputSoapEnvelope.body = value
            End Set
        End Property

        Public Function PerformLDAPLogin(ByVal deviceID As String, ByVal userID As String, _
            ByVal password As String, ByVal station As String, ByVal InTrainingMode As Boolean, _
            ByVal appVersion As String) As ScannerServiceResponse

            Dim serviceResponse As ScannerServiceResponse = Nothing

            Try
                Dim objSafetracSOAPBody As New SafetracSOAPBody()
                Dim objUser As New SafetracSOAPBodyUser()
                Dim objUserIn As New UserInData()
                objUserIn.USER_ID = userID
                objUserIn.PASSWORD = password
                objUserIn.APPVERSION = appVersion
                objUser.Item = objUserIn
                Dim objBody(0) As Object
                objBody(0) = objUser
                objSafetracSOAPBody.Items = objBody

                Me.DeviceID = deviceID
                Me.Station = station
                Me.TrainingMode = InTrainingMode
                Me.AssignMessageID()
                Me.UserID = userID
                Me.RequestType = DataSync.MessageHeaderTypeServiceType.G
                Me.RequestOperationType = MessageHeaderTypeRequestedOperationType.LDAPLOGIN
                Me.Body = Serialize(objSafetracSOAPBody)

                Dim objOutputSoapEnvelope As SafetracSOAPEnvelope _
                    = _objDataSyncService.PerformGeneralService(_objInputSoapEnvelope)

                serviceResponse = New ScannerServiceResponse(objOutputSoapEnvelope)

            Catch ex As Exception
                Logger.LogException(ex)
                serviceResponse = New ScannerServiceResponse(ex)
            End Try
            Return serviceResponse
        End Function

        Public Function GetLanSettings() As ScannerServiceResponse

            Dim serviceResponse As ScannerServiceResponse = Nothing
            Try
                Dim strResponse As String = String.Empty
                strResponse = _objWS_Device_Admin.GetLANSettings(ConfigManager.SerialNumber)
                serviceResponse = New ScannerServiceResponse(strResponse)
            Catch ex As Exception
                Logger.LogException(ex)
                serviceResponse = New ScannerServiceResponse(ex)
            End Try
            Return serviceResponse
        End Function


        Public Function GetSyncTime() As Date

            Try
                Dim strResponse As String = String.Empty

                strResponse = _objWS_GetDateTime.GetLocalDateTime(DeviceID)

                Dim serviceReponse As New ScannerServiceResponse(strResponse)

                If serviceReponse.Response.Tables("GETLOCALDATETIME").Rows(0)("RESULT").ToString() = "OK" Then
                    Dim objDateTime As New Date(Convert.ToInt16(serviceReponse.Response.Tables("OK").Rows(0)("YEAR")), _
                        Convert.ToInt16(serviceReponse.Response.Tables("OK").Rows(0)("MONTH")), _
                        Convert.ToInt16(serviceReponse.Response.Tables("OK").Rows(0)("DAY")), _
                        Convert.ToInt16(serviceReponse.Response.Tables("OK").Rows(0)("HOUR")), _
                        Convert.ToInt16(serviceReponse.Response.Tables("OK").Rows(0)("MIN")), 0)
                    Return objDateTime
                Else
                    'Log the error result

                    Throw New SafetracException(ReturnCodes.Exception, "Invalid", "WebServices.GetSyncTime")

                End If
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New SafetracException(ReturnCodes.Unknown, "Unknown", "WebServices.GetSyncTime")
            End Try
        End Function

        Public Function GetFlightToAdd(ByVal flightNum As String, ByVal flightDate As NWADateTime) As ScannerServiceResponse

            Dim serviceResponse As ScannerServiceResponse = Nothing

            Try
                Dim objSafetracSOAPBody As New SafetracSOAPBody()
                Dim objDownloadReq As New DownloadReqData()
                Dim objFlightRequest As New DownloadReqDataFlight()
                objFlightRequest.FLT_NUM = flightNum
                objFlightRequest.IS_NEW_REQUEST = "Y"
                objFlightRequest.FLT_SCHED_DTM = flightDate.SqlDateFormat
                objFlightRequest.DEPARTURESTATIONCODE = Me.Station
                Dim objFlights(0) As DownloadReqDataFlight
                objFlights(0) = objFlightRequest
                objDownloadReq.Flight = objFlights
                objDownloadReq.FlightCount = 1
                Dim objBody(0) As Object
                objBody(0) = objDownloadReq
                objSafetracSOAPBody.Items = objBody

                Me.AssignMessageID()
                Me.RequestType = DataSync.MessageHeaderTypeServiceType.D
                Me.RequestOperationType = MessageHeaderTypeRequestedOperationType.FLIGHT
                Me.Body = Serialize(objSafetracSOAPBody)

                Dim objOutputSoapEnvelope As SafetracSOAPEnvelope _
                    = _objDataSyncService.PerformDownloadService(_objInputSoapEnvelope)

                serviceResponse = New ScannerServiceResponse(objOutputSoapEnvelope)

            Catch ex As Exception
                serviceResponse = New ScannerServiceResponse(ex)
            End Try

            Return serviceResponse

        End Function

        Public Function GetAircraftPositions(ByVal flightNum As String, ByVal flightDate As NWADateTime) As ScannerServiceResponse

            Dim serviceResponse As ScannerServiceResponse = Nothing

            Try
                Dim objSafetracSOAPBody As New SafetracSOAPBody()
                Dim objDownloadReq As New DownloadReqData()
                Dim objFlightRequest As New DownloadReqDataFlight()
                objFlightRequest.FLT_NUM = flightNum
                objFlightRequest.IS_NEW_REQUEST = "Y"
                objFlightRequest.FLT_SCHED_DTM = flightDate.SqlDateFormat
                objFlightRequest.DEPARTURESTATIONCODE = Me.Station
                Dim objFlights(0) As DownloadReqDataFlight
                objFlights(0) = objFlightRequest
                objDownloadReq.Flight = objFlights
                objDownloadReq.FlightCount = 1
                Dim objBody(0) As Object
                objBody(0) = objDownloadReq
                objSafetracSOAPBody.Items = objBody

                Me.AssignMessageID()
                Me.RequestType = DataSync.MessageHeaderTypeServiceType.G
                Me.RequestOperationType = MessageHeaderTypeRequestedOperationType.AIRCRAFTCONFIG
                Me.Body = Serialize(objSafetracSOAPBody)

                Dim objOutputSoapEnvelope As SafetracSOAPEnvelope _
                    = _objDataSyncService.PerformDownloadService(_objInputSoapEnvelope)

                serviceResponse = New ScannerServiceResponse(objOutputSoapEnvelope)

            Catch ex As Exception
                serviceResponse = New ScannerServiceResponse(ex)
            End Try

            Return serviceResponse

        End Function

        Public Function GetAircraftContainers(ByVal flightNum As String, ByVal flightDate As NWADateTime) As ScannerServiceResponse

            Dim serviceResponse As ScannerServiceResponse = Nothing

            Try
                Dim objSafetracSOAPBody As New SafetracSOAPBody()
                Dim objDownloadReq As New DownloadReqData()
                Dim objFlightRequest As New DownloadReqDataFlight()
                objFlightRequest.FLT_NUM = flightNum
                objFlightRequest.IS_NEW_REQUEST = "Y"
                objFlightRequest.FLT_SCHED_DTM = flightDate.SqlDateFormat
                objFlightRequest.DEPARTURESTATIONCODE = Me.Station
                Dim objFlights(0) As DownloadReqDataFlight
                objFlights(0) = objFlightRequest
                objDownloadReq.Flight = objFlights
                objDownloadReq.FlightCount = 1
                Dim objBody(0) As Object
                objBody(0) = objDownloadReq
                objSafetracSOAPBody.Items = objBody

                Me.AssignMessageID()
                Me.RequestType = DataSync.MessageHeaderTypeServiceType.D
                Me.RequestOperationType = MessageHeaderTypeRequestedOperationType.ULD
                Me.Body = Serialize(objSafetracSOAPBody)

                Dim objOutputSoapEnvelope As SafetracSOAPEnvelope _
                    = _objDataSyncService.PerformDownloadService(_objInputSoapEnvelope)

                serviceResponse = New ScannerServiceResponse(objOutputSoapEnvelope)

            Catch ex As Exception
                serviceResponse = New ScannerServiceResponse(ex)
            End Try

            Return serviceResponse

        End Function

        Public Function GetAircraftBins(ByVal flightNum As String, ByVal flightDate As NWADateTime) As ScannerServiceResponse

            Dim serviceResponse As ScannerServiceResponse = Nothing

            Try
                Dim strResponse As String = String.Empty
                strResponse = _objACConfig.GetACConfig("HHT889", "NW", flightNum, _
                        flightDate.WebFormat, "MSP", "D")
                serviceResponse = New ScannerServiceResponse(strResponse)
            Catch ex As Exception
                serviceResponse = New ScannerServiceResponse(ex)
            End Try

            Return serviceResponse

        End Function

        Public Function ProcessFreight(ByVal flightNum As String, ByVal flightDate As NWADateTime) _
                    As Boolean
            Try
                Dim response As String = _objWS_Freight_Load.ProcessFreight("HHT889", _
                    "NW", flightNum, flightDate.WebFormat, "MSP", "Y")
                If response = "<PROCESSFREIGHT>OKAY</PROCESSFREIGHT>" Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                'log exception
                Return False
            End Try
        End Function

        Public Function GetBagsToUnload(ByVal airlineCode As String, ByVal flightNum As String, _
        ByVal flightDate As NWADateTime, ByVal station As String) As ScannerServiceResponse
            Dim serviceResponse As ScannerServiceResponse = Nothing
            Try
                Dim objSafetracSOAPBody As New SafetracSOAPBody()
                Dim objBagsToUnloadIn(0) As BagsToUnldInData
                objBagsToUnloadIn(0) = New BagsToUnldInData
                objBagsToUnloadIn(0).OP_AL_CDE = airlineCode
                objBagsToUnloadIn(0).OP_FLT_NUM = flightNum
                objBagsToUnloadIn(0).FLT_SCHED_DTM = flightDate.SqlDateFormat
                objBagsToUnloadIn(0).AP_CDE = station
                Dim objBagsToUnload(0) As SafetracSOAPBodyBagsToUnld
                objBagsToUnload(0) = New SafetracSOAPBodyBagsToUnld
                objBagsToUnload(0).Items = objBagsToUnloadIn
                objSafetracSOAPBody.Items = objBagsToUnload
                Dim strInput As String = Serialize(objSafetracSOAPBody)

                Me.AssignMessageID()
                Me.RequestType = DataSync.MessageHeaderTypeServiceType.G
                Me.RequestOperationType = MessageHeaderTypeRequestedOperationType.VIEWBAGSTOUNLD
                Me.Body = Serialize(objSafetracSOAPBody)

                Dim objOutputSoapEnvelope As SafetracSOAPEnvelope _
                    = _objDataSyncService.PerformGeneralService(_objInputSoapEnvelope)

                serviceResponse = New ScannerServiceResponse(objOutputSoapEnvelope)

            Catch ex As Exception
                serviceResponse = New ScannerServiceResponse(ex)
            End Try
            Return serviceResponse
        End Function
        Public Function GetContainerSummary(ByVal _strContainer As String, ByVal _blnIsContainerNum As Boolean) As ScannerServiceResponse

            Dim serviceResponse As ScannerServiceResponse = Nothing

            Try
                Dim objSafetracSOAPBody As New SafetracSOAPBody()
                Dim objULDCartIn(0) As ULDCartInData
                objULDCartIn(0) = New ULDCartInData

                If _blnIsContainerNum = True Then 'if valid CSN
                    objULDCartIn(0).CNTNR_ID = String.Empty
                    objULDCartIn(0).CNTNR_SEQ_NUM = _strContainer
                Else 'if valid ULD
                    objULDCartIn(0).CNTNR_ID = _strContainer
                    objULDCartIn(0).CNTNR_SEQ_NUM = String.Empty
                End If

                objULDCartIn(0).AP_CDE = Me.Station
                Dim objULDCart(0) As SafetracSOAPBodyULDCart
                objULDCart(0) = New SafetracSOAPBodyULDCart
                objULDCart(0).Items = objULDCartIn
                objSafetracSOAPBody.Items = objULDCart
                Dim strInput As String = Serialize(objSafetracSOAPBody)

                Me.AssignMessageID()
                Me.RequestType = DataSync.MessageHeaderTypeServiceType.G
                Me.RequestOperationType = MessageHeaderTypeRequestedOperationType.VIEWULDCARTINQ
                Me.Body = Serialize(objSafetracSOAPBody)
                Dim objOutputSoapEnvelope As SafetracSOAPEnvelope _
                        = _objDataSyncService.PerformGeneralService(_objInputSoapEnvelope)

                serviceResponse = New ScannerServiceResponse(objOutputSoapEnvelope)
                'Dim row1 As DataRow = serviceResponse.Response.Tables("BagTagDupOut").Rows(0)
                'Debug.WriteLine(s1)

            Catch ex As Exception
                serviceResponse = New ScannerServiceResponse(ex)
            End Try
            Return serviceResponse
        End Function
        Public Function GetBinBulkSummary(ByVal flightNum As String, ByVal flightDate As NWADateTime, ByVal strBinBulkNum As String)
            Dim serviceResponse As ScannerServiceResponse = Nothing
            Try
                Dim objSafetracSOAPBody As New SafetracSOAPBody()
                Dim objBinBulkIn(0) As BinBulkInData
                objBinBulkIn(0) = New BinBulkInData

                objBinBulkIn(0).AP_CDE = Me.Station
                objBinBulkIn(0).FLT_SCHED_DTM = flightDate.SqlDateFormat
                objBinBulkIn(0).OP_FLT_NUM = flightNum
                objBinBulkIn(0).POS_NUM = strBinBulkNum

                Dim objBinBulk(0) As SafetracSOAPBodyBinbulk
                objBinBulk(0) = New SafetracSOAPBodyBinbulk
                objBinBulk(0).Items = objBinBulkIn
                objSafetracSOAPBody.Items = objBinBulk
                Dim strInput As String = Serialize(objSafetracSOAPBody)

                Me.AssignMessageID()
                Me.RequestType = DataSync.MessageHeaderTypeServiceType.G
                Me.RequestOperationType = MessageHeaderTypeRequestedOperationType.VIEWBINBULKINQ
                Me.Body = Serialize(objSafetracSOAPBody)
                Dim objOutputSoapEnvelope As SafetracSOAPEnvelope _
                        = _objDataSyncService.PerformGeneralService(_objInputSoapEnvelope)
                serviceResponse = New ScannerServiceResponse(objOutputSoapEnvelope)
            Catch ex As Exception
                serviceResponse = New ScannerServiceResponse(ex)
            End Try
            Return serviceResponse
        End Function
        Public Function GetDuplicatesBagtags(ByVal bagTagNum As String)

            Dim serviceResponse As ScannerServiceResponse = Nothing

            Try
                Dim objSafetracSOAPBody As New SafetracSOAPBody()
                Dim objBagTagIn(0) As BagTagInData
                objBagTagIn(0) = New BagTagInData
                objBagTagIn(0).BAG_ID = bagTagNum
                objBagTagIn(0).AP_CDE = Station
                Dim objBagTag(0) As SafetracSOAPBodyBagTag
                objBagTag(0) = New SafetracSOAPBodyBagTag
                objBagTag(0).Items = objBagTagIn
                objSafetracSOAPBody.Items = objBagTag
                Dim strInput As String = Serialize(objSafetracSOAPBody)

                Me.AssignMessageID()
                Me.RequestType = DataSync.MessageHeaderTypeServiceType.G
                Me.RequestOperationType = MessageHeaderTypeRequestedOperationType.BAGTAGINQDUP
                Me.Body = Serialize(objSafetracSOAPBody)
                Dim objOutputSoapEnvelope As SafetracSOAPEnvelope _
                        = _objDataSyncService.PerformGeneralService(_objInputSoapEnvelope)

                serviceResponse = New ScannerServiceResponse(objOutputSoapEnvelope)

            Catch ex As Exception
                serviceResponse = New ScannerServiceResponse(ex)
            End Try
            Return serviceResponse
        End Function
        Public Function PerformBagtagInquiry(ByVal bagtagNum As String, ByVal airlineCode As String, _
                     ByVal creationDateTime As NWADateTime) As ScannerServiceResponse

            Dim serviceResponse As ScannerServiceResponse = Nothing

            Try

                Dim objSafetracSOAPBody As New SafetracSOAPBody()
                Dim objBagTagIn(0) As BagTagInData
                objBagTagIn(0) = New BagTagInData
                objBagTagIn(0).BAG_ID = bagtagNum
                objBagTagIn(0).OP_AL_CDE = airlineCode
                objBagTagIn(0).CRTN_DTM = creationDateTime.SqlDateFormat
                objBagTagIn(0).AP_CDE = Me.Station
                Dim objBagTag(0) As SafetracSOAPBodyBagTag
                objBagTag(0) = New SafetracSOAPBodyBagTag
                objBagTag(0).Items = objBagTagIn
                objSafetracSOAPBody.Items = objBagTag
                Dim strInput As String = Serialize(objSafetracSOAPBody)

                Me.AssignMessageID()
                Me.RequestType = DataSync.MessageHeaderTypeServiceType.G
                Me.RequestOperationType = MessageHeaderTypeRequestedOperationType.BAGTAGINQ
                Me.Body = Serialize(objSafetracSOAPBody)
                Dim objOutputSoapEnvelope As SafetracSOAPEnvelope _
                        = _objDataSyncService.PerformDownloadService(_objInputSoapEnvelope)
                serviceResponse = New ScannerServiceResponse(objOutputSoapEnvelope)

            Catch ex As Exception
                serviceResponse = New ScannerServiceResponse(ex)
            End Try
            Return serviceResponse
        End Function

        Public Function VerifyClock(ByVal flightNum As String, ByVal flightDate As NWADateTime, ByVal clockNumber As String, _
            ByVal station As String) As ScannerServiceResponse

        End Function

        Public Function PreCloseFlight(ByVal flightNum As String, ByVal flightDate As NWADateTime) As ScannerServiceResponse

        End Function

        Public Function CloseFlight(ByVal flightNum As String, ByVal flightDate As NWADateTime, _
        ByVal station As String, ByVal override As String, ByVal lineNumber As String) As ScannerServiceResponse


        End Function

        Public Function RegisterContainer(ByVal flightNum As String, ByVal flightDate As NWADateTime, _
       ByVal strContainerNum As String, ByVal containerName As String, ByVal finalDest As String) As ScannerServiceResponse
            Dim serviceResponse As ScannerServiceResponse = Nothing
            Try
                Dim objSafetracSOAPBody As New SafetracSOAPBody()
                Dim objULDRegInData As ULDRegInData = New ULDRegInData
                objULDRegInData.OP_FLT_NUM = flightNum
                objULDRegInData.FLT_SCHED_DTM = flightDate.SqlDateFormat
                objULDRegInData.CNTNR_SEQ_NUM = strContainerNum
                objULDRegInData.CNTNR_ID = containerName
                objULDRegInData.FNL_DEST_AP_CDE = finalDest
                objULDRegInData.AP_CDE = Me.Station
                Dim objULDReg(0) As SafetracSOAPBodyULDReg
                objULDReg(0) = New SafetracSOAPBodyULDReg
                objULDReg(0).Item = objULDRegInData
                objSafetracSOAPBody.Items = objULDReg
                Dim strInput As String = Serialize(objSafetracSOAPBody)

                Me.AssignMessageID()
                Me.RequestType = DataSync.MessageHeaderTypeServiceType.G
                Me.RequestOperationType = MessageHeaderTypeRequestedOperationType.ULDREG
                Me.Body = Serialize(objSafetracSOAPBody)

                Dim objOutputSoapEnvelope As SafetracSOAPEnvelope _
                    = _objDataSyncService.PerformGeneralService(_objInputSoapEnvelope)

                serviceResponse = New ScannerServiceResponse(objOutputSoapEnvelope)


            Catch ex As Exception
                serviceResponse = New ScannerServiceResponse(ex)
            End Try
            Return serviceResponse
        End Function

        Public Function ChangeContainerDefinition(ByVal flightNum As String, ByVal containerNum As String, _
        ByVal containerName As String, ByVal containerType As String, ByVal hubCode As String, _
        ByVal hubFlightDest As String, ByVal hubFlightNum As String, ByVal hubFlightSched As String) _
        As ScannerServiceResponse
            Dim serviceResponse As ScannerServiceResponse = Nothing
            Try
                Dim objSafetracSOAPBody As New SafetracSOAPBody()
                Dim objULDDefInData As ULDDefInData = New ULDDefInData
                objULDDefInData.AP_CDE = Me.Station
                objULDDefInData.CNTNR_ID = containerName
                objULDDefInData.CNTNR_SEQ_NUM = containerNum
                objULDDefInData.CNTNR_TYP_CDE = containerType
                objULDDefInData.HUB_AL_CDE = hubCode
                objULDDefInData.HUB_FLT_DEST = hubFlightDest
                objULDDefInData.HUB_FLT_NUM = hubFlightNum
                objULDDefInData.HUB_FLT_SCHED_DTM = hubFlightSched

                Dim objULDDef(0) As SafetracSOAPBodyULDDef
                objULDDef(0) = New SafetracSOAPBodyULDDef
                objULDDef(0).Item = objULDDefInData
                objSafetracSOAPBody.Items = objULDDef
                Dim strInput As String = Serialize(objSafetracSOAPBody)

                Me.AssignMessageID()
                Me.RequestType = DataSync.MessageHeaderTypeServiceType.G
                Me.RequestOperationType = MessageHeaderTypeRequestedOperationType.ULDDEF
                Me.Body = Serialize(objSafetracSOAPBody)

                Dim objOutputSoapEnvelope As SafetracSOAPEnvelope _
                    = _objDataSyncService.PerformGeneralService(_objInputSoapEnvelope)

                serviceResponse = New ScannerServiceResponse(objOutputSoapEnvelope)


            Catch ex As Exception
                serviceResponse = New ScannerServiceResponse(ex)
            End Try
            Return serviceResponse
        End Function

        Public Function CreateContainerSheetNumber(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
               ByVal containerName As String, ByVal containerType As String, ByVal destinationName As String) As ScannerServiceResponse

            Dim serviceResponse As ScannerServiceResponse = Nothing
            Try
                Dim objSafetracSOAPBody As New SafetracSOAPBody()
                Dim objULDCreateNormalInData As ULDCreateNormalInData = New ULDCreateNormalInData
                objULDCreateNormalInData.AP_CDE = Me.Station
                objULDCreateNormalInData.CNTNR_ID = containerName
                objULDCreateNormalInData.CNTNR_TYP_CDE = containerType
                objULDCreateNormalInData.FLT_SCHED_DTM = departureDate.SqlDateFormat
                objULDCreateNormalInData.FNL_DEST_AP_CDE = destinationName
                objULDCreateNormalInData.OP_AL_CDE = flightNum.Substring(0, 2)
                objULDCreateNormalInData.OP_FLT_NUM = flightNum.Substring(2)
                objULDCreateNormalInData.REMARK = String.Empty
                Dim objULDCreate(0) As SafetracSOAPBodyULDCreate
                objULDCreate(0) = New SafetracSOAPBodyULDCreate
                objULDCreate(0).Item = objULDCreateNormalInData
                objSafetracSOAPBody.Items = objULDCreate
                Dim strInput As String = Serialize(objSafetracSOAPBody)

                Me.AssignMessageID()
                Me.RequestType = DataSync.MessageHeaderTypeServiceType.G
                Me.RequestOperationType = MessageHeaderTypeRequestedOperationType.ULDCREATE
                Me.Body = Serialize(objSafetracSOAPBody)

                Dim objOutputSoapEnvelope As SafetracSOAPEnvelope _
                    = _objDataSyncService.PerformGeneralService(_objInputSoapEnvelope)

                serviceResponse = New ScannerServiceResponse(objOutputSoapEnvelope)

            Catch ex As Exception
                serviceResponse = New ScannerServiceResponse(ex)
            End Try
            Return serviceResponse
        End Function


        Public Function CreateHubContainerSheetNumber(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
               ByVal containerName As String, ByVal containerType As String, ByVal destinationName As String, _
        ByVal hubFlightNum As String, ByVal hubFlightDate As NWADateTime, ByVal hubDestination As String) As ScannerServiceResponse

            Dim serviceResponse As ScannerServiceResponse = Nothing
            Try
                Dim objSafetracSOAPBody As New SafetracSOAPBody()
                Dim objULDCreateHubInData As ULDCreateHubInData = New ULDCreateHubInData()
                objULDCreateHubInData.AP_CDE = Me.Station
                objULDCreateHubInData.CNTNR_ID = containerName
                objULDCreateHubInData.CNTNR_TYP_CDE = containerType
                objULDCreateHubInData.FLT_SCHED_DTM = departureDate.SqlDateFormat
                objULDCreateHubInData.FNL_DEST_AP_CDE = destinationName
                objULDCreateHubInData.OP_AL_CDE = flightNum.Substring(0, 2)
                objULDCreateHubInData.OP_FLT_NUM = flightNum.Substring(2)
                objULDCreateHubInData.HUB_AP_CDE = Me.Station
                objULDCreateHubInData.HUB_CARR_CDE = hubFlightNum.Substring(0, 2)
                objULDCreateHubInData.HUB_FLT_NUM = hubFlightNum.Substring(2)
                objULDCreateHubInData.HUB_FLT_SCHED_DTM = hubFlightDate.SqlDateFormat
                objULDCreateHubInData.REMARK = String.Empty
                Dim objULDCreate(0) As SafetracSOAPBodyULDCreate
                objULDCreate(0) = New SafetracSOAPBodyULDCreate
                objULDCreate(0).Item = objULDCreateHubInData
                objSafetracSOAPBody.Items = objULDCreate
                Dim strInput As String = Serialize(objSafetracSOAPBody)

                Me.AssignMessageID()
                Me.RequestType = DataSync.MessageHeaderTypeServiceType.G
                Me.RequestOperationType = MessageHeaderTypeRequestedOperationType.ULDCREATE
                Me.Body = Serialize(objSafetracSOAPBody)

                Dim objOutputSoapEnvelope As SafetracSOAPEnvelope _
                    = _objDataSyncService.PerformGeneralService(_objInputSoapEnvelope)

                serviceResponse = New ScannerServiceResponse(objOutputSoapEnvelope)

            Catch ex As Exception
                serviceResponse = New ScannerServiceResponse(ex)
            End Try
            Return serviceResponse
        End Function


        Public Sub Dipose()
            Try
                _objWebServices = Nothing
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Public Shared Function Serialize(ByVal safetracSoapObj As SafetracSOAPBody) As String
            Dim strOutput As String = String.Empty
            Try
                Dim objXmlSerializer As New Xml.Serialization.XmlSerializer(GetType(SafetracSOAPBody))
                Dim objWriter As New StringWriter()
                objXmlSerializer.Serialize(objWriter, safetracSoapObj)
                Dim ObjXMLDoc As New XmlDocument
                ObjXMLDoc.LoadXml(objWriter.ToString)
                strOutput = ObjXMLDoc.OuterXml
                strOutput = strOutput.Replace("UTF-16", "utf-8")
                strOutput = strOutput.Replace("utf-16", "utf-8")
            Catch ex As Exception
                Throw ex
            End Try
            Return strOutput
        End Function


    End Class

End Namespace
