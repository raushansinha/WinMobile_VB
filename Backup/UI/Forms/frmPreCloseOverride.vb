#Region "NORTHWEST AIRLINES COPYRIGHT"
'File Name        : frmPreCloseOverride.Vb
'Description      : It loads the details of the Users who have not done the Preclose.The User Can Overides the Status. 
'Author           : Avinash D.N
'Created Date     : 18/10/2007
'Copyright Desc   : 
'******************************************************************
' Copyright (C) 2007 NORTHWEST AIRLINES COPYRIGHT - All Rights Reserved. 
' 
' This file embodies  materials and concepts which are confidential 
' and proprietary to NORTHWEST AIRLINES COPYRIGHT, and is made available solely pursuant 
' to the terms of a written agreement with NORTHWEST AIRLINES COPYRIGHT. 
'****************************************************************** 

'Reviewed By       :
'Reviewed Date     :
'The following section would repeat for each bug / feature that needs to be fixed during post implementation / product maintenance
#Region "MODIFICATION HISTORY"
'Feature / Bug No  :  
'Modified By       :  
'Modified Date     :
'Modified Desc     : 
'Reviewed By       :  
'Reviewed Date     :
#End Region

#End Region

#Region "Namespaces"
Imports System
Imports System.Net
Imports System.Xml
Imports System.Data
Imports System.IO
Imports System.Text
Imports NWA.Safetrac.Scanner.Utils

Imports NWA.Safetrac.Scanner.BO
#End Region
Namespace NWA.Safetrac.Scanner.UI

    Public Class frmPreCloseOverride

        Dim _dsResult As DataSet
        Private _strFlightNum As String
        Private _dtFlightDate As NWADateTime

        Public Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime, ByVal dsResult As DataSet)

            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            _strFlightNum = flightNum
            _dtFlightDate = flightDate
            _dsResult = dsResult
        End Sub
        Private Sub cmdPreLDO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreLDO.Click
            Dim i As Integer
            Try

                For i = 0 To dgPreCloseDetail.VisibleRowCount - 1
                    If dgPreCloseDetail.IsSelected(i) Then
                        ' MsgBox("USER ID" & dgPreCloseDetail.Item(dgPreCloseDetail.CurrentRowIndex, 0))
                    End If
                Next
                'Pending - Call web service


                'Select Case iRet

                '    Case RESULT_LD_OK
                '        ShowFormPLU()
                '        ' Run service call right away
                Logger.LogMessage("UIController.NextForm = New frmFlightReadyToClose(_strFlightNum, _dtFlightDate)", LogType.Trace, "frmPreCloseOverride.cmdPreLDO_Click")
                UIController.NextForm = New frmFlightReadyToClose(_strFlightNum, _dtFlightDate)
                UIController.NextForm.ShowDialog()
                '
                '    Case RESULT_LD_ERR
                '        ' Message should already be displayed; e.g. SOAP error

                '    Case Else
                '        ShowError("TUXEDO ERROR", "WBPLLO Error", GetLDResult())

                'End Select

            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub


        Private Sub frmPreCloseOverride_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("**PreClose Flight**")
            MyBase.HideFooter()
            'dgPreCloseDetail.DataSource = _dsResult.Tables("PreCloseOut")
            dgPreCloseDetail.DataSource = _dsResult.Tables(1)
        End Sub


        Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Logger.LogMessage("GoToMainMenu()", LogType.Trace, "frmPreCloseOverride.cmdCancel_Click")
            MyBase.GoToMainMenu()
        End Sub

        Private Sub frmPreCloseOverride_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Me.cmdCancel_Click(Me, Nothing)
            End If
            If e.KeyCode = Keys.O Then
                Me.cmdPreLDO_Click(Me, Nothing)
            End If

        End Sub

        Private Sub frmPreCloseOverride_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            lblWRFLResponce.BackColor = Color.Black
        End Sub
    End Class
End Namespace