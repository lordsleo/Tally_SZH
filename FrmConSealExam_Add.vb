Imports TALLY.DBControl
Public Class FrmConSealExam_Add
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim Count As Integer
    Dim dvSealNo As New DataView()

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler txtNo.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler cbContainer.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler cbNewSealNo.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler txtWorkPlace.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler txtOriginalSealNO.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler cbOgSealCondition.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler txtRemark.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler cbSealType.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler dtpTimeBegin.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler dtpTimeEnd.KeyDown, AddressOf FrmConSealExam_Add_KeyDown

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
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbSealType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtOriginalSealNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWorkPlace As System.Windows.Forms.TextBox
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents cbContainer As System.Windows.Forms.ComboBox
    Friend WithEvents cbNewSealNo As System.Windows.Forms.ComboBox
    Friend WithEvents cbOgSealCondition As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConSealExam_Add))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbSealType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOriginalSealNO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtWorkPlace = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbContainer = New System.Windows.Forms.ComboBox()
        Me.cbNewSealNo = New System.Windows.Forms.ComboBox()
        Me.cbOgSealCondition = New System.Windows.Forms.ComboBox()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowSort = True
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowDivider = GridLines1
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.ScrollTips = False
        Me.C1DBG.Size = New System.Drawing.Size(190, 323)
        Me.C1DBG.TabIndex = 11
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(202, 292)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 24)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "清空"
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(338, 292)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 12
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(270, 292)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 11
        Me.btSave.Text = "确认"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(202, 238)
        Me.txtRemark.MaxLength = 100
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(200, 46)
        Me.txtRemark.TabIndex = 14
        Me.txtRemark.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(198, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 267
        Me.Label10.Text = "备注"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(198, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 266
        Me.Label9.Text = "原铅封情况"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(272, 150)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeEnd.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(198, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 265
        Me.Label8.Text = "结束时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(272, 126)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeBegin.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(198, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 264
        Me.Label7.Text = "开始时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSealType
        '
        Me.cbSealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSealType.Location = New System.Drawing.Point(272, 78)
        Me.cbSealType.Name = "cbSealType"
        Me.cbSealType.Size = New System.Drawing.Size(130, 20)
        Me.cbSealType.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(198, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 263
        Me.Label6.Text = "新铅封类型"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOriginalSealNO
        '
        Me.txtOriginalSealNO.Location = New System.Drawing.Point(272, 174)
        Me.txtOriginalSealNO.MaxLength = 20
        Me.txtOriginalSealNO.Name = "txtOriginalSealNO"
        Me.txtOriginalSealNO.Size = New System.Drawing.Size(130, 21)
        Me.txtOriginalSealNO.TabIndex = 7
        Me.txtOriginalSealNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(198, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 262
        Me.Label4.Text = "原铅封号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(198, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 261
        Me.Label5.Text = "新铅封号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(198, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 260
        Me.Label3.Text = "集装箱号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(190, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 259
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtWorkPlace
        '
        Me.txtWorkPlace.Location = New System.Drawing.Point(272, 102)
        Me.txtWorkPlace.MaxLength = 50
        Me.txtWorkPlace.Name = "txtWorkPlace"
        Me.txtWorkPlace.Size = New System.Drawing.Size(130, 21)
        Me.txtWorkPlace.TabIndex = 4
        Me.txtWorkPlace.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(198, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 270
        Me.Label1.Text = "工作地点"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(272, 6)
        Me.txtNo.MaxLength = 10
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(130, 21)
        Me.txtNo.TabIndex = 0
        Me.txtNo.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(198, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 272
        Me.Label2.Text = "编号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbContainer
        '
        Me.cbContainer.Location = New System.Drawing.Point(272, 30)
        Me.cbContainer.MaxDropDownItems = 20
        Me.cbContainer.MaxLength = 12
        Me.cbContainer.Name = "cbContainer"
        Me.cbContainer.Size = New System.Drawing.Size(130, 20)
        Me.cbContainer.TabIndex = 273
        '
        'cbNewSealNo
        '
        Me.cbNewSealNo.Location = New System.Drawing.Point(272, 54)
        Me.cbNewSealNo.MaxDropDownItems = 20
        Me.cbNewSealNo.Name = "cbNewSealNo"
        Me.cbNewSealNo.Size = New System.Drawing.Size(130, 20)
        Me.cbNewSealNo.TabIndex = 274
        '
        'cbOgSealCondition
        '
        Me.cbOgSealCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOgSealCondition.Location = New System.Drawing.Point(272, 198)
        Me.cbOgSealCondition.Name = "cbOgSealCondition"
        Me.cbOgSealCondition.Size = New System.Drawing.Size(130, 20)
        Me.cbOgSealCondition.TabIndex = 275
        '
        'FrmConSealExam_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(412, 323)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbOgSealCondition, Me.cbNewSealNo, Me.cbContainer, Me.txtNo, Me.Label2, Me.txtWorkPlace, Me.Label1, Me.btnClear, Me.btQuit, Me.btSave, Me.txtRemark, Me.Label10, Me.Label9, Me.dtpTimeEnd, Me.Label8, Me.dtpTimeBegin, Me.Label7, Me.cbSealType, Me.Label6, Me.txtOriginalSealNO, Me.Label4, Me.Label5, Me.Label3, Me.txtID, Me.C1DBG})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConSealExam_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱验封施封信息 增加"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConSealExam_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim dvSealType As New DataView()
        Dim dvWorkType As New DataView()
        Dim sqlstr, sqlSealType, sqlWorkType As String
        Me.StartPosition = FormStartPosition.CenterScreen

        Dim dvConInfo As New DataView()
        Dim sqlConInfo As String    '显示该船次所有被理过的集装箱箱号铅封号
        sqlConInfo = "SELECT CON_TALLY_DETAIL.CONTAINER_NO, CON_TALLY_DETAIL.SEALNO FROM CON_TALLY_DETAIL INNER JOIN CON_TALLY_LIST ON CON_TALLY_DETAIL.CON_TALLY_LIST_ID = CON_TALLY_LIST.CON_TALLY_LIST_ID WHERE CON_TALLY_LIST.SHIP_ID = '" & Ship_ID & "' ORDER BY CON_TALLY_DETAIL.CONTAINER_NO"
        dvConInfo = Filldata(sqlConInfo)
        Me.C1DBG.DataSource = dvConInfo
        Me.C1DBG.Columns("CONTAINER_NO").Caption = "集装箱号"
        Me.C1DBG.Columns("SEALNO").Caption = "铅封号"
        Count = dvConInfo.Count
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "共" & Count & "条记录"
        Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 78
        Me.C1DBG.Splits(0).DisplayColumns("SEALNO").Width = 80

        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

        cbContainer.DataSource = Filldata(sqlConInfo)
        cbContainer.DisplayMember = "CONTAINER_NO"
        cbContainer.ValueMember = "CONTAINER_NO"

        Dim sqlSealNo As String
        '选出本部门可用铅封号
        sqlSealNo = "select SEALNO from SEAL_RECORD where Dept_Code= '" & G_DeptCode & "' and SEAL_STATE = '2' order by SEALNO "
        dvSealNo = Filldata(sqlSealNo)
        cbNewSealNo.DataSource = dvSealNo
        cbNewSealNo.DisplayMember = "SEALNO"
        cbNewSealNo.ValueMember = "SEALNO"

        sqlSealType = "select Code_Seal_Type,Seal_Type from Code_Seal_Type  "
        dvSealType = Filldata(sqlSealType)
        cbSealType.DataSource = dvSealType
        cbSealType.DisplayMember = "Seal_Type"
        cbSealType.ValueMember = "Code_Seal_Type"

        Dim sqlOgSealCondition As String = "SELECT Code_SealCircs, SealCircs_CHI, SealCircs_Eng FROM Code_SealCircs ORDER BY Code_SealCircs"
        Dim dvOgSealCondition As New DataView()
        dvOgSealCondition = Filldata(sqlOgSealCondition)
        Me.cbOgSealCondition.DataSource = dvOgSealCondition
        Me.cbOgSealCondition.DisplayMember = "SealCircs_CHI"
        Me.cbOgSealCondition.ValueMember = "Code_SealCircs"

        sqlstr = "select * from Seal_Exam where SEAL_EXAM_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        dtpTimeEnd.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            'txtShip.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            'txtVoyage.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
            txtNo.Text = ds.Tables(0).Rows(0).Item("NO")
            cbContainer.SelectedValue = ds.Tables(0).Rows(0).Item("CONTAINER_NO")
            cbNewSealNo.Text = ds.Tables(0).Rows(0).Item("NEWSEALNO")
            cbSealType.SelectedValue = ds.Tables(0).Rows(0).Item("Seal_Type")
            txtWorkPlace.Text = ds.Tables(0).Rows(0).Item("WORK_PLACE")
            txtOriginalSealNO.Text = ds.Tables(0).Rows(0).Item("ORIGINESEALNO")
            Me.cbOgSealCondition.SelectedValue = ds.Tables(0).Rows(0).Item("ORIGINESEALNO_CONDITION")
            txtRemark.Text = ds.Tables(0).Rows(0).Item("REMARK")
            dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")
            dtpTimeEnd.Value = ds.Tables(0).Rows(0).Item("TIME_TO")
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        Me.cbContainer.SelectedValue = Me.C1DBG.Columns("CONTAINER_NO").Text
        Me.txtOriginalSealNO.Text = Me.C1DBG.Columns("SEALNO").Text
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.txtNo.Clear()
        Me.cbContainer.SelectedValue = ""
        Me.cbNewSealNo.SelectedValue = ""
        Me.txtWorkPlace.Clear()
        Me.txtOriginalSealNO.Clear()
        Me.cbOgSealCondition.SelectedValue = "00"
        Me.txtRemark.Clear()
        Me.cbSealType.SelectedValue = "0"
        Me.dtpTimeBegin.Value = Now
        Me.dtpTimeEnd.Value = Now
    End Sub
  
    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim strNewSeal, strOldSeal, strsqlNoCon, strsql, strsqlexist, strsqlstate As String
        Dim dv As New DataView()
        Dim i As Integer
        strNewSeal = UCase(Trim(cbNewSealNo.Text))      '铅封号保存全部大写
        strOldSeal = UCase(Trim(txtOriginalSealNO.Text))
        strsqlNoCon = "select * from seal_exam where SHIP_ID= '" & Ship_ID & _
            "' and ( CONTAINER_NO= '" & Trim(cbContainer.Text) & "' or NO = '" & Trim(txtNo.Text) & "')"
        strsql = "select * from SEAL_EXAM where "
        'strsqlexist = "select * from SEAL_RECORD where SEALNO = '" & strNewSeal & "'"
        'strsqlstate = "select * from SEAL_RECORD where SEALNO = '" & strNewSeal & _
        '    "' and Dept_Code= '" & G_DeptCode & "' and SEAL_STATE = '2' "
        Dim Mark As Boolean = False
        Try
            If Trim(txtNo.Text) <> "" Then
                If cbContainer.SelectedValue <> Nothing Then
                    If DateDiff(DateInterval.Minute, Me.dtpTimeBegin.Value, Me.dtpTimeEnd.Value) >= 0 Then
                        If cbNewSealNo.SelectedValue <> Nothing Or strNewSeal = "" Then
                            Mark = True
                        Else
                            For i = 0 To dvSealNo.Count - 1
                                If dvSealNo.Item(i)("SEALNO") = strNewSeal Then Exit For
                            Next
                            If i < dvSealNo.Count Then
                                Mark = True
                            Else
                                MessageBox.Show("请选择或清空新铅封号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Else
                        MessageBox.Show("开始时间应在结束时间之前。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("请选择集装箱号！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("编号不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If Mark = True Then
                If Filldata(strsqlNoCon).Count = 0 Then
                    If strNewSeal <> "" Then        '新加铅封号不为空
                        'If verifySealSingle(strNewSeal) Then        '铅封检验   在此不必了 因为都是从库表中选出的
                        dv = Filldata(strsql & " NEWSEALNO = '" & strNewSeal & "'")
                        If dv.Count = 0 Then        '新加铅封未使用过     
                            'If Filldata(strsqlexist).Count = 1 Then     '此铅封已入库   在此不必了  因为所选出的铅封号都是在库的
                            '    If Filldata(strsqlstate).Count = 1 Then '新铅封状态检查通过  在此不必了  因为所选出的铅封号都是能用的
                            '添加此施封记录，然后在库表中修改此铅封记录
                            If strOldSeal = "" Then
                                If Me.cbOgSealCondition.SelectedValue = "00" Then
                                    AddSealExam(strNewSeal, strOldSeal)         '只施封
                                    Me.Close()
                                Else
                                    MessageBox.Show("不验封时不能选原铅封情况！", "错误提示")
                                End If
                            Else
                                'If verifySealSingle(strOldSeal) Then
                                dv = Filldata(strsql & " ORIGINESEALNO = '" & strOldSeal & "'")
                                If dv.Count = 0 Then    '原铅封可以增加
                                    AddSealExam(strNewSeal, strOldSeal)     '验封后再施封
                                    Me.Close()
                                Else
                                    MessageBox.Show("已存在验封施封记录，请检查", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                                'Else
                                'MessageBox.Show("旧铅封号不合法！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                'End If
                            End If
                            '    Else
                            '        MessageBox.Show("新铅封号不在本部门或已被使用或注销！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            '    End If
                            'Else    '此铅封未入库
                            'End If
                        Else
                            MessageBox.Show("已存在施封记录，请检查", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        'Else
                        '    MessageBox.Show("新铅封号不合法！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'End If
                    Else        '新加铅封号为空,只验封不施封，输入旧铅封号
                        If strOldSeal <> "" Then
                            If cbSealType.SelectedValue = 0 Then
                                'If verifySealSingle(strOldSeal) Then    '铅封检验
                                dv = Filldata(strsql & " ORIGINESEALNO = '" & strOldSeal & "'")
                                If dv.Count = 0 Then    '原铅封可以增加
                                    AddSealExam(strNewSeal, strOldSeal)     '只验封
                                    Me.Close()
                                Else
                                    MessageBox.Show("已存在验封记录，请检查", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                                'Else
                                '    MessageBox.Show("旧铅封号不合法！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                'End If
                            Else
                                MessageBox.Show("不施封时不能选新加铅封类型！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("新旧铅封号不能全为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Else
                    MessageBox.Show("编号或箱号已被使用过，不可重复", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As System.Exception
            'MessageBox.Show(ex.Message, "意外处理", MessageBoxButtons.OK)
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddSealExam(ByVal strNewSeal As String, ByVal strOldSeal As String)
        Dim row As DataRow
        row = ds.Tables(0).NewRow()

        'row.Item("CHI_VESSEL") = Trim(txtShip.Text)
        'row.Item("VOYAGE") = Trim(txtVoyage.Text)

        row.Item("NO") = Trim(txtNo.Text)
        row.Item("CONTAINER_NO") = Trim(cbContainer.Text)
        row.Item("NEWSEALNO") = strNewSeal
        row.Item("ORIGINESEALNO") = strOldSeal
        row.Item("ORIGINESEALNO_CONDITION") = Me.cbOgSealCondition.SelectedValue
        row.Item("REMARK") = Trim(txtRemark.Text)
        row.Item("WORK_PLACE") = Trim(txtWorkPlace.Text)

        row.Item("TIME_FROM") = dtpTimeBegin.Value
        row.Item("TIME_TO") = dtpTimeEnd.Value
        row.Item("Seal_Type") = cbSealType.SelectedValue

        row.Item("Ship_ID") = Ship_ID
        row.Item("WORKTYPE") = "2"
        row.Item("Dept_Code") = G_DeptCode
        row.Item("USER_NAME") = G_User

        ds.Tables(0).Rows.Add(row)
        sqlda.Update(ds)
    End Sub

    Private Function verifySealSingle(ByVal strSeal As String) As Boolean   '大写非空字符串 COSCATO34582
        Dim i As Short
        Dim c As Char
        If Len(strSeal) >= 2 Then
            For i = Len(strSeal) To 1 Step -1
                c = Mid(strSeal, i, 1)
                If c >= "0" And c <= "9" Then

                Else
                    If c >= "A" And c <= "Z" Then
                        Exit For
                    Else
                        MessageBox.Show("存在非法字符", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                        Exit Function
                    End If
                End If
            Next

            If i >= 1 And i < Len(strSeal) Then ' 从exit for 来
                For i = i - 1 To 1 Step -1
                    c = Mid(strSeal, i, 1)
                    If (c >= "A" And c <= "Z") Or (c >= "0" And c <= "9") Then

                    Else
                        Exit For
                    End If
                Next
                If i < 1 Then
                    Return True
                    Exit Function
                Else
                    MessageBox.Show("存在非法字符", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("字符串非法", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf Len(strSeal) = 1 Then
            MessageBox.Show("字符串长度不足", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If      '为空不判断，直接返回 false
        Return False
        Exit Function
    End Function

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub cbContainer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbContainer.SelectedIndexChanged
        If TypeName(Me.cbContainer.SelectedValue) = "String" Then
            Dim i As Integer
            For i = 0 To Count - 1
                If Me.C1DBG.Columns("CONTAINER_NO").CellValue(i) = Me.cbContainer.Text Then Exit For
            Next
            If i < Count Then
                Me.C1DBG.Row = i
                Me.txtOriginalSealNO.Text = Me.C1DBG.Columns("SEALNO").Text
            End If
        End If
    End Sub

    Private Sub cbContainer_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbContainer.Leave
        Dim i As Integer
        For i = 0 To Count - 1
            If Me.C1DBG.Columns("CONTAINER_NO").CellValue(i) = Trim(Me.cbContainer.Text) Then Exit For
        Next
        If i < Count Then
            Me.C1DBG.Row = i
            Me.txtOriginalSealNO.Text = Me.C1DBG.Columns("SEALNO").Text
            Call Me.C1DBG_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub cbNewSealNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNewSealNo.Leave
        Try
            'If TypeName(cbNewSealNo.SelectedValue) <> "String" And Trim(cbNewSealNo.Text) <> "" Then
            '    Dim i As Integer
            '    For i = 0 To dvSealNo.Count - 1
            '        If dvSealNo.Item(i)("SEALNO") = Trim(Me.cbNewSealNo.Text) Then Exit For
            '    Next
            '    If i >= dvSealNo.Count Then
            '        MessageBox.Show("请选择或清空新铅封号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmConSealExam_Add_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If Me.txtNo.Focused Then
                Me.cbContainer.Focus()
            ElseIf Me.cbContainer.Focused Then
                Me.cbNewSealNo.Focus()
            ElseIf Me.cbNewSealNo.Focused Then
                Me.cbSealType.Focus()
            ElseIf Me.cbSealType.Focused Then
                Me.txtWorkPlace.Focus()
            ElseIf Me.txtWorkPlace.Focused Then
                Me.dtpTimeBegin.Focus()
            ElseIf Me.dtpTimeBegin.Focused Then
                Me.dtpTimeEnd.Focus()
            ElseIf Me.dtpTimeEnd.Focused Then
                Me.txtOriginalSealNO.Focus()
            ElseIf Me.txtOriginalSealNO.Focused Then
                Me.cbOgSealCondition.Focus()
            ElseIf Me.cbOgSealCondition.Focused Then
                Me.txtRemark.Focus()
            ElseIf Me.txtRemark.Focused Then
                Me.btSave.Focus()
            End If
        End If
    End Sub

End Class
