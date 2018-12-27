Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmModifyFlight
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
            Me.cbEnable = New System.Windows.Forms.CheckBox
            Me.lblHeader = New System.Windows.Forms.Label
            Me.cmbFlights = New System.Windows.Forms.ComboBox
            Me.cmdModify = New System.Windows.Forms.Button
            Me.fraParms.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraParms
            '
            Me.fraParms.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraParms.Controls.Add(Me.cbEnable)
            Me.fraParms.Controls.Add(Me.lblHeader)
            Me.fraParms.Controls.Add(Me.cmbFlights)
            Me.fraParms.Controls.Add(Me.cmdModify)
            Me.fraParms.Location = New System.Drawing.Point(4, 48)
            Me.fraParms.Name = "fraParms"
            Me.fraParms.Size = New System.Drawing.Size(233, 217)
            '
            'cbEnable
            '
            Me.cbEnable.Enabled = False
            Me.cbEnable.Location = New System.Drawing.Point(72, 107)
            Me.cbEnable.Name = "cbEnable"
            Me.cbEnable.Size = New System.Drawing.Size(100, 20)
            Me.cbEnable.TabIndex = 4
            Me.cbEnable.Text = "Disable PBM"
            '
            'lblHeader
            '
            Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHeader.Location = New System.Drawing.Point(0, 0)
            Me.lblHeader.Name = "lblHeader"
            Me.lblHeader.Size = New System.Drawing.Size(237, 25)
            Me.lblHeader.Text = "Select Flight"
            Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmbFlights
            '
            Me.cmbFlights.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmbFlights.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.cmbFlights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmbFlights.Location = New System.Drawing.Point(18, 57)
            Me.cmbFlights.Name = "cmbFlights"
            Me.cmbFlights.Size = New System.Drawing.Size(196, 27)
            Me.cmbFlights.TabIndex = 8
            '
            'cmdModify
            '
            Me.cmdModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdModify.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.cmdModify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdModify.Location = New System.Drawing.Point(54, 148)
            Me.cmdModify.Name = "cmdModify"
            Me.cmdModify.Size = New System.Drawing.Size(137, 33)
            Me.cmdModify.TabIndex = 9
            Me.cmdModify.Text = "[ENT] Modify"
            '
            'frmModifyFlight
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
            Me.Name = "frmModifyFlight"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraParms.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraParms As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblHeader As System.Windows.Forms.Label
        Friend WithEvents cmbFlights As System.Windows.Forms.ComboBox
        Friend WithEvents cmdModify As System.Windows.Forms.Button
        Friend WithEvents cbEnable As System.Windows.Forms.CheckBox
    End Class
End Namespace
