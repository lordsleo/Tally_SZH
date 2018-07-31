Imports TALLY.DBControl
Public Class FrmDepartMent_ADD
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
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDept_Code As System.Windows.Forms.TextBox
    Friend WithEvents txtDept_Name As System.Windows.Forms.TextBox
    Friend WithEvents txtDept_Short As System.Windows.Forms.TextBox
    Friend WithEvents txtDept_Manag As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTallyDept As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDept_Code = New System.Windows.Forms.TextBox()
        Me.txtDept_Name = New System.Windows.Forms.TextBox()
        Me.txtDept_Short = New System.Windows.Forms.TextBox()
        Me.txtDept_Manag = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTallyDept = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(150, 140)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 93
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(82, 140)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 92
        Me.btSave.Text = "确认"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(14, 140)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 91
        Me.btAdd.Text = "清空"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(4, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 90
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "部门代码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "部门名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "部门简称"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "部门负责人"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDept_Code
        '
        Me.txtDept_Code.Location = New System.Drawing.Point(86, 6)
        Me.txtDept_Code.MaxLength = 12
        Me.txtDept_Code.Name = "txtDept_Code"
        Me.txtDept_Code.Size = New System.Drawing.Size(130, 21)
        Me.txtDept_Code.TabIndex = 99
        Me.txtDept_Code.Text = ""
        '
        'txtDept_Name
        '
        Me.txtDept_Name.Location = New System.Drawing.Point(86, 30)
        Me.txtDept_Name.MaxLength = 40
        Me.txtDept_Name.Name = "txtDept_Name"
        Me.txtDept_Name.Size = New System.Drawing.Size(130, 21)
        Me.txtDept_Name.TabIndex = 100
        Me.txtDept_Name.Text = ""
        '
        'txtDept_Short
        '
        Me.txtDept_Short.Location = New System.Drawing.Point(86, 54)
        Me.txtDept_Short.MaxLength = 2
        Me.txtDept_Short.Name = "txtDept_Short"
        Me.txtDept_Short.Size = New System.Drawing.Size(130, 21)
        Me.txtDept_Short.TabIndex = 101
        Me.txtDept_Short.Text = ""
        '
        'txtDept_Manag
        '
        Me.txtDept_Manag.Location = New System.Drawing.Point(86, 78)
        Me.txtDept_Manag.MaxLength = 8
        Me.txtDept_Manag.Name = "txtDept_Manag"
        Me.txtDept_Manag.Size = New System.Drawing.Size(130, 21)
        Me.txtDept_Manag.TabIndex = 102
        Me.txtDept_Manag.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "理货部标志"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTallyDept
        '
        Me.txtTallyDept.Location = New System.Drawing.Point(86, 102)
        Me.txtTallyDept.Name = "txtTallyDept"
        Me.txtTallyDept.Size = New System.Drawing.Size(130, 20)
        Me.txtTallyDept.TabIndex = 104
        '
        'FrmDepartMent_ADD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(232, 169)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtTallyDept, Me.Label5, Me.txtDept_Manag, Me.txtDept_Short, Me.txtDept_Name, Me.txtDept_Code, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.btQuit, Me.btSave, Me.btAdd, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDepartMent_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "部门信息_增加"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtDept_Code_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDept_Code.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDept_Name.Focus()
        End If
    End Sub
    Private Sub txtDept_Name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDept_Name.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDept_Short.Focus()
        End If
    End Sub
    Private Sub txtDept_Short_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDept_Short.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDept_Manag.Focus()
        End If
    End Sub
    Private Sub txtDept_Manag_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDept_Manag.KeyPress
        If e.KeyChar = Chr(13) Then
            Call btSave_Click(sender, e)
            txtDept_Code.Focus()
        End If
    End Sub

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim ds1 As New DataSet()
        Dim sqlstr As String

        Me.StartPosition = FormStartPosition.CenterScreen

        sqlstr = "select Value,DESCRi from CodeLiner_ID Order by Value"
        dw = Getdata(sqlstr, ds1)
        txtTallyDept.DataSource = ds1.Tables(0).DefaultView
        txtTallyDept.DisplayMember = "DESCRi"
        txtTallyDept.ValueMember = "Value"

        sqlstr = "select * from DepartMent where DepartMent_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("DepartMent_ID")
            txtDept_Code.Text = ds.Tables(0).Rows(0).Item("Dept_Code")
            txtDept_Name.Text = ds.Tables(0).Rows(0).Item("Dept_Name")
            txtDept_Short.Text = ds.Tables(0).Rows(0).Item("Dept_Short")
            txtDept_Manag.Text = ds.Tables(0).Rows(0).Item("Dept_Manag")
            txtTallyDept.SelectedValue = ds.Tables(0).Rows(0).Item("TallyDept")
        End If


        txtDept_Code.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        txtDept_Name.Text = ""
        txtDept_Short.Text = ""
        txtDept_Manag.Text = ""
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim dsSave As New DataSet()
            If Getdata("select * from DepartMent where Dept_Code='" & Trim(txtDept_Code.Text) & "'", dsSave).Count > 0 Then
                MsgBox("可能已存在此部门信息,请注意检查!")
                Exit Sub
            End If
            If Len(Trim(txtDept_Code.Text)) > 0 And Len(Trim(txtDept_Name.Text)) > 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()

                row("Dept_Code") = Trim(txtDept_Code.Text)
                row("Dept_Name") = Trim(txtDept_Name.Text)
                row("Dept_Short") = Trim(txtDept_Short.Text)
                row("TallyDept") = Trim(txtTallyDept.SelectedValue)
                row("Dept_Manag") = Trim(txtDept_Manag.Text)
                row("User_Name") = Trim(G_User)
                row("System") = "0"

                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
                Me.Close()
            Else
                MsgBox("部门代码不能为空!", MsgBoxStyle.Critical, "提示")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

End Class
