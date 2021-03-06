
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.SyncManager
Imports NWA.Safetrac.Scanner.WebReferences


Namespace NWA.Safetrac.Scanner.BO

    Public Module LoginController

        Public Function PerformLogin(ByVal userID As String, ByVal password As String, _
              ByVal cityCode As String, ByVal hostSystem As String, ByVal IsTrainingMode As Boolean) As ReturnCodes

            Try
                'call performLDAPLogin webservice
                'pass the following parameters
                'UserId
                'HHT_ID
                'password
                'Airport code (station code from config file)
                'Departure station code (connecting server - MSP, DTW, TRN)
                'IsTrainingMode
                'AppVersion (from Check software version)

                Dim objScanner As Scanner = Scanner.GetInstance()
                Dim objWebServices As ScannerServices = ScannerServices.GetInstance()

                Logger.LogMessage("Before calling Login Webservice", LogType.Information, "LoginController.PerformLogin")

                Dim response As ScannerServiceResponse = objWebServices.PerformLDAPLogin(objScanner.DeviceName, _
                    userID, password, hostSystem, IsTrainingMode, objScanner.AppVersion)

                If response.IsSuccessful Then
                    'login successful

                    'set the default values to scanner
                    'pending - set the user name from webservice response
                    Dim strName As String = "LastName, FirstName"
                    'set the station name
                    objScanner.Station = cityCode
                    'set the user object
                    objScanner.CurrentUser = New User(userID, password, strName)
                    'set logged in flag
                    objScanner.CurrentUser.IsLoggedOn = True
                    'set flag whether the user is connected in training mode
                    objScanner.InTrainingMode = IsTrainingMode
                    'set the station type - pending
                    objScanner.StationType = StationType.Batch

                    'Add server application version to the cache
                    CacheManager.My("ServerAppVersion") = "1.2"

                    'set the default parameters to webservices
                    objWebServices.DeviceID = objScanner.DeviceName
                    objWebServices.Station = cityCode
                    objWebServices.UserID = userID
                    objWebServices.TrainingMode = IsTrainingMode

                    'start syncmanager
                    Dim syncInstance As SyncManager.SyncManager = SyncManager.SyncManager.GetSyncInstance()
                    syncInstance.InitSyncManager()
                    Return ReturnCodes.Ok

                Else
                    Return response.ReturnCode
                End If

            Catch safetracEx As SafetracException
                Logger.LogException(safetracEx)
                Throw safetracEx
            Catch ex As Exception
                Logger.LogException(ex)
            End Try

        End Function

        Public Function PerformLogoff() As Boolean

            Try

                Dim syncInstance As SyncManager.SyncManager = SyncManager.SyncManager.GetSyncInstance()
                'check is sync is completed
                If syncInstance.IsUploadSyncCompleted() = False Then
                    'perform forced sync
                    syncInstance.ForceSync(True)
                End If

                If syncInstance.ShutdownSyncManager() Then
                    Dim objScanner As Scanner = Scanner.GetInstance
                    objScanner.CurrentUser.IsLoggedOn = False
                    CacheManager.LastUser = objScanner.CurrentUser
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Logger.LogException(ex)
                Return False
            End Try

        End Function

        Public Function PerformAutoLogoff() As Boolean
            Try

                Dim syncInstance As SyncManager.SyncManager = SyncManager.SyncManager.GetSyncInstance()
                'check is sync is completed
                If syncInstance.IsUploadSyncCompleted() = False Then
                    'perform forced sync
                    syncInstance.ForceSync(True)
                End If

                If syncInstance.ShutdownSyncManager() Then
                    Dim objScanner As Scanner = Scanner.GetInstance
                    objScanner.CurrentUser.IsLoggedOn = False
                    CacheManager.LastUser = objScanner.CurrentUser
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Logger.LogException(ex)
                Return False
            End Try
        End Function

        Public Function ValidateWithLastLoggedUser(ByVal userID As String, ByVal password As String, _
              ByVal cityCode As String, ByVal hostSystem As String, ByVal IsTrainingMode As Boolean) As ReturnCodes

            Dim objLastUser As User = CacheManager.LastUser
            Dim objScanner As Scanner = Scanner.GetInstance

            If objLastUser IsNot Nothing Then
                If (objLastUser.UserID) = userID _
                And (objLastUser.Password = password) _
                And (objScanner.CityCode = cityCode) _
                And (objScanner.Station = hostSystem) _
                And (objScanner.InTrainingMode = IsTrainingMode) Then
                    Return ReturnCodes.Ok
                Else
                    Return ReturnCodes.LogonInvalid
                End If
            Else
                Return ReturnCodes.LogonInvalid
            End If

        End Function

    End Module

End Namespace