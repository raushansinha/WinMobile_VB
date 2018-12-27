Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class dlgWeight

        Private _intWeight As Integer

        Public ReadOnly Property Weight() As Integer
            Get
                Return _intWeight
            End Get
        End Property

        Private Sub dlgWeight_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Enter Then
                If IsNumeric(txtManualWgt.Text) Then
                    Dim intWeight As Integer
                    intWeight = Convert.ToInt16(txtManualWgt.Text)
                    If intWeight > 0 Then
                        _intWeight = intWeight
                        Me.Close()
                    Else
                        lblFooter.Text = "INVALID WEIGHT"
                        txtManualWgt.Focus()
                        txtManualWgt.SelectionStart = 0
                        txtManualWgt.SelectionLength = txtManualWgt.Text.Length
                    End If
                Else
                    lblFooter.Text = "INVALID WEIGHT"
                    txtManualWgt.Focus()
                    txtManualWgt.SelectionStart = 0
                    txtManualWgt.SelectionLength = txtManualWgt.Text.Length
                End If
            End If
        End Sub

        Private Sub dlgWeight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            txtManualWgt.Focus()
            lblFooter.Text = String.Empty
        End Sub
    End Class
End Namespace
