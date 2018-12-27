
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmLateBagInfPageTwo
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
            Me.fraInfoP2 = New OpenNETCF.Windows.Forms.GroupBox
            Me.btnBack3 = New System.Windows.Forms.Button
            Me.btnAddBags = New System.Windows.Forms.Button
            Me.lblInfPage2 = New System.Windows.Forms.Label
            Me.lblQty = New System.Windows.Forms.Label
            Me.txtBags = New System.Windows.Forms.TextBox
            Me.btnUp = New System.Windows.Forms.Button
            Me.btnDown = New System.Windows.Forms.Button
            Me.lblPos = New System.Windows.Forms.Label
            Me.cmbPos = New System.Windows.Forms.ComboBox
            Me.lblDest = New System.Windows.Forms.Label
            Me.txtDest = New System.Windows.Forms.TextBox
            Me.lblFnl = New System.Windows.Forms.Label
            Me.txtFnl = New System.Windows.Forms.TextBox
            Me.fraInfoP2.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraInfoP2
            '
            Me.fraInfoP2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraInfoP2.Controls.Add(Me.btnBack3)
            Me.fraInfoP2.Controls.Add(Me.btnAddBags)
            Me.fraInfoP2.Controls.Add(Me.lblInfPage2)
            Me.fraInfoP2.Controls.Add(Me.lblQty)
            Me.fraInfoP2.Controls.Add(Me.txtBags)
            Me.fraInfoP2.Controls.Add(Me.btnUp)
            Me.fraInfoP2.Controls.Add(Me.btnDown)
            Me.fraInfoP2.Controls.Add(Me.lblPos)
            Me.fraInfoP2.Controls.Add(Me.cmbPos)
            Me.fraInfoP2.Controls.Add(Me.lblDest)
            Me.fraInfoP2.Controls.Add(Me.txtDest)
            Me.fraInfoP2.Controls.Add(Me.lblFnl)
            Me.fraInfoP2.Controls.Add(Me.txtFnl)
            Me.fraInfoP2.Location = New System.Drawing.Point(0, 58)
            Me.fraInfoP2.Name = "fraInfoP2"
            Me.fraInfoP2.Size = New System.Drawing.Size(239, 215)
            '
            'btnBack3
            '
            Me.btnBack3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnBack3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.btnBack3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnBack3.Location = New System.Drawing.Point(12, 172)
            Me.btnBack3.Name = "btnBack3"
            Me.btnBack3.Size = New System.Drawing.Size(85, 30)
            Me.btnBack3.TabIndex = 7
            Me.btnBack3.Text = "<< Back"
            '
            'btnAddBags
            '
            Me.btnAddBags.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnAddBags.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.btnAddBags.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnAddBags.Location = New System.Drawing.Point(109, 172)
            Me.btnAddBags.Name = "btnAddBags"
            Me.btnAddBags.Size = New System.Drawing.Size(117, 30)
            Me.btnAddBags.TabIndex = 6
            Me.btnAddBags.Text = "[ENT] Add Bags"
            '
            'lblInfPage2
            '
            Me.lblInfPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblInfPage2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblInfPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblInfPage2.Location = New System.Drawing.Point(0, 0)
            Me.lblInfPage2.Name = "lblInfPage2"
            Me.lblInfPage2.Size = New System.Drawing.Size(240, 25)
            Me.lblInfPage2.Text = "Enter Information (p.2)"
            Me.lblInfPage2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblQty
            '
            Me.lblQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblQty.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblQty.Location = New System.Drawing.Point(3, 81)
            Me.lblQty.Name = "lblQty"
            Me.lblQty.Size = New System.Drawing.Size(46, 25)
            Me.lblQty.Text = "Qty"
            Me.lblQty.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtBags
            '
            Me.txtBags.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtBags.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.txtBags.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtBags.Location = New System.Drawing.Point(56, 77)
            Me.txtBags.MaxLength = 1
            Me.txtBags.Name = "txtBags"
            Me.txtBags.Size = New System.Drawing.Size(41, 26)
            Me.txtBags.TabIndex = 1
            Me.txtBags.Text = "1"
            '
            'btnUp
            '
            Me.btnUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnUp.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.btnUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnUp.Location = New System.Drawing.Point(112, 77)
            Me.btnUp.Name = "btnUp"
            Me.btnUp.Size = New System.Drawing.Size(50, 29)
            Me.btnUp.TabIndex = 2
            Me.btnUp.Text = "+"
            '
            'btnDown
            '
            Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnDown.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.btnDown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnDown.Location = New System.Drawing.Point(176, 77)
            Me.btnDown.Name = "btnDown"
            Me.btnDown.Size = New System.Drawing.Size(50, 29)
            Me.btnDown.TabIndex = 3
            Me.btnDown.Text = "-"
            '
            'lblPos
            '
            Me.lblPos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblPos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblPos.Location = New System.Drawing.Point(3, 36)
            Me.lblPos.Name = "lblPos"
            Me.lblPos.Size = New System.Drawing.Size(46, 26)
            Me.lblPos.Text = "Pos"
            Me.lblPos.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cmbPos
            '
            Me.cmbPos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmbPos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.cmbPos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmbPos.Location = New System.Drawing.Point(56, 32)
            Me.cmbPos.Name = "cmbPos"
            Me.cmbPos.Size = New System.Drawing.Size(89, 27)
            Me.cmbPos.TabIndex = 0
            '
            'lblDest
            '
            Me.lblDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDest.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDest.Location = New System.Drawing.Point(4, 131)
            Me.lblDest.Name = "lblDest"
            Me.lblDest.Size = New System.Drawing.Size(46, 25)
            Me.lblDest.Text = "Dest"
            Me.lblDest.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtDest
            '
            Me.txtDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtDest.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.txtDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtDest.Location = New System.Drawing.Point(56, 129)
            Me.txtDest.MaxLength = 3
            Me.txtDest.Name = "txtDest"
            Me.txtDest.Size = New System.Drawing.Size(57, 26)
            Me.txtDest.TabIndex = 4
            '
            'lblFnl
            '
            Me.lblFnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFnl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFnl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFnl.Location = New System.Drawing.Point(118, 130)
            Me.lblFnl.Name = "lblFnl"
            Me.lblFnl.Size = New System.Drawing.Size(44, 25)
            Me.lblFnl.Text = "FNL"
            Me.lblFnl.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtFnl
            '
            Me.txtFnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtFnl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.txtFnl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtFnl.Location = New System.Drawing.Point(169, 130)
            Me.txtFnl.MaxLength = 3
            Me.txtFnl.Name = "txtFnl"
            Me.txtFnl.Size = New System.Drawing.Size(57, 26)
            Me.txtFnl.TabIndex = 5
            '
            'frmLateBagInfPageTwo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraInfoP2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmLateBagInfPageTwo"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraInfoP2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraInfoP2 As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents btnAddBags As System.Windows.Forms.Button
        Friend WithEvents lblInfPage2 As System.Windows.Forms.Label
        Friend WithEvents lblQty As System.Windows.Forms.Label
        Friend WithEvents txtBags As System.Windows.Forms.TextBox
        Friend WithEvents btnUp As System.Windows.Forms.Button
        Friend WithEvents btnDown As System.Windows.Forms.Button
        Friend WithEvents lblPos As System.Windows.Forms.Label
        Friend WithEvents cmbPos As System.Windows.Forms.ComboBox
        Friend WithEvents lblDest As System.Windows.Forms.Label
        Friend WithEvents txtDest As System.Windows.Forms.TextBox
        Friend WithEvents lblFnl As System.Windows.Forms.Label
        Friend WithEvents txtFnl As System.Windows.Forms.TextBox
        Friend WithEvents btnBack3 As System.Windows.Forms.Button
    End Class
End Namespace