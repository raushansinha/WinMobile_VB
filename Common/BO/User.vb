Namespace NWA.Safetrac.Scanner.BO
    Public Class User

        Private _strUserID As String
        Private _strPassword As String
        Private _strUserName As String
        Private _blnIsLoggedOn As Boolean

        Public ReadOnly Property UserID() As String
            Get
                Return _strUserID
            End Get
            'Set(ByVal value As String)
            '    _strUserID = value
            'End Set
        End Property

        Public ReadOnly Property Password() As String
            Get
                Return _strPassword
            End Get
            'Set(ByVal value As String)
            '    _strPassword = value
            'End Set
        End Property

        Public ReadOnly Property UserName() As String
            Get
                Return _strUserName
            End Get
            'Set(ByVal value As String)
            '    _strUserName = value
            'End Set
        End Property

        Public Property IsLoggedOn() As Boolean
            Get
                Return _blnIsLoggedOn
            End Get
            Set(ByVal value As Boolean)
                _blnIsLoggedOn = value
            End Set
        End Property

        Public Sub New(ByVal userId As String, ByVal password As String, ByVal userName As String)
            _strUserID = userId
            _strPassword = password
            _strUserName = userName
        End Sub

        Public Shared Function ValidateUsers(ByVal user1 As User, ByVal user2 As User) As Boolean
            If user1.UserID = user2.UserID _
            And user1.Password = user2.Password _
            And user1.UserName = user2.UserName _
            Then
                Return True
            Else
                Return False
            End If
        End Function

    End Class

End Namespace

