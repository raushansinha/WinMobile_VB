
Imports System.Data
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.WebReferences

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmCreateMultipleContainers

        Private _dsContainerList As DataSet

        Private Sub frmCreateMultipleContainerSheetNumber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                MyBase.SetHeader("ULD Sheet Creation")
                lblFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                lblDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat

                Dim containersTable As New DataTable("Contianers")
                containersTable.Columns.Add(New DataColumn("ULD NUM"))
                containersTable.Columns.Add(New DataColumn("TYPE"))
                containersTable.Columns.Add(New DataColumn("DEST"))
                containersTable.Columns.Add(New DataColumn("CSN"))
                _dsContainerList.Tables.Add(containersTable)
                dgContainerList.DataSource = _dsContainerList.Tables("Contianers")
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
            Try
                Dim result As DialogResult
                Dim strContainerName As String = String.Empty
                Dim strType As String = String.Empty
                Dim strDest As String = String.Empty

                Dim objContainerInquiry As New frmContainerInquiryTwo()
                result = objContainerInquiry.ShowDialog()

                If result = Windows.Forms.DialogResult.Cancel Then
                    Exit Sub
                End If

                strContainerName = objContainerInquiry.ContainerName

                Dim objCreateContainer As New frmCreateContainerSheetNum(strContainerName)
                result = objCreateContainer.ShowDialog()

                If result = Windows.Forms.DialogResult.Cancel Then
                    Exit Sub
                End If

                strType = objCreateContainer.Type
                strDest = objCreateContainer.Destination

                'not sure if the array size should be 3 or 4
                Dim objArry(3) As String
                'might get a null exception
                'objArry(0) = New String
                objArry(0) = strContainerName
                objArry(1) = strType
                objArry(2) = strDest
                objArry(3) = String.Empty

                _dsContainerList.Tables(0).Rows.Add(objArry)
                'check if the gris is refreshing or not
                dgContainerList.Refresh()
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
            'Select the container sheet number to remove from the safetrac database 


        End Sub

        Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

            If MyBase.IsInNetwork(True) = False Then
                Exit Sub
            End If

            If _dsContainerList.Tables(0).Rows.Count <> 0 Then
                MyBase.SetError("ENTER DETAILS")
            End If

            Dim refCount As Integer = 0

            For refCount = 0 To _dsContainerList.Tables(0).Rows.Count
                Dim strContainerName As String = String.Empty
                Dim strType As String = String.Empty
                Dim strDest As String = String.Empty

                strContainerName = _dsContainerList.Tables(0).Rows(refCount)("ULD NUM")
                strType = _dsContainerList.Tables(0).Rows(refCount)("TYPE")
                strDest = _dsContainerList.Tables(0).Rows(refCount)("DEST")

                Dim createResponse As ScannerServiceResponse

                createResponse = MyBase.FlightsCollection.CurrentFlight.CreateContainerSheetNum(strContainerName, _
                strType, strDest)

                If createResponse.IsSuccessful Then
                    _dsContainerList.Tables(0).Rows(refCount)("CSN") = ""
                Else
                    MyBase.SetError(createResponse.ReturnMessage)
                End If
            Next

            dgContainerList.Refresh()

        End Sub

        Private Sub btnRegister_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnRegister.KeyDown
            If _dsContainerList.Tables(0).Rows.Count > 0 Then
                Dim strMessage = "Are your sure to exit? All data entered will be lost"
                If MessageBox.Show(strMessage, "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    MyBase.GoToMainMenu()
                End If
            Else
                MyBase.GoToMainMenu()
            End If
        End Sub

    End Class

End Namespace