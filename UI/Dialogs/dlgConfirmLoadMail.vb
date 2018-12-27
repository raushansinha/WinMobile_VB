Namespace NWA.Safetrac.Scanner.UI
    Public Class dlgConfirmLoadMail

        Private Sub dlgConfirmLoadMail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            Select Case e.KeyCode
                Case Keys.Y
                    DialogResult = Windows.Forms.DialogResult.Yes
                    Me.Close()
                Case Keys.N
                    DialogResult = Windows.Forms.DialogResult.No
                    Me.Close()
            End Select
        End Sub

    End Class
End Namespace