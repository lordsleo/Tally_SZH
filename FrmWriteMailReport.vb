Imports System.Web.Mail
Imports System.IO
Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmWriteMailReport
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet
    Dim dw As New DataView
    Dim sqlstr As String
    Dim sqlBlnosList As String
    Dim dsBlnoslist As New DataSet
    Dim dvBlnosList As DataView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbTrade As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbRoute As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbHgLoad As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents rbDel As System.Windows.Forms.RadioButton
    Friend WithEvents rbAdd As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnSelAll As System.Windows.Forms.Button
    Dim BackUpFile As String

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写 dispose 以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btRead As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LSign As System.Windows.Forms.TextBox
    Friend WithEvents PB As System.Windows.Forms.ProgressBar
    Friend WithEvents LNextPort As System.Windows.Forms.Label
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents rbJT As System.Windows.Forms.RadioButton
    Friend WithEvents LShipOwner As System.Windows.Forms.Label
    Friend WithEvents LShipCompany As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbEmail As System.Windows.Forms.ComboBox
    Friend WithEvents txtShipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LJinChu As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LVoyage As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LEnglish As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LChina As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btWriteNew As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents OpenFile As System.Windows.Forms.Button
    Friend WithEvents 船长 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTallyName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents 开工时间 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LStartTime As System.Windows.Forms.TextBox
    Friend WithEvents LEndTime As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWriteMailReport))
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.btRead = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.LSign = New System.Windows.Forms.TextBox
        Me.PB = New System.Windows.Forms.ProgressBar
        Me.LNextPort = New System.Windows.Forms.Label
        Me.GB = New System.Windows.Forms.GroupBox
        Me.rbJT = New System.Windows.Forms.RadioButton
        Me.LShipOwner = New System.Windows.Forms.Label
        Me.LShipCompany = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbEmail = New System.Windows.Forms.ComboBox
        Me.txtShipCode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LJinChu = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LVoyage = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LEnglish = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LChina = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btWriteNew = New System.Windows.Forms.Button
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.OpenFile = New System.Windows.Forms.Button
        Me.船长 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtPhoneCode = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTallyName = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LStartTime = New System.Windows.Forms.TextBox
        Me.开工时间 = New System.Windows.Forms.Label
        Me.LEndTime = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbTrade = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbRoute = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbHgLoad = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.rbDel = New System.Windows.Forms.RadioButton
        Me.rbAdd = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnSelAll = New System.Windows.Forms.Button
        Me.GB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btRead
        '
        Me.btRead.Location = New System.Drawing.Point(4, 237)
        Me.btRead.Name = "btRead"
        Me.btRead.Size = New System.Drawing.Size(70, 22)
        Me.btRead.TabIndex = 91
        Me.btRead.Text = "查看报文"
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(236, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 14)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "IMO"
        '
        'LSign
        '
        Me.LSign.Location = New System.Drawing.Point(266, 20)
        Me.LSign.Name = "LSign"
        Me.LSign.Size = New System.Drawing.Size(104, 21)
        Me.LSign.TabIndex = 89
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(3, 263)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(368, 18)
        Me.PB.TabIndex = 88
        '
        'LNextPort
        '
        Me.LNextPort.Location = New System.Drawing.Point(356, 176)
        Me.LNextPort.Name = "LNextPort"
        Me.LNextPort.Size = New System.Drawing.Size(8, 8)
        Me.LNextPort.TabIndex = 86
        Me.LNextPort.Visible = False
        '
        'GB
        '
        Me.GB.Controls.Add(Me.rbJT)
        Me.GB.Location = New System.Drawing.Point(80, 213)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(102, 48)
        Me.GB.TabIndex = 85
        Me.GB.TabStop = False
        Me.GB.Text = "报文类型"
        '
        'rbJT
        '
        Me.rbJT.Checked = True
        Me.rbJT.Location = New System.Drawing.Point(8, 26)
        Me.rbJT.Name = "rbJT"
        Me.rbJT.Size = New System.Drawing.Size(87, 20)
        Me.rbJT.TabIndex = 0
        Me.rbJT.TabStop = True
        Me.rbJT.Text = "交通部平台"
        '
        'LShipOwner
        '
        Me.LShipOwner.Location = New System.Drawing.Point(330, 201)
        Me.LShipOwner.Name = "LShipOwner"
        Me.LShipOwner.Size = New System.Drawing.Size(8, 8)
        Me.LShipOwner.TabIndex = 84
        Me.LShipOwner.Visible = False
        '
        'LShipCompany
        '
        Me.LShipCompany.Location = New System.Drawing.Point(344, 201)
        Me.LShipCompany.Name = "LShipCompany"
        Me.LShipCompany.Size = New System.Drawing.Size(6, 8)
        Me.LShipCompany.TabIndex = 83
        Me.LShipCompany.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(493, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "收文用户"
        '
        'cbEmail
        '
        Me.cbEmail.Location = New System.Drawing.Point(555, 18)
        Me.cbEmail.Name = "cbEmail"
        Me.cbEmail.Size = New System.Drawing.Size(130, 20)
        Me.cbEmail.TabIndex = 81
        '
        'txtShipCode
        '
        Me.txtShipCode.Location = New System.Drawing.Point(424, 20)
        Me.txtShipCode.Name = "txtShipCode"
        Me.txtShipCode.Size = New System.Drawing.Size(42, 21)
        Me.txtShipCode.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(388, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 14)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "船码"
        '
        'LJinChu
        '
        Me.LJinChu.Location = New System.Drawing.Point(146, 24)
        Me.LJinChu.Name = "LJinChu"
        Me.LJinChu.Size = New System.Drawing.Size(60, 14)
        Me.LJinChu.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(101, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 14)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "进出口"
        '
        'LVoyage
        '
        Me.LVoyage.ForeColor = System.Drawing.Color.Blue
        Me.LVoyage.Location = New System.Drawing.Point(36, 24)
        Me.LVoyage.Name = "LVoyage"
        Me.LVoyage.Size = New System.Drawing.Size(62, 14)
        Me.LVoyage.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "航次"
        '
        'LEnglish
        '
        Me.LEnglish.ForeColor = System.Drawing.Color.Blue
        Me.LEnglish.Location = New System.Drawing.Point(240, 4)
        Me.LEnglish.Name = "LEnglish"
        Me.LEnglish.Size = New System.Drawing.Size(128, 16)
        Me.LEnglish.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(184, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "英文船名"
        '
        'LChina
        '
        Me.LChina.ForeColor = System.Drawing.Color.Blue
        Me.LChina.Location = New System.Drawing.Point(58, 4)
        Me.LChina.Name = "LChina"
        Me.LChina.Size = New System.Drawing.Size(124, 16)
        Me.LChina.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "中文船名"
        '
        'btWriteNew
        '
        Me.btWriteNew.Location = New System.Drawing.Point(4, 209)
        Me.btWriteNew.Name = "btWriteNew"
        Me.btWriteNew.Size = New System.Drawing.Size(70, 24)
        Me.btWriteNew.TabIndex = 70
        Me.btWriteNew.Text = "生成报文"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(2, 185)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(304, 21)
        Me.txtFile.TabIndex = 69
        '
        'OpenFile
        '
        Me.OpenFile.Location = New System.Drawing.Point(308, 184)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Size = New System.Drawing.Size(62, 24)
        Me.OpenFile.TabIndex = 68
        Me.OpenFile.Text = "打开文件"
        '
        '船长
        '
        Me.船长.Location = New System.Drawing.Point(2, 115)
        Me.船长.Name = "船长"
        Me.船长.Size = New System.Drawing.Size(80, 16)
        Me.船长.TabIndex = 92
        Me.船长.Text = "船长大副姓名"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(78, 113)
        Me.txtName.MaxLength = 35
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(292, 21)
        Me.txtName.TabIndex = 93
        '
        'txtPhoneCode
        '
        Me.txtPhoneCode.Location = New System.Drawing.Point(106, 137)
        Me.txtPhoneCode.MaxLength = 50
        Me.txtPhoneCode.Name = "txtPhoneCode"
        Me.txtPhoneCode.Size = New System.Drawing.Size(264, 21)
        Me.txtPhoneCode.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(2, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "船长大副联系号码"
        '
        'txtTallyName
        '
        Me.txtTallyName.Location = New System.Drawing.Point(96, 161)
        Me.txtTallyName.MaxLength = 35
        Me.txtTallyName.Name = "txtTallyName"
        Me.txtTallyName.Size = New System.Drawing.Size(274, 21)
        Me.txtTallyName.TabIndex = 97
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(2, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "理货责任人名称"
        '
        'LStartTime
        '
        Me.LStartTime.Location = New System.Drawing.Point(60, 66)
        Me.LStartTime.MaxLength = 35
        Me.LStartTime.Name = "LStartTime"
        Me.LStartTime.Size = New System.Drawing.Size(122, 21)
        Me.LStartTime.TabIndex = 100
        '
        '开工时间
        '
        Me.开工时间.Location = New System.Drawing.Point(2, 68)
        Me.开工时间.Name = "开工时间"
        Me.开工时间.Size = New System.Drawing.Size(54, 16)
        Me.开工时间.TabIndex = 99
        Me.开工时间.Text = "开工时间"
        '
        'LEndTime
        '
        Me.LEndTime.Location = New System.Drawing.Point(240, 66)
        Me.LEndTime.MaxLength = 35
        Me.LEndTime.Name = "LEndTime"
        Me.LEndTime.Size = New System.Drawing.Size(130, 21)
        Me.LEndTime.TabIndex = 102
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(184, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "完工时间"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(184, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 16)
        Me.Label12.TabIndex = 110
        Me.Label12.Text = "内外贸"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbTrade
        '
        Me.cbTrade.Location = New System.Drawing.Point(240, 44)
        Me.cbTrade.Name = "cbTrade"
        Me.cbTrade.Size = New System.Drawing.Size(130, 20)
        Me.cbTrade.TabIndex = 109
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(1, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 16)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "航次标志"
        '
        'cbRoute
        '
        Me.cbRoute.Location = New System.Drawing.Point(60, 45)
        Me.cbRoute.Name = "cbRoute"
        Me.cbRoute.Size = New System.Drawing.Size(122, 20)
        Me.cbRoute.TabIndex = 107
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(1, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "装卸货地"
        '
        'cbHgLoad
        '
        Me.cbHgLoad.Location = New System.Drawing.Point(60, 89)
        Me.cbHgLoad.Name = "cbHgLoad"
        Me.cbHgLoad.Size = New System.Drawing.Size(310, 20)
        Me.cbHgLoad.TabIndex = 111
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(302, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 30)
        Me.Button1.TabIndex = 113
        Me.Button1.Text = "退出"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(4, 287)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 74)
        Me.GroupBox1.TabIndex = 114
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "友情提醒"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(18, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(323, 36)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "    请操作人员详细核对上述内容，其中IMO号、航次标志、" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "装卸货地务必选择准确后方可生成报文。"
        '
        'rbDel
        '
        Me.rbDel.Location = New System.Drawing.Point(57, 26)
        Me.rbDel.Name = "rbDel"
        Me.rbDel.Size = New System.Drawing.Size(63, 20)
        Me.rbDel.TabIndex = 1
        Me.rbDel.Text = "删除"
        '
        'rbAdd
        '
        Me.rbAdd.Checked = True
        Me.rbAdd.Location = New System.Drawing.Point(8, 26)
        Me.rbAdd.Name = "rbAdd"
        Me.rbAdd.Size = New System.Drawing.Size(66, 20)
        Me.rbAdd.TabIndex = 0
        Me.rbAdd.TabStop = True
        Me.rbAdd.Text = "增加"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbDel)
        Me.GroupBox2.Controls.Add(Me.rbAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(182, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(114, 48)
        Me.GroupBox2.TabIndex = 115
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "报文类型"
        '
        'C1DBG
        '
        Me.C1DBG.AllowColMove = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FetchRowStyles = True
        Me.C1DBG.FilterBar = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(377, 4)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(319, 330)
        Me.C1DBG.TabIndex = 273
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'btnSelAll
        '
        Me.btnSelAll.Location = New System.Drawing.Point(615, 338)
        Me.btnSelAll.Name = "btnSelAll"
        Me.btnSelAll.Size = New System.Drawing.Size(70, 23)
        Me.btnSelAll.TabIndex = 275
        Me.btnSelAll.Text = "全选"
        '
        'FrmWriteMailReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(698, 367)
        Me.Controls.Add(Me.btnSelAll)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbHgLoad)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbTrade)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbRoute)
        Me.Controls.Add(Me.OpenFile)
        Me.Controls.Add(Me.LEndTime)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LStartTime)
        Me.Controls.Add(Me.开工时间)
        Me.Controls.Add(Me.txtTallyName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPhoneCode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.船长)
        Me.Controls.Add(Me.btRead)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LSign)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.LNextPort)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.LShipOwner)
        Me.Controls.Add(Me.LShipCompany)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbEmail)
        Me.Controls.Add(Me.txtShipCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LJinChu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LVoyage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LEnglish)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LChina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btWriteNew)
        Me.Controls.Add(Me.txtFile)
        Me.Name = "FrmWriteMailReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "生成理货报告报文(件杂货)"
        Me.GB.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub FrmWriteMailReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds1 As New DataSet
        Dim dw1 As New DataView
        Dim ds2 As New DataSet
        Dim dw2 As New DataView
        Dim ds3 As New DataSet
        Dim dw3 As New DataView
        Dim ds4 As New DataSet
        Dim dw4 As New DataView
        Dim ds5 As New DataSet
        Dim dw5 As New DataView
        Dim PathStr As String
        Dim FilePath As String

        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "EDIINI.INI"
            Dim sr As New StreamReader(FilePath) '打开报文文件
            txtFile.Text = sr.ReadLine()
            BackUpFile = sr.ReadLine()
            BackUpFile = sr.ReadLine()
            sr.Close()
        Catch
        End Try

        sqlstr = "select * from EMail_Cust order by ID"
        dw1 = Getdata(sqlstr, ds1)
        cbEmail.DataSource = ds1.Tables(0).DefaultView
        cbEmail.DisplayMember = "E_Name"
        cbEmail.ValueMember = "E_Code"
        cbEmail.SelectedValue = "2301"

        sqlstr = "select * from code_route "
        dw2 = Getdata(sqlstr, ds2)
        cbRoute.DataSource = ds2.Tables(0).DefaultView
        cbRoute.DisplayMember = "routename"
        cbRoute.ValueMember = "coderoute"

        sqlstr = "select * from Code_Trade order by Trade_ID"
        dw3 = Getdata(sqlstr, ds3)
        cbTrade.DataSource = ds3.Tables(0).DefaultView
        cbTrade.DisplayMember = "Trade"
        cbTrade.ValueMember = "S_Trade"

        sqlstr = "select S_Trade,coderoute from sship where ship_id=" & Ship_ID

        If Getdata(sqlstr, ds4).Count > 0 Then
            cbRoute.SelectedValue = ds4.Tables(0).Rows(0).Item("coderoute")
            cbTrade.SelectedValue = ds4.Tables(0).Rows(0).Item("S_Trade")
        End If

        sqlstr = "select Code_HGLoad,HGLoad from TB_Code_HGLoad "

        If Getdata(sqlstr, ds5).Count > 0 Then
            cbHgLoad.DataSource = ds5.Tables(0).DefaultView
            cbHgLoad.DisplayMember = "HGLoad"
            cbHgLoad.ValueMember = "Code_HGLoad"
        End If
        '件杂货数据显示
        sqlBlnosList = "select DISTINCT GOODS_CHA,unload_port, load_port, GOODS_ENG, CODE_PACK,PACK_ENG pack_cha, MARK, AMOUNT, WEIGHT,VOLUMN ,AMOUNT_ori,WEIGHT_ori,VOLUMN_ori,EDIMark, '0' Sel,mblno, BLNO from szh_CARGO_HATCH_LIST_NEW_LXJ where Ship_ID=" & Ship_ID & " and AMOUNT <> 0 order by mblno,BLNO "  '******要修改
        dvBlnosList = Getdata(sqlBlnosList, dsBlnoslist)
        C1DBG.DataSource = dvBlnosList
        SetGrid()
    End Sub
    Private Sub SetGrid()

        C1DBG.Columns("Sel").Caption = "选"
        C1DBG.Columns("BLNO").Caption = "子提单"
        C1DBG.Columns("mblno").Caption = "主提单"
        C1DBG.Splits(0).DisplayColumns("Sel").Width = 45
        C1DBG.Splits(0).DisplayColumns("BLNO").Width = 120
        C1DBG.Splits(0).DisplayColumns("mblno").Width = 120
        C1DBG.Columns("Sel").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
        C1DBG.Columns("Sel").ValueItems.Translate = True
        Dim vi As C1.Win.C1TrueDBGrid.ValueItem
        vi = New C1.Win.C1TrueDBGrid.ValueItem("0", False)
        C1DBG.Columns("Sel").ValueItems.Values.Add(vi)
        vi = New C1.Win.C1TrueDBGrid.ValueItem("1", True)
        C1DBG.Columns("Sel").ValueItems.Values.Add(vi)
        Dim i As Integer
        For i = 0 To C1DBG.Columns.Count - 1
            C1DBG.Splits(0).DisplayColumns(i).Locked = True
        Next
        C1DBG.Splits(0).DisplayColumns("Sel").Locked = False
        For i = 0 To C1DBG.Columns.IndexOf(C1DBG.Columns("Sel")) - 1
            C1DBG.Splits(0).DisplayColumns(i).Visible = False
        Next
        RefreshC1BillFooter()
    End Sub
    Private Sub OpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFile.Click
        OpenFileDialog.AddExtension = True
        OpenFileDialog.DefaultExt = "*.*"
        OpenFileDialog.InitialDirectory = txtFile.Text
        OpenFileDialog.ShowDialog()
        txtFile.Text = OpenFileDialog.FileName
    End Sub

    Private Function CheckConNO(ByVal CNO As String) As Integer 'return 0 箱号有错 1 校验有错 2 校验正确
        Dim S() As Integer = {10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 34, 35, 36, 37, 38}
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim l As Integer
        i = 0
        str = UCase(CNO)
        If Len(Trim(UCase(CNO))) = 12 And Mid(Trim(UCase(CNO)), 5, 1) = " " Then
            str = Mid(Trim(UCase(CNO)), 1, 4) & Mid(Trim(UCase(CNO)), 6, 7)
        Else
            Return 0
        End If
        k = 1
        For j = 1 To 4
            If Asc(Mid(Trim(str), j, 1)) >= Asc("A") And Asc(Mid(Trim(str), j, 1)) <= Asc("Z") Then
                i = i + S(Asc(Mid(Trim(str), j, 1)) - Asc("A")) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next

        For j = 5 To 10
            If Asc(Mid(Trim(str), j, 1)) >= Asc("0") And Asc(Mid(Trim(str), j, 1)) <= Asc("9") Then
                i = i + CInt(Mid(Trim(str), j, 1)) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next
        If i Mod 11 = CInt(Mid(Trim(str), 11, 1)) Or (i Mod 11) - 10 = CInt(Mid(Trim(str), 11, 1)) Then
            Return 2
        Else
            Return 1
        End If
    End Function
    Private Function EditFetch(ByVal str As String) As String
        Dim s As String
        Dim se As String
        Dim j As Integer
        s = ""
        j = 1
        Do While j <= Len(str)
            se = Mid(str, j, 1)
            If se = "?" Then
                j = j + 1
                se = Mid(str, j, 1)
                If se = ":" Or se = "'" Or se = "?" Then
                    s = s & se
                Else
                    s = s & "?" & se
                End If
            End If
            If se = ":" Or se = "'" Then
                Exit Do
            Else
                s = s & se
            End If
            j = j + 1
        Loop
        EditFetch = s
    End Function
    Dim iSelConSum As Integer
    ''' <summary>
    ''' 获取选中提单列表
    ''' </summary>
    Private Sub getblnoslist()
        Try
            dvBlnosList.RowFilter = "Sel='1'"
            dw = dvBlnosList
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btWriteNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btWriteNew.Click
        If (Trim(txtShipCode.Text).Length = 0) Then
            txtShipCode.Text = "1"
        End If
        If LSign.Text.Trim().Length() > 0 Then
            If rbJT.Checked = True Then
                getblnoslist() '获取选中的提单号
                iSelConSum = dw.Count
                If MsgBox("所选箱个数： " & iSelConSum.ToString() & ",是否继续生成报文？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                    'MessageBox.Show("所选箱数： " + clbcontslist.CheckedItems.Count)
                    Call WriteZH()
                    Call WriteReport()
                End If
            End If
        Else
            MsgBox("IMO 都不能为空!!!")
        End If
    End Sub
    Private Sub WriteReport()
        On Error GoTo Err
        '******************************************中海
        Dim txtLine As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim k As Integer = 0
        Dim str As String
        Dim Ss As String '开工时间
        Dim Es As String '完工时间
        Dim s As String
        Dim dwt As New DataView
        Dim dst As New DataSet
        Dim strFile As String

        Dim ImExport As String = "" '进出口
        Dim ExPlaceCode As String = "" '装货地代码
        Dim ImPlaceCode As String = "" '卸货地代码
        Dim Trade As String = "1"
        Dim dss As New DataSet
        Dim dws As New DataView
        Dim ReportType As String = "2"
        If rbAdd.Checked = True Then
            ReportType = "2"
        Else
            If rbDel.Checked = True Then
                ReportType = "3"
            End If
        End If

        If cbTrade.SelectedValue.ToString.Trim() = "1" Then
            Trade = "2"
        Else
            Trade = "1"
        End If
        If LJinChu.Text.Trim() = "进口" Then
            ImExport = "IMPORT"
            ImPlaceCode = cbHgLoad.SelectedValue.ToString().Trim() + "/2301"
        Else
            ImExport = "EXPORT"
            ExPlaceCode = cbHgLoad.SelectedValue.ToString().Trim() + "/2301"
        End If
        strFile = txtFile.Text & "CCTALLY" & UCase(LSign.Text.Trim()) & UCase(txtShipCode.Text.Trim()) & RetVoyageStr(LVoyage.Text) & ".txt"
        Dim Report_Name As String
        Report_Name = "CCTALLY" & UCase(LSign.Text.Trim()) & UCase(txtShipCode.Text.Trim()) & RetVoyageStr(LVoyage.Text)
        ''''''''''''一、测试类连接数据
        Dim fi As New FileInfo(strFile)
        Dim fs As FileStream
        fs = fi.OpenRead()
        Dim Length As Integer
        Length = CType(fs.Length, Integer)
        Dim bytes() As Byte
        '校验
        ReDim bytes(0 To Length - 1)
        fs.Read(bytes, 0, Length)
        '数据检查
        Dim dsRecord As New DataSet
        Dim dwRecord As New DataView
        sqlstr = "select * from report_record  where SHIP_ID=" & Ship_ID & " AND OPER_NAME='" & G_User & "' AND OPER_TIME> GETDATE()-1"
        dwRecord = Getdata(sqlstr, dsRecord)
        If (dwRecord.Count > 0) Then
            If MsgBox("上次发送本航次的时间为" + dwRecord(0)("OPER_TIME") + ",确定取消本次发送吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                MsgBox("取消发送！")
            Else
                '数据保存
                ExecTextSql(bytes, "insert into report_record(SHIP_ID,OPER_NAME,OPER_TIME,REPORT_NAME,Report_Type,REPORT)values(" & Ship_ID & ",'" & G_User & "',getdate(), '" & Report_Name & "','1',@file)")
            End If
        Else
            ExecTextSql(bytes, "insert into report_record(SHIP_ID,OPER_NAME,OPER_TIME,REPORT_NAME,Report_Type,REPORT)values(" & Ship_ID & ",'" & G_User & "',getdate(), '" & Report_Name & "','1',@file)")
        End If
Err:
        MsgBox(Err.Description)
    End Sub
    Private Sub WriteZH()
        On Error GoTo Err
        '******************************************中海
        Dim txtLine As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim k As Integer = 0
        Dim str As String
        Dim Ss As String '开工时间
        Dim Es As String '完工时间
        Dim s As String
        Dim dwt As New DataView
        Dim dst As New DataSet
        Dim strFile As String

        Dim ImExport As String = "" '进出口
        Dim ExPlaceCode As String = "" '装货地代码
        Dim ImPlaceCode As String = "" '卸货地代码
        Dim Trade As String = "1"
        Dim dss As New DataSet
        Dim dws As New DataView
        Dim ReportType As String = "2"
        If rbAdd.Checked = True Then
            ReportType = "2"
        Else
            If rbDel.Checked = True Then
                ReportType = "3"
            End If
        End If

        If cbTrade.SelectedValue.ToString.Trim() = "1" Then
            Trade = "2"
        Else
            Trade = "1"
        End If
        If LJinChu.Text.Trim() = "进口" Then
            ImExport = "IMPORT"
            ImPlaceCode = cbHgLoad.SelectedValue.ToString().Trim() + "/2301"
        Else
            ImExport = "EXPORT"
            ExPlaceCode = cbHgLoad.SelectedValue.ToString().Trim() + "/2301"
        End If
        strFile = txtFile.Text & "CCTALLY" & UCase(LSign.Text.Trim()) & UCase(txtShipCode.Text.Trim()) & RetVoyageStr(LVoyage.Text) & ".txt"

        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default())  '打开报文文件
        '**************写00行
        txtLine = "00:CCTALLY:" & ImExport & ":" & ReportType & ":2310139007805:2301:" & Trim(CType(Year(Now), String))
        s = Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtLine = txtLine & s & "'"
        sw.WriteLine(txtLine)

        '************写05
        If txtName.Text.Trim().Length() > 0 Then
            txtLine = "05:" & txtName.Text.Trim() & ":" & txtPhoneCode.Text.Trim() & ":" & "TE'"
            sw.WriteLine(txtLine)
            i = 2
        End If
        '**************写06
        txtLine = "06:2310139007805:" & txtTallyName.Text.Trim() & "::'"
        i = i + 1
        sw.WriteLine(txtLine)
        '*************写10
        If LStartTime.Text.ToString().Length() > 0 Then
            Ss = Trim(CType(Year(CType(LEndTime.Text.ToString(), Date)), String))
            Ss = Ss & Mid("0" & Trim(CType(Month(CType(LStartTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Month(CType(LStartTime.Text.ToString(), Date)), String))) - 1, 2)

            Ss = Ss & Mid("0" & Trim(CType(Day(CType(LStartTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Day(CType(LStartTime.Text.ToString(), Date)), String))) - 1, 2)

            Ss = Ss & Mid("0" & Trim(CType(Hour(CType(LStartTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Hour(CType(LStartTime.Text.ToString(), Date)), String))) - 1, 2)

            Ss = Ss & Mid("0" & Trim(CType(Minute(CType(LStartTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Minute(CType(LStartTime.Text.ToString(), Date)), String))) - 1, 2)
            Ss = Ss & "086"
        Else
            Ss = ""
        End If

        If LEndTime.Text.ToString().Length() > 0 Then
            Es = Trim(CType(Year(CType(LEndTime.Text.ToString(), Date)), String))
            Es = Es & Mid("0" & Trim(CType(Month(CType(LEndTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Month(CType(LEndTime.Text.ToString(), Date)), String))) - 1, 2)

            Es = Es & Mid("0" & Trim(CType(Day(CType(LEndTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Day(CType(LEndTime.Text.ToString(), Date)), String))) - 1, 2)

            Es = Es & Mid("0" & Trim(CType(Hour(CType(LEndTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Hour(CType(LEndTime.Text.ToString(), Date)), String))) - 1, 2)

            Es = Es & Mid("0" & Trim(CType(Minute(CType(LEndTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Minute(CType(LEndTime.Text.ToString(), Date)), String))) - 1, 2)
            Es = Es & "086"
        Else
            Es = ""
        End If
        txtLine = "10:" & UCase(Trim(txtShipCode.Text)) & ":" & UCase(Trim(LEnglish.Text)) & ":1:" & LVoyage.Text & ":" & LSign.Text.Trim() & ":2301:" & ExPlaceCode & "::" & ImPlaceCode & "::" & Ss & ":" & Es & ":" & cbRoute.SelectedValue & ":" & Trade & "'"
        i = i + 1
        sw.WriteLine(txtLine)
        '************写12 提单循环
        '取数据源处&&SUN
        'sqlstr = "select  DISTINCT mblno, BLNO, unload_port, load_port, GOODS_CHA, GOODS_ENG, CODE_PACK,PACK_ENG pack_cha, MARK, AMOUNT, WEIGHT,VOLUMN ,AMOUNT_ori,WEIGHT_ori,VOLUMN_ori from szh_CARGO_HATCH_LIST_NEW_LXJ where Ship_ID=" & Ship_ID & " and AMOUNT <> 0 order by mblno,BLNO "  '******要修改
        'dw = Getdata(sqlstr, ds)

        PB.Maximum = dw.Count
        PB.Value = 0

        Do While j < dw.Count
            PB.Value = j
            '********************************12
            'txtLine = "12:" & RetBLNO(UCase(ds.Tables(0).Rows(j).Item("mblno"))) & ":" & ":"
            txtLine = "12:" & RetBLNO(UCase(dw(j)("mblno"))) & ":" & RetBLNO(UCase(dw(j)("BLNO"))) & ":"

            If Not IsDBNull(dw(j)("AMOUNT")) Then
                If Trim(dw(j)("AMOUNT")) = "0" Then
                    txtLine = txtLine & "1:"
                Else
                    txtLine = txtLine & Trim(dw(j)("AMOUNT")) & ":"
                End If
            Else
                txtLine = txtLine & "1:"
            End If
            If Not IsDBNull(dw(j)("CODE_PACK")) Then
                txtLine = txtLine & Trim(dw(j)("CODE_PACK")) & ":"
            Else
                txtLine = txtLine & ":"
            End If
            If Not IsDBNull(dw(j)("pack_cha")) Then
                txtLine = txtLine & RetStr(Trim(dw(j)("pack_cha"))) & ":"
            Else
                txtLine = txtLine & ":"
            End If

            If Not IsDBNull(dw(j)("WEIGHT")) Then
                txtLine = txtLine & Trim(CType(dw(j)("WEIGHT"), Double))
            End If

            txtLine = txtLine & ":"
            If Not IsDBNull(dw(j)("VOLUMN")) Then
                If Trim(CType(dw(j)("VOLUMN"), Double)) = "0" Then
                    txtLine = txtLine & "1:3'"
                Else
                    txtLine = txtLine & Trim(CType(dw(j)("VOLUMN"), Double)) & ":3'"
                End If
            Else
                txtLine = txtLine & "1:3'"
            End If
            i = i + 1
            j = j + 1
            sw.WriteLine(txtLine)
        Loop

        '********************************50  其中 52 件杂货没有

        'dst.Reset()
        'str = "select DISTINCT SHIP_ID,BLNO,DAMAGED_REMARK,DAMAGED_CODE,DAMAGED_DESC,DESCR from WORK_RECORD_new where SHIP_ID=" & Ship_ID & " and DAMAGED_REMARK='01' ORDER BY BLNO"

        'dwt = Getdata(str, dst)

        'If dwt.Count > 0 Then
        '    k = 0
        '    Do While k < dwt.Count

        '        txtLine = "50:" & Trim(dst.Tables(0).Rows(0).Item("BLNO")) & "::::"

        '        '*********************残损信息                

        '        If Not IsDBNull(dst.Tables(0).Rows(k).Item("DAMAGED_CODE")) Then
        '            txtLine = txtLine & RetStr(Trim(dst.Tables(0).Rows(k).Item("DAMAGED_CODE"))) & ":"
        '        Else
        '            txtLine = txtLine & ":"
        '        End If
        '        If Not IsDBNull(dst.Tables(0).Rows(k).Item("DAMAGED_DESC")) Then
        '            txtLine = txtLine & RetStr(Trim(dst.Tables(0).Rows(k).Item("DAMAGED_DESC"))) & ":"
        '        Else
        '            txtLine = txtLine & ":"
        '        End If

        '        txtLine = txtLine & "::"
        '        If Not IsDBNull(dst.Tables(0).Rows(k).Item("DESCR")) Then
        '            txtLine = txtLine & RetStr(Trim(dst.Tables(0).Rows(k).Item("DESCR")))
        '        Else
        '            txtLine = txtLine
        '        End If
        '        txtLine = txtLine & ":'"
        '        sw.WriteLine(txtLine)
        '        i = i + 1

        '        k = k + 1
        '    Loop
        'End If
        txtLine = "99:" & Trim(CType(i + 1, String)) & "'"
        sw.WriteLine(txtLine)
        sw.Close()
        MsgBox("理货报告生成完成,谢谢! 报文共 " & Trim(CType(i + 1, String)) & " 行 共 " & j & " 个提单 共 " & k & " 个残损!")
        Exit Sub
Err:
        MsgBox(Err.Description)
    End Sub
    Private Function FindPort(ByVal Port As String, ByVal Company As String) As String
        Dim dsPort As New DataSet
        Dim dwPort As New DataView
        Dim str As String
        str = "select * from Code_Port_Relation where Code_Port='" & Port & "' and Code_SHIPOWNER='" & Company & "'"
        dwPort = Getdata(str, dsPort)
        If dwPort.Count > 0 Then
            FindPort = dsPort.Tables(0).Rows(0).Item("Code_Port_Relation") & ":" & dsPort.Tables(0).Rows(0).Item("Port_Relation")
        Else
            FindPort = Port & ":"
        End If
    End Function
    Private Function RetBLNO(ByVal Pstr As String) As String
        Dim i As Integer

        Dim sstr As String
        sstr = ""
        If Len(Trim(Pstr)) > 0 Then
            For i = 1 To Pstr.Trim().Length()
                If (Asc(Mid(Pstr, i, 1)) >= Asc("0") And Asc(Mid(Pstr, i, 1)) <= Asc("9")) Or (Asc(Mid(Pstr, i, 1)) >= Asc("a") And Asc(Mid(Pstr, i, 1)) <= Asc("z")) Or (Asc(Mid(Pstr, i, 1)) >= Asc("A") And Asc(Mid(Pstr, i, 1)) <= Asc("Z")) Then

                    sstr = sstr & Mid(Pstr, i, 1)

                End If
            Next
        End If
        RetBLNO = sstr
    End Function
    Private Function RetStr(ByVal Pstr As String) As String
        Dim i As Integer

        Dim sstr As String
        sstr = ""
        For i = 1 To Pstr.Trim().Length()
            If Mid(Pstr, i, 1) = "?" Or Mid(Pstr, i, 1) = ":" Or Mid(Pstr, i, 1) = "'" Then
                sstr = sstr & "?" & Mid(Pstr, i, 1)
            Else
                sstr = sstr & Mid(Pstr, i, 1)
            End If
        Next
        RetStr = sstr

    End Function
    Private Function RetVoyageStr(ByVal Pstr As String) As String
        Dim i As Integer

        Dim sstr As String
        sstr = ""
        For i = 1 To Pstr.Trim().Length()
            If Mid(Pstr, i, 1) = "\" Or Mid(Pstr, i, 1) = "/" Then
                ' sstr = sstr & "?" & Mid(Pstr, i, 1)
            Else
                sstr = sstr & Mid(Pstr, i, 1)
            End If
        Next
        RetVoyageStr = sstr

    End Function
    Private Sub btRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRead.Click
        Dim PathStr As String
        Dim FilePath As String
        Dim strFile As String

        strFile = txtFile.Text & "CCTALLY" & UCase(LSign.Text.Trim()) & UCase(txtShipCode.Text.Trim()) & RetVoyageStr(LVoyage.Text) & ".txt"

        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "NOTEPAD.EXE"
            Shell(FilePath & " " & strFile, AppWinStyle.NormalFocus, True)
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub C1DBG_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColUpdate
        RefreshC1BillFooter()
    End Sub
    '报文发送后对CARGO_HATCH_new中的EDIMARK字段更新
    Dim iSelSum As Integer
    Private Sub RefreshC1BillFooter()
        C1DBG.Columns("mblno").FooterText = "计" & C1DBG.RowCount & "项"
        iSelSum = 0
        Dim i As Integer
        For i = 0 To C1DBG.RowCount - 1
            If C1DBG.Columns("Sel").CellValue(i).ToString() = "1" Then
                iSelSum += 1
            End If
        Next
        C1DBG.Columns("BLNO").FooterText = "选中" & iSelSum.ToString() & "项"
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("EDIMark").CellValue(e.Row).ToString() = "1" Then
            e.CellStyle.ForeColor = Color.Orange
        End If
    End Sub

    Private Sub C1DBG_Filter(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs) Handles C1DBG.Filter
        RefreshC1BillFooter()
    End Sub

    Private Sub btnSelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelAll.Click
        Dim i As Integer
        Dim iLocal As Integer = C1DBG.Row
        If btnSelAll.Text = "全选" Then
            For i = 0 To C1DBG.RowCount - 1
                C1DBG.Row = i
                C1DBG.Columns("Sel").Text = "1"
            Next
            btnSelAll.Text = "全清"
        Else
            For i = 0 To C1DBG.RowCount - 1
                C1DBG.Row = i
                C1DBG.Columns("Sel").Text = "0"
            Next
            btnSelAll.Text = "全选"
        End If
        C1DBG.UpdateData()
        C1DBG.Row = iLocal
        RefreshC1BillFooter()
    End Sub
End Class
