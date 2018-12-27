
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI

    Public Class dlgCreateNewAWB

        Private _intPcs As Integer = 0
        Private _intWgt As Integer = 0
        Private _strType As String = String.Empty
        Private _strDest As String = String.Empty
        Private _strFinalDest As String = String.Empty

        Public ReadOnly Property Pieces() As Integer
            Get
                Return _intPcs
            End Get
        End Property

        Public ReadOnly Property Weight() As Integer
            Get
                Return _intWgt
            End Get
        End Property

        Public ReadOnly Property Type() As String
            Get
                Return _strType
            End Get
        End Property

        Public ReadOnly Property Destination() As String
            Get
                Return _strDest
            End Get
        End Property

        Public ReadOnly Property FinalDestination() As String
            Get
                Return _strFinalDest
            End Get
        End Property

        Private Sub frmCreateNewAWB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            Try

                If txtPcs.Text.Length = 0 Then
                    lblFooter.Text = "INVALID PCS"
                    SetFocus(txtPcs)
                    Exit Sub
                Else
                    If Not IsNumeric(txtPcs.Text) Then
                        lblFooter.Text = "INVALID PCS"
                        SetFocus(txtPcs)
                        Exit Sub
                    End If
                End If

                ' Validate Weight
                If txtWgt.Text.Length = 0 Then
                    lblFooter.Text = "INVALID WEIGHT"
                    SetFocus(txtWgt)
                    Exit Sub
                Else
                    If Not IsNumeric(txtWgt.Text) Then
                        lblFooter.Text = "INVALID WEIGHT"
                        SetFocus(txtWgt)
                        Exit Sub
                    End If
                End If

                ' Validate Type
                If cmbTypes.Text.Trim = "" Then
                    lblFooter.Text = "INVALID TYPE"
                    cmbTypes.Focus()
                    Exit Sub
                End If

                _intPcs = txtPcs.Text
                _intWgt = txtWgt.Text
                _strType = cmbTypes.Text
                Me.Close()

            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub frmCreateNewAWB_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Filling combobox with freight commodity types
            cmbTypes.Items.Clear()
            cmbTypes.Items.Add("C")
            cmbTypes.Items.Add("F")
            cmbTypes.Items.Add("QF")
            cmbTypes.Items.Add("V")
            txtPcs.Focus()
            lblFooter.Text = String.Empty
        End Sub

        Public Sub SetFocus(ByRef txtBox As TextBox)
            Try
                txtBox.Focus()
                txtBox.SelectionStart = 0
                txtBox.SelectionLength = txtBox.Text.Length
            Catch notSupportedEx As NotSupportedException
                System.Diagnostics.Debug.WriteLine(notSupportedEx.ToString)
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

    End Class
End Namespace
