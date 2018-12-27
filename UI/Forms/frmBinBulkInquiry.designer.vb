Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmBinBulkInquiry
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
            Me.fraParms = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblAll = New System.Windows.Forms.Label
            Me.lblFlight = New System.Windows.Forms.Label
            Me.btnContinue = New System.Windows.Forms.Button
            Me.txtDate = New System.Windows.Forms.TextBox
            Me.txtFlight = New System.Windows.Forms.TextBox
            Me.txtBinBulk = New System.Windows.Forms.TextBox
            Me.lblDate = New System.Windows.Forms.Label
            Me.lblFlght = New System.Windows.Forms.Label
            Me.lblBinBulk = New System.Windows.Forms.Label
            Me.fraParms.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraParms
            '
            Me.fraParms.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraParms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.fraParms.Controls.Add(Me.lblAll)
            Me.fraParms.Controls.Add(Me.lblFlight)
            Me.fraParms.Controls.Add(Me.btnContinue)
            Me.fraParms.Controls.Add(Me.txtDate)
            Me.fraParms.Controls.Add(Me.txtFlight)
            Me.fraParms.Controls.Add(Me.txtBinBulk)
            Me.fraParms.Controls.Add(Me.lblDate)
            Me.fraParms.Controls.Add(Me.lblFlght)
            Me.fraParms.Controls.Add(Me.lblBinBulk)
            Me.fraParms.Location = New System.Drawing.Point(4, 56)
            Me.fraParms.Name = "fraParms"
            Me.fraParms.Size = New System.Drawing.Size(233, 225)
            '
            'lblAll
            '
            Me.lblAll.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.lblAll.Location = New System.Drawing.Point(110, 67)
            Me.lblAll.Name = "lblAll"
            Me.lblAll.Size = New System.Drawing.Size(85, 15)
            Me.lblAll.Text = "Blank =""ALL"""
            Me.lblAll.Visible = False
            '
            'lblFlight
            '
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.Location = New System.Drawing.Point(17, -5)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(190, 28)
            Me.lblFlight.Text = "Enter Flight Info"
            '
            'btnContinue
            '
            Me.btnContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnContinue.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnContinue.Location = New System.Drawing.Point(48, 176)
            Me.btnContinue.Name = "btnContinue"
            Me.btnContinue.Size = New System.Drawing.Size(137, 33)
            Me.btnContinue.TabIndex = 3
            Me.btnContinue.Text = "[ENT] Continue"
            '
            'txtDate
            '
            Me.txtDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtDate.Location = New System.Drawing.Point(104, 125)
            Me.txtDate.MaxLength = 5
            Me.txtDate.Name = "txtDate"
            Me.txtDate.Size = New System.Drawing.Size(81, 26)
            Me.txtDate.TabIndex = 2
            '
            'txtFlight
            '
            Me.txtFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtFlight.Location = New System.Drawing.Point(104, 85)
            Me.txtFlight.MaxLength = 6
            Me.txtFlight.Name = "txtFlight"
            Me.txtFlight.Size = New System.Drawing.Size(81, 26)
            Me.txtFlight.TabIndex = 1
            '
            'txtBinBulk
            '
            Me.txtBinBulk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtBinBulk.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtBinBulk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtBinBulk.Location = New System.Drawing.Point(104, 38)
            Me.txtBinBulk.MaxLength = 2
            Me.txtBinBulk.Name = "txtBinBulk"
            Me.txtBinBulk.Size = New System.Drawing.Size(81, 26)
            Me.txtBinBulk.TabIndex = 0
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(40, 128)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(57, 17)
            Me.lblDate.Text = "DATE"
            Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblFlght
            '
            Me.lblFlght.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlght.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlght.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlght.Location = New System.Drawing.Point(24, 85)
            Me.lblFlght.Name = "lblFlght"
            Me.lblFlght.Size = New System.Drawing.Size(73, 17)
            Me.lblFlght.Text = "FLIGHT"
            Me.lblFlght.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblBinBulk
            '
            Me.lblBinBulk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBinBulk.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBinBulk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBinBulk.Location = New System.Drawing.Point(3, 38)
            Me.lblBinBulk.Name = "lblBinBulk"
            Me.lblBinBulk.Size = New System.Drawing.Size(94, 17)
            Me.lblBinBulk.Text = "BIN/BULK"
            Me.lblBinBulk.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'frmBinBulkInquiry
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraParms)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmBinBulkInquiry"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraParms.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraParms As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents btnContinue As System.Windows.Forms.Button
        Friend WithEvents txtDate As System.Windows.Forms.TextBox
        Friend WithEvents txtFlight As System.Windows.Forms.TextBox
        Friend WithEvents txtBinBulk As System.Windows.Forms.TextBox
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents lblFlght As System.Windows.Forms.Label
        Friend WithEvents lblBinBulk As System.Windows.Forms.Label
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents lblAll As System.Windows.Forms.Label
    End Class
End Namespace
