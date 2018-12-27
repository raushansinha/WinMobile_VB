Imports NWA.Safetrac.Scanner.Utils
Namespace NWA.Safetrac.Scanner.UI
    Public Class frmVerifyClockMessage
        Private Sub frmVerifyClockMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            MyBase.SetHeader("**Verify Clock**")
            MyBase.HideFooter()

        End Sub

        Private Sub cmdLDDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLDDone.Click
            Logger.LogMessage("GoToMainMenu", LogType.Trace, "frmVerifyClockMessage.cmdLDDone_Click")
            MyBase.GoToMainMenu()
        End Sub

        Private Sub frmVerifyClockMessage_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If (e.KeyCode = Keys.Escape) Then
                Me.cmdLDDone_Click(Me, Nothing)
            End If

        End Sub

        Private Sub frmVerifyClockMessage_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            lblLDSuccessful.BackColor = Color.Black
        End Sub
    End Class
End Namespace