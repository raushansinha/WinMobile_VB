Imports NWA.Safetrac.Scanner.BO

Namespace NWA.Safetrac.Scanner.UI

    Public Class frmMailType

        Private Sub cmbTypes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTypes.KeyDown
            If e.KeyCode = Keys.Escape Then
                MyBase.GoToMainMenu()
                Me.Close()
            End If
            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                Else
                    cmdContinue_Click(sender, e)
                End If
            End If
        End Sub

        Private Sub cmdContinue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinue.Click
            Try

                UIController.NextForm = New frmLoadMail(cmbTypes.SelectedItem.ToString())
                UIController.NextForm.ShowDialog()

            Catch ex As Exception

            End Try
        End Sub

        Private Sub frmMailType_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Select Case UIController.CurrentFunction
                Case SafetracFunction.LoadMailIntoContainer
                    MyBase.SetHeader("Load Mail")
                Case SafetracFunction.UnloadMailFromContainer
                    MyBase.SetHeader("Unload Mail")
            End Select
            cmbTypes.Items.Clear()
            cmbTypes.Items.Add("EMERY")
            cmbTypes.Items.Add("FOR")
            cmbTypes.Items.Add("MAIL")
            cmbTypes.Items.Add("SAM")
            cmbTypes.Items.Add("XMAIL")
            cmbTypes.SelectedIndex = 2 'Set default to mail
            cmbTypes.Focus()
        End Sub
    End Class
End Namespace
