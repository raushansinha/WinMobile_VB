
Imports System.Data
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.Communication
Imports NWA.Safetrac.Scanner.WebReferences

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmBinBulkInquiry
        Private Sub frmBinBulkInquiry1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.UpdateUserActionTime()
            MyBase.ClearError()
            MyBase.Reader.Disable()
            Me.BringToFront()
            Me.Refresh()

            If UIController.CurrentFunction = SafetracFunction.BinBulkInquiry Then
                MyBase.SetHeader("Bin/Bulk Inquiry")
            Else
                MyBase.SetHeader("Bags", "to Bin/Bulk")
            End If
            If MyBase.FlightsCollection.CurrentFlight IsNot Nothing Then
                txtFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                txtDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
            End If

            If UIController.CurrentFunction = SafetracFunction.BinBulkInquiry Then
                lblAll.Visible = True
            Else
                lblAll.Visible = False
            End If

        End Sub

        Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
            Dim strLog As String = String.Empty
            MyBase.UpdateUserActionTime()
            ' Check for  error condition set

            If MyBase.IsErrorEnabled Then
                MyBase.ClearError()
                Exit Sub
            End If

            ' Check inputs given or not. 
            If txtBinBulk.Text.Length = 0 Then
                If Not UIController.CurrentFunction = SafetracFunction.BinBulkInquiry Then
                    MyBase.SetError("INVALID BIN/BULK")
                    Logger.LogMessage("Invalid BinBulk", LogType.Trace, "frmBinBulkInquiry.btnContinue_Click")
                    MyBase.SetFocus(Me.txtBinBulk)
                    Exit Sub
                End If
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



           'TO CHECK IF ENTERED BIN BULK IS VALID
            Dim enumRetCode As BinBulkReturnCodes
            strLog = String.Format("Before BinBulkInquiry FlightNum = {0}, Date = {1}", txtFlight.Text, txtDate.Text, enumRetCode.ToString())
            Logger.LogMessage(strLog, LogType.Information, "frmBinBulkInquiry.btnContinue_Click")
            ' Check input formats.
            enumRetCode = Validate.IsBinBulkValid(txtBinBulk.Text.Trim)
            strLog = String.Format("After BinBulkInquiry ReturnCode = {0}", enumRetCode.ToString())
            Logger.LogMessage(strLog, LogType.Information, "frmBinBulkInquiry.btnContinue_Click")
            If enumRetCode <> BinBulkReturnCodes.BinValid And enumRetCode <> BinBulkReturnCodes.BulkValid Then
                MyBase.SetError("INVALID BIN/BULK")
                Logger.LogMessage("Invalid BinBuulk", LogType.Trace, "frmBinBulkInquiry.btnContinue_Click")
                MyBase.SetFocus(Me.txtBinBulk)
                Exit Sub
            End If

            'TO CHECK IT FLIGHT IS VALID
            Dim strFlightNum As String
            strFlightNum = txtFlight.Text
            If Validate.IsNWAFlightValid(strFlightNum) Then
                txtFlight.Text = strFlightNum
            Else
                MyBase.SetError(DisplayMessages.InvalidFlightFormat)
                MyBase.SetFocus(Me.txtFlight)
                Exit Sub
            End If
            strFlightNum = txtFlight.Text.Trim.ToUpper

            'VALIDATE DATE
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
            Dim strBinBulkNum As String = txtBinBulk.Text
            Dim dsResult As DataSet
            Try
                If MyBase.FlightsCollection.IsFlightValid(strFlightNum, dtDeparture) Then  'CHECK IF FLIGHT EXISTS IN DB
                    If MyBase.FlightsCollection.CurrentFlight.IsBinBulkValid(txtBinBulk.Text) <> ReturnCodes.Ok Then
                        'Invalid Bin Bulk
                        MyBase.SetError("INVALID BIN/BULK")
                        MyBase.SetFocus(txtBinBulk)
                        Exit Sub
                    End If
                    If UIController.CurrentFunction = SafetracFunction.BinBulkInquiry Then
                        If strBinBulkNum = String.Empty Then
                            strBinBulkNum = "ALL"
                            txtBinBulk.Text = strBinBulkNum
                        End If
                        Try
                            dsResult = Common.GetBinBulkSummary(strFlightNum, dtDeparture, strBinBulkNum)
                        Catch ex As Exception
                            Logger.LogException(ex)
                            Exit Sub
                        End Try
                    End If
                ElseIf ConnectionManager.IsConnected Then    'if non configured flight
                    If UIController.CurrentFunction = SafetracFunction.BinBulkInquiry Then
                        Dim _objWebServices As ScannerServices = ScannerServices.GetInstance
                        Try
                            Dim response As ScannerServiceResponse = _objWebServices.GetBinBulkSummary(strFlightNum, dtDeparture, strBinBulkNum)
                            If response.IsSuccessful Then
                                dsResult = response.Response
                            Else
                                MyBase.Reader.Enable()
                                MyBase.SetError(DisplayMessages.InvalidFlight)
                                MyBase.SetFocus(Me.txtFlight)
                            End If
                        Catch ex As Exception
                            Logger.LogException(ex)
                            Exit Sub
                        End Try
                    End If
                Else
                    MyBase.Reader.Enable()
                    MyBase.SetError(DisplayMessages.NonConfiguredFlight)
                    MyBase.SetFocus(Me.txtFlight)
                End If
            Catch ex As Exception
                Logger.LogException(ex)
            End Try

            'All fine, proceed to LoadBagToBinBulk Form
            If UIController.CurrentFunction = SafetracFunction.BinBulkInquiry Then
                If Not dsResult Is Nothing Then
                    UIController.NextForm = New frmBinBulkSummary(dsResult)
                    'dsResult can come f
                    UIController.NextForm.ShowDialog()
                End If
            Else
                'ElseIf UIController.CurrentFunction = SafetracFunction.LoadBagIntoBinBulk Or _
                '            UIController.CurrentFunction = SafetracFunction.ExpediteBag Then
                UIController.NextForm = New frmLoadBagToBinBulk(strFlightNum, dtDeparture, txtBinBulk.Text)
                UIController.NextForm.ShowDialog()
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

        Private Sub frmBinBulkInquiry1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                MyBase.GoToMainMenu()
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
            MyBase.FormatKeysForDate(txtDate, Asc(e.KeyCode))
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
            MyBase.FormatKeysForFlight(txtDate, Asc(e.KeyCode))
        End Sub

        Private Sub txtFlight_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFlight.LostFocus
            Dim strTemp As String
            strTemp = Trim(txtFlight.Text)
            If IsNWAFlightValid(strTemp) Then
                txtFlight.Text = strTemp
            End If
        End Sub
    End Class

End Namespace

