Imports TALLY.DBControl
Public Class FrmConSealExam_Delete
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
    Friend WithEvents cbNewSealNo As System.Windows.Forms.ComboBox
    Friend WithEvents cbContainer As System.Windows.Forms.ComboBox
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWorkPlace As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cbOgSealCondition As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConSealExam_Delete))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.cbNewSealNo = New System.Windows.Forms.ComboBox()
        Me.cbContainer = New System.Windows.Forms.ComboBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtWorkPlace = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cbOgSealCondition = New System.Windows.Forms.ComboBox()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbNewSealNo
        '
        Me.cbNewSealNo.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbNewSealNo.Location = New System.Drawing.Point(272, 54)
        Me.cbNewSealNo.MaxDropDownItems = 20
        Me.cbNewSealNo.Name = "cbNewSealNo"
        Me.cbNewSealNo.Size = New System.Drawing.Size(130, 20)
        Me.cbNewSealNo.TabIndex = 323
        '
        'cbContainer
        '
        Me.cbContainer.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbContainer.Location = New System.Drawing.Point(272, 30)
        Me.cbContainer.MaxDropDownItems = 20
        Me.cbContainer.MaxLength = 12
        Me.cbContainer.Name = "cbContainer"
        Me.cbContainer.Size = New System.Drawing.Size(130, 20)
        Me.cbContainer.TabIndex = 322
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(272, 6)
        Me.txtNo.MaxLength = 10
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(130, 21)
        Me.txtNo.TabIndex = 300
        Me.txtNo.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(198, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 321
        Me.Label2.Text = "编号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWorkPlace
        '
        Me.txtWorkPlace.Location = New System.Drawing.Point(272, 102)
        Me.txtWorkPlace.MaxLength = 50
        Me.txtWorkPlace.Name = "txtWorkPlace"
        Me.txtWorkPlace.Size = New System.Drawing.Size(130, 21)
        Me.txtWorkPlace.TabIndex = 302
        Me.txtWorkPlace.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(198, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 320
        Me.Label1.Text = "工作地点"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(302, 292)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 309
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(234, 292)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 308
        Me.btSave.Text = "确认"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(202, 238)
        Me.txtRemark.MaxLength = 100
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(200, 46)
        Me.txtRemark.TabIndex = 310
        Me.txtRemark.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(198, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 319
        Me.Label10.Text = "备注"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(198, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 318
        Me.Label9.Text = "原铅封情况"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(272, 150)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeEnd.TabIndex = 304
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(198, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 317
        Me.Label8.Text = "结束时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(272, 126)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeBegin.TabIndex = 303
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(198, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 316
        Me.Label7.Text = "开始时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSealType
        '
        Me.cbSealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSealType.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbSealType.Location = New System.Drawing.Point(272, 78)
        Me.cbSealType.Name = "cbSealType"
        Me.cbSealType.Size = New System.Drawing.Size(130, 20)
        Me.cbSealType.TabIndex = 301
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(198, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 315
        Me.Label6.Text = "新铅封类型"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOriginalSealNO
        '
        Me.txtOriginalSealNO.Location = New System.Drawing.Point(272, 174)
        Me.txtOriginalSealNO.MaxLength = 20
        Me.txtOriginalSealNO.Name = "txtOriginalSealNO"
        Me.txtOriginalSealNO.Size = New System.Drawing.Size(130, 21)
        Me.txtOriginalSealNO.TabIndex = 305
        Me.txtOriginalSealNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(198, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 314
        Me.Label4.Text = "原铅封号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(198, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 313
        Me.Label5.Text = "新铅封号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(198, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 312
        Me.Label3.Text = "集装箱号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(190, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 311
        Me.txtID.Text = ""
        Me.txtID.Visible = False
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
        Me.C1DBG.TabIndex = 307
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'cbOgSealCondition
        '
        Me.cbOgSealCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOgSealCondition.Location = New System.Drawing.Point(272, 198)
        Me.cbOgSealCondition.Name = "cbOgSealCondition"
        Me.cbOgSealCondition.Size = New System.Drawing.Size(130, 20)
        Me.cbOgSealCondition.TabIndex = 324
        '
        'FrmConSealExam_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(412, 323)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbOgSealCondition, Me.cbNewSealNo, Me.cbContainer, Me.txtNo, Me.Label2, Me.txtWorkPlace, Me.Label1, Me.btQuit, Me.btSave, Me.txtRemark, Me.Label10, Me.Label9, Me.dtpTimeEnd, Me.Label8, Me.dtpTimeBegin, Me.Label7, Me.cbSealType, Me.Label6, Me.txtOriginalSealNO, Me.Label4, Me.Label5, Me.Label3, Me.txtID, Me.C1DBG})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConSealExam_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱验封施封信息 删除"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConSealExam_Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 80
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

        Me.txtNo.Enabled = False
        Me.cbContainer.Enabled = False

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
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

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MessageBox.Show("确认要删除吗？", "警告提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                '记录操作日志
                Call OperateHistory(G_DeptName, Now, G_User, "删除", "Seal_Exam", Trim(txtID.Text), "SEAL_EXAM_ID")
                '删除此验封施封记录
                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)
                Me.Close()
            End If
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

End Class
