Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmLoadBagToContainer
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
            Me.fraScanTo = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblCurrentULDDest = New System.Windows.Forms.Label
            Me.lblDst = New System.Windows.Forms.Label
            Me.lblDte = New System.Windows.Forms.Label
            Me.lblFlght = New System.Windows.Forms.Label
            Me.lblULDCart = New System.Windows.Forms.Label
            Me.lblCurrentULD = New System.Windows.Forms.Label
            Me.lblCurrentULDFlt = New System.Windows.Forms.Label
            Me.lblCurrentULDFltDate = New System.Windows.Forms.Label
            Me.lblTyp = New System.Windows.Forms.Label
            Me.lblCurrentULDType = New System.Windows.Forms.Label
            Me.fraScan = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblHeader = New System.Windows.Forms.Label
            Me.txtBagtag = New System.Windows.Forms.TextBox
            Me.btnSetMode = New System.Windows.Forms.Button
            Me.Label17 = New System.Windows.Forms.Label
            Me.lblAlwaysExpCode = New System.Windows.Forms.Label
            Me.fraAlwaysExp = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblExpCode = New System.Windows.Forms.Label
            Me.lblExpTitle = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.fraScanTo.SuspendLayout()
            Me.fraScan.SuspendLayout()
            Me.fraAlwaysExp.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraScanTo
            '
            Me.fraScanTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraScanTo.Controls.Add(Me.lblCurrentULDDest)
            Me.fraScanTo.Controls.Add(Me.lblDst)
            Me.fraScanTo.Controls.Add(Me.lblDte)
            Me.fraScanTo.Controls.Add(Me.lblFlght)
            Me.fraScanTo.Controls.Add(Me.lblULDCart)
            Me.fraScanTo.Controls.Add(Me.lblCurrentULD)
            Me.fraScanTo.Controls.Add(Me.lblCurrentULDFlt)
            Me.fraScanTo.Controls.Add(Me.lblCurrentULDFltDate)
            Me.fraScanTo.Controls.Add(Me.lblTyp)
            Me.fraScanTo.Controls.Add(Me.lblCurrentULDType)
            Me.fraScanTo.Location = New System.Drawing.Point(5, 120)
            Me.fraScanTo.Name = "fraScanTo"
            Me.fraScanTo.Size = New System.Drawing.Size(161, 137)
            '
            'lblCurrentULDDest
            '
            Me.lblCurrentULDDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCurrentULDDest.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCurrentULDDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCurrentULDDest.Location = New System.Drawing.Point(88, 64)
            Me.lblCurrentULDDest.Name = "lblCurrentULDDest"
            Me.lblCurrentULDDest.Size = New System.Drawing.Size(57, 21)
            Me.lblCurrentULDDest.Text = "MSP"
            Me.lblCurrentULDDest.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDst
            '
            Me.lblDst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDst.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDst.Location = New System.Drawing.Point(88, 47)
            Me.lblDst.Name = "lblDst"
            Me.lblDst.Size = New System.Drawing.Size(57, 17)
            Me.lblDst.Text = "Dest"
            Me.lblDst.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDte
            '
            Me.lblDte.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDte.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDte.Location = New System.Drawing.Point(8, 88)
            Me.lblDte.Name = "lblDte"
            Me.lblDte.Size = New System.Drawing.Size(49, 17)
            Me.lblDte.Text = "Date"
            Me.lblDte.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlght
            '
            Me.lblFlght.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlght.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFlght.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlght.Location = New System.Drawing.Point(8, 48)
            Me.lblFlght.Name = "lblFlght"
            Me.lblFlght.Size = New System.Drawing.Size(57, 17)
            Me.lblFlght.Text = "Flight"
            Me.lblFlght.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblULDCart
            '
            Me.lblULDCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblULDCart.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblULDCart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblULDCart.Location = New System.Drawing.Point(8, 3)
            Me.lblULDCart.Name = "lblULDCart"
            Me.lblULDCart.Size = New System.Drawing.Size(137, 20)
            Me.lblULDCart.Text = "ULD/CART"
            Me.lblULDCart.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblCurrentULD
            '
            Me.lblCurrentULD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCurrentULD.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCurrentULD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCurrentULD.Location = New System.Drawing.Point(8, 24)
            Me.lblCurrentULD.Name = "lblCurrentULD"
            Me.lblCurrentULD.Size = New System.Drawing.Size(137, 22)
            Me.lblCurrentULD.Text = "AKE12345NW"
            Me.lblCurrentULD.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblCurrentULDFlt
            '
            Me.lblCurrentULDFlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCurrentULDFlt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCurrentULDFlt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCurrentULDFlt.Location = New System.Drawing.Point(1, 64)
            Me.lblCurrentULDFlt.Name = "lblCurrentULDFlt"
            Me.lblCurrentULDFlt.Size = New System.Drawing.Size(81, 21)
            Me.lblCurrentULDFlt.Text = "NW1543"
            Me.lblCurrentULDFlt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblCurrentULDFltDate
            '
            Me.lblCurrentULDFltDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCurrentULDFltDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCurrentULDFltDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCurrentULDFltDate.Location = New System.Drawing.Point(1, 104)
            Me.lblCurrentULDFltDate.Name = "lblCurrentULDFltDate"
            Me.lblCurrentULDFltDate.Size = New System.Drawing.Size(65, 22)
            Me.lblCurrentULDFltDate.Text = "20FEB"
            Me.lblCurrentULDFltDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblTyp
            '
            Me.lblTyp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTyp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblTyp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTyp.Location = New System.Drawing.Point(88, 88)
            Me.lblTyp.Name = "lblTyp"
            Me.lblTyp.Size = New System.Drawing.Size(70, 17)
            Me.lblTyp.Text = "ULD Type"
            Me.lblTyp.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblCurrentULDType
            '
            Me.lblCurrentULDType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCurrentULDType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCurrentULDType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCurrentULDType.Location = New System.Drawing.Point(80, 104)
            Me.lblCurrentULDType.Name = "lblCurrentULDType"
            Me.lblCurrentULDType.Size = New System.Drawing.Size(65, 22)
            Me.lblCurrentULDType.Text = "MIXED"
            Me.lblCurrentULDType.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraScan
            '
            Me.fraScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraScan.Controls.Add(Me.lblHeader)
            Me.fraScan.Controls.Add(Me.txtBagtag)
            Me.fraScan.Location = New System.Drawing.Point(4, 48)
            Me.fraScan.Name = "fraScan"
            Me.fraScan.Size = New System.Drawing.Size(233, 66)
            '
            'lblHeader
            '
            Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHeader.Location = New System.Drawing.Point(0, 0)
            Me.lblHeader.Name = "lblHeader"
            Me.lblHeader.Size = New System.Drawing.Size(233, 24)
            Me.lblHeader.Text = "Scan/Enter Bagtag"
            Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtBagtag
            '
            Me.txtBagtag.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtBagtag.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
            Me.txtBagtag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtBagtag.Location = New System.Drawing.Point(32, 27)
            Me.txtBagtag.MaxLength = 10
            Me.txtBagtag.Name = "txtBagtag"
            Me.txtBagtag.Size = New System.Drawing.Size(169, 32)
            Me.txtBagtag.TabIndex = 1
            '
            'btnSetMode
            '
            Me.btnSetMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnSetMode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.btnSetMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnSetMode.Location = New System.Drawing.Point(172, 200)
            Me.btnSetMode.Name = "btnSetMode"
            Me.btnSetMode.Size = New System.Drawing.Size(65, 57)
            Me.btnSetMode.TabIndex = 3
            Me.btnSetMode.Text = "SET SCAN MODE"
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label17.Location = New System.Drawing.Point(0, 0)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(73, 16)
            Me.Label17.Text = "EXP Code"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblAlwaysExpCode
            '
            Me.lblAlwaysExpCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblAlwaysExpCode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblAlwaysExpCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblAlwaysExpCode.Location = New System.Drawing.Point(-232, 120)
            Me.lblAlwaysExpCode.Name = "lblAlwaysExpCode"
            Me.lblAlwaysExpCode.Size = New System.Drawing.Size(57, 22)
            Me.lblAlwaysExpCode.Text = "G"
            Me.lblAlwaysExpCode.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraAlwaysExp
            '
            Me.fraAlwaysExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraAlwaysExp.Controls.Add(Me.lblExpCode)
            Me.fraAlwaysExp.Controls.Add(Me.lblExpTitle)
            Me.fraAlwaysExp.Controls.Add(Me.Label1)
            Me.fraAlwaysExp.Location = New System.Drawing.Point(167, 126)
            Me.fraAlwaysExp.Name = "fraAlwaysExp"
            Me.fraAlwaysExp.Size = New System.Drawing.Size(70, 40)
            '
            'lblExpCode
            '
            Me.lblExpCode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblExpCode.Location = New System.Drawing.Point(16, 16)
            Me.lblExpCode.Name = "lblExpCode"
            Me.lblExpCode.Size = New System.Drawing.Size(36, 22)
            Me.lblExpCode.Text = "Label1"
            Me.lblExpCode.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblExpTitle
            '
            Me.lblExpTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblExpTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblExpTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblExpTitle.Location = New System.Drawing.Point(0, 0)
            Me.lblExpTitle.Name = "lblExpTitle"
            Me.lblExpTitle.Size = New System.Drawing.Size(73, 16)
            Me.lblExpTitle.Text = "EXP Code"
            Me.lblExpTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(-232, 120)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(57, 22)
            Me.Label1.Text = "G"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmLoadBagToContainer
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraAlwaysExp)
            Me.Controls.Add(Me.fraScanTo)
            Me.Controls.Add(Me.fraScan)
            Me.Controls.Add(Me.btnSetMode)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmLoadBagToContainer"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraScanTo.ResumeLayout(False)
            Me.fraScan.ResumeLayout(False)
            Me.fraAlwaysExp.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraScanTo As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblCurrentULDDest As System.Windows.Forms.Label
        Friend WithEvents lblDst As System.Windows.Forms.Label
        Friend WithEvents lblDte As System.Windows.Forms.Label
        Friend WithEvents lblFlght As System.Windows.Forms.Label
        Friend WithEvents lblULDCart As System.Windows.Forms.Label
        Friend WithEvents lblCurrentULD As System.Windows.Forms.Label
        Friend WithEvents lblCurrentULDFlt As System.Windows.Forms.Label
        Friend WithEvents lblCurrentULDFltDate As System.Windows.Forms.Label
        Friend WithEvents lblTyp As System.Windows.Forms.Label
        Friend WithEvents lblCurrentULDType As System.Windows.Forms.Label
        Friend WithEvents fraScan As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblHeader As System.Windows.Forms.Label
        Friend WithEvents txtBagtag As System.Windows.Forms.TextBox
        Friend WithEvents btnSetMode As System.Windows.Forms.Button
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents lblAlwaysExpCode As System.Windows.Forms.Label
        Friend WithEvents fraAlwaysExp As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblExpCode As System.Windows.Forms.Label
        Friend WithEvents lblExpTitle As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class
End Namespace
