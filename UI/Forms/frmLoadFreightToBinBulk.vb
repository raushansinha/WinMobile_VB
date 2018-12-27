
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.Communication

Namespace NWA.Safetrac.Scanner.UI

    Public Class frmLoadFreightToBinBulk

        Private Sub frmLoadFreightToBinBulk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                MyBase.SetHeader("LOAD FREIGHT")
                MyBase.ShowControl(fraScan)
                MyBase.HideControl(fraResult)
                MyBase.HideControl(fraWait)
                MyBase.HideControl(fraInitCargo)
                MyBase.HideControl(fraResult)
                MyBase.SetFocus(txtAWB)
                MyBase.Reader.Enable()
                lblBinBulk.Text = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.BinBulkNum
                lblFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                lblDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
                If MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LastScannedBags().Count > 0 Then
                    txtAWB.Text = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LastScannedBags().Dequeue
                End If
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub txtAWB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAWB.KeyDown
            
            If e.KeyCode = Keys.Escape Then
                UIController.NextForm = New frmBinBulkInquiryForFreight
                frmBinBulkInquiryForFreight.ShowDialog()
            End If

            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If
                If MyBase.IsFooterEnabled Then
                    MyBase.ClearFooter()
                    Exit Sub
                End If

                If fraResult.Visible = True Then
                    MyBase.HideControl(fraResult)
                End If

                Dim strLog As String = String.Empty
                Dim strAWB As String = txtAWB.Text.Trim
                Dim retCode As ReturnCodes

                Try
                    Logger.LogMessage("Before validating AWB AWBNum = " & strAWB, LogType.Information, "frmLoadFreightToBinBulk.ProceedAWB")

                    Dim retAWBCode As AWBReturnCodes = Validate.IsAWBValid(strAWB)

                    strLog = String.Format("After validating  AWB ReturnCode = {0}", retAWBCode.ToString())
                    Logger.LogMessage(strLog, LogType.Trace, "frmLoadFreightToBinBulk.ProceedAWB")

                    If retAWBCode <> AWBReturnCodes.AWBValid Then
                        MyBase.SetError("INVALID AWB")
                        MyBase.SetFocus(txtAWB)
                        Exit Sub
                    End If

                    txtAWB.Text = strAWB
                    MyBase.SetFocus(txtAWB)
                    MyBase.ShowControl(fraWait)
                    MyBase.Reader.Disable()

                    'validate if the freight record exists in the local sql ce database
                    If Common.IsAWBValid(strAWB) = False Then
                        MyBase.SetFooter("UNKNOWN AWB")
                        MyBase.HideControl(fraWait)
                        txtAWB.Enabled = False
                        Dim createNew As DialogResult
                        Dim objdlgConfirmCreateNewAWB As New dlgConfirmCreateNewAWB()
                        createNew = objdlgConfirmCreateNewAWB.ShowDialog()
                        If createNew = Windows.Forms.DialogResult.OK Then

                            If ConnectionManager.IsConnected = False Then
                                Dim objDlgNoNetwork As New dlgNoNetworkPrompt()
                                objDlgNoNetwork.ShowDialog()
                                Exit Sub
                            End If

                            Dim intNewPieceCount As Integer
                            Dim intNewPieceWgt As Integer
                            Dim strNewPieceType As String
                            Dim strNewDest As String
                            Dim strNewFinal As String

                            'create new awb number
                            Dim objDlgCreateNewAWB As New dlgCreateNewAWB()
                            objDlgCreateNewAWB.ShowDialog()

                            intNewPieceCount = objDlgCreateNewAWB.Pieces
                            intNewPieceWgt = objDlgCreateNewAWB.Weight
                            strNewPieceType = objDlgCreateNewAWB.Type
                            strNewDest = objDlgCreateNewAWB.Destination
                            strNewFinal = objDlgCreateNewAWB.FinalDestination

                            retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.CreateNewAWB(intNewPieceCount, _
                            intNewPieceWgt, strNewPieceType, strNewDest, strNewFinal)

                            Select Case retCode
                                'pending - comments
                            End Select
                            Exit Sub
                        Else
                            'no load authorization
                            MyBase.SetError("NO LOAD AUTH")
                            txtAWB.Enabled = True
                            MyBase.SetFocus(txtAWB)
                            MyBase.HideControl(fraWait)
                            Exit Sub
                        End If
                    End If

                    'validate if the freight is valid w.r.t the flight
                    If MyBase.FlightsCollection.CurrentFlight.IsAWBValid(strAWB) = False Then
                        'invalid awb w.r.t to the flight - expedite cargo
                        Dim objDlgConfirmExpedite As New dlgConfirmExpedite()
                        If objDlgConfirmExpedite.ShowDialog() = Windows.Forms.DialogResult.OK Then
                            retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LoadExpediteFreight(strAWB)
                            MyBase.HideControl(fraWait)
                            Select Case retCode
                                Case ReturnCodes.Ok
                                    'pending - validate with evb code the applicable 
                                    'return codes and messages
                                    MyBase.SetFooter("OKAY")
                                    Exit Sub
                                Case ReturnCodes.FlightClosed
                                    MyBase.SetError(DisplayMessages.FlightClosed)
                                    Exit Sub
                                Case ReturnCodes.FlightDeparted
                                    MyBase.SetError(DisplayMessages.FlightDeparted)
                                    Exit Sub
                                Case ReturnCodes.DatabaseError
                                    MyBase.SetError(DisplayMessages.DatabaseError)
                                    Exit Sub
                            End Select
                            Exit Sub
                        Else
                            'user denied to expedite the awb
                            MyBase.SetError("NO LOAD AUTH")
                            MyBase.HideControl(fraWait)
                            txtAWB.Enabled = True
                            MyBase.SetFocus(txtAWB)
                            Exit Sub
                        End If
                    End If

                    'all validations passed - proceed with normal freight loading
                    Logger.LogMessage("Before LoadAWB AWBNum = " & strAWB, LogType.Information, "frmLoadFreightToBinBulk.ProceedAWB")
                    retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LoadFreight(strAWB)
                    strLog = String.Format("After LoadAWB ReturnCode = {0}", retCode.ToString())

                    Select Case retCode
                        Case ReturnCodes.Ok
                            MyBase.ShowControl(fraResult)
                            'pending - get the freight details from database and show the results

                            lblRecvPcs.Text = Common.GetPiecesForFreight(txtAWB.Text)
                            lblRecvWgt.Text = Common.GetWeightForFreight(txtAWB.Text)
                            lblRecvFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                            lblRecvDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
                            lblRecvStatus.Text = Common.GetFlightStatus(lblRecvFlight.Text)

                            MyBase.Reader.Enable()
                            MyBase.SetFooter("OK TO LOAD")
                        Case AWBReturnCodes.CargoNotDone
                            'Initiate cargo
                            MyBase.ShowControl(fraInitCargo)
                            'Pending - Call enumFunRet = InitiateCargo
                            'Sleep(5000)
                            MyBase.HideControl(fraInitCargo)
                        Case ReturnCodes.FreightAlreadyLoaded
                            MyBase.SetFooter(DisplayMessages.AlreadyRegistered)
                            MyBase.SetFocus(txtAWB)
                            MyBase.HideControl(fraWait)
                            Exit Sub
                            'Case ReturnCodes.LoadError
                            '    MyBase.SetError(DisplayMessages.LoadError)
                            '    MyBase.SetFocus(txtAWB)
                            '    MyBase.HideControl(fraWait)
                            '    Exit Sub
                        Case ReturnCodes.DatabaseError
                            MyBase.SetFooter(DisplayMessages.DatabaseError)
                            MyBase.SetFocus(txtAWB)
                            MyBase.HideControl(fraWait)
                            Exit Sub
                    End Select
                    MyBase.HideControl(fraWait)
                Catch safetracEx As SafetracException
                    Logger.LogException(safetracEx)
                Catch ex As Exception
                    Logger.LogException(ex)
                End Try

            End If

        End Sub

        Private Sub txtAWB_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAWB.GotFocus
            MyBase.SetFocus(txtAWB)
        End Sub

    End Class
End Namespace
