<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportNew
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportNew))
        Me.dtpBegin = New System.Windows.Forms.DateTimePicker
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbFeeStat = New System.Windows.Forms.GroupBox
        Me.btnFeeInput = New System.Windows.Forms.Button
        Me.btnFeeXYLH = New System.Windows.Forms.Button
        Me.btnFeeProduce = New System.Windows.Forms.Button
        Me.btnFeeEdi = New System.Windows.Forms.Button
        Me.btnFeeZDHZ = New System.Windows.Forms.Button
        Me.btnywfs_con = New System.Windows.Forms.Button
        Me.btnFeeVoyageCon = New System.Windows.Forms.Button
        Me.btnywfs_cargo = New System.Windows.Forms.Button
        Me.btnFeeVoyageCargo = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chktype = New System.Windows.Forms.CheckBox
        Me.dtpreporttime = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnQuit = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnExportEdit = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnSave = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.gbFeeStat.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpBegin
        '
        Me.dtpBegin.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpBegin.Enabled = False
        Me.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBegin.Location = New System.Drawing.Point(350, 44)
        Me.dtpBegin.Name = "dtpBegin"
        Me.dtpBegin.Size = New System.Drawing.Size(120, 21)
        Me.dtpBegin.TabIndex = 3
        Me.dtpBegin.Visible = False
        '
        'dtpEnd
        '
        Me.dtpEnd.Checked = False
        Me.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpEnd.Enabled = False
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(350, 71)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(120, 21)
        Me.dtpEnd.TabIndex = 4
        Me.dtpEnd.Visible = False
        '
        'Label2
        '
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(308, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "结束时间"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(308, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "开始时间"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'gbFeeStat
        '
        Me.gbFeeStat.Controls.Add(Me.btnFeeInput)
        Me.gbFeeStat.Controls.Add(Me.btnFeeXYLH)
        Me.gbFeeStat.Controls.Add(Me.btnFeeProduce)
        Me.gbFeeStat.Controls.Add(Me.btnFeeEdi)
        Me.gbFeeStat.Controls.Add(Me.btnFeeZDHZ)
        Me.gbFeeStat.Controls.Add(Me.btnywfs_con)
        Me.gbFeeStat.Controls.Add(Me.btnFeeVoyageCon)
        Me.gbFeeStat.Controls.Add(Me.btnywfs_cargo)
        Me.gbFeeStat.Controls.Add(Me.Button3)
        Me.gbFeeStat.Controls.Add(Me.btnFeeVoyageCargo)
        Me.gbFeeStat.Location = New System.Drawing.Point(212, 8)
        Me.gbFeeStat.Name = "gbFeeStat"
        Me.gbFeeStat.Size = New System.Drawing.Size(649, 51)
        Me.gbFeeStat.TabIndex = 1
        Me.gbFeeStat.TabStop = False
        Me.gbFeeStat.Text = "统计项目"
        '
        'btnFeeInput
        '
        Me.btnFeeInput.AutoSize = True
        Me.btnFeeInput.Location = New System.Drawing.Point(163, 15)
        Me.btnFeeInput.Name = "btnFeeInput"
        Me.btnFeeInput.Size = New System.Drawing.Size(108, 32)
        Me.btnFeeInput.TabIndex = 6
        Me.btnFeeInput.Text = "当月数据录入"
        '
        'btnFeeXYLH
        '
        Me.btnFeeXYLH.AutoSize = True
        Me.btnFeeXYLH.Location = New System.Drawing.Point(444, 104)
        Me.btnFeeXYLH.Name = "btnFeeXYLH"
        Me.btnFeeXYLH.Size = New System.Drawing.Size(89, 32)
        Me.btnFeeXYLH.TabIndex = 5
        Me.btnFeeXYLH.Text = "协议理货"
        '
        'btnFeeProduce
        '
        Me.btnFeeProduce.AutoSize = True
        Me.btnFeeProduce.Location = New System.Drawing.Point(321, 67)
        Me.btnFeeProduce.Name = "btnFeeProduce"
        Me.btnFeeProduce.Size = New System.Drawing.Size(117, 32)
        Me.btnFeeProduce.TabIndex = 3
        Me.btnFeeProduce.Text = "生产情况统计"
        '
        'btnFeeEdi
        '
        Me.btnFeeEdi.AutoSize = True
        Me.btnFeeEdi.Location = New System.Drawing.Point(321, 105)
        Me.btnFeeEdi.Name = "btnFeeEdi"
        Me.btnFeeEdi.Size = New System.Drawing.Size(117, 32)
        Me.btnFeeEdi.TabIndex = 4
        Me.btnFeeEdi.Text = "出口集装箱EDI季报"
        '
        'btnFeeZDHZ
        '
        Me.btnFeeZDHZ.AutoSize = True
        Me.btnFeeZDHZ.Location = New System.Drawing.Point(193, 72)
        Me.btnFeeZDHZ.Name = "btnFeeZDHZ"
        Me.btnFeeZDHZ.Size = New System.Drawing.Size(108, 32)
        Me.btnFeeZDHZ.TabIndex = 2
        Me.btnFeeZDHZ.Text = "重点货种"
        Me.btnFeeZDHZ.Visible = False
        '
        'btnywfs_con
        '
        Me.btnywfs_con.AutoSize = True
        Me.btnywfs_con.Location = New System.Drawing.Point(537, 106)
        Me.btnywfs_con.Name = "btnywfs_con"
        Me.btnywfs_con.Size = New System.Drawing.Size(89, 32)
        Me.btnywfs_con.TabIndex = 1
        Me.btnywfs_con.Text = "业务费收-集"
        Me.btnywfs_con.Visible = False
        '
        'btnFeeVoyageCon
        '
        Me.btnFeeVoyageCon.AutoSize = True
        Me.btnFeeVoyageCon.Location = New System.Drawing.Point(444, 66)
        Me.btnFeeVoyageCon.Name = "btnFeeVoyageCon"
        Me.btnFeeVoyageCon.Size = New System.Drawing.Size(89, 32)
        Me.btnFeeVoyageCon.TabIndex = 1
        Me.btnFeeVoyageCon.Text = "集装箱明细"
        '
        'btnywfs_cargo
        '
        Me.btnywfs_cargo.AutoSize = True
        Me.btnywfs_cargo.Location = New System.Drawing.Point(537, 66)
        Me.btnywfs_cargo.Name = "btnywfs_cargo"
        Me.btnywfs_cargo.Size = New System.Drawing.Size(89, 32)
        Me.btnywfs_cargo.TabIndex = 0
        Me.btnywfs_cargo.Text = "业务费收-件"
        Me.btnywfs_cargo.Visible = False
        '
        'btnFeeVoyageCargo
        '
        Me.btnFeeVoyageCargo.AutoSize = True
        Me.btnFeeVoyageCargo.Location = New System.Drawing.Point(27, 15)
        Me.btnFeeVoyageCargo.Name = "btnFeeVoyageCargo"
        Me.btnFeeVoyageCargo.Size = New System.Drawing.Size(108, 32)
        Me.btnFeeVoyageCargo.TabIndex = 0
        Me.btnFeeVoyageCargo.Text = "件杂货明细"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chktype)
        Me.GroupBox1.Controls.Add(Me.dtpreporttime)
        Me.GroupBox1.Controls.Add(Me.dtpBegin)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 51)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询条件"
        '
        'chktype
        '
        Me.chktype.AutoSize = True
        Me.chktype.Enabled = False
        Me.chktype.Location = New System.Drawing.Point(321, 16)
        Me.chktype.Name = "chktype"
        Me.chktype.Size = New System.Drawing.Size(84, 16)
        Me.chktype.TabIndex = 2
        Me.chktype.Text = "按时间查询"
        Me.chktype.UseVisualStyleBackColor = True
        Me.chktype.Visible = False
        '
        'dtpreporttime
        '
        Me.dtpreporttime.CustomFormat = " yyyy-MM"
        Me.dtpreporttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpreporttime.Location = New System.Drawing.Point(74, 20)
        Me.dtpreporttime.Name = "dtpreporttime"
        Me.dtpreporttime.Size = New System.Drawing.Size(113, 21)
        Me.dtpreporttime.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(18, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "报表时间"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.C1DBG)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(865, 369)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "统计结果"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TextBox18)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.TextBox17)
        Me.Panel4.Controls.Add(Me.TextBox15)
        Me.Panel4.Controls.Add(Me.TextBox14)
        Me.Panel4.Controls.Add(Me.TextBox12)
        Me.Panel4.Controls.Add(Me.TextBox11)
        Me.Panel4.Controls.Add(Me.TextBox9)
        Me.Panel4.Controls.Add(Me.TextBox16)
        Me.Panel4.Controls.Add(Me.TextBox8)
        Me.Panel4.Controls.Add(Me.TextBox13)
        Me.Panel4.Controls.Add(Me.TextBox6)
        Me.Panel4.Controls.Add(Me.TextBox10)
        Me.Panel4.Controls.Add(Me.TextBox5)
        Me.Panel4.Controls.Add(Me.TextBox7)
        Me.Panel4.Controls.Add(Me.TextBox3)
        Me.Panel4.Controls.Add(Me.TextBox4)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(6, 20)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(806, 343)
        Me.Panel4.TabIndex = 7
        Me.Panel4.Visible = False
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(483, 274)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(88, 21)
        Me.TextBox18.TabIndex = 17
        Me.TextBox18.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Location = New System.Drawing.Point(707, 263)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 32)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "退出"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Location = New System.Drawing.Point(707, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 32)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "保存"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(385, 274)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(88, 21)
        Me.TextBox17.TabIndex = 16
        Me.TextBox17.Visible = False
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(483, 232)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(88, 21)
        Me.TextBox15.TabIndex = 14
        Me.TextBox15.Visible = False
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(385, 232)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(88, 21)
        Me.TextBox14.TabIndex = 13
        Me.TextBox14.Visible = False
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(483, 189)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(88, 21)
        Me.TextBox12.TabIndex = 11
        Me.TextBox12.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(385, 189)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(88, 21)
        Me.TextBox11.TabIndex = 10
        Me.TextBox11.Visible = False
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(483, 149)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(88, 21)
        Me.TextBox9.TabIndex = 8
        Me.TextBox9.Visible = False
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(286, 274)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(88, 21)
        Me.TextBox16.TabIndex = 15
        Me.TextBox16.Visible = False
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(385, 149)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(88, 21)
        Me.TextBox8.TabIndex = 7
        Me.TextBox8.Visible = False
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(286, 232)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(88, 21)
        Me.TextBox13.TabIndex = 12
        Me.TextBox13.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(483, 108)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(88, 21)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(286, 189)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(88, 21)
        Me.TextBox10.TabIndex = 9
        Me.TextBox10.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(385, 108)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(88, 21)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(286, 149)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(88, 21)
        Me.TextBox7.TabIndex = 6
        Me.TextBox7.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(483, 66)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(88, 21)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(286, 108)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(88, 21)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(385, 66)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(88, 21)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(286, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 21)
        Me.TextBox1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(190, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 32)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "其他"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(190, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 32)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "内贸"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(190, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 32)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "内支线"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(190, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 32)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "外贸"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(190, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 32)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "散化理货"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(483, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 29)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "收入"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(385, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 29)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "吨数"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(286, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 29)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "艘次"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(190, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 32)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "货主委托"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBG
        '
        Me.C1DBG.AllowSort = False
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(3, 17)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(859, 349)
        Me.C1DBG.TabIndex = 6
        Me.C1DBG.Text = "C1TrueDBGrid1"
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.gbFeeStat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(865, 64)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(865, 369)
        Me.Panel2.TabIndex = 1
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Location = New System.Drawing.Point(460, 8)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(92, 32)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "退出"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPrint.Location = New System.Drawing.Point(451, -49)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(92, 32)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "打印"
        Me.btnPrint.Visible = False
        '
        'btnExportEdit
        '
        Me.btnExportEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExportEdit.Location = New System.Drawing.Point(312, 8)
        Me.btnExportEdit.Name = "btnExportEdit"
        Me.btnExportEdit.Size = New System.Drawing.Size(92, 32)
        Me.btnExportEdit.TabIndex = 0
        Me.btnExportEdit.Text = "导出"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnExportEdit)
        Me.Panel3.Controls.Add(Me.btnQuit)
        Me.Panel3.Controls.Add(Me.btnPrint)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 433)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(865, 48)
        Me.Panel3.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(193, -44)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(92, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "保存"
        Me.btnSave.Visible = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Location = New System.Drawing.Point(299, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 32)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "船舶明细"
        '
        'FrmReportNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 481)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FrmReportNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "统计报表"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbFeeStat.ResumeLayout(False)
        Me.gbFeeStat.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbFeeStat As System.Windows.Forms.GroupBox
    Friend WithEvents btnFeeXYLH As System.Windows.Forms.Button
    Friend WithEvents btnFeeProduce As System.Windows.Forms.Button
    Friend WithEvents btnFeeEdi As System.Windows.Forms.Button
    Friend WithEvents btnFeeZDHZ As System.Windows.Forms.Button
    Friend WithEvents btnFeeVoyageCon As System.Windows.Forms.Button
    Friend WithEvents btnFeeVoyageCargo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chktype As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnExportEdit As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtpreporttime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnywfs_con As System.Windows.Forms.Button
    Friend WithEvents btnywfs_cargo As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnFeeInput As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
