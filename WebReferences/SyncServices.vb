Imports System.Web.Services
Imports NWA.Safetrac.Scanner
Imports NWA.Safetrac.Scanner.WebReferences.J2EE.DataSync

Namespace NWA.Safetrac.Scanner.WebReferences

    Public Class SyncServices
        ''' <summary>
        ''' Sets the header and the body to invoke the webservice
        ''' </summary>
        ''' <remarks></remarks>

        Private _objDataSyn As New DataSyncService
        Private _objMessageRequestHdr As New MessageHeaderType
        Private _objOperationTypeValue As New MessageHeaderTypeRequestedOperationType
        Private _objOperationServiceType As New MessageHeaderTypeServiceType
        Private _objSOAPEnvelope As New SafetracSOAPEnvelope
        ''' <summary>
        ''' Invokes the webservices related to upload operations
        ''' </summary>
        ''' <returns>Error code</returns>
        ''' <remarks></remarks>
        Public Function InvokeUploadWebservice() As Int16
            Dim intReturnCode As Int16
            Try
                _objSOAPEnvelope.header = _objMessageRequestHdr
                _objSOAPEnvelope = _objDataSyn.PerformUploadService(_objSOAPEnvelope)
                intReturnCode = _objSOAPEnvelope.returnCode
                Return intReturnCode
            Catch ex As Exception
                Throw ex
            Finally
                intReturnCode = Nothing
            End Try

        End Function
        ''' <summary>
        ''' Invokes the webservices related to the dowload operations
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function InvokeDownloadWebservice() As Int16
            Dim intReturnCode As Int16
            Try
                _objSOAPEnvelope.header = _objMessageRequestHdr
                _objSOAPEnvelope = _objDataSyn.PerformDownloadService(_objSOAPEnvelope)
                intReturnCode = _objSOAPEnvelope.returnCode
                Return intReturnCode
            Catch ex As Exception
                Throw ex
            Finally
                intReturnCode = Nothing
            End Try

        End Function
        ''' <summary>
        ''' Set the HHTID for request header
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public WriteOnly Property DeviceID() As String
            Set(ByVal value As String)
                _objMessageRequestHdr.hhtID = value
            End Set
        End Property
        ''' <summary>
        ''' Set the Dept station for request header
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public WriteOnly Property DeptStation() As String
            Set(ByVal value As String)
                _objMessageRequestHdr.deprStationCode = value
            End Set
        End Property
        ''' <summary>
        ''' Set the Training mode for request header
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public WriteOnly Property TrainingMode() As String
            Set(ByVal value As String)
                _objMessageRequestHdr.isTrainingMode = "Y"
            End Set
        End Property
        ''' <summary>
        ''' Set the operation type for request header
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public WriteOnly Property ServiceID() As Byte
            Set(ByVal value As Byte)
                Select Case value
                    Case Is = 1
                        _objMessageRequestHdr.serviceType = MessageHeaderTypeServiceType.U
                    Case Is = 2
                        _objMessageRequestHdr.serviceType = MessageHeaderTypeServiceType.D
                    Case Is = 3
                        _objMessageRequestHdr.serviceType = MessageHeaderTypeServiceType.G
                    Case Else
                        'log message invalid type
                        'WebServiceInstance
                End Select
            End Set
        End Property
        ''' <summary>
        ''' Set the operation sub type for request header
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public Property CommodityType() As String
            Get
                Return _objMessageRequestHdr.requestedOperationType
            End Get
            Set(ByVal value As String)
                Select Case value
                    Case Is = "BAGS"
                        _objMessageRequestHdr.requestedOperationType = MessageHeaderTypeRequestedOperationType.BAGS
                    Case Is = "FLIGHT"
                        _objMessageRequestHdr.requestedOperationType = MessageHeaderTypeRequestedOperationType.FLIGHT
                    Case Is = "AIRCRAFT"
                        _objMessageRequestHdr.requestedOperationType = MessageHeaderTypeRequestedOperationType.AIRCRAFTCONFIG
                    Case Is = "AIRLINECODE"
                        _objMessageRequestHdr.requestedOperationType = MessageHeaderTypeRequestedOperationType.AIRLINECODE
                    Case Is = "ERRORCODES"
                        _objMessageRequestHdr.requestedOperationType = MessageHeaderTypeRequestedOperationType.ERRORCODES
                    Case Is = "FREIGHT"
                        _objMessageRequestHdr.requestedOperationType = MessageHeaderTypeRequestedOperationType.FREIGHT
                    Case Is = "LINEITEM"
                        _objMessageRequestHdr.requestedOperationType = MessageHeaderTypeRequestedOperationType.LINEITEM
                    Case Is = "MAIL"
                        _objMessageRequestHdr.requestedOperationType = MessageHeaderTypeRequestedOperationType.MAIL
                    Case Is = "PASSENGER"
                        _objMessageRequestHdr.requestedOperationType = MessageHeaderTypeRequestedOperationType.PASSENGERCONFIG
                    Case Is = "ULD"
                        _objMessageRequestHdr.requestedOperationType = MessageHeaderTypeRequestedOperationType.ULD
                    Case Else
                        _objMessageRequestHdr.requestedOperationType = Nothing
                End Select
            End Set
        End Property
        ''' <summary>
        ''' Get / Set the body of the WebService
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MessageBody() As String
            Get
                Return _objSOAPEnvelope.body
            End Get
            Set(ByVal value As String)
                _objSOAPEnvelope.body = value
            End Set
        End Property
        ''' <summary>
        ''' Get the return code from response header
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property ReturnCode() As Int16
            Get
                Return _objSOAPEnvelope.returnCode
            End Get
        End Property
        ''' <summary>
        ''' Get the load status from response header
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property LoadStatus() As String
            Get
                Return _objSOAPEnvelope.loadStatus
            End Get
        End Property
        ''' <summary>
        ''' Get the Error ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property ErrorCode() As String
            Get
                Return _objSOAPEnvelope.errorCode
            End Get
        End Property
        ''' <summary>
        ''' Get the load status from response header
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property ErrorMessage() As String
            Get
                Return _objSOAPEnvelope.errorMsg
            End Get
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="DevID"></param>
        ''' <param name="DeptStnCode"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function SetDeviceIDAndStationCode(ByVal devID As String, ByVal deptStnCode As String) As Boolean
            DeviceID = devID
            DeptStation = deptStnCode
        End Function
        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        Public Sub New()
        End Sub
    End Class
End Namespace