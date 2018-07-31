Imports TALLY.DBControl
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Math
Imports System.Drawing.Printing
Public Class Frm_single_bay_movebox
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_printpreview As System.Windows.Forms.Button
    Friend WithEvents btn_pagesetup As System.Windows.Forms.Button
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_defined_bay As System.Windows.Forms.ComboBox
    Friend WithEvents btn_cancle As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Pl_bay_map As System.Windows.Forms.Panel
    Friend WithEvents c1dbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_single_bay_movebox))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_printpreview = New System.Windows.Forms.Button()
        Me.btn_pagesetup = New System.Windows.Forms.Button()
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_defined_bay = New System.Windows.Forms.ComboBox()
        Me.btn_cancle = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.c1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Pl_bay_map = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_printpreview, Me.btn_pagesetup, Me.btn_enter, Me.Label1, Me.cmb_defined_bay, Me.btn_cancle})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(778, 74)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btn_printpreview
        '
        Me.btn_printpreview.Location = New System.Drawing.Point(354, 25)
        Me.btn_printpreview.Name = "btn_printpreview"
        Me.btn_printpreview.Size = New System.Drawing.Size(64, 24)
        Me.btn_printpreview.TabIndex = 12
        Me.btn_printpreview.Text = "打印预揽"
        '
        'btn_pagesetup
        '
        Me.btn_pagesetup.Location = New System.Drawing.Point(279, 25)
        Me.btn_pagesetup.Name = "btn_pagesetup"
        Me.btn_pagesetup.Size = New System.Drawing.Size(64, 24)
        Me.btn_pagesetup.TabIndex = 11
        Me.btn_pagesetup.Text = "页面设置"
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(429, 25)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(64, 24)
        Me.btn_enter.TabIndex = 10
        Me.btn_enter.Text = "确认"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(153, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "BAY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_defined_bay
        '
        Me.cmb_defined_bay.Location = New System.Drawing.Point(200, 27)
        Me.cmb_defined_bay.Name = "cmb_defined_bay"
        Me.cmb_defined_bay.Size = New System.Drawing.Size(68, 20)
        Me.cmb_defined_bay.TabIndex = 7
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(504, 25)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(64, 24)
        Me.btn_cancle.TabIndex = 9
        Me.btn_cancle.Text = "取消"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1dbg})
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(578, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 679)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "箱信息"
        '
        'c1dbg
        '
        Me.c1dbg.AllowFilter = True
        Me.c1dbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.c1dbg.AllowSort = True
        Me.c1dbg.CaptionHeight = 18
        Me.c1dbg.CollapseColor = System.Drawing.Color.Black
        Me.c1dbg.DataChanged = False
        Me.c1dbg.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1dbg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1dbg.ExpandColor = System.Drawing.Color.Black
        Me.c1dbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbg.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.c1dbg.Location = New System.Drawing.Point(3, 17)
        Me.c1dbg.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.c1dbg.Name = "c1dbg"
        Me.c1dbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbg.PreviewInfo.ZoomFactor = 75
        Me.c1dbg.PrintInfo.ShowOptionsDialog = False
        Me.c1dbg.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.c1dbg.RowDivider = GridLines1
        Me.c1dbg.RowHeight = 16
        Me.c1dbg.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1dbg.ScrollTips = False
        Me.c1dbg.Size = New System.Drawing.Size(194, 659)
        Me.c1dbg.TabIndex = 0
        Me.c1dbg.PropBag = CType(resources.GetObject("c1dbg.PropBag"), String)
        '
        'Pl_bay_map
        '
        Me.Pl_bay_map.AutoScroll = True
        Me.Pl_bay_map.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pl_bay_map.Location = New System.Drawing.Point(0, 74)
        Me.Pl_bay_map.Name = "Pl_bay_map"
        Me.Pl_bay_map.Size = New System.Drawing.Size(578, 679)
        Me.Pl_bay_map.TabIndex = 4
        '
        'Frm_single_bay_movebox
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(778, 753)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Pl_bay_map, Me.GroupBox2, Me.GroupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_single_bay_movebox"
        Me.Text = "贝内倒箱"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds_defined_bay As New DataSet()
    Dim storedpagesettings As PageSettings
    '船信息
    Dim ds_c1dbg As New DataSet() '填充C1 
    Dim sqlda_c1dbg As New SqlClient.SqlDataAdapter()
    Dim container_No As String '箱号
    Dim v_id As Integer
    Dim ENG_VESSEL As String
    Dim CHI_VESSEL As String
    Dim VOYAGE As String
    Dim ds_exist_bay As New DataSet()
    Dim ds_ship As New DataSet()
    Dim i, j, n, k As Integer
    Dim col_count As Integer
    Dim bmp_bay_map As Bitmap
    Dim bmpgraphics_bay_map As Graphics
    Dim pen_line As New Pen(Color.Black, 1)
    Dim print_result As New PrintDocument()
    Dim distolefe As Integer = 60 '距左边距移动的位移
    Dim distotop As Integer = 40 '最上面一行写BAY
    Dim ff As New FontFamily("宋体")
    Dim f As New Font(ff, 6)
    Dim f_container As New Font(ff, 4)
    Dim bay_f As New Font(ff, 25, FontStyle.Bold)
    Dim container_f As New Font(ff, 15, FontStyle.Bold)
    Dim bru_fill As New SolidBrush(Color.Blue)
    '甲板
    Dim ds_board_char As New DataSet()
    Dim small_row As Integer
    Dim small_col As Integer
    Dim big_row As Integer
    Dim big_col As Integer
    Dim ds_board As New DataSet()
    Dim bay_row As String
    Dim bay_col As String
    Dim ds_unuse_col As New DataSet()
    Dim BAYNO As String
    Dim ds_container As New DataSet() '找箱号
    '舱内
    Dim ds_cabin As New DataSet()
    Dim ds_cabin_char As New DataSet()
    Dim small_row_cabin As Integer
    Dim small_col_cabin As Integer
    Dim big_row_cabin As Integer
    Dim big_col_cabin As Integer
    Dim bay_row_cabin As String
    Dim bay_col_cabin As String
    'Dim storepagesettings As New PageSettings()
    '鼠标单击事件
    Dim p As Point
    Dim color1 As Color
    Dim rectx As Single
    Dim recty As Single
    Dim j_col As Integer
    Dim i_row As Integer
    Dim col_count_board As Integer
    Dim col_count_cabin As Integer
    Dim mark As String
    Dim btn_count As Integer = 0 '鼠标单击次数
    Dim bayno_check As String
    Dim sql_str_bayno As String
    Dim ds_bayno As New DataSet()
    Private Sub Frm_single_bay_movebox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bmp_bay_map = New Bitmap(800, 900) '(Me.Pl_bay_map.Width, Me.Pl_bay_map.Height) 
        bmpgraphics_bay_map = Graphics.FromImage(bmp_bay_map)
        Me.Pl_bay_map.BackgroundImage = bmp_bay_map
        pen_line.DashStyle = DashStyle.Solid
        '写船名
        If Getdata("select VESSEL_ID,VESSEL.ENG_VESSEL,VESSEL.CHI_VESSEL, sship.VOYAGE from VESSEL,sship where sship.ship_id=" & Ship_ID & " and sship.v_id=VESSEL.VESSEL_id", ds_ship).Count > 0 Then
            v_id = ds_ship.Tables(0).Rows(0).Item("VESSEL_id")
            ENG_VESSEL = ds_ship.Tables(0).Rows(0).Item("ENG_VESSEL")
            CHI_VESSEL = ds_ship.Tables(0).Rows(0).Item("CHI_VESSEL")
            VOYAGE = ds_ship.Tables(0).Rows(0).Item("VOYAGE")
            '写船名航次
            bmpgraphics_bay_map.DrawString(ENG_VESSEL, Me.Font, Brushes.Black, distolefe + 40, distotop + 0)
            bmpgraphics_bay_map.DrawString(VOYAGE, Me.Font, Brushes.Black, 200, distotop + 0)
            bmpgraphics_bay_map.DrawString("POL：LYG", Me.Font, Brushes.Black, 300, distotop + 0)
            '写BAY
            bmpgraphics_bay_map.DrawString("BAY " & Me.cmb_defined_bay.Text, bay_f, Brushes.Black, 200, 0)
            Me.Pl_bay_map.Refresh()
            '写已存在的贝列
            If Getdata("select  bay_num from con_map,sship where sship.ship_id='" & Ship_ID & "' and sship.v_id=con_map.v_id group by bay_num", ds_exist_bay).Count > 0 Then
                For i = 0 To ds_exist_bay.Tables(0).Rows.Count - 1
                    Me.cmb_defined_bay.Items.Add(ds_exist_bay.Tables(0).Rows(i).Item("bay_num"))
                Next
            End If
        End If
    End Sub
    Private Sub cmb_defined_bay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_defined_bay.TextChanged
        show_bay_map(bmpgraphics_bay_map)
        fill_c1dbg()
    End Sub

    '填充C1
    Private Sub fill_c1dbg()
        Me.c1dbg.DataSource = Updatedata(sqlda_c1dbg, "select CONTAINER_NO,BAYNO,CON_IMAGE_ID from con_image where bayno like '" & Trim(Me.cmb_defined_bay.Text) & "%' and ship_id=" & Ship_ID, ds_c1dbg)
        Me.c1dbg.Columns.Item(1).Caption = "贝位号"
        Me.c1dbg.Columns.Item(0).Caption = "箱号"
        Me.c1dbg.Splits(0).DisplayColumns.Item(0).Width = 90
        Me.c1dbg.Splits(0).DisplayColumns.Item(1).Width = 80
        Me.c1dbg.Splits(0).DisplayColumns.Item(2).Visible = False
    End Sub
    Private Sub show_bay_map(ByVal bmpgraphics_bay_map As Graphics)
        '清空
        bmpgraphics_bay_map.Clear(Me.BackColor)
        small_col = 0
        big_col = 0
        small_col_cabin = 0
        big_col_cabin = 0

        ''甲板取甲板的列数
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='board'", ds_board).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='board'", ds_board_char)
            small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") '取甲板屏幕的最小行
            big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") '取甲板屏幕的最大行
            small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") '取甲板屏幕的最小列
            big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") '取甲板屏幕的最大列
        End If
        '取舱内的列数
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='cabin'", ds_cabin).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='cabin'", ds_cabin_char)
            small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") '取舱内屏幕的最小列
            big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") '取舱内屏幕的最大列
            small_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_row") '取舱内屏幕的最小行
            big_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_row") '取舱内屏幕的最大行
        End If
        '写船名航次
        bmpgraphics_bay_map.DrawString(ENG_VESSEL, Me.Font, Brushes.Black, distolefe + 40, distotop + 0)
        bmpgraphics_bay_map.DrawString(VOYAGE, Me.Font, Brushes.Black, 200, distotop + 0)
        bmpgraphics_bay_map.DrawString("POL：LYG", Me.Font, Brushes.Black, 300, distotop + 0)
        '写BAY
        bmpgraphics_bay_map.DrawString("BAY " & Me.cmb_defined_bay.Text, bay_f, Brushes.Black, 200, 0)
        '甲板开始
        If ds_board.Tables(0).Rows.Count > 0 Then
            '计算甲板结果图的顶点位置
            If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '比较甲板和舱内的列数
                col_count = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''甲板上列数和舱内的差额
            Else
                col_count = 0
            End If
            ''画甲板矩形
            For i = small_row To big_row
                For j = small_col To big_col
                    If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("user_char") = 1 Then
                        '矩形
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * 10 + 20 * (j - small_col + 1), distotop + 200 + 20 - 20 * (i - small_row + 1), 20, 20)
                        '贝位号
                        BAYNO = ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                        '判断此贝位号有无箱号
                        If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT from con_image where  con_image.BAYNO='" & BAYNO & "'and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            '填充矩形
                            bmpgraphics_bay_map.FillRectangle(bru_fill, distolefe + col_count * 10 + 20 * (j - small_col + 1) + 1, distotop + 200 + 20 - 20 * (i - small_row + 1) + 1, 19, 19)
                            bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("code_unload_port"), container_f, Brushes.DarkGray, distolefe + col_count * 10 + 20 * (j - small_col + 1) + 2, distotop + 200 + 20 - 20 * (i - small_row + 1) + 1)
                        End If
                    End If
                Next
            Next
            '画贝层
            For i = small_row To big_row '战位最大屏列,按行读，行坐标先变
                bay_row = 78 + i * 2
                bmpgraphics_bay_map.DrawString(bay_row, Me.Font, Brushes.Black, distolefe + 5, distotop + 220 + 20 - 20 * (i - small_row + 1) - 20 + 5) '贝层
            Next
            ''写贝列
            n = big_col - small_col + 1
            'bay_row = 78 + i * 2
            Dim strcon As Integer
            strcon = 1
            Dim strsmallcol As Integer
            strsmallcol = small_col
            Dim strbigcol As Integer
            strbigcol = big_col
            If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'", ds_unuse_col).Count > 0 Then
                If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") Is System.DBNull.Value Then

                Else
                    If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "右边" Then
                        strbigcol = strbigcol - 1
                    Else
                        If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "左边" Then
                            strsmallcol = strsmallcol + 1
                            strcon = 2
                        End If
                    End If
                End If
            End If
            For j = strsmallcol To strbigcol   '战位最大屏列
                If n Mod 2 = 0 Then
                    k = small_col + Fix(n / 2) - j
                    If k > 0 Then
                        If k < 5 Then
                            bay_col = "0" & k * 2
                        Else
                            bay_col = k * 2
                        End If
                    Else
                        If Abs(k) * 2 + 1 < 10 Then
                            bay_col = "0" & Abs(k) * 2 + 1
                        Else
                            bay_col = Abs(k) * 2 + 1
                        End If
                    End If
                Else
                    k = small_col + Fix(n / 2) - j
                    If k = 0 Then
                        bay_col = "00"
                    Else
                        If k > 0 Then
                            If k * 2 < 10 Then
                                bay_col = "0" & k * 2
                            Else
                                bay_col = k * 2
                            End If
                        Else
                            If Abs(k) * 2 - 1 < 10 Then
                                bay_col = "0" & Abs(k) * 2 - 1
                            Else
                                bay_col = Abs(k) * 2 - 1
                            End If
                        End If
                    End If
                End If
                bmpgraphics_bay_map.DrawString(bay_col, Me.Font, Brushes.Black, distolefe + col_count * 10 + 20 * (j - strsmallcol + strcon) + 3, distotop + 200 + 20 + 3) '贝列
            Next
        End If '甲板结束
        ''舱内开始
        If ds_cabin.Tables(0).Rows.Count > 0 Then
            '计算舱内结果图的顶点位置
            If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                col_count = (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) ''甲板上列数和舱内的差额
            Else
                col_count = 0
            End If
            ''画舱内矩形
            For i = small_row_cabin To big_row_cabin
                For j = small_col_cabin To big_col_cabin
                    If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("user_char") = 1 Then
                        '矩形
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * 10 + 20 * (j - small_col_cabin + 1), distotop + 240 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1), 20, 20) '   bmpgraphics_result_cabin.DrawRectangle(pen_line, 20 * (j - small_col_cabin + 1), 200 - 20 * (i - small_row_cabin + 1), 20, 20
                        '贝位号
                        BAYNO = ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                        '判断此贝位号有无箱号
                        If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT from con_image where  con_image.BAYNO='" & BAYNO & "'and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            '填充矩形
                            bmpgraphics_bay_map.FillRectangle(bru_fill, distolefe + col_count * 10 + 20 * (j - small_col_cabin + 1) + 1, distotop + 240 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1) + 1, 19, 19)
                            bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("code_unload_port"), container_f, Brushes.DarkGray, distolefe + col_count * 10 + 20 * (j - small_col_cabin + 1) + 2, distotop + 240 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1) + 1)
                        End If
                    End If
                Next
            Next
            '画贝层
            For i = small_row_cabin To big_row_cabin '战位最大屏列,按行读，行坐标先变
                If i * 2 < 10 Then
                    bay_row_cabin = "0" & i * 2
                Else
                    bay_row_cabin = i * 2
                End If
                bmpgraphics_bay_map.DrawString(bay_row_cabin, Me.Font, Brushes.Black, distolefe + 5, distotop + 240 + (big_row_cabin - small_row_cabin + 1 + 1) * 20 - 20 * (i - small_row_cabin + 1) - 20 + 5) '贝层
            Next
            ''写贝列
            n = big_col_cabin - small_col_cabin + 1
            'bay_row_cabin = 78 + i * 2
            Dim strcon As Integer
            strcon = 1
            Dim strsmallcol As Integer
            strsmallcol = small_col_cabin
            Dim strbigcol As Integer
            strbigcol = big_col_cabin
            If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'", ds_unuse_col).Count > 0 Then
                If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") Is System.DBNull.Value Then

                Else
                    If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "右边" Then
                        strbigcol = strbigcol - 1
                    Else
                        If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "左边" Then
                            strsmallcol = strsmallcol + 1
                            strcon = 2
                        End If
                    End If
                End If
            End If
            For j = strsmallcol To strbigcol   '战位最大屏列
                'For j = small_col_cabin To big_col_cabin '战位最大屏列
                If n Mod 2 = 0 Then
                    k = small_col_cabin + Fix(n / 2) - j
                    If k > 0 Then
                        If k < 5 Then
                            bay_col_cabin = "0" & k * 2
                        Else
                            bay_col_cabin = k * 2
                        End If
                    Else
                        If Abs(k) * 2 + 1 < 10 Then
                            bay_col_cabin = "0" & Abs(k) * 2 + 1
                        Else
                            bay_col_cabin = Abs(k) * 2 + 1
                        End If
                    End If
                Else
                    k = small_col_cabin + Fix(n / 2) - j
                    If k = 0 Then
                        bay_col_cabin = "00"
                    Else
                        If k > 0 Then
                            If k * 2 < 10 Then
                                bay_col_cabin = "0" & k * 2
                            Else
                                bay_col_cabin = k * 2
                            End If
                        Else
                            If Abs(k) * 2 - 1 < 10 Then
                                bay_col_cabin = "0" & Abs(k) * 2 - 1
                            Else
                                bay_col_cabin = Abs(k) * 2 - 1
                            End If
                        End If
                    End If
                End If
                bmpgraphics_bay_map.DrawString(bay_col_cabin, Me.Font, Brushes.Black, distolefe + col_count * 10 + 20 * (j - strsmallcol + strcon) + 3, distotop + 240 + (big_row_cabin - small_row_cabin + 1) * 20 + 1) '贝列
            Next
        End If
        Me.Pl_bay_map.Refresh()
    End Sub
    Private Sub Pl_bay_map_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pl_bay_map.MouseDown
        If e.Button = MouseButtons.Left Then
            '鼠标第一次单击开始
            color1 = bmp_bay_map.GetPixel(e.X, e.Y)
            If color1.ToArgb = Color.Blue.ToArgb Or color1.ToArgb = Color.DarkGray.ToArgb Then
                btn_count = btn_count + 1
                '计算甲板结果图的顶点位置
                If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '比较甲板和舱内的列数
                    col_count_board = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''甲板上列数和舱内的差额
                Else
                    col_count_board = 0
                End If
                '计算舱内结果图的顶点位置
                If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                    col_count_cabin = (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) ''甲板上列数和舱内的差额
                Else
                    col_count_cabin = 0
                End If
                p.X = e.X
                p.Y = e.Y
                recty = p.Y / 20
                recty = Fix(recty) * 20
                If recty < distotop + 220 Then
                    rectx = (p.X + (col_count_board Mod 2) * 10) / 20
                    rectx = Fix(rectx) * 20
                    mark = "board"
                    i_row = Fix((distotop + 200 + 20 - recty) / 20) + small_row - 1
                    j_col = Fix((rectx - distolefe - col_count_board * 10) / 20) + small_col - 1
                Else
                    rectx = (p.X + (col_count_cabin Mod 2) * 10) / 20
                    rectx = Fix(rectx) * 20
                    mark = "cabin" ' distotop + 240 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1)
                    i_row = Fix(((distotop + 240 + (big_row_cabin - small_row_cabin + 1) * 20) - recty) / 20) + small_row_cabin - 1
                    j_col = Fix((rectx - distolefe - col_count_cabin * 10) / 20) + small_col - 1
                End If
                bayno_check = "select bay_num + bay_col + bay_row from con_map where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and location='" & mark & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'and screen_col='" & j_col & "' and screen_row='" & i_row & "'"
                If Getdata(bayno_check, ds_bayno).Count > 0 Then
                    bayno_check = ds_bayno.Tables(0).Rows(0).Item(0)
                    If Getdata("select con_image.CONTAINER_NO from con_image where  con_image.BAYNO='" & bayno_check & "' and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                        '箱号
                        container_No = ds_container.Tables(0).Rows(0).Item("container_no")

                    End If
                End If
            Else
                '空白色
                If btn_count Mod 2 = 1 Then
                    btn_count = 0
                    '鼠标第二次单击
                    '计算甲板结果图的顶点位置
                    If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '比较甲板和舱内的列数
                        col_count_board = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''甲板上列数和舱内的差额
                    Else
                        col_count_board = 0
                    End If
                    '计算舱内结果图的顶点位置
                    If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                        col_count_cabin = (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) ''甲板上列数和舱内的差额
                    Else
                        col_count_cabin = 0
                    End If
                    p.X = e.X
                    p.Y = e.Y
                    recty = p.Y / 20
                    recty = Fix(recty) * 20
                    If recty < distotop + 220 Then
                        rectx = (p.X + (col_count_board Mod 2) * 10) / 20
                        rectx = Fix(rectx) * 20
                        mark = "board"
                        i_row = Fix((distotop + 200 + 20 - recty) / 20) + small_row - 1
                        j_col = Fix((rectx - distolefe - col_count_board * 10) / 20) + small_col - 1
                    Else
                        rectx = (p.X + (col_count_cabin Mod 2) * 10) / 20
                        rectx = Fix(rectx) * 20
                        mark = "cabin" ' distotop + 240 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1)
                        i_row = Fix(((distotop + 240 + (big_row_cabin - small_row_cabin + 1) * 20) - recty) / 20) + small_row_cabin - 1
                        j_col = Fix((rectx - distolefe - col_count_cabin * 10) / 20) + small_col - 1
                    End If
                    bayno_check = "select bay_num + bay_col + bay_row from con_map where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and location='" & mark & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'and screen_col='" & j_col & "' and screen_row='" & i_row & "' and user_char=1"
                    If Getdata(bayno_check, ds_bayno).Count > 0 Then
                        bayno_check = ds_bayno.Tables(0).Rows(0).Item(0)
                        ExecSql("UPDATE con_image set bayno='" & bayno_check & "' where container_No='" & container_No & "' and ship_Id=" & Ship_ID)
                        show_bay_map(bmpgraphics_bay_map)
                        fill_c1dbg()
                    End If
                End If
                '空白色
            End If
        End If
    End Sub

    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        sqlda_c1dbg.Update(ds_c1dbg)
        fill_c1dbg()
        Me.c1dbg.Refresh()
        show_bay_map(bmpgraphics_bay_map)
    End Sub

    Private Sub btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub
End Class
