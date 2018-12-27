Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.BO

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmCloseReopenFlight


        ''' <summary>
        ''' Go to frmFlightInquiryForClose Form
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
            UIController.NextForm = New frmFlightInquiryForClose()
            UIController.NextForm.ShowDialog()
        End Sub

        ''' <summary>
        '''  FORM LOAD
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub frmCloseReopenFlight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            imgWizard.Image = Images.WIZARD
            If UIController.CurrentFunction = SafetracFunction.CloseFlight Then
                lblMessage.Text = "This function will assist with closing a flight"
                MyBase.SetHeader("Close Flight")
                lblAppVersion.Text = MyBase.Scanner.AppVersion.ToString()
            ElseIf UIController.CurrentFunction = SafetracFunction.ReopenFlight Then
                lblMessage.Text = "This function will assist with reopening a flight."
                MyBase.SetHeader("Reopen Flight")
                lblAppVersion.Visible = False
            End If
        End Sub

        Private Sub frmCloseReopenFlight_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            lblWelCome.BackColor = Color.Black
        End Sub
    End Class
End Namespace