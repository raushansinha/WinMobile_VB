Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Namespace NWA.Safetrac.Scanner.UI
    Public Class frmVerifyClock
        Private _strFlightNum As String
        Private _dtFlightDate As NWADateTime

        Public Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime)

            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            _strFlightNum = flightNum
            _dtFlightDate = flightDate

        End Sub
        Private Sub frmVerifyClock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("**Verify Clock**")
            MyBase.HideFooter()

            ' Show clock number
            lblClock.Text = Scanner.CurrentUser.UserID
        End Sub



        Private Sub cmdVerify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerify.Click
            Dim iRet As ReturnCodes


            'iRet = FlightsCollection.Flights(_strFlightNum, _dtFlightDate).VerifyClock(_strFlightNum, _dtFlightDate, lblClock.Text)
            'pending - include return codes

            'Select Case iRet
            '    Case RESULT_CLK_OK

            Logger.LogMessage("UIController.NextForm = New frmVerifyClockMessage()", LogType.Trace, "frmVerifyClock.cmdVerify_Click")
            UIController.NextForm = New frmVerifyClockMessage()
            UIController.NextForm.ShowDialog()

            '    Case RESULT_CLK_NO_PREPLAN
            '        Me.Hide()
            '        ShowError("VERIFY ERROR", "NO PRE PLAN", "This flight has not been preplanned.  Please call CLC for help.")

            '    Case Else
            '        Me.Hide()

            'End Select
        End Sub

        Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Logger.LogMessage("GoToMainMenu", LogType.Trace, "frmVerifyClock.cmdCancel_Click")
            MyBase.GoToMainMenu()
        End Sub

        Private Sub chkCertify_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCertify.CheckStateChanged
            If chkCertify.Checked Then
                cmdVerify.Enabled = True
            Else
                cmdVerify.Enabled = False
            End If
        End Sub

        Private Sub frmVerifyClock_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Me.cmdCancel_Click(Me, Nothing)
            End If

        End Sub

        Private Sub frmVerifyClock_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            lblClockNumNeeded.BackColor = Color.Black
        End Sub
    End Class
End Namespace