Imports OpenNETCF.Windows.Forms.GroupBox

Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgConfirmMergeContainers
        Inherits Windows.Forms.Form
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
            Me.fraConfirm = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblTitle = New System.Windows.Forms.Label
            Me.lblToContainerName = New System.Windows.Forms.Label
            Me.lblToShtTitle = New System.Windows.Forms.Label
            Me.lblToContainerNum = New System.Windows.Forms.Label
            Me.lblConfirmMeg = New System.Windows.Forms.Label
            Me.lblConfirmToDate = New System.Windows.Forms.Label
            Me.lblConfirmToFlt = New System.Windows.Forms.Label
            Me.lblConfirmToTitle = New System.Windows.Forms.Label
            Me.lblExceptTitle = New System.Windows.Forms.Label
            Me.lblFromContainerName = New System.Windows.Forms.Label
            Me.lblConfirmFromFlt = New System.Windows.Forms.Label
            Me.lblConfirmFromDate = New System.Windows.Forms.Label
            Me.lblFromContainerNum = New System.Windows.Forms.Label
            Me.lblFromShtTitle = New System.Windows.Forms.Label
            Me.fraConfirm.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraConfirm
            '
            Me.fraConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraConfirm.Controls.Add(Me.lblTitle)
            Me.fraConfirm.Controls.Add(Me.lblToContainerName)
            Me.fraConfirm.Controls.Add(Me.lblToShtTitle)
            Me.fraConfirm.Controls.Add(Me.lblToContainerNum)
            Me.fraConfirm.Controls.Add(Me.lblConfirmMeg)
            Me.fraConfirm.Controls.Add(Me.lblConfirmToDate)
            Me.fraConfirm.Controls.Add(Me.lblConfirmToFlt)
            Me.fraConfirm.Controls.Add(Me.lblConfirmToTitle)
            Me.fraConfirm.Controls.Add(Me.lblExceptTitle)
            Me.fraConfirm.Controls.Add(Me.lblFromContainerName)
            Me.fraConfirm.Controls.Add(Me.lblConfirmFromFlt)
            Me.fraConfirm.Controls.Add(Me.lblConfirmFromDate)
            Me.fraConfirm.Controls.Add(Me.lblFromContainerNum)
            Me.fraConfirm.Controls.Add(Me.lblFromShtTitle)
            Me.fraConfirm.Location = New System.Drawing.Point(0, 0)
            Me.fraConfirm.Name = "fraConfirm"
            Me.fraConfirm.Size = New System.Drawing.Size(240, 224)
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(0, 22)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(240, 25)
            Me.lblTitle.Text = "FROM"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblToContainerName
            '
            Me.lblToContainerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblToContainerName.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblToContainerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblToContainerName.Location = New System.Drawing.Point(32, 132)
            Me.lblToContainerName.Name = "lblToContainerName"
            Me.lblToContainerName.Size = New System.Drawing.Size(169, 22)
            Me.lblToContainerName.Text = "CAR12345NW"
            Me.lblToContainerName.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblToShtTitle
            '
            Me.lblToShtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblToShtTitle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblToShtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblToShtTitle.Location = New System.Drawing.Point(9, 154)
            Me.lblToShtTitle.Name = "lblToShtTitle"
            Me.lblToShtTitle.Size = New System.Drawing.Size(66, 22)
            Me.lblToShtTitle.Text = "Sht#:"
            '
            'lblToContainerNum
            '
            Me.lblToContainerNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblToContainerNum.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblToContainerNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblToContainerNum.Location = New System.Drawing.Point(64, 154)
            Me.lblToContainerNum.Name = "lblToContainerNum"
            Me.lblToContainerNum.Size = New System.Drawing.Size(166, 20)
            Me.lblToContainerNum.Text = "12345DTW12340"
            Me.lblToContainerNum.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblConfirmMeg
            '
            Me.lblConfirmMeg.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblConfirmMeg.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblConfirmMeg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblConfirmMeg.Location = New System.Drawing.Point(0, 197)
            Me.lblConfirmMeg.Name = "lblConfirmMeg"
            Me.lblConfirmMeg.Size = New System.Drawing.Size(240, 25)
            Me.lblConfirmMeg.Text = "(Y)es  (N)o  (ESC)"
            Me.lblConfirmMeg.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblConfirmToDate
            '
            Me.lblConfirmToDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblConfirmToDate.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblConfirmToDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblConfirmToDate.Location = New System.Drawing.Point(128, 175)
            Me.lblConfirmToDate.Name = "lblConfirmToDate"
            Me.lblConfirmToDate.Size = New System.Drawing.Size(89, 22)
            Me.lblConfirmToDate.Text = "20JUL"
            Me.lblConfirmToDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblConfirmToFlt
            '
            Me.lblConfirmToFlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblConfirmToFlt.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblConfirmToFlt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblConfirmToFlt.Location = New System.Drawing.Point(3, 174)
            Me.lblConfirmToFlt.Name = "lblConfirmToFlt"
            Me.lblConfirmToFlt.Size = New System.Drawing.Size(101, 23)
            Me.lblConfirmToFlt.Text = "NW1543"
            Me.lblConfirmToFlt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblConfirmToTitle
            '
            Me.lblConfirmToTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblConfirmToTitle.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblConfirmToTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblConfirmToTitle.Location = New System.Drawing.Point(0, 107)
            Me.lblConfirmToTitle.Name = "lblConfirmToTitle"
            Me.lblConfirmToTitle.Size = New System.Drawing.Size(240, 25)
            Me.lblConfirmToTitle.Text = "TO"
            Me.lblConfirmToTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblExceptTitle
            '
            Me.lblExceptTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblExceptTitle.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblExceptTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblExceptTitle.Location = New System.Drawing.Point(0, 0)
            Me.lblExceptTitle.Name = "lblExceptTitle"
            Me.lblExceptTitle.Size = New System.Drawing.Size(241, 22)
            Me.lblExceptTitle.Text = "CONFIRM MERGE"
            Me.lblExceptTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFromContainerName
            '
            Me.lblFromContainerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFromContainerName.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblFromContainerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFromContainerName.Location = New System.Drawing.Point(32, 46)
            Me.lblFromContainerName.Name = "lblFromContainerName"
            Me.lblFromContainerName.Size = New System.Drawing.Size(169, 21)
            Me.lblFromContainerName.Text = "CAR12345NW"
            Me.lblFromContainerName.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblConfirmFromFlt
            '
            Me.lblConfirmFromFlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblConfirmFromFlt.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblConfirmFromFlt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblConfirmFromFlt.Location = New System.Drawing.Point(3, 86)
            Me.lblConfirmFromFlt.Name = "lblConfirmFromFlt"
            Me.lblConfirmFromFlt.Size = New System.Drawing.Size(101, 21)
            Me.lblConfirmFromFlt.Text = "NW1543"
            Me.lblConfirmFromFlt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblConfirmFromDate
            '
            Me.lblConfirmFromDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblConfirmFromDate.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblConfirmFromDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblConfirmFromDate.Location = New System.Drawing.Point(128, 86)
            Me.lblConfirmFromDate.Name = "lblConfirmFromDate"
            Me.lblConfirmFromDate.Size = New System.Drawing.Size(89, 20)
            Me.lblConfirmFromDate.Text = "20JUL"
            Me.lblConfirmFromDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFromContainerNum
            '
            Me.lblFromContainerNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFromContainerNum.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFromContainerNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFromContainerNum.Location = New System.Drawing.Point(64, 67)
            Me.lblFromContainerNum.Name = "lblFromContainerNum"
            Me.lblFromContainerNum.Size = New System.Drawing.Size(166, 19)
            Me.lblFromContainerNum.Text = "12345DTW12340"
            Me.lblFromContainerNum.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFromShtTitle
            '
            Me.lblFromShtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFromShtTitle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFromShtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFromShtTitle.Location = New System.Drawing.Point(9, 70)
            Me.lblFromShtTitle.Name = "lblFromShtTitle"
            Me.lblFromShtTitle.Size = New System.Drawing.Size(60, 16)
            Me.lblFromShtTitle.Text = "Sht#:"
            '
            'frmMergeContainersConfirm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 225)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraConfirm)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmMergeContainersConfirm"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraConfirm.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraConfirm As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents lblToContainerName As System.Windows.Forms.Label
        Friend WithEvents lblToShtTitle As System.Windows.Forms.Label
        Friend WithEvents lblToContainerNum As System.Windows.Forms.Label
        Friend WithEvents lblConfirmToDate As System.Windows.Forms.Label
        Friend WithEvents lblConfirmToFlt As System.Windows.Forms.Label
        Friend WithEvents lblConfirmToTitle As System.Windows.Forms.Label
        Friend WithEvents lblExceptTitle As System.Windows.Forms.Label
        Friend WithEvents lblFromContainerName As System.Windows.Forms.Label
        Friend WithEvents lblConfirmFromFlt As System.Windows.Forms.Label
        Friend WithEvents lblConfirmFromDate As System.Windows.Forms.Label
        Friend WithEvents lblFromContainerNum As System.Windows.Forms.Label
        Friend WithEvents lblFromShtTitle As System.Windows.Forms.Label
        Friend WithEvents lblConfirmMeg As System.Windows.Forms.Label
    End Class
End Namespace
