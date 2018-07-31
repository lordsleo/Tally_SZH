Imports TALLY.DBControl
Public Class FrmABSENT_ADD
    Inherits System.Windows.Forms.Form

    Dim sqlstr As String
    Dim ds As New DataSet()
    Dim dw As New DataView()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTPABSENTDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbCode_HOLIDAY_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbWORK_NAME As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btResume = New System.Windows.Forms.Button
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DTPABSENTDATE = New System.Windows.Forms.DateTimePicker
        Me.CmbCode_HOLIDAY_TYPE = New System.Windows.Forms.ComboBox
        Me.CmbWORK_NAME = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 18)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "姓名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(94, 86)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 4
        Me.btQuit.Text = "取消"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(26, 86)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 3
        Me.btResume.Text = "确认"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(8, 80)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(20, 21)
        Me.txtID.TabIndex = 103
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "假别"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPABSENTDATE
        '
        Me.DTPABSENTDATE.CustomFormat = "yyyy/MM/dd"
        Me.DTPABSENTDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPABSENTDATE.Location = New System.Drawing.Point(59, 30)
        Me.DTPABSENTDATE.Name = "DTPABSENTDATE"
        Me.DTPABSENTDATE.Size = New System.Drawing.Size(114, 21)
        Me.DTPABSENTDATE.TabIndex = 1
        '
        'CmbCode_HOLIDAY_TYPE
        '
        Me.CmbCode_HOLIDAY_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCode_HOLIDAY_TYPE.Location = New System.Drawing.Point(59, 56)
        Me.CmbCode_HOLIDAY_TYPE.Name = "CmbCode_HOLIDAY_TYPE"
        Me.CmbCode_HOLIDAY_TYPE.Size = New System.Drawing.Size(114, 20)
        Me.CmbCode_HOLIDAY_TYPE.TabIndex = 2
        '
        'CmbWORK_NAME
        '
        Me.CmbWORK_NAME.Location = New System.Drawing.Point(59, 6)
        Me.CmbWORK_NAME.Name = "CmbWORK_NAME"
        Me.CmbWORK_NAME.Size = New System.Drawing.Size(114, 20)
        Me.CmbWORK_NAME.TabIndex = 0
        '
        'FrmABSENT_ADD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(184, 117)
        Me.Controls.Add(Me.CmbCode_HOLIDAY_TYPE)
        Me.Controls.Add(Me.DTPABSENTDATE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btResume)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.CmbWORK_NAME)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmABSENT_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "当班考勤_增加"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmABSENT_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err

        Call FillCode_HOLIDAY_TYPE()
        Call FillWORK_NAME()
        CmbCode_HOLIDAY_TYPE.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try

            sqlstr = "select * from ABSENT where DEPT_CODE= '" & G_DeptCode & "' and WORK_NO='" & CmbWORK_NAME.SelectedValue & "' and datediff(dd,ABSENTDATE,'" & DTPABSENTDATE.Value & "')=0 "
            dw = Updatedata(sqlda, sqlstr, ds)
            If dw.Count = 0 Then
                If MsgBox("你确认要修改吗？", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                    Dim sqldc As String
                    Dim duty As String
                    Dim TALLY_TEAM As String
                    Dim dvc As New DataView()
                    Dim dsc As New DataSet()
                    sqldc = "SELECT Code_DUTY,TALLY_TEAM FROM TALLY_CLERK where WORK_NO='" & CmbWORK_NAME.SelectedValue & "'"
                    dvc = DBControl.Getdata(sqldc, dsc)

                    If dvc.Count > 0 Then
                        duty = dvc(0)(0)
                        TALLY_TEAM = dvc(0)(1)
                    End If
                    Dim row As DataRow
                    row = ds.Tables(0).NewRow()
                    If duty = 20 Then
                        row("WORK_TYPE") = TALLY_TEAM
                    End If

                    row("DEPT_CODE") = G_DeptCode
                    row("WORK_NO") = CmbWORK_NAME.SelectedValue
                    row("ABSENTDATE") = DTPABSENTDATE.Value
                    row("Code_HOLIDAY_TYPE") = CmbCode_HOLIDAY_TYPE.SelectedValue
                    row("DAYNIGHTMARK") = "01"
                    row("USER_NAME") = G_User

                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                    Call btQuit_Click(sender, e)
                End If
            Else
                MsgBox("已经存在此人信息，不能增加记录！", MsgBoxStyle.Exclamation, "提示")
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FillCode_HOLIDAY_TYPE()
        Dim sqldc As String
        Dim dvc As New DataView()
        Dim dsc As New DataSet()
        sqldc = "SELECT Code_Holiday_Type,Holiday_Type FROM Code_Holiday_Type WHERE ( Code_HOLIDAY_TYPE between 1 and 89 ) "
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbCode_HOLIDAY_TYPE.DataSource = dvc
        Me.CmbCode_HOLIDAY_TYPE.DisplayMember = "Holiday_Type"
        Me.CmbCode_HOLIDAY_TYPE.ValueMember = "Code_Holiday_Type"
    End Sub

    Private Sub FillWORK_NAME()
        Dim sqldc As String
        Dim dvc As New DataView()
        Dim dsc As New DataSet()
        If G_DeptCode = "26.11.11" Then
            sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE (DEPT_CODE like '" & G_DeptCode & "%' or DEPT_CODE='29.11.11') order by NAME "
        Else
            sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE (DEPT_CODE like '" & G_DeptCode & "%' or DEPT_CODE='29.11.12') order by NAME "
        End If

        Me.CmbWORK_NAME.DataSource = DBControl.Getdata(sqldc, dsc)
        Me.CmbWORK_NAME.DisplayMember = "NAME"
        Me.CmbWORK_NAME.ValueMember = "WORK_NO"
    End Sub

    Private Sub CmbWORK_NAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbWORK_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTPABSENTDATE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DTPABSENTDATE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPABSENTDATE.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbCode_HOLIDAY_TYPE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbCode_HOLIDAY_TYPE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCode_HOLIDAY_TYPE.KeyDown
        If e.KeyCode = Keys.Enter Then
            btResume.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btResume_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btResume.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btQuit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btQuit.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
