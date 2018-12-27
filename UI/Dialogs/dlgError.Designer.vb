Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgError
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
            Me.cmdClose = New System.Windows.Forms.Button
            Me.Label3 = New System.Windows.Forms.Label
            Me.lblErrorDesc = New System.Windows.Forms.Label
            Me.lblErrorTitle = New System.Windows.Forms.Label
            Me.cmdReport = New System.Windows.Forms.Button
            Me.lblTitle = New System.Windows.Forms.Label
            Me.SuspendLayout()
            '
            'cmdClose
            '
            Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.cmdClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdClose.Location = New System.Drawing.Point(0, 262)
            Me.cmdClose.Name = "cmdClose"
            Me.cmdClose.Size = New System.Drawing.Size(233, 33)
            Me.cmdClose.TabIndex = 0
            Me.cmdClose.Text = "[ESC] Close"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(9, 175)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(209, 33)
            Me.Label3.Text = "If the condition persists, call the NWA Help Desk."
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblErrorDesc
            '
            Me.lblErrorDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblErrorDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblErrorDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblErrorDesc.Location = New System.Drawing.Point(0, 104)
            Me.lblErrorDesc.Name = "lblErrorDesc"
            Me.lblErrorDesc.Size = New System.Drawing.Size(233, 71)
            Me.lblErrorDesc.Text = "An error occurred while connecting to the network.  Please try your request again" & _
                "."
            Me.lblErrorDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblErrorTitle
            '
            Me.lblErrorTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblErrorTitle.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblErrorTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblErrorTitle.Location = New System.Drawing.Point(0, 44)
            Me.lblErrorTitle.Name = "lblErrorTitle"
            Me.lblErrorTitle.Size = New System.Drawing.Size(233, 49)
            Me.lblErrorTitle.Text = "Network Connection Error"
            Me.lblErrorTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmdReport
            '
            Me.cmdReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdReport.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
            Me.cmdReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdReport.Location = New System.Drawing.Point(0, 213)
            Me.cmdReport.Name = "cmdReport"
            Me.cmdReport.Size = New System.Drawing.Size(233, 41)
            Me.cmdReport.TabIndex = 4
            Me.cmdReport.Text = "What do I Report?"
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(4, 8)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(229, 25)
            Me.lblTitle.Text = "ERROR TYPE"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dlgError
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.Controls.Add(Me.cmdClose)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.lblErrorDesc)
            Me.Controls.Add(Me.lblErrorTitle)
            Me.Controls.Add(Me.cmdReport)
            Me.Controls.Add(Me.lblTitle)
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.Name = "dlgError"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents cmdClose As System.Windows.Forms.Button
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblErrorDesc As System.Windows.Forms.Label
        Friend WithEvents lblErrorTitle As System.Windows.Forms.Label
        Friend WithEvents cmdReport As System.Windows.Forms.Button
        Friend WithEvents lblTitle As System.Windows.Forms.Label
    End Class
End Namespace