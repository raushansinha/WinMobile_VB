
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI



    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgCloseReopenFlight
        Inherits System.Windows.Forms.Form

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
            Me.fraCloseOpen = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblHeader = New System.Windows.Forms.Label
            Me.cmdCloseFlt = New System.Windows.Forms.Button
            Me.cmdReopenFlt = New System.Windows.Forms.Button
            Me.fraCloseOpen.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraCloseOpen
            '
            Me.fraCloseOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraCloseOpen.Controls.Add(Me.lblHeader)
            Me.fraCloseOpen.Controls.Add(Me.cmdCloseFlt)
            Me.fraCloseOpen.Controls.Add(Me.cmdReopenFlt)
            Me.fraCloseOpen.Location = New System.Drawing.Point(3, 7)
            Me.fraCloseOpen.Name = "fraCloseOpen"
            Me.fraCloseOpen.Size = New System.Drawing.Size(233, 89)
            '
            'lblHeader
            '
            Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHeader.Location = New System.Drawing.Point(0, 8)
            Me.lblHeader.Name = "lblHeader"
            Me.lblHeader.Size = New System.Drawing.Size(233, 25)
            Me.lblHeader.Text = "Close/Reopen Flight?"
            Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmdCloseFlt
            '
            Me.cmdCloseFlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdCloseFlt.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdCloseFlt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdCloseFlt.Location = New System.Drawing.Point(8, 40)
            Me.cmdCloseFlt.Name = "cmdCloseFlt"
            Me.cmdCloseFlt.Size = New System.Drawing.Size(97, 41)
            Me.cmdCloseFlt.TabIndex = 1
            Me.cmdCloseFlt.Text = "[1] Close"
            '
            'cmdReopenFlt
            '
            Me.cmdReopenFlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdReopenFlt.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdReopenFlt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdReopenFlt.Location = New System.Drawing.Point(120, 40)
            Me.cmdReopenFlt.Name = "cmdReopenFlt"
            Me.cmdReopenFlt.Size = New System.Drawing.Size(105, 41)
            Me.cmdReopenFlt.TabIndex = 2
            Me.cmdReopenFlt.Text = "[3] Reopen"
            '
            'dlgCloseReopenFlight
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 105)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraCloseOpen)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 150)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "dlgCloseReopenFlight"
            Me.fraCloseOpen.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraCloseOpen As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblHeader As System.Windows.Forms.Label
        Friend WithEvents cmdCloseFlt As System.Windows.Forms.Button
        Friend WithEvents cmdReopenFlt As System.Windows.Forms.Button
    End Class
End Namespace
