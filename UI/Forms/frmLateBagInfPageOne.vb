Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Namespace NWA.Safetrac.Scanner.UI
    Public Class frmLateBagInfPageOne
        Private _strFlightNum As String
        Private _dtFlightDate As NWADateTime
        Public Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime)
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            _strFlightNum = flightNum
            _dtFlightDate = flightDate
        End Sub
        Private Sub frmLateBagInfPage1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("")
            'display list of bagtypes from Enumu into combobox 
            cmbType.Items.Clear()
            cmbType.Items.Add("B")
            cmbType.Items.Add("HB")
            cmbType.Items.Add("PB")
            cmbType.SelectedIndex = 0

            'Fill the comments into combobox 
            cmbComment.Items.Clear()
            cmbComment.Items.Add("Stroller")
            cmbComment.Items.Add("Car Seat")
            cmbComment.Items.Add("Wheelchair")
            cmbComment.Items.Add("Jetway Bags")
            cmbComment.SelectedIndex = 0
        End Sub
        Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
            If cmbType.Text = "HB" Then
                txtWgt.Text = "60"
                txtWgt.Enabled = False
            ElseIf cmbType.Text = "PB" Then
                txtWgt.Text = "20"
                txtWgt.Enabled = False
            Else
                txtWgt.Text = "30"
                txtWgt.Enabled = False
            End If
        End Sub
        Private Sub txtWgt_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWgt.GotFocus
            MyBase.SetFocus(txtWgt)
        End Sub
        Private Sub btnComment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbComment.SelectedIndexChanged
            If cmbComment.Text = "Wheelchair" Then
                'txtWgt.Text = "20"
            End If
        End Sub
        Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
            If cmbType.Text <> "" And txtWgt.Text <> "" And cmbComment.Text <> "" Then
                UIController.NextForm = New frmLateBagInfPageTwo(_strFlightNum, _dtFlightDate, cmbType.SelectedItem, txtWgt.Text, cmbComment.SelectedItem)
                UIController.NextForm.ShowDialog()
            Else
                Logger.LogMessage("", LogType.Trace, "frmLateBagInfPageOne.btnNext_Click")
                MyBase.SetError("SELECT VALUES")
                Exit Sub
            End If
        End Sub
    End Class
End Namespace
