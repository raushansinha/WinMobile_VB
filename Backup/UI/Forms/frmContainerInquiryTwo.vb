Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Namespace NWA.Safetrac.Scanner.UI
    Public Class frmContainerInquiryTwo

        Private _strContainerName As String

        Public ReadOnly Property ContainerName() As String
            Get
                return _strContainerName
            End Get
        End Property

        Public Overrides Sub OnScan(ByVal sender As Object, ByVal e As Hardware.ScanEventArgs)
            txtULDSheet.Text = e.ScannedValue
            txtULDSheet_KeyDown(sender, New KeyEventArgs(Keys.Enter))
        End Sub

        Private Sub frmULDCartInquiryTwo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If UIController.CurrentFunction = SafetracFunction.PositionContainer Then
                MyBase.SetHeader("ULD Position")
            ElseIf UIController.CurrentFunction = SafetracFunction.ChangeContainerDefinition Then
                MyBase.SetHeader("ULD Definition")
            ElseIf UIController.CurrentFunction = SafetracFunction.CreateContainerSheetNumber Then
                MyBase.SetHeader("ULD Sheet Creation")
            ElseIf UIController.CurrentFunction = SafetracFunction.CreateMultipleContainerSheets Then
                MyBase.SetHeader("ULD Sheet Creation")
            End If
            MyBase.Reader.Enable()
            MyBase.SetFocus(txtULDSheet)
        End Sub

        Private Sub txtULDSheet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtULDSheet.KeyDown
            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If

                Try
                    Dim strContainer As String = txtULDSheet.Text.Trim.ToUpper
                    'Dim blnIsContainerNum As Boolean

                    If MyBase.IsErrorEnabled Then
                        MyBase.ClearError()
                        Exit Sub
                    End If

                    If Validate.IsContainerNumValid(strContainer) Then
                        MyBase.SetFooter("Enter ULD")
                        'blnIsContainerNum = True
                        'Me.IdentifyFlightForContainer(strContainer, blnIsContainerNum)
                    ElseIf BO.Validate.IsULDNumFormatValid(strContainer) Then
                        'user has entered ULD number
                        If UIController.CurrentFunction = SafetracFunction.CreateContainerSheetNumber Then
                            UIController.NextForm = New frmCreateContainerSheetNum(strContainer)
                            UIController.NextForm.ShowDialog()
                            MyBase.SetError("")
                            Exit Sub
                        ElseIf UIController.CurrentFunction = SafetracFunction.CreateMultipleContainerSheets Then
                            DialogResult = Windows.Forms.DialogResult.OK
                            _strContainerName = strContainer
                            Me.Close()
                        End If
                        'blnIsContainerNum = False
                        'Me.IdentifyFlightForContainer(strContainer, blnIsContainerNum)
                    Else
                        Logger.LogMessage("Invalid Format", LogType.Trace, "frmContainerSummary.btnLookup_Click")
                        MyBase.SetError(DisplayMessages.InvalidULDFormat)
                        SetFocus(txtULDSheet)
                    End If
                Catch safetracEx As SafetracException
                    Logger.LogException(safetracEx)
                Catch ex As Exception
                    Logger.LogException(ex)
                End Try
            End If
        End Sub

        Private Sub txtULDSheet_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtULDSheet.GotFocus
            MyBase.SetFocus(txtULDSheet)
        End Sub

        Private Sub txtULDSheet_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtULDSheet.LostFocus
            txtULDSheet.Text = txtULDSheet.Text.Trim.ToUpper
        End Sub

        Private Sub frmContainerInquiryTwo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                If UIController.CurrentFunction = SafetracFunction.CreateMultipleContainerSheets Then
                    DialogResult = Windows.Forms.DialogResult.Cancel
                    Me.Close()
                Else
                    MyBase.GoToMainMenu()
                End If
            End If
        End Sub

    End Class
End Namespace