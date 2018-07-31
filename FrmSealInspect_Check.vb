Imports TALLY.DBControl
Public Class FrmSealInspect_Check
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSealNOEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNOBegin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents txtContainer As System.Windows.Forms.TextBox
    Friend WithEvents cbSealState As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtShip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtVoyage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContainer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSealNOEnd = New System.Windows.Forms.TextBox()
        Me.txtSealNOBegin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbSealState = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbDept = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(78, 8)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 199
        Me.txtShip.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "中文船名"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 197
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(78, 38)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 201
        Me.txtVoyage.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 200
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContainer
        '
        Me.txtContainer.Location = New System.Drawing.Point(78, 68)
        Me.txtContainer.MaxLength = 11
        Me.txtContainer.Name = "txtContainer"
        Me.txtContainer.Size = New System.Drawing.Size(130, 21)
        Me.txtContainer.TabIndex = 203
        Me.txtContainer.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "集装箱号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSealNOEnd
        '
        Me.txtSealNOEnd.Location = New System.Drawing.Point(78, 128)
        Me.txtSealNOEnd.MaxLength = 20
        Me.txtSealNOEnd.Name = "txtSealNOEnd"
        Me.txtSealNOEnd.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOEnd.TabIndex = 207
        Me.txtSealNOEnd.Text = ""
        '
        'txtSealNOBegin
        '
        Me.txtSealNOBegin.Location = New System.Drawing.Point(78, 98)
        Me.txtSealNOBegin.MaxLength = 20
        Me.txtSealNOBegin.Name = "txtSealNOBegin"
        Me.txtSealNOBegin.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOBegin.TabIndex = 206
        Me.txtSealNOBegin.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 205
        Me.Label4.Text = "铅封止号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(4, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 204
        Me.Label5.Text = "铅封起号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSealState
        '
        Me.cbSealState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSealState.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbSealState.Location = New System.Drawing.Point(78, 158)
        Me.cbSealState.Name = "cbSealState"
        Me.cbSealState.Size = New System.Drawing.Size(130, 20)
        Me.cbSealState.TabIndex = 209
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 208
        Me.Label6.Text = "铅封状态"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDept
        '
        Me.cbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDept.Location = New System.Drawing.Point(78, 188)
        Me.cbDept.Name = "cbDept"
        Me.cbDept.Size = New System.Drawing.Size(130, 20)
        Me.cbDept.TabIndex = 211
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 210
        Me.Label7.Text = "部门"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(110, 214)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 213
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(42, 214)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 212
        Me.btSave.Text = "确认"
        '
        'FrmSealInspect_Check
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(214, 241)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btQuit, Me.btSave, Me.cbDept, Me.Label7, Me.cbSealState, Me.Label6, Me.txtSealNOEnd, Me.txtSealNOBegin, Me.Label4, Me.Label5, Me.txtContainer, Me.Label3, Me.txtVoyage, Me.Label1, Me.txtShip, Me.Label2, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSealInspect_Check"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "铅封状态信息  查询"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Public strCondition, strConditionShip, strConditionVoyage, strConditionCont, strConditionSeal, strConditionState, strConditionDept As String
    Public iLocal As Short = -1
    Public strSealNOBegin, strSealNOEnd As String

    Private Sub FrmSealInspect_Check_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim dvDept As New DataView()
        Dim sqlstr, sqlDept As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlDept = "select dept_code,dept_name from department  "
        sqlstr = "select * from View_SEALRECORD where ID=" & ID & ""
        'dw = Updatedata(sqlda, sqlstr, ds)
        dw = Getdata(sqlstr, ds)
        dvDept = Filldata(sqlDept)
        cbDept.DataSource = dvDept
        cbDept.DisplayMember = "dept_name"
        cbDept.ValueMember = "dept_code"

        'cbDept.Items.Add("任何部门")
        'cbSealState.Items.Add("aaaaaa")

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtShip.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            txtVoyage.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
            txtContainer.Text = ds.Tables(0).Rows(0).Item("CONTAINER_NO")
            txtSealNOBegin.Text = ds.Tables(0).Rows(0).Item("SEALNO")
            'txtSealNOEnd.Text = ds.Tables(0).Rows(0).Item("SEALNO")
            cbSealState.SelectedIndex = ds.Tables(0).Rows(0).Item("SEAL_STATE")
            cbDept.SelectedValue = ds.Tables(0).Rows(0).Item("dept_code")
        End If

        txtShip.Focus()
        strCondition = " 100 = 100 "    '初始化查询条件
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim strShip, strVoyage, strContainer As String

        strShip = Trim(txtShip.Text)
        strVoyage = Trim(txtVoyage.Text)
        strContainer = Trim(txtContainer.Text)
        strSealNOBegin = UCase(Trim(txtSealNOBegin.Text))
        strSealNOEnd = UCase(Trim(txtSealNOEnd.Text))
        'If strSealNOEnd = "" Then
        '    strSealNOEnd = strSealNOBegin
        'End If
        strCondition = " '100' = '100"      '查询条件
        If strShip <> "" Then
            strConditionShip = strCondition & "' and  CHI_VESSEL = '" & strShip
        Else
            strConditionShip = strCondition
        End If
        If strVoyage <> "" Then
            strConditionVoyage = strConditionShip & "' and VOYAGE = '" & strVoyage
        Else
            strConditionVoyage = strConditionShip
        End If
        If strContainer <> "" Then
            strConditionCont = strConditionVoyage & "' and CONTAINER_NO = '" & strContainer
        Else
            strConditionCont = strConditionVoyage
        End If
        If cbSealState.SelectedIndex <> 0 Then
            strConditionState = strConditionCont & "' and SEAL_STATE = '" & cbSealState.SelectedIndex
        Else
            strConditionState = strConditionCont
        End If
        If cbDept.SelectedValue <> "00" And cbDept.SelectedValue <> Nothing Then
            strConditionDept = strConditionState & "' and DEPT_CODE = '" & cbDept.SelectedValue
        Else
            strConditionDept = strConditionState
        End If
        If strSealNOBegin <> "" Then
            If strSealNOEnd <> "" Then
                If StrComp(strSealNOBegin, strSealNOEnd, CompareMethod.Text) <> 0 Then  '一段铅封号
                    If VerifySealNOInput(strSealNOBegin, strSealNOEnd) Then     '铅封起止号通过验证
                        iLocal = GetSealLocation(strSealNOBegin, strSealNOEnd)
                        strConditionSeal = strConditionDept & "' and left(SEALNO, " & iLocal - 1 & " ) = '" & Mid(strSealNOBegin, 1, iLocal - 1)
                        Dim sublen As Short = Len(strSealNOBegin) - iLocal + 1
                        strConditionSeal = strConditionSeal & "' and dbo.ISNUMSTR(right(SEALNO," & sublen & "))= 1 "
                        strConditionSeal = strConditionSeal & " and len(SEALNO) = '" & Len(strSealNOBegin)
                    Else            '铅封起止号不能通过验证
                        Exit Sub
                    End If
                Else        '单个铅封号
                    strConditionSeal = strConditionDept & "' and SEALNO = '" & strSealNOBegin
                End If
            Else    '单个铅封号
                strConditionSeal = strConditionDept & "' and SEALNO = '" & strSealNOBegin
            End If
        Else
            If strSealNOEnd = "" Then   '不从铅封号查询
                strConditionSeal = strConditionDept
            Else
                MessageBox.Show("输入单个铅封号应在铅封起号文本框中。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'strCondition = " 100 = 100 "
                Exit Sub
            End If
        End If
        strCondition = strConditionSeal & "' "
        'MessageBox.Show(strCondition, "111", MessageBoxButtons.OK)
        Me.Hide()
    End Sub

    Private Function GetSealLocation(ByVal strSealNOBegin As String, ByVal strSealNOEnd As String) As Short
        Dim i As Short = 1
        For i = 1 To Len(strSealNOBegin)
            If Mid(strSealNOBegin, i, 1) <> Mid(strSealNOEnd, i, 1) Then
                Exit For
            End If
        Next
        'i标记铅封号中第一个不等字符位置
        Return i
    End Function

    Private Function VerifySealNOInput(ByVal strSealNOBegin As String, ByVal strSealNOEnd As String) As Boolean
        '铅封号格式验证
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
                        MessageBox.Show("铅封号不合法！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return False
                        Exit Function
                    End If
                End If
            Next

            If i >= 1 And i < iLength1 Then     'i为铅封号前后部分界线，标记最末位字母符号位置
                If Mid(strSealNOBegin, i + 1) <= Mid(strSealNOEnd, i + 1) Then
                    '后部通过验证
                Else
                    MessageBox.Show("铅封起号必须位于止号之前！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return False
                    Exit Function
                End If
            ElseIf i < 1 Then
                MessageBox.Show("铅封号不能全为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return False
                Exit Function
            ElseIf i = iLength1 Then
                MessageBox.Show("铅封号后部不能为字母！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
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
                        MessageBox.Show("铅封号不合法！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return False
                        Exit Function
                    End If
                End If
            Next

            If StrComp(Mid(strSealNOBegin, 1, i), Mid(strSealNOEnd, 1, i), CompareMethod.Text) = 0 Then
                flag = True             '全部通过验证
                Return flag
            Else
                MessageBox.Show("铅封起止号前部不一致！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return False
                Exit Function
            End If
        Else
            If iLength1 <> iLength2 Then
                MessageBox.Show("铅封起止号长度不一致！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            If iLength1 <= 0 Then
                MessageBox.Show("铅封起号不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            Return False
            Exit Function
        End If

    End Function

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        strCondition = " 100 = 100 "
        Me.Close()
    End Sub

    Private Sub txtShip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShip.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtVoyage.Focus()
        End If
    End Sub

    Private Sub txtVoyage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVoyage.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtContainer.Focus()
        End If
    End Sub

    Private Sub txtContainer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContainer.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtSealNOBegin.Focus()
        End If
    End Sub

    Private Sub txtSealNOBegin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSealNOBegin.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtSealNOEnd.Focus()
        End If
    End Sub

    Private Sub txtSealNOEnd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSealNOEnd.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbSealState.Focus()
        End If
    End Sub

    Private Sub cbSealState_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbSealState.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbDept.Focus()
        End If
    End Sub

    Private Sub cbDept_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbDept.KeyPress
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
