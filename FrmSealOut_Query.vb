Imports TALLY.DBControl
Public Class FrmSealOut_Query
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtSealNOEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNOBegin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtLeadPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtSealTimeOut As System.Windows.Forms.TextBox
    Friend WithEvents cbLeadDept As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtLeadPerson = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.txtSealTimeOut = New System.Windows.Forms.TextBox()
        Me.txtSealNOEnd = New System.Windows.Forms.TextBox()
        Me.txtSealNOBegin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cbLeadDept = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtLeadPerson
        '
        Me.txtLeadPerson.Location = New System.Drawing.Point(76, 128)
        Me.txtLeadPerson.MaxLength = 10
        Me.txtLeadPerson.Name = "txtLeadPerson"
        Me.txtLeadPerson.Size = New System.Drawing.Size(130, 21)
        Me.txtLeadPerson.TabIndex = 152
        Me.txtLeadPerson.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "领用人"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(72, 156)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 150
        Me.btQuit.Text = "返回"
        '
        'txtSealTimeOut
        '
        Me.txtSealTimeOut.Location = New System.Drawing.Point(76, 68)
        Me.txtSealTimeOut.MaxLength = 20
        Me.txtSealTimeOut.Name = "txtSealTimeOut"
        Me.txtSealTimeOut.Size = New System.Drawing.Size(130, 21)
        Me.txtSealTimeOut.TabIndex = 148
        Me.txtSealTimeOut.Text = ""
        '
        'txtSealNOEnd
        '
        Me.txtSealNOEnd.Location = New System.Drawing.Point(76, 38)
        Me.txtSealNOEnd.MaxLength = 20
        Me.txtSealNOEnd.Name = "txtSealNOEnd"
        Me.txtSealNOEnd.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOEnd.TabIndex = 147
        Me.txtSealNOEnd.Text = ""
        '
        'txtSealNOBegin
        '
        Me.txtSealNOBegin.Location = New System.Drawing.Point(76, 8)
        Me.txtSealNOBegin.MaxLength = 20
        Me.txtSealNOBegin.Name = "txtSealNOBegin"
        Me.txtSealNOBegin.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOBegin.TabIndex = 146
        Me.txtSealNOBegin.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "领用部门"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "出库日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "铅封止号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "铅封起号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 141
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'cbLeadDept
        '
        Me.cbLeadDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLeadDept.Location = New System.Drawing.Point(76, 98)
        Me.cbLeadDept.Name = "cbLeadDept"
        Me.cbLeadDept.Size = New System.Drawing.Size(130, 20)
        Me.cbLeadDept.TabIndex = 181
        '
        'FrmSealOut_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(210, 183)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbLeadDept, Me.txtLeadPerson, Me.Label5, Me.btQuit, Me.txtSealTimeOut, Me.txtSealNOEnd, Me.txtSealNOBegin, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSealOut_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "铅封出库信息 查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmSealOut_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim dvDept As New DataView()

        Dim sqlstr, sqlDept As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select * from SEAL_OUT where SEAL_OUT_ID=" & ID & ""
        sqlDept = "select dept_code,dept_name from department where dept_code<>'00' "

        dvDept = Filldata(sqlDept)
        cbLeadDept.DataSource = dvDept
        cbLeadDept.DisplayMember = "dept_name"
        cbLeadDept.ValueMember = "dept_code"

        dw = Getdata(sqlstr, ds)

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtSealNOBegin.Text = ds.Tables(0).Rows(0).Item("SEALNO_BEGIN")
            txtSealNOEnd.Text = ds.Tables(0).Rows(0).Item("SEALNO_END")
            txtSealTimeOut.Text = ds.Tables(0).Rows(0).Item("TIME_OUT")
            cbLeadDept.SelectedValue = ds.Tables(0).Rows(0).Item("LEAD_DEPARTMENT")
            txtLeadPerson.Text = ds.Tables(0).Rows(0).Item("LEAD_PERSON")
            'txtUserName.Text = ds.Tables(0).Rows(0).Item("USER_NAME")
        End If

        btQuit.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
