Imports OpenNETCF.Windows.Forms

Namespace NWA.Safetrac.Scanner.UI



    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgUnloadMailFrom
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
            Me.fraUnloadMenu = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmdUnloadULD = New System.Windows.Forms.Button
            Me.cmdUnloadBB = New System.Windows.Forms.Button
            Me.Label7 = New System.Windows.Forms.Label
            Me.timMailCheck = New System.Windows.Forms.Timer
            Me.fraUnloadMenu.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraUnloadMenu
            '
            Me.fraUnloadMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraUnloadMenu.Controls.Add(Me.cmdUnloadULD)
            Me.fraUnloadMenu.Controls.Add(Me.cmdUnloadBB)
            Me.fraUnloadMenu.Controls.Add(Me.Label7)
            Me.fraUnloadMenu.Location = New System.Drawing.Point(3, 3)
            Me.fraUnloadMenu.Name = "fraUnloadMenu"
            Me.fraUnloadMenu.Size = New System.Drawing.Size(233, 225)
            '
            'cmdUnloadULD
            '
            Me.cmdUnloadULD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdUnloadULD.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdUnloadULD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdUnloadULD.Location = New System.Drawing.Point(32, 144)
            Me.cmdUnloadULD.Name = "cmdUnloadULD"
            Me.cmdUnloadULD.Size = New System.Drawing.Size(169, 49)
            Me.cmdUnloadULD.TabIndex = 0
            Me.cmdUnloadULD.Text = "[3] ULD/Cart"
            '
            'cmdUnloadBB
            '
            Me.cmdUnloadBB.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdUnloadBB.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdUnloadBB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdUnloadBB.Location = New System.Drawing.Point(32, 56)
            Me.cmdUnloadBB.Name = "cmdUnloadBB"
            Me.cmdUnloadBB.Size = New System.Drawing.Size(169, 49)
            Me.cmdUnloadBB.TabIndex = 1
            Me.cmdUnloadBB.Text = "[1] Bin/Bulk"
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(0, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(233, 25)
            Me.Label7.Text = "Unload Mail from..."
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'timMailCheck
            '
            Me.timMailCheck.Interval = 1000
            '
            'dlgUnloadMailFrom
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 230)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraUnloadMenu)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 50)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "dlgUnloadMailFrom"
            Me.fraUnloadMenu.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraUnloadMenu As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmdUnloadULD As System.Windows.Forms.Button
        Friend WithEvents cmdUnloadBB As System.Windows.Forms.Button
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents timMailCheck As System.Windows.Forms.Timer
    End Class
End Namespace