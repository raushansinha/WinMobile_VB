Namespace NWA.Safetrac.Scanner.UI
    Public Class dlgConfirmExpedite
        Private Sub dlgExpediteAWB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            Select Case e.KeyCode
                Case Keys.Y, Keys.Enter
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Case Keys.Escape
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Me.Close()
                Case Else
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Me.Close()
            End Select
        End Sub

        Private Sub dlgConfirmExpedite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If UIController.CurrentFunction = BO.SafetracFunction.LoadBagIntoBinBulk Or _
            UIController.CurrentFunction = BO.SafetracFunction.LoadBagToContainer Then
                lblHeader.Text = "EXPEDITE THIS BAG?"
            Else
                'pending - verify this condition
                lblHeader.Text = "EXPEDITE THIS AWB?"
            End If
        End Sub
    End Class
End Namespace
