
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmCloseOverride
        Inherits frmSafetracBase

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer
        Private mainMenu1 As System.Windows.Forms.MainMenu

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.mainMenu1 = New System.Windows.Forms.MainMenu
            Me.grbWFLTReason = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmdCancel = New System.Windows.Forms.Button
            Me.cmdOverride = New System.Windows.Forms.Button
            Me.lblWRFLResponce = New System.Windows.Forms.Label
            Me.lblWFLTReason = New System.Windows.Forms.Label
            Me.grbWFLTReason.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbWFLTReason
            '
            Me.grbWFLTReason.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbWFLTReason.Controls.Add(Me.cmdCancel)
            Me.grbWFLTReason.Controls.Add(Me.cmdOverride)
            Me.grbWFLTReason.Controls.Add(Me.lblWRFLResponce)
            Me.grbWFLTReason.Controls.Add(Me.lblWFLTReason)
            Me.grbWFLTReason.Location = New System.Drawing.Point(0, 56)
            Me.grbWFLTReason.Name = "grbWFLTReason"
            Me.grbWFLTReason.Size = New System.Drawing.Size(233, 257)
            '
            'cmdCancel
            '
            Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdCancel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdCancel.Location = New System.Drawing.Point(56, 187)
            Me.cmdCancel.Name = "cmdCancel"
            Me.cmdCancel.Size = New System.Drawing.Size(129, 49)
            Me.cmdCancel.TabIndex = 0
            Me.cmdCancel.Text = "(ESC) Cancel"
            '
            'cmdOverride
            '
            Me.cmdOverride.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdOverride.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdOverride.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdOverride.Location = New System.Drawing.Point(56, 131)
            Me.cmdOverride.Name = "cmdOverride"
            Me.cmdOverride.Size = New System.Drawing.Size(129, 49)
            Me.cmdOverride.TabIndex = 1
            Me.cmdOverride.Text = "(O) Override"
            '
            'lblWRFLResponce
            '
            Me.lblWRFLResponce.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblWRFLResponce.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblWRFLResponce.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblWRFLResponce.Location = New System.Drawing.Point(0, 0)
            Me.lblWRFLResponce.Name = "lblWRFLResponce"
            Me.lblWRFLResponce.Size = New System.Drawing.Size(233, 33)
            Me.lblWRFLResponce.Text = "WorldFlight Response"
            Me.lblWRFLResponce.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblWFLTReason
            '
            Me.lblWFLTReason.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblWFLTReason.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold)
            Me.lblWFLTReason.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblWFLTReason.Location = New System.Drawing.Point(3, 40)
            Me.lblWFLTReason.Name = "lblWFLTReason"
            Me.lblWFLTReason.Size = New System.Drawing.Size(222, 76)
            Me.lblWFLTReason.Text = "*REASONABLENESS CHECK FOR DOMESTIC BAGGAGE FAILED*"
            Me.lblWFLTReason.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmCloseOverride
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.grbWFLTReason)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmCloseOverride"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.grbWFLTReason.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbWFLTReason As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmdCancel As System.Windows.Forms.Button
        Friend WithEvents cmdOverride As System.Windows.Forms.Button
        Friend WithEvents lblWRFLResponce As System.Windows.Forms.Label
        Friend WithEvents lblWFLTReason As System.Windows.Forms.Label
    End Class
End Namespace