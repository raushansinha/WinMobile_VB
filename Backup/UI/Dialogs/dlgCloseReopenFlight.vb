Namespace NWA.Safetrac.Scanner.UI
    Public Class dlgCloseReopenFlight

        Private Sub cmdCloseFlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloseFlt.Click
            UIController.CurrentFunction = BO.SafetracFunction.CloseFlight
            Me.Close()
        End Sub

        Private Sub cmdReopenFlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReopenFlt.Click
            UIController.CurrentFunction = BO.SafetracFunction.ReopenFlight
            Me.Close()
        End Sub

        Private Sub dlgCloseReopenFlight_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
            If e.KeyCode = Keys.D1 Then
                Me.cmdCloseFlt_Click(Me, Nothing)
            End If
            If e.KeyCode = Keys.D3 Then
                Me.cmdReopenFlt_Click(Me, Nothing)
            End If
        End Sub

        Private Sub dlgCloseReopenFlight_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            lblHeader.BackColor = Color.Black
        End Sub
    End Class
End Namespace