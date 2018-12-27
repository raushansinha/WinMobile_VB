Imports NWA.Safetrac.Scanner.BO
Imports System.Data
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.Communication
Imports NWA.Safetrac.Scanner.WebReferences
Namespace NWA.Safetrac.Scanner.UI
    Public Class frmDuplicateBagsList

        Private _strBagtagNum As String
        Private _strFlightNum As String
        Private _dtDepartureDate As NWADateTime
        Private _dsWSDup As DataSet = Nothing 'dataset obtained fro Duplicate bagtags from WS call
        Private _strairlineCode As String
        Private _strCreationDateTime As String
        Private _ArrAirlineCode(3) As String
        Private _ArrCreationDateTime(3) As String

        'expose flight number , flight date of the bag tag selected as public property
        Public ReadOnly Property FlightNum() As String
            Get
                Return _strFlightNum
            End Get
        End Property

        Public ReadOnly Property FlightDate() As NWADateTime
            Get
                Return _dtDepartureDate
            End Get
        End Property

        Public ReadOnly Property AirlineCode() As String
            Get
                Return _strairlineCode
            End Get
        End Property



        Public ReadOnly Property CreationDateTime() As String
            Get
                Return _strCreationDateTime
            End Get
        End Property


        Public Sub New(ByVal bagtagNum As String)
            InitializeComponent()
            _strBagtagNum = bagtagNum
            lblDupeBagtag.Text = _strBagtagNum
        End Sub

        Public Sub New(ByVal bagtagNum As String, ByVal dsDupBagtags As DataSet)
            InitializeComponent()
            lblDupeBagtag.Text = _strBagtagNum
            _dsWSDup = dsDupBagtags
        End Sub


        Private Sub frmDuplicateBagsList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            Select Case e.KeyCode
                Case Keys.D1
                    If (pnlDupe1.Visible = True) Then
                        pnlDupe1_Click(Me, Nothing)
                    End If
                Case Keys.D2
                    If (pnlDupe2.Visible = True) Then
                        pnlDupe2_Click(Me, Nothing)
                    End If
                Case Keys.D3
                    If (pnlDupe3.Visible = True) Then
                        pnlDupe3_Click(Me, Nothing)
                    End If
                Case Keys.D4
                    If (pnlDupe4.Visible = True) Then
                        pnlDupe4_Click(Me, Nothing)
                    End If
            End Select
            Logger.LogMessage("Selected Duplicate Bagtag =" & e.KeyCode, LogType.Trace, "frmDuplicateBagsList_KeyDown")
        End Sub
        Private Sub frmViewDuplicateBagsList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("Duplicate(Bagtag)")
            Try
                Dim dsLocalDup As DataSet
                Dim intFlCol As Integer
                Dim intDtCol As Integer
                Dim IntDupCol As Integer
                Dim intPNRCol As Integer
                Dim tbBagtagDups As DataTable

                If _dsWSDup Is Nothing Then ' get dataset from Local SQLCE DB
                    dsLocalDup = Common.GetDuplicateBagtags(_strBagtagNum)
                    If Not dsLocalDup Is Nothing Then
                        tbBagtagDups = dsLocalDup.Tables(0)
                        intFlCol = 0
                        intDtCol = 2
                        IntDupCol = 3
                        intPNRCol = 4
                    End If
                Else ' dataset returned from webservice call
                    tbBagtagDups = _dsWSDup.Tables("BagTagDupOut")
                    intFlCol = 1
                    intDtCol = 3
                    IntDupCol = 11
                    intPNRCol = 10
                End If

                Try 'populate the feilds from corresponding dataset
                    Dim intRef As Integer = 0
                    Dim intRefCount As Integer = tbBagtagDups.Rows.Count
                    For intRef = 0 To intRefCount - 1
                        Select Case intRef
                            Case 0
                                lblDupeFlt1.Text = tbBagtagDups.Rows(intRef)(intFlCol) & tbBagtagDups.Rows(intRef)(intFlCol + 1)
                                lblDupeDate1.Text = tbBagtagDups.Rows(intRef)(intDtCol)
                                lblDupeDate1.Text = Convert.ToDateTime(lblDupeDate1.Text).ToString("ddMMM")
                                lblDupeName1.Text = tbBagtagDups.Rows(intRef)(IntDupCol)
                                lblDupePNR1.Text = tbBagtagDups.Rows(intRef)(intPNRCol)
                                _ArrAirlineCode(intRef) = tbBagtagDups.Rows(intRef)("OP_AL_CDE")
                                _ArrCreationDateTime(intRef) = tbBagtagDups.Rows(intRef)("CRTN_DTM")
                                pnlDupe1.Visible = True
                                pnlDupe1.Refresh()
                            Case 1
                                lblDupeFlt2.Text = tbBagtagDups.Rows(intRef)(intFlCol) & tbBagtagDups.Rows(intRef)(intFlCol + 1)
                                lblDupeDate2.Text = tbBagtagDups.Rows(intRef)(intDtCol)
                                lblDupeDate2.Text = Convert.ToDateTime(lblDupeDate1.Text).ToString("ddMMM")
                                lblDupeName2.Text = tbBagtagDups.Rows(intRef)(IntDupCol)
                                lblDupePNR2.Text = tbBagtagDups.Rows(intRef)(intPNRCol)
                                _ArrAirlineCode(intRef) = tbBagtagDups.Rows(intRef)("OP_AL_CDE")
                                _ArrCreationDateTime(intRef) = tbBagtagDups.Rows(intRef)("CRTN_DTM")
                                pnlDupe2.Visible = True
                                pnlDupe2.Refresh()
                            Case 2
                                lblDupeFlt3.Text = tbBagtagDups.Rows(intRef)(intFlCol) & tbBagtagDups.Rows(intRef)(intFlCol + 1)
                                lblDupeDate3.Text = tbBagtagDups.Rows(intRef)(intDtCol)
                                lblDupeDate3.Text = Convert.ToDateTime(lblDupeDate1.Text).ToString("ddMMM")
                                lblDupeName3.Text = tbBagtagDups.Rows(intRef)(IntDupCol)
                                lblDupePNR3.Text = tbBagtagDups.Rows(intRef)(intPNRCol)
                                _ArrAirlineCode(intRef) = tbBagtagDups.Rows(intRef)("OP_AL_CDE")
                                _ArrCreationDateTime(intRef) = tbBagtagDups.Rows(intRef)("CRTN_DTM")
                                pnlDupe3.Visible = True
                                pnlDupe3.Refresh()
                            Case 3
                                lblDupeFlt4.Text = tbBagtagDups.Rows(intRef)(intFlCol) & tbBagtagDups.Rows(intRef)(intFlCol + 1)
                                lblDupeDate4.Text = tbBagtagDups.Rows(intRef)(intDtCol)
                                lblDupeDate4.Text = Convert.ToDateTime(lblDupeDate1.Text).ToString("ddMMM")
                                lblDupeName4.Text = tbBagtagDups.Rows(intRef)(IntDupCol)
                                lblDupePNR4.Text = tbBagtagDups.Rows(intRef)(intPNRCol)
                                _ArrAirlineCode(intRef) = tbBagtagDups.Rows(intRef)("OP_AL_CDE")
                                _ArrCreationDateTime(intRef) = tbBagtagDups.Rows(intRef)("CRTN_DTM")
                                pnlDupe4.Visible = True
                                pnlDupe4.Refresh()
                        End Select
                        Logger.LogMessage("Load DuplicateBagtag" & intRef, LogType.Trace, "frmViewDuplicateBagsList_Load")
                    Next
                    pnlDupe1.TabIndex = 0
                Catch ex As Exception
                End Try
            Catch safetracExp As SafetracException
                Logger.LogException(safetracExp)
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub
        'Private Sub frmViewDuplicateBagsList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '    MyBase.SetHeader("Duplicate(Bagtag)")
        '    Try
        '        Dim ds As DataSet
        '        ds = Common.GetDuplicateBagtags(_strBagtagNum)
        '        Try
        '            Dim intRef As Integer = 0
        '            Dim intRefCount As Integer = ds.Tables(0).Rows.Count
        '            For intRef = 0 To intRefCount - 1
        '                Select Case intRef
        '                    Case 0
        '                        lblDupeFlt1.Text = ds.Tables(0).Rows(intRef)(0) & ds.Tables(0).Rows(intRef)(1)
        '                        lblDupeDate1.Text = ds.Tables(0).Rows(intRef)(2)
        '                        lblDupeDate1.Text = Convert.ToDateTime(lblDupeDate1.Text).ToString("ddMMM")
        '                        lblDupeName1.Text = ds.Tables(0).Rows(intRef)(3)
        '                        lblDupePNR1.Text = ds.Tables(0).Rows(intRef)(4)
        '                        lblDupeSelect1.Text = intRef + 1
        '                        pnlDupe1.Visible = True
        '                        pnlDupe1.Refresh()
        '                    Case 1
        '                        lblDupeFlt2.Text = ds.Tables(0).Rows(intRef)(0) & ds.Tables(0).Rows(intRef)(1)
        '                        lblDupeDate2.Text = ds.Tables(0).Rows(intRef)(2)
        '                        lblDupeDate2.Text = Convert.ToDateTime(lblDupeDate2.Text).ToString("ddMMM")
        '                        lblDupeName2.Text = ds.Tables(0).Rows(intRef)(3)
        '                        lblDupePNR2.Text = ds.Tables(0).Rows(intRef)(4)
        '                        lblDupeSelect2.Text = intRef + 1
        '                        pnlDupe2.Visible = True
        '                        pnlDupe2.Refresh()
        '                    Case 2
        '                        lblDupeFlt3.Text = ds.Tables(0).Rows(intRef)(0) & ds.Tables(0).Rows(intRef)(1)
        '                        lblDupeDate3.Text = ds.Tables(0).Rows(intRef)(2)
        '                        lblDupeDate3.Text = Convert.ToDateTime(lblDupeDate3.Text).ToString("ddMMM")
        '                        lblDupeName3.Text = ds.Tables(0).Rows(intRef)(3)
        '                        lblDupePNR3.Text = ds.Tables(0).Rows(intRef)(4)
        '                        lblDupeSelect3.Text = intRef + 1
        '                        pnlDupe3.Visible = True
        '                        pnlDupe3.Refresh()
        '                    Case 3
        '                        lblDupeFlt4.Text = ds.Tables(0).Rows(intRef)(0) & ds.Tables(0).Rows(intRef)(1)
        '                        lblDupeDate4.Text = ds.Tables(0).Rows(intRef)(2)
        '                        lblDupeDate4.Text = Convert.ToDateTime(lblDupeDate4.Text).ToString("ddMMM")
        '                        lblDupeName4.Text = ds.Tables(0).Rows(intRef)(3)
        '                        lblDupePNR4.Text = ds.Tables(0).Rows(intRef)(4)
        '                        lblDupeSelect4.Text = intRef + 1
        '                        pnlDupe4.Visible = True
        '                        pnlDupe4.Refresh()
        '                End Select
        '                Logger.LogMessage("Load DuplicateBagtag" & intRef, LogType.Trace, "frmViewDuplicateBagsList_Load")
        '            Next
        '            pnlDupe1.TabIndex = 0
        '        Catch ex As Exception
        '        End Try
        '    Catch safetracExp As SafetracException
        '        Logger.LogException(safetracExp)
        '    Catch ex As Exception
        '        Logger.LogException(ex)
        '    End Try
        'End Sub

        Private Sub pnlDupe1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlDupe1.Click
            _strBagtagNum = lblDupeBagtag.Text
            _strFlightNum = lblDupeFlt1.Text
            _dtDepartureDate = New NWADateTime(lblDupeDate1.Text)
            _strairlineCode = _ArrAirlineCode(0)
            _strCreationDateTime = _ArrCreationDateTime(0)
            Logger.LogMessage("Selected DuplicateBagtag FlightNum = " & _strFlightNum & ",Date = " & _dtDepartureDate.ToString, LogType.Trace, "frmDuplicateBagsList.pnlDupe1_Click")
            Me.Close()
        End Sub

        Private Sub pnlDupe2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlDupe2.Click
            _strBagtagNum = lblDupeBagtag.Text
            _strFlightNum = lblDupeFlt2.Text
            _dtDepartureDate = New NWADateTime(lblDupeDate2.Text)
            _strairlineCode = _ArrAirlineCode(1)
            _strCreationDateTime = _ArrCreationDateTime(1)
            Logger.LogMessage("Selected DuplicateBagtag FlightNum = " & _strFlightNum & ",Date = " & _dtDepartureDate.ToString, LogType.Trace, "frmDuplicateBagsList.pnlDupe1_Click")
            Me.Close()
        End Sub

        Private Sub pnlDupe3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlDupe3.Click
            _strBagtagNum = lblDupeBagtag.Text
            _strFlightNum = lblDupeFlt3.Text
            _dtDepartureDate = New NWADateTime(lblDupeDate3.Text)
            _strairlineCode = _ArrAirlineCode(2)
            _strCreationDateTime = _ArrCreationDateTime(2)
            Logger.LogMessage("Selected DuplicateBagtag FlightNum = " & _strFlightNum & ",Date = " & _dtDepartureDate.ToString, LogType.Trace, "frmDuplicateBagsList.pnlDupe1_Click")
            Me.Close()
        End Sub

        Private Sub pnlDupe4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlDupe4.Click
            _strBagtagNum = lblDupeBagtag.Text
            _strFlightNum = lblDupeFlt4.Text
            _dtDepartureDate = New NWADateTime(lblDupeDate4.Text)
            _strairlineCode = _ArrAirlineCode(3)
            _strCreationDateTime = _ArrCreationDateTime(3)
            Logger.LogMessage("Selected DuplicateBagtag FlightNum = " & _strFlightNum & ",Date = " & _dtDepartureDate.ToString, LogType.Trace, "frmDuplicateBagsList.pnlDupe1_Click")
            Me.Close()
        End Sub

    End Class
End Namespace
