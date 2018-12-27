Imports System.Windows.Forms
Imports OpenNETCF.Windows.Forms
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.DataAccess

Namespace NWA.Safetrac.Scanner.UI
    Public Class ApplicationMain

        Shared Sub Main()
            Try

                'Check if the application is already running
                If IsAppAlreadyRunning() Then
                    MessageBox.Show("Safetrac HHT Already Running")
                    Application.Exit()
                    Exit Sub
                End If

                If Not IO.File.Exists(ConfigManager.SqlceURL) Then
                    CreateDatabase.CreateDatabase()
                End If

                'test code - added for testing purpose only -  will be deleted later - pending
                FlightsCollection.InsertRecords(9)

                Dim objScanner As BO.Scanner
                objScanner = BO.Scanner.GetInstance

                If objScanner.IsAutoConfigNeeded() Then
                    objScanner.AutoConfigure()
                End If

                'Start the Application
                Application.Run(New frmBase)

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Shared Function IsAppAlreadyRunning() As Boolean
            Return False
        End Function
    End Class
End Namespace