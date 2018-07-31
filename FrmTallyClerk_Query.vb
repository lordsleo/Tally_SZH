Imports TALLY.DBControl
Public Class FrmTallyClerk_Query
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()

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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDeptCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtKNOWLEDGE As System.Windows.Forms.ComboBox
    Friend WithEvents txtWorkType As System.Windows.Forms.ComboBox
    Friend WithEvents txtTECHNICAL As System.Windows.Forms.ComboBox
    Friend WithEvents txtDuty As System.Windows.Forms.ComboBox
    Friend WithEvents txtTallyTeam As System.Windows.Forms.ComboBox
    Friend WithEvents txtSex As System.Windows.Forms.ComboBox
    Friend WithEvents txtBirthDay As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSTATION As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMOBILE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtWorkNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDeptCode = New System.Windows.Forms.ComboBox()
        Me.txtKNOWLEDGE = New System.Windows.Forms.ComboBox()
        Me.txtWorkType = New System.Windows.Forms.ComboBox()
        Me.txtTECHNICAL = New System.Windows.Forms.ComboBox()
        Me.txtDuty = New System.Windows.Forms.ComboBox()
        Me.txtTallyTeam = New System.Windows.Forms.ComboBox()
        Me.txtSex = New System.Windows.Forms.ComboBox()
        Me.txtBirthDay = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEMAIL = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSTATION = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMOBILE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtWorkNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(2, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 18)
        Me.Label13.TabIndex = 253
        Me.Label13.Text = "部门"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(242, 166)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 18)
        Me.Label14.TabIndex = 252
        Me.Label14.Text = "上岗证书"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(246, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 18)
        Me.Label15.TabIndex = 251
        Me.Label15.Text = "手机"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(2, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 18)
        Me.Label16.TabIndex = 250
        Me.Label16.Text = "电话"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDeptCode
        '
        Me.txtDeptCode.Location = New System.Drawing.Point(62, 112)
        Me.txtDeptCode.Name = "txtDeptCode"
        Me.txtDeptCode.Size = New System.Drawing.Size(178, 20)
        Me.txtDeptCode.TabIndex = 249
        '
        'txtKNOWLEDGE
        '
        Me.txtKNOWLEDGE.Location = New System.Drawing.Point(298, 112)
        Me.txtKNOWLEDGE.Name = "txtKNOWLEDGE"
        Me.txtKNOWLEDGE.Size = New System.Drawing.Size(178, 20)
        Me.txtKNOWLEDGE.TabIndex = 248
        '
        'txtWorkType
        '
        Me.txtWorkType.Location = New System.Drawing.Point(298, 84)
        Me.txtWorkType.Name = "txtWorkType"
        Me.txtWorkType.Size = New System.Drawing.Size(178, 20)
        Me.txtWorkType.TabIndex = 247
        '
        'txtTECHNICAL
        '
        Me.txtTECHNICAL.Location = New System.Drawing.Point(298, 58)
        Me.txtTECHNICAL.Name = "txtTECHNICAL"
        Me.txtTECHNICAL.Size = New System.Drawing.Size(178, 20)
        Me.txtTECHNICAL.TabIndex = 246
        '
        'txtDuty
        '
        Me.txtDuty.Location = New System.Drawing.Point(298, 30)
        Me.txtDuty.Name = "txtDuty"
        Me.txtDuty.Size = New System.Drawing.Size(178, 20)
        Me.txtDuty.TabIndex = 245
        '
        'txtTallyTeam
        '
        Me.txtTallyTeam.Location = New System.Drawing.Point(62, 138)
        Me.txtTallyTeam.Name = "txtTallyTeam"
        Me.txtTallyTeam.Size = New System.Drawing.Size(178, 20)
        Me.txtTallyTeam.TabIndex = 244
        '
        'txtSex
        '
        Me.txtSex.Location = New System.Drawing.Point(62, 58)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(178, 20)
        Me.txtSex.TabIndex = 243
        '
        'txtBirthDay
        '
        Me.txtBirthDay.CustomFormat = "yyyy/MM/dd"
        Me.txtBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtBirthDay.Location = New System.Drawing.Point(62, 84)
        Me.txtBirthDay.Name = "txtBirthDay"
        Me.txtBirthDay.Size = New System.Drawing.Size(178, 21)
        Me.txtBirthDay.TabIndex = 242
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(2, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 22)
        Me.Label11.TabIndex = 241
        Me.Label11.Text = "住址"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(246, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 18)
        Me.Label6.TabIndex = 240
        Me.Label6.Text = "E_MAIL"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(246, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 239
        Me.Label7.Text = "学历"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(246, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 18)
        Me.Label8.TabIndex = 238
        Me.Label8.Text = "工种"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEMAIL
        '
        Me.txtEMAIL.Location = New System.Drawing.Point(298, 138)
        Me.txtEMAIL.MaxLength = 40
        Me.txtEMAIL.Name = "txtEMAIL"
        Me.txtEMAIL.Size = New System.Drawing.Size(178, 21)
        Me.txtEMAIL.TabIndex = 237
        Me.txtEMAIL.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(246, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 18)
        Me.Label9.TabIndex = 236
        Me.Label9.Text = "职称"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSTATION
        '
        Me.txtSTATION.Location = New System.Drawing.Point(298, 166)
        Me.txtSTATION.MaxLength = 20
        Me.txtSTATION.Name = "txtSTATION"
        Me.txtSTATION.Size = New System.Drawing.Size(178, 21)
        Me.txtSTATION.TabIndex = 235
        Me.txtSTATION.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(246, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 18)
        Me.Label10.TabIndex = 234
        Me.Label10.Text = "职务"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(62, 166)
        Me.txtAddress.MaxLength = 40
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(178, 21)
        Me.txtAddress.TabIndex = 233
        Me.txtAddress.Text = ""
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(207, 226)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 231
        Me.btQuit.Text = "返回"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(62, 196)
        Me.txtTelephone.MaxLength = 20
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(178, 21)
        Me.txtTelephone.TabIndex = 229
        Me.txtTelephone.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 228
        Me.Label5.Text = "所在班次"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 227
        Me.Label4.Text = "出生日期"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMOBILE
        '
        Me.txtMOBILE.Location = New System.Drawing.Point(298, 2)
        Me.txtMOBILE.MaxLength = 20
        Me.txtMOBILE.Name = "txtMOBILE"
        Me.txtMOBILE.Size = New System.Drawing.Size(178, 21)
        Me.txtMOBILE.TabIndex = 226
        Me.txtMOBILE.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 225
        Me.Label3.Text = "性别"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWorkNo
        '
        Me.txtWorkNo.Location = New System.Drawing.Point(62, 30)
        Me.txtWorkNo.MaxLength = 10
        Me.txtWorkNo.Name = "txtWorkNo"
        Me.txtWorkNo.Size = New System.Drawing.Size(178, 21)
        Me.txtWorkNo.TabIndex = 224
        Me.txtWorkNo.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 223
        Me.Label2.Text = "工号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(62, 2)
        Me.txtName.MaxLength = 10
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(178, 21)
        Me.txtName.TabIndex = 222
        Me.txtName.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 221
        Me.Label1.Text = "姓名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(4, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 232
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'FrmTallyClerk_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(478, 253)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.txtDeptCode, Me.txtKNOWLEDGE, Me.txtWorkType, Me.txtTECHNICAL, Me.txtDuty, Me.txtTallyTeam, Me.txtSex, Me.txtBirthDay, Me.Label11, Me.Label6, Me.Label7, Me.Label8, Me.txtEMAIL, Me.Label9, Me.txtSTATION, Me.Label10, Me.txtAddress, Me.btQuit, Me.txtTelephone, Me.Label5, Me.Label4, Me.txtMOBILE, Me.Label3, Me.txtWorkNo, Me.Label2, Me.txtName, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTallyClerk_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "员工信息_查看"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = Chr(13) Then
            txtWorkNo.Focus()
        End If
    End Sub
    Private Sub txtWorkNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWorkNo.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSex.Focus()
        End If
    End Sub
    Private Sub txtSex_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSex.KeyPress
        If e.KeyChar = Chr(13) Then
            txtBirthDay.Focus()
        End If
    End Sub

    Private Sub txtBirthDay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBirthDay.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDeptCode.Focus()
        End If
    End Sub

    Private Sub txtDeptCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDeptCode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtTallyTeam.Focus()
        End If
    End Sub

    Private Sub txtTallyTeam_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTallyTeam.KeyPress
        If e.KeyChar = Chr(13) Then
            txtAddress.Focus()
        End If
    End Sub

    Private Sub txtAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddress.KeyPress
        If e.KeyChar = Chr(13) Then
            txtTelephone.Focus()
        End If
    End Sub

    Private Sub txtTelephone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelephone.KeyPress
        If e.KeyChar = Chr(13) Then
            txtMOBILE.Focus()
        End If
    End Sub

    Private Sub txtMOBILE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMOBILE.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDuty.Focus()
        End If
    End Sub

    Private Sub txtDuty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDuty.KeyPress
        If e.KeyChar = Chr(13) Then
            txtTECHNICAL.Focus()
        End If
    End Sub

    Private Sub txtTECHNICAL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTECHNICAL.KeyPress
        If e.KeyChar = Chr(13) Then
            txtWorkType.Focus()
        End If
    End Sub

    Private Sub txtWorkType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWorkType.KeyPress
        If e.KeyChar = Chr(13) Then
            txtKNOWLEDGE.Focus()
        End If
    End Sub
    Private Sub txtKNOWLEDGE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKNOWLEDGE.KeyPress
        If e.KeyChar = Chr(13) Then
            txtEMAIL.Focus()
        End If
    End Sub

    Private Sub txtEMAIL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEMAIL.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSTATION.Focus()
        End If
    End Sub

    Private Sub txtSTATION_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSTATION.KeyPress
        If e.KeyChar = Chr(13) Then
            btQuit.Focus()
        End If
    End Sub
    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim ds1 As New DataSet()
        Dim ds2 As New DataSet()
        Dim ds3 As New DataSet()
        Dim ds4 As New DataSet()
        Dim ds5 As New DataSet()
        Dim ds6 As New DataSet()
        Dim ds7 As New DataSet()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select Code_Sex,Sex from Code_Sex"
        dw = Getdata(sqlstr, ds1)
        txtSex.DataSource = ds1.Tables(0).DefaultView
        txtSex.DisplayMember = "Sex"
        txtSex.ValueMember = "Code_Sex"

        sqlstr = "select Dept_Code,Dept_Name From DepartMent "
        dw = Getdata(sqlstr, ds2)
        txtDeptCode.DataSource = ds2.Tables(0).DefaultView
        txtDeptCode.DisplayMember = "Dept_Name"
        txtDeptCode.ValueMember = "Dept_Code"

        sqlstr = "select Distinct Work_Type,Work_Type From Work_Begin "
        dw = Getdata(sqlstr, ds3)
        txtTallyTeam.DataSource = ds3.Tables(0).DefaultView
        txtTallyTeam.DisplayMember = "Work_Type"
        txtTallyTeam.ValueMember = "Work_Type"

        sqlstr = "select Code_Duty,Duty_CHA From Code_Duty "
        dw = Getdata(sqlstr, ds4)
        txtDuty.DataSource = ds4.Tables(0).DefaultView
        txtDuty.DisplayMember = "Duty_CHA"
        txtDuty.ValueMember = "Code_Duty"

        sqlstr = "select Code_TECHNICAL_POSITION,TECHNICAL_POSITION From Code_TECHNICAL_POSITION "
        dw = Getdata(sqlstr, ds5)
        txtTECHNICAL.DataSource = ds5.Tables(0).DefaultView
        txtTECHNICAL.DisplayMember = "TECHNICAL_POSITION"
        txtTECHNICAL.ValueMember = "Code_TECHNICAL_POSITION"

        sqlstr = "select Code_WORK_TYPE,WORK_TYPE From Code_WORK_TYPE "
        dw = Getdata(sqlstr, ds6)
        txtWorkType.DataSource = ds6.Tables(0).DefaultView
        txtWorkType.DisplayMember = "WORK_TYPE"
        txtWorkType.ValueMember = "Code_WORK_TYPE"

        sqlstr = "select Code_KNOWLEDGE,KNOWLEDGE from Code_KNOWLEDGE"
        dw = Getdata(sqlstr, ds7)
        txtKNOWLEDGE.DataSource = ds7.Tables(0).DefaultView
        txtKNOWLEDGE.DisplayMember = "KNOWLEDGE"
        txtKNOWLEDGE.ValueMember = "Code_KNOWLEDGE"

        sqlstr = "select * from TALLY_CLERK where TALLY_CLERK_ID=" & ID & ""

        dw = Getdata(sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("TALLY_CLERK_ID")
            txtName.Text = ds.Tables(0).Rows(0).Item("Name")
            txtWorkNo.Text = ds.Tables(0).Rows(0).Item("Work_No")
            txtSex.SelectedValue = ds.Tables(0).Rows(0).Item("Code_SEX")
            txtBirthDay.Value = ds.Tables(0).Rows(0).Item("BIRTHDAY")
            txtDeptCode.SelectedValue = ds.Tables(0).Rows(0).Item("DEPT_CODE")
            txtTallyTeam.SelectedValue = ds.Tables(0).Rows(0).Item("TALLY_TEAM")
            txtAddress.Text = ds.Tables(0).Rows(0).Item("ADDRESS")
            txtTelephone.Text = ds.Tables(0).Rows(0).Item("TELEPHONE")
            txtMOBILE.Text = ds.Tables(0).Rows(0).Item("MOBILE")
            txtDuty.SelectedValue = ds.Tables(0).Rows(0).Item("code_DUTY")
            txtTECHNICAL.SelectedValue = ds.Tables(0).Rows(0).Item("code_TECHNICAL_POSITION")
            txtWorkType.SelectedValue = ds.Tables(0).Rows(0).Item("code_WORK_TYPE")
            txtKNOWLEDGE.SelectedValue = ds.Tables(0).Rows(0).Item("code_KNOWLEDGE")
            txtEMAIL.Text = ds.Tables(0).Rows(0).Item("E_MAIL")
            txtSTATION.Text = ds.Tables(0).Rows(0).Item("STATION_CERTIFICATE")


        End If


        txtName.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub
    
    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
