Imports System.Data
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.BO
Namespace NWA.Safetrac.Scanner.UI
    Public Class frmViewBagsOnAlert

        Private _strFlightNum As String
        Private _dtDeparture As NWADateTime

        Public Sub New(ByVal flightNum As String, ByVal departureDate As NWADateTime)
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
            _strFlightNum = flightNum
            _dtDeparture = departureDate
        End Sub

        Private Sub frmViewBagsOnAlert_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            MyBase.SetHeader("Bagtag Alerts")
            MyBase.UpdateUserActionTime()

            ' Set labels
            lblFlight.Text = _strFlightNum ' frmSetBagtagAlert.txtFlight.Text
            lblDate.Text = _dtDeparture.NWAFormat ' frmSetBagtagAlert.txtDate.Text
            lblStation.Text = MyBase.Scanner.CityCode

            Try
                Dim strLog As String
                Dim dsBagsOnAlert As DataSet

                strLog = String.Format("Before GetBagsOnAlert : Flight = {0} Departure = {1}", _strFlightNum, _dtDeparture)
                Logger.LogMessage(strLog, LogType.Information, "frmViewBagsOnAlert.frmViewBagsOnAlert_Load")

                dsBagsOnAlert = MyBase.FlightsCollection.Flights(_strFlightNum, _dtDeparture).GetBagsOnAlert()

                Dim dataRow As DataRow

                If dsBagsOnAlert.Tables(0).Rows.Count = 0 Then
                    lstAlertBags.Items.Add("[NO ALERTS SET]")
                    btnRemove.Enabled = False
                Else
                    For Each dataRow In dsBagsOnAlert.Tables(0).Rows
                        lstAlertBags.Items.Add(dataRow(0))
                    Next
                    lstAlertBags.SelectedIndex = 0
                    btnRemove.Enabled = True
                End If
                strLog = String.Format("After GetBagsOnAlert : AlertBags = {0}", lstAlertBags)
                Logger.LogMessage(strLog, LogType.Information, "frmViewBagsOnAlert.frmViewBagsOnAlert_Load")

            Catch ex As Exception
                Logger.LogException(ex)
            End Try

            ' Set focus
            lstAlertBags.Focus()
            MyBase.Refresh()
            MyBase.BringToFront()
            Me.Refresh()
            Me.BringToFront()
        End Sub

        Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
            MyBase.UpdateUserActionTime()
            Dim enumRet As ReturnCodes
            Dim strLog As String

            Try
                If lstAlertBags.SelectedIndex >= 0 Then
                    If lstAlertBags.SelectedItem <> "[NO ALERTS SET]" Then
                        fraWait.Visible = True
                        fraWait.BringToFront()

                        strLog = String.Format("Before RemoveBagAlert : Flight = {0} Departure = {1} AlertBag = {2}", lblFlight.Text, _dtDeparture, lstAlertBags.SelectedItem)
                        Logger.LogMessage(strLog, LogType.Information, "frmViewBagsOnAlert.cmdRemove_Click")

                        enumRet = MyBase.FlightsCollection.Flights(lblFlight.Text, _dtDeparture).RemoveBagAlert(lstAlertBags.SelectedItem)

                        strLog = String.Format("After RemoveBagAlert : ReturnCode = {0}", enumRet.ToString())
                        Logger.LogMessage(strLog, LogType.Information, "frmViewBagsOnAlert.cmdRemove_Click")

                        fraWait.Visible = False
                        Select Case enumRet
                            Case ReturnCodes.Ok
                                Logger.LogMessage("UI.NextForm = New frmBagAlertMenu(DisplayMessages.RemoveAlert)", LogType.Trace, "frmViewBagsOnAlert.cmdRemove_Click")
                                UI.NextForm = New frmBagAlertMenu(DisplayMessages.RemoveAlert)
                                UI.NextForm.ShowDialog()
                            Case Else
                                Logger.LogMessage("UI.NextForm = New frmBagAlertMenu(DisplayMessages.AlertError)", LogType.Trace, "frmViewBagsOnAlert.cmdRemove_Click")
                                UI.NextForm = New frmBagAlertMenu(DisplayMessages.AlertError)
                                UI.NextForm.ShowDialog()
                        End Select
                    End If
                End If
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub lbList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstAlertBags.KeyDown
            If e.KeyCode = Keys.Enter Then
                cmdRemove_Click(sender, e)
            End If
        End Sub

        Private Sub frmViewBagsOnAlert_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Logger.LogMessage("UIController.NextForm = New frmBagAlertMenu()", LogType.Trace, "frmViewBagsOnAlert.frmViewBagsOnAlert_KeyDown")
                UIController.CurrentFunction = SafetracFunction.AlertMenu
                UIController.NextForm = New frmBagAlertMenu()
                UIController.NextForm.ShowDialog()
            ElseIf e.KeyCode = Keys.Enter Then
                cmdRemove_Click(sender, e)
            End If
        End Sub
    End Class
End Namespace
