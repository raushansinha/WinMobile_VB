Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI

    Public Class frmFlightInfo

     

        Private Sub frmFlightInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("ULD Position")
            MyBase.SetFocus(txtFlight)
        End Sub

        Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click

            If MyBase.IsErrorEnabled() Then
                MyBase.ClearError()
                Exit Sub
            End If

            ' Check inputs
            If txtFlight.Text.Length = 0 Then
                MyBase.SetError("INVALID FLIGHT")
                MyBase.SetFocus(Me.txtFlight)
                Exit Sub
            End If

            If txtDate.Text.Length = 0 Then
                MyBase.SetError("INVALID DATE")
                MyBase.SetFocus(Me.txtFlight)
                Exit Sub
            End If

            Dim flightNum As String
            flightNum = txtFlight.Text.Trim
            If Not Validate.IsNWAFlightValid(flightNum) Then
                Logger.LogMessage("InvalidFlightFormat", LogType.Trace, "frmFlightInfo.btnContinue_Click")
                MyBase.SetError("INVALID FLT FORMAT")
                MyBase.SetFocus(Me.txtFlight)
                Exit Sub
            End If

            Dim dtDeparture As NWADateTime

            Try
                dtDeparture = New NWADateTime(txtDate.Text.Trim)
                txtDate.Text = dtDeparture.NWAFormat
            Catch safetracExp As SafetracException
                Logger.LogException(safetracExp)
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtDate)
                Exit Sub
            Catch exp As Exception
                Logger.LogException(exp)
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtDate)
                Exit Sub
            End Try

            If MyBase.FlightsCollection.IsFlightValid(flightNum, dtDeparture) Then
                If UIController.CurrentFunction = SafetracFunction.PositionContainer Then
                    UIController.NextForm = New frmPositionContainer()
                    UIController.NextForm.ShowDialog()
                End If
            Else
                Logger.LogMessage("InvalidFlight", LogType.Trace, "frmFlightInfo.btnContinue_Click")
            End If

        End Sub

        Private Sub txtFlight_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFlight.KeyDown
            If e.KeyCode = Keys.Escape Then
                MyBase.GoToMainMenu()
                Exit Sub
            End If

            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled = True Then
                    MyBase.ClearError()
                    Exit Sub
                End If
                If MyBase.IsFooterEnabled Then
                    MyBase.ClearFooter()
                    Exit Sub
                End If
                btnContinue_Click(sender, e)
            Else
                FormatKeysForFlight(txtFlight, e.KeyCode)
            End If
        End Sub

        Private Sub txtFlight_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFlight.GotFocus
            MyBase.SetFocus(txtFlight)
        End Sub

        Private Sub txtFlight_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFlight.LostFocus
            Dim sTemp As String = txtFlight.Text.Trim.ToUpper
            If Validate.IsNWAFlightValid(sTemp) Then
                txtFlight.Text = sTemp
            End If
        End Sub

        Private Sub txtDate_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
            txtDate.Text = Validate.ToFiveDigitDate(txtDate.Text)
        End Sub

        Private Sub txtDate_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.GotFocus
            MyBase.SetFocus(txtDate)
        End Sub

        Private Sub txtDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
            If e.KeyCode = Keys.Escape Then
                MyBase.GoToMainMenu()
                Exit Sub
            End If

            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled = True Then
                    MyBase.ClearError()
                    Exit Sub
                End If
                If MyBase.IsFooterEnabled Then
                    MyBase.ClearFooter()
                    Exit Sub
                End If
                btnContinue_Click(sender, e)
            Else
                FormatKeysForDate(txtDate, e.KeyCode)
            End If
        End Sub

    End Class
End Namespace