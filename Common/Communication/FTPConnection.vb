Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports OpenNETCF.Net
Imports OpenNETCF.Net.Ftp
Imports NWA.Safetrac.Scanner.Utils


Namespace NWA.Safetrac.Scanner.Communication
    ''' <summary>
    ''' Contains methods for performing FTP operations
    ''' </summary>
    ''' <remarks></remarks>
    Public Class FTPConnection
        Dim _objFtpWebRequest As FtpWebRequest
        Dim _objFtpRequestStream As Stream
        Dim _objResponseReader As StreamReader

        ''' <summary>
        ''' Boolean flag indicating whether the FTP connection is active
        ''' </summary>
        ''' <remarks></remarks>
        Private _IsActive As Boolean
        Public Property IsActive() As Boolean
            Get
                Return _IsActive
            End Get
            Set(ByVal value As Boolean)
                _IsActive = value
            End Set
        End Property
        ''' <summary>
        ''' This method will be used to connect device to the network using FTP 
        ''' </summary>
        ''' <remarks></remarks>
        Public Function Connect(ByVal host As String, ByVal port As String, ByVal directory As String, ByVal icredentials As ICredentials) As Boolean
            Dim uri As Uri = Nothing
            port = "21"
            If directory Is Nothing Or directory = String.Empty Then
                uri = New Uri(String.Format("ftp://{0}/", host))
            Else
                uri = New Uri(String.Format("ftp://{0}/{1}/", host, directory))
            End If
            Try
                Dim creator As New FtpRequestCreator()
                WebRequest.RegisterPrefix("ftp:", creator)
                _objFtpWebRequest = DirectCast(WebRequest.Create(uri), FtpWebRequest)
                _objFtpWebRequest.Credentials = icredentials
                _objFtpRequestStream = _objFtpWebRequest.GetRequestStream()
                _objResponseReader = New StreamReader(_objFtpRequestStream)
                Me.IsActive = True
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''' <summary>
        ''' This method will be used to disconnect device from the FTP network
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Disconnect()
            If Not _objFtpRequestStream Is Nothing Then
                Try
                    _objFtpRequestStream.Close()
                    _objResponseReader.Close()
                Catch ex As Exception
                End Try
                _objFtpRequestStream = Nothing
            End If
            _objFtpWebRequest = Nothing
            Me.IsActive = False
        End Sub
        ''' <summary>
        ''' This method will be used to upload file to the server using FTP connection
        ''' </summary>
        ''' <remarks></remarks>
        Public Function UploadFile(ByVal filename As String) As Boolean
            Try
                'If File.Exists("\Storage Card\Logs\abc.zip") = False Then
                '    MsgBox("verify file name")
                'End If
                'filename = "\Storage Card\Logs\abc.zip"

                Dim responseReader As New StreamReader(_objFtpRequestStream)
                Dim responseString As String = responseReader.ReadToEnd()

                Dim filestream As New FileStream(filename, FileMode.Open) ' Open the input file
                Dim fileReader As New BinaryReader(filestream)

                'opening data connection
                Dim ftpResponseStream As Stream = _objFtpWebRequest.GetResponse().GetResponseStream()
                Dim dataWriter As New BinaryWriter(ftpResponseStream)
                Dim objWriter As StreamWriter = New StreamWriter(ftpResponseStream)

                ' to send commands to server
                Dim commandWriter As New StreamWriter(_objFtpRequestStream)
                ' Set transfer type to IMAGE (binary). 
                commandWriter.Write("TYPE I" & Chr(13) & "" & Chr(10) & "")
                commandWriter.Flush()

                ' Reading the request output 
                _objResponseReader = New StreamReader(_objFtpRequestStream)
                responseString = _objResponseReader.ReadToEnd()

                ' Write the command to the request stream. 
                Dim cmd As String = "stor " + Path.GetFileName(filename) + "" & Chr(13) & "" & Chr(10) & ""
                commandWriter.Write(cmd)
                commandWriter.Flush()

                ' We MUST flush before we start reading from both response and request 
                ' Reading the request output 
                responseString = _objResponseReader.ReadToEnd()

                Dim bufsize As Long = New FileInfo(filename).Length
                Dim buf As Byte() = New Byte(bufsize - 1) {}
                Dim xcount As Integer
                While ((fileReader.Read(buf, 0, buf.Length) <> 0))
                    dataWriter.Write(buf, 0, buf.Length)
                    If xcount <= 0 Then
                        Exit While
                    End If
                End While


                fileReader.Close()
                filestream.Close()
                dataWriter.Close()
                _objResponseReader.Close()

                Return True
            Catch ex As Exception
                Return False
            End Try

        End Function

    End Class ' END CLASS DEFINITION FTPConnection

End Namespace ' Communication
