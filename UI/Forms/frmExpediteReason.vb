Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Namespace NWA.Safetrac.Scanner.UI

    Public Class frmExpediteReason

        Private Sub frmExpediteReason_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            Logger.LogMessage("Selected ExpediteReason=" & e.KeyCode, LogType.Trace, "frmExpediteReason_KeyDown")
            Select Case e.KeyCode
                Case Keys.D0, Keys.N, Keys.Escape
                    CacheManager.ExpediteCode = BOConstants.NoExpedite
                    If UIController.CurrentFunction = SafetracFunction.ExpediteBag Then
                        UIController.NextForm = New frmMainMenu
                        UIController.NextForm.ShowDialog()
                    ElseIf UIController.CurrentFunction = SafetracFunction.LoadBagIntoBinBulk Then
                        Me.Close()
                    ElseIf UIController.CurrentFunction = SafetracFunction.LoadBagToContainer Then
                        Me.Close()
                    End If
                Case Keys.D1, Keys.A
                    ' XRAY
                    CacheManager.ExpediteCode = BOConstants.ExpediteXRay
                    Me.LoadNextForm()
                Case Keys.D3, Keys.C
                    ' Misconnect
                    CacheManager.ExpediteCode = BOConstants.ExpediteMisconnect
                    Me.LoadNextForm()
                Case Keys.D5, Keys.F
                    ' PAX onboard
                    CacheManager.ExpediteCode = BOConstants.ExpeditePaxOnboard
                    Me.LoadNextForm()
                Case Keys.D7, Keys.I
                    ' Cancelled Flt
                    CacheManager.ExpediteCode = BOConstants.EexpediteCancelledFlight
                    Me.LoadNextForm()
                Case Keys.D9, Keys.K
                    ' Domestic Transfer
                    CacheManager.ExpediteCode = BOConstants.ExpediteDomesticXFR
                    Me.LoadNextForm()
            End Select
        End Sub

        Private Sub frmExpediteReason_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("Bags", "to Bin/Bulk")
        End Sub

        Public Sub LoadNextForm()
            If UIController.CurrentFunction = SafetracFunction.ExpediteBag Then
                UIController.NextForm = New frmBinBulkInquiry
                UIController.NextForm.ShowDialog()
                Exit Sub
            ElseIf UIController.CurrentFunction = SafetracFunction.LoadBagIntoBinBulk Then
                Me.Close()
            ElseIf UIController.CurrentFunction = SafetracFunction.LoadBagToContainer Then
                Me.Close()
            End If
        End Sub

    End Class

End Namespace
