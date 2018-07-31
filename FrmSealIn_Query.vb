Imports TALLY.DBControl
Public Class FrmSealIn_Query
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtManufact As System.Windows.Forms.TextBox
    Friend WithEvents txtSealTimeIn As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNOEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNOBegin As System.Windows.Forms.TextBox
    Friend WithEvents txtRuKuRen As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.txtManufact = New System.Windows.Forms.TextBox()
        Me.txtSealTimeIn = New System.Windows.Forms.TextBox()
        Me.txtSealNOEnd = New System.Windows.Forms.TextBox()
        Me.txtSealNOBegin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtRuKuRen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btQuit.Location = New System.Drawing.Point(78, 156)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 136
        Me.btQuit.Text = "返回"
        '
        'txtManufact
        '
        Me.txtManufact.Location = New System.Drawing.Point(82, 98)
        Me.txtManufact.MaxLength = 30
        Me.txtManufact.Name = "txtManufact"
        Me.txtManufact.Size = New System.Drawing.Size(130, 21)
        Me.txtManufact.TabIndex = 135
        Me.txtManufact.Text = ""
        '
        'txtSealTimeIn
        '
        Me.txtSealTimeIn.Location = New System.Drawing.Point(82, 68)
        Me.txtSealTimeIn.MaxLength = 20
        Me.txtSealTimeIn.Name = "txtSealTimeIn"
        Me.txtSealTimeIn.Size = New System.Drawing.Size(130, 21)
        Me.txtSealTimeIn.TabIndex = 134
        Me.txtSealTimeIn.Text = ""
        '
        'txtSealNOEnd
        '
        Me.txtSealNOEnd.Location = New System.Drawing.Point(82, 38)
        Me.txtSealNOEnd.MaxLength = 20
        Me.txtSealNOEnd.Name = "txtSealNOEnd"
        Me.txtSealNOEnd.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOEnd.TabIndex = 133
        Me.txtSealNOEnd.Text = ""
        '
        'txtSealNOBegin
        '
        Me.txtSealNOBegin.Location = New System.Drawing.Point(82, 8)
        Me.txtSealNOBegin.MaxLength = 20
        Me.txtSealNOBegin.Name = "txtSealNOBegin"
        Me.txtSealNOBegin.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOBegin.TabIndex = 132
        Me.txtSealNOBegin.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "供货商"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "进库日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "铅封止号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "铅封起号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 127
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtRuKuRen
        '
        Me.txtRuKuRen.Location = New System.Drawing.Point(82, 128)
        Me.txtRuKuRen.MaxLength = 10
        Me.txtRuKuRen.Name = "txtRuKuRen"
        Me.txtRuKuRen.Size = New System.Drawing.Size(130, 21)
        Me.txtRuKuRen.TabIndex = 138
        Me.txtRuKuRen.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "入库人"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmSealIn_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(218, 183)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtRuKuRen, Me.Label5, Me.btQuit, Me.txtManufact, Me.txtSealTimeIn, Me.txtSealNOEnd, Me.txtSealNOBegin, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSealIn_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "铅封入库信息 查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmSealIn_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select * from SEAL_IN where SEAL_IN_ID=" & ID & ""

        dw = Getdata(sqlstr, ds)

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtSealNOBegin.Text = ds.Tables(0).Rows(0).Item("SEALNO_BEGIN")
            txtSealNOEnd.Text = ds.Tables(0).Rows(0).Item("SEALNO_END")
            txtSealTimeIn.Text = ds.Tables(0).Rows(0).Item("TIME_IN")
            txtManufact.Text = ds.Tables(0).Rows(0).Item("MANUFACTURER")
            txtRuKuRen.Text = ds.Tables(0).Rows(0).Item("INWAREHOUSE_PERSON")
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
