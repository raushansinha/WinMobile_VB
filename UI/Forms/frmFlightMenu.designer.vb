Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmFlightMenu
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
            Me.fraMenu = New OpenNETCF.Windows.Forms.GroupBox
            Me.btnModify = New System.Windows.Forms.Button
            Me.btnRemove = New System.Windows.Forms.Button
            Me.lblHeader = New System.Windows.Forms.Label
            Me.btnAdd = New System.Windows.Forms.Button
            Me.fraMenu.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraMenu
            '
            Me.fraMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraMenu.Controls.Add(Me.btnModify)
            Me.fraMenu.Controls.Add(Me.btnRemove)
            Me.fraMenu.Controls.Add(Me.lblHeader)
            Me.fraMenu.Controls.Add(Me.btnAdd)
            Me.fraMenu.Location = New System.Drawing.Point(4, 45)
            Me.fraMenu.Name = "fraMenu"
            Me.fraMenu.Size = New System.Drawing.Size(233, 233)
            '
            'btnModify
            '
            Me.btnModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnModify.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnModify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnModify.Location = New System.Drawing.Point(24, 172)
            Me.btnModify.Name = "btnModify"
            Me.btnModify.Size = New System.Drawing.Size(185, 41)
            Me.btnModify.TabIndex = 2
            Me.btnModify.Text = "[7] Modify"
            '
            'btnRemove
            '
            Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnRemove.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnRemove.Location = New System.Drawing.Point(24, 110)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Size = New System.Drawing.Size(185, 41)
            Me.btnRemove.TabIndex = 1
            Me.btnRemove.Text = "[4] Remove"
            '
            'lblHeader
            '
            Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHeader.Location = New System.Drawing.Point(0, 0)
            Me.lblHeader.Name = "lblHeader"
            Me.lblHeader.Size = New System.Drawing.Size(233, 31)
            Me.lblHeader.Text = "Flight Management"
            Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'btnAdd
            '
            Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnAdd.Location = New System.Drawing.Point(24, 48)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(185, 41)
            Me.btnAdd.TabIndex = 0
            Me.btnAdd.Text = "[1] Add"
            '
            'frmFlightMenu
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraMenu)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmFlightMenu"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraMenu.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraMenu As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents btnModify As System.Windows.Forms.Button
        Friend WithEvents btnRemove As System.Windows.Forms.Button
        Friend WithEvents lblHeader As System.Windows.Forms.Label
        Friend WithEvents btnAdd As System.Windows.Forms.Button
    End Class
End Namespace
