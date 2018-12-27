
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.BO
Namespace NWA.Safetrac.Scanner.UI
    Public Class frmBagAlertMenu
        Sub New()
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
        End Sub

        Sub New(ByVal footerMessage As String)
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
            If footerMessage IsNot Nothing Then
                MyBase.SetFooter(footerMessage)
            Else
                MyBase.HideFooter()
            End If
        End Sub

        Private Sub frmBagAlertMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("Bagtag Alerts")
            MyBase.Reader.Enable()
            btnView.Focus()
        End Sub

        Private Sub btnMnuCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
            Try
                MyBase.UpdateUserActionTime()
                ' Setting current function to SetBagAlert.
                UIController.CurrentFunction = SafetracFunction.SetBagAlert
                ' Calls frmSetBagtagAlert and Dispose itself.
                UIController.NextForm = New frmSetBagtagAlert()
                UIController.NextForm.ShowDialog()
            Catch ex As Exception
                Logger.LogMessage("Create BagtagAlert", LogType.Trace, "frmBagAlertMenu.btnMnuCreate_Click")
            End Try
        End Sub

        Private Sub btnMnuRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
            Try
                MyBase.UpdateUserActionTime()
                ' Setting current function to a common SetBagAlert for Set/Remove.
                Logger.LogMessage("Remove Alerts function selected", LogType.Trace, "frmBagAlertMenu.btnMnuRemove_Click")
                UIController.CurrentFunction = SafetracFunction.RemoveBagAlert
                ' Calls frmRemoveBagtagAlert and Dispose itself
                UIController.NextForm = New frmSetBagtagAlert()
                UIController.NextForm.ShowDialog()
            Catch ex As Exception
                Logger.LogMessage("Remove BagtagAlert", LogType.Trace, "frmBagAlertMenu.btnMnuRemove_Click")
            End Try
        End Sub

        Private Sub btnMnuView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
            Try
                MyBase.UpdateUserActionTime()
                ' Setting current function to ViewListOfBagsOnAlert.
                UIController.CurrentFunction = SafetracFunction.ViewBagsOnAlert
                ' Calls frmRemoveBagtagAlert common for View/Remove
                UIController.NextForm = New frmSetBagtagAlert()
                UIController.NextForm.ShowDialog()
            Catch ex As Exception
                Logger.LogMessage("View BagtagAlert", LogType.Trace, "frmBagAlertMenu.btnMnuView_Click")
            End Try
        End Sub

        Private Sub frmBagAlertMenu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            MyBase.UpdateUserActionTime()
            If e.KeyCode = Keys.D1 Then
                Call btnMnuView_Click(sender, e)
            ElseIf e.KeyCode = Keys.D4 Then
                Call btnMnuCreate_Click(sender, e)
            ElseIf e.KeyCode = Keys.D7 Then
                Call btnMnuRemove_Click(sender, e)
            ElseIf e.KeyCode = Keys.Escape Then
                MyBase.GoToMainMenu()
            End If
        End Sub
    End Class
End Namespace