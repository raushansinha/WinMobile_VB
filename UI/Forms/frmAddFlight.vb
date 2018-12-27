
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI

    Public Class frmAddFlight

        Private Sub frmFlightInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                MyBase.SetHeader("ADD FLIGHT")
                MyBase.SetFocus(txtFlight)

                'test code - delete later - pending
                txtFlight.Text = "56"
                txtDate.Text = "24OCT"

            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub txtFlight_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFlight.KeyDown
            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If
                btnAddFlight_Click(Me, Nothing)
            End If
            MyBase.FormatKeysForFlight(txtFlight, e.KeyCode)
        End Sub

        Private Sub txtFlight_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFlight.LostFocus
            Dim strTemp As String = txtFlight.Text.Trim
            If Validate.IsNWAFlightValid(strTemp) Then
                txtFlight.Text = strTemp
            End If
        End Sub

        Private Sub txtDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If
                btnAddFlight_Click(Me, Nothing)
            End If
            MyBase.FormatKeysForDate(txtFlight, e.KeyCode)
        End Sub

        Private Sub txtDate_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
            txtDate.Text = Validate.ToFiveDigitDate(txtDate.Text.Trim)
        End Sub

        Private Sub btnAddFlight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFlight.Click

            Dim strLog As String = String.Empty

            If MyBase.IsErrorEnabled Then
                MyBase.ClearError()
                Exit Sub
            End If

            If Len(txtFlight.Text) = 0 Then
                MyBase.SetError(DisplayMessages.InvalidFlight)
                txtFlight.Focus()
                Exit Sub
            End If

            If Len(txtDate.Text) = 0 Then
                MyBase.SetError(DisplayMessages.InvalidDepartureDate)
                txtDate.Focus()
                Exit Sub
            End If

            If Not (Validate.IsNWAFlightValid(txtFlight.Text)) Then
                Logger.LogMessage("InvalidFlight", LogType.Trace, "frmAddFlight.btnAddFlight_Click")
                MyBase.SetError(DisplayMessages.InvalidFlightFormat)
                txtFlight.Focus()
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
            If Not (Validate.IsNWADateValid(txtDate.Text)) Then
                MyBase.SetError("INVALID DATE")
                txtDate.Focus()
                Exit Sub
            End If

            Dim retCode As ReturnCodes
            Dim blnIsError As Boolean = True
            Dim strFooterMessage As String = String.Empty

            Try

                strLog = String.Format("Before Flights.AddFlight FlightNum = {0}, Date = {1}", txtFlight.Text, txtDate.Text, retCode.ToString())
                Logger.LogMessage(strLog, LogType.Information, "frmAddFlight.btnAddFlight_Click")

                retCode = MyBase.FlightsCollection.AddFlight(txtFlight.Text.Trim, dtDeparture)

                strLog = String.Format("After AddFlight ReturnCode = {0}", retCode.ToString())
                Logger.LogMessage(strLog, LogType.Information, "frmAddFlight.btnAddFlight_Click")

                Select Case retCode
                    Case ReturnCodes.FlightAdded
                        MyBase.SetFooter("FLGHT ADDED")
                        'Dim blnResult As ReturnCodes = MyBase.FlightsCollection.CurrentFlight.DiablePBM(c chkPbm.Checked)
                    Case ReturnCodes.NotAuthorized
                        strFooterMessage = "NOT AUTHORIZED"
                    Case ReturnCodes.FlightInvalid
                    Case ReturnCodes.FlightAddError
                        strFooterMessage = "ERROR IN ADD FLIGHT"
                    Case ReturnCodes.FlightDepartureUnknown
                    Case ReturnCodes.FlightAlreadyExists
                        strFooterMessage = "ALREADY EXISTS"
                    Case ReturnCodes.DatabaseError
                        strFooterMessage = DisplayMessages.DatabaseError
                    Case ReturnCodes.Unknown
                        strFooterMessage = DisplayMessages.UnknownError
                    Case ReturnCodes.NotInNetwork
                        Dim objNoNetwork As New dlgNoNetworkPrompt()
                        objNoNetwork.ShowDialog()
                        Exit Sub
                    Case Else
                        strFooterMessage = DisplayMessages.UnknownError
                End Select
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
            'UIController.NextForm = New frmFlightMenu(strFooterMessage, blnIsError)
            'UIController.NextForm.ShowDialog()
        End Sub

    End Class

End Namespace