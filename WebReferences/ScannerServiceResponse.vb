
Imports System.IO
Imports System.Data
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.WebReferences.J2EE

Namespace NWA.Safetrac.Scanner.WebReferences

    Public Class ScannerServiceResponse

        Private _dsResponse As DataSet = Nothing
        Private _blnIsSuccessful As Boolean = False
        Private _strReturnCode As String = String.Empty
        Private _strReturnMessage As String = String.Empty
        Private _returnCode As ReturnCodes = ReturnCodes.Unknown

        Public ReadOnly Property IsSuccessful() As Boolean
            Get
                Return _blnIsSuccessful
            End Get
        End Property

        Public ReadOnly Property Response() As DataSet
            Get
                Return _dsResponse
            End Get
        End Property

        Public ReadOnly Property ReturnMessage() As String
            Get
                Return _strReturnMessage
            End Get
        End Property

        Public ReadOnly Property ReturnCode() As ReturnCodes
            Get
                Return _returnCode
            End Get
        End Property

        Public ReadOnly Property ReturnCodeString() As String
            Get
                Return _strReturnCode
            End Get
        End Property

        Public Sub New(ByVal SoapResponse As DataSync.SafetracSOAPEnvelope)
            Try

                InitializeResponse(SoapResponse.body)

                If SoapResponse.returnCode = "1" Then
                    _blnIsSuccessful = True
                    _returnCode = ReturnCodes.Success
                    _strReturnMessage = String.Empty
                Else
                    _blnIsSuccessful = False
                    InitializeReturnCode(SoapResponse.errorCode)
                    _strReturnMessage = SoapResponse.errorMsg
                End If
            Catch ex As Exception
                _blnIsSuccessful = True
                _returnCode = ReturnCodes.Exception
            End Try
        End Sub

        Public Sub New(ByVal webResponse As String)
            Try
                InitializeResponse(webResponse)
                If _dsResponse.Tables("ERROR") Is Nothing Then
                    _blnIsSuccessful = True
                    _returnCode = ReturnCodes.Success
                Else
                    _blnIsSuccessful = False
                    _strReturnCode = _dsResponse.Tables("ERROR").Rows(0)("NUMBER")
                    _strReturnMessage = _dsResponse.Tables("ERROR").Rows(0)("ERRORCODE")
                End If
            Catch ex As Exception
                _blnIsSuccessful = True
                _returnCode = ReturnCodes.Exception
            End Try
        End Sub

        Public Sub New(ByVal exception As Exception)
            _blnIsSuccessful = False
            _returnCode = ReturnCodes.Exception
            _strReturnMessage = exception.ToString()
        End Sub

        Private Sub InitializeResponse(ByVal webResponse As String)
            Try
                Dim objStringReader As New StringReader(webResponse)
                _dsResponse = New DataSet
                _dsResponse.ReadXml(objStringReader)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Private Sub InitializeReturnCode(ByVal responseCode As String)
            Try
                Select Case responseCode
                    Case "SFT_CNT_1025"
                        _returnCode = ReturnCodes.ContainerAlreadyClosed
                    Case 0
                        _returnCode = ReturnCodes.BinBulkInvalid
                    Case 1
                    Case 2
                    Case Else
                        _returnCode = ReturnCodes.Unknown
                End Select
            Catch ex As Exception
                _returnCode = ReturnCodes.Unknown
            End Try
        End Sub

    End Class

End Namespace
