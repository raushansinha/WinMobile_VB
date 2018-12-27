Imports NWA.Safetrac.Scanner.BO
Namespace NWA.Safetrac.Scanner.UI
    Public Class dlgScanMode

        Private Sub cmdManualWgt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdManualWgt.Click
            ' Sets scan mode to single heavy.
            CacheManager.BagScanMode = ScanModes.SingleHeavy
            Me.Close()
        End Sub

        Private Sub cmdMultiHeavy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMultiHeavy.Click
            ' Sets scan mode to heavy.
            CacheManager.BagScanMode = ScanModes.Heavy
            Me.Close()
        End Sub

        Private Sub cmdAnimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnimal.Click
            ' Sets scan mode to animal.
            CacheManager.BagScanMode = ScanModes.Animal
            Me.Close()
        End Sub

        Private Sub cmdDamaged_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDamaged.Click
            ' Sets scan mode to damaged.
            CacheManager.BagScanMode = ScanModes.Damaged
            Me.Close()
        End Sub

        Private Sub cmdNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNormal.Click
            ' Sets scan mode to normal.
            CacheManager.BagScanMode = ScanModes.Normal
            Me.Close()
        End Sub

        Private Sub cmdPlaneside_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlaneside.Click
            ' Sets scan mode to planeside.
            CacheManager.BagScanMode = ScanModes.Planeside
            Me.Close()
        End Sub

        Private Sub dlgScanMode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

            Select Case e.KeyCode
                Case Keys.N
                    cmdNormal_Click(sender, e)
                Case Keys.P
                    cmdPlaneside_Click(sender, e)
                Case Keys.H
                    cmdManualWgt_Click(sender, e)
                Case Keys.X
                    cmdMultiHeavy_Click(sender, e)
                Case Keys.D
                    cmdDamaged_Click(sender, e)
                Case Keys.A
                    cmdAnimal_Click(sender, e)
            End Select

        End Sub

        Private Sub frmSetScanMode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If UIController.CurrentFunction = SafetracFunction.LoadBagToContainer Then
                cmdAnimal.Visible = False
            End If

            Dim flight As Flight = FlightsCollection.GetInstance.CurrentFlight
            If flight.IsPBMDisabled Then
                cmdPBM.Text = "Enable PBM"
            Else
                cmdPBM.Text = "Disable PBM"
            End If

            'If ScanModes.Heavy Then
            '    cmdManualWgt.Text = "[H] Single Heavy"
            'Else
            '    cmdManualWgt.Text = "[W] Weight"
            'End If

        End Sub

        Private Sub cmdPBM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPBM.Click

            Dim flight As Flight = FlightsCollection.GetInstance.CurrentFlight

            Dim retCode As ReturnCodes = flight.DiablePBM(Not flight.IsPBMDisabled)

            Select Case retCode
                Case ReturnCodes.IsInternational
                    MessageBox.Show("Not Authorized", "PBM", MessageBoxButtons.OK, _
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Case ReturnCodes.IsHubTypeStation
                    MessageBox.Show("Not Authorized", "PBM", MessageBoxButtons.OK, _
                                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Case ReturnCodes.PBMDisabled
                    cmdPBM.Text = "Enable PBM"
                Case ReturnCodes.PBMEnabled
                    cmdPBM.Text = "Disable PBM"
            End Select

        End Sub

    End Class

End Namespace
