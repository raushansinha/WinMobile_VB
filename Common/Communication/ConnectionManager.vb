
Imports System.Net
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.Communication
    ''' <summary>
    ''' Monitors the network and ensures for network availibility inorder to perform
    ''' Safetrac operations
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ConnectionManager

        Private _ConnectionType As String
        Public Property ConnectionType() As String
            Get
                Return _ConnectionType
            End Get
            Set(ByVal value As String)
                _ConnectionType = value
            End Set
        End Property
        ''' <summary>
        ''' Initialize Connection Manager which monitors the network availibility
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()

        End Sub
        ''' <summary>
        ''' Run Connection Manager
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Run()

        End Sub
        ''' <summary>
        ''' Stop Connection Manager
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub StopConnectionManager()

        End Sub
        Public Function IsDeviceConnected(ByVal serverIPAddress As String) As Boolean
            Dim objIPHostEntry As System.Net.IPHostEntry
            Try
                objIPHostEntry = System.Net.Dns.Resolve(serverIPAddress)
                If objIPHostEntry IsNot Nothing Then
                    If objIPHostEntry.AddressList.Length > 0 Then
                        Return True
                    End If
                End If
                Return False
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Shared ReadOnly Property IsConnected() As Boolean
            Get
                Try
                    Dim objIPHostEntry As IPHostEntry = Dns.GetHostEntry(ConfigManager.ServerIPAddress)
                    If objIPHostEntry.AddressList.Length > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    Return False
                End Try
            End Get
        End Property


    End Class ' END CLASS DEFINITION ConnectionManager

End Namespace ' Communication

