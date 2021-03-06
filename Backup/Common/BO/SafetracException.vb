Namespace NWA.Safetrac.Scanner.BO
    ''' <summary>
    ''' Represents an Safetrac Exception
    ''' </summary>
    ''' <remarks></remarks>
    Public Class SafetracException
        Inherits System.Exception

        Private _errorCode As ReturnCodes = ReturnCodes.Unknown
        Private _strSource As String = String.Empty

        ''' <summary>
        ''' Error code of the Safetrac Exception
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly Property ErrorCode() As ReturnCodes
            Get
                Return _errorCode
            End Get
        End Property
        Public ReadOnly Property Source() As String
            Get
                Return _strSource
            End Get
        End Property
        Public Sub New(ByVal errorCode As ReturnCodes)
            MyBase.New()
            _strSource = String.Empty
            _errorCode = errorCode
        End Sub
        Public Sub New(ByVal errorCode As ReturnCodes, ByVal errorMessage As String)
            MyBase.New(errorMessage)
            _errorCode = errorCode
        End Sub
        Public Sub New(ByVal errorCode As ReturnCodes, ByVal errorMessage As String, ByVal source As String)
            MyBase.New(errorMessage)
            _strSource = source
            _errorCode = errorCode
        End Sub
        Public Sub New(ByVal errorCode As ReturnCodes, ByVal errorMessage As String, ByVal source As String, _
                    ByVal innerException As Exception)
            MyBase.New(errorMessage, innerException)
            _strSource = source
            _errorCode = errorCode
        End Sub
        Public Overrides Function ToString() As String
            Return _errorCode.ToString() & " : " & MyBase.Message
        End Function
    End Class
End Namespace