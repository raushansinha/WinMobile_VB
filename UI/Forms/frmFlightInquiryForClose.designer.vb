Namespace NWA.Safetrac.Scanner.UI



    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmFlightInquiryForClose
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
            Me.grbPage2 = New OpenNETCF.Windows.Forms.GroupBox
            Me.txtFlight = New System.Windows.Forms.TextBox
            Me.lblDate = New System.Windows.Forms.Label
            Me.lblFlight = New System.Windows.Forms.Label
            Me.lblEnterFlight = New System.Windows.Forms.Label
            Me.txtDate = New System.Windows.Forms.TextBox
            Me.btnNext = New System.Windows.Forms.Button
            Me.btnPrev = New System.Windows.Forms.Button
            Me.grbPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbPage2
            '
            Me.grbPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbPage2.Controls.Add(Me.txtFlight)
            Me.grbPage2.Controls.Add(Me.lblDate)
            Me.grbPage2.Controls.Add(Me.lblFlight)
            Me.grbPage2.Controls.Add(Me.lblEnterFlight)
            Me.grbPage2.Controls.Add(Me.txtDate)
            Me.grbPage2.Location = New System.Drawing.Point(0, 57)
            Me.grbPage2.Name = "grbPage2"
            Me.grbPage2.Size = New System.Drawing.Size(233, 197)
            '
            'txtFlight
            '
            Me.txtFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtFlight.Location = New System.Drawing.Point(112, 48)
            Me.txtFlight.MaxLength = 6
            Me.txtFlight.Name = "txtFlight"
            Me.txtFlight.Size = New System.Drawing.Size(81, 26)
            Me.txtFlight.TabIndex = 0
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(48, 91)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(57, 25)
            Me.lblDate.Text = "Date"
            Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblFlight
            '
            Me.lblFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlight.Location = New System.Drawing.Point(40, 48)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(65, 25)
            Me.lblFlight.Text = "Flight"
            Me.lblFlight.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblEnterFlight
            '
            Me.lblEnterFlight.BackColor = System.Drawing.SystemColors.WindowText
            Me.lblEnterFlight.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblEnterFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblEnterFlight.Location = New System.Drawing.Point(0, 0)
            Me.lblEnterFlight.Name = "lblEnterFlight"
            Me.lblEnterFlight.Size = New System.Drawing.Size(233, 25)
            Me.lblEnterFlight.Text = "Enter Flight"
            Me.lblEnterFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtDate
            '
            Me.txtDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtDate.Location = New System.Drawing.Point(112, 96)
            Me.txtDate.MaxLength = 5
            Me.txtDate.Name = "txtDate"
            Me.txtDate.Size = New System.Drawing.Size(81, 26)
            Me.txtDate.TabIndex = 1
            '
            'btnNext
            '
            Me.btnNext.BackColor = System.Drawing.Color.Silver
            Me.btnNext.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnNext.Location = New System.Drawing.Point(120, 258)
            Me.btnNext.Name = "btnNext"
            Me.btnNext.Size = New System.Drawing.Size(113, 41)
            Me.btnNext.TabIndex = 2
            Me.btnNext.Text = "(Ent) Next >"
            '
            'btnPrev
            '
            Me.btnPrev.BackColor = System.Drawing.Color.Silver
            Me.btnPrev.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.btnPrev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnPrev.Location = New System.Drawing.Point(0, 258)
            Me.btnPrev.Name = "btnPrev"
            Me.btnPrev.Size = New System.Drawing.Size(113, 41)
            Me.btnPrev.TabIndex = 3
            Me.btnPrev.Text = "< Prev"
            '
            'frmFlightInquiryForClose
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.grbPage2)
            Me.Controls.Add(Me.btnNext)
            Me.Controls.Add(Me.btnPrev)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmFlightInquiryForClose"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.grbPage2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbPage2 As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents txtFlight As System.Windows.Forms.TextBox
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents lblEnterFlight As System.Windows.Forms.Label
        Friend WithEvents txtDate As System.Windows.Forms.TextBox
        Friend WithEvents btnNext As System.Windows.Forms.Button
        Friend WithEvents btnPrev As System.Windows.Forms.Button
    End Class
End Namespace