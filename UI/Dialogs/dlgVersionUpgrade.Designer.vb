Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgVersionUpgrade
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
            Me.fraInfo = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmdHideReport = New System.Windows.Forms.Button
            Me.Label8 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.lblTitle = New System.Windows.Forms.Label
            Me.fraInfo.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraInfo
            '
            Me.fraInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraInfo.Controls.Add(Me.lblTitle)
            Me.fraInfo.Controls.Add(Me.cmdHideReport)
            Me.fraInfo.Controls.Add(Me.Label8)
            Me.fraInfo.Controls.Add(Me.Label7)
            Me.fraInfo.Controls.Add(Me.Label6)
            Me.fraInfo.Controls.Add(Me.Label5)
            Me.fraInfo.Location = New System.Drawing.Point(4, 6)
            Me.fraInfo.Name = "fraInfo"
            Me.fraInfo.Size = New System.Drawing.Size(233, 150)
            '
            'cmdHideReport
            '
            Me.cmdHideReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdHideReport.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.cmdHideReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdHideReport.Location = New System.Drawing.Point(0, 117)
            Me.cmdHideReport.Name = "cmdHideReport"
            Me.cmdHideReport.Size = New System.Drawing.Size(233, 33)
            Me.cmdHideReport.TabIndex = 0
            Me.cmdHideReport.Text = "OK"
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(8, 97)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(105, 17)
            Me.Label8.Text = "612-726-6955"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(120, 97)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(105, 17)
            Me.Label7.Text = "800-328-2283"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(8, 73)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(217, 25)
            Me.Label6.Text = "NWA Help Desk"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular)
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(8, 36)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(217, 37)
            Me.Label5.Text = "A version upgrade is available with the Helpdesk. Please contact"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(3, 6)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(227, 25)
            Me.lblTitle.Text = "VERSION UPGRADE"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dlgVersionUpgrade
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 160)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraInfo)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 100)
            Me.Menu = Me.mainMenu1
            Me.Name = "dlgVersionUpgrade"
            Me.fraInfo.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraInfo As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmdHideReport As System.Windows.Forms.Button
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblTitle As System.Windows.Forms.Label
    End Class

End Namespace