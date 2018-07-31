Imports TALLY.DBControl
Public Class FrmCargoGoods_Delete
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dwCompany As New DataView()
    Dim dwBerthNo As New DataView()

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
    Friend WithEvents cbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents cbBerthNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbCodeGoods As System.Windows.Forms.ComboBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtStandWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbCompany = New System.Windows.Forms.ComboBox()
        Me.cbBerthNo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCodeGoods = New System.Windows.Forms.ComboBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtStandWeight = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbCompany
        '
        Me.cbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCompany.Location = New System.Drawing.Point(70, 96)
        Me.cbCompany.Name = "cbCompany"
        Me.cbCompany.Size = New System.Drawing.Size(130, 20)
        Me.cbCompany.TabIndex = 208
        '
        'cbBerthNo
        '
        Me.cbBerthNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBerthNo.Location = New System.Drawing.Point(70, 66)
        Me.cbBerthNo.Name = "cbBerthNo"
        Me.cbBerthNo.Size = New System.Drawing.Size(130, 20)
        Me.cbBerthNo.TabIndex = 207
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 206
        Me.Label3.Text = "泊位号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbCodeGoods
        '
        Me.cbCodeGoods.Location = New System.Drawing.Point(70, 36)
        Me.cbCodeGoods.MaxDropDownItems = 15
        Me.cbCodeGoods.MaxLength = 12
        Me.cbCodeGoods.Name = "cbCodeGoods"
        Me.cbCodeGoods.Size = New System.Drawing.Size(130, 20)
        Me.cbCodeGoods.TabIndex = 197
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(106, 186)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 200
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btSave.Location = New System.Drawing.Point(38, 186)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 199
        Me.btSave.Text = "确认"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(70, 126)
        Me.txtWeight.MaxLength = 16
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.TabIndex = 198
        Me.txtWeight.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 205
        Me.Label5.Text = "总重量"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNo
        '
        Me.txtBillNo.Location = New System.Drawing.Point(70, 6)
        Me.txtBillNo.MaxLength = 20
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNo.TabIndex = 196
        Me.txtBillNo.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 204
        Me.Label4.Text = "货名代码"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 203
        Me.Label2.Text = "装卸公司"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 202
        Me.Label1.Text = "提单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 201
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(170, 128)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(30, 20)
        Me.Label35.TabIndex = 494
        Me.Label35.Text = "公斤"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(169, 158)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 20)
        Me.Label28.TabIndex = 509
        Me.Label28.Text = "公斤"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStandWeight
        '
        Me.txtStandWeight.Location = New System.Drawing.Point(69, 156)
        Me.txtStandWeight.MaxLength = 10
        Me.txtStandWeight.Name = "txtStandWeight"
        Me.txtStandWeight.TabIndex = 507
        Me.txtStandWeight.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(7, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 20)
        Me.Label10.TabIndex = 508
        Me.Label10.Text = "标准件重"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCargoGoods_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(206, 215)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label28, Me.txtStandWeight, Me.Label10, Me.Label35, Me.cbCompany, Me.cbBerthNo, Me.Label3, Me.cbCodeGoods, Me.btQuit, Me.btSave, Me.txtWeight, Me.Label5, Me.txtBillNo, Me.Label4, Me.Label2, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoGoods_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "散货货物情况信息 删除"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargoGoods_Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dwCodeGoods As New DataView()
        Dim sqlCodeGoods, sqlCompany, sqlBerthNo As String
        Try
            sqlCompany = "SELECT Code, DepartMent FROM CodeCompany order by department"
            dwCompany = Filldata(sqlCompany)
            sqlBerthNo = "SELECT BERTH_ID, CODE_BERTH, NAME_BERTH, COMPANY, Code FROM CODE_BERTH LEFT OUTER JOIN CodeCompany ON COMPANY = DepartMent ORDER BY LEN(CODE_BERTH), CODE_BERTH"
            dwBerthNo = Filldata(sqlBerthNo)

            cbCompany.DataSource = dwCompany
            cbCompany.DisplayMember = "DepartMent"
            cbCompany.ValueMember = "Code"

            cbBerthNo.DataSource = dwBerthNo
            cbBerthNo.DisplayMember = "NAME_BERTH"
            cbBerthNo.ValueMember = "CODE_BERTH"

            sqlstr = "select * from CARGO_GOODS where CARGO_GOODS_ID =" & ID & ""
            dw = Updatedata(sqlda, sqlstr, ds)

            If dw.Count > 0 Then
                txtID.Text = ds.Tables(0).Rows(0).Item("CARGO_GOODS_ID")
                Me.txtBillNo.Text = ds.Tables(0).Rows(0).Item("BLNO")
                Me.cbCodeGoods.Text = ds.Tables(0).Rows(0).Item("CODE_GOODS")
                Me.cbBerthNo.SelectedValue = ds.Tables(0).Rows(0).Item("BERTHNO")
                Me.cbCompany.SelectedValue = ds.Tables(0).Rows(0).Item("HIDE_COMPANY")
                If IsNumeric(ds.Tables(0).Rows(0).Item("TOTAL_WEIGHT")) Then
                    Me.txtWeight.Text = ds.Tables(0).Rows(0).Item("TOTAL_WEIGHT")
                End If
                If IsNumeric(ds.Tables(0).Rows(0).Item("StandsWeight")) Then
                    Me.txtStandWeight.Text = ds.Tables(0).Rows(0).Item("StandsWeight")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MessageBox.Show("确认要删除吗？", "警告提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                '记录操作日志
                Call OperateHistory(G_DeptName, Now, G_User, "删除", "CARGO_GOODS", Trim(txtID.Text), "CARGO_GOODS_ID")
                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)
            End If
            Me.Close()
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
