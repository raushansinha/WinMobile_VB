
Imports System.Data
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.WebReferences
Imports NWA.Safetrac.Scanner.Communication


Namespace NWA.Safetrac.Scanner.UI
    Public Class frmContainerSummary

        Private _strContainer As String = String.Empty
        Private _blnIsContainerNum As Boolean = False

        Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
            MyBase.HideControl(fraContainerSummary)
            MyBase.HideControl(lblInformation)
            MyBase.HideControl(btnCloseReopen)
            MyBase.HideControl(fraContainerStatus)
            MyBase.ShowControl(btnLookup)
        End Sub

        Sub New(ByVal ULDSheet As String, ByVal isContainerNum As Boolean)
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
            _strContainer = ULDSheet
            _blnIsContainerNum = isContainerNum
        End Sub

        Private Sub frmULDCartSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.UpdateUserActionTime()
            MyBase.SetHeader("ULD/Cart Inquiry")
            MyBase.SetFocus(txtULDSheet)
            If _strContainer IsNot String.Empty Then
                txtULDSheet_KeyDown(sender, New KeyEventArgs(Keys.Enter))
            End If
        End Sub

        Private Sub frmULDCartSummary_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

            If e.KeyCode = Keys.Control Then
                Select Case e.KeyCode
                    Case Keys.C, Keys.R, Keys.D3
                        If btnCloseReopen.Visible = True Then
                            btnCloseReopen_Click(Me, Nothing)
                        End If
                End Select
            End If

            If e.KeyCode = Keys.Escape Then
                MyBase.GoToMainMenu()
            End If

        End Sub

        Private Sub txtULDSheet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtULDSheet.KeyDown
            If e.KeyCode = Keys.Enter Then
                Me.btnLookup_Click(Me, Nothing)
                MyBase.FormatKeysForULD(txtULDSheet, e.KeyCode)
            End If
        End Sub

        Private Sub IdentifyFlightForContainer()

            Dim objFlight As New NWAFlight
            Try

                If _blnIsContainerNum = True Then
                    objFlight = Common.GetFlightForContainerNum(_strContainer)
                    If objFlight.Number IsNot Nothing Then
                        If MyBase.FlightsCollection.IsFlightValid(objFlight.Number, objFlight.DepartureDate) Then
                            If MyBase.FlightsCollection.CurrentFlight.IsContainerNumValid(_strContainer) Then
                                DisplayContainerSummary()
                            Else
                                Logger.LogMessage("InvalidULDorCartorContainerSheet", LogType.Trace, " frmContainerSummary.IdentifyFlightForContainer")
                                MyBase.SetError(DisplayMessages.InvalidUldOrCartOrContainerSheet)
                                MyBase.SetFocus(txtULDSheet)
                            End If
                        Else
                            'not configured flight - make a webservice call
                            Me.GetUnknownContainerSummary()
                        End If
                    Else
                        'not configured flight - make a webservice call
                        Me.GetUnknownContainerSummary()
                    End If
                Else
                    objFlight = Common.GetFlightForContainerName(_strContainer)
                    If objFlight.Number IsNot Nothing Then
                        If MyBase.FlightsCollection.IsFlightValid(objFlight.Number, objFlight.DepartureDate) Then
                            If MyBase.FlightsCollection.CurrentFlight.IsContainerNameValid(_strContainer) Then
                                DisplayContainerSummary()
                            Else
                                MyBase.SetError(DisplayMessages.InvalidUldOrCartOrContainerSheet)
                                MyBase.SetFocus(txtULDSheet)
                            End If
                        Else
                            'not configured flight - make a webservice call
                            Me.GetUnknownContainerSummary()
                        End If
                    Else
                        'not configured flight - make a webservice call
                        Me.GetUnknownContainerSummary()
                    End If
                End If
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Public Sub DisplayContainerSummary()
            Try
                Dim objContainer As Container = MyBase.FlightsCollection.CurrentFlight.CurrentContainer

                If _blnIsContainerNum Then
                    lblSheetOrULD1.Text = "SHEET"
                    txtULDSheet.Text = objContainer.ContainerSheetNum
                    lblSheetOrULD2.Text = "ULD"
                    lblULDCS.Text = objContainer.ContainerName
                Else
                    lblSheetOrULD1.Text = "ULD"
                    txtULDSheet.Text = objContainer.ContainerName
                    lblSheetOrULD2.Text = "SHEET"
                    lblULDCS.Text = objContainer.ContainerSheetNum
                End If

                lblFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                lblDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
                lblEDT.Text = MyBase.FlightsCollection.CurrentFlight.EstimatedDepartureTime
                lblDest.Text = objContainer.Destination
                lblPos.Text = objContainer.Position
                lblType.Text = objContainer.Type
                lblBags.Text = objContainer.BagCount
                lblMailWgt.Text = objContainer.MailsWeight
                lblFrtWgt.Text = objContainer.FreightWeight

                Me.RefereshControls(objContainer.IsClosed)
                MyBase.SetFooter("ULD LOCATED")
                MyBase.HideControl(btnLookup)
                MyBase.ShowControl(fraContainerSummary)
                MyBase.ShowControl(btnCloseReopen)
                MyBase.ShowControl(lblInformation)
                MyBase.ShowControl(fraContainerStatus)
                MyBase.SetFocus(txtULDSheet)
            Catch expSafetrac As BO.SafetracException
                Select Case expSafetrac.ErrorCode
                    Case ReturnCodes.DatabaseError
                        MyBase.SetError(DisplayMessages.DatabaseError)
                    Case ReturnCodes.ContainerNumInvalid
                        MyBase.SetError(DisplayMessages.UnknownContainerSheet)
                    Case ReturnCodes.ContainerNameInvalid
                        MyBase.SetError("UNKNOWN ULD")
                    Case ReturnCodes.ContainerNotRegistered
                        MyBase.SetError("SHEET NOT REGD")
                    Case ReturnCodes.ContainerClosed
                        MyBase.SetError(DisplayMessages.ULDinUse)
                    Case ReturnCodes.Unknown, ReturnCodes.Exception
                        MyBase.SetError(DisplayMessages.UnknownError)
                End Select
            Catch ex As Exception
                Logger.LogException(ex)
                MyBase.SetError(DisplayMessages.UnknownError)
            End Try

        End Sub

        Public Sub GetUnknownContainerSummary()
            Dim ds As DataSet
            'pending
            Try   'make webservice call for container inquiry
                If ConnectionManager.IsConnected Then
                    Dim _objWebServicesDup As ScannerServices = ScannerServices.GetInstance
                    Dim response As ScannerServiceResponse = _objWebServicesDup.GetContainerSummary(_strContainer, _blnIsContainerNum)
                    If response.IsSuccessful Then
                        ds = response.Response
                        DisplayContainerSummary()
                        'populate dataset values to UI
                        'lblFlight.Text = 
                        'lblDate.Text = 
                        'lblEDT.Text =
                        'lblDest.Text = 
                        'lblPos.Text = 
                        'lblType.Text = 
                        'lblBags.Text = 
                        'lblMailWgt.Text = 
                        'lblFrtWgt.Text = 
                    Else
                        MyBase.SetFooter(DisplayMessages.InvalidUldOrCartOrContainerSheet)
                        Logger.LogMessage(response.ReturnMessage, LogType.Exception, "frmContainerSummary.GetUnknownContainerSummary")
                        Exit Sub
                    End If
                Else
                    MyBase.SetFooter(DisplayMessages.NonConfiguredFlight)
                    Exit Sub
                End If
                'disable reopen / close button since its a non configured flight
                btnCloseReopen.Enabled = False
            Catch ex As Exception
            End Try
        End Sub


        Private Sub btnCloseReopen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCloseReopen.Click
            Dim strLog As String = String.Empty
            If MyBase.IsErrorEnabled Then
                MyBase.ClearError()
            End If

            Dim retCode As ReturnCodes
            Try
                strLog = String.Format("Before FlightsCollection.CurrentFlight.CurrentContainer.IsClosed, ULDSheet = {0}", txtULDSheet.Text, retCode.ToString())
                Logger.LogMessage(strLog, LogType.Information, "frmContainerSummary.btnCloseReopen_Click")

                If MyBase.FlightsCollection.CurrentFlight.CurrentContainer.IsClosed Then
                    'pending
                    'reopen - make webservice call
                    retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Reopen()
                Else
                    retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Close()
                End If

                strLog = String.Format("After FlightsCollection.CurrentFlight.CurrentContainer.IsClosed, ReturnCode = {0}", retCode.ToString())
                Logger.LogMessage(strLog, LogType.Information, "frmContainerSummary.btnCloseReopen_Click")

                Select Case retCode
                    Case ReturnCodes.ContainerReopened
                        Me.RefereshControls(MyBase.FlightsCollection.CurrentFlight.CurrentContainer.IsClosed)
                        MyBase.SetFooter("CONTAINER OPENED")
                    Case ReturnCodes.ContainerClosed
                        Me.RefereshControls(MyBase.FlightsCollection.CurrentFlight.CurrentContainer.IsClosed)
                        MyBase.SetFooter("CONTAINER CLOSED")
                    Case ReturnCodes.ContainerAlreadyClosed
                        MyBase.SetFooter("CONTAINER CLOSED")
                    Case ReturnCodes.ContainerAlreadyOpened
                        MyBase.SetFooter("CONTAINER OPENED")
                    Case ReturnCodes.FlightClosed
                        MyBase.SetError(DisplayMessages.FlightClosed)
                    Case ReturnCodes.FlightDeparted
                        MyBase.SetError(DisplayMessages.FlightDeparted)
                    Case ReturnCodes.NotAuthorized
                        MyBase.SetError(DisplayMessages.UserNotAuthorized)
                    Case ReturnCodes.DatabaseError
                        MyBase.SetError(DisplayMessages.DatabaseError)
                    Case ReturnCodes.Unknown, ReturnCodes.Exception
                        MyBase.SetError(DisplayMessages.UnknownError)
                End Select
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Public Sub RefereshControls(ByVal isClosed As Boolean)
            If isClosed Then
                lblContainerStatus.Text = "CLOSED"
                btnCloseReopen.Text = "[R]eopen"
            Else
                lblContainerStatus.Text = "OPEN"
                btnCloseReopen.Text = "[C]lose"
            End If
        End Sub

        Private Sub frmULDCartSummary_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
            txtULDSheet.Text = txtULDSheet.Text.ToUpper
        End Sub

        Private Sub btnLookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookup.Click

            'txtULDSheet_KeyDown(sender, e)

            If MyBase.IsErrorEnabled Then
                MyBase.ClearError()
                Exit Sub
            End If

            If Validate.IsContainerNumValid(txtULDSheet.Text) Then
                _strContainer = txtULDSheet.Text.Substring(0, 5).ToUpper
                'lblSheetOrULD1.Text = "SHEET"
                'lblSheetOrULD2.Text = "ULD"
                _blnIsContainerNum = True
                Me.IdentifyFlightForContainer()
                'if user enters ULD number
            ElseIf BO.Validate.IsULDNumFormatValid(txtULDSheet.Text) Then
                _strContainer = txtULDSheet.Text.ToUpper
                'lblSheetOrULD1.Text = "ULD"
                'lblSheetOrULD2.Text = "SHEET"
                _blnIsContainerNum = False
                Me.IdentifyFlightForContainer()
            Else
                Logger.LogMessage("Invalid Format", LogType.Trace, "frmContainerSummary.btnLookup_Click")
                MyBase.SetError(DisplayMessages.InvalidULDFormat)
                SetFocus(txtULDSheet)
            End If

            ' MyBase.FormatKeysForULD(txtULDSheet, e.KeyCode)
        End Sub

        Private Sub txtULDSheet_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtULDSheet.LostFocus
            Dim sTemp As String
            sTemp = txtULDSheet.Text
            If Validate.IsULDNumFormatValid(sTemp) Then
                txtULDSheet.Text = sTemp
            End If
        End Sub

        Private Sub txtULDSheet_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtULDSheet.GotFocus
            MyBase.SetFocus(txtULDSheet)
        End Sub
    End Class
End Namespace
