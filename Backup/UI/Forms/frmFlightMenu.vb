Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Namespace NWA.Safetrac.Scanner.UI
    Public Class frmFlightMenu

        Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
        End Sub
        Sub New(ByVal footerMessage As String, ByVal isError As Boolean)

            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.

            If footerMessage Is Nothing Or footerMessage = String.Empty Then
                MyBase.HideFooter()
            Else
                If isError Then
                    MyBase.SetError(footerMessage)
                Else
                    MyBase.SetFooter(footerMessage)
                End If
            End If

        End Sub

        Private Sub frmBagAlertMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("MANAGE FLIGHTS")
            MyBase.Reader.Enable()
            btnAdd.Focus()
        End Sub

        Private Sub frmBagAlertMenu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            MyBase.UpdateUserActionTime()
            Logger.LogMessage("Selected FlightManagement =" & e.KeyCode, LogType.Trace, "frmBagAlertMenu_KeyDown")
            ' When user enters from keypad.
            If e.KeyCode = Keys.D1 Then
                Call btnAdd_Click(sender, e)
            ElseIf e.KeyCode = Keys.D4 Then
                Call btnRemove_Click(sender, e)
            ElseIf e.KeyCode = Keys.D7 Then
                Call btnModify_Click(sender, e)
            ElseIf e.KeyCode = Keys.Escape Then
                'If Escape is pressed, goes back to main menu.
                MyBase.GoToMainMenu()
            End If
        End Sub


        Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
            Logger.LogMessage("Selected FlightManagement = AddFlight", LogType.Trace, "frmFlightMenu.btnAdd_Click")
            UIController.CurrentFunction = SafetracFunction.AddFlight
            UIController.NextForm = New frmAddFlight()
            UIController.NextForm.ShowDialog()
        End Sub

        Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
            Logger.LogMessage("Selected FlightManagement = RemoveFlight", LogType.Trace, "frmFlightMenu.btnRemove_Click")
            UIController.CurrentFunction = SafetracFunction.RemoveFlight
            UIController.NextForm = New frmRemoveFlight()
            UIController.NextForm.ShowDialog()
        End Sub

        Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
            Logger.LogMessage("Selected FlightManagement = ModifyFlight", LogType.Trace, "frmFlightMenu.btnModify_Click")
            UIController.CurrentFunction = SafetracFunction.ModifyFlight
            UIController.NextForm = New frmModifyFlight()
            UIController.NextForm.ShowDialog()
        End Sub
    End Class
End Namespace