Imports TALLY.DBControl
Public Class FrmSealOut_Edit
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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtLeadPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSealNOEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNOBegin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents cbLeadDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpSealTimeOut As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtLeadPerson = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSealNOEnd = New System.Windows.Forms.TextBox()
        Me.txtSealNOBegin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cbLeadDept = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpSealTimeOut = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(108, 156)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 6
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(40, 156)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 5
        Me.btSave.Text = "确认"
        '
        'txtLeadPerson
        '
        Me.txtLeadPerson.Location = New System.Drawing.Point(76, 128)
        Me.txtLeadPerson.MaxLength = 10
        Me.txtLeadPerson.Name = "txtLeadPerson"
        Me.txtLeadPerson.Size = New System.Drawing.Size(130, 21)
        Me.txtLeadPerson.TabIndex = 4
        Me.txtLeadPerson.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 176
        Me.Label5.Text = "领用人"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSealNOEnd
        '
        Me.txtSealNOEnd.Enabled = False
        Me.txtSealNOEnd.Location = New System.Drawing.Point(76, 38)
        Me.txtSealNOEnd.MaxLength = 20
        Me.txtSealNOEnd.Name = "txtSealNOEnd"
        Me.txtSealNOEnd.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOEnd.TabIndex = 1
        Me.txtSealNOEnd.Text = ""
        '
        'txtSealNOBegin
        '
        Me.txtSealNOBegin.Enabled = False
        Me.txtSealNOBegin.Location = New System.Drawing.Point(76, 8)
        Me.txtSealNOBegin.MaxLength = 20
        Me.txtSealNOBegin.Name = "txtSealNOBegin"
        Me.txtSealNOBegin.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOBegin.TabIndex = 0
        Me.txtSealNOBegin.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "领用部门"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "铅封止号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "铅封起号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 169
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'cbLeadDept
        '
        Me.cbLeadDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLeadDept.Location = New System.Drawing.Point(76, 98)
        Me.cbLeadDept.Name = "cbLeadDept"
        Me.cbLeadDept.Size = New System.Drawing.Size(130, 20)
        Me.cbLeadDept.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "领用日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpSealTimeOut
        '
        Me.dtpSealTimeOut.Location = New System.Drawing.Point(76, 68)
        Me.dtpSealTimeOut.Name = "dtpSealTimeOut"
        Me.dtpSealTimeOut.Size = New System.Drawing.Size(130, 21)
        Me.dtpSealTimeOut.TabIndex = 2
        Me.dtpSealTimeOut.Value = New Date(2003, 12, 10, 0, 0, 0, 0)
        '
        'FrmSealOut_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(210, 183)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpSealTimeOut, Me.Label3, Me.cbLeadDept, Me.btQuit, Me.btSave, Me.txtLeadPerson, Me.Label5, Me.txtSealNOEnd, Me.txtSealNOBegin, Me.Label4, Me.Label2, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSealOut_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "铅封出库信息 修改"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmSealOut_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim dvDept As New DataView()
        Dim sqlstr, sqlDept As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlDept = "select dept_code,dept_name from department where dept_code<>'00' "
        sqlstr = "select * from SEAL_OUT where SEAL_OUT_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        dvDept = Filldata(sqlDept)
        cbLeadDept.DataSource = dvDept
        cbLeadDept.DisplayMember = "dept_name"
        cbLeadDept.ValueMember = "dept_code"

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtSealNOBegin.Text = ds.Tables(0).Rows(0).Item("SEALNO_BEGIN")
            txtSealNOEnd.Text = ds.Tables(0).Rows(0).Item("SEALNO_END")
            dtpSealTimeOut.Text = ds.Tables(0).Rows(0).Item("TIME_OUT")
            txtLeadPerson.Text = ds.Tables(0).Rows(0).Item("LEAD_PERSON")
            cbLeadDept.SelectedValue = ds.Tables(0).Rows(0).Item("LEAD_DEPARTMENT")
        End If

        dtpSealTimeOut.Focus()
        Exit Sub

Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim iFlag As Short
        Try
            'Dim EditDate As Date = CDate(Trim(txtSealTimeOut.Text))
            If Len(Trim(txtLeadPerson.Text)) > 0 Then
                If MsgBox("确认要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                    '变更每个铅封记录状态到初始态
                    iFlag = UpdateSealRecord("spEditTwoSealRecord", txtSealNOBegin.Text, txtSealNOEnd.Text, cbLeadDept.SelectedValue, Trim(txtLeadPerson.Text))
                    If iFlag = 2 Then   '修改成功
                        '记录操作日志
                        Call OperateHistory(G_DeptName, Now, G_User, "修改", "SEAL_OUT", Trim(txtID.Text), "SEAL_OUT_ID")
                        '修改此铅封出库记录
                        ds.Tables(0).Rows(0).Item("LEAD_PERSON") = Trim(txtLeadPerson.Text)
                        ds.Tables(0).Rows(0).Item("LEAD_DEPARTMENT") = cbLeadDept.SelectedValue
                        ds.Tables(0).Rows(0).Item("TIME_OUT") = dtpSealTimeOut.Value.Date

                        sqlda.Update(ds)
                        Me.Close()
                    Else        '不能正常修改
                        If iFlag = 1 Then
                            MessageBox.Show("存在断号情况或者有些铅封不存在，请检查。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, _
                            MessageBoxDefaultButton.Button1)
                        Else    'iFlag=0
                            MessageBox.Show("铅封状态不允许修改，请检查。", "错误提示", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        End If
                    End If
                End If
            Else
                MsgBox("领用人不能为空!", MsgBoxStyle.Critical, "提示")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function UpdateSealRecord(ByVal storeproc As String, ByVal strSealNOBegin As String, ByVal strSealNOEnd As String, ByVal strDept As String, ByVal strPerson As String) As Short
        Dim sqlcmd As New SqlClient.SqlCommand(storeproc, sqlconn)

        Dim prmSealNOBegin, prmSealNOEnd, prmDept, prmPerson, prmRowCount, prmFlag As SqlClient.SqlParameter
        Dim iFlag As Short  'iFlag标记此段铅封信息是否顺利修改

        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandTimeout = 300

        prmSealNOBegin = sqlcmd.Parameters.Add("@strSealNOBegin", SqlDbType.VarChar, 20)
        prmSealNOEnd = sqlcmd.Parameters.Add("@strSealNOEnd", SqlDbType.VarChar, 20)
        prmDept = sqlcmd.Parameters.Add("@strDept", SqlDbType.VarChar, 12)
        prmPerson = sqlcmd.Parameters.Add("@strUserPerson", SqlDbType.VarChar, 10)
        prmRowCount = sqlcmd.Parameters.Add("@rowcount", SqlDbType.Int)
        prmFlag = sqlcmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int)

        prmSealNOBegin.Direction = ParameterDirection.Input
        prmSealNOEnd.Direction = ParameterDirection.Input
        prmDept.Direction = ParameterDirection.Input
        prmPerson.Direction = ParameterDirection.Input
        prmRowCount.Direction = ParameterDirection.Output
        prmFlag.Direction = ParameterDirection.ReturnValue

        prmDept.Value = strDept
        prmPerson.Value = strPerson
        prmSealNOBegin.Value = strSealNOBegin
        prmSealNOEnd.Value = strSealNOEnd

        sqlconn.Open()
        sqlcmd.ExecuteNonQuery()
        'iRowCount = CType(prmRowCount.Value, Short)
        iFlag = CType(prmFlag.Value, Short)
        sqlconn.Close()
        'MessageBox.Show("iRowCount=" & iRowCount & " iFlag=" & iFlag, "test")
        Return iFlag
    End Function

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtSealNOBegin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSealNOBegin.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtSealNOEnd.Focus()
        End If
    End Sub

    Private Sub txtSealNOEnd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSealNOEnd.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpSealTimeOut.Focus()
        End If
    End Sub

    Private Sub dtpSealTimeOut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpSealTimeOut.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbLeadDept.Focus()
        End If
    End Sub

    Private Sub cbLeadDept_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbLeadDept.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtLeadPerson.Focus()
        End If
    End Sub

    Private Sub txtLeadPerson_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLeadPerson.KeyPress
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
