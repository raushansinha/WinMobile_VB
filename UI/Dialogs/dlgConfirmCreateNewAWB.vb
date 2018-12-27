Namespace NWA.Safetrac.Scanner.UI
    Public Class dlgConfirmCreateNewAWB

        Private Sub dlgCreateAWB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If UCase(e.KeyCode) = Keys.Y Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If
        End Sub
    End Class
End Namespace

