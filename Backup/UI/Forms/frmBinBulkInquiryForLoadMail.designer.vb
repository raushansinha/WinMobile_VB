Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmBinBulkInquiryForLoadMail
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
            Me.lblHeader = New System.Windows.Forms.Label
            Me.txtDate = New System.Windows.Forms.TextBox
            Me.txtFlight = New System.Windows.Forms.TextBox
            Me.txtBinBulk = New System.Windows.Forms.TextBox
            Me.lblParm3 = New System.Windows.Forms.Label
            Me.lblParm2 = New System.Windows.Forms.Label
            Me.lblParm1 = New System.Windows.Forms.Label
            Me.lblParm4 = New System.Windows.Forms.Label
            Me.cmbTypes = New System.Windows.Forms.ComboBox
            Me.btnContinue = New System.Windows.Forms.Button
            Me.fraParms.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraParms
            '
            Me.fraParms.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraParms.Controls.Add(Me.lblHeader)
            Me.fraParms.Controls.Add(Me.txtDate)
            Me.fraParms.Controls.Add(Me.txtFlight)
            Me.fraParms.Controls.Add(Me.txtBinBulk)
            Me.fraParms.Controls.Add(Me.lblParm3)
            Me.fraParms.Controls.Add(Me.lblParm2)
            Me.fraParms.Controls.Add(Me.lblParm1)
            Me.fraParms.Controls.Add(Me.lblParm4)
            Me.fraParms.Controls.Add(Me.cmbTypes)
            Me.fraParms.Controls.Add(Me.btnContinue)
            Me.fraParms.Location = New System.Drawing.Point(4, 48)
            Me.fraParms.Name = "fraParms"
            Me.fraParms.Size = New System.Drawing.Size(233, 233)
            '
            'lblHeader
            '
            Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHeader.Location = New System.Drawing.Point(0, 0)
            Me.lblHeader.Name = "lblHeader"
            Me.lblHeader.Size = New System.Drawing.Size(237, 25)
            Me.lblHeader.Text = "Enter Load Information"
            Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtDate
            '
            Me.txtDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtDate.Location = New System.Drawing.Point(112, 104)
            Me.txtDate.MaxLength = 5
            Me.txtDate.Name = "txtDate"
            Me.txtDate.Size = New System.Drawing.Size(81, 26)
            Me.txtDate.TabIndex = 3
            '
            'txtFlight
            '
            Me.txtFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtFlight.Location = New System.Drawing.Point(112, 72)
            Me.txtFlight.MaxLength = 6
            Me.txtFlight.Name = "txtFlight"
            Me.txtFlight.Size = New System.Drawing.Size(81, 26)
            Me.txtFlight.TabIndex = 2
            '
            'txtBinBulk
            '
            Me.txtBinBulk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtBinBulk.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtBinBulk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtBinBulk.Location = New System.Drawing.Point(112, 40)
            Me.txtBinBulk.MaxLength = 2
            Me.txtBinBulk.Name = "txtBinBulk"
            Me.txtBinBulk.Size = New System.Drawing.Size(81, 26)
            Me.txtBinBulk.TabIndex = 1
            '
            'lblParm3
            '
            Me.lblParm3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblParm3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblParm3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblParm3.Location = New System.Drawing.Point(48, 104)
            Me.lblParm3.Name = "lblParm3"
            Me.lblParm3.Size = New System.Drawing.Size(57, 17)
            Me.lblParm3.Text = "DATE"
            Me.lblParm3.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblParm2
            '
            Me.lblParm2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblParm2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblParm2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblParm2.Location = New System.Drawing.Point(33, 72)
            Me.lblParm2.Name = "lblParm2"
            Me.lblParm2.Size = New System.Drawing.Size(72, 17)
            Me.lblParm2.Text = "FLIGHT"
            Me.lblParm2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblParm1
            '
            Me.lblParm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblParm1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblParm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblParm1.Location = New System.Drawing.Point(3, 40)
            Me.lblParm1.Name = "lblParm1"
            Me.lblParm1.Size = New System.Drawing.Size(102, 17)
            Me.lblParm1.Text = "BIN/BULK"
            Me.lblParm1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblParm4
            '
            Me.lblParm4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblParm4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblParm4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblParm4.Location = New System.Drawing.Point(48, 136)
            Me.lblParm4.Name = "lblParm4"
            Me.lblParm4.Size = New System.Drawing.Size(57, 17)
            Me.lblParm4.Text = "TYPE"
            Me.lblParm4.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cmbTypes
            '
            Me.cmbTypes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmbTypes.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.cmbTypes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmbTypes.Items.Add("EMERY")
            Me.cmbTypes.Items.Add("FOR")
            Me.cmbTypes.Items.Add("MAIL")
            Me.cmbTypes.Items.Add("SAM")
            Me.cmbTypes.Items.Add("XMAIL")
            Me.cmbTypes.Location = New System.Drawing.Point(112, 136)
            Me.cmbTypes.Name = "cmbTypes"
            Me.cmbTypes.Size = New System.Drawing.Size(81, 27)
            Me.cmbTypes.TabIndex = 4
            '
            'btnContinue
            '
            Me.btnContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnContinue.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnContinue.Location = New System.Drawing.Point(48, 184)
            Me.btnContinue.Name = "btnContinue"
            Me.btnContinue.Size = New System.Drawing.Size(137, 33)
            Me.btnContinue.TabIndex = 5
            Me.btnContinue.Text = "[ENT] Continue"
            '
            'frmBinBulkInquiryForLoadMail
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
            Me.Name = "frmBinBulkInquiryForLoadMail"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraParms.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraParms As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblHeader As System.Windows.Forms.Label
        Friend WithEvents txtDate As System.Windows.Forms.TextBox
        Friend WithEvents txtFlight As System.Windows.Forms.TextBox
        Friend WithEvents txtBinBulk As System.Windows.Forms.TextBox
        Friend WithEvents lblParm3 As System.Windows.Forms.Label
        Friend WithEvents lblParm2 As System.Windows.Forms.Label
        Friend WithEvents lblParm1 As System.Windows.Forms.Label
        Friend WithEvents lblParm4 As System.Windows.Forms.Label
        Friend WithEvents cmbTypes As System.Windows.Forms.ComboBox
        Friend WithEvents btnContinue As System.Windows.Forms.Button
    End Class
End Namespace
