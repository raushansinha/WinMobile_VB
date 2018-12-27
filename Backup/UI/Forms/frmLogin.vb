
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmLogin

        Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try

                'Hide the status panel of base form
                MyBase.Reader.SetCapsLock()
                MyBase.HideStatusPanel()
                MyBase.HideFooter()

                MyBase.ShowControl(imgWelCome)
                lblHagent.Text = ConfigManager.HAgent
                lblStation.Text = ConfigManager.ProductionStation
                lblLoginMain.Text = "[" & ConfigManager.HHTId & "] Login"
                lblAppVersion.Text = "v" & Scanner.AppVersion

                'Setup combobox: Add production name, training name
                cmbSystem.Items.Clear()
                cmbSystem.Items.Add(ConfigManager.ProductionStation)
                cmbSystem.Items.Add(ConfigManager.TrainingStationName)
                cmbSystem.SelectedIndex = 0

                MyBase.Reader.Disable()

                txtUser.Text = String.Empty
                txtPassword.Text = String.Empty
                MyBase.SetFocus(txtUser)
                Me.Refresh()

                'test code - will be deleted later - pending
                'MyBase.FlightsCollection.AddTestFlight("NW1232", New NWADateTime(Date.Now))
                'MyBase.FlightsCollection.AddTestFlight("NW1231", New NWADateTime(Date.Now))
                MyBase.FlightsCollection.AddTestFlight("NW1154", New NWADateTime(Date.Now))
                MyBase.FlightsCollection.AddTestFlight("NW0574", New NWADateTime(Date.Now))
                txtUser.Text = "n48366"
                txtPassword.Text = "wip@123"
                cmdLogin_Click(Me, Nothing)

            Catch ex As Exception
                'For testing purposes only - will be deleted later
                MessageBox.Show(ex.ToString)
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub txtUser_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.GotFocus
            MyBase.SetFocus(txtUser)
        End Sub

        Private Sub txtPassword_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
            MyBase.SetFocus(txtPassword)
        End Sub

        Private Sub cmbSystem_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSystem.KeyDown
            'If Enter is pressed, run login
            If e.KeyCode = Keys.Enter Then
                cmdLogin_Click(Me, Nothing)
            End If
        End Sub

        Private Sub txtUser_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUser.KeyDown
            If e.KeyCode = Keys.Enter Then
                cmdLogin_Click(Me, Nothing)
            End If
        End Sub

        Private Sub txtPassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
            'If Enter is pressed, run login
            If e.KeyCode = Keys.Enter Then
                cmdLogin_Click(Me, Nothing)
            End If
        End Sub

        Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
            Dim strLog = String.Empty
            If MyBase.IsErrorEnabled Then
                MyBase.ClearError()
                Exit Sub
            End If

            Dim strUserId As String = txtUser.Text.Trim.ToUpper
            Dim strPassword As String = txtPassword.Text.Trim.ToUpper

            If strUserId = String.Empty Then
                MyBase.SetError("Enter User ID")
                Exit Sub
            End If

            If strPassword = String.Empty Then
                If Not strUserId = BOConstants.LoginVersionUserId Then
                    MyBase.SetError("Enter Password ID")
                    Exit Sub
                End If
            End If

            Logger.LogMessage("user login1=" & strUserId, LogType.Information, "frmLogin.cmdLogin_Click1")
            Logger.LogMessage("user login2=" & strUserId, LogType.Information, "frmLogin.cmdLogin_Click2")

            'check is version user login
            If strUserId = BOConstants.LoginVersionUserId Then
                Dim objVersion As New dlgVersion()
                objVersion.ShowDialog()
                txtUser.Text = String.Empty
                Exit Sub
                'check if its admin login
            ElseIf strUserId = BOConstants.LoginAdminUserId And strPassword = BOConstants.LoginAdminPassword Then
                Dim objHHTConfig As New frmViewHHTConfiguration()
                objHHTConfig.ShowDialog()
                Exit Sub
                'checkk if its autoconfig login
            ElseIf strUserId = BOConstants.LoginAutoConfigUserId And strPassword = BOConstants.LoginAutoConfigPassword Then
                Try
                    MyBase.Scanner.AutoConfigure()
                Catch ex As Exception
                    Logger.LogException(ex)
                    Dim objErrorDlg As New dlgError(String.Empty, ex.Message)
                    objErrorDlg.ShowDialog()
                End Try

                'Reference Code - Will be deleted later
                'Select Case iRet
                'Case AUTOCF_OK
                '    ' gDolphUtil.PerformWarmReboot
                '    Call PerformWarmBoot()
                'Case AUTOCF_FILE_MISSING
                '    ShowError("NO CONFIG FILE", "Config file missing", "Tried to read file, but it is missing.")
                'Case AUTOCF_SN_NOTFOUND
                '    ShowError("SERIAL UNKNOWN", "Serial number error", "Serial number does not match config file.")
                'Case AUTOCF_FILE_ERROR
                '    ShowError("AUTOCONFIG", "File Error", "An error was encountered when using config file.")
                'Case AUTOCF_WS_ERROR
                '    ShowError("AUTOCONFIG", "Cannot contact server", "Config settings could not be retrieved.")
                'Case AUTOCF_WS_NODATA
                '    ShowError("AUTOCONFIG", "No Data Returned", "Server is available, but no data came back.")
                'Case AUTOCF_WS_SN_NOTFOUND
                '    ShowError("AUTOCONFIG", "Serial Number Error", "Serial number is not in database.")
                'End Select
                'Exit Sub
                'check if auto configuration is required
            ElseIf ConfigManager.HHTId = Nothing Or ConfigManager.HHTId = String.Empty Then
                MessageBox.Show("Please rerun autoconfig. If problem persists, please contact the helpdesk.", _
                "Scanner not configured", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txtUser.Text = "AUTO"
                txtPassword.Text = "CONFIG"
                MyBase.SetFocus(txtUser)
            ElseIf strUserId = "DEV" And strPassword = "DEV" Then
                Dim strName As String = "LastName, FirstName"
                MyBase.Scanner.Station = CityCode
                MyBase.Scanner.CurrentUser = New User("DEV", "DEV", strName)
                MyBase.Scanner.CurrentUser.IsLoggedOn = True
                MyBase.Scanner.InTrainingMode = True
                MyBase.Scanner.StationType = StationType.Batch
                CacheManager.My("ServerAppVersion") = "1.2"
                InitSyncManager()
                MyBase.GoToMainMenu()
            Else
                Dim blnTrainingMode As Boolean
                Dim strStation As String
                Dim returnCode As ReturnCodes

                MyBase.ShowControl(fraWait)

                strStation = cmbSystem.SelectedItem.ToString

                If strStation = ConfigManager.ProductionStation Then
                    blnTrainingMode = False
                ElseIf strStation = ConfigManager.TrainingStationName Then
                    blnTrainingMode = True
                End If

                Try

                    Logger.LogMessage("Calling PerformLogin webservice ", LogType.Information, "frmLogin.cmdLogin_Click")

                    If NWA.Safetrac.Scanner.Communication.ConnectionManager.IsConnected Then
                        returnCode = LoginController.PerformLogin(strUserId, strPassword, ConfigManager.CityCode, _
                                    strStation, blnTrainingMode)
                        'if ldap loging not successful, validate with the last logged user
                        If returnCode <> ReturnCodes.Ok Then

                            strLog = String.Format("Before ValidateWithLastLoggedUser UserId={0}, Password={1} , CityCode={2}, Station={3}, TrainingMode={4} ", strUserId, strPassword, ConfigManager.CityCode, strStation, blnTrainingMode)
                            Logger.LogMessage(strLog, LogType.Information, "frmLogin.cmdLogin_Click")

                            returnCode = LoginController.ValidateWithLastLoggedUser(strUserId, strPassword, _
                                        ConfigManager.CityCode, strStation, blnTrainingMode)

                            strLog = String.Format("After ValidateWithLastLoggedUser ReturnCode = {0}", returnCode.ToString())
                            Logger.LogMessage(strLog, LogType.Information, "frmLogin.cmdLogin_Click")

                        End If
                    End If

                    Logger.LogMessage("After PerformLogin ReturnCode=" & returnCode, LogType.Information, "frmLogin.cmdLogin_Click")


                    MyBase.HideControl(fraWait)

                    Select Case returnCode
                        Case ReturnCodes.Ok
                            Try
                                Logger.LogMessage("Login successful", LogType.Information, "frmLogin.cmdLogin_Click")
                                'display welcome dialog with user name
                                lblName.Text = MyBase.Scanner.CurrentUser.UserName

                                MyBase.ShowControl(fraWelcome)

                                Me.InitSyncManager()

                                'sync up time
                                MyBase.Scanner.SyncTime()

                                'upload log files to FTP server
                                Logger.UploadLogFiles()
                                Logger.LogMessage("Uploading files successful", LogType.Information, "frmLogin.cmdLogin_Click")

                                'all successful - go to main menu
                                MyBase.HideControl(fraWelcome)

                                MyBase.GoToMainMenu()

                            Catch ex As Exception
                                'for testing purpose only - will be deleted later
                                MessageBox.Show(ex.ToString)
                                Logger.LogException(ex)
                            End Try
                        Case ReturnCodes.NotAuthorized
                            MyBase.SetError("NOT AUTHORIZED")
                        Case ReturnCodes.DatabaseError
                            MyBase.SetError("DATABASE ERROR")
                        Case ReturnCodes.LogonInvalid
                            MyBase.SetError("INVALID LOGIN")
                            MyBase.SetFocus(txtUser)
                            txtUser.Text = "DEV"
                            txtPassword.Text = "DEV"
                            MyBase.ClearError()
                            cmdLogin_Click(Me, Nothing)
                        Case ReturnCodes.HHTNotInPack
                            MyBase.SetError("HHT NOT IN PACK")
                        Case ReturnCodes.HHTNotAssigned
                            MyBase.SetError("PACK NOT ASSIGNED")
                        Case ReturnCodes.FrontEndError
                            MyBase.SetError("FRONTEND ERROR")
                        Case ReturnCodes.HHTInvalid
                            MyBase.SetError("UNKNOWN HHT ID")
                    End Select
                Catch ex As Exception
                    MyBase.HideControl(fraWait)
                    MessageBox.Show(ex.ToString)
                    Logger.LogException(ex)
                End Try
                Exit Sub
            End If

        End Sub

        Public Function InitSyncManager() As Boolean
            'Dim syncInstance As SyncManager.SyncManager = SyncManager.SyncManager.GetSyncInstance()
            'Return (syncInstance.InitSyncManager())
        End Function


        Private Sub cmdLogin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmdLogin.KeyDown
            If e.KeyCode = Keys.Enter Then
                cmdLogin_Click(Me, Nothing)
            End If
        End Sub
    End Class
End Namespace