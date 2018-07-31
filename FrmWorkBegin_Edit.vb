Imports TALLY.DBControl
Public Class FrmWorkBegin_Edit
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDayNightMark As System.Windows.Forms.ComboBox
    Friend WithEvents txtTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDeptCode As System.Windows.Forms.ComboBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtWorkType As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btResume As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDayNightMark = New System.Windows.Forms.ComboBox()
        Me.txtTime = New System.Windows.Forms.DateTimePicker()
        Me.txtDeptCode = New System.Windows.Forms.ComboBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btResume = New System.Windows.Forms.Button()
        Me.txtWorkType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 18)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "白夜班"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "部门名称"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDayNightMark
        '
        Me.txtDayNightMark.Location = New System.Drawing.Point(58, 76)
        Me.txtDayNightMark.Name = "txtDayNightMark"
        Me.txtDayNightMark.Size = New System.Drawing.Size(170, 20)
        Me.txtDayNightMark.TabIndex = 132
        '
        'txtTime
        '
        Me.txtTime.CustomFormat = "yyyy/MM/dd"
        Me.txtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTime.Location = New System.Drawing.Point(58, 26)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(170, 21)
        Me.txtTime.TabIndex = 131
        '
        'txtDeptCode
        '
        Me.txtDeptCode.Location = New System.Drawing.Point(58, 2)
        Me.txtDeptCode.Name = "txtDeptCode"
        Me.txtDeptCode.Size = New System.Drawing.Size(170, 20)
        Me.txtDeptCode.TabIndex = 130
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(117, 106)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 128
        Me.btQuit.Text = "取消"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(49, 106)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 127
        Me.btResume.Text = "确认"
        '
        'txtWorkType
        '
        Me.txtWorkType.Location = New System.Drawing.Point(58, 50)
        Me.txtWorkType.MaxLength = 2
        Me.txtWorkType.Name = "txtWorkType"
        Me.txtWorkType.Size = New System.Drawing.Size(170, 21)
        Me.txtWorkType.TabIndex = 125
        Me.txtWorkType.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "班次"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 18)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "开始日期"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 129
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'FrmWorkBegin_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(230, 133)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.Label4, Me.txtDayNightMark, Me.txtTime, Me.txtDeptCode, Me.btQuit, Me.btResume, Me.txtWorkType, Me.Label3, Me.Label2, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWorkBegin_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "班次及起始时间信息_编辑"
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

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "修改", "Work_Begin", Trim(txtID.Text), "WORK_BEGIN_ID")

                ds.Tables(0).Rows(0).Item("Dept_Code") = Trim(txtDeptCode.SelectedValue)
                ds.Tables(0).Rows(0).Item("Time_From") = txtTime.Value
                ds.Tables(0).Rows(0).Item("Work_Type") = Trim(txtWorkType.Text)
                ds.Tables(0).Rows(0).Item("DayNightMark") = Trim(txtDayNightMark.SelectedValue)

                sqlda.Update(ds)
                Me.Close()

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
            btResume.Focus()
        End If
    End Sub
End Class
