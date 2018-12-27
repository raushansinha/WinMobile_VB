Imports OpenNETCF.Windows.Forms

Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgNoNetworkPrompt
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
            Me.lblErrLong = New System.Windows.Forms.Label
            Me.lblTitle = New System.Windows.Forms.Label
            Me.SuspendLayout()
            '
            'cmdClose
            '
            Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.cmdClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdClose.Location = New System.Drawing.Point(3, 113)
            Me.cmdClose.Name = "cmdClose"
            Me.cmdClose.Size = New System.Drawing.Size(233, 33)
            Me.cmdClose.TabIndex = 1
            Me.cmdClose.Text = "[ESC] OK"
            '
            'lblErrLong
            '
            Me.lblErrLong.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblErrLong.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblErrLong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblErrLong.Location = New System.Drawing.Point(3, 35)
            Me.lblErrLong.Name = "lblErrLong"
            Me.lblErrLong.Size = New System.Drawing.Size(233, 72)
            Me.lblErrLong.Text = "You need to be in RF Zone to perform this operation. Please move to an RF availab" & _
                "le zone"
            Me.lblErrLong.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(3, 4)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(233, 25)
            Me.lblTitle.Text = "NO RF"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dlgNoNetworkPrompt
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.AutoScroll = True
            Me.ClientSize = New System.Drawing.Size(240, 150)
            Me.ControlBox = False
            Me.Controls.Add(Me.cmdClose)
            Me.Controls.Add(Me.lblErrLong)
            Me.Controls.Add(Me.lblTitle)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.Name = "dlgNoNetworkPrompt"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents cmdClose As System.Windows.Forms.Button
        Friend WithEvents lblErrLong As System.Windows.Forms.Label
        Friend WithEvents lblTitle As System.Windows.Forms.Label
    End Class

End Namespace