
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmPositionContainer
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
            Me.fraPosition = New OpenNETCF.Windows.Forms.GroupBox
            Me.txtPosition = New System.Windows.Forms.TextBox
            Me.fraContainerInfo = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblDest1 = New System.Windows.Forms.Label
            Me.lblContainerTitle = New System.Windows.Forms.Label
            Me.lblULDType1 = New System.Windows.Forms.Label
            Me.lblULDDate1 = New System.Windows.Forms.Label
            Me.lblULDFlight1 = New System.Windows.Forms.Label
            Me.lblULDFlight = New System.Windows.Forms.Label
            Me.lblULDDate = New System.Windows.Forms.Label
            Me.lblULDType = New System.Windows.Forms.Label
            Me.lblContainer = New System.Windows.Forms.Label
            Me.lblDest = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.txtContainer = New System.Windows.Forms.TextBox
            Me.lblPosition = New System.Windows.Forms.Label
            Me.lblContainerInfo = New System.Windows.Forms.Label
            Me.fraWeight = New OpenNETCF.Windows.Forms.GroupBox
            Me.txtWeight = New System.Windows.Forms.TextBox
            Me.lblWeight = New System.Windows.Forms.Label
            Me.lblWeightUnit = New System.Windows.Forms.Label
            Me.lblPositionEmpty = New System.Windows.Forms.Label
            Me.fraPosition.SuspendLayout()
            Me.fraContainerInfo.SuspendLayout()
            Me.fraWeight.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraPosition
            '
            Me.fraPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraPosition.Controls.Add(Me.txtPosition)
            Me.fraPosition.Location = New System.Drawing.Point(0, 7)
            Me.fraPosition.Name = "fraPosition"
            Me.fraPosition.Size = New System.Drawing.Size(233, 43)
            Me.fraPosition.Visible = False
            '
            'txtPosition
            '
            Me.txtPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtPosition.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Regular)
            Me.txtPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtPosition.Location = New System.Drawing.Point(72, 9)
            Me.txtPosition.Name = "txtPosition"
            Me.txtPosition.Size = New System.Drawing.Size(81, 27)
            Me.txtPosition.TabIndex = 0
            '
            'fraContainerInfo
            '
            Me.fraContainerInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraContainerInfo.Controls.Add(Me.lblDest1)
            Me.fraContainerInfo.Controls.Add(Me.lblContainerTitle)
            Me.fraContainerInfo.Controls.Add(Me.lblULDType1)
            Me.fraContainerInfo.Controls.Add(Me.lblULDDate1)
            Me.fraContainerInfo.Controls.Add(Me.lblULDFlight1)
            Me.fraContainerInfo.Controls.Add(Me.lblULDFlight)
            Me.fraContainerInfo.Controls.Add(Me.lblULDDate)
            Me.fraContainerInfo.Controls.Add(Me.lblULDType)
            Me.fraContainerInfo.Controls.Add(Me.lblContainer)
            Me.fraContainerInfo.Controls.Add(Me.lblDest)
            Me.fraContainerInfo.Location = New System.Drawing.Point(0, 111)
            Me.fraContainerInfo.Name = "fraContainerInfo"
            Me.fraContainerInfo.Size = New System.Drawing.Size(233, 110)
            Me.fraContainerInfo.Visible = False
            '
            'lblDest1
            '
            Me.lblDest1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDest1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDest1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDest1.Location = New System.Drawing.Point(176, 16)
            Me.lblDest1.Name = "lblDest1"
            Me.lblDest1.Size = New System.Drawing.Size(49, 17)
            Me.lblDest1.Text = "Dest"
            Me.lblDest1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblContainerTitle
            '
            Me.lblContainerTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblContainerTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblContainerTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblContainerTitle.Location = New System.Drawing.Point(8, 16)
            Me.lblContainerTitle.Name = "lblContainerTitle"
            Me.lblContainerTitle.Size = New System.Drawing.Size(169, 17)
            Me.lblContainerTitle.Text = "ULD/Sheet"
            Me.lblContainerTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblULDType1
            '
            Me.lblULDType1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblULDType1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblULDType1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblULDType1.Location = New System.Drawing.Point(144, 64)
            Me.lblULDType1.Name = "lblULDType1"
            Me.lblULDType1.Size = New System.Drawing.Size(81, 17)
            Me.lblULDType1.Text = "Type"
            Me.lblULDType1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblULDDate1
            '
            Me.lblULDDate1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblULDDate1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblULDDate1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblULDDate1.Location = New System.Drawing.Point(96, 64)
            Me.lblULDDate1.Name = "lblULDDate1"
            Me.lblULDDate1.Size = New System.Drawing.Size(49, 17)
            Me.lblULDDate1.Text = "Date"
            Me.lblULDDate1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblULDFlight1
            '
            Me.lblULDFlight1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblULDFlight1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblULDFlight1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblULDFlight1.Location = New System.Drawing.Point(8, 64)
            Me.lblULDFlight1.Name = "lblULDFlight1"
            Me.lblULDFlight1.Size = New System.Drawing.Size(89, 17)
            Me.lblULDFlight1.Text = "Flight"
            Me.lblULDFlight1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblULDFlight
            '
            Me.lblULDFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblULDFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblULDFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblULDFlight.Location = New System.Drawing.Point(8, 82)
            Me.lblULDFlight.Name = "lblULDFlight"
            Me.lblULDFlight.Size = New System.Drawing.Size(81, 22)
            Me.lblULDFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblULDDate
            '
            Me.lblULDDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblULDDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblULDDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblULDDate.Location = New System.Drawing.Point(88, 82)
            Me.lblULDDate.Name = "lblULDDate"
            Me.lblULDDate.Size = New System.Drawing.Size(57, 20)
            Me.lblULDDate.Text = " "
            Me.lblULDDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblULDType
            '
            Me.lblULDType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblULDType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblULDType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblULDType.Location = New System.Drawing.Point(152, 82)
            Me.lblULDType.Name = "lblULDType"
            Me.lblULDType.Size = New System.Drawing.Size(73, 22)
            Me.lblULDType.Text = " "
            Me.lblULDType.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblContainer
            '
            Me.lblContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblContainer.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblContainer.Location = New System.Drawing.Point(8, 37)
            Me.lblContainer.Name = "lblContainer"
            Me.lblContainer.Size = New System.Drawing.Size(161, 23)
            Me.lblContainer.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDest
            '
            Me.lblDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDest.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDest.Location = New System.Drawing.Point(176, 36)
            Me.lblDest.Name = "lblDest"
            Me.lblDest.Size = New System.Drawing.Size(49, 23)
            Me.lblDest.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(0, 53)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(233, 24)
            Me.Label2.Text = "Enter Sheet/ULD"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtContainer
            '
            Me.txtContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtContainer.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtContainer.Location = New System.Drawing.Point(40, 77)
            Me.txtContainer.Name = "txtContainer"
            Me.txtContainer.Size = New System.Drawing.Size(153, 26)
            Me.txtContainer.TabIndex = 8
            Me.txtContainer.Text = "232323232"
            '
            'lblPosition
            '
            Me.lblPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPosition.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblPosition.Location = New System.Drawing.Point(15, 224)
            Me.lblPosition.Name = "lblPosition"
            Me.lblPosition.Size = New System.Drawing.Size(81, 18)
            Me.lblPosition.Text = "Position"
            Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblContainerInfo
            '
            Me.lblContainerInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblContainerInfo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblContainerInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblContainerInfo.Location = New System.Drawing.Point(12, 105)
            Me.lblContainerInfo.Name = "lblContainerInfo"
            Me.lblContainerInfo.Size = New System.Drawing.Size(129, 16)
            Me.lblContainerInfo.Text = "Container Info"
            Me.lblContainerInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraWeight
            '
            Me.fraWeight.BackColor = System.Drawing.Color.White
            Me.fraWeight.Controls.Add(Me.fraPosition)
            Me.fraWeight.Controls.Add(Me.lblWeight)
            Me.fraWeight.Controls.Add(Me.lblWeightUnit)
            Me.fraWeight.Controls.Add(Me.txtWeight)
            Me.fraWeight.Location = New System.Drawing.Point(0, 227)
            Me.fraWeight.Name = "fraWeight"
            Me.fraWeight.Size = New System.Drawing.Size(233, 57)
            Me.fraWeight.Visible = False
            '
            'txtWeight
            '
            Me.txtWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtWeight.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.txtWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtWeight.Location = New System.Drawing.Point(104, 27)
            Me.txtWeight.Name = "txtWeight"
            Me.txtWeight.Size = New System.Drawing.Size(81, 29)
            Me.txtWeight.TabIndex = 0
            '
            'lblWeight
            '
            Me.lblWeight.BackColor = System.Drawing.Color.White
            Me.lblWeight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblWeight.ForeColor = System.Drawing.Color.Black
            Me.lblWeight.Location = New System.Drawing.Point(8, 29)
            Me.lblWeight.Name = "lblWeight"
            Me.lblWeight.Size = New System.Drawing.Size(89, 19)
            Me.lblWeight.Text = "Enter Wgt"
            Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblWeightUnit
            '
            Me.lblWeightUnit.BackColor = System.Drawing.Color.White
            Me.lblWeightUnit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblWeightUnit.ForeColor = System.Drawing.Color.Black
            Me.lblWeightUnit.Location = New System.Drawing.Point(192, 29)
            Me.lblWeightUnit.Name = "lblWeightUnit"
            Me.lblWeightUnit.Size = New System.Drawing.Size(37, 19)
            Me.lblWeightUnit.Text = "LBS"
            '
            'lblPositionEmpty
            '
            Me.lblPositionEmpty.BackColor = System.Drawing.Color.White
            Me.lblPositionEmpty.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblPositionEmpty.ForeColor = System.Drawing.Color.Black
            Me.lblPositionEmpty.Location = New System.Drawing.Point(5, 222)
            Me.lblPositionEmpty.Name = "lblPositionEmpty"
            Me.lblPositionEmpty.Size = New System.Drawing.Size(171, 18)
            Me.lblPositionEmpty.Text = "Position Empty ULD"
            Me.lblPositionEmpty.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmPositionContainer
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.lblPosition)
            Me.Controls.Add(Me.lblContainerInfo)
            Me.Controls.Add(Me.fraContainerInfo)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtContainer)
            Me.Controls.Add(Me.lblPositionEmpty)
            Me.Controls.Add(Me.fraWeight)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmPositionContainer"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraPosition.ResumeLayout(False)
            Me.fraContainerInfo.ResumeLayout(False)
            Me.fraWeight.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraPosition As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents txtPosition As System.Windows.Forms.TextBox
        Friend WithEvents fraContainerInfo As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblDest1 As System.Windows.Forms.Label
        Friend WithEvents lblContainerTitle As System.Windows.Forms.Label
        Friend WithEvents lblULDType1 As System.Windows.Forms.Label
        Friend WithEvents lblULDDate1 As System.Windows.Forms.Label
        Friend WithEvents lblULDFlight1 As System.Windows.Forms.Label
        Friend WithEvents lblULDFlight As System.Windows.Forms.Label
        Friend WithEvents lblULDDate As System.Windows.Forms.Label
        Friend WithEvents lblULDType As System.Windows.Forms.Label
        Friend WithEvents lblContainer As System.Windows.Forms.Label
        Friend WithEvents lblDest As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtContainer As System.Windows.Forms.TextBox
        Friend WithEvents lblPosition As System.Windows.Forms.Label
        Friend WithEvents lblContainerInfo As System.Windows.Forms.Label
        Friend WithEvents fraWeight As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents txtWeight As System.Windows.Forms.TextBox
        Friend WithEvents lblWeight As System.Windows.Forms.Label
        Friend WithEvents lblWeightUnit As System.Windows.Forms.Label
        Friend WithEvents lblPositionEmpty As System.Windows.Forms.Label

    End Class
End Namespace
