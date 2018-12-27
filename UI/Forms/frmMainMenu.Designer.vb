
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmMainMenu
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
            Me.lblCode = New System.Windows.Forms.ListBox
            Me.cmdFilter = New System.Windows.Forms.Button
            Me.lstMenu = New System.Windows.Forms.ListBox
            Me.SuspendLayout()
            '
            'lblCode
            '
            Me.lblCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCode.Location = New System.Drawing.Point(0, 56)
            Me.lblCode.Name = "lblCode"
            Me.lblCode.Size = New System.Drawing.Size(50, 192)
            Me.lblCode.TabIndex = 2
            '
            'cmdFilter
            '
            Me.cmdFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdFilter.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.cmdFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdFilter.Location = New System.Drawing.Point(0, 250)
            Me.cmdFilter.Name = "cmdFilter"
            Me.cmdFilter.Size = New System.Drawing.Size(233, 33)
            Me.cmdFilter.TabIndex = 3
            Me.cmdFilter.Text = "[F] Filter Menu"
            '
            'lstMenu
            '
            Me.lstMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lstMenu.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lstMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lstMenu.Location = New System.Drawing.Point(32, 56)
            Me.lstMenu.Name = "lstMenu"
            Me.lstMenu.Size = New System.Drawing.Size(201, 192)
            Me.lstMenu.TabIndex = 1
            '
            'frmMainMenu
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.cmdFilter)
            Me.Controls.Add(Me.lstMenu)
            Me.Controls.Add(Me.lblCode)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmMainMenu"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblCode As System.Windows.Forms.ListBox
        Friend WithEvents cmdFilter As System.Windows.Forms.Button
        Friend WithEvents lstMenu As System.Windows.Forms.ListBox
    End Class
End Namespace
