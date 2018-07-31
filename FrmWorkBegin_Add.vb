Imports TALLY.DBControl
Public Class FrmWorkBegin_Add
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
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkType As System.Windows.Forms.TextBox
    Friend WithEvents txtDeptCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDayNightMark As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.txtWorkType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtDeptCode = New System.Windows.Forms.ComboBox()
        Me.txtTime = New System.Windows.Forms.DateTimePicker()
        Me.txtDayNightMark = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(151, 110)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 116
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(83, 110)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 115
        Me.btSave.Text = "确认"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(15, 110)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 114
        Me.btAdd.Text = "清空"
        '
        'txtWorkType
        '
        Me.txtWorkType.Location = New System.Drawing.Point(58, 55)
        Me.txtWorkType.MaxLength = 2
        Me.txtWorkType.Name = "txtWorkType"
        Me.txtWorkType.Size = New System.Drawing.Size(170, 21)
        Me.txtWorkType.TabIndex = 113
        Me.txtWorkType.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "班次"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 18)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "开始日期"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 6)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 117
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtDeptCode
        '
        Me.txtDeptCode.Location = New System.Drawing.Point(58, 6)
        Me.txtDeptCode.Name = "txtDeptCode"
        Me.txtDeptCode.Size = New System.Drawing.Size(170, 20)
        Me.txtDeptCode.TabIndex = 118
        '
        'txtTime
        '
        Me.txtTime.CustomFormat = "yyyy/MM/dd"
        Me.txtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTime.Location = New System.Drawing.Point(58, 30)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(170, 21)
        Me.txtTime.TabIndex = 119
        '
        'txtDayNightMark
        '
        Me.txtDayNightMark.Location = New System.Drawing.Point(58, 80)
        Me.txtDayNightMark.Name = "txtDayNightMark"
        Me.txtDayNightMark.Size = New System.Drawing.Size(170, 20)
        Me.txtDayNightMark.TabIndex = 120
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 18)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "白夜班"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "部门名称"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmWorkBegin_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(230, 137)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.Label4, Me.txtDayNightMark, Me.txtTime, Me.txtDeptCode, Me.btQuit, Me.btSave, Me.btAdd, Me.txtWorkType, Me.Label3, Me.Label2, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWorkBegin_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "班次及起始时间信息_增加"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim ds1 As New DataSet()
        Dim ds2 As New DataSet()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select Dept_Code,Dept_Name from Department where dept_code like '" & G_DeptCode & "%'"
        dw = Getdata(sqlstr, ds1)
        txtDeptCode.DataSource = ds1.Tables(0).DefaultView
        txtDeptCode.DisplayMember = "Dept_Name"
        txtDeptCode.ValueMember = "Dept_Code"

        sqlstr = "select Code_WorkTime,WorkTime from Code_WorkTime order by WorkTime_ID "
        dw = Getdata(sqlstr, ds2)
        txtDayNightMark.DataSource = ds2.Tables(0).DefaultView
        txtDayNightMark.DisplayMember = "WorkTime"
        txtDayNightMark.ValueMember = "Code_WorkTime"

        sqlstr = "select * from Work_Begin where WORK_BEGIN_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("WORK_BEGIN_ID")
            txtDeptCode.SelectedValue = ds.Tables(0).Rows(0).Item("Dept_Code")
            txtTime.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")
            txtWorkType.Text = ds.Tables(0).Rows(0).Item("WORK_TYPE")
            txtDayNightMark.SelectedValue = ds.Tables(0).Rows(0).Item("DayNightMark")
        End If


        txtDeptCode.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        txtWorkType.Text = ""
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim dsSave As New DataSet()
            If Getdata("select * from Work_Begin where Dept_Code='" & Trim(txtDeptCode.SelectedValue) & "' and Work_Type='" & Trim(txtWorkType.Text) & "'", dsSave).Count > 0 Then
                MsgBox("可能已存在此班次信息,请注意检查!")
                Exit Sub
            End If
            If Len(Trim(txtDeptCode.Text)) > 0 And Len(Trim(txtWorkType.Text)) > 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()

                row("Dept_Code") = Trim(txtDeptCode.SelectedValue)
                row("Time_From") = txtTime.Value
                row("Work_Type") = Trim(txtWorkType.Text)
                row("DayNightMark") = Trim(txtDayNightMark.SelectedValue)
                row("USER_NAME") = G_User

                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
                Me.Close()
            Else
                MsgBox("部门 班次 不能为空!", MsgBoxStyle.Critical, "提示")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtDeptCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDeptCode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtTime.Focus()
        End If
    End Sub

    Private Sub txtTime_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTime.KeyPress
        If e.KeyChar = Chr(13) Then
            txtWorkType.Focus()
        End If
    End Sub
    Private Sub txtWorkType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWorkType.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDayNightMark.Focus()
        End If
    End Sub
    Private Sub txtDayNightMark_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDayNightMark.KeyPress
        If e.KeyChar = Chr(13) Then
            btSave.Focus()
        End If
    End Sub
End Class
