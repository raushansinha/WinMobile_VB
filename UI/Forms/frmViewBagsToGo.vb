Imports System.Data
Imports NWA.Safetrac.Scanner.BO
Namespace NWA.Safetrac.Scanner.UI

    Public Class frmViewBagsToGo
        'Private _strFlightNum As String
        'Private _dtFlightDate As NWADateTime
        'Public Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime)
        '    ' This call is required by the Windows Form Designer.
        '    InitializeComponent()
        '    _strFlightNum = flightNum
        '    _dtFlightDate = flightDate
        'End Sub
        Private Sub btnSortDest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortDest.Click
            Dim ds As DataSet
            lblDestHeader.Visible = True
            lblDestHeader.BringToFront()
            lblXferCount.Visible = False
            lblStatusHeader.Visible = False
            lblSortMode.Text = " DEST"
            ds = FlightsCollection.CurrentFlight.GetBagsToGoByDest()
            PopulateNodes(ds, "DEST")
        End Sub

        Private Sub btnSortXFER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortXFER.Click
            Dim ds As DataSet
            lblXferCount.Visible = True
            lblXferCount.BringToFront()
            lblDestHeader.Visible = False
            lblStatusHeader.Visible = False
            lblSortMode.Text = " XFER"
            ds = FlightsCollection.CurrentFlight.GetBagsToGoByXFER()
            lblXferCount.Text = "XFER: " & ds.Tables(2).Rows(0)(0).ToString
            lblXferLocalCount.Text = "LOCAL: " & ds.Tables(2).Rows(0)(1).ToString
            PopulateNodes(ds, "XFER")
        End Sub
        Private Sub btnSortStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortStatus.Click
            Dim ds As DataSet
            lblStatusHeader.Visible = True
            lblStatusHeader.BringToFront()
            lblXferCount.Visible = False
            lblDestHeader.Visible = False
            lblSortMode.Text = " STATUS"
            ds = FlightsCollection.CurrentFlight.GetBagsToGoByStatus()
            PopulateNodes(ds, "STATUS")
        End Sub
        Private Sub PopulateNodes(ByVal ds As DataSet, ByVal sortBy As String)
            Try
                tvBagsToGo.Nodes.Clear()
                Dim tn As New TreeNode()
                Dim intParentNode As Integer, intCount As Integer
                Dim dtrParent As DataRow, dtrChild As DataRow
                intParentNode = 0
                For Each dtrParent In ds.Tables(0).Rows
                    tn = New TreeNode
                    For intCount = 0 To ds.Tables(0).Columns.Count - 1
                        tn.Text &= dtrParent(intCount) & "    "
                        ' & "  " & dtrParent(1) & "  " & dtrParent(2) & "   " & dtrParent(3)
                    Next
                    tvBagsToGo.Nodes.Add(tn)
                    For Each dtrChild In dtrParent.GetChildRows(sortBy)
                        tn = New TreeNode
                        For intCount = 1 To ds.Tables(1).Columns.Count - 1
                            tn.Text &= dtrChild(intCount) & "    "
                            ' & "   " & dtrChild(2)
                        Next
                        tvBagsToGo.Nodes(intParentNode).Nodes.Add(tn)
                    Next
                    intParentNode += 1
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Private Sub frmViewBagsToGo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                MyBase.GoToMainMenu()
            End If
        End Sub

      
        Private Sub frmViewBagsToGo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                MyBase.SetHeader("Bags To Go")
                lblFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                lblDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
                lblTime.Text = MyBase.FlightsCollection.CurrentFlight.EstimatedDepartureTime
                btnSortDest_Click(sender, e)
            Catch ex As Exception
            End Try
        End Sub
    End Class
End Namespace