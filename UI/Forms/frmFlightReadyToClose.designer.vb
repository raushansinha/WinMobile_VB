
Imports System.Windows.Forms.DataGrid
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmFlightReadyToClose
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
            Me.btnStartLD = New System.Windows.Forms.Button
            Me.lblReadyToLD = New System.Windows.Forms.Label
            Me.lblMessage = New System.Windows.Forms.Label
            Me.btnNext = New System.Windows.Forms.Button
            Me.btnPrev = New System.Windows.Forms.Button
            Me.grbPage5.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbPage5
            '
            Me.grbPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbPage5.Controls.Add(Me.btnStartLD)
            Me.grbPage5.Controls.Add(Me.lblReadyToLD)
            Me.grbPage5.Controls.Add(Me.lblMessage)
            Me.grbPage5.Location = New System.Drawing.Point(0, 56)
            Me.grbPage5.Name = "grbPage5"
            Me.grbPage5.Size = New System.Drawing.Size(233, 198)
            '
            'btnStartLD
            '
            Me.btnStartLD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnStartLD.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular)
            Me.btnStartLD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnStartLD.Location = New System.Drawing.Point(24, 128)
            Me.btnStartLD.Name = "btnStartLD"
            Me.btnStartLD.Size = New System.Drawing.Size(183, 55)
            Me.btnStartLD.TabIndex = 0
            Me.btnStartLD.Text = "(C) Close Flight"
            '
            'lblReadyToLD
            '
            Me.lblReadyToLD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblReadyToLD.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblReadyToLD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblReadyToLD.Location = New System.Drawing.Point(0, 0)
            Me.lblReadyToLD.Name = "lblReadyToLD"
            Me.lblReadyToLD.Size = New System.Drawing.Size(233, 25)
            Me.lblReadyToLD.Text = "Ready to LD!"
            Me.lblReadyToLD.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblMessage
            '
            Me.lblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMessage.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblMessage.Location = New System.Drawing.Point(8, 32)
            Me.lblMessage.Name = "lblMessage"
            Me.lblMessage.Size = New System.Drawing.Size(217, 73)
            Me.lblMessage.Text = "Press the Close Flight button to begin."
            Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'btnNext
            '
            Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnNext.Enabled = False
            Me.btnNext.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnNext.Location = New System.Drawing.Point(120, 258)
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
            Me.btnPrev.Location = New System.Drawing.Point(0, 258)
            Me.btnPrev.Name = "btnPrev"
            Me.btnPrev.Size = New System.Drawing.Size(113, 41)
            Me.btnPrev.TabIndex = 2
            Me.btnPrev.Text = "< Prev"
            '
            'frmFlightReadyToClose
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.grbPage5)
            Me.Controls.Add(Me.btnNext)
            Me.Controls.Add(Me.btnPrev)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmFlightReadyToClose"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.grbPage5.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbPage5 As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents btnStartLD As System.Windows.Forms.Button
        Friend WithEvents lblReadyToLD As System.Windows.Forms.Label
        Friend WithEvents lblMessage As System.Windows.Forms.Label
        Friend WithEvents btnNext As System.Windows.Forms.Button
        Friend WithEvents btnPrev As System.Windows.Forms.Button
    End Class
End Namespace