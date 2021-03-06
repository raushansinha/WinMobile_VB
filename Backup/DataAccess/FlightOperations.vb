Imports System.Xml
Imports System.Data.SqlServerCe
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.BO

Namespace NWA.Safetrac.Scanner.DataAccess
    ''' <summary>
    ''' Contains methods to perform Flight related operations with the local SQL CE database
    ''' </summary>
    ''' <remarks></remarks>
    Public Module FlightOperations

#Region "VARIABLES"

        ''' <summary>
        ''' SqlCe connection object
        ''' </summary>
        ''' <remarks></remarks>
        Private _objSqlCeCon As SqlCeConnection
        ''' <summary>
        ''' SqlCe command object
        ''' </summary>
        ''' <remarks></remarks>
        Private _objSqlCeCmd As SqlCeCommand
        ''' <summary>
        ''' SqlCe connection string
        ''' </summary>
        ''' <remarks></remarks>
        Private _strConStr As String

        Sub New()
            _strConStr = "data source=" & ConfigManager.SqlceURL
            _objSqlCeCon = New SqlCeConnection(_strConStr)
            _objSqlCeCon.Open()
        End Sub

#End Region

#Region "BIN BULK METHODS"

#Region "BIN BULK GENERIC METHODS"

        Public Function GetBagCountOfBin(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
         ByVal binBulkNo As String) As Integer
            Dim strSql As String
            Try
                strSql = "select count(*)  from T_Bag_Tag where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and POS_NUM = '" & binBulkNo & "'"
                Return SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql)
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try

        End Function

        Public Function GetMailCountOfBin(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
       ByVal binBulkNo As String) As Integer
            Dim strSql As String
            Try
                strSql = "select count(*)  from T_Mail where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and POS_ID = '" & binBulkNo & "'"
                Return SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql)
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function GetFreightCountOfBin(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNo As String) As Integer
            Dim strSql As String
            Try
                strSql = "select count(*)  from T_Freight where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and POS_NUM = '" & binBulkNo & "'"
                Return SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql)
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try

        End Function

        Public Function GetBagsWeightOfBin(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
       ByVal binBulkNo As String) As Integer
            Dim strSql As String
            Try
                If GetBagCountOfBin(flightNum, departureDate, binBulkNo) > 0 Then
                    strSql = "select sum(bag_wt_lb) as weight  from T_Bag_Tag where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and"
                    strSql = strSql & "  FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and POS_NUM = '" & binBulkNo & "'"
                    Return SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql)
                Else
                    Return 0
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function GetMailsWeightOfBin(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNo As String) As Integer
            Dim strSql As String
            Try
                If GetMailCountOfBin(flightNum, departureDate, binBulkNo) > 0 Then
                    strSql = "select sum(TOT_WT_LB)  from T_Mail where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = '" & flightNum.Substring(2).Trim.Trim & "' and "
                    strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and POS_ID = '" & binBulkNo & "'"
                    Return SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql)
                Else
                    Return 0
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function GetFreightWeightOfBin(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNo As String) As Integer
            Dim strSql As String
            Try
                If GetFreightCountOfBin(flightNum, departureDate, binBulkNo) > 0 Then
                    strSql = "select sum(ITM_WT_LB)  from T_Freight where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                    strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and POS_NUM = '" & binBulkNo & "'"
                    Return SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql)
                Else
                    Return 0
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function GetTotalWeightOfBin(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNo As String) As Integer
            Try
                Return (GetBagsWeightOfBin(flightNum, departureDate, binBulkNo) + GetMailsWeightOfBin(flightNum, departureDate, binBulkNo) + GetFreightWeightOfBin(flightNum, departureDate, binBulkNo))
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        'Public Function GetBinBulkSummary(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        'ByVal binBulkNum As String) As DataSet
        '    Dim ds As New DataSet
        '    Dim dc As New DataColumn("BinBulk")
        '    Dim dc1 As New DataColumn("bags")
        '    Dim dc2 As New DataColumn("mails")
        '    Dim dc3 As New DataColumn("freights")
        '    Dim dc4 As New DataColumn("mailwt")
        '    Dim dc5 As New DataColumn("freightwt")
        '    ds.Tables.Add("BinSummary")
        '    ds.Tables(0).Columns.Add(dc)
        '    ds.Tables(0).Columns.Add(dc1)
        '    ds.Tables(0).Columns.Add(dc2)
        '    ds.Tables(0).Columns.Add(dc3)
        '    ds.Tables(0).Columns.Add(dc4)
        '    ds.Tables(0).Columns.Add(dc5)

        '    ds.Tables(0).Rows.Add()
        '    ds.Tables(0).Rows(0)("BinBulk") = binBulkNum
        '    ds.Tables(0).Rows(0)("bags") = GetBagCountOfBin(flightNum, departureDate, binBulkNum)
        '    ds.Tables(0).Rows(0)("mails") = GetMailCountOfBin(flightNum, departureDate, binBulkNum)
        '    ds.Tables(0).Rows(0)("freights") = GetFreightCountOfBin(flightNum, departureDate, binBulkNum)
        '    ds.Tables(0).Rows(0)("mailwt") = GetMailsWeightOfBin(flightNum, departureDate, binBulkNum)
        '    ds.Tables(0).Rows(0)("freightwt") = GetFreightWeightOfBin(flightNum, departureDate, binBulkNum)
        '    Return ds
        'End Function

        Public Function GetAllBinBulksSummary(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
       ByVal IsWideBody As Boolean) As DataSet
            Try
                Dim ds As New DataSet, bin As Integer, bulk As Integer, row As Integer = 0
                Dim dc As New DataColumn("BinBulk")
                Dim dc1 As New DataColumn("bags")
                Dim dc2 As New DataColumn("mails")
                Dim dc3 As New DataColumn("freights")
                Dim dc4 As New DataColumn("mailwt")
                Dim dc5 As New DataColumn("freightwt")
                ds.Tables.Add("BinSummary")
                ds.Tables(0).Columns.Add(dc)
                ds.Tables(0).Columns.Add(dc1)
                ds.Tables(0).Columns.Add(dc2)
                ds.Tables(0).Columns.Add(dc3)
                ds.Tables(0).Columns.Add(dc4)
                ds.Tables(0).Columns.Add(dc5)
                If IsWideBody Then
                    For bulk = 51 To 54
                        ds.Tables(0).Rows.Add()
                        ds.Tables(0).Rows(row)("BinBulk") = bulk
                        ds.Tables(0).Rows(row)("bags") = GetBagCountOfBin(flightNum, departureDate, bin)
                        ds.Tables(0).Rows(row)("mails") = GetMailCountOfBin(flightNum, departureDate, bin)
                        ds.Tables(0).Rows(row)("freights") = GetFreightCountOfBin(flightNum, departureDate, bin)
                        ds.Tables(0).Rows(row)("mailwt") = GetMailsWeightOfBin(flightNum, departureDate, bin)
                        ds.Tables(0).Rows(row)("freightwt") = GetFreightWeightOfBin(flightNum, departureDate, bin)
                        row = row + 1
                    Next
                    Return ds
                Else
                    For bin = 1 To 4
                        ds.Tables(0).Rows.Add()
                        ds.Tables(0).Rows(bin - 1)("BinBulk") = bin
                        ds.Tables(0).Rows(bin - 1)("bags") = GetBagCountOfBin(flightNum, departureDate, bin)
                        ds.Tables(0).Rows(bin - 1)("mails") = GetMailCountOfBin(flightNum, departureDate, bin)
                        ds.Tables(0).Rows(bin - 1)("freights") = GetFreightCountOfBin(flightNum, departureDate, bin)
                        ds.Tables(0).Rows(bin - 1)("mailwt") = GetMailsWeightOfBin(flightNum, departureDate, bin)
                        ds.Tables(0).Rows(bin - 1)("freightwt") = GetFreightWeightOfBin(flightNum, departureDate, bin)
                    Next
                    Return ds
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function IsBinBulkLoaded(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                                    ByVal binBulkNum As String) As Boolean
            Try
                If GetBagCountOfBin(flightNum, departureDate, binBulkNum) > 0 _
                Or GetMailCountOfBin(flightNum, departureDate, binBulkNum) > 0 _
                Or GetFreightCountOfBin(flightNum, departureDate, binBulkNum) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function IsMailAlreadyLoadedIntoBin(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                               ByVal binbulkNum As String, ByVal mailNum As String) As ReturnCodes
            'is bag already loaded into this bin bulk number
            Try
                Dim strSql As String
                strSql = "select count(*) from T_Mail where MAIL_BRCD_ID = '" & mailNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and POS_ID = '" & binbulkNum & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsMailAlreadyLoadedIntoBin = ReturnCodes.Ok
                Else
                    IsMailAlreadyLoadedIntoBin = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsMailAlreadyLoadedIntoBin = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsMailAlreadyLoadedIntoBin = ReturnCodes.Exception
            End Try
        End Function

        Public Function IsBagAlreadyLoadedIntoBin(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                      ByVal binBulkNum As String, ByVal bagTagNum As String) As ReturnCodes
            'is bag already loaded into this bin bulk number
            Try
                Dim strSql As String
                strSql = "select count(*) from T_Bag_Tag where bag_id= '" & bagTagNum & "' and LD_STATS_CDE =  'Y'  and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and POS_NUM = '" & binBulkNum & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsBagAlreadyLoadedIntoBin = ReturnCodes.Ok
                Else
                    IsBagAlreadyLoadedIntoBin = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsBagAlreadyLoadedIntoBin = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsBagAlreadyLoadedIntoBin = ReturnCodes.Exception
            End Try
        End Function

        Public Function IsFreightLoaded(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                            ByVal freightNum As String) As ReturnCodes
            'is freight already loaded 
            Try
                Dim strSql As String
                strSql = "select count(*) from T_Freight where AWB_NUM= '" & freightNum & "' and LOAD_IND =  'Y'  and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsFreightLoaded = ReturnCodes.Ok
                Else
                    IsFreightLoaded = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsFreightLoaded = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsFreightLoaded = ReturnCodes.Exception
            End Try
        End Function
        Public Function IsFreightAlreadyLoadedIntoBin(ByVal flightNum As String, ByVal departureDate As NWADateTime, ByVal binbulkNum As String, ByVal freightNum As String) As ReturnCodes

            'is freight already loaded into this bin bulk number
            Try
                Dim strSql As String
                strSql = "select count(*) from T_Freight where AWB_NUM = '" & freightNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and pos_num = '" & binbulkNum & "' and LOAD_IND='Y'"
                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsFreightAlreadyLoadedIntoBin = ReturnCodes.Ok
                Else
                    IsFreightAlreadyLoadedIntoBin = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsFreightAlreadyLoadedIntoBin = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsFreightAlreadyLoadedIntoBin = ReturnCodes.Exception
            End Try
        End Function
#End Region

#Region "BIN BULK LOAD METHODS"

        Public Function InsertBagForBinBulk(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNum As String, ByVal bagTagNum As String) As ReturnCodes
            Try
                Dim strSqlInsert As String
                strSqlInsert = "Insert into T_Bag_Tag (OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM,BAG_ID,LD_AUTH_IND,LD_STATS_CDE,OFLD_IND,XPDT_IND,POS_NUM,TRKG_IND,SCANNED_TIME,MODIFIED_TIME )"
                strSqlInsert &= "Values('" & flightNum.Substring(0, 2).Trim & "','" & flightNum.Substring(2).Trim & "','"
                strSqlInsert &= departureDate.SqlDateFormat & "','" & bagTagNum & "','Y','Y','N','N','" & binBulkNum & "','N',getdate(),getdate())"


                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlInsert) > 0 Then
                    InsertBagForBinBulk = ReturnCodes.Ok
                Else
                    InsertBagForBinBulk = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                InsertBagForBinBulk = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                InsertBagForBinBulk = ReturnCodes.Unknown
            End Try
        End Function

        Public Function LoadBagToBinBulk(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNum As String, ByVal bagTagNum As String) As ReturnCodes
            Try
                Dim strSqlUpdate As String
                strSqlUpdate = "update  T_Bag_Tag set pos_num = '" & binBulkNum & "',LD_STATS_CDE='Y',TRKG_IND='N',"
                strSqlUpdate = strSqlUpdate & " scanned_time = getdate() where "
                strSqlUpdate = strSqlUpdate & " BAG_ID = '" & bagTagNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSqlUpdate = strSqlUpdate & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlUpdate) > 0 Then
                    LoadBagToBinBulk = ReturnCodes.Ok
                Else
                    LoadBagToBinBulk = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadBagToBinBulk = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadBagToBinBulk = ReturnCodes.Unknown
            End Try
        End Function

        Public Function LoadBagToBinBulk(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNum As String, ByVal bagTagNum As String, ByVal weight As String) As ReturnCodes
            'pending - include weight in the query
            Try
                Dim strSqlUpdate As String
                strSqlUpdate = "update  T_Bag_Tag set pos_num = '" & binBulkNum & "',LD_STATS_CDE='Y',TRKG_IND='N',"
                strSqlUpdate = strSqlUpdate & " scanned_time = getdate() where "
                strSqlUpdate = strSqlUpdate & " BAG_ID = '" & bagTagNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSqlUpdate = strSqlUpdate & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlUpdate) > 0 Then
                    LoadBagToBinBulk = ReturnCodes.Ok
                Else
                    LoadBagToBinBulk = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadBagToBinBulk = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadBagToBinBulk = ReturnCodes.Unknown
            End Try
        End Function

        Public Function InsertMailForBinBulk(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                ByVal binBulkNum As String, ByVal mailNum As String) As ReturnCodes
            Try
                Dim strSqlInsert As String

                strSqlInsert = "Insert into T_Mail (MAIL_BRCD_ID,OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM,POS_ID,CMDTY_TYP_CDE,SCANNED_TIME,MODIFIED_TIME) "
                strSqlInsert &= "Values ('" & mailNum & "','" & flightNum.Substring(0, 2).Trim & "','"
                strSqlInsert &= flightNum.Substring(2).Trim & "','" & departureDate.SqlDateFormat & "','"
                strSqlInsert &= binBulkNum & " ','MAIL',getdate(),getdate())"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlInsert) > 0 Then
                    InsertMailForBinBulk = ReturnCodes.Ok
                Else
                    InsertMailForBinBulk = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                InsertMailForBinBulk = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                InsertMailForBinBulk = ReturnCodes.Unknown
            End Try
        End Function

        Public Function LoadMailToBinBulk(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNum As String, ByVal mailNum As String) As ReturnCodes
            Try
                Dim strSqlUpdate As String

                strSqlUpdate = "update T_Mail set pos_id = '" & binBulkNum & "', "
                strSqlUpdate &= " scanned_time = getdate() where MAIL_BRCD_ID = '" & mailNum & "' and "
                strSqlUpdate &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSqlUpdate &= " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlUpdate) > 0 Then
                    LoadMailToBinBulk = ReturnCodes.Ok
                Else
                    LoadMailToBinBulk = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadMailToBinBulk = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadMailToBinBulk = ReturnCodes.Unknown
            End Try
        End Function

        ''' <summary>
        ''' Load mail to Bin/Bulk of the Flight
        ''' </summary>
        Public Function LoadMailToBinBulk(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal BinBulkNum As String, ByVal mailNum As String, ByVal mailType As String, _
        ByVal weight As Double, ByVal pieceCount As Integer, ByVal finalDestination As String) As ReturnCodes
            Try
                Dim strSqlUpdate As String
                strSqlUpdate = "update  T_Mail set pos_id = '" & BinBulkNum & "', CMDTY_TYP_CDE='" & mailType & "',"
                strSqlUpdate = strSqlUpdate & " ITM_CNT ='" & pieceCount & "', TOT_WT_LB= '" & weight & "', FNL_DEST_AP_CDE ='" & finalDestination & "',"
                strSqlUpdate = strSqlUpdate & " scanned_time = getdate()"
                strSqlUpdate = strSqlUpdate & " where MAIL_BRCD_ID = '" & mailNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSqlUpdate = strSqlUpdate & "FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlUpdate) > 0 Then
                    LoadMailToBinBulk = ReturnCodes.Ok
                Else
                    LoadMailToBinBulk = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadMailToBinBulk = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadMailToBinBulk = ReturnCodes.Unknown
            End Try
        End Function

        Public Function LoadUnknownBagToBinBulk(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
         ByVal binBulkNum As String, ByVal bagTagNum As String) As ReturnCodes
            'insert a new bagtag recordd with default values - for PBM Loading
            Try
                Dim strSqlInsert As String
                strSqlInsert = "Insert into T_Bag_Tag (OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM,BAG_ID,LD_AUTH_IND,LD_STATS_CDE,OFLD_IND,XPDT_IND,POS_NUM,TRKG_IND,SCANNED_TIME,MODIFIED_TIME )"
                strSqlInsert &= "Values('" & flightNum.Substring(0, 2).Trim & "','" & flightNum.Substring(2).Trim & "','"
                strSqlInsert &= departureDate.SqlDateFormat & "','" & bagTagNum & "','Y','Y','N','N','" & binBulkNum & "','N',getdate(),getdate())"


                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlInsert) > 0 Then
                    LoadUnknownBagToBinBulk = ReturnCodes.Ok
                Else
                    LoadUnknownBagToBinBulk = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadUnknownBagToBinBulk = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadUnknownBagToBinBulk = ReturnCodes.Unknown
            End Try

        End Function

        Public Function LoadUnknownBagToBinBulk(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNum As String, ByVal bagTagNum As String, ByVal expediteCode As String) As ReturnCodes
            'insert a new bagtag recordd along with expedite code and default values
            Try
                Dim strSqlInsert As String
                strSqlInsert = "Insert into T_Bag_Tag (OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM,BAG_ID,LD_AUTH_IND,LD_STATS_CDE,OFLD_IND,XPDT_IND,POS_NUM,TRKG_IND,SCANNED_TIME,MODIFIED_TIME )"
                strSqlInsert &= "Values('" & flightNum.Substring(0, 2).Trim & "','" & flightNum.Substring(2).Trim & "','"
                strSqlInsert &= departureDate.SqlDateFormat & "','" & bagTagNum & "','Y','Y','N','" & expediteCode & "','" & binBulkNum & "','N',getdate(),getdate())"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlInsert) > 0 Then
                    LoadUnknownBagToBinBulk = ReturnCodes.Ok
                Else
                    LoadUnknownBagToBinBulk = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadUnknownBagToBinBulk = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadUnknownBagToBinBulk = ReturnCodes.Unknown
            End Try
        End Function

        Public Function LoadFreightToBinBulk(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNum As String, ByVal freightNum As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update  T_Freight set pos_num = '" & binBulkNum & "',LOAD_IND='Y',LOAD_SEQ_NUM=0, "
                strSql = strSql & " scanned_time = getdate() where AWB_NUM = '" & freightNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    LoadFreightToBinBulk = ReturnCodes.Ok
                Else
                    LoadFreightToBinBulk = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadFreightToBinBulk = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadFreightToBinBulk = ReturnCodes.Unknown
            End Try
        End Function
        Public Function LoadFreightToBinBulk(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
              ByVal binBulkNum As String, ByVal freightNum As String, ByVal finalDest As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update  T_Freight set pos_num = '" & binBulkNum & "',LOAD_IND='Y',LOAD_SEQ_NUM=0,FNL_DEST_AP_CDE='" & finalDest & "',"
                strSql = strSql & " scanned_time = getdate() where AWB_NUM = '" & freightNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    LoadFreightToBinBulk = ReturnCodes.Ok
                Else
                    LoadFreightToBinBulk = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadFreightToBinBulk = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadFreightToBinBulk = ReturnCodes.Unknown
            End Try
        End Function
        Public Function LoadExpediteFreight(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
             ByVal binBulkNum As String, ByVal freightNum As String, ByVal finalDest As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update  T_Freight set pos_num = '" & binBulkNum & "',LOAD_IND='Y',LOAD_SEQ_NUM=0,FNL_DEST_AP_CDE='" & finalDest & "',XPDT_IND='Y'"
                strSql = strSql & " scanned_time = getdate() where AWB_NUM = '" & freightNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    LoadExpediteFreight = ReturnCodes.Ok
                Else
                    LoadExpediteFreight = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadExpediteFreight = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadExpediteFreight = ReturnCodes.Unknown
            End Try
        End Function

        Public Function LoadAnimalToBinBulk(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNum As String, ByVal animalNum As String, ByVal weight As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update  T_Bag_Tag set pos_num = '" & binBulkNum & "', weight = '" & weight & "',"
                strSql = strSql & "  scanned_time = getdate() where BAG_ID = '" & animalNum & "' and "
                strSql = strSql & " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    LoadAnimalToBinBulk = ReturnCodes.Ok
                Else
                    LoadAnimalToBinBulk = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadAnimalToBinBulk = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadAnimalToBinBulk = ReturnCodes.Unknown
            End Try
        End Function

        Public Function LoadDamagedBagToBinBulk(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNum As String, ByVal bagTagNum As String, ByVal weight As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update  T_Bag_Tag set pos_num = '" & binBulkNum & "', DMGD_IND = 'Y', "
                strSql = strSql & " scanned_time = getdate() where BAG_ID = '" & bagTagNum & "' and "
                strSql = strSql & " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    LoadDamagedBagToBinBulk = ReturnCodes.Ok
                Else
                    LoadDamagedBagToBinBulk = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadDamagedBagToBinBulk = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadDamagedBagToBinBulk = ReturnCodes.Unknown
            End Try
        End Function

        Public Function LoadDamagedBagToContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal containerNum As String, ByVal bagTagNum As String, ByVal weight As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update  T_Bag_Tag set CNTNR_SEQ_NUM = '" & containerNum & "', DMGD_IND = 'Y', "
                strSql = strSql & " scanned_time = getdate() where BAG_ID = '" & bagTagNum & "' and "
                strSql = strSql & " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    LoadDamagedBagToContainer = ReturnCodes.Ok
                Else
                    LoadDamagedBagToContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadDamagedBagToContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadDamagedBagToContainer = ReturnCodes.Unknown
            End Try
        End Function

        ''' <summary>
        ''' Expedite a bag for loading
        ''' </summary>
        Public Function LoadExpediteBag(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNum As String, ByVal bagTagNum As String, ByVal expediteCode As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update  T_Bag_Tag set pos_num = '" & binBulkNum & "', XPDT_IND = 'Y', OP_AL_CDE= '" & flightNum.Substring(0, 2) & "', OP_FLT_NUM = " & flightNum.Substring(2).Trim & ","
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "', scanned_time = getdate() where BAG_ID = '" & bagTagNum & "'"
                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    LoadExpediteBag = ReturnCodes.Ok
                Else
                    LoadExpediteBag = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadExpediteBag = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadExpediteBag = ReturnCodes.Unknown
            End Try
        End Function
        Public Function LoadExpediteFreight(ByVal flightNum As String, ByVal departureDate As NWADateTime, ByVal binBulkNum As String, ByVal freightNum As String) As ReturnCodes

            Try
                Dim strSql As String
                strSql = "update T_Freight set pos_num = '" & binBulkNum & "',LOAD_IND='Y',LOAD_SEQ_NUM=0,XPDT_IND='Y' ,OP_AL_CDE= '" & flightNum.Substring(0, 2) & "', OP_FLT_NUM = " & flightNum.Substring(2).Trim & ","
                strSql = strSql & " scanned_time = getdate(), FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' where AWB_NUM = '" & freightNum & "'"
                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    LoadExpediteFreight = ReturnCodes.Ok
                Else
                    LoadExpediteFreight = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadExpediteFreight = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadExpediteFreight = ReturnCodes.Unknown
            End Try
        End Function
        '>>>>>>>>>>>>>>>>>PENDING<<<<<<<<<<<<<<<<<<<<<<
        Public Function AddLateBag(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNum As String, ByVal commdType As String, ByVal count As String, ByVal weight As String, _
        ByVal finalDestination As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "insert into T_Line_Item "
                strSql &= "(LIN_ITEM_SEQ_NUM,OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM,POS_NUM,CMDTY_TYP_CDE,"
                strSql &= "FNL_DEST_AP_CD,WF_CGO_WT_LBS,WF_CGO_PCS_CNT) values "
                strSql &= " ('L" & Now.ToString("ddhhmmss") & "', '" & flightNum.Substring(0, 2) & "', '" & flightNum.Substring(2) & "',"
                strSql &= " '" & departureDate.SqlDateFormat & "', '" & binBulkNum & "', '" & commdType & "',"
                strSql &= " '" & finalDestination & "', '" & weight & "', '" & count & "')"
                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    Return ReturnCodes.Ok
                Else
                    Return ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                AddLateBag = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                AddLateBag = ReturnCodes.Unknown
            End Try
        End Function

#End Region

#Region "BIN BULK UNLOAD METHODS"
        Public Function UnloadBagFromBinBulk(ByVal FlightNum As String, ByVal departureDate As NWADateTime, _
                ByVal bagTagNum As String, ByVal destination As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update  T_Bag_Tag set pos_num = '',cntnr_id= NULL,cntnr_seq_num = NULL,LD_STATS_CDE='O',scanned_time = getdate() where BAG_ID = '" & bagTagNum & "' and OP_AL_CDE = '" & FlightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & FlightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"
                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    UnloadBagFromBinBulk = ReturnCodes.Ok
                Else
                    UnloadBagFromBinBulk = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                UnloadBagFromBinBulk = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                UnloadBagFromBinBulk = ReturnCodes.Unknown
            End Try
        End Function
        ''' <summary>
        ''' Unload mail from the Bin/Bulk of the Flight
        ''' </summary>
        Public Function UnloadMailFromBinBulk(ByVal FlightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkNum As String, ByVal mailNum As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update  T_Mail set pos_id = '', scanned_time = getdate() where MAIL_BRCD_ID = '" & mailNum & "' and OP_AL_CDE = '" & FlightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & FlightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"
                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    UnloadMailFromBinBulk = ReturnCodes.Ok
                Else
                    UnloadMailFromBinBulk = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                UnloadMailFromBinBulk = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                UnloadMailFromBinBulk = ReturnCodes.Unknown
            End Try
        End Function
        Public Function PositionLineItem(ByVal FlightNum As String, ByVal departureDate As NWADateTime, _
        ByVal positionNum As String, ByVal lineItemSeqNum As String) As ReturnCodes

            Try
                Dim strSql As String
                If positionNum = "XX" Then
                    strSql = "update  T_Line_Item set POS_NUM = ''where LIN_ITEM_SEQ_NUM = '" & lineItemSeqNum & "' "
                    strSql &= " and OP_AL_CDE = '" & FlightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & FlightNum.Substring(2).Trim & " "
                    strSql &= " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"
                    If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                        PositionLineItem = ReturnCodes.Ok
                    Else
                        PositionLineItem = ReturnCodes.NotOk
                    End If
                Else
                    strSql = "update  T_Line_Item set POS_NUM = '" & positionNum & "'where LIN_ITEM_SEQ_NUM = '" & lineItemSeqNum & "' "
                    strSql &= " and OP_AL_CDE = '" & FlightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & FlightNum.Substring(2).Trim & " "
                    strSql &= " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"
                    If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                        PositionLineItem = ReturnCodes.Ok
                    Else
                        PositionLineItem = ReturnCodes.NotOk
                    End If
                End If
            Catch exSql As SqlCeException
                PositionLineItem = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                PositionLineItem = ReturnCodes.Unknown
            End Try
        End Function
        Public Function PositionLineItem(ByVal FlightNum As String, ByVal departureDate As NWADateTime, _
        ByVal positionNum As String, ByVal lineItemSeqNum As String, ByVal reason As String) As ReturnCodes

            Try
                Dim strSql As String
                strSql = "update  T_Line_Item set POS_NUM = ''where LIN_ITEM_SEQ_NUM = '" & lineItemSeqNum & "',RMK_TXT='" & reason & "'"
                strSql &= " and OP_AL_CDE = '" & FlightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & FlightNum.Substring(2).Trim & " "
                strSql &= " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"
                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    PositionLineItem = ReturnCodes.Ok
                Else
                    PositionLineItem = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                PositionLineItem = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                PositionLineItem = ReturnCodes.Unknown
            End Try
        End Function
        Public Function UnloadFreight(ByVal FlightNum As String, ByVal DepartureDate As NWADateTime, _
             ByVal AWBNumber As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update T_Freight set LOAD_IND='O',LOAD_SEQ_NUM= NULL where AWB_NUM = '" & AWBNumber & "' "
                strSql &= " and OP_AL_CDE = '" & FlightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & FlightNum.Substring(2).Trim & " and "
                strSql &= " FLT_SCHED_DTM = '" & DepartureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    UnloadFreight = ReturnCodes.Ok
                Else
                    UnloadFreight = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                UnloadFreight = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                UnloadFreight = ReturnCodes.Unknown
            End Try
        End Function

#End Region

#End Region

#Region "CONTAINER METHODS"

#Region "CONTAINER GENERIC METHODS"

        Public Function AddContainers(ByVal containersData As DataSet) As Boolean
            Try
                If SqlCeHelper.UpdateTable("T_Container", containersData) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch exSql As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function IsContainerLoaded(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                        ByVal containerNum As String) As Boolean
            Try
                If GetBagCountOfContainer(flightNum, departureDate, containerNum) > 0 _
                Or GetMailCountOfContainer(flightNum, departureDate, containerNum) > 0 _
                Or GetFreightCountOfContainer(flightNum, departureDate, containerNum) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function IsContainerClosed(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                   ByVal containerNum As String) As Boolean
            Try
                Dim strSql As String
                strSql = "select count(*)  from T_Container where CNTNR_SEQ_NUM = '" & containerNum & "'and CNTNR_STATS_CDE='C' and "
                strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                strSql = strSql & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' "
                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function
        Public Function IsContainerRegistered(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                           ByVal containerNum As String) As Boolean
            Try
                Dim strSql As String
                strSql = "select count(*)  from T_Container where CNTNR_SEQ_NUM = '" & containerNum & "'and CNTNR_ID is not null and "
                strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                strSql = strSql & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' "
                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function IsMailAlreadyLoadedIntoContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                                           ByVal containerNum As String, ByVal mailNum As String) As ReturnCodes
            'is bag already loaded into this bin bulk number
            Try
                Dim strSql As String
                strSql = "select count(*) from T_Mail where MAIL_BRCD_ID = '" & mailNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and CNTNR_SEQ_NUM = '" & containerNum & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsMailAlreadyLoadedIntoContainer = ReturnCodes.Ok
                Else
                    IsMailAlreadyLoadedIntoContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsMailAlreadyLoadedIntoContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsMailAlreadyLoadedIntoContainer = ReturnCodes.Exception
            End Try
        End Function

        Public Function IsBagAlreadyLoadedIntoContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                        ByVal containerNum As String, ByVal bagTagNum As String) As ReturnCodes
            'is bag already loaded into this bin bulk number

            Try
                Dim strSql As String
                strSql = "select count(*) from T_Bag_Tag where bag_id= '" & bagTagNum & "' and LD_STATS_CDE =  'Y'  and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql &= " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and CNTNR_SEQ_NUM = '" & containerNum & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsBagAlreadyLoadedIntoContainer = ReturnCodes.Ok
                Else
                    IsBagAlreadyLoadedIntoContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsBagAlreadyLoadedIntoContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsBagAlreadyLoadedIntoContainer = ReturnCodes.Exception
            End Try
        End Function

        'get container num based upon container name for the specified flight
        Public Function GetContainerNum(ByVal flightNum As String, ByVal flightDate As NWADateTime, _
        ByVal containerName As String) As String
            Dim strSql As String, dr As SqlCeDataReader
            strSql = "select CNTNR_SEQ_NUM  from T_Container where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim.Trim & "' and OP_FLT_NUM = '" & flightNum.Substring(2).Trim.Trim & "' and "
            strSql = strSql & " FLT_SCHED_DTM = '" & flightDate.SqlDateFormat & "' and CNTNR_ID = '" & containerName & "'"

            dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
            If dr.Read() Then
                Return dr(0).ToString
            Else
                Return Nothing
            End If
            Return Nothing
        End Function

        'get container name based upon container number for the specified flight
        Public Function GetContainerName(ByVal flightNum As String, ByVal flightDate As NWADateTime, _
        ByVal containerNum As String) As String
            Dim strSql As String, dr As SqlCeDataReader
            strSql = "select CNTNR_ID from T_Container where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
            strSql = strSql & " FLT_SCHED_DTM = '" & flightDate.SqlDateFormat & "' and CNTNR_SEQ_NUM = '" & containerNum & "'"

            dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
            If dr.Read() Then
                Return dr(0).ToString
            Else
                Return Nothing
            End If
            Return Nothing
            Return Nothing
        End Function

        Public Function GetContainerType(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                            ByVal containerNum As String) As String
            Try
                Dim strSql As String
                strSql = "select CNTNR_TYP_CDE  from T_Container where CNTNR_SEQ_NUM = '" & containerNum & "' and "
                strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                strSql = strSql & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' "
                Return (SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql))
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try

        End Function
        Public Function GetContainerOrigin(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                                   ByVal containerNum As String) As String
            Try
                Dim strSql As String
                strSql = "select AP_CDE  from T_Container where CNTNR_SEQ_NUM = '" & containerNum & "' and "
                strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                strSql = strSql & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' "
                Return (SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql))
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function
        Public Function GetContainerDestination(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                            ByVal containerNum As String) As String
            Try
                Dim strSql As String
                strSql = "select FNL_DEST_AP_CDE  from T_Container where CNTNR_SEQ_NUM = '" & containerNum & "' and "
                strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                strSql = strSql & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' "
                Return (SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql))
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try

        End Function

        Public Function GetContainerFinalDestination(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                          ByVal containerNum As String) As String
            Try
                Dim strSql As String
                strSql = "select FNL_DEST_AP_CDE  from T_Container where CNTNR_SEQ_NUM = '" & containerNum & "'and "
                strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                strSql = strSql & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' "
                Return (SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql))
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function GetContainerEstimatedDepartureTime(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                            ByVal containerNum As String) As String
            Try
                Dim strSql As String
                strSql = "select FNL_DEST_AP_CDE  from T_Container where CNTNR_SEQ_NUM = '" & containerNum & "'and "
                strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                strSql = strSql & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' "
                Return (SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql))
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        'Public Function GetContainerFinalDestination(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        '            ByVal containerNum As String) As String

        'End Function

        Public Function GetContainerPosition(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                    ByVal containerNum As String) As String
            Try
                Dim strSql As String
                strSql = "select POS_NUM  from T_Container where CNTNR_SEQ_NUM = '" & containerNum & "'and "
                strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                strSql = strSql & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' "
                Return (SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql))
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function GetBagCountOfContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
         ByVal containerNum As String) As Integer
            Try
                Dim strSql As String
                strSql = "select count(*)  from T_Bag_Tag where CNTNR_SEQ_NUM = '" & containerNum & "'and "
                strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                strSql = strSql & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' "
                Return (SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql))
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function GetMailCountOfContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
       ByVal containerNum As String) As Integer
            Try
                Dim strSql As String
                strSql = "select count(*)  from T_Mail where CNTNR_SEQ_NUM = '" & containerNum & "'and "
                strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                strSql = strSql & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' "
                Return (SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql))
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function GetFreightCountOfContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal containerNum As String) As Integer
            Dim strSql As String
            Try
                strSql = "select count(*)  from T_Freight where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and CNTNR_SEQ_NUM = '" & containerNum & "'"
                Return SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql)
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try

        End Function

        Public Function GetBagsWeightOfContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
       ByVal containerNum As String) As Integer
            Try
                Dim strSql As String
                If GetBagCountOfContainer(flightNum, departureDate, containerNum) > 0 Then
                    strSql = "select sum(BAG_WT_LB)  from T_Bag_Tag where CNTNR_SEQ_NUM = '" & containerNum & "'and "
                    strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                    strSql = strSql & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' "
                    Return (SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql))
                Else
                    Return 0
                End If
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function GetMailsWeightOfContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal containerNum As String) As Integer
            Try
                Dim strSql As String
                If GetMailCountOfContainer(flightNum, departureDate, containerNum) > 0 Then
                    strSql = "select sum(TOT_WT_LB)  from T_Mail where CNTNR_SEQ_NUM = '" & containerNum & "'and "
                    strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                    strSql = strSql & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' "
                    Return (SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql))
                Else
                    Return 0
                End If
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function GetFreightWeightOfContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal containerNum As String) As Integer
            Try
                Dim strSql As String
                If GetFreightCountOfContainer(flightNum, departureDate, containerNum) > 0 Then
                    strSql = "select sum(ITM_WT_LB)  from T_Freight where CNTNR_SEQ_NUM = '" & containerNum & "'and "
                    strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                    strSql = strSql & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' "
                    Return (SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql))
                Else
                    Return 0
                End If
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function GetTotalWeightOfContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal containerNum As String) As Integer
        End Function

        ''' <summary>
        ''' Position container on the flight
        ''' </summary>
        Public Function PositionContainer(ByVal containerSheetNum As String, ByVal flightNum As String, _
                ByVal departureDate As NWADateTime, ByVal position As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update T_Container set POS_NUM = '" & position & "', "
                strSql = strSql & " where CNTNR_SEQ_NUM = '" & containerSheetNum & "' and "
                strSql = strSql & " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    PositionContainer = ReturnCodes.Ok
                Else
                    PositionContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                PositionContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                PositionContainer = ReturnCodes.Unknown
            End Try
        End Function

        ''' <summary>
        ''' Associate an ULD with an Container Sheet Number
        ''' </summary>
        Public Function RegisterContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal containerNum As String, ByVal containerName As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update T_Container set CNTNR_ID = '" & containerName & "', "
                strSql = strSql & " where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and "
                strSql = strSql & " CNTNR_SEQ_NUM = '" & containerNum & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    RegisterContainer = ReturnCodes.Ok
                Else
                    RegisterContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                RegisterContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                RegisterContainer = ReturnCodes.Unknown
            End Try
        End Function

        Public Function ChangeContainerDefinition(ByVal containerSheetNum As String, ByVal destination As String, _
                  ByVal containerType As String) As ReturnCodes
            Try
                Dim strSql As String
                If destination <> " " And containerType <> " " Then
                    strSql = "update T_Container set FNL_DEST_AP_CDE = '" & destination & "', "
                    strSql = strSql & " CNTNR_TYP_CDE = '" & containerType & "', "
                    strSql = strSql & " scanned_time = getdate() where CNTNR_ID = '" & containerSheetNum & "'"
                ElseIf destination <> " " Then
                    strSql = "update T_Container set FNL_DEST_AP_CDE = '" & destination & "', "
                    strSql = strSql & " scanned_time = getdate() "
                    strSql = strSql & " where CNTNR_ID = '" & containerSheetNum & "'"
                Else
                    strSql = "update T_Container set CNTNR_TYP_CDE = '" & containerType & "',"
                    strSql = strSql & "  scanned_time = getdate()"
                    strSql = strSql & "  where CNTNR_ID = '" & containerSheetNum & "'"
                End If

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    ChangeContainerDefinition = ReturnCodes.Ok
                Else
                    ChangeContainerDefinition = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                ChangeContainerDefinition = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                ChangeContainerDefinition = ReturnCodes.Unknown
            End Try
        End Function

        ''' <summary>
        ''' Close a container
        ''' </summary>
        Public Function CloseContainer(ByVal flightNum As String, _
        ByVal departureDate As NWADateTime, ByVal containerNum As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update T_Container set CNTNR_STATS_CDE = 'C', "
                strSql = strSql & " scanned_time = getdate() where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and "
                strSql = strSql & " CNTNR_SEQ_NUM = '" & containerNum & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    CloseContainer = ReturnCodes.Ok
                Else
                    CloseContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                CloseContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                CloseContainer = ReturnCodes.Unknown
            End Try
        End Function

        ''' <summary>
        ''' Reopen an container
        ''' </summary>
        Public Function ReopenContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal containerSheetNum As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update T_Container set CNTNR_STATS_CDE = 'O', "
                strSql = strSql & " scanned_time = getdate() where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' and "
                strSql = strSql & " CNTNR_SEQ_NUM = '" & containerSheetNum & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    ReopenContainer = ReturnCodes.Ok
                Else
                    ReopenContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                Return ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                Return ReturnCodes.Unknown
            End Try

        End Function
        Public Function MergeContainers(ByVal fromFlightNum As String, ByVal fromFlightDate As NWADateTime, _
               ByVal fromMerge As String, ByVal toFlightNum As String, ByVal toFlightDate As NWADateTime, _
               ByVal toMerge As String, ByVal mergeType As String, ByVal pieceCount As String) As ReturnCodes
            Try
                Dim strSql As String = String.Empty, fromUldNum As String = String.Empty, toUldNum As String = String.Empty
                Dim strSqlMail As String = String.Empty, strSqlFreight As String = String.Empty

                If fromMerge.Length = 13 Then
                    fromUldNum = GetContainerName(fromFlightNum, fromFlightDate, fromMerge)
                End If
                If toMerge.Length = 13 Then
                    toUldNum = GetContainerName(fromFlightNum, fromFlightDate, fromMerge)
                End If

                If mergeType = "ALL" Then

                    If toUldNum <> String.Empty Then
                        If fromUldNum <> String.Empty Then
                            strSql = "update T_Bag_Tag set CNTNR_ID = '" & toUldNum & " ,CNTNR_SEQ_NUM = '" & toMerge & "', POS_NUM='', "
                            strSql &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSql &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSql &= " where CNTNR_ID = '" & fromUldNum & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSql &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSql &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"

                            strSqlMail = "update T_Mail set CNTNR_SEQ_NUM = '" & toMerge & "', POS_ID='', "
                            strSqlMail &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlMail &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlMail &= " where CNTNR_SEQ_NUM = '" & fromUldNum & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlMail &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlMail &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"

                            strSqlFreight = "update T_Freight set CNTNR_SEQ_NUM = '" & toMerge & "', POS_NUM='', "
                            strSqlFreight &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlFreight &= " where CNTNR_SEQ_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlFreight &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"

                        Else
                            strSql = "update T_Bag_Tag set CNTNR_ID = '" & toUldNum & " ,CNTNR_SEQ_NUM = '" & toMerge & "', POS_NUM='', "
                            strSql &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSql &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSql &= " where POS_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSql &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSql &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"

                            strSqlMail = "update T_Mail set CNTNR_SEQ_NUM = '" & toMerge & "', POS_ID='', "
                            strSqlMail &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlMail &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlMail &= " where POS_ID = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlMail &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlMail &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"

                            strSqlFreight = "update T_Freight set CNTNR_SEQ_NUM = '" & toMerge & "', POS_NUM='', "
                            strSqlFreight &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlFreight &= " where POS_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlFreight &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"
                        End If
                    Else
                        If fromUldNum <> String.Empty Then
                            strSql = "update T_Bag_Tag set POS_NUM = '" & toMerge & "', CNTNR_ID='', CNTNR_SEQ_NUM = NULL , "
                            strSql &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSql &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSql &= " where CNTNR_ID = '" & fromUldNum & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSql &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSql &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"

                            strSqlMail = "update T_Mail set POS_ID = '" & toMerge & "',CNTNR_SEQ_NUM = NULL , "
                            strSqlMail &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlMail &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlMail &= " where CNTNR_SEQ_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlMail &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlMail &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"

                            strSqlFreight = "update T_Freight set POS_NUM = '" & toMerge & "',CNTNR_SEQ_NUM = NULL , "
                            strSqlFreight &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlFreight &= " where CNTNR_SEQ_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlFreight &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"
                        Else
                            strSql = "update T_Bag_Tag set POS_NUM = '" & toMerge & "',  CNTNR_ID='', CNTNR_SEQ_NUM = NULL , "
                            strSql &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSql &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSql &= " where POS_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSql &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSql &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"

                            strSqlMail = "update T_Mail set POS_ID = '" & toMerge & "', CNTNR_SEQ_NUM = NULL , "
                            strSqlMail &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlMail &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlMail &= " where POS_ID = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlMail &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlMail &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"

                            strSqlFreight = "update T_Bag_Tag set POS_NUM = '" & toMerge & "',CNTNR_SEQ_NUM = NULL , "
                            strSqlFreight &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlFreight &= " where POS_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlFreight &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"

                        End If
                    End If
                    If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 _
                    And SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlMail) > 0 _
                    And SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlFreight) > 0 Then
                        Return ReturnCodes.Ok
                    Else
                        Return ReturnCodes.NotOk
                    End If
                ElseIf mergeType = "BAG" Then
                    Dim dr As SqlCeDataReader
                    Dim rowCount As Integer
                    If toUldNum <> String.Empty Then
                        If fromUldNum <> String.Empty Then
                            strSql = "select bag_id from T_Bag_Tag "
                            strSql &= " where CNTNR_ID = '" & fromUldNum & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSql &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSql &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "' order by SCANNED_TIME desc"
                            dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                            For rowCount = 0 To pieceCount - 1
                                If (dr.Read()) Then
                                    strSql = "update T_Bag_Tag set CNTNR_ID = '" & toUldNum & " ,CNTNR_SEQ_NUM = '" & toMerge & "', POS_NUM='', "
                                    strSql &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                                    strSql &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                                    strSql &= " where bag_id= '" & dr("bag_id") & "', CNTNR_ID = '" & fromUldNum & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                                    strSql &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                                    strSql &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"
                                End If
                            Next
                        Else
                            strSql = "select bag_id from T_Bag_Tag "
                            strSql &= " where POS_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSql &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSql &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "' order by SCANNED_TIME desc"
                            dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                            For rowCount = 0 To pieceCount - 1
                                If (dr.Read()) Then
                                    strSql = "update T_Bag_Tag set CNTNR_ID = '" & toUldNum & " ,CNTNR_SEQ_NUM = '" & toMerge & "', POS_NUM='', "
                                    strSql &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                                    strSql &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                                    strSql &= " where bag_id= '" & dr("bag_id") & "', POS_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                                    strSql &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                                    strSql &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"
                                End If
                            Next
                        End If
                    Else
                        If fromUldNum <> String.Empty Then

                            strSql = "select bag_id from T_Bag_Tag "
                            strSql &= " where CNTNR_ID = '" & fromUldNum & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSql &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSql &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "' order by SCANNED_TIME desc"
                            dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                            For rowCount = 0 To pieceCount - 1
                                If (dr.Read()) Then
                                    strSql = "update T_Bag_Tag set POS_NUM = '" & toMerge & "', CNTNR_ID='', CNTNR_SEQ_NUM = NULL , "
                                    strSql &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                                    strSql &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                                    strSql &= " where bag_id= '" & dr("bag_id") & "',CNTNR_ID = '" & fromUldNum & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                                    strSql &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                                    strSql &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"
                                End If
                            Next
                        Else
                            strSql = "select bag_id from T_Bag_Tag "
                            strSql &= " where POS_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSql &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSql &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'  order by SCANNED_TIME desc"
                            dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                            For rowCount = 0 To pieceCount - 1
                                If (dr.Read()) Then
                                    strSql = "update T_Bag_Tag set POS_NUM = '" & toMerge & "',  CNTNR_ID='', CNTNR_SEQ_NUM = NULL , "
                                    strSql &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                                    strSql &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                                    strSql &= " where bag_id= '" & dr("bag_id") & "', POS_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                                    strSql &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                                    strSql &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"
                                End If
                            Next
                        End If
                    End If
                ElseIf mergeType = "MAIL" Then
                    If toUldNum <> String.Empty Then
                        If fromUldNum <> String.Empty Then
                            strSqlMail = "update T_Mail set CNTNR_SEQ_NUM = '" & toMerge & "', POS_ID='', "
                            strSqlMail &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlMail &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlMail &= " where CNTNR_SEQ_NUM = '" & fromUldNum & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlMail &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlMail &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"
                        Else
                            strSqlMail = "update T_Mail set CNTNR_SEQ_NUM = '" & toMerge & "', POS_ID='', "
                            strSqlMail &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlMail &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlMail &= " where POS_ID = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlMail &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlMail &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"
                        End If
                    Else
                        If fromUldNum <> String.Empty Then
                            strSqlMail = "update T_Mail set POS_ID = '" & toMerge & "',CNTNR_SEQ_NUM = NULL , "
                            strSqlMail &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlMail &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlMail &= " where CNTNR_SEQ_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlMail &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlMail &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"
                        Else
                            strSqlMail = "update T_Mail set POS_ID = '" & toMerge & "', CNTNR_SEQ_NUM = NULL , "
                            strSqlMail &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlMail &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlMail &= " where POS_ID = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlMail &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlMail &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"
                        End If
                    End If
                    If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                        Return ReturnCodes.Ok
                    Else
                        Return ReturnCodes.NotOk
                    End If
                Else
                    If toUldNum <> String.Empty Then
                        If fromUldNum <> String.Empty Then
                            strSqlFreight = "update T_Freight set CNTNR_SEQ_NUM = '" & toMerge & "', POS_NUM='', "
                            strSqlFreight &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlFreight &= " where CNTNR_SEQ_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlFreight &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"
                        Else
                            strSqlFreight = "update T_Freight set CNTNR_SEQ_NUM = '" & toMerge & "', POS_NUM='', "
                            strSqlFreight &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlFreight &= " where POS_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlFreight &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"
                        End If
                    Else
                        If fromUldNum <> String.Empty Then

                            strSqlFreight = "update T_Freight set POS_NUM = '" & toMerge & "',CNTNR_SEQ_NUM = NULL , "
                            strSqlFreight &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlFreight &= " where CNTNR_SEQ_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlFreight &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"
                        Else
                            strSqlFreight = "update T_Bag_Tag set POS_NUM = '" & toMerge & "',CNTNR_SEQ_NUM = NULL , "
                            strSqlFreight &= " OP_AL_CDE = '" & toFlightNum.Substring(0, 2) & "' ,OP_FLT_NUM = '" & toFlightNum.Substring(2) & "', "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & toFlightDate.SqlDateFormat & "'"
                            strSqlFreight &= " where POS_NUM = '" & fromMerge & "' and OP_AL_CDE = '" & fromFlightNum.Substring(0, 2).Trim & "' and "
                            strSqlFreight &= " OP_FLT_NUM = '" & fromFlightNum.Substring(2).Trim & "' and "
                            strSqlFreight &= " FLT_SCHED_DTM = '" & fromFlightDate.SqlDateFormat & "'"
                        End If
                    End If
                    If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                        Return ReturnCodes.Ok
                    Else
                        Return ReturnCodes.NotOk
                    End If
                End If
            Catch exSql As SqlCeException
                Return ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                Return ReturnCodes.Unknown
            End Try
        End Function
#End Region

#Region "CONTAINER LOAD METHODS"

        Public Function InsertBagForContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal containerNum As String, ByVal bagtagNum As String) As ReturnCodes
            Try
                Dim strSqlInsert As String

                strSqlInsert = "Insert into T_Bag_Tag (OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM,BAG_ID,LD_AUTH_IND,LD_STATS_CDE,OFLD_IND,XPDT_IND,CNTNR_SEQ_NUM,TRKG_IND,SCANNED_TIME,MODIFIED_TIME )"
                strSqlInsert &= "Values('" & flightNum.Substring(0, 2).Trim & "','" & flightNum.Substring(0, 2).Trim & "','"
                strSqlInsert &= departureDate.SqlDateFormat & "','" & bagtagNum & "','Y','Y','N','N','" & containerNum & "','N',getdate(),getdate())"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlInsert) > 0 Then
                    InsertBagForContainer = ReturnCodes.Ok
                Else
                    InsertBagForContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                InsertBagForContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                InsertBagForContainer = ReturnCodes.Unknown
            End Try
        End Function

        ''' <summary>
        ''' Load bag to container of the Flight
        ''' </summary>
        Public Function LoadBagToContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal containerNum As String, ByVal bagtagNum As String) As ReturnCodes
            Try
                Dim strSqlUpdate As String
                strSqlUpdate = "update  T_Bag_Tag set CNTNR_SEQ_NUM = '" & containerNum & "',LD_STATS_CDE='Y',TRKG_IND='N',"
                strSqlUpdate = strSqlUpdate & " scanned_time = getdate() where "
                strSqlUpdate = strSqlUpdate & " BAG_ID = '" & bagtagNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSqlUpdate = strSqlUpdate & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlUpdate) > 0 Then
                    LoadBagToContainer = ReturnCodes.Ok
                    '    ElseIf SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlInsert) > 0 Then

                Else
                    LoadBagToContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadBagToContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadBagToContainer = ReturnCodes.Unknown
            End Try
        End Function

        Public Function LoadBagToContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal containerNum As String, ByVal bagtagNum As String, ByVal weight As String) As ReturnCodes
            'include weight as loading
            Try
                Dim strSqlUpdate As String
                strSqlUpdate = "update  T_Bag_Tag set CNTNR_SEQ_NUM = '" & containerNum & "',LD_STATS_CDE='Y',TRKG_IND='N',"
                strSqlUpdate = strSqlUpdate & " scanned_time = getdate() where "
                strSqlUpdate = strSqlUpdate & " BAG_ID = '" & bagtagNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSqlUpdate = strSqlUpdate & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlUpdate) > 0 Then
                    LoadBagToContainer = ReturnCodes.Ok
                    '  ElseIf SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlInsert) > 0 Then

                Else
                    LoadBagToContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadBagToContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadBagToContainer = ReturnCodes.Unknown
            End Try

        End Function

        Public Function InsertMailForContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
              ByVal containerSheetNum As String, ByVal mailNum As String) As ReturnCodes
            Try
                Dim strSqlInsert As String

                strSqlInsert = "Insert into T_Mail (MAIL_BRCD_ID,OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM,CNTNR_SEQ_NUM,CMDTY_TYP_CDE,SCANNED_TIME,MODIFIED_TIME) "
                strSqlInsert &= "Values ('" & mailNum & "','" & flightNum.Substring(0, 2).Trim & "','"
                strSqlInsert &= flightNum.Substring(0, 2).Trim & "','" & departureDate.SqlDateFormat & "','"
                strSqlInsert &= containerSheetNum & " ','MAIL',getdate(),getdate())"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlInsert) > 0 Then
                    InsertMailForContainer = ReturnCodes.Ok
                Else
                    InsertMailForContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                InsertMailForContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                InsertMailForContainer = ReturnCodes.Unknown
            End Try
        End Function

        Public Function LoadMailToContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
              ByVal containerSheetNum As String, ByVal mailNum As String) As ReturnCodes
            Try
                Dim strSqlUpdate As String
                strSqlUpdate = "update  T_Mail set CNTNR_SEQ_NUM = '" & containerSheetNum & "', "
                strSqlUpdate = strSqlUpdate & " scanned_time = getdate() where MAIL_BRCD_ID = '" & mailNum & "' and "
                strSqlUpdate = strSqlUpdate & "OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlUpdate) > 0 Then
                    LoadMailToContainer = ReturnCodes.Ok
                    '    ElseIf SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlInsert) > 0 Then
                Else
                    LoadMailToContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadMailToContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadMailToContainer = ReturnCodes.Unknown
            End Try
        End Function

        ''' <summary>
        ''' To load a mail to the container
        ''' </summary>
        Public Function LoadMailToContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal containerSheetNum As String, ByVal mailNum As String, ByVal mailType As String, _
        ByVal weight As Double, ByVal pieceCount As Integer, ByVal finalDestination As String) As ReturnCodes
            Try
                Dim strSqlUpdate As String
                strSqlUpdate = "update  T_Mail set CNTNR_SEQ_NUM = '" & containerSheetNum & "', CMDTY_TYP_CDE='" & mailType & "',"
                strSqlUpdate = strSqlUpdate & " ITM_CNT ='" & pieceCount & "', TOT_WT_LB= '" & weight & "', FNL_DEST_AP_CDE ='" & finalDestination & "',"
                strSqlUpdate = strSqlUpdate & " DEST_AP_CDE = '" & finalDestination & "',scanned_time = getdate()"
                strSqlUpdate = strSqlUpdate & " where MAIL_BRCD_ID = '" & mailNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSqlUpdate = strSqlUpdate & "FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlUpdate) > 0 Then
                    LoadMailToContainer = ReturnCodes.Ok
                    '                ElseIf SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlInsert) > 0 Then
                Else
                    LoadMailToContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadMailToContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadMailToContainer = ReturnCodes.Unknown
            End Try
        End Function

        Public Function LoadUnknownBagToContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
    ByVal containerNum As String, ByVal bagTagNum As String) As ReturnCodes
            'insert a new bagtag recordd with default values
            Try
                Dim strSqlInsert As String

                strSqlInsert = "Insert into T_Bag_Tag (OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM,BAG_ID,LD_AUTH_IND,LD_STATS_CDE,OFLD_IND,XPDT_IND,CNTNR_SEQ_NUM,TRKG_IND,SCANNED_TIME,MODIFIED_TIME )"
                strSqlInsert &= "Values('" & flightNum.Substring(0, 2).Trim & "','" & flightNum.Substring(0, 2).Trim & "','"
                strSqlInsert &= departureDate.SqlDateFormat & "','" & bagTagNum & "','Y','Y','N','N','" & containerNum & "','N',getdate(),getdate())"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlInsert) > 0 Then
                    LoadUnknownBagToContainer = ReturnCodes.Ok
                Else
                    LoadUnknownBagToContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadUnknownBagToContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadUnknownBagToContainer = ReturnCodes.Unknown
            End Try
        End Function

        Public Function LoadUnknownBagToContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal containerNum As String, ByVal bagTagNum As String, ByVal expediteCode As String) As ReturnCodes
            'insert a new bagtag recordd along with expedite code and default values
            Try
                Dim strSqlInsert As String

                strSqlInsert = "Insert into T_Bag_Tag (OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM,BAG_ID,LD_AUTH_IND,LD_STATS_CDE,OFLD_IND,XPDT_IND,CNTNR_SEQ_NUM,TRKG_IND,SCANNED_TIME,MODIFIED_TIME )"
                strSqlInsert &= "Values('" & flightNum.Substring(0, 2).Trim & "','" & flightNum.Substring(0, 2).Trim & "','"
                strSqlInsert &= departureDate.SqlDateFormat & "','" & bagTagNum & "','Y','Y','N','" & expediteCode & "','" & containerNum & "','N',getdate(),getdate())"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSqlInsert) > 0 Then
                    LoadUnknownBagToContainer = ReturnCodes.Ok
                Else
                    LoadUnknownBagToContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadUnknownBagToContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadUnknownBagToContainer = ReturnCodes.Unknown
            End Try
        End Function

#End Region

#Region "CONTAINER UNLOAD METHODS"

        Public Function UnloadBagFromContainer(ByVal FlightNum As String, ByVal departureDate As NWADateTime, _
                        ByVal bagTagNum As String, ByVal destination As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update  T_Bag_Tag set CNTNR_SEQ_NUM = '',LD_STATS_CDE='O'"
                strSql = strSql & " ,scanned_time = getdate() where BAG_ID = '" & bagTagNum & "' and"
                strSql = strSql & " OP_AL_CDE = '" & FlightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & FlightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    UnloadBagFromContainer = ReturnCodes.Ok
                Else
                    UnloadBagFromContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                UnloadBagFromContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                UnloadBagFromContainer = ReturnCodes.Unknown
            End Try
        End Function

        ''' <summary>
        ''' Unload mail from container
        ''' </summary>
        Public Function UnloadMailFromContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
            ByVal containerSheetNum As String, ByVal mailNum As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update  T_Mail set CNTNR_SEQ_NUM = NULL,scanned_time = getdate()"
                strSql = strSql & "  where MAIL_BRCD_ID = '" & mailNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = '"
                strSql = strSql & flightNum.Substring(0, 2).Trim & "' and  FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    UnloadMailFromContainer = ReturnCodes.Ok
                Else
                    UnloadMailFromContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                UnloadMailFromContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                UnloadMailFromContainer = ReturnCodes.Unknown
            End Try
        End Function

#End Region

#End Region

#Region "COMMON METHODS"

        ''' <summary>
        ''' Retrieve bag tag information from the local database
        ''' </summary>
        ''' <param name="bagtagNum"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function RetrieveBagtagInfo(ByVal bagtagNum As String) As DataSet
            Try
                Dim strSql As String, ds As New DataSet
                strSql = "select *  from T_Bag_Tag where BAG_ID = '" & bagtagNum & "'"
                Return (SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql))
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        ''' <summary>
        ''' Retrieve Container Information
        ''' </summary>
        ''' <param name="containerSheetNum"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function RetrieveContainerInfo(ByVal containerSheetNum As String) As DataSet
            Try
                Dim strSql As String, ds As New DataSet
                strSql = "select *  from T_Container where CNTNR_SEQ_NUM = '" & containerSheetNum & "'"

                Return (SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql))
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        ''' <summary>
        ''' Retrieve information for the Mail
        ''' </summary>
        Public Function GetMailInfo(ByVal mailNum As String) As DataSet
            Try
                Dim strSql As String, ds As New DataSet
                strSql = "select *  from T_Mail where MAIL_BRCD_ID = '" & mailNum & "'"

                Return (SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql))
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        ''' <summary>
        ''' Validates bagtag
        ''' </summary>
        Public Function IsBagTagValid(ByVal BagTag As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "select count(*)  from T_Bag_Tag where BAG_ID = '" & BagTag & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsBagTagValid = ReturnCodes.Ok
                Else
                    IsBagTagValid = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsBagTagValid = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsBagTagValid = ReturnCodes.Unknown
            End Try
        End Function

        Public Function IsMailValid(ByVal mailNum As String) As Boolean
            Try
                Dim strSql As String
                strSql = "select count(*)  from T_Mail where MAIL_BRCD_ID = '" & mailNum & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsMailValid = ReturnCodes.Ok
                Else
                    IsMailValid = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsMailValid = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsMailValid = ReturnCodes.Unknown
            End Try
        End Function

        ''' <summary>
        ''' Validates the container number
        ''' </summary>
        Public Function IsContainerNumValid(ByVal containerNum As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "select CNTNR_SEQ_NUM  from T_Container where CNTNR_SEQ_NUM = '" & containerNum & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsContainerNumValid = ReturnCodes.Ok
                Else
                    IsContainerNumValid = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsContainerNumValid = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsContainerNumValid = ReturnCodes.Unknown
            End Try
        End Function

        ''' <summary>
        ''' Validates the container name
        ''' </summary>
        Public Function IsContainerNameValid(ByVal containerName As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "select CNTNR_ID  from T_Container where CNTNR_ID = '" & containerName & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsContainerNameValid = ReturnCodes.Ok
                Else
                    IsContainerNameValid = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsContainerNameValid = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsContainerNameValid = ReturnCodes.Unknown
            End Try
        End Function

        'get container num based upon container name
        Public Function GetContainerNum(ByVal containerName As String) As String
            Try
                Dim strSql As String, dr As SqlCeDataReader
                strSql = "select CNTNR_SEQ_NUM  from T_Container where CNTNR_ID = '" & containerName & "'"

                dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                If dr.Read() Then
                    Return dr(0).ToString
                Else
                    Return Nothing
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        'get container name based upon container number
        Public Function GetContainerName(ByVal containerNum As String) As String
            Try
                Dim strSql As String, dr As SqlCeDataReader
                strSql = "select CNTNR_ID  from T_Container where CNTNR_SEQ_NUM = '" & containerNum & "'"

                dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                If dr.Read() Then
                    Return dr(0).ToString
                Else
                    Return Nothing
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetFlightNumForBagtag(ByVal bagTag As String) _
        As NWAFlight
            Try
                Dim strSql As String, dr As SqlCeDataReader
                strSql = "select OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM  from T_Bag_TAG where BAG_ID = '" & bagTag & "'"

                dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                If dr.Read() Then
                    Dim objFlight As New NWAFlight(dr(0).ToString.Trim & dr(1).ToString.Trim, New NWADateTime(Convert.ToDateTime(dr(2))))
                    Return objFlight
                Else
                    Return Nothing
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        ''' <summary>
        ''' Return Flight information based upon the container name
        ''' </summary>
        Public Function GetFlightNumForContainerNum(ByVal containerSheetNum As String) _
        As NWAFlight
            Try
                Dim strSql As String, dr As SqlCeDataReader
                strSql = "select OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM  from T_Container where CNTNR_SEQ_NUM = '" & containerSheetNum & "'"

                dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                If dr.Read() Then
                    Dim objFlight As New NWAFlight(dr(0).ToString.Trim & dr(1).ToString.Trim, New NWADateTime(Convert.ToDateTime(dr(2))))
                    Return objFlight
                Else
                    Return Nothing
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        ''' <summary>
        ''' Return Flight information based upon the container name
        ''' </summary>
        Public Function GetFlightNumForContainerName(ByVal containerName As String) _
        As NWAFlight
            Try
                Dim strSql As String, dr As SqlCeDataReader
                strSql = "select OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM  from T_Container where CNTNR_ID = '" & containerName & "'"

                dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                If dr.Read() Then
                    Dim objFlight As New NWAFlight(dr(0).ToString.Trim & dr(1).ToString.Trim, New NWADateTime(Convert.ToDateTime(dr(2))))
                    Return objFlight
                Else
                    Return Nothing
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        ''' <summary>
        ''' Retrieve information for the Mail
        ''' </summary>
        Public Function GetFlightNumForMail(ByVal mailNum As String) As NWAFlight
            Try
                Dim strSql As String, dr As SqlCeDataReader
                strSql = "select OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM  from T_Mail where MAIL_BRCD_ID = '" & mailNum & "'"

                dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                If dr.Read() Then
                    Dim objFlight As New NWAFlight(dr(0).ToString.Trim & dr(1).ToString.Trim, New NWADateTime(Convert.ToDateTime(dr(2))))
                    Return objFlight
                Else
                    Return Nothing
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function GetFlightNumForFreight(ByVal freightNum As String) As NWAFlight
            Try
                Dim strSql As String, dr As SqlCeDataReader
                strSql = "select OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM  from T_Freight where AWB_NUM = '" & freightNum & "'"

                dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                If dr.Read() Then
                    Dim objFlight As New NWAFlight(dr(0).ToString.Trim & dr(1).ToString.Trim, New NWADateTime(Convert.ToDateTime(dr(2))))
                    Return objFlight
                Else
                    Return Nothing
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        ''' <summary>
        ''' Retrieve flight information from the local SQL CE database
        ''' </summary>
        Public Function RetrieveFlightInfo(ByVal flightNum As String, ByVal departureDate As NWADateTime) _
        As DataSet
            Try
                Dim strSql As String, ds As New DataSet
                strSql = "select *  from T_Container where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                Return (SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql))
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function IsDuplicateBagtag(ByVal bagTagNum As String) As Boolean
            Try
                Dim iCountDupBags As New Integer
                Dim strSql As String
                strSql = "select count(*) from T_Bag_Tag where BAG_ID = '" & bagTagNum & "'"
                iCountDupBags = SqlCeHelper.ExecuteScalar(_strConStr, CommandType.Text, strSql)
                If iCountDupBags > 1 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function GetDuplicateBagtags(ByVal bagTagNum As String) As DataSet
            Dim strSql As String, ds As New DataSet
            Try
                strSql = "select a.OP_AL_CDE ,a.OP_FLT_NUM,a.FLT_SCHED_DTM,b.PNR_NUM,b.LST_NME  from T_Bag_Tag a, "
                strSql = strSql & " T_Passenger_Config b where a.BAG_PSGR_SEQ_NUM = b.BAG_PSGR_SEQ_NUM and a.BAG_ID = '" & bagTagNum & "'"
                Return (SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql))
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError, " ", " ")
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown, " ", " ")
            End Try
        End Function

        Public Function GetFlightForBagTag(ByVal bagTagNum As String) As NWAFlight
            Dim objNWAFlight As New NWAFlight
            Try
                If IsDuplicateBagtag(bagTagNum) Then
                    Throw New SafetracException(ReturnCodes.BagtagDuplicatesFound)
                Else

                    Dim strSql As String
                    Dim dr As SqlCeDataReader
                    strSql = "select OP_AL_CDE,OP_FLT_NUM,FLT_SCHED_DTM from T_Bag_Tag where BAG_ID = '" & bagTagNum & "'"
                    dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                    If dr.Read() Then
                        'objNWAFlight.Number = dr(0)
                        'objNWAFlight.DepartureDate = New NWADateTime(Convert.ToDateTime(dr(1)))
                        objNWAFlight = New NWAFlight(dr(0).ToString.Trim & dr(1).ToString.Trim, New NWADateTime(Convert.ToDateTime(dr(2))))
                    Else
                        Throw New SafetracException(ReturnCodes.NotConfiguredFlight)
                    End If
                End If
            Catch exSql As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError, " ", " ")
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New SafetracException(ReturnCodes.Unknown, " ", " ")
            End Try
            'GetFlightForBagTag = objNWAFlight
            Return objNWAFlight
        End Function

        Public Function IsFreightValid(ByVal freightNum As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "select count(*)  from T_Freight where AWB_NUM = '" & freightNum & "'"
                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsFreightValid = ReturnCodes.Ok
                Else
                    IsFreightValid = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsFreightValid = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsFreightValid = ReturnCodes.Unknown
            End Try
        End Function

        Public Function IsFreightValid(ByVal flightNum As String, ByVal departureDate As NWADateTime, ByVal freightNum As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "select count(*)  from T_Freight where AWB_NUM = '" & freightNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' "
                strSql &= " and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql &= " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"
                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsFreightValid = ReturnCodes.Ok
                Else
                    IsFreightValid = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsFreightValid = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsFreightValid = ReturnCodes.Unknown
            End Try
        End Function

        Public Function IsFreightAlreadyLoaded(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                                  ByVal freightNum As String) As Boolean
            Try
                Dim strSql As String
                strSql = "select count(*)  from T_Freight where AWB_NUM = '" & freightNum & "' and LOAD_IND='Y'"
                strSql &= " and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql &= " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsFreightAlreadyLoaded = ReturnCodes.Ok
                Else
                    IsFreightAlreadyLoaded = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsFreightAlreadyLoaded = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsFreightAlreadyLoaded = ReturnCodes.Unknown
            End Try
        End Function
#End Region

#Region "FLIGHT METHODS"

        '>>>>>>>>>>>>>>>PENDING for UpdateTable method in SQLCeHelper<<<<<<<<<<<<<<<<<<<<<<


        '>>>>>>>>>>>>>>>PENDING for UpdateTable method in SQLCeHelper<<<<<<<<<<<<<<<<<<<<<<

        'Pending for field name to get Passanger Class

        Public Function GetPassengerClass(ByVal bagTagNum As String, _
        ByVal flightNum As String, ByVal departureDate As NWADateTime) As String
            Try
                Dim strSql As String, dr As SqlCeDataReader
                strSql = "select CBN_CL_CDE from T_Bag_Tag where BAG_ID = '" & bagTagNum & "' and "
                strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"
                dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                If dr.Read Then
                    Return dr(0)
                Else
                    Return String.Empty
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        ''' <summary>
        ''' Create a Container Sheet Number for the flight info provided by the user
        ''' </summary>
        Public Function CreateContainerSheetNum(ByVal containerType As String, _
        ByVal flightNum As String, ByVal departureDate As NWADateTime) As XmlElement

            Return Nothing
        End Function

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>PENDING<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        ''' <summary>
        ''' To check whether a valid position on the flight
        ''' </summary>
        Public Function IsPositionAvailable(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                 ByVal position As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update  BagTag set "
                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        ''' <summary>
        ''' Validats bagtag for the given flight
        ''' </summary>
        Public Function IsBagTagValid(ByVal flightNum As String, ByVal flightDate As NWADateTime, _
        ByVal bagTag As String) As ReturnCodes
            Try
                Dim strSql As String
                Dim retval As Object
                strSql = "select COUNT(*) from T_Bag_Tag where BAG_ID = '" & bagTag & "' and "
                strSql = strSql & " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & flightDate.SqlDateFormat & "'"

                retval = SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql)
                If retval > 0 Then
                    IsBagTagValid = ReturnCodes.Ok
                Else
                    IsBagTagValid = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsBagTagValid = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsBagTagValid = ReturnCodes.Unknown
            End Try
        End Function

        Public Function IsMailValid(ByVal flightNum As String, ByVal flightDate As NWADateTime, _
        ByVal mailNum As String) As Boolean
            Return True
        End Function

        ''' <summary>
        ''' Validates container number for the given flight
        ''' </summary>
        Public Function IsContainerNumValid(ByVal flightNum As String, ByVal flightDate As NWADateTime, _
        ByVal ContainerNum As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "select count(*)  from T_Container where CNTNR_SEQ_NUM = '" & ContainerNum & "' and "
                strSql = strSql & " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & flightDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsContainerNumValid = ReturnCodes.Ok
                Else
                    IsContainerNumValid = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsContainerNumValid = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsContainerNumValid = ReturnCodes.Unknown
            End Try
        End Function

        ''' <summary>
        ''' Validates container number for the given flight
        ''' </summary>
        Public Function IsContainerNameValid(ByVal flightNum As String, ByVal flightDate As NWADateTime, _
        ByVal ContainerName As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "select count(*)  from T_Container where CNTNR_ID = '" & ContainerName & "' and "
                strSql = strSql & " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & flightDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsContainerNameValid = ReturnCodes.Ok
                Else
                    IsContainerNameValid = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsContainerNameValid = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsContainerNameValid = ReturnCodes.Unknown
            End Try
        End Function

        ''' <summary>
        ''' Pre-close a flight
        ''' </summary>
        Public Function PrecloseFlight(ByVal flightNum As String, ByVal departureDate As NWADateTime, ByVal destination As String) As XmlElement
            Return Nothing
        End Function

        ''' <summary>
        ''' Remove a flight from local SQL Ce
        ''' </summary>
        Public Function RemoveFlight(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
              ByVal tableList As List(Of String)) As Boolean
            Dim strSql As String
            Dim strTableName As String
            Try
                For Each strTableName In tableList
                    strSql = "Delete from " & strTableName & " where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " AND FLT_SCHED_DTM ='" & departureDate.SqlDateFormat & "'"
                    If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) < 0 Then
                        Return False
                    End If
                Next
                Return True
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        ''' <summary>
        ''' Get the loose items of the flight
        ''' </summary>
        Public Function GetLineItems(ByVal flightNum As String, ByVal departureDate As NWADateTime) As DataSet
            Try
                Dim strSql As String
                strSql = "select LIN_ITEM_SEQ_NUM,POS_NUM,CMDTY_TYP_CDE,CNTNR_ID,WF_CGO_PCS_CNT,WF_CGO_WT_LBS,RMK_TXT from T_Line_Item where "
                strSql &= " OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                strSql = strSql & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "' order by POS_NUM"
                Return (SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql))
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function IsBagOnAlert(ByVal flightNum As String, ByVal departureDate As NWADateTime, ByVal bagtagNum As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "select count(*) from T_Bag_Tag where bag_id= '" & bagtagNum & "' and trkg_ind =  'Y'  and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsBagOnAlert = ReturnCodes.Ok
                Else
                    IsBagOnAlert = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsBagOnAlert = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsBagOnAlert = ReturnCodes.Exception
            End Try

        End Function

        ''' <summary>
        ''' Set a bag on alert
        ''' </summary>
        Public Function SetBagtagAlert(ByVal bagtagNum As String, ByVal flightNum As String, _
                ByVal departureDate As NWADateTime) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update T_Bag_Tag set trkg_ind =  'Y',scanned_time = getdate()"
                strSql = strSql & "  where BAG_ID = '" & bagtagNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    SetBagtagAlert = ReturnCodes.Ok
                Else
                    SetBagtagAlert = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                SetBagtagAlert = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                SetBagtagAlert = ReturnCodes.Exception
            End Try

        End Function

        ''' <summary>
        ''' Remove existing alert on a bag
        ''' </summary>
        Public Function RemoveBagtagAlert(ByVal bagtagNum As String, ByVal flightNum As String, _
                ByVal departureDate As NWADateTime) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update T_Bag_Tag set trkg_ind =  'N', scanned_time = getdate()"
                strSql = strSql & "  where BAG_ID = '" & bagtagNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    RemoveBagtagAlert = ReturnCodes.Ok
                Else
                    RemoveBagtagAlert = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                RemoveBagtagAlert = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                RemoveBagtagAlert = ReturnCodes.Exception
            End Try
        End Function

        ''' <summary>
        ''' Return list of bags on alert for the flight
        ''' </summary>
        Public Function GetBagsOnAlert(ByVal flightNum As String, ByVal departureDate As NWADateTime) _
        As DataSet
            Try
                Dim strSql As String
                strSql = "select BAG_ID from T_Bag_Tag  where trkg_ind = 'Y' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & "FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"
                Return (SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql))
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        '>>>>>>>>>>>>>>>>>>>>>PENDING<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        ''' <summary>
        ''' To create a container sheet number for the HUB based container
        ''' </summary>
        Public Function CreateHubContainerSheetNum(ByVal containerType As String, ByVal flightNum As String, _
                   ByVal destination As String, ByVal departureDate As NWADateTime, _
                   ByVal finalDestination As String, ByVal inWard As String, _
                   ByVal outWard As String) As XmlElement
            Return Nothing
        End Function

        ''' <summary>
        ''' Return bags to unload from a flight
        ''' </summary>
        Public Function GetBagsToUnload(ByVal flightNum As String, _
                ByVal departureDate As NWADateTime) As DataSet
            Dim dsp As New DataSet, dsc As New DataSet, dt As New DataTable
            Dim dsContainer As DataSet
            Dim strSql As String
            Try

                'Sorting by Destination
                strSql = "select distinct POS_NUM from T_BAG_TAG where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM='" & departureDate.SqlDateFormat & "' "
                strSql &= "AND ld_stats_cde  = 'Y' AND  ofld_ind = 'Y'"
                dsp = SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql)
                ' MsgBox("Bin/Bulk : " & dsp.Tables(0).Rows.Count)
                strSql = "select distinct CNTNR_ID from T_BAG_TAG where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM='" & departureDate.SqlDateFormat & "' "
                strSql &= "AND ld_stats_cde  = 'Y' AND  ofld_ind = 'Y'"
                '  MsgBox(strSql)
                dsContainer = SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql)
                '   MsgBox("container: " & dsContainer.Tables(0).Rows.Count)
                dt = dsContainer.Tables(0).Copy
                dt.TableName = "Container"
                dsp.Tables.Add(dt)
                strSql = "select Bag_Id,POS_NUM,CNTNR_ID from T_BAG_TAG"
                dsc = SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql)
                dt = dsc.Tables(0).Copy()
                dt.TableName = "Child"
                dsp.Tables(0).TableName = "Position"
                dsp.Tables.Add(dt)
                MsgBox(dsp.Tables.Count)
                If dsp.Tables(0).Rows.Count > 0 Then
                    dsp.Relations.Add("BagPosition", dsp.Tables("Position").Columns("POS_NUM"), _
                             dsp.Tables("Child").Columns("POS_NUM"), False)
                    dsp.Relations.Add("BagContainer", dsp.Tables("Container").Columns("CNTNR_ID"), _
                           dsp.Tables("Child").Columns("CNTNR_ID"), False)
                    Return dsp
                Else
                    Return Nothing
                End If
            Catch ex As SqlCeException
                Throw ex
            Catch ex As Exception
                Throw ex
            End Try

        End Function

        ''' <summary>
        ''' Unload bag from the flight
        ''' </summary>
        Public Function UnloadBag(ByVal bagtagNum As String, ByVal flightNum As String, _
              ByVal departureDate As NWADateTime) As ReturnCodes
            Dim strSql As String
            Dim intRet As Integer
            Try
                strSql = "update T_Bag_Tag set LD_STATS_CDE = 'O',POS_NUM='',CNTNR_ID=NULL,CNTNR_SEQ_NUM=NULL,LD_SEQ_NUM=0 "
                strSql &= " where BAG_ID= '" & bagtagNum & "' and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM='" & departureDate.SqlDateFormat & "'"
                intRet = SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql)
                If intRet > 0 Then
                    Return ReturnCodes.BagtagUnloaded
                End If
            Catch ex As SqlCeException
                UnloadBag = ReturnCodes.DatabaseError
            Catch ex As Exception
                UnloadBag = ReturnCodes.Unknown
            End Try

        End Function

        ''' <summary>
        ''' Unload freight from flight position
        ''' </summary>
        ''' <param name="AWBNumber"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        'Public Function UnloadFreight(ByVal AWBNumber As String) As Boolean
        '    Dim strSql As String
        '    strSql = "update  BagTag set "
        '    If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
        '        Return True
        '    Else
        '        Return False
        '    End If
        'End Function

        Public Function ExpectedDepartureTime(ByVal FlightNum As String, _
        ByVal DepartureDate As NWADateTime) As String
            Try
                Dim strSql As String, retString As String
                strSql = "select FLT_DPTR_DTM  from T_Flight_Info where "
                strSql &= " OP_AL_CDE = '" & FlightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & FlightNum.Substring(2).Trim & " "
                retString = SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql)
                If retString <> String.Empty Then
                    ExpectedDepartureTime = New NWADateTime(Convert.ToDateTime(retString)).NWATime
                Else
                    Return Nothing
                End If
            Catch sqlEx As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function IsFlightConfigured(ByVal flightNum As String, _
        ByVal departureDate As NWADateTime) As Boolean
            Try
                Dim strSql As String
                strSql = "select count(*)  from T_Flight_Info where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' "
                strSql = strSql & " and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsFlightConfigured = ReturnCodes.Ok
                Else
                    IsFlightConfigured = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsFlightConfigured = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsFlightConfigured = ReturnCodes.Unknown
            End Try
        End Function

        Public Function AddBinBulks(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        ByVal binBulkData As DataSet) As Boolean

        End Function

        Public Function GetConfiguredFlightBinBulks(ByVal flightNum As String, ByVal departureDate As NWADateTime) As DataSet
            Return Nothing
        End Function

        Public Function GetConfiguredFlightContainers(ByVal flightNum As String, ByVal departureDate As NWADateTime) As DataSet
            Try
                Dim strSql As String
                strSql = "select CNTNR_ID,CNTNR_SEQ_NUM from T_Container where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' "
                strSql = strSql & " and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"
                Return (SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql))
            Catch exSql As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function GetConfiguredFlight(ByVal flightNum As String, ByVal departureDate As NWADateTime) As DataSet
            Try
                Dim strSql As String
                strSql = "select *  from T_Flight_Info where OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' "
                strSql = strSql & " and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"
                Return (SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql))
            Catch exSql As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try

        End Function

        Public Function GetConfiguredFlights() As DataSet
            Try
                Dim strSql As String
                strSql = "select *  from T_Flight_Info "
                Return (SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql))
            Catch exSql As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        Public Function BagsToGo(ByVal apCode As String, ByVal flightNum As String, ByVal departureDate As NWADateTime, ByVal sortBy As String) As DataSet

            Dim dsHeader As New DataSet, dsDetail As New DataSet, tempDs As New DataSet
            Dim dt As New DataTable, dataRow As DataRow
            Dim strSql As String
            Dim intDetailCount As Integer, intHeaderCount As Integer, intTotalBagsToGo As Integer, intLocalBagsToGo As Integer
            Dim intInboundBgasToGo As Integer, intOffLoadedBags As Integer, intCount As Integer
            Try
                dsDetail.Tables.Add("Detail")
                'Sorting by Destination

                If sortBy = "DEST" Then
                    dsDetail.Tables(0).Columns.Add("DEST_AP_CDE")
                    dsDetail.Tables(0).Columns.Add("BAG_ID")
                    dsDetail.Tables(0).Columns.Add("SOURCE")
                    dsDetail.Tables(0).Columns.Add("STATUS")
                    strSql = "select distinct DEST_AP_CDE from T_BAG_TAG"
                    dsHeader = SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql)
                    dsHeader.Tables(0).Columns.Add("BagToGO")
                    dsHeader.Tables(0).Columns.Add("LocalBagToGO")
                    dsHeader.Tables(0).Columns.Add("InBoundBagToGO")
                    dsHeader.Tables(0).Columns.Add("OffLoadedBags")
                    For intCount = 0 To dsHeader.Tables(0).Rows.Count - 1
                        intDetailCount = 0
                        intTotalBagsToGo = 0
                        intLocalBagsToGo = 0
                        intInboundBgasToGo = 0
                        intOffLoadedBags = 0
                        strSql = "select a.ap_cde,a.ofld_ind,a.Bag_Id,a.ld_auth_ind,a.xpdt_ind,b.stby_ind "
                        strSql &= " from T_BAG_TAG a, T_Passenger_Config b where a.BAG_PSGR_SEQ_NUM = b.BAG_PSGR_SEQ_NUM and "
                        strSql &= " (a.ld_stats_cde != 'Y' OR   (a.ld_stats_cde = 'Y' AND  SUBSTRING(cntnr_id, 1, 3) = 'CAR')) and DEST_AP_CDE ='" & dsHeader.Tables(0).Rows(intCount)(0) & "' "
                        strSql &= " and  a.OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and a.OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and a.FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                        tempDs = SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql)

                        For Each dataRow In tempDs.Tables(0).Rows
                            dsDetail.Tables(0).Rows.Add()
                            dsDetail.Tables(0).Rows(intDetailCount)("DEST_AP_CDE") = dsHeader.Tables(0).Rows(intCount)("DEST_AP_CDE")
                            dsDetail.Tables(0).Rows(intDetailCount)("BAG_ID") = dataRow("Bag_ID")
                            If dataRow("ofld_ind").ToString = "Y" Then
                                intOffLoadedBags = intOffLoadedBags + 1
                                dsDetail.Tables(0).Rows(intDetailCount)("STATUS") = "*UNL*"
                            Else
                                intTotalBagsToGo = intTotalBagsToGo + 1
                                If dataRow("ld_auth_ind") = "N" Then
                                    dsDetail.Tables(0).Rows(intDetailCount)("STATUS") = "NOAUTH"
                                ElseIf dataRow("stby_ind") = "Y" Then
                                    dsDetail.Tables(0).Rows(intDetailCount)("STATUS") = "STBY"
                                ElseIf dataRow("xpdt_ind") <> "N" Then
                                    dsDetail.Tables(0).Rows(intDetailCount)("STATUS") = "EXPDT"
                                Else
                                    dsDetail.Tables(0).Rows(intDetailCount)("STATUS") = "OK"
                                End If
                                If dataRow("ap_cde") = apCode Then
                                    intLocalBagsToGo = intLocalBagsToGo + 1
                                    dsDetail.Tables(0).Rows(intDetailCount)("SOURCE") = " "
                                Else
                                    intInboundBgasToGo = intInboundBgasToGo + 1
                                    dsDetail.Tables(0).Rows(intDetailCount)("SOURCE") = "I"
                                End If
                            End If
                            intDetailCount = intDetailCount + 1
                        Next
                        dsHeader.Tables(0).Rows(intCount)("BagToGO") = intTotalBagsToGo
                        dsHeader.Tables(0).Rows(intCount)("LocalBagToGO") = intLocalBagsToGo
                        dsHeader.Tables(0).Rows(intCount)("InBoundBagToGO") = intInboundBgasToGo
                        dsHeader.Tables(0).Rows(intCount)("OffLoadedBags") = intOffLoadedBags
                    Next
                    'dsp.Merge(dsc)
                    dt = dsDetail.Tables(0).Copy()
                    dsHeader.Tables(0).TableName = "Header"
                    dsHeader.Tables.Add(dt)
                    dsHeader.Relations.Add(sortBy, dsHeader.Tables(0).Columns("DEST_AP_CDE"), _
                             dsHeader.Tables(1).Columns("DEST_AP_CDE"), False)
                    tempDs.Dispose()
                    dsDetail.Dispose()
                    Return dsHeader

                    'Sorting by Status
                ElseIf sortBy = "STATUS" Then
                    Dim strCurrentStatus As String, strNewStatus As String, strSource As String
                    Dim strFlightNum As String = String.Empty
                    strCurrentStatus = String.Empty
                    strNewStatus = String.Empty
                    strSource = String.Empty

                    strSql = "SELECT B.AP_CDE,B.bag_id,B.ofld_ind,B.ld_auth_ind,B.xpdt_ind,COALESCE(p.op_leg_al_cde, ' ') as op_leg_al_cde,"
                    strSql &= " COALESCE(p.op_leg_flt_num, 0) as op_leg_flt_num,P.stby_ind FROM   T_BAG_TAG B,T_Passenger_Config P "
                    strSql &= "where B.BAG_PSGR_SEQ_NUM = P.BAG_PSGR_SEQ_NUM and "
                    strSql &= " (B.ld_stats_cde != 'Y' OR   (B.ld_stats_cde = 'Y' AND  SUBSTRING(cntnr_id, 1, 3) = 'CAR'))"
                    strSql &= " and b.OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and b.OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and b.FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"
                    strSql &= "ORDER BY B.ofld_ind, B.ld_auth_ind, B.xpdt_ind, p.stby_ind, op_leg_flt_num"

                    tempDs = SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql)

                    dsHeader.Tables.Add("Header")
                    dsHeader.Tables(0).Columns.Add("Status")
                    dsHeader.Tables(0).Columns.Add("BagToGO")
                    dsHeader.Tables(0).Columns.Add("LocalBagToGO")
                    dsHeader.Tables(0).Columns.Add("InBoundBagToGO")

                    dsDetail.Tables(0).Columns.Add("Status")
                    dsDetail.Tables(0).Columns.Add("BAG_ID")
                    dsDetail.Tables(0).Columns.Add("SOURCE")
                    dsDetail.Tables(0).Columns.Add("LegFlightNum")

                    intDetailCount = 0
                    intHeaderCount = 0

                    For Each dataRow In tempDs.Tables(0).Rows
                        If dataRow("ofld_ind").ToString = "Y" Then
                            strNewStatus = "*UNL*"
                        Else
                            If dataRow("ld_auth_ind") = "N" Then
                                strNewStatus = "NOAUTH"
                            ElseIf dataRow("stby_ind") = "Y" Then
                                strNewStatus = "STBY"
                            ElseIf dataRow("xpdt_ind") <> "N" Then
                                strNewStatus = "EXPDT"
                            Else
                                strNewStatus = "OK"
                            End If
                            If dataRow("op_leg_flt_num") = 0 Then
                                strFlightNum = "    "
                                strSource = "     "
                            Else
                                strFlightNum = RTrim(dataRow("op_leg_al_cde")) & LTrim(dataRow("op_leg_flt_num").ToString())
                                strSource = "I"
                            End If
                        End If
                        If strCurrentStatus = strNewStatus Then
                            dsDetail.Tables(0).Rows.Add()
                            dsDetail.Tables(0).Rows(intDetailCount)("STATUS") = strCurrentStatus
                            dsDetail.Tables(0).Rows(intDetailCount)("LegFlightNum") = strFlightNum
                            dsDetail.Tables(0).Rows(intDetailCount)("BAG_ID") = dataRow("Bag_ID")
                            dsDetail.Tables(0).Rows(intDetailCount)("SOURCE") = strSource
                            intTotalBagsToGo = intTotalBagsToGo + 1
                            If dataRow("op_leg_flt_num") = 0 Then
                                intLocalBagsToGo = intLocalBagsToGo + 1
                            Else
                                intInboundBgasToGo = intInboundBgasToGo + 1
                            End If
                            intDetailCount = intDetailCount + 1
                        ElseIf strCurrentStatus <> String.Empty Then
                            dsHeader.Tables(0).Rows.Add()
                            dsHeader.Tables(0).Rows(intHeaderCount)("STATUS") = strCurrentStatus
                            dsHeader.Tables(0).Rows(intHeaderCount)("BagToGO") = intTotalBagsToGo
                            dsHeader.Tables(0).Rows(intHeaderCount)("LocalBagToGO") = intLocalBagsToGo
                            dsHeader.Tables(0).Rows(intHeaderCount)("InBoundBagToGO") = intInboundBgasToGo
                            intTotalBagsToGo = 1
                            If dataRow("op_leg_flt_num") = 0 Then
                                intLocalBagsToGo = 1
                                intInboundBgasToGo = 0
                            Else
                                intInboundBgasToGo = 1
                                intLocalBagsToGo = 0
                            End If
                            intHeaderCount = intHeaderCount + 1
                            strCurrentStatus = strNewStatus
                        Else
                            strCurrentStatus = strNewStatus
                            dsDetail.Tables(0).Rows.Add()
                            dsDetail.Tables(0).Rows(intDetailCount)("STATUS") = strCurrentStatus
                            dsDetail.Tables(0).Rows(intDetailCount)("LegFlightNum") = strFlightNum
                            dsDetail.Tables(0).Rows(intDetailCount)("BAG_ID") = dataRow("Bag_ID")
                            dsDetail.Tables(0).Rows(intDetailCount)("SOURCE") = strSource
                            intTotalBagsToGo = 1
                            If dataRow("op_leg_flt_num") = 0 Then
                                intLocalBagsToGo = 1
                            Else
                                intInboundBgasToGo = 1
                            End If
                            intDetailCount = intDetailCount + 1
                        End If
                    Next
                    dsHeader.Tables(0).Rows.Add()
                    dsHeader.Tables(0).Rows(intHeaderCount)("STATUS") = strCurrentStatus
                    dsHeader.Tables(0).Rows(intHeaderCount)("BagToGO") = intTotalBagsToGo
                    dsHeader.Tables(0).Rows(intHeaderCount)("LocalBagToGO") = intLocalBagsToGo
                    dsHeader.Tables(0).Rows(intHeaderCount)("InBoundBagToGO") = intInboundBgasToGo

                    'dsp.Merge(dsc)
                    dt = dsDetail.Tables(0).Copy()
                    dsHeader.Tables(0).TableName = "Header"
                    dsHeader.Tables.Add(dt)
                    dsHeader.Relations.Add(sortBy, dsHeader.Tables(0).Columns("STATUS"), _
                             dsHeader.Tables(1).Columns("STATUS"), False)
                    tempDs.Dispose()
                    dsDetail.Dispose()
                    Return dsHeader
                    'Sort by XFER


                ElseIf sortBy = "XFER" Then
                    Dim dr As SqlCeDataReader
                    Dim strCurrentStatus As String, strNewStatus As String, strSource As String
                    Dim strFlightNum As String = String.Empty
                    Dim strCurrentFlightNum As String = String.Empty
                    Dim strCurrentAirLinesCode As String = String.Empty
                    Dim strBlockTime As String = String.Empty
                    Dim strBlockGate As String = String.Empty
                    strCurrentStatus = String.Empty
                    strNewStatus = String.Empty
                    strSource = String.Empty
                    intDetailCount = 0
                    intTotalBagsToGo = 0
                    intLocalBagsToGo = 0
                    intInboundBgasToGo = 0
                    intOffLoadedBags = 0

                    strSql = "SELECT B.bag_id,B.ap_cde,B.ofld_ind,B.ld_auth_ind,B.xpdt_ind,P.stby_ind,"
                    strSql &= "COALESCE(P.OP_LEG_AL_CDE, 'ZZ') as OP_LEG_AL_CDE, COALESCE(P.OP_LEG_FLT_NUM, 0) as OP_LEG_FLT_NUM,"
                    strSql &= " COALESCE(P.LEG_FLT_SCHED_DTM, getdate()) as LEG_FLT_SCHED_DTM "
                    strSql &= " FROM   T_BAG_TAG B,T_Passenger_Config P "
                    strSql &= "where B.BAG_PSGR_SEQ_NUM = P.BAG_PSGR_SEQ_NUM and "
                    strSql &= " (B.ld_stats_cde != 'Y' OR   (B.ld_stats_cde = 'Y' AND  SUBSTRING(cntnr_id, 1, 3) = 'CAR'))"
                    strSql &= " and b.OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and b.OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and b.FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"
                    strSql &= " ORDER BY OP_LEG_FLT_NUM"

                    tempDs = SqlCeHelper.ExecuteDataset(_objSqlCeCon, CommandType.Text, strSql)

                    dsHeader.Tables.Add("Header")
                    dsHeader.Tables(0).Columns.Add("InBoundFlightNum")
                    dsHeader.Tables(0).Columns.Add("InBoundFlightBagCount")
                    dsHeader.Tables(0).Columns.Add("InBoundFlightTime")
                    dsHeader.Tables(0).Columns.Add("InBoundFlightGate")

                    dsDetail.Tables(0).Columns.Add("InBoundFlightNum")
                    dsDetail.Tables(0).Columns.Add("BAG_ID")
                    dsDetail.Tables(0).Columns.Add("Status")

                    intDetailCount = 0
                    intHeaderCount = 0

                    For Each dataRow In tempDs.Tables(0).Rows

                        If dataRow("ofld_ind").ToString = "Y" Then
                            strNewStatus = "*UNL*"
                        Else
                            intTotalBagsToGo = intTotalBagsToGo + 1
                            If dataRow("ld_auth_ind") = "N" Then
                                strNewStatus = "NOAUTH"
                            ElseIf dataRow("stby_ind") = "Y" Then
                                strNewStatus = "STBY"
                            ElseIf dataRow("xpdt_ind") <> "N" Then
                                strNewStatus = "EXPDT"
                            Else
                                strNewStatus = "OK"
                            End If
                            If dataRow("op_leg_flt_num") = 0 Or dataRow("op_leg_al_cde") = "ZZ" Then
                                strFlightNum = "*LOCAL"
                                intLocalBagsToGo = intLocalBagsToGo + 1
                            End If
                        End If
                        If strCurrentAirLinesCode = dataRow("op_leg_al_cde") And strCurrentFlightNum = dataRow("op_leg_flt_num").ToString.Trim Then
                            dsDetail.Tables(0).Rows.Add()
                            dsDetail.Tables(0).Rows(intDetailCount)("InBoundFlightNum") = strFlightNum
                            dsDetail.Tables(0).Rows(intDetailCount)("STATUS") = strNewStatus
                            dsDetail.Tables(0).Rows(intDetailCount)("BAG_ID") = dataRow("Bag_ID")
                            intInboundBgasToGo = intInboundBgasToGo + 1
                            intDetailCount = intDetailCount + 1
                        ElseIf intInboundBgasToGo <> 0 Then
                            dsHeader.Tables(0).Rows.Add()
                            dsHeader.Tables(0).Rows(intHeaderCount)("InBoundFlightNum") = strFlightNum
                            dsHeader.Tables(0).Rows(intHeaderCount)("InBoundFlightBagCount") = intInboundBgasToGo.ToString("000")
                            dsHeader.Tables(0).Rows(intHeaderCount)("InBoundFlightTime") = strBlockTime
                            dsHeader.Tables(0).Rows(intHeaderCount)("InBoundFlightGate") = strBlockGate
                            intInboundBgasToGo = 1
                            strCurrentAirLinesCode = dataRow("op_leg_al_cde").ToString
                            strCurrentFlightNum = dataRow("op_leg_flt_num").ToString
                            If dataRow("op_leg_flt_num") <> 0 Then
                                strSql = "select COALESCE(leg_flt_blk_dtm, leg_flt_est_dtm) as Block_Time,LEG_GATE_CDE from T_Passenger_Config where "
                                strSql &= " op_leg_al_cde = '" & dataRow("op_leg_al_cde") & "' and op_leg_flt_num ='" & dataRow("op_leg_flt_num") & "'"
                                strSql &= "and LEG_FLT_SCHED_DTM = '" & dataRow("LEG_FLT_SCHED_DTM") & "'"
                                dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                                If dr.Read Then
                                    strBlockTime = Convert.ToDateTime(dr(0)).ToString("HHMM")
                                    strBlockGate = dr(1).ToString
                                Else
                                    strBlockTime = "00:00"
                                    strBlockGate = "     "
                                End If
                                strFlightNum = RTrim(dataRow("op_leg_al_cde")) & LTrim(dataRow("op_leg_flt_num").ToString())
                            Else
                                strFlightNum = "*LOCAL"
                                strBlockTime = "      "
                                strBlockGate = "     "
                            End If
                            intHeaderCount = intHeaderCount + 1
                        Else
                            strCurrentAirLinesCode = dataRow("op_leg_al_cde").ToString
                            strCurrentFlightNum = dataRow("op_leg_flt_num").ToString
                            If dataRow("op_leg_flt_num") <> 0 Then
                                strSql = "select COALESCE(leg_flt_blk_dtm, leg_flt_est_dtm) as Block_Time,LEG_GATE_CDE from T_Passenger_Config where "
                                strSql &= " op_leg_al_cde = '" & dataRow("op_leg_al_cde") & "' and op_leg_flt_num ='" & dataRow("op_leg_flt_num") & "'"
                                strSql &= "and LEG_FLT_SCHED_DTM = '" & dataRow("LEG_FLT_SCHED_DTM") & "'"
                                dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                                If dr.Read Then
                                    strBlockTime = Convert.ToDateTime(dr(0)).ToString("HHMM")
                                    strBlockGate = dr(1)
                                Else
                                    strBlockTime = "00:00"
                                    strBlockGate = "     "
                                End If
                                strFlightNum = RTrim(dataRow("op_leg_al_cde")) & LTrim(dataRow("op_leg_flt_num").ToString())
                            Else
                                strFlightNum = "*LOCAL"
                                strBlockTime = "      "
                                strBlockGate = "     "
                            End If
                            dsDetail.Tables(0).Rows.Add()
                            dsDetail.Tables(0).Rows(intDetailCount)("InBoundFlightNum") = strFlightNum
                            dsDetail.Tables(0).Rows(intDetailCount)("BAG_ID") = dataRow("Bag_ID").ToString
                            dsDetail.Tables(0).Rows(intDetailCount)("STATUS") = strNewStatus
                            intInboundBgasToGo = 1
                            intDetailCount = intDetailCount + 1
                        End If
                    Next
                    dsHeader.Tables(0).Rows.Add()
                    dsHeader.Tables(0).Rows(intHeaderCount)("InBoundFlightNum") = strFlightNum
                    dsHeader.Tables(0).Rows(intHeaderCount)("InBoundFlightBagCount") = intInboundBgasToGo.ToString("000")
                    dsHeader.Tables(0).Rows(intHeaderCount)("InBoundFlightTime") = strBlockTime.ToString
                    dsHeader.Tables(0).Rows(intHeaderCount)("InBoundFlightGate") = strBlockGate.ToString

                    'dsp.Merge(dsc)
                    dt = dsDetail.Tables(0).Copy()
                    dsHeader.Tables(0).TableName = "Header"
                    dsHeader.Tables.Add(dt)
                    dsHeader.Relations.Add(sortBy, dsHeader.Tables(0).Columns("InBoundFlightNum"), _
                             dsHeader.Tables(1).Columns("InBoundFlightNum"), False)

                    dsHeader.Tables.Add("XFER")
                    dsHeader.Tables("XFER").Columns.Add("InBoundBagCount")
                    dsHeader.Tables("XFER").Columns.Add("LocalBagCount")
                    dsHeader.Tables("XFER").Rows.Add()
                    dsHeader.Tables("XFER").Rows(0)("InBoundBagCount") = intTotalBagsToGo.ToString
                    dsHeader.Tables("XFER").Rows(0)("LocalBagCount") = intLocalBagsToGo.ToString
                    tempDs.Dispose()
                    dsDetail.Dispose()
                    Return dsHeader
                Else
                    Return Nothing
                End If
            Catch ex As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function


        Public Function IsBagOnNoLoad(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                       ByVal bagTagNum As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "select count(*) from T_Bag_Tag where bag_id= '" & bagTagNum & "' and SCRTY_STATS_CDE =  'N'  and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsBagOnNoLoad = ReturnCodes.Ok
                Else
                    IsBagOnNoLoad = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsBagOnNoLoad = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsBagOnNoLoad = ReturnCodes.Exception
            End Try
        End Function

        Public Function IsBagSecurityCleared(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                ByVal bagTagNum As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "select count(*) from T_Bag_Tag where bag_id= '" & bagTagNum & "' and SCRTY_STATS_CDE =  'Y'  and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsBagSecurityCleared = ReturnCodes.Ok
                Else
                    IsBagSecurityCleared = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsBagSecurityCleared = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsBagSecurityCleared = ReturnCodes.Exception
            End Try
        End Function

        Public Function IsPassengerOnStandBy(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                ByVal bagTagNum As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "select count(*) from T_Bag_Tag a,T_Passenger_Config b where a.BAG_PSGR_SEQ_NUM = b.BAG_PSGR_SEQ_NUM"
                strSql &= " and a.BAG_ID = '" & bagTagNum & "' and b.STBY_IND='Y' and "
                strSql &= " a.OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and a.OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                strSql &= " and a.FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsPassengerOnStandBy = ReturnCodes.Ok
                Else
                    IsPassengerOnStandBy = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsPassengerOnStandBy = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsPassengerOnStandBy = ReturnCodes.Exception
            End Try
        End Function

        Public Function IsPassengerCheckedIn(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                ByVal bagTagNum As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "select count(*) from T_Bag_Tag a,T_Passenger_Config b where a.BAG_PSGR_SEQ_NUM = b.BAG_PSGR_SEQ_NUM"
                strSql &= " and a.BAG_ID = '" & bagTagNum & "' and b.CKIN_IND='Y' and "
                strSql &= " a.OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and a.OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                strSql &= " and a.FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsPassengerCheckedIn = ReturnCodes.Ok
                Else
                    IsPassengerCheckedIn = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsPassengerCheckedIn = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsPassengerCheckedIn = ReturnCodes.Exception
            End Try
        End Function

        Public Function IsBagAlreadyLoaded(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                      ByVal bagTagNum As String) As ReturnCodes
            'is bag already loaded (might be either into a Bin or a container)
            Try
                Dim strSql As String
                strSql = "select count(*) from T_Bag_Tag where bag_id= '" & bagTagNum & "' and LD_STATS_CDE =  'Y'  and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsBagAlreadyLoaded = ReturnCodes.Ok
                Else
                    IsBagAlreadyLoaded = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsBagAlreadyLoaded = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsBagAlreadyLoaded = ReturnCodes.Exception
            End Try
        End Function

        Public Function IsBagAlreadyUnloaded(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                     ByVal bagTagNum As String) As ReturnCodes
            'is bag already loaded (might be either into a Bin or a container)
            Try
                Dim strSql As String
                strSql = "select count(*) from T_Bag_Tag where bag_id= '" & bagTagNum & "' and LD_STATS_CDE =  'Y'  and OP_AL_CDE = '" & flightNum.Substring(0, 2).Trim & "' and OP_FLT_NUM = " & flightNum.Substring(2).Trim & " and "
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "'"

                If SqlCeHelper.ExecuteScalar(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    IsBagAlreadyUnloaded = ReturnCodes.Ok
                Else
                    IsBagAlreadyUnloaded = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                IsBagAlreadyUnloaded = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                IsBagAlreadyUnloaded = ReturnCodes.Exception
            End Try
        End Function

        Public Function AddFlight(ByVal flightData As DataSet) As Boolean
            Try
                If SqlCeHelper.UpdateTable("T_Flight_Info", flightData) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch exSql As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        '''' <summary>
        '''' Add a flight to the local SQL Ce database
        '''' </summary>
        'Public Function AddFlight(ByVal flightXml As String) As ReturnCodes
        '    Try
        '        Dim ds As New DataSet
        '        Dim objMemoryStream As IO.MemoryStream
        '        objMemoryStream = New IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(flightXml))
        '        If SqlCeHelper.UpdateTable("T_Flight_Info", ds) > 0 Then
        '            AddFlight = ReturnCodes.Ok
        '        Else
        '            AddFlight = ReturnCodes.NotOk
        '        End If
        '    Catch exSql As SqlCeException
        '        AddFlight = ReturnCodes.DatabaseError
        '    Catch ex As Exception
        '        Logger.LogException(ex)
        '        AddFlight = ReturnCodes.Unknown
        '    End Try
        'End Function

        Public Function AddAircraftConfig(ByVal configData As DataSet) As Boolean
            Try
                If SqlCeHelper.UpdateTable("T_Aircraft_Config", configData) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch exSql As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

#End Region

        Public Sub InsertTables(ByVal noofrec As Integer)
            Dim sql As String
            Dim i As Int16
            On Error Resume Next
            If noofrec < 1 Then
                MsgBox("enter no of records")
                Exit Sub
            End If
            For i = 0 To noofrec
                sql = "Insert into T_Passenger_Config Values('9','MSP" & i & "','NW','1231',getdate(),'10','MUM','9999',getdate(),getdate(),'PNR0','Sinha','Y','Y','Y','N','CHE',getdate())"
                sql = "Insert into T_Passenger_Config Values('3','MSP" & i & "','NW','1231',getdate(),'10','MUM','9999',getdate(),getdate(),'PNR0','Sinha','Y','Y','Y','N','CHE',getdate())"
                'sql &= "'2007-09-25','2007-09-25','PNR" & i & "','Sinha','Y','Y','Y','N','CHE','2007-09-25')"
                SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
                'sql = "Insert into T_Passenger_Config Values('9','MSP" & i & "','NW','1232','2007-09-25','1" & i & "','IB','8888'"
                'sql &= "'2007-09-25','2007-09-25','PNR" & i & "','Sinha','Y','Y','Y','N','MUM','2007-09-25')"
                SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
            Next
            For i = 0 To noofrec
                'sql = "Insert into T_Bag_Tag Values('NW',1231,'" & New NWADateTime(Date.Now).SqlDateFormat & "','00121234" & i + 10 & "',5,'MSP','73234MSP03287','Y','AKE12345NW',getdate(),'CHG',getdate(),'B','y','N','S','O','L','O',1234,'R','X',12224.3,12,'D','T','S',getdate(),getdate(),getdate())"
                sql = "Insert into T_Bag_Tag Values('NW',1231,'" & New NWADateTime(Date.Now).SqlDateFormat & "','00121234" & i + 10 & "',9,'MSP',73235,'Y','AKE12345NW',getdate(),'WAS',getdate(),'B','y','N','S','O','Y','Y',1234,'R','X',12224.3,12,'D','T','S',getdate(),getdate(),getdate())"
                SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
                sql = "Insert into T_Bag_Tag Values('NW',1231,'" & New NWADateTime(Date.Now).SqlDateFormat & "','00121234" & i + 15 & "',91,'MSP',73234,'Y','AKE12346NW',getdate(),'MUM',getdate(),'B','y','N','S','O','Y','Y',1234,'R','X',12224.3,13,'D','T','S',getdate(),getdate(),getdate())"
                SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
                sql = "Insert into T_Bag_Tag Values('NW',1232,'" & New NWADateTime(Date.Now).SqlDateFormat & "','00221234" & i + 10 & "',3,'MSP',73234,'Y','AKE12346NW',getdate(),'MUM',getdate(),'B','y','N','S','O','Y','Y',1234,'R','X',12224.3,13,'D','T','S',getdate(),getdate(),getdate())"
                SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
            Next i
            'MsgBox("bagtag inserted")
            For i = 0 To noofrec
                sql = "Insert into T_Aircraft_Config Values('009913" & i & "','51','10','Y','F','2007-09-25')"
                SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
            Next i
            'MsgBox("aircraft config inserted")
            'For i = 0 To noofrec
            '    sql = "Insert into T_Passenger_Config Values('MSP" & i & "'," & i & ",7,'123" & i & "','Test','Y','A','B','N','NW',8,'Test','2007-09-25')"
            '    SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
            '    sql = "Insert into T_Passenger_Config Values('MSP" & i & "'," & i + 10 & ",7,'123" & i & "','Test','Y','A','B','N','NW',8,'Test','2007-09-25')"
            '    SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
            'Next
            MsgBox("Mail started")
            For i = 0 To noofrec
                sql = "Insert into T_Mail Values('1234" & i & "','4X8NTVJVBD0" & i & "','CHG','NW',1231,'" & New NWADateTime(Date.Now).SqlDateFormat & "','MSP','MUM','',NULL,1212,'MAIL',12,3434,'2007-09-25','2007-09-25')"
                SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
                sql = "Insert into T_Mail Values('1234" & i + 10 & "','mail002','MSP','NW',1231,'" & New NWADateTime(Date.Now).SqlDateFormat & "','MSP','MUM','',NULL,1212,'MAIL',12,3434,'2007-09-25','2007-09-25')"
                SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
            Next
            MsgBox("MAIL inserted")
            For i = 0 To noofrec
                sql = "Insert Into T_Container Values('NW','MSP','1231','" & New NWADateTime(Date.Now).SqlDateFormat & "','A','0121234567" & i & "00004','AKE12346NW' ,'C1000','T','2','2007-09-25','HYD','MUM','2007-09-25','2007-09-25' )"
                SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
                sql = "Insert Into T_Container Values('NW','CHG','1231','" & New NWADateTime(Date.Now).SqlDateFormat & "','A','012123456780000" & i & ",'AKE12345NW' ,'C1000','T','2','2007-09-25','HYD','MUM','2007-09-25','2007-09-25' )"
                SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
            Next
            'MsgBox("CONTAINER inserted")
            For i = 0 To noofrec
                sql = "Insert into T_Line_Item Values('NW',1231,'" & New NWADateTime(Date.Now).SqlDateFormat & "'," & i & ",'HELO','2','HK1001','MAIL','Y','NWA',123,5,355,4,'NWA969','Test12','Test','2007-09-25','2007-09-25')"
                SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
            Next
            ' MsgBox("LINE ITEM inserted")
            For i = 0 To noofrec
                sql = "Insert into T_Freight Values('NW','MSP',1231,'" & New NWADateTime(Date.Now).SqlDateFormat & "','A','NWA100',1000,'MAIL',2000,1111,500,'MSP','VSS','T','4','2',121,'L','S','2007-09-25',73234,'X','D','1210101','1255','2007-09-25','2007-09-25')"
                SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
            Next
            'MsgBox("FREIGHT inserted")
            For i = 0 To noofrec
                sql = " Insert into T_Flight_Info Values('MSP" & i & "','NW','" & New NWADateTime(Date.Now).SqlDateFormat & "','" & New NWADateTime(Date.Now).SqlDateFormat & "',1231,'YES','A',12,'09913','N','Y','Y','2007-09-25')"
                SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
            Next
            sql = " Insert into T_Airline_Code Values('NWA','TTEST','123','2007-09-25')"
            SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, sql)
            sql = " Insert into T_Airline_Code Values('NW','TTEST','123','2007-09-25')"

            ' Next
            'MsgBox("Airline Code inserted")
            ' MsgBox("Record inserted")
        End Sub

        Public Function HasBinCapacityExceeded(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                        ByVal binBulkNum As String) As Boolean

            Return False
        End Function

        Public Function HasContainerCapacityExceeded(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                        ByVal containerNum As String) As Boolean


            Return False
        End Function

        Public Function GetBagsToGoCount(ByVal flightNum As String, ByVal departureDate As NWADateTime) As Integer

        End Function
        '        Public Function LoadExpediteBagToContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
        'ByVal containerNum As String, ByVal bagTagNum As String, ByVal expediteCode As String) As ReturnCodes
        '            Try
        '                Dim strSql As String
        '                strSql = "update T_Bag_Tag set CNTNR_SEQ_NUM = '" & containerNum & "', XPDT_IND = 'Y', OP_AL_CDE= '" & flightNum.Substring(0, 2) & "', OP_FLT_NUM = " & flightNum.Substring(2).Trim & ","
        '                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "', scanned_time = getdate() where BAG_ID = '" & bagTagNum & "'"
        '                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
        '                    LoadExpediteBagToContainer = ReturnCodes.Ok
        '                Else
        '                    LoadExpediteBagToContainer = ReturnCodes.NotOk
        '                End If
        '            Catch exSql As SqlCeException
        '                LoadExpediteBagToContainer = ReturnCodes.DatabaseError
        '            Catch ex As Exception
        '                Logger.LogException(ex)
        '                LoadExpediteBagToContainer = ReturnCodes.Unknown
        '            End Try
        '        End Function
        Public Function LoadExpediteBagToContainer(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
            ByVal containerNum As String, ByVal bagTagNum As String, ByVal expediteCode As String) As ReturnCodes
            Try
                Dim strSql As String
                strSql = "update T_Bag_Tag set CNTNR_SEQ_NUM = '" & containerNum & "', trkg_ind = 'N', LD_STATS_CDE = 'Y', XPDT_IND = 'Y', OP_AL_CDE= '" & flightNum.Substring(0, 2) & "', OP_FLT_NUM = " & flightNum.Substring(2).Trim & ","
                strSql = strSql & " FLT_SCHED_DTM = '" & departureDate.SqlDateFormat & "', scanned_time = getdate() where BAG_ID = '" & bagTagNum & "'"
                If SqlCeHelper.ExecuteNonQuery(_objSqlCeCon, CommandType.Text, strSql) > 0 Then
                    LoadExpediteBagToContainer = ReturnCodes.Ok
                Else
                    LoadExpediteBagToContainer = ReturnCodes.NotOk
                End If
            Catch exSql As SqlCeException
                LoadExpediteBagToContainer = ReturnCodes.DatabaseError
            Catch ex As Exception
                Logger.LogException(ex)
                LoadExpediteBagToContainer = ReturnCodes.Unknown
            End Try
        End Function


        Public Function GetPcsForFreight(ByVal awbNum As String) As String
            Try
                Dim strSql As String, dr As SqlCeDataReader
                strSql = "select ITM_CNT from T_Freight where AWB_NUM = '" & awbNum & "'"
                dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                If dr.Read() Then
                    Dim Pcs As New String(dr(0).ToString.Trim)
                    Return Pcs
                Else
                    Return Nothing
                End If
            Catch exSql As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function
        Public Function GetIndWeightForFreight(ByVal awbNum As String) As String
            Try
                Dim strSql As String, dr As SqlCeDataReader
                strSql = "select ITM_WT_LB from T_Freight where AWB_NUM = '" & awbNum & "'"
                dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                If dr.Read() Then
                    Dim Weight As New String(dr(0).ToString.Trim)
                    Return Weight
                Else
                    Return Nothing
                End If
            Catch exSql As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function
        Public Function GetFltStatus(ByVal flightNum As String) As String
            Try
                Dim strSql As String, dr As SqlCeDataReader
                strSql = "select IS_CLOSE from T_Flight_Info where OP_FLT_NUM = " & flightNum.Substring(2).Trim & " "
                dr = SqlCeHelper.ExecuteReader(_objSqlCeCon, CommandType.Text, strSql)
                If dr.Read() Then
                    Dim FltStatus As New String(dr(0).ToString.Trim)
                    Return FltStatus
                Else
                    Return Nothing
                End If
            Catch exSql As SqlCeException
                Throw New SafetracException(ReturnCodes.DatabaseError)
            Catch ex As Exception
                Logger.LogException(ex)
                Throw New SafetracException(ReturnCodes.Unknown)
            End Try
        End Function

        '''' <summary>
        '''' Add a flight to the local SQL Ce database
        '''' </summary>
        'Public Function AddContainers(ByVal containerXml As String) As ReturnCodes
        '    Try
        '        Dim ds As New DataSet
        '        Dim objMemoryStream As IO.MemoryStream
        '        objMemoryStream = New IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(containerXml))
        '        If SqlCeHelper.UpdateTable("T_Container", ds) > 0 Then
        '            AddContainers = ReturnCodes.Ok
        '        Else
        '            AddContainers = ReturnCodes.NotOk
        '        End If
        '    Catch exSql As SqlCeException
        '        AddContainers = ReturnCodes.DatabaseError
        '    Catch ex As Exception
        '        Logger.LogException(ex)
        '        AddContainers = ReturnCodes.Unknown
        '    End Try
        'End Function

    End Module ' END CLASS DEFINITION FlightOperations

End Namespace ' DataAccessLayer

