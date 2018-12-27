Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO
Imports NWA.Safetrac.Scanner.DataAccess.SqlCeHelper

Namespace NWA.Safetrac.Scanner.DataAccess
    Public Class CreateDatabase
        Private Shared _DBPATH As String
        Private Shared _DBNAME As String
        Public Shared Property DBPath() As String
            Get
                Return _DBPATH
            End Get
            Set(ByVal value As String)
                _DBPATH = value
            End Set
        End Property
        Public Shared Property DBName() As String
            Get
                Return _DBNAME
            End Get
            Set(ByVal value As String)
                _DBNAME = value
            End Set
        End Property
        Public Shared Function IsDataBaseExist() As Boolean
            Dim strDBURL As String
            Try
                strDBURL = _DBPATH + "\" + _DBNAME
                If File.Exists(strDBURL) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Shared Sub CreateDatabase()
            Dim SqlEngine As SqlCeEngine
            Dim strSQL As String, strConStr As String
            Dim strDBURL As String
            Dim strDBPath As String
            Dim strDBName As String
            strDBPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
            strDBName = "safetrac.sdf"
            strDBURL = strDBPath + "\" + strDBName

            ' MsgBox("data source=" & strDBPath)
            SqlEngine = New SqlServerCe.SqlCeEngine("data source=" & strDBURL)
            SqlEngine.CreateDatabase()
            '   cn = New System.Data.SqlServerCe.SqlCeConnection("Data Source=" & strDBURL)
            strConStr = "data source=" & strDBURL
            Try
                SqlEngine.Dispose()
                strSQL = "CREATE TABLE T_Aircraft_Config("
                strSQL = strSQL & "OP_FLT_NUM numeric(4,0) NOT NULL,"
                strSQL = strSQL & "FLT_SCHED_DTM datetime,"
                strSQL = strSQL & "OP_AL_CDE nvarchar(3),"
                strSQL = strSQL & "AC_NOSE_NUM nvarchar(10) ,"
                strSQL = strSQL & "POS_NUM nvarchar(2),"
                strSQL = strSQL & "PLLT_LOC_NUM nvarchar(2),"
                strSQL = strSQL & "IN_USE_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "PLLT_SLT_CDE nvarchar(2) NOT NULL,"
                'strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL,"
                strSQL = strSQL & " CONSTRAINT pkAirConfig PRIMARY KEY (AC_NOSE_NUM,POS_NUM,PLLT_LOC_NUM))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "CREATE TABLE T_Passenger_Config("
                strSQL = strSQL & "BAG_PSGR_SEQ_NUM numeric(7,0),"
                strSQL = strSQL & "AP_CDE nvarchar(5),"
                strSQL = strSQL & "OP_AL_CDE nvarchar(3) NOT NULL,"
                strSQL = strSQL & "OP_FLT_NUM numeric(4,0) NOT NULL,"
                strSQL = strSQL & "FLT_SCHED_DTM datetime,"
                strSQL = strSQL & "LEG_SEQ_NUM numeric(2),"
                strSQL = strSQL & "OP_LEG_AL_CDE nvarchar(3) NOT NULL,"
                strSQL = strSQL & "OP_LEG_FLT_NUM numeric(4,0) NOT NULL,"
                strSQL = strSQL & "LEG_FLT_SCHED_DTM datetime,"
                strSQL = strSQL & "LEG_FLT_EST_DTM datetime,"
                strSQL = strSQL & "LEG_FLT_BLK_DTM datetime,"
                strSQL = strSQL & "LEG_GATE_CDE nvarchar(5) NOT NULL,"
                strSQL = strSQL & "PNR_NUM nvarchar(7) NOT NULL,"
                strSQL = strSQL & "LST_NME nvarchar(40) NULL,"
                strSQL = strSQL & "CKIN_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "BRD_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "RERTE_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "STBY_IND nvarchar(1) NOT NULL, "
                strSQL = strSQL & "LEG_AP_CDE nvarchar(5) NOT NULL,"
                'strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL,"
                strSQL = strSQL & "CONSTRAINT pkPassConfig PRIMARY KEY(AP_CDE, BAG_PSGR_SEQ_NUM, LEG_SEQ_NUM))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "CREATE TABLE T_Bag_Tag("
                strSQL = strSQL & "OP_AL_CDE nvarchar(3),"
                strSQL = strSQL & "OP_FLT_NUM numeric(4,0),"
                strSQL = strSQL & "FLT_SCHED_DTM datetime,"
                strSQL = strSQL & "BAG_ID nvarchar(10),"
                strSQL = strSQL & "BAG_PSGR_SEQ_NUM numeric(7,0),"
                strSQL = strSQL & "AP_CDE nvarchar(5) NOT NULL,"
                strSQL = strSQL & "CNTNR_SEQ_NUM numeric(6) NULL,"
                strSQL = strSQL & "BAG_TYP_CDE nvarchar(4) NULL,"
                strSQL = strSQL & "CNTNR_ID nvarchar(10) NULL,"
                strSQL = strSQL & "BAG_TAG_CRTN_DTM datetime NOT NULL,"
                strSQL = strSQL & "DEST_AP_CDE nvarchar(5) NOT NULL,"
                strSQL = strSQL & "BSM_CRTN_DTM datetime NULL,"
                strSQL = strSQL & "BAG_CRTN_TYP_CDE nvarchar(1) NOT NULL,"
                strSQL = strSQL & "BSM_DEL_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "LD_AUTH_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "SCRTY_STATS_CDE nvarchar(1) NOT NULL,"
                strSQL = strSQL & "CBN_CL_CDE nvarchar(1) NULL,"
                strSQL = strSQL & "LD_STATS_CDE nvarchar(1) NOT NULL,"
                strSQL = strSQL & "OFLD_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "LD_SEQ_NUM numeric(4) NULL,"
                strSQL = strSQL & "RLBL_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "XPDT_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "BAG_WT_LB numeric(6,1) NULL,"
                strSQL = strSQL & "POS_NUM nvarchar(2) NULL,"
                strSQL = strSQL & "DMGD_IND nvarchar(1) NULL,"
                strSQL = strSQL & "TRKG_IND nvarchar(1) NULL,"
                strSQL = strSQL & "SHRT_CONN_FLT_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "ALRT_TMS datetime NULL,"
                strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL,"
                strSQL = strSQL & "SCANNED_TIME datetime NULL,"
                strSQL = strSQL & "CONSTRAINT pkBagTag PRIMARY KEY(OP_AL_CDE, OP_FLT_NUM, FLT_SCHED_DTM, BAG_ID,BAG_PSGR_SEQ_NUM))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "CREATE TABLE T_Freight("
                strSQL = strSQL & "OP_AL_CDE nvarchar(3),"
                strSQL = strSQL & "AP_CDE nvarchar(5),"
                strSQL = strSQL & "OP_FLT_NUM numeric(4,0),"
                strSQL = strSQL & "FLT_SCHED_DTM datetime,"
                strSQL = strSQL & "ARR_DPTR_CDE nvarchar(1),"
                strSQL = strSQL & "AWB_NUM nvarchar(18),"
                strSQL = strSQL & "WF_SCRN_LIN_ITM_NUM numeric(4,0) NULL,"
                strSQL = strSQL & "CMDTY_TYP_CDE nvarchar(8) NOT NULL,"
                strSQL = strSQL & "ITM_CNT numeric(4) NOT NULL,"
                strSQL = strSQL & "ITM_WT_LB numeric(6,1) NOT NULL,"
                strSQL = strSQL & "AVG_ITM_WT_LB numeric(6,1) NOT NULL,"
                strSQL = strSQL & "DEST_AP_CDE nvarchar(5) NOT NULL,"
                strSQL = strSQL & "FNL_DEST_AP_CDE nvarchar(5) NULL,"
                strSQL = strSQL & "THRU_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "POS_NUM nvarchar(2) NULL,"
                strSQL = strSQL & "PREV_POS_NUM nvarchar(2) NULL,"
                strSQL = strSQL & "LOAD_SEQ_NUM numeric(3) NULL,"
                strSQL = strSQL & "LOAD_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "SCN_IND nvarchar(1) NULL,"
                strSQL = strSQL & "SCN_DTM datetime  NULL,"
                strSQL = strSQL & "CNTNR_SEQ_NUM numeric(6) NULL,"
                strSQL = strSQL & "XPDT_IND nvarchar(1) NULL, "
                strSQL = strSQL & "DNGR_FRGT_IND nvarchar(1) NULL,"
                strSQL = strSQL & "FRGT_STG_LOC_CDE nvarchar(11) NULL,"
                strSQL = strSQL & "PREV_FRGT_STG_LOC_CDE nvarchar(11) NULL,"
                strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL,"
                strSQL = strSQL & "SCANNED_TIME datetime NULL,"
                strSQL = strSQL & "CONSTRAINT pkFreight PRIMARY KEY(OP_AL_CDE, AP_CDE, OP_FLT_NUM, FLT_SCHED_DTM,ARR_DPTR_CDE, AWB_NUM))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "CREATE TABLE T_Mail("
                strSQL = strSQL & "MAIL_UNIT_SEQ_NUM numeric(7),"
                strSQL = strSQL & "MAIL_BRCD_ID nvarchar(30) NOT NULL,"
                strSQL = strSQL & "AP_CDE nvarchar(5) NULL,"
                strSQL = strSQL & "OP_AL_CDE nvarchar(3) NOT NULL,"
                strSQL = strSQL & "OP_FLT_NUM numeric(4,0) NULL,"
                strSQL = strSQL & "FLT_SCHED_DTM datetime NULL,"
                strSQL = strSQL & "DEST_AP_CDE nvarchar(5) NULL,"
                strSQL = strSQL & "FNL_DEST_AP_CDE nvarchar(5) NULL,"
                strSQL = strSQL & "POS_ID nvarchar(2) NULL,"
                strSQL = strSQL & "CNTNR_SEQ_NUM numeric(6) NULL,"
                strSQL = strSQL & "LD_SEQ_NUM numeric(4) NULL,"
                strSQL = strSQL & "CMDTY_TYP_CDE nvarchar(8) NULL,"
                strSQL = strSQL & "TOT_WT_LB numeric(6,1) NULL,"
                strSQL = strSQL & "ITM_CNT numeric(5) NULL,"
                strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL, "
                strSQL = strSQL & "SCANNED_TIME datetime NULL,"
                strSQL = strSQL & "CONSTRAINT pkMail PRIMARY KEY(MAIL_BRCD_ID))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "CREATE TABLE T_Container("
                strSQL = strSQL & "OP_AL_CDE nvarchar(3),"
                strSQL = strSQL & "AP_CDE nvarchar(5),"
                strSQL = strSQL & "OP_FLT_NUM numeric(4,0),"
                strSQL = strSQL & "FLT_SCHED_DTM datetime,"
                strSQL = strSQL & "ARR_DPTR_CDE nvarchar(1),"
                strSQL = strSQL & "CNTNR_SEQ_NUM numeric(6),"
                strSQL = strSQL & "CNTNR_ID nvarchar(10) NULL,"
                strSQL = strSQL & "CNTNR_TYP_CDE nvarchar(6) NULL,"
                strSQL = strSQL & "CNTNR_STATS_CDE nvarchar(1) NULL,"
                strSQL = strSQL & "POS_NUM nvarchar(2) NULL,"
                strSQL = strSQL & "FLT_DPTR_DTM datetime NOT NULL,"
                strSQL = strSQL & "TRNSF_OP_AL_CDE nvarchar(3) NULL,"
                strSQL = strSQL & "TRNSF_OP_FLT_NUM numeric(4,0) NULL,"
                strSQL = strSQL & "TRNSF_DPTR_DTM datetime NULL,"
                strSQL = strSQL & "TRNSF_DEST_AP_CDE nvarchar(5) NULL,"
                strSQL = strSQL & "FNL_DEST_AP_CDE nvarchar(5) NULL,"
                strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL,"
                strSQL = strSQL & "SCANNED_TIME datetime NULL,"
                strSQL = strSQL & "CONSTRAINT pkContainer PRIMARY KEY(OP_AL_CDE, AP_CDE, OP_FLT_NUM, FLT_SCHED_DTM, "
                strSQL = strSQL & "ARR_DPTR_CDE, CNTNR_SEQ_NUM))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "CREATE TABLE T_Line_Item("
                strSQL = strSQL & "LIN_ITEM_SEQ_NUM nvarchar(9) NOT NULL,"
                strSQL = strSQL & "OP_AL_CDE nvarchar(3) NOT NULL,"
                strSQL = strSQL & "OP_FLT_NUM numeric(4,0),"
                strSQL = strSQL & "FLT_SCHED_DTM datetime,"
                strSQL = strSQL & "MSG_LIN_NUM nvarchar(4) NULL,"
                strSQL = strSQL & "POS_NUM nvarchar(2) NULL,"
                strSQL = strSQL & "CNTNR_ID nvarchar(10) NULL,"
                strSQL = strSQL & "CMDTY_TYP_CDE nvarchar(8) NOT NULL,"
                strSQL = strSQL & "THRU_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "FNL_DEST_AP_CD nvarchar(5) NOT NULL,"
                strSQL = strSQL & "WF_CGO_WT_LBS numeric(6,1) NULL,"
                strSQL = strSQL & "WF_CGO_PCS_CNT numeric(5) NULL,"
                strSQL = strSQL & "SCNR_ID nvarchar(6) NOT NULL,"
                strSQL = strSQL & "USR_ID nvarchar(6) NOT NULL,"
                strSQL = strSQL & "RMK_TXT nvarchar(15) NULL,"
                strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL,"
                strSQL = strSQL & "SCANNED_TIME datetime NULL,"
                strSQL = strSQL & "AP_CDE nvarchar(5),"
                strSQL = strSQL & "CONSTRAINT pkLineItem PRIMARY KEY(LIN_ITEM_SEQ_NUM))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "CREATE TABLE T_Airline_Code("
                strSQL = strSQL & "AL_CDE nvarchar(3),"
                strSQL = strSQL & "AL_NME nvarchar(35) NOT NULL,"
                strSQL = strSQL & "AL_NUM nvarchar(3) NOT NULL,"
                strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL,"
                strSQL = strSQL & "CONSTRAINT pkAirCode PRIMARY KEY(AL_CDE))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "CREATE TABLE T_Error_Code("
                strSQL = strSQL & "CODE nvarchar(10),"
                strSQL = strSQL & "TYPE nvarchar(10) NOT NULL,"
                strSQL = strSQL & "DESCRIP nvarchar(250) NOT NULL,"
                strSQL = strSQL & "SEVERITY_LEVEL nvarchar(2) NOT NULL,"
                strSQL = strSQL & "ACTION nvarchar(20) NOT NULL,"
                strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL,"
                strSQL = strSQL & "CONSTRAINT pkErrCode PRIMARY KEY(CODE))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "CREATE TABLE T_Flight_Info("
                strSQL = strSQL & "AP_CDE nvarchar(5),"
                strSQL = strSQL & "OP_AL_CDE nvarchar(3),"
                strSQL = strSQL & "FLT_SCHED_DTM datetime,"
                strSQL = strSQL & "FLT_GND_DTM datetime,"
                strSQL = strSQL & "WF_STATS_CDE nvarchar(3),"
                strSQL = strSQL & "FLT_EST_DTM datetime,"
                strSQL = strSQL & "OP_FLT_NUM numeric(4,0),"
                strSQL = strSQL & "IS_NEW_REQUEST nvarchar(5),"
                strSQL = strSQL & "ARR_DPTR_CDE nvarchar(1),"
                strSQL = strSQL & "LEG_SEQ_NUM numeric(2),"
                strSQL = strSQL & "GATE_CDE nvarchar(5) NOT NULL,"
                strSQL = strSQL & "AC_NOSE_NUM nvarchar(5) NOT NULL,"
                strSQL = strSQL & "ORIG_DEST_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "PRE_CLOSE nvarchar(1) NOT NULL,"
                strSQL = strSQL & "IS_CLOSE nvarchar(1) NOT NULL,"
                strSQL = strSQL & "IS_WIDE_BODY nvarchar(1) NOT NULL,"
                strSQL = strSQL & "INTL_CTY_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL,"
                strSQL = strSQL & "CONSTRAINT pkFltinfo PRIMARY KEY(AP_CDE, OP_AL_CDE, FLT_SCHED_DTM, OP_FLT_NUM,ARR_DPTR_CDE, LEG_SEQ_NUM))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "CREATE TABLE T_Sync_Time("
                strSQL = strSQL & "TABLE_NAME nvarchar(40),"
                strSQL = strSQL & "SYNC_UPLOAD_TIME datetime NULL,"
                strSQL = strSQL & "SYNC_DOWNLOAD_TIME datetime NULL,"
                strSQL = strSQL & "CONSTRAINT pkSynTime PRIMARY KEY(TABLE_NAME))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                'strSQL = "create index airconfigselectindex on T_Aircraft_Config (MODIFIED_TIME)"
                'ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                'strSQL = "create index passconfigselectindex on T_Passenger_Config (MODIFIED_TIME)"
                'ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "create index bagtagselectindex on T_Bag_Tag (SCANNED_TIME)"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "create index freightselectindex on T_Freight (SCANNED_TIME)"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "create index mailselectindex on T_Mail (SCANNED_TIME)"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "create index containerselectindex on T_Container (SCANNED_TIME)"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "create index lineitemselectindex on T_Line_Item (SCANNED_TIME)"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "create index aircodeselectindex on T_Airline_Code (MODIFIED_TIME)"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "create index errcodeselectindex on T_Error_Code (MODIFIED_TIME)"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "create index fltinfoselectindex on T_Flight_Info (MODIFIED_TIME)"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)



                '''''''''''''''''Temp Tables               

                strSQL = "CREATE TABLE tempT_Bag_Tag("
                strSQL = strSQL & "OP_AL_CDE nvarchar(3),"
                strSQL = strSQL & "OP_FLT_NUM numeric(4,0),"
                strSQL = strSQL & "FLT_SCHED_DTM datetime,"
                strSQL = strSQL & "BAG_ID nvarchar(10),"
                strSQL = strSQL & "BAG_PSGR_SEQ_NUM numeric(7,0),"
                strSQL = strSQL & "AP_CDE nvarchar(5) NOT NULL,"
                strSQL = strSQL & "CNTNR_SEQ_NUM numeric(6) NULL,"
                strSQL = strSQL & "BAG_TYP_CDE nvarchar(4) NULL,"
                strSQL = strSQL & "CNTNR_ID nvarchar(10) NULL,"
                strSQL = strSQL & "BAG_TAG_CRTN_DTM datetime NOT NULL,"
                strSQL = strSQL & "DEST_AP_CDE nvarchar(5) NOT NULL,"
                strSQL = strSQL & "BSM_CRTN_DTM datetime NULL,"
                strSQL = strSQL & "BAG_CRTN_TYP_CDE nvarchar(1) NOT NULL,"
                strSQL = strSQL & "BSM_DEL_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "LD_AUTH_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "SCRTY_STATS_CDE nvarchar(1) NOT NULL,"
                strSQL = strSQL & "CBN_CL_CDE nvarchar(1) NULL,"
                strSQL = strSQL & "LD_STATS_CDE nvarchar(1) NOT NULL,"
                strSQL = strSQL & "OFLD_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "LD_SEQ_NUM numeric(4) NULL,"
                strSQL = strSQL & "RLBL_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "XPDT_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "BAG_WT_LB numeric(6,1) NULL,"
                strSQL = strSQL & "POS_NUM nvarchar(2) NULL,"
                strSQL = strSQL & "DMGD_IND nvarchar(1) NULL,"
                strSQL = strSQL & "TRKG_IND nvarchar(1) NULL,"
                strSQL = strSQL & "SHRT_CONN_FLT_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "ALRT_TMS datetime NULL,"
                strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL,"
                strSQL = strSQL & "SCANNED_TIME datetime NULL,"
                strSQL = strSQL & "CONSTRAINT pkBagTag PRIMARY KEY(OP_AL_CDE, OP_FLT_NUM, FLT_SCHED_DTM, BAG_ID,BAG_PSGR_SEQ_NUM))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "CREATE TABLE tempT_Freight("
                strSQL = strSQL & "OP_AL_CDE nvarchar(3),"
                strSQL = strSQL & "AP_CDE nvarchar(5),"
                strSQL = strSQL & "OP_FLT_NUM numeric(4,0),"
                strSQL = strSQL & "FLT_SCHED_DTM datetime,"
                strSQL = strSQL & "ARR_DPTR_CDE nvarchar(1),"
                strSQL = strSQL & "AWB_NUM nvarchar(18),"
                strSQL = strSQL & "WF_SCRN_LIN_ITM_NUM numeric(4,0) NULL,"
                strSQL = strSQL & "CMDTY_TYP_CDE nvarchar(8) NOT NULL,"
                strSQL = strSQL & "ITM_CNT numeric(4) NOT NULL,"
                strSQL = strSQL & "ITM_WT_LB numeric(6,1) NOT NULL,"
                strSQL = strSQL & "AVG_ITM_WT_LB numeric(6,1) NOT NULL,"
                strSQL = strSQL & "DEST_AP_CDE nvarchar(5) NOT NULL,"
                strSQL = strSQL & "FNL_DEST_AP_CDE nvarchar(5) NULL,"
                strSQL = strSQL & "THRU_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "POS_NUM nvarchar(2) NULL,"
                strSQL = strSQL & "PREV_POS_NUM nvarchar(2) NULL,"
                strSQL = strSQL & "LOAD_SEQ_NUM numeric(3) NULL,"
                strSQL = strSQL & "LOAD_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "SCN_IND nvarchar(1) NULL,"
                strSQL = strSQL & "SCN_DTM datetime  NULL,"
                strSQL = strSQL & "CNTNR_SEQ_NUM numeric(6) NULL,"
                strSQL = strSQL & "XPDT_IND nvarchar(1) NULL, "
                strSQL = strSQL & "DNGR_FRGT_IND nvarchar(1) NULL,"
                strSQL = strSQL & "FRGT_STG_LOC_CDE nvarchar(11) NULL,"
                strSQL = strSQL & "PREV_FRGT_STG_LOC_CDE nvarchar(11) NULL,"
                strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL,"
                strSQL = strSQL & "SCANNED_TIME datetime NULL,"
                strSQL = strSQL & "CONSTRAINT pkFreight PRIMARY KEY(OP_AL_CDE, AP_CDE, OP_FLT_NUM, FLT_SCHED_DTM,ARR_DPTR_CDE, AWB_NUM))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "CREATE TABLE tempT_Mail("
                strSQL = strSQL & "MAIL_UNIT_SEQ_NUM numeric(7),"
                strSQL = strSQL & "MAIL_BRCD_ID nvarchar(30) NOT NULL,"
                strSQL = strSQL & "AP_CDE nvarchar(5) NULL,"
                strSQL = strSQL & "OP_AL_CDE nvarchar(3) NOT NULL,"
                strSQL = strSQL & "OP_FLT_NUM numeric(4,0) NULL,"
                strSQL = strSQL & "FLT_SCHED_DTM datetime NULL,"
                strSQL = strSQL & "DEST_AP_CDE nvarchar(5) NULL,"
                strSQL = strSQL & "FNL_DEST_AP_CDE nvarchar(5) NULL,"
                strSQL = strSQL & "POS_ID nvarchar(2) NULL,"
                strSQL = strSQL & "CNTNR_SEQ_NUM numeric(6) NULL,"
                strSQL = strSQL & "LD_SEQ_NUM numeric(4) NULL,"
                strSQL = strSQL & "CMDTY_TYP_CDE nvarchar(8) NULL,"
                strSQL = strSQL & "TOT_WT_LB numeric(6,1) NULL,"
                strSQL = strSQL & "ITM_CNT numeric(5) NULL,"
                strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL, "
                strSQL = strSQL & "SCANNED_TIME datetime NULL,"
                strSQL = strSQL & "CONSTRAINT pkMail PRIMARY KEY(MAIL_BRCD_ID))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "CREATE TABLE tempT_Container("
                strSQL = strSQL & "OP_AL_CDE nvarchar(3),"
                strSQL = strSQL & "AP_CDE nvarchar(5),"
                strSQL = strSQL & "OP_FLT_NUM numeric(4,0),"
                strSQL = strSQL & "FLT_SCHED_DTM datetime,"
                strSQL = strSQL & "ARR_DPTR_CDE nvarchar(1),"
                strSQL = strSQL & "CNTNR_SEQ_NUM numeric(6),"
                strSQL = strSQL & "CNTNR_ID nvarchar(10) NULL,"
                strSQL = strSQL & "CNTNR_TYP_CDE nvarchar(6) NULL,"
                strSQL = strSQL & "CNTNR_STATS_CDE nvarchar(1) NULL,"
                strSQL = strSQL & "POS_NUM nvarchar(2) NULL,"
                strSQL = strSQL & "FLT_DPTR_DTM datetime NOT NULL,"
                strSQL = strSQL & "TRNSF_OP_AL_CDE nvarchar(3) NULL,"
                strSQL = strSQL & "TRNSF_OP_FLT_NUM numeric(4,0) NULL,"
                strSQL = strSQL & "TRNSF_DPTR_DTM datetime NULL,"
                strSQL = strSQL & "TRNSF_DEST_AP_CDE nvarchar(5) NULL,"
                strSQL = strSQL & "FNL_DEST_AP_CDE nvarchar(5) NULL,"
                strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL,"
                strSQL = strSQL & "SCANNED_TIME datetime NULL,"
                strSQL = strSQL & "CONSTRAINT pkContainer PRIMARY KEY(OP_AL_CDE, AP_CDE, OP_FLT_NUM, FLT_SCHED_DTM, "
                strSQL = strSQL & "ARR_DPTR_CDE, CNTNR_SEQ_NUM))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "CREATE TABLE tempT_Line_Item("
                strSQL = strSQL & "LIN_ITEM_SEQ_NUM nvarchar(9) NOT NULL,"
                strSQL = strSQL & "OP_AL_CDE nvarchar(3) NOT NULL,"
                strSQL = strSQL & "OP_FLT_NUM numeric(4,0),"
                strSQL = strSQL & "FLT_SCHED_DTM datetime,"
                strSQL = strSQL & "MSG_LIN_NUM nvarchar(4) NULL,"
                strSQL = strSQL & "POS_NUM nvarchar(2) NULL,"
                strSQL = strSQL & "CNTNR_ID nvarchar(10) NULL,"
                strSQL = strSQL & "CMDTY_TYP_CDE nvarchar(8) NOT NULL,"
                strSQL = strSQL & "THRU_IND nvarchar(1) NOT NULL,"
                strSQL = strSQL & "FNL_DEST_AP_CD nvarchar(5) NOT NULL,"
                strSQL = strSQL & "WF_CGO_WT_LBS numeric(6,1) NULL,"
                strSQL = strSQL & "WF_CGO_PCS_CNT numeric(5) NULL,"
                strSQL = strSQL & "SCNR_ID nvarchar(6) NOT NULL,"
                strSQL = strSQL & "USR_ID nvarchar(6) NOT NULL,"
                strSQL = strSQL & "RMK_TXT nvarchar(15) NULL,"
                strSQL = strSQL & "MODIFIED_TIME datetime NOT NULL,"
                strSQL = strSQL & "SCANNED_TIME datetime NULL,"
                strSQL = strSQL & "AP_CDE nvarchar(5),"
                strSQL = strSQL & "CONSTRAINT pkLineItem PRIMARY KEY(LIN_ITEM_SEQ_NUM))"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "create index bagtagselectindex on tempT_Bag_Tag (SCANNED_TIME)"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "create index freightselectindex on tempT_Freight (SCANNED_TIME)"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "create index mailselectindex on tempT_Mail (SCANNED_TIME)"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "create index containerselectindex on tempT_Container (SCANNED_TIME)"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "create index lineitemselectindex on tempT_Line_Item (SCANNED_TIME)"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                '''''''''End of Temp table

                Dim dt As New DateTime(2007, 10, 29, 0, 0, 0)
                Dim dt1 As New DateTime(2007, 11, 9, 0, 0, 0)
                Dim dt2 As New DateTime(2007, 10, 25, 0, 0, 0)
                Dim dt3 As New DateTime(2007, 10, 29, 0, 0, 0)
                Dim dt4 As New DateTime(2007, 10, 30, 0, 0, 0)
                Dim dt5 As New DateTime(2007, 10, 25, 0, 0, 0)
                Dim dt6 As New DateTime(2007, 11, 5, 0, 0, 0)
                Dim dt7 As New DateTime(2007, 11, 8, 0, 0, 0)
                Dim dt8 As New DateTime(2007, 10, 25, 0, 0, 0)

                Dim dtT As New DateTime(2007, 9, 25, 19, 58, 19)



                strSQL = "Insert into T_Flight_Info Values('MSP','NW','" & Format(dt, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dt, "yyyy-MM-dd HH:mm:ss") & "','1','" & Format(dt, "yyyy-MM-dd HH:mm:ss") & "',461,'Y','D',0,'A12','00991','N','N','N','N','N',getdate())"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "Insert into T_Flight_Info Values('MSP','NW','" & Format(dt1, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dt1, "yyyy-MM-dd HH:mm:ss") & "','2','" & Format(dt1, "yyyy-MM-dd HH:mm:ss") & "',42,'Y','D',0,'A12','00991','N','N','N','N','N',getdate())"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "Insert into T_Flight_Info Values('MSP','NW','" & Format(dt2, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dt2, "yyyy-MM-dd HH:mm:ss") & "','1','" & Format(dt2, "yyyy-MM-dd HH:mm:ss") & "',574,'Y','D',0,'A12','00991','N','N','N','N','N',getdate())"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "Insert into T_Flight_Info Values('MSP','NW','" & Format(dt3, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dt3, "yyyy-MM-dd HH:mm:ss") & "','1','" & Format(dt2, "yyyy-MM-dd HH:mm:ss") & "',1235,'Y','D',0,'A12','00991','N','N','N','N','N',getdate())"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "Insert into T_Flight_Info Values('MSP','NW','" & Format(dt4, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dt4, "yyyy-MM-dd HH:mm:ss") & "','1','" & Format(dt4, "yyyy-MM-dd HH:mm:ss") & "',1154,'Y','D',0,'A12','00991','N','N','N','N','N',getdate())"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "Insert into T_Flight_Info Values('MSP','NW','" & Format(dt5, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dt5, "yyyy-MM-dd HH:mm:ss") & "','1','" & Format(dt5, "yyyy-MM-dd HH:mm:ss") & "',44,'Y','D',0,'A12','00991','N','N','N','N','N',getdate())"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "Insert into T_Flight_Info Values('LAX','NW','" & Format(dt6, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dt6, "yyyy-MM-dd HH:mm:ss") & "','1','" & Format(dt6, "yyyy-MM-dd HH:mm:ss") & "',802,'Y','D',0,'A12','00991','N','N','N','N','N',getdate())"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                strSQL = "Insert into T_Flight_Info Values('LAX','NW','" & Format(dt7, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dt7, "yyyy-MM-dd HH:mm:ss") & "','1','" & Format(dt7, "yyyy-MM-dd HH:mm:ss") & "',68,'Y','D',0,'A12','00991','N','N','N','N','N',getdate())"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                'strSQL = "Insert into T_Flight_Info Values('LAX','NW','" & Format(dt8, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dt8, "yyyy-MM-dd HH:mm:ss") & "','1','" & Format(dt8, "yyyy-MM-dd HH:mm:ss") & "',574,'Y','D',12,'A12','00991','N','N','N','N','N',getdate())"
                'ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                'strSQL = "Insert into T_Flight_Info Values('PDX','NW','" & Format(dt, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dt, "yyyy-MM-dd HH:mm:ss") & "',461,'Y','D',13,'00992','Y','N','N',getdate())"
                'ExecuteNonQuery(strConStr, CommandType.Text, strSQL)


                strSQL = "Insert into T_Sync_Time Values('T_Aircraft_Config','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "')"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)
                strSQL = "Insert into T_Sync_Time Values('T_Passenger_Config','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "')"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)
                strSQL = "Insert into T_Sync_Time Values('T_Bag_Tag','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "')"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)
                strSQL = "Insert into T_Sync_Time Values('T_Freight','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "')"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)
                strSQL = "Insert into T_Sync_Time Values('T_Mail','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "')"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)
                strSQL = "Insert into T_Sync_Time Values('T_Container','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "')"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)
                strSQL = "Insert into T_Sync_Time Values('T_Line_Item','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "')"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)
                strSQL = "Insert into T_Sync_Time Values('T_Airline_Code','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "')"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)
                strSQL = "Insert into T_Sync_Time Values('T_Error_Code','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "')"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)
                strSQL = "Insert into T_Sync_Time Values('T_Flight_Info','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "','" & Format(dtT, "yyyy-MM-dd HH:mm:ss") & "')"
                ExecuteNonQuery(strConStr, CommandType.Text, strSQL)




                'Dim i As Int16 = 1
                'For i = 0 To 5
                'cmd.CommandText = "Insert Into Employ Values('NWA" & i & "',20)"
                'strSQL = "Insert into T_Bag_Tag Values('" & i & "'," & 8 + i & ",getdate(),'N0Y" & i & "'," & 4 + i & ",'MSP',101010,'Y','HK1001',getdate(),'CHG',getdate(),'B','y','N','S','O','L','O',1234,'R','X',12224.3,12,'D','T','S',getdate(),getdate(),getdate())"
                'strSQL = "Insert into T_Bag_Tag Values('" & i & "'," & 8 + i & ",getdate(),'N0Y" & i & "'," & 4 + i & ",'MSP',101010,'Y','HK1001',getdate(),'CHG',getdate(),'B','y','N','S','O','L','O',1234,'R','X',12224.3,12,'D','T','S',getdate(),getdate(),getdate())"
                'strSQL = "Insert into T_Bag_Tag Values('1',7,'" & Format(dt, "yyyy-MM-dd HH:mm:ss") & "','N0P101',5,'MSP',101010,'Y','HK1001',getdate(),'CHG',getdate(),'B','y','N','S','O','L','O',1234,'R','X',12224.3,12,'D','T','S',getdate(),getdate(),getdate())"
                'ExecuteNonQuery(strConStr, CommandType.Text, strSQL)
                ''Next i
                'strSQL = "Insert into T_Flight_Info Values('MSP','NWA','" & Format(dt, "yyyy-MM-dd HH:mm:ss") & "',9900,'true','D',12,'00991','N','N','N',getdate())"
                'ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                'strSQL = "Insert into T_Flight_Info Values('MSP','NW','" & Format(dt1, "yyyy-MM-dd HH:mm:ss") & "',4660,'true','D',13,'00992','Y','N','N',getdate())"
                'ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

                'strSQL = "Insert into T_Sync_Time Values('T_Flight_Info',getdate(),getdate())"
                'ExecuteNonQuery(strConStr, CommandType.Text, strSQL)

            Catch ex As SqlCeException
                MsgBox(ex.Message)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                SqlEngine.Dispose()
                'If SqlEngine != DBNull Then SqlEngine.Dispose()
            End Try
        End Sub
    End Class
End Namespace

