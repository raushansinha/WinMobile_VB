
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.WebReferences

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmCreateContainerSheetNum

        Private _strContainerName As String
        Private _strType As String
        Private _strDest As String

        Public ReadOnly Property Type() As String
            Get
                Return _strType
            End Get
        End Property

        Public ReadOnly Property Destination() As String
            Get
                Return _strDest
            End Get
        End Property

        Sub New(ByVal containerName As String)
            InitializeComponent()
            _strContainerName = containerName
        End Sub

        Private Sub frmCreateContainerSheetNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("ULD Sheet Creation")
            MyBase.HideControl(fraNewSheetNum)
            MyBase.ShowControl(cmdCreate)
            If Not MyBase.FlightsCollection.CurrentFlight Is Nothing Then
                txtFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                txtDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
            End If
            
            If UIController.CurrentFunction = SafetracFunction.CreateMultipleContainerSheets Then
                txtFlight.Enabled = False
                txtDate.Enabled = False
            End If
        End Sub

        Private Sub txtDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.GotFocus
            SetFocus(txtDate)
        End Sub

        Private Sub txtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
            If Len(txtDate.Text) = 0 Then
                MyBase.SetError(DisplayMessages.InvalidDepartureDate)
                txtDate.Focus()
            End If
            txtDate.Text = UCase(txtDate.Text)
        End Sub

        Private Sub txtDest_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDest.GotFocus
            If Len(txtDest.Text) = 0 Then
                MyBase.SetError(DisplayMessages.InvalidDestination)
                txtDest.Focus()
            End If
            SetFocus(txtDest)
        End Sub

        Private Sub txtDest_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDest.KeyPress
            If MyBase.IsErrorEnabled Then
                If e.KeyChar = Chr(Keys.Enter) Then
                    ClearError()
                End If
            Else
                If e.KeyChar = Chr(Keys.Enter) Then
                    cmdCreate_Click(Me, Nothing)
                End If
            End If
        End Sub

        Private Sub txtDest_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDest.LostFocus
            If Len(txtDate.Text) = 0 Then
                MyBase.SetError(DisplayMessages.InvalidDepartureDate)
                txtDate.Focus()
                Exit Sub
            End If
            txtDest.Text = UCase(txtDest.Text)
        End Sub

        Private Sub txtFlight_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFlight.GotFocus
            SetFocus(txtFlight)
        End Sub

        Private Sub txtFlight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFlight.KeyPress
            If MyBase.IsErrorEnabled = True Then
                If e.KeyChar = (Chr(Keys.Enter)) Then
                    ' Clear any errors previously displayed
                    MyBase.ClearError()
                End If
                Exit Sub
            Else
                If e.KeyChar = (Chr(Keys.Enter)) Then
                    cmdCreate_Click(Me, Nothing)
                End If
            End If
            MyBase.FormatKeysForFlight(txtFlight, AscW(e.KeyChar))
        End Sub

        Private Sub txtFlight_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFlight.LostFocus
            If Len(txtFlight.Text) = 0 Then
                MyBase.SetError(DisplayMessages.InvalidFlight)
                txtFlight.Focus()
            End If
            txtFlight.Text = UCase(txtFlight.Text)
        End Sub

        Private Sub cmbContType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbContType.KeyPress
            If MyBase.IsErrorEnabled = True Then
                If e.KeyChar = (Chr(Keys.Enter)) Then
                    MyBase.ClearError()
                End If
                Exit Sub
            Else
                If e.KeyChar = (Chr(Keys.Enter)) Then
                    cmdCreate_Click(Me, Nothing)
                End If
            End If

            If cmbContType.Text = "HUB" Then
                MyBase.ShowControl(fraHubCont)
            Else
                fraHubCont.Visible = False
                If cmbContType.Text = "SORT" Then
                    txtDest.Visible = False
                    txtDest.Enabled = False
                    Me.Refresh()
                Else
                    txtDest.Visible = True
                    txtDest.Enabled = True
                    Me.Refresh()
                End If
            End If

            lblContType.Text = cmbContType.Text
        End Sub

        Private Sub cmbContType_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbContType.TextChanged
            If cmbContType.Text = "HUB" Then
                MyBase.ShowControl(fraHubCont)
            Else
                fraHubCont.Visible = False
                If cmbContType.Text = "SORT" Then
                    txtDest.Visible = False
                    txtDest.Enabled = False
                    Me.Refresh()
                Else
                    txtDest.Visible = True
                    txtDest.Enabled = True
                    Me.Refresh()
                End If
            End If
            lblContType.Text = cmbContType.Text
        End Sub

        Private Sub cmbContType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbContType.SelectedIndexChanged
            If cmbContType.Text = "HUB" Then
                MyBase.ShowControl(fraHubCont)
            Else
                fraHubCont.Visible = False
                If cmbContType.Text = "SORT" Then
                    txtDest.Visible = False
                    txtDest.Enabled = False
                    Me.Refresh()
                Else
                    txtDest.Visible = True
                    txtDest.Enabled = True
                    Me.Refresh()
                End If
            End If
            lblContType.Text = cmbContType.Text
        End Sub

        Private Sub txtHubFlight_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHubFlight.GotFocus
            SetFocus(txtHubFlight)
        End Sub

        Private Sub txtHubFlight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHubFlight.KeyPress
            If MyBase.IsErrorEnabled = True Then
                If e.KeyChar = (Chr(Keys.Enter)) Then
                    MyBase.ClearError()
                End If
                Exit Sub
            Else
                If e.KeyChar = (Chr(Keys.Enter)) Then
                    cmdCreate_Click(Me, Nothing)
                End If
            End If
            MyBase.FormatKeysForFlight(txtFlight, AscW(e.KeyChar))
        End Sub
        Private Sub txtHubDest_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHubDest.GotFocus
            SetFocus(txtHubDest)
        End Sub

        Private Sub txtHubDest_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHubDest.KeyPress
            If MyBase.IsErrorEnabled Then
                If e.KeyChar = Chr(Keys.Enter) Then
                    ClearError()
                End If
            Else
                If e.KeyChar = Chr(Keys.Enter) Then
                    cmdCreate_Click(Me, Nothing)
                End If
            End If
        End Sub

        Private Sub txtHubDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHubDate.GotFocus
            SetFocus(txtHubDate)
        End Sub

        Private Sub txtHubDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHubDate.KeyPress
            If MyBase.IsErrorEnabled = True Then
                If e.KeyChar = (Chr(Keys.Enter)) Then
                    MyBase.ClearError()
                End If
                Exit Sub
            Else
                If e.KeyChar = (Chr(Keys.Enter)) Then
                    cmdCreate_Click(Me, Nothing)
                End If
            End If
            FormatKeysForDate(txtDate, AscW(e.KeyChar))
        End Sub

        Private Sub cmdCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreate.Click

            If Not MyBase.IsErrorEnabled Then
                MyBase.ClearError()
                Exit Sub
            End If

            Dim strFlightNum As String = String.Empty
            Dim dtFlightDate As NWADateTime
            Dim strType As String = String.Empty
            Dim strDest As String = String.Empty
            Dim strHubFlightNum As String = String.Empty
            Dim dtHubFlightDate As NWADateTime
            Dim strHubFlightDest As String = String.Empty

            strFlightNum = txtFlight.Text.ToUpper

            If Not Validate.IsNWAFlightValid(txtFlight.Text) Then
                Logger.LogMessage("InvalidFlightFormat", LogType.Warning, "frmCreateContainerSheetNum.cmdCreate_Click")
                MyBase.SetError(DisplayMessages.InvalidFlightFormat)
                SetFocus(txtFlight)
                Exit Sub
            Else
                txtFlight.Text = strFlightNum
            End If

            Try
                dtFlightDate = New NWADateTime(txtDate.Text.Trim)
                txtDate.Text = dtFlightDate.NWAFormat
            Catch safetracExp As SafetracException
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtDate)
                Exit Sub
            Catch exp As Exception
                Logger.LogException(exp)
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtDate)
                Exit Sub
            End Try

            strDest = txtDest.Text.Trim.ToUpper

            If strDest <> "" Then
                Logger.LogMessage("InvalidDestingnation", LogType.Warning, "frmCreateContainerSheetNum.cmdCreate_Click")
                MyBase.SetError(DisplayMessages.InvalidDestination)
                SetFocus(txtDest)
                Exit Sub
            End If

            strType = cmbContType.Text.Trim.ToUpper

            If strType = String.Empty Then
                MyBase.SetError(DisplayMessages.InvalidType)
                SetFocus(txtDest)
                Exit Sub
            End If

            If strType = "HUB" Then

                strHubFlightDest = txtHubDest.Text.ToUpper.Trim
                strHubFlightNum = txtHubFlight.Text.Trim.ToUpper

                If Validate.IsNWAFlightValid(txtHubFlight.Text) = False Then
                    MyBase.SetError(DisplayMessages.InvalidFlightFormat)
                    SetFocus(txtHubFlight)
                    Exit Sub
                Else
                    txtHubFlight.Text = strHubFlightNum
                End If

                Try
                    dtHubFlightDate = New NWADateTime(txtHubDate.Text.Trim)
                    txtHubDate.Text = dtHubFlightDate.NWAFormat
                Catch safetracExp As SafetracException
                    MyBase.SetError(DisplayMessages.InvalidDateFormat)
                    MyBase.SetFocus(Me.txtDate)
                    Exit Sub
                Catch exp As Exception
                    Logger.LogException(exp)
                    MyBase.SetError(DisplayMessages.InvalidDateFormat)
                    MyBase.SetFocus(Me.txtDate)
                    Exit Sub
                End Try

                If Len(Trim(txtHubDest.Text)) = 0 Then
                    MyBase.SetError(DisplayMessages.InvalidDestinationFormat)
                    SetFocus(txtHubDate)
                    Exit Sub
                End If
            End If

            If UIController.CurrentFunction = SafetracFunction.CreateMultipleContainerSheets Then
                DialogResult = Windows.Forms.DialogResult.OK
                _strType = cmbContType.Text
                _strDest = txtDest.Text
                Me.Close()
            ElseIf UIController.CurrentFunction = SafetracFunction.CreateContainerSheetNumber Then

                If MyBase.IsInNetwork(True) Then
                    Dim containerResponse As ScannerServiceResponse

                    If strType = "HUB" Then
                        containerResponse = MyBase.FlightsCollection.CurrentFlight.CreateContainerSheetNum(_strContainerName, _
                        strType, strDest)
                    Else
                        containerResponse = MyBase.FlightsCollection.CurrentFlight.CreateHubContainerSheetNum(_strContainerName, _
                                            strType, strDest, strHubFlightNum, dtHubFlightDate, strHubFlightDest)
                    End If

                    Select Case containerResponse.ReturnCode
                        Case ReturnCodes.FlightClosed

                        Case ReturnCodes.FlightDeparted

                        Case ReturnCodes.ContainerNameInvalid

                        Case ReturnCodes.DestinationInvalid

                        Case ReturnCodes.FinalDestinationInvalid

                        Case ReturnCodes.Ok
                            MyBase.SetFooter("SHEET CREATED")
                    End Select

                End If
            End If
        End Sub

        Private Sub frmCreateContainerSheetNum_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                If UIController.CurrentFunction = SafetracFunction.CreateMultipleContainerSheets Then
                    DialogResult = Windows.Forms.DialogResult.Cancel
                    Me.Close()
                Else
                    MyBase.GoToMainMenu()
                End If
            End If
        End Sub

    End Class
End Namespace