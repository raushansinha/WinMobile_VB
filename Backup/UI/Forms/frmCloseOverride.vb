
Imports NWA.Safetrac.Scanner.BO
Namespace NWA.Safetrac.Scanner.UI
    Public Class frmCloseOverride
        Public Const RESULT_WS_OK = 0
        Public Const RESULT_LD_OK = 1                  ' Success
        Public Const RESULT_LD_ERR = 2                 ' some Error
        Public Const RESULT_LD_RECS_NOTSENT = 3         ' Records not sent to WFLT

        Private _strFlightNum As String
        Private _dtFlightDate As NWADateTime

        Public Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime)

            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
            _strFlightNum = flightNum
            _dtFlightDate = flightDate
        End Sub

        Private Sub frmCloseOverride_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("**Close Flight**")
            MyBase.HideFooter()
        End Sub



        Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            MyBase.GoToMainMenu()
        End Sub

        Private Sub cmdOverride_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOverride.Click
            'Dim iRet As ReturnCodes

            'UnComent below line while integrating webService
            ' iRet = FlightsCollection.Flights(_strFlightNum, _dtFlightDate).Close(True)


            'pending - include return codes

            'Select Case iRet

            '    Case RESULT_LD_OK

            UIController.NextForm = New frmVerifyClock(_strFlightNum, _dtFlightDate)
            UIController.NextForm.ShowDialog()
            '    Case RESULT_LD_RECS_NOTSENT
            '        ShowError("RECORDS PENDING", "Records to be sent to WFLT", _
            '                    "Please wait one minute and try again.")

            '    Case RESULT_LD_ERR
            '        ' Message should already be displayed; e.g. SOAP error

            '    Case Else
            '        ShowError("WEBSERVICE ERROR", "Flight Close Error", GetLDResult())

            'End Select
        End Sub

        Private Sub frmCloseOverride_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Me.cmdCancel_Click(Me, Nothing)
            End If
            If e.KeyCode = Keys.O Then
                Me.cmdOverride_Click(Me, Nothing)
            End If


        End Sub

        Private Sub frmCloseOverride_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            lblWRFLResponce.BackColor = Color.Black
        End Sub
    End Class
End Namespace