Imports System.Xml
Imports System.IO
Imports System.Collections.Generic
Imports NWA.Safetrac.Scanner.BO

Namespace NWA.Safetrac.Scanner.Utils
    ''' <summary>
    ''' Retrieves the configuration settings from the configuration files and make them available to the application
    ''' </summary>
    ''' <remarks></remarks>
    Public Module ConfigManager
        Private _diConfigValues As New Dictionary(Of String, String)
        Private _strAppPath As String
        Private _intLogLevel As Integer = 2
        Private _timeAutoLogoff As TimeSpan

        Public ReadOnly Property My(ByVal key As String) As String
            Get
                If _diConfigValues.ContainsKey(key) Then
                    Return _diConfigValues(key)
                Else
                    Return Nothing
                End If
            End Get
        End Property

        Public Property SerialNumber() As String
            Get
                Return _diConfigValues("SerialNumber")
            End Get
            Set(ByVal value As String)
                SetAppSettingToConfigFile("SerialNumber", value)
            End Set
        End Property
        Public Property HAgent() As String
            Get
                Return _diConfigValues("HAgent")
            End Get
            Set(ByVal value As String)
                SetAppSettingToConfigFile("HAgent", value)
            End Set
        End Property

        Public Property HHTId() As String
            Get
                Return _diConfigValues("HHTId")
            End Get
            Set(ByVal value As String)
                SetAppSettingToConfigFile("HHTId", value)
            End Set
        End Property

        Public Property NetName() As String
            Get
                Return _diConfigValues("NetName")
            End Get
            Set(ByVal value As String)
                SetAppSettingToConfigFile("NetName", value)
            End Set
        End Property

        Public Property ProductionStation() As String
            Get
                Return _diConfigValues("ProductionStation")
            End Get
            Set(ByVal value As String)
                SetAppSettingToConfigFile("ProductionStation", value)
            End Set
        End Property

        Public Property J2EEServer() As String
            Get
                Return _diConfigValues("J2EEServer")
            End Get
            Set(ByVal value As String)
                SetAppSettingToConfigFile("J2EEServer", value)
            End Set
        End Property

        Public Property NETServer() As String
            Get
                Return _diConfigValues("NETServer")
            End Get
            Set(ByVal value As String)
                SetAppSettingToConfigFile("NETServer", value)
            End Set
        End Property

        Public Property TrainingStation() As String
            Get
                Return _diConfigValues("TrainingStation")
            End Get
            Set(ByVal value As String)
                SetAppSettingToConfigFile("TrainingStation", value)
            End Set
        End Property

        Public Property TrainingStationName() As String
            Get
                Return _diConfigValues("TrainingStationName")
            End Get
            Set(ByVal value As String)
                SetAppSettingToConfigFile("TrainingStationName", value)
            End Set
        End Property

        Public Property CityCode() As String
            Get
                Return _diConfigValues("CityCode")
            End Get
            Set(ByVal value As String)
                SetAppSettingToConfigFile("CityCode", value)
            End Set
        End Property

        Public Property FTPServerIPAddress() As String
            Get
                Return _diConfigValues("FTPServerIPAddress")
            End Get
            Set(ByVal value As String)
                SetAppSettingToConfigFile("FTPServerIPAddress", value)
            End Set
        End Property

        Public Property FTPServerPort() As String
            Get
                Return _diConfigValues("FTPServerPort")
            End Get
            Set(ByVal value As String)
                SetAppSettingToConfigFile("FTPServerPort", value)
            End Set
        End Property

        Public ReadOnly Property DurationToHoldFlightData() As Integer
            Get
                Return _diConfigValues("DurationToHoldFlightDataInHours")
            End Get
        End Property
        Public ReadOnly Property ServerIPAddress() As String
            Get
                Return _diConfigValues("ServerIPAddress")
            End Get
        End Property
        Public ReadOnly Property ApplicationPath() As String
            Get
                Return _strAppPath
            End Get
        End Property
        Public ReadOnly Property SqlceURL() As String
            Get
                Return _strAppPath & "\" & _diConfigValues("databaseName")
            End Get
        End Property

        Public Property LogLevel() As Integer
            Get
                Return _intLogLevel
            End Get
            Set(ByVal value As Integer)
                _intLogLevel = value
            End Set
        End Property

        Public Property WS_DataSyncService() As String
            Get
                Return _diConfigValues("WS_DataSyncService")
            End Get
            Set(ByVal value As String)
                SetWebReferenceToConfigFile("WS_DataSyncService", value)
            End Set
        End Property
        Public Property WS_GetACConfig_AOT() As String
            Get
                Return _diConfigValues("WS_GetACConfig_AOT")
            End Get
            Set(ByVal value As String)
                SetWebReferenceToConfigFile("WS_GetACConfig_AOT", value)
            End Set
        End Property

        Public Property WS_Device_Admin_AOT() As String
            Get
                Return _diConfigValues("WS_Device_Admin_AOT")
            End Get
            Set(ByVal value As String)
                SetWebReferenceToConfigFile("WS_Device_Admin_AOT", value)
            End Set
        End Property

        Public Property WS_FlightLD_AOT() As String
            Get
                Return _diConfigValues("WS_FlightLD_AOT")
            End Get
            Set(ByVal value As String)
                SetWebReferenceToConfigFile("WS_FlightLD_AOT", value)
            End Set
        End Property

        Public Property WS_Freight_Load_AOT() As String
            Get
                Return _diConfigValues("WS_Freight_Load_AOT")
            End Get
            Set(ByVal value As String)
                SetWebReferenceToConfigFile("WS_Freight_Load_AOT", value)
            End Set
        End Property

        Public Property WS_GetDateTime_AOT() As String
            Get
                Return _diConfigValues("WS_GetDateTime_AOT")
            End Get
            Set(ByVal value As String)
                SetWebReferenceToConfigFile("WS_GetDateTime_AOT", value)
            End Set
        End Property

        Public Property WS_ReadDDSGLineItems_AOT() As String
            Get
                Return _diConfigValues("WS_ReadDDSGLineItems_AOT")
            End Get
            Set(ByVal value As String)
                SetWebReferenceToConfigFile("WS_ReadDDSGLineItems_AOT", value)
            End Set
        End Property

        Public Property WS_SOSA_Logger() As String
            Get
                Return _diConfigValues("WS_SOSA_Logger")
            End Get
            Set(ByVal value As String)
                SetWebReferenceToConfigFile("WS_SOSA_Logger", value)
            End Set
        End Property

        Public ReadOnly Property AutoLogoffTime() As TimeSpan
            Get
                Return _timeAutoLogoff
            End Get
        End Property

        Sub New()
            Initialize()
        End Sub

        Private Sub Initialize()
            'Test code - will be deleted later
            _strAppPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
            If File.Exists(_strAppPath & UtilConstants.ConfigFileName) Then
                UtilConstants.ConfigFileName = _strAppPath & UtilConstants.ConfigFileName
            ElseIf File.Exists("\Flash Disk" & UtilConstants.ConfigFileName) Then
                UtilConstants.ConfigFileName = "\Flash Disk" & UtilConstants.ConfigFileName
            Else
                UtilConstants.ConfigFileName = "\Storage Card" & UtilConstants.ConfigFileName
            End If

            Try
                If File.Exists(UtilConstants.ConfigFileName) Then
                    Dim objXmlDocument As New XmlDocument()
                    objXmlDocument.Load(UtilConstants.ConfigFileName)
                    Dim objXmlNodeList As XmlNodeList
                    Dim objXmlSingleNode As XmlNode

                    'populate application settings
                    objXmlNodeList = objXmlDocument.SelectNodes("//configuration/appSettings/add")
                    For Each objXmlNode As XmlNode In objXmlNodeList
                        _diConfigValues.Add(objXmlNode.Attributes("key").Value, objXmlNode.Attributes("value").Value)
                    Next

                    'populate webreferences url's
                    objXmlNodeList = objXmlDocument.SelectNodes("//configuration/webReferences/add")
                    For Each objXmlNode As XmlNode In objXmlNodeList
                        _diConfigValues.Add(objXmlNode.Attributes("reference").Value, objXmlNode.Attributes("url").Value)
                    Next
                    objXmlSingleNode = objXmlDocument.SelectSingleNode("//configuration/sqlceRefrence/add")
                    'Add the DB refrence
                    _diConfigValues.Add(objXmlSingleNode.Attributes("reference").Value, objXmlSingleNode.Attributes("url").Value)
                Else
                    'Initialize config values from registry
                End If

                Try
                    _intLogLevel = Convert.ToInt16(_diConfigValues("LogLevel"))
                Catch ex As Exception
                    'in case of exception, set to the default value
                    _intLogLevel = 2
                End Try

                Try
                    _timeAutoLogoff = New TimeSpan(0, Convert.ToInt16(_diConfigValues("AutoLogoffTime")), 0)
                Catch ex As Exception
                    'in case of exception, set to the default value
                    _timeAutoLogoff = New TimeSpan(0, 30, 0)
                End Try

            Catch ex As Exception
                MsgBox(ex.ToString)
                Logger.LogException(ex)
                'Displaying exception in message only for testing purpose. Would be removed later
            End Try
        End Sub

        Public Sub SetAppSettingToConfigFile(ByVal key As String, ByVal value As String)
            Try
                If File.Exists(UtilConstants.ConfigFileName) Then
                    Dim objXmlDocument As New XmlDocument()
                    objXmlDocument.Load(UtilConstants.ConfigFileName)
                    Dim objXmlNode As XmlNode
                    objXmlNode = objXmlDocument.SelectSingleNode("//configuration/appSettings/add[@key='" & key & "']")
                    If objXmlNode IsNot Nothing Then
                        objXmlNode.Attributes("value").Value = value
                        objXmlDocument.Save(UtilConstants.ConfigFileName)
                    Else
                        Throw New SafetracException(ReturnCodes.Exception, "Invalid Configuration Key", _
                        "ConfigManager.SetAppSettingToConfigFile")
                    End If
                Else
                    Throw New SafetracException(ReturnCodes.Exception, "Safetrac configuration file could not be located", _
                                            "ConfigManager.SetAppSettingToConfigFile")
                End If
            Catch ex As Exception
                Logger.LogException(ex)
                'Displaying exception in message only for testing purpose. Would be removed later
                MsgBox(ex.ToString)
                Throw ex
            End Try
        End Sub

        Public Sub AddAppSettingToConfigFile(ByVal key As String, ByVal value As String)
            Try
                If File.Exists(UtilConstants.ConfigFileName) Then
                    Dim objXmlDocument As New XmlDocument()
                    objXmlDocument.Load(UtilConstants.ConfigFileName)
                    Dim objXmlElement As XmlElement = objXmlDocument.CreateElement("add")
                    Dim objXmlAttributeKey As XmlAttribute = objXmlDocument.CreateAttribute("key")
                    Dim objXmlAttributeValue As XmlAttribute = objXmlDocument.CreateAttribute("value")
                    objXmlElement.Attributes.Append(objXmlAttributeKey)
                    objXmlElement.Attributes.Append(objXmlAttributeValue)
                    objXmlElement.SetAttribute("key", key)
                    objXmlElement.SetAttribute("value", value)
                    objXmlDocument.DocumentElement.FirstChild.AppendChild(objXmlElement)
                    objXmlDocument.Save(UtilConstants.ConfigFileName)
                Else
                    Throw New SafetracException(ReturnCodes.Exception, "Safetrac configuration file could not be located", _
                                            "ConfigManager.SetAppSettingToConfigFile")
                End If
            Catch ex As Exception
                Logger.LogException(ex)
                'Displaying exception in message only for testing purpose. Would be removed later
                MsgBox(ex.ToString)
                Throw ex
            End Try
        End Sub


        Public Sub SetWebReferenceToConfigFile(ByVal referenceName As String, ByVal url As String)
            Try
                If File.Exists(UtilConstants.ConfigFileName) Then
                    Dim objXmlDocument As New XmlDocument()
                    objXmlDocument.Load(UtilConstants.ConfigFileName)
                    Dim objXmlNode As XmlNode
                    objXmlNode = objXmlDocument.SelectSingleNode("//configuration/webReferences/add[@reference='" & referenceName & "']")
                    If objXmlNode IsNot Nothing Then
                        objXmlNode.Attributes("url").Value = url
                        objXmlDocument.Save(UtilConstants.ConfigFileName)
                    Else
                        Throw New SafetracException(ReturnCodes.Exception, "Invalid Configuration Key", _
                        "ConfigManager.SetAppSettingToConfigFile")
                    End If
                Else
                    Throw New SafetracException(ReturnCodes.Exception, "Safetrac configuration file could not be located", _
                                            "ConfigManager.SetAppSettingToConfigFile")
                End If
            Catch ex As Exception
                Logger.LogException(ex)
                'Displaying exception in message only for testing purpose. Would be removed later
                MsgBox(ex.ToString)
                Throw ex
            End Try
        End Sub

        Public Sub AddWebReferenceToConfigFile(ByVal referenceName As String, ByVal url As String)
            Try
                If File.Exists(UtilConstants.ConfigFileName) Then
                    Dim objXmlDocument As New XmlDocument()
                    objXmlDocument.Load(UtilConstants.ConfigFileName)
                    Dim objXmlElement As XmlElement = objXmlDocument.CreateElement("add")
                    Dim objXmlAttributeKey As XmlAttribute = objXmlDocument.CreateAttribute("reference")
                    Dim objXmlAttributeValue As XmlAttribute = objXmlDocument.CreateAttribute("url")
                    objXmlElement.Attributes.Append(objXmlAttributeKey)
                    objXmlElement.Attributes.Append(objXmlAttributeValue)
                    objXmlElement.SetAttribute("reference", referenceName)
                    objXmlElement.SetAttribute("url", url)
                    objXmlDocument.DocumentElement.LastChild.AppendChild(objXmlElement)
                    objXmlDocument.Save(UtilConstants.ConfigFileName)
                Else
                    Throw New SafetracException(ReturnCodes.Exception, "Safetrac configuration file could not be located", _
                                            "ConfigManager.SetAppSettingToConfigFile")
                End If
            Catch ex As Exception
                Logger.LogException(ex)
                'Displaying exception in message only for testing purpose. Would be removed later
                MsgBox(ex.ToString)
                Throw ex
            End Try
        End Sub
    End Module

End Namespace ' Utils