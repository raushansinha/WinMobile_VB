
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI

    Public Class frmViewHTTInformation

        Private Sub frmViewHTTPInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            RefreshHHTInformation()
            MyBase.SetHeader("HHT Registration Info")
        End Sub

        Private Sub cmdSetBacklight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetBacklight.Click
            Dim objDlgBacklightTime As New dlgSetBackLightTime()
            Logger.LogMessage("objDlgBacklightTime.ShowDialog()", LogType.Trace, "frmViewHTTPInfo.cmdSetBacklight_Click")
            objDlgBacklightTime.ShowDialog()
            RefreshHHTInformation()
        End Sub

        Private Sub frmViewHTTPInfo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Logger.LogMessage("GoToMainMenu", LogType.Trace, "frmViewHTTPInfo.frmViewHTTPInfo_KeyDown")
                MyBase.GoToMainMenu()
            End If
        End Sub

        Public Sub RefreshHHTInformation()
            Try
                lblHHT.Text = MyBase.Scanner.DeviceName
                lblUser.Text = MyBase.Scanner.CurrentUser.UserID
                lblFullName.Text = MyBase.Scanner.CurrentUser.UserName
                lblIP.Text = MyBase.Scanner.IPAddress
                lblCity.Text = MyBase.Scanner.CityCode
                If MyBase.Scanner.InTrainingMode = True Then
                    lblTraining.Text = "YES"
                Else
                    lblTraining.Text = "NO"
                End If

                lblBacklightTime.Text = MyBase.Reader.BacklightTime & " Minutes"
                lblVersion.Text = "v" & MyBase.Scanner.AppVersion.ToString
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub


    End Class
End Namespace
