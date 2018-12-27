Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmChangeContainerDefinition
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
            Me.fraFlightInfo = New System.Windows.Forms.Panel
            Me.lblContainer = New System.Windows.Forms.Label
            Me.lblULDDate = New System.Windows.Forms.Label
            Me.lblULDFlight = New System.Windows.Forms.Label
            Me.lblFlight = New System.Windows.Forms.Label
            Me.lblDate = New System.Windows.Forms.Label
            Me.lblContainerHeader = New System.Windows.Forms.Label
            Me.fraChangeDefinition = New System.Windows.Forms.Panel
            Me.lblType = New System.Windows.Forms.Label
            Me.lblDest = New System.Windows.Forms.Label
            Me.txtDest = New System.Windows.Forms.TextBox
            Me.cmbContType = New System.Windows.Forms.ComboBox
            Me.lblUld = New System.Windows.Forms.Label
            Me.txtContainer = New System.Windows.Forms.TextBox
            Me.fraHubContainer = New OpenNETCF.Windows.Forms.GroupBox
            Me.txtHubDest = New System.Windows.Forms.TextBox
            Me.txtHubDate = New System.Windows.Forms.TextBox
            Me.txtHubFlight = New System.Windows.Forms.TextBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.fraFlightInfo.SuspendLayout()
            Me.fraChangeDefinition.SuspendLayout()
            Me.fraHubContainer.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraFlightInfo
            '
            Me.fraFlightInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraFlightInfo.Controls.Add(Me.lblContainer)
            Me.fraFlightInfo.Controls.Add(Me.lblULDDate)
            Me.fraFlightInfo.Controls.Add(Me.lblULDFlight)
            Me.fraFlightInfo.Controls.Add(Me.lblFlight)
            Me.fraFlightInfo.Controls.Add(Me.lblDate)
            Me.fraFlightInfo.Controls.Add(Me.lblContainerHeader)
            Me.fraFlightInfo.Location = New System.Drawing.Point(0, 111)
            Me.fraFlightInfo.Name = "fraFlightInfo"
            Me.fraFlightInfo.Size = New System.Drawing.Size(233, 56)
            '
            'lblContainer
            '
            Me.lblContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblContainer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblContainer.Location = New System.Drawing.Point(88, 1)
            Me.lblContainer.Name = "lblContainer"
            Me.lblContainer.Size = New System.Drawing.Size(137, 17)
            Me.lblContainer.Text = "NW8888"
            '
            'lblULDDate
            '
            Me.lblULDDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblULDDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblULDDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblULDDate.Location = New System.Drawing.Point(88, 33)
            Me.lblULDDate.Name = "lblULDDate"
            Me.lblULDDate.Size = New System.Drawing.Size(65, 17)
            Me.lblULDDate.Text = "88XXX"
            '
            'lblULDFlight
            '
            Me.lblULDFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblULDFlight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblULDFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblULDFlight.Location = New System.Drawing.Point(88, 17)
            Me.lblULDFlight.Name = "lblULDFlight"
            Me.lblULDFlight.Size = New System.Drawing.Size(73, 17)
            Me.lblULDFlight.Text = "NW8888"
            '
            'lblFlight
            '
            Me.lblFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlight.Location = New System.Drawing.Point(0, 16)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(73, 17)
            Me.lblFlight.Text = "Flight"
            Me.lblFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(0, 32)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(73, 17)
            Me.lblDate.Text = "Date"
            Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblContainerHeader
            '
            Me.lblContainerHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblContainerHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblContainerHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblContainerHeader.Location = New System.Drawing.Point(0, 0)
            Me.lblContainerHeader.Name = "lblContainerHeader"
            Me.lblContainerHeader.Size = New System.Drawing.Size(73, 17)
            Me.lblContainerHeader.Text = "Sheet"
            Me.lblContainerHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraChangeDefinition
            '
            Me.fraChangeDefinition.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraChangeDefinition.Controls.Add(Me.lblType)
            Me.fraChangeDefinition.Controls.Add(Me.lblDest)
            Me.fraChangeDefinition.Controls.Add(Me.txtDest)
            Me.fraChangeDefinition.Controls.Add(Me.cmbContType)
            Me.fraChangeDefinition.Location = New System.Drawing.Point(0, 168)
            Me.fraChangeDefinition.Name = "fraChangeDefinition"
            Me.fraChangeDefinition.Size = New System.Drawing.Size(233, 62)
            '
            'lblType
            '
            Me.lblType.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblType.Location = New System.Drawing.Point(0, 3)
            Me.lblType.Name = "lblType"
            Me.lblType.Size = New System.Drawing.Size(73, 17)
            Me.lblType.Text = "Type"
            Me.lblType.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDest
            '
            Me.lblDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDest.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDest.Location = New System.Drawing.Point(0, 35)
            Me.lblDest.Name = "lblDest"
            Me.lblDest.Size = New System.Drawing.Size(73, 17)
            Me.lblDest.Text = "Dest"
            Me.lblDest.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtDest
            '
            Me.txtDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtDest.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtDest.Location = New System.Drawing.Point(88, 32)
            Me.txtDest.MaxLength = 3
            Me.txtDest.Name = "txtDest"
            Me.txtDest.Size = New System.Drawing.Size(81, 26)
            Me.txtDest.TabIndex = 2
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
            Me.cmbContType.Location = New System.Drawing.Point(88, 0)
            Me.cmbContType.Name = "cmbContType"
            Me.cmbContType.Size = New System.Drawing.Size(81, 23)
            Me.cmbContType.TabIndex = 1
            '
            'lblUld
            '
            Me.lblUld.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblUld.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblUld.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblUld.Location = New System.Drawing.Point(0, 56)
            Me.lblUld.Name = "lblUld"
            Me.lblUld.Size = New System.Drawing.Size(233, 24)
            Me.lblUld.Text = "Enter Sheet/ULD"
            Me.lblUld.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtContainer
            '
            Me.txtContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtContainer.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtContainer.Location = New System.Drawing.Point(40, 83)
            Me.txtContainer.MaxLength = 13
            Me.txtContainer.Name = "txtContainer"
            Me.txtContainer.Size = New System.Drawing.Size(153, 26)
            Me.txtContainer.TabIndex = 0
            '
            'fraHubContainer
            '
            Me.fraHubContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraHubContainer.Controls.Add(Me.txtHubDest)
            Me.fraHubContainer.Controls.Add(Me.txtHubDate)
            Me.fraHubContainer.Controls.Add(Me.txtHubFlight)
            Me.fraHubContainer.Controls.Add(Me.Label1)
            Me.fraHubContainer.Controls.Add(Me.Label7)
            Me.fraHubContainer.Controls.Add(Me.Label6)
            Me.fraHubContainer.Location = New System.Drawing.Point(0, 233)
            Me.fraHubContainer.Name = "fraHubContainer"
            Me.fraHubContainer.Size = New System.Drawing.Size(233, 57)
            Me.fraHubContainer.Visible = False
            '
            'txtHubDest
            '
            Me.txtHubDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtHubDest.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtHubDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtHubDest.Location = New System.Drawing.Point(153, 28)
            Me.txtHubDest.MaxLength = 3
            Me.txtHubDest.Name = "txtHubDest"
            Me.txtHubDest.Size = New System.Drawing.Size(73, 26)
            Me.txtHubDest.TabIndex = 5
            '
            'txtHubDate
            '
            Me.txtHubDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtHubDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtHubDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtHubDate.Location = New System.Drawing.Point(81, 28)
            Me.txtHubDate.MaxLength = 5
            Me.txtHubDate.Name = "txtHubDate"
            Me.txtHubDate.Size = New System.Drawing.Size(73, 26)
            Me.txtHubDate.TabIndex = 4
            '
            'txtHubFlight
            '
            Me.txtHubFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtHubFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtHubFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtHubFlight.Location = New System.Drawing.Point(9, 28)
            Me.txtHubFlight.MaxLength = 6
            Me.txtHubFlight.Name = "txtHubFlight"
            Me.txtHubFlight.Size = New System.Drawing.Size(73, 26)
            Me.txtHubFlight.TabIndex = 3
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(9, 3)
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
            Me.Label7.Location = New System.Drawing.Point(153, 3)
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
            Me.Label6.Location = New System.Drawing.Point(81, 3)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(73, 25)
            Me.Label6.Text = "Date"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmChangeContainerDefinition
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraHubContainer)
            Me.Controls.Add(Me.fraFlightInfo)
            Me.Controls.Add(Me.fraChangeDefinition)
            Me.Controls.Add(Me.lblUld)
            Me.Controls.Add(Me.txtContainer)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmChangeContainerDefinition"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraFlightInfo.ResumeLayout(False)
            Me.fraChangeDefinition.ResumeLayout(False)
            Me.fraHubContainer.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraFlightInfo As System.Windows.Forms.Panel
        Friend WithEvents lblContainer As System.Windows.Forms.Label
        Friend WithEvents lblULDDate As System.Windows.Forms.Label
        Friend WithEvents lblULDFlight As System.Windows.Forms.Label
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents lblContainerHeader As System.Windows.Forms.Label
        Friend WithEvents fraChangeDefinition As System.Windows.Forms.Panel
        Friend WithEvents lblType As System.Windows.Forms.Label
        Friend WithEvents lblDest As System.Windows.Forms.Label
        Friend WithEvents txtDest As System.Windows.Forms.TextBox
        Friend WithEvents cmbContType As System.Windows.Forms.ComboBox
        Friend WithEvents lblUld As System.Windows.Forms.Label
        Friend WithEvents txtContainer As System.Windows.Forms.TextBox
        Friend WithEvents fraHubContainer As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents txtHubDest As System.Windows.Forms.TextBox
        Friend WithEvents txtHubDate As System.Windows.Forms.TextBox
        Friend WithEvents txtHubFlight As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
    End Class

End Namespace