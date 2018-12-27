
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmRegisterContainer
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
            Me.lbl4 = New System.Windows.Forms.Label
            Me.mainMenu1 = New System.Windows.Forms.MainMenu
            Me.fraContainerInfo = New OpenNETCF.Windows.Forms.GroupBox
            Me.lbl3 = New System.Windows.Forms.Label
            Me.lbl5 = New System.Windows.Forms.Label
            Me.lbl6 = New System.Windows.Forms.Label
            Me.lblFlightNum = New System.Windows.Forms.Label
            Me.lblFlightDate = New System.Windows.Forms.Label
            Me.lblContainerDestination = New System.Windows.Forms.Label
            Me.lblContainerType = New System.Windows.Forms.Label
            Me.lblContainerHeader = New System.Windows.Forms.Label
            Me.lbl2 = New System.Windows.Forms.Label
            Me.txtContainerName = New System.Windows.Forms.TextBox
            Me.lblContainerNum = New System.Windows.Forms.Label
            Me.lblFrameTitle = New System.Windows.Forms.Label
            Me.btnLookup = New System.Windows.Forms.Button
            Me.fraContainerInfo.SuspendLayout()
            Me.SuspendLayout()
            '
            'lbl4
            '
            Me.lbl4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl4.Location = New System.Drawing.Point(128, 24)
            Me.lbl4.Name = "lbl4"
            Me.lbl4.Size = New System.Drawing.Size(89, 25)
            Me.lbl4.Text = "Date"
            Me.lbl4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraContainerInfo
            '
            Me.fraContainerInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraContainerInfo.Controls.Add(Me.lbl3)
            Me.fraContainerInfo.Controls.Add(Me.lbl4)
            Me.fraContainerInfo.Controls.Add(Me.lbl5)
            Me.fraContainerInfo.Controls.Add(Me.lbl6)
            Me.fraContainerInfo.Controls.Add(Me.lblFlightNum)
            Me.fraContainerInfo.Controls.Add(Me.lblFlightDate)
            Me.fraContainerInfo.Controls.Add(Me.lblContainerDestination)
            Me.fraContainerInfo.Controls.Add(Me.lblContainerType)
            Me.fraContainerInfo.Location = New System.Drawing.Point(0, 109)
            Me.fraContainerInfo.Name = "fraContainerInfo"
            Me.fraContainerInfo.Size = New System.Drawing.Size(233, 130)
            '
            'lbl3
            '
            Me.lbl3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl3.Location = New System.Drawing.Point(16, 24)
            Me.lbl3.Name = "lbl3"
            Me.lbl3.Size = New System.Drawing.Size(81, 25)
            Me.lbl3.Text = "Flight"
            Me.lbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lbl5
            '
            Me.lbl5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lbl5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl5.Location = New System.Drawing.Point(16, 72)
            Me.lbl5.Name = "lbl5"
            Me.lbl5.Size = New System.Drawing.Size(81, 25)
            Me.lbl5.Text = "Dest"
            Me.lbl5.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lbl6
            '
            Me.lbl6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl6.Location = New System.Drawing.Point(128, 72)
            Me.lbl6.Name = "lbl6"
            Me.lbl6.Size = New System.Drawing.Size(89, 25)
            Me.lbl6.Text = "Type"
            Me.lbl6.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlightNum
            '
            Me.lblFlightNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlightNum.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlightNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlightNum.Location = New System.Drawing.Point(16, 48)
            Me.lblFlightNum.Name = "lblFlightNum"
            Me.lblFlightNum.Size = New System.Drawing.Size(81, 25)
            Me.lblFlightNum.Text = "NW0044"
            Me.lblFlightNum.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlightDate
            '
            Me.lblFlightDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlightDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlightDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlightDate.Location = New System.Drawing.Point(128, 48)
            Me.lblFlightDate.Name = "lblFlightDate"
            Me.lblFlightDate.Size = New System.Drawing.Size(89, 25)
            Me.lblFlightDate.Text = "13OCT"
            Me.lblFlightDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblContainerDestination
            '
            Me.lblContainerDestination.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblContainerDestination.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblContainerDestination.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblContainerDestination.Location = New System.Drawing.Point(16, 96)
            Me.lblContainerDestination.Name = "lblContainerDestination"
            Me.lblContainerDestination.Size = New System.Drawing.Size(81, 25)
            Me.lblContainerDestination.Text = "LGW"
            Me.lblContainerDestination.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblContainerType
            '
            Me.lblContainerType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblContainerType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblContainerType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblContainerType.Location = New System.Drawing.Point(128, 96)
            Me.lblContainerType.Name = "lblContainerType"
            Me.lblContainerType.Size = New System.Drawing.Size(89, 25)
            Me.lblContainerType.Text = "MPRIO"
            Me.lblContainerType.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblContainerHeader
            '
            Me.lblContainerHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblContainerHeader.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblContainerHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblContainerHeader.Location = New System.Drawing.Point(6, 52)
            Me.lblContainerHeader.Name = "lblContainerHeader"
            Me.lblContainerHeader.Size = New System.Drawing.Size(65, 25)
            Me.lblContainerHeader.Text = "Sheet #"
            Me.lblContainerHeader.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lbl2
            '
            Me.lbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl2.Location = New System.Drawing.Point(3, 77)
            Me.lbl2.Name = "lbl2"
            Me.lbl2.Size = New System.Drawing.Size(68, 25)
            Me.lbl2.Text = "ULD"
            Me.lbl2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtContainerName
            '
            Me.txtContainerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtContainerName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtContainerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtContainerName.Location = New System.Drawing.Point(77, 76)
            Me.txtContainerName.MaxLength = 10
            Me.txtContainerName.Name = "txtContainerName"
            Me.txtContainerName.Size = New System.Drawing.Size(137, 26)
            Me.txtContainerName.TabIndex = 0
            '
            'lblContainerNum
            '
            Me.lblContainerNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblContainerNum.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblContainerNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblContainerNum.Location = New System.Drawing.Point(77, 52)
            Me.lblContainerNum.Name = "lblContainerNum"
            Me.lblContainerNum.Size = New System.Drawing.Size(148, 21)
            Me.lblContainerNum.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFrameTitle
            '
            Me.lblFrameTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lblFrameTitle.Location = New System.Drawing.Point(16, 100)
            Me.lblFrameTitle.Name = "lblFrameTitle"
            Me.lblFrameTitle.Size = New System.Drawing.Size(136, 27)
            Me.lblFrameTitle.Text = "Container Data"
            Me.lblFrameTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'btnLookup
            '
            Me.btnLookup.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnLookup.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnLookup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnLookup.Location = New System.Drawing.Point(56, 248)
            Me.btnLookup.Name = "btnLookup"
            Me.btnLookup.Size = New System.Drawing.Size(129, 33)
            Me.btnLookup.TabIndex = 7
            Me.btnLookup.Text = "[ENT] Lookup"
            '
            'frmRegisterContainer
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.btnLookup)
            Me.Controls.Add(Me.txtContainerName)
            Me.Controls.Add(Me.lblFrameTitle)
            Me.Controls.Add(Me.fraContainerInfo)
            Me.Controls.Add(Me.lblContainerHeader)
            Me.Controls.Add(Me.lbl2)
            Me.Controls.Add(Me.lblContainerNum)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmRegisterContainer"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraContainerInfo.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraContainerInfo As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lbl3 As System.Windows.Forms.Label
        Friend WithEvents lbl5 As System.Windows.Forms.Label
        Friend WithEvents lbl6 As System.Windows.Forms.Label
        Friend WithEvents lblFlightNum As System.Windows.Forms.Label
        Friend WithEvents lblFlightDate As System.Windows.Forms.Label
        Friend WithEvents lblContainerDestination As System.Windows.Forms.Label
        Friend WithEvents lblContainerType As System.Windows.Forms.Label
        Friend WithEvents lblContainerHeader As System.Windows.Forms.Label
        Friend WithEvents lbl2 As System.Windows.Forms.Label
        Friend WithEvents txtContainerName As System.Windows.Forms.TextBox
        Friend WithEvents lblContainerNum As System.Windows.Forms.Label
        Friend WithEvents lbl4 As System.Windows.Forms.Label
        Friend WithEvents lblFrameTitle As System.Windows.Forms.Label
        Friend WithEvents btnLookup As System.Windows.Forms.Button
    End Class

End Namespace