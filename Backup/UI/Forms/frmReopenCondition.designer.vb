
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI



    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmReopenCondition
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
            Me.grbPage3 = New OpenNETCF.Windows.Forms.GroupBox
            Me.btnReopen = New System.Windows.Forms.Button
            Me.lblReadyToOpen = New System.Windows.Forms.Label
            Me.lblMessage = New System.Windows.Forms.Label
            Me.btnNext = New System.Windows.Forms.Button
            Me.btnPrev = New System.Windows.Forms.Button
            Me.grbPage3.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbPage3
            '
            Me.grbPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbPage3.Controls.Add(Me.btnReopen)
            Me.grbPage3.Controls.Add(Me.lblReadyToOpen)
            Me.grbPage3.Controls.Add(Me.lblMessage)
            Me.grbPage3.Location = New System.Drawing.Point(0, 56)
            Me.grbPage3.Name = "grbPage3"
            Me.grbPage3.Size = New System.Drawing.Size(233, 195)
            '
            'btnReopen
            '
            Me.btnReopen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnReopen.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular)
            Me.btnReopen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnReopen.Location = New System.Drawing.Point(24, 127)
            Me.btnReopen.Name = "btnReopen"
            Me.btnReopen.Size = New System.Drawing.Size(185, 54)
            Me.btnReopen.TabIndex = 0
            Me.btnReopen.Text = "(R) Reopen Flight"
            '
            'lblReadyToOpen
            '
            Me.lblReadyToOpen.BackColor = System.Drawing.Color.Black
            Me.lblReadyToOpen.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblReadyToOpen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblReadyToOpen.Location = New System.Drawing.Point(0, 0)
            Me.lblReadyToOpen.Name = "lblReadyToOpen"
            Me.lblReadyToOpen.Size = New System.Drawing.Size(233, 25)
            Me.lblReadyToOpen.Text = "Ready to Reopen!"
            Me.lblReadyToOpen.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblMessage
            '
            Me.lblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMessage.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblMessage.Location = New System.Drawing.Point(3, 32)
            Me.lblMessage.Name = "lblMessage"
            Me.lblMessage.Size = New System.Drawing.Size(227, 73)
            Me.lblMessage.Text = "Press the Reopen Flight button to begin."
            Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'btnNext
            '
            Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnNext.Enabled = False
            Me.btnNext.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnNext.Location = New System.Drawing.Point(120, 256)
            Me.btnNext.Name = "btnNext"
            Me.btnNext.Size = New System.Drawing.Size(113, 41)
            Me.btnNext.TabIndex = 1
            Me.btnNext.Text = "(Ent) Next >"
            '
            'btnPrev
            '
            Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnPrev.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.btnPrev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnPrev.Location = New System.Drawing.Point(0, 256)
            Me.btnPrev.Name = "btnPrev"
            Me.btnPrev.Size = New System.Drawing.Size(113, 41)
            Me.btnPrev.TabIndex = 2
            Me.btnPrev.Text = "< Prev"
            '
            'frmReopenCondition
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.grbPage3)
            Me.Controls.Add(Me.btnNext)
            Me.Controls.Add(Me.btnPrev)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmReopenCondition"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.grbPage3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbPage3 As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents btnReopen As System.Windows.Forms.Button
        Friend WithEvents lblReadyToOpen As System.Windows.Forms.Label
        Friend WithEvents lblMessage As System.Windows.Forms.Label
        Friend WithEvents btnNext As System.Windows.Forms.Button
        Friend WithEvents btnPrev As System.Windows.Forms.Button
    End Class
End Namespace