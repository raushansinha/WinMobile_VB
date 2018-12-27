Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Communication
Imports NWA.Safetrac.Scanner.WebReferences
Imports System.Data


Namespace NWA.Safetrac.Scanner.UI

    Public Class frmBagtagInquiry

        Private Sub frmBagtagInquiry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("Bagtag Inquiry")
            MyBase.Reader.Enable()
            MyBase.HideControl(fraSummary)
            txtBagtag.Text = "0012064036"
            MyBase.SetFocus(txtBagtag)
        End Sub

        Public Overrides Sub OnScan(ByVal sender As Object, ByVal e As Hardware.ScanEventArgs)
            txtBagtag.Text = e.ScannedValue
            txtBagtag_KeyDown(sender, New KeyEventArgs(Keys.Enter))
        End Sub

        Private Sub txtBagtag_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBagtag.KeyDown

            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If

                Try
                    Dim strLog As String = String.Empty
                    Dim nwaFlight As NWAFlight = Nothing
                    Dim strBagtagNum As String = txtBagtag.Text.Trim

                    strLog = String.Format("Bagtag Number {0} is entered by user", strBagtagNum)
                    Logger.LogMessage(strLog, LogType.Warning, "frmBagtagInquiry.txtBagtag_KeyDown")

                    'check if bagtag is valid
                    Dim iRet As BagTagReturnCodes
                    Try
                        iRet = Validate.IsBagtagValid(strBagtagNum)
                        Logger.LogMessage(strLog, LogType.Warning, "frmBagtagInquiry.txtBagtag_KeyDown")
                        Select Case iRet
                            Case BagTagReturnCodes.BagtagValid
                                txtBagtag.Text = strBagtagNum
                                '' fix bagtag number if 0 is missing in first letter of BagTag number
                                'If Len(strBagtagNum) = 8 Then
                                '    strBagtagNum = "0" & strBagtagNum
                                '    txtBagtag.Text = strBagtagNum
                                'End If
                            Case Else
                                MyBase.SetError(DisplayMessages.InvalidBagTagFormat)
                                MyBase.SetFocus(txtBagtag)
                                strLog = String.Format("Invalid bagtag {0} entered by user", strBagtagNum)
                                Logger.LogMessage(strLog, LogType.Information, "frmBagtagInquiry.txtBagtag_KeyDown")
                                Exit Sub
                        End Select
                    Catch ex As Exception
                        Logger.LogException(ex)
                    End Try


                    If Common.IsBagtagValid(strBagtagNum) Then 'check if valid bagtag - found in sql ce database
                        If Common.IsDuplicateBagtag(strBagtagNum) Then  'show duplicates if exist
                            MyBase.SetFooter(DisplayMessages.DuplicateBagTagsFound)
                            Logger.LogMessage("DuplicateBagTagsFound", LogType.Warning, "frmBagtagInquiry.txtBagtag_KeyDown")
                            Dim objfrmDuplicateBagtags As New frmDuplicateBagsList(strBagtagNum)
                            Logger.LogMessage("objfrmDuplicateBagtags.ShowDialog()", LogType.Trace, "frmUnloadBag.txtBagtag_KeyDown")
                            objfrmDuplicateBagtags.ShowDialog() 'pop up the list showing available options of diff Passengers having same bagatag no's
                            nwaFlight.Number = objfrmDuplicateBagtags.FlightNum 'get the selected flight from popup menu
                            nwaFlight.DepartureDate = objfrmDuplicateBagtags.FlightDate  'get the selected date from popup menu
                        Else 'if no duplicates exist
                            nwaFlight = Common.GetFlightForBagTag(strBagtagNum)
                        End If
                        Try
                            If MyBase.FlightsCollection.IsFlightValid(nwaFlight.Number, nwaFlight.DepartureDate) Then
                                Dim dsReturn As DataSet
                                'pending - getbagtagsummary method should be in flight object because we
                                'have to show the inward and outward flight details, passenger details etc
                                'dsReturn = Mybase.FlightsCollection.CurrentFlight.GetBagtagSummary(strBagtagNum)
                                If Not dsReturn Is Nothing Then 'if data can be fetched in to dictionary object go to next form 
                                    Try
                                        'PENDING 
                                        Me.ShowControl(fraSummary)
                                        'populate the controls with dataset values from Dictionary onject _diReturn
                                        '      lblLocation.Text     'BIN/BULK number
                                        '      lblSeqNum.Text       'Sequence # in which the Bag was scanned
                                        '      lblBagFltId.Text     'Flight ID.
                                        '      lblBagFltItin.Text   'Destination city code of the Flight.
                                        '      lblBagFltDate.Text   'Departure Date
                                        '      lblBagFltTime.Text   'Estimated Time of Departure of Flight.
                                        '      lblBagFltGate.Text   ' Gate where the aircraft is parked and where passengers boarded.
                                        '      lblInwFltId.Text     'Inward Flight ID
                                        '      lblInwFltCity1.Text  'Inward Origin city code
                                        '      lblInwFltCity2.Text  'Inward Destination city code
                                        '      lblOnwFltId.Text     'Onward Flight ID
                                        '      lblOnwFltCity1.Text  'Onward Origin city code
                                        '      lblOnwFltCity2.Text  'Onward Destination city code
                                        '      lblPAXName.Text      'Passenger’s Last Name.

                                        'If Passenger Status = "C" Then
                                        '    lblPAXStatus.Text = "CKD IN"
                                        '    else if Passenger Status = "S" Then
                                        '    lblPAXStatus.Text = "STANDBY"
                                        'End If
                                    Catch ex As SafetracException
                                        MyBase.SetError(DisplayMessages.DatabaseError)
                                        MyBase.SetFocus(txtBagtag)
                                        Logger.LogException(ex)
                                    End Try
                                Else
                                    Me.GetSummaryForNonConfiguredFlight()
                                End If
                            End If
                        Catch ex As SafetracException
                            Logger.LogException(ex)
                        End Try
                    Else
                        'webservice call for bagtag
                        Me.GetSummaryForNonConfiguredFlight()
                    End If
                Catch safetracEx As SafetracException
                    MessageBox.Show(safetracEx.ErrorCode)
                Catch ex As Exception
                    Logger.LogException(ex)
                End Try
            Else
                FormatKeysForBagtag(txtBagtag, e.KeyCode)
            End If
        End Sub

        Private Sub GetSummaryForNonConfiguredFlight()
            Dim strLog As String
            Try
                Dim strBagtagNum As String = txtBagtag.Text

                If ConnectionManager.IsConnected Then
                    Dim ds As DataSet = Nothing
                    Dim strAirlineCode As String
                    Dim nwaFlight As NWAFlight = Nothing
                    Dim dtCreationDateTime As NWADateTime

                    Dim _objWebServicesDup As ScannerServices = ScannerServices.GetInstance
                    Dim responseDup As ScannerServiceResponse = _objWebServicesDup.GetDuplicatesBagtags(strBagtagNum)
                    If responseDup.IsSuccessful Then
                        ds = responseDup.Response
                        If ds.Tables("BagTagDupOut").Rows.Count > 1 Then 'if duplicate bags exist
                            MyBase.SetFooter(DisplayMessages.DuplicateBagTagsFound)
                            Logger.LogMessage("DuplicateBagTagsFound", LogType.Warning, "frmBagtagInquiry.txtBagtag_KeyDown")
                            Dim objfrmDuplicateBagtags As New frmDuplicateBagsList(strBagtagNum, ds)
                            objfrmDuplicateBagtags.ShowDialog() 'pop up the list showing available options of diff Passengers having same bagatag no's
                            NWAFlight.Number = objfrmDuplicateBagtags.FlightNum 'get the selected flight from popup menu
                            NWAFlight.DepartureDate = objfrmDuplicateBagtags.FlightDate  'get the selected date from popup menu
                            strAirlineCode = objfrmDuplicateBagtags.AirlineCode
                            'pending test
                            dtCreationDateTime = New NWADateTime(objfrmDuplicateBagtags.CreationDateTime)
                        Else 'if DupBagtag dataset has only one record,directly use the same record
                            nwaFlight.Number = ds.Tables("BagTagDupOut").Rows(0)("OP_AL_CDE") & ds.Tables("BagTagDupOut").Rows(0)("OP_FLT_NUM")
                            nwaFlight.DepartureDate = New NWADateTime(ds.Tables("BagTagDupOut").Rows(0).Item("FLT_SCHED_DTM").ToString)
                            strAirlineCode = ds.Tables("BagTagDupOut").Rows(0).Item("OP_AL_CDE")
                            dtCreationDateTime = New NWADateTime(ds.Tables("BagTagDupOut").Rows(0).Item("CRTN_DTM").ToString)
                        End If
                    Else
                        'test code - delete later
                        MyBase.SetFooter(DisplayMessages.InvalidBagTagFormat)
                        'MyBase.SetFooter(response.ReturnMessage)
                        MyBase.SetFocus(txtBagtag)
                        strLog = String.Format("Invalid bagtag {0} entered by user", strBagtagNum)
                        Logger.LogMessage(strLog, LogType.Information, "frmBagtagInquiry.txtBagtag_KeyDown")
                        Exit Sub
                    End If

                    Dim response As ScannerServiceResponse = _objWebServicesDup.PerformBagtagInquiry(strBagtagNum, strAirlineCode, dtCreationDateTime)
                    If response.IsSuccessful Then
                        ds = response.Response
                        'populate the controls with dataset values from Dictionary onject _diReturn
                        '      lblLocation.Text     'BIN/BULK number
                        '      lblSeqNum.Text       'Sequence # in which the Bag was scanned
                        '      lblBagFltId.Text     'Flight ID.
                        '      lblBagFltItin.Text   'Destination city code of the Flight.
                        '      lblBagFltDate.Text   'Departure Date
                        '      lblBagFltTime.Text   'Estimated Time of Departure of Flight.
                        '      lblBagFltGate.Text   ' Gate where the aircraft is parked and where passengers boarded.
                        '      lblInwFltId.Text     'Inward Flight ID
                        '      lblInwFltCity1.Text  'Inward Origin city code
                        '      lblInwFltCity2.Text  'Inward Destination city code
                        '      lblOnwFltId.Text     'Onward Flight ID
                        '      lblOnwFltCity1.Text  'Onward Origin city code
                        '      lblOnwFltCity2.Text  'Onward Destination city code
                        '      lblPAXName.Text      'Passenger’s Last Name.

                        'If Passenger Status = "C" Then
                        '    lblPAXStatus.Text = "CKD IN"
                        '    else if Passenger Status = "S" Then
                        '    lblPAXStatus.Text = "STANDBY"
                        'End If
                    Else
                        'test code - delete later
                        MyBase.SetFooter(DisplayMessages.InvalidBagTagFormat)
                        'MyBase.SetFooter(response.ReturnMessage)
                        MyBase.SetFocus(txtBagtag)
                        strLog = String.Format("Invalid bagtag {0} entered by user", strBagtagNum)
                        Logger.LogMessage(strLog, LogType.Information, "frmBagtagInquiry.txtBagtag_KeyDown")
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub frmBagtagInquiry_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            'hide footer , when there is no error
            If Not MyBase.IsErrorEnabled Then
                MyBase.HideFooter()
            End If
            If e.KeyCode = Keys.Escape Then
                Logger.LogMessage("GoToMainMenu", LogType.Trace, "frmBagtagInquiry_KeyDown")
                MyBase.GoToMainMenu()
            End If
        End Sub
    End Class
End Namespace
