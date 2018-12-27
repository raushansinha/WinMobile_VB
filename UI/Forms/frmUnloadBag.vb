Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Namespace NWA.Safetrac.Scanner.UI
   
    Public Class frmUnloadBag

        Public Overrides Sub onScan(ByVal sender As Object, ByVal e As Hardware.ScanEventArgs)
            txtBagtag.Text = e.ScannedValue
            txtBagtag_KeyDown(sender, New KeyEventArgs(Keys.Enter))
        End Sub

        Private Sub frmUnloadBag_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            'hide footer , when there is no error
            If Not MyBase.IsErrorEnabled Then
                MyBase.HideFooter()
            End If
            If e.KeyCode = Keys.Escape Then
                Logger.LogMessage("GoToMainMenu", LogType.Trace, "frmUnloadBag.frmUnloadBag_KeyDown")
                MyBase.GoToMainMenu()
            End If
        End Sub

        Private Sub txtBagtag_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBagtag.GotFocus
            MyBase.SetFocus(txtBagtag)
        End Sub

        Private Sub txtBagtag_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBagtag.KeyDown
            Dim strLog As String
            'clear the footer if it is already showing an error
            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                Else
                    'if enter key is pressed
                    Dim strBagtag As String = String.Empty
                    Dim nwaFlight As NWAFlight = Nothing

                    Try
                        MyBase.HideControl(pnlResults)
                        MyBase.HideFooter()
                        strBagtag = txtBagtag.Text.Trim

                        If Validate.IsBagtagValid(strBagtag) = BagTagReturnCodes.BagtagValid Then
                            txtBagtag.Text = strBagtag
                        Else
                            MyBase.SetError(DisplayMessages.InvalidBagTagFormat)
                            Exit Sub
                        End If

                        If Common.IsDuplicateBagtag(strBagtag) Then
                            'show duplicates
                            MyBase.SetFooter(DisplayMessages.DuplicateBagTagsFound)
                            Logger.LogMessage("DuplicateBagTagsFound", LogType.Warning, "frmUnloadBag.txtBagtag_KeyDown")
                            Dim objfrmDuplicateBagtags As New frmDuplicateBagsList(strBagtag)
                            Logger.LogMessage("objfrmDuplicateBagtags.ShowDialog()", LogType.Trace, "frmUnloadBag.txtBagtag_KeyDown")
                            objfrmDuplicateBagtags.ShowDialog() 'pop up the list showing available options of diff Passengers having same bagatag no's
                            nwaFlight.Number = objfrmDuplicateBagtags.FlightNum 'get the selected flight from popup menu
                            nwaFlight.DepartureDate = objfrmDuplicateBagtags.FlightDate  'get the selected date from popup menu
                        Else
                            nwaFlight = Common.GetFlightForBagTag(strBagtag)
                        End If

                        Dim retCode As ReturnCodes

                        strLog = String.Format("Before UnloadBag : Flight = {0} DepartureDate = {1} strBagtag = {2}", nwaFlight.Number, nwaFlight.DepartureDate, strBagtag)
                        Logger.LogMessage(strLog, LogType.Information, "frmUnloadBag.txtBagtag_KeyDown")

                        retCode = MyBase.FlightsCollection.Flights(nwaFlight.Number, nwaFlight.DepartureDate).UnloadBag(strBagtag)

                        strLog = String.Format("After UnloadBag : ReturnCode = {0}", retCode.ToString())
                        Logger.LogMessage(strLog, LogType.Information, "frmUnloadBag.txtBagtag_KeyDown")

                        Select Case retCode
                            Case ReturnCodes.FlightClosed
                                MyBase.SetFooter(DisplayMessages.FlightClosed)
                            Case ReturnCodes.FlightDeparted
                                MyBase.SetFooter(DisplayMessages.FlightDeparted)
                            Case ReturnCodes.PassengerOnStandBy
                                MyBase.SetFooter(DisplayMessages.PassengerOnStandby)
                            Case ReturnCodes.PassengerNotCheckedIn
                                MyBase.SetFooter(DisplayMessages.PassengerNotCheckedIn)
                            Case ReturnCodes.BagtagUnknown
                                MyBase.SetFooter(DisplayMessages.UnknownBag)
                            Case ReturnCodes.BagtagUnloaded
                                lblFlt.Text = nwaFlight.Number
                                lblDest.Text = MyBase.FlightsCollection.Flights(nwaFlight.Number, nwaFlight.DepartureDate).Destination
                                lblClass.Text = FlightsCollection.Flights(nwaFlight.Number, nwaFlight.DepartureDate).GetPassengerClass(strBagtag)
                                MyBase.ShowControl(pnlResults)
                                MyBase.SetFooter(DisplayMessages.BagUnloaded)
                            Case ReturnCodes.DatabaseError
                                MyBase.SetFooter(DisplayMessages.DatabaseError)
                            Case ReturnCodes.Unknown
                        End Select
                    Catch safetracExp As SafetracException
                        Select Case safetracExp.ErrorCode
                            Case ReturnCodes.BagtagDuplicatesFound
                            Case ReturnCodes.NotConfiguredFlight
                                MyBase.SetError(DisplayMessages.NonConfiguredFlight)
                            Case ReturnCodes.DatabaseError
                                MyBase.SetError(DisplayMessages.DatabaseError)
                            Case ReturnCodes.Unknown
                                MyBase.SetError(DisplayMessages.UnknownError)
                        End Select
                    Catch ex As Exception
                        Logger.LogException(ex)
                        MessageBox.Show(ex.ToString())
                    End Try
                End If
            End If
        End Sub

        Private Sub frmUnloadBag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("UNLOAD BAGGAGE")
            MyBase.UpdateUserActionTime()
            MyBase.Reader.Enable()
        End Sub

        Private Sub frmUnloadBag_Closing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            MyBase.Reader.Disable()
        End Sub
    End Class
End Namespace