Imports TALLY.DBControl
Public Class FrmCargoGoods_Add
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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbCodeGoods As System.Windows.Forms.ComboBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents cbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents cbBerthNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtStandWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbCodeGoods = New System.Windows.Forms.ComboBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbBerthNo = New System.Windows.Forms.ComboBox()
        Me.cbCompany = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtStandWeight = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbCodeGoods
        '
        Me.cbCodeGoods.Location = New System.Drawing.Point(70, 36)
        Me.cbCodeGoods.MaxDropDownItems = 15
        Me.cbCodeGoods.MaxLength = 12
        Me.cbCodeGoods.Name = "cbCodeGoods"
        Me.cbCodeGoods.Size = New System.Drawing.Size(130, 20)
        Me.cbCodeGoods.TabIndex = 168
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(136, 190)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 172
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(70, 190)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 171
        Me.btSave.Text = "确认"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(4, 190)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 24)
        Me.btnClear.TabIndex = 170
        Me.btnClear.Text = "清空"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(70, 126)
        Me.txtWeight.MaxLength = 16
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.TabIndex = 169
        Me.txtWeight.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "总重量"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNo
        '
        Me.txtBillNo.Location = New System.Drawing.Point(70, 6)
        Me.txtBillNo.MaxLength = 20
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNo.TabIndex = 166
        Me.txtBillNo.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 176
        Me.Label4.Text = "货名"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "装卸公司"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "提单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 173
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 179
        Me.Label3.Text = "泊位号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbBerthNo
        '
        Me.cbBerthNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBerthNo.Location = New System.Drawing.Point(70, 66)
        Me.cbBerthNo.MaxDropDownItems = 20
        Me.cbBerthNo.Name = "cbBerthNo"
        Me.cbBerthNo.Size = New System.Drawing.Size(130, 20)
        Me.cbBerthNo.TabIndex = 180
        '
        'cbCompany
        '
        Me.cbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCompany.Location = New System.Drawing.Point(70, 96)
        Me.cbCompany.Name = "cbCompany"
        Me.cbCompany.Size = New System.Drawing.Size(130, 20)
        Me.cbCompany.TabIndex = 181
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(170, 128)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(30, 20)
        Me.Label35.TabIndex = 493
        Me.Label35.Text = "公斤"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(170, 160)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 20)
        Me.Label28.TabIndex = 506
        Me.Label28.Text = "公斤"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStandWeight
        '
        Me.txtStandWeight.Location = New System.Drawing.Point(70, 158)
        Me.txtStandWeight.MaxLength = 10
        Me.txtStandWeight.Name = "txtStandWeight"
        Me.txtStandWeight.TabIndex = 504
        Me.txtStandWeight.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 20)
        Me.Label10.TabIndex = 505
        Me.Label10.Text = "标准件重"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCargoGoods_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(206, 221)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label28, Me.txtStandWeight, Me.Label10, Me.Label35, Me.cbCompany, Me.cbBerthNo, Me.Label3, Me.cbCodeGoods, Me.btQuit, Me.btSave, Me.btnClear, Me.txtWeight, Me.Label5, Me.txtBillNo, Me.Label4, Me.Label2, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoGoods_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "散货货物情况信息 增加"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargoGoods_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dwCodeGoods As New DataView()
        Dim sqlCodeGoods, sqlCompany, sqlBerthNo As String
        Try
            'sqlCodeGoods = "SELECT CODE, GOODS FROM CODEGOODS order by goods"
            'dwCodeGoods = Filldata(sqlCodeGoods)
            sqlCompany = "SELECT Code, DepartMent FROM CodeCompany order by department"
            dwCompany = Filldata(sqlCompany)
            sqlBerthNo = "SELECT BERTH_ID, CODE_BERTH, NAME_BERTH, COMPANY, Code FROM CODE_BERTH LEFT OUTER JOIN CodeCompany ON COMPANY = DepartMent ORDER BY LEN(CODE_BERTH), CODE_BERTH"
            dwBerthNo = Filldata(sqlBerthNo)

            'cbCodeGoods.DataSource = dwCodeGoods
            'cbCodeGoods.DisplayMember = "GOODS"
            'cbCodeGoods.ValueMember = "CODE"

            cbCompany.DataSource = dwCompany
            cbCompany.DisplayMember = "DepartMent"
            cbCompany.ValueMember = "Code"

            cbBerthNo.DataSource = dwBerthNo
            cbBerthNo.DisplayMember = "NAME_BERTH"
            cbBerthNo.ValueMember = "CODE_BERTH"

            Me.cbCompany.SelectedValue = "00"
            cbCodeGoods.Text = FrmCargoGoods.strGoods
            cbBerthNo.SelectedValue = FrmCargoGoods.strBerthNo
            Call Me.cbBerthNo_SelectedValueChanged(sender, e)
            txtWeight.Text = FrmCargoGoods.iTons * 1000
            Me.txtStandWeight.Text = "50.150"

            'Dim i As Short
            'For i = 0 To dwBerthNo.Count - 1
            '    If dwBerthNo.Item(i)("CODE_BERTH") = cbBerthNo.SelectedValue Then
            '        cbCompany.SelectedValue = dwBerthNo.Item(i)("Code")
            '        Exit For
            '    End If
            'Next
       
            Dim y, m, d, h As String
            y = Now.Year
            m = Microsoft.VisualBasic.Strings.Right(String.Concat("0", Now.Month), 2)
            d = Microsoft.VisualBasic.Strings.Right(String.Concat("0", Now.Day), 2)
            h = Microsoft.VisualBasic.Strings.Right(String.Concat("0", Now.Hour), 2)
            txtBillNo.Text = y & m & d & h

            sqlstr = "select * from CARGO_GOODS where CARGO_GOODS_ID =" & ID & ""
            dw = Updatedata(sqlda, sqlstr, ds)

            If dw.Count > 0 Then
                txtID.Text = ds.Tables(0).Rows(0).Item("CARGO_GOODS_ID")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlExist As String
        sqlExist = "select * from CARGO_GOODS where SHIP_ID = '" & Ship_ID & _
                "' and BLNO = '" & Trim(txtBillNo.Text) & "'"
        Try
            If Trim(txtBillNo.Text) <> "" Then
                If cbCodeGoods.Text.Trim <> "" Then
                    If cbCompany.SelectedValue <> "00" Then
                        Dim row As DataRow
                        row = ds.Tables(0).NewRow
                        If Trim(txtWeight.Text) <> "" Then
                            If IsNumeric(Trim(txtWeight.Text)) Then
                                row.Item("TOTAL_WEIGHT") = Trim(txtWeight.Text)
                            Else
                                Me.txtWeight.Focus()
                                MessageBox.Show("总重量应为数字。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        Else
                        End If
                        If IsNumeric(Trim(txtStandWeight.Text)) Then
                            row.Item("StandsWeight") = Trim(Me.txtStandWeight.Text)
                        Else
                            Me.txtStandWeight.Focus()
                            MessageBox.Show("标准件重应为数字。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                        If Filldata(sqlExist).Count = 0 Then
                            row.Item("BLNO") = Trim(txtBillNo.Text).ToUpper
                            row.Item("CODE_GOODS") = cbCodeGoods.Text
                            row.Item("HIDE_COMPANY") = cbCompany.SelectedValue
                            row.Item("BERTHNO") = cbBerthNo.SelectedValue
                            row.Item("SHIP_ID") = Ship_ID
                            row.Item("USER_NAME") = G_User
                            row.Item("DEPT_CODE") = G_DeptCode
                            ds.Tables(0).Rows.Add(row)
                            sqlda.Update(ds)
                            Me.Close()
                        Else
                            Me.txtBillNo.Focus()
                            MessageBox.Show("提单号不可重复。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        Me.cbCompany.Focus()
                        MessageBox.Show("装卸公司不能为空。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    Me.cbCodeGoods.Focus()
                    MessageBox.Show("货名不能为空。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Me.txtBillNo.Focus()
                MessageBox.Show("提单号不能为空。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.txtWeight.Clear()
        Me.cbCodeGoods.Text = ""
        Me.cbBerthNo.SelectedValue = "0"
        Me.cbCompany.SelectedValue = "00"
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub cbBerthNo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBerthNo.SelectedValueChanged
        Try
            Dim i As Short
            If TypeName(cbBerthNo.SelectedValue) = "String" Then
                For i = 0 To dwBerthNo.Count - 1
                    If dwBerthNo.Item(i)("CODE_BERTH") = cbBerthNo.SelectedValue Then
                        cbCompany.SelectedValue = dwBerthNo.Item(i)("Code")
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbCompany_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCompany.SelectedValueChanged
        'Try
        '    dwBerthNo.RowFilter = "COMPANY = '" & Trim(cbCompany.Text) & "' or CODE_BERTH = '0'"
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub txtBillNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBillNo.KeyPress
        If e.KeyChar = Chr(13) Then
            cbCodeGoods.Focus()
        End If
    End Sub

    Private Sub cbCodeGoods_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbCodeGoods.KeyPress
        If e.KeyChar = Chr(13) Then
            cbBerthNo.Focus()
        End If
    End Sub

    Private Sub cbBerthNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbBerthNo.KeyPress
        If e.KeyChar = Chr(13) Then
            cbCompany.Focus()
        End If
    End Sub

    Private Sub cbCompany_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbCompany.KeyPress
        If e.KeyChar = Chr(13) Then
            txtWeight.Focus()
        End If
    End Sub

    Private Sub txtWeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeight.KeyPress
        If e.KeyChar = Chr(13) Then
            txtStandWeight.Focus()
        End If
    End Sub

    Private Sub txtStandWeight_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStandWeight.KeyDown
        If e.KeyCode = Keys.Enter Then
            btSave.Focus()
        End If
    End Sub
End Class
