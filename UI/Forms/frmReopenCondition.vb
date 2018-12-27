Imports System.Xml
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils


Namespace NWA.Safetrac.Scanner.UI

    Public Class frmReopenCondition

        Private _strFlightNum As String
        Private _dtFlightDate As NWADateTime
        Public Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime)

            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            _strFlightNum = flightNum
            _dtFlightDate = flightDate

        End Sub

        Private Sub frmReopenCondition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("Reopen Flight:")
            MyBase.HideFooter()
        End Sub


        Private Sub cmdReopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReopen.Click
            Try

                Dim iRet As ReturnCodes
                Dim strLog As String

                Try
                    strLog = String.Format("Before Reopen : FlightNum = {0} FlightDate = {1}", _strFlightNum, _dtFlightDate)
                    Logger.LogMessage(strLog, LogType.Information, "frmReopenCondition.cmdReopen_Click")

                    iRet = FlightsCollection.Flights(_strFlightNum, _dtFlightDate).Reopen()
                    UIController.NextForm = New frmReopenResult(iRet)
                    UIController.NextForm.ShowDialog()

                    strLog = String.Format("After Reopen : ReturnCode = {0}", iRet.ToString())
                    Logger.LogMessage(strLog, LogType.Information, "frmReopenCondition.cmdReopen_Click")

                Catch exSafetrac As SafetracException
                    Select Case exSafetrac.ErrorCode
                        Case ReturnCodes.DatabaseError
                    End Select
                Catch ex As Exception
                    Logger.LogException(ex)
                End Try
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
            Try
                Logger.LogMessage("UIController.NextForm = frmFlightInquiryForClose", LogType.Trace, "frmReopenCondition.cmdPrev_Click")
                UIController.NextForm = frmFlightInquiryForClose
                UIController.NextForm.ShowDialog()
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub frmReopenCondition_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If (e.KeyCode = Keys.P) Then
                Me.cmdReopen_Click(Me, Nothing)
            End If

        End Sub

        Private Sub frmReopenCondition_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            lblReadyToOpen.BackColor = Color.Black
        End Sub

        Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
            cmdReopen_Click(Me, Nothing)
        End Sub
    End Class
End Namespace