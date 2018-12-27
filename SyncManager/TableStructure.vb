#Region "NORTHWEST AIRLINES COPYRIGHT"
'File Name        : TableStructure.Vb
'Description      : All Parameters of SQL tables assigned to Table Structure Object which Cached from resource file
'Author           : 
'Created Date     : 
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

#Region "NAMESPACES"
Imports System.Resources
Imports NWA.Safetrac.Scanner.Utils
#End Region
Namespace NWA.Safetrac.Scanner.SyncManager
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class TableStructure
        Private _strTableName As String
        Private _strTableAlias As String
        Private _strCommodityType As String
        Private _blnUploadApplicable As Boolean
        Private _blnDownloadApplicable As Boolean
        'Private _strCreateCommand As String
        Private _strSelectCommand As String
        Private _strIndexCommand As String
        Private _strInsertNewRecordCommandBlindUpdate As String
        Private _strDeleteNewRecordCommandBlindUpdate As String
        Private _strInsertOnlyNewerServerRecordsCommand As String
        Private _strDeleteOnlyNewerServerRecordsCommand As String
        Private _strSelectNonOverridingFieldsCommand As String
        Private _strSkipRecordsCommand As String
        Private _strSelectTempRecordsCommand As String
        Private _strDeleteTempRecordsCommand As String
        Private _strInsertCommand As String
        Private _strUpdateCommand As String
        Private _strUpdateNonOvveridingCommand As String
        Private _strDeleteCommand As String
        Private _blnIsScanApplicable As Boolean
        Private _strmreaderSchema As IO.StreamReader
        Private Shared _dicTables As New Dictionary(Of String, TableStructure)
        Private Shared _lstUploadTables As New List(Of String)
        Private Shared _lstDownloadTables As New List(Of String)
        Private Shared _lstScanApplicableTables As New List(Of String)
        ''' <summary>
        ''' Initialize table object
        ''' </summary>
        ''' <param name="TableAliasName"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal tableAliasName As String, ByVal streamReader As IO.StreamReader)
            _strTableAlias = tableAliasName
            If streamReader IsNot Nothing Then
                _strmreaderSchema = streamReader
            End If
            FetchTableDetails()
        End Sub
        ''' <summary>
        ''' Assign the table object with parameters from the resource file
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function FetchTableDetails() As Boolean
            Dim resourceManager As ResourceManager
            Try
                resourceManager = SqlCETableStructures.ResourceManager()
                _strTableName = resourceManager.GetString(_strTableAlias & "TableName")
                _strCommodityType = resourceManager.GetString(_strTableAlias & "CommodityName")
                _blnUploadApplicable = Convert.ToBoolean(resourceManager.GetString(_strTableAlias & "UploadApplicable"))
                _blnDownloadApplicable = Convert.ToBoolean(resourceManager.GetString(_strTableAlias & "DownloadApplicable"))
                '_strCreateCommand = resourceManager.GetString(_strTableName & "CreateCommand")
                _strSelectCommand = resourceManager.GetString(_strTableAlias & "SelectCommand")
                _strIndexCommand = resourceManager.GetString(_strTableAlias & "IndexCommand")
                ''''''
                _strInsertCommand = resourceManager.GetString(_strTableAlias & "InsertCommand")
                ''''''
                _strUpdateCommand = resourceManager.GetString(_strTableAlias & "UpdateCommand")
                _strUpdateNonOvveridingCommand = resourceManager.GetString(_strTableAlias & "UpdateNonOverridingCommand")
                '''''
                _strDeleteCommand = resourceManager.GetString(_strTableAlias & "DeleteCommand")
                _blnIsScanApplicable = Convert.ToBoolean(resourceManager.GetString(_strTableAlias & "ScanApplicable"))
                _strInsertNewRecordCommandBlindUpdate = resourceManager.GetString(_strTableAlias & "InsertNewRecordCommandBlindUpdate")
                _strDeleteNewRecordCommandBlindUpdate = resourceManager.GetString(_strTableAlias & "DeleteNewRecordCommandBlindUpdate")
                _strInsertOnlyNewerServerRecordsCommand = resourceManager.GetString(_strTableAlias & "InsertOnlyNewerServerRecordsCommand")
                _strDeleteOnlyNewerServerRecordsCommand = resourceManager.GetString(_strTableAlias & "DeleteOnlyNewerServerRecordsCommand")
                _strSelectNonOverridingFieldsCommand = resourceManager.GetString(_strTableAlias & "SelectNonOverridingFieldsCommand")
                _strSkipRecordsCommand = resourceManager.GetString(_strTableAlias & "SkipRecordsCommand")
                _strSelectTempRecordsCommand = resourceManager.GetString(_strTableAlias & "SelectTempRecordsCommand")
                _strDeleteTempRecordsCommand = resourceManager.GetString(_strTableAlias & "DeleteTempRecordsCommand")

                'Add table object to the table list
                If Not _dicTables.ContainsKey(_strTableName) Then
                    _dicTables.Add(_strTableName, Me)
                End If
                'Add upload applicable tables to upload list
                If _blnUploadApplicable Then
                    _lstUploadTables.Add(_strTableName)
                End If
                'Add download applicable tables to download list
                If _blnDownloadApplicable Then
                    _lstDownloadTables.Add(_strTableName)
                End If
                'Add scan applicable tables to scan list
                If _blnIsScanApplicable Then
                    _lstScanApplicableTables.Add(_strTableName)
                End If
                SyncManager.MessageLogging("Fetching table details", LogType.Information, "FetchTableDetails")
                Return True
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
            End Try
        End Function

        ''' <summary>
        ''' Get Table Name
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property Name() As String
            Get
                Return _strTableName
            End Get
        End Property
        ''' <summary>
        ''' Get Table Alias
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property TableAlias() As String
            Get
                Return _strTableAlias
            End Get
        End Property
        ''' <summary>
        ''' Get Commodity Type
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property CommodityType() As String
            Get
                Return _strCommodityType
            End Get
        End Property
        ''' <summary>
        ''' Get table object is applicable for Upload operation
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property IsUploadApplicable() As String
            Get
                Return _blnUploadApplicable
            End Get
        End Property
        ''' <summary>
        ''' Get table object is applicable for Download operation
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property IsDownloadApplicable() As String
            Get
                Return _blnDownloadApplicable
            End Get
        End Property

        'Public ReadOnly Property CreateCommand() As String
        '    Get
        '        Return _strCreateCommand
        '    End Get
        'End Property
        ''' <summary>
        ''' Select command of the table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property SelectCommand() As String
            Get
                Return _strSelectCommand
            End Get
        End Property
        ''' <summary>
        ''' Index command of the table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property IndexCommand() As String
            Get
                Return _strIndexCommand
            End Get
        End Property
        ''' <summary>
        ''' Insert command of the table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property InsertCommand() As String
            Get
                Return _strInsertCommand
            End Get
            Set(ByVal value As String)
                _strInsertCommand = value
            End Set
        End Property
        ''' <summary>
        ''' Update command of the table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property UpdateCommand() As String
            Get
                Return _strUpdateCommand
            End Get
            Set(ByVal value As String)
                _strUpdateCommand = value
            End Set
        End Property
        ''' <summary>
        ''' Delete command of the table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DeleteCommand() As String
            Get
                Return _strDeleteCommand
            End Get
            Set(ByVal value As String)
                _strDeleteCommand = value
            End Set
        End Property
        ''' <summary>
        ''' Table schema
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Schema() As IO.StreamReader
            Get
                Return _strmreaderSchema
            End Get
            Set(ByVal value As IO.StreamReader)
                _strmreaderSchema = value
            End Set
        End Property
        ''' <summary>
        ''' Table Object
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared ReadOnly Property TableObject(ByVal TableName As String) As TableStructure
            Get
                If _dicTables.ContainsKey(TableName) Then
                    Return _dicTables(TableName)
                End If
                Return Nothing
            End Get
        End Property
        ''' <summary>
        ''' Get list of Tables applicable to Upload operation
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared ReadOnly Property UploadTables() As List(Of String)
            Get
                Return _lstUploadTables
                Return Nothing
            End Get
        End Property
        ''' <summary>
        ''' Get list of Tables applicable to Download operation
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared ReadOnly Property DownloadTables() As List(Of String)
            Get
                Return _lstDownloadTables
                Return Nothing
            End Get
        End Property
        ''' <summary>
        ''' Get if the object has a barcode scan applicable
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property IsScanApplicable() As Boolean
            Get
                Return _blnIsScanApplicable
            End Get
        End Property
        ''' <summary>
        ''' Blind Insert SqlCE Command
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property InsertNewRecordBlindUpdate() As String
            Get
                Return _strInsertNewRecordCommandBlindUpdate
            End Get
        End Property
        ''' <summary>
        ''' Delete new records from temp
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property DeleteNewRecordBlindUpdate() As String
            Get
                Return _strDeleteNewRecordCommandBlindUpdate
            End Get
        End Property
        ''' <summary>
        ''' Insert command, newer records from server
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property InsertOnlyNewerServerRecords() As String
            Get
                Return _strInsertOnlyNewerServerRecordsCommand
            End Get
        End Property
        ''' <summary>
        ''' Delete command, newer records on temp table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property DeleteOnlyNewerServerRecords() As String
            Get
                Return _strDeleteOnlyNewerServerRecordsCommand
            End Get
        End Property
        ''' <summary>
        ''' Select only non ovverriding fields command
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property SelectNonOverridingFields() As String
            Get
                Return _strSelectNonOverridingFieldsCommand
            End Get
        End Property
        ''' <summary>
        ''' Skip records command from temp table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property SkipRecords() As String
            Get
                Return _strSkipRecordsCommand
            End Get
        End Property
        ''' <summary>
        ''' Select command from temp table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property SelectTempRecords() As String
            Get
                Return _strSelectTempRecordsCommand
            End Get
        End Property
        ''' <summary>
        ''' Delete command from temp table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property DeleteTempRecords() As String
            Get
                Return _strDeleteTempRecordsCommand
            End Get
        End Property
    End Class
End Namespace