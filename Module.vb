Module TALLY_Module
    'Public conn As String = "data source=168.100.1.37;initial catalog=Tally;password=tally123;persist security info=True;user id=tally;workstation id=LXJ;packet size=4096"
    Public conn As String = "data source=168.100.1.10;initial catalog=Tally;password=tally_j2mv9;persist security info=True;user id=tally;workstation id=LXJ;packet size=4096"
    Public conn_ver As String = "data source=168.100.1.10;initial catalog=Tally_verify;password=tally_j2mv9;persist security info=True;user id=tally;workstation id=LXJ;packet size=4096"
    Public conn_rs As String = "data source=168.100.1.10;initial catalog=tally_rs;password=tally_j2mv9;persist security info=True;user id=tally;workstation id=CENTER-T433F6I4;packet size=4096"
    Public conn_tally As String = "data source=168.122.9.1;initial catalog=Tally;password=tally_j2mv9;persist security info=True;user id=tally;workstation id=CENTER-T433F6I4;packet size=4096"
    Public sqlconn As New SqlClient.SqlConnection(conn)

    Public xlApp As Excel.Application  '定义EXCEL 应用程序
    Public xlBook As Excel.Workbook    '定义EXCEL 工作薄
    Public xlSheet As Excel.Worksheet  '定义EXCEL 工作表
    Public TBar As Integer = 1         'TOOLBAR可见的标志位
    Public Mnu As Integer = 1         'FRMMAIN上的菜单可见的标志位
    Public ProcessIDs(10) As Integer

    '******************Group    
    Public G_User As String '操作员名
    Public G_User_Serial As String '操作员工号
    Public G_CurrentTime As DateTime '当前时间
    Public G_DeptCode As String '操作员所属部门代码
    Public G_DeptName As String '操作员所属部门名称
    Public G_Part_Id As Integer '角色ID
    Public G_Part As String '操作员角色
    Public G_SelectCode As String  '存放由查询返回的带回的代码
    Public G_SelectStr As String  '存放由查询返回的带回的String 
    Public G_ShipName As String '
    Public G_Voyage As String


    Public G_WorkNo As String '登录人员工号
    Public G_Date As DateTime
    Public G_BC As String
    Public G_BB As String
    Public G_Lock As String
    Public Flag As Integer '检索Flag
    Public Sql_Find As String '检索sql
    Public Table_Name As String '检索表名
    Public ID As Integer '数据库中ID 标识字段
    Public Ship_ID As Integer '船舶航次ID 标识字段
    Public SortStr As String '排序
    Public Inoutport_Cha As String '中文出口1，进口0
    Public Inoutport_eng As String '英文出口1，进口0
    '*********************ZLP
    Public Hatch_in As Integer '出口1，进口0
    Public dsdaily As New DataSet '日报
    Public dsdaily_other As New DataSet '日报
    Public REMARKS As String '日报备注
    Public REMARKS_OTHER As String '翻舱日报备注
    Public OKMARK As Integer '日报确定
    Public OKMARK_OTHER As Integer '翻舱日报确定
    Public OKQUERY As Integer '日报查询
    Public OKQUERY_OTHER As Integer '翻舱日报查询
    Public ff As Integer '翻舱类别
    Public UNLOADPORT As String '卸货港代码
    Public DS_DO As New DataSet   '处理结果
    Public trade As String '内外贸 1为内贸 2为外贸
    Public ds_sship As New DataSet   '船舶信息
    Public mark As String '是否处理 1为处理 0为未处理
    Public LISTTIME As DateTime '报表日期
    Public LIST_DEPTNAME As String '报表部门
    Public LIST_MAN As String '报表人员
    '******************GL    
    Public GL_Time As Date
    Public GL_Str As String
    Public GL_ID As Integer
    Public GL_Clerk As Integer
    Public GL_Date As DateTime
    Public GL_Date1 As DateTime
    Public PortCode As String
    Public GL_Deptflag As String '考勤中变换的部门
    Public GL_Shift As String
    Public GL_WCRB As String '完船日报
    Public GL_FAX As String '传递消息
    Public GL_READ As Integer
    Public GL_hatch As Integer '舱口数
    Public GL_IOPORT As String
    'pan
    Public SysType As String = "1"   '系统类别：1散杂货，2集装箱，0全部

End Module
