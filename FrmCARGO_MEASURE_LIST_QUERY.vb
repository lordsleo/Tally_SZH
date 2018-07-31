Imports TALLY.DBControl
Public Class FrmCARGO_MEASURE_LIST_QUERY
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsgoods As New DataSet()
    Dim dsclerk As New DataSet()
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
    Friend WithEvents TxtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtTOTAL_VOLUME As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtHIGH As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtWIDTH As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtPIECE_VOLUME As System.Windows.Forms.TextBox
    Friend WithEvents TxtLONG As System.Windows.Forms.TextBox
    Friend WithEvents TxtAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DTPMEASUREDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtREMARK As System.Windows.Forms.TextBox
    Friend WithEvents TxtWORK_PLACE As System.Windows.Forms.TextBox
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
    Friend WithEvents CombTALLY_CLERK As System.Windows.Forms.ComboBox
    Friend WithEvents combcode_goods As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMARK As System.Windows.Forms.TextBox
    Friend WithEvents txtBLNO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.TxtGOODS_CHA = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtTOTAL_VOLUME = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtHIGH = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtWIDTH = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtPIECE_VOLUME = New System.Windows.Forms.TextBox()
        Me.TxtLONG = New System.Windows.Forms.TextBox()
        Me.TxtAMOUNT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DTPMEASUREDATE = New System.Windows.Forms.DateTimePicker()
        Me.TxtREMARK = New System.Windows.Forms.TextBox()
        Me.TxtWORK_PLACE = New System.Windows.Forms.TextBox()
        Me.TxtNO = New System.Windows.Forms.TextBox()
        Me.CombTALLY_CLERK = New System.Windows.Forms.ComboBox()
        Me.combcode_goods = New System.Windows.Forms.ComboBox()
        Me.TxtMARK = New System.Windows.Forms.TextBox()
        Me.txtBLNO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(180, 270)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 155
        Me.BTQUIT.Text = "取消"
        '
        'TxtGOODS_CHA
        '
        Me.TxtGOODS_CHA.Enabled = False
        Me.TxtGOODS_CHA.Location = New System.Drawing.Point(94, 176)
        Me.TxtGOODS_CHA.MaxLength = 30
        Me.TxtGOODS_CHA.Name = "TxtGOODS_CHA"
        Me.TxtGOODS_CHA.Size = New System.Drawing.Size(128, 21)
        Me.TxtGOODS_CHA.TabIndex = 190
        Me.TxtGOODS_CHA.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(10, 176)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 22)
        Me.Label20.TabIndex = 189
        Me.Label20.Text = "货物中文描述"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label19.Location = New System.Drawing.Point(370, 148)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 22)
        Me.Label19.TabIndex = 188
        Me.Label19.Text = "立方米"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label18.Location = New System.Drawing.Point(370, 92)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 22)
        Me.Label18.TabIndex = 187
        Me.Label18.Text = "立方米"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.Location = New System.Drawing.Point(396, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 22)
        Me.Label17.TabIndex = 186
        Me.Label17.Text = "米"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label16.Location = New System.Drawing.Point(396, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 22)
        Me.Label16.TabIndex = 185
        Me.Label16.Text = "米"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(396, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 22)
        Me.Label15.TabIndex = 184
        Me.Label15.Text = "米"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTOTAL_VOLUME
        '
        Me.TxtTOTAL_VOLUME.Enabled = False
        Me.TxtTOTAL_VOLUME.Location = New System.Drawing.Point(286, 148)
        Me.TxtTOTAL_VOLUME.Name = "TxtTOTAL_VOLUME"
        Me.TxtTOTAL_VOLUME.Size = New System.Drawing.Size(84, 21)
        Me.TxtTOTAL_VOLUME.TabIndex = 183
        Me.TxtTOTAL_VOLUME.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(226, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 22)
        Me.Label14.TabIndex = 182
        Me.Label14.Text = "总体积"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtHIGH
        '
        Me.TxtHIGH.Enabled = False
        Me.TxtHIGH.Location = New System.Drawing.Point(286, 64)
        Me.TxtHIGH.Name = "TxtHIGH"
        Me.TxtHIGH.Size = New System.Drawing.Size(110, 21)
        Me.TxtHIGH.TabIndex = 181
        Me.TxtHIGH.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(226, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 22)
        Me.Label13.TabIndex = 180
        Me.Label13.Text = "高"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtWIDTH
        '
        Me.TxtWIDTH.Enabled = False
        Me.TxtWIDTH.Location = New System.Drawing.Point(286, 36)
        Me.TxtWIDTH.Name = "TxtWIDTH"
        Me.TxtWIDTH.Size = New System.Drawing.Size(110, 21)
        Me.TxtWIDTH.TabIndex = 179
        Me.TxtWIDTH.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(226, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 22)
        Me.Label12.TabIndex = 178
        Me.Label12.Text = "宽"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPIECE_VOLUME
        '
        Me.TxtPIECE_VOLUME.Enabled = False
        Me.TxtPIECE_VOLUME.Location = New System.Drawing.Point(286, 92)
        Me.TxtPIECE_VOLUME.Name = "TxtPIECE_VOLUME"
        Me.TxtPIECE_VOLUME.Size = New System.Drawing.Size(84, 21)
        Me.TxtPIECE_VOLUME.TabIndex = 177
        Me.TxtPIECE_VOLUME.Text = ""
        '
        'TxtLONG
        '
        Me.TxtLONG.Enabled = False
        Me.TxtLONG.Location = New System.Drawing.Point(286, 8)
        Me.TxtLONG.Name = "TxtLONG"
        Me.TxtLONG.Size = New System.Drawing.Size(110, 21)
        Me.TxtLONG.TabIndex = 176
        Me.TxtLONG.Text = ""
        '
        'TxtAMOUNT
        '
        Me.TxtAMOUNT.Enabled = False
        Me.TxtAMOUNT.Location = New System.Drawing.Point(286, 120)
        Me.TxtAMOUNT.Name = "TxtAMOUNT"
        Me.TxtAMOUNT.Size = New System.Drawing.Size(126, 21)
        Me.TxtAMOUNT.TabIndex = 175
        Me.TxtAMOUNT.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(226, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 22)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "单件体积"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(226, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 22)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "长"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(226, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 22)
        Me.Label11.TabIndex = 172
        Me.Label11.Text = "件数"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPMEASUREDATE
        '
        Me.DTPMEASUREDATE.CustomFormat = "yyyy-MM-dd"
        Me.DTPMEASUREDATE.Enabled = False
        Me.DTPMEASUREDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPMEASUREDATE.Location = New System.Drawing.Point(94, 36)
        Me.DTPMEASUREDATE.Name = "DTPMEASUREDATE"
        Me.DTPMEASUREDATE.Size = New System.Drawing.Size(128, 21)
        Me.DTPMEASUREDATE.TabIndex = 171
        '
        'TxtREMARK
        '
        Me.TxtREMARK.Enabled = False
        Me.TxtREMARK.Location = New System.Drawing.Point(94, 204)
        Me.TxtREMARK.MaxLength = 100
        Me.TxtREMARK.Multiline = True
        Me.TxtREMARK.Name = "TxtREMARK"
        Me.TxtREMARK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtREMARK.Size = New System.Drawing.Size(320, 54)
        Me.TxtREMARK.TabIndex = 170
        Me.TxtREMARK.Text = ""
        '
        'TxtWORK_PLACE
        '
        Me.TxtWORK_PLACE.Enabled = False
        Me.TxtWORK_PLACE.Location = New System.Drawing.Point(94, 64)
        Me.TxtWORK_PLACE.MaxLength = 30
        Me.TxtWORK_PLACE.Name = "TxtWORK_PLACE"
        Me.TxtWORK_PLACE.Size = New System.Drawing.Size(128, 21)
        Me.TxtWORK_PLACE.TabIndex = 169
        Me.TxtWORK_PLACE.Text = ""
        '
        'TxtNO
        '
        Me.TxtNO.Enabled = False
        Me.TxtNO.Location = New System.Drawing.Point(94, 8)
        Me.TxtNO.MaxLength = 10
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(128, 21)
        Me.TxtNO.TabIndex = 168
        Me.TxtNO.Text = ""
        '
        'CombTALLY_CLERK
        '
        Me.CombTALLY_CLERK.Enabled = False
        Me.CombTALLY_CLERK.Location = New System.Drawing.Point(286, 176)
        Me.CombTALLY_CLERK.Name = "CombTALLY_CLERK"
        Me.CombTALLY_CLERK.Size = New System.Drawing.Size(128, 20)
        Me.CombTALLY_CLERK.TabIndex = 167
        '
        'combcode_goods
        '
        Me.combcode_goods.Enabled = False
        Me.combcode_goods.Location = New System.Drawing.Point(94, 148)
        Me.combcode_goods.Name = "combcode_goods"
        Me.combcode_goods.Size = New System.Drawing.Size(128, 20)
        Me.combcode_goods.TabIndex = 166
        '
        'TxtMARK
        '
        Me.TxtMARK.Enabled = False
        Me.TxtMARK.Location = New System.Drawing.Point(94, 120)
        Me.TxtMARK.MaxLength = 30
        Me.TxtMARK.Name = "TxtMARK"
        Me.TxtMARK.Size = New System.Drawing.Size(128, 21)
        Me.TxtMARK.TabIndex = 165
        Me.TxtMARK.Text = ""
        '
        'txtBLNO
        '
        Me.txtBLNO.Enabled = False
        Me.txtBLNO.Location = New System.Drawing.Point(94, 92)
        Me.txtBLNO.MaxLength = 20
        Me.txtBLNO.Name = "txtBLNO"
        Me.txtBLNO.Size = New System.Drawing.Size(128, 21)
        Me.txtBLNO.TabIndex = 164
        Me.txtBLNO.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(226, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 22)
        Me.Label7.TabIndex = 163
        Me.Label7.Text = "丈量人员"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 22)
        Me.Label6.TabIndex = 162
        Me.Label6.Text = "备注"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "丈量地点"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(10, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 22)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "货名"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(10, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 22)
        Me.Label9.TabIndex = 159
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(10, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 22)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "提单号"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 22)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "丈量日期"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 22)
        Me.Label3.TabIndex = 156
        Me.Label3.Text = "丈量单编号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCARGO_MEASURE_LIST_QUERY
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(424, 307)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtGOODS_CHA, Me.Label20, Me.Label19, Me.Label18, Me.Label17, Me.Label16, Me.Label15, Me.TxtTOTAL_VOLUME, Me.Label14, Me.TxtHIGH, Me.Label13, Me.TxtWIDTH, Me.Label12, Me.TxtPIECE_VOLUME, Me.TxtLONG, Me.TxtAMOUNT, Me.Label5, Me.Label2, Me.Label11, Me.DTPMEASUREDATE, Me.TxtREMARK, Me.TxtWORK_PLACE, Me.TxtNO, Me.CombTALLY_CLERK, Me.combcode_goods, Me.TxtMARK, Me.txtBLNO, Me.Label7, Me.Label6, Me.Label1, Me.Label10, Me.Label9, Me.Label8, Me.Label4, Me.Label3, Me.BTQUIT})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCARGO_MEASURE_LIST_QUERY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "丈量单_查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCARGO_MEASURE_LIST_QUERY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE_GOODS,GOODS_CHA+' '+ISNULL(GOODS_ENG,' ') as goods from code_cargo order by code_goods ", dsgoods)
        combcode_goods.DataSource = dsgoods.Tables(0).DefaultView
        combcode_goods.DisplayMember = "goods"
        combcode_goods.ValueMember = "CODE_GOODS"

        dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk)
        CombTALLY_CLERK.DataSource = dsclerk.Tables(0).DefaultView
        CombTALLY_CLERK.DisplayMember = "name"
        CombTALLY_CLERK.ValueMember = "work_no"

        dw = Updatedata(sqlda, "select * from CARGO_MEASURE_LIST where MEASURE_ID='" & ID & "'", ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            TxtWORK_PLACE.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("WORK_PLACE"))), "", Trim(ds.Tables(0).Rows(0).Item("WORK_PLACE")))
            TxtLONG.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("LONG"))), "", Trim(ds.Tables(0).Rows(0).Item("LONG")))
            TxtWIDTH.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("WIDTH"))), "", Trim(ds.Tables(0).Rows(0).Item("WIDTH")))
            TxtHIGH.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("HIGH"))), "", Trim(ds.Tables(0).Rows(0).Item("HIGH")))
            TxtTOTAL_VOLUME.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("TOTAL_VOLUME"))), "", Trim(ds.Tables(0).Rows(0).Item("TOTAL_VOLUME")))
            TxtPIECE_VOLUME.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("PIECE_VOLUME"))), "", Trim(ds.Tables(0).Rows(0).Item("PIECE_VOLUME")))
            TxtREMARK.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("remark"))), "", Trim(ds.Tables(0).Rows(0).Item("remark")))
            DTPMEASUREDATE.Value = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("MEASUREDATE"))), Now, Trim(ds.Tables(0).Rows(0).Item("MEASUREDATE")))
            'Call clerk()
            CombTALLY_CLERK.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("MEASURE_WORKER"))), "", Trim(ds.Tables(0).Rows(0).Item("MEASURE_WORKER")))
            TxtNO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("NO"))), "", Trim(ds.Tables(0).Rows(0).Item("NO")))
            txtBLNO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("BLNO"))), "0", Trim(ds.Tables(0).Rows(0).Item("BLNO")))
            TxtMARK.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("MARK"))), "0", Trim(ds.Tables(0).Rows(0).Item("MARK")))
            combcode_goods.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("code_goods"))), "", Trim(ds.Tables(0).Rows(0).Item("code_goods")))
            TxtGOODS_CHA.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("GOODS_CHA"))), "", Trim(ds.Tables(0).Rows(0).Item("GOODS_CHA")))
            TxtAMOUNT.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("AMOUNT"))), "0", Trim(ds.Tables(0).Rows(0).Item("AMOUNT")))
        End If


        Exit Sub
Err:
        Resume Next
    End Sub
    Private Sub clerk()
        Try

            dw = Getdata("exec sp_measure_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & DTPMEASUREDATE.Value & "'", dsclerk)
            CombTALLY_CLERK.DataSource = dsclerk.Tables(0).DefaultView
            CombTALLY_CLERK.DisplayMember = "name"
            CombTALLY_CLERK.ValueMember = "work_no"

        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub
End Class
