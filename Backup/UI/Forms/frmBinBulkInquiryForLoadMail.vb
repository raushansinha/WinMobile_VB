Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.BO

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmBinBulkInquiryForLoadMail

        Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
            Dim strLog As String = String.Empty
            ' Check for  error condition set
            If MyBase.IsErrorEnabled Then
                MyBase.ClearError()
                Exit Sub
            End If

            ' Check inputs given or not. 
            If txtBinBulk.Text.Length = 0 Then
                MyBase.SetError("INVALID BIN/BULK")
                MyBase.SetFocus(Me.txtBinBulk)
                Exit Sub
            End If

            If txtFlight.Text.Length = 0 Then
                MyBase.SetError(DisplayMessages.InvalidFlightFormat)
                MyBase.SetFocus(Me.txtFlight)
                Exit Sub
            End If

            If txtDate.Text.Length = 0 Then
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtDate)
                Exit Sub
            End If

            Dim enumRetCode As BinBulkReturnCodes

            ' Check input formats.

            strLog = String.Format("BinBulkInquiryForLoadMail For  BinBulk = {0}, Flight= {1}, Date = {2}", _
            txtBinBulk.Text, txtFlight.Text, txtDate.Text)
            Logger.LogMessage(strLog, LogType.Information, "frmBinBulkInquiryForFreight.cmdContinue_Click")

            enumRetCode = Validate.IsBinBulkValid(txtBinBulk.Text.Trim)

            strLog = String.Format("After BinBulkInquiryForLoadMail ReturnCode = {0}", enumRetCode.ToString())
            Logger.LogMessage(strLog, LogType.Information, "frmBinBulkInquiryForFreight.cmdContinue_Click")

            If enumRetCode <> BinBulkReturnCodes.BinValid And enumRetCode <> BinBulkReturnCodes.BulkValid Then
                MyBase.SetError("INVALID BIN/BULK")
                Logger.LogMessage("Invalid BinBulk", LogType.Trace, "frmBinBulkInquiryForFreight.cmdContinue_Click")
                MyBase.SetFocus(Me.txtBinBulk)
                Exit Sub
            End If

            Dim strFlightNum As String

            strFlightNum = txtFlight.Text.ToUpper
            If Validate.IsNWAFlightValid(strFlightNum) Then
                txtFlight.Text = strFlightNum
            Else
                Logger.LogMessage("InvalidFlightFormat", LogType.Warning, "frmBinBulkInquiryForFreight.cmdContinue_Click")
                MyBase.SetError(DisplayMessages.InvalidFlightFormat)
                MyBase.SetFocus(Me.txtFlight)
                Exit Sub
            End If

            Dim dtDeparture As NWADateTime

            Try
                dtDeparture = New NWADateTime(txtDate.Text.Trim)
                txtDate.Text = dtDeparture.NWAFormat
            Catch safetracExp As SafetracException
                Logger.LogMessage("InvalidDateFormat", LogType.Warning, "frmBinBulkInquiryForFreight.cmdContinue_Click")
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtDate)
                Exit Sub
            Catch exp As Exception
                Logger.LogException(exp)
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtDate)
                Exit Sub
            End Try

            If Not MyBase.FlightsCollection.IsFlightValid(strFlightNum, dtDeparture) Then
                MyBase.Reader.Enable()
                MyBase.SetError(DisplayMessages.NonConfiguredFlight)
                MyBase.SetFocus(Me.txtFlight)
                Exit Sub
            End If

            If MyBase.FlightsCollection.CurrentFlight.IsClosed Then
                strLog = String.Format("Flight = {0} is closed ", txtFlight.Text)
                Logger.LogMessage(strLog, LogType.Information, "frmBinBulkInquiryForFreight.cmdContinue_Click")
                MyBase.SetError(DisplayMessages.FlightClosed)
                MyBase.SetFocus(txtFlight)
                Exit Sub
            End If

            If MyBase.FlightsCollection.CurrentFlight.IsDeparted Then
                'Flight has departed
                strLog = String.Format("Flight = {0} is Departed ", txtDate.Text)
                Logger.LogMessage(strLog, LogType.Information, "frmBinBulkInquiryForFreight.cmdContinue_Click")
                MyBase.SetError(DisplayMessages.FlightDeparted)
                MyBase.SetFocus(txtFlight)
                Exit Sub
            End If

            If UIController.CurrentFunction = SafetracFunction.LoadMailIntoBinBulk Then
                If MyBase.FlightsCollection.CurrentFlight.AreLoadAllowed Then
                    'Load are not allowed on this flight
                    strLog = String.Format("Load are not allowed on this flight = {0} ", txtFlight.Text)
                    Logger.LogMessage(strLog, LogType.Information, "frmBinBulkInquiryForFreight.cmdContinue_Click")
                    MyBase.SetError(DisplayMessages.NoLoadsonFlight)

                    Exit Sub
                End If
            End If

            If MyBase.FlightsCollection.CurrentFlight.IsBinBulkValid(txtBinBulk.Text.Trim) <> ReturnCodes.Ok Then
                MyBase.SetError("INVALID BIN/BULK")
                Logger.LogMessage("INVALID BIN/BULK", LogType.Trace, "frmBinBulkInquiryForLoadMail.btnContinue_Click")
                MyBase.SetFocus(Me.txtBinBulk)
                Exit Sub
            End If

            UIController.NextForm = New frmLoadMail(cmbTypes.Text)
            UIController.NextForm.ShowDialog()

        End Sub
        Private Sub cmbTypes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTypes.KeyDown
            If MyBase.IsErrorEnabled Then
                If e.KeyCode = Keys.Enter Then
                    MyBase.ClearError()
                    Exit Sub
                End If
            Else
                If e.KeyCode = Keys.Enter Then
                    btnContinue_Click(sender, e)
                End If
            End If
        End Sub

        Private Sub btnContinue_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnContinue.KeyDown
            If MyBase.IsErrorEnabled Then
                If e.KeyCode = Keys.Enter Then
                    MyBase.ClearError()
                End If
                Exit Sub
            Else
                If e.KeyCode = Keys.Enter Then
                    btnContinue_Click(sender, e)
                End If
            End If
        End Sub

        Private Sub txtBinBulk_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBinBulk.GotFocus
            MyBase.SetFocus(txtBinBulk)
        End Sub

        Private Sub txtBinBulk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBinBulk.KeyDown
            If MyBase.IsErrorEnabled Then
                If e.KeyCode = Keys.Enter Then
                    MyBase.ClearError()
                End If
                Exit Sub
            Else
                If e.KeyCode = Keys.Enter Then
                    btnContinue_Click(sender, e)
                Else
                    MyBase.FormatKeysForBinBulk(txtBinBulk, Asc(e.KeyCode))
                End If
            End If

        End Sub

        Private Sub txtDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.GotFocus
            MyBase.SetFocus(txtDate)
        End Sub

        Private Sub txtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
            If MyBase.IsErrorEnabled Then
                If e.KeyCode = Keys.Enter Then
                    MyBase.ClearError()
                End If
                Exit Sub
            Else
                If e.KeyCode = Keys.Enter Then
                    btnContinue_Click(sender, e)
                End If
            End If

            MyBase.FormatKeysForBinBulk(txtDate, Asc(e.KeyCode))

        End Sub

        Private Sub txtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
            txtDate.Text = Validate.ToFiveDigitDate(txtDate.Text)
        End Sub

        Private Sub txtFlight_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFlight.GotFocus
            MyBase.SetFocus(txtFlight)
        End Sub

        Private Sub txtFlight_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFlight.KeyDown
            If MyBase.IsErrorEnabled Then
                If e.KeyCode = Keys.Enter Then
                    MyBase.ClearError()
                End If
                Exit Sub
            Else
                If e.KeyCode = Keys.Enter Then
                    btnContinue_Click(sender, e)
                End If
            End If
            MyBase.FormatKeysForBinBulk(txtFlight, Asc(e.KeyCode))
        End Sub

        Private Sub txtFlight_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFlight.LostFocus
            Dim strTemp As String
            strTemp = txtFlight.Text
            If Validate.IsNWAFlightValid(strTemp) Then
                txtFlight.Text = strTemp
            End If
        End Sub

        Private Sub frmBinBulkInquiryForLoadMail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                UIController.NextForm = New frmMainMenu
                UIController.NextForm.ShowDialog()
            End If
        End Sub


        Private Sub frmBinBulkMailType_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            MyBase.Reader.Disable()
            Select Case UIController.CurrentFunction
                Case SafetracFunction.LoadMailIntoBinBulk
                    MyBase.SetHeader("Load Mail")
                Case SafetracFunction.UnloadMailFromBinBulk
                    MyBase.SetHeader("Unload Mail")
            End Select

            If MyBase.FlightsCollection.CurrentFlight IsNot Nothing Then
                txtFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                txtDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
                If MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk IsNot Nothing Then
                    txtBinBulk.Text = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.BinBulkNum
                End If
            End If

            MyBase.SetFocus(txtBinBulk)

        End Sub

    End Class
End Namespace
