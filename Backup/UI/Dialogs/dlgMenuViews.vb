Namespace NWA.Safetrac.Scanner.UI
    Public Class dlgMenuViews

        Private _filter As MenuFliter = MenuFliter.MenuAll

        Public ReadOnly Property FilterCriteria() As MenuFliter
            Get
                Return _filter
            End Get
        End Property

        Private Sub cmdViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewAll.Click
            _filter = MenuFliter.MenuAll
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub cmdViewInq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewInq.Click
            _filter = MenuFliter.MenuInquiry
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub cmdViewULD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewULD.Click
            _filter = MenuFliter.MenuUld
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub cmdViewBag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewBag.Click
            _filter = MenuFliter.MenuBag
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub dlgMenuViews_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If
        End Sub
    End Class

    Public Enum MenuFliter
        MenuAll = 0
        MenuInquiry = 1
        MenuUld = 2
        MenuBag = 3
    End Enum

End Namespace