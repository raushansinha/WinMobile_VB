Imports NWA.Safetrac.Scanner.Utils
Namespace NWA.Safetrac.Scanner.UI
    Public Class frmSelectReason

        Private _strSelectedReason As String

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        End Sub

        Public ReadOnly Property Reason() As String
            Get
                Return _strSelectedReason
            End Get
        End Property

        Private Sub frmSelectReason_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            lbReasons.Items.Clear()
            lbReasons.Items.Add("AF - Aircraft Capacity Full")
            lbReasons.Items.Add("AD - Aircraft Downgrade")
            lbReasons.Items.Add("AU - Aircraft Capacity-Unusable")
            lbReasons.Items.Add("TS - Time-Scheduled Ground Time")
            lbReasons.Items.Add("TL - Time-Less than Scheduled Ground")
            lbReasons.Items.Add("TR - Time-Reduced Staff")
            lbReasons.Items.Add("SN - Not At Gate-Freight not staged")
            lbReasons.Items.Add("SG - Not At Gate-Gate Change")
            lbReasons.Items.Add("SL - Late At Gate")
            lbReasons.Items.Add("CW - Cargo Weight/Size")
            lbReasons.Items.Add("CV - Cargo Compatibility Violation")
            lbReasons.Items.Add("WB - Weight/Balance-Flight ZFW Exceeded or Imbalance")
            lbReasons.Items.Add("IW - Weather")
            lbReasons.Items.Add("IX - Flight Cancelled")
            lbReasons.Items.Add("IM - Maintenance")
            lbReasons.Items.Add("EQ - Lack of Ground Equipment")
            lbReasons.SelectedIndex = 0
        End Sub

        Private Sub cmdSelectReason_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectReason.Click
            Try
                If lbReasons.SelectedIndex < 0 Then
                    MessageBox.Show("Please select a reason code.")
                    Exit Sub
                Else
                    _strSelectedReason = Trim(lbReasons.Items(0).ToString.Substring(0, 2))
                End If
                Me.Close()
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

    End Class
End Namespace