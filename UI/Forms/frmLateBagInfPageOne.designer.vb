
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmLateBagInfPageOne
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
            Me.fraInfoP1 = New OpenNETCF.Windows.Forms.GroupBox
            Me.btnNext = New System.Windows.Forms.Button
            Me.lblInfPage1 = New System.Windows.Forms.Label
            Me.cmbComment = New System.Windows.Forms.ComboBox
            Me.lblComments = New System.Windows.Forms.Label
            Me.lblType = New System.Windows.Forms.Label
            Me.cmbType = New System.Windows.Forms.ComboBox
            Me.lblSpecWgt = New System.Windows.Forms.Label
            Me.txtWgt = New System.Windows.Forms.TextBox
            Me.fraInfoP1.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraInfoP1
            '
            Me.fraInfoP1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraInfoP1.Controls.Add(Me.btnNext)
            Me.fraInfoP1.Controls.Add(Me.lblInfPage1)
            Me.fraInfoP1.Controls.Add(Me.cmbComment)
            Me.fraInfoP1.Controls.Add(Me.lblComments)
            Me.fraInfoP1.Controls.Add(Me.lblType)
            Me.fraInfoP1.Controls.Add(Me.cmbType)
            Me.fraInfoP1.Controls.Add(Me.lblSpecWgt)
            Me.fraInfoP1.Controls.Add(Me.txtWgt)
            Me.fraInfoP1.Location = New System.Drawing.Point(0, 56)
            Me.fraInfoP1.Name = "fraInfoP1"
            Me.fraInfoP1.Size = New System.Drawing.Size(238, 218)
            '
            'btnNext
            '
            Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnNext.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnNext.Location = New System.Drawing.Point(70, 179)
            Me.btnNext.Name = "btnNext"
            Me.btnNext.Size = New System.Drawing.Size(107, 31)
            Me.btnNext.TabIndex = 3
            Me.btnNext.Text = "Next >>"
            '
            'lblInfPage1
            '
            Me.lblInfPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblInfPage1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblInfPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblInfPage1.Location = New System.Drawing.Point(0, 0)
            Me.lblInfPage1.Name = "lblInfPage1"
            Me.lblInfPage1.Size = New System.Drawing.Size(240, 25)
            Me.lblInfPage1.Text = "Enter Information (p.1)"
            Me.lblInfPage1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmbComment
            '
            Me.cmbComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmbComment.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmbComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmbComment.Location = New System.Drawing.Point(22, 139)
            Me.cmbComment.Name = "cmbComment"
            Me.cmbComment.Size = New System.Drawing.Size(193, 23)
            Me.cmbComment.TabIndex = 2
            '
            'lblComments
            '
            Me.lblComments.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblComments.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblComments.Location = New System.Drawing.Point(77, 110)
            Me.lblComments.Name = "lblComments"
            Me.lblComments.Size = New System.Drawing.Size(100, 26)
            Me.lblComments.Text = "Comment"
            '
            'lblType
            '
            Me.lblType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblType.Location = New System.Drawing.Point(6, 37)
            Me.lblType.Name = "lblType"
            Me.lblType.Size = New System.Drawing.Size(81, 25)
            Me.lblType.Text = "Type"
            Me.lblType.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cmbType
            '
            Me.cmbType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmbType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.cmbType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmbType.Location = New System.Drawing.Point(96, 37)
            Me.cmbType.Name = "cmbType"
            Me.cmbType.Size = New System.Drawing.Size(81, 27)
            Me.cmbType.TabIndex = 0
            '
            'lblSpecWgt
            '
            Me.lblSpecWgt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblSpecWgt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblSpecWgt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSpecWgt.Location = New System.Drawing.Point(6, 72)
            Me.lblSpecWgt.Name = "lblSpecWgt"
            Me.lblSpecWgt.Size = New System.Drawing.Size(84, 26)
            Me.lblSpecWgt.Text = "Spec Wgt"
            Me.lblSpecWgt.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtWgt
            '
            Me.txtWgt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtWgt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.txtWgt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtWgt.Location = New System.Drawing.Point(96, 72)
            Me.txtWgt.Name = "txtWgt"
            Me.txtWgt.ReadOnly = True
            Me.txtWgt.Size = New System.Drawing.Size(81, 26)
            Me.txtWgt.TabIndex = 1
            '
            'frmLateBagInfPageOne
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraInfoP1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmLateBagInfPageOne"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraInfoP1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraInfoP1 As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents btnNext As System.Windows.Forms.Button
        Friend WithEvents lblInfPage1 As System.Windows.Forms.Label
        Friend WithEvents cmbComment As System.Windows.Forms.ComboBox
        Friend WithEvents lblComments As System.Windows.Forms.Label
        Friend WithEvents lblType As System.Windows.Forms.Label
        Friend WithEvents cmbType As System.Windows.Forms.ComboBox
        Friend WithEvents lblSpecWgt As System.Windows.Forms.Label
        Friend WithEvents txtWgt As System.Windows.Forms.TextBox
    End Class
End Namespace