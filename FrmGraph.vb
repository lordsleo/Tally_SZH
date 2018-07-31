Imports TALLY.DBControl
Imports System.Drawing.Printing

Public Class FrmGraph
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuery As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCompile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents GBV As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolBarV As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnOK As System.Windows.Forms.ToolBarButton
    Friend WithEvents S2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSearch As System.Windows.Forms.ToolBarButton
    Friend WithEvents S3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSort As System.Windows.Forms.ToolBarButton
    Friend WithEvents S4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEng As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnselect As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnline As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnrect As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnmark As System.Windows.Forms.ToolBarButton
    Friend WithEvents pic_LC As System.Windows.Forms.PictureBox
    Friend WithEvents pic_LT As System.Windows.Forms.PictureBox
    Friend WithEvents pic_LB As System.Windows.Forms.PictureBox
    Friend WithEvents pic_CT As System.Windows.Forms.PictureBox
    Friend WithEvents pic_RB As System.Windows.Forms.PictureBox
    Friend WithEvents pic_RT As System.Windows.Forms.PictureBox
    Friend WithEvents pic_CB As System.Windows.Forms.PictureBox
    Friend WithEvents pic_RC As System.Windows.Forms.PictureBox
    Friend WithEvents textInput As System.Windows.Forms.TextBox
    Friend WithEvents contextMenuForm As System.Windows.Forms.ContextMenu
    Friend WithEvents muItemAry As System.Windows.Forms.MenuItem
    Friend WithEvents muItemFirst As System.Windows.Forms.MenuItem
    Friend WithEvents muItemLast As System.Windows.Forms.MenuItem
    Friend WithEvents muItemDele As System.Windows.Forms.MenuItem
    Friend WithEvents muItemSave As System.Windows.Forms.MenuItem
    Friend WithEvents muItemExit As System.Windows.Forms.MenuItem
    Friend WithEvents toolBarObj As System.Windows.Forms.ToolBar
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents muItemLineType As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MuitemRefresh As System.Windows.Forms.MenuItem
    Friend WithEvents TimerRefresh As System.Windows.Forms.Timer
    Friend WithEvents MuitemPreview As System.Windows.Forms.MenuItem
    Friend WithEvents MuitemPrint As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MuItemShip As System.Windows.Forms.MenuItem
    Friend WithEvents MuItemCabinCount As System.Windows.Forms.MenuItem
    Friend WithEvents labCabinCount As System.Windows.Forms.Label
    Friend WithEvents txtCabinCount As System.Windows.Forms.TextBox
    Friend WithEvents plMobile As System.Windows.Forms.Panel
    Friend WithEvents c1Mobile As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents MuItemText As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents muItemdashLine As System.Windows.Forms.MenuItem
    Private WithEvents plDrawPlat As System.Windows.Forms.Panel
    Friend WithEvents pic_Move As System.Windows.Forms.PictureBox
    Friend WithEvents picBoxDraw As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGraph))
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.mnuPrint = New System.Windows.Forms.MenuItem
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.mnuCompile = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.GB = New System.Windows.Forms.GroupBox
        Me.plMobile = New System.Windows.Forms.Panel
        Me.rb1 = New System.Windows.Forms.RadioButton
        Me.c1Mobile = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.rb2 = New System.Windows.Forms.RadioButton
        Me.rb3 = New System.Windows.Forms.RadioButton
        Me.Label = New System.Windows.Forms.Label
        Me.toolBarObj = New System.Windows.Forms.ToolBar
        Me.tbbtnselect = New System.Windows.Forms.ToolBarButton
        Me.tbbtnline = New System.Windows.Forms.ToolBarButton
        Me.tbbtnrect = New System.Windows.Forms.ToolBarButton
        Me.tbbtnmark = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.plDrawPlat = New System.Windows.Forms.Panel
        Me.pic_CB = New System.Windows.Forms.PictureBox
        Me.pic_LB = New System.Windows.Forms.PictureBox
        Me.pic_LC = New System.Windows.Forms.PictureBox
        Me.pic_LT = New System.Windows.Forms.PictureBox
        Me.pic_CT = New System.Windows.Forms.PictureBox
        Me.pic_RT = New System.Windows.Forms.PictureBox
        Me.pic_RC = New System.Windows.Forms.PictureBox
        Me.pic_RB = New System.Windows.Forms.PictureBox
        Me.pic_Move = New System.Windows.Forms.PictureBox
        Me.txtCabinCount = New System.Windows.Forms.TextBox
        Me.labCabinCount = New System.Windows.Forms.Label
        Me.textInput = New System.Windows.Forms.TextBox
        Me.picBoxDraw = New System.Windows.Forms.PictureBox
        Me.contextMenuForm = New System.Windows.Forms.ContextMenu
        Me.muItemAry = New System.Windows.Forms.MenuItem
        Me.muItemFirst = New System.Windows.Forms.MenuItem
        Me.muItemLast = New System.Windows.Forms.MenuItem
        Me.muItemDele = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.muItemSave = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MuitemRefresh = New System.Windows.Forms.MenuItem
        Me.MuItemText = New System.Windows.Forms.MenuItem
        Me.MuItemShip = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.muItemLineType = New System.Windows.Forms.MenuItem
        Me.muItemdashLine = New System.Windows.Forms.MenuItem
        Me.MuItemCabinCount = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MuitemPreview = New System.Windows.Forms.MenuItem
        Me.MuitemPrint = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.muItemExit = New System.Windows.Forms.MenuItem
        Me.GBV = New System.Windows.Forms.GroupBox
        Me.ToolBarV = New System.Windows.Forms.ToolBar
        Me.tbbtnOK = New System.Windows.Forms.ToolBarButton
        Me.S2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSearch = New System.Windows.Forms.ToolBarButton
        Me.S3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSort = New System.Windows.Forms.ToolBarButton
        Me.S4 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEng = New System.Windows.Forms.ToolBarButton
        Me.btResure = New System.Windows.Forms.Button
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.TimerRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.GB.SuspendLayout()
        Me.plMobile.SuspendLayout()
        CType(Me.c1Mobile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plDrawPlat.SuspendLayout()
        CType(Me.pic_CB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_LB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_LC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_LT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_CT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_RT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_RC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_RB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Move, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ImageList.Images.SetKeyName(10, "")
        Me.ImageList.Images.SetKeyName(11, "")
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuSep1, Me.mnuPrint, Me.mnuExport, Me.mnuSep2, Me.mnuQuit})
        Me.mnuFile.Text = "文件(&F)"
        '
        'mnuFind
        '
        Me.mnuFind.Enabled = False
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "检索(&F)"
        '
        'mnuQuery
        '
        Me.mnuQuery.Enabled = False
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "查看(&Q)"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 2
        Me.mnuSep1.Text = "-"
        '
        'mnuPrint
        '
        Me.mnuPrint.Enabled = False
        Me.mnuPrint.Index = 3
        Me.mnuPrint.Text = "打印(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Enabled = False
        Me.mnuExport.Index = 4
        Me.mnuExport.Text = "导出(&E)"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 5
        Me.mnuSep2.Text = "-"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 6
        Me.mnuQuit.Text = "退出(&X)"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete})
        Me.mnuCompile.Text = "编辑(&E)"
        '
        'mnuAdd
        '
        Me.mnuAdd.Enabled = False
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "增加(&A)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Enabled = False
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "编辑(&E)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Enabled = False
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "删除(&D)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'GB
        '
        Me.GB.Controls.Add(Me.plMobile)
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Controls.Add(Me.toolBarObj)
        Me.GB.Controls.Add(Me.plDrawPlat)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(174, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(540, 411)
        Me.GB.TabIndex = 3
        Me.GB.TabStop = False
        '
        'plMobile
        '
        Me.plMobile.BackgroundImage = CType(resources.GetObject("plMobile.BackgroundImage"), System.Drawing.Image)
        Me.plMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plMobile.Controls.Add(Me.rb1)
        Me.plMobile.Controls.Add(Me.c1Mobile)
        Me.plMobile.Controls.Add(Me.rb2)
        Me.plMobile.Controls.Add(Me.rb3)
        Me.plMobile.Location = New System.Drawing.Point(224, 24)
        Me.plMobile.Name = "plMobile"
        Me.plMobile.Size = New System.Drawing.Size(448, 144)
        Me.plMobile.TabIndex = 4
        Me.plMobile.Visible = False
        '
        'rb1
        '
        Me.rb1.BackColor = System.Drawing.Color.Transparent
        Me.rb1.ForeColor = System.Drawing.Color.Red
        Me.rb1.Location = New System.Drawing.Point(12, 4)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(62, 18)
        Me.rb1.TabIndex = 1
        Me.rb1.Text = "格式一"
        Me.rb1.UseVisualStyleBackColor = False
        Me.rb1.Visible = False
        '
        'c1Mobile
        '
        Me.c1Mobile.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.c1Mobile.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1Mobile.Images.Add(CType(resources.GetObject("c1Mobile.Images"), System.Drawing.Image))
        Me.c1Mobile.Location = New System.Drawing.Point(0, 22)
        Me.c1Mobile.Name = "c1Mobile"
        Me.c1Mobile.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1Mobile.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1Mobile.PreviewInfo.ZoomFactor = 75
        Me.c1Mobile.PrintInfo.PageSettings = CType(resources.GetObject("c1Mobile.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1Mobile.Size = New System.Drawing.Size(446, 120)
        Me.c1Mobile.TabIndex = 0
        Me.c1Mobile.Text = "C1TrueDBGrid1"
        Me.c1Mobile.PropBag = resources.GetString("c1Mobile.PropBag")
        '
        'rb2
        '
        Me.rb2.BackColor = System.Drawing.Color.Transparent
        Me.rb2.ForeColor = System.Drawing.Color.Red
        Me.rb2.Location = New System.Drawing.Point(78, 4)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(62, 18)
        Me.rb2.TabIndex = 1
        Me.rb2.Text = "格式二"
        Me.rb2.UseVisualStyleBackColor = False
        Me.rb2.Visible = False
        '
        'rb3
        '
        Me.rb3.BackColor = System.Drawing.Color.Transparent
        Me.rb3.ForeColor = System.Drawing.Color.Red
        Me.rb3.Location = New System.Drawing.Point(144, 4)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(62, 18)
        Me.rb3.TabIndex = 1
        Me.rb3.Text = "格式三"
        Me.rb3.UseVisualStyleBackColor = False
        Me.rb3.Visible = False
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label.Location = New System.Drawing.Point(3, 58)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(534, 57)
        Me.Label.TabIndex = 11
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'toolBarObj
        '
        Me.toolBarObj.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnselect, Me.tbbtnline, Me.tbbtnrect, Me.tbbtnmark, Me.ToolBarButton1, Me.tbbtnQuit})
        Me.toolBarObj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toolBarObj.DropDownArrows = True
        Me.toolBarObj.Enabled = False
        Me.toolBarObj.ImageList = Me.ImageList
        Me.toolBarObj.Location = New System.Drawing.Point(3, 17)
        Me.toolBarObj.Name = "toolBarObj"
        Me.toolBarObj.ShowToolTips = True
        Me.toolBarObj.Size = New System.Drawing.Size(534, 41)
        Me.toolBarObj.TabIndex = 9
        '
        'tbbtnselect
        '
        Me.tbbtnselect.ImageIndex = 2
        Me.tbbtnselect.Name = "tbbtnselect"
        Me.tbbtnselect.Pushed = True
        Me.tbbtnselect.Tag = "sel"
        Me.tbbtnselect.Text = "选择"
        Me.tbbtnselect.ToolTipText = "选择"
        '
        'tbbtnline
        '
        Me.tbbtnline.ImageIndex = 3
        Me.tbbtnline.Name = "tbbtnline"
        Me.tbbtnline.Tag = "line"
        Me.tbbtnline.Text = "直线"
        Me.tbbtnline.ToolTipText = "直线"
        '
        'tbbtnrect
        '
        Me.tbbtnrect.ImageIndex = 4
        Me.tbbtnrect.Name = "tbbtnrect"
        Me.tbbtnrect.Tag = "rect"
        Me.tbbtnrect.Text = "矩形"
        Me.tbbtnrect.ToolTipText = "矩形"
        '
        'tbbtnmark
        '
        Me.tbbtnmark.ImageIndex = 1
        Me.tbbtnmark.Name = "tbbtnmark"
        Me.tbbtnmark.Tag = "lab"
        Me.tbbtnmark.Text = "标签"
        Me.tbbtnmark.ToolTipText = "标签"
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Name = "tbbtnQuit"
        Me.tbbtnQuit.Tag = "quit"
        Me.tbbtnQuit.Text = "退出"
        Me.tbbtnQuit.ToolTipText = "退出"
        '
        'plDrawPlat
        '
        Me.plDrawPlat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.plDrawPlat.AutoScroll = True
        Me.plDrawPlat.BackColor = System.Drawing.SystemColors.Control
        Me.plDrawPlat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.plDrawPlat.Controls.Add(Me.pic_CB)
        Me.plDrawPlat.Controls.Add(Me.pic_LB)
        Me.plDrawPlat.Controls.Add(Me.pic_LC)
        Me.plDrawPlat.Controls.Add(Me.pic_LT)
        Me.plDrawPlat.Controls.Add(Me.pic_CT)
        Me.plDrawPlat.Controls.Add(Me.pic_RT)
        Me.plDrawPlat.Controls.Add(Me.pic_RC)
        Me.plDrawPlat.Controls.Add(Me.pic_RB)
        Me.plDrawPlat.Controls.Add(Me.pic_Move)
        Me.plDrawPlat.Controls.Add(Me.txtCabinCount)
        Me.plDrawPlat.Controls.Add(Me.labCabinCount)
        Me.plDrawPlat.Controls.Add(Me.textInput)
        Me.plDrawPlat.Controls.Add(Me.picBoxDraw)
        Me.plDrawPlat.Cursor = System.Windows.Forms.Cursors.Default
        Me.plDrawPlat.Location = New System.Drawing.Point(4, 117)
        Me.plDrawPlat.Name = "plDrawPlat"
        Me.plDrawPlat.Size = New System.Drawing.Size(532, 291)
        Me.plDrawPlat.TabIndex = 12
        '
        'pic_CB
        '
        Me.pic_CB.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.pic_CB.Image = CType(resources.GetObject("pic_CB.Image"), System.Drawing.Image)
        Me.pic_CB.Location = New System.Drawing.Point(46, 132)
        Me.pic_CB.Name = "pic_CB"
        Me.pic_CB.Size = New System.Drawing.Size(6, 6)
        Me.pic_CB.TabIndex = 0
        Me.pic_CB.TabStop = False
        Me.pic_CB.Tag = "CB"
        Me.pic_CB.Visible = False
        '
        'pic_LB
        '
        Me.pic_LB.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.pic_LB.Image = CType(resources.GetObject("pic_LB.Image"), System.Drawing.Image)
        Me.pic_LB.Location = New System.Drawing.Point(32, 132)
        Me.pic_LB.Name = "pic_LB"
        Me.pic_LB.Size = New System.Drawing.Size(6, 6)
        Me.pic_LB.TabIndex = 0
        Me.pic_LB.TabStop = False
        Me.pic_LB.Tag = "LB"
        Me.pic_LB.Visible = False
        '
        'pic_LC
        '
        Me.pic_LC.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.pic_LC.Image = CType(resources.GetObject("pic_LC.Image"), System.Drawing.Image)
        Me.pic_LC.Location = New System.Drawing.Point(32, 118)
        Me.pic_LC.Name = "pic_LC"
        Me.pic_LC.Size = New System.Drawing.Size(6, 6)
        Me.pic_LC.TabIndex = 0
        Me.pic_LC.TabStop = False
        Me.pic_LC.Tag = "LC"
        Me.pic_LC.Visible = False
        '
        'pic_LT
        '
        Me.pic_LT.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.pic_LT.Image = CType(resources.GetObject("pic_LT.Image"), System.Drawing.Image)
        Me.pic_LT.Location = New System.Drawing.Point(32, 104)
        Me.pic_LT.Name = "pic_LT"
        Me.pic_LT.Size = New System.Drawing.Size(6, 6)
        Me.pic_LT.TabIndex = 0
        Me.pic_LT.TabStop = False
        Me.pic_LT.Tag = "LT"
        Me.pic_LT.Visible = False
        '
        'pic_CT
        '
        Me.pic_CT.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.pic_CT.Image = CType(resources.GetObject("pic_CT.Image"), System.Drawing.Image)
        Me.pic_CT.Location = New System.Drawing.Point(46, 104)
        Me.pic_CT.Name = "pic_CT"
        Me.pic_CT.Size = New System.Drawing.Size(6, 6)
        Me.pic_CT.TabIndex = 0
        Me.pic_CT.TabStop = False
        Me.pic_CT.Tag = "CT"
        Me.pic_CT.Visible = False
        '
        'pic_RT
        '
        Me.pic_RT.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.pic_RT.Image = CType(resources.GetObject("pic_RT.Image"), System.Drawing.Image)
        Me.pic_RT.Location = New System.Drawing.Point(60, 104)
        Me.pic_RT.Name = "pic_RT"
        Me.pic_RT.Size = New System.Drawing.Size(6, 6)
        Me.pic_RT.TabIndex = 0
        Me.pic_RT.TabStop = False
        Me.pic_RT.Tag = "RT"
        Me.pic_RT.Visible = False
        '
        'pic_RC
        '
        Me.pic_RC.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.pic_RC.Image = CType(resources.GetObject("pic_RC.Image"), System.Drawing.Image)
        Me.pic_RC.Location = New System.Drawing.Point(60, 118)
        Me.pic_RC.Name = "pic_RC"
        Me.pic_RC.Size = New System.Drawing.Size(6, 6)
        Me.pic_RC.TabIndex = 0
        Me.pic_RC.TabStop = False
        Me.pic_RC.Tag = "RC"
        Me.pic_RC.Visible = False
        '
        'pic_RB
        '
        Me.pic_RB.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.pic_RB.Image = CType(resources.GetObject("pic_RB.Image"), System.Drawing.Image)
        Me.pic_RB.Location = New System.Drawing.Point(60, 132)
        Me.pic_RB.Name = "pic_RB"
        Me.pic_RB.Size = New System.Drawing.Size(6, 6)
        Me.pic_RB.TabIndex = 0
        Me.pic_RB.TabStop = False
        Me.pic_RB.Tag = "RB"
        Me.pic_RB.Visible = False
        '
        'pic_Move
        '
        Me.pic_Move.BackColor = System.Drawing.Color.Black
        Me.pic_Move.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.pic_Move.Location = New System.Drawing.Point(492, 180)
        Me.pic_Move.Name = "pic_Move"
        Me.pic_Move.Size = New System.Drawing.Size(6, 6)
        Me.pic_Move.TabIndex = 11
        Me.pic_Move.TabStop = False
        Me.pic_Move.Tag = "RB"
        '
        'txtCabinCount
        '
        Me.txtCabinCount.Location = New System.Drawing.Point(122, 16)
        Me.txtCabinCount.Name = "txtCabinCount"
        Me.txtCabinCount.Size = New System.Drawing.Size(42, 21)
        Me.txtCabinCount.TabIndex = 3
        Me.txtCabinCount.Visible = False
        '
        'labCabinCount
        '
        Me.labCabinCount.Location = New System.Drawing.Point(68, 16)
        Me.labCabinCount.Name = "labCabinCount"
        Me.labCabinCount.Size = New System.Drawing.Size(54, 23)
        Me.labCabinCount.TabIndex = 2
        Me.labCabinCount.Text = "舱个数："
        Me.labCabinCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.labCabinCount.Visible = False
        '
        'textInput
        '
        Me.textInput.BackColor = System.Drawing.SystemColors.Menu
        Me.textInput.Location = New System.Drawing.Point(92, 100)
        Me.textInput.Multiline = True
        Me.textInput.Name = "textInput"
        Me.textInput.Size = New System.Drawing.Size(154, 102)
        Me.textInput.TabIndex = 1
        Me.textInput.Visible = False
        '
        'picBoxDraw
        '
        Me.picBoxDraw.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBoxDraw.BackColor = System.Drawing.SystemColors.Control
        Me.picBoxDraw.ContextMenu = Me.contextMenuForm
        Me.picBoxDraw.Location = New System.Drawing.Point(-2, -2)
        Me.picBoxDraw.Name = "picBoxDraw"
        Me.picBoxDraw.Size = New System.Drawing.Size(524, 286)
        Me.picBoxDraw.TabIndex = 12
        Me.picBoxDraw.TabStop = False
        '
        'contextMenuForm
        '
        Me.contextMenuForm.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.muItemAry, Me.muItemDele, Me.MenuItem2, Me.muItemSave, Me.MenuItem3, Me.MuitemRefresh, Me.MuItemText, Me.MuItemShip, Me.MenuItem5, Me.muItemLineType, Me.muItemdashLine, Me.MuItemCabinCount, Me.MenuItem4, Me.MenuItem8, Me.MenuItem6, Me.MuitemPreview, Me.MuitemPrint, Me.MenuItem7, Me.muItemExit})
        '
        'muItemAry
        '
        Me.muItemAry.Index = 0
        Me.muItemAry.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.muItemFirst, Me.muItemLast})
        Me.muItemAry.Text = "排列"
        Me.muItemAry.Visible = False
        '
        'muItemFirst
        '
        Me.muItemFirst.Index = 0
        Me.muItemFirst.Text = "最前面"
        '
        'muItemLast
        '
        Me.muItemLast.Index = 1
        Me.muItemLast.Text = "最后面"
        '
        'muItemDele
        '
        Me.muItemDele.Index = 1
        Me.muItemDele.Text = "删除"
        Me.muItemDele.Visible = False
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "-"
        Me.MenuItem2.Visible = False
        '
        'muItemSave
        '
        Me.muItemSave.Index = 3
        Me.muItemSave.Text = "保存"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 4
        Me.MenuItem3.Text = "-"
        '
        'MuitemRefresh
        '
        Me.MuitemRefresh.Index = 5
        Me.MuitemRefresh.Text = "刷新"
        '
        'MuItemText
        '
        Me.MuItemText.Index = 6
        Me.MuItemText.Text = "隐藏可选数据"
        '
        'MuItemShip
        '
        Me.MuItemShip.Index = 7
        Me.MuItemShip.Text = "隐藏可选船"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 8
        Me.MenuItem5.Text = "-"
        '
        'muItemLineType
        '
        Me.muItemLineType.Index = 9
        Me.muItemLineType.Text = "虚线"
        '
        'muItemdashLine
        '
        Me.muItemdashLine.Index = 10
        Me.muItemdashLine.Text = "锁线"
        '
        'MuItemCabinCount
        '
        Me.MuItemCabinCount.Index = 11
        Me.MuItemCabinCount.Text = "分舱"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 12
        Me.MenuItem4.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 13
        Me.MenuItem8.Text = "字体"
        Me.MenuItem8.Visible = False
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 14
        Me.MenuItem6.Text = "页面设置"
        '
        'MuitemPreview
        '
        Me.MuitemPreview.Index = 15
        Me.MuitemPreview.Text = "打印预览"
        '
        'MuitemPrint
        '
        Me.MuitemPrint.Index = 16
        Me.MuitemPrint.Text = "打印"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 17
        Me.MenuItem7.Text = "-"
        '
        'muItemExit
        '
        Me.muItemExit.Index = 18
        Me.muItemExit.Text = "退出"
        '
        'GBV
        '
        Me.GBV.Controls.Add(Me.ToolBarV)
        Me.GBV.Controls.Add(Me.btResure)
        Me.GBV.Controls.Add(Me.txtVoyage)
        Me.GBV.Controls.Add(Me.Label2)
        Me.GBV.Controls.Add(Me.txtShipName)
        Me.GBV.Controls.Add(Me.Label1)
        Me.GBV.Controls.Add(Me.C1DBGV)
        Me.GBV.Dock = System.Windows.Forms.DockStyle.Left
        Me.GBV.Location = New System.Drawing.Point(0, 0)
        Me.GBV.Name = "GBV"
        Me.GBV.Size = New System.Drawing.Size(174, 411)
        Me.GBV.TabIndex = 2
        Me.GBV.TabStop = False
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 367)
        Me.ToolBarV.Name = "ToolBarV"
        Me.ToolBarV.ShowToolTips = True
        Me.ToolBarV.Size = New System.Drawing.Size(168, 41)
        Me.ToolBarV.TabIndex = 15
        '
        'tbbtnOK
        '
        Me.tbbtnOK.ImageIndex = 8
        Me.tbbtnOK.Name = "tbbtnOK"
        Me.tbbtnOK.Text = "常规"
        '
        'S2
        '
        Me.S2.Name = "S2"
        Me.S2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSearch
        '
        Me.tbbtnSearch.ImageIndex = 9
        Me.tbbtnSearch.Name = "tbbtnSearch"
        Me.tbbtnSearch.Text = "检索"
        '
        'S3
        '
        Me.S3.Name = "S3"
        Me.S3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSort
        '
        Me.tbbtnSort.ImageIndex = 10
        Me.tbbtnSort.Name = "tbbtnSort"
        Me.tbbtnSort.Text = "排序"
        '
        'S4
        '
        Me.S4.Name = "S4"
        Me.S4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnEng
        '
        Me.tbbtnEng.ImageIndex = 11
        Me.tbbtnEng.Name = "tbbtnEng"
        Me.tbbtnEng.Text = "英文"
        '
        'btResure
        '
        Me.btResure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btResure.Location = New System.Drawing.Point(126, 342)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(42, 22)
        Me.btResure.TabIndex = 12
        Me.btResure.Text = "查询"
        '
        'txtVoyage
        '
        Me.txtVoyage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVoyage.Location = New System.Drawing.Point(36, 342)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(88, 21)
        Me.txtVoyage.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(6, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "航次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShipName.Location = New System.Drawing.Point(36, 318)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(132, 21)
        Me.txtShipName.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(6, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "船名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("C1DBGV.Images"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(3, 17)
        Me.C1DBGV.Name = "C1DBGV"
        Me.C1DBGV.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGV.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGV.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGV.Size = New System.Drawing.Size(168, 295)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = resources.GetString("C1DBGV.PropBag")
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = -1
        Me.MenuItem1.Text = ""
        '
        'TimerRefresh
        '
        Me.TimerRefresh.Enabled = True
        Me.TimerRefresh.Interval = 3000
        '
        'FrmGraph
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 411)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Menu = Me.MainMenu
        Me.Name = "FrmGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "散杂货图形"
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.plMobile.ResumeLayout(False)
        CType(Me.c1Mobile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.plDrawPlat.ResumeLayout(False)
        Me.plDrawPlat.PerformLayout()
        CType(Me.pic_CB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_LB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_LC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_LT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_CT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_RT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_RC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_RB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Move, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxDraw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBV.ResumeLayout(False)
        Me.GBV.PerformLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dsShip As New DataSet   '船舶数据集
    Dim SqlStrShip As String  '船舶条件语句
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String
    Dim pageset As PageSettings
    Dim ds As New DataSet
    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    Dim ColNum As Integer '不显示的列数
    Public Shared InOutCode As String
    Dim ds_ship_statu As New DataSet   '船舶状态
    Dim oldShip_id As Integer '老的ship-id
    Dim dotLine As Boolean '判断是否是点画线
    Dim dashValues As Single() = {1, 2, 15, 2} '定义锁线样式
    Dim dashLine As Boolean '判断是否是锁线
    Dim fnt_all As New Font("宋体", 8, FontStyle.Bold)
    Dim fsty As New FontStyle

    '*********4.1 '***************要修改
    Private Sub FrmCargofeestat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'Call preview("WL7_1") '*****************权限设计 '*************要修改模块号
        Me.Text = Me.Text & "_" & G_DeptName
        SortShip = " Order by Ship_Statu,Dept_Code,id desc " '默认的排序 
        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%' and code_goods<>'2' " '船舶不变的条件设计
        SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3'))  and code_goods<>'2' " 'OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0) "
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '*****************调用航次信息
        Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        txtShipName.Text = G_ShipName
        txtVoyage.Text = G_Voyage
        txtShipName.Focus()

        'pic_Move.Location = New Point(Me.picBoxDraw.Size.Width, Me.picBoxDraw.Size.Height - 50)
        pic_Move.Location = New Point(1000, 500)

        '启动刷新画图区域
        Me.TimerRefresh.Start()
    End Sub

    Private Sub myDataGridShip(ByVal Sql As String) '**************航次信息
        Dim strsql As String
        Dim i As Integer
        strsql = "select SHIP_ID as ID ,SHIP_STATU,INOUTPORT,DEPT_CODE,ENG_VESSEL,CHI_VESSEL,VOYAGE,InOutPort_Name,Dept_Short from View_SSHip " '船舶条件语句 不改部分
        strsql = strsql & Sql
        Try
            Me.C1DBGV.DataSource = Getdata(strsql, dsShip)
            For i = 0 To 4 '设计部显示的列
                Me.C1DBGV.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Call SetColumnCaptionShip() '设计列标题
            Call SetColumnWidthShip() '设计列宽度
            If dsShip.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumShip(5)  '设计合计列
            End If
            Me.C1DBGV.FetchRowStyles = True
            Me.C1DBGV.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionShip() '*****************航次标题
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='View_SSHip'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = 4

            Do While i < Me.C1DBGV.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGV.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGV.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidthShip() '************航次列宽
        Dim i As Integer
        Try
            Me.C1DBGV.Splits(0).DisplayColumns.Item(4).Width = Me.C1DBGV.Width / 2 - 25
            Me.C1DBGV.Splits(0).DisplayColumns.Item(5).Width = Me.C1DBGV.Width / 2 - 25
            Me.C1DBGV.Splits(0).DisplayColumns.Item(6).Width = 35
            Me.C1DBGV.Splits(0).DisplayColumns.Item(7).Width = 24
            Me.C1DBGV.Splits(0).DisplayColumns.Item(8).Width = 18
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnSumShip(ByVal Col As Integer) '****************航次汇总行
        Me.C1DBGV.ColumnFooters = True
        Me.C1DBGV.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGV.Columns.Item(Col).FooterText = "共 " & dsShip.Tables(0).Rows.Count & " 条"
    End Sub

    Private Sub ToolBarV_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBarV.ButtonClick
        Select Case Me.ToolBarV.Buttons.IndexOf(e.Button)
            Case 0
                SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3')) and code_goods<>'2' " ' OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) " '船舶可变的条件设计
                SortShip = " Order by Ship_Statu,Dept_Code,id desc "
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)
            Case 2
                Dim FrmFind As New FrmFind
                Table_Name = "SSHIP"
                FrmFind.ShowDialog()
                If Flag = 0 Then
                    Call myDataGridShip(FirmShip & inoutstr & " and (" & Sql_Find & ")  " & SortShip)    '可能要修改
                    SqlStrShip = FirmStr & " and (" & Sql_Find & ")  "    '可能要修改
                ElseIf Flag = 2 Then
                    SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0))  and code_goods<>'2' "
                    '可能要修改
                    Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '可能要修改
                End If
            Case 4
                Dim FrmSort As New FrmSort
                FrmSort.ShowDialog()
                If Len(Trim(SortStr)) > 0 Then
                    SortShip = " Order by " & SortStr
                End If
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)
            Case 6
                Me.C1DBGV.Splits(0).DisplayColumns.Item(4).Visible = True
                Me.C1DBGV.Splits(0).DisplayColumns.Item(5).Visible = False
                If dsShip.Tables(0).Rows.Count > 0 Then
                    Call SetColumnSumShip(4)  '设计合计列
                End If
                Me.C1DBGV.FetchRowStyles = True
                Me.C1DBGV.Refresh()
        End Select
    End Sub

    Private Sub C1DBGV_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBGV.FetchRowStyle
        If Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 1 Then
            e.CellStyle.BackColor = System.Drawing.Color.White
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 2 Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 3 Then
            e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 4 Then
            e.CellStyle.BackColor = System.Drawing.Color.Pink
        End If
    End Sub

    Private Sub C1DBGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBGV.DoubleClick
        On Error GoTo Err
        'Dim frmfee As New Frmfeestat_cheap()

        Dim dsShip As New DataSet
        Dim strsql As String
        Dim dw As New DataView
        Ship_ID = CType(Me.C1DBGV.Columns.Item("ID").Text.ToString, Integer)

        '重画船图
        openGraph(sender, e)
        oldShip_id = Ship_ID '新shipid副给老的ship-id

        strsql = "select * from View_SSHIP where SHIP_ID=" & Ship_ID
        dw = Getdata(strsql, dsShip)
        Label.Text = ""
        If dsShip.Tables(0).DefaultView.Count > 0 Then
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                'CHI_VESSEL = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))  '中文船名
                Label.Text = Label.Text & "中文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
                G_ShipName = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
                txtShipName.Text = G_ShipName
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then

                Label.Text = Label.Text & "英文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                'VOYAGE = Trim(dsShip.Tables(0).Rows(0).Item("VOYAGE")) '航次
                Label.Text = Label.Text & "航次:" & Trim(dsShip.Tables(0).Rows(0).Item("Voyage")) & " "
                G_Voyage = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
                txtVoyage.Text = G_Voyage
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name"))) > 0 Then
                Label.Text = Label.Text & "进出口:" & Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Trade"))) > 0 Then
                Label.Text = Label.Text & "内外贸:" & Trim(dsShip.Tables(0).Rows(0).Item("Trade")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE"))) > 0 Then
                Label.Text = Label.Text & "国外轮:" & Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIPAGENT_CHAE"))) > 0 Then
                Label.Text = Label.Text & "船代:" & Trim(dsShip.Tables(0).Rows(0).Item("SHIPAGENT_CHA")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("GOODS"))) > 0 Then
                Label.Text = Label.Text & "货名:" & Trim(dsShip.Tables(0).Rows(0).Item("GOODS")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Tons"))) > 0 Then
                Label.Text = Label.Text & "吨数:" & Trim(dsShip.Tables(0).Rows(0).Item("Tons")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("BerthNo"))) > 0 Then
                Label.Text = Label.Text & "泊位:" & Trim(dsShip.Tables(0).Rows(0).Item("BerthNo")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("File_No"))) > 0 Then
                Label.Text = Label.Text & "档案号:" & Trim(dsShip.Tables(0).Rows(0).Item("File_No")) & " "
            End If
        End If
        FirmStr = " and Ship_ID=" & Ship_ID & " Order by substring(fee_code,dbo.FindLastDotPos(fee_code),len(fee_code)-dbo.FindLastDotPos(fee_code)) " '设计初始条件  在检索后不改变的条件  '***************要修改 或 2>1
        DynaStr = " 2>1 " '设计其它初始条件    在检索后不需要的条件 ***************要修改 或 其它条件
        SelectStr = " Top 20 " ' " Top 20 "
        SqlStr = " (" & DynaStr & ")  " & FirmStr
        Me.toolBarObj.Enabled = True
        Me.mnuAdd.Enabled = True
        Me.mnuDelete.Enabled = True
        Me.mnuEdit.Enabled = True
        Me.mnuExport.Enabled = True
        Me.mnuFind.Enabled = True
        Me.mnuPrint.Enabled = True
        Me.mnuQuery.Enabled = True
        Call preview("WL4_1") '*****************权限设计 '*************要修改模块号
        '刷新可以选择的文本
        Call Me.fillC1Mobile()
        '控制c1mobile的位置
        Me.plMobile.Location = New Point(400, 9)
        Me.plMobile.Visible = True

        '  Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub preview(ByVal Func As String) '***************权限设计
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet
        Dim i As Integer
        sqlstr = " select FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
        Previewdv = Getdata(sqlstr, Previewds)
        If Previewdv.Count > 0 Then
            If Previewdv(i)("FUNC_CODE_Add") = 1 Then 'ADD 按钮可见
                toolBarObj.Buttons.Item(3).Enabled = True
                mnuAdd.Enabled = True
            Else                                      'ADD 按钮不可见
                Me.toolBarObj.Buttons.Item(3).Enabled = False
                mnuAdd.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Change") = 1 Then '修改 按钮可见
                Me.toolBarObj.Buttons.Item(4).Enabled = True
                mnuEdit.Enabled = True
            Else                                          '修改 按钮不可见
                Me.toolBarObj.Buttons.Item(4).Enabled = False
                mnuEdit.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Del") = 1 Then '删除 按钮可见
                Me.toolBarObj.Buttons.Item(5).Enabled = True
                mnuDelete.Enabled = True
            Else                                     '删除按钮不可见
                Me.toolBarObj.Buttons.Item(5).Enabled = False
                mnuDelete.Enabled = False
            End If
        End If
    End Sub

    Private Sub Frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.C1DBGV.Height = Me.Height - 140
        Me.Label1.Top = Me.C1DBGV.Height + 20
        Me.txtShipName.Top = Me.C1DBGV.Height + 20
        Me.Label2.Top = Me.C1DBGV.Height + 40
        Me.txtVoyage.Top = Me.C1DBGV.Height + 40
        Me.btResure.Top = Me.C1DBGV.Height + 40
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' ))  and code_goods<>'2' "
        '可能要修改
        G_ShipName = Trim(txtShipName.Text)
        G_Voyage = Trim(txtVoyage.Text)
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)
        If dsShip.Tables(0).Rows.Count > 0 Then
            C1DBGV_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub txtShipName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShipName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtVoyage.Focus()
        End If
    End Sub

    Private Sub txtVoyage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoyage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btResure.Focus()
        End If
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles toolBarObj.ButtonClick
        Dim tb As System.Windows.Forms.ToolBar = CType(sender, System.Windows.Forms.ToolBar)
        Dim bt As System.Windows.Forms.ToolBarButton
        For Each bt In tb.Buttons
            If bt Is e.Button = False Then
                bt.Pushed = False
            End If
        Next
        e.Button.Pushed = True
        pushBtName = e.Button.Tag.ToString
        If pushBtName = "quit" Then
            Me.Close()
        End If
        If pushBtName = "lab" Then
            rb1.Visible = True
            rb2.Visible = True
            rb3.Visible = True
            rb1.Checked = True
        Else
            rb1.Visible = False
            rb2.Visible = False
            rb3.Visible = False
            rb1.Checked = False
        End If
        Select Case pushBtName
            Case "sel"
                Me.Cursor = Cursors.Default
            Case Else
                Me.Cursor = Cursors.Cross
                idxSelected = -1
                pic_sel()
        End Select
        'For Each bt In tb.Buttons
        '    bt.Pushed = False
        'Next
        'tb.Buttons.Item(0).Pushed = True
        'Me.Cursor = Cursors.Default
    End Sub

    '定义一个图形每举
    Private Enum objType
        LINE = 0
        RECT = 1
        LABEL = 2
    End Enum

    '定义一个线形每举
    Private Enum lineType
        SolidLine = 0 '实线
        dotLine = 1 '虚线
        dashLine = 2 '锁线
    End Enum

    '定义一个结构
    Private Structure objGraph
        Public gType As objType '图形
        Public lType As lineType '线形
        Public Graph As Object
    End Structure

    Private m_Graph As New ArrayList
    Private curPosX, curPosY As Integer
    Private lastX, lastY As Integer
    Private idxSelect As Integer = -1
    Private idxSelected As Integer = -1
    Private pushBtName As String = "sel"
    Private blDrawing As Boolean = False
    Private blMoving As Boolean = False
    Private fnt As New Font("宋体", 9)
    Private blSave As Boolean = True

    Private Function GetSelectIndex(ByVal x As Integer, ByVal y As Integer) As Integer
        Dim g As Graphics
        g = Me.picBoxDraw.CreateGraphics
        'g = Me.plDrawPlat.CreateGraphics
        If (idxSelect >= 0 And idxSelect < m_Graph.Count) Then
            '定义一个结构类型的变量
            Dim objGh As objGraph   '=(objgraph)(m_graph[idxselect]) 
            '给定义的变量取值
            objGh = CType(m_Graph(idxSelect), objGraph)

            If objGh.gType = objType.LABEL Then
                Dim lb As Graph.Lab
                lb = CObj(objGh.Graph)
                '			Graph.Lab lb=(Graph.Lab)(objGh.Graph);
                g.DrawRectangle(New Pen(Me.BackColor, 1), New Rectangle(lb.Location, lb.Size))
                '			g.DrawRectangle(new Pen(this.BackColor,1),new Rectangle(lb.Location,lb.Size));
            End If
            ReDraw()
        End If
        Dim pen As New Pen(Color.Blue, 1)
        Dim i As Integer
        For i = 0 To m_Graph.Count - 1
            Dim objGh As objGraph
            objgh = CType(m_Graph(i), objGraph)
            Select Case objgh.gType
                Case objType.LINE
                    Dim ln As New Graph.Line
                    ln = CObj(objgh.Graph)
                    If ln.IsSelect(New Point(x, y)) Then
                        g.DrawLine(pen, ln.P1, ln.P2)
                        Return i
                    End If
                Case objType.RECT
                    Dim rt As Graph.Rect
                    rt = CObj(objgh.Graph)
                    If rt.IsSelect(New Point(x, y)) Then
                        g.DrawRectangle(pen, New Rectangle(rt.location, rt.Size))
                        Return i
                    End If
                Case objType.LABEL
                    Dim lb As Graph.Lab
                    lb = CObj(objgh.Graph)
                    If lb.IsSelect(New Point(x, y)) Then
                        pen.DashStyle = Drawing.Drawing2D.DashStyle.Dot
                        g.DrawRectangle(pen, New Rectangle(lb.Location, lb.Size))
                        Dim rectRR As New RectangleF
                        rectRR.X = CType(lb.Location.X, Single)
                        rectRR.Y = CType(lb.Location.Y, Single)
                        rectRR.Height = CType(lb.Size.Height, Single)
                        rectRR.Width = CType(lb.Size.Width, Single)
                        g.DrawString(lb.Text, fnt, Brushes.Black, rectRR)
                        Return i
                    End If
            End Select
        Next
        Return -1
    End Function

    '估计此函数是重新画界面上的所有图形对象
    Private Sub ReDraw()
        Dim g As Graphics
        'g = Me.plDrawPlat.CreateGraphics 
        g = Me.picBoxDraw.CreateGraphics
        Dim penunsel As New Pen(Color.Black, 1)
        Dim pensel As New Pen(Color.Brown, 1)
        Dim pen As Pen
        Dim i As Integer = m_Graph.Count - 1
        'for循环取出接口m-graph中的每一个对象
        For i = m_Graph.Count - 1 To 0 Step -1
            '定义一个结构类型变量
            Dim objGh As objGraph
            objGh = CType(m_Graph(i), objGraph)
            If i = idxSelected Then '????
                pen = pensel
            Else
                pen = penunsel
            End If
            Select Case objGh.gType
                Case objType.LINE
                    Dim Ln As Graph.Line = CObj(objGh.Graph)
                    subLineType(objGh, pen) '设置线形
                    g.DrawLine(pen, Ln.P1, Ln.P2)
                Case objType.RECT
                    Dim rt As New Graph.Rect
                    rt = CObj(objGh.Graph)
                    subLineType(objGh, pen) '设置线形
                    g.DrawRectangle(pen, New Rectangle(rt.location, rt.Size))
                Case objType.LABEL
                    Dim lb As Graph.Lab
                    lb = CObj(objGh.Graph)
                    '把一个rectangle转化成rectanglef
                    Dim rectRR As New RectangleF
                    rectRR.X = CType(lb.Location.X, Single)
                    rectRR.Y = CType(lb.Location.Y, Single)
                    rectRR.Height = CType(lb.Size.Height, Single)
                    rectRR.Width = CType(lb.Size.Width, Single)
                    g.DrawString(lb.Text, fnt, Brushes.Black, rectRR)
            End Select
        Next
    End Sub

    '设置线形
    Private Sub subLineType(ByVal objgh As objGraph, ByRef pen As Pen)
        Select Case objgh.lType
            Case lineType.dotLine
                pen.DashStyle = Drawing.Drawing2D.DashStyle.Dot '点画线
            Case lineType.SolidLine
                pen.DashStyle = Drawing.Drawing2D.DashStyle.Solid '实线
            Case lineType.dashLine
                pen.DashPattern = dashValues '锁线
        End Select
    End Sub

    '定义一个图形类
    Public Class Graph
        Public graph()
        '定义一个标签类
        Public Class Lab
            '判断鼠标单几的是否是lable上的点
            Public Location As Point '????
            Public Size As Size '?????
            Public Text As String ' = "双击我!"

            Public Function IsSelect(ByVal p As Point) As Boolean
                '什么时间给location副值的？
                Dim x1 As Integer = Location.X
                Dim x2 As Integer = Location.X + Size.Width
                Dim y1 As Integer = Location.Y
                Dim y2 As Integer = Location.Y + Size.Height
                If p.Y <= y2 And p.Y >= y1 And p.X <= x2 And p.X >= x1 Then
                    Return True
                Else
                    Return False
                End If
            End Function
        End Class
        '定义一个矩形类
        Public Class Rect
            Public location As Point
            Public Size As Size
            Private m_Diff As Integer = 2
            '定义一个属性
            Public Property Diff() As Integer
                Set(ByVal Value As Integer) 'value是系统分配的值
                    If Value > 0 And Value < 100 Then
                        m_Diff = Value
                    End If
                End Set
                Get
                    Return m_Diff
                End Get
            End Property
            '定义一个函数，估计是要判断鼠标单击的点是否可以选种矩形
            Public Function IsSelect(ByVal p As Point) As Boolean
                Dim x1 As Integer = location.X
                Dim x2 As Integer = location.X + Size.Width
                Dim y1 As Integer = location.Y
                Dim y2 As Integer = location.Y + Size.Height
                If (p.Y <= y2 And p.Y >= y1) And (Math.Abs(p.X - x1) <= m_Diff Or Math.Abs(p.X - x2) <= m_Diff) Then
                    Return True
                End If
                If (p.X <= x2 And p.X >= x1) And (Math.Abs(p.Y - y1) <= m_Diff Or Math.Abs(p.Y - y2) <= m_Diff) Then
                    Return True
                End If
                Return False
            End Function
        End Class

        '定义一个直线类
        Public Class Line
            Public P1 As Point
            Public P2 As Point
            Public line5 As Integer
            Private m_Diff As Integer = 2
            '定义一个属性
            Public Property diff() As Integer
                Get
                    Return m_Diff
                End Get
                Set(ByVal Value As Integer)
                    If (Value > 0 And Value < 100) Then
                        m_Diff = Value
                    End If
                End Set
            End Property
            '传递一个x，判断y应该在此条直线上的值
            Private Function XToY(ByVal x As Integer) As Integer
                '斜率
                Dim k As Double = CType((P2.Y - P1.Y), Double) / CType((P2.X - P1.X), Double)
                '由直线的斜率计算传递过来的x应该对应的y值
                Dim y As Integer = CType((k * (x - P1.X) + P1.Y), Integer)
                Return y
            End Function
            '传递一个y，判断x应该在此条直线上的值
            Private Function YToX(ByVal y As Integer) As Integer
                '斜率的负值
                Dim k As Double = CType((P2.X - P1.X), Double) / CType((P2.Y - P1.Y), Double)
                '由直线的斜率计算传递过来的y应该对应的x值
                Dim x As Integer = CType((k * (y - P1.Y) + P1.X), Integer)
                Return x
            End Function
            '计算鼠标是否选种了直线
            Public Function IsSelect(ByVal p As Point) As Boolean
                If (Math.Abs(P1.X - P2.X) >= Math.Abs(P1.Y - P2.Y)) Then
                    If (p.X > Math.Max(P1.X, P2.X) Or p.X < Math.Min(P1.X, P2.X)) Then
                        Return False
                    End If
                    Dim y As Integer = XToY(p.X)
                    If (Math.Abs(p.Y - y) <= m_Diff) Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    If (p.Y > Math.Max(P1.Y, P2.Y) Or p.Y < Math.Min(P1.Y, P2.Y)) Then
                        Return False
                    End If
                    Dim x As Integer = YToX(p.Y)
                    If (Math.Abs(p.X - x) <= m_Diff) Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End Function
        End Class
    End Class

    Private Sub pic_sel()
        If Me.textInput.Visible Then
            Exit Sub
        End If
        Dim aryPic(7) As PictureBox
        aryPic(0) = pic_LT
        aryPic(1) = pic_RB
        aryPic(2) = pic_CT
        aryPic(3) = pic_RT
        aryPic(4) = pic_LC
        aryPic(5) = pic_RC
        aryPic(6) = pic_LB
        aryPic(7) = pic_CB
        If idxSelected >= 0 And idxSelected < m_Graph.Count Then
            Dim objGh As objGraph
            objGh = m_Graph(idxSelected)
            Select Case objGh.gType
                Case objType.LINE
                    Dim ln As Graph.Line = CObj(objGh.Graph)
                    Me.pic_LT.Location = New Point(ln.P1.X - 3 + Me.plDrawPlat.AutoScrollPosition.X, ln.P1.Y - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    Me.pic_RB.Location = New Point(ln.P2.X - 3 + Me.plDrawPlat.AutoScrollPosition.X, ln.P2.Y - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    Me.pic_LT.Visible = True
                    Me.pic_RB.Visible = True
                    Me.pic_LT.Cursor = Cursors.Hand
                    Me.pic_RB.Cursor = Cursors.Hand
                    Dim i As Integer
                    For i = 2 To aryPic.Length - 1
                        aryPic(i).Visible = False
                    Next
                Case objType.RECT
                    Dim rt As Graph.Rect
                    rt = CObj(objGh.Graph)
                    Me.pic_LT.Location = New Point(rt.location.X - 3 + Me.plDrawPlat.AutoScrollPosition.X, rt.location.Y - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    Me.pic_CT.Location = New Point(rt.location.X + rt.Size.Width / 2 - 3 + Me.plDrawPlat.AutoScrollPosition.X, rt.location.Y - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    Me.pic_RT.Location = New Point(rt.location.X + rt.Size.Width - 3 + Me.plDrawPlat.AutoScrollPosition.X, rt.location.Y - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    Me.pic_LC.Location = New Point(rt.location.X + -3 + Me.plDrawPlat.AutoScrollPosition.X, rt.location.Y + rt.Size.Height / 2 - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    Me.pic_RC.Location = New Point(rt.location.X + rt.Size.Width - 3 + Me.plDrawPlat.AutoScrollPosition.X, rt.location.Y + rt.Size.Height / 2 - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    Me.pic_LB.Location = New Point(rt.location.X - 3 + Me.plDrawPlat.AutoScrollPosition.X, rt.location.Y + rt.Size.Height - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    Me.pic_CB.Location = New Point(rt.location.X + rt.Size.Width / 2 - 3 + Me.plDrawPlat.AutoScrollPosition.X, rt.location.Y + rt.Size.Height - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    Me.pic_RB.Location = New Point(rt.location.X + rt.Size.Width - 3 + Me.plDrawPlat.AutoScrollPosition.X, rt.location.Y + rt.Size.Height - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    Me.pic_LT.Cursor = Cursors.SizeNWSE
                    Me.pic_RB.Cursor = Cursors.SizeNWSE
                    Dim i As Integer
                    For i = 0 To aryPic.Length - 1
                        aryPic(i).Visible = True
                    Next
                Case objType.LABEL
                    Dim lb As Graph.Lab
                    lb = CObj(objGh.Graph)
                    pic_LT.Location = New Point(lb.Location.X - 3 + Me.plDrawPlat.AutoScrollPosition.X, lb.Location.Y - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    pic_CT.Location = New Point(lb.Location.X + lb.Size.Width / 2 - 3 + Me.plDrawPlat.AutoScrollPosition.X, lb.Location.Y - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    pic_RT.Location = New Point(lb.Location.X + lb.Size.Width - 3 + Me.plDrawPlat.AutoScrollPosition.X, lb.Location.Y - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    pic_LC.Location = New Point(lb.Location.X + -3 + Me.plDrawPlat.AutoScrollPosition.X, lb.Location.Y + lb.Size.Height / 2 - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    pic_RC.Location = New Point(lb.Location.X + lb.Size.Width - 3 + Me.plDrawPlat.AutoScrollPosition.X, lb.Location.Y + lb.Size.Height / 2 - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    pic_LB.Location = New Point(lb.Location.X - 3 + Me.plDrawPlat.AutoScrollPosition.X, lb.Location.Y + lb.Size.Height - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    pic_CB.Location = New Point(lb.Location.X + lb.Size.Width / 2 - 3 + Me.plDrawPlat.AutoScrollPosition.X, lb.Location.Y + lb.Size.Height - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    pic_RB.Location = New Point(lb.Location.X + lb.Size.Width - 3 + Me.plDrawPlat.AutoScrollPosition.X, lb.Location.Y + lb.Size.Height - 3 + Me.plDrawPlat.AutoScrollPosition.Y)
                    pic_LT.Cursor = Cursors.SizeNWSE
                    pic_RB.Cursor = Cursors.SizeNWSE
                    Dim i As Integer
                    For i = 0 To aryPic.Length - 1
                        aryPic(i).Visible = True
                    Next
            End Select
        Else
            Dim i As Integer
            For i = 0 To aryPic.Length - 1
                aryPic(i).Visible = False
            Next
        End If
    End Sub

    Private Sub plDrawPlat_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles plDrawPlat.Paint
        'ReDraw()
    End Sub

    Private Sub pic_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Text = e.X & "," & e.Y
        If blMoving Then
            If idxSelected < 0 Then
                Exit Sub
            End If
            Dim objGh As objGraph
            objGh = m_Graph(idxSelected)
            Dim g As Graphics = Me.picBoxDraw.CreateGraphics
            Dim pen As New Pen(Color.Black, 1)
            Dim pencls As New Pen(Me.BackColor, 1)
            Dim picTag As String = CType((CType(sender, PictureBox).Tag), String)
            Dim dx As Integer = e.X - curPosX
            Dim dy As Integer = e.Y - curPosY
            Dim ddx As Integer = lastX - curPosX
            Dim ddy As Integer = lastY - curPosY
            Select Case objGh.gType
                Case objType.LINE
                    Dim ln As Graph.Line
                    ln = CObj(objGh.Graph)
                    Select Case picTag
                        Case "LT"
                            If ddx <> 0 Or ddy <> 0 Then
                                g.DrawLine(pencls, New Point(ln.P1.X + ddx, ln.P1.Y + ddy), ln.P2)
                            End If
                            ReDraw()
                            g.DrawLine(pen, New Point(ln.P1.X + dx, ln.P1.Y + dy), ln.P2)
                        Case "RB"
                            If ddx <> 0 Or ddy <> 0 Then
                                g.DrawLine(pencls, ln.P1, New Point(ln.P2.X + ddx, ln.P2.Y + ddy))
                            End If
                            ReDraw()
                            g.DrawLine(pen, ln.P1, New Point(ln.P2.X + dx, ln.P2.Y + dy))
                    End Select
                Case objType.RECT
                    Dim rt As Graph.Rect
                    rt = CObj(objGh.Graph)
                    rtSizing(New Rectangle(rt.location, rt.Size), dx, dy, ddx, ddy, picTag, pen, pencls)
                Case objType.LABEL
                    Dim lb As Graph.Lab
                    lb = CObj(objGh.Graph)
                    rtSizing(New Rectangle(lb.Location, lb.Size), dx, dy, ddx, ddy, picTag, pen, pencls)
            End Select
            lastX = e.X
            lastY = e.Y
        End If
    End Sub

    Private Sub pic_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        curPosX = e.X
        curPosY = e.Y
        blMoving = True
    End Sub

    Private Sub pic_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        lastX = e.X
        lastY = e.Y
        pic_MouseLeave(sender, e)
    End Sub

    Private Sub pic_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        If blMoving Then
            blMoving = False
            If idxSelected < 0 Then
                Exit Sub
            End If
            Dim objGh As objGraph
            objGh = m_Graph(idxSelected)
            Dim picTag As String = CType(CType(sender, PictureBox).Tag, String)
            Dim dx As Integer = lastX - curPosX
            Dim dy As Integer = lastY - curPosY
            Dim pencls As New Pen(Me.BackColor) '用来重画原来的图形，等于清除掉原来的图形
            Dim g As Graphics = Me.picBoxDraw.CreateGraphics
            Dim rtmp As Rectangle
            Select Case objGh.gType
                Case objType.LINE
                    Dim ln As Graph.Line = CObj(objGh.Graph)
                    Select Case picTag
                        Case "LT"
                            g.DrawLine(pencls, ln.P1, ln.P2)
                            ln.P1 = New Point(ln.P1.X + dx, ln.P1.Y + dy)
                        Case "RB"
                            g.DrawLine(pencls, ln.P1, ln.P2)
                            ln.P2 = New Point(ln.P2.X + dx, ln.P2.Y + dy)
                    End Select
                Case objType.RECT
                    Dim rt As Graph.Rect = CObj(objGh.Graph)
                    g.DrawRectangle(pencls, New Rectangle(rt.location, rt.Size))
                    rtmp = rtSized(New Rectangle(rt.location, rt.Size), dx, dy, picTag)
                    rt.location = rtmp.Location
                    rt.Size = rtmp.Size
                Case objType.LABEL
                    Dim lb As Graph.Lab
                    lb = CObj(objGh.Graph)
                    g.DrawRectangle(pencls, New Rectangle(lb.Location, lb.Size))
                    '把一个rectangle转化成rectanglef
                    Dim rectRR As New RectangleF
                    rectRR.X = CType(lb.Location.X, Single)
                    rectRR.Y = CType(lb.Location.Y, Single)
                    rectRR.Height = CType(lb.Size.Height, Single)
                    rectRR.Width = CType(lb.Size.Width, Single)
                    g.DrawString(lb.Text, fnt, New SolidBrush(Me.BackColor), rectRR)
                    rtmp = rtSized(New Rectangle(lb.Location, lb.Size), dx, dy, picTag)
                    g.DrawRectangle(pencls, rtmp)
                    lb.Location = rtmp.Location
                    lb.Size = rtmp.Size
            End Select
        End If
        ReDraw()
    End Sub

    Private Function rtSized(ByVal rt As Rectangle, ByVal dx As Integer, ByVal dy As Integer, ByVal picTag As String) As Rectangle
        Select Case picTag
            Case "LT"
                If rt.Size.Width - dx < 2 Then
                    dx = rt.Size.Width - 2
                End If
                If rt.Size.Height - dy < 2 Then
                    dy = rt.Size.Height - 2
                End If
                rt.Location = New Point(rt.Location.X + dx, rt.Location.Y + dy)
                rt.Size = New Size(rt.Size.Width - dx, rt.Size.Height - dy)
            Case "CT"
                If rt.Size.Height - dy < 2 Then
                    dy = rt.Size.Height - 2
                End If
                rt.Location = New Point(rt.Location.X, rt.Location.Y + dy)
                rt.Size = New Size(rt.Size.Width, rt.Size.Height - dy)
            Case "RT"
                If rt.Size.Width + dx < 2 Then
                    dx = 2 - rt.Size.Width
                End If
                If rt.Size.Height - dy < 2 Then
                    dy = rt.Size.Height - 2
                End If
                rt.Location = New Point(rt.Location.X, rt.Location.Y + dy)
                rt.Size = New Size(rt.Size.Width + dx, rt.Size.Height - dy)
            Case "LC"
                If rt.Size.Width - dx < 2 Then
                    dx = rt.Size.Width - 2
                End If
                rt.Location = New Point(rt.Location.X + dx, rt.Location.Y)
                rt.Size = New Size(rt.Size.Width - dx, rt.Size.Height)
            Case "RC"
                If rt.Size.Width + dx < 2 Then
                    dx = 2 - rt.Size.Width
                End If
                rt.Size = New Size(rt.Size.Width + dx, rt.Size.Height)
            Case "LB"
                If rt.Size.Width - dx < 2 Then
                    dx = rt.Size.Width - 2
                End If
                If rt.Size.Height + dy < 2 Then
                    dy = 2 - rt.Size.Height
                End If
                rt.Location = New Point(rt.Location.X + dx, rt.Location.Y)
                rt.Size = New Size(rt.Size.Width - dx, rt.Size.Height + dy)
            Case "CB"
                If rt.Size.Height + dy < 2 Then
                    dy = 2 - rt.Size.Height
                End If
                rt.Size = New Size(rt.Size.Width, rt.Size.Height + dy)
            Case "RB"
                If rt.Size.Width + dx < 2 Then
                    dx = 2 - rt.Size.Width
                End If
                If rt.Size.Height + dy < 2 Then
                    dy = 2 - rt.Size.Height
                End If
                rt.Size = New Size(rt.Size.Width + dx, rt.Size.Height + dy)
        End Select
        Return rt
    End Function

    Private Sub rtSizing(ByVal rt As Rectangle, ByVal dx As Integer, ByVal dy As Integer, ByVal ddx As Integer, ByVal ddy As Integer, ByVal pictag As String, ByVal pen As Pen, ByVal pencls As Pen)
        Dim g As Graphics = Me.CreateGraphics
        Select Case pictag
            Case "LT"
                g.DrawRectangle(pencls, rt.Location.X + ddx, rt.Location.Y + ddy, rt.Size.Width - ddx, rt.Size.Height - ddy)
                ReDraw()
                g.DrawRectangle(pen, rt.Location.X + dx, rt.Location.Y + dy, rt.Size.Width - dx, rt.Size.Height - dy)
            Case "CT"
                g.DrawRectangle(pencls, rt.Location.X, rt.Location.Y + ddy, rt.Size.Width, rt.Size.Height - ddy)
                ReDraw()
                g.DrawRectangle(pen, rt.Location.X, rt.Location.Y + dy, rt.Size.Width, rt.Size.Height - dy)
            Case "RT"
                g.DrawRectangle(pencls, rt.Location.X, rt.Location.Y + ddy, rt.Size.Width + ddx, rt.Size.Height - ddy)
                ReDraw()
                g.DrawRectangle(pen, rt.Location.X, rt.Location.Y + dy, rt.Size.Width + dx, rt.Size.Height - dy)
            Case "LC"
                g.DrawRectangle(pencls, rt.Location.X + ddx, rt.Location.Y, rt.Size.Width - ddx, rt.Size.Height)
                ReDraw()
                g.DrawRectangle(pen, rt.Location.X + dx, rt.Location.Y, rt.Size.Width - dx, rt.Size.Height)
            Case "RC"
                g.DrawRectangle(pencls, rt.Location.X, rt.Location.Y, rt.Size.Width + ddx, rt.Size.Height)
                ReDraw()
                g.DrawRectangle(pen, rt.Location.X, rt.Location.Y, rt.Size.Width + dx, rt.Size.Height)
            Case "LB"
                g.DrawRectangle(pencls, rt.Location.X + ddx, rt.Location.Y, rt.Size.Width - ddx, rt.Size.Height + ddy)
                ReDraw()
                g.DrawRectangle(pen, rt.Location.X + dx, rt.Location.Y, rt.Size.Width - dx, rt.Size.Height + dy)
            Case "CB"
                g.DrawRectangle(pencls, rt.Location.X, rt.Location.Y, rt.Size.Width, rt.Size.Height + ddy)
                ReDraw()
                g.DrawRectangle(pen, rt.Location.X, rt.Location.Y, rt.Size.Width, rt.Size.Height + dy)
            Case "RB"
                g.DrawRectangle(pencls, rt.Location.X, rt.Location.Y, rt.Size.Width + ddx, rt.Size.Height + ddy)
                ReDraw()
                g.DrawRectangle(pen, rt.Location.X, rt.Location.Y, rt.Size.Width + dx, rt.Size.Height + dy)
        End Select
    End Sub

    Private Sub pic_LC_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_LC.MouseMove
        pic_MouseMove(sender, e)
    End Sub

    Private Sub pic_LC_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_LC.MouseLeave
        pic_MouseLeave(sender, e)
    End Sub

    Private Sub pic_LC_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_LC.MouseDown
        pic_MouseDown(sender, e)
    End Sub

    Private Sub pic_LC_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_LC.MouseUp
        pic_MouseUp(sender, e)
    End Sub

    Private Sub pic_LT_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_LT.MouseMove
        pic_MouseMove(sender, e)
    End Sub

    Private Sub pic_LT_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_LT.MouseLeave
        pic_MouseLeave(sender, e)
    End Sub

    Private Sub pic_LT_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_LT.MouseDown
        pic_MouseDown(sender, e)
    End Sub

    Private Sub pic_LT_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_LT.MouseUp
        pic_MouseUp(sender, e)
    End Sub

    Private Sub pic_LB_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_LB.MouseMove
        pic_MouseMove(sender, e)
    End Sub

    Private Sub pic_LB_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_LB.MouseLeave
        pic_MouseLeave(sender, e)
    End Sub

    Private Sub pic_LB_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_LB.MouseDown
        pic_MouseDown(sender, e)
    End Sub

    Private Sub pic_LB_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_LB.MouseUp
        pic_MouseUp(sender, e)
    End Sub

    Private Sub pic_CT_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_CT.MouseMove
        pic_MouseMove(sender, e)
    End Sub

    Private Sub pic_CT_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_CT.MouseLeave
        pic_MouseLeave(sender, e)
    End Sub

    Private Sub pic_CT_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_CT.MouseDown
        pic_MouseDown(sender, e)
    End Sub

    Private Sub pic_CT_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_CT.MouseUp
        pic_MouseUp(sender, e)
    End Sub

    Private Sub pic_CB_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_CB.MouseLeave
        pic_MouseLeave(sender, e)
    End Sub

    Private Sub pic_CB_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_CB.MouseMove
        pic_MouseMove(sender, e)
    End Sub

    Private Sub pic_CB_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_CB.MouseDown
        pic_MouseDown(sender, e)
    End Sub

    Private Sub pic_CB_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_CB.MouseUp
        pic_MouseUp(sender, e)
    End Sub

    Private Sub pic_RT_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_RT.MouseMove
        pic_MouseMove(sender, e)
    End Sub

    Private Sub pic_RT_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_RT.MouseLeave
        pic_MouseLeave(sender, e)
    End Sub

    Private Sub pic_RT_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_RT.MouseDown
        pic_MouseDown(sender, e)
    End Sub

    Private Sub pic_RT_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_RT.MouseUp
        pic_MouseUp(sender, e)
    End Sub

    Private Sub pic_RC_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_RC.MouseMove
        pic_MouseMove(sender, e)
    End Sub

    Private Sub pic_RC_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_RC.MouseLeave
        pic_MouseLeave(sender, e)
    End Sub

    Private Sub pic_RC_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_RC.MouseDown
        pic_MouseDown(sender, e)
    End Sub

    Private Sub pic_RC_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_RC.MouseUp
        pic_MouseUp(sender, e)
    End Sub

    Private Sub pic_RB_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_RB.MouseMove
        pic_MouseMove(sender, e)
    End Sub

    Private Sub pic_RB_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_RB.MouseLeave
        pic_MouseLeave(sender, e)
    End Sub

    Private Sub pic_RB_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_RB.MouseDown
        pic_MouseDown(sender, e)
    End Sub

    Private Sub pic_RB_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_RB.MouseUp
        pic_MouseUp(sender, e)
    End Sub

    Private Sub textInput_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles textInput.Leave
        If idxSelected < 0 Then
            Exit Sub
        End If
        Dim objgh As objGraph = m_Graph(idxSelected)
        Select Case objgh.gType
            Case objType.LABEL
                Dim lb As Graph.Lab = CObj(objgh.Graph)
                lb.Text = Me.textInput.Text
                Me.textInput.Visible = False
                ReDraw()
        End Select
    End Sub

    '删除
    Private Sub muItemDele_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muItemDele.Click
        If idxSelected >= 0 And idxSelected < m_Graph.Count Then
            m_Graph.RemoveAt(idxSelected)
            Me.picBoxDraw.CreateGraphics.Clear(Me.BackColor)
            ReDraw()
        End If
    End Sub

    Private Sub muItemSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muItemSave.Click
        idxSelected = -1
        '保存
        '清除掉原来保存的图形
        ExecSql("delete from shipgraph where ship_id=" & oldShip_id & " and mobule=0")
        '保存现有的图形
        Dim dsGraph As New DataSet
        Dim sqldaGraph As New SqlClient.SqlDataAdapter
        Dim strGraph As String = "select * from shipgraph where ship_id=" & oldShip_id & " and mobule=0"
        Updatedata(sqldaGraph, strGraph, dsGraph)
        Dim graphCount As Integer = 0
        '读出内存中保存的图形
        For graphCount = 0 To m_Graph.Count - 1
            Dim row As DataRow
            row = dsGraph.Tables(0).NewRow
            row("ship_id") = oldShip_id
            Dim objGh As objGraph
            objGh = m_Graph(graphCount)
            Select Case objGh.gType
                Case objType.LINE
                    Dim ln As Graph.Line = CObj(objGh.Graph)
                    row("linetype") = objGh.lType '线形
                    row("graphType") = "LINE"
                    row("ltx") = ln.P1.X
                    row("lty") = ln.P2.X
                    row("rbx") = ln.P1.Y
                    row("rby") = ln.P2.Y
                Case objType.RECT
                    Dim rt As Graph.Rect = CObj(objGh.Graph)
                    row("linetype") = objGh.lType '线形
                    row("graphType") = "RECT"
                    row("ltx") = rt.location.X
                    row("lty") = rt.location.Y
                    row("rbx") = rt.Size.Width
                    row("rby") = rt.Size.Height
                Case objType.LABEL
                    Dim lb As Graph.Lab = CObj(objGh.Graph)
                    row("graphType") = "LABEL"
                    row("ltx") = lb.Location.X
                    row("lty") = lb.Location.Y
                    row("rbx") = lb.Size.Width
                    row("rby") = lb.Size.Height
                    row("text") = lb.Text
            End Select
            dsGraph.Tables(0).Rows.Add(row)
        Next
        sqldaGraph.Update(dsGraph)
        blSave = True
    End Sub

    Private Sub openGraph(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If comfirmSave() Then
            Return
        End If
        idxSelected = -1
        '从数据库中读出数据
        Dim dsGraph As New DataSet
        Dim sqldaGraph As New SqlClient.SqlDataAdapter
        Dim strGraph As String = "select * from shipgraph where ship_id=" & Ship_ID & " and mobule=0"
        Updatedata(sqldaGraph, strGraph, dsGraph)

        '判断是否有模板
        If dsGraph.Tables(0).Rows.Count = 0 Then
            '判断是不是班轮
            'Dim dsLinerId As New DataSet
            'Getdata("select LINER_ID from vessel where VESSEL_ID=(select v_id from sship where ship_id=" & Ship_ID & ")", dslinerid)
            'If dsLinerId.Tables(0).Rows(0).Item("liner_id") = 1 Then

            'End If
            ExecSql("insert into shipgraph(ship_id,graphType,linetype,ltx,lty,rbx,rby,text) select " & Ship_ID & ",graphType,linetype,ltx,lty,rbx,rby,text from shipgraph where mobule=1")
            Updatedata(sqldaGraph, strGraph, dsGraph)
        Else
            '定义picBoxDraw宽度
            Dim maxwidth As Integer
            Dim dsmaxwidth As New DataSet
            Dim strmaxwidth As String = "select max(ltx) from shipgraph where ship_id=" & Ship_ID & " and mobule=0"
            maxwidth = Getdata(strmaxwidth, dsmaxwidth).Table.Rows(0)(0)
            pic_Move.Location = New Point(maxwidth + 10, 500)
            picBoxDraw.Size = New Size(maxwidth, picBoxDraw.Size.Height)
        End If

        Dim graphCount As Integer = 0
        '清除原有图形
        m_Graph.Clear()
        '读数据到内存中
        Dim objGh As objGraph
        For graphCount = 0 To dsGraph.Tables(0).Rows.Count - 1
            Select Case dsGraph.Tables(0).Rows(graphCount).Item("graphtype")
                Case "LINE"
                    Dim ln As New Graph.Line
                    ln.P1 = New Point(Convert.ToInt32(dsGraph.Tables(0).Rows(graphCount).Item("ltx")), dsGraph.Tables(0).Rows(graphCount).Item("rbx"))
                    ln.P2 = New Point(Convert.ToInt32(dsGraph.Tables(0).Rows(graphCount).Item("lty")), dsGraph.Tables(0).Rows(graphCount).Item("rby"))
                    objGh = New objGraph
                    objGh.gType = objType.LINE
                    '线形
                    'If dsGraph.Tables(0).Rows(graphCount).Item("linetype") = 0 Then
                    '    objGh.lType = dsGraph.Tables(0).Rows(graphCount).Item("linetype")
                    'Else
                    objGh.lType = dsGraph.Tables(0).Rows(graphCount).Item("linetype")
                    'End If
                    objGh.Graph = ln
                    m_Graph.Add(objGh)
                Case "RECT"
                    Dim rt As New Graph.Rect
                    rt.location = New Point(dsGraph.Tables(0).Rows(graphCount).Item("ltx"), dsGraph.Tables(0).Rows(graphCount).Item("lty"))
                    rt.Size = New Size(dsGraph.Tables(0).Rows(graphCount).Item("rbx"), dsGraph.Tables(0).Rows(graphCount).Item("rby"))
                    objGh = New objGraph
                    objGh.gType = objType.RECT
                    '线形
                    'If dsGraph.Tables(0).Rows(graphCount).Item("linetype") = 0 Then
                    '    objGh.lType = lineType.SolidLine
                    'Else
                    '    objGh.lType = lineType.dotLine
                    'End If
                    objGh.lType = dsGraph.Tables(0).Rows(graphCount).Item("linetype")

                    objGh.Graph = rt
                    m_Graph.Add(objGh)
                Case "LABEL"
                    Dim lb As New Graph.Lab
                    lb.Location = New Point(dsGraph.Tables(0).Rows(graphCount).Item("ltx"), dsGraph.Tables(0).Rows(graphCount).Item("lty"))
                    lb.Size = New Size(dsGraph.Tables(0).Rows(graphCount).Item("rbx"), dsGraph.Tables(0).Rows(graphCount).Item("rby"))
                    lb.Text = dsGraph.Tables(0).Rows(graphCount).Item("text")
                    objGh = New objGraph
                    objGh.gType = objType.LABEL
                    objGh.Graph = lb
                    m_Graph.Add(objGh)
            End Select
        Next
        Me.picBoxDraw.CreateGraphics.Clear(Me.BackColor)
        ReDraw()
    End Sub

    Private Function comfirmSave() As Boolean
        If Not blSave Then
            Select Case MessageBox.Show("数据尚未保存，现在要保存吗？", "保存", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    muItemSave_Click(System.DBNull.Value, System.EventArgs.Empty)
                    Return (Not blSave)
                Case DialogResult.No
                    Return False
                Case DialogResult.Cancel
                    Return True
            End Select
        End If
        Return False
    End Function

    Private Sub muItemExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muItemExit.Click
        '退出
        Me.Close()
    End Sub

    Private Sub muItemFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muItemFirst.Click
        '最前
        If idxSelected >= 0 And idxSelected < m_Graph.Count Then
            Dim obj As Object = m_Graph(idxSelected)
            m_Graph.RemoveAt(idxSelected)
            m_Graph.Insert(0, obj)
            idxSelected = 0
        End If
    End Sub

    Private Sub muItemLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muItemLast.Click
        '最后
        If idxSelected >= 0 And idxSelected < m_Graph.Count Then
            Dim obj As Object = m_Graph(idxSelected)
            m_Graph.RemoveAt(idxSelected)
            m_Graph.Add(obj)
            idxSelected = m_Graph.Count - 1
        End If
    End Sub

    Private Sub muItemLineType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muItemLineType.Click
        muItemLineType.Checked = Not muItemLineType.Checked
        '线形
        dotLine = muItemLineType.Checked
        If dotLine = True Then
            muItemdashLine.Checked = False
            dashLine = False
        End If
    End Sub

    Private Sub MuitemRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuitemRefresh.Click
        Me.picBoxDraw.Refresh()
        Me.picBoxDraw.Refresh()
    End Sub

    Private Sub TimerRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRefresh.Tick
        'Me.picBoxDraw.Refresh()
    End Sub

    Private Sub printpageeventhandler(ByVal obj As System.Object, ByVal ev As PrintPageEventArgs)
        Dim penunsel As New Pen(Color.Black, 1)
        Dim pensel As New Pen(Color.Brown, 1)
        Dim pen As New Pen(Color.Black, 1)
        '左边距
        Dim disToLeft As Integer = 30
        '右边距
        Dim disToTop As Integer = 220
        Dim g As Graphics
        g = ev.Graphics
        '画表头
        Dim ff As New FontFamily("宋体")
        Dim f As New Font(ff, 8)
        Dim head_f As New Font(ff, 8, FontStyle.Bold)
        Dim right_f As New Font(ff, 8)
        '填充卸货港和舱位中的数字
        Dim digitalF As New Font(ff, 6)
        Dim dsUnload_port As New DataSet
        '填充舱中的件数和吨数
        Dim dsCabin As New DataSet
        '船名航次的数据集
        Dim dsVessel As New DataSet
        'Getdata("select sship.ENG_VESSEL,VOYAGE,WORKTIME_END,nationality_english from sship,vessel,code_nationality where sship.v_id = vessel.VESSEL_ID And vessel.nationality_code = code_nationality.nationality_eng and sship.ship_id=" & Ship_ID, dsVessel)
        Getdata("select ENG_VESSEL,VOYAGE,WORKTIME_END,nationality_english from view_shipgraph_shipinfo where ship_id=" & Ship_ID, dsVessel)

        '左边
        g.DrawString("HEAD OFFICE", head_f, Brushes.Black, disToLeft + 50, 0)
        g.DrawString("1.Bai Jia Zhuang Dong Li, Chaoyang", f, Brushes.Black, disToLeft, 15)
        g.DrawString("District,Beijing,P.R.China", f, Brushes.Black, disToLeft, 30)
        g.DrawString("Post code:100026 Fax: (010)65920347", f, Brushes.Black, disToLeft, 45)
        g.DrawString("Tel: (010)65920349  65947860", f, Brushes.Black, disToLeft, 60)

        '卸货港开始
        Dim leftx As Integer
        Dim lefty As Integer
        leftx = disToLeft + 40
        lefty = disToTop - 120
        '矩形
        g.DrawRectangle(pen, leftx, lefty, 200, 110)
        '横线
        g.DrawLine(pen, leftx, lefty + 22, leftx + 200, lefty + 22)
        g.DrawLine(pen, leftx, lefty + 44, leftx + 200, lefty + 44)
        g.DrawLine(pen, leftx, lefty + 66, leftx + 200, lefty + 66)
        g.DrawLine(pen, leftx, lefty + 88, leftx + 200, lefty + 88)
        'g.DrawLine(pen, leftx, lefty + 75, leftx + 200, lefty + 75)
        'g.DrawLine(pen, leftx, lefty + 90, leftx + 200, lefty + 90)
        '中间的竖线
        g.DrawLine(pen, leftx + 100, lefty, leftx + 100, lefty + 110)
        '右边的斜线
        g.DrawLine(pen, leftx + 100, lefty + 22, leftx + 200, lefty + 0)
        g.DrawLine(pen, leftx + 100, lefty + 44, leftx + 200, lefty + 22)
        g.DrawLine(pen, leftx + 100, lefty + 66, leftx + 200, lefty + 44)
        g.DrawLine(pen, leftx + 100, lefty + 88, leftx + 200, lefty + 66)
        g.DrawLine(pen, leftx + 100, lefty + 110, leftx + 200, lefty + 88)
        'g.DrawLine(pen, leftx + 100, lefty + 90, leftx + 200, lefty + 75)
        'g.DrawLine(pen, leftx + 100, lefty + 105, leftx + 200, lefty + 90)
        '框顶部的说明
        g.DrawString("Port of discharge", f, Brushes.Black, leftx + 2, lefty + 3)
        g.DrawString("P'kgs", f, Brushes.Black, leftx + 100, lefty + 3)
        g.DrawString("Tons", f, Brushes.Black, leftx + 100 + 75, lefty + 8)
        '卸货港的名称和件数 、吨数
        If Getdata("select code_port.port_eng,sum(amount) as amount,sum(gross_weight)/1000 as gross_weight from cargo_hatch_list,code_port where cargo_hatch_list.unload_port=code_port.code_port and  ship_id =" & Ship_ID & " group by unload_port,code_port.port_eng", dsUnload_port).Count > 0 Then
            Dim cycUnloadPort As Integer = 0
            For cycUnloadPort = 0 To dsUnload_port.Tables(0).Rows.Count - 1
                '卸货港名称
                g.DrawString(dsUnload_port.Tables(0).Rows(cycUnloadPort).Item("port_eng"), f, Brushes.Black, leftx + 2, lefty + 4 + (cycUnloadPort + 1) * 22)
                '件数
                g.DrawString(dsUnload_port.Tables(0).Rows(cycUnloadPort).Item("amount"), digitalF, Brushes.Black, leftx + 100, lefty + 4 + (cycUnloadPort + 1) * 22)
                '吨数
                g.DrawString(System.Math.Round(dsUnload_port.Tables(0).Rows(cycUnloadPort).Item("gross_weight"), 3), digitalF, Brushes.Black, leftx + 100 + 65, lefty + 10 + (cycUnloadPort + 1) * 22)
            Next
        End If
        '卸货港结束

        If Microsoft.VisualBasic.Left(ev.PageSettings.PaperSize.PaperName, 2) = "A4" Then
            '图形
            Dim graphHead As Image = Image.FromFile(CurDir() + "\graphhead.jpg")
            g.DrawImage(graphHead, 370, 0)
            'stowage plan
            Dim sss As New Single
            sss = 13
            Dim stoff As New FontFamily("Arial")
            Dim stoF As New Font(stoff, sss, FontStyle.Bold)

            g.DrawString("STOWAGE      PLAN", stoF, Brushes.Black, 470, disToTop - 120 - 10)
            '右边
            g.DrawString("LIANYUNGANG BRANCH", right_f, Brushes.Black, 1130 - 250 + 60, 0)
            g.DrawString("STATE PATENT NO.", right_f, Brushes.Black, 1130 - 237 + 60, 20)
            g.DrawString("95318813.2", f, Brushes.Black, 1130 - 205 + 60, 60)
            'vessel
            g.DrawString("Vessel:", f, Brushes.Black, disToLeft + 230 + 20, disToTop - 120 + 20)
            g.DrawLine(pen, disToLeft + 230 + 60, disToTop - 120 + 20 + 13, disToLeft + 400 - 5, disToTop - 120 + 20 + 13)
            If dsVessel.Tables(0).Rows(0).Item("ENG_VESSEL") Is System.DBNull.Value = False Then
                g.DrawString(dsVessel.Tables(0).Rows(0).Item("ENG_VESSEL"), f, Brushes.Black, disToLeft + 230 + 62, disToTop - 120 + 20)
            End If
            'voy
            g.DrawString("Voy,No.:", f, Brushes.Black, disToLeft + 400, disToTop - 120 + 20)
            g.DrawLine(pen, disToLeft + 400 + 50, disToTop - 120 + 20 + 13, disToLeft + 510, disToTop - 120 + 20 + 13)
            If dsVessel.Tables(0).Rows(0).Item("VOYAGE") Is System.DBNull.Value = False Then
                g.DrawString(dsVessel.Tables(0).Rows(0).Item("VOYAGE"), f, Brushes.Black, disToLeft + 400 + 50, disToTop - 120 + 20)
            End If
            'nationality
            g.DrawString("Nationality:", f, Brushes.Black, disToLeft + 230 + 20, disToTop - 120 + 20 + 20)
            g.DrawLine(pen, disToLeft + 230 + 20 + 70, disToTop - 120 + 20 + 20 + 13, disToLeft + 510, disToTop - 120 + 20 + 20 + 13)
            If dsVessel.Tables(0).Rows(0).Item("nationality_english") Is System.DBNull.Value = False Then
                g.DrawString(dsVessel.Tables(0).Rows(0).Item("nationality_english"), f, Brushes.Black, disToLeft + 230 + 20 + 72, disToTop - 120 + 20 + 20)
            End If
            'port of loading 
            g.DrawString("Port of loading:", f, Brushes.Black, disToLeft + 230 + 20, disToTop - 120 + 20 + 40)
            g.DrawLine(pen, disToLeft + 230 + 20 + 90, disToTop - 120 + 20 + 40 + 13, disToLeft + 510, disToTop - 120 + 20 + 40 + 13)
            g.DrawString("China Lianyungang", f, Brushes.Black, disToLeft + 230 + 20 + 92, disToTop - 120 + 20 + 40)
            'loading completed on
            g.DrawString("Loading completed on:", f, Brushes.Black, disToLeft + 230 + 20, disToTop - 120 + 20 + 60)
            g.DrawLine(pen, disToLeft + 230 + 20 + 120, disToTop - 120 + 20 + 60 + 13, disToLeft + 510, disToTop - 120 + 20 + 60 + 13)
            If dsVessel.Tables(0).Rows(0).Item("WORKTIME_END") Is System.DBNull.Value = False Then
                g.DrawString(DatePart(DateInterval.Year, dsVessel.Tables(0).Rows(0).Item("WORKTIME_END")) & "-" & DatePart(DateInterval.Month, dsVessel.Tables(0).Rows(0).Item("WORKTIME_END")) & "-" & DatePart(DateInterval.Day, dsVessel.Tables(0).Rows(0).Item("WORKTIME_END")), f, Brushes.Black, disToLeft + 230 + 20 + 120, disToTop - 120 + 20 + 60)
            Else
                g.DrawString(Now.Year.ToString() & "-" & Now.Month.ToString() & "-" & Now.Date.ToString(), f, Brushes.Black, disToLeft + 230 + 20 + 120, disToTop - 120 + 20 + 60)
            End If
            '画最下面的remark
            g.DrawString("Remarks:", f, Brushes.Black, disToLeft + 80, 787 - 30)
            g.DrawLine(pen, disToLeft + 80 + 50, 787 - 40, disToLeft + 500, 787 - 40)
            g.DrawLine(pen, disToLeft + 80 + 50, 787 - 40 + 25, disToLeft + 500, 787 - 40 + 25)
            g.DrawString("Master/Chief Officer:", f, Brushes.Black, disToLeft + 60 + 500, 787 - 40 + 15)
            g.DrawLine(pen, disToLeft + 60 + 500 + 100 + 20, 787 - 40 + 25, disToLeft + 60 + 500 + 50 + 350, 787 - 40 + 25)

            Dim rectlx As Integer = 550
            '舱位
            g.DrawRectangle(pen, rectlx, disToTop - 120 + 20, 490, 90)
            '横线
            g.DrawLine(pen, rectlx, disToTop - 120 + 20 + 30, rectlx + 490, disToTop - 120 + 20 + 30)
            g.DrawLine(pen, rectlx, disToTop - 120 + 20 + 60, rectlx + 490, disToTop - 120 + 20 + 60)
            '竖线和标题
            Dim noL As Integer
            For noL = 1 To 8
                g.DrawLine(pen, rectlx + noL * 55, disToTop - 120 + 20, rectlx + noL * 55, disToTop - 120 + 20 + 90)
            Next
            '右侧的说明
            '每个舱里的件数和吨数开始
            g.DrawString("P'kgs", f, Brushes.Black, rectlx + 10, disToTop - 120 + 20 + 30 + 8)
            g.DrawString("Tons", f, Brushes.Black, rectlx + 10, disToTop - 120 + 20 + 60 + 10)
            '斜线中的说明
            Dim hatchF As New Font(ff, 6)
            g.DrawString("Hatch", hatchF, Brushes.Black, rectlx + 30, disToTop - 120 + 20 + 6)
            g.DrawString("Items", digitalF, Brushes.Black, rectlx + 5, disToTop - 120 + 20 + 20)
            '斜线
            g.DrawLine(pen, rectlx, disToTop - 120 + 20, rectlx + 55, disToTop - 120 + 20 + 30)
            '件数 '吨数  '标题
            Getdata("exec spgraph " & Ship_ID, dsCabin)
            Dim totalPkgs As Integer = 0 '合计件数
            Dim totalTons As Double = 0 '合计吨数
            If dsCabin.Tables(0).Rows.Count > 0 Then
                'Dim fdscabin As New Font(ff, 9)
                For noL = 0 To dsCabin.Tables(0).Rows.Count - 1
                    '标题
                    If noL < 10 Then
                        If dsCabin.Tables(0).Rows(noL).Item("cabinname") <= 12 Then
                            g.DrawString("No." & dsCabin.Tables(0).Rows(noL).Item("cabinname"), f, Brushes.Black, rectlx + (noL + 1) * 55 + 10, disToTop - 120 + 20 + 10)
                        Else
                            If dsCabin.Tables(0).Rows(noL).Item("cabinname") = 13 Then '甲板
                                g.DrawString("DECK", f, Brushes.Black, rectlx + (noL + 1) * 55 + 8, disToTop - 120 + 20 + 10)
                            End If
                            If dsCabin.Tables(0).Rows(noL).Item("cabinname") = 14 Then '前甲板
                                g.DrawString("FOREDECK", f, Brushes.Black, rectlx + (noL + 1) * 55 + 5, disToTop - 120 + 20 + 10)
                            End If
                            If dsCabin.Tables(0).Rows(noL).Item("cabinname") = 15 Then '后甲板
                                g.DrawString("AFTERDECK", f, Brushes.Black, rectlx + (noL + 1) * 55 + 5, disToTop - 120 + 20 + 10)
                            End If
                            If dsCabin.Tables(0).Rows(noL).Item("cabinname") = 16 Then '房间舱
                                g.DrawString("LOCKER", f, Brushes.Black, rectlx + (noL + 1) * 55 + 5, disToTop - 120 + 20 + 10)
                            End If
                        End If
                    End If
                    '件数
                    g.DrawString(dsCabin.Tables(0).Rows(noL).Item("pkgs"), f, Brushes.Black, rectlx + 10 + (noL + 1) * 55, disToTop - 70 + 8)
                    totalPkgs = totalPkgs + dsCabin.Tables(0).Rows(noL).Item("pkgs")
                    '吨数
                    g.DrawString(Math.Round(dsCabin.Tables(0).Rows(noL).Item("tons") / 1000, 3), f, Brushes.Black, rectlx + 10 + (noL + 1) * 55, disToTop - 30)
                    totalTons = totalTons + Math.Round(dsCabin.Tables(0).Rows(noL).Item("tons") / 1000, 3)
                Next
            End If
            '写total
            g.DrawString("Total", f, Brushes.Black, rectlx + 8 * 55 + 5, disToTop - 120 + 20 + 10)
            If totalPkgs > 0 Then
                g.DrawString(totalPkgs, f, Brushes.Black, rectlx + 8 * 55 + 5, disToTop - 120 + 20 + 10 + 30)
            End If
            If totalTons > 0 Then
                g.DrawString(totalTons, f, Brushes.Black, rectlx + 8 * 55 + 5, disToTop - 120 + 20 + 10 + 30 + 30)
            End If
        End If
        If Microsoft.VisualBasic.Left(ev.PageSettings.PaperSize.PaperName, 2) = "B4" Then
            '图形
            Dim graphHead As Image = Image.FromFile(CurDir() + "\graphhead.jpg")
            g.DrawImage(graphHead, 370 + 157, 0)
            'stowage plan
            Dim stoff As New FontFamily("Arial")
            Dim stoF As New Font(stoff, 13, FontStyle.Bold)
            g.DrawString("STOWAGE      PLAN", stoF, Brushes.Black, 470 + 157, disToTop - 120 - 10)
            '右边
            g.DrawString("LIANYUNGANG BRANCH", right_f, Brushes.Black, 1130 - 250 + 60 + 315, 0)
            g.DrawString("STATE PATENT NO.", right_f, Brushes.Black, 1130 - 237 + 60 + 315, 20)
            g.DrawString("95318813.2", f, Brushes.Black, 1130 - 205 + 60 + 315, 60)

            '画最下面的remark
            g.DrawString("Remarks:", f, Brushes.Black, disToLeft + 80, 787 - 30 + 200)
            g.DrawLine(pen, disToLeft + 80 + 50, 787 - 40 + 200, disToLeft + 500 + 157, 787 - 40 + 200)
            g.DrawLine(pen, disToLeft + 80 + 50, 787 - 40 + 25 + 200, disToLeft + 500 + 157, 787 - 40 + 25 + 200)

            g.DrawString("Master/Chief Officer:", f, Brushes.Black, disToLeft + 60 + 500 + 157, 787 - 40 + 15 + 200)
            g.DrawLine(pen, disToLeft + 60 + 500 + 100 + 20 + 157, 787 - 40 + 25 + 200, disToLeft + 60 + 500 + 50 + 350 + 315, 787 - 40 + 25 + 200)

            disToLeft = disToLeft + 40

            'vessel
            g.DrawString("Vessel:", f, Brushes.Black, disToLeft + 230 + 20, disToTop - 120 + 20)
            g.DrawLine(pen, disToLeft + 230 + 60, disToTop - 120 + 20 + 13, disToLeft + 400 - 5, disToTop - 120 + 20 + 13)
            If dsVessel.Tables(0).Rows(0).Item("ENG_VESSEL") Is System.DBNull.Value = False Then
                g.DrawString(dsVessel.Tables(0).Rows(0).Item("ENG_VESSEL"), f, Brushes.Black, disToLeft + 230 + 62, disToTop - 120 + 20)
            End If
            'voy
            g.DrawString("Voy,No.:", f, Brushes.Black, disToLeft + 400 + 20, disToTop - 120 + 20)
            g.DrawLine(pen, disToLeft + 400 + 50 + 20, disToTop - 120 + 20 + 13, disToLeft + 510 + 80, disToTop - 120 + 20 + 13)
            If dsVessel.Tables(0).Rows(0).Item("VOYAGE") Is System.DBNull.Value = False Then
                g.DrawString(dsVessel.Tables(0).Rows(0).Item("VOYAGE"), f, Brushes.Black, disToLeft + 400 + 50 + 30, disToTop - 120 + 20)
            End If
            'nationality
            g.DrawString("Nationality:", f, Brushes.Black, disToLeft + 230 + 20, disToTop - 120 + 20 + 20)
            g.DrawLine(pen, disToLeft + 230 + 20 + 70, disToTop - 120 + 20 + 20 + 13, disToLeft + 510 + 80, disToTop - 120 + 20 + 20 + 13)
            If dsVessel.Tables(0).Rows(0).Item("nationality_english") Is System.DBNull.Value = False Then
                g.DrawString(dsVessel.Tables(0).Rows(0).Item("nationality_english"), f, Brushes.Black, disToLeft + 230 + 20 + 72, disToTop - 120 + 20 + 20)
            End If
            'port of loading
            g.DrawString("Port of loading:", f, Brushes.Black, disToLeft + 230 + 20, disToTop - 120 + 20 + 40)
            g.DrawLine(pen, disToLeft + 230 + 20 + 90, disToTop - 120 + 20 + 40 + 13, disToLeft + 510 + 80, disToTop - 120 + 20 + 40 + 13)
            g.DrawString("China Lianyungang", f, Brushes.Black, disToLeft + 230 + 20 + 92, disToTop - 120 + 20 + 40)
            'loading completed on
            g.DrawString("Loading completed on:", f, Brushes.Black, disToLeft + 230 + 20, disToTop - 120 + 20 + 60)
            g.DrawLine(pen, disToLeft + 230 + 20 + 120, disToTop - 120 + 20 + 60 + 13, disToLeft + 510 + 80, disToTop - 120 + 20 + 60 + 13)
            If dsVessel.Tables(0).Rows(0).Item("WORKTIME_END") Is System.DBNull.Value = False Then
                g.DrawString(DatePart(DateInterval.Year, dsVessel.Tables(0).Rows(0).Item("WORKTIME_END")) & "-" & DatePart(DateInterval.Month, dsVessel.Tables(0).Rows(0).Item("WORKTIME_END")) & "-" & DatePart(DateInterval.Day, dsVessel.Tables(0).Rows(0).Item("WORKTIME_END")), f, Brushes.Black, disToLeft + 230 + 20 + 120, disToTop - 120 + 20 + 60)
            Else
                g.DrawString(Now.Year.ToString() & "-" & Now.Month.ToString() & "-" & Now.Date.ToString(), f, Brushes.Black, disToLeft + 230 + 20 + 120, disToTop - 120 + 20 + 60)
            End If

            disToLeft = disToLeft - 40

            Dim rectlx As Integer = 550 - 180
            Dim rectweight As Integer = 490 + 180
            Dim rectwt As Integer = 55 + 20
            rectlx = rectlx + 315
            '舱位
            g.DrawRectangle(pen, rectlx, disToTop - 120 + 20, rectweight, 90)
            '横线
            g.DrawLine(pen, rectlx, disToTop - 120 + 20 + 30, rectlx + rectweight, disToTop - 120 + 20 + 30)
            g.DrawLine(pen, rectlx, disToTop - 120 + 20 + 60, rectlx + rectweight, disToTop - 120 + 20 + 60)
            '竖线
            Dim noL As Integer
            For noL = 1 To 8
                g.DrawLine(pen, rectlx + noL * rectwt, disToTop - 120 + 20, rectlx + noL * rectwt, disToTop - 120 + 20 + 90)
            Next
            '右侧的说明
            '每个舱里的件数和吨数开始
            g.DrawString("P'kgs", f, Brushes.Black, rectlx + 20, disToTop - 120 + 20 + 30 + 8)
            g.DrawString("Tons", f, Brushes.Black, rectlx + 20, disToTop - 120 + 20 + 60 + 10)
            '斜线中的说明
            Dim hatchF As New Font(ff, 6)
            g.DrawString("Hatch", hatchF, Brushes.Black, rectlx + 40, disToTop - 120 + 20 + 6)
            g.DrawString("Items", digitalF, Brushes.Black, rectlx + 5, disToTop - 120 + 20 + 20)
            '斜线
            g.DrawLine(pen, rectlx, disToTop - 120 + 20, rectlx + rectwt, disToTop - 120 + 20 + 30)
            '件数 '吨数  '标题
            Getdata("exec spgraph " & Ship_ID, dsCabin)
            Dim totalPkgs As Integer = 0 '合计件数
            Dim totalTons As Double = 0 '合计吨数
            If dsCabin.Tables(0).Rows.Count > 0 Then
                'Dim fdscabin As New Font(ff, 9)
                For noL = 0 To dsCabin.Tables(0).Rows.Count - 1
                    '标题
                    If noL < 10 Then
                        If dsCabin.Tables(0).Rows(noL).Item("cabinname") <= 12 Then
                            g.DrawString("No." & dsCabin.Tables(0).Rows(noL).Item("cabinname"), f, Brushes.Black, rectlx + (noL + 1) * rectwt + 10, disToTop - 120 + 20 + 10)
                        Else
                            If dsCabin.Tables(0).Rows(noL).Item("cabinname") = 13 Then '甲板
                                g.DrawString("DECK", f, Brushes.Black, rectlx + (noL + 1) * rectwt + 8, disToTop - 120 + 20 + 10)
                            End If
                            If dsCabin.Tables(0).Rows(noL).Item("cabinname") = 14 Then '前甲板
                                g.DrawString("FOREDECK", f, Brushes.Black, rectlx + (noL + 1) * rectwt + 5, disToTop - 120 + 20 + 10)
                            End If
                            If dsCabin.Tables(0).Rows(noL).Item("cabinname") = 15 Then '后甲板
                                g.DrawString("AFTERDECK", f, Brushes.Black, rectlx + (noL + 1) * rectwt + 5, disToTop - 120 + 20 + 10)
                            End If
                            If dsCabin.Tables(0).Rows(noL).Item("cabinname") = 16 Then '房间舱
                                g.DrawString("LOCKER", f, Brushes.Black, rectlx + (noL + 1) * rectwt + 5, disToTop - 120 + 20 + 10)
                            End If
                        End If
                    End If
                    '件数
                    g.DrawString(dsCabin.Tables(0).Rows(noL).Item("pkgs"), f, Brushes.Black, rectlx + 10 + (noL + 1) * rectwt, disToTop - 70 + 8)
                    totalPkgs = totalPkgs + dsCabin.Tables(0).Rows(noL).Item("pkgs")
                    '吨数
                    g.DrawString(Math.Round(dsCabin.Tables(0).Rows(noL).Item("tons") / 1000, 3), f, Brushes.Black, rectlx + 10 + (noL + 1) * rectwt, disToTop - 30)
                    totalTons = totalTons + Math.Round(dsCabin.Tables(0).Rows(noL).Item("tons") / 1000, 3)
                Next
            End If
            '写total
            g.DrawString("Total", f, Brushes.Black, rectlx + 8 * rectwt + 10, disToTop - 120 + 20 + 10)
            If totalPkgs > 0 Then
                g.DrawString(totalPkgs, f, Brushes.Black, rectlx + 8 * rectwt + 10, disToTop - 120 + 20 + 10 + 30)
            End If
            If totalTons > 0 Then
                g.DrawString(totalTons, f, Brushes.Black, rectlx + 8 * rectwt + 10, disToTop - 120 + 20 + 10 + 30 + 30)
            End If
            rectlx = rectlx - 315
        End If

        Dim i As Integer = m_Graph.Count - 1
        'for循环取出接口m-graph中的每一个对象
        For i = m_Graph.Count - 1 To 0 Step -1
            '定义一个结构类型变量
            Dim objGh As objGraph
            objGh = CType(m_Graph(i), objGraph)
            If i = idxSelected Then '????
                pen = pensel
            Else
                pen = penunsel
            End If
            Select Case objGh.gType
                Case objType.LINE
                    Dim Ln As Graph.Line = CObj(objGh.Graph)
                    subLineType(objGh, pen) '设置线形         printrate
                    'g.DrawLine(pen, Ln.P1.X + disToLeft, Ln.P1.Y + disToTop, Ln.P2.X + disToLeft, Ln.P2.Y + disToTop)
                    g.DrawLine(pen, Ln.P1.X + disToLeft, Ln.P1.Y + disToTop, Ln.P2.X + disToLeft, Ln.P2.Y + disToTop)
                Case objType.RECT
                    Dim rt As New Graph.Rect
                    rt = CObj(objGh.Graph)
                    subLineType(objGh, pen) '设置线形
                    'g.DrawRectangle(pen, New Rectangle(rt.location.X + disToLeft, rt.location.Y + disToTop, rt.Size.Width, rt.Size.Height))
                    g.DrawRectangle(pen, New Rectangle(rt.location.X + disToLeft, rt.location.Y + disToTop, rt.Size.Width, rt.Size.Height))
                Case objType.LABEL
                    Dim lb As Graph.Lab
                    lb = CObj(objGh.Graph)
                    '把一个rectangle转化成rectanglef 
                    Dim rectRR As New RectangleF
                    rectRR.X = CType(lb.Location.X, Single) + disToLeft
                    rectRR.Y = CType(lb.Location.Y, Single) + disToTop
                    rectRR.Height = CType(lb.Size.Height, Single)
                    rectRR.Width = CType(lb.Size.Width, Single)
                    'g.DrawString(lb.Text, fnt, Brushes.Black, rectRR)
                    g.DrawString(lb.Text, fnt, Brushes.Black, rectRR)
            End Select
        Next
        ev.HasMorePages = False
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Try
            Dim psdlg As New PageSetupDialog
            psdlg.AllowMargins = False
            psdlg.AllowOrientation = False
            ' If Me.storedpagesettings Is System.DBNull.Value Then
            Me.pageset = New PageSettings
            '   End If
            psdlg.PageSettings = Me.pageset
            psdlg.PageSettings.Landscape = True
            psdlg.ShowDialog()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MuitemPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuitemPreview.Click
        Try
            Dim pd As New PrintDocument
            'pd.DefaultPageSettings.Landscape = True
            AddHandler pd.PrintPage, AddressOf printpageeventhandler
            If (Me.pageset Is System.DBNull.Value) = False Then
                pd.DefaultPageSettings = Me.pageset
            End If

            pd.DefaultPageSettings.Landscape = True
            Dim dlg As New PrintPreviewDialog
            dlg.Document = pd
            dlg.ShowDialog()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MuitemPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuitemPrint.Click
        Try
            Dim pd As New PrintDocument
            AddHandler pd.PrintPage, AddressOf printpageeventhandler
            pd.DefaultPageSettings.Landscape = True
            Dim ptdlg As New PrintDialog
            ptdlg.Document = pd
            ptdlg.AllowSelection = True
            ptdlg.AllowSomePages = True
            Dim result As DialogResult
            result = ptdlg.ShowDialog
            If (result = DialogResult.OK) Then
                pd.Print()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MuItemShip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuItemShip.Click
        Me.MuItemShip.Checked = Not Me.MuItemShip.Checked
        If Me.MuItemShip.Checked Then
            Me.GBV.Visible = False
        Else
            Me.GBV.Visible = True
            '控制c1mobile的位置
            If Me.plMobile.Location.X > 700 Then
                Me.plMobile.Location = New Point(700, 9)
            End If
        End If

        'pic_Move.Location = New Point(Me.picBoxDraw.Size.Width, Me.picBoxDraw.Size.Height - 30)

        'Dim p As New Point
        'p.X = plDrawPlat.Location.X
        'p.Y = plDrawPlat.Location.Y
        'p.X = plDrawPlat.Size.Height
        'p.Y = plDrawPlat.Size.Width
    End Sub

    Private Sub MuItemCabinCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuItemCabinCount.Click
        Me.MuItemCabinCount.Checked = Not Me.MuItemCabinCount.Checked
        If Me.MuItemCabinCount.Checked = True Then
            Me.labCabinCount.Visible = True
            Me.txtCabinCount.Visible = True
        Else
            Me.labCabinCount.Visible = False
            Me.txtCabinCount.Visible = False
        End If
    End Sub

    Private Sub txtCabinCount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCabinCount.KeyDown
        If e.KeyCode <> Keys.Enter Then
            Select Case e.KeyCode
                Case Keys.D0
                Case Keys.D1
                Case Keys.D2
                Case Keys.D3
                Case Keys.D4
                Case Keys.D5
                Case Keys.D6
                Case Keys.D7
                Case Keys.D8
                Case Keys.D9
                Case Keys.Back
                Case Keys.Delete
                Case Keys.Left
                Case Keys.Right
                Case Keys.Up
                Case Keys.Down
                Case Keys.NumPad0
                Case Keys.NumPad1
                Case Keys.NumPad2
                Case Keys.NumPad3
                Case Keys.NumPad4
                Case Keys.NumPad5
                Case Keys.NumPad6
                Case Keys.NumPad7
                Case Keys.NumPad8
                Case Keys.NumPad9

                Case Else
                    MsgBox("请输入数字！", MsgBoxStyle.OKOnly, "警告")
                    Me.txtCabinCount.Text = ""
                    Me.txtCabinCount.Focus()
                    Exit Sub
            End Select
        Else
            '首先判断是否输入的是有效数字
            Try
                If Len(Trim(Me.txtCabinCount.Text)) > 0 Then
                    If CType(Me.txtCabinCount.Text, Integer) > 0 And CType(Me.txtCabinCount.Text, Integer) < 7 Then
                        Dim objGh As objGraph
                        Dim i As Integer = 0
                        Dim moveX As Integer '定义移动的距离
                        'moveX = (1010 - 65) / CType(Me.txtCabinCount.Text, Integer)

                        '多个舱的情况
                        '2至4个舱时的情况   2-3
                        If CType(Me.txtCabinCount.Text, Integer) > 1 And CType(Me.txtCabinCount.Text, Integer) < 4 Then
                            moveX = (1010 - 65) / CType(Me.txtCabinCount.Text, Integer)
                            For i = 1 To CType(Me.txtCabinCount.Text, Integer) - 1
                                '加舱的分割线
                                Dim ln As New Graph.Line
                                ln.P1 = New Point(65 + i * moveX, 80)
                                ln.P2 = New Point(65 + i * moveX, 510)
                                objGh = New objGraph
                                objGh.gType = objType.LINE
                                'objGh.lType = dsGraph.Tables(0).Rows(graphCount).Item("linetype")
                                objGh.Graph = ln
                                m_Graph.Add(objGh)
                            Next
                            For i = 1 To CType(Me.txtCabinCount.Text, Integer)
                                '加舱的标签
                                Dim lb As New Graph.Lab
                                lb.Location = New Point(67 + moveX / 2 + (i - 1) * moveX - 22, 64)
                                lb.Size = New Size(33, 15)
                                lb.Text = "No." & (CType(Me.txtCabinCount.Text, Integer) - i + 1)
                                objGh = New objGraph
                                objGh.gType = objType.LABEL
                                objGh.Graph = lb
                                m_Graph.Add(objGh)

                                Dim ln As New Graph.Rect
                                ln.location = New Point(67 + moveX / 2 + (i - 1) * moveX - 22, 63)
                                ln.Size = New Size(33, 17)
                                objGh = New objGraph
                                objGh.gType = objType.RECT
                                objGh.Graph = ln
                                m_Graph.Add(objGh)
                            Next
                            '多于4个舱时的情况  4-5
                        ElseIf CType(Me.txtCabinCount.Text, Integer) > 3 And CType(Me.txtCabinCount.Text, Integer) < 7 Then
                            '定义picBoxDraw宽度
                            picBoxDraw.Size = New Size(1010 + 315, picBoxDraw.Size.Height + 200)
                            'picBoxDraw.Size = New Size(1010 + 315 * (CType(Me.txtCabinCount.Text, Integer) - 3), picBoxDraw.Size.Height)
                            pic_Move.Location = New Point(picBoxDraw.Size.Width, picBoxDraw.Size.Height)
                            'pic_Move.Location = New Point(picBoxDraw.Size.Width, pic_Move.Location.Y)
                            moveX = (1010 + 315 - 65) / CType(Me.txtCabinCount.Text, Integer)

                            '移动模板上的右边线及三条横线

                            Dim objGh1 As objGraph
                            objGh1 = m_Graph(1)
                            Dim pencls As New Pen(Me.BackColor)     '用来重画原来的图形，等于清除掉原来的图形
                            Dim g1 As Graphics = Me.picBoxDraw.CreateGraphics
                            Dim ln1 As Graph.Line = CObj(objGh1.Graph)
                            g1.DrawLine(pencls, ln1.P1, ln1.P2)
                            'ln1.P2 = New Point(ln1.P2.X + 315 * (CType(Me.txtCabinCount.Text, Integer) - 3), ln1.P2.Y)
                            ln1.P2 = New Point(ln1.P2.X + 315, ln1.P2.Y)
                            ReDraw()

                            Dim objGh10 As objGraph
                            objGh10 = m_Graph(10)
                            Dim g10 As Graphics = Me.picBoxDraw.CreateGraphics
                            Dim ln10 As Graph.Line = CObj(objGh10.Graph)
                            g10.DrawLine(pencls, ln10.P1, ln10.P2)
                            ln10.P2 = New Point(ln10.P2.X + 315, ln10.P2.Y)
                            ReDraw()

                            '2/3/7/8/11/5
                            Dim objGh8 As objGraph
                            objGh8 = m_Graph(8)
                            Dim g8 As Graphics = Me.picBoxDraw.CreateGraphics
                            Dim ln8 As Graph.Line = CObj(objGh8.Graph)
                            g8.DrawLine(pencls, ln8.P1, ln8.P2)
                            ln8.P1 = New Point(ln8.P1.X + 315, ln8.P1.Y)
                            ln8.P2 = New Point(ln8.P2.X + 315, ln8.P2.Y + 200)
                            ReDraw()

                            Dim objGh2 As objGraph
                            objGh2 = m_Graph(2)
                            Dim g2 As Graphics = Me.picBoxDraw.CreateGraphics
                            Dim ln2 As Graph.Line = CObj(objGh2.Graph)
                            g2.DrawLine(pencls, ln2.P1, ln2.P2)
                            ln2.P2 = New Point(ln2.P2.X, ln2.P2.Y + 200)
                            ReDraw()

                            Dim objGh3 As objGraph
                            objGh3 = m_Graph(3)
                            Dim g3 As Graphics = Me.picBoxDraw.CreateGraphics
                            Dim ln3 As Graph.Line = CObj(objGh3.Graph)
                            g3.DrawLine(pencls, ln3.P1, ln3.P2)
                            ln3.P2 = New Point(ln3.P2.X, ln3.P2.Y + 200)
                            ReDraw()

                            Dim objGh7 As objGraph
                            objGh7 = m_Graph(7)
                            Dim g7 As Graphics = Me.picBoxDraw.CreateGraphics
                            Dim ln7 As Graph.Line = CObj(objGh7.Graph)
                            g7.DrawLine(pencls, ln7.P1, ln7.P2)
                            ln7.P1 = New Point(ln7.P1.X, ln7.P1.Y + 100)
                            ln7.P2 = New Point(ln7.P2.X, ln7.P2.Y + 200)
                            ReDraw()

                            Dim objGh5 As objGraph
                            objGh5 = m_Graph(5)
                            Dim g5 As Graphics = Me.picBoxDraw.CreateGraphics
                            Dim ln5 As Graph.Line = CObj(objGh5.Graph)
                            g5.DrawLine(pencls, ln5.P1, ln5.P2)
                            ln5.P2 = New Point(ln5.P2.X, ln5.P2.Y + 100)
                            ReDraw()

                            Dim objGh11 As objGraph
                            objGh11 = m_Graph(11)
                            Dim g11 As Graphics = Me.picBoxDraw.CreateGraphics
                            Dim ln11 As Graph.Line = CObj(objGh11.Graph)
                            g11.DrawLine(pencls, ln11.P1, ln11.P2)
                            ln11.P2 = New Point(ln11.P2.X, ln11.P2.Y + 200)
                            ReDraw()

                            '9/4
                            Dim objGh9 As objGraph
                            objGh9 = m_Graph(9)
                            Dim g9 As Graphics = Me.picBoxDraw.CreateGraphics
                            Dim ln9 As Graph.Line = CObj(objGh9.Graph)
                            g9.DrawLine(pencls, ln9.P1, ln9.P2)
                            ln9.P1 = New Point(ln9.P1.X + 315, ln9.P1.Y + 200)
                            ln9.P2 = New Point(ln9.P2.X, ln9.P2.Y + 200)
                            ReDraw()

                            Dim objGh4 As objGraph
                            objGh4 = m_Graph(4)
                            Dim g4 As Graphics = Me.picBoxDraw.CreateGraphics
                            Dim ln4 As Graph.Line = CObj(objGh4.Graph)
                            g4.DrawLine(pencls, ln4.P1, ln4.P2)
                            ln4.P1 = New Point(ln4.P1.X, ln4.P1.Y + 200)
                            ln4.P2 = New Point(ln4.P2.X, ln4.P2.Y + 200)
                            ReDraw()

                            '6
                            Dim objGh6 As objGraph
                            objGh6 = m_Graph(6)
                            Dim g6 As Graphics = Me.picBoxDraw.CreateGraphics
                            Dim ln6 As Graph.Line = CObj(objGh6.Graph)
                            g6.DrawLine(pencls, ln6.P1, ln6.P2)
                            ln6.P1 = New Point(ln6.P1.X, ln6.P1.Y + 100)
                            ln6.P2 = New Point(ln6.P2.X, ln6.P2.Y + 100)
                            ReDraw()

                            For i = 1 To CType(Me.txtCabinCount.Text, Integer) - 1
                                '加舱的分割线
                                Dim ln As New Graph.Line
                                ln.P1 = New Point(65 + i * moveX, 80)
                                ln.P2 = New Point(65 + i * moveX, 510 + 200)
                                objGh = New objGraph
                                objGh.gType = objType.LINE
                                'objGh.lType = dsGraph.Tables(0).Rows(graphCount).Item("linetype")
                                objGh.Graph = ln
                                m_Graph.Add(objGh)
                            Next
                            For i = 1 To CType(Me.txtCabinCount.Text, Integer)
                                '加舱的标签
                                Dim lb As New Graph.Lab
                                lb.Location = New Point(67 + moveX / 2 + (i - 1) * moveX - 22, 64)
                                lb.Size = New Size(33, 15)
                                lb.Text = "No." & (CType(Me.txtCabinCount.Text, Integer) - i + 1)
                                objGh = New objGraph
                                objGh.gType = objType.LABEL
                                objGh.Graph = lb
                                m_Graph.Add(objGh)

                                Dim ln As New Graph.Rect
                                ln.location = New Point(67 + moveX / 2 + (i - 1) * moveX - 22, 63)
                                ln.Size = New Size(33, 17)
                                objGh = New objGraph
                                objGh.gType = objType.RECT
                                objGh.Graph = ln
                                m_Graph.Add(objGh)
                            Next
                        ElseIf CType(Me.txtCabinCount.Text, Integer) = 1 Then
                            '一个舱
                            Dim lb As New Graph.Lab
                            lb.Location = New Point(67 + 473 - 22, 64)
                            lb.Size = New Size(33, 15)
                            lb.Text = "No.1"
                            objGh = New objGraph
                            objGh.gType = objType.LABEL
                            objGh.Graph = lb
                            m_Graph.Add(objGh)

                            Dim ln As New Graph.Rect
                            ln.location = New Point(67 + 473 - 22, 63)
                            ln.Size = New Size(33, 17)
                            objGh = New objGraph
                            objGh.gType = objType.RECT
                            objGh.Graph = ln
                            m_Graph.Add(objGh)
                        End If

                        ReDraw()
                        Me.labCabinCount.Visible = False
                        Me.txtCabinCount.Visible = False
                    Else
                        MsgBox("分舱过多,请使用Excel手工船图！", MsgBoxStyle.OKOnly, "提示")
                        Exit Sub
                    End If
                End If
            Catch
                MsgBox("输入的数字有错误，请重新输入！", MsgBoxStyle.OKOnly, "提示")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txtCabinCount_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCabinCount.VisibleChanged
        If Me.txtCabinCount.Visible = True Then
            Me.txtCabinCount.Focus()
            Me.MuItemCabinCount.Checked = True
        Else
            Me.MuItemCabinCount.Checked = False
            Me.txtCabinCount.Text = ""
        End If
    End Sub

    Dim plMove As Boolean = False
    Dim plPoint As New Point
    Dim plOldPoint As New Point

    Private Sub plMobile_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles plMobile.MouseDown
        plMove = True
        plPoint.X = e.X
        plPoint.Y = e.Y
        plOldPoint.X = Me.plMobile.Location.X
        plOldPoint.Y = Me.plMobile.Location.Y
    End Sub

    Private Sub plMobile_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles plMobile.MouseUp
        If plMove = True Then
            Me.plMobile.Location = New Point(plOldPoint.X + (e.X - plPoint.X), plOldPoint.Y + (e.Y - plPoint.Y))
        End If
        plMove = False
        Me.plMobile.BringToFront()
    End Sub

    Private Sub plMobile_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles plMobile.MouseEnter
        Me.Cursor = Cursors.SizeAll
    End Sub

    Private Sub plMobile_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles plMobile.MouseLeave
        Cursor = Cursors.Default
    End Sub

    '填充选择数据的panel
    Dim dsC1Mobile As New DataSet
    Private Sub fillC1Mobile()
        'Dim str As String = "select descr,hatch_position,blno,goods_cha,mark,cast(sum(amount) as int) amount,sum(weight) weight from view_sp_cargo_hatched where ship_id=" & Ship_ID & " group by descr,goods_cha,blno,mark,hatch_position"
        Dim str As String = "select descr,hatch_position,blno,GOODS_ENG,cast(sum(amount) as int) amount,sum(weight) weight,code_pack from view_sp_cargo_hatched where ship_id=" & Ship_ID & " group by descr,GOODS_ENG,blno,mark,hatch_position,code_pack"
        Me.c1Mobile.DataSource = Getdata(str, dsC1Mobile)
        'Getdata("exec spgraphtext " & Ship_ID, dsC1Mobile)
        Me.c1Mobile.Splits(0).DisplayColumns.Item("code_pack").Visible = False
        'Me.c1Mobile.Splits(0).DisplayColumns.Item("mark").Visible = False
        'Me.c1Mobile.Splits(0).DisplayColumns.Item("code_goods").Visible = False
        'Me.c1Mobile.Splits(0).DisplayColumns.Item("pkgs").Visible = False
        'Me.c1Mobile.Splits(0).DisplayColumns.Item("tons").Visible = False
        Me.c1Mobile.Columns.Item("descr").Caption = "舱名"
        Me.c1Mobile.Columns.Item("blno").Caption = "提单号"
        Me.c1Mobile.Columns.Item("GOODS_ENG").Caption = "货名"

        'Me.c1Mobile.Columns.Item("mark").Caption = "麦头"
        Me.c1Mobile.Columns.Item("amount").Caption = "件数"
        Me.c1Mobile.Columns.Item("weight").Caption = "重量"
        Me.c1Mobile.Columns.Item("hatch_position").Caption = "舱位"

        columnswidth()
    End Sub

    Private Sub columnswidth()
        Dim j As Integer
        For j = 0 To Me.c1Mobile.Columns.Count - 1
            Me.c1Mobile.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.c1Mobile.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.c1Mobile.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.c1Mobile.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.c1Mobile.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.c1Mobile.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
            Me.c1Mobile.Splits(0).DisplayColumns.Item(j).Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        Next
        'Me.c1Mobile.Splits(0).DisplayColumns.Item("descr").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        'Me.c1Mobile.Splits(0).DisplayColumns.Item("blno").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        'Me.c1Mobile.Splits(0).DisplayColumns.Item("goods_cha").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuItemText.Click
        Me.MuItemText.Checked = Not Me.MuItemText.Checked
        If Me.MuItemText.Checked Then
            Me.plMobile.Visible = False
        Else
            Me.plMobile.Visible = True
        End If
    End Sub

    Private Sub c1Mobile_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1Mobile.MouseEnter
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub muItemdashLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muItemdashLine.Click
        muItemdashLine.Checked = Not muItemdashLine.Checked
        '线形
        dashLine = muItemdashLine.Checked
        If dashLine = True Then
            muItemLineType.Checked = False
            dotLine = False
        End If
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        MuitemPreview_Click(sender, e)
    End Sub

    Private curMovPosX, curMovPosY, lastMovX, lastMovY As Integer
    Private blMovMoving As Boolean = False
    Dim dx, dy As Integer

    Private Sub pic_Move_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_Move.MouseDown
        curMovPosX = e.X
        curMovPosY = e.Y
        blMovMoving = True
    End Sub

    Private Sub pic_Move_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_Move.MouseUp
        lastMovX = e.X
        lastMovY = e.Y
        pic_Move_MouseLeave(sender, e)
    End Sub

    Private Sub pic_Move_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If blMovMoving = True Then
            blMovMoving = False
            dx = lastMovX - curMovPosX
            dy = lastMovY - curMovPosY
            If (pic_Move.Location.X + dx) > 1006 Then
                pic_Move.Location = New Point(pic_Move.Location.X + dx + Me.plDrawPlat.AutoScrollPosition.X, pic_Move.Location.Y)
                picBoxDraw.Size = New Size(picBoxDraw.Size.Width + dx + Me.plDrawPlat.AutoScrollPosition.X, picBoxDraw.Size.Height)
            Else
                pic_Move.Location = New Point(1000 + Me.plDrawPlat.AutoScrollPosition.X, pic_Move.Location.Y)
                picBoxDraw.Size = New Size(1006 + Me.plDrawPlat.AutoScrollPosition.X, picBoxDraw.Size.Height)
            End If
        End If
    End Sub

    Private Sub picBoxDraw_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBoxDraw.DoubleClick
        If idxSelected < 0 Then
            Exit Sub
        End If
        Dim objGh As objGraph
        objGh = m_Graph(idxSelected)
        Select Case objGh.gType
            Case objType.LABEL
                Dim aryPic(7) As PictureBox
                aryPic(0) = pic_LT
                aryPic(1) = pic_RB
                aryPic(2) = pic_CT
                aryPic(3) = pic_RT
                aryPic(4) = pic_LC
                aryPic(5) = pic_RC
                aryPic(6) = pic_LB
                aryPic(7) = pic_CB
                Dim i As Integer
                For i = 0 To aryPic.Length - 1
                    aryPic(i).Visible = False
                Next
                Dim lb As Graph.Lab
                lb = CObj(objGh.Graph)
                Me.textInput.Text = lb.Text
                Me.textInput.Location = lb.Location
                Me.textInput.Size = lb.Size
                Me.textInput.Visible = True
                Me.textInput.Focus()
                Me.textInput.SelectAll()
        End Select
    End Sub

    Private Sub picBoxDraw_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBoxDraw.MouseDown
        If e.Button = MouseButtons.Left Then
            If textInput.Visible Then
                textInput_Leave(System.DBNull.Value, System.EventArgs.Empty)  '????????????????????????????????????????????????????????????
            End If
            Select Case pushBtName
                Case "line"
                    blSave = False
                    blDrawing = True
                Case "rect"
                    blSave = False
                    blDrawing = True
                Case "lab"
                    blSave = False
                    blDrawing = True
                Case "sel" '选择图形对象
                    idxSelected = GetSelectIndex(e.X, e.Y)
                    ReDraw()
                    If idxSelected >= 0 And idxSelected < m_Graph.Count Then
                        blMoving = True
                        blSave = False
                    End If
                Case Else
                    Return
            End Select
            curPosX = e.X
            curPosY = e.Y
            lastX = e.X
            lastY = e.Y
        End If
        If e.Button = MouseButtons.Right Then
            If pushBtName = "sel" Then
                idxSelected = GetSelectIndex(e.X, e.Y)
                ReDraw()
                If idxSelected >= 0 And idxSelected < m_Graph.Count Then
                    Me.muItemAry.Visible = True
                    Me.muItemDele.Visible = True
                    Me.MenuItem2.Visible = True
                Else
                    Me.muItemAry.Visible = False
                    Me.muItemDele.Visible = False
                    Me.MenuItem2.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub picBoxDraw_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBoxDraw.MouseEnter
        Select Case pushBtName
            Case "sel"
                Cursor = Cursors.Default
            Case Else
                Cursor = Cursors.Cross
        End Select
    End Sub

    Private Sub picBoxDraw_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBoxDraw.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub picBoxDraw_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBoxDraw.MouseMove
        Me.Text = e.X & "," & e.Y

        If e.X + Me.plDrawPlat.AutoScrollPosition.X < 5 Then
            Me.MuItemShip.Checked = False
            Me.GBV.Visible = True
            If Me.plMobile.Location.X > 700 Then
                Me.plMobile.Location = New Point(700, 9)
            End If
        Else
            Me.MuItemShip.Checked = True
            Me.GBV.Visible = False
        End If

        If blDrawing Then
            Dim g As Graphics = Me.picBoxDraw.CreateGraphics
            Dim pen As New Pen(Color.Black, 1)
            Select Case pushBtName
                Case "line"
                    If curPosX <> lastX Or curPosY <> lastY Then
                        g.DrawLine(New Pen(Me.BackColor, 1), curPosX, curPosY, lastX, lastY)
                    End If
                    ReDraw()
                    '线形
                    If dotLine = True Then
                        pen.DashStyle = Drawing.Drawing2D.DashStyle.Dot
                    Else
                        If dashLine = True Then
                            pen.DashPattern = dashValues
                        Else
                            pen.DashStyle = Drawing.Drawing2D.DashStyle.Solid
                        End If
                    End If
                    g.DrawLine(pen, curPosX, curPosY, e.X, e.Y)
                Case "rect"
                    If curPosX <> lastX Or curPosY <> lastY Then
                        g.DrawRectangle(New Pen(Me.BackColor, 1), Math.Min(curPosX, lastX), Math.Min(curPosY, lastY), Math.Abs(lastX - curPosX), Math.Abs(lastY - curPosY))
                    End If
                    ReDraw()
                    '线形
                    If dotLine = True Then
                        pen.DashStyle = Drawing.Drawing2D.DashStyle.Dot
                    Else
                        If dashLine = True Then
                            pen.DashPattern = dashValues
                        Else
                            pen.DashStyle = Drawing.Drawing2D.DashStyle.Solid
                        End If
                    End If
                    g.DrawRectangle(pen, Math.Min(curPosX, e.X), Math.Min(curPosY, e.Y), Math.Abs(e.X - curPosX), Math.Abs(e.Y - curPosY))
                Case "lab"
                    If curPosX <> lastX Or curPosY <> lastY Then
                        g.DrawRectangle(New Pen(Me.BackColor, 1), Math.Min(curPosX, lastX), Math.Min(curPosY, lastY), Math.Abs(lastX - curPosX), Math.Abs(lastY - curPosY))
                    End If
                    ReDraw()
                    g.DrawRectangle(pen, Math.Min(curPosX, e.X), Math.Min(curPosY, e.Y), Math.Abs(e.X - curPosX), Math.Abs(e.Y - curPosY))
                Case Else
                    Return
            End Select
            lastX = e.X
            lastY = e.Y
        Else
            If pushBtName = "sel" Then
                idxSelect = GetSelectIndex(e.X, e.Y)
                pic_sel()
            End If
            If blMoving Then
                If idxSelected >= 0 And idxSelected < m_Graph.Count Then
                    Dim g As Graphics = Me.picBoxDraw.CreateGraphics
                    Dim pen As New Pen(Color.Black, 1)
                    Dim objGh As objGraph
                    objGh = m_Graph(idxSelected)
                    Select Case objGh.gType
                        Case objType.LINE
                            Dim ln As Graph.Line
                            ln = CObj(objGh.Graph)
                            If curPosX <> lastX Or curPosY <> lastY Then
                                g.DrawLine(New Pen(Me.BackColor, 1), New Point(ln.P1.X + lastX - curPosX, ln.P1.Y + lastY - curPosY), New Point(ln.P2.X + lastX - curPosX, ln.P2.Y + lastY - curPosY))
                            End If
                            ReDraw()
                            '线形
                            If objGh.lType = lineType.dotLine Then
                                pen.DashStyle = Drawing.Drawing2D.DashStyle.Dot
                            Else
                                If objGh.lType = lineType.dashLine Then
                                    pen.DashPattern = dashValues
                                Else
                                    pen.DashStyle = Drawing.Drawing2D.DashStyle.Solid
                                End If
                            End If
                            g.DrawLine(pen, New Point(ln.P1.X + e.X - curPosX, ln.P1.Y + e.Y - curPosY), New Point(ln.P2.X + e.X - curPosX, ln.P2.Y + e.Y - curPosY))
                        Case objType.RECT
                            Dim rt As Graph.Rect
                            rt = CObj(objGh.Graph)
                            If curPosX <> lastX Or curPosY <> lastY Then
                                g.DrawRectangle(New Pen(Me.BackColor, 1), rt.location.X + lastX - curPosX, rt.location.Y + lastY - curPosY, rt.Size.Width, rt.Size.Height)
                            End If
                            ReDraw()
                            '线形
                            If objGh.lType = lineType.dotLine Then
                                pen.DashStyle = Drawing.Drawing2D.DashStyle.Dot
                            Else
                                If objGh.lType = lineType.dashLine Then
                                    pen.DashPattern = dashValues
                                Else
                                    pen.DashStyle = Drawing.Drawing2D.DashStyle.Solid
                                End If
                            End If
                            g.DrawRectangle(pen, rt.location.X + e.X - curPosX, rt.location.Y + e.Y - curPosY, rt.Size.Width, rt.Size.Height)
                        Case objType.LABEL
                            Dim lb As Graph.Lab
                            lb = CObj(objGh.Graph)
                            If curPosX <> lastX Or curPosY <> lastY Then
                                g.DrawRectangle(New Pen(Me.BackColor, 1), lb.Location.X + lastX - curPosX, lb.Location.Y + lastY - curPosY, lb.Size.Width, lb.Size.Height)
                            End If
                            ReDraw()
                            g.DrawRectangle(pen, lb.Location.X + e.X - curPosX, lb.Location.Y + e.Y - curPosY, lb.Size.Width, lb.Size.Height)
                        Case Else
                            Exit Sub
                    End Select
                    lastX = e.X
                    lastY = e.Y
                End If
            End If
        End If
    End Sub

    Private Sub picBoxDraw_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBoxDraw.MouseUp
        If blDrawing Then
            blDrawing = False
            Dim objGh As objGraph
            If e.X <> curPosX Or e.Y <> curPosY Then
                Select Case pushBtName
                    Case "line"
                        Dim ln As Graph.Line
                        ln = New FrmGraph.Graph.Line
                        ln.P1 = New Point(curPosX, curPosY)
                        ln.P2 = New Point(e.X, e.Y)
                        objGh = New objGraph
                        objGh.gType = objType.LINE
                        '线形
                        If dotLine = True Then
                            objgh.lType = lineType.dotLine
                        Else
                            If dashLine = True Then
                                objgh.lType = lineType.dashLine
                            Else
                                objgh.lType = lineType.SolidLine
                            End If
                        End If
                        objgh.Graph = New Object
                        objGh.Graph = ln
                        m_Graph.Add(objGh)
                    Case "rect"
                        Dim rt As Graph.Rect
                        rt = New FrmGraph.Graph.Rect
                        rt.location = New Point(Math.Min(curPosX, e.X), Math.Min(curPosY, e.Y))
                        rt.Size = New Size(Math.Abs(curPosX - e.X), Math.Abs(curPosY - e.Y))
                        objGh = New objGraph
                        objGh.gType = objType.RECT
                        '线形
                        If dotLine = True Then
                            objgh.lType = lineType.dotLine
                        Else
                            If dashLine = True Then
                                objgh.lType = lineType.dashLine
                            Else
                                objgh.lType = lineType.SolidLine
                            End If
                        End If
                        objgh.Graph = New Object
                        objGh.Graph = rt
                        m_Graph.Add(objGh)
                    Case "lab"
                        Dim lb As Graph.Lab
                        Dim lbw As Integer
                        Dim lbh As Integer
                        Dim bz As String = ""
                        lb = New FrmGraph.Graph.Lab
                        lb.Location = New Point(Math.Min(curPosX, e.X), Math.Min(curPosY, e.Y))
                        'lb.Size = New Size(Math.Abs(curPosX - e.X), Math.Abs(curPosY - e.Y))

                        If Math.Abs(curPosX - e.X) < 40 Then
                            lbw = 40
                        Else
                            lbw = Math.Abs(curPosX - e.X)
                        End If
                        If Math.Abs(curPosY - e.Y) < 30 Then
                            'If lb.Size.Height < 30 Then
                            lbh = 30
                        Else
                            lbh = Math.Abs(curPosY - e.Y)
                        End If
                        lb.Size = New Size(lbw, lbh)
                        Me.picBoxDraw.Refresh()
                        If Me.c1Mobile.SelectedRows.Count > 0 Then
                            ' dsC1Mobile.Tables(0).Rows(Me.c1Mobile.SelectedRows.Item(0)).Item("blno") & 
                            If CType(Me.c1Mobile.Columns.Item("amount").Text.ToString, Integer) > 1 And Me.c1Mobile.Columns.Item("code_pack").Text <> "IN BULK" Then
                                bz = Me.c1Mobile.Columns.Item("code_pack").Text.ToString + "S"
                            End If

                            If rb1.Checked = True Then
                                lb.Text = Me.c1Mobile.Columns.Item("blno").Text & Chr(10) & Me.c1Mobile.Columns.Item("goods_eng").Text & Chr(10) & Me.c1Mobile.Columns.Item("amount").Text & bz & Chr(10) & Math.Round(CType(Me.c1Mobile.Columns.Item("weight").Text, Single) / 1000, 3) & "T"
                            End If
                            If rb2.Checked = True Then
                                lb.Text = Me.c1Mobile.Columns.Item("blno").Text & Chr(10) & Me.c1Mobile.Columns.Item("amount").Text & bz & Chr(10) & Math.Round(CType(Me.c1Mobile.Columns.Item("weight").Text, Single) / 1000, 3) & "T"
                            End If
                            If rb3.Checked = True Then
                                lb.Text = Me.c1Mobile.Columns.Item("blno").Text & " " & Me.c1Mobile.Columns.Item("amount").Text & " " & bz & " " & Math.Round(CType(Me.c1Mobile.Columns.Item("weight").Text, Single) / 1000, 3) & "T"
                            End If
                        Else
                            lb.Text = "双击我!"
                            ''stowage plan
                            'Dim sss As New Single
                            'sss = 13
                            'Dim stoff As New FontFamily("Arial")
                            'Dim stoF As New Font(stoff, sss, FontStyle.Bold)
                        End If

                        Me.picBoxDraw.CreateGraphics.DrawRectangle(New Pen(Me.BackColor, 1), New Rectangle(lb.Location, lb.Size))
                        objGh = New objGraph
                        objGh.gType = objType.LABEL
                        objgh.Graph = New Object
                        objGh.Graph = lb
                        m_Graph.Add(objGh)
                End Select
                Me.picBoxDraw.CreateGraphics.Clear(Me.BackColor)
                ReDraw()
            End If
        End If
        If blMoving Then
            blMoving = False
            If idxSelected >= 0 And idxSelected < m_Graph.Count Then
                Dim g As Graphics = Me.picBoxDraw.CreateGraphics
                Dim objGh As objGraph
                objgh = m_Graph(idxSelected)
                Select Case objgh.gType
                    Case objType.LINE
                        Dim ln As Graph.Line
                        ln = CObj(objgh.Graph)
                        g.DrawLine(New Pen(Me.BackColor), ln.P1, ln.P2)
                        ln.P1 = New Point(ln.P1.X + e.X - curPosX, ln.P1.Y + e.Y - curPosY)
                        ln.P2 = New Point(ln.P2.X + e.X - curPosX, ln.P2.Y + e.Y - curPosY)
                    Case objType.RECT
                        Dim rt As Graph.Rect
                        rt = CObj(objgh.Graph)
                        g.DrawRectangle(New Pen(Me.BackColor), New Rectangle(rt.location, rt.Size))
                        rt.location = New Point(rt.location.X + e.X - curPosX, rt.location.Y + e.Y - curPosY)
                    Case objType.LABEL
                        Dim lb As Graph.Lab
                        lb = CObj(objgh.Graph)
                        g.DrawRectangle(New Pen(Me.BackColor), New Rectangle(lb.Location, lb.Size))
                        '把一个rectangle转化成rectanglef
                        Dim rectRR As New RectangleF
                        rectRR.X = CType(lb.Location.X, Single)
                        rectRR.Y = CType(lb.Location.Y, Single)
                        rectRR.Height = CType(lb.Size.Height, Single)
                        rectRR.Width = CType(lb.Size.Width, Single)
                        g.DrawString(lb.Text, fnt, New SolidBrush(Me.BackColor), rectRR)
                        lb.Location = New Point(lb.Location.X + e.X - curPosX, lb.Location.Y + e.Y - curPosY)
                    Case Else
                        Exit Sub
                End Select
                ReDraw()
            End If
        End If
    End Sub

    Private Sub picBoxDraw_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picBoxDraw.Paint
        ReDraw()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Dim fdialog As New FontDialog
        If fdialog.ShowDialog() = DialogResult.OK Then
            fnt_all = fdialog.Font
            picBoxDraw.Refresh()
        End If
    End Sub

End Class