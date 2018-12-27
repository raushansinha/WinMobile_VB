Imports System.Data
Imports System.Xml
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmLoadSummary
        Private _strFlightNum As String
        Private _dtFlightDate As NWADateTime

        Public Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime)

            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            _strFlightNum = flightNum
            _dtFlightDate = flightDate
        End Sub
        Public Sub New(ByVal dsLoadDetail As DataSet)

            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.

        End Sub

        ''' <summary>
        ''' FORM LOAD
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub frmLoadSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("Close Flight")
            MyBase.HideFooter()
            Try
                'populate feilds from dataset values
                'lblB.text = 
                'lblIB.Text = 
                'lblMB.Text = 
                'lblHB.Text = 
                'lblPB.Text = 
                'lblC.Text = 
                'lblF.Text = 
                'lblQF.Text = 
                'lblV.Text = 
                'lblM.Text = 
                'lblFor.Text = 
                'lblSAM.Text = 
                'lblThru.Text = 

            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
            UIController.NextForm = New frmPreClose()
            UIController.NextForm.ShowDialog()
        End Sub

        Private Sub cmdViewDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewDetail.Click
            UIController.NextForm = New frmLoadDetail()
            UIController.NextForm.ShowDialog()
        End Sub

        Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
            UIController.NextForm = New frmFlightInquiryForClose()
            UIController.NextForm.ShowDialog()
        End Sub

        Private Sub frmLoadSummary_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            lblViewTitle.BackColor = Color.Black
        End Sub

        Private Sub frmLoadSummary_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If (e.KeyCode = Keys.V) Then
                Me.cmdViewDetail_Click(Me, Nothing)
            End If


        End Sub
    End Class
End Namespace