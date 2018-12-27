Imports System.Xml
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.Communication
Imports NWA.Safetrac.Scanner.WebReferences
Imports System.data




Namespace NWA.Safetrac.Scanner.UI

    Public Class frmFlightInquiryForClose
        Public Const RESULT_UNLOADBAGS_YES = 100
        Public Const RESULT_UNLOADBAGS_NO = 101
        Public Const RESULT_WS_NO_DATA = 1
        Public Const RESULT_WS_WEBSERVICE_FAULT = 2

        Private Sub frmFlightInquiry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If UIController.CurrentFunction = SafetracFunction.CloseFlight Then
                MyBase.SetHeader("Close Flight")
            ElseIf UIController.CurrentFunction = SafetracFunction.ReopenFlight Then
                MyBase.SetHeader("Reopen Flight")
            End If

        End Sub

        Private Sub txtFlight_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFlight.GotFocus
            MyBase.SetFocus(txtFlight)
        End Sub
        Private Sub txtFlight_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFlight.LostFocus
            Dim flightNum As String
            flightNum = txtFlight.Text.Trim
            If Validate.IsNWAFlightValid(flightNum) Then
                txtFlight.Text = flightNum
            End If
        End Sub
        Private Sub txtDate_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.GotFocus
            MyBase.SetFocus(txtDate)
        End Sub

        Private Sub txtDate_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
            txtDate.Text = Validate.ToFiveDigitDate(txtDate.Text.Trim)
        End Sub

        Private Sub txtFlight_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFlight.KeyDown
            If MyBase.IsErrorEnabled Then
                If e.KeyCode = Keys.Enter Then
                    MyBase.ClearError()
                End If
                Exit Sub
            Else
                If e.KeyCode = Keys.Enter Then
                    cmdNext_Click(Me, Nothing)
                End If
            End If
            FormatKeysForFlight(txtFlight, AscW(e.KeyCode))
        End Sub

        Private Sub txtDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
            If MyBase.IsErrorEnabled Then
                If e.KeyCode = Keys.Enter Then
                    MyBase.ClearError()
                End If
                Exit Sub
            Else
                If e.KeyCode = Keys.Enter Then
                    cmdNext_Click(Me, Nothing)
                End If
            End If
            FormatKeysForDate(txtDate, AscW(e.KeyCode))
        End Sub

        Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
            Dim dsLoadSummary As DataSet
            Dim iRet As Integer

            If MyBase.IsErrorEnabled Then
                MyBase.ClearError()
                Exit Sub
            Else
                If txtFlight.Text.Length = 0 Then
                    MyBase.SetError("INVALID FLIGHT")
                    MyBase.SetFocus(Me.txtFlight)
                    Exit Sub
                End If

                If txtDate.Text.Length = 0 Then
                    MyBase.SetError("INVALID DATE")
                    MyBase.SetFocus(Me.txtDate)
                    Exit Sub
                End If

                Dim strflightNum As String
                strflightNum = txtFlight.Text.Trim
                If Validate.IsNWAFlightValid(strflightNum) Then
                    txtFlight.Text = strflightNum
                Else
                    Logger.LogMessage("InvalidFlightFormat", LogType.Trace, "frmFlightInquiryForClose.cmdNext_Click")
                    MyBase.SetError("INVALID FLT FORMAT")
                    MyBase.SetFocus(Me.txtFlight)
                    Exit Sub
                End If

                Dim dtDeparture As NWADateTime
                Try
                    dtDeparture = New NWADateTime(txtDate.Text.Trim)
                    txtDate.Text = dtDeparture.NWAFormat
                Catch safetracExp As SafetracException
                    Logger.LogException(safetracExp)
                    MyBase.SetError(DisplayMessages.InvalidDateFormat)
                    MyBase.SetFocus(Me.txtDate)
                    Exit Sub
                Catch exp As Exception
                    Logger.LogException(exp)
                    MyBase.SetError(DisplayMessages.InvalidDateFormat)
                    MyBase.SetFocus(Me.txtDate)
                    Exit Sub
                End Try



                If UIController.CurrentFunction = SafetracFunction.ReopenFlight Then
                    If MyBase.FlightsCollection.IsFlightValid(strflightNum, dtDeparture) Then
                        If FlightsCollection.Flights(strflightNum, dtDeparture).IsClosed Then
                            UIController.NextForm = New frmReopenCondition(strflightNum, dtDeparture)
                            UIController.NextForm.ShowDialog()
                        Else
                            Logger.LogMessage("InvalidFlight", LogType.Trace, "frmFlightInquiryForClose.cmdNext_Click")
                            MyBase.SetError("ALREADY OPEN")
                            MyBase.SetFocus(Me.txtFlight)
                            Exit Sub
                            'End If
                        End If
                    ElseIf ConnectionManager.IsConnected Then
                        'Pending - invoke webservice to reopen() flight
                    End If
                ElseIf UIController.CurrentFunction = SafetracFunction.CloseFlight Then
                    If MyBase.FlightsCollection.IsFlightValid(strflightNum, dtDeparture) Then
                        If FlightsCollection.CurrentFlight.IsClosed = False Then
                            Try
                                iRet = Common.CheckBagsToUnload(strflightNum, dtDeparture)
                                Select Case iRet
                                    Case RESULT_UNLOADBAGS_NO ' if no bags to be unloaded,then proceed to the load summary
                                        dsLoadSummary = FlightsCollection.CurrentFlight.GetLoadSummary
                                        If Not dsLoadSummary Is Nothing Then
                                            UIController.NextForm = New frmLoadSummary(dsLoadSummary)
                                            UIController.NextForm.ShowDialog()
                                        End If
                                    Case RESULT_UNLOADBAGS_YES 'Show Warning if still more bags to be unloaded are present
                                        btnNext.Enabled = False
                                        Dim objUnload As New dlgUnloadBagWarning()
                                        objUnload.ShowDialog()
                                        Exit Sub
                                End Select
                            Catch ex As Exception
                            End Try
                        Else
                            MyBase.SetError("ALREADY CLOSED")
                            MyBase.SetFocus(Me.txtFlight)
                            Exit Sub
                        End If
                    ElseIf ConnectionManager.IsConnected Then 'non configured flight
                        'Pending - invoke webservice to close flight
                    End If
                End If
            End If
        End Sub

        Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
            Try
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                Else
                    UIController.NextForm = New frmCloseReopenFlight()
                    UIController.NextForm.ShowDialog()
                End If
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub frmFlightInquiryForClose_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            lblEnterFlight.BackColor = Color.Black
        End Sub
    End Class
End Namespace
