
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmUnloadBag
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
            Me.pnlScan = New OpenNETCF.Windows.Forms.GroupBox
            Me.lbl1 = New System.Windows.Forms.Label
            Me.txtBagtag = New System.Windows.Forms.TextBox
            Me.lblSts = New System.Windows.Forms.Label
            Me.lbl4 = New System.Windows.Forms.Label
            Me.lbl2 = New System.Windows.Forms.Label
            Me.lbl11 = New System.Windows.Forms.Label
            Me.lblFlt = New System.Windows.Forms.Label
            Me.lblDest = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.lblClass = New System.Windows.Forms.Label
            Me.lblStatus = New System.Windows.Forms.Label
            Me.pnlResults = New OpenNETCF.Windows.Forms.GroupBox
            Me.pnlScan.SuspendLayout()
            Me.pnlResults.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlScan
            '
            Me.pnlScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.pnlScan.Controls.Add(Me.lbl1)
            Me.pnlScan.Controls.Add(Me.txtBagtag)
            Me.pnlScan.Location = New System.Drawing.Point(0, 48)
            Me.pnlScan.Name = "pnlScan"
            Me.pnlScan.Size = New System.Drawing.Size(233, 74)
            '
            'lbl1
            '
            Me.lbl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl1.Location = New System.Drawing.Point(0, 8)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(233, 24)
            Me.lbl1.Text = "Scan/Enter Bagtag"
            Me.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtBagtag
            '
            Me.txtBagtag.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtBagtag.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
            Me.txtBagtag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtBagtag.Location = New System.Drawing.Point(32, 34)
            Me.txtBagtag.MaxLength = 10
            Me.txtBagtag.Name = "txtBagtag"
            Me.txtBagtag.Size = New System.Drawing.Size(169, 32)
            Me.txtBagtag.TabIndex = 1
            '
            'lblSts
            '
            Me.lblSts.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSts.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblSts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblSts.Location = New System.Drawing.Point(0, 0)
            Me.lblSts.Name = "lblSts"
            Me.lblSts.Size = New System.Drawing.Size(233, 25)
            Me.lblSts.Text = "Status"
            Me.lblSts.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lbl4
            '
            Me.lbl4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl4.Location = New System.Drawing.Point(0, 96)
            Me.lbl4.Name = "lbl4"
            Me.lbl4.Size = New System.Drawing.Size(233, 22)
            Me.lbl4.Text = "Class"
            Me.lbl4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lbl2
            '
            Me.lbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl2.Location = New System.Drawing.Point(136, 48)
            Me.lbl2.Name = "lbl2"
            Me.lbl2.Size = New System.Drawing.Size(97, 22)
            Me.lbl2.Text = "Dest"
            Me.lbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lbl11
            '
            Me.lbl11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lbl11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl11.Location = New System.Drawing.Point(0, 48)
            Me.lbl11.Name = "lbl11"
            Me.lbl11.Size = New System.Drawing.Size(97, 22)
            Me.lbl11.Text = "Flight"
            Me.lbl11.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlt
            '
            Me.lblFlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlt.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lblFlt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlt.Location = New System.Drawing.Point(8, 70)
            Me.lblFlt.Name = "lblFlt"
            Me.lblFlt.Size = New System.Drawing.Size(81, 24)
            Me.lblFlt.Text = "NW1543"
            Me.lblFlt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDest
            '
            Me.lblDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDest.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lblDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDest.Location = New System.Drawing.Point(152, 71)
            Me.lblDest.Name = "lblDest"
            Me.lblDest.Size = New System.Drawing.Size(65, 23)
            Me.lblDest.Text = "MSP"
            Me.lblDest.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(88, 48)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(57, 22)
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblClass
            '
            Me.lblClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblClass.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lblClass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblClass.Location = New System.Drawing.Point(96, 118)
            Me.lblClass.Name = "lblClass"
            Me.lblClass.Size = New System.Drawing.Size(41, 24)
            Me.lblClass.Text = "Y"
            Me.lblClass.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblStatus
            '
            Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblStatus.Location = New System.Drawing.Point(0, 24)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(233, 25)
            Me.lblStatus.Text = "** UNLOADED OK **"
            Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'pnlResults
            '
            Me.pnlResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.pnlResults.Controls.Add(Me.lblStatus)
            Me.pnlResults.Controls.Add(Me.lblClass)
            Me.pnlResults.Controls.Add(Me.Label3)
            Me.pnlResults.Controls.Add(Me.lblDest)
            Me.pnlResults.Controls.Add(Me.lblFlt)
            Me.pnlResults.Controls.Add(Me.lbl11)
            Me.pnlResults.Controls.Add(Me.lbl2)
            Me.pnlResults.Controls.Add(Me.lbl4)
            Me.pnlResults.Controls.Add(Me.lblSts)
            Me.pnlResults.Enabled = False
            Me.pnlResults.Location = New System.Drawing.Point(0, 128)
            Me.pnlResults.Name = "pnlResults"
            Me.pnlResults.Size = New System.Drawing.Size(233, 144)
            Me.pnlResults.Visible = False
            '
            'frmUnloadBag
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlResults)
            Me.Controls.Add(Me.pnlScan)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmUnloadBag"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.pnlScan.ResumeLayout(False)
            Me.pnlResults.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlScan As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents txtBagtag As System.Windows.Forms.TextBox
        Friend WithEvents lblSts As System.Windows.Forms.Label
        Friend WithEvents lbl4 As System.Windows.Forms.Label
        Friend WithEvents lbl2 As System.Windows.Forms.Label
        Friend WithEvents lbl11 As System.Windows.Forms.Label
        Friend WithEvents lblFlt As System.Windows.Forms.Label
        Friend WithEvents lblDest As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblClass As System.Windows.Forms.Label
        Private WithEvents pnlResults As OpenNETCF.Windows.Forms.GroupBox
        Private WithEvents lblStatus As System.Windows.Forms.Label
    End Class

End Namespace