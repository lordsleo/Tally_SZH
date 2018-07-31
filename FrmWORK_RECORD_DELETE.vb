Imports TALLY.DBControl
Public Class FrmWORK_RECORD_DELETE
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsgoods As New DataSet()
    Dim dspack As New DataSet()
    Dim dsberth As New DataSet()
    Dim dshatch_no As New DataSet()
    Dim dsclerk As New DataSet()
    Dim DSDAMAGE As New DataSet()
    Dim dsBLNO As New DataSet()
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
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
    Friend WithEvents CombCode_pack As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents combcode_goods As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMARK As System.Windows.Forms.TextBox
    Friend WithEvents txtBLNO As System.Windows.Forms.TextBox
    Friend WithEvents CombDAMAGED_REMARK As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDESCR As System.Windows.Forms.TextBox
    Friend WithEvents CombTALLY_CLERK As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTime_from As System.Windows.Forms.TextBox
    Friend WithEvents Txttime_to As System.Windows.Forms.TextBox
    Friend WithEvents DTPRECORD_DAY As System.Windows.Forms.DateTimePicker
    Friend WithEvents CombHATCH_NO As System.Windows.Forms.ComboBox
    Friend WithEvents CombBERTHNO As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTDELETE As System.Windows.Forms.Button
    Friend WithEvents TxtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTons As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.BTDELETE = New System.Windows.Forms.Button
        Me.TxtNO = New System.Windows.Forms.TextBox
        Me.CombCode_pack = New System.Windows.Forms.ComboBox
        Me.TxtAMOUNT = New System.Windows.Forms.TextBox
        Me.combcode_goods = New System.Windows.Forms.ComboBox
        Me.TxtMARK = New System.Windows.Forms.TextBox
        Me.txtBLNO = New System.Windows.Forms.TextBox
        Me.CombDAMAGED_REMARK = New System.Windows.Forms.ComboBox
        Me.TxtDESCR = New System.Windows.Forms.TextBox
        Me.CombTALLY_CLERK = New System.Windows.Forms.ComboBox
        Me.TxtTime_from = New System.Windows.Forms.TextBox
        Me.Txttime_to = New System.Windows.Forms.TextBox
        Me.DTPRECORD_DAY = New System.Windows.Forms.DateTimePicker
        Me.CombHATCH_NO = New System.Windows.Forms.ComboBox
        Me.CombBERTHNO = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtGOODS_CHA = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtTons = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(204, 286)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 96
        Me.BTQUIT.Text = "取消"
        '
        'BTDELETE
        '
        Me.BTDELETE.Location = New System.Drawing.Point(132, 286)
        Me.BTDELETE.Name = "BTDELETE"
        Me.BTDELETE.Size = New System.Drawing.Size(65, 24)
        Me.BTDELETE.TabIndex = 95
        Me.BTDELETE.Text = "确认"
        '
        'TxtNO
        '
        Me.TxtNO.Enabled = False
        Me.TxtNO.Location = New System.Drawing.Point(80, 56)
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(106, 21)
        Me.TxtNO.TabIndex = 93
        Me.TxtNO.Text = ""
        '
        'CombCode_pack
        '
        Me.CombCode_pack.Enabled = False
        Me.CombCode_pack.Location = New System.Drawing.Point(278, 88)
        Me.CombCode_pack.Name = "CombCode_pack"
        Me.CombCode_pack.Size = New System.Drawing.Size(108, 20)
        Me.CombCode_pack.TabIndex = 92
        '
        'TxtAMOUNT
        '
        Me.TxtAMOUNT.Enabled = False
        Me.TxtAMOUNT.Location = New System.Drawing.Point(278, 114)
        Me.TxtAMOUNT.Name = "TxtAMOUNT"
        Me.TxtAMOUNT.Size = New System.Drawing.Size(108, 21)
        Me.TxtAMOUNT.TabIndex = 91
        Me.TxtAMOUNT.Text = ""
        '
        'combcode_goods
        '
        Me.combcode_goods.Enabled = False
        Me.combcode_goods.Location = New System.Drawing.Point(278, 32)
        Me.combcode_goods.Name = "combcode_goods"
        Me.combcode_goods.Size = New System.Drawing.Size(108, 20)
        Me.combcode_goods.TabIndex = 90
        '
        'TxtMARK
        '
        Me.TxtMARK.Enabled = False
        Me.TxtMARK.Location = New System.Drawing.Point(278, 4)
        Me.TxtMARK.MaxLength = 30
        Me.TxtMARK.Name = "TxtMARK"
        Me.TxtMARK.Size = New System.Drawing.Size(108, 21)
        Me.TxtMARK.TabIndex = 89
        Me.TxtMARK.Text = ""
        '
        'txtBLNO
        '
        Me.txtBLNO.Enabled = False
        Me.txtBLNO.Location = New System.Drawing.Point(80, 168)
        Me.txtBLNO.MaxLength = 20
        Me.txtBLNO.Name = "txtBLNO"
        Me.txtBLNO.Size = New System.Drawing.Size(108, 21)
        Me.txtBLNO.TabIndex = 88
        Me.txtBLNO.Text = ""
        '
        'CombDAMAGED_REMARK
        '
        Me.CombDAMAGED_REMARK.Enabled = False
        Me.CombDAMAGED_REMARK.Location = New System.Drawing.Point(278, 170)
        Me.CombDAMAGED_REMARK.Name = "CombDAMAGED_REMARK"
        Me.CombDAMAGED_REMARK.Size = New System.Drawing.Size(108, 20)
        Me.CombDAMAGED_REMARK.TabIndex = 87
        '
        'TxtDESCR
        '
        Me.TxtDESCR.Enabled = False
        Me.TxtDESCR.Location = New System.Drawing.Point(80, 224)
        Me.TxtDESCR.MaxLength = 100
        Me.TxtDESCR.Multiline = True
        Me.TxtDESCR.Name = "TxtDESCR"
        Me.TxtDESCR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDESCR.Size = New System.Drawing.Size(306, 56)
        Me.TxtDESCR.TabIndex = 86
        Me.TxtDESCR.Text = ""
        '
        'CombTALLY_CLERK
        '
        Me.CombTALLY_CLERK.Enabled = False
        Me.CombTALLY_CLERK.Location = New System.Drawing.Point(278, 144)
        Me.CombTALLY_CLERK.Name = "CombTALLY_CLERK"
        Me.CombTALLY_CLERK.Size = New System.Drawing.Size(108, 20)
        Me.CombTALLY_CLERK.TabIndex = 85
        '
        'TxtTime_from
        '
        Me.TxtTime_from.Enabled = False
        Me.TxtTime_from.Location = New System.Drawing.Point(80, 112)
        Me.TxtTime_from.MaxLength = 4
        Me.TxtTime_from.Name = "TxtTime_from"
        Me.TxtTime_from.Size = New System.Drawing.Size(108, 21)
        Me.TxtTime_from.TabIndex = 84
        Me.TxtTime_from.Text = ""
        '
        'Txttime_to
        '
        Me.Txttime_to.Enabled = False
        Me.Txttime_to.Location = New System.Drawing.Point(80, 140)
        Me.Txttime_to.MaxLength = 4
        Me.Txttime_to.Name = "Txttime_to"
        Me.Txttime_to.Size = New System.Drawing.Size(108, 21)
        Me.Txttime_to.TabIndex = 83
        Me.Txttime_to.Text = ""
        '
        'DTPRECORD_DAY
        '
        Me.DTPRECORD_DAY.CustomFormat = "yyyy-MM-dd"
        Me.DTPRECORD_DAY.Enabled = False
        Me.DTPRECORD_DAY.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPRECORD_DAY.Location = New System.Drawing.Point(80, 84)
        Me.DTPRECORD_DAY.Name = "DTPRECORD_DAY"
        Me.DTPRECORD_DAY.Size = New System.Drawing.Size(108, 21)
        Me.DTPRECORD_DAY.TabIndex = 82
        '
        'CombHATCH_NO
        '
        Me.CombHATCH_NO.Enabled = False
        Me.CombHATCH_NO.Location = New System.Drawing.Point(80, 28)
        Me.CombHATCH_NO.Name = "CombHATCH_NO"
        Me.CombHATCH_NO.Size = New System.Drawing.Size(108, 20)
        Me.CombHATCH_NO.TabIndex = 81
        '
        'CombBERTHNO
        '
        Me.CombBERTHNO.Enabled = False
        Me.CombBERTHNO.Location = New System.Drawing.Point(80, 2)
        Me.CombBERTHNO.Name = "CombBERTHNO"
        Me.CombBERTHNO.Size = New System.Drawing.Size(108, 20)
        Me.CombBERTHNO.TabIndex = 80
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(194, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 22)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "理货员"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(194, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 22)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "情况编码"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(194, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 22)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "包装"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(194, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 22)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "件数"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(194, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 22)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "货名"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(194, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 22)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(10, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 22)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "提单号"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(10, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 22)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "情况描述"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 22)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "结束时间"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 22)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "开始时间"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 22)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "记录日期"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 22)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "记录单编号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 22)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "舱别"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 22)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "泊位号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtGOODS_CHA
        '
        Me.TxtGOODS_CHA.Enabled = False
        Me.TxtGOODS_CHA.Location = New System.Drawing.Point(278, 60)
        Me.TxtGOODS_CHA.MaxLength = 30
        Me.TxtGOODS_CHA.Name = "TxtGOODS_CHA"
        Me.TxtGOODS_CHA.Size = New System.Drawing.Size(108, 21)
        Me.TxtGOODS_CHA.TabIndex = 98
        Me.TxtGOODS_CHA.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(194, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 22)
        Me.Label15.TabIndex = 97
        Me.Label15.Text = "货物中文描述"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(158, 196)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 20)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "超重货物总重(公斤)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTons
        '
        Me.txtTons.Enabled = False
        Me.txtTons.Location = New System.Drawing.Point(278, 196)
        Me.txtTons.Name = "txtTons"
        Me.txtTons.Size = New System.Drawing.Size(108, 21)
        Me.txtTons.TabIndex = 100
        Me.txtTons.Text = ""
        '
        'FrmWORK_RECORD_DELETE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(396, 319)
        Me.Controls.Add(Me.txtTons)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtGOODS_CHA)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.BTDELETE)
        Me.Controls.Add(Me.TxtNO)
        Me.Controls.Add(Me.CombCode_pack)
        Me.Controls.Add(Me.TxtAMOUNT)
        Me.Controls.Add(Me.combcode_goods)
        Me.Controls.Add(Me.TxtMARK)
        Me.Controls.Add(Me.txtBLNO)
        Me.Controls.Add(Me.CombDAMAGED_REMARK)
        Me.Controls.Add(Me.TxtDESCR)
        Me.Controls.Add(Me.CombTALLY_CLERK)
        Me.Controls.Add(Me.TxtTime_from)
        Me.Controls.Add(Me.Txttime_to)
        Me.Controls.Add(Me.DTPRECORD_DAY)
        Me.Controls.Add(Me.CombHATCH_NO)
        Me.Controls.Add(Me.CombBERTHNO)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWORK_RECORD_DELETE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "现场记录_删除"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmWORK_RECORD_DELETE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE_GOODS,GOODS_CHA+' '+ISNULL(GOODS_ENG,' ') as goods from code_cargo order by code_goods ", dsgoods)
        combcode_goods.DataSource = dsgoods.Tables(0).DefaultView
        combcode_goods.DisplayMember = "goods"
        combcode_goods.ValueMember = "CODE_GOODS"

        dw = Getdata("select code_pack,pack_cha+' '+isnull(pack_eng,' ') as pack from code_pack order by pack ", dspack)
        CombCode_pack.DataSource = dspack.Tables(0).DefaultView
        CombCode_pack.DisplayMember = "pack"
        CombCode_pack.ValueMember = "code_pack"

        dw = Getdata("select CODE_BERTH,NAME_BERTH from CODE_BERTH where DEPT_CODE like '" & Trim(G_DeptCode) & "%'", dsberth)
        CombBERTHNO.DataSource = dsberth.Tables(0).DefaultView
        CombBERTHNO.DisplayMember = "NAME_BERTH"
        CombBERTHNO.ValueMember = "CODE_BERTH"

        dw = Getdata("select value,descr from codecabin", dshatch_no)
        CombHATCH_NO.DataSource = dshatch_no.Tables(0).DefaultView
        CombHATCH_NO.DisplayMember = "descr"
        CombHATCH_NO.ValueMember = "value"

        dw = Getdata("select work_no,name from TALLY_CLERK order by name", dsclerk)
        CombTALLY_CLERK.DataSource = dsclerk.Tables(0).DefaultView
        CombTALLY_CLERK.DisplayMember = "name"
        CombTALLY_CLERK.ValueMember = "work_no"

        dw = Getdata("SELECT CODE_DAMAGE,NAME_DAMAGE FROM DAMAGE", DSDAMAGE)
        CombDAMAGED_REMARK.DataSource = DSDAMAGE.Tables(0).DefaultView
        CombDAMAGED_REMARK.DisplayMember = "NAME_DAMAGE"
        CombDAMAGED_REMARK.ValueMember = "CODE_DAMAGE"


        dw = Updatedata(sqlda, "select * from WORK_RECORD_new where WORK_RECORD_ID='" & ID & "'", ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            TxtTime_from.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_from"))), "", Trim(ds.Tables(0).Rows(0).Item("time_from")))
            Txttime_to.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_to"))), "", Trim(ds.Tables(0).Rows(0).Item("time_to")))
            CombHATCH_NO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("hatch_no"))), "", Trim(ds.Tables(0).Rows(0).Item("hatch_no")))
            CombBERTHNO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("BERTHNO"))), "", Trim(ds.Tables(0).Rows(0).Item("BERTHNO")))
            TxtDESCR.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("DESCR"))), "", Trim(ds.Tables(0).Rows(0).Item("DESCR")))
            DTPRECORD_DAY.Value = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("RECORD_DAY"))), Now, Trim(ds.Tables(0).Rows(0).Item("RECORD_DAY")))
            CombDAMAGED_REMARK.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("DAMAGED_REMARK"))), "", Trim(ds.Tables(0).Rows(0).Item("DAMAGED_REMARK")))
            TxtGOODS_CHA.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("GOODS_CHA"))), "", Trim(ds.Tables(0).Rows(0).Item("GOODS_CHA")))
            'Call clerk()

            CombTALLY_CLERK.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk"))), "", Trim(ds.Tables(0).Rows(0).Item("tally_clerk")))
            TxtAMOUNT.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("AMOUNT"))), "0", Trim(ds.Tables(0).Rows(0).Item("AMOUNT")))
            txtTons.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("Tons"))), "0", Trim(ds.Tables(0).Rows(0).Item("Tons")))
            TxtNO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("NO"))), "", Trim(ds.Tables(0).Rows(0).Item("NO")))
            txtBLNO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("BLNO"))), "0", Trim(ds.Tables(0).Rows(0).Item("BLNO")))
            TxtMARK.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("MARK"))), "0", Trim(ds.Tables(0).Rows(0).Item("MARK")))
            combcode_goods.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("code_goods"))), "", Trim(ds.Tables(0).Rows(0).Item("code_goods")))
            CombCode_pack.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("Code_pack"))), "0", Trim(ds.Tables(0).Rows(0).Item("Code_pack")))
        End If

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub clerk()
        Try
            dw = Getdata("exec sp_waitfor_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & TxtTime_from.Text & "','" & DTPRECORD_DAY.Value & "'", dsclerk)
            CombTALLY_CLERK.DataSource = dsclerk.Tables(0).DefaultView
            CombTALLY_CLERK.DisplayMember = "name"
            CombTALLY_CLERK.ValueMember = "work_no"
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTDELETE.Click
        If MsgBox("确认要删除吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
            Call OperateHistory(G_DeptName, Now, G_User, "删除", "work_record", ID, "work_record_id")
            ds.Tables(0).Rows(0).Delete()
            sqlda.Update(ds)
            Call BTQUIT_Click(sender, e)
        End If
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub
End Class
