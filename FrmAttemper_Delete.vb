Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmAttemper_Delete
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
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtREMARK As System.Windows.Forms.TextBox
    Friend WithEvents DTPWATCHDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbWORK_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbWeather As System.Windows.Forms.ComboBox
    Friend WithEvents TxtITEM As System.Windows.Forms.TextBox
    Friend WithEvents CmbWATCH_DIRECTOR As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDIRECTOR As System.Windows.Forms.ComboBox
    Friend WithEvents TxtWATCH_ID As System.Windows.Forms.TextBox
    Friend WithEvents TxtUSER_NAME As System.Windows.Forms.TextBox
    Friend WithEvents CmbDAYNIGHTMARK As System.Windows.Forms.ComboBox
    Friend WithEvents TxtLock_Mark As System.Windows.Forms.TextBox
    Friend WithEvents CmbPIECE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox()
        Me.DTPWATCHDATE = New System.Windows.Forms.DateTimePicker()
        Me.CmbDAYNIGHTMARK = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtITEM = New System.Windows.Forms.TextBox()
        Me.TxtREMARK = New System.Windows.Forms.TextBox()
        Me.CmbWATCH_DIRECTOR = New System.Windows.Forms.ComboBox()
        Me.CmbDIRECTOR = New System.Windows.Forms.ComboBox()
        Me.CmbWORK_TYPE = New System.Windows.Forms.ComboBox()
        Me.TxtWATCH_ID = New System.Windows.Forms.TextBox()
        Me.CmbWeather = New System.Windows.Forms.ComboBox()
        Me.TxtUSER_NAME = New System.Windows.Forms.TextBox()
        Me.TxtLock_Mark = New System.Windows.Forms.TextBox()
        Me.CmbPIECE = New System.Windows.Forms.ComboBox()
        Me.GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB
        '
        Me.GB.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GB.Controls.AddRange(New System.Windows.Forms.Control() {Me.CmbDEPT_CODE, Me.DTPWATCHDATE, Me.CmbDAYNIGHTMARK, Me.Label1, Me.btnQuit, Me.btnSave, Me.Label2, Me.Label4, Me.Label7, Me.Label15, Me.Label16, Me.Label19, Me.Label20, Me.TxtITEM, Me.TxtREMARK, Me.CmbWATCH_DIRECTOR, Me.CmbDIRECTOR, Me.CmbWORK_TYPE, Me.TxtWATCH_ID, Me.CmbWeather, Me.TxtUSER_NAME, Me.TxtLock_Mark})
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(572, 174)
        Me.GB.TabIndex = 0
        Me.GB.TabStop = False
        Me.GB.Text = "值班记录"
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEPT_CODE.Enabled = False
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(80, 142)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(54, 20)
        Me.CmbDEPT_CODE.TabIndex = 36
        Me.CmbDEPT_CODE.Visible = False
        '
        'DTPWATCHDATE
        '
        Me.DTPWATCHDATE.CustomFormat = "yyyy/MM/dd"
        Me.DTPWATCHDATE.Enabled = False
        Me.DTPWATCHDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWATCHDATE.Location = New System.Drawing.Point(84, 12)
        Me.DTPWATCHDATE.Name = "DTPWATCHDATE"
        Me.DTPWATCHDATE.Size = New System.Drawing.Size(112, 21)
        Me.DTPWATCHDATE.TabIndex = 2
        '
        'CmbDAYNIGHTMARK
        '
        Me.CmbDAYNIGHTMARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDAYNIGHTMARK.Enabled = False
        Me.CmbDAYNIGHTMARK.Location = New System.Drawing.Point(268, 35)
        Me.CmbDAYNIGHTMARK.Name = "CmbDAYNIGHTMARK"
        Me.CmbDAYNIGHTMARK.Size = New System.Drawing.Size(114, 20)
        Me.CmbDAYNIGHTMARK.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "日期"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(289, 139)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(65, 24)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "取消"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(219, 139)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "确定"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(202, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "班次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(202, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "班别"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 36)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "交接班事项"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(387, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 20)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "值班主任"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(387, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 20)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "接班主任"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(6, 94)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 36)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "备注"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(6, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 20)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "天气"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtITEM
        '
        Me.TxtITEM.Location = New System.Drawing.Point(82, 55)
        Me.TxtITEM.MaxLength = 200
        Me.TxtITEM.Multiline = True
        Me.TxtITEM.Name = "TxtITEM"
        Me.TxtITEM.ReadOnly = True
        Me.TxtITEM.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtITEM.Size = New System.Drawing.Size(488, 37)
        Me.TxtITEM.TabIndex = 8
        Me.TxtITEM.Text = ""
        '
        'TxtREMARK
        '
        Me.TxtREMARK.Location = New System.Drawing.Point(82, 93)
        Me.TxtREMARK.MaxLength = 100
        Me.TxtREMARK.Multiline = True
        Me.TxtREMARK.Name = "TxtREMARK"
        Me.TxtREMARK.ReadOnly = True
        Me.TxtREMARK.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtREMARK.Size = New System.Drawing.Size(488, 37)
        Me.TxtREMARK.TabIndex = 9
        Me.TxtREMARK.Text = ""
        '
        'CmbWATCH_DIRECTOR
        '
        Me.CmbWATCH_DIRECTOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWATCH_DIRECTOR.Enabled = False
        Me.CmbWATCH_DIRECTOR.Location = New System.Drawing.Point(456, 14)
        Me.CmbWATCH_DIRECTOR.Name = "CmbWATCH_DIRECTOR"
        Me.CmbWATCH_DIRECTOR.Size = New System.Drawing.Size(112, 20)
        Me.CmbWATCH_DIRECTOR.TabIndex = 6
        '
        'CmbDIRECTOR
        '
        Me.CmbDIRECTOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDIRECTOR.Enabled = False
        Me.CmbDIRECTOR.Location = New System.Drawing.Point(456, 35)
        Me.CmbDIRECTOR.Name = "CmbDIRECTOR"
        Me.CmbDIRECTOR.Size = New System.Drawing.Size(112, 20)
        Me.CmbDIRECTOR.TabIndex = 7
        '
        'CmbWORK_TYPE
        '
        Me.CmbWORK_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWORK_TYPE.Enabled = False
        Me.CmbWORK_TYPE.Location = New System.Drawing.Point(268, 14)
        Me.CmbWORK_TYPE.Name = "CmbWORK_TYPE"
        Me.CmbWORK_TYPE.Size = New System.Drawing.Size(114, 20)
        Me.CmbWORK_TYPE.TabIndex = 4
        '
        'TxtWATCH_ID
        '
        Me.TxtWATCH_ID.Location = New System.Drawing.Point(8, 142)
        Me.TxtWATCH_ID.MaxLength = 4
        Me.TxtWATCH_ID.Name = "TxtWATCH_ID"
        Me.TxtWATCH_ID.ReadOnly = True
        Me.TxtWATCH_ID.Size = New System.Drawing.Size(22, 21)
        Me.TxtWATCH_ID.TabIndex = 34
        Me.TxtWATCH_ID.TabStop = False
        Me.TxtWATCH_ID.Text = ""
        Me.TxtWATCH_ID.Visible = False
        '
        'CmbWeather
        '
        Me.CmbWeather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWeather.Enabled = False
        Me.CmbWeather.Location = New System.Drawing.Point(84, 35)
        Me.CmbWeather.Name = "CmbWeather"
        Me.CmbWeather.Size = New System.Drawing.Size(112, 20)
        Me.CmbWeather.TabIndex = 3
        '
        'TxtUSER_NAME
        '
        Me.TxtUSER_NAME.Location = New System.Drawing.Point(32, 142)
        Me.TxtUSER_NAME.MaxLength = 4
        Me.TxtUSER_NAME.Name = "TxtUSER_NAME"
        Me.TxtUSER_NAME.ReadOnly = True
        Me.TxtUSER_NAME.Size = New System.Drawing.Size(22, 21)
        Me.TxtUSER_NAME.TabIndex = 35
        Me.TxtUSER_NAME.TabStop = False
        Me.TxtUSER_NAME.Text = ""
        Me.TxtUSER_NAME.Visible = False
        '
        'TxtLock_Mark
        '
        Me.TxtLock_Mark.Location = New System.Drawing.Point(56, 142)
        Me.TxtLock_Mark.MaxLength = 4
        Me.TxtLock_Mark.Name = "TxtLock_Mark"
        Me.TxtLock_Mark.ReadOnly = True
        Me.TxtLock_Mark.Size = New System.Drawing.Size(22, 21)
        Me.TxtLock_Mark.TabIndex = 35
        Me.TxtLock_Mark.TabStop = False
        Me.TxtLock_Mark.Text = ""
        Me.TxtLock_Mark.Visible = False
        '
        'CmbPIECE
        '
        Me.CmbPIECE.Location = New System.Drawing.Point(174, 68)
        Me.CmbPIECE.Name = "CmbPIECE"
        Me.CmbPIECE.Size = New System.Drawing.Size(98, 20)
        Me.CmbPIECE.TabIndex = 1
        '
        'FrmAttemper_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(574, 175)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GB})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAttemper_Delete"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "值班调度_删除"
        Me.GB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim ds_sub As New DataSet()
    Dim dw As New DataView()
    Dim dw_sub As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim sqlda_sub As New SqlClient.SqlDataAdapter()

    Dim SqlStr As String  '条件语句

    Private Sub FrmAttemper_Delete_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Call FillWeather()
        Call FillWORK_TYPE()
        Call FillDAYNIGHTMARK()
        Call FillWATCH_DIRECTOR()
        Call FillDIRECTOR()
        Call FillDEPT_CODE()
        If G_DeptCode = "26.11" Then
            Label15.Text = "值班调度"
            Label16.Text = "值班调度"
        Else
            Label15.Text = "值班主任"
            Label16.Text = "值班主任"
        End If
        SqlStr = "select * from WATCH_RECORD where WATCH_ID=" & ID & ""
        dw = Updatedata(sqlda, SqlStr, ds)
        If dw.Count > 0 Then
            TxtWATCH_ID.Text = ds.Tables(0).Rows(0).Item("WATCH_ID")
            TxtLock_Mark.Text = ds.Tables(0).Rows(0).Item("Lock_Mark")
            TxtUSER_NAME.Text = Trim(G_User)
            CmbDEPT_CODE.SelectedValue = Trim(G_DeptCode)

            DTPWATCHDATE.Value = ds.Tables(0).Rows(0).Item("WATCHDATE")
            CmbWeather.SelectedValue = ds.Tables(0).Rows(0).Item("WEATHER")
            CmbWORK_TYPE.SelectedValue = ds.Tables(0).Rows(0).Item("WORK_TYPE")
            CmbDAYNIGHTMARK.SelectedValue = ds.Tables(0).Rows(0).Item("DayNightMark")
            CmbWATCH_DIRECTOR.SelectedValue = ds.Tables(0).Rows(0).Item("WATCH_DIRECTOR")
            CmbDIRECTOR.SelectedValue = ds.Tables(0).Rows(0).Item("DIRECTOR")
            TxtITEM.Text = ds.Tables(0).Rows(0).Item("ITEM")
            TxtREMARK.Text = ds.Tables(0).Rows(0).Item("REMARK")

        End If
        DTPWATCHDATE.Focus()
        Exit Sub
Err:
        Resume Next

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If MsgBox("你确认要删除吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "删除", "WATCH_RECORD", Trim(TxtWATCH_ID.Text), "WATCH_ID")

                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)



                Call btnQuit_Click(sender, e)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillWeather()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select Code_Weather,Weather from Code_Weather"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbWeather.DataSource = dvc
        Me.CmbWeather.DisplayMember = "Weather"
        Me.CmbWeather.ValueMember = "Code_Weather"
    End Sub

    Private Sub FillWORK_TYPE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "SELECT WORK_TYPE FROM WORK_BEGIN WHERE DEPT_CODE='" & G_DeptCode & "' ORDER BY TIME_FROM, DayNightMark"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbWORK_TYPE.DataSource = dvc
        Me.CmbWORK_TYPE.DisplayMember = "WORK_TYPE"
        Me.CmbWORK_TYPE.ValueMember = "WORK_TYPE"
    End Sub

    Private Sub FillWATCH_DIRECTOR()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "SELECT Code_Director,Director FROM Code_Director WHERE DEPT_CODE ='" & G_DeptCode & "'"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbWATCH_DIRECTOR.DataSource = dvc
        Me.CmbWATCH_DIRECTOR.DisplayMember = "Director"
        Me.CmbWATCH_DIRECTOR.ValueMember = "Code_Director"
    End Sub

    Private Sub FillDIRECTOR()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "SELECT Code_Director,Director FROM Code_Director WHERE DEPT_CODE ='" & G_DeptCode & "'"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDIRECTOR.DataSource = dvc
        Me.CmbDIRECTOR.DisplayMember = "Director"
        Me.CmbDIRECTOR.ValueMember = "Code_Director"
    End Sub

    Private Sub FillDAYNIGHTMARK()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "SELECT Code_WorkTime,WorkTime FROM Code_WorkTime"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDAYNIGHTMARK.DataSource = dvc
        Me.CmbDAYNIGHTMARK.DisplayMember = "WorkTime"
        Me.CmbDAYNIGHTMARK.ValueMember = "Code_WorkTime"
    End Sub

    Private Sub FillDEPT_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDEPT_CODE.DataSource = dvc
        Me.CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE.ValueMember = "DEPT_CODE"
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnQuit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnQuit.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub GB_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GB.Enter

    End Sub
End Class
