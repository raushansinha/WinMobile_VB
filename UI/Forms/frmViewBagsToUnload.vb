
Imports System
Imports System.Text
Imports System.IO
Imports System.IO.Directory
Imports System.Exception
Imports System.Xml
Imports System.Data
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI

    Public Class frmViewBagsToUnload

        Private _dsReponse As DataSet = Nothing

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
        End Sub

        Public Sub New(ByVal dsReponse As DataSet)
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
            _dsReponse = dsReponse
        End Sub

        Private Sub frmViewBagsToUnload_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Logger.LogMessage("UIController.NextForm = New frmFlightInquiry", LogType.Trace, "frmViewBagsToUnload.frmViewBagsToUnload_KeyDown")
                UIController.NextForm = New frmFlightInquiry
                UIController.NextForm.ShowDialog()
            End If
        End Sub

        Private Sub frmListOfUnloadBags_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'populate the controls
            MyBase.SetHeader("ViewBagsToBeUnloaded")
            If _dsReponse Is Nothing Then
                'bags to unload for a configured flight
                lblFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                lblDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
                PopulateBagsToUnload()
            Else
                'web service response for a non-configured flight
                PopulateBagsToUnload(_dsReponse)
            End If
        End Sub

        Private Sub tvResults_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvResults.GotFocus
            btnExit.Text = "EXIT: TAB, then ESC"
        End Sub

        Private Sub tvResults_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvResults.LostFocus
            btnExit.Text = "EXIT: ESC"
        End Sub

        Private Sub PopulateBagsToUnload()
            Try
                Logger.LogMessage("GetBagsToUnload", LogType.Trace, "frmViewBagsToUnload.PopulateBagsToUnload()")
                Dim ds As DataSet = FlightsCollection.CurrentFlight.GetBagsToUnload()
                If ds IsNot Nothing Then
                    tvResults.Nodes.Clear()
                    Dim tn As New TreeNode()
                    Dim intParentNode As Integer, intCount As Integer
                    Dim dtrParent As DataRow, dtrChild As DataRow
                    intParentNode = 0
                    For Each dtrParent In ds.Tables("Position").Rows
                        tn = New TreeNode
                        For intCount = 0 To ds.Tables("Position").Columns.Count - 1
                            tn.Text &= dtrParent(intCount) & "    "
                            ' & "  " & dtrParent(1) & "  " & dtrParent(2) & "   " & dtrParent(3)
                        Next
                        tvResults.Nodes.Add(tn)
                        For Each dtrChild In dtrParent.GetChildRows("BagPosition")
                            tn = New TreeNode
                            ' For intCount = 1 To ds.Tables(1).Columns.Count - 1
                            tn.Text = dtrChild(0)
                            ' & "   " & dtrChild(2)
                            'Next
                            tvResults.Nodes(intParentNode).Nodes.Add(tn)
                        Next
                        intParentNode += 1
                    Next
                    For Each dtrParent In ds.Tables("Container").Rows
                        tn = New TreeNode
                        For intCount = 0 To ds.Tables("Container").Columns.Count - 1
                            tn.Text &= dtrParent(intCount) & "    "
                            ' & "  " & dtrParent(1) & "  " & dtrParent(2) & "   " & dtrParent(3)
                        Next
                        tvResults.Nodes.Add(tn)
                        For Each dtrChild In dtrParent.GetChildRows("BagContainer")
                            tn = New TreeNode
                            ' For intCount = 1 To ds.Tables(1).Columns.Count - 1
                            tn.Text = dtrChild(0)
                            ' & "   " & dtrChild(2)
                            'Next
                            tvResults.Nodes(intParentNode).Nodes.Add(tn)
                        Next
                        intParentNode += 1
                    Next
                Else
                    MyBase.SetFooter("No Bags to Unload")
                End If
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub PopulateBagsToUnload(ByVal ds As DataSet)
            Try

                'delete this code later and uncomment the below code
                Dim nodeTreeView As TreeNode = Nothing
                Dim intParent As Integer = 0
                Dim intChild As Integer
                Dim i As Integer = 0

                'intParent = ds.Tables("BagsToUnldOut").Rows.Count - 1
                'nodeTreeView = tvResults.Nodes.Add(ds.Tables("BagsToUnldOut").Rows(intParent).Item("CNTNR_ID").ToString)
                'For intChild = 0 To ds.Tables("BagsToUnldOut").Rows.Count - 1
                '    nodeTreeView.Nodes.Add(ds.Tables("BagsToUnldOut").Rows(intChild).Item("BAG_ID").ToString)
                'Next



                'Assumption
                'valid data  - populate to the tree view
                '            - bagatg associated with  ULD , CNTNR_ID = "NOULD" ,          BAG_ID = bagtag number , POS = BIN number
                '            - bagatg associated with hold , CNTNR_ID = container number , BAG_ID = bagtag number , POS = "NOBIN"
                'invalid data- do not populate but log in logmessages
                '            - bagatg associated with CNTNR_ID = container number , BAG_ID = bagtag number , POS = BIN number


                Dim objDataSet As New DataSet()
                Dim objDataView As New DataView
                Dim strTempNode As String = String.Empty
                Dim intCountRecs As Integer = String.Empty

                Dim tbBags As DataTable = New DataTable("BagsToUnldOutData")
                objDataSet.Tables.Add(tbBags)
                objDataView.Table = objDataSet.Tables("BagsToUnldOutData")
                objDataView.Sort = "[CNTNR_ID], POS"

                For intCountRecs = 0 To objDataView.Count - 1
                    If strTempNode Is Nothing Then
                        nodeTreeView = tvResults.Nodes.Add(objDataView.Item(intCountRecs).Row.Item("CNTNR_ID").ToString)
                        strTempNode = objDataView.Item(intCountRecs).Row.Item("CNTNR_ID").ToString
                        nodeTreeView.Nodes.Add(objDataView.Item(intCountRecs).Row.Item("BAG_ID").ToString)
                    Else
                        If objDataView.Item(intCountRecs).Row.Item("POS").ToString = "NOBIN" Then
                            If (objDataView.Item(intCountRecs).Row.Item("CNTNR_ID").ToString <> strTempNode) Then
                                nodeTreeView = tvResults.Nodes.Add(objDataView.Item(intCountRecs).Row.Item("CNTNR_ID").ToString)
                            End If
                            strTempNode = objDataView.Item(intCountRecs).Row.Item("CNTNR_ID").ToString
                            nodeTreeView.Nodes.Add(objDataView.Item(intCountRecs).Row.Item("BAG_ID").ToString)
                        ElseIf objDataView.Item(intCountRecs).Row.Item("CNTNR_ID").ToString = "NOULD" Then
                            If (objDataView.Item(intCountRecs).Row.Item("POS").ToString <> strTempNode) Then
                                nodeTreeView = tvResults.Nodes.Add(objDataView.Item(intCountRecs).Row.Item("POS").ToString)
                            End If
                            strTempNode = objDataView.Item(intCountRecs).Row.Item("POS").ToString
                            nodeTreeView.Nodes.Add(objDataView.Item(intCountRecs).Row.Item("BAG_ID").ToString)
                        Else
                            Debug.WriteLine("Bagtag has Both Container =" & objDataView.Item(intCountRecs).Row.Item("CNTNR_ID").ToString & " and Hold=" & objDataView.Item(intCountRecs).Row.Item("POS").ToString)
                        End If
                    End If
                Next

            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

    End Class
End Namespace