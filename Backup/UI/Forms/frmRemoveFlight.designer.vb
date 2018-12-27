Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmRemoveFlight
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
            Me.cmbFlights = New System.Windows.Forms.ComboBox
            Me.btnRemove = New System.Windows.Forms.Button
            Me.fraParms.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraParms
            '
            Me.fraParms.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraParms.Controls.Add(Me.lblHeader)
            Me.fraParms.Controls.Add(Me.cmbFlights)
            Me.fraParms.Controls.Add(Me.btnRemove)
            Me.fraParms.Location = New System.Drawing.Point(4, 48)
            Me.fraParms.Name = "fraParms"
            Me.fraParms.Size = New System.Drawing.Size(233, 217)
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
            Me.cmbFlights.Location = New System.Drawing.Point(20, 72)
            Me.cmbFlights.Name = "cmbFlights"
            Me.cmbFlights.Size = New System.Drawing.Size(196, 27)
            Me.cmbFlights.TabIndex = 0
            '
            'btnRemove
            '
            Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnRemove.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnRemove.Location = New System.Drawing.Point(54, 148)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Size = New System.Drawing.Size(137, 33)
            Me.btnRemove.TabIndex = 1
            Me.btnRemove.Text = "[ENT] Remove"
            '
            'frmRemoveFlight
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
            Me.Name = "frmRemoveFlight"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraParms.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraParms As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblHeader As System.Windows.Forms.Label
        Friend WithEvents cmbFlights As System.Windows.Forms.ComboBox
        Friend WithEvents btnRemove As System.Windows.Forms.Button
    End Class
End Namespace
