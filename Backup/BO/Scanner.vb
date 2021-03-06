Imports System.IO
Imports System.Data
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.Hardware
Imports NWA.Safetrac.Scanner.WebReferences
Imports System.Net

Namespace NWA.Safetrac.Scanner.BO

    Public Class Scanner
        Private _strDeviceName As String
        Private _strIPAddress As String
        Private _blnInTrainingMode As Boolean
        Private _strCityCode As String
        Private _strStation As String
        Private _strJ2EEWebserver As String
        Private _strNETWebserver As String
        Private _strHAGENTCode As String
        Private _stationType As StationType
        Private _appVersion As Version
        Private _strAppVersion As String
        Private _objCurrentUser As User
        Private Shared _objScanner As Scanner

        Public Shared Function GetInstance() As Scanner
            If _objScanner Is Nothing Then
                _objScanner = New Scanner
            End If
            Return _objScanner
        End Function

        Private Sub New()
            Try
                _appVersion = System.Reflection.Assembly.GetCallingAssembly.GetName.Version
                _strAppVersion = _appVersion.Major.ToString() & "." & _appVersion.Minor.ToString()
                _strDeviceName = ConfigManager.HHTId
                _strHAGENTCode = ConfigManager.HAgent
                _strCityCode = ConfigManager.CityCode
                _strStation = String.Empty
                _strJ2EEWebserver = ConfigManager.J2EEServer
                _strNETWebserver = ConfigManager.NETServer
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Property DeviceName() As String
            Get
                Return _strDeviceName
            End Get
            Set(ByVal value As String)
                _strDeviceName = value
            End Set
        End Property
        Public ReadOnly Property IPAddress() As String
            Get
                Return Dns.GetHostEntry(Dns.GetHostName).AddressList.GetValue(0).ToString()
            End Get
        End Property
        Public Property InTrainingMode() As Boolean
            Get
                Return _blnInTrainingMode
            End Get
            Set(ByVal value As Boolean)
                _blnInTrainingMode = value
            End Set
        End Property
        Public Property CityCode() As String
            Get
                Return _strCityCode
            End Get
            Set(ByVal value As String)
                _strCityCode = value
            End Set
        End Property

        'Public ReadOnly Property AppVersion() As Version
        '    Get
        '        Return _appVersion
        '    End Get
        'End Property

        Public ReadOnly Property AppVersion() As String
            Get
                Return _strAppVersion
            End Get
        End Property

        Public Property Station() As String
            Get
                Return _strStation
            End Get
            Set(ByVal value As String)
                _strStation = value
            End Set
        End Property
        Public Property J2EEWebserver() As String
            Get
                Return _strJ2EEWebserver
            End Get
            Set(ByVal value As String)
                _strJ2EEWebserver = value
            End Set
        End Property
        Public Property NETWebserver() As String
            Get
                Return _strNETWebserver
            End Get
            Set(ByVal value As String)
                _strNETWebserver = value
            End Set
        End Property
        Public Property HAGENTCode() As String
            Get
                Return _strHAGENTCode
            End Get
            Set(ByVal value As String)
                _strHAGENTCode = value
            End Set
        End Property

        Public Property StationType() As StationType
            Get
                Return _stationType
            End Get
            Set(ByVal value As StationType)
                _stationType = value
            End Set
        End Property

        Public Property CurrentUser() As User
            Get
                Return _objCurrentUser
            End Get
            Set(ByVal value As User)
                If _objCurrentUser IsNot Nothing Then
                    CacheManager.LastUser = _objCurrentUser
                    _objCurrentUser = Nothing
                End If
                _objCurrentUser = value
            End Set
        End Property

        Public Function IsAutoConfigNeeded() As Boolean
            If ConfigManager.SerialNumber = Nothing _
                Or ConfigManager.HHTId = Nothing _
                Or ConfigManager.NetName = Nothing _
                Or ConfigManager.ProductionStation = Nothing Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function SyncTime() As Boolean
            Dim blnResult As Boolean = False
            Try
                Dim services As ScannerServices = ScannerServices.GetInstance()
                Dim serverDateTime As Date = services.GetSyncTime()
                Dim objPsion7535 As Psion7535
                objPsion7535 = Psion7535.GetInstance()
                objPsion7535.DateTime = serverDateTime
                blnResult = True
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
            Return blnResult
        End Function

        Public Function AutoConfigure() As ReturnCodes
            Dim retCode As ReturnCodes
            Try
                Dim objWebServices As ScannerServices = ScannerServices.GetInstance()
                Dim response As ScannerServiceResponse = objWebServices.GetLanSettings()

                If response.Response.Tables.Count > 1 Then
                    Throw New Exception(response.Response.Tables("ERROR").Rows(0)("MESSAGE").ToString)
                    'pending - include return codes
                End If

                Dim dataRow As DataRow = response.Response.Tables("GETLANSETTINGS").Rows(0)
                ConfigManager.HHTId = dataRow("HHTID").ToString
                ConfigManager.NetName = dataRow("NETNAME").ToString()
                ConfigManager.ProductionStation = dataRow("STATION").ToString()
                ConfigManager.TrainingStation = dataRow("TRAININGCITYDATA").ToString()
                ConfigManager.J2EEServer = dataRow("WEBSERVER").ToString()
                retCode = ReturnCodes.Ok

            Catch ex As Exception
                Logger.LogException(ex)
                retCode = ReturnCodes.Unknown
            End Try
            Return retCode
        End Function

        Public Sub Dispose()
            _objScanner = Nothing
        End Sub

    End Class
End Namespace