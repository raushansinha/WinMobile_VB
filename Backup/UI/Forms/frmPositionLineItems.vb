Imports System.Data
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI

    Public Class frmPositionLineItems

        Private _drLineItem As DataRow
        Private _strLineItemSeqNum As String
        Private _strPosition As String

        Public Sub New(ByVal lineItem As DataRow)
            Try
                InitializeComponent()
                _drLineItem = lineItem
                _strLineItemSeqNum = _drLineItem("LIN_ITEM_SEQ_NUM")
                ' MsgBox(_drLineItem(0))
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub frmPositionLineItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                MyBase.SetHeader("View Line Items")
                MyBase.HideControl(fraWait)

                Dim binBulks As List(Of String) = MyBase.FlightsCollection.CurrentFlight.GetListOfBinBulks()
                cmbPos.DataSource = binBulks

                lblSelType.Text = _drLineItem("CMDTY_TYP_CDE").ToString
                lblSelWgt.Text = _drLineItem("AOT_CGO_WT_LBS").ToString
                lblSelComments.Text = _drLineItem("RMK_TXT").ToString
                If _drLineItem("POS_NUM") IsNot Nothing Then
                    _strPosition = _drLineItem("POS_NUM").ToString
                    'cmbPos.SelectedValue = _strPosition
                    '_drLineItem("POS_NUM").ToString()
                    cmbPos.SelectedIndex = 0
                    If cmbPos.Items.IndexOf(_strPosition) <> -1 Then
                        cmbPos.SelectedIndex = cmbPos.Items.IndexOf(_strPosition)
                    Else
                        cmbPos.SelectedIndex = 0
                    End If

                End If
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub cmbPos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPos.SelectedIndexChanged
            'If MyBase.IsErrorEnabled Then
            '    MyBase.ClearError()
            '    Exit Sub
            'Else
            '    cmdConfirmLoad_Click(Me, Nothing)
            'End If
        End Sub

        Private Sub cmdConfirmLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmLoad.Click

            Dim strPosition As String = cmbPos.Text.Trim
            Dim strSelectedReason As String
            Dim strLog As String

            If cmbPos.SelectedValue <> _strPosition Then
                Try
                    If strPosition = String.Empty Then
                        MyBase.SetError("NEED POSITION")
                        Logger.LogMessage("POSITION Empty", LogType.Warning, "frmPositionLineItems.cmdConfirmLoad_Click")
                        Exit Sub
                    ElseIf strPosition = "XX" Then
                        Dim strCommdityType As String = _drLineItem("CMDTY_TYP_CDE").ToString
                        strLog = String.Format("CommdityType = {0}", strCommdityType)
                        Logger.LogMessage(strLog, LogType.Trace, "frmPositionLineItems.cmdConfirmLoad_Click")

                        If strCommdityType = "C" Or strCommdityType = "F" Or strCommdityType = "QF" Or _
                        strCommdityType = "V" Or strCommdityType = "C*" Or strCommdityType = "F*" Or _
                        strCommdityType = "QF" Or strCommdityType = "V*" Then
                            ' Ask user for reason code for removing freight
                            Dim objSelectReason As New frmSelectReason
                            objSelectReason.ShowDialog()
                            strSelectedReason = objSelectReason.Reason
                            strLog = String.Format("SelectedReason = {0}", strSelectedReason)
                            Logger.LogMessage(strLog, LogType.Trace, "frmPositionLineItems.cmdConfirmLoad_Click")

                            strLog = String.Format("Before UnloadLineItem : LineItemSeqNum = {0}", _strLineItemSeqNum)
                            Logger.LogMessage(strLog, LogType.Information, "frmPositionLineItems.cmdConfirmLoad_Click")
                            Dim retCode As ReturnCodes

                            'pending - update reason to db query
                            retCode = MyBase.FlightsCollection.CurrentFlight.UnloadLineItem(_strLineItemSeqNum, strSelectedReason)

                            strLog = String.Format("After UnloadLineItem : ReturnCode = {0}", retCode.ToString())
                            Logger.LogMessage(strLog, LogType.Information, "frmPositionLineItems.cmdConfirmLoad_Click")

                            'do what  - pending
                        Else
                            ' Not freight - Send an "XX" to cut
                            'MyBase.ShowControl(fraWait)
                            Dim retCode As ReturnCodes

                            strLog = String.Format("Before UnloadLineItem : LineItemSeqNum = {0}", _strLineItemSeqNum)
                            Logger.LogMessage(strLog, LogType.Information, "frmPositionLineItems.cmdConfirmLoad_Click")

                            retCode = MyBase.FlightsCollection.CurrentFlight.UnloadLineItem(_strLineItemSeqNum)

                            strLog = String.Format("After UnloadLineItem : ReturnCode = {0}", retCode.ToString())
                            Logger.LogMessage(strLog, LogType.Information, "frmPositionLineItems.cmdConfirmLoad_Click")

                            'MyBase.HideControl(fraWait)
                            Select Case retCode
                                Case ReturnCodes.Ok
                                    UIController.NextForm = New frmViewLineItems()
                                    UIController.NextForm.ShowDialog()
                                Case ReturnCodes.NotOk
                                    MyBase.SetError("NO DATA FOUND")
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
                        End If
                    Else
                        'MyBase.ShowControl(fraWait)
                        Dim retCode As ReturnCodes
                        strPosition = cmbPos.SelectedItem

                        strLog = String.Format("Before PositionLineItem : LineItemSeqNum = {0}", _strLineItemSeqNum)
                        Logger.LogMessage(strLog, LogType.Information, "frmPositionLineItems.cmdConfirmLoad_Click")

                        retCode = MyBase.FlightsCollection.CurrentFlight.BinBulks(strPosition).PositionLineItem(_strLineItemSeqNum.Trim)

                        strLog = String.Format("After PositionLineItem : ReturnCode = {0}", retCode.ToString())
                        Logger.LogMessage(strLog, LogType.Information, "frmPositionLineItems.cmdConfirmLoad_Click")

                        Select Case retCode
                            Case ReturnCodes.Ok
                                UIController.NextForm = New frmViewLineItems()
                                UIController.NextForm.ShowDialog()
                            Case ReturnCodes.NotOk
                                MyBase.SetError("NO DATA FOUND")
                            Case ReturnCodes.FlightClosed
                                MyBase.SetError(DisplayMessages.FlightClosed)
                                Exit Sub
                            Case ReturnCodes.FlightDeparted
                                MyBase.SetError(DisplayMessages.FlightDeparted)
                                Exit Sub
                            Case ReturnCodes.DatabaseError
                                MyBase.SetError(DisplayMessages.DatabaseError)
                                Exit Sub
                            Case Else
                        End Select
                        'MyBase.HideControl(fraWait)
                    End If

                Catch ex As Exception
                    Logger.LogException(ex)
                End Try
            End If
        End Sub

        Private Sub frmPositionLineItems_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Try
                    UIController.NextForm = New frmViewLineItems()
                    UIController.NextForm.ShowDialog()
                    Logger.LogMessage("UIController.NextForm = New frmViewLineItems()", LogType.Trace, "frmPositionLineItems.frmPositionLineItems_KeyDown")
                Catch ex As Exception
                    Logger.LogException(ex)
                End Try
            End If
        End Sub
    End Class

End Namespace
