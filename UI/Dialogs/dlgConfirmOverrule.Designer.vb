Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgConfirmOverrule
        Inherits System.Windows.Forms.Form
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
            Me.fraOverrule = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblMsg = New System.Windows.Forms.Label
            Me.cmdYesOverrule = New System.Windows.Forms.Button
            Me.cmdNoOverrule = New System.Windows.Forms.Button
            Me.lblOverrule = New System.Windows.Forms.Label
            Me.fraOverrule.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraOverrule
            '
            Me.fraOverrule.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraOverrule.Controls.Add(Me.lblMsg)
            Me.fraOverrule.Controls.Add(Me.cmdYesOverrule)
            Me.fraOverrule.Controls.Add(Me.cmdNoOverrule)
            Me.fraOverrule.Controls.Add(Me.lblOverrule)
            Me.fraOverrule.Location = New System.Drawing.Point(4, 5)
            Me.fraOverrule.Name = "fraOverrule"
            Me.fraOverrule.Size = New System.Drawing.Size(233, 159)
            '
            'lblMsg
            '
            Me.lblMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMsg.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblMsg.Location = New System.Drawing.Point(8, 39)
            Me.lblMsg.Name = "lblMsg"
            Me.lblMsg.Size = New System.Drawing.Size(217, 45)
            Me.lblMsg.Text = "Do you want to convert ULD to SORT?"
            Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmdYesOverrule
            '
            Me.cmdYesOverrule.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmdYesOverrule.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.cmdYesOverrule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdYesOverrule.Location = New System.Drawing.Point(8, 96)
            Me.cmdYesOverrule.Name = "cmdYesOverrule"
            Me.cmdYesOverrule.Size = New System.Drawing.Size(97, 41)
            Me.cmdYesOverrule.TabIndex = 1
            Me.cmdYesOverrule.Text = "(A) Yes"
            '
            'cmdNoOverrule
            '
            Me.cmdNoOverrule.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmdNoOverrule.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.cmdNoOverrule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdNoOverrule.Location = New System.Drawing.Point(128, 96)
            Me.cmdNoOverrule.Name = "cmdNoOverrule"
            Me.cmdNoOverrule.Size = New System.Drawing.Size(97, 41)
            Me.cmdNoOverrule.TabIndex = 2
            Me.cmdNoOverrule.Text = "(C) No"
            '
            'lblOverrule
            '
            Me.lblOverrule.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblOverrule.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblOverrule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblOverrule.Location = New System.Drawing.Point(0, 0)
            Me.lblOverrule.Name = "lblOverrule"
            Me.lblOverrule.Size = New System.Drawing.Size(233, 25)
            Me.lblOverrule.Text = "Need Overrule"
            Me.lblOverrule.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dlgConfirmOverrule
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 170)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraOverrule)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "dlgConfirmOverrule"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraOverrule.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents fraOverrule As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblMsg As System.Windows.Forms.Label
        Friend WithEvents cmdYesOverrule As System.Windows.Forms.Button
        Friend WithEvents cmdNoOverrule As System.Windows.Forms.Button
        Friend WithEvents lblOverrule As System.Windows.Forms.Label
    End Class

End Namespace
