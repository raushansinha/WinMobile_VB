Imports NWA.Safetrac.Scanner.BO
Namespace NWA.Safetrac.Scanner.UI

    Public Class dlgConfirmMergeContainers
        Public Sub New(ByVal fromFlightNum As String, ByVal fromFlightDate As String, ByVal toFlightNum As String, _
                    ByVal toFlightDate As String, ByVal fromULDNum As String, ByVal fromULDName As String, _
                    ByVal toULDNum As String, ByVal toULDName As String)


            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            lblConfirmFromDate.Text = fromFlightDate
            lblConfirmFromFlt.Text = fromFlightNum
            lblFromContainerName.Text = fromULDName
            lblFromContainerNum.Text = fromULDNum

            lblConfirmToDate.Text = toFlightDate
            lblConfirmToFlt.Text = toFlightNum
            lblToContainerName.Text = toULDName
            lblToContainerNum.Text = toULDNum

        End Sub

        Public Sub New(ByVal fromFlightNum As String, ByVal fromFlightDate As String, ByVal toFlightNum As String, _
                    ByVal toFlightDate As String, ByVal fromBinNum As String, ByVal toBinNum As String)

            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

            lblConfirmFromDate.Text = fromFlightDate
            lblConfirmFromFlt.Text = fromFlightNum
            lblFromContainerName.Text = fromBinNum
            lblFromContainerNum.Text = String.Empty

            lblConfirmToDate.Text = toFlightDate
            lblConfirmToFlt.Text = toFlightNum
            lblToContainerName.Text = toBinNum
            lblToContainerNum.Text = String.Empty

        End Sub
        Private Sub frmMergeContainersConfirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'lblSingleHeader.Text = Headers.ConfirmMerge

        End Sub
        Private Sub frmMergeContainersConfirm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Y Then
                DialogResult = Windows.Forms.DialogResult.Yes
                Me.Close()
            ElseIf e.KeyCode = Keys.N Then
                DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If
        End Sub
    End Class
End Namespace