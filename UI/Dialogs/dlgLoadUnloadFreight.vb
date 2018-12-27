
Imports NWA.Safetrac.Scanner.BO

Namespace NWA.Safetrac.Scanner.UI

    Public Class dlgLoadUnloadFreight

        Private Sub cmdLoadFrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadFrt.Click
            UIController.CurrentFunction = SafetracFunction.LoadBagIntoBinBulk
            Me.Close()
        End Sub

        Private Sub cmdUnloadFrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnloadFrt.Click
            UIController.CurrentFunction = SafetracFunction.UnloadFreight
            Me.Close()
        End Sub

        Private Sub dlgLoadUnloadFreight_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.D1 Then
                cmdLoadFrt_Click(Me, Nothing)
            ElseIf e.KeyCode = Keys.D3 Then
                cmdUnloadFrt_Click(Me, Nothing)
            End If
        End Sub

        Private Sub fraFrt_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraFrt.GotFocus

        End Sub

        Private Sub dlgLoadUnloadFreight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace