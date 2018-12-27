
Namespace NWA.Safetrac.Scanner.UI

    Public Class dlgNoNetworkPrompt

        Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
            Me.Close()
        End Sub

        Private Sub dlgNoNetworkPrompt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        End Sub

    End Class

End Namespace