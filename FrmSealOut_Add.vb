Imports TALLY.DBControl
Public Class FrmSealOut_Add
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע�⣺���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSealNOEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNOBegin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtLeadPerson As System.Windows.Forms.TextBox
    Friend WithEvents cbLeadDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeOut As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
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
        Me.dtpTimeOut = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(140, 156)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 7
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(74, 156)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 6
        Me.btSave.Text = "ȷ��"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(8, 156)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 24)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "���"
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
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "������"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSealNOEnd
        '
        Me.txtSealNOEnd.Location = New System.Drawing.Point(76, 38)
        Me.txtSealNOEnd.MaxLength = 20
        Me.txtSealNOEnd.Name = "txtSealNOEnd"
        Me.txtSealNOEnd.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOEnd.TabIndex = 1
        Me.txtSealNOEnd.Text = ""
        '
        'txtSealNOBegin
        '
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
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "���ò���"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Ǧ��ֹ��"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Ǧ�����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 158
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
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "��������"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeOut
        '
        Me.dtpTimeOut.Location = New System.Drawing.Point(76, 68)
        Me.dtpTimeOut.Name = "dtpTimeOut"
        Me.dtpTimeOut.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeOut.TabIndex = 2
        Me.dtpTimeOut.Value = New Date(2003, 12, 10, 0, 0, 0, 0)
        '
        'FrmSealOut_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(210, 183)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpTimeOut, Me.Label3, Me.cbLeadDept, Me.btQuit, Me.btSave, Me.btnClear, Me.txtLeadPerson, Me.Label5, Me.txtSealNOEnd, Me.txtSealNOBegin, Me.Label4, Me.Label2, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSealOut_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ǧ�������Ϣ ����"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmSealOut_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim dvDept As New DataView()
        Dim sqlstr, sqlDept As String
        sqlDept = "select dept_code,dept_name from department where dept_code<>'00' "
        dvDept = Filldata(sqlDept)
        cbLeadDept.DataSource = dvDept
        cbLeadDept.DisplayMember = "dept_name"
        cbLeadDept.ValueMember = "dept_code"

        'Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select * from SEAL_OUT where SEAL_OUT_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtSealNOBegin.Text = ds.Tables(0).Rows(0).Item("SEALNO_BEGIN")
            txtSealNOEnd.Text = ds.Tables(0).Rows(0).Item("SEALNO_END")
            dtpTimeOut.Text = ds.Tables(0).Rows(0).Item("TIME_OUT")
            cbLeadDept.SelectedValue = ds.Tables(0).Rows(0).Item("LEAD_DEPARTMENT")
            txtLeadPerson.Text = ds.Tables(0).Rows(0).Item("LEAD_PERSON")
        End If

        txtSealNOBegin.Focus()
        Exit Sub

Err:
        Resume Next
    End Sub

    Private Function VerifySealNOInput(ByVal strSealNOBegin As String, ByVal strSealNOEnd As String) As Boolean
        'Ǧ��Ÿ�ʽ��֤
        Dim i, j, iLength1, iLength2 As Short
        Dim strSealNO, strNOBegin, strNOEnd As String
        Dim c1, c2 As Char
        Dim flag As Boolean = False
        iLength1 = Len(strSealNOBegin)
        iLength2 = Len(strSealNOEnd)
        
        If iLength1 = iLength2 And iLength1 > 0 Then
            For i = iLength1 To 1 Step -1
                c1 = Mid(strSealNOBegin, i, 1)
                c2 = Mid(strSealNOEnd, i, 1)
                If (c1 >= "0" And c1 <= "9") And (c2 >= "0" And c2 <= "9") Then

                Else
                    If (c1 >= "A" And c1 <= "Z") And (c2 >= "A" And c2 <= "Z") Then
                        Exit For
                    Else
                        MessageBox.Show("Ǧ��Ų��Ϸ���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return False
                        Exit Function
                    End If
                End If
            Next

            If i >= 1 And i < iLength1 Then
                If Mid(strSealNOBegin, i + 1) <= Mid(strSealNOEnd, i + 1) Then
                    '��ͨ����֤
                Else
                    MessageBox.Show("Ǧ����ű���λ��ֹ��֮ǰ��", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return False
                    Exit Function
                End If
            ElseIf i < 1 Then
                MessageBox.Show("Ǧ��Ų���ȫΪ���֣�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return False
                Exit Function
            ElseIf i = iLength1 Then
                MessageBox.Show("Ǧ��ź󲿲���Ϊ��ĸ��", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return False
                Exit Function
            End If

            For j = 1 To i
                c1 = Mid(strSealNOBegin, j, 1)
                c2 = Mid(strSealNOEnd, j, 1)
                If (c1 >= "A" And c1 <= "Z") And (c2 >= "A" And c2 <= "Z") Then

                Else
                    If (c1 >= "0" And c1 <= "9") And (c2 >= "0" And c2 <= "9") Then

                    Else
                        MessageBox.Show("Ǧ��Ų��Ϸ���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return False
                        Exit Function
                    End If
                End If
            Next

            If StrComp(Mid(strSealNOBegin, 1, i), Mid(strSealNOEnd, 1, i), CompareMethod.Text) = 0 Then
                flag = True             'ȫ��ͨ����֤
                Return flag
            Else
                MessageBox.Show("Ǧ����ֹ��ǰ����һ�£�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return False
                Exit Function
            End If
        Else
            If iLength1 <> iLength2 Then
                MessageBox.Show("Ǧ����ֹ�ų��Ȳ�һ�£�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            If iLength1 <= 0 Then
                MessageBox.Show("Ǧ����Ų���Ϊ�գ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            Return False
            Exit Function
        End If

    End Function

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim iFlag As Short
        Dim strSealNOBegin, strSealNOEnd, strLeadDept, strLeadPerson As String

        strSealNOBegin = UCase(Trim(txtSealNOBegin.Text))
        strSealNOEnd = UCase(Trim(txtSealNOEnd.Text))
        If strSealNOEnd = "" Then
            strSealNOEnd = strSealNOBegin
        End If
        'strLeadDept = cbLeadDept.SelectedText
        strLeadPerson = Trim(txtLeadPerson.Text)
        Try
            'Dim OutDate As Date = CDate(Trim(txtSealTimeOut.Text))

            If VerifySealNOInput(strSealNOBegin, strSealNOEnd) Then     'Ǧ����ֹ�Ÿ�ʽͨ����֤
                If Len(strLeadPerson) > 0 Then

                    '���Ǧ��״̬��¼
                    iFlag = UpdateSealRecord("spEditSealRecord", strSealNOBegin, strSealNOEnd, cbLeadDept.SelectedValue, strLeadPerson)

                    If iFlag = 2 Then   '��������

                        '����Ǧ������¼
                        Dim row As DataRow
                        row = ds.Tables(0).NewRow()

                        row("SEALNO_BEGIN") = strSealNOBegin
                        row("SEALNO_END") = strSealNOEnd
                        row("LEAD_DEPARTMENT") = cbLeadDept.SelectedValue
                        row("LEAD_PERSON") = strLeadPerson
                        row("TIME_OUT") = dtpTimeOut.Value.Date
                        row("USER_NAME") = G_User

                        ds.Tables(0).Rows.Add(row)
                        sqlda.Update(ds)

                        Me.Close()
                    Else            '������������
                        If iFlag = 1 Then
                            MessageBox.Show("���ڶϺ����������ЩǦ�ⲻ���ڣ����顣", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error, _
                            MessageBoxDefaultButton.Button1)
                        Else    'iFlag=0
                            MessageBox.Show("Ǧ��״̬��������⣬���顣", "������ʾ", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        End If
                    End If
                Else
                    MsgBox("�����˲���Ϊ��!", MsgBoxStyle.Critical, "��ʾ")
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function UpdateSealRecord(ByVal storeproc As String, ByVal strSealNOBegin As String, ByVal strSealNOEnd As String, ByVal strDept As String, ByVal strPerson As String) As Short
        Dim sqlcmd As New SqlClient.SqlCommand(storeproc, sqlconn)
        Dim prmSealNOBegin, prmSealNOEnd, prmNewState, prmDeptCode, prmPerson, prmUserName, prmRowCount, prmFlag As SqlClient.SqlParameter
        Dim iFlag As Short  'iFlag��Ǵ˶�Ǧ���Ƿ�˳������

        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandTimeout = 300

        prmSealNOBegin = sqlcmd.Parameters.Add("@strSealNOBegin", SqlDbType.VarChar, 20)
        prmSealNOEnd = sqlcmd.Parameters.Add("@strSealNOEnd", SqlDbType.VarChar, 20)
        prmNewState = sqlcmd.Parameters.Add("@NewState", SqlDbType.VarChar, 2)
        prmDeptCode = sqlcmd.Parameters.Add("@strDept", SqlDbType.VarChar, 12)
        prmPerson = sqlcmd.Parameters.Add("@strUserPerson", SqlDbType.VarChar, 10)
        prmUserName = sqlcmd.Parameters.Add("@strUserName", SqlDbType.VarChar, 10)
        prmRowCount = sqlcmd.Parameters.Add("@rowcount", SqlDbType.Int)
        prmFlag = sqlcmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int)

        prmSealNOBegin.Direction = ParameterDirection.Input
        prmSealNOEnd.Direction = ParameterDirection.Input
        prmNewState.Direction = ParameterDirection.Input
        prmDeptCode.Direction = ParameterDirection.Input
        prmPerson.Direction = ParameterDirection.Input
        prmUserName.Direction = ParameterDirection.Input
        prmRowCount.Direction = ParameterDirection.Output
        prmFlag.Direction = ParameterDirection.ReturnValue

        prmSealNOBegin.Value = strSealNOBegin
        prmSealNOEnd.Value = strSealNOEnd
        prmNewState.Value = "2"     'NewState="2"��ʾ����
        prmDeptCode.Value = strDept
        prmPerson.Value = strPerson
        prmUserName.Value = G_User

        sqlconn.Open()
        sqlcmd.ExecuteNonQuery()
        'iRowCount = CType(prmRowCount.Value, Short)
        iFlag = CType(prmFlag.Value, Short)
        sqlconn.Close()
        'MessageBox.Show("iRowCount=" & iRowCount & " iFlag=" & iFlag, "test")
        Return iFlag
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSealNOBegin.Text = ""
        txtSealNOEnd.Text = ""
        txtLeadPerson.Text = ""
    End Sub

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
            Me.dtpTimeOut.Focus()
        End If
    End Sub

    Private Sub dtpTimeOut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpTimeOut.KeyPress
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
