Imports TALLY.DBControl
Public Class FrmCargo_hatch_sheet_define
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsa As New DataSet()
    Dim dsb As New DataSet()
    Dim dsc As New DataSet()
    Dim dsd As New DataSet()
    Dim dse As New DataSet()
    Dim dsf As New DataSet()
    Dim dsg As New DataSet()
    Dim dsh As New DataSet()
    Dim dsi As New DataSet()
    Dim dsj As New DataSet()


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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents txta As System.Windows.Forms.ComboBox
    Friend WithEvents txtb As System.Windows.Forms.ComboBox
    Friend WithEvents txtc As System.Windows.Forms.ComboBox
    Friend WithEvents txtd As System.Windows.Forms.ComboBox
    Friend WithEvents txtf As System.Windows.Forms.ComboBox
    Friend WithEvents txtg As System.Windows.Forms.ComboBox
    Friend WithEvents txth As System.Windows.Forms.ComboBox
    Friend WithEvents txti As System.Windows.Forms.ComboBox
    Friend WithEvents txtj As System.Windows.Forms.ComboBox
    Friend WithEvents txte As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.BTOK = New System.Windows.Forms.Button()
        Me.txta = New System.Windows.Forms.ComboBox()
        Me.txtb = New System.Windows.Forms.ComboBox()
        Me.txtc = New System.Windows.Forms.ComboBox()
        Me.txtd = New System.Windows.Forms.ComboBox()
        Me.txtf = New System.Windows.Forms.ComboBox()
        Me.txtg = New System.Windows.Forms.ComboBox()
        Me.txth = New System.Windows.Forms.ComboBox()
        Me.txti = New System.Windows.Forms.ComboBox()
        Me.txtj = New System.Windows.Forms.ComboBox()
        Me.txte = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "a舱名称"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "b舱名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "c舱名称"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "d舱名称"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "e舱名称"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(188, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "f舱名称"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(188, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 22)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "g舱名称"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(188, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 22)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "h舱名称"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(188, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 22)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "i舱名称"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(188, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 22)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "j舱名称"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(186, 162)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 71
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(113, 162)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 70
        Me.BTOK.Text = "确认"
        '
        'txta
        '
        Me.txta.Location = New System.Drawing.Point(82, 10)
        Me.txta.Name = "txta"
        Me.txta.Size = New System.Drawing.Size(96, 20)
        Me.txta.TabIndex = 72
        '
        'txtb
        '
        Me.txtb.Location = New System.Drawing.Point(82, 40)
        Me.txtb.Name = "txtb"
        Me.txtb.Size = New System.Drawing.Size(96, 20)
        Me.txtb.TabIndex = 73
        '
        'txtc
        '
        Me.txtc.Location = New System.Drawing.Point(82, 68)
        Me.txtc.Name = "txtc"
        Me.txtc.Size = New System.Drawing.Size(96, 20)
        Me.txtc.TabIndex = 74
        '
        'txtd
        '
        Me.txtd.Location = New System.Drawing.Point(82, 98)
        Me.txtd.Name = "txtd"
        Me.txtd.Size = New System.Drawing.Size(96, 20)
        Me.txtd.TabIndex = 75
        '
        'txtf
        '
        Me.txtf.Location = New System.Drawing.Point(260, 10)
        Me.txtf.Name = "txtf"
        Me.txtf.Size = New System.Drawing.Size(96, 20)
        Me.txtf.TabIndex = 76
        '
        'txtg
        '
        Me.txtg.Location = New System.Drawing.Point(260, 38)
        Me.txtg.Name = "txtg"
        Me.txtg.Size = New System.Drawing.Size(96, 20)
        Me.txtg.TabIndex = 77
        '
        'txth
        '
        Me.txth.Location = New System.Drawing.Point(260, 68)
        Me.txth.Name = "txth"
        Me.txth.Size = New System.Drawing.Size(96, 20)
        Me.txth.TabIndex = 78
        '
        'txti
        '
        Me.txti.Location = New System.Drawing.Point(260, 96)
        Me.txti.Name = "txti"
        Me.txti.Size = New System.Drawing.Size(96, 20)
        Me.txti.TabIndex = 79
        '
        'txtj
        '
        Me.txtj.Location = New System.Drawing.Point(260, 126)
        Me.txtj.Name = "txtj"
        Me.txtj.Size = New System.Drawing.Size(96, 20)
        Me.txtj.TabIndex = 80
        '
        'txte
        '
        Me.txte.Location = New System.Drawing.Point(82, 126)
        Me.txte.Name = "txte"
        Me.txte.Size = New System.Drawing.Size(96, 20)
        Me.txte.TabIndex = 81
        '
        'FrmCargo_hatch_sheet_define
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(364, 199)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txte, Me.txtj, Me.txti, Me.txth, Me.txtg, Me.txtf, Me.txtd, Me.txtc, Me.txtb, Me.txta, Me.BTQUIT, Me.BTOK, Me.Label10, Me.Label9, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargo_hatch_sheet_define"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "舱口名定义"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargo_hatch_sheet_define_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dw = Getdata("select value,descr from codecabin", dsa)
            txta.DataSource = dsa.Tables(0).DefaultView
            txta.ValueMember = "descr"
            txta.DisplayMember = "descr"

            dw = Getdata("select value,descr from codecabin", dsb)
            txtb.DataSource = dsb.Tables(0).DefaultView
            txtb.ValueMember = "descr"
            txtb.DisplayMember = "descr"

            dw = Getdata("select value,descr from codecabin", dsc)
            txtc.DataSource = dsc.Tables(0).DefaultView
            txtc.ValueMember = "descr"
            txtc.DisplayMember = "descr"

            dw = Getdata("select value,descr from codecabin", dsd)
            txtd.DataSource = dsd.Tables(0).DefaultView
            txtd.ValueMember = "descr"
            txtd.DisplayMember = "descr"

            dw = Getdata("select value,descr from codecabin", dse)
            txte.DataSource = dse.Tables(0).DefaultView
            txte.ValueMember = "descr"
            txte.DisplayMember = "descr"

            dw = Getdata("select value,descr from codecabin", dsf)
            txtf.DataSource = dsf.Tables(0).DefaultView
            txtf.ValueMember = "descr"
            txtf.DisplayMember = "descr"

            dw = Getdata("select value,descr from codecabin", dsg)
            txtg.DataSource = dsg.Tables(0).DefaultView
            txtg.ValueMember = "descr"
            txtg.DisplayMember = "descr"

            dw = Getdata("select value,descr from codecabin", dsh)
            txth.DataSource = dsh.Tables(0).DefaultView
            txth.ValueMember = "descr"
            txth.DisplayMember = "descr"

            dw = Getdata("select value,descr from codecabin", dsi)
            txti.DataSource = dsi.Tables(0).DefaultView
            txti.ValueMember = "descr"
            txti.DisplayMember = "descr"

            dw = Getdata("select value,descr from codecabin", dsj)
            txtj.DataSource = dsj.Tables(0).DefaultView
            txtj.ValueMember = "descr"
            txtj.DisplayMember = "descr"

            dw = Updatedata(sqlda, "select * from CARGO_HATCH_NAME where ship_id='" & Ship_ID & "'", ds)
            If ds.Tables(0).DefaultView.Count > 0 Then

                txta.SelectedValue = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("HATCH_A")), "", ds.Tables(0).Rows(0).Item("HATCH_A"))
                txtb.SelectedValue = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("HATCH_b")), "", ds.Tables(0).Rows(0).Item("HATCH_b"))
                txtc.SelectedValue = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("HATCH_c")), "", ds.Tables(0).Rows(0).Item("HATCH_c"))
                txtd.SelectedValue = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("HATCH_d")), "", ds.Tables(0).Rows(0).Item("HATCH_d"))
                txte.SelectedValue = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("HATCH_e")), "", ds.Tables(0).Rows(0).Item("HATCH_e"))
                txtf.SelectedValue = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("HATCH_f")), "", ds.Tables(0).Rows(0).Item("HATCH_f"))
                txtg.SelectedValue = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("HATCH_g")), "", ds.Tables(0).Rows(0).Item("HATCH_g"))
                txth.SelectedValue = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("HATCH_h")), "", ds.Tables(0).Rows(0).Item("HATCH_h"))
                txti.SelectedValue = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("HATCH_i")), "", ds.Tables(0).Rows(0).Item("HATCH_i"))
                txtj.SelectedValue = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("HATCH_j")), "", ds.Tables(0).Rows(0).Item("HATCH_j"))

            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Try



            If ds.Tables(0).DefaultView.Count > 0 Then
                ds.Tables(0).Rows(0).Item("HATCH_A") = Trim(txta.Text)
                ds.Tables(0).Rows(0).Item("HATCH_b") = Trim(txtb.Text)
                ds.Tables(0).Rows(0).Item("HATCH_c") = Trim(txtc.Text)
                ds.Tables(0).Rows(0).Item("HATCH_d") = Trim(txtd.Text)
                ds.Tables(0).Rows(0).Item("HATCH_e") = Trim(txte.Text)
                ds.Tables(0).Rows(0).Item("HATCH_f") = Trim(txtf.Text)
                ds.Tables(0).Rows(0).Item("HATCH_g") = Trim(txtg.Text)
                ds.Tables(0).Rows(0).Item("HATCH_h") = Trim(txth.Text)
                ds.Tables(0).Rows(0).Item("HATCH_i") = Trim(txti.Text)
                ds.Tables(0).Rows(0).Item("HATCH_j") = Trim(txtj.Text)
                ds.Tables(0).Rows(0).Item("user_name") = Trim(G_User)
                sqlda.Update(ds)
                Call BTQUIT_Click(sender, e)
            Else
                Dim row As DataRow
                row = ds.Tables(0).NewRow
                row("ship_id") = Trim(Ship_ID)
                row("HATCH_A") = Trim(txta.Text)
                row("HATCH_b") = Trim(txtb.Text)
                row("HATCH_c") = Trim(txtc.Text)
                row("HATCH_d") = Trim(txtd.Text)
                row("HATCH_e") = Trim(txte.Text)
                row("HATCH_f") = Trim(txtf.Text)
                row("HATCH_g") = Trim(txtg.Text)
                row("HATCH_h") = Trim(txth.Text)
                row("HATCH_i") = Trim(txti.Text)
                row("HATCH_j") = Trim(txtj.Text)
                row("user_name") = Trim(G_User)
                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
                Call BTQUIT_Click(sender, e)



            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub
End Class
