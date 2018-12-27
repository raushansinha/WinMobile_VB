
Imports OpenNETCF.Windows.Forms

Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmAlertCondition
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
            Me.fraAlert = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblCancel = New System.Windows.Forms.Label
            Me.lblLoad = New System.Windows.Forms.Label
            Me.lblAlert = New System.Windows.Forms.Label
            Me.fraScan = New OpenNETCF.Windows.Forms.GroupBox
            Me.txtBagtag = New System.Windows.Forms.TextBox
            Me.lblScan = New System.Windows.Forms.Label
            Me.fraAlert.SuspendLayout()
            Me.fraScan.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraAlert
            '
            Me.fraAlert.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraAlert.Controls.Add(Me.lblCancel)
            Me.fraAlert.Controls.Add(Me.lblLoad)
            Me.fraAlert.Controls.Add(Me.lblAlert)
            Me.fraAlert.Location = New System.Drawing.Point(4, 112)
            Me.fraAlert.Name = "fraAlert"
            Me.fraAlert.Size = New System.Drawing.Size(233, 169)
            '
            'lblCancel
            '
            Me.lblCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCancel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCancel.Location = New System.Drawing.Point(32, 120)
            Me.lblCancel.Name = "lblCancel"
            Me.lblCancel.Size = New System.Drawing.Size(161, 25)
            Me.lblCancel.Text = "[3] Cancel load"
            '
            'lblLoad
            '
            Me.lblLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblLoad.Location = New System.Drawing.Point(32, 64)
            Me.lblLoad.Name = "lblLoad"
            Me.lblLoad.Size = New System.Drawing.Size(181, 25)
            Me.lblLoad.Text = "[1] Load this bag"
            '
            'lblAlert
            '
            Me.lblAlert.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblAlert.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblAlert.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblAlert.Location = New System.Drawing.Point(8, 16)
            Me.lblAlert.Name = "lblAlert"
            Me.lblAlert.Size = New System.Drawing.Size(217, 25)
            Me.lblAlert.Text = "BAGTAG ON ALERT"
            Me.lblAlert.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraScan
            '
            Me.fraScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraScan.Controls.Add(Me.txtBagtag)
            Me.fraScan.Controls.Add(Me.lblScan)
            Me.fraScan.Location = New System.Drawing.Point(4, 47)
            Me.fraScan.Name = "fraScan"
            Me.fraScan.Size = New System.Drawing.Size(233, 65)
            '
            'txtBagtag
            '
            Me.txtBagtag.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtBagtag.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
            Me.txtBagtag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtBagtag.Location = New System.Drawing.Point(32, 28)
            Me.txtBagtag.MaxLength = 10
            Me.txtBagtag.Name = "txtBagtag"
            Me.txtBagtag.Size = New System.Drawing.Size(169, 32)
            Me.txtBagtag.TabIndex = 0
            '
            'lblScan
            '
            Me.lblScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblScan.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblScan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblScan.Location = New System.Drawing.Point(-1, 0)
            Me.lblScan.Name = "lblScan"
            Me.lblScan.Size = New System.Drawing.Size(233, 24)
            Me.lblScan.Text = "Scan/Enter Bagtag"
            Me.lblScan.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmAlertCondition
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraAlert)
            Me.Controls.Add(Me.fraScan)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmAlertCondition"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraAlert.ResumeLayout(False)
            Me.fraScan.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraAlert As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblCancel As System.Windows.Forms.Label
        Friend WithEvents lblLoad As System.Windows.Forms.Label
        Friend WithEvents lblAlert As System.Windows.Forms.Label
        Friend WithEvents fraScan As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents txtBagtag As System.Windows.Forms.TextBox
        Friend WithEvents lblScan As System.Windows.Forms.Label
    End Class
End Namespace