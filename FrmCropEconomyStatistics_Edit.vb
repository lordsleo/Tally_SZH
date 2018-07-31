Imports TALLY.DBControl
Public Class FrmCropEconomyStatistics_Edit
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()

    Dim sqlItem As String
    Dim dvItem As New DataView()

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler dtpDate.KeyUp, AddressOf FrmCropEconomyStatistics_Add_KeyUp
        AddHandler cbItem.KeyUp, AddressOf FrmCropEconomyStatistics_Add_KeyUp
        AddHandler cbUnit.KeyUp, AddressOf FrmCropEconomyStatistics_Add_KeyUp
        AddHandler txtYearPlan.KeyUp, AddressOf FrmCropEconomyStatistics_Add_KeyUp
        AddHandler txtMonthComp.KeyUp, AddressOf FrmCropEconomyStatistics_Add_KeyUp
        AddHandler txtTotalComp.KeyUp, AddressOf FrmCropEconomyStatistics_Add_KeyUp
        AddHandler txtLastComp.KeyUp, AddressOf FrmCropEconomyStatistics_Add_KeyUp
        AddHandler txtIncrease.KeyUp, AddressOf FrmCropEconomyStatistics_Add_KeyUp
        AddHandler txtComplete.KeyUp, AddressOf FrmCropEconomyStatistics_Add_KeyUp
        AddHandler txtGrade.KeyUp, AddressOf FrmCropEconomyStatistics_Add_KeyUp
        AddHandler txtRemark.KeyUp, AddressOf FrmCropEconomyStatistics_Add_KeyUp
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
    Public WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Public WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents txtComplete As System.Windows.Forms.TextBox
    Friend WithEvents txtIncrease As System.Windows.Forms.TextBox
    Friend WithEvents txtLastComp As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalComp As System.Windows.Forms.TextBox
    Friend WithEvents txtMonthComp As System.Windows.Forms.TextBox
    Friend WithEvents txtYearPlan As System.Windows.Forms.TextBox
    Friend WithEvents cbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents cbItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.txtComplete = New System.Windows.Forms.TextBox()
        Me.txtIncrease = New System.Windows.Forms.TextBox()
        Me.txtLastComp = New System.Windows.Forms.TextBox()
        Me.txtTotalComp = New System.Windows.Forms.TextBox()
        Me.txtMonthComp = New System.Windows.Forms.TextBox()
        Me.txtYearPlan = New System.Windows.Forms.TextBox()
        Me.cbUnit = New System.Windows.Forms.ComboBox()
        Me.cbItem = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(92, 6)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(158, 21)
        Me.dtpDate.TabIndex = 382
        Me.dtpDate.Value = New Date(2004, 3, 25, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 20)
        Me.Label10.TabIndex = 380
        Me.Label10.Text = "选择年月"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 396
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(132, 342)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 395
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(64, 342)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 394
        Me.btSave.Text = "确认"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(10, 264)
        Me.txtRemark.MaxLength = 200
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(238, 70)
        Me.txtRemark.TabIndex = 392
        Me.txtRemark.Text = ""
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(92, 220)
        Me.txtGrade.MaxLength = 20
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(158, 21)
        Me.txtGrade.TabIndex = 391
        Me.txtGrade.Text = ""
        '
        'txtComplete
        '
        Me.txtComplete.Location = New System.Drawing.Point(92, 196)
        Me.txtComplete.MaxLength = 20
        Me.txtComplete.Name = "txtComplete"
        Me.txtComplete.Size = New System.Drawing.Size(158, 21)
        Me.txtComplete.TabIndex = 390
        Me.txtComplete.Text = ""
        '
        'txtIncrease
        '
        Me.txtIncrease.Location = New System.Drawing.Point(92, 172)
        Me.txtIncrease.MaxLength = 20
        Me.txtIncrease.Name = "txtIncrease"
        Me.txtIncrease.Size = New System.Drawing.Size(158, 21)
        Me.txtIncrease.TabIndex = 389
        Me.txtIncrease.Text = ""
        '
        'txtLastComp
        '
        Me.txtLastComp.Location = New System.Drawing.Point(92, 148)
        Me.txtLastComp.MaxLength = 20
        Me.txtLastComp.Name = "txtLastComp"
        Me.txtLastComp.Size = New System.Drawing.Size(158, 21)
        Me.txtLastComp.TabIndex = 388
        Me.txtLastComp.Text = ""
        '
        'txtTotalComp
        '
        Me.txtTotalComp.Location = New System.Drawing.Point(92, 124)
        Me.txtTotalComp.MaxLength = 20
        Me.txtTotalComp.Name = "txtTotalComp"
        Me.txtTotalComp.Size = New System.Drawing.Size(158, 21)
        Me.txtTotalComp.TabIndex = 387
        Me.txtTotalComp.Text = ""
        '
        'txtMonthComp
        '
        Me.txtMonthComp.Location = New System.Drawing.Point(92, 100)
        Me.txtMonthComp.MaxLength = 20
        Me.txtMonthComp.Name = "txtMonthComp"
        Me.txtMonthComp.Size = New System.Drawing.Size(158, 21)
        Me.txtMonthComp.TabIndex = 386
        Me.txtMonthComp.Text = ""
        '
        'txtYearPlan
        '
        Me.txtYearPlan.Location = New System.Drawing.Point(92, 76)
        Me.txtYearPlan.MaxLength = 20
        Me.txtYearPlan.Name = "txtYearPlan"
        Me.txtYearPlan.Size = New System.Drawing.Size(158, 21)
        Me.txtYearPlan.TabIndex = 385
        Me.txtYearPlan.Text = ""
        '
        'cbUnit
        '
        Me.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnit.Location = New System.Drawing.Point(92, 54)
        Me.cbUnit.MaxDropDownItems = 20
        Me.cbUnit.Name = "cbUnit"
        Me.cbUnit.Size = New System.Drawing.Size(158, 20)
        Me.cbUnit.TabIndex = 384
        '
        'cbItem
        '
        Me.cbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbItem.Location = New System.Drawing.Point(92, 30)
        Me.cbItem.MaxDropDownItems = 20
        Me.cbItem.Name = "cbItem"
        Me.cbItem.Size = New System.Drawing.Size(158, 20)
        Me.cbItem.TabIndex = 383
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(6, 244)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 20)
        Me.Label11.TabIndex = 381
        Me.Label11.Text = "备注"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 379
        Me.Label9.Text = "评分"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 378
        Me.Label8.Text = "累计完成率(%)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 377
        Me.Label7.Text = "同比增长率(%)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 376
        Me.Label6.Text = "去年同期累计"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 375
        Me.Label5.Text = "累计完成"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 374
        Me.Label4.Text = "本月完成"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 373
        Me.Label3.Text = "年度计划"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 372
        Me.Label2.Text = "选择计算单位"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 371
        Me.Label1.Text = "选择项目"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCropEconomyStatistics_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(258, 371)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpDate, Me.Label10, Me.txtID, Me.btQuit, Me.btSave, Me.txtRemark, Me.txtGrade, Me.txtComplete, Me.txtIncrease, Me.txtLastComp, Me.txtTotalComp, Me.txtMonthComp, Me.txtYearPlan, Me.cbUnit, Me.cbItem, Me.Label11, Me.Label9, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCropEconomyStatistics_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "局经济效果指标统计表信息 修改"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCropEconomyStatistics_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dw As New DataView()
            Dim sqlstr As String
            sqlstr = "select * from REPORT_ECONOMY_TARGET where REPORT_ECONOMY_TARGET_ID =" & ID & ""
            dw = Updatedata(sqlda, sqlstr, ds)

            'sqlItem = "SELECT CODE_ITEM, ITEM FROM CODE_ECONOMY_ITEM ORDER BY CODE_ITEM"
            'dvItem = Filldata(sqlItem)
            'Me.cbItem.DataSource = dvItem
            'Me.cbItem.DisplayMember = "ITEM"
            'Me.cbItem.ValueMember = "CODE_ITEM"

            Dim sqlUnit As String = "SELECT CODE_UNIT, UNIT FROM CODE_ECONOMY_UNIT ORDER BY CODE_UNIT"
            Dim dvUnit As New DataView()
            dvUnit = Filldata(sqlUnit)
            Me.cbUnit.DataSource = dvUnit
            Me.cbUnit.DisplayMember = "UNIT"
            Me.cbUnit.ValueMember = "CODE_UNIT"

            dtpDate.Format = DateTimePickerFormat.Custom
            dtpDate.CustomFormat = "yyyy年 MM月"
            'dtpDate.Value = Now
            dtpDate.Enabled = False
            If dw.Count > 0 Then
                txtID.Text = ds.Tables(0).Rows(0).Item("REPORT_ECONOMY_TARGET_ID")
                dtpDate.Value = ds.Tables(0).Rows(0).Item("YEARMONTH")
                Me.cbUnit.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_UNIT")

                If IsNumeric(ds.Tables(0).Rows(0).Item("PLAN_YEAR")) Then
                    Me.txtYearPlan.Text = ds.Tables(0).Rows(0).Item("PLAN_YEAR")
                End If
                If IsNumeric(ds.Tables(0).Rows(0).Item("COMPLETE_YEARMONTH")) Then
                    Me.txtMonthComp.Text = ds.Tables(0).Rows(0).Item("COMPLETE_YEARMONTH")
                End If
                If IsNumeric(ds.Tables(0).Rows(0).Item("COMPLETE_YEAR")) Then
                    Me.txtTotalComp.Text = ds.Tables(0).Rows(0).Item("COMPLETE_YEAR")
                End If
                If IsNumeric(ds.Tables(0).Rows(0).Item("COMPLETE_LAST")) Then
                    Me.txtLastComp.Text = ds.Tables(0).Rows(0).Item("COMPLETE_LAST")
                End If
                If IsNumeric(ds.Tables(0).Rows(0).Item("REDUCE_ADD")) Then
                    Me.txtIncrease.Text = ds.Tables(0).Rows(0).Item("REDUCE_ADD")
                End If
                If IsNumeric(ds.Tables(0).Rows(0).Item("COMPLETEPERCENT")) Then
                    Me.txtComplete.Text = ds.Tables(0).Rows(0).Item("COMPLETEPERCENT")
                End If
                If IsNumeric(ds.Tables(0).Rows(0).Item("GRADE")) Then
                    Me.txtGrade.Text = ds.Tables(0).Rows(0).Item("GRADE")
                End If
                Me.txtRemark.Text = ds.Tables(0).Rows(0).Item("DEMO")

                sqlItem = "SELECT CODE_ITEM, ITEM FROM CODE_ECONOMY_ITEM where code_item not in (select code_item from REPORT_ECONOMY_TARGET where datediff(yy,'" & dtpDate.Value & "',YEARMONTH)=0 and datediff(mm,'" & dtpDate.Value & "',YEARMONTH)=0) or code_item='" & ds.Tables(0).Rows(0).Item("CODE_ITEM") & "' ORDER BY CODE_ITEM"
                dvItem = Filldata(sqlItem)
                Me.cbItem.DataSource = dvItem
                Me.cbItem.DisplayMember = "ITEM"
                Me.cbItem.ValueMember = "CODE_ITEM"
                Me.cbItem.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_ITEM")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function SetNumValue(ByVal strNumColumn As String, ByVal strNumValue As String, Optional ByVal message As String = "数据") As Boolean
        Dim flag As Boolean = True
        If Trim(strNumValue) <> "" Then     '
            If IsNumeric(Trim(strNumValue)) Then
                ds.Tables(0).Rows(0).Item(strNumColumn) = Trim(strNumValue)
            Else
                MessageBox.Show(message + "应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = False
            End If
        Else    '此列留空
        End If
        Return flag
    End Function

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        '时间和项目不能重复，但这里不用检验
        Try
            If SetNumValue("PLAN_YEAR", txtYearPlan.Text, "年度计划") = False Then    '输入不合法，不能更新
                txtYearPlan.Focus()
                txtYearPlan.SelectAll()
                Exit Sub
            ElseIf SetNumValue("COMPLETE_YEARMONTH", txtMonthComp.Text, "本月完成") = False Then
                txtMonthComp.Focus()
                txtMonthComp.SelectAll()
                Exit Sub
            ElseIf SetNumValue("COMPLETE_YEAR", txtTotalComp.Text, "累计完成") = False Then
                txtTotalComp.Focus()
                txtTotalComp.SelectAll()
                Exit Sub
            ElseIf SetNumValue("COMPLETE_LAST", txtLastComp.Text, "去年同期累计") = False Then
                txtLastComp.Focus()
                txtLastComp.SelectAll()
                Exit Sub
            ElseIf SetNumValue("REDUCE_ADD", txtIncrease.Text, "同比增长率") = False Then
                txtIncrease.Focus()
                txtIncrease.SelectAll()
                Exit Sub
            ElseIf SetNumValue("COMPLETEPERCENT", txtComplete.Text, "累计完成率") = False Then
                txtComplete.Focus()
                txtComplete.SelectAll()
                Exit Sub
            ElseIf SetNumValue("GRADE", txtGrade.Text, "评分") = False Then
                txtGrade.Focus()
                txtGrade.SelectAll()
                Exit Sub
            End If
            ds.Tables(0).Rows(0).Item("YEARMONTH") = Me.dtpDate.Value
            ds.Tables(0).Rows(0).Item("CODE_ITEM") = Me.cbItem.SelectedValue
            ds.Tables(0).Rows(0).Item("CODE_UNIT") = Me.cbUnit.SelectedValue
            ds.Tables(0).Rows(0).Item("DEMO") = Me.txtRemark.Text

            If MessageBox.Show("确定要修改吗？", "警告提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                '记录操作日志
                Call OperateHistory(G_DeptName, Now, G_User, "修改", "REPORT_ECONOMY_TARGET", Trim(txtID.Text), "REPORT_ECONOMY_TARGET_ID")
                sqlda.Update(ds)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbItem_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbItem.Leave
        Try
            Select Case Me.cbItem.SelectedValue
                Case "011"
                    Me.cbUnit.SelectedValue = "01"
                Case "012"
                    Me.cbUnit.SelectedValue = "01"
                Case "013"
                    Me.cbUnit.SelectedValue = "02"
                Case "014"
                    Me.cbUnit.SelectedValue = "02"
                Case "021"
                    Me.cbUnit.SelectedValue = "03"
                Case "031"
                    Me.cbUnit.SelectedValue = "03"
                Case "041"
                    Me.cbUnit.SelectedValue = "04"
                Case "042"
                    Me.cbUnit.SelectedValue = "00"
                Case "043"
                    Me.cbUnit.SelectedValue = "00"
                Case "051"
                    Me.cbUnit.SelectedValue = "04"
                Case "052"
                    Me.cbUnit.SelectedValue = "00"
                Case "053"
                    Me.cbUnit.SelectedValue = "00"
                Case "061"
                    Me.cbUnit.SelectedValue = "05"
                Case "062"
                    Me.cbUnit.SelectedValue = "06"
                Case "071"
                    Me.cbUnit.SelectedValue = "05"
                Case "072"
                    Me.cbUnit.SelectedValue = "06"
                Case "073"
                    Me.cbUnit.SelectedValue = "06"
                Case "074"
                    Me.cbUnit.SelectedValue = "08"
                Case "081"
                    Me.cbUnit.SelectedValue = "07"
                Case "082"
                    Me.cbUnit.SelectedValue = "06"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmCropEconomyStatistics_Add_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If Me.dtpDate.Focused Then
                Me.cbItem.Focus()
            ElseIf Me.cbItem.Focused Then
                Me.cbUnit.Focus()
            ElseIf Me.cbUnit.Focused Then
                Me.txtYearPlan.Focus()
            ElseIf Me.txtYearPlan.Focused Then
                Me.txtMonthComp.Focus()
            ElseIf Me.txtMonthComp.Focused Then
                Me.txtTotalComp.Focus()
            ElseIf Me.txtTotalComp.Focused Then
                Me.txtLastComp.Focus()
            ElseIf Me.txtLastComp.Focused Then
                Me.txtIncrease.Focus()
            ElseIf Me.txtIncrease.Focused Then
                Me.txtComplete.Focus()
            ElseIf Me.txtComplete.Focused Then
                Me.txtGrade.Focus()
            ElseIf Me.txtGrade.Focused Then
                Me.txtRemark.Focus()
            ElseIf Me.txtRemark.Focused Then
                Me.btSave.Focus()
            End If
        End If
    End Sub
End Class
