Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmBinBulkInquiryForFreight
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
            Me.txtFinalDest = New System.Windows.Forms.TextBox
            Me.lblFinal = New System.Windows.Forms.Label
            Me.txtDest = New System.Windows.Forms.TextBox
            Me.lblDst = New System.Windows.Forms.Label
            Me.lblBinBulk = New System.Windows.Forms.Label
            Me.lblFlight = New System.Windows.Forms.Label
            Me.lblDate = New System.Windows.Forms.Label
            Me.txtBinBulk = New System.Windows.Forms.TextBox
            Me.txtFlight = New System.Windows.Forms.TextBox
            Me.txtDate = New System.Windows.Forms.TextBox
            Me.btnContinue = New System.Windows.Forms.Button
            Me.fraParms.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraParms
            '
            Me.fraParms.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraParms.Controls.Add(Me.txtFinalDest)
            Me.fraParms.Controls.Add(Me.lblFinal)
            Me.fraParms.Controls.Add(Me.txtDest)
            Me.fraParms.Controls.Add(Me.lblDst)
            Me.fraParms.Controls.Add(Me.lblBinBulk)
            Me.fraParms.Controls.Add(Me.lblFlight)
            Me.fraParms.Controls.Add(Me.lblDate)
            Me.fraParms.Controls.Add(Me.txtBinBulk)
            Me.fraParms.Controls.Add(Me.txtFlight)
            Me.fraParms.Controls.Add(Me.txtDate)
            Me.fraParms.Controls.Add(Me.btnContinue)
            Me.fraParms.Location = New System.Drawing.Point(4, 48)
            Me.fraParms.Name = "fraParms"
            Me.fraParms.Size = New System.Drawing.Size(233, 233)
            '
            'txtFinalDest
            '
            Me.txtFinalDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtFinalDest.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtFinalDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtFinalDest.Location = New System.Drawing.Point(104, 160)
            Me.txtFinalDest.MaxLength = 3
            Me.txtFinalDest.Name = "txtFinalDest"
            Me.txtFinalDest.Size = New System.Drawing.Size(81, 26)
            Me.txtFinalDest.TabIndex = 0
            '
            'lblFinal
            '
            Me.lblFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFinal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFinal.Location = New System.Drawing.Point(40, 160)
            Me.lblFinal.Name = "lblFinal"
            Me.lblFinal.Size = New System.Drawing.Size(57, 17)
            Me.lblFinal.Text = "FNL"
            Me.lblFinal.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtDest
            '
            Me.txtDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtDest.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtDest.Location = New System.Drawing.Point(104, 128)
            Me.txtDest.MaxLength = 3
            Me.txtDest.Name = "txtDest"
            Me.txtDest.Size = New System.Drawing.Size(81, 26)
            Me.txtDest.TabIndex = 2
            '
            'lblDst
            '
            Me.lblDst.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDst.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDst.Location = New System.Drawing.Point(40, 128)
            Me.lblDst.Name = "lblDst"
            Me.lblDst.Size = New System.Drawing.Size(57, 17)
            Me.lblDst.Text = "DEST"
            Me.lblDst.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblBinBulk
            '
            Me.lblBinBulk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBinBulk.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBinBulk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBinBulk.Location = New System.Drawing.Point(3, 32)
            Me.lblBinBulk.Name = "lblBinBulk"
            Me.lblBinBulk.Size = New System.Drawing.Size(94, 17)
            Me.lblBinBulk.Text = "BIN/BULK"
            Me.lblBinBulk.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblFlight
            '
            Me.lblFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlight.Location = New System.Drawing.Point(28, 64)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(70, 17)
            Me.lblFlight.Text = "FLIGHT"
            Me.lblFlight.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(40, 96)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(57, 17)
            Me.lblDate.Text = "DATE"
            Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtBinBulk
            '
            Me.txtBinBulk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtBinBulk.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtBinBulk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtBinBulk.Location = New System.Drawing.Point(104, 32)
            Me.txtBinBulk.MaxLength = 2
            Me.txtBinBulk.Name = "txtBinBulk"
            Me.txtBinBulk.Size = New System.Drawing.Size(81, 26)
            Me.txtBinBulk.TabIndex = 7
            '
            'txtFlight
            '
            Me.txtFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtFlight.Location = New System.Drawing.Point(104, 64)
            Me.txtFlight.MaxLength = 6
            Me.txtFlight.Name = "txtFlight"
            Me.txtFlight.Size = New System.Drawing.Size(81, 26)
            Me.txtFlight.TabIndex = 8
            '
            'txtDate
            '
            Me.txtDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtDate.Location = New System.Drawing.Point(104, 96)
            Me.txtDate.MaxLength = 5
            Me.txtDate.Name = "txtDate"
            Me.txtDate.Size = New System.Drawing.Size(81, 26)
            Me.txtDate.TabIndex = 9
            '
            'btnContinue
            '
            Me.btnContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnContinue.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnContinue.Location = New System.Drawing.Point(48, 188)
            Me.btnContinue.Name = "btnContinue"
            Me.btnContinue.Size = New System.Drawing.Size(137, 41)
            Me.btnContinue.TabIndex = 10
            Me.btnContinue.Text = "[ENT] Continue"
            '
            'frmBinBulkInquiryForFreight
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 320)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraParms)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.MinimizeBox = False
            Me.Name = "frmBinBulkInquiryForFreight"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraParms.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraParms As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents txtFinalDest As System.Windows.Forms.TextBox
        Friend WithEvents lblFinal As System.Windows.Forms.Label
        Friend WithEvents txtDest As System.Windows.Forms.TextBox
        Friend WithEvents lblDst As System.Windows.Forms.Label
        Friend WithEvents lblBinBulk As System.Windows.Forms.Label
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents txtBinBulk As System.Windows.Forms.TextBox
        Friend WithEvents txtFlight As System.Windows.Forms.TextBox
        Friend WithEvents txtDate As System.Windows.Forms.TextBox
        Friend WithEvents btnContinue As System.Windows.Forms.Button
    End Class
End Namespace
