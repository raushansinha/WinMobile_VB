
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI

    Public Class frmBinBulkInquiryForFreight

        Private Sub frmFreightBinBulkInquiry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("LOAD FREIGHT")
            MyBase.SetFocus(txtBinBulk)
            MyBase.Reader.Disable()

            If FlightsCollection.CurrentFlight IsNot Nothing Then
                txtFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                txtDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
                txtDest.Text = MyBase.FlightsCollection.CurrentFlight.Destination
                txtFinalDest.Text = MyBase.FlightsCollection.CurrentFlight.FinalDestination
                If FlightsCollection.CurrentFlight.CurrentBinBulk IsNot Nothing Then
                    txtBinBulk.Text = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.BinBulkNum
                End If
            End If

        End Sub

        Private Sub cmdContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click

            Dim strLog As String

            ' Check for  error condition set
            If MyBase.IsErrorEnabled Then
                MyBase.ClearError()
                Exit Sub
            End If
            If MyBase.IsFooterEnabled Then
                MyBase.ClearFooter()
                Exit Sub
            End If

            ' Check inputs given or not. 
            If txtBinBulk.Text.Length = 0 Then
                MyBase.SetError("INVALID BIN/BULK")
                MyBase.SetFocus(Me.txtBinBulk)
                Exit Sub
            End If

            txtFlight.Text = txtFlight.Text.ToUpper
            txtDate.Text = txtDate.Text.ToUpper
            txtDest.Text = txtDest.Text.ToUpper

            If txtFlight.Text.Length = 0 Then
                MyBase.SetError(DisplayMessages.InvalidFlightFormat)
                MyBase.SetFocus(Me.txtFlight)
                Exit Sub
            End If

            If txtDate.Text.Length = 0 Then
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                Logger.LogMessage("InvalidDateFormat", LogType.Warning, "frmBinBulkInquiryForFreight.cmdContinue_Click")
                MyBase.SetFocus(Me.txtDate)
                Exit Sub
            End If

            If txtDest.Text.Length = 0 Then
                MyBase.SetError(DisplayMessages.InvalidDestination)
                Logger.LogMessage("InvalidDestination", LogType.Trace, "frmBinBulkInquiryForFreight.cmdContinue_Click")
                MyBase.SetFocus(Me.txtDest)
                Exit Sub
            End If

            ' Check input formats.
            Dim enumRetCode As BinBulkReturnCodes = Validate.IsBinBulkValid(txtBinBulk.Text.Trim)

            If enumRetCode <> BinBulkReturnCodes.BinValid And enumRetCode <> BinBulkReturnCodes.BulkValid Then
                MyBase.SetError("INVALID BIN/BULK")
                Logger.LogMessage("InvalidBinBulk", LogType.Trace, "frmBinBulkInquiryForFreight.cmdContinue_Click")
                MyBase.SetFocus(Me.txtBinBulk)
                Exit Sub
            End If

            Dim trimChar() As Char = {"0"}
            Dim strTemp As String
            Dim strTemp1 As String

            strTemp = txtFlight.Text.Trim
            strTemp1 = txtFlight.Text

            If Validate.IsNWAFlightValid(strTemp) Then
                txtFlight.Text = strTemp
            Else
                MyBase.SetError(DisplayMessages.InvalidFlightFormat)
                Logger.LogMessage("Invalid Flight", LogType.Trace, "frmBinBulkInquiryForFreight")
                MyBase.SetFocus(Me.txtFlight)
                Exit Sub
            End If

            Dim dtDeparture As NWADateTime

            Try
                dtDeparture = New NWADateTime(txtDate.Text.Trim)
                txtDate.Text = dtDeparture.NWAFormat
            Catch safetracExp As SafetracException
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtDate)
                Exit Sub
            Catch exp As Exception
                Logger.LogException(exp)
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtDate)
                Exit Sub
            End Try

            Try

                strLog = String.Format("BinBulkInquiryFreight For: BinBulk = {0}, FlightNum = {1}, Date = {2}, Destingnation = {3}, Final Destingnation = {4}", _
                                       txtBinBulk.Text, txtFlight.Text, txtDate.Text, txtDest.Text, txtFinalDest.Text)
                Logger.LogMessage(strLog, LogType.Information, "frmBinBulkInquiryForFreight.cmdContinue_Click")

                If MyBase.FlightsCollection.IsFlightValid(strTemp1, dtDeparture) = False Then
                    MyBase.SetFooter(DisplayMessages.NonConfiguredFlight)
                    Exit Sub
                End If

                Dim retCode As ReturnCodes = MyBase.FlightsCollection.CurrentFlight.IsBinBulkValid(txtBinBulk.Text)

                strLog = String.Format("After BinBulkInquiryFreight ReturnCode = {0}", retCode.ToString())
                Logger.LogMessage(strLog, LogType.Information, "frmBinBulkInquiryForFreight.cmdContinue_Click")

                Select Case retCode
                    Case ReturnCodes.Ok
                        UIController.NextForm = New frmLoadFreightToBinBulk()
                        frmLoadFreightToBinBulk.ShowDialog()
                        Reader.Enable()
                    Case ReturnCodes.NotOk
                        MyBase.SetError(DisplayMessages.InvalidHold)
                        'Case ReturnCodes.UnknownHold, ReturnCodes.UnknownFlightDept
                        '    MyBase.SetError("INVALID FLT FORMAT")
                        '    MyBase.SetFocus(txtFlight)
                    Case ReturnCodes.DatabaseError
                        MyBase.SetError("DATABASE ERROR")
                    Case ReturnCodes.FlightNoMoreLoads
                        MyBase.SetError("NO LOADS ON FLT")
                        'Case ReturnCodes.DestinationInvalid
                        '    MyBase.SetError("INVALID DEST")
                    Case ReturnCodes.BinBulkInvalid, ReturnCodes.NotOk
                        MyBase.SetError("INVALID BIN/BULK")
                        MyBase.SetFocus(txtBinBulk)
                    Case ReturnCodes.FlightDeparted
                        MyBase.SetError("FLIGHT DEPARTED")
                        MyBase.SetFocus(txtFlight)
                        'Case ReturnCodes.CustomOkLoad
                        '    MyBase.SetError("UNLOAD BAGS->CH")
                End Select
            Catch ex As Exception
                Logger.LogException(ex)
            End Try

        End Sub


        Private Sub txtBinBulk_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBinBulk.GotFocus
            MyBase.SetFocus(txtBinBulk)
        End Sub

        Private Sub txtBinBulk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBinBulk.KeyDown
            MyBase.FormatKeysForBinBulk(txtBinBulk, Asc(e.KeyCode))
        End Sub

        Private Sub txtDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.GotFocus
            MyBase.SetFocus(txtDate)
        End Sub

        Private Sub txtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
            MyBase.FormatKeysForDate(txtDate, Asc(e.KeyCode))
        End Sub

        Private Sub txtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
            txtDate.Text = Validate.ToFiveDigitDate(txtDate.Text)
        End Sub

        Private Sub txtDest_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDest.GotFocus
            MyBase.SetFocus(txtDest)
        End Sub

        Private Sub txtFinalDest_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFinalDest.GotFocus
            MyBase.SetFocus(txtFinalDest)
        End Sub

        Private Sub txtFlight_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFlight.GotFocus
            MyBase.SetFocus(txtFlight)
        End Sub

        Private Sub txtFlight_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFlight.KeyDown
            MyBase.FormatKeysForFlight(txtFlight, Asc(e.KeyCode))
        End Sub

        Private Sub txtFlight_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFlight.LostFocus
            Dim strTemp As String = txtFlight.Text
            If Validate.IsNWAFlightValid(strTemp) Then
                txtFlight.Text = strTemp
            End If
        End Sub

        Private Sub frmBinBulkInquiryForFreight_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                MyBase.GoToMainMenu()
                Exit Sub
            End If
            If e.KeyCode = Keys.Enter Then
                cmdContinue_Click(sender, e)
            End If
        End Sub

    End Class
End Namespace