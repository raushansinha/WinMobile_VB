Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmPositionContainer

        Private Sub frmPositionULDSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                MyBase.Reader.Enable()
                MyBase.SetHeader("ULD Position")
                MyBase.HideControl(fraContainerInfo)
                MyBase.HideControl(fraWeight)
                MyBase.HideControl(fraPosition)
                lblULDFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                lblULDDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Public Overrides Sub OnScan(ByVal sender As Object, ByVal e As Hardware.ScanEventArgs)
            txtContainer.Text = e.ScannedValue
            txtContainer_KeyDown(sender, Nothing)
        End Sub

        Private Sub txtPosition_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPosition.KeyDown

            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled = True Then
                    MyBase.ClearError()
                    Exit Sub
                End If

                Try
                    Dim strLog As String = String.Empty
                    Dim retCode As ReturnCodes

                    strLog = String.Format("Before PositionContainer: FlightNum = {0} DepartureDate = {1} ContainerNum = {2} Position = {3}", _
                    lblULDFlight.Text, lblULDDate.Text, txtContainer.Text, txtPosition.Text)
                    Logger.LogMessage(strLog, LogType.Information, "frmPositionContainer.txtPosition_KeyDown")

                    retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.PositionContainer(txtPosition.Text)

                    strLog = String.Format("After PositionContainer: Status = {0}", retCode.ToString())
                    Logger.LogMessage(strLog, LogType.Information, "frmPositionContainer.txtPosition_KeyDown")

                    Select Case retCode
                        Case ReturnCodes.Ok                    ' Success
                            MyBase.SetFocus(txtContainer)
                            MyBase.SetFooter("** POSITIONED **")
                        Case ReturnCodes.DatabaseError            ' DB error
                            MyBase.SetFocus(txtPosition)
                            MyBase.SetError(DisplayMessages.DatabaseError)
                        Case ReturnCodes.ContainerNumInvalid
                            MyBase.SetFocus(txtContainer)
                            MyBase.SetError(DisplayMessages.UnknownContainerSheet)
                        Case ReturnCodes.ContainerMoved
                            MyBase.SetFocus(txtContainer)
                            MyBase.SetFooter("* REPOSITIONED *")
                        Case ReturnCodes.ContainerPositionInUse            ' Position already occupied
                            MyBase.SetFocus(txtContainer)
                            MyBase.SetError("POS IN USE")
                        Case ReturnCodes.ContainerPositionCleared          ' Position has been cleared
                            MyBase.SetFooter("** REMOVED **")
                            'Case ReturnCodes.ULDToHold          ' Trying to position ULD in hold (must verify)
                            '    MyBase.SetFocus(txtPosition)
                            '    MyBase.SetError("NO ULD TO HOLD")
                        Case ReturnCodes.ContainerPositionInvalid
                            MyBase.SetFocus(txtPosition)
                            MyBase.SetError("INVALID POSITION")
                        Case ReturnCodes.CartsNotAllowed             ' Carts cannot be positioned
                            MyBase.SetFocus(txtContainer)
                            MyBase.SetError("CANT POS CARTS")
                        Case ReturnCodes.FlightClosed
                            MyBase.SetError("FLIGHT CLOSED")
                            MyBase.SetFocus(txtContainer)
                    End Select
                Catch safetracEx As SafetracException
                    Logger.LogException(safetracEx)
                Catch ex As Exception
                    Logger.LogException(ex)
                End Try
            End If
        End Sub

        Private Sub frmPositionContainer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                MyBase.GoToMainMenu()
            End If
        End Sub

        
        Private Sub txtContainer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContainer.KeyDown
            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If

                If fraContainerInfo.Visible = True Then
                    MyBase.HideControl(fraContainerInfo)
                    MyBase.HideControl(fraPosition)
                    MyBase.SetFocus(txtContainer)
                    Exit Sub
                End If

                Try
                    Dim strContainer As String = txtContainer.Text.Trim.ToUpper

                    If MyBase.IsErrorEnabled Then
                        MyBase.ClearError()
                        Exit Sub
                    End If

                    If Validate.IsContainerNumValid(strContainer) Then
                        If MyBase.FlightsCollection.CurrentFlight.IsContainerNumValid(strContainer) Then
                            lblContainerTitle.Text = "ULD"
                            lblContainer.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ContainerName
                            lblDest.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Destination
                            lblULDType.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Type
                            If MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Position IsNot Nothing Then
                                txtPosition.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Position
                            End If
                        Else
                            Logger.LogMessage("InvalidUldOrCartOrContainerSheet", LogType.Trace, " frmContainerSummary.IdentifyFlightForContainer")
                            MyBase.SetError(DisplayMessages.InvalidUldOrCartOrContainerSheet)
                            MyBase.SetFocus(txtContainer)
                        End If
                    ElseIf BO.Validate.IsULDNumFormatValid(strContainer) Then
                        'user has entered ULD number
                        If MyBase.FlightsCollection.CurrentFlight.IsContainerNameValid(strContainer) Then
                            lblContainerTitle.Text = "Sheet"
                            lblContainer.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ContainerSheetNum
                            lblDest.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Destination
                            lblULDType.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Type
                            If MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Position IsNot Nothing Then
                                txtPosition.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Position
                            End If
                        Else
                            Logger.LogMessage("InvalidUldOrCartOrContainerSheet", LogType.Trace, " frmContainerSummary.IdentifyFlightForContainer")
                            MyBase.SetError(DisplayMessages.InvalidUldOrCartOrContainerSheet)
                            MyBase.SetFocus(txtContainer)
                        End If
                    Else
                        Logger.LogMessage("Invalid Format", LogType.Trace, "frmContainerSummary.btnLookup_Click")
                        MyBase.SetError(DisplayMessages.InvalidULDFormat)
                        SetFocus(txtContainer)
                    End If
                Catch safetracEx As SafetracException
                    Logger.LogException(safetracEx)
                Catch ex As Exception
                    Logger.LogException(ex)
                End Try
            End If

        End Sub
    End Class
End Namespace