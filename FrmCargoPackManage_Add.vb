Imports TALLY.DBControl
Public Class FrmCargoPackManage_Add
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim row As DataRow
    Dim dvCodeGoods As New DataView()
    Dim sqlCodeGoods As String

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
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbGoodsCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtRecedeAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtPackNum As System.Windows.Forms.TextBox
    Friend WithEvents txtLeadAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtMargin As System.Windows.Forms.TextBox
    Friend WithEvents txtTeam As System.Windows.Forms.TextBox
    Friend WithEvents dtpTimeLead As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLeader As System.Windows.Forms.TextBox
    Friend WithEvents txtProvider As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtRecedeAmount = New System.Windows.Forms.TextBox
        Me.txtPackNum = New System.Windows.Forms.TextBox
        Me.txtLeadAmount = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbGoodsCode = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtMargin = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTeam = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpTimeEnd = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.dtpTimeLead = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLeader = New System.Windows.Forms.TextBox
        Me.txtProvider = New System.Windows.Forms.TextBox
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtRecedeAmount
        '
        Me.txtRecedeAmount.Location = New System.Drawing.Point(82, 138)
        Me.txtRecedeAmount.MaxLength = 10
        Me.txtRecedeAmount.Name = "txtRecedeAmount"
        Me.txtRecedeAmount.Size = New System.Drawing.Size(128, 21)
        Me.txtRecedeAmount.TabIndex = 332
        Me.txtRecedeAmount.Text = ""
        '
        'txtPackNum
        '
        Me.txtPackNum.Location = New System.Drawing.Point(82, 160)
        Me.txtPackNum.MaxLength = 10
        Me.txtPackNum.Name = "txtPackNum"
        Me.txtPackNum.Size = New System.Drawing.Size(128, 21)
        Me.txtPackNum.TabIndex = 333
        Me.txtPackNum.Text = ""
        '
        'txtLeadAmount
        '
        Me.txtLeadAmount.Location = New System.Drawing.Point(82, 116)
        Me.txtLeadAmount.MaxLength = 10
        Me.txtLeadAmount.Name = "txtLeadAmount"
        Me.txtLeadAmount.Size = New System.Drawing.Size(128, 21)
        Me.txtLeadAmount.TabIndex = 331
        Me.txtLeadAmount.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 118)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 20)
        Me.Label19.TabIndex = 344
        Me.Label19.Text = "领数"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 228)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 20)
        Me.Label18.TabIndex = 341
        Me.Label18.Text = "发放人"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 206)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 20)
        Me.Label14.TabIndex = 340
        Me.Label14.Text = "领用人"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGoodsCode.Location = New System.Drawing.Point(82, 6)
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(128, 20)
        Me.cbGoodsCode.TabIndex = 325
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 20)
        Me.Label17.TabIndex = 339
        Me.Label17.Text = "提单"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMargin
        '
        Me.txtMargin.Location = New System.Drawing.Point(82, 182)
        Me.txtMargin.MaxLength = 10
        Me.txtMargin.Name = "txtMargin"
        Me.txtMargin.Size = New System.Drawing.Size(128, 21)
        Me.txtMargin.TabIndex = 334
        Me.txtMargin.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 184)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 338
        Me.Label15.Text = "差额"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTeam
        '
        Me.txtTeam.Location = New System.Drawing.Point(82, 28)
        Me.txtTeam.MaxLength = 20
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(128, 21)
        Me.txtTeam.TabIndex = 326
        Me.txtTeam.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 337
        Me.Label9.Text = "灌包班组"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(82, 72)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(128, 21)
        Me.dtpTimeEnd.TabIndex = 329
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 336
        Me.Label8.Text = "作业止时"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(82, 50)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(128, 21)
        Me.dtpTimeBegin.TabIndex = 328
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 335
        Me.Label7.Text = "作业起时"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 162)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 20)
        Me.Label20.TabIndex = 343
        Me.Label20.Text = "灌包数"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 140)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 20)
        Me.Label21.TabIndex = 342
        Me.Label21.Text = "退数"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 345
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'dtpTimeLead
        '
        Me.dtpTimeLead.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeLead.Location = New System.Drawing.Point(82, 94)
        Me.dtpTimeLead.Name = "dtpTimeLead"
        Me.dtpTimeLead.Size = New System.Drawing.Size(128, 21)
        Me.dtpTimeLead.TabIndex = 346
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 347
        Me.Label1.Text = "领退时间"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLeader
        '
        Me.txtLeader.Location = New System.Drawing.Point(82, 204)
        Me.txtLeader.MaxLength = 10
        Me.txtLeader.Name = "txtLeader"
        Me.txtLeader.Size = New System.Drawing.Size(128, 21)
        Me.txtLeader.TabIndex = 348
        Me.txtLeader.Text = ""
        '
        'txtProvider
        '
        Me.txtProvider.Location = New System.Drawing.Point(82, 226)
        Me.txtProvider.MaxLength = 10
        Me.txtProvider.Name = "txtProvider"
        Me.txtProvider.Size = New System.Drawing.Size(128, 21)
        Me.txtProvider.TabIndex = 349
        Me.txtProvider.Text = ""
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(142, 254)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 352
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(76, 254)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 351
        Me.btSave.Text = "确认"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(10, 254)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 24)
        Me.btnClear.TabIndex = 350
        Me.btnClear.Text = "清空"
        '
        'FrmCargoPackManage_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(216, 281)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtProvider)
        Me.Controls.Add(Me.txtLeader)
        Me.Controls.Add(Me.dtpTimeLead)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtRecedeAmount)
        Me.Controls.Add(Me.txtPackNum)
        Me.Controls.Add(Me.txtLeadAmount)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbGoodsCode)
        Me.Controls.Add(Me.txtMargin)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTeam)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpTimeEnd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpTimeBegin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoPackManage_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "散货袋皮管理信息 增加"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargoPackManage_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String

        'sqlCodeGoods = "SELECT CARGO_GOODS.SHIP_ID, CARGO_GOODS.CODE_GOODS, CODEGOODS.GOODS FROM CARGO_GOODS LEFT OUTER JOIN CODEGOODS ON CARGO_GOODS.CODE_GOODS = CODEGOODS.CODE where CARGO_GOODS.SHIP_ID = '" & Ship_ID & "'"
        ' 改为提单
        sqlCodeGoods = "SELECT BLNO FROM CARGO_GOODS  where SHIP_ID = '" & Ship_ID & "'"
        dvCodeGoods = Filldata(sqlCodeGoods)
        cbGoodsCode.DataSource = dvCodeGoods
        cbGoodsCode.DisplayMember = "BLNO"
        cbGoodsCode.ValueMember = "BLNO"

        sqlstr = "select * from CARGO_PACK_MANAGE where PACK_MANAGE_ID =" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        dtpTimeEnd.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        dtpTimeLead.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("PACK_MANAGE_ID")
            txtTeam.Text = ds.Tables(0).Rows(0).Item("TEAM")
            txtLeader.Text = ds.Tables(0).Rows(0).Item("BAG_LEADER")
            txtProvider.Text = ds.Tables(0).Rows(0).Item("PROVIDER")

            If Not IsDBNull(ds.Tables(0).Rows(0).Item("LEAD_AMOUNT")) Then
                txtLeadAmount.Text = ds.Tables(0).Rows(0).Item("LEAD_AMOUNT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("RECEDE_AMOUNT")) Then
                txtRecedeAmount.Text = ds.Tables(0).Rows(0).Item("RECEDE_AMOUNT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("PACK_NUMBER")) Then
                txtPackNum.Text = ds.Tables(0).Rows(0).Item("PACK_NUMBER")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("MARGIN")) Then
                txtMargin.Text = ds.Tables(0).Rows(0).Item("MARGIN")
            End If

            dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")
            dtpTimeEnd.Value = ds.Tables(0).Rows(0).Item("TIME_TO")
            dtpTimeLead.Value = ds.Tables(0).Rows(0).Item("TIME_LEAD_RECEDE")

            cbGoodsCode.SelectedValue = ds.Tables(0).Rows(0).Item("GOODS_CODE")
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlExist As String
        sqlExist = "select * from CARGO_PACK_MANAGE where SHIP_ID = '" & Ship_ID & "' and Team = '" & Trim(txtTeam.Text) & _
        "' and not ( datediff(mi, '" & dtpTimeEnd.Value & "' ,time_from) >= 0 or datediff(mi,time_to, '" & dtpTimeBegin.Value & "' ) >= 0 )"
        Try
            If dvCodeGoods.Count = 0 Then
                MessageBox.Show("该船次的货物情况尚未录入，无法执行操作。", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Exit Sub
            End If
            If Trim(txtTeam.Text) <> "" And Trim(txtLeader.Text) <> "" Then
                If DateDiff(DateInterval.Minute, dtpTimeBegin.Value, dtpTimeEnd.Value) > 0 Then
                    row = ds.Tables(0).NewRow
                    If SetNumValue("LEAD_AMOUNT", txtLeadAmount.Text, "领数") = False Then    '输入不合法，
                        Exit Sub
                    ElseIf SetNumValue("RECEDE_AMOUNT", txtRecedeAmount.Text, "退数") = False Then
                        Exit Sub
                    ElseIf SetNumValue("PACK_NUMBER", txtPackNum.Text, "灌包数") = False Then
                        Exit Sub
                    ElseIf SetNumValue("MARGIN", txtMargin.Text, "差额") = False Then
                        Exit Sub
                    End If
                    row.Item("TEAM") = Trim(txtTeam.Text)
                    row.Item("BAG_LEADER") = Trim(txtLeader.Text)
                    row.Item("PROVIDER") = Trim(txtProvider.Text)
                    row.Item("TIME_FROM") = dtpTimeBegin.Value
                    row.Item("TIME_TO") = dtpTimeEnd.Value
                    row.Item("TIME_LEAD_RECEDE") = dtpTimeLead.Value
                    row.Item("GOODS_CODE") = cbGoodsCode.SelectedValue

                    row.Item("DEPT_CODE") = FrmCargoPackManage.strCodeDept
                    row.Item("SHIP_ID") = Ship_ID
                    row.Item("USER_NAME") = G_User
                    If Filldata(sqlExist).Count = 0 Then
                        ds.Tables(0).Rows.Add(row)
                        sqlda.Update(ds)
                        Me.Close()
                    Else
                        MessageBox.Show("同一船次 同一班组 在 同一作业时段 不能重复领用。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("作业起时间应在止时间之前。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("请输入 灌包班组 和 领用人。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
  
    End Sub

    Private Function SetNumValue(ByVal strNumColumn As String, ByVal strNumValue As String, Optional ByVal message As String = "数据") As Boolean
        Dim flag As Boolean = True
        If Trim(strNumValue) <> "" Then     '
            If IsNumeric(Trim(strNumValue)) Then
                row.Item(strNumColumn) = Trim(strNumValue)
            Else
                MessageBox.Show(message + "应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = False
            End If
        Else    '此列留空
        End If
        Return flag
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.txtTeam.Clear()
        Me.txtLeadAmount.Clear()
        Me.txtRecedeAmount.Clear()
        Me.txtPackNum.Clear()
        Me.txtMargin.Clear()
        Me.txtLeader.Clear()
        Me.txtProvider.Clear()
        dtpTimeBegin.Value = Now
        dtpTimeEnd.Value = Now
        dtpTimeLead.Value = Now
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub cbGoodsCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbGoodsCode.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTeam.Focus()
        End If
    End Sub

    Private Sub txtTeam_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTeam.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpTimeBegin.Focus()
        End If
    End Sub

    Private Sub dtpTimeBegin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpTimeBegin.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpTimeEnd.Focus()
        End If
    End Sub

    Private Sub dtpTimeEnd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpTimeEnd.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpTimeLead.Focus()
        End If
    End Sub

    Private Sub dtpTimeLead_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpTimeLead.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtLeadAmount.Focus()
        End If
    End Sub

    Private Sub txtLeadAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLeadAmount.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtRecedeAmount.Focus()
        End If
    End Sub

    Private Sub txtRecedeAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRecedeAmount.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPackNum.Focus()
        End If
    End Sub

    Private Sub txtPackNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPackNum.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtMargin.Focus()
        End If
    End Sub

    Private Sub txtMargin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMargin.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtLeader.Focus()
        End If
    End Sub

    Private Sub txtLeader_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLeader.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtProvider.Focus()
        End If
    End Sub

    Private Sub txtProvider_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProvider.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btSave.Focus()
        End If
    End Sub

    Private Sub btSave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btSave.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Me.btSave_Click(sender, e)
        End If
    End Sub

End Class
