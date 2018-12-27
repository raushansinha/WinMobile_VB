
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils


Namespace NWA.Safetrac.Scanner.UI
    Public Class dlgVersion

        Private Sub cmdHideVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHideVersion.Click
            Me.Close()
        End Sub

        Private Sub dlgVersion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                Dim objScanner As Scanner.BO.Scanner = Scanner.BO.Scanner.GetInstance
                Dim objReader As Hardware.ISafetracScanner = Hardware.Psion7535.GetInstance
                Dim strNETVersion As String = String.Empty
                Dim strPsionVersion As String = String.Empty
                Dim strSDFVersion As String = String.Empty

                strNETVersion = System.Environment.Version.ToString()
                strPsionVersion = objReader.Version.ToString
                strSDFVersion = OpenNETCF.Environment2.SdfVersion.ToString()

                lblAppVersion.Text = lblAppVersion.Text & objScanner.AppVersion.ToString()
                lblNETVersion.Text = lblNETVersion.Text & strNETVersion
                lblSDFVersion.Text = lblSDFVersion.Text & strSDFVersion
                lblPsionSDK.Text = lblPsionSDK.Text & strPsionVersion
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

    End Class
End Namespace