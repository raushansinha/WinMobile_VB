
Imports System.Data
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmViewLineItems

        Dim _dtLastRefresh As Date
        Dim _dsLineItems As DataSet

        Private Sub frmViewLineItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("View Line Items")
            lblFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
            lblDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
            btnRefresh_Click(Me, Nothing)
        End Sub

        Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
            Try
                
                Logger.LogMessage("GetLineItems", LogType.Trace, "frmViewLineItems.btnRefresh_Click")
                _dsLineItems = MyBase.FlightsCollection.CurrentFlight.GetLineItems()

                If _dsLineItems.Tables(0).Rows.Count > 0 Then
                    dgLineItems.TableStyles.Add(getGridStyle(_dsLineItems))
                    dgLineItems.DataSource = _dsLineItems.Tables(0)
                Else
                    MyBase.SetError("DATA NOT FOUND")
                End If
                _dtLastRefresh = Date.Now
                lblLastRefresh.Text = _dtLastRefresh.ToString("ddMMM")
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
            Try
                If dgLineItems.CurrentRowIndex < 0 Then
                    MessageBox.Show("Please select a row to position")
                    Exit Sub
                Else
                    'MyBase.ShowControl(fraWait)
                    'If dgLineItems.CurrentRowIndex > 0 And dgLineItems.Item(dgLineItems.CurrentRowIndex, 3).ToString.ToLower <> "loose" Then
                    '    MsgBox("Positioning ULD/cart function not yet available.")
                    '    Exit Sub
                    'End If
                    'MyBase.HideControl(fraWait)
                    'Me.Refresh()
                End If
                Logger.LogMessage("UIController.NextForm = New frmPositionLineItems(Nothing)", LogType.Trace, "frmViewLineItems.cmdLoad_Click")
                Dim row As DataRow
                row = _dsLineItems.Tables(0).Rows(dgLineItems.CurrentRowIndex)
                UIController.NextForm = New frmPositionLineItems(row)
                UIController.NextForm.ShowDialog()
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub cmdUpdateAWBs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateAWBs.Click
            'update AWB's - call the existing .NET webservice
            If MyBase.FlightsCollection.CurrentFlight.ProcessFreight() Then
                btnRefresh_Click(sender, e)
            End If
        End Sub

        Private Sub tmrLastRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLastRefresh.Tick
            btnRefresh_Click(sender, e)
        End Sub

        Private Sub frmViewLineItems_Closing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            tmrLastRefresh.Enabled = False
            tmrLastRefresh.Interval = 0
        End Sub

        Private Sub frmViewLineItems_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Logger.LogMessage("GoToMainMenu", LogType.Trace, "frmViewLineItems.frmViewLineItems_KeyDown")
                MyBase.GoToMainMenu()
            End If
        End Sub

        Private Function getGridStyle(ByVal ds As DataSet) As DataGridTableStyle
            Try
                Dim dgS As New DataGridTableStyle
                Dim dgCoL As New DataGridTextBoxColumn, colIndex As Integer
                dgS.MappingName = _dsLineItems.Tables(0).TableName
                dgCoL.Width = 0
                dgCoL.MappingName = _dsLineItems.Tables(0).Columns(0).ColumnName
                dgS.GridColumnStyles.Add(dgCoL)
                For colIndex = 1 To ds.Tables(0).Columns.Count - 2
                    dgCoL = New DataGridTextBoxColumn
                    dgCoL.Width = 35
                    dgCoL.MappingName = _dsLineItems.Tables(0).Columns(colIndex).ColumnName
                    dgS.GridColumnStyles.Add(dgCoL)
                Next
                dgCoL = New DataGridTextBoxColumn
                dgCoL.Width = 60
                dgCoL.MappingName = _dsLineItems.Tables(0).Columns(ds.Tables(0).Columns.Count - 1).ColumnName
                dgS.GridColumnStyles.Add(dgCoL)
                Return dgS
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Private Sub dgLineItems_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLineItems.Click
            If dgLineItems.CurrentRowIndex >= 0 Then
                btnLoad.Enabled = True
            Else
                btnLoad.Enabled = False
            End If
            btnLoad.Enabled = True
        End Sub

    End Class
End Namespace
