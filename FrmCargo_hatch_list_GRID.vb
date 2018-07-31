Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmCargo_hatch_list_GRID
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim addmark As String

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
    Friend WithEvents C1dbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents BTDELETE As System.Windows.Forms.Button
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCargo_hatch_list_GRID))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.C1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.BTDELETE = New System.Windows.Forms.Button()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.BTOK = New System.Windows.Forms.Button()
        CType(Me.C1dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1dbg
        '
        Me.C1dbg.AllowAddNew = True
        Me.C1dbg.AllowDelete = True
        Me.C1dbg.AllowFilter = True
        Me.C1dbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1dbg.AllowSort = True
        Me.C1dbg.CaptionHeight = 18
        Me.C1dbg.CollapseColor = System.Drawing.Color.Black
        Me.C1dbg.DataChanged = False
        Me.C1dbg.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1dbg.ExpandColor = System.Drawing.Color.Black
        Me.C1dbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1dbg.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1dbg.Location = New System.Drawing.Point(8, 8)
        Me.C1dbg.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1dbg.Name = "C1dbg"
        Me.C1dbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1dbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1dbg.PreviewInfo.ZoomFactor = 75
        Me.C1dbg.PrintInfo.ShowOptionsDialog = False
        Me.C1dbg.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1dbg.RowDivider = GridLines1
        Me.C1dbg.RowHeight = 16
        Me.C1dbg.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1dbg.ScrollTips = False
        Me.C1dbg.Size = New System.Drawing.Size(834, 322)
        Me.C1dbg.TabIndex = 84
        Me.C1dbg.Text = "C1TrueDBGrid1"
        Me.C1dbg.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" Colu" & _
        "mnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" Def" & _
        "RecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0" & _
        ", 0, 830, 318</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
        """ me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent" & _
        "=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><Foot" & _
        "erStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" />" & _
        "<HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""Highligh" & _
        "tRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle " & _
        "parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""S" & _
        "tyle11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" " & _
        "me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style paren" & _
        "t="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading""" & _
        " me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me" & _
        "=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""" & _
        "Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""" & _
        "EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""Reco" & _
        "rdSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me" & _
        "=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><La" & _
        "yout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 8" & _
        "30, 318</ClientArea></Blob>"
        '
        'BTDELETE
        '
        Me.BTDELETE.Location = New System.Drawing.Point(322, 362)
        Me.BTDELETE.Name = "BTDELETE"
        Me.BTDELETE.Size = New System.Drawing.Size(65, 24)
        Me.BTDELETE.TabIndex = 95
        Me.BTDELETE.Text = "单行删除"
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(468, 362)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 94
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(396, 362)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 93
        Me.BTOK.Text = "确认"
        '
        'FrmCargo_hatch_list_GRID
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(848, 413)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.BTDELETE, Me.BTQUIT, Me.BTOK, Me.C1dbg})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargo_hatch_list_GRID"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "散杂货舱单_增加"
        CType(Me.C1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargo_hatch_list_GRID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        addmark = ""
        dw = Updatedata(sqlda, "select CARGO_HATCH_LIST_ID,SHIP_ID,BLNO,MARK,ACCESSORY,MARK_NON,LOAD_PORT,UNLOAD_PORT,Code_Pack,CODE_GOODS,GOODS_ENG,GOODS_CHA,amount_ori,tons_ori,SIZE_MEASURE,AMOUNT,GROSS_WEIGHT,SENDER,NOTIFY_PERSON,RECEIVER,PIECE_WEIGHT,USER_NAME from cargo_hatch_list where 1>2", ds)
        Me.C1dbg.DataSource = ds.Tables(0).DefaultView
        Call ITEM_FILL()
        Call PACK()
        Call UNLOADPORT()
        Call LOADPORT()
        Call CODE_GOODS()

        Me.C1dbg.Splits(0).DisplayColumns.Item("CARGO_HATCH_LIST_ID").Visible = False
        Me.C1dbg.Splits(0).DisplayColumns.Item("SHIP_ID").Visible = False
        Me.C1dbg.Splits(0).DisplayColumns.Item("MARK_NON").Visible = False
        Me.C1dbg.Splits(0).DisplayColumns.Item("PIECE_WEIGHT").Visible = False
        Me.C1dbg.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False

        Me.C1dbg.Columns.Item("BLNO").Caption = "提单号"
        Me.C1dbg.Columns.Item("MARK").Caption = "标志"
        Me.C1dbg.Columns.Item("ACCESSORY").Caption = "是否附件"
        Me.C1dbg.Columns.Item("LOAD_PORT").Caption = "装货港"
        Me.C1dbg.Columns.Item("UNLOAD_PORT").Caption = "卸货港"
        Me.C1dbg.Columns.Item("code_goods").Caption = "货类"
        Me.C1dbg.Columns.Item("GOODS_ENG").Caption = "货物英文描述"
        Me.C1dbg.Columns.Item("goods_cha").Caption = "货物中文描述"
        Me.C1dbg.Columns.Item("CODE_PACK").Caption = "包装"
        Me.C1dbg.Columns.Item("AMOUNT").Caption = "实装件数"
        Me.C1dbg.Columns.Item("GROSS_WEIGHT").Caption = "实装毛重"
        Me.C1dbg.Columns.Item("amount_ori").Caption = "原配件数"
        Me.C1dbg.Columns.Item("tons_ori").Caption = "原配毛重"
        Me.C1dbg.Columns.Item("SIZE_MEASURE").Caption = "尺寸"
        Me.C1dbg.Columns.Item("SENDER").Caption = "发货方"
        'Me.C1dbg.Columns.Item("NETWEIGHT").Caption = "净重"
        'Me.C1dbg.Columns.Item("TONS").Caption = "衡重"
        Me.C1dbg.Columns.Item("NOTIFY_PERSON").Caption = "通知方"
        Me.C1dbg.Columns.Item("RECEIVER").Caption = "收货方"

        Me.C1dbg.Splits(0).DisplayColumns.Item("BLNO").Width = 60
        Me.C1dbg.Splits(0).DisplayColumns.Item("MARK").Width = 70
        Me.C1dbg.Splits(0).DisplayColumns.Item("code_goods").Width = 100
        Me.C1dbg.Splits(0).DisplayColumns.Item("goods_cha").Width = 100
        Me.C1dbg.Splits(0).DisplayColumns.Item("CODE_PACK").Width = 50
        Me.C1dbg.Splits(0).DisplayColumns.Item("AMOUNT").Width = 50
        Me.C1dbg.Splits(0).DisplayColumns.Item("amount_ori").Width = 50
        Me.C1dbg.Splits(0).DisplayColumns.Item("ACCESSORY").Width = 50
        Me.C1dbg.Splits(0).DisplayColumns.Item("LOAD_PORT").Width = 150
        Me.C1dbg.Splits(0).DisplayColumns.Item("UNLOAD_PORT").Width = 150
        Me.C1dbg.Splits(0).DisplayColumns.Item("GOODS_ENG").Width = 100
        Me.C1dbg.Splits(0).DisplayColumns.Item("NETWEIGHT").Width = 60
        Me.C1dbg.Splits(0).DisplayColumns.Item("GROSS_WEIGHT").Width = 50
        Me.C1dbg.Splits(0).DisplayColumns.Item("tons_ori").Width = 50
        Me.C1dbg.Splits(0).DisplayColumns.Item("SIZE_MEASURE").Width = 50
        Me.C1dbg.Splits(0).DisplayColumns.Item("SENDER").Width = 60
        Me.C1dbg.Splits(0).DisplayColumns.Item("TONS").Width = 60
        Me.C1dbg.Splits(0).DisplayColumns.Item("NOTIFY_PERSON").Width = 60
        Me.C1dbg.Splits(0).DisplayColumns.Item("RECEIVER").Width = 60
        Me.C1dbg.Refresh()
        Me.C1dbg.Row = Me.C1dbg.Row + 1
        Exit Sub
Err:
        Resume Next
    End Sub
    Private Sub C1dbg_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1dbg.RowColChange
        Try
            If e.LastRow <> -1 Then
                Me.C1dbg.Columns.Item("ship_id").Text = Ship_ID
                Me.C1dbg.Columns.Item("user_name").Value = G_User
                Me.C1dbg.Columns.Item("ACCESSORY").Value = 0
                'Call ITEM_FILL()
                'Call PACK()
                'Call UNLOADPORT()
                'Call LOADPORT()
                'Call CODE_GOODS()
            End If
            If e.LastCol = 4 Then

            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1dbg_OnAddNew(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1dbg.OnAddNew
        Dim BLNO As String
        Dim MARK As String
        Dim UNLOAD As String
        Dim LOAD As String
        Dim CODE_GOODS As String
        Dim GOODS_CHA As String
        Dim GOODS_ENG As String
        Dim CODE_PACK As String

        On Error GoTo err
        If Me.C1dbg.Row >= 1 Then
            Me.C1dbg.Row = Me.C1dbg.Row - 1
            BLNO = Trim(Me.C1dbg.Columns.Item("blno").Text)
            MARK = Trim(Me.C1dbg.Columns.Item("MARK").Text)
            UNLOAD = IIf(Len(Trim(Me.C1dbg.Columns.Item("UNLOAD_port").Value)) > 0, Trim(Me.C1dbg.Columns.Item("UNLOAD_port").Value), "")
            LOAD = IIf(Len(Trim(Me.C1dbg.Columns.Item("LOAD_port").Value)) > 0, Trim(Me.C1dbg.Columns.Item("LOAD_port").Value), "")
            CODE_GOODS = IIf(Len(Trim(Me.C1dbg.Columns.Item("CODE_GOODS").Value)) > 0, Trim(Me.C1dbg.Columns.Item("CODE_GOODS").Value), "")
            GOODS_CHA = Trim(Me.C1dbg.Columns.Item("GOODS_CHA").Text)
            GOODS_ENG = Trim(Me.C1dbg.Columns.Item("GOODS_ENG").Text)
            CODE_PACK = IIf(Len(Trim(Me.C1dbg.Columns.Item("CODE_PACK").Value)) > 0, Trim(Me.C1dbg.Columns.Item("CODE_PACK").Value), "")
            If Len(BLNO) > 0 Then
                If Len(MARK) > 0 Then
                    If Len(UNLOAD) > 0 Then
                        If Len(LOAD) > 0 Then
                            If Len(CODE_GOODS) > 0 Then
                                If Len(GOODS_CHA) > 0 Then
                                    If Len(GOODS_ENG) > 0 Then
                                        Me.C1dbg.Row = Me.C1dbg.Row + 1
                                        Me.C1dbg.Columns.Item("blno").Text = BLNO
                                        Me.C1dbg.Columns.Item("MARK").Text = MARK
                                        Me.C1dbg.Columns.Item("UNLOAD_port").Value = UNLOAD
                                        Me.C1dbg.Columns.Item("LOAD_port").Value = LOAD
                                        Me.C1dbg.Columns.Item("CODE_GOODS").Value = CODE_GOODS
                                        Me.C1dbg.Columns.Item("GOODS_CHA").Text = GOODS_CHA
                                        Me.C1dbg.Columns.Item("GOODS_ENG").Text = IIf(Len(GOODS_ENG) > 0, GOODS_ENG, "")
                                        Me.C1dbg.Columns.Item("CODE_PACK").Value = IIf(Len(CODE_PACK) > 0, CODE_PACK, "")
                                    Else
                                        Me.C1dbg.Row = Me.C1dbg.Row + 1
                                        Me.C1dbg.Delete()
                                        Me.C1dbg.Row = Me.C1dbg.Row - 1
                                        MsgBox("货物英文描述不能为空！")
                                    End If
                                Else
                                    Me.C1dbg.Row = Me.C1dbg.Row + 1
                                    Me.C1dbg.Delete()
                                    Me.C1dbg.Row = Me.C1dbg.Row - 1
                                    MsgBox("货物中文描述不能为空！")
                                End If
                            Else
                                Me.C1dbg.Row = Me.C1dbg.Row + 1
                                Me.C1dbg.Delete()
                                Me.C1dbg.Row = Me.C1dbg.Row - 1
                                MsgBox("货类不能为空！")
                            End If
                        Else
                            Me.C1dbg.Row = Me.C1dbg.Row + 1
                            Me.C1dbg.Delete()
                            Me.C1dbg.Row = Me.C1dbg.Row - 1
                            MsgBox("装货港不能为空！")
                        End If
                    Else
                        Me.C1dbg.Row = Me.C1dbg.Row + 1
                        Me.C1dbg.Delete()
                        Me.C1dbg.Row = Me.C1dbg.Row - 1
                        MsgBox("卸货港不能为空！")
                    End If
                Else
                    Me.C1dbg.Row = Me.C1dbg.Row + 1
                    Me.C1dbg.Delete()
                    Me.C1dbg.Row = Me.C1dbg.Row - 1
                    MsgBox("标志不能为空！")
                End If
            Else
                Me.C1dbg.Row = Me.C1dbg.Row + 1
                Me.C1dbg.Delete()
                Me.C1dbg.Row = Me.C1dbg.Row - 1
                MsgBox("提单号不能为空！")
            End If
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub UNLOADPORT()
        Dim DSUNLOAD As New DataSet
        Try
            Dim i As Integer
            DSUNLOAD.Reset()
            dw = Getdata("select CODE_PORT,isnull(PORT_ENG,'')+PORT_CHA as PORT from CODE_PORT ORDER BY PORT", DSUNLOAD)
            If DSUNLOAD.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("UNLOAD_PORT").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                Me.C1dbg.Columns.Item("UNLOAD_PORT").ValueItems.Translate = True
                Do While Me.C1dbg.Columns.Item("UNLOAD_PORT").ValueItems.Values.Count > 0
                    Me.C1dbg.Columns.Item("UNLOAD_PORT").ValueItems.Values.RemoveAt(0)
                Loop
                For i = 0 To DSUNLOAD.Tables(0).Rows.Count - 1
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                    vi.DisplayValue = DSUNLOAD.Tables(0).Rows(i)("PORT")
                    vi.Value = DSUNLOAD.Tables(0).Rows(i)("CODE_PORT")
                    Me.C1dbg.Columns.Item("UNLOAD_PORT").ValueItems.Values.Add(vi)
                Next
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LOADPORT()
        Dim DSLOAD As New DataSet
        Try
            Dim i As Integer
            DSLOAD.Reset()
            dw = Getdata("select CODE_PORT,isnull(PORT_ENG,'')+PORT_CHA as PORT from CODE_PORT ORDER BY PORT", DSLOAD)
            If DSLOAD.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("LOAD_PORT").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                Me.C1dbg.Columns.Item("LOAD_PORT").ValueItems.Translate = True
                Do While Me.C1dbg.Columns.Item("LOAD_PORT").ValueItems.Values.Count > 0
                    Me.C1dbg.Columns.Item("LOAD_PORT").ValueItems.Values.RemoveAt(0)
                Loop
                For i = 0 To DSLOAD.Tables(0).Rows.Count - 1
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                    vi.DisplayValue = DSLOAD.Tables(0).Rows(i)("PORT")
                    vi.Value = DSLOAD.Tables(0).Rows(i)("CODE_PORT")
                    Me.C1dbg.Columns.Item("LOAD_PORT").ValueItems.Values.Add(vi)
                Next
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ITEM_FILL()
        Try
            Dim i As Integer
            Dim dstrue As New DataSet
            dstrue.Reset()
            dw = Getdata("select Value,Descri from true", dstrue)
            Me.C1dbg.Columns.Item("ACCESSORY").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            Me.C1dbg.Columns.Item("ACCESSORY").ValueItems.Translate = True
            Do While Me.C1dbg.Columns.Item("ACCESSORY").ValueItems.Values.Count > 0
                Me.C1dbg.Columns.Item("ACCESSORY").ValueItems.Values.RemoveAt(0)
            Loop
            For i = 0 To dstrue.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dstrue.Tables(0).Rows(i)("Descri")
                vi.Value = dstrue.Tables(0).Rows(i)("Value")
                Me.C1dbg.Columns.Item("ACCESSORY").ValueItems.Values.Add(vi)
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PACK()
        Dim DSPACK As New DataSet
        Try
            Dim i As Integer
            DSPACK.Reset()
            dw = Getdata("select CODE_PACK,PACK_CHA from CODE_PACK order by px", DSPACK)
            If DSPACK.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Translate = True
                Do While Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.Count > 0
                    Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.RemoveAt(0)
                Loop
                For i = 0 To DSPACK.Tables(0).Rows.Count - 1
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                    vi.DisplayValue = DSPACK.Tables(0).Rows(i)("PACK_CHA")
                    vi.Value = DSPACK.Tables(0).Rows(i)("CODE_PACK")
                    Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.Add(vi)
                Next
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CODE_GOODS() '所有的货类填充
        Dim DSGOODS As New DataSet
        Try
            Dim i As Integer
            DSGOODS.Reset()
            dw = Getdata("SELECT CODE_GOODS,isnull(GOODS_ENG,'')+GOODS_CHA  as GOODS_CHA   FROM CODE_CARGO ORDER BY GOODS_CHA", DSGOODS)
            If DSGOODS.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Translate = True
                Do While Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Values.Count > 0
                    Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Values.RemoveAt(0)
                Loop
                For i = 0 To DSGOODS.Tables(0).Rows.Count - 1
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                    vi.DisplayValue = DSGOODS.Tables(0).Rows(i)("GOODS_CHA")
                    vi.Value = DSGOODS.Tables(0).Rows(i)("CODE_GOODS")
                    Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Values.Add(vi)
                Next
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTDELETE.Click
        Me.C1dbg.Delete()
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Dim i As Integer
        Dim j As Integer
        Dim row As DataRow
        Try
            'If Len(Trim(Me.C1dbg.Columns.Item("blno").Text)) = 0 Then
            '    Me.C1dbg.Delete()
            '    Me.C1dbg.Refresh()
            'End If
            addmark = "1"
            Me.C1dbg.MoveLast()
            j = Me.C1dbg.Row
            Me.C1dbg.MoveFirst()

            For i = 0 To j
                Me.C1dbg.Columns.Item("ship_id").Text = Ship_ID
                Me.C1dbg.Columns.Item("USER_NAME").Text = Trim(G_User)
                If Len(Trim(Me.C1dbg.Columns.Item("blno").Text)) > 0 Then
                    If Len(Trim(Me.C1dbg.Columns.Item("MARK").Text)) > 0 Then
                        If Len(Trim(Me.C1dbg.Columns.Item("LOAD_PORT").Text)) > 0 Then
                            If Len(Trim(Me.C1dbg.Columns.Item("UNLOAD_PORT").Text)) > 0 Then
                                If Len(Trim(Me.C1dbg.Columns.Item("GOODS_CHA").Text)) > 0 Then
                                    If Len(Trim(Me.C1dbg.Columns.Item("CODE_GOODS").Text)) > 0 Then

                                    Else
                                        MsgBox("录入有错误，请检查！")
                                        Me.C1dbg.Row = i
                                        addmark = ""
                                        Exit Sub
                                    End If
                                Else
                                    MsgBox("录入有错误，请检查！")
                                    Me.C1dbg.Row = i
                                    addmark = ""
                                    Exit Sub
                                End If
                            Else
                                MsgBox("录入有错误，请检查！")
                                Me.C1dbg.Row = i
                                addmark = ""
                                Exit Sub
                            End If
                        Else
                            MsgBox("录入有错误，请检查！")
                            Me.C1dbg.Row = i
                            addmark = ""
                            Exit Sub
                        End If
                    Else
                        Me.C1dbg.Columns.Item("MARK").Text = "N/M"
                    End If
                Else
                    MsgBox("录入有错误，请检查！")
                    Me.C1dbg.Row = i
                    addmark = ""
                    Exit Sub
                End If
                Me.C1dbg.MoveNext()
            Next i
            sqlda.Update(ds)
            'Me.C1dbg.MoveFirst()

            'For i = 0 To j
            '    row = ds.Tables(0).NewRow
            '    row("SHIP_ID") = Trim(Ship_ID)
            '    row("BLNO") = Trim(Me.C1dbg.Columns.Item("blno").Text)
            '    row("MARK") = Trim(Me.C1dbg.Columns.Item("MARK").Text)
            '    row("ACCESSORY") = Trim(Me.C1dbg.Columns.Item("ACCESSORY").Value)
            '    row("LOAD_PORT") = Trim(Me.C1dbg.Columns.Item("LOAD_PORT").Value)
            '    row("UNLOAD_PORT") = Trim(Me.C1dbg.Columns.Item("UNLOAD_PORT").Value)
            '    row("AMOUNT") = IIf(Len(Trim(Me.C1dbg.Columns.Item("AMOUNT").Text)) > 0, Trim(Me.C1dbg.Columns.Item("AMOUNT").Text), 0)
            '    row("Code_Pack") = IIf(Len(Trim(Me.C1dbg.Columns.Item("Code_Pack").Value)) > 0, Trim(Me.C1dbg.Columns.Item("Code_Pack").Value), "000")
            '    row("CODE_GOODS") = IIf(Len(Trim(Me.C1dbg.Columns.Item("CODE_GOODS").Value)) > 0, Trim(Me.C1dbg.Columns.Item("CODE_GOODS").Value), "0000")
            '    row("GOODS_ENG") = Trim(Me.C1dbg.Columns.Item("GOODS_ENG").Text)
            '    row("GOODS_CHA") = Trim(Me.C1dbg.Columns.Item("GOODS_CHA").Text)
            '    row("NETWEIGHT") = IIf(Len(Trim(Me.C1dbg.Columns.Item("NETWEIGHT").Text)) > 0, Trim(Me.C1dbg.Columns.Item("NETWEIGHT").Text), 0)
            '    row("GROSS_WEIGHT") = IIf(Len(Trim(Me.C1dbg.Columns.Item("GROSS_WEIGHT").Text)) > 0, Trim(Me.C1dbg.Columns.Item("GROSS_WEIGHT").Text), 0)
            '    row("SIZE_MEASURE") = IIf(Len(Trim(Me.C1dbg.Columns.Item("SIZE_MEASURE").Text)) > 0, Trim(Me.C1dbg.Columns.Item("SIZE_MEASURE").Text), 0)
            '    row("TONS") = IIf(Len(Trim(Me.C1dbg.Columns.Item("TONS").Text)) > 0, Trim(Me.C1dbg.Columns.Item("TONS").Text), 0)
            '    row("SENDER") = Trim(Me.C1dbg.Columns.Item("SENDER").Text)
            '    row("NOTIFY_PERSON") = Trim(Me.C1dbg.Columns.Item("NOTIFY_PERSON").Text)
            '    row("RECEIVER") = Trim(Me.C1dbg.Columns.Item("RECEIVER").Text)
            '    row("USER_NAME") = Trim(G_User)
            '    ds.Tables(0).Rows.Add(row)
            '    sqlda.Update(ds)
            '    Me.C1dbg.MoveNext()

            'Next i
            Call BTQUIT_Click(sender, e)
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub

    Private Sub C1DBG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1dbg.KeyPress
        Dim DSLOAD As New DataSet
        Dim DSUNLOAD As New DataSet
        Dim DSGOODS As New DataSet
        Dim DSPACK As New DataSet

        Try
            If e.KeyChar = Chr(13) Then
                If Me.C1dbg.Col = 19 Then
                    Me.C1dbg.Row = Me.C1dbg.Row + 1
                    Me.C1dbg.Col = 0
                    SendKeys.Send("{LEFT}")
                End If
                If Me.C1dbg.Col = 6 Then
                    If Len(Trim(Me.C1dbg.Columns.Item("LOAD_PORT").Text)) > 0 Then
                        Dim i As Integer
                        DSLOAD.Reset()
                        dw = Getdata("select CODE_PORT,isnull(PORT_ENG,'')+PORT_CHA as PORT from CODE_PORT where PORT_ENG like '%" & Microsoft.VisualBasic.UCase(Trim(Me.C1dbg.Columns.Item("LOAD_PORT").Text)) & "%' or port_cha like '%" & Trim(Me.C1dbg.Columns.Item("LOAD_PORT").Text) & "%' or code_port like '%" & Trim(Me.C1dbg.Columns.Item("LOAD_PORT").Text) & "%' ORDER BY PORT", DSLOAD)
                        If DSLOAD.Tables(0).Rows.Count > 0 Then
                            Me.C1dbg.Columns.Item("LOAD_PORT").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                            Me.C1dbg.Columns.Item("LOAD_PORT").ValueItems.Translate = True
                            Do While Me.C1dbg.Columns.Item("LOAD_PORT").ValueItems.Values.Count > 0
                                Me.C1dbg.Columns.Item("LOAD_PORT").ValueItems.Values.RemoveAt(0)
                            Loop
                            For i = 0 To DSLOAD.Tables(0).Rows.Count - 1
                                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                                vi.DisplayValue = DSLOAD.Tables(0).Rows(i)("PORT")
                                vi.Value = DSLOAD.Tables(0).Rows(i)("CODE_PORT")
                                Me.C1dbg.Columns.Item("LOAD_PORT").ValueItems.Values.Add(vi)
                            Next
                            Me.C1dbg.Columns.Item("LOAD_PORT").Value = DSLOAD.Tables(0).Rows(0).Item("code_port")
                        Else
                            Call LOADPORT()
                            Me.C1dbg.Col = 6
                            'SendKeys.Send("{LEFT}")
                        End If
                    Else
                        MsgBox("装货港不能为空！")
                        Call LOADPORT()
                        Me.C1dbg.Col = 6
                        SendKeys.Send("{LEFT}")
                    End If
                End If
                If Me.C1dbg.Col = 7 Then
                    If Len(Trim(Me.C1dbg.Columns.Item("UNLOAD_PORT").Text)) > 0 Then
                        Dim i As Integer
                        DSUNLOAD.Reset()
                        dw = Getdata("select CODE_PORT,isnull(PORT_ENG,'')+PORT_CHA as PORT from CODE_PORT where PORT_ENG like '%" & Trim(Me.C1dbg.Columns.Item("UNLOAD_PORT").Text) & "%' or port_cha like '%" & Trim(Me.C1dbg.Columns.Item("UNLOAD_PORT").Text) & "%' or code_port like '%" & Trim(Me.C1dbg.Columns.Item("UNLOAD_PORT").Text) & "%'  ORDER BY PORT", DSUNLOAD)
                        If DSUNLOAD.Tables(0).Rows.Count > 0 Then
                            Me.C1dbg.Columns.Item("UNLOAD_PORT").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                            Me.C1dbg.Columns.Item("UNLOAD_PORT").ValueItems.Translate = True
                            Do While Me.C1dbg.Columns.Item("UNLOAD_PORT").ValueItems.Values.Count > 0
                                Me.C1dbg.Columns.Item("UNLOAD_PORT").ValueItems.Values.RemoveAt(0)
                            Loop
                            For i = 0 To DSUNLOAD.Tables(0).Rows.Count - 1
                                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                                vi.DisplayValue = DSUNLOAD.Tables(0).Rows(i)("PORT")
                                vi.Value = DSUNLOAD.Tables(0).Rows(i)("CODE_PORT")
                                Me.C1dbg.Columns.Item("UNLOAD_PORT").ValueItems.Values.Add(vi)
                            Next
                            Me.C1dbg.Columns.Item("UNLOAD_PORT").Value = DSUNLOAD.Tables(0).Rows(0).Item("code_port")
                        Else
                            Call UNLOADPORT()
                            Me.C1dbg.Col = 7
                            'SendKeys.Send("{LEFT}")
                        End If
                    Else
                        MsgBox("卸货港不能为空！")
                        Call UNLOADPORT()
                        Me.C1dbg.Col = 7
                        SendKeys.Send("{LEFT}")
                    End If
                End If
                If Me.C1dbg.Col = 9 Then
                    If Len(Trim(Me.C1dbg.Columns.Item("CODE_PACK").Text)) > 0 Then
                        Dim i As Integer
                        DSPACK.Reset()
                        dw = Getdata("select CODE_PACK,ISNULL(PACK_CHA,'') as PACK_CHA from CODE_PACK where PACK_ENG like '%" & Trim(Me.C1dbg.Columns.Item("CODE_PACK").Text) & "%' or pACK_cha like '%" & Trim(Me.C1dbg.Columns.Item("CODE_PACK").Text) & "%' or code_PACK like '%" & Trim(Me.C1dbg.Columns.Item("CODE_PACK").Text) & "%'  ORDER BY PACK_CHA", DSPACK)
                        If DSPACK.Tables(0).Rows.Count > 0 Then
                            Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                            Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Translate = True
                            Do While Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.Count > 0
                                Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.RemoveAt(0)
                            Loop
                            For i = 0 To DSPACK.Tables(0).Rows.Count - 1
                                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                                vi.DisplayValue = DSPACK.Tables(0).Rows(i)("PACK_CHA")
                                vi.Value = DSPACK.Tables(0).Rows(i)("CODE_PACK")
                                Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.Add(vi)
                            Next
                            Me.C1dbg.Columns.Item("CODE_PACK").Value = DSPACK.Tables(0).Rows(0).Item("CODE_PACK")
                        Else
                            Call PACK()
                            Me.C1dbg.Col = 9
                            'SendKeys.Send("{LEFT}")
                        End If
                    Else
                        MsgBox("包装不能为空！")
                        Call PACK()
                        Me.C1dbg.Col = 9
                        SendKeys.Send("{LEFT}")
                    End If
                End If
                If Me.C1dbg.Col = 10 Then
                    If Len(Trim(Me.C1dbg.Columns.Item("CODE_GOODS").Text)) > 0 Then
                        Dim i As Integer
                        DSGOODS.Reset()
                        dw = Getdata("SELECT CODE_GOODS,isnull(GOODS_ENG,'')+isnull(GOODS_CHA,'')  as GOODS_CHA  FROM CODE_CARGO where goods_eng like '%" & Trim(Me.C1dbg.Columns.Item("CODE_GOODS").Text) & "%' or GOODS_cha like '%" & Trim(Me.C1dbg.Columns.Item("CODE_GOODS").Text) & "%' or CODE_GOODS = '" & Trim(Me.C1dbg.Columns.Item("CODE_GOODS").Text) & "' ORDER BY GOODS_CHA", DSGOODS)
                        If DSGOODS.Tables(0).Rows.Count > 0 Then
                            Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                            Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Translate = True
                            Do While Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Values.Count > 0
                                Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Values.RemoveAt(0)
                            Loop
                            For i = 0 To DSGOODS.Tables(0).Rows.Count - 1
                                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                                vi.DisplayValue = DSGOODS.Tables(0).Rows(i)("GOODS_CHA")
                                vi.Value = DSGOODS.Tables(0).Rows(i)("CODE_GOODS")
                                Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Values.Add(vi)
                            Next
                            Me.C1dbg.Columns.Item("CODE_GOODS").Value = DSGOODS.Tables(0).Rows(0).Item("CODE_GOODS")
                            'If Len(Trim(Me.C1dbg.Columns.Item("CODE_GOODS").Value)) > 0 Then
                            '    Dim DSOTHER As New DataSet()
                            '    dw = Getdata("SELECT GOODS_CHA,isnull(GOODS_ENG,'') AS GOODS_ENG FROM CODE_CARGO WHERE CODE_GOODS='" & Me.C1dbg.Columns.Item("CODE_GOODS").Value & "'", DSOTHER)
                            '    If DSOTHER.Tables(0).Rows.Count > 0 Then
                            '        Me.C1dbg.Columns.Item("GOODS_CHA").Text = DSOTHER.Tables(0).Rows(0).Item("GOODS_CHA")
                            '        Me.C1dbg.Columns.Item("GOODS_ENG").Text = DSOTHER.Tables(0).Rows(0).Item("GOODS_ENG")
                            '    End If
                            'End If
                        Else
                            Call CODE_GOODS()
                            Me.C1dbg.Col = 10
                            'SendKeys.Send("{LEFT}")
                        End If

                    Else
                        MsgBox("货类不能为空！")
                        Call CODE_GOODS()
                        Me.C1dbg.Col = 10
                        SendKeys.Send("{LEFT}")
                    End If
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
