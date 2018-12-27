
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmCreateContainerSheetNum
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
            Me.fraULDInfo = New OpenNETCF.Windows.Forms.GroupBox
            Me.fraHubCont = New OpenNETCF.Windows.Forms.GroupBox
            Me.txtHubDest = New System.Windows.Forms.TextBox
            Me.txtHubDate = New System.Windows.Forms.TextBox
            Me.txtHubFlight = New System.Windows.Forms.TextBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.lbl1 = New System.Windows.Forms.Label
            Me.lbl2 = New System.Windows.Forms.Label
            Me.lbl4 = New System.Windows.Forms.Label
            Me.txtFlight = New System.Windows.Forms.TextBox
            Me.txtDate = New System.Windows.Forms.TextBox
            Me.cmbContType = New System.Windows.Forms.ComboBox
            Me.lblContType = New System.Windows.Forms.Label
            Me.lbl3 = New System.Windows.Forms.Label
            Me.txtDest = New System.Windows.Forms.TextBox
            Me.fraNewSheetNum = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblNewContSheetNum = New System.Windows.Forms.Label
            Me.lblSheetNum = New System.Windows.Forms.Label
            Me.cmdCreate = New System.Windows.Forms.Button
            Me.fraULDInfo.SuspendLayout()
            Me.fraHubCont.SuspendLayout()
            Me.fraNewSheetNum.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraULDInfo
            '
            Me.fraULDInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraULDInfo.Controls.Add(Me.fraHubCont)
            Me.fraULDInfo.Controls.Add(Me.lbl1)
            Me.fraULDInfo.Controls.Add(Me.lbl2)
            Me.fraULDInfo.Controls.Add(Me.lbl4)
            Me.fraULDInfo.Controls.Add(Me.txtFlight)
            Me.fraULDInfo.Controls.Add(Me.txtDate)
            Me.fraULDInfo.Controls.Add(Me.cmbContType)
            Me.fraULDInfo.Controls.Add(Me.lblContType)
            Me.fraULDInfo.Controls.Add(Me.lbl3)
            Me.fraULDInfo.Controls.Add(Me.txtDest)
            Me.fraULDInfo.Location = New System.Drawing.Point(0, 56)
            Me.fraULDInfo.Name = "fraULDInfo"
            Me.fraULDInfo.Size = New System.Drawing.Size(233, 145)
            '
            'fraHubCont
            '
            Me.fraHubCont.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraHubCont.Controls.Add(Me.txtHubDest)
            Me.fraHubCont.Controls.Add(Me.txtHubDate)
            Me.fraHubCont.Controls.Add(Me.txtHubFlight)
            Me.fraHubCont.Controls.Add(Me.Label1)
            Me.fraHubCont.Controls.Add(Me.Label7)
            Me.fraHubCont.Controls.Add(Me.Label6)
            Me.fraHubCont.Location = New System.Drawing.Point(0, 146)
            Me.fraHubCont.Name = "fraHubCont"
            Me.fraHubCont.Size = New System.Drawing.Size(233, 80)
            '
            'txtHubDest
            '
            Me.txtHubDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtHubDest.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtHubDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtHubDest.Location = New System.Drawing.Point(153, 40)
            Me.txtHubDest.Name = "txtHubDest"
            Me.txtHubDest.Size = New System.Drawing.Size(73, 26)
            Me.txtHubDest.TabIndex = 0
            '
            'txtHubDate
            '
            Me.txtHubDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtHubDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtHubDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtHubDate.Location = New System.Drawing.Point(81, 40)
            Me.txtHubDate.Name = "txtHubDate"
            Me.txtHubDate.Size = New System.Drawing.Size(73, 26)
            Me.txtHubDate.TabIndex = 1
            '
            'txtHubFlight
            '
            Me.txtHubFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtHubFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtHubFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtHubFlight.Location = New System.Drawing.Point(9, 40)
            Me.txtHubFlight.Name = "txtHubFlight"
            Me.txtHubFlight.Size = New System.Drawing.Size(73, 26)
            Me.txtHubFlight.TabIndex = 2
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(9, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(73, 25)
            Me.Label1.Text = "Flight"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(153, 16)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(73, 25)
            Me.Label7.Text = "Dest"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(81, 16)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(73, 25)
            Me.Label6.Text = "Date"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lbl1
            '
            Me.lbl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl1.Location = New System.Drawing.Point(8, 16)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(57, 25)
            Me.lbl1.Text = "Flight"
            Me.lbl1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lbl2
            '
            Me.lbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl2.Location = New System.Drawing.Point(8, 48)
            Me.lbl2.Name = "lbl2"
            Me.lbl2.Size = New System.Drawing.Size(57, 25)
            Me.lbl2.Text = "Date"
            Me.lbl2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lbl4
            '
            Me.lbl4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl4.Location = New System.Drawing.Point(8, 79)
            Me.lbl4.Name = "lbl4"
            Me.lbl4.Size = New System.Drawing.Size(57, 25)
            Me.lbl4.Text = "Type"
            Me.lbl4.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtFlight
            '
            Me.txtFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtFlight.Location = New System.Drawing.Point(72, 16)
            Me.txtFlight.MaxLength = 6
            Me.txtFlight.Name = "txtFlight"
            Me.txtFlight.Size = New System.Drawing.Size(81, 26)
            Me.txtFlight.TabIndex = 0
            '
            'txtDate
            '
            Me.txtDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtDate.Location = New System.Drawing.Point(72, 48)
            Me.txtDate.MaxLength = 5
            Me.txtDate.Name = "txtDate"
            Me.txtDate.Size = New System.Drawing.Size(81, 26)
            Me.txtDate.TabIndex = 1
            '
            'cmbContType
            '
            Me.cmbContType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmbContType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmbContType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmbContType.Items.Add("AOG")
            Me.cmbContType.Items.Add("COMAIL")
            Me.cmbContType.Items.Add("FOR")
            Me.cmbContType.Items.Add("HUB")
            Me.cmbContType.Items.Add("LOCAL")
            Me.cmbContType.Items.Add("MAIL")
            Me.cmbContType.Items.Add("MIXED")
            Me.cmbContType.Items.Add("MPRIO")
            Me.cmbContType.Items.Add("EMPTY")
            Me.cmbContType.Items.Add("PRIO")
            Me.cmbContType.Items.Add("QFRT")
            Me.cmbContType.Items.Add("SORT")
            Me.cmbContType.Items.Add("TB")
            Me.cmbContType.Items.Add("THR_B")
            Me.cmbContType.Items.Add("THR_F")
            Me.cmbContType.Items.Add("THR_M")
            Me.cmbContType.Items.Add("XFRT")
            Me.cmbContType.Items.Add("XMAIL")
            Me.cmbContType.Location = New System.Drawing.Point(72, 80)
            Me.cmbContType.Name = "cmbContType"
            Me.cmbContType.Size = New System.Drawing.Size(81, 23)
            Me.cmbContType.TabIndex = 2
            '
            'lblContType
            '
            Me.lblContType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblContType.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblContType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblContType.Location = New System.Drawing.Point(152, 80)
            Me.lblContType.Name = "lblContType"
            Me.lblContType.Size = New System.Drawing.Size(73, 25)
            Me.lblContType.Text = "SORT"
            Me.lblContType.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lbl3
            '
            Me.lbl3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl3.Location = New System.Drawing.Point(8, 111)
            Me.lbl3.Name = "lbl3"
            Me.lbl3.Size = New System.Drawing.Size(57, 25)
            Me.lbl3.Text = "Dest"
            Me.lbl3.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtDest
            '
            Me.txtDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtDest.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtDest.Location = New System.Drawing.Point(72, 112)
            Me.txtDest.MaxLength = 3
            Me.txtDest.Name = "txtDest"
            Me.txtDest.Size = New System.Drawing.Size(81, 26)
            Me.txtDest.TabIndex = 3
            '
            'fraNewSheetNum
            '
            Me.fraNewSheetNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraNewSheetNum.Controls.Add(Me.lblNewContSheetNum)
            Me.fraNewSheetNum.Controls.Add(Me.lblSheetNum)
            Me.fraNewSheetNum.Location = New System.Drawing.Point(0, 199)
            Me.fraNewSheetNum.Name = "fraNewSheetNum"
            Me.fraNewSheetNum.Size = New System.Drawing.Size(233, 80)
            Me.fraNewSheetNum.Visible = False
            '
            'lblNewContSheetNum
            '
            Me.lblNewContSheetNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblNewContSheetNum.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblNewContSheetNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblNewContSheetNum.Location = New System.Drawing.Point(8, 45)
            Me.lblNewContSheetNum.Name = "lblNewContSheetNum"
            Me.lblNewContSheetNum.Size = New System.Drawing.Size(217, 25)
            Me.lblNewContSheetNum.Text = "11600MSP98344"
            Me.lblNewContSheetNum.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblSheetNum
            '
            Me.lblSheetNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblSheetNum.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Underline)
            Me.lblSheetNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSheetNum.Location = New System.Drawing.Point(8, 13)
            Me.lblSheetNum.Name = "lblSheetNum"
            Me.lblSheetNum.Size = New System.Drawing.Size(217, 25)
            Me.lblSheetNum.Text = "Sheet #"
            Me.lblSheetNum.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmdCreate
            '
            Me.cmdCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdCreate.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdCreate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdCreate.Location = New System.Drawing.Point(8, 227)
            Me.cmdCreate.Name = "cmdCreate"
            Me.cmdCreate.Size = New System.Drawing.Size(217, 41)
            Me.cmdCreate.TabIndex = 6
            Me.cmdCreate.Text = "[ENT] Create ULD/Cart"
            '
            'frmCreateContainerSheetNum
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.cmdCreate)
            Me.Controls.Add(Me.fraULDInfo)
            Me.Controls.Add(Me.fraNewSheetNum)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmCreateContainerSheetNum"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraULDInfo.ResumeLayout(False)
            Me.fraHubCont.ResumeLayout(False)
            Me.fraNewSheetNum.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraULDInfo As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents lbl2 As System.Windows.Forms.Label
        Friend WithEvents lbl4 As System.Windows.Forms.Label
        Friend WithEvents txtFlight As System.Windows.Forms.TextBox
        Friend WithEvents txtDate As System.Windows.Forms.TextBox
        Friend WithEvents cmbContType As System.Windows.Forms.ComboBox
        Friend WithEvents lblContType As System.Windows.Forms.Label
        Friend WithEvents lbl3 As System.Windows.Forms.Label
        Friend WithEvents txtDest As System.Windows.Forms.TextBox
        Friend WithEvents cmdCreate As System.Windows.Forms.Button
        Friend WithEvents fraNewSheetNum As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblSheetNum As System.Windows.Forms.Label
        Friend WithEvents lblNewContSheetNum As System.Windows.Forms.Label
        Friend WithEvents fraHubCont As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents txtHubDest As System.Windows.Forms.TextBox
        Friend WithEvents txtHubDate As System.Windows.Forms.TextBox
        Friend WithEvents txtHubFlight As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class

End Namespace