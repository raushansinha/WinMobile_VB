Imports NWA.Safetrac.Scanner.BO

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmBase
        Private Sub frmBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            UIController.CurrentFunction = SafetracFunction.Login
            UIController.PreviousForm = Nothing
            UIController.NextForm = New frmLogin()
            UIController.NextForm.ShowDialog()
        End Sub
    End Class
End Namespace
