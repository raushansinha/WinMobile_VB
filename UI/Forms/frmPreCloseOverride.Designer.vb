
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmPreCloseOverride
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
            Me.grbWFLTReason = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblWRFLResponce = New System.Windows.Forms.Label
            Me.grbLoadDetail = New OpenNETCF.Windows.Forms.GroupBox
            Me.dgPreCloseDetail = New System.Windows.Forms.DataGrid
            Me.cmdCancel = New System.Windows.Forms.Button
            Me.cmdPreLDO = New System.Windows.Forms.Button
            Me.grbWFLTReason.SuspendLayout()
            Me.grbLoadDetail.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbWFLTReason
            '
            Me.grbWFLTReason.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbWFLTReason.Controls.Add(Me.lblWRFLResponce)
            Me.grbWFLTReason.Controls.Add(Me.grbLoadDetail)
            Me.grbWFLTReason.Controls.Add(Me.cmdCancel)
            Me.grbWFLTReason.Controls.Add(Me.cmdPreLDO)
            Me.grbWFLTReason.Location = New System.Drawing.Point(0, 56)
            Me.grbWFLTReason.Name = "grbWFLTReason"
            Me.grbWFLTReason.Size = New System.Drawing.Size(233, 257)
            '
            'lblWRFLResponce
            '
            Me.lblWRFLResponce.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblWRFLResponce.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblWRFLResponce.ForeColor = System.Drawing.Color.White
            Me.lblWRFLResponce.Location = New System.Drawing.Point(3, 4)
            Me.lblWRFLResponce.Name = "lblWRFLResponce"
            Me.lblWRFLResponce.Size = New System.Drawing.Size(229, 33)
            Me.lblWRFLResponce.Text = "WorldFlight Responce"
            Me.lblWRFLResponce.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'grbLoadDetail
            '
            Me.grbLoadDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbLoadDetail.Controls.Add(Me.dgPreCloseDetail)
            Me.grbLoadDetail.Location = New System.Drawing.Point(3, 34)
            Me.grbLoadDetail.Name = "grbLoadDetail"
            Me.grbLoadDetail.Size = New System.Drawing.Size(227, 131)
            '
            'dgPreCloseDetail
            '
            Me.dgPreCloseDetail.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.dgPreCloseDetail.Location = New System.Drawing.Point(8, 8)
            Me.dgPreCloseDetail.Name = "dgPreCloseDetail"
            Me.dgPreCloseDetail.Size = New System.Drawing.Size(214, 120)
            Me.dgPreCloseDetail.TabIndex = 0
            '
            'cmdCancel
            '
            Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdCancel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdCancel.Location = New System.Drawing.Point(56, 207)
            Me.cmdCancel.Name = "cmdCancel"
            Me.cmdCancel.Size = New System.Drawing.Size(129, 32)
            Me.cmdCancel.TabIndex = 0
            Me.cmdCancel.Text = "(ESC) Cancel"
            '
            'cmdPreLDO
            '
            Me.cmdPreLDO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdPreLDO.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdPreLDO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdPreLDO.Location = New System.Drawing.Point(56, 170)
            Me.cmdPreLDO.Name = "cmdPreLDO"
            Me.cmdPreLDO.Size = New System.Drawing.Size(129, 32)
            Me.cmdPreLDO.TabIndex = 1
            Me.cmdPreLDO.Text = "(O) Override"
            '
            'frmPreCloseOverride
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.grbWFLTReason)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmPreCloseOverride"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.grbWFLTReason.ResumeLayout(False)
            Me.grbLoadDetail.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbWFLTReason As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmdCancel As System.Windows.Forms.Button
        Friend WithEvents cmdPreLDO As System.Windows.Forms.Button
        Friend WithEvents grbLoadDetail As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents dgPreCloseDetail As System.Windows.Forms.DataGrid
        Friend WithEvents lblWRFLResponce As System.Windows.Forms.Label
    End Class
End Namespace