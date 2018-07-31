Public Class FrmMain
    Inherits System.Windows.Forms.Form
    Dim Menuitem(137) As Menuitem
    Dim ds As New DataSet()
    Dim dv As DataView
    Dim dstime1 As New DataSet
    Dim dvtime1 As DataView
    Friend WithEvents His_info As System.Windows.Forms.MenuItem
    Friend WithEvents WL2_7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents TTJJ As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTSShip As System.Windows.Forms.ToolBarButton
    Friend WithEvents TallyRead As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportRecord As System.Windows.Forms.MenuItem
    Dim sqlstr As String

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
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

    '注意：以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents stb As System.Windows.Forms.StatusBar
    Friend WithEvents StBDep As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StB_Department As System.Windows.Forms.StatusBarPanel
    Friend WithEvents stbUser As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StB_User As System.Windows.Forms.StatusBarPanel
    Friend WithEvents STBT As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StB_Time As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem151 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem153 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents TTBQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents TTBBill As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBBillPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBInvoice As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBSeal As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBS1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBS2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBPassWord As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBLogoff As System.Windows.Forms.ToolBarButton
    Friend WithEvents WL1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_3 As System.Windows.Forms.MenuItem
    Friend WithEvents WL2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL2_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL2_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL2_3 As System.Windows.Forms.MenuItem
    Friend WithEvents WL2_4 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_6 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_7 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_8 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_9 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_10 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL2_5 As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_20 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_22 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_23 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_24 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_26 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_27 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_28 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_29 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_4_3 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_4_5 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_4_6 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_4_7 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_4_9 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_4_10 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_6_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_6_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_6_3 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_6_4 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_6_5 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_3 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_4 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_5 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_6 As System.Windows.Forms.MenuItem
    Friend WithEvents WL6_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL6_2_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL6_2_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL6_2_3 As System.Windows.Forms.MenuItem
    Friend WithEvents WL6_2_4 As System.Windows.Forms.MenuItem
    Friend WithEvents WL6_2_5 As System.Windows.Forms.MenuItem
    Friend WithEvents WL6_2_6 As System.Windows.Forms.MenuItem
    Friend WithEvents WL8 As System.Windows.Forms.MenuItem
    Friend WithEvents WL8_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL8_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL8_3 As System.Windows.Forms.MenuItem
    Friend WithEvents WL8_4 As System.Windows.Forms.MenuItem
    Friend WithEvents WL9 As System.Windows.Forms.MenuItem
    Friend WithEvents WL9_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL9_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL9_3 As System.Windows.Forms.MenuItem
    Friend WithEvents WL9_4 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_3 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_4 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_5 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_6 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_7 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_8 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_9 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_10 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_11 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_12 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_13 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_14 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_15 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_16 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_17 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11_3 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11_4 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11_5 As System.Windows.Forms.MenuItem
    Friend WithEvents WL12 As System.Windows.Forms.MenuItem
    Friend WithEvents WL12_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL12_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL8_5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11_6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents WL8_6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents WL2_6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents TTGZI As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents TTBInout As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents WL1_45 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_44 As System.Windows.Forms.MenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents WL11_7 As System.Windows.Forms.MenuItem
    Friend WithEvents upload As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents WL3_0 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents code_manage As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.WL1 = New System.Windows.Forms.MenuItem
        Me.WL1_1 = New System.Windows.Forms.MenuItem
        Me.WL1_28 = New System.Windows.Forms.MenuItem
        Me.WL1_2 = New System.Windows.Forms.MenuItem
        Me.WL1_10 = New System.Windows.Forms.MenuItem
        Me.WL1_20 = New System.Windows.Forms.MenuItem
        Me.WL1_29 = New System.Windows.Forms.MenuItem
        Me.WL1_26 = New System.Windows.Forms.MenuItem
        Me.WL1_27 = New System.Windows.Forms.MenuItem
        Me.MenuItem151 = New System.Windows.Forms.MenuItem
        Me.WL1_45 = New System.Windows.Forms.MenuItem
        Me.WL1_7 = New System.Windows.Forms.MenuItem
        Me.WL1_8 = New System.Windows.Forms.MenuItem
        Me.WL1_3 = New System.Windows.Forms.MenuItem
        Me.WL1_9 = New System.Windows.Forms.MenuItem
        Me.WL1_11 = New System.Windows.Forms.MenuItem
        Me.MenuItem152 = New System.Windows.Forms.MenuItem
        Me.WL1_44 = New System.Windows.Forms.MenuItem
        Me.MenuItem153 = New System.Windows.Forms.MenuItem
        Me.WL1_6 = New System.Windows.Forms.MenuItem
        Me.WL1_24 = New System.Windows.Forms.MenuItem
        Me.WL1_22 = New System.Windows.Forms.MenuItem
        Me.WL1_23 = New System.Windows.Forms.MenuItem
        Me.WL2 = New System.Windows.Forms.MenuItem
        Me.WL2_6 = New System.Windows.Forms.MenuItem
        Me.WL2_4 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.WL2_1 = New System.Windows.Forms.MenuItem
        Me.WL2_2 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.WL2_3 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.WL2_5 = New System.Windows.Forms.MenuItem
        Me.WL2_7 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.WL3 = New System.Windows.Forms.MenuItem
        Me.WL3_0 = New System.Windows.Forms.MenuItem
        Me.WL3_1 = New System.Windows.Forms.MenuItem
        Me.WL3_2 = New System.Windows.Forms.MenuItem
        Me.WL3_3 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.WL3_4 = New System.Windows.Forms.MenuItem
        Me.WL3_4_7 = New System.Windows.Forms.MenuItem
        Me.WL3_4_6 = New System.Windows.Forms.MenuItem
        Me.WL3_4_3 = New System.Windows.Forms.MenuItem
        Me.WL3_4_10 = New System.Windows.Forms.MenuItem
        Me.WL3_4_9 = New System.Windows.Forms.MenuItem
        Me.WL3_4_5 = New System.Windows.Forms.MenuItem
        Me.WL3_5 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.WL3_6 = New System.Windows.Forms.MenuItem
        Me.WL3_6_1 = New System.Windows.Forms.MenuItem
        Me.WL3_6_2 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.WL3_6_3 = New System.Windows.Forms.MenuItem
        Me.WL3_6_5 = New System.Windows.Forms.MenuItem
        Me.WL3_6_4 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.WL6_2 = New System.Windows.Forms.MenuItem
        Me.WL6_2_1 = New System.Windows.Forms.MenuItem
        Me.WL6_2_2 = New System.Windows.Forms.MenuItem
        Me.WL6_2_3 = New System.Windows.Forms.MenuItem
        Me.WL6_2_4 = New System.Windows.Forms.MenuItem
        Me.WL6_2_5 = New System.Windows.Forms.MenuItem
        Me.WL6_2_6 = New System.Windows.Forms.MenuItem
        Me.WL8 = New System.Windows.Forms.MenuItem
        Me.WL8_1 = New System.Windows.Forms.MenuItem
        Me.WL8_2 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.WL8_3 = New System.Windows.Forms.MenuItem
        Me.WL8_4 = New System.Windows.Forms.MenuItem
        Me.WL8_5 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.WL8_6 = New System.Windows.Forms.MenuItem
        Me.WL9 = New System.Windows.Forms.MenuItem
        Me.WL9_1 = New System.Windows.Forms.MenuItem
        Me.WL9_2 = New System.Windows.Forms.MenuItem
        Me.WL9_3 = New System.Windows.Forms.MenuItem
        Me.WL9_4 = New System.Windows.Forms.MenuItem
        Me.WL10 = New System.Windows.Forms.MenuItem
        Me.WL10_1 = New System.Windows.Forms.MenuItem
        Me.WL10_2 = New System.Windows.Forms.MenuItem
        Me.WL10_3 = New System.Windows.Forms.MenuItem
        Me.WL10_4 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.WL10_5 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.WL10_6 = New System.Windows.Forms.MenuItem
        Me.WL10_7 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.WL10_14 = New System.Windows.Forms.MenuItem
        Me.WL10_8 = New System.Windows.Forms.MenuItem
        Me.WL10_9 = New System.Windows.Forms.MenuItem
        Me.WL10_10 = New System.Windows.Forms.MenuItem
        Me.WL10_11 = New System.Windows.Forms.MenuItem
        Me.WL10_12 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.WL10_13 = New System.Windows.Forms.MenuItem
        Me.WL10_15 = New System.Windows.Forms.MenuItem
        Me.WL10_16 = New System.Windows.Forms.MenuItem
        Me.WL10_17 = New System.Windows.Forms.MenuItem
        Me.mnuReportRecord = New System.Windows.Forms.MenuItem
        Me.WL11 = New System.Windows.Forms.MenuItem
        Me.WL11_1 = New System.Windows.Forms.MenuItem
        Me.WL11_2 = New System.Windows.Forms.MenuItem
        Me.WL11_3 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.WL11_4 = New System.Windows.Forms.MenuItem
        Me.WL11_5 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.WL11_6 = New System.Windows.Forms.MenuItem
        Me.WL11_7 = New System.Windows.Forms.MenuItem
        Me.His_info = New System.Windows.Forms.MenuItem
        Me.WL12 = New System.Windows.Forms.MenuItem
        Me.WL12_1 = New System.Windows.Forms.MenuItem
        Me.WL12_2 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.upload = New System.Windows.Forms.MenuItem
        Me.code_manage = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.stb = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StBDep = New System.Windows.Forms.StatusBarPanel
        Me.StB_Department = New System.Windows.Forms.StatusBarPanel
        Me.stbUser = New System.Windows.Forms.StatusBarPanel
        Me.StB_User = New System.Windows.Forms.StatusBarPanel
        Me.STBT = New System.Windows.Forms.StatusBarPanel
        Me.StB_Time = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.TTBBillPrint = New System.Windows.Forms.ToolBarButton
        Me.TTBBill = New System.Windows.Forms.ToolBarButton
        Me.TTSShip = New System.Windows.Forms.ToolBarButton
        Me.TTBInvoice = New System.Windows.Forms.ToolBarButton
        Me.TallyRead = New System.Windows.Forms.ToolBarButton
        Me.TTBS1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.TTBInout = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.TTGZI = New System.Windows.Forms.ToolBarButton
        Me.TTJJ = New System.Windows.Forms.ToolBarButton
        Me.TTBSeal = New System.Windows.Forms.ToolBarButton
        Me.TTBS2 = New System.Windows.Forms.ToolBarButton
        Me.TTBPassWord = New System.Windows.Forms.ToolBarButton
        Me.TTBLogoff = New System.Windows.Forms.ToolBarButton
        Me.TTBQuit = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StBDep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StB_Department, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StB_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STBT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StB_Time, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL1, Me.WL2, Me.WL3, Me.WL8, Me.WL9, Me.WL10, Me.WL11, Me.WL12})
        '
        'WL1
        '
        Me.WL1.Index = 0
        Me.WL1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL1_1, Me.WL1_28, Me.WL1_2, Me.WL1_10, Me.WL1_20, Me.WL1_29, Me.WL1_26, Me.WL1_27, Me.MenuItem151, Me.WL1_45, Me.WL1_7, Me.WL1_8, Me.WL1_3, Me.WL1_9, Me.WL1_11, Me.MenuItem152, Me.WL1_44, Me.MenuItem153, Me.WL1_6, Me.WL1_24, Me.WL1_22, Me.WL1_23})
        Me.WL1.Text = "基础资料"
        '
        'WL1_1
        '
        Me.WL1_1.Index = 0
        Me.WL1_1.Text = "部门代码"
        '
        'WL1_28
        '
        Me.WL1_28.Index = 1
        Me.WL1_28.Text = "员工名录表"
        '
        'WL1_2
        '
        Me.WL1_2.Index = 2
        Me.WL1_2.Text = "职务代码"
        Me.WL1_2.Visible = False
        '
        'WL1_10
        '
        Me.WL1_10.Index = 3
        Me.WL1_10.Text = "部门主管人"
        Me.WL1_10.Visible = False
        '
        'WL1_20
        '
        Me.WL1_20.Index = 4
        Me.WL1_20.Text = "部门审核人"
        '
        'WL1_29
        '
        Me.WL1_29.Index = 5
        Me.WL1_29.Text = "交接班人员名录"
        '
        'WL1_26
        '
        Me.WL1_26.Index = 6
        Me.WL1_26.Text = "班次信息"
        '
        'WL1_27
        '
        Me.WL1_27.Index = 7
        Me.WL1_27.Text = "上班时间信息"
        '
        'MenuItem151
        '
        Me.MenuItem151.Index = 8
        Me.MenuItem151.Text = "-"
        '
        'WL1_45
        '
        Me.WL1_45.Index = 9
        Me.WL1_45.Text = "货名代码"
        '
        'WL1_7
        '
        Me.WL1_7.Index = 10
        Me.WL1_7.Text = "港名代码"
        '
        'WL1_8
        '
        Me.WL1_8.Index = 11
        Me.WL1_8.Text = "国籍代码"
        '
        'WL1_3
        '
        Me.WL1_3.Index = 12
        Me.WL1_3.Text = "泊位代码"
        '
        'WL1_9
        '
        Me.WL1_9.Index = 13
        Me.WL1_9.Text = "船代货代"
        '
        'WL1_11
        '
        Me.WL1_11.Index = 14
        Me.WL1_11.Text = "船公司代码"
        '
        'MenuItem152
        '
        Me.MenuItem152.Index = 15
        Me.MenuItem152.Text = "-"
        Me.MenuItem152.Visible = False
        '
        'WL1_44
        '
        Me.WL1_44.Index = 16
        Me.WL1_44.Text = "统计货类代码"
        Me.WL1_44.Visible = False
        '
        'MenuItem153
        '
        Me.MenuItem153.Index = 17
        Me.MenuItem153.Text = "-"
        '
        'WL1_6
        '
        Me.WL1_6.Index = 18
        Me.WL1_6.Text = "包装及缩写"
        '
        'WL1_24
        '
        Me.WL1_24.Index = 19
        Me.WL1_24.Text = "理货类别代码"
        '
        'WL1_22
        '
        Me.WL1_22.Index = 20
        Me.WL1_22.Text = "货物残损程度部位"
        '
        'WL1_23
        '
        Me.WL1_23.Index = 21
        Me.WL1_23.Text = "货物残损用语"
        '
        'WL2
        '
        Me.WL2.Index = 1
        Me.WL2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL2_6, Me.WL2_4, Me.MenuItem1, Me.WL2_1, Me.WL2_2, Me.MenuItem10, Me.WL2_3, Me.MenuItem3, Me.WL2_5, Me.WL2_7, Me.MenuItem23})
        Me.WL2.Text = "船舶调度"
        '
        'WL2_6
        '
        Me.WL2_6.Index = 0
        Me.WL2_6.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.WL2_6.Text = "值班派工"
        '
        'WL2_4
        '
        Me.WL2_4.Index = 1
        Me.WL2_4.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.WL2_4.Text = "值班信息查询"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 2
        Me.MenuItem1.Text = "-"
        '
        'WL2_1
        '
        Me.WL2_1.Index = 3
        Me.WL2_1.Text = "船舶规范"
        '
        'WL2_2
        '
        Me.WL2_2.Index = 4
        Me.WL2_2.Text = "航次信息"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 5
        Me.MenuItem10.Text = "-"
        '
        'WL2_3
        '
        Me.WL2_3.Index = 6
        Me.WL2_3.Text = "作业委托书"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 7
        Me.MenuItem3.Text = "-"
        Me.MenuItem3.Visible = False
        '
        'WL2_5
        '
        Me.WL2_5.Index = 8
        Me.WL2_5.Text = "资料归档"
        Me.WL2_5.Visible = False
        '
        'WL2_7
        '
        Me.WL2_7.Index = 9
        Me.WL2_7.Text = "数据审核"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 10
        Me.MenuItem23.Text = "原单审核"
        Me.MenuItem23.Visible = False
        '
        'WL3
        '
        Me.WL3.Index = 2
        Me.WL3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL3_0, Me.WL3_1, Me.WL3_2, Me.WL3_3, Me.MenuItem22, Me.MenuItem5, Me.MenuItem25, Me.WL3_4, Me.WL3_5, Me.MenuItem15, Me.WL3_6, Me.MenuItem16, Me.WL6_2})
        Me.WL3.Text = "散杂货理货"
        '
        'WL3_0
        '
        Me.WL3_0.Index = 0
        Me.WL3_0.Text = "舱单/装货单信息"
        '
        'WL3_1
        '
        Me.WL3_1.Index = 1
        Me.WL3_1.Text = "舱单信息"
        Me.WL3_1.Visible = False
        '
        'WL3_2
        '
        Me.WL3_2.Index = 2
        Me.WL3_2.Text = "作业分舱单"
        '
        'WL3_3
        '
        Me.WL3_3.Index = 3
        Me.WL3_3.Text = "现场资料"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 4
        Me.MenuItem22.Text = "理货凭证"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Text = "装卸进度表"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 6
        Me.MenuItem25.Text = "验封施封"
        '
        'WL3_4
        '
        Me.WL3_4.Index = 7
        Me.WL3_4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL3_4_7, Me.WL3_4_6, Me.WL3_4_3, Me.WL3_4_10, Me.WL3_4_9, Me.WL3_4_5})
        Me.WL3_4.Text = "完船信息"
        '
        'WL3_4_7
        '
        Me.WL3_4_7.Index = 0
        Me.WL3_4_7.Text = "分港卸货单"
        '
        'WL3_4_6
        '
        Me.WL3_4_6.Index = 1
        Me.WL3_4_6.Text = "出口分舱单"
        '
        'WL3_4_3
        '
        Me.WL3_4_3.Index = 2
        Me.WL3_4_3.Text = "工残记录"
        '
        'WL3_4_10
        '
        Me.WL3_4_10.Index = 3
        Me.WL3_4_10.Text = "理货汇总证明书"
        '
        'WL3_4_9
        '
        Me.WL3_4_9.Index = 4
        Me.WL3_4_9.Text = "附加费项目明细表"
        '
        'WL3_4_5
        '
        Me.WL3_4_5.Index = 5
        Me.WL3_4_5.Text = "装/卸船报告"
        '
        'WL3_5
        '
        Me.WL3_5.Index = 8
        Me.WL3_5.Text = "积载图绘制"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 9
        Me.MenuItem15.Text = "-"
        '
        'WL3_6
        '
        Me.WL3_6.Index = 10
        Me.WL3_6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL3_6_1, Me.WL3_6_2, Me.MenuItem24, Me.MenuItem12, Me.WL3_6_3, Me.WL3_6_5, Me.WL3_6_4})
        Me.WL3_6.Text = "散化肥灌包理货"
        '
        'WL3_6_1
        '
        Me.WL3_6_1.Index = 0
        Me.WL3_6_1.Text = "散货货物情况"
        '
        'WL3_6_2
        '
        Me.WL3_6_2.Index = 1
        Me.WL3_6_2.Text = "灌包理货单"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 2
        Me.MenuItem24.Text = "灌包质检日报"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 3
        Me.MenuItem12.Text = "-"
        '
        'WL3_6_3
        '
        Me.WL3_6_3.Index = 4
        Me.WL3_6_3.Text = "灌包理货日报"
        '
        'WL3_6_5
        '
        Me.WL3_6_5.Index = 5
        Me.WL3_6_5.Text = "完工理货交接单"
        '
        'WL3_6_4
        '
        Me.WL3_6_4.Index = 6
        Me.WL3_6_4.Text = "袋皮管理"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 11
        Me.MenuItem16.Text = "-"
        '
        'WL6_2
        '
        Me.WL6_2.Index = 12
        Me.WL6_2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL6_2_1, Me.WL6_2_2, Me.WL6_2_3, Me.WL6_2_4, Me.WL6_2_5, Me.WL6_2_6})
        Me.WL6_2.Text = "监管货物转场"
        '
        'WL6_2_1
        '
        Me.WL6_2_1.Index = 0
        Me.WL6_2_1.Text = "委托书"
        '
        'WL6_2_2
        '
        Me.WL6_2_2.Index = 1
        Me.WL6_2_2.Text = "计数单"
        '
        'WL6_2_3
        '
        Me.WL6_2_3.Index = 2
        Me.WL6_2_3.Text = "现场记录"
        '
        'WL6_2_4
        '
        Me.WL6_2_4.Index = 3
        Me.WL6_2_4.Text = "残损单"
        '
        'WL6_2_5
        '
        Me.WL6_2_5.Index = 4
        Me.WL6_2_5.Text = "理货证明书"
        '
        'WL6_2_6
        '
        Me.WL6_2_6.Index = 5
        Me.WL6_2_6.Text = "理货汇总证明书"
        '
        'WL8
        '
        Me.WL8.Index = 3
        Me.WL8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL8_1, Me.WL8_2, Me.MenuItem13, Me.MenuItem14, Me.WL8_3, Me.WL8_4, Me.WL8_5, Me.MenuItem11, Me.MenuItem19, Me.MenuItem18, Me.WL8_6})
        Me.WL8.Text = "绩效管理"
        '
        'WL8_1
        '
        Me.WL8_1.Index = 0
        Me.WL8_1.Text = "员工考勤管理"
        '
        'WL8_2
        '
        Me.WL8_2.Index = 1
        Me.WL8_2.Text = "员工月考勤表处理"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 2
        Me.MenuItem13.Text = "其他人员考勤处理"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Text = "-"
        '
        'WL8_3
        '
        Me.WL8_3.Index = 4
        Me.WL8_3.Text = "绩效工资"
        Me.WL8_3.Visible = False
        '
        'WL8_4
        '
        Me.WL8_4.Index = 5
        Me.WL8_4.Text = "出勤工时绩效"
        Me.WL8_4.Visible = False
        '
        'WL8_5
        '
        Me.WL8_5.Index = 6
        Me.WL8_5.Text = "待时绩效"
        Me.WL8_5.Visible = False
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 7
        Me.MenuItem11.Text = "-"
        Me.MenuItem11.Visible = False
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 8
        Me.MenuItem19.Text = "奖金查询"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 9
        Me.MenuItem18.Text = "岗位工资录入"
        Me.MenuItem18.Visible = False
        '
        'WL8_6
        '
        Me.WL8_6.Index = 10
        Me.WL8_6.Text = "当月工资查询"
        '
        'WL9
        '
        Me.WL9.Index = 4
        Me.WL9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL9_1, Me.WL9_2, Me.WL9_3, Me.WL9_4})
        Me.WL9.Text = "铅封管理"
        '
        'WL9_1
        '
        Me.WL9_1.Index = 0
        Me.WL9_1.Text = "铅封入库"
        '
        'WL9_2
        '
        Me.WL9_2.Index = 1
        Me.WL9_2.Text = "铅封出库"
        '
        'WL9_3
        '
        Me.WL9_3.Index = 2
        Me.WL9_3.Text = "铅封注销"
        '
        'WL9_4
        '
        Me.WL9_4.Index = 3
        Me.WL9_4.Text = "铅封查询"
        '
        'WL10
        '
        Me.WL10.Index = 5
        Me.WL10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL10_1, Me.WL10_2, Me.WL10_3, Me.WL10_4, Me.MenuItem6, Me.WL10_5, Me.MenuItem8, Me.WL10_6, Me.WL10_7, Me.MenuItem9, Me.WL10_14, Me.WL10_8, Me.WL10_9, Me.WL10_10, Me.WL10_11, Me.WL10_12, Me.MenuItem7, Me.WL10_13, Me.WL10_15, Me.WL10_16, Me.WL10_17, Me.mnuReportRecord})
        Me.WL10.Text = "统计报表"
        '
        'WL10_1
        '
        Me.WL10_1.Index = 0
        Me.WL10_1.Text = "理货财务统计月报"
        Me.WL10_1.Visible = False
        '
        'WL10_2
        '
        Me.WL10_2.Index = 1
        Me.WL10_2.Text = "理货质量统计月报"
        Me.WL10_2.Visible = False
        '
        'WL10_3
        '
        Me.WL10_3.Index = 2
        Me.WL10_3.Text = "理货费收统计月报"
        Me.WL10_3.Visible = False
        '
        'WL10_4
        '
        Me.WL10_4.Index = 3
        Me.WL10_4.Text = "理货业务统计月报"
        Me.WL10_4.Visible = False
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Text = "-"
        Me.MenuItem6.Visible = False
        '
        'WL10_5
        '
        Me.WL10_5.Index = 5
        Me.WL10_5.Text = "局经济效果指标统计表"
        Me.WL10_5.Visible = False
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 6
        Me.MenuItem8.Text = "-"
        Me.MenuItem8.Visible = False
        '
        'WL10_6
        '
        Me.WL10_6.Index = 7
        Me.WL10_6.Text = "进出口散杂货综合统计表"
        '
        'WL10_7
        '
        Me.WL10_7.Index = 8
        Me.WL10_7.Text = "船舶代理分类一览表"
        Me.WL10_7.Visible = False
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 9
        Me.MenuItem9.Text = "-"
        '
        'WL10_14
        '
        Me.WL10_14.Index = 10
        Me.WL10_14.Text = "杂项费收统计表"
        '
        'WL10_8
        '
        Me.WL10_8.Index = 11
        Me.WL10_8.Text = "分部门完船情况统计表"
        Me.WL10_8.Visible = False
        '
        'WL10_9
        '
        Me.WL10_9.Index = 12
        Me.WL10_9.Text = "分部门理货月度统计综合报表(一)"
        Me.WL10_9.Visible = False
        '
        'WL10_10
        '
        Me.WL10_10.Index = 13
        Me.WL10_10.Text = "分部门理货月度统计综合报表(二)"
        Me.WL10_10.Visible = False
        '
        'WL10_11
        '
        Me.WL10_11.Index = 14
        Me.WL10_11.Text = "部门理货统计表"
        '
        'WL10_12
        '
        Me.WL10_12.Index = 15
        Me.WL10_12.Text = "分部门件杂货理货统计表"
        Me.WL10_12.Visible = False
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 16
        Me.MenuItem7.Text = "-"
        Me.MenuItem7.Visible = False
        '
        'WL10_13
        '
        Me.WL10_13.Index = 17
        Me.WL10_13.Text = "水尺计重部月报"
        Me.WL10_13.Visible = False
        '
        'WL10_15
        '
        Me.WL10_15.Index = 18
        Me.WL10_15.Text = "EDI费收统计表"
        Me.WL10_15.Visible = False
        '
        'WL10_16
        '
        Me.WL10_16.Index = 19
        Me.WL10_16.Text = "拆装箱月度理货情况汇总表"
        Me.WL10_16.Visible = False
        '
        'WL10_17
        '
        Me.WL10_17.Index = 20
        Me.WL10_17.Text = "进口货物转场月统计表"
        Me.WL10_17.Visible = False
        '
        'mnuReportRecord
        '
        Me.mnuReportRecord.Index = 21
        Me.mnuReportRecord.Text = "理货报告统计"
        '
        'WL11
        '
        Me.WL11.Index = 6
        Me.WL11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL11_1, Me.WL11_2, Me.WL11_3, Me.MenuItem20, Me.MenuItem2, Me.WL11_4, Me.WL11_5, Me.MenuItem4, Me.WL11_6, Me.WL11_7, Me.His_info})
        Me.WL11.Text = "系统管理"
        '
        'WL11_1
        '
        Me.WL11_1.Index = 0
        Me.WL11_1.Text = "密码修改"
        '
        'WL11_2
        '
        Me.WL11_2.Index = 1
        Me.WL11_2.Text = "用户设置"
        '
        'WL11_3
        '
        Me.WL11_3.Index = 2
        Me.WL11_3.Text = "角色设置"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 3
        Me.MenuItem20.Text = "清除excel"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 4
        Me.MenuItem2.Text = "-"
        '
        'WL11_4
        '
        Me.WL11_4.Index = 5
        Me.WL11_4.Text = "注销"
        '
        'WL11_5
        '
        Me.WL11_5.Index = 6
        Me.WL11_5.Text = "退出"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 7
        Me.MenuItem4.Text = "-"
        '
        'WL11_6
        '
        Me.WL11_6.Index = 8
        Me.WL11_6.Text = "EDI 路径设置"
        '
        'WL11_7
        '
        Me.WL11_7.Index = 9
        Me.WL11_7.Text = "即时信息"
        '
        'His_info
        '
        Me.His_info.Index = 10
        Me.His_info.Text = "操作记录"
        '
        'WL12
        '
        Me.WL12.Index = 7
        Me.WL12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL12_1, Me.WL12_2, Me.MenuItem17, Me.upload, Me.code_manage, Me.MenuItem21})
        Me.WL12.Text = "帮助"
        '
        'WL12_1
        '
        Me.WL12_1.Index = 0
        Me.WL12_1.Text = "帮助"
        '
        'WL12_2
        '
        Me.WL12_2.Index = 1
        Me.WL12_2.Text = "关于.."
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 2
        Me.MenuItem17.Text = "资料存取"
        '
        'upload
        '
        Me.upload.Index = 3
        Me.upload.Text = "上传文件"
        Me.upload.Visible = False
        '
        'code_manage
        '
        Me.code_manage.Index = 4
        Me.code_manage.Text = "代码管理"
        Me.code_manage.Visible = False
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 5
        Me.MenuItem21.Text = "代码同步"
        '
        'stb
        '
        Me.stb.Location = New System.Drawing.Point(0, 326)
        Me.stb.Name = "stb"
        Me.stb.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StBDep, Me.StB_Department, Me.stbUser, Me.StB_User, Me.STBT, Me.StB_Time, Me.StatusBarPanel2})
        Me.stb.ShowPanels = True
        Me.stb.Size = New System.Drawing.Size(946, 22)
        Me.stb.TabIndex = 3
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Icon = CType(resources.GetObject("StatusBarPanel1.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 20
        '
        'StBDep
        '
        Me.StBDep.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.StBDep.Name = "StBDep"
        Me.StBDep.Text = "部门名称："
        Me.StBDep.Width = 80
        '
        'StB_Department
        '
        Me.StB_Department.Name = "StB_Department"
        Me.StB_Department.Width = 150
        '
        'stbUser
        '
        Me.stbUser.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.stbUser.Name = "stbUser"
        Me.stbUser.Text = "当前操作员："
        Me.stbUser.Width = 80
        '
        'StB_User
        '
        Me.StB_User.Name = "StB_User"
        Me.StB_User.Width = 150
        '
        'STBT
        '
        Me.STBT.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.STBT.Name = "STBT"
        Me.STBT.Text = "当前时间："
        Me.STBT.Width = 80
        '
        'StB_Time
        '
        Me.StB_Time.Name = "StB_Time"
        Me.StB_Time.Width = 200
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "连云港外轮理货有限公司（LYGOST）      版权所有"
        Me.StatusBarPanel2.Width = 500
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.TTBBillPrint, Me.TTBBill, Me.TTSShip, Me.TTBInvoice, Me.TallyRead, Me.TTBS1, Me.ToolBarButton2, Me.TTBInout, Me.ToolBarButton1, Me.TTGZI, Me.TTJJ, Me.TTBSeal, Me.TTBS2, Me.TTBPassWord, Me.TTBLogoff, Me.TTBQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(946, 41)
        Me.ToolBar.TabIndex = 5
        '
        'TTBBillPrint
        '
        Me.TTBBillPrint.ImageIndex = 0
        Me.TTBBillPrint.Name = "TTBBillPrint"
        Me.TTBBillPrint.Text = "值班派工"
        Me.TTBBillPrint.ToolTipText = "值班派工"
        '
        'TTBBill
        '
        Me.TTBBill.ImageIndex = 1
        Me.TTBBill.Name = "TTBBill"
        Me.TTBBill.Text = "派工查询"
        Me.TTBBill.ToolTipText = "派工查询"
        '
        'TTSShip
        '
        Me.TTSShip.ImageIndex = 13
        Me.TTSShip.Name = "TTSShip"
        Me.TTSShip.Text = "航次信息"
        Me.TTSShip.ToolTipText = "航次信息"
        '
        'TTBInvoice
        '
        Me.TTBInvoice.ImageIndex = 3
        Me.TTBInvoice.Name = "TTBInvoice"
        Me.TTBInvoice.Text = "现场资料"
        Me.TTBInvoice.ToolTipText = "现场资料"
        '
        'TallyRead
        '
        Me.TallyRead.ImageIndex = 11
        Me.TallyRead.Name = "TallyRead"
        Me.TallyRead.Text = "理货报告"
        Me.TallyRead.ToolTipText = "理货报告"
        '
        'TTBS1
        '
        Me.TTBS1.Name = "TTBS1"
        Me.TTBS1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 12
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Text = "数据审核"
        Me.ToolBarButton2.ToolTipText = "完船单证数据复核"
        '
        'TTBInout
        '
        Me.TTBInout.ImageIndex = 4
        Me.TTBInout.Name = "TTBInout"
        Me.TTBInout.Text = "考勤处理"
        Me.TTBInout.ToolTipText = "考勤处理"
        Me.TTBInout.Visible = False
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 9
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "其他考勤"
        Me.ToolBarButton1.ToolTipText = "其他考勤"
        Me.ToolBarButton1.Visible = False
        '
        'TTGZI
        '
        Me.TTGZI.ImageIndex = 2
        Me.TTGZI.Name = "TTGZI"
        Me.TTGZI.Text = "工资查询"
        Me.TTGZI.ToolTipText = "工资查询"
        '
        'TTJJ
        '
        Me.TTJJ.ImageIndex = 10
        Me.TTJJ.Name = "TTJJ"
        Me.TTJJ.Text = "奖金查询"
        Me.TTJJ.ToolTipText = "奖金查询"
        '
        'TTBSeal
        '
        Me.TTBSeal.ImageIndex = 5
        Me.TTBSeal.Name = "TTBSeal"
        Me.TTBSeal.Text = "铅封管理"
        Me.TTBSeal.ToolTipText = "铅封管理"
        '
        'TTBS2
        '
        Me.TTBS2.Name = "TTBS2"
        Me.TTBS2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'TTBPassWord
        '
        Me.TTBPassWord.ImageIndex = 6
        Me.TTBPassWord.Name = "TTBPassWord"
        Me.TTBPassWord.Text = "登录密码"
        Me.TTBPassWord.ToolTipText = "密码修改"
        '
        'TTBLogoff
        '
        Me.TTBLogoff.ImageIndex = 7
        Me.TTBLogoff.Name = "TTBLogoff"
        Me.TTBLogoff.Text = "系统注销"
        Me.TTBLogoff.ToolTipText = "注销"
        '
        'TTBQuit
        '
        Me.TTBQuit.ImageIndex = 8
        Me.TTBQuit.Name = "TTBQuit"
        Me.TTBQuit.Text = "退出系统"
        Me.TTBQuit.ToolTipText = "退出"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        Me.ImageList.Images.SetKeyName(9, "")
        Me.ImageList.Images.SetKeyName(10, "AUTHOR.ICO")
        Me.ImageList.Images.SetKeyName(11, "hg123.ico")
        Me.ImageList.Images.SetKeyName(12, "FONT02.ICO")
        Me.ImageList.Images.SetKeyName(13, "jzx.ico")
        '
        'Timer
        '
        Me.Timer.Interval = 50
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'FrmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(946, 348)
        Me.Controls.Add(Me.ToolBar)
        Me.Controls.Add(Me.stb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "连云港外轮理货信息管理系统_散杂货业务管理子系统"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StBDep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StB_Department, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StB_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STBT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StB_Time, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub FrmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        End
    End Sub

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StB_Department.Text = G_DeptName
        Me.StB_User.Text = G_User
        Me.Timer.Start()
        Me.Timer1.Start()
        Menuitem(1) = WL1_1
        Menuitem(2) = WL11_1
        Menuitem(3) = WL11_2
        Menuitem(4) = WL11_3
        Menuitem(5) = WL1_2
        Menuitem(6) = WL1_3
        Menuitem(7) = WL1_44
        Menuitem(133) = WL1_45

        'Menuitem(8) = WL1_5
        Menuitem(9) = WL1_6
        Menuitem(10) = WL1_7
        Menuitem(11) = WL1_8
        Menuitem(12) = WL1_9
        Menuitem(13) = WL1_10
        Menuitem(14) = WL1_11
        'Menuitem(15) = WL1_13
        'Menuitem(16) = WL1_14
        'Menuitem(17) = WL1_16
        'Menuitem(18) = WL1_21
        Menuitem(19) = WL1_22
        Menuitem(20) = WL1_23
        Menuitem(21) = WL1_24
        'Menuitem(22) = WL1_25
        Menuitem(23) = WL1_26
        Menuitem(24) = WL1_27
        Menuitem(25) = WL1_28
        Menuitem(26) = WL1_29
        'Menuitem(27) = WL1_12
        'Menuitem(28) = WL1_15
        'Menuitem(29) = WL1_17
        'Menuitem(30) = WL1_18
        'Menuitem(31) = WL1_19
        Menuitem(32) = WL1_20
        'Menuitem(33) = WL1_30
        Menuitem(34) = WL11_6
        Menuitem(35) = WL2_1
        Menuitem(36) = WL2_2
        Menuitem(37) = WL2_3
        Menuitem(38) = WL2_4
        Menuitem(39) = WL2_5
        Menuitem(40) = WL3_1
        Menuitem(41) = WL3_2
        Menuitem(42) = WL3_4_3
        Menuitem(43) = WL3_4_5
        Menuitem(44) = WL3_4_6
        Menuitem(45) = WL3_4_7
        Menuitem(46) = WL3_4_9
        Menuitem(47) = WL3_4_10
        Menuitem(48) = WL3_5
        Menuitem(49) = WL3_6_1
        Menuitem(50) = WL3_6_2
        Menuitem(51) = WL3_6_3
        Menuitem(52) = WL3_6_4
        Menuitem(53) = WL3_6_5
        'Menuitem(54) = WL4_1_1
        'Menuitem(55) = WL4_1_2
        'Menuitem(56) = WL4_1_3
        'Menuitem(57) = WL4_2
        'Menuitem(58) = WL4_3
        'Menuitem(59) = WL4_4
        'Menuitem(60) = WL4_5
        'Menuitem(61) = WL4_7
        'Menuitem(62) = WL4_8
        'Menuitem(63) = WL4_9
        'Menuitem(64) = WL4_10
        'Menuitem(65) = WL4_11
        'Menuitem(66) = WL4_14
        'Menuitem(67) = WL4_15
        'Menuitem(68) = WL4_16
        Menuitem(69) = WL9_1
        Menuitem(70) = WL9_2
        Menuitem(71) = WL9_3
        Menuitem(72) = WL9_4
        Menuitem(73) = WL8_1
        Menuitem(74) = WL8_2
        Menuitem(75) = WL8_3
        Menuitem(76) = WL8_4
        Menuitem(77) = WL8_5
        'Menuitem(78) = WL7_1
        'Menuitem(79) = WL7_2_1
        'Menuitem(80) = WL7_2_2
        'Menuitem(81) = WL7_3
        'Menuitem(82) = WL7_4
        'Menuitem(83) = WL7_5
        'Menuitem(84) = WL7_6
        Menuitem(85) = WL10_1
        Menuitem(86) = WL10_2
        Menuitem(87) = WL10_3
        Menuitem(88) = WL10_4
        Menuitem(89) = WL10_5
        Menuitem(90) = WL10_6
        Menuitem(91) = WL10_7
        Menuitem(92) = WL10_8
        Menuitem(93) = WL10_9
        Menuitem(94) = WL10_10
        Menuitem(95) = WL10_11
        Menuitem(96) = WL10_12
        Menuitem(97) = WL10_13
        Menuitem(98) = WL10_14
        Menuitem(99) = WL10_15
        Menuitem(100) = WL10_16
        Menuitem(101) = WL10_17
        'Menuitem(102) = WL5_1
        'Menuitem(103) = WL5_2
        'Menuitem(104) = WL5_3
        'Menuitem(105) = WL5_4
        'Menuitem(106) = WL5_5
        'Menuitem(107) = WL5_6
        'Menuitem(108) = WL5_7
        'Menuitem(109) = WL6_1_1
        'Menuitem(110) = WL6_1_2
        'Menuitem(111) = WL6_2_1
        'Menuitem(112) = WL6_2_2
        'Menuitem(113) = WL6_2_3
        'Menuitem(114) = WL6_2_4
        'Menuitem(115) = WL6_2_5
        'Menuitem(116) = WL6_2_6
        'Menuitem(117) = WL6_3_1
        'Menuitem(118) = WL6_3_2
        'Menuitem(119) = WL6_3_3
        'Menuitem(120) = WL6_3_4
        'Menuitem(121) = WL6_3_5
        'Menuitem(122) = WL6_3_6
        'Menuitem(123) = WL7_7
        'Menuitem(124) = WL7_8
        'Menuitem(125) = WL7_9
        Menuitem(126) = WL8_6
        Menuitem(127) = WL1
        Menuitem(128) = WL2
        Menuitem(129) = WL3
        'Menuitem(130) = WL4
        'Menuitem(131) = WL5
        'Menuitem(132) = WL6
        'Menuitem(133) = WL7
        Menuitem(134) = WL8
        Menuitem(135) = WL9
        Menuitem(136) = WL10
        Menuitem(137) = WL11
        sqlstr = "select FUNC_CODE,FUNC_NAME,FUNC_CODE_View from View_UserPreview where PART_ID= " & G_Part_Id & " and Serial_Nam= '" & G_User_Serial & "'"
        dv = DBControl.Getdata(sqlstr, ds)
        Dim k As Integer '菜单是否可见的标志位
        Dim i As Integer
        Dim j As Integer
        Try
            For i = 1 To 137
                k = 0
                For j = 0 To dv.Count - 1
                    If Menuitem(i).Text = dv(j)("FUNC_Name") And dv(j)("FUNC_CODE_View") = 1 Then
                        Menuitem(i).Enabled = True
                        k = k + 1
                        Exit For
                    End If
                Next
                If k = 0 Then
                    Menuitem(i).Enabled = False
                End If
            Next
        Catch ex As System.Exception
            ' MsgBox(ex.Message)
        End Try
        If G_User_Serial = "WLGCH" Then
            code_manage.Visible = True
            MenuItem21.Visible = True
        End If
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Me.StB_Time.Text = Now()
        If TBar = 1 Then
            Me.ToolBar.Visible = True
        Else
            Me.ToolBar.Visible = False
        End If

        If Mnu = 1 Then
            WL1.Visible = True
            WL2.Visible = True
            WL3.Visible = True
            'WL4.Visible = False
            'WL5.Visible = False
            'WL6.Visible = False
            'WL7.Visible = False
            WL8.Visible = True
            WL9.Visible = True
            WL10.Visible = True
            WL11.Visible = True
            WL12.Visible = True
        Else
            WL1.Visible = False
            WL2.Visible = False
            WL3.Visible = False
            'WL4.Visible = False
            'WL5.Visible = False
            'WL6.Visible = False
            'WL7.Visible = False
            WL8.Visible = False
            WL9.Visible = False
            WL10.Visible = False
            WL11.Visible = False
            WL12.Visible = False
        End If
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        If e.Button.Text = "值班派工" Then
            Call WL2_6_Click(sender, e)
        End If

        If e.Button.Text = "派工查询" Then
            Call WL2_4_Click(sender, e)
        End If


        If e.Button.Text = "航次信息" Then
            Call WL2_2_Click(sender, e)
        End If

        If e.Button.Text = "理货报告" Then
            Call WL3_0_Click(sender, e)
        End If


        If e.Button.Text = "数据审核" Then
            Call WL2_7_Click(sender, e)
        End If

        If e.Button.Text = "现场资料" Then
            Call WL3_3_Click(sender, e)
        End If

        'If e.Button.Text = "考勤处理" Then
        '    Call WL8_2_Click(sender, e)
        'End If

        'If e.Button.Text = "其他考勤" Then
        '    Call MenuItem13_Click(sender, e)
        'End If

        If e.Button.Text = "工资查询" Then
            Call WL8_6_Click(sender, e)
        End If

        If e.Button.Text = "奖金查询" Then
            Call MenuItem19_Click(sender, e)
        End If

        If e.Button.Text = "铅封管理" Then
            TBar = 0
            Mnu = 0
            Dim Frm As New FrmSealInspect
            Frm.ShowDialog()
        End If

        If e.Button.Text = "登录密码" Then
            Dim frm As New FrmUserPass
            frm.ShowDialog()
        End If
        If e.Button.Text = "退出系统" Then
            End
        End If
        If e.Button.Text = "系统注销" Then
            Dim FrmLogin As New FrmLogin
            FrmLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub WL1_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_1.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmDepartMent()
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_2.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmDuty()
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_3.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmBERTH()
        Frm.MdiParent = Me
        Frm.Show()
    End Sub
    Private Sub WL1_45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_45.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCargo 'Frmnewgoods
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_44.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New Frmnewgoodstype
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    'Private Sub WL1_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_4.Click
    '    TBar = 0
    '    Mnu = 0
    '    Dim Frm As New FrmCargo()
    '    Frm.MdiParent = Me
    '    Frm.Show()
    'End Sub

    Private Sub WL1_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmGoodsType
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_6.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmPack
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_7.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmPort
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_8.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmNationality
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_9.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmShipAgent
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_10.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmManager
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_11.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmShipOwner
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim frm As New FrmShipName
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL1_13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmTallyType
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New FrmConPosition
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub

    Private Sub WL1_15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New FrmConDamagedType
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub

    Private Sub WL1_16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New FrmConKind
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub

    Private Sub WL1_17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TBar = 0
        'Mnu = 0
        'Dim frm As New FrmConType
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub WL1_18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TBar = 0
        'Mnu = 0
        'Dim frm As New FrmCONCRITERION
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub WL1_19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim frm As New FrmTypeShipRelation
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL1_20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_20.Click
        TBar = 0
        Mnu = 0
        Dim frm As New FrmCheck
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL1_21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New FrmConTraffic
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub

    Private Sub WL1_22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_22.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCargoDamagedDegree
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_23_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_23.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCargoDamaged
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_24.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmWorkType
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New FrmFee
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub

    Private Sub WL1_26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_26.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmWorkBegin
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_27_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_27.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmWorkTime
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_28.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmTallyClerk
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_29.Click
        TBar = 0
        Mnu = 0
        Dim frm As New FrmDirector
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL1_30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim frm As New FrmEmailName
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL2_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL2_1.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmVessel_Papers
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL2_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL2_2.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmSShip
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL2_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL2_3.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmConsign
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL2_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL2_4.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmAttemper
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL2_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL2_5.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmPigeonhole
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_1.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCARGO_HATCH_LIST
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_2.Click
        TBar = 0
        Mnu = 0
        Dim frm As New FrmCargo_hatch_sheet
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL3_3_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim frm As New FrmTally_sheet
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL3_3_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCARGO_WAITFOR
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_3_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCargo_onport
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_3_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCARGO_MEASURE_LIST
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_3_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmSEAL_EXAM
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_3_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCARGO_DAILY_REPORT
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_4_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCARGO_SHORT
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_4_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCARGO_DAMAGED_List
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_4_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_4_3.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmDAMAGE_work
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_4_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCARGO_MARKS_ASSORTING
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_4_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_4_6.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCARGO_HATCHED
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_4_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_4_7.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New Frmport_unload
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_4_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim Frm As New FRMCARGO_TALLY_CERTIFICATE
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_4_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_4_9.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FRMCARGO_APPEND_FEE
        Frm.MdiParent = Me
        Frm.Show()
    End Sub


    Private Sub WL3_4_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_4_10.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FRMCARGO_CERTIFICATE_SUM
        Frm.MdiParent = Me
        Frm.Show()
    End Sub


    Private Sub WL11_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL11_1.Click
        Dim frm As New FrmUserPass
        frm.MdiParent = Me
        frm.Show()
    End Sub



    Private Sub WL11_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL11_2.Click
        TBar = 0
        Mnu = 0
        Dim frm As New FrmUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL11_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL11_3.Click
        TBar = 0
        Mnu = 0
        Dim frm As New FrmPart
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL8_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL8_1.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmABSENT
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL8_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL8_2.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmABSENT_Print
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL8_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL8_3.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmPAY_PERFORMANCE
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL8_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL8_4.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmATT_PERFORMANCE
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL8_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL8_5.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmSTANDBY_PERFORMANCE
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL11_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL11_4.Click
        Dim Frm As New FrmLogin
        Frm.Show()
        Me.Hide()
    End Sub

    Private Sub WL11_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL11_5.Click
        End
    End Sub

    Private Sub WL9_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL9_1.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmSealIn
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL9_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL9_2.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmSealOut
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL9_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL9_3.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmSealKill
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL9_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL9_4.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmSealInspect
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_6_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_6_1.Click
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New FrmCargoGoods
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub

    Private Sub WL3_6_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_6_2.Click
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New FrmCargoPackSheet
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub

    Private Sub WL3_6_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_6_3.Click
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New FrmCargoPackReport
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub

    Private Sub WL3_6_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_6_4.Click
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New FrmCargoPackManage
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub

    Private Sub WL3_6_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_6_5.Click
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New FrmCargoPackRecord
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub

    Private Sub WL10_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_5.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCropEconomyStatistics
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    'Private Sub WL4_1_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TBar = 0
    '    Mnu = 0
    '    Dim Frm As New FrmEDIReadList
    '    Frm.MdiParent = Me
    '    Frm.Show()
    'End Sub
    Private Sub WL10_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_3.Click
        Dim frm As New Frm_tally_fee_stat_month
        frm.ShowDialog()

    End Sub


    Private Sub WL10_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_7.Click
        Dim frm As New Frm_ship_agent_sort
        frm.ShowDialog()

    End Sub

    Private Sub WL10_15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_15.Click
        'Dim frm As New Frm_con_edi_stat_month
        'frm.ShowDialog()

    End Sub

    Private Sub WL10_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_4.Click
        Dim frm As New Frm_tally_work_stat_month
        frm.ShowDialog()

    End Sub
    Private Sub WL10_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_1.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmREPORT_TALLY_FINANCE
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL10_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_2.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmREPORT_TALLY_QUALITY
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL10_14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_14.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmBILL_PERFORMANCE
        Frm.MdiParent = Me
        Frm.Show()
    End Sub
    Private Sub WL10_16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_16.Click
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New FrmConLoadContainerStatistics
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub
    Private Sub WL10_13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_13.Click
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New FrmCargoWaterReport
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub
    Private Sub WL10_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_8.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmFinishShipStatistics
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL10_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_6.Click
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New FrmFinishVesselStatistics
        'Frm.MdiParent = Me
        'Frm.Show()

        TBar = 0
        Mnu = 0
        Dim Frm As New FrmAccountStat
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL10_12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_12.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FRMCARGO_MONTH
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL10_11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_11.Click
        TBar = 0
        Mnu = 0
        'Dim Frm As New FRMCARGO_CON_YEARTALLY
        Dim Frm As New FrmReportNew
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL11_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL11_6.Click
        Dim Frm As New FrmEDIINI
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL8_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL8_6.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmTally_Wage
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New frm_conload
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim Frm As New FrmBILL_2_INVOICE
        'Frm.ShowDialog()
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New FrmBILL_2_INVOICE_C
        'frm.ShowDialog()
    End Sub

    Private Sub WL3_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_5.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmGraph
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        TALLY.DBControl.KillTotalExcelProcess()  '清除所有EXCEL进程
    End Sub

    'Private Sub WL4_1_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TBar = 0
    '    Mnu = 0
    '    Dim Frm As New FrmEDIWriteList
    '    Frm.MdiParent = Me
    '    Frm.Show()
    'End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCargo_onport
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FRMCARGO_CERTIFICATE
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TBar = 0
        'Mnu = 0
        'Dim Frm As New FrmCon_Onport
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        'TBar = 0
        'Mnu = 0
        'Dim frm As New FrmCargoPackTest
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub WL10_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_9.Click
        Dim Frm As New Frmreport_cargo
        Frm.ShowDialog()
    End Sub

    Private Sub WL10_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_10.Click
        Dim Frm As New FrmReport_CON
        Frm.ShowDialog()
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmSEAL_EXAM
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL3_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_3.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCargo_onport
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCARGO_Monitor
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL2_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL2_6.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmAttemper_NewMain
        Frm.MinimizeBox = False
        Frm.MaximizeBox = False
        Frm.ShowDialog()
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmABSENT_Print_tmp
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL11_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL11_7.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmFax
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            sqlstr = "SELECT * FROM VIEW_FAX where DEPT_CODE= '" & G_DeptCode & "' and statu=0 order by id desc "
            dvtime1 = DBControl.Getdata(sqlstr, dstime1)
            If dvtime1.Count > 0 Then
                GL_FAX = dstime1.Tables(0).Rows(0)("id")
                If GL_READ = 0 Then
                    Me.Text = Me.Text & "___________您有" & dvtime1.Count & "条未读信息___________"
                    GL_READ = 1
                    'Dim Frm As New FrmFax_Query
                    'Frm.ShowDialog()
                End If
            Else
                Me.Text = "外轮理货信息管理系统_散杂货业务管理子系统"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub upload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upload.Click
        Dim Frm As New FrmUpload
        'Frm.MdiParent = Me
        Frm.ShowDialog()
    End Sub

    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        TBar = 0
        Mnu = 0
        'Dim Frm As New FrmFileView
        Dim Frm As New File_bak
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL12_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL12_2.Click
        'Dim t As Char
        'Dim s As Integer
        't = "a"
        's = System.Convert.ToInt16(t)

        'Dim i As Integer = 1
        'Dim temp As Integer = 3
        'Dim ran As New Random(i * temp * System.Convert.ToDouble((DateTime.Now.Ticks)))

        'Dim Frm As New FrmGraphtest
        'Frm.ShowDialog()

        MessageBox.Show(String.Format("连云港外理散杂货理货系统 V{0}", Application.ProductVersion), "关于", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub WL3_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL3_0.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCARGO_HATCH_LIST_new
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Dim Frm As New FrmRs_Salary_In
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub MenuItem19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New Frm_Bonus_New
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub code_manage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles code_manage.Click
        If G_User_Serial = "WLGCH" Then
            TBar = 0
            Mnu = 0
            Dim Frm As New FrmOperationManage
            Frm.MdiParent = Me
            Frm.Show()
        End If
    End Sub

    Private Sub His_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles His_info.Click
        Dim Frm As New Frm_His
        Frm.ShowDialog()
    End Sub

    Private Sub WL2_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL2_7.Click
        '件杂货
        If G_Part_Id = "49" Or G_Part_Id = "27" Or G_Part_Id = "9" Or G_Part_Id = "1" Then '审核员
            TBar = 0
            Mnu = 0
            Dim Frm As New FrmCargo_verify
            Frm.MdiParent = Me
            Frm.Show()
        End If
        '集装箱
        'If G_Part_Id = "49" Or G_Part_Id = "1" Then '审核员
        '    TBar = 0
        '    Mnu = 0
        '    Dim Frm As New FrmCon_Verify
        '    Frm.MdiParent = Me
        '    Frm.Show()
        'End If
    End Sub

    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        If G_User_Serial = "WLGCH" Then
            Dim Frm As New CODE_SYNC
            Frm.ShowDialog()
        End If
    End Sub

    Private Sub MenuItem23_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Dim Frm As New FrmCargo_verify3
        Frm.ShowDialog()
    End Sub

    ''' <summary>
    ''' 动态链接库接收参数 TallyOther
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReceiveParametersOther()
        TallyOther.G_User = G_User
        TallyOther.G_User_Serial = G_User_Serial
        TallyOther.G_DeptCode = G_DeptCode
        TallyOther.G_DeptName = G_DeptName
        TallyOther.G_Part_Id = G_Part_Id
        TallyOther.G_Part = G_Part
    End Sub

    Private Sub mnuReportRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportRecord.Click
        Dim fm As New TallyOther.FrmReportRecord
        fm.SysType = SysType
        fm.Controls.Add(Me.stb)
        Hide()
        ReceiveParametersOther()
        fm.ShowDialog()
        Me.Controls.Add(Me.stb)
        Show()
    End Sub
End Class
