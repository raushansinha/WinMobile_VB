Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Hardware

Namespace NWA.Safetrac.Scanner.UI
    Public Class dlgSetBackLightTime

        Private Sub frmModifyBackLightTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'populate the values to combobox
            cmbBacklightTimes.Items.Clear()
            cmbBacklightTimes.Items.Add("1 Minute")
            cmbBacklightTimes.Items.Add("2 Minutes")
            cmbBacklightTimes.Items.Add("5 Minutes")
            cmbBacklightTimes.SelectedIndex = 0
        End Sub

        Private Sub cmdBacklightOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBacklightOK.Click
            Try

                If MessageBox.Show("This change requires a warm reset. Apply change to scanner and reboot?", "Reboot required", _
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                    Dim strBacklightTime As String = cmbBacklightTimes.SelectedItem.ToString

                    Dim objReader As Psion7535
                    objReader = Psion7535.GetInstance

                    Select Case strBacklightTime
                        Case "1 Minute"
                            ' 1 minute
                            objReader.BackLightTime = 1
                            objReader.WarmReboot()
                        Case "2 Minutes"
                            ' 2 minutes
                            objReader.BackLightTime = 2
                            objReader.WarmReboot()
                        Case "5 Minutes"
                            ' 5 minutes
                            objReader.BackLightTime = 5
                            objReader.WarmReboot()
                        Case Else
                            Me.Close()
                    End Select
                End If
                Me.Close()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub dlgSetBackLightTime_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        End Sub

    End Class

End Namespace