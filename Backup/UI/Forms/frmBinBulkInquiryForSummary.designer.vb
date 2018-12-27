
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmBinBulkInquiryForSummary
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
            Me.btnLookup = New System.Windows.Forms.Button
            Me.lbl6 = New System.Windows.Forms.Label
            Me.lb17 = New System.Windows.Forms.Label
            Me.txtFlight = New System.Windows.Forms.TextBox
            Me.txtDate = New System.Windows.Forms.TextBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.lbl1 = New System.Windows.Forms.Label
            Me.txtBinBulk = New System.Windows.Forms.TextBox
            Me.fraParms.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraParms
            '
            Me.fraParms.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraParms.Controls.Add(Me.btnLookup)
            Me.fraParms.Controls.Add(Me.lbl6)
            Me.fraParms.Controls.Add(Me.lb17)
            Me.fraParms.Controls.Add(Me.txtFlight)
            Me.fraParms.Controls.Add(Me.txtDate)
            Me.fraParms.Controls.Add(Me.Label2)
            Me.fraParms.Controls.Add(Me.lbl1)
            Me.fraParms.Controls.Add(Me.txtBinBulk)
            Me.fraParms.Location = New System.Drawing.Point(0, 67)
            Me.fraParms.Name = "fraParms"
            Me.fraParms.Size = New System.Drawing.Size(240, 208)
            '
            'btnLookup
            '
            Me.btnLookup.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnLookup.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnLookup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnLookup.Location = New System.Drawing.Point(48, 168)
            Me.btnLookup.Name = "btnLookup"
            Me.btnLookup.Size = New System.Drawing.Size(137, 33)
            Me.btnLookup.TabIndex = 3
            Me.btnLookup.Text = "[ENT] Lookup"
            '
            'lbl6
            '
            Me.lbl6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl6.Location = New System.Drawing.Point(32, 80)
            Me.lbl6.Name = "lbl6"
            Me.lbl6.Size = New System.Drawing.Size(65, 25)
            Me.lbl6.Text = "Flight"
            Me.lbl6.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lb17
            '
            Me.lb17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lb17.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lb17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lb17.Location = New System.Drawing.Point(40, 123)
            Me.lb17.Name = "lb17"
            Me.lb17.Size = New System.Drawing.Size(57, 25)
            Me.lb17.Text = "Date"
            Me.lb17.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtFlight
            '
            Me.txtFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtFlight.Location = New System.Drawing.Point(104, 80)
            Me.txtFlight.MaxLength = 6
            Me.txtFlight.Name = "txtFlight"
            Me.txtFlight.Size = New System.Drawing.Size(81, 26)
            Me.txtFlight.TabIndex = 1
            '
            'txtDate
            '
            Me.txtDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtDate.Location = New System.Drawing.Point(104, 128)
            Me.txtDate.Name = "txtDate"
            Me.txtDate.Size = New System.Drawing.Size(81, 26)
            Me.txtDate.TabIndex = 2
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(96, 58)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(97, 13)
            Me.Label2.Text = "(Blank = 'ALL')"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lbl1
            '
            Me.lbl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl1.Location = New System.Drawing.Point(3, 32)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(94, 25)
            Me.lbl1.Text = "Bin/Bulk"
            Me.lbl1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtBinBulk
            '
            Me.txtBinBulk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtBinBulk.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtBinBulk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtBinBulk.Location = New System.Drawing.Point(104, 32)
            Me.txtBinBulk.MaxLength = 2
            Me.txtBinBulk.Name = "txtBinBulk"
            Me.txtBinBulk.Size = New System.Drawing.Size(113, 26)
            Me.txtBinBulk.TabIndex = 0
            '
            'frmBinBulkInquiryForSummary
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
            Me.Name = "frmBinBulkInquiryForSummary"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraParms.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraParms As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents btnLookup As System.Windows.Forms.Button
        Friend WithEvents lbl6 As System.Windows.Forms.Label
        Friend WithEvents lb17 As System.Windows.Forms.Label
        Friend WithEvents txtFlight As System.Windows.Forms.TextBox
        Friend WithEvents txtDate As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents txtBinBulk As System.Windows.Forms.TextBox
    End Class
End Namespace