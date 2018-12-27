
Imports System.Windows.Forms.DataGrid
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmPreClose
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
            Me.grbPage5 = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmdPreClose = New System.Windows.Forms.Button
            Me.lblReadyToPreClose = New System.Windows.Forms.Label
            Me.lblMessage = New System.Windows.Forms.Label
            Me.cmdNext = New System.Windows.Forms.Button
            Me.cmdPrev = New System.Windows.Forms.Button
            Me.grbPage5.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbPage5
            '
            Me.grbPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbPage5.Controls.Add(Me.cmdPreClose)
            Me.grbPage5.Controls.Add(Me.lblReadyToPreClose)
            Me.grbPage5.Controls.Add(Me.lblMessage)
            Me.grbPage5.Location = New System.Drawing.Point(0, 57)
            Me.grbPage5.Name = "grbPage5"
            Me.grbPage5.Size = New System.Drawing.Size(233, 195)
            '
            'cmdPreClose
            '
            Me.cmdPreClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdPreClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular)
            Me.cmdPreClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdPreClose.Location = New System.Drawing.Point(24, 128)
            Me.cmdPreClose.Name = "cmdPreClose"
            Me.cmdPreClose.Size = New System.Drawing.Size(183, 55)
            Me.cmdPreClose.TabIndex = 0
            Me.cmdPreClose.Text = "(P)PreClose Flight"
            '
            'lblReadyToPreClose
            '
            Me.lblReadyToPreClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblReadyToPreClose.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblReadyToPreClose.ForeColor = System.Drawing.Color.White
            Me.lblReadyToPreClose.Location = New System.Drawing.Point(0, 0)
            Me.lblReadyToPreClose.Name = "lblReadyToPreClose"
            Me.lblReadyToPreClose.Size = New System.Drawing.Size(233, 25)
            Me.lblReadyToPreClose.Text = "Ready to PRECLOSE!"
            Me.lblReadyToPreClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblMessage
            '
            Me.lblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMessage.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblMessage.Location = New System.Drawing.Point(8, 32)
            Me.lblMessage.Name = "lblMessage"
            Me.lblMessage.Size = New System.Drawing.Size(217, 73)
            Me.lblMessage.Text = "Press the PreClose Flight button to begin."
            Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmdNext
            '
            Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdNext.Enabled = False
            Me.cmdNext.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdNext.Location = New System.Drawing.Point(120, 258)
            Me.cmdNext.Name = "cmdNext"
            Me.cmdNext.Size = New System.Drawing.Size(113, 41)
            Me.cmdNext.TabIndex = 1
            Me.cmdNext.Text = "(Ent) Next >"
            '
            'cmdPrev
            '
            Me.cmdPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdPrev.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdPrev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdPrev.Location = New System.Drawing.Point(0, 258)
            Me.cmdPrev.Name = "cmdPrev"
            Me.cmdPrev.Size = New System.Drawing.Size(113, 41)
            Me.cmdPrev.TabIndex = 2
            Me.cmdPrev.Text = "< Prev"
            '
            'frmPreClose
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.grbPage5)
            Me.Controls.Add(Me.cmdNext)
            Me.Controls.Add(Me.cmdPrev)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmPreClose"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.grbPage5.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbPage5 As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmdPreClose As System.Windows.Forms.Button
        Friend WithEvents lblReadyToPreClose As System.Windows.Forms.Label
        Friend WithEvents lblMessage As System.Windows.Forms.Label
        Friend WithEvents cmdNext As System.Windows.Forms.Button
        Friend WithEvents cmdPrev As System.Windows.Forms.Button
    End Class
End Namespace