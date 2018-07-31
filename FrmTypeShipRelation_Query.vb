Imports TALLY.DBControl
Public Class FrmTypeShipRelation_Query
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
    Friend WithEvents txtShipOwner As System.Windows.Forms.ComboBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtShipOwner = New System.Windows.Forms.ComboBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtShipOwner
        '
        Me.txtShipOwner.Location = New System.Drawing.Point(82, 38)
        Me.txtShipOwner.Name = "txtShipOwner"
        Me.txtShipOwner.Size = New System.Drawing.Size(150, 20)
        Me.txtShipOwner.TabIndex = 141
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(85, 94)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 139
        Me.btQuit.Text = "返回"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(82, 66)
        Me.txtCode.MaxLength = 12
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(150, 21)
        Me.txtCode.TabIndex = 137
        Me.txtCode.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "对应代码"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "船公司"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNO
        '
        Me.txtNO.Location = New System.Drawing.Point(82, 8)
        Me.txtNO.MaxLength = 12
        Me.txtNO.Name = "txtNO"
        Me.txtNO.Size = New System.Drawing.Size(150, 21)
        Me.txtNO.TabIndex = 134
        Me.txtNO.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "箱号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 140
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'FrmTypeShipRelation_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(234, 119)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtShipOwner, Me.btQuit, Me.txtCode, Me.Label5, Me.Label4, Me.txtNO, Me.Label3, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTypeShipRelation_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "箱号与船公司箱型对照表_查看"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub txtNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNO.KeyPress
        If e.KeyChar = Chr(13) Then
            txtShipOwner.Focus()
        End If
    End Sub

    Private Sub txtShipOwner_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShipOwner.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCode.Focus()
        End If
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNO.Focus()
        End If
    End Sub

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim ds1 As New DataSet()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select CODE_SHIPOWNER,ShipOWNER_CHA from CODE_SHIP_OWNER Order by CODE_SHIPOWNER"
        dw = Getdata(sqlstr, ds1)
        txtShipOwner.DataSource = ds1.Tables(0).DefaultView
        txtShipOwner.DisplayMember = "ShipOWNER_CHA"
        txtShipOwner.ValueMember = "CODE_SHIPOWNER"

        sqlstr = "select * from CODE_TYPE_SHIP_RELATION where CODE_TYPE_SHIP_RELATION_ID=" & ID & ""

        dw = Getdata(sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("CODE_TYPE_SHIP_RELATION_ID")
            txtNO.Text = ds.Tables(0).Rows(0).Item("CONTAINER_NO")
            txtShipOwner.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_SHIP_OWNER")
            txtCode.Text = ds.Tables(0).Rows(0).Item("CODE_CON_TYPE")
        End If


        txtCode.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
