
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmCloseReopenFlight
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
            Me.grbContinue = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblContinue3 = New System.Windows.Forms.Label
            Me.grbPage1 = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblWelCome = New System.Windows.Forms.Label
            Me.imgWizard = New System.Windows.Forms.PictureBox
            Me.lblAppVersion = New System.Windows.Forms.Label
            Me.lblMessage = New System.Windows.Forms.Label
            Me.cmdPrev = New System.Windows.Forms.Button
            Me.cmdNext = New System.Windows.Forms.Button
            Me.grbContinue.SuspendLayout()
            Me.grbPage1.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbContinue
            '
            Me.grbContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbContinue.Controls.Add(Me.lblContinue3)
            Me.grbContinue.Location = New System.Drawing.Point(0, 200)
            Me.grbContinue.Name = "grbContinue"
            Me.grbContinue.Size = New System.Drawing.Size(233, 54)
            '
            'lblContinue3
            '
            Me.lblContinue3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblContinue3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lblContinue3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblContinue3.Location = New System.Drawing.Point(8, 16)
            Me.lblContinue3.Name = "lblContinue3"
            Me.lblContinue3.Size = New System.Drawing.Size(217, 25)
            Me.lblContinue3.Text = "Press 'Next' To Continue"
            Me.lblContinue3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'grbPage1
            '
            Me.grbPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbPage1.Controls.Add(Me.lblWelCome)
            Me.grbPage1.Controls.Add(Me.imgWizard)
            Me.grbPage1.Controls.Add(Me.lblAppVersion)
            Me.grbPage1.Controls.Add(Me.lblMessage)
            Me.grbPage1.Location = New System.Drawing.Point(0, 56)
            Me.grbPage1.Name = "grbPage1"
            Me.grbPage1.Size = New System.Drawing.Size(233, 201)
            '
            'lblWelCome
            '
            Me.lblWelCome.BackColor = System.Drawing.Color.Black
            Me.lblWelCome.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblWelCome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblWelCome.Location = New System.Drawing.Point(3, 0)
            Me.lblWelCome.Name = "lblWelCome"
            Me.lblWelCome.Size = New System.Drawing.Size(229, 25)
            Me.lblWelCome.Text = "WELCOME!"
            Me.lblWelCome.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'imgWizard
            '
            Me.imgWizard.Location = New System.Drawing.Point(3, 26)
            Me.imgWizard.Name = "imgWizard"
            Me.imgWizard.Size = New System.Drawing.Size(111, 117)
            '
            'lblAppVersion
            '
            Me.lblAppVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblAppVersion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.lblAppVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblAppVersion.Location = New System.Drawing.Point(168, 124)
            Me.lblAppVersion.Name = "lblAppVersion"
            Me.lblAppVersion.Size = New System.Drawing.Size(57, 17)
            Me.lblAppVersion.Text = "[Ver]"
            Me.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblMessage
            '
            Me.lblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMessage.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
            Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblMessage.Location = New System.Drawing.Point(112, 24)
            Me.lblMessage.Name = "lblMessage"
            Me.lblMessage.Size = New System.Drawing.Size(113, 121)
            Me.lblMessage.Text = "This function will assist with reopening a flight."
            Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmdPrev
            '
            Me.cmdPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdPrev.Enabled = False
            Me.cmdPrev.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdPrev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdPrev.Location = New System.Drawing.Point(0, 259)
            Me.cmdPrev.Name = "cmdPrev"
            Me.cmdPrev.Size = New System.Drawing.Size(113, 41)
            Me.cmdPrev.TabIndex = 2
            Me.cmdPrev.Text = "< Prev"
            '
            'cmdNext
            '
            Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdNext.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdNext.Location = New System.Drawing.Point(120, 259)
            Me.cmdNext.Name = "cmdNext"
            Me.cmdNext.Size = New System.Drawing.Size(113, 41)
            Me.cmdNext.TabIndex = 3
            Me.cmdNext.Text = "(Ent) Next >"
            '
            'frmCloseReopenFlight
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.grbContinue)
            Me.Controls.Add(Me.grbPage1)
            Me.Controls.Add(Me.cmdPrev)
            Me.Controls.Add(Me.cmdNext)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmCloseReopenFlight"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.grbContinue.ResumeLayout(False)
            Me.grbPage1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbContinue As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblContinue3 As System.Windows.Forms.Label
        Friend WithEvents grbPage1 As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblWelCome As System.Windows.Forms.Label
        Friend WithEvents lblMessage As System.Windows.Forms.Label
        Friend WithEvents cmdPrev As System.Windows.Forms.Button
        Friend WithEvents cmdNext As System.Windows.Forms.Button
        Friend WithEvents lblAppVersion As System.Windows.Forms.Label
        Friend WithEvents imgWizard As System.Windows.Forms.PictureBox
    End Class
End Namespace