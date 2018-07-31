Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmAttemper_ManagerQuery
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents CmbDAYNIGHTMARK As System.Windows.Forms.ComboBox
    Friend WithEvents DTPWATCHDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btQuery As System.Windows.Forms.Button
    Friend WithEvents tbctrl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents C1_5 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1_4 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1_3 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1_2 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1_1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1info As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents C1DBG5V As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBG4 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBG5 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAttemper_ManagerQuery))
        Me.CmbDAYNIGHTMARK = New System.Windows.Forms.ComboBox
        Me.DTPWATCHDATE = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btQuery = New System.Windows.Forms.Button
        Me.tbctrl = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GB2 = New System.Windows.Forms.GroupBox
        Me.C1DBG5V = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.C1DBG5 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.C1DBG4 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.C1_5 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1_4 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1_3 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1_2 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1_1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1info = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.btnQuit = New System.Windows.Forms.Button
        Me.tbctrl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GB2.SuspendLayout()
        CType(Me.C1DBG5V, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1DBG5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1DBG4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.C1_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbDAYNIGHTMARK
        '
        Me.CmbDAYNIGHTMARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDAYNIGHTMARK.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CmbDAYNIGHTMARK.Location = New System.Drawing.Point(298, 18)
        Me.CmbDAYNIGHTMARK.Name = "CmbDAYNIGHTMARK"
        Me.CmbDAYNIGHTMARK.Size = New System.Drawing.Size(84, 24)
        Me.CmbDAYNIGHTMARK.TabIndex = 42
        '
        'DTPWATCHDATE
        '
        Me.DTPWATCHDATE.CustomFormat = "yyyy年MM月dd日"
        Me.DTPWATCHDATE.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DTPWATCHDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWATCHDATE.Location = New System.Drawing.Point(80, 16)
        Me.DTPWATCHDATE.Name = "DTPWATCHDATE"
        Me.DTPWATCHDATE.Size = New System.Drawing.Size(150, 26)
        Me.DTPWATCHDATE.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 22)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "日  期"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 22)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "白夜班"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuery
        '
        Me.btQuery.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btQuery.Location = New System.Drawing.Point(390, 16)
        Me.btQuery.Name = "btQuery"
        Me.btQuery.Size = New System.Drawing.Size(62, 28)
        Me.btQuery.TabIndex = 43
        Me.btQuery.Text = "查 询"
        '
        'tbctrl
        '
        Me.tbctrl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbctrl.Controls.Add(Me.TabPage1)
        Me.tbctrl.Controls.Add(Me.TabPage3)
        Me.tbctrl.Controls.Add(Me.TabPage2)
        Me.tbctrl.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tbctrl.Location = New System.Drawing.Point(4, 56)
        Me.tbctrl.Name = "tbctrl"
        Me.tbctrl.SelectedIndex = 0
        Me.tbctrl.Size = New System.Drawing.Size(975, 538)
        Me.tbctrl.TabIndex = 44
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GB2)
        Me.TabPage1.Controls.Add(Me.C1DBG)
        Me.TabPage1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(967, 509)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "          船派工           "
        '
        'GB2
        '
        Me.GB2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GB2.Controls.Add(Me.C1DBG5V)
        Me.GB2.Location = New System.Drawing.Point(11, 327)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(256, 182)
        Me.GB2.TabIndex = 2
        Me.GB2.TabStop = False
        Me.GB2.Text = "船派工信息"
        '
        'C1DBG5V
        '
        Me.C1DBG5V.CaptionHeight = 18
        Me.C1DBG5V.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG5V.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C1DBG5V.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG5V.Images.Add(CType(resources.GetObject("C1DBG5V.Images"), System.Drawing.Image))
        Me.C1DBG5V.Location = New System.Drawing.Point(3, 22)
        Me.C1DBG5V.Name = "C1DBG5V"
        Me.C1DBG5V.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG5V.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG5V.PreviewInfo.ZoomFactor = 75
        Me.C1DBG5V.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG5V.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG5V.RowHeight = 16
        Me.C1DBG5V.Size = New System.Drawing.Size(250, 157)
        Me.C1DBG5V.TabIndex = 0
        Me.C1DBG5V.PropBag = resources.GetString("C1DBG5V.PropBag")
        '
        'C1DBG
        '
        Me.C1DBG.AllowColMove = False
        Me.C1DBG.AllowDrag = True
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(2, 2)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(962, 323)
        Me.C1DBG.TabIndex = 0
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(967, 509)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "            考    勤          "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.C1DBG5)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 505)
        Me.GroupBox2.TabIndex = 116
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "庙岭理货部"
        '
        'C1DBG5
        '
        Me.C1DBG5.AllowColMove = False
        Me.C1DBG5.CaptionHeight = 18
        Me.C1DBG5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG5.Enabled = False
        Me.C1DBG5.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C1DBG5.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG5.Images.Add(CType(resources.GetObject("C1DBG5.Images"), System.Drawing.Image))
        Me.C1DBG5.Location = New System.Drawing.Point(3, 22)
        Me.C1DBG5.Name = "C1DBG5"
        Me.C1DBG5.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG5.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG5.PreviewInfo.ZoomFactor = 75
        Me.C1DBG5.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG5.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG5.RowHeight = 16
        Me.C1DBG5.Size = New System.Drawing.Size(311, 480)
        Me.C1DBG5.TabIndex = 0
        Me.C1DBG5.PropBag = resources.GetString("C1DBG5.PropBag")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.C1DBG4)
        Me.GroupBox1.Location = New System.Drawing.Point(435, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 505)
        Me.GroupBox1.TabIndex = 115
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "连云理货部"
        Me.GroupBox1.Visible = False
        '
        'C1DBG4
        '
        Me.C1DBG4.AllowColMove = False
        Me.C1DBG4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG4.Enabled = False
        Me.C1DBG4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C1DBG4.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG4.Images.Add(CType(resources.GetObject("C1DBG4.Images"), System.Drawing.Image))
        Me.C1DBG4.Location = New System.Drawing.Point(3, 22)
        Me.C1DBG4.Name = "C1DBG4"
        Me.C1DBG4.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG4.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG4.PreviewInfo.ZoomFactor = 75
        Me.C1DBG4.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG4.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG4.Size = New System.Drawing.Size(311, 480)
        Me.C1DBG4.TabIndex = 0
        Me.C1DBG4.Visible = False
        Me.C1DBG4.PropBag = resources.GetString("C1DBG4.PropBag")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.C1_5)
        Me.TabPage2.Controls.Add(Me.C1_4)
        Me.TabPage2.Controls.Add(Me.C1_3)
        Me.TabPage2.Controls.Add(Me.C1_2)
        Me.TabPage2.Controls.Add(Me.C1_1)
        Me.TabPage2.Controls.Add(Me.C1info)
        Me.TabPage2.Controls.Add(Me.Label31)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(967, 509)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Visible = False
        '
        'C1_5
        '
        Me.C1_5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C1_5.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1_5.Images.Add(CType(resources.GetObject("C1_5.Images"), System.Drawing.Image))
        Me.C1_5.Location = New System.Drawing.Point(746, 42)
        Me.C1_5.Name = "C1_5"
        Me.C1_5.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1_5.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1_5.PreviewInfo.ZoomFactor = 75
        Me.C1_5.PrintInfo.PageSettings = CType(resources.GetObject("C1_5.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1_5.Size = New System.Drawing.Size(136, 444)
        Me.C1_5.TabIndex = 11
        Me.C1_5.Text = "C1TrueDBGrid6"
        Me.C1_5.Visible = False
        Me.C1_5.PropBag = resources.GetString("C1_5.PropBag")
        '
        'C1_4
        '
        Me.C1_4.AllowRowSelect = False
        Me.C1_4.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1_4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C1_4.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1_4.Images.Add(CType(resources.GetObject("C1_4.Images"), System.Drawing.Image))
        Me.C1_4.Location = New System.Drawing.Point(598, 42)
        Me.C1_4.Name = "C1_4"
        Me.C1_4.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1_4.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1_4.PreviewInfo.ZoomFactor = 75
        Me.C1_4.PrintInfo.PageSettings = CType(resources.GetObject("C1_4.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1_4.Size = New System.Drawing.Size(136, 444)
        Me.C1_4.TabIndex = 10
        Me.C1_4.Text = "C1TrueDBGrid5"
        Me.C1_4.Visible = False
        Me.C1_4.PropBag = resources.GetString("C1_4.PropBag")
        '
        'C1_3
        '
        Me.C1_3.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.IndividualRows
        Me.C1_3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C1_3.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1_3.Images.Add(CType(resources.GetObject("C1_3.Images"), System.Drawing.Image))
        Me.C1_3.Location = New System.Drawing.Point(450, 42)
        Me.C1_3.Name = "C1_3"
        Me.C1_3.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1_3.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1_3.PreviewInfo.ZoomFactor = 75
        Me.C1_3.PrintInfo.PageSettings = CType(resources.GetObject("C1_3.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1_3.Size = New System.Drawing.Size(136, 444)
        Me.C1_3.TabIndex = 9
        Me.C1_3.Text = "C1TrueDBGrid4"
        Me.C1_3.Visible = False
        Me.C1_3.PropBag = resources.GetString("C1_3.PropBag")
        '
        'C1_2
        '
        Me.C1_2.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.IndividualRows
        Me.C1_2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C1_2.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1_2.Images.Add(CType(resources.GetObject("C1_2.Images"), System.Drawing.Image))
        Me.C1_2.Location = New System.Drawing.Point(302, 42)
        Me.C1_2.Name = "C1_2"
        Me.C1_2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1_2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1_2.PreviewInfo.ZoomFactor = 75
        Me.C1_2.PrintInfo.PageSettings = CType(resources.GetObject("C1_2.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1_2.Size = New System.Drawing.Size(136, 444)
        Me.C1_2.TabIndex = 8
        Me.C1_2.Text = "C1TrueDBGrid3"
        Me.C1_2.Visible = False
        Me.C1_2.PropBag = resources.GetString("C1_2.PropBag")
        '
        'C1_1
        '
        Me.C1_1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.IndividualRows
        Me.C1_1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C1_1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1_1.Images.Add(CType(resources.GetObject("C1_1.Images"), System.Drawing.Image))
        Me.C1_1.Location = New System.Drawing.Point(154, 42)
        Me.C1_1.Name = "C1_1"
        Me.C1_1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1_1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1_1.PreviewInfo.ZoomFactor = 75
        Me.C1_1.PrintInfo.PageSettings = CType(resources.GetObject("C1_1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1_1.Size = New System.Drawing.Size(136, 444)
        Me.C1_1.TabIndex = 7
        Me.C1_1.Text = "C1TrueDBGrid2"
        Me.C1_1.Visible = False
        Me.C1_1.PropBag = resources.GetString("C1_1.PropBag")
        '
        'C1info
        '
        Me.C1info.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.IndividualRows
        Me.C1info.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C1info.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1info.Images.Add(CType(resources.GetObject("C1info.Images"), System.Drawing.Image))
        Me.C1info.Location = New System.Drawing.Point(6, 42)
        Me.C1info.Name = "C1info"
        Me.C1info.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1info.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1info.PreviewInfo.ZoomFactor = 75
        Me.C1info.PrintInfo.PageSettings = CType(resources.GetObject("C1info.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1info.Size = New System.Drawing.Size(136, 444)
        Me.C1info.TabIndex = 6
        Me.C1info.Text = "C1TrueDBGrid1"
        Me.C1info.Visible = False
        Me.C1info.PropBag = resources.GetString("C1info.PropBag")
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(746, 14)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(136, 23)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "驻场站五部"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label31.Visible = False
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(598, 14)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(136, 23)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "驻场站四部"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label30.Visible = False
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(450, 14)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(136, 23)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = "驻场站三部"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label29.Visible = False
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(304, 14)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(136, 23)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "驻场站二部"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label28.Visible = False
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(154, 14)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(136, 23)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "驻场站一部"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label27.Visible = False
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(6, 14)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(136, 23)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "信息中心"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label26.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnQuit.Image = CType(resources.GetObject("btnQuit.Image"), System.Drawing.Image)
        Me.btnQuit.Location = New System.Drawing.Point(506, 14)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(82, 30)
        Me.btnQuit.TabIndex = 45
        Me.btnQuit.Text = "退 出"
        '
        'FrmAttemper_ManagerQuery
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.tbctrl)
        Me.Controls.Add(Me.btQuery)
        Me.Controls.Add(Me.CmbDAYNIGHTMARK)
        Me.Controls.Add(Me.DTPWATCHDATE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAttemper_ManagerQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "派工考勤信息查询"
        Me.tbctrl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GB2.ResumeLayout(False)
        CType(Me.C1DBG5V, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.C1DBG5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.C1DBG4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.C1_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim PGFlag As Integer
    Dim dwShipWorkRecord As New DataView
    Dim dsShipWorkRecord As New DataSet
    Dim ds As New DataSet
    Dim dsPre As New DataSet
    Dim dsPreQ As New DataSet
    Dim dskq As New DataSet
    Dim dskq1 As New DataSet
    Dim ds_sub As New DataSet
    Dim dsship As New DataSet
    Dim dstmp As New DataSet
    Dim dw As New DataView
    Dim dwkq As New DataView
    Dim dwkq1 As New DataView
    Dim dw_sub As New DataView
    Dim dwship As New DataView
    Dim dwtmp As New DataView
    Dim sqlda As New SqlClient.SqlDataAdapter
    Dim sqldakq As New SqlClient.SqlDataAdapter
    Dim sqlda_sub As New SqlClient.SqlDataAdapter
    Dim sqldatmp As New SqlClient.SqlDataAdapter
    Dim PIECE As Integer
    Dim TONS As Double
    Dim TALLY_CARGO As Integer
    Dim TALLY_CARGO_TON As Double
    Dim TALLY_CARGO_his As Integer
    Dim TALLY_CARGO_TON_his As Double
    Dim TOTAL_NUM As Integer
    Dim TOTAL_NUM_TON As Double
    Dim REMAIN As Integer
    Dim REMAIN_TON As Double

    Dim SqlStr As String  '条件语句
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    Dim ResureMark As Integer
    Dim tttt As Integer
    Private Sub FrmAttemper_ManagerQuery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillDAYNIGHTMARK()
    End Sub
    Private Sub FillDAYNIGHTMARK()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "SELECT Code_WorkTime,WorkTime FROM Code_WorkTime"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDAYNIGHTMARK.DataSource = dvc
        Me.CmbDAYNIGHTMARK.DisplayMember = "WorkTime"
        Me.CmbDAYNIGHTMARK.ValueMember = "Code_WorkTime"
    End Sub

    Private Sub CQuery()
        Dim strsql As String
        Dim i As Integer
        FirmStr = " Order by Dept_Code,Ship_Statu"
        'DynaStr = " ( ship_id in (select distinct ship_id from WATCH_RECORD_SHIP where datediff(dd,WATCHSHIPDATE ,'" & DTPWATCHDATE.Value & "')=0 and  DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "') and DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) "
        DynaStr = " datediff(dd,WATCHSHIPDATE ,'" & DTPWATCHDATE.Value & "')=0 and  DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "' "
        SqlStr = DynaStr & FirmStr
        strsql = "select * from WATCH_RECORD_Query where " & SqlStr
        dwship = Getdata(strsql, dsship)
        Try
            Me.C1DBG.DataSource = dwship
            For i = 0 To 4
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBG.Columns.Item("DEPT_SHORT").Caption = "部门"
            Me.C1DBG.Columns.Item("BERTHNO").Caption = "泊位"
            Me.C1DBG.Columns.Item("BERTH_POSITION").Caption = "位置"
            Me.C1DBG.Columns.Item("CHI_VESSEL").Caption = "船名"
            Me.C1DBG.Columns.Item("VOYAGE").Caption = "航次"
            Me.C1DBG.Columns.Item("NATIONALITY_CHA").Caption = "国籍"
            Me.C1DBG.Columns.Item("InOutPort_Name").Caption = "进/出"
            Me.C1DBG.Columns.Item("PORT_CHA").Caption = "港名"
            Me.C1DBG.Columns.Item("GOODS_CHA").Caption = "货名"
            Me.C1DBG.Columns.Item("PIECE").Caption = "原配件数"
            Me.C1DBG.Columns.Item("TONS").Caption = "原配吨数"
            Me.C1DBG.Columns.Item("REMAIN").Caption = "剩余件数"
            Me.C1DBG.Columns.Item("REMAIN_TON").Caption = "剩余吨数"
            Me.C1DBG.Columns.Item("SHIPAGENT_SHORT").Caption = "船代"
            C1DBG.Columns.Item("WATCHSHIPDATE").Caption = "派工时间"
            C1DBG.Columns.Item("WORKTIME_BEGIN").Caption = "开工时间"
            Me.C1DBG.Columns.Item("WORKTIME_END").Caption = "完工时间"
            Me.C1DBG.Columns.Item("tons_sum").Caption = "吨数"
            C1DBG.Columns.Item("WATCHSHIPDATE").NumberFormat = "yy/MM/dd HH:mm"
            C1DBG.Columns.Item("WORKTIME_BEGIN").NumberFormat = "yy/MM/dd HH:mm"
            C1DBG.Columns.Item("WORKTIME_END").NumberFormat = "yy/MM/dd HH:mm"
            For i = 5 To C1DBG.Columns.Count - 1
                C1DBG.Splits(0).DisplayColumns.Item(i).AutoSize()
            Next
            Me.C1DBG.FetchRowStyles = True
            Me.C1DBG.Refresh()
            'tbctrl.SelectedTab = TabPage1


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
    End Sub

    Private Sub btQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuery.Click
        Call CQuery()
        Call C2Query()
        Call C1Query()
    End Sub
    Private Sub C2Query()


        GL_Str = CmbDAYNIGHTMARK.SelectedValue
        GL_Time = DTPWATCHDATE.Value
        On Error GoTo Err
        Dim sqlstr As String

        'sqlstr = "select DEPT_CODE,WORK_NO,DAYNIGHTMARK+10 as Code_HOLIDAY_TYPE,Code_workstat from ABSENT where DEPT_CODE Like '" & G_DeptCode & "' and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0  ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
        'If G_DeptCode = "26.11.11" Then
        sqlstr = "select * from ABSENT where (DEPT_CODE = '26.11.11' or DEPT_CODE ='29.11.11') and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0  ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
        'Else
        '    sqlstr = "select * from ABSENT where (DEPT_CODE = '" & G_DeptCode & "' ) and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0  ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
        'End If
        'dwkq = Updatedata(sqldakq, sqlstr, dskq)

        'Call FillDAYNIGHTMARK()
        'Call FillDEPT_CODE()

        dwkq = Getdata(sqlstr, dskq)
        If dwkq.Count > 0 Then
            'CmbDEPT_CODE.SelectedValue = dskq.Tables(0).Rows(0).Item("DEPT_CODE")
            'DTPWATCHDATE.Value = dskq.Tables(0).Rows(0).Item("ABSENTDATE")
            'CmbWORK_TYPE.Text = dskq.Tables(0).Rows(0).Item("WORK_TYPE")
            'CmbDAYNIGHTMARK.SelectedValue = dskq.Tables(0).Rows(0).Item("DAYNIGHTMARK")

            '***************定义子表
            Dim i As Integer
            Dim dst As New DataSet
            Dim sqla As New SqlClient.SqlDataAdapter
            Dim sqlc As New SqlClient.SqlCommand

            Me.C1DBG4.DataSource = dwkq

            For i = 0 To Me.C1DBG4.Columns.Count - 1
                Me.C1DBG4.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBG4.Splits(0).DisplayColumns.Item("dept_code").Visible = True
            Me.C1DBG4.Splits(0).DisplayColumns.Item("WORK_NO").Visible = True
            Me.C1DBG4.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").Visible = True

            Me.C1DBG4.Splits(0).DisplayColumns.Item("Code_workstat").Visible = True


            Me.C1DBG4.Columns.Item("WORK_NO").Caption = "姓名"
            Me.C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").Caption = "假别"
            Me.C1DBG4.Columns.Item("dept_code").Caption = "部门"
            Me.C1DBG4.Columns.Item("Code_workstat").Caption = "工作状态"

            Me.C1DBG4.Splits(0).DisplayColumns("dept_code").Width = 40
            Me.C1DBG4.Splits(0).DisplayColumns("WORK_NO").Width = 70
            Me.C1DBG4.Splits(0).DisplayColumns("Code_HOLIDAY_TYPE").Width = 80
            Me.C1DBG4.Splits(0).DisplayColumns("Code_workstat").Width = 80
            Me.C1DBG4.Refresh()

            '***************姓名
            Me.C1DBG4.Columns.Item("WORK_NO").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG4.Columns.Item("WORK_NO").ValueItems.Translate = True
            Me.C1DBG4.Columns.Item("WORK_NO").ValueItems.Validate = True
            Me.C1DBG4.Splits(0).DisplayColumns.Item("WORK_NO").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT NAME, WORK_NO FROM TALLY_CLERK"
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("NAME"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("WORK_NO"))
                Me.C1DBG4.Columns.Item("WORK_NO").ValueItems.Values.Add(vi)
            Next

            '***************假别
            Me.C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Translate = True
            Me.C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Validate = True
            If G_DeptCode = "26.11" Then
                Me.C1DBG4.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").AllowFocus = False
            End If
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT Code_Holiday_Type,Holiday_Type FROM Code_Holiday_Type where Code_Holiday_Type<98 order by orderby,convert(int,Code_Holiday_Type) "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("Holiday_Type"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("Code_Holiday_Type"))
                Me.C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Values.Add(vi)
            Next
            '***************理货部
            Me.C1DBG4.Columns.Item("dept_code").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG4.Columns.Item("dept_code").ValueItems.Translate = True
            Me.C1DBG4.Columns.Item("dept_code").ValueItems.Validate = True
            Me.C1DBG4.Splits(0).DisplayColumns.Item("dept_code").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT DEPT_CODE, DEPT_SHORT FROM DEPARTMENT"
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("DEPT_SHORT"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("DEPT_CODE"))
                Me.C1DBG4.Columns.Item("DEPT_CODE").ValueItems.Values.Add(vi)
            Next
            '***************状态
            Me.C1DBG4.Columns.Item("Code_workstat").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG4.Columns.Item("Code_workstat").ValueItems.Translate = True
            Me.C1DBG4.Columns.Item("Code_workstat").ValueItems.Validate = True
            'Me.C1DBG.Splits(0).DisplayColumns.Item("Code_workstat").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT Code_workstat,workstat FROM Code_workstat" ' order by convert(int,Code_workstat) "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("workstat"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("Code_workstat"))
                Me.C1DBG4.Columns.Item("Code_workstat").ValueItems.Values.Add(vi)
            Next
        End If
        '***************************************************************************

        'sqlstr = "select DEPT_CODE,WORK_NO,DAYNIGHTMARK+10 as Code_HOLIDAY_TYPE,Code_workstat from ABSENT where DEPT_CODE Like '" & G_DeptCode & "' and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0  ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
        'If G_DeptCode = "26.11.11" Then
        sqlstr = "select * from ABSENT where (DEPT_CODE = '26.11.12' or DEPT_CODE = '29.11.12') and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0  ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
        'Else
        '    sqlstr = "select * from ABSENT where (DEPT_CODE = '" & G_DeptCode & "' ) and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0  ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
        'End If
        dwkq1 = Getdata(sqlstr, dskq1)

        'Call FillDAYNIGHTMARK()
        'Call FillDEPT_CODE()

        'dwkq = Updatedata(sqldakq, sqlstr, dskq)
        If dwkq1.Count > 0 Then
            'CmbDEPT_CODE.SelectedValue = dskq.Tables(0).Rows(0).Item("DEPT_CODE")
            'DTPWATCHDATE.Value = dskq.Tables(0).Rows(0).Item("ABSENTDATE")
            'CmbWORK_TYPE.Text = dskq.Tables(0).Rows(0).Item("WORK_TYPE")
            'CmbDAYNIGHTMARK.SelectedValue = dskq.Tables(0).Rows(0).Item("DAYNIGHTMARK")

            '***************定义子表
            Dim i As Integer
            Dim dst1 As New DataSet
            Dim sqla1 As New SqlClient.SqlDataAdapter
            Dim sqlc1 As New SqlClient.SqlCommand

            Me.C1DBG5.DataSource = dwkq1

            For i = 0 To Me.C1DBG5.Columns.Count - 1
                Me.C1DBG5.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBG5.Splits(0).DisplayColumns.Item("dept_code").Visible = True
            Me.C1DBG5.Splits(0).DisplayColumns.Item("WORK_NO").Visible = True
            Me.C1DBG5.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").Visible = True

            Me.C1DBG5.Splits(0).DisplayColumns.Item("Code_workstat").Visible = True


            Me.C1DBG5.Columns.Item("WORK_NO").Caption = "姓名"
            Me.C1DBG5.Columns.Item("Code_HOLIDAY_TYPE").Caption = "假别"
            Me.C1DBG5.Columns.Item("dept_code").Caption = "部门"
            Me.C1DBG5.Columns.Item("Code_workstat").Caption = "工作状态"

            Me.C1DBG5.Splits(0).DisplayColumns("dept_code").Width = 40
            Me.C1DBG5.Splits(0).DisplayColumns("WORK_NO").Width = 70
            Me.C1DBG5.Splits(0).DisplayColumns("Code_HOLIDAY_TYPE").Width = 80
            Me.C1DBG5.Splits(0).DisplayColumns("Code_workstat").Width = 80
            Me.C1DBG5.Refresh()

            '***************姓名
            Me.C1DBG5.Columns.Item("WORK_NO").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG5.Columns.Item("WORK_NO").ValueItems.Translate = True
            Me.C1DBG5.Columns.Item("WORK_NO").ValueItems.Validate = True
            Me.C1DBG5.Splits(0).DisplayColumns.Item("WORK_NO").AllowFocus = False
            sqlc1.Connection = sqlconn
            sqlc1.CommandText = "SELECT NAME, WORK_NO FROM TALLY_CLERK"
            sqla1.SelectCommand = sqlc1
            dst1.Reset()
            sqla1.Fill(dst1)
            For i = 0 To dst1.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst1.Tables(0).Rows(i)("NAME"))
                vi.Value = Trim(dst1.Tables(0).Rows(i)("WORK_NO"))
                Me.C1DBG5.Columns.Item("WORK_NO").ValueItems.Values.Add(vi)
            Next

            '***************假别
            Me.C1DBG5.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG5.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Translate = True
            Me.C1DBG5.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Validate = True
            If G_DeptCode = "26.11" Then
                Me.C1DBG5.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").AllowFocus = False
            End If
            sqlc1.Connection = sqlconn
            sqlc1.CommandText = "SELECT Code_Holiday_Type,Holiday_Type FROM Code_Holiday_Type where Code_Holiday_Type<98 order by orderby,convert(int,Code_Holiday_Type) "
            sqla1.SelectCommand = sqlc1
            dst1.Reset()
            sqla1.Fill(dst1)
            For i = 0 To dst1.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst1.Tables(0).Rows(i)("Holiday_Type"))
                vi.Value = Trim(dst1.Tables(0).Rows(i)("Code_Holiday_Type"))
                Me.C1DBG5.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Values.Add(vi)
            Next
            '***************理货部
            Me.C1DBG5.Columns.Item("dept_code").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG5.Columns.Item("dept_code").ValueItems.Translate = True
            Me.C1DBG5.Columns.Item("dept_code").ValueItems.Validate = True
            Me.C1DBG5.Splits(0).DisplayColumns.Item("dept_code").AllowFocus = False
            sqlc1.Connection = sqlconn
            sqlc1.CommandText = "SELECT DEPT_CODE, DEPT_SHORT FROM DEPARTMENT"
            sqla1.SelectCommand = sqlc1
            dst1.Reset()
            sqla1.Fill(dst1)
            For i = 0 To dst1.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst1.Tables(0).Rows(i)("DEPT_SHORT"))
                vi.Value = Trim(dst1.Tables(0).Rows(i)("DEPT_CODE"))
                Me.C1DBG5.Columns.Item("DEPT_CODE").ValueItems.Values.Add(vi)
            Next
            '***************状态
            Me.C1DBG5.Columns.Item("Code_workstat").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG5.Columns.Item("Code_workstat").ValueItems.Translate = True
            Me.C1DBG5.Columns.Item("Code_workstat").ValueItems.Validate = True
            'Me.C1DBG.Splits(0).DisplayColumns.Item("Code_workstat").AllowFocus = False
            sqlc1.Connection = sqlconn
            sqlc1.CommandText = "SELECT Code_workstat,workstat FROM Code_workstat" ' order by convert(int,Code_workstat) "
            sqla1.SelectCommand = sqlc1
            dst1.Reset()
            sqla1.Fill(dst1)
            For i = 0 To dst1.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst1.Tables(0).Rows(i)("workstat"))
                vi.Value = Trim(dst1.Tables(0).Rows(i)("Code_workstat"))
                Me.C1DBG5.Columns.Item("Code_workstat").ValueItems.Values.Add(vi)
            Next
        End If

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        Dim dsClerk As New DataSet
        Dim dwClerk As New DataView
        Dim dstemp As New DataSet
        Dim dwtemp As New DataView
        Dim dstmp As New DataSet
        Dim dwtmp As New DataView
        Dim i As Integer

        'If G_DeptCode = "26.11" Then
        SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0  and DEPT_CODE Like '26.11%' and SHIP_ID=" & Me.C1DBG.Columns.Item("SHIP_ID").Text & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
        dwClerk = Updatedata(sqlda, SqlStr, dsClerk)
        ' Else
        '    SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0 and WORK_TYPE='" & CmbWORK_TYPE.SelectedValue & "' and DEPT_CODE ='" & G_DeptCode & "' and SHIP_ID=" & Me.C1DBG5.Columns.Item("SHIP_ID").Text & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
        '    dwClerk = Updatedata(sqlda, SqlStr, dsClerk)
        ' End If
        If dwClerk.Count > 0 Then                       '********* 派工，编辑 
            'ID = dwClerk(0)(0)
            'GL_Clerk = 1
            Me.C1DBG5V.Visible = True
            Me.C1DBG5V.Refresh()
        Else
            'GL_Clerk = 0
            Me.C1DBG5V.Visible = False
            Me.C1DBG5V.Refresh()
            MsgBox("此船无派工信息！", MsgBoxStyle.Information, "提示")
            Exit Sub
        End If

        Dim st As String
        'st = "exec TALLY_CLERK_Query '" & DTPWATCHDATE.Value & "','" & Me.C1DBG.Columns.Item("DEPT_CODE").Text & "','" & CmbWORK_TYPE.SelectedValue & "'," & Me.C1DBG.Columns.Item("SHIP_ID").Text & ",'" & CmbDAYNIGHTMARK.SelectedValue & "'"
        dwClerk = Getdata("exec TALLY_CLERK_Query '" & DTPWATCHDATE.Value & "','26.11'," & Me.C1DBG.Columns.Item("SHIP_ID").Text & ",'" & CmbDAYNIGHTMARK.SelectedValue & "'", dsClerk)
        'MsgBox(Me.C1DBG.Columns.Item("DEPT_CODE").Text, MsgBoxStyle.Information, "提示")
        'MsgBox(G_DeptCode, MsgBoxStyle.Information, "提示")
        If dwClerk.Count > 0 Then

            Me.C1DBG5V.DataSource = dwClerk

            Me.C1DBG5V.Columns.Item("WORK_NO").Caption = "工号"
            Me.C1DBG5V.Columns.Item("Name").Caption = "姓名"
            Me.C1DBG5V.Columns.Item("CODE_DUTY").Caption = "职务"
            Me.C1DBG5V.Columns.Item("DEPT_CODE").Caption = "部门"

            Me.C1DBG5V.Splits(0).DisplayColumns.Item(0).Width = 50
            Me.C1DBG5V.Splits(0).DisplayColumns.Item(1).Width = 65
            Me.C1DBG5V.Splits(0).DisplayColumns.Item(2).Width = 65
            Me.C1DBG5V.Splits(0).DisplayColumns.Item(3).Width = 30

            'Dim i As Integer
            Dim dst As New DataSet
            Dim sqla As New SqlClient.SqlDataAdapter
            Dim sqlc As New SqlClient.SqlCommand
            '***************职务
            Me.C1DBG5V.Columns.Item("CODE_DUTY").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG5V.Columns.Item("CODE_DUTY").ValueItems.Translate = True
            Me.C1DBG5V.Columns.Item("CODE_DUTY").ValueItems.Validate = True
            Me.C1DBG5V.Splits(0).DisplayColumns.Item("CODE_DUTY").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT CODE_DUTY, DUTY_CHA FROM CODE_DUTY "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("DUTY_CHA"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("CODE_DUTY"))
                Me.C1DBG5V.Columns.Item("CODE_DUTY").ValueItems.Values.Add(vi)
            Next
            '***************部门
            Me.C1DBG5V.Columns.Item("DEPT_CODE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG5V.Columns.Item("DEPT_CODE").ValueItems.Translate = True
            Me.C1DBG5V.Columns.Item("DEPT_CODE").ValueItems.Validate = True
            Me.C1DBG5V.Splits(0).DisplayColumns.Item("CODE_DUTY").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT DEPT_CODE, DEPT_SHORT FROM DEPARTMENT "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("DEPT_SHORT"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("DEPT_CODE"))
                Me.C1DBG5V.Columns.Item("DEPT_CODE").ValueItems.Values.Add(vi)
            Next
        Else

            MsgBox("此船无派工信息！", MsgBoxStyle.Information, "提示")
        End If
    End Sub

    Private Sub C1Query()
        'If G_DeptCode = "26.11" Then
        Dim str As String
        Dim dsinfo As New DataSet
        Dim dwinfo As New DataView
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

        str = "SELECT b.NAME, c.WorkTime FROM ABSENT a INNER JOIN Code_WorkTime c ON a.DAYNIGHTMARK = c.Code_WorkTime INNER JOIN TALLY_CLERK b ON a.WORK_NO = b.WORK_NO WHERE datediff(dd,absentdate ,'" & DTPWATCHDATE.Value & "')=0 and (a.DEPT_CODE = '26.11.30' or a.DEPT_CODE='29.11.30') order by NAME,WorkTime "
        dwinfo = Getdata(str, dsinfo)
        Me.C1info.DataSource = dwinfo
        Me.C1info.Columns.Item("NAME").Caption = "  姓名"
        Me.C1info.Columns.Item("WorkTime").Caption = " 出勤  "
        Me.C1info.Splits(0).DisplayColumns.Item(0).Width = 50
        Me.C1info.Splits(0).DisplayColumns.Item(1).Width = 60

        str = "SELECT b.NAME, c.WorkTime FROM ABSENT a INNER JOIN Code_WorkTime c ON a.DAYNIGHTMARK = c.Code_WorkTime INNER JOIN TALLY_CLERK b ON a.WORK_NO = b.WORK_NO WHERE datediff(dd,absentdate ,'" & DTPWATCHDATE.Value & "')=0 and (a.DEPT_CODE = '26.12.11' or a.DEPT_CODE='29.12.11') order by NAME,WorkTime "
        dw1 = Getdata(str, ds1)
        Me.C1_1.DataSource = dw1
        Me.C1_1.Columns.Item("NAME").Caption = "  姓名"
        Me.C1_1.Columns.Item("WorkTime").Caption = " 出勤  "
        Me.C1_1.Splits(0).DisplayColumns.Item(0).Width = 50
        Me.C1_1.Splits(0).DisplayColumns.Item(1).Width = 60


        str = "SELECT b.NAME, c.WorkTime FROM ABSENT a INNER JOIN Code_WorkTime c ON a.DAYNIGHTMARK = c.Code_WorkTime INNER JOIN TALLY_CLERK b ON a.WORK_NO = b.WORK_NO WHERE datediff(dd,absentdate ,'" & DTPWATCHDATE.Value & "')=0 and (a.DEPT_CODE = '26.12.12' or a.DEPT_CODE='29.12.12') order by NAME,WorkTime "
        dw2 = Getdata(str, ds2)
        Me.C1_2.DataSource = dw2
        Me.C1_2.Columns.Item("NAME").Caption = "  姓名"
        Me.C1_2.Columns.Item("WorkTime").Caption = " 出勤  "
        Me.C1_2.Splits(0).DisplayColumns.Item(0).Width = 50
        Me.C1_2.Splits(0).DisplayColumns.Item(1).Width = 60

        str = "SELECT b.NAME, c.WorkTime FROM ABSENT a INNER JOIN Code_WorkTime c ON a.DAYNIGHTMARK = c.Code_WorkTime INNER JOIN TALLY_CLERK b ON a.WORK_NO = b.WORK_NO WHERE datediff(dd,absentdate ,'" & DTPWATCHDATE.Value & "')=0 and (a.DEPT_CODE = '26.12.13' or a.DEPT_CODE='29.12.13') order by NAME,WorkTime "
        dw3 = Getdata(str, ds3)
        Me.C1_3.DataSource = dw3
        Me.C1_3.Columns.Item("NAME").Caption = "  姓名"
        Me.C1_3.Columns.Item("WorkTime").Caption = " 出勤  "
        Me.C1_3.Splits(0).DisplayColumns.Item(0).Width = 50
        Me.C1_3.Splits(0).DisplayColumns.Item(1).Width = 60

        str = "SELECT b.NAME, c.WorkTime FROM ABSENT a INNER JOIN Code_WorkTime c ON a.DAYNIGHTMARK = c.Code_WorkTime INNER JOIN TALLY_CLERK b ON a.WORK_NO = b.WORK_NO WHERE datediff(dd,absentdate ,'" & DTPWATCHDATE.Value & "')=0 and (a.DEPT_CODE = '26.12.14' or a.DEPT_CODE='29.12.14') order by NAME,WorkTime "
        dw4 = Getdata(str, ds4)
        Me.C1_4.DataSource = dw4
        Me.C1_4.Columns.Item("NAME").Caption = "  姓名"
        Me.C1_4.Columns.Item("WorkTime").Caption = " 出勤  "
        Me.C1_4.Splits(0).DisplayColumns.Item(0).Width = 50
        Me.C1_4.Splits(0).DisplayColumns.Item(1).Width = 60

        str = "SELECT b.NAME, c.WorkTime FROM ABSENT a INNER JOIN Code_WorkTime c ON a.DAYNIGHTMARK = c.Code_WorkTime INNER JOIN TALLY_CLERK b ON a.WORK_NO = b.WORK_NO WHERE datediff(dd,absentdate ,'" & DTPWATCHDATE.Value & "')=0 and (a.DEPT_CODE = '26.12.15' or a.DEPT_CODE='29.12.15') order by NAME,WorkTime "
        dw5 = Getdata(str, ds5)
        Me.C1_5.DataSource = dw5
        Me.C1_5.Columns.Item("NAME").Caption = "  姓名"
        Me.C1_5.Columns.Item("WorkTime").Caption = " 出勤  "
        Me.C1_5.Splits(0).DisplayColumns.Item(0).Width = 50
        Me.C1_5.Splits(0).DisplayColumns.Item(1).Width = 60
        'End If
    End Sub

    Private Sub C1TrueDBGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBG5.Click

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        'Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
    End Sub

End Class
