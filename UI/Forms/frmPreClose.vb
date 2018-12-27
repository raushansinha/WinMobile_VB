Imports System
Imports System.Net
Imports System.Xml
Imports System.Data
Imports System.IO
Imports System.Text
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmPreClose

        Dim _dsDetail As DataSet
        Private _strFlightNum As String
        Private _isFromLoadSummary As Boolean
        Private _dtFlightDate As NWADateTime

        'Public Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime, ByVal isFromLoadSummary As Boolean)

        '    ' This call is required by the Windows Form Designer.
        '    InitializeComponent()

        '    ' Add any initialization after the InitializeComponent() call.
        '    _strFlightNum = flightNum
        '    _dtFlightDate = flightDate
        '    _isFromLoadSummary = isFromLoadSummary

        'End Sub



        Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
            'If _isFromLoadSummary Then
            '    Logger.LogMessage("UIController.NextForm = New frmLoadSummary(_strFlightNum, _dtFlightDate)", LogType.Trace, "frmPreClose.cmdPrev_Click")
            '    UIController.NextForm = New frmLoadSummary(_strFlightNum, _dtFlightDate)
            '    UIController.NextForm.ShowDialog()
            'Else
            '    Logger.LogMessage("UIController.NextForm = New frmLoadDetail(_strFlightNum, _dtFlightDate)", LogType.Trace, "frmPreClose.cmdPrev_Click")
            '    UIController.NextForm = New frmLoadDetail(_strFlightNum, _dtFlightDate)
            '    UIController.NextForm.ShowDialog()
            'End If
        End Sub

        Private Sub cmdPreClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreClose.Click
            _dsDetail = New DataSet("PreClose")
            Dim memoryStream As New MemoryStream()
            Dim xmlTextWriter As New XmlTextWriter(memoryStream, UTF8Encoding.UTF8)
            Dim streamReader As New StreamReader(memoryStream)
            Dim strLog As String

            Dim str As String
            Try

                'Pending-webservices "Schema Hardcoded we have to fetch from webservices"
                str = "<SafetracSoapBody><PreClose>"
                str = str + "<PreCloseOut><Device_ID>HHT696</Device_ID><User_ID>Avinash</User_ID><PreClose_Ind>Y</PreClose_Ind></PreCloseOut>"
                str = str + "<PreCloseOut><Device_ID>HHT785</Device_ID><User_ID>Nishanth</User_ID><PreClose_Ind></PreClose_Ind></PreCloseOut>"
                str = str + "</PreClose></SafetracSoapBody>"

                memoryStream = New MemoryStream(System.Text.Encoding.UTF8.GetBytes(str))
                _dsDetail.ReadXml(memoryStream)

                strLog = String.Format("MemoryStream = ", memoryStream)
                Logger.LogMessage(strLog, LogType.Information, "frmPreClose.cmdPreClose_Click")

                Dim dtcCheck As DataColumn = New DataColumn(" Delete")
                'declaring a column named Delete
                dtcCheck.DataType = System.Type.GetType("System.Boolean")
                'setting the datatype for the column
                dtcCheck.DefaultValue = False
                _dsDetail.Tables("PreCloseOut").Columns.Add(dtcCheck)

                If (_dsDetail.Tables("PreCloseOut").Rows.Count) > 0 Then
                    Logger.LogMessage("UIController.NextForm = New frmPreCloseOverride(_strFlightNum, _dtFlightDate, _dsDetail)", LogType.Trace, "frmPreClose.cmdPreClose_Click")
                    UIController.NextForm = New frmPreCloseOverride(_strFlightNum, _dtFlightDate, _dsDetail)
                    UIController.NextForm.ShowDialog()
                Else
                    Logger.LogMessage("UIController.NextForm = New frmFlightReadyToClose(_strFlightNum, _dtFlightDate)", LogType.Trace, "frmPreClose.cmdPreClose_Click")
                    UIController.NextForm = New frmFlightReadyToClose(_strFlightNum, _dtFlightDate)
                    UIController.NextForm.ShowDialog()

                End If

            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub frmPreClose_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("PreClose:" & _strFlightNum)
            MyBase.HideFooter()
        End Sub

        Private Sub frmPreClose_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.P Then
                Me.cmdPreClose_Click(Me, Nothing)
            End If

        End Sub

        Private Sub frmPreClose_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            lblReadyToPreClose.BackColor = Color.Black
        End Sub
    End Class
End Namespace