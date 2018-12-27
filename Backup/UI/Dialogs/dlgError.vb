Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class dlgError

        Public Sub New(ByVal title As String, ByVal description As String)
            Try
                ' This call is required by the Windows Form Designer.
                InitializeComponent()
                ' Add any initialization after the InitializeComponent() call.
                cmdReport.Enabled = False
                lblErrorTitle.Text = title
                lblErrorDesc.Text = description
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace
