Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Namespace NWA.Safetrac.Scanner.UI
    Public Class frmSetBagtagAlert
        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
        End Sub

        Private Sub frmSetBagtagAlert_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            Try
                If e.KeyCode = Keys.Escape Then
                    Logger.LogMessage("UIController.NextForm = New frmBagAlertMenu()", LogType.Trace, "frmSetBagtagAlert.frmSetBagtagAlert_KeyDown")
                    UIController.NextForm = New frmBagAlertMenu()
                    UIController.NextForm.ShowDialog()
                    Me.Dispose()
                End If
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub frmSetBagtagAlert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("Bagtag Alerts")
            If UIController.CurrentFunction = SafetracFunction.ViewBagsOnAlert Then
                MyBase.Reader.Disable()
                fraBagtag.Visible = False
                txtBagtag.Enabled = False
            Else
                MyBase.Reader.Enable()
            End If

            If MyBase.FlightsCollection.CurrentFlight IsNot Nothing Then
                txtFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                txtDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
                txtBagtag.Focus()
            End If
            txtFlight.Focus()
            Me.Refresh()
        End Sub

        Private Sub cmdContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
            Dim strLog As String
            MyBase.UpdateUserActionTime()

            ' Check for  error condition set
            If MyBase.IsErrorEnabled Then
                MyBase.ClearError()
                Exit Sub
            End If

            ' Check inputs given or not. 
            If txtFlight.Text.Length = 0 Then
                MyBase.SetError(DisplayMessages.InvalidFlightFormat)
                MyBase.SetFocus(Me.txtFlight)
                Exit Sub
            End If

            If txtDate.Text.Length = 0 Then
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtFlight)
                Exit Sub
            End If

            If UIController.CurrentFunction <> SafetracFunction.ViewBagsOnAlert Then
                If txtBagtag.Text.Length = 0 Then
                    MyBase.SetError(DisplayMessages.InvalidBagTagFormat)
                    MyBase.SetFocus(Me.txtFlight)
                    Exit Sub
                End If
            End If

            Dim strFlightNum As String
            Dim strFlightNum1 As String

            strFlightNum1 = txtFlight.Text.Trim
            strFlightNum = txtFlight.Text.Trim

            If Validate.IsNWAFlightValid(strFlightNum) Then
                txtFlight.Text = strFlightNum
            Else
                MyBase.SetError(DisplayMessages.InvalidFlightFormat)
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

            Dim strBagtag As String = String.Empty

            ' Check input formats.
            If UIController.CurrentFunction <> SafetracFunction.ViewBagsOnAlert Then
                strBagtag = txtBagtag.Text.Trim
                If Validate.IsBagtagValid(strBagtag) = BagTagReturnCodes.BagtagValid Then
                    txtBagtag.Text = strBagtag
                Else
                    MyBase.SetError(DisplayMessages.InvalidBagTagFormat)
                    MyBase.SetFocus(Me.txtBagtag)
                    Exit Sub
                End If
            End If

            ' All format validations successful. Proceed. Show User Wait Screen
            MyBase.ShowControl(fraWait)
            MyBase.Reader.Disable()

            ' Calls BO:Flight for BagAlert updation
            Dim retCode As ReturnCodes

            If Not MyBase.FlightsCollection.IsFlightValid(strFlightNum1, dtDeparture) Then
                MyBase.Reader.Enable()
                MyBase.SetError(DisplayMessages.NonConfiguredFlight)
                MyBase.SetFocus(Me.txtFlight)
                MyBase.HideControl(fraWait)
                Exit Sub
            End If

            Try
                If UIController.CurrentFunction = SafetracFunction.ViewBagsOnAlert Then
                    UI.NextForm = New frmViewBagsOnAlert(strFlightNum1, dtDeparture)
                    UIController.NextForm.ShowDialog()
                ElseIf UIController.CurrentFunction = SafetracFunction.SetBagAlert Then

                    strLog = String.Format("Before SetBagtagAlert : Flight = {0} Departure = {1} Bagtag = {2}", txtFlight.Text, dtDeparture, strBagtag)
                    Logger.LogMessage(strLog, LogType.Information, "frmSetBagtagAlert.cmdContinue_Click")

                    retCode = MyBase.FlightsCollection.Flights(strFlightNum1, dtDeparture).SetBagtagAlert(strBagtag)

                    strLog = String.Format("After SetBagtagAlert : ReturnCode = {0}", retCode.ToString())
                    Logger.LogMessage(strLog, LogType.Information, "frmSetBagtagAlert.cmdContinue_Click")

                ElseIf UIController.CurrentFunction = SafetracFunction.RemoveBagAlert Then

                    strLog = String.Format("Before RemoveBagAlert : Flight = {0} Departure = {1} Bagtag = {2}", txtFlight.Text, dtDeparture, strBagtag)
                    Logger.LogMessage(strLog, LogType.Information, "frmSetBagtagAlert.cmdContinue_Click")

                    retCode = MyBase.FlightsCollection.Flights(strFlightNum1, dtDeparture).RemoveBagAlert(strBagtag)

                    strLog = String.Format("After RemoveBagAlert : ReturnCode = {0}", retCode.ToString())
                    Logger.LogMessage(strLog, LogType.Information, "frmSetBagtagAlert.cmdContinue_Click")

                End If
                MyBase.HideControl(fraWait)
                Select Case retCode
                    Case ReturnCodes.Ok
                        If UIController.CurrentFunction = SafetracFunction.SetBagAlert Then
                            UI.NextForm = New frmBagAlertMenu(DisplayMessages.SetBagAlert)
                        ElseIf UIController.CurrentFunction = SafetracFunction.RemoveBagAlert Then
                            UI.NextForm = New frmBagAlertMenu(DisplayMessages.RemoveAlert)
                        End If
                        UIController.NextForm.ShowDialog()
                    Case ReturnCodes.FlightClosed
                        MyBase.SetError(DisplayMessages.FlightClosed)
                    Case ReturnCodes.FlightDeparted
                        MyBase.SetError(DisplayMessages.FlightDeparted)
                    Case ReturnCodes.BagtagUnknown
                    Case ReturnCodes.BagtagInvalidForFlight
                        MyBase.SetError(DisplayMessages.UnknownBag)
                        MyBase.SetFocus(txtBagtag)
                    Case ReturnCodes.BagtagAlreadyOnAlert
                        MyBase.SetError("BAG ON ALERT")
                        MyBase.SetFocus(txtBagtag)
                    Case ReturnCodes.BagtagNotOnAlert
                        MyBase.SetError("BAG NOT ON ALERT")
                        MyBase.SetFocus(txtBagtag)
                    Case Else
                        UI.NextForm = New frmBagAlertMenu(DisplayMessages.AlertError)
                        UIController.NextForm.ShowDialog()
                End Select
            Catch ex As Exception
                Logger.LogException(ex)
            End Try

            MyBase.Reader.Enable()
        End Sub

        Private Sub txtFlight_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFlight.GotFocus
            MyBase.Reader.Disable()
            MyBase.SetFocus(txtFlight)
        End Sub
        Private Sub txtBagtag_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBagtag.GotFocus
            MyBase.Reader.Enable()
            MyBase.SetFocus(txtBagtag)
        End Sub
        Private Sub txtDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.GotFocus
            MyBase.Reader.Disable()
            MyBase.SetFocus(txtDate)
        End Sub
        Private Sub txtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
            Dim strTemp As String
            strTemp = txtDate.Text.Trim
            If Validate.IsNWADateValid(strTemp) Then
                txtDate.Text = strTemp
            Else
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtDate)
                Exit Sub
            End If
        End Sub
        Private Sub txtBagtag_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBagtag.KeyDown
            If MyBase.IsErrorEnabled Then
                If e.KeyCode = Keys.Enter Then
                    MyBase.ClearError()
                End If
                Exit Sub
            End If
            If e.KeyCode = Keys.Enter Then
                Call cmdContinue_Click(sender, e)
            Else
                MyBase.FormatKeysForBagtag(txtBagtag, e.KeyCode)
            End If
            If e.KeyCode = Keys.Escape Then
                Logger.LogMessage("UIController.NextForm = New frmBagAlertMenu()", LogType.Trace, "frmSetBagtagAlert.txtBagtag_KeyDown")
                UIController.NextForm = New frmBagAlertMenu()
                UIController.NextForm.ShowDialog()
                Me.Dispose()
            End If

        End Sub

    End Class
End Namespace
