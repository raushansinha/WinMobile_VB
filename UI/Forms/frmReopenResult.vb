Imports NWA.Safetrac.Scanner.Utils
Namespace NWA.Safetrac.Scanner.UI
    Public Class frmReopenResult

        Public Const RESULT_RECOV_OK = 101                    ' Success
        Public Const RESULT_RECOV_ERR = 102                   ' some Error
        Public Const RESULT_RECOV_NEEDS_RALL = 103            ' OK, but needs RALL to remove items
        Public Const RESULT_RECOV_NOT_FOUND = 104             ' Nothing found in flight_additional
        Public Const RESULT_RECOV_UPD_IN_PROGRESS = 105       ' CLC Update in progress

        Private _intReturnCode
        Public Sub New(ByVal iRet As Integer)

            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            _intReturnCode = iRet
            ' Add any initialization after the InitializeComponent() call.
        End Sub
        Private Sub frmReopenResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim strLog As String
            MyBase.SetHeader("Reopen Flight:")
            MyBase.HideFooter()
            strLog = String.Format("ReopenResult : ReturnCode = {0}", _intReturnCode.ToString())
            Logger.LogMessage(strLog, LogType.Information, "frmReopenResult.frmReopenResult_Load")
            Select Case _intReturnCode
                Case RESULT_RECOV_OK
                    lblStatusReopenDesc.Text = "You may continue scanning " & _
                                 "items on this flight."
                    lblStatusReopen.Text = "Flight opened successfully."
                Case RESULT_RECOV_NEEDS_RALL
                    lblStatusReopenDesc.Text = "RALL needed; contact CLC to allow offloading items."
                    lblStatusReopen.Text = "Flight opened successfully."
                Case RESULT_RECOV_NOT_FOUND
                    lblStatusReopenDesc.Text = "Flight not in Safetrac database; check flight and date entered."
                    lblStatusReopen.Text = "Flight reopen FAILED."
                Case RESULT_RECOV_UPD_IN_PROGRESS
                    lblStatusReopenDesc.Text = "FDSG Locked; Cannot reset until FDSG is released (2 minutes max)."
                    lblStatusReopen.Text = "FDSG Update In Progress"
                Case Else
                    lblStatusReopenDesc.Text = "There was an error"
                    lblStatusReopen.Text = "Flight reopen FAILED!"
            End Select
            cmdPrev.Enabled = False
            cmdDone.Focus()
        End Sub

        Private Sub cmdDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDone.Click
            Logger.LogMessage("GoToMainMenu", LogType.Trace, "frmReopenResult.cmdDone_Click")
            MyBase.GoToMainMenu()
        End Sub

        Private Sub frmReopenResult_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If (e.KeyCode = Keys.Enter) Then
                Me.cmdDone_Click(Me, Nothing)
            End If
        End Sub

        Private Sub frmReopenResult_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            lblReopenFlightRslt.BackColor = Color.Black
        End Sub
    End Class
End Namespace