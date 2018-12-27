Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmSetBagtagAlert
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
            Me.fraBagtag = New OpenNETCF.Windows.Forms.GroupBox
            Me.txtBagtag = New System.Windows.Forms.TextBox
            Me.lblEnterBagtagTitle = New System.Windows.Forms.Label
            Me.fraParms = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblFlightInfoTitle = New System.Windows.Forms.Label
            Me.lblFlght = New System.Windows.Forms.Label
            Me.lblDte = New System.Windows.Forms.Label
            Me.txtFlight = New System.Windows.Forms.TextBox
            Me.txtDate = New System.Windows.Forms.TextBox
            Me.fraWait = New OpenNETCF.Windows.Forms.GroupBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.lblRetrieving = New System.Windows.Forms.Label
            Me.btnContinue = New System.Windows.Forms.Button
            Me.fraBagtag.SuspendLayout()
            Me.fraParms.SuspendLayout()
            Me.fraWait.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraBagtag
            '
            Me.fraBagtag.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraBagtag.Controls.Add(Me.txtBagtag)
            Me.fraBagtag.Controls.Add(Me.lblEnterBagtagTitle)
            Me.fraBagtag.Location = New System.Drawing.Point(4, 159)
            Me.fraBagtag.Name = "fraBagtag"
            Me.fraBagtag.Size = New System.Drawing.Size(233, 65)
            '
            'txtBagtag
            '
            Me.txtBagtag.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtBagtag.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
            Me.txtBagtag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtBagtag.Location = New System.Drawing.Point(32, 27)
            Me.txtBagtag.MaxLength = 10
            Me.txtBagtag.Name = "txtBagtag"
            Me.txtBagtag.Size = New System.Drawing.Size(169, 32)
            Me.txtBagtag.TabIndex = 2
            '
            'lblEnterBagtagTitle
            '
            Me.lblEnterBagtagTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblEnterBagtagTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblEnterBagtagTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblEnterBagtagTitle.Location = New System.Drawing.Point(0, 0)
            Me.lblEnterBagtagTitle.Name = "lblEnterBagtagTitle"
            Me.lblEnterBagtagTitle.Size = New System.Drawing.Size(233, 24)
            Me.lblEnterBagtagTitle.Text = "Enter Bagtag"
            Me.lblEnterBagtagTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraParms
            '
            Me.fraParms.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraParms.Controls.Add(Me.lblFlightInfoTitle)
            Me.fraParms.Controls.Add(Me.lblFlght)
            Me.fraParms.Controls.Add(Me.lblDte)
            Me.fraParms.Controls.Add(Me.txtFlight)
            Me.fraParms.Controls.Add(Me.txtDate)
            Me.fraParms.Location = New System.Drawing.Point(4, 48)
            Me.fraParms.Name = "fraParms"
            Me.fraParms.Size = New System.Drawing.Size(233, 105)
            '
            'lblFlightInfoTitle
            '
            Me.lblFlightInfoTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlightInfoTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblFlightInfoTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlightInfoTitle.Location = New System.Drawing.Point(0, 0)
            Me.lblFlightInfoTitle.Name = "lblFlightInfoTitle"
            Me.lblFlightInfoTitle.Size = New System.Drawing.Size(233, 24)
            Me.lblFlightInfoTitle.Text = "Enter Flight Info"
            Me.lblFlightInfoTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlght
            '
            Me.lblFlght.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlght.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlght.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlght.Location = New System.Drawing.Point(24, 32)
            Me.lblFlght.Name = "lblFlght"
            Me.lblFlght.Size = New System.Drawing.Size(74, 17)
            Me.lblFlght.Text = "FLIGHT"
            Me.lblFlght.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblDte
            '
            Me.lblDte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDte.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDte.Location = New System.Drawing.Point(40, 72)
            Me.lblDte.Name = "lblDte"
            Me.lblDte.Size = New System.Drawing.Size(57, 17)
            Me.lblDte.Text = "DATE"
            Me.lblDte.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtFlight
            '
            Me.txtFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtFlight.Location = New System.Drawing.Point(104, 29)
            Me.txtFlight.MaxLength = 6
            Me.txtFlight.Name = "txtFlight"
            Me.txtFlight.Size = New System.Drawing.Size(81, 26)
            Me.txtFlight.TabIndex = 0
            '
            'txtDate
            '
            Me.txtDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtDate.Location = New System.Drawing.Point(104, 69)
            Me.txtDate.MaxLength = 5
            Me.txtDate.Name = "txtDate"
            Me.txtDate.Size = New System.Drawing.Size(81, 26)
            Me.txtDate.TabIndex = 1
            '
            'fraWait
            '
            Me.fraWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraWait.Controls.Add(Me.Label4)
            Me.fraWait.Controls.Add(Me.lblRetrieving)
            Me.fraWait.Location = New System.Drawing.Point(4, 100)
            Me.fraWait.Name = "fraWait"
            Me.fraWait.Size = New System.Drawing.Size(233, 125)
            Me.fraWait.Visible = False
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label4.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(8, 88)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(217, 33)
            Me.Label4.Text = "Please Wait..."
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblRetrieving
            '
            Me.lblRetrieving.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblRetrieving.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
            Me.lblRetrieving.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblRetrieving.Location = New System.Drawing.Point(8, 11)
            Me.lblRetrieving.Name = "lblRetrieving"
            Me.lblRetrieving.Size = New System.Drawing.Size(217, 53)
            Me.lblRetrieving.Text = "Retrieving Bagtag Alert Data"
            Me.lblRetrieving.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'btnContinue
            '
            Me.btnContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnContinue.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnContinue.Location = New System.Drawing.Point(52, 231)
            Me.btnContinue.Name = "btnContinue"
            Me.btnContinue.Size = New System.Drawing.Size(137, 33)
            Me.btnContinue.TabIndex = 3
            Me.btnContinue.Text = "[ENT] Continue"
            '
            'frmSetBagtagAlert
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraParms)
            Me.Controls.Add(Me.btnContinue)
            Me.Controls.Add(Me.fraBagtag)
            Me.Controls.Add(Me.fraWait)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmSetBagtagAlert"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraBagtag.ResumeLayout(False)
            Me.fraParms.ResumeLayout(False)
            Me.fraWait.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraBagtag As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents txtBagtag As System.Windows.Forms.TextBox
        Friend WithEvents lblEnterBagtagTitle As System.Windows.Forms.Label
        Friend WithEvents fraParms As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblFlightInfoTitle As System.Windows.Forms.Label
        Friend WithEvents lblFlght As System.Windows.Forms.Label
        Friend WithEvents lblDte As System.Windows.Forms.Label
        Friend WithEvents txtFlight As System.Windows.Forms.TextBox
        Friend WithEvents txtDate As System.Windows.Forms.TextBox
        Friend WithEvents btnContinue As System.Windows.Forms.Button
        Friend WithEvents fraWait As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblRetrieving As System.Windows.Forms.Label
    End Class
End Namespace

