Imports System.Windows.Forms.DataGrid
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmLoadDetail
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
            Me.grbPage4 = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmdViewSummary = New System.Windows.Forms.Button
            Me.lblViewTitle = New System.Windows.Forms.Label
            Me.grbLoadDetail = New OpenNETCF.Windows.Forms.GroupBox
            Me.dgLoadDetail = New System.Windows.Forms.DataGrid
            Me.cmdNext = New System.Windows.Forms.Button
            Me.cmdPrev = New System.Windows.Forms.Button
            Me.grbPage4.SuspendLayout()
            Me.grbLoadDetail.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbPage4
            '
            Me.grbPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbPage4.Controls.Add(Me.cmdViewSummary)
            Me.grbPage4.Controls.Add(Me.lblViewTitle)
            Me.grbPage4.Controls.Add(Me.grbLoadDetail)
            Me.grbPage4.Location = New System.Drawing.Point(0, 56)
            Me.grbPage4.Name = "grbPage4"
            Me.grbPage4.Size = New System.Drawing.Size(233, 199)
            '
            'cmdViewSummary
            '
            Me.cmdViewSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdViewSummary.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdViewSummary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdViewSummary.Location = New System.Drawing.Point(42, 163)
            Me.cmdViewSummary.Name = "cmdViewSummary"
            Me.cmdViewSummary.Size = New System.Drawing.Size(137, 33)
            Me.cmdViewSummary.TabIndex = 0
            Me.cmdViewSummary.Text = "[V] View Summary"
            '
            'lblViewTitle
            '
            Me.lblViewTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblViewTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblViewTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblViewTitle.Location = New System.Drawing.Point(0, 0)
            Me.lblViewTitle.Name = "lblViewTitle"
            Me.lblViewTitle.Size = New System.Drawing.Size(233, 25)
            Me.lblViewTitle.Text = "LOAD DETAIL"
            Me.lblViewTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'grbLoadDetail
            '
            Me.grbLoadDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbLoadDetail.Controls.Add(Me.dgLoadDetail)
            Me.grbLoadDetail.Location = New System.Drawing.Point(3, 28)
            Me.grbLoadDetail.Name = "grbLoadDetail"
            Me.grbLoadDetail.Size = New System.Drawing.Size(227, 131)
            '
            'dgLoadDetail
            '
            Me.dgLoadDetail.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.dgLoadDetail.Location = New System.Drawing.Point(8, 8)
            Me.dgLoadDetail.Name = "dgLoadDetail"
            Me.dgLoadDetail.Size = New System.Drawing.Size(214, 120)
            Me.dgLoadDetail.TabIndex = 0
            '
            'cmdNext
            '
            Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdNext.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdNext.Location = New System.Drawing.Point(120, 261)
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
            Me.cmdPrev.Location = New System.Drawing.Point(0, 261)
            Me.cmdPrev.Name = "cmdPrev"
            Me.cmdPrev.Size = New System.Drawing.Size(113, 41)
            Me.cmdPrev.TabIndex = 2
            Me.cmdPrev.Text = "< Prev"
            '
            'frmLoadDetail
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.grbPage4)
            Me.Controls.Add(Me.cmdNext)
            Me.Controls.Add(Me.cmdPrev)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmLoadDetail"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.grbPage4.ResumeLayout(False)
            Me.grbLoadDetail.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbPage4 As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmdViewSummary As System.Windows.Forms.Button
        Friend WithEvents lblViewTitle As System.Windows.Forms.Label
        Friend WithEvents cmdNext As System.Windows.Forms.Button
        Friend WithEvents cmdPrev As System.Windows.Forms.Button
        Friend WithEvents grbLoadDetail As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents dgLoadDetail As System.Windows.Forms.DataGrid

    End Class
End Namespace