Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgSetBackLightTime
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
            Me.fraBacklight = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmdBacklightOK = New System.Windows.Forms.Button
            Me.cmbBacklightTimes = New System.Windows.Forms.ComboBox
            Me.lblStayOn = New System.Windows.Forms.Label
            Me.lblbacklightSetting = New System.Windows.Forms.Label
            Me.Label10 = New System.Windows.Forms.Label
            Me.fraBacklight.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraBacklight
            '
            Me.fraBacklight.BackColor = System.Drawing.Color.White
            Me.fraBacklight.Controls.Add(Me.cmdBacklightOK)
            Me.fraBacklight.Controls.Add(Me.cmbBacklightTimes)
            Me.fraBacklight.Controls.Add(Me.lblStayOn)
            Me.fraBacklight.Controls.Add(Me.lblbacklightSetting)
            Me.fraBacklight.Controls.Add(Me.Label10)
            Me.fraBacklight.Location = New System.Drawing.Point(3, 4)
            Me.fraBacklight.Name = "fraBacklight"
            Me.fraBacklight.Size = New System.Drawing.Size(234, 147)
            '
            'cmdBacklightOK
            '
            Me.cmdBacklightOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdBacklightOK.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
            Me.cmdBacklightOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdBacklightOK.Location = New System.Drawing.Point(32, 92)
            Me.cmdBacklightOK.Name = "cmdBacklightOK"
            Me.cmdBacklightOK.Size = New System.Drawing.Size(185, 41)
            Me.cmdBacklightOK.TabIndex = 0
            Me.cmdBacklightOK.Text = "[ENT] Set This Time"
            '
            'cmbBacklightTimes
            '
            Me.cmbBacklightTimes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmbBacklightTimes.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
            Me.cmbBacklightTimes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmbBacklightTimes.Location = New System.Drawing.Point(80, 56)
            Me.cmbBacklightTimes.Name = "cmbBacklightTimes"
            Me.cmbBacklightTimes.Size = New System.Drawing.Size(137, 30)
            Me.cmbBacklightTimes.TabIndex = 1
            '
            'lblStayOn
            '
            Me.lblStayOn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblStayOn.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
            Me.lblStayOn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblStayOn.Location = New System.Drawing.Point(3, 56)
            Me.lblStayOn.Name = "lblStayOn"
            Me.lblStayOn.Size = New System.Drawing.Size(71, 25)
            Me.lblStayOn.Text = "Stay on"
            Me.lblStayOn.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblbacklightSetting
            '
            Me.lblbacklightSetting.BackColor = System.Drawing.Color.Black
            Me.lblbacklightSetting.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblbacklightSetting.ForeColor = System.Drawing.Color.White
            Me.lblbacklightSetting.Location = New System.Drawing.Point(0, 0)
            Me.lblbacklightSetting.Name = "lblbacklightSetting"
            Me.lblbacklightSetting.Size = New System.Drawing.Size(233, 25)
            Me.lblbacklightSetting.Text = "Backlight Setting"
            Me.lblbacklightSetting.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic)
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(47, 25)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(145, 28)
            Me.Label10.Text = "(While on batteries)"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dlgSetBackLightTime
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(240, 155)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraBacklight)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 120)
            Me.MinimizeBox = False
            Me.Name = "dlgSetBackLightTime"
            Me.fraBacklight.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraBacklight As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmdBacklightOK As System.Windows.Forms.Button
        Friend WithEvents cmbBacklightTimes As System.Windows.Forms.ComboBox
        Friend WithEvents lblStayOn As System.Windows.Forms.Label
        Friend WithEvents lblbacklightSetting As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
    End Class

End Namespace