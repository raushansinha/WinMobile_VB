Imports NWA.Safetrac.Scanner.BO
Namespace NWA.Safetrac.Scanner.UI

    Public Class dlgBagOnAlert
        Private Sub dlgBagOnAlert_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            Select Case e.KeyCode
                Case Keys.D1, Keys.A
                    ' for Loading bag on alert.
                    DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Case Keys.D3, Keys.C
                    DialogResult = Windows.Forms.DialogResult.Cancel
                    Me.Close()
            End Select
        End Sub
    End Class
End Namespace
