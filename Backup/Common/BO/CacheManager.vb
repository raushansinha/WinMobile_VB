Imports System.Collections.Generic

Namespace NWA.Safetrac.Scanner.BO

    ''' <summary>
    ''' Represents the Global Cache for the application
    ''' </summary>
    ''' <remarks></remarks>
    Public Module CacheManager

        Private _diCache As New Dictionary(Of String, Object)
        Private _scanMode As ScanModes
        Private _mailType As MailTypes
        Private _bagType As BagTypes
        Private _freightType As FreightTypes
        Private _dateLastActionTime As Date
        Private _strExpediteCode As String
        Private _objLastUser As User

        Public Property ExpediteCode() As String
            Get
                Return _strExpediteCode
            End Get
            Set(ByVal value As String)
                _strExpediteCode = value
            End Set
        End Property

        ''' <summary>
        ''' Holds last bag scan mode
        ''' </summary>
        ''' <remarks></remarks>
        Public Property BagScanMode() As ScanModes
            Get
                Return _scanMode
            End Get
            Set(ByVal value As ScanModes)
                _scanMode = value
            End Set
        End Property
        ''' <summary>
        ''' Holds last mail type
        ''' </summary>
        ''' <remarks></remarks>
        Public Property LastMailType() As MailTypes
            Get
                Return _mailType
            End Get
            Set(ByVal value As MailTypes)
                _mailType = value
            End Set
        End Property
        ''' <summary>
        ''' Holds last bag type
        ''' </summary>
        ''' <remarks></remarks>
        Public Property LastBagType() As BagTypes
            Get
                Return _bagType
            End Get
            Set(ByVal value As BagTypes)
                _bagType = value
            End Set
        End Property
        ''' <summary>
        ''' Holds last freight type
        ''' </summary>
        ''' <remarks></remarks>
        Public Property LastFreightType() As FreightTypes
            Get
                Return _freightType
            End Get
            Set(ByVal value As FreightTypes)
                _freightType = value
            End Set
        End Property
        ''' <summary>
        ''' Holds last user action time
        ''' </summary>
        ''' <remarks></remarks>
        Public Property LastUserActionTime() As Date
            Get
                Return _dateLastActionTime
            End Get
            Set(ByVal value As Date)
                _dateLastActionTime = value
            End Set
        End Property

        Public Property LastUser() As User
            Get
                Return _objLastUser
            End Get
            Set(ByVal value As User)
                _objLastUser = value
            End Set
        End Property


        ''' <summary>
        ''' Add a Key Value pair to the Cache
        ''' </summary>
        ''' <param name="KeyName"></param>
        ''' <param name="Value"></param>
        ''' <remarks></remarks>
        Private Sub Add(ByVal keyName As String, ByVal value As Object)
            _diCache.Add(keyName, value)
        End Sub
        ''' <summary>
        ''' Remove an existing Key Value pair from the Cache
        ''' </summary>
        ''' <param name="KeyName"></param>
        ''' <remarks></remarks>
        Public Sub Remove(ByVal KeyName As String)
            _diCache.Remove(KeyName)
        End Sub
        Public Function ContainsKey(ByVal keyName As String) As Boolean
            Return _diCache.ContainsKey(keyName)
        End Function
        Public Function ContainsValue(ByVal value As Object) As Boolean
            Return _diCache.ContainsValue(value)
        End Function
        Public Property My(ByVal keyName As String) As Object
            Get
                If _diCache.ContainsKey(keyName) Then
                    Return _diCache(keyName)
                Else
                    Return Nothing
                End If
            End Get
            Set(ByVal value As Object)
                If _diCache.ContainsKey(keyName) Then
                    _diCache(keyName) = value
                Else
                    Add(keyName, value)
                End If
            End Set
        End Property

        ''' <summary>
        ''' Update last user action time to cache
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub UpdateUserActionTime()
            _dateLastActionTime = Date.Now
        End Sub

        Sub New()
            UpdateUserActionTime()
        End Sub

        '''' <summary>
        '''' Get Last user
        '''' </summary>
        '''' <returns></returns>
        '''' <remarks></remarks>
        'Public Function GetLastUser() As User
        '    Return Nothing
        'End Function

    End Module

End Namespace

