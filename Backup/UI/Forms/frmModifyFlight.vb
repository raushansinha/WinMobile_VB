
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI

    Public Class frmModifyFlight

        Private Sub frmModifyFlight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("MODIFY FLIGHT")
            InitializeFlightsList()
        End Sub

        Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
            Try

                Dim retCode As ReturnCodes
                Dim blnIsError As Boolean = True
                Dim footerMessage As String = String.Empty
                Dim blnEnabled As Boolean = cbEnable.Checked

                Dim nwaFlightKey As NWAFlight = MyBase.FlightsCollection.GetFlightNum(cmbFlights.SelectedValue.ToString)

                retCode = MyBase.FlightsCollection.Flights(nwaFlightKey.Number, nwaFlightKey.DepartureDate).DiablePBM(blnEnabled)

                Select Case retCode
                    Case ReturnCodes.IsHubTypeStation
                        footerMessage = "NOT AUTHORIZED"
                    Case ReturnCodes.IsInternational
                        footerMessage = "NOT AUTHORIZED"
                    Case ReturnCodes.PBMEnabled
                        footerMessage = "PBM ENABLED"
                    Case ReturnCodes.PBMDisabled
                        footerMessage = "PBM DISABLED"
                    Case ReturnCodes.NotAuthorized
                        footerMessage = "NOT AUTHORIZED"
                    Case ReturnCodes.DatabaseError
                        footerMessage = DisplayMessages.DatabaseError
                    Case ReturnCodes.Unknown
                        footerMessage = DisplayMessages.UnknownError
                    Case Else
                        footerMessage = DisplayMessages.UnknownError
                End Select

                UIController.CurrentFunction = SafetracFunction.FlightsMenu
                UIController.NextForm = New frmFlightMenu(footerMessage, blnIsError)
                UIController.NextForm.ShowDialog()

            Catch ex As Exception
                Logger.LogException(ex)
            End Try

        End Sub

        Private Sub frmModifyFlight_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                UIController.CurrentFunction = SafetracFunction.FlightsMenu
                UIController.NextForm = New frmFlightMenu()
                UIController.NextForm.ShowDialog()
            End If
        End Sub

        Private Sub InitializeFlightsList()
            Try
                Dim liFlights As List(Of String) = MyBase.FlightsCollection.GetConfiguredFlightsList
                If liFlights.Count > 1 Then
                    cmbFlights.DataSource = liFlights
                    cmbFlights.SelectedIndex = 0
                    ShowFlightStatus()
                Else
                    UIController.CurrentFunction = BO.SafetracFunction.FlightsMenu
                    UIController.NextForm = New frmFlightMenu("NO CONF FLIGHTS", True)
                    UIController.NextForm.ShowDialog()
                End If
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Public Sub ShowFlightStatus()
            Try
                Dim nwaFlightKey As NWAFlight = MyBase.FlightsCollection.GetFlightNum(cmbFlights.SelectedValue.ToString)
                cbEnable.Checked = MyBase.FlightsCollection.Flights(nwaFlightKey.Number, nwaFlightKey.DepartureDate).IsPBMDisabled
                cbEnable.Enabled = True
            Catch ex As Exception
                Logger.LogException(ex)
                cbEnable.Enabled = False
            End Try

        End Sub

        Private Sub cmbFlights_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFlights.SelectedValueChanged
            ShowFlightStatus()
        End Sub

    End Class
End Namespace
