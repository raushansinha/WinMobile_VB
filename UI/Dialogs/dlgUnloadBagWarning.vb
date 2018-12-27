
Namespace NWA.Safetrac.Scanner.UI

    Public Class dlgUnloadBagWarning

        Private Sub dlgUnloadBagWarning_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If

        End Sub
    End Class

End Namespace

