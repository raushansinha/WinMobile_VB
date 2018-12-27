
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgVersion
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
            Me.fraVersion = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblPsionSDK = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.cmdHideVersion = New System.Windows.Forms.Button
            Me.lblAppVersion = New System.Windows.Forms.Label
            Me.lblNETVersion = New System.Windows.Forms.Label
            Me.lblSDFVersion = New System.Windows.Forms.Label
            Me.fraVersion.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraVersion
            '
            Me.fraVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraVersion.Controls.Add(Me.lblPsionSDK)
            Me.fraVersion.Controls.Add(Me.Label9)
            Me.fraVersion.Controls.Add(Me.Label8)
            Me.fraVersion.Controls.Add(Me.cmdHideVersion)
            Me.fraVersion.Controls.Add(Me.lblAppVersion)
            Me.fraVersion.Controls.Add(Me.lblNETVersion)
            Me.fraVersion.Controls.Add(Me.lblSDFVersion)
            Me.fraVersion.Location = New System.Drawing.Point(3, 5)
            Me.fraVersion.Name = "fraVersion"
            Me.fraVersion.Size = New System.Drawing.Size(235, 191)
            '
            'lblPsionSDK
            '
            Me.lblPsionSDK.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPsionSDK.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular)
            Me.lblPsionSDK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblPsionSDK.Location = New System.Drawing.Point(16, 136)
            Me.lblPsionSDK.Name = "lblPsionSDK"
            Me.lblPsionSDK.Size = New System.Drawing.Size(169, 17)
            Me.lblPsionSDK.Text = "[SDK Ver] "
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(8, 27)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(217, 25)
            Me.Label9.Text = "External Applications"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(-1, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(238, 25)
            Me.Label8.Text = "Version Info"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmdHideVersion
            '
            Me.cmdHideVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdHideVersion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdHideVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdHideVersion.Location = New System.Drawing.Point(71, 161)
            Me.cmdHideVersion.Name = "cmdHideVersion"
            Me.cmdHideVersion.Size = New System.Drawing.Size(97, 24)
            Me.cmdHideVersion.TabIndex = 2
            Me.cmdHideVersion.Text = "Hide"
            '
            'lblAppVersion
            '
            Me.lblAppVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblAppVersion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular)
            Me.lblAppVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblAppVersion.Location = New System.Drawing.Point(16, 55)
            Me.lblAppVersion.Name = "lblAppVersion"
            Me.lblAppVersion.Size = New System.Drawing.Size(201, 17)
            Me.lblAppVersion.Text = "[App version] "
            '
            'lblNETVersion
            '
            Me.lblNETVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblNETVersion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular)
            Me.lblNETVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblNETVersion.Location = New System.Drawing.Point(16, 80)
            Me.lblNETVersion.Name = "lblNETVersion"
            Me.lblNETVersion.Size = New System.Drawing.Size(169, 17)
            Me.lblNETVersion.Text = "[.NET Ver] "
            '
            'lblSDFVersion
            '
            Me.lblSDFVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblSDFVersion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular)
            Me.lblSDFVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSDFVersion.Location = New System.Drawing.Point(16, 108)
            Me.lblSDFVersion.Name = "lblSDFVersion"
            Me.lblSDFVersion.Size = New System.Drawing.Size(169, 17)
            Me.lblSDFVersion.Text = "[SDF Ver] "
            '
            'dlgVersion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
            Me.ClientSize = New System.Drawing.Size(240, 200)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraVersion)
            Me.ForeColor = System.Drawing.Color.Black
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 70)
            Me.MinimizeBox = False
            Me.Name = "dlgVersion"
            Me.fraVersion.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraVersion As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents cmdHideVersion As System.Windows.Forms.Button
        Friend WithEvents lblAppVersion As System.Windows.Forms.Label
        Friend WithEvents lblNETVersion As System.Windows.Forms.Label
        Friend WithEvents lblSDFVersion As System.Windows.Forms.Label
        Friend WithEvents lblPsionSDK As System.Windows.Forms.Label
    End Class
End Namespace
