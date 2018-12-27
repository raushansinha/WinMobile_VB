Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgCreateNewAWB
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
            Me.fraNewAWB = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmbTypes = New System.Windows.Forms.ComboBox
            Me.lblTyp = New System.Windows.Forms.Label
            Me.lblHeader = New System.Windows.Forms.Label
            Me.txtPcs = New System.Windows.Forms.TextBox
            Me.lblPieces = New System.Windows.Forms.Label
            Me.txtWgt = New System.Windows.Forms.TextBox
            Me.lblTtl = New System.Windows.Forms.Label
            Me.lblFooter = New System.Windows.Forms.Label
            Me.fraNewAWB.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraNewAWB
            '
            Me.fraNewAWB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraNewAWB.Controls.Add(Me.cmbTypes)
            Me.fraNewAWB.Controls.Add(Me.lblTyp)
            Me.fraNewAWB.Controls.Add(Me.lblHeader)
            Me.fraNewAWB.Controls.Add(Me.txtPcs)
            Me.fraNewAWB.Controls.Add(Me.lblPieces)
            Me.fraNewAWB.Controls.Add(Me.txtWgt)
            Me.fraNewAWB.Controls.Add(Me.lblTtl)
            Me.fraNewAWB.Location = New System.Drawing.Point(4, 50)
            Me.fraNewAWB.Name = "fraNewAWB"
            Me.fraNewAWB.Size = New System.Drawing.Size(233, 153)
            '
            'cmbTypes
            '
            Me.cmbTypes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmbTypes.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmbTypes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmbTypes.Location = New System.Drawing.Point(136, 112)
            Me.cmbTypes.Name = "cmbTypes"
            Me.cmbTypes.Size = New System.Drawing.Size(81, 30)
            Me.cmbTypes.TabIndex = 2
            '
            'lblTyp
            '
            Me.lblTyp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTyp.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblTyp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTyp.Location = New System.Drawing.Point(64, 112)
            Me.lblTyp.Name = "lblTyp"
            Me.lblTyp.Size = New System.Drawing.Size(57, 25)
            Me.lblTyp.Text = "Type"
            Me.lblTyp.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblHeader
            '
            Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHeader.Location = New System.Drawing.Point(0, 0)
            Me.lblHeader.Name = "lblHeader"
            Me.lblHeader.Size = New System.Drawing.Size(233, 25)
            Me.lblHeader.Text = "New AWB Info"
            Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtPcs
            '
            Me.txtPcs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtPcs.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
            Me.txtPcs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtPcs.Location = New System.Drawing.Point(136, 32)
            Me.txtPcs.MaxLength = 3
            Me.txtPcs.Name = "txtPcs"
            Me.txtPcs.Size = New System.Drawing.Size(57, 32)
            Me.txtPcs.TabIndex = 0
            '
            'lblPieces
            '
            Me.lblPieces.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPieces.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblPieces.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblPieces.Location = New System.Drawing.Point(56, 32)
            Me.lblPieces.Name = "lblPieces"
            Me.lblPieces.Size = New System.Drawing.Size(74, 25)
            Me.lblPieces.Text = "Pieces"
            Me.lblPieces.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtWgt
            '
            Me.txtWgt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtWgt.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
            Me.txtWgt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtWgt.Location = New System.Drawing.Point(136, 72)
            Me.txtWgt.Name = "txtWgt"
            Me.txtWgt.Size = New System.Drawing.Size(73, 32)
            Me.txtWgt.TabIndex = 1
            '
            'lblTtl
            '
            Me.lblTtl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTtl.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblTtl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTtl.Location = New System.Drawing.Point(24, 72)
            Me.lblTtl.Name = "lblTtl"
            Me.lblTtl.Size = New System.Drawing.Size(121, 25)
            Me.lblTtl.Text = "Total Wgt."
            '
            'lblFooter
            '
            Me.lblFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFooter.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFooter.Location = New System.Drawing.Point(3, 206)
            Me.lblFooter.Name = "lblFooter"
            Me.lblFooter.Size = New System.Drawing.Size(240, 26)
            Me.lblFooter.Text = "Footer"
            Me.lblFooter.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dlgCreateNewAWB
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 235)
            Me.ControlBox = False
            Me.Controls.Add(Me.lblFooter)
            Me.Controls.Add(Me.fraNewAWB)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 50)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "dlgCreateNewAWB"
            Me.fraNewAWB.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraNewAWB As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmbTypes As System.Windows.Forms.ComboBox
        Friend WithEvents lblTyp As System.Windows.Forms.Label
        Friend WithEvents lblHeader As System.Windows.Forms.Label
        Friend WithEvents txtPcs As System.Windows.Forms.TextBox
        Friend WithEvents lblPieces As System.Windows.Forms.Label
        Friend WithEvents txtWgt As System.Windows.Forms.TextBox
        Friend WithEvents lblTtl As System.Windows.Forms.Label
        Private WithEvents lblFooter As System.Windows.Forms.Label
    End Class
End Namespace

