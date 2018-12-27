
Imports System.Data
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmLoadDetail

        Dim _dsLineItems As DataSet
        Dim _dsLoadSummary As DataSet
        Private _strFlightNum As String
        Private _dtFlightDate As NWADateTime
        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
        End Sub

        Private Sub frmLoadDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("Close Flight:" & _strFlightNum)
            MyBase.HideFooter()
            'view line items code copy pasted below
            Try
                Logger.LogMessage("GetLineItems", LogType.Trace, "frmLoadDetail_Load")
                _dsLineItems = MyBase.FlightsCollection.CurrentFlight.GetLineItems()
                If _dsLineItems.Tables(0).Rows.Count > 0 Then
                    'dsLineItems.Tables(0).Columns("LIN_ITEM_SEQ_NUM")
                    dgLoadDetail.TableStyles.Add(getGridStyle(_dsLineItems))
                    dgLoadDetail.DataSource = _dsLineItems.Tables(0)
                    'pending - hide unecessary colums, align the grid appropriately
                Else
                    MyBase.SetError("DATA NOT FOUND")
                End If
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click

            UIController.NextForm = New frmPreClose()
            UIController.NextForm.ShowDialog()
        End Sub

        Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
            UIController.NextForm = New frmFlightInquiryForClose()
            UIController.NextForm.ShowDialog()
        End Sub


        Private Sub cmdViewSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewSummary.Click
            Try
                _dsLoadSummary = FlightsCollection.CurrentFlight.GetLoadSummary
                UIController.NextForm = New frmLoadSummary(_dsLoadSummary)
                UIController.NextForm.ShowDialog()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub frmLoadDetail_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            lblViewTitle.BackColor = Color.Black
        End Sub

        Private Sub frmLoadDetail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If (e.KeyCode = Keys.V) Then
                Me.cmdViewSummary_Click(Me, Nothing)
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

    End Class
End Namespace