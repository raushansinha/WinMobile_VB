
Imports System
Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Threading
Imports System.Xml.Serialization
Imports NWA.Safetrac.Scanner.Communication
Imports NWA.Safetrac.Scanner.WebReferences.SOSA

Namespace NWA.Safetrac.Scanner.Utils

    'Dim _strLogFilesFolderName As String = "\Logs"
    'Dim _strLogFileDirPath As String = ConfigManager.ApplicationPath & _strLogFilesFolderName
    'Dim _strEndElement As String = "</Logs>"

    Public Module Logger

        Dim _strLogFilesFolderName As String = "\Logs"
        Dim _strLogFileDirPath As String = ConfigManager.ApplicationPath & _strLogFilesFolderName
        'Dim _strLogFileDirPath As String = "\Program Files" & _strLogFilesFolderName
        'Dim _strEndElement As String = "</Logs>"
        Private _strLogFileName As String = String.Empty
        Private _objSOSALogger As New LoggerService()
        Private _intLogLevel As Integer
        Private _queSOSALogs As New Queue(Of String)
        Private _thrdUpdater As Thread
        Private _blnFTPRunning As Boolean = False

        Sub New()
            Try
                DeleteLogFiles()
                _intLogLevel = ConfigManager.LogLevel
                CreateNewLogFile()
                _thrdUpdater = New Thread(AddressOf UpdateLogs)
                _thrdUpdater.IsBackground = True
                _thrdUpdater.Priority = ThreadPriority.BelowNormal
                _thrdUpdater.Start()
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Public Sub LogMessage(ByVal message As String, ByVal logType As LogType, _
                    ByVal source As String)
            Select Case _intLogLevel
                Case 1
                    'Exceptions message only
                    If logType = Utils.LogType.Exception Then
                        LogMessageInternal(message, logType, source)
                    End If
                Case 2
                    'Exception, Information messages
                    If logType = Utils.LogType.Exception Or logType = Utils.LogType.Information Then
                        LogMessageInternal(message, logType, source)
                    End If
                Case 3
                    'Exception, Information, Warning messages
                    If logType <> Utils.LogType.Trace Then
                        LogMessageInternal(message, logType, source)
                    End If
                Case 4
                    'Exception, Information, Warning, Debug messages
                    LogMessageInternal(message, logType, source)
                Case Else
                    'unknown condition - log all messages
                    LogMessageInternal(message, logType, source)
            End Select
        End Sub

        Private Sub LogMessageInternal(ByVal message As String, ByVal logType As LogType, _
                    ByVal source As String)
            LogToLocalFile(message, logType, source)
            QueueToSOSA(message, logType, source)
        End Sub


        Public Sub LogException(ByVal objException As Exception)
            LogToLocalFile(objException.Message, LogType.Exception, objException.ToString)
            QueueToSOSA(objException.Message, LogType.Exception, objException.ToString)
            Debug.WriteLine(objException.ToString)
        End Sub

        Private Sub UpdateLogs()
            Do
                Try
                    If _queSOSALogs.Count > 10 Then
                        Debug.WriteLine("***************************LOGGER RUNNING******************************")
                        Try
                            Dim intRefCount As Integer = _queSOSALogs.Count
                            Dim strLog As String = String.Empty
                            If ConnectionManager.IsConnected Then
                                For intRefCount = 0 To intRefCount = 5
                                    strLog = _queSOSALogs.Dequeue
                                    Dim strSOSAXMLResponse As String = _objSOSALogger.insertLogDetails(strLog)
                                Next
                            Else
                                If _queSOSALogs.Count > 25 Then
                                    Dim intQueCount As Integer = _queSOSALogs.Count - 10
                                    For intRefCount = 0 To intRefCount = intQueCount
                                        _queSOSALogs.Dequeue()
                                    Next

                                End If
                            End If

                            Debug.WriteLine("***************************LOGGER STOPPED*****************************")

                        Catch ex As Exception
                        End Try
                    End If
                Catch ex As Exception
                    Debug.WriteLine(ex.ToString)
                Finally
                    Thread.Sleep(10000)
                End Try
            Loop
        End Sub

        Private Sub LogToLocalFile(ByVal message As String, ByVal logType As LogType, _
                    ByVal source As String)
            Try
                Dim strLogSchema As String = ApplyLogFileSchema(message, logType, source)
                If _blnFTPRunning = False Then
                    If Directory.Exists(_strLogFileDirPath) = False Then
                        Directory.CreateDirectory(_strLogFileDirPath)
                    End If
                    If File.Exists(_strLogFileName) = False Then
                        CreateNewLogFile()
                    End If
                    If (((New FileInfo(_strLogFileName).Length) > 2097152) Or (_strLogFileName.Substring(_strLogFileName.Length - 20, 9) <> DateTime.Now.ToString("ddMMMyyyy"))) Then
                        CreateNewLogFile()
                    End If

                    'open the file and write the log message
                    Dim objStreamWriter As New StreamWriter(_strLogFileName, True)
                    objStreamWriter.Write(strLogSchema)
                    objStreamWriter.Flush()
                    objStreamWriter.Close()

                End If
            Catch ex As Exception
                Debug.WriteLine(ex.ToString())
            End Try
        End Sub

        'Private Sub LogToLocalFile(ByVal message As String, ByVal logType As LogType, _
        '            ByVal source As String)
        '    Try

        '        If Directory.Exists(_strLogFileDirPath) = False Then
        '            Directory.CreateDirectory(_strLogFileDirPath)
        '        End If

        '        If (((New FileInfo(_strLogFileName).Length) > 1500) Or (_strLogFileName.Substring(_strLogFileName.Length - 20, 9) <> DateTime.Now.ToString("ddMMMyyyy"))) Then
        '            CreateNewLogFile()
        '        End If

        '        'open the file and write the log message
        '        Dim strLogSchema As String = ApplyLogFileSchema(message, logType, source)

        '        If strLogSchema IsNot String.Empty Then
        '            Dim objStreamWriter As New StreamWriter(_strLogFileName, True)
        '            objStreamWriter.Write(strLogSchema)
        '            objStreamWriter.Flush()
        '            objStreamWriter.Close()
        '        End If
        '    Catch ex As Exception
        '        Debug.WriteLine(ex.ToString())
        '    End Try
        'End Sub

       

        Private Function QueueToSOSA(ByVal message As String, ByVal logType As LogType, _
                    ByVal source As String) As String
            Dim strSOSALogSchema As String = String.Empty
            Try
                'Apply SOSA schema and get XML as String
                strSOSALogSchema = ApplySOSASchema(message, logType, source)
                _queSOSALogs.Enqueue(strSOSALogSchema)
            Catch ex As Exception
                Debug.WriteLine(ex.ToString())
            End Try
            Return strSOSALogSchema
        End Function

        'Private Function LogToSOSA(ByVal message As String, ByVal logType As LogType, _
        '            ByVal source As String) As String
        '    Dim strSOSALogSchema As String = String.Empty
        '    Try
        '        'Apply SOSA schema and get XML as String
        '        strSOSALogSchema = ApplySOSASchema(message, logType, source)
        '        If strSOSALogSchema IsNot String.Empty Then
        '            'CONTACT WEB SERVICE - send LogSOSAXMLReq.xml & get response in to LogSOSAXMLResp.xml
        '            If NWA.Safetrac.Scanner.Communication.ConnectionManager.IsConnected Then
        '                'strSOSALogSchema = "<?xml version=" & "'1.0'" & " encoding=" & "" & "'utf-8'" & "?>" & "<Logger><LoggerInfo><ApplicationCode>FLR</ApplicationCode><ApplicationModule>FLR</ApplicationModule><LogCode>APPERR</LogCode><LogTimestamp>2007-10-09 09:48:59.599</LogTimestamp><LogDetails>java.lang.StringIndexOutOfBoundsException: String index out of range:200</LogDetails><LogEventCode>Eventtest</LogEventCode><RecordProcessingIndicator>N</RecordProcessingIndicator><UserId>n00000</UserId></LoggerInfo></Logger>"
        '                Dim strSOSAXMLResponse As String = _objSOSALogger.insertLogDetails(strSOSALogSchema)
        '                Debug.WriteLine(strSOSAXMLResponse)
        '            End If
        '            'to write response to a local file
        '            'Dim fsResp As FileStream = New FileStream(_strLogFileDirPath & "\SOSAXMLResponse.xml", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite)
        '            'Dim respBytes As Byte() = New UTF8Encoding().GetBytes(strSOSAXMLResponse)
        '            'fsResp.Write(respBytes, 0, respBytes.Length)
        '            'fsResp.Close()
        '        End If
        '    Catch ex As Exception
        '        Debug.WriteLine(ex.ToString())
        '    End Try
        '    Return strSOSALogSchema
        'End Function


        Private Function ApplySOSASchema(ByVal message As String, _
                        ByVal logType As LogType, ByVal source As String) As String
            Dim strSOSALog As String = String.Empty
            Try
                Dim objSOAPEnv As SOAPENVEnvelope = New SOAPENVEnvelope
                Dim objSOAPLogInfo As SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetailsQ0xmlLoggerLoggerInfo = objSOAPEnv.SOAPENVBody.q0insertLogDetails.q0xml.Logger.LoggerInfo
                objSOAPLogInfo.ApplicationModule = ""
                objSOAPLogInfo.ApplicationCode = "SAFETRAC"
                objSOAPLogInfo.LogCode = logType.ToString
                objSOAPLogInfo.LogTimestamp = Date.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
                objSOAPLogInfo.LogDetails = message & source
                objSOAPLogInfo.LogEventCode = logType.ToString
                objSOAPLogInfo.RecordProcessingIndicator = "Y"
                objSOAPLogInfo.UserId = "31311"
                'objSOAPLogInfo.ApplicationModule = "FLR"
                'objSOAPLogInfo.ApplicationCode = "FLR"
                'objSOAPLogInfo.LogCode = "APPERR"
                'objSOAPLogInfo.LogTimestamp = "2007-10-09 09:48:59.599"
                'objSOAPLogInfo.LogDetails = "java.lang.StringIndexOutOfBoundsException: String index out of range:200"
                'objSOAPLogInfo.LogEventCode = "Eventtest"
                'objSOAPLogInfo.RecordProcessingIndicator = "N"
                'objSOAPLogInfo.UserId = "n00000"
                strSOSALog = objSOAPEnv.ToString()
            Catch ex As Exception
                Debug.WriteLine(ex.ToString())
            End Try
            Return strSOSALog
        End Function

        Private Function ApplyLogFileSchema(ByVal message As String, _
                       ByVal logType As LogType, ByVal source As String) As String
            Dim strLog As String = String.Empty
            Try
                Dim objLog As New Log
                objLog.Time = DateTime.Now.ToString
                objLog.Type = logType.ToString
                objLog.Message = message
                If source Is Nothing Then
                    objLog.Source = ""
                Else
                    objLog.Source = source
                End If
                strLog = objLog.ToString()
            Catch ex As Exception
                Debug.WriteLine(ex.ToString())
            End Try
            Return strLog
        End Function

        Private Sub CreateNewLogFile()
            Try

                _strLogFileName = CreateNewLogFileName()
                Dim objFileStream As FileStream = File.Create(_strLogFileName)
                Dim headerBytes() As Byte = Encoding.UTF8.GetBytes("<?xml version=""1.0"" encoding=""utf-8""?><Logs>")
                objFileStream.Write(headerBytes, 0, headerBytes.Length)
                objFileStream.Close()

                'Dim objXmlTextWriter As New XmlTextWriter(_strLogFileName, System.Text.Encoding.UTF8)
                'objXmlTextWriter.Formatting = Formatting.Indented
                'objXmlTextWriter.Indentation = 4
                'objXmlTextWriter.WriteStartDocument(True)
                'objXmlTextWriter.WriteStartElement("")
                'objXmlTextWriter.WriteEndElement()
                'objXmlTextWriter.WriteEndDocument()
                'objXmlTextWriter.Flush()
                'objXmlTextWriter.Close()

            Catch ex As Exception

            End Try
        End Sub

        Private Function CreateNewLogFileName() As String
            Return _strLogFileDirPath & "\\HHT-" & ConfigManager.HHTId & "-" & _
                DateTime.Now.ToString("ddMMMyyyy-hhmmss") & ".log"
        End Function

        Public Function UploadLogFiles() As Boolean
            Try
                _blnFTPRunning = True
                'get all the file names in the dicrectory
                Dim strFileNames() As String = Directory.GetFiles(_strLogFileDirPath)
                Dim fileName As String = String.Empty

                If strFileNames.Length = 0 Then
                    Logger.LogMessage("No Log files To Upload", LogType.Exception, "logger.UploadLogFiles()")
                    Exit Function
                End If

                'for each file in the directory
                For Each fileName In strFileNames
         
                    Try
                        'if its not todays log file
                        If fileName <> _strLogFileName Then
                            'appending XML encoding , start and end elements before uploading
                            Dim objStreamWriter As New StreamWriter(fileName, True)
                            objStreamWriter.Write("</Logs>")
                            objStreamWriter.Flush()
                            objStreamWriter.Close()

                            'Upload to FTP
                            Dim objCredentials As System.Net.NetworkCredential = New System.Net.NetworkCredential("anonymous", "")
                            Dim objFTPConn As FTPConnection = New FTPConnection
                            objFTPConn.Connect(ConfigManager.FTPServerIPAddress, ConfigManager.FTPServerPort, Nothing, objCredentials)
                            If objFTPConn.IsActive Then
                                Try
                                    objFTPConn.UploadFile(fileName)
                                Catch ex As Exception
                                End Try
                            End If
                            objFTPConn.Disconnect()
                            File.Delete(fileName)
                        End If
                    Catch ex As Exception
                        Logger.LogException(ex)
                    End Try
                Next
            Catch ex As Exception
                Logger.LogException(ex)
                Debug.WriteLine(ex.ToString)
                _blnFTPRunning = False
            Finally
                _blnFTPRunning = False
            End Try
        End Function
        Public Sub DeleteLogFiles()
            'get all the file names in the dicrectory
            Dim strFileNames() As String = Directory.GetFiles(_strLogFileDirPath)
            Dim strFileName As String = String.Empty
            Dim timeDiff As New TimeSpan(2, 0, 0, 0)
            Dim dtFileDate As Date
            Dim strFileDate As String

            'for each file in the directory
            For Each strFileName In strFileNames
                Try
                    strFileDate = strFileName.Substring(_strLogFileName.Length - 20, 16)
                    dtFileDate = Date.ParseExact(strFileDate, "ddMMMyyyy-hhmmss", Nothing)
                    If Date.Now.Subtract(dtFileDate).TotalHours > timeDiff.TotalHours Then
                        File.Delete(strFileName)
                    End If
                Catch ex As Exception
                    Logger.LogException(ex)
                End Try
            Next
        End Sub
    End Module
  

    <Serializable()> _
    Partial Public Class SOAPENVEnvelope

        Private sOAPENVBodyField As New SOAPENVEnvelopeSOAPENVBody
        '''<remarks/>
        Public Property SOAPENVBody() As SOAPENVEnvelopeSOAPENVBody
            Get
                Return Me.sOAPENVBodyField
            End Get
            Set(ByVal value As SOAPENVEnvelopeSOAPENVBody)
                Me.sOAPENVBodyField = value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Dim strSOSALog As String = String.Empty
            Try
                Dim objXmlSerializer As New Xml.Serialization.XmlSerializer(GetType(SOAPENVEnvelope))
                Dim objWriter As New StringWriter()
                Dim ObjXMLDoc As New XmlDocument
                objXmlSerializer.Serialize(objWriter, Me)
                ObjXMLDoc.LoadXml(objWriter.ToString)
                strSOSALog = "<?xml version=" & "'1.0'" & " encoding=" & "" & "'utf-8'" & "?>" & ObjXMLDoc.DocumentElement.FirstChild.FirstChild.FirstChild.InnerXml
            Catch ex As Exception
            End Try
            Return strSOSALog
        End Function

    End Class

    '''<remarks/>
    Partial Public Class SOAPENVEnvelopeSOAPENVBody

        Private q0insertLogDetailsField As New SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetails

        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property q0insertLogDetails() As SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetails
            Get
                Return Me.q0insertLogDetailsField
            End Get
            Set(ByVal value As SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetails)
                Me.q0insertLogDetailsField = value
            End Set
        End Property
    End Class

    '''<remarks/>

    Partial Public Class SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetails

        Private q0xmlField As New SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetailsQ0xml

        '''<remarks/>

        '<System.Xml.Serialization.XmlElementAttribute("q0-xml")> _
        <System.Xml.Serialization.XmlElement()> _
        Public Property q0xml() As SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetailsQ0xml
            Get
                Return Me.q0xmlField
            End Get
            Set(ByVal value As SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetailsQ0xml)
                Me.q0xmlField = value
            End Set
        End Property
    End Class

    '''<remarks/>

    Partial Public Class SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetailsQ0xml

        Private loggerField As New SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetailsQ0xmlLogger

        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property Logger() As SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetailsQ0xmlLogger
            Get
                Return Me.loggerField
            End Get
            Set(ByVal value As SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetailsQ0xmlLogger)
                Me.loggerField = value
            End Set
        End Property
    End Class



    Partial Public Class SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetailsQ0xmlLogger

        Private loggerInfoField As New SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetailsQ0xmlLoggerLoggerInfo

        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property LoggerInfo() As SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetailsQ0xmlLoggerLoggerInfo
            Get
                Return Me.loggerInfoField
            End Get
            Set(ByVal value As SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetailsQ0xmlLoggerLoggerInfo)
                Me.loggerInfoField = value
            End Set
        End Property
    End Class

    '''<remarks/>

    Partial Public Class SOAPENVEnvelopeSOAPENVBodyQ0insertLogDetailsQ0xmlLoggerLoggerInfo

        Private applicationCodeField As String

        Private applicationModuleField As String

        Private logCodeField As String

        Private logTimestampField As String

        Private logDetailsField As String

        Private logEventCodeField As String

        Private recordProcessingIndicatorField As String

        Private userIdField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property ApplicationCode() As String
            Get
                Return Me.applicationCodeField
            End Get
            Set(ByVal value As String)
                Me.applicationCodeField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property ApplicationModule() As String
            Get
                Return Me.applicationModuleField
            End Get
            Set(ByVal value As String)
                Me.applicationModuleField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property LogCode() As String
            Get
                Return Me.logCodeField
            End Get
            Set(ByVal value As String)
                Me.logCodeField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property LogTimestamp() As String
            Get
                Return Me.logTimestampField
            End Get
            Set(ByVal value As String)
                Me.logTimestampField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property LogDetails() As String
            Get
                Return Me.logDetailsField
            End Get
            Set(ByVal value As String)
                Me.logDetailsField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property LogEventCode() As String
            Get
                Return Me.logEventCodeField
            End Get
            Set(ByVal value As String)
                Me.logEventCodeField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property RecordProcessingIndicator() As String
            Get
                Return Me.recordProcessingIndicatorField
            End Get
            Set(ByVal value As String)
                Me.recordProcessingIndicatorField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property UserId() As String
            Get
                Return Me.userIdField
            End Get
            Set(ByVal value As String)
                Me.userIdField = value
            End Set
        End Property
    End Class

    <Serializable()> _
Partial Public Class Log

        Private strTimeField As String
        Private strTypeField As String
        Private strSourceField As String
        Private strMsgField As String
        Private strExeField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property Time() As String
            Get
                Return Me.strTimeField
            End Get
            Set(ByVal value As String)
                Me.strTimeField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property Type() As String
            Get
                Return Me.strTypeField
            End Get
            Set(ByVal value As String)
                Me.strTypeField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property Message() As String
            Get
                Return Me.strMsgField
            End Get
            Set(ByVal value As String)
                Me.strMsgField = value
            End Set
        End Property


        '''<remarks/>
        <System.Xml.Serialization.XmlElement()> _
        Public Property Source() As String
            Get
                Return Me.strSourceField
            End Get
            Set(ByVal value As String)
                Me.strSourceField = value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Dim strLog As String = String.Empty
            Try
                Dim objXmlSerializer As New Xml.Serialization.XmlSerializer(GetType(Log))
                Dim objWriter As New StringWriter()
                Dim ObjXMLDoc As New XmlDocument
                objXmlSerializer.Serialize(objWriter, Me)
                ObjXMLDoc.LoadXml(objWriter.ToString)
                strLog = "<Log>" & ObjXMLDoc.DocumentElement.InnerXml & "</Log>"
            Catch ex As Exception

            End Try
            Return strLog
        End Function

    End Class


    ''' <summary>
    ''' Holds the values for the possible Log levels
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LogType
        ''' <summary>
        ''' Separate Log generated for all the Trace Information  
        ''' </summary>
        ''' <remarks></remarks>
        Exception
        ''' <summary>
        ''' Indicates the Log value is of type Information
        ''' </summary>
        ''' <remarks></remarks>
        Information
        ''' <summary>
        ''' Indicates the Log value is of type Warning
        ''' </summary>
        ''' <remarks></remarks>
        Warning
        ''' <summary>
        ''' Indicates the Log value is of type Trace
        ''' </summary>
        ''' <remarks></remarks>
        Trace
    End Enum

    Public Module UtilConstants
        ''' <summary>
        ''' Directory Path of Config File
        ''' </summary>
        ''' <remarks></remarks>
        Public ConfigPath As String = "\Flash Disk"
        ''' <summary>
        ''' Name of the config file
        ''' </summary>
        ''' <remarks></remarks>
        Public ConfigFileName As String = "\Safetrac.config"
        'Private Const MSP_SSID = "<ZooPhytic>"
    End Module

End Namespace ' Utils

