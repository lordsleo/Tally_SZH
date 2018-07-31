Imports TALLY.DBControl
Public Class FrmABSENT_Query
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtWORK_NAME As System.Windows.Forms.TextBox
    Friend WithEvents DTPABSENTDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbCode_HOLIDAY_TYPE As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtWORK_NAME = New System.Windows.Forms.TextBox
        Me.DTPABSENTDATE = New System.Windows.Forms.DateTimePicker
        Me.CmbCode_HOLIDAY_TYPE = New System.Windows.Forms.ComboBox
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
        Me.btQuit.Location = New System.Drawing.Point(60, 88)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 3
        Me.btQuit.Text = "返回"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(8, 82)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(20, 21)
        Me.txtID.TabIndex = 103
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "假别"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtWORK_NAME
        '
        Me.TxtWORK_NAME.Location = New System.Drawing.Point(59, 6)
        Me.TxtWORK_NAME.Name = "TxtWORK_NAME"
        Me.TxtWORK_NAME.Size = New System.Drawing.Size(114, 21)
        Me.TxtWORK_NAME.TabIndex = 0
        Me.TxtWORK_NAME.Text = ""
        '
        'DTPABSENTDATE
        '
        Me.DTPABSENTDATE.CustomFormat = "yyyy/MM/dd"
        Me.DTPABSENTDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPABSENTDATE.Location = New System.Drawing.Point(59, 32)
        Me.DTPABSENTDATE.Name = "DTPABSENTDATE"
        Me.DTPABSENTDATE.Size = New System.Drawing.Size(114, 21)
        Me.DTPABSENTDATE.TabIndex = 1
        '
        'CmbCode_HOLIDAY_TYPE
        '
        Me.CmbCode_HOLIDAY_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCode_HOLIDAY_TYPE.Location = New System.Drawing.Point(59, 58)
        Me.CmbCode_HOLIDAY_TYPE.Name = "CmbCode_HOLIDAY_TYPE"
        Me.CmbCode_HOLIDAY_TYPE.Size = New System.Drawing.Size(114, 20)
        Me.CmbCode_HOLIDAY_TYPE.TabIndex = 2
        '
        'FrmABSENT_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(184, 119)
        Me.Controls.Add(Me.CmbCode_HOLIDAY_TYPE)
        Me.Controls.Add(Me.DTPABSENTDATE)
        Me.Controls.Add(Me.TxtWORK_NAME)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmABSENT_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "当班考勤_查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmABSENT_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        On Error GoTo Err
        Call FillCode_HOLIDAY_TYPE()
        sqlstr = "select * from ABSENT where ABSENT_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then

            Dim sqldc As String
            Dim dvc As New DataView()
            Dim dsc As New DataSet()
            sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK where WORK_NO='" & ds.Tables(0).Rows(0).Item("WORK_NO") & "'"
            dvc = DBControl.Getdata(sqldc, dsc)
            TxtWORK_NAME.Text = dvc(0)(0)
            ' TxtWORK_NO.Text = dvc(0)(1)
            txtID.Text = ds.Tables(0).Rows(0).Item("ABSENT_ID")
            CmbCode_HOLIDAY_TYPE.SelectedValue = ds.Tables(0).Rows(0).Item("Code_HOLIDAY_TYPE")
            DTPABSENTDATE.Value = ds.Tables(0).Rows(0).Item("ABSENTDATE")

        End If
        CmbCode_HOLIDAY_TYPE.Focus()

        Exit Sub
Err:
        Resume Next
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

End Class
