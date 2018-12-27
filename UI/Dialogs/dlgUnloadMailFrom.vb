Imports NWA.Safetrac.Scanner.BO

Namespace NWA.Safetrac.Scanner.UI
    Public Class dlgUnloadMailFrom

        Private _strMessage As String = String.Empty

        Public ReadOnly Property Message() As String
            Get
                Return _strMessage
            End Get
        End Property


        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
        End Sub

        Private Sub cmdUnloadBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnloadBB.Click
            UIController.CurrentFunction = SafetracFunction.UnloadMailFromBinBulk
            Me.Close()
        End Sub

        Private Sub cmdUnloadULD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnloadULD.Click

            Dim objFlights As FlightsCollection

            objFlights = FlightsCollection.GetInstance

            If objFlights.CurrentFlight Is Nothing Then
                _strMessage = DisplayMessages.RegisterULDFirst
                Me.Close()
                Exit Sub
            End If

            If objFlights.CurrentFlight.CurrentContainer Is Nothing Then
                _strMessage = DisplayMessages.RegisterULDFirst
                Me.Close()
                Exit Sub
            End If


            If objFlights.CurrentFlight.IsClosed Then
                _strMessage = DisplayMessages.FlightClosed
                Me.Close()
                Exit Sub
            End If

            If objFlights.CurrentFlight.IsDeparted Then
                'Flight has departed
                _strMessage = DisplayMessages.FlightDeparted
                Me.Close()
                Exit Sub
            End If

            If UIController.CurrentFunction = SafetracFunction.LoadMailIntoContainer Then
                If objFlights.CurrentFlight.AreLoadAllowed Then
                    'Load are not allowed on this flight
                    _strMessage = DisplayMessages.RegisterULDFirst
                    Exit Sub
                End If
            End If

            UIController.CurrentFunction = BO.SafetracFunction.UnloadMailFromContainer
            Me.Close()

        End Sub

        Private Sub dlgUnloadMailFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.D1 Then
                cmdUnloadBB_Click(Me, Nothing)
            ElseIf e.KeyCode = Keys.D3 Then
                cmdUnloadULD_Click(Me, Nothing)
            End If
        End Sub

    End Class
End Namespace
