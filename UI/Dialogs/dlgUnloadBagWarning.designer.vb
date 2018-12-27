
Imports OpenNETCF.Windows.Forms

Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgUnloadBagWarning
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
            Me.fraPage3 = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblErr1 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.lblErr2 = New System.Windows.Forms.Label
            Me.cmdPrev = New System.Windows.Forms.Button
            Me.cmdNext = New System.Windows.Forms.Button
            Me.fraPage3.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraPage3
            '
            Me.fraPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraPage3.Controls.Add(Me.lblErr1)
            Me.fraPage3.Controls.Add(Me.Label4)
            Me.fraPage3.Controls.Add(Me.lblErr2)
            Me.fraPage3.Location = New System.Drawing.Point(0, 51)
            Me.fraPage3.Name = "fraPage3"
            Me.fraPage3.Size = New System.Drawing.Size(233, 193)
            '
            'lblErr1
            '
            Me.lblErr1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblErr1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblErr1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblErr1.Location = New System.Drawing.Point(16, 28)
            Me.lblErr1.Name = "lblErr1"
            Me.lblErr1.Size = New System.Drawing.Size(201, 49)
            Me.lblErr1.Text = "There are bags to unload."
            Me.lblErr1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label4.ForeColor = System.Drawing.Color.White
            Me.Label4.Location = New System.Drawing.Point(0, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(233, 25)
            Me.Label4.Text = "-- WARNING --"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblErr2
            '
            Me.lblErr2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblErr2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblErr2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblErr2.Location = New System.Drawing.Point(8, 76)
            Me.lblErr2.Name = "lblErr2"
            Me.lblErr2.Size = New System.Drawing.Size(217, 73)
            Me.lblErr2.Text = "To view bags, press [ESC] and then CTRL+H"
            Me.lblErr2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmdPrev
            '
            Me.cmdPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdPrev.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdPrev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdPrev.Location = New System.Drawing.Point(0, 254)
            Me.cmdPrev.Name = "cmdPrev"
            Me.cmdPrev.Size = New System.Drawing.Size(113, 41)
            Me.cmdPrev.TabIndex = 6
            Me.cmdPrev.Text = "< Prev"
            Me.cmdPrev.Visible = False
            '
            'cmdNext
            '
            Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdNext.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdNext.Location = New System.Drawing.Point(120, 254)
            Me.cmdNext.Name = "cmdNext"
            Me.cmdNext.Size = New System.Drawing.Size(113, 41)
            Me.cmdNext.TabIndex = 7
            Me.cmdNext.Text = "(Ent) Next >"
            Me.cmdNext.Visible = False
            '
            'dlgUnloadBagWarning
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 294)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraPage3)
            Me.Controls.Add(Me.cmdPrev)
            Me.Controls.Add(Me.cmdNext)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "dlgUnloadBagWarning"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraPage3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraPage3 As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblErr1 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblErr2 As System.Windows.Forms.Label
        Friend WithEvents cmdPrev As System.Windows.Forms.Button
        Friend WithEvents cmdNext As System.Windows.Forms.Button
    End Class
End Namespace