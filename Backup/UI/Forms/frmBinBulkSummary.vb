
Imports System.Data
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmBinBulkSummary
        Private _strBinBulkHdr As String
        Private _strFlightNum As String
        Private _dtFlightDate As NWADateTime
        Private _strbinBulkNum As String
        Private _dsResult As DataSet = Nothing

        Public Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime, ByVal binBulkNum As String)
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
            _strFlightNum = flightNum
            _dtFlightDate = flightDate
            _strbinBulkNum = binBulkNum
        End Sub

        Public Sub New(ByVal dsResult As DataSet)
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
            _dsResult = dsResult
        End Sub

        Private Sub frmBinBulkSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("Bin/Bulk Inquiry")
            Try
                If _dsResult Is Nothing Then
                    'pending
                    'determine data set coming from webservice or from local DB depending and populate
                    lblFlight.Text = _strFlightNum
                    lblDate.Text = _dtFlightDate.NWAFormat
                    lblEst.Text = MyBase.FlightsCollection.CurrentFlight.EstimatedDepartureTime
                    lblDest.Text = MyBase.FlightsCollection.CurrentFlight.Destination
                    'pending - Final Destination city code of Items loaded on the Flight.
                    lblFinal.Text = String.Empty
                    lblGate.Text = MyBase.FlightsCollection.CurrentFlight.Gate

                    If MyBase.FlightsCollection.CurrentFlight.IsWideBody Then
                        lblBinBulkTitle.Text = "BULK"
                    Else
                        lblBinBulkTitle.Text = "BIN"
                    End If

                    If _strbinBulkNum = "ALL" Then
                        Dim objBinBulk As KeyValuePair(Of String, BinBulk)
                        Dim diBinBulks As Dictionary(Of String, BinBulk) = MyBase.FlightsCollection.CurrentFlight.BinBulks
                        For Each objBinBulk In diBinBulks
                            Select Case objBinBulk.Key
                                Case "1", "51"
                                    lblHold1.Text = objBinBulk.Key
                                    lblBags1.Text = objBinBulk.Value.BagsWeight
                                    lblMail1.Text = objBinBulk.Value.MailsWeight
                                    lblFrt1.Text = objBinBulk.Value.FreightWeight
                                Case "2", "52"
                                    lblHold2.Text = objBinBulk.Key
                                    lblBags2.Text = objBinBulk.Value.BagsWeight
                                    lblMail2.Text = objBinBulk.Value.MailsWeight
                                    lblFrt2.Text = objBinBulk.Value.FreightWeight
                                Case "3", "53"
                                    lblHold3.Text = objBinBulk.Key
                                    lblBags3.Text = objBinBulk.Value.BagsWeight
                                    lblMail3.Text = objBinBulk.Value.MailsWeight
                                    lblFrt3.Text = objBinBulk.Value.FreightWeight
                                Case "4", "54"
                                    lblHold4.Text = objBinBulk.Key
                                    lblBags4.Text = objBinBulk.Value.BagsWeight
                                    lblMail4.Text = objBinBulk.Value.MailsWeight
                                    lblFrt4.Text = objBinBulk.Value.FreightWeight
                            End Select
                        Next
                    Else
                        Dim objBinBulk As BinBulk = MyBase.FlightsCollection.CurrentFlight.BinBulks(_strbinBulkNum)
                        lblHold1.Text = objBinBulk.BinBulkNum
                        lblBags1.Text = objBinBulk.BagsWeight
                        lblMail1.Text = objBinBulk.MailsWeight
                        lblFrt1.Text = objBinBulk.FreightWeight
                    End If
                Else
                    'webservice response
                    'populate the view with webservice response

                End If
            Catch expSafetrac As SafetracException
                Logger.LogException(expSafetrac)
            Catch exp As Exception
                Logger.LogException(exp)
            End Try
        End Sub

        Private Sub frmBinBulkSummary_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                'MyBase.GoToMainMenu()
                UIController.NextForm = New frmBinBulkInquiry
                UIController.NextForm.ShowDialog()
            End If
        End Sub

    End Class
End Namespace

