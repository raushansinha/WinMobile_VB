Imports System.Text
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmLoadMail
        Private _strMailType As String
        Private _strContainerSheetNumber
        'Private _blnLoadToBin As Boolean
        Private _blnManualEntry As Boolean = False

        Public Sub New(ByVal mailType As String)
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
            _strMailType = mailType
        End Sub

        Private Sub frmLoadMail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                If UIController.CurrentFunction = SafetracFunction.LoadMailIntoBinBulk Or _
                UIController.CurrentFunction = SafetracFunction.UnloadMailFromBinBulk Then
                    UIController.NextForm = New frmBinBulkInquiryForLoadMail
                    UIController.NextForm.ShowDialog()
                ElseIf UIController.CurrentFunction = SafetracFunction.LoadMailIntoContainer Or _
                UIController.CurrentFunction = SafetracFunction.UnloadMailFromContainer Then
                    UIController.NextForm = New frmMailType
                    UIController.NextForm.ShowDialog()
                End If
            End If
            If e.KeyCode = Keys.Enter Then
                txtMailBarcode.Text = txtMailBarcode.Text.ToUpper()
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If
                If MyBase.IsFooterEnabled Then
                    MyBase.ClearFooter()
                    Exit Sub
                End If
                If lblType.Text <> "FOR" Or e.KeyCode = Keys.Back Then
                    txtWeight.Text = BOConstants.DefaultMailWeight
                    ProceedWithLoad()
                Else
                    ProceedWithLoad()
                End If
            End If
        End Sub

        Private Sub frmLoadMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            MyBase.Reader.Enable()

            lblFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
            lblDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
            lblDest.Text = MyBase.FlightsCollection.CurrentFlight.Destination
            lblType.Text = _strMailType
            _blnManualEntry = False

            Select Case UIController.CurrentFunction
                Case SafetracFunction.LoadMailIntoBinBulk
                    MyBase.SetHeader("Load Mail")
                    lblBinBulk.Text = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.BinBulkNum
                    '_blnLoadToBin = True
                    SetBinBulkHeader()
                Case SafetracFunction.LoadMailIntoContainer
                    MyBase.SetHeader("Load Mail")
                    lblBinBulk.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ContainerName
                    lblBinBulkTitle.Text = "ULD"
                    '_blnLoadToBin = False
                Case SafetracFunction.UnloadMailFromBinBulk
                    MyBase.SetHeader("Unload Mail")
                    lblBinBulk.Text = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.BinBulkNum
                    '_blnLoadToBin = True
                    SetBinBulkHeader()
                Case SafetracFunction.UnloadMailFromContainer
                    MyBase.SetHeader("Unload Mail")
                    lblBinBulk.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ContainerSheetNum
                    '_blnLoadToBin = False
                    lblBinBulkTitle.Text = "ULD"
            End Select

            txtWeight.Text = String.Empty
            MyBase.Reader.Enable()
            MyBase.SetFocus(txtMailBarcode)

        End Sub

        Private Sub ProceedWithLoad()
            Dim strLog As String = String.Empty
            'Dim retCode As ReturnCodes

            If txtMailBarcode.Text.Trim = String.Empty Then
                Dim confirm As DialogResult
                Dim objdlgConfirmLoad As New dlgConfirmLoadMail
                confirm = objdlgConfirmLoad.ShowDialog
                If confirm = Windows.Forms.DialogResult.Yes Then
                    'pending - evaluate what
                Else
                    MyBase.SetFooter("ENTRY CANCELLED")
                    Exit Sub
                End If
            End If

            ' If barcode is empty, set manual mode
            If txtMailBarcode.Text.Trim = String.Empty Then
                _blnManualEntry = True

                ' Verify PIECE COUNT if manual mode
                If IsNumeric(txtPieces.Text) Then
                    Try
                        Dim intPieces As Integer = Convert.ToInt16(txtPieces.Text)
                    Catch ex As Exception
                        Logger.LogException(ex)
                        MyBase.SetError(DisplayMessages.InvalidPieceCount)
                        MyBase.SetFocus(txtPieces)
                        Exit Sub
                    End Try
                Else
                    Logger.LogMessage("invalid peice count", LogType.Trace, "frmLoadMail.ProceedWithLoad")
                    MyBase.SetError("USE NUM FOR PCS")
                    MyBase.SetFocus(txtPieces)
                    Exit Sub
                End If

                ' Verify WEIGHT, Watch out for "K" for kilograms, though
                If Not Validate.IsMailWeightValid(txtWeight.Text) Then
                    Logger.LogMessage("InvalidWeight", LogType.Trace, "frmLoadMail.ProceedWithLoad")
                    MyBase.SetError(DisplayMessages.InvalidWeight)
                    MyBase.SetFocus(txtWeight)
                    Exit Sub
                End If

                ' Verfiy FNL if something is entered
                If Len(txtFNL.Text) > 0 Then
                    If (Not IsAlpha(txtFNL.Text)) Or Len(txtFNL.Text) <> 3 Then
                        Logger.LogMessage("INVALID CITY CODE", LogType.Trace, "frmLoadMail.ProceedWithLoad")
                        MyBase.SetError("INVALID CITY CODE")
                        MyBase.SetFocus(txtFNL)
                        Exit Sub
                    End If
                End If
                'with manual indicator
                Me.ProceedForLoad()
            Else
                'user has scanned a mail barcode
                Dim strMailNum As String = txtMailBarcode.Text.Trim
                txtMailBarcode.Text = strMailNum
                Dim mailRet As MailReturnCodes
                ' Verify the barcode format entered

                Logger.LogMessage("Before checking IsMailValid strMailNum=" & strMailNum, LogType.Information, "frmLoadMail.ProceedWithLoad")
                mailRet = Validate.IsMailValid(strMailNum)
                Logger.LogMessage("After checking IsMailValid ReturnCode=" & mailRet.ToString(), LogType.Information, "frmLoadMail.ProceedWithLoad")

                Select Case mailRet
                    Case MailReturnCodes.MailDomesticOk
                        'Copy weight from barcode into weight field
                        txtWeight.Text = Strings.Right(strMailNum, 2)
                        ' Default piece count to 1
                        txtPieces.Text = "1"
                        ProceedForLoad()
                    Case MailReturnCodes.MailForeignOk
                        ' Extract weight
                        txtWeight.Text = GetFORWeight(strMailNum)
                        ' Auto set mail type
                        lblType.Text = "FOR"
                        txtPieces.Text = "1"
                        ProceedForLoad()
                    Case MailReturnCodes.MailEmeOk
                        ' Extract weight
                        txtWeight.Text = GetEmeryWeight(strMailNum)
                        lblType.Text = "EMERY"
                        txtPieces.Text = "1"
                        ProceedForLoad()
                    Case MailReturnCodes.MailInvalid
                        MyBase.SetError(DisplayMessages.InvalidBarcode)
                        MyBase.SetFocus(txtMailBarcode)
                    Case MailReturnCodes.MailSwitchBin, MailReturnCodes.MailSwitchBulk
                        ' ATTEMPT TO SWITCH HOLDS
                        ' If length = 10, then the location was scanned;
                        ' convert barcode to 1- or 2-digit entry
                        If txtMailBarcode.Text.Length = 10 Then
                            txtMailBarcode.Text = CStr(CInt(Strings.Right(txtMailBarcode.Text, 2)))
                        End If
                        ' Fill in the Parms
                        lblBinBulk.Text = strMailNum
                        SetBinBulkHeader()
                        Dim retCode As ReturnCodes

                        Logger.LogMessage("Before checking IsBinBulkValid strMailNum=" & strMailNum, LogType.Information, "frmLoadMail.ProceedWithLoad")
                        retCode = MyBase.FlightsCollection.CurrentFlight.IsBinBulkValid(strMailNum)
                        Logger.LogMessage("After checking IsBinBulkValid ReturnCode=" & mailRet.ToString(), LogType.Information, "frmLoadMail.ProceedWithLoad")

                        ' Check results of BIN/BULK inquiry
                        Select Case retCode
                            Case ReturnCodes.Ok
                                txtMailBarcode.Text = String.Empty
                                SetBinBulkHeader()
                                'pending - validate if we should do this - added by aditya
                                UIController.CurrentFunction = SafetracFunction.LoadBagIntoBinBulk
                                lblBinBulk.Text = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.BinBulkNum
                                MyBase.Reader.Enable()
                            Case ReturnCodes.NotOk
                                MyBase.SetError("INVALID BIN/BULK")
                                MyBase.SetFocus(txtMailBarcode)
                        End Select

                    Case MailReturnCodes.MailSwitchContainer

                        If txtMailBarcode.Text.Length = 10 Then
                            txtMailBarcode.Text = CStr(CInt(Strings.Right(txtMailBarcode.Text, 2)))
                        End If

                        ' Fill in the Parms
                        lblBinBulk.Text = txtMailBarcode.Text
                        lblBinBulkTitle.Text = "ULD"
                        If MyBase.FlightsCollection.CurrentFlight.IsContainerNumValid(txtMailBarcode.Text) Then
                            'test this condition
                            'lblBinBulk.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ContainerSheetNum
                        End If

                    Case MailReturnCodes.MailInvalidBulk
                        MyBase.SetError("INVALID BULK LOC")
                        MyBase.SetFocus(txtMailBarcode)

                    Case MailReturnCodes.MailInvalidBin
                        MyBase.SetError("INVALID BIN LOC")
                        MyBase.SetFocus(txtMailBarcode)
                End Select
            End If
        End Sub

        Private Sub ProceedForLoad()
            Dim strLog As String = String.Empty
            Try

                Dim retCode As ReturnCodes
                Dim strMailNum As String = txtMailBarcode.Text
                Dim strHold As String = lblBinBulk.Text
                Dim strType As String = lblType.Text
                Dim strDestination As String = String.Empty
                If UIController.CurrentFunction = SafetracFunction.LoadMailIntoContainer _
                 Or UIController.CurrentFunction = SafetracFunction.UnloadMailFromContainer Then
                    strDestination = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Destination
                Else
                    strDestination = lblDest.Text
                End If
                Dim strFinalDestination As String = txtFNL.Text
                Dim intPieceCount As Integer = Convert.ToInt16(txtPieces.Text)
                Dim dblWeight As Double = Convert.ToDouble(txtWeight.Text)

                strLog = String.Format("Before {0} strMailNum={1}", UIController.CurrentFunction, strMailNum)
                Logger.LogMessage(strLog, LogType.Information, "frmLoadMail.ProceedForLoad")

                Select Case UIController.CurrentFunction
                    Case SafetracFunction.LoadMailIntoBinBulk
                        retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LoadMail(strMailNum, _
                            strType, strDestination, strFinalDestination, intPieceCount, dblWeight, _blnManualEntry)
                    Case SafetracFunction.LoadMailIntoContainer
                        retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.LoadMail(strMailNum, _
                                                    strType, strDestination, strFinalDestination, intPieceCount, dblWeight, _blnManualEntry)
                    Case SafetracFunction.UnloadMailFromBinBulk
                        retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.UnloadMail(strMailNum)

                    Case SafetracFunction.UnloadMailFromContainer
                        retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.UnloadMail(strMailNum)

                End Select

                strLog = String.Format("After  {0} ReturnCode = {0}", UIController.CurrentFunction, retCode.ToString())
                Logger.LogMessage(strLog, LogType.Information, "frmAddFlight.btnAddFlight_Click")


                Select Case retCode
                    Case ReturnCodes.Ok
                        MyBase.SetFooter("MAIL REGISTERED")
                        ' Exit to main menu if manually keyed
                        If _blnManualEntry Then
                            System.Threading.Thread.Sleep(500)
                            UIController.NextForm = New frmMainMenu()
                            UIController.NextForm.ShowDialog()
                        Else
                            MyBase.SetFocus(txtMailBarcode)
                        End If
                    Case ReturnCodes.MailOffloaded
                        MyBase.SetFooter("MAIL OFFLOADED")
                        MyBase.SetFocus(txtMailBarcode)
                    Case ReturnCodes.FlightClosed
                        MyBase.SetError("FLIGHT CLOSED")
                        MyBase.SetFocus(txtMailBarcode)
                    Case ReturnCodes.FlightDeparted
                        MyBase.SetError("FLIGHT DEPARTED")
                        MyBase.SetFocus(txtMailBarcode)
                    Case ReturnCodes.NotAuthorized
                        MyBase.SetError("NOT AUTHORIZED")
                        MyBase.SetFocus(txtMailBarcode)
                    Case ReturnCodes.DatabaseError
                        MyBase.SetError("DATABASE ERROR")
                        MyBase.SetFocus(txtMailBarcode)
                    Case ReturnCodes.ContainerClosed
                        MyBase.SetError("ULD CLOSED")
                        MyBase.SetFocus(txtMailBarcode)
                    Case ReturnCodes.MailAlreadyRegistered
                        MyBase.SetError("MAIL ALREADY REGD")
                        MyBase.SetFocus(txtMailBarcode)
                    Case ReturnCodes.ContainerNotRegistered
                        MyBase.SetError("ULD NOT REGD")
                        MyBase.SetFocus(txtMailBarcode)
                    Case ReturnCodes.FinalDestinationInvalid
                        MyBase.SetError("INVALID FNL CITY")
                        MyBase.SetFocus(txtMailBarcode)
                    Case ReturnCodes.FlightDestinationInvalid
                        MyBase.SetError("INVALID DEST CITY")
                        MyBase.SetFocus(txtMailBarcode)
                    Case ReturnCodes.ZipCodeInvalid
                        MyBase.SetError("ZIP DOES NOT EXIST")
                        MyBase.SetFocus(txtMailBarcode)
                    Case ReturnCodes.MailNotFound, ReturnCodes.NotOk
                        MyBase.SetError("MAIL NOT FOUND")
                        MyBase.SetFocus(txtMailBarcode)
                        'Case RESULT_027_NOT_ENOUGH
                        '    ShowOpError(frmFunc027, "COMM NOT LOADED", True)
                        '    frmFunc027.txtMailBarcode.SetFocus()
                        '    AfterTextFocus(frmFunc027.txtMailBarcode, True)
                        'Case RESULT_INVALID_RETURN_BY_FRONTEND
                        '    ShowOpError(frmFunc027, "FRONTEND ERROR", True)
                End Select
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Function GetEmeryWeight(ByVal barcode As String) As String
            GetEmeryWeight = Strings.Right(barcode, 2)
        End Function

        Private Sub SetBinBulkHeader()
            If MyBase.FlightsCollection.CurrentFlight.IsWideBody Then
                lblBinBulkTitle.Text = "BULK"
            Else
                lblBinBulkTitle.Text = "BIN"
            End If
        End Sub

        Private Function GetFORWeight(ByVal barcode As String) As String
            ' TASK: Extracts weight from intl (FOR) barcodes.
            ' Grab the weight out (last 4 chars, ABCD = ABC.D)
            '  and trim leading zeroes by convert to number then
            '   back to string.

            Dim strTemp As String
            strTemp = Strings.Right(barcode, 4)
            strTemp = CStr(CInt(Strings.Left(strTemp, 3))) & "." & Strings.Right(strTemp, 1)
            ' Append "K" for kilograms
            GetFORWeight = strTemp & "K"
        End Function

        Private Sub txtFNL_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFNL.GotFocus
            MyBase.SetFocus(txtFNL)
        End Sub

        Private Sub txtWeight_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWeight.GotFocus
            txtWeight.Text = BOConstants.DefaultMailWeight
            MyBase.SetFocus(txtWeight)
        End Sub

    End Class
End Namespace