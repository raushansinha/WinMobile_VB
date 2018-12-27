Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmFlightReadyToClose
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
        

        Private Sub cmdStartLD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartLD.Click
            Dim strLog As String = String.Empty

            Try

                ' SendTestDataHTML
                strLog = String.Format("Before Flight Close FlightNum = {0}, Date = {1}", _strFlightNum, _dtFlightDate)
                Logger.LogMessage(strLog, LogType.Information, "frmFlightReadyToClose.cmdStartLD_Click")


                Dim iRet As ReturnCodes

                'UnComent below line while integrating webService
                ' iRet = FlightsCollection.Flights(_strFlightNum, _dtFlightDate).Close(False)
                'pending - include return codes

                strLog = String.Format("After Flight Close ReturnCode = {0}", iRet.ToString())
                Logger.LogMessage(strLog, LogType.Information, "frmFlightReadyToClose.cmdStartLD_Click")

                'Select Case iRet

                '    Case RESULT_LD_OK

                UIController.NextForm = New frmCloseOverride(_strFlightNum, _dtFlightDate)
                UIController.NextForm.ShowDialog()

                '    Case RESULT_LD_RECS_NOTSENT
                '        ShowError("RECORDS PENDING", "Records to be sent to WFLT", _
                '                    "Please wait one minute and try again.")

                '    Case RESULT_LD_ERR
                '        ' Message should already be displayed; e.g. SOAP error

                '    Case Else
                '        ShowError("WEBSERVICE ERROR", "Flight Close Error", GetLDResult())

                'End Select
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub


        Private Sub frmFlightReadyToClose_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
           
            If e.KeyCode = Keys.C Then
                Me.cmdStartLD_Click(Me, Nothing)
            End If


        End Sub

        Private Sub frmFlightReadyToClose_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("Close Flight:" & _strFlightNum)
            MyBase.HideFooter()
        End Sub

        Private Sub frmFlightReadyToClose_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            lblReadyToLD.BackColor = Color.Black
        End Sub

    End Class
End Namespace