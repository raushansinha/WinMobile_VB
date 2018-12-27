
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmContainerInquiry

        Dim _cntnrNum As String

        Private Sub frmULDCartInquiry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If UIController.CurrentFunction = SafetracFunction.LoadBagToContainer Then
                MyBase.SetHeader("Bags to ULD/Cart")
            Else
                MyBase.SetHeader("ULD/Cart Inquiry")
            End If
            MyBase.Reader.Enable()
            ' Pending test data
            txtULDSheet.Text = "AKE76257NW"
            MyBase.SetFocus(txtULDSheet)
        End Sub

        Public Overrides Sub OnScan(ByVal sender As Object, ByVal e As Hardware.ScanEventArgs)
            txtULDSheet.Text = e.ScannedValue
        End Sub

        Private Sub txtULDSheet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtULDSheet.KeyDown
            If e.KeyCode = Keys.Escape Then
                MyBase.GoToMainMenu()
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                Else
                    cmdLookup_Click(Me, Nothing)
                End If
            Else
                MyBase.FormatKeysForULD(txtULDSheet, e.KeyCode)
            End If
        End Sub

        Private Sub cmdLookup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLookup.Click
            Try

                Dim strContainer As String = txtULDSheet.Text.Trim.ToUpper
                Dim blnIsContainerNum As Boolean

                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If

                If MyBase.IsFooterEnabled Then
                    MyBase.ClearFooter()
                    Exit Sub
                End If

                _cntnrNum = strContainer

                If Validate.IsContainerNumValid(strContainer) Then
                    blnIsContainerNum = True
                    strContainer = strContainer.Substring(0, 5)
                    Me.IdentifyFlightForContainer(strContainer, blnIsContainerNum)
                ElseIf BO.Validate.IsULDNumFormatValid(strContainer) Then
                    'user has entered ULD number
                    blnIsContainerNum = False
                    Me.IdentifyFlightForContainer(strContainer, blnIsContainerNum)
                Else
                    Logger.LogMessage("Invalid Format", LogType.Trace, "frmContainerSummary.btnLookup_Click")
                    MyBase.SetError(DisplayMessages.InvalidULDFormat)
                    SetFocus(txtULDSheet)
                End If
            Catch safetracEx As SafetracException
                Logger.LogException(safetracEx)
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub IdentifyFlightForContainer(ByVal strContainer As String, ByVal blnIsContainerNum As Boolean)

            Dim objFlight As New NWAFlight
            Try
                If blnIsContainerNum = True Then
                    objFlight = Common.GetFlightForContainerNum(strContainer)
                    If objFlight.Number IsNot Nothing Then
                        If MyBase.FlightsCollection.IsFlightValid(objFlight.Number, objFlight.DepartureDate) Then
                            If MyBase.FlightsCollection.CurrentFlight.IsContainerNumValid(strContainer) Then
                                If UIController.CurrentFunction = SafetracFunction.LoadBagToContainer Then
                                    UIController.NextForm = New frmLoadBagToContainer()
                                    UIController.NextForm.ShowDialog()
                                ElseIf UIController.CurrentFunction = SafetracFunction.RegisterContainer Then
                                    'first check if the container is already registered
                                    If MyBase.FlightsCollection.CurrentFlight.CurrentContainer.IsRegistered Then
                                        'display message that the container is already registered
                                        MyBase.SetFooter(DisplayMessages.ContainerSheetAlreadyRegistered)
                                        Exit Sub
                                    Else
                                        'check is network is available
                                        If MyBase.IsInNetwork(True) Then
                                            'proceed to container registration
                                            UIController.NextForm = New frmRegisterContainer(_cntnrNum)
                                            UIController.NextForm.ShowDialog()
                                        End If
                                    End If
                                End If
                            Else
                                Logger.LogMessage("InvalidULDorCartorContainerSheet", LogType.Trace, " frmContainerSummary.IdentifyFlightForContainer")
                                MyBase.SetError(DisplayMessages.InvalidUldOrCartOrContainerSheet)
                                MyBase.SetFocus(txtULDSheet)
                            End If
                        Else
                            'unknown container
                            MyBase.SetError(DisplayMessages.UnknownContainerSheet)
                            Exit Sub
                        End If
                    Else
                        'unknown container
                        MyBase.SetError(DisplayMessages.UnknownContainerSheet)
                        Exit Sub
                    End If
                Else
                    objFlight = Common.GetFlightForContainerName(strContainer)
                    If objFlight.Number IsNot Nothing Then
                        If MyBase.FlightsCollection.IsFlightValid(objFlight.Number, objFlight.DepartureDate) Then
                            If MyBase.FlightsCollection.CurrentFlight.IsContainerNameValid(strContainer) Then
                                If UIController.CurrentFunction = SafetracFunction.LoadBagToContainer Then
                                    UIController.NextForm = New frmLoadBagToContainer()
                                    UIController.NextForm.ShowDialog()
                                ElseIf UIController.CurrentFunction = SafetracFunction.RegisterContainer Then
                                    'pending
                                    'check in the existing code what if the user enters as container name
                                    MyBase.SetFooter(DisplayMessages.InvalidULDFormat)
                                    Exit Sub
                                End If
                            Else
                                MyBase.SetError(DisplayMessages.InvalidUldOrCartOrContainerSheet)
                                MyBase.SetFocus(txtULDSheet)
                            End If
                        Else
                            'unknown container name
                            MyBase.SetError(DisplayMessages.UnknownContainer)
                            Exit Sub
                        End If
                    Else
                        'unknown container name
                        MyBase.SetError(DisplayMessages.UnknownContainer)
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub txtULDSheet_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtULDSheet.LostFocus
            txtULDSheet.Text = txtULDSheet.Text.Trim.ToUpper
        End Sub

        Private Sub txtULDSheet_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtULDSheet.GotFocus
            MyBase.SetFocus(txtULDSheet)
        End Sub

        Private Sub frmContainerInquiry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                MyBase.GoToMainMenu()
            End If
        End Sub

    End Class
End Namespace
