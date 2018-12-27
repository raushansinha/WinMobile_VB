Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgNetworkError
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
            Me.fraInfo = New OpenNETCF.Windows.Forms.GroupBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.cmdHideReport = New System.Windows.Forms.Button
            Me.Label5 = New System.Windows.Forms.Label
            Me.lblTitle = New System.Windows.Forms.Label
            Me.fraInfo.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraInfo
            '
            Me.fraInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraInfo.Controls.Add(Me.Label1)
            Me.fraInfo.Controls.Add(Me.Label2)
            Me.fraInfo.Controls.Add(Me.Label4)
            Me.fraInfo.Controls.Add(Me.cmdHideReport)
            Me.fraInfo.Controls.Add(Me.Label5)
            Me.fraInfo.Location = New System.Drawing.Point(0, 40)
            Me.fraInfo.Name = "fraInfo"
            Me.fraInfo.Size = New System.Drawing.Size(233, 265)
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(8, 96)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(217, 41)
            Me.Label1.Text = "This screen will disappear when an RF connection is available."
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular)
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(8, 168)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(217, 49)
            Me.Label2.Text = "If the problem persists, notify the helpdesk of this error, the HHT ID, and your " & _
                "approximate location."
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(0, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(233, 25)
            Me.Label4.Text = "Error Information"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmdHideReport
            '
            Me.cmdHideReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdHideReport.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.cmdHideReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdHideReport.Location = New System.Drawing.Point(0, 232)
            Me.cmdHideReport.Name = "cmdHideReport"
            Me.cmdHideReport.Size = New System.Drawing.Size(233, 33)
            Me.cmdHideReport.TabIndex = 3
            Me.cmdHideReport.Text = "OK"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular)
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(8, 32)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(217, 33)
            Me.Label5.Text = "This scanner has lost its wireless network connection."
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(8, 8)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(217, 25)
            Me.lblTitle.Text = "NO RF CONNECTION"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dlgNoNetwork
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.AutoScroll = True
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.Controls.Add(Me.fraInfo)
            Me.Controls.Add(Me.lblTitle)
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.Name = "dlgNoNetwork"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraInfo.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraInfo As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cmdHideReport As System.Windows.Forms.Button
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblTitle As System.Windows.Forms.Label
    End Class
End Namespace