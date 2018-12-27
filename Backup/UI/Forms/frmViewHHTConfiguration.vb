Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Namespace NWA.Safetrac.Scanner.UI

    Public Class frmViewHHTConfiguration

        Private Sub frmViewHHTConfiguration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                MyBase.HideStatusPanel()
                MyBase.ShowControl(tabWebserverPage)
                txtHHTId.Text = ConfigManager.HHTId
                txtProdStation.Text = ConfigManager.ProductionStation
                txtTrainingStation.Text = ConfigManager.TrainingStation
                txtHagent.Text = ConfigManager.HAgent
                txtWebserver1.Text = ConfigManager.J2EEServer
                txtWebserver2.Text = ConfigManager.NETServer
                txtFTPServer.Text = ConfigManager.FTPServerIPAddress
                txtFTPPort.Text = ConfigManager.FTPServerPort
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            Try
                If MessageBox.Show("Are you sure you want to update these settings?", _
                    "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                    MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                    If Not txtHHTId.Text.Trim = ConfigManager.HHTId Then
                        ConfigManager.HHTId = txtHHTId.Text.Trim.ToUpper
                        txtHHTId.Text = ConfigManager.HHTId
                    End If
                    If Not txtProdStation.Text.Trim = ConfigManager.ProductionStation Then
                        ConfigManager.ProductionStation = txtProdStation.Text.Trim.ToUpper
                        txtProdStation.Text = ConfigManager.ProductionStation
                    End If
                    If Not txtTrainingStation.Text.Trim = ConfigManager.TrainingStation Then
                        ConfigManager.TrainingStation = txtTrainingStation.Text.Trim.ToUpper
                        txtTrainingStation.Text = ConfigManager.TrainingStation
                    End If
                    If Not txtHagent.Text.Trim = ConfigManager.HAgent Then
                        ConfigManager.HAgent = txtHagent.Text.Trim.ToUpper
                        Scanner.HAGENTCode = txtHagent.Text.Trim.ToUpper
                        txtHagent.Text = ConfigManager.HAgent
                    End If
                    If Not txtWebserver1.Text.Trim = ConfigManager.J2EEServer Then
                        ConfigManager.J2EEServer = txtWebserver1.Text.Trim.ToUpper
                        txtWebserver1.Text = ConfigManager.J2EEServer
                    End If
                    If Not txtWebserver2.Text.Trim = ConfigManager.NETServer Then
                        ConfigManager.NETServer = txtWebserver2.Text.Trim.ToUpper
                        txtWebserver2.Text.Trim.ToUpper()
                    End If
                    If Not txtFTPServer.Text.Trim = ConfigManager.FTPServerIPAddress Then
                        ConfigManager.FTPServerIPAddress = txtFTPServer.Text.Trim.ToUpper
                    End If
                    If Not txtFTPPort.Text.Trim = ConfigManager.FTPServerPort Then
                        ConfigManager.FTPServerPort = txtFTPPort.Text.Trim.ToUpper
                    End If
                    MessageBox.Show("Settings changed", "Done")
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub frmViewHHTConfiguration_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        End Sub

    End Class
End Namespace
