
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.WebReferences

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmFlightInquiry

        Private Sub frmFlightInquiry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                MyBase.GoToMainMenu()
            End If
        End Sub

        Private Sub txtFlight_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFlight.GotFocus
            MyBase.SetFocus(txtFlight)
        End Sub

        Private Sub frmFlightInquiry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Set Header 
            If UIController.CurrentFunction = SafetracFunction.ViewBagsToBeUnloaded Then
                MyBase.SetHeader("Bags To Unload")
            ElseIf UIController.CurrentFunction = SafetracFunction.ViewLineItems Then
                MyBase.SetHeader("View Line Items")
            ElseIf UIController.CurrentFunction = SafetracFunction.AddLateBag Then
                MyBase.SetHeader("Add Late Bags")
            ElseIf UIController.CurrentFunction = SafetracFunction.ViewBagsToGo Then
                MyBase.SetHeader("Bags To Go")
                'creatre multiple container sheet number - 07-11-07
            ElseIf UIController.CurrentFunction = SafetracFunction.CreateMultipleContainerSheets Then
                MyBase.SetHeader("ULD Sheet Creation")
            End If
            'end creatre multiple container sheet number - 07-11-07
            If MyBase.FlightsCollection.CurrentFlight IsNot Nothing Then
                txtFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                txtDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
            End If
            txtFlight.Focus()
        End Sub

        Private Sub txtFlight_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFlight.KeyDown
            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If
                End If
            MyBase.FormatKeysForFlight(txtFlight, e.KeyCode)
        End Sub
        Private Sub txtFlight_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFlight.LostFocus
            Dim strTemp As String
            strTemp = txtFlight.Text.Trim
            If Validate.IsNWAFlightValid(strTemp) Then
                txtFlight.Text = strTemp
            End If
        End Sub

        Private Sub txtDate_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.GotFocus
            MyBase.SetFocus(txtDate)
        End Sub

        Private Sub txtDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                End If
                Exit Sub
            End If
            MyBase.FormatKeysForDate(txtDate, e.KeyCode)
        End Sub

        Private Sub txtDate_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
            txtDate.Text = ToFiveDigitDate(txtDate.Text)
        End Sub

        Public Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
            
            If MyBase.IsErrorEnabled Then
                MyBase.ClearError()
                Exit Sub
            End If

            Dim strFlight As String
            Dim dtDeparture As NWADateTime

            If txtFlight.Text.Length = 0 Then
                MyBase.SetError(DisplayMessages.InvalidFlightFormat)
                MyBase.SetFocus(txtFlight)
                Exit Sub
            End If

            If txtDate.Text.Length = 0 Then
                MyBase.SetError(DisplayMessages.InvalidDepartureDate)
                MyBase.SetFocus(txtDate)
                Exit Sub
            End If

            strFlight = txtFlight.Text.Trim.ToUpper
            If Validate.IsNWAFlightValid(strFlight) Then
                txtFlight.Text = strFlight
            Else
                Logger.LogMessage("InvalidFlightFormat", LogType.Trace, "frmFlightInquiry.btnContinue_Click")
                MyBase.SetError(DisplayMessages.InvalidFlightFormat)
                MyBase.SetFocus(txtFlight)
                Exit Sub
            End If

            Try
                dtDeparture = New NWADateTime(txtDate.Text.Trim)
                txtDate.Text = dtDeparture.NWAFormat
            Catch safetracExp As SafetracException
                Select Case safetracExp.ErrorCode
                    Case ReturnCodes.FlightDateInvalid
                        MyBase.SetError(DisplayMessages.InvalidDepartureDate)
                    Case ReturnCodes.FlightDepartureUnknown
                        MyBase.SetError(DisplayMessages.UnknownFlight)
                End Select
                MyBase.SetFocus(Me.txtDate)
                Exit Sub
                Logger.LogException(safetracExp)
            End Try

            If MyBase.FlightsCollection.IsFlightValid(strFlight, dtDeparture) Then
                If UIController.CurrentFunction = SafetracFunction.ViewLineItems Then
                    UIController.NextForm = New frmViewLineItems()
                    UIController.NextForm.ShowDialog()
                ElseIf UIController.CurrentFunction = SafetracFunction.ViewBagsToBeUnloaded Then
                    UIController.NextForm = New frmViewBagsToUnload()
                    UIController.NextForm.ShowDialog()
                ElseIf UIController.CurrentFunction = SafetracFunction.AddLateBag Then
                    UIController.NextForm = New frmLateBagInfPageOne(strFlight, dtDeparture)
                    UIController.NextForm.ShowDialog()
                ElseIf UIController.CurrentFunction = SafetracFunction.ViewBagsToGo Then
                    UIController.NextForm = New frmViewBagsToGo()
                    UIController.NextForm.ShowDialog()
                ElseIf UIController.CurrentFunction = SafetracFunction.CreateMultipleContainerSheets Then
                    UIController.NextForm = New frmCreateMultipleContainers()
                    UIController.NextForm.ShowDialog()
                End If
            Else
                If UIController.CurrentFunction = SafetracFunction.ViewBagsToGo Then
                    'make webservice call to get bagstogo. if valid response, then only
                    'go to view bags to go page
                ElseIf UIController.CurrentFunction = SafetracFunction.ViewBagsToBeUnloaded Then
                    If MyBase.IsInNetwork(True) Then
                        Dim bagsResponse As ScannerServiceResponse = Common.GetBagsToUnload(strFlight, dtDeparture)
                        If bagsResponse.IsSuccessful Then
                            UIController.NextForm = New frmViewBagsToUnload(bagsResponse.Response)
                            UIController.NextForm.ShowDialog()
                        Else
                            MyBase.SetFooter(bagsResponse.ReturnMessage)
                        End If
                    End If
                End If
                Logger.LogMessage("InvalidFlight", LogType.Trace, "frmFlightInquiry.btnContinue_Click")
                MyBase.SetError(DisplayMessages.InvalidFlight)
                MyBase.SetFocus(txtFlight)
                Exit Sub
            End If
        End Sub
    End Class
End Namespace