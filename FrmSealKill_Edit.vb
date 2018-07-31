Imports TALLY.DBControl
Public Class FrmSealKill_Edit
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()

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
    Friend WithEvents cbDept As System.Windows.Forms.ComboBox
    Friend WithEvents txtPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSealNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtKillReason As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents dtpSealTime As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbDept = New System.Windows.Forms.ComboBox()
        Me.txtPerson = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSealNO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtKillReason = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.dtpSealTime = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'cbDept
        '
        Me.cbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDept.Location = New System.Drawing.Point(76, 32)
        Me.cbDept.Name = "cbDept"
        Me.cbDept.Size = New System.Drawing.Size(130, 20)
        Me.cbDept.TabIndex = 3
        '
        'txtPerson
        '
        Me.txtPerson.Location = New System.Drawing.Point(76, 58)
        Me.txtPerson.MaxLength = 10
        Me.txtPerson.Name = "txtPerson"
        Me.txtPerson.Size = New System.Drawing.Size(130, 21)
        Me.txtPerson.TabIndex = 1
        Me.txtPerson.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 198
        Me.Label5.Text = "责任人"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSealNO
        '
        Me.txtSealNO.Location = New System.Drawing.Point(76, 6)
        Me.txtSealNO.MaxLength = 20
        Me.txtSealNO.Name = "txtSealNO"
        Me.txtSealNO.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNO.TabIndex = 0
        Me.txtSealNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 195
        Me.Label4.Text = "部门"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 193
        Me.Label1.Text = "铅封号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 192
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtKillReason
        '
        Me.txtKillReason.Location = New System.Drawing.Point(10, 132)
        Me.txtKillReason.MaxLength = 30
        Me.txtKillReason.Multiline = True
        Me.txtKillReason.Name = "txtKillReason"
        Me.txtKillReason.Size = New System.Drawing.Size(196, 66)
        Me.txtKillReason.TabIndex = 4
        Me.txtKillReason.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "注销原因"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(112, 204)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 6
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(44, 204)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 5
        Me.btSave.Text = "确认"
        '
        'dtpSealTime
        '
        Me.dtpSealTime.Location = New System.Drawing.Point(76, 84)
        Me.dtpSealTime.Name = "dtpSealTime"
        Me.dtpSealTime.Size = New System.Drawing.Size(130, 21)
        Me.dtpSealTime.TabIndex = 2
        '
        'FrmSealKill_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(214, 231)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpSealTime, Me.btQuit, Me.btSave, Me.txtKillReason, Me.Label2, Me.cbDept, Me.txtPerson, Me.Label5, Me.txtSealNO, Me.Label4, Me.Label3, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSealKill_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "铅封注销信息 注销"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmSealKill_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim dvDept As New DataView()
        Dim sqlstr, sqlDept As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlDept = "select dept_code,dept_name from department where dept_code<>'00' "
        sqlstr = "select * from SEAL_RECORD where SEAL_RECORD_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        dvDept = Filldata(sqlDept)
        cbDept.DataSource = dvDept
        cbDept.DisplayMember = "dept_name"
        cbDept.ValueMember = "dept_code"

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtSealNO.Text = ds.Tables(0).Rows(0).Item("SEALNO")
            dtpSealTime.Text = ds.Tables(0).Rows(0).Item("sealdate")
            txtKillReason.Text = ds.Tables(0).Rows(0).Item("logoff_reason")
            txtPerson.Text = ds.Tables(0).Rows(0).Item("USER_PERSON")
            cbDept.SelectedValue = ds.Tables(0).Rows(0).Item("dept_code")
        End If

        txtSealNO.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim iFlag As Short
        Dim strSealNO, strReason, strPerson As String
        strSealNO = UCase(Trim(txtSealNO.Text))
        strReason = Trim(txtKillReason.Text)
        strPerson = Trim(txtPerson.Text)
        Try
            'Dim EditDate As Date = CDate(Trim(txtSealTime.Text))

            Dim sqlKill As String = "update seal_record  set SEAL_STATE= '4' , SEALDATE= '" & _
                dtpSealTime.Value.Date & "' ,LOGOFF_REASON= '" & strReason & "' , USER_PERSON= '" & _
                strPerson & "' , USER_NAME= '" & G_User & _
                "' , Dept_Code= '" & cbDept.SelectedValue & _
                "' where SEALNO= '" & strSealNO & "' and (SEAL_STATE='1' or SEAL_STATE='2')"

            If Len(strSealNO) > 0 Then
                If MsgBox("确认要注销吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                    '记录操作日志
                    Call OperateHistory(G_DeptName, Now, G_User, "注销", "SEAL_RECORD", Trim(txtID.Text), "SEAL_RECORD_ID")

                    Dim sqlcmd As New SqlClient.SqlCommand(sqlKill, sqlconn)
                    sqlcmd.CommandTimeout = 300
                    sqlcmd.CommandType = CommandType.Text
                    sqlconn.Open()
                    iFlag = sqlcmd.ExecuteNonQuery()
                    sqlconn.Close()
                    If iFlag = 1 Then '成功注销
                        Me.Close()
                    Else        'iFlag=0 不能注销
                        MessageBox.Show("无法注销！可能铅封号不存在，或铅封在使用，或铅封已注销。请检查。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MsgBox("铅封号不能为空!", MsgBoxStyle.Critical, "提示")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtSealNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSealNO.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbDept.Focus()
        End If
    End Sub

    Private Sub cbDept_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbDept.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPerson.Focus()
        End If
    End Sub

    Private Sub txtPerson_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPerson.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpSealTime.Focus()
        End If
    End Sub

    Private Sub dtpSealTime_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpSealTime.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtKillReason.Focus()
        End If
    End Sub

    Private Sub txtKillReason_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKillReason.KeyPress
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
