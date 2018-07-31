Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmAttemper_PG
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet
    Dim dw As New DataView
    Dim dsship As New DataSet
    Dim dwship As New DataView
    Dim dstmp As New DataSet
    Dim dwtmp As New DataView
    Dim SqlStr As String  '条件语句
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    Dim sqlda As New SqlClient.SqlDataAdapter
    Dim sqldatmp As New SqlClient.SqlDataAdapter
    Dim ds_sub As New DataSet
    Dim dw_sub As New DataView
    Dim sqlda_sub As New SqlClient.SqlDataAdapter
    Dim sqldaClerk As New SqlClient.SqlDataAdapter
    Dim ds_sub1 As New DataSet
    Dim dw_sub1 As New DataView
    Dim sqlda_sub1 As New SqlClient.SqlDataAdapter
    Dim PIECE As Integer
    Dim TONS As Double
    Dim TALLY_CARGO As Integer
    Dim TALLY_CARGO_TON As Double
    Dim TALLY_CARGO_his As Integer
    Dim TALLY_CARGO_TON_his As Double
    Dim TOTAL_NUM As Integer
    Dim TOTAL_NUM_TON As Double
    Dim REMAIN As Integer
    Dim REMAIN_TON As Double
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写 dispose 以清理组件列表。
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtREMAIN_TON As System.Windows.Forms.TextBox
    Friend WithEvents TxtTOTAL_NUM_TON As System.Windows.Forms.TextBox
    Friend WithEvents TxtTALLY_CARGO_TON As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtTALLY_CARGO As System.Windows.Forms.TextBox
    Friend WithEvents TxtCOMPANY_REMARK As System.Windows.Forms.TextBox
    Friend WithEvents TxtDEPT_REMARK As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TxtTOTAL_NUM As System.Windows.Forms.TextBox
    Friend WithEvents TxtREMAIN As System.Windows.Forms.TextBox
    Friend WithEvents CmbMARK_COMPLETE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBERTHNO As System.Windows.Forms.TextBox
    Friend WithEvents CmbNATIONALITY_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCODE_GOODS As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPIECE As System.Windows.Forms.TextBox
    Friend WithEvents TxtTONS As System.Windows.Forms.TextBox
    Friend WithEvents TxtTICKET As System.Windows.Forms.TextBox
    Friend WithEvents CmbINOUTPORT As System.Windows.Forms.ComboBox
    Friend WithEvents CmbLOAD_UNLOAD_PORT As System.Windows.Forms.ComboBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GB4 As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBG1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents CmbDAYNIGHTMARK As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbWORK_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents BtnADD As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmbCLERK_NAME As System.Windows.Forms.ComboBox
    Friend WithEvents GB3 As System.Windows.Forms.GroupBox
    Friend WithEvents RBgsqt1 As System.Windows.Forms.RadioButton
    Friend WithEvents RBbzdb1 As System.Windows.Forms.RadioButton
    Friend WithEvents RBbzqt1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtShip_ID As System.Windows.Forms.TextBox
    Friend WithEvents DTPWATCHDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPERSON As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CmbWork_No As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBgsqt As System.Windows.Forms.RadioButton
    Friend WithEvents RBbzdb As System.Windows.Forms.RadioButton
    Friend WithEvents RBbzqt As System.Windows.Forms.RadioButton
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents C1DBG2 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmAttemper_PG))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines2 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines3 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.GB1 = New System.Windows.Forms.GroupBox
        Me.btSave = New System.Windows.Forms.Button
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.TxtREMAIN_TON = New System.Windows.Forms.TextBox
        Me.TxtTOTAL_NUM_TON = New System.Windows.Forms.TextBox
        Me.TxtTALLY_CARGO_TON = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.TxtTALLY_CARGO = New System.Windows.Forms.TextBox
        Me.TxtCOMPANY_REMARK = New System.Windows.Forms.TextBox
        Me.TxtDEPT_REMARK = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.TxtTOTAL_NUM = New System.Windows.Forms.TextBox
        Me.TxtREMAIN = New System.Windows.Forms.TextBox
        Me.CmbMARK_COMPLETE = New System.Windows.Forms.ComboBox
        Me.TxtBERTHNO = New System.Windows.Forms.TextBox
        Me.CmbNATIONALITY_CODE = New System.Windows.Forms.ComboBox
        Me.CmbCODE_GOODS = New System.Windows.Forms.ComboBox
        Me.TxtPIECE = New System.Windows.Forms.TextBox
        Me.TxtTONS = New System.Windows.Forms.TextBox
        Me.TxtTICKET = New System.Windows.Forms.TextBox
        Me.CmbINOUTPORT = New System.Windows.Forms.ComboBox
        Me.CmbLOAD_UNLOAD_PORT = New System.Windows.Forms.ComboBox
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.GB2 = New System.Windows.Forms.GroupBox
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB4 = New System.Windows.Forms.GroupBox
        Me.C1DBG1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnSave = New System.Windows.Forms.Button
        Me.CmbDAYNIGHTMARK = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbWORK_TYPE = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GB = New System.Windows.Forms.GroupBox
        Me.BtnADD = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmbCLERK_NAME = New System.Windows.Forms.ComboBox
        Me.C1DBG2 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB3 = New System.Windows.Forms.GroupBox
        Me.RBgsqt1 = New System.Windows.Forms.RadioButton
        Me.RBbzdb1 = New System.Windows.Forms.RadioButton
        Me.RBbzqt1 = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.TxtShip_ID = New System.Windows.Forms.TextBox
        Me.DTPWATCHDATE = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtPERSON = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.CmbWork_No = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RBgsqt = New System.Windows.Forms.RadioButton
        Me.RBbzdb = New System.Windows.Forms.RadioButton
        Me.RBbzqt = New System.Windows.Forms.RadioButton
        Me.btQuit = New System.Windows.Forms.Button
        Me.GB1.SuspendLayout()
        Me.GB2.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB4.SuspendLayout()
        CType(Me.C1DBG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        CType(Me.C1DBG2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.btSave)
        Me.GB1.Controls.Add(Me.Label21)
        Me.GB1.Controls.Add(Me.Label24)
        Me.GB1.Controls.Add(Me.Label25)
        Me.GB1.Controls.Add(Me.TxtREMAIN_TON)
        Me.GB1.Controls.Add(Me.TxtTOTAL_NUM_TON)
        Me.GB1.Controls.Add(Me.TxtTALLY_CARGO_TON)
        Me.GB1.Controls.Add(Me.Label23)
        Me.GB1.Controls.Add(Me.TxtTALLY_CARGO)
        Me.GB1.Controls.Add(Me.TxtCOMPANY_REMARK)
        Me.GB1.Controls.Add(Me.TxtDEPT_REMARK)
        Me.GB1.Controls.Add(Me.Label3)
        Me.GB1.Controls.Add(Me.Label5)
        Me.GB1.Controls.Add(Me.Label6)
        Me.GB1.Controls.Add(Me.Label8)
        Me.GB1.Controls.Add(Me.Label9)
        Me.GB1.Controls.Add(Me.Label10)
        Me.GB1.Controls.Add(Me.Label11)
        Me.GB1.Controls.Add(Me.Label12)
        Me.GB1.Controls.Add(Me.Label13)
        Me.GB1.Controls.Add(Me.Label14)
        Me.GB1.Controls.Add(Me.Label17)
        Me.GB1.Controls.Add(Me.Label18)
        Me.GB1.Controls.Add(Me.Label22)
        Me.GB1.Controls.Add(Me.TxtTOTAL_NUM)
        Me.GB1.Controls.Add(Me.TxtREMAIN)
        Me.GB1.Controls.Add(Me.CmbMARK_COMPLETE)
        Me.GB1.Controls.Add(Me.TxtBERTHNO)
        Me.GB1.Controls.Add(Me.CmbNATIONALITY_CODE)
        Me.GB1.Controls.Add(Me.CmbCODE_GOODS)
        Me.GB1.Controls.Add(Me.TxtPIECE)
        Me.GB1.Controls.Add(Me.TxtTONS)
        Me.GB1.Controls.Add(Me.TxtTICKET)
        Me.GB1.Controls.Add(Me.CmbINOUTPORT)
        Me.GB1.Controls.Add(Me.CmbLOAD_UNLOAD_PORT)
        Me.GB1.Controls.Add(Me.BtnDelete)
        Me.GB1.Enabled = False
        Me.GB1.Location = New System.Drawing.Point(154, 24)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(534, 224)
        Me.GB1.TabIndex = 4
        Me.GB1.TabStop = False
        Me.GB1.Text = "单船记录"
        '
        'btSave
        '
        Me.btSave.Enabled = False
        Me.btSave.Location = New System.Drawing.Point(164, 198)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(44, 23)
        Me.btSave.TabIndex = 40
        Me.btSave.Text = "保存"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(426, 44)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(8, 20)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "/"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(426, 68)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(8, 20)
        Me.Label24.TabIndex = 38
        Me.Label24.Text = "/"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(426, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(8, 20)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "/"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtREMAIN_TON
        '
        Me.TxtREMAIN_TON.Location = New System.Drawing.Point(436, 68)
        Me.TxtREMAIN_TON.MaxLength = 9
        Me.TxtREMAIN_TON.Name = "TxtREMAIN_TON"
        Me.TxtREMAIN_TON.Size = New System.Drawing.Size(94, 21)
        Me.TxtREMAIN_TON.TabIndex = 36
        Me.TxtREMAIN_TON.Text = ""
        '
        'TxtTOTAL_NUM_TON
        '
        Me.TxtTOTAL_NUM_TON.Location = New System.Drawing.Point(436, 44)
        Me.TxtTOTAL_NUM_TON.MaxLength = 9
        Me.TxtTOTAL_NUM_TON.Name = "TxtTOTAL_NUM_TON"
        Me.TxtTOTAL_NUM_TON.Size = New System.Drawing.Size(94, 21)
        Me.TxtTOTAL_NUM_TON.TabIndex = 35
        Me.TxtTOTAL_NUM_TON.Text = ""
        '
        'TxtTALLY_CARGO_TON
        '
        Me.TxtTALLY_CARGO_TON.Location = New System.Drawing.Point(436, 20)
        Me.TxtTALLY_CARGO_TON.MaxLength = 9
        Me.TxtTALLY_CARGO_TON.Name = "TxtTALLY_CARGO_TON"
        Me.TxtTALLY_CARGO_TON.Size = New System.Drawing.Size(94, 21)
        Me.TxtTALLY_CARGO_TON.TabIndex = 34
        Me.TxtTALLY_CARGO_TON.Text = ""
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(6, 155)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 36)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "理货部备注"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTALLY_CARGO
        '
        Me.TxtTALLY_CARGO.Location = New System.Drawing.Point(342, 20)
        Me.TxtTALLY_CARGO.MaxLength = 8
        Me.TxtTALLY_CARGO.Name = "TxtTALLY_CARGO"
        Me.TxtTALLY_CARGO.Size = New System.Drawing.Size(82, 21)
        Me.TxtTALLY_CARGO.TabIndex = 8
        Me.TxtTALLY_CARGO.Text = ""
        '
        'TxtCOMPANY_REMARK
        '
        Me.TxtCOMPANY_REMARK.Location = New System.Drawing.Point(72, 115)
        Me.TxtCOMPANY_REMARK.MaxLength = 200
        Me.TxtCOMPANY_REMARK.Multiline = True
        Me.TxtCOMPANY_REMARK.Name = "TxtCOMPANY_REMARK"
        Me.TxtCOMPANY_REMARK.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtCOMPANY_REMARK.Size = New System.Drawing.Size(460, 37)
        Me.TxtCOMPANY_REMARK.TabIndex = 12
        Me.TxtCOMPANY_REMARK.Text = ""
        '
        'TxtDEPT_REMARK
        '
        Me.TxtDEPT_REMARK.Location = New System.Drawing.Point(72, 155)
        Me.TxtDEPT_REMARK.MaxLength = 100
        Me.TxtDEPT_REMARK.Multiline = True
        Me.TxtDEPT_REMARK.Name = "TxtDEPT_REMARK"
        Me.TxtDEPT_REMARK.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtDEPT_REMARK.Size = New System.Drawing.Size(460, 37)
        Me.TxtDEPT_REMARK.TabIndex = 13
        Me.TxtDEPT_REMARK.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "泊位号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "票数"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "装卸港名称"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 20)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "进出口"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(148, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "货类"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(148, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 20)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "原载件数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(148, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 20)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "原载吨数"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(148, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 20)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "国籍"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(286, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 20)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "本班完船"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(286, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 20)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "余数"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(286, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 20)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "本班理货"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(286, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 20)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "累计数"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(6, 115)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 36)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "公司备注"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTOTAL_NUM
        '
        Me.TxtTOTAL_NUM.Location = New System.Drawing.Point(342, 44)
        Me.TxtTOTAL_NUM.MaxLength = 8
        Me.TxtTOTAL_NUM.Name = "TxtTOTAL_NUM"
        Me.TxtTOTAL_NUM.Size = New System.Drawing.Size(82, 21)
        Me.TxtTOTAL_NUM.TabIndex = 9
        Me.TxtTOTAL_NUM.Text = ""
        '
        'TxtREMAIN
        '
        Me.TxtREMAIN.Location = New System.Drawing.Point(342, 68)
        Me.TxtREMAIN.MaxLength = 8
        Me.TxtREMAIN.Name = "TxtREMAIN"
        Me.TxtREMAIN.Size = New System.Drawing.Size(82, 21)
        Me.TxtREMAIN.TabIndex = 10
        Me.TxtREMAIN.Text = ""
        '
        'CmbMARK_COMPLETE
        '
        Me.CmbMARK_COMPLETE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMARK_COMPLETE.Location = New System.Drawing.Point(342, 92)
        Me.CmbMARK_COMPLETE.Name = "CmbMARK_COMPLETE"
        Me.CmbMARK_COMPLETE.Size = New System.Drawing.Size(188, 20)
        Me.CmbMARK_COMPLETE.TabIndex = 11
        '
        'TxtBERTHNO
        '
        Me.TxtBERTHNO.Location = New System.Drawing.Point(73, 19)
        Me.TxtBERTHNO.MaxLength = 2
        Me.TxtBERTHNO.Name = "TxtBERTHNO"
        Me.TxtBERTHNO.Size = New System.Drawing.Size(73, 21)
        Me.TxtBERTHNO.TabIndex = 0
        Me.TxtBERTHNO.Text = ""
        '
        'CmbNATIONALITY_CODE
        '
        Me.CmbNATIONALITY_CODE.Location = New System.Drawing.Point(204, 19)
        Me.CmbNATIONALITY_CODE.Name = "CmbNATIONALITY_CODE"
        Me.CmbNATIONALITY_CODE.Size = New System.Drawing.Size(80, 20)
        Me.CmbNATIONALITY_CODE.TabIndex = 4
        '
        'CmbCODE_GOODS
        '
        Me.CmbCODE_GOODS.Location = New System.Drawing.Point(204, 43)
        Me.CmbCODE_GOODS.Name = "CmbCODE_GOODS"
        Me.CmbCODE_GOODS.Size = New System.Drawing.Size(80, 20)
        Me.CmbCODE_GOODS.TabIndex = 5
        '
        'TxtPIECE
        '
        Me.TxtPIECE.Location = New System.Drawing.Point(204, 67)
        Me.TxtPIECE.Name = "TxtPIECE"
        Me.TxtPIECE.Size = New System.Drawing.Size(80, 21)
        Me.TxtPIECE.TabIndex = 6
        Me.TxtPIECE.Text = ""
        '
        'TxtTONS
        '
        Me.TxtTONS.Location = New System.Drawing.Point(204, 91)
        Me.TxtTONS.Name = "TxtTONS"
        Me.TxtTONS.Size = New System.Drawing.Size(80, 21)
        Me.TxtTONS.TabIndex = 7
        Me.TxtTONS.Text = ""
        '
        'TxtTICKET
        '
        Me.TxtTICKET.Location = New System.Drawing.Point(73, 67)
        Me.TxtTICKET.MaxLength = 4
        Me.TxtTICKET.Name = "TxtTICKET"
        Me.TxtTICKET.Size = New System.Drawing.Size(73, 21)
        Me.TxtTICKET.TabIndex = 2
        Me.TxtTICKET.Text = ""
        '
        'CmbINOUTPORT
        '
        Me.CmbINOUTPORT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbINOUTPORT.Location = New System.Drawing.Point(73, 43)
        Me.CmbINOUTPORT.Name = "CmbINOUTPORT"
        Me.CmbINOUTPORT.Size = New System.Drawing.Size(73, 20)
        Me.CmbINOUTPORT.TabIndex = 1
        '
        'CmbLOAD_UNLOAD_PORT
        '
        Me.CmbLOAD_UNLOAD_PORT.Location = New System.Drawing.Point(73, 91)
        Me.CmbLOAD_UNLOAD_PORT.Name = "CmbLOAD_UNLOAD_PORT"
        Me.CmbLOAD_UNLOAD_PORT.Size = New System.Drawing.Size(73, 20)
        Me.CmbLOAD_UNLOAD_PORT.TabIndex = 3
        '
        'BtnDelete
        '
        Me.BtnDelete.Enabled = False
        Me.BtnDelete.Location = New System.Drawing.Point(212, 198)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(42, 22)
        Me.BtnDelete.TabIndex = 20
        Me.BtnDelete.Text = "删除"
        '
        'GB2
        '
        Me.GB2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GB2.Controls.Add(Me.C1DBG)
        Me.GB2.Enabled = False
        Me.GB2.Location = New System.Drawing.Point(0, 2)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(154, 526)
        Me.GB2.TabIndex = 3
        Me.GB2.TabStop = False
        Me.GB2.Text = "航次信息"
        '
        'C1DBG
        '
        Me.C1DBG.AllowColMove = False
        Me.C1DBG.AllowDrag = True
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG.AllowSort = True
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(4, 14)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowDivider = GridLines1
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.ScrollTips = False
        Me.C1DBG.Size = New System.Drawing.Size(148, 508)
        Me.C1DBG.TabIndex = 0
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Style11{}Style12{}Style13{}Style5{}Style4{}Style7{}Style6{}EvenRow{Back" & _
        "Color:Aqua;}Selected{ForeColor:HighlightText;BackColor:Highlight;}Heading{Wrap:T" & _
        "rue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:C" & _
        "ontrol;}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}Filter" & _
        "Bar{}OddRow{}Footer{}Caption{AlignHorz:Center;}Style27{}Normal{}Style26{}Highlig" & _
        "htRow{ForeColor:HighlightText;BackColor:Highlight;}Style10{AlignHorz:Near;}Edito" & _
        "r{}RecordSelector{AlignImage:Center;}Style9{}Style8{}Style3{}Style2{}Group{BackC" & _
        "olor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""False"" Name="""" CaptionHe" & _
        "ight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedC" & _
        "ellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" " & _
        "HorizontalScrollGroup=""1""><ClientRect>0, 0, 144, 504</ClientRect><BorderSide>0</" & _
        "BorderSide><CaptionStyle parent=""Heading"" me=""Style10"" /><EditorStyle parent=""Ed" & _
        "itor"" me=""Style2"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle" & _
        " parent=""FilterBar"" me=""Style27"" /><FooterStyle parent=""Footer"" me=""Style4"" /><G" & _
        "roupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style" & _
        "3"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle paren" & _
        "t=""Inactive"" me=""Style6"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSel" & _
        "ectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selecte" & _
        "d"" me=""Style5"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.Merg" & _
        "eView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal" & _
        """ me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" m" & _
        "e=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=" & _
        """Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Hig" & _
        "hlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""Od" & _
        "dRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=" & _
        """FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</" & _
        "vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16" & _
        "</DefaultRecSelWidth><ClientArea>0, 0, 144, 504</ClientArea></Blob>"
        '
        'GB4
        '
        Me.GB4.Controls.Add(Me.C1DBG1)
        Me.GB4.Location = New System.Drawing.Point(464, 250)
        Me.GB4.Name = "GB4"
        Me.GB4.Size = New System.Drawing.Size(222, 290)
        Me.GB4.TabIndex = 105
        Me.GB4.TabStop = False
        Me.GB4.Text = "已派工情况"
        '
        'C1DBG1
        '
        Me.C1DBG1.AllowColMove = False
        Me.C1DBG1.AllowFilter = True
        Me.C1DBG1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG1.AllowSort = True
        Me.C1DBG1.AllowUpdate = False
        Me.C1DBG1.CaptionHeight = 18
        Me.C1DBG1.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG1.DataChanged = False
        Me.C1DBG1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG1.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG1.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1DBG1.Location = New System.Drawing.Point(3, 16)
        Me.C1DBG1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG1.Name = "C1DBG1"
        Me.C1DBG1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG1.PreviewInfo.ZoomFactor = 75
        Me.C1DBG1.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG1.RecordSelectorWidth = 16
        GridLines2.Color = System.Drawing.Color.DarkGray
        GridLines2.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG1.RowDivider = GridLines2
        Me.C1DBG1.RowHeight = 16
        Me.C1DBG1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG1.ScrollTips = False
        Me.C1DBG1.Size = New System.Drawing.Size(217, 270)
        Me.C1DBG1.TabIndex = 0
        Me.C1DBG1.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView AllowColMove=""False"" Name="""" CaptionHeight=""18"" ColumnCa" & _
        "ptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordS" & _
        "electorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGr" & _
        "oup=""1""><ClientRect>0, 0, 213, 266</ClientRect><BorderSide>0</BorderSide><Captio" & _
        "nStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /" & _
        "><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar""" & _
        " me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""G" & _
        "roup"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowS" & _
        "tyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""St" & _
        "yle4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""" & _
        "RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><S" & _
        "tyle parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><Nam" & _
        "edStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><S" & _
        "tyle parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Styl" & _
        "e parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style" & _
        " parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style" & _
        " parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style pare" & _
        "nt=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Styl" & _
        "e parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSpl" & _
        "its>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidt" & _
        "h><ClientArea>0, 0, 213, 266</ClientArea></Blob>"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(270, 514)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 96
        Me.btnSave.Text = "保存"
        '
        'CmbDAYNIGHTMARK
        '
        Me.CmbDAYNIGHTMARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbDAYNIGHTMARK.Enabled = False
        Me.CmbDAYNIGHTMARK.Location = New System.Drawing.Point(444, 2)
        Me.CmbDAYNIGHTMARK.Name = "CmbDAYNIGHTMARK"
        Me.CmbDAYNIGHTMARK.Size = New System.Drawing.Size(94, 20)
        Me.CmbDAYNIGHTMARK.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(276, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "班次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbWORK_TYPE
        '
        Me.CmbWORK_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbWORK_TYPE.Enabled = False
        Me.CmbWORK_TYPE.Location = New System.Drawing.Point(310, 2)
        Me.CmbWORK_TYPE.Name = "CmbWORK_TYPE"
        Me.CmbWORK_TYPE.Size = New System.Drawing.Size(94, 20)
        Me.CmbWORK_TYPE.TabIndex = 90
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(406, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 20)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "班别"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GB
        '
        Me.GB.Controls.Add(Me.BtnADD)
        Me.GB.Controls.Add(Me.Label7)
        Me.GB.Controls.Add(Me.CmbCLERK_NAME)
        Me.GB.Controls.Add(Me.C1DBG2)
        Me.GB.Controls.Add(Me.GB3)
        Me.GB.Controls.Add(Me.Button1)
        Me.GB.Location = New System.Drawing.Point(156, 338)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(306, 174)
        Me.GB.TabIndex = 95
        Me.GB.TabStop = False
        Me.GB.Text = "理货员"
        '
        'BtnADD
        '
        Me.BtnADD.Enabled = False
        Me.BtnADD.Location = New System.Drawing.Point(147, 145)
        Me.BtnADD.Name = "BtnADD"
        Me.BtnADD.Size = New System.Drawing.Size(65, 24)
        Me.BtnADD.TabIndex = 3
        Me.BtnADD.Text = "添加"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(125, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "理货员姓名"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbCLERK_NAME
        '
        Me.CmbCLERK_NAME.Location = New System.Drawing.Point(200, 116)
        Me.CmbCLERK_NAME.Name = "CmbCLERK_NAME"
        Me.CmbCLERK_NAME.Size = New System.Drawing.Size(100, 20)
        Me.CmbCLERK_NAME.TabIndex = 2
        '
        'C1DBG2
        '
        Me.C1DBG2.AllowColMove = False
        Me.C1DBG2.AllowFilter = True
        Me.C1DBG2.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG2.AllowSort = True
        Me.C1DBG2.AllowUpdate = False
        Me.C1DBG2.CaptionHeight = 18
        Me.C1DBG2.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG2.DataChanged = False
        Me.C1DBG2.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG2.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG2.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG2.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.C1DBG2.Location = New System.Drawing.Point(3, 16)
        Me.C1DBG2.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG2.Name = "C1DBG2"
        Me.C1DBG2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG2.PreviewInfo.ZoomFactor = 75
        Me.C1DBG2.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG2.RecordSelectorWidth = 16
        GridLines3.Color = System.Drawing.Color.DarkGray
        GridLines3.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG2.RowDivider = GridLines3
        Me.C1DBG2.RowHeight = 16
        Me.C1DBG2.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG2.ScrollTips = False
        Me.C1DBG2.Size = New System.Drawing.Size(300, 94)
        Me.C1DBG2.TabIndex = 0
        Me.C1DBG2.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Style11{}Style12{}FilterBar{}Style5{}Style4{}Style7{}Style6{}EvenRow{Ba" & _
        "ckColor:Aqua;}Selected{ForeColor:HighlightText;BackColor:Highlight;}Heading{Wrap" & _
        ":True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor" & _
        ":Control;}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}Foot" & _
        "er{}Caption{AlignHorz:Center;}Editor{}Normal{}HighlightRow{ForeColor:HighlightTe" & _
        "xt;BackColor:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Style9" & _
        "{}Style8{}Style3{}Style2{}Style13{}Group{BackColor:ControlDark;Border:None,,0, 0" & _
        ", 0, 0;AlignVert:Center;}Style10{AlignHorz:Near;}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView AllowColMove=""False"" Name="""" CaptionHeight=""18"" ColumnCa" & _
        "ptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordS" & _
        "electorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGr" & _
        "oup=""1""><ClientRect>0, 0, 296, 90</ClientRect><BorderSide>0</BorderSide><Caption" & _
        "Style parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" />" & _
        "<EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" " & _
        "me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Gr" & _
        "oup"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowSt" & _
        "yle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Sty" & _
        "le4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""R" & _
        "ecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><St" & _
        "yle parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><Name" & _
        "dStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><St" & _
        "yle parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style" & _
        " parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style " & _
        "parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style " & _
        "parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style paren" & _
        "t=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style" & _
        " parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSpli" & _
        "ts>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</DefaultRecSelW" & _
        "idth><ClientArea>0, 0, 296, 90</ClientArea></Blob>"
        '
        'GB3
        '
        Me.GB3.BackColor = System.Drawing.Color.Transparent
        Me.GB3.Controls.Add(Me.RBgsqt1)
        Me.GB3.Controls.Add(Me.RBbzdb1)
        Me.GB3.Controls.Add(Me.RBbzqt1)
        Me.GB3.Location = New System.Drawing.Point(4, 108)
        Me.GB3.Name = "GB3"
        Me.GB3.Size = New System.Drawing.Size(112, 64)
        Me.GB3.TabIndex = 1
        Me.GB3.TabStop = False
        '
        'RBgsqt1
        '
        Me.RBgsqt1.BackColor = System.Drawing.Color.Transparent
        Me.RBgsqt1.Location = New System.Drawing.Point(4, 46)
        Me.RBgsqt1.Name = "RBgsqt1"
        Me.RBgsqt1.Size = New System.Drawing.Size(112, 18)
        Me.RBgsqt1.TabIndex = 2
        Me.RBgsqt1.Text = "公司其他人员"
        '
        'RBbzdb1
        '
        Me.RBbzdb1.BackColor = System.Drawing.Color.Transparent
        Me.RBbzdb1.Location = New System.Drawing.Point(4, 10)
        Me.RBbzdb1.Name = "RBbzdb1"
        Me.RBbzdb1.Size = New System.Drawing.Size(112, 18)
        Me.RBbzdb1.TabIndex = 0
        Me.RBbzdb1.Text = "本班当班人员"
        '
        'RBbzqt1
        '
        Me.RBbzqt1.BackColor = System.Drawing.Color.Transparent
        Me.RBbzqt1.Location = New System.Drawing.Point(4, 28)
        Me.RBbzqt1.Name = "RBbzqt1"
        Me.RBbzqt1.Size = New System.Drawing.Size(112, 18)
        Me.RBbzqt1.TabIndex = 1
        Me.RBbzqt1.Text = "本部其他人员"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(216, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "删除"
        '
        'TxtShip_ID
        '
        Me.TxtShip_ID.Location = New System.Drawing.Point(170, 514)
        Me.TxtShip_ID.MaxLength = 40
        Me.TxtShip_ID.Name = "TxtShip_ID"
        Me.TxtShip_ID.ReadOnly = True
        Me.TxtShip_ID.Size = New System.Drawing.Size(22, 21)
        Me.TxtShip_ID.TabIndex = 100
        Me.TxtShip_ID.TabStop = False
        Me.TxtShip_ID.Text = ""
        Me.TxtShip_ID.Visible = False
        '
        'DTPWATCHDATE
        '
        Me.DTPWATCHDATE.CustomFormat = "yyyy/MM/dd"
        Me.DTPWATCHDATE.Enabled = False
        Me.DTPWATCHDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWATCHDATE.Location = New System.Drawing.Point(188, 2)
        Me.DTPWATCHDATE.Name = "DTPWATCHDATE"
        Me.DTPWATCHDATE.Size = New System.Drawing.Size(88, 21)
        Me.DTPWATCHDATE.TabIndex = 89
        Me.DTPWATCHDATE.Value = New Date(2006, 4, 14, 9, 25, 24, 281)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(156, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "日期"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtPERSON)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.CmbWork_No)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(156, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 86)
        Me.GroupBox2.TabIndex = 106
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "理货组长"
        '
        'TxtPERSON
        '
        Me.TxtPERSON.Location = New System.Drawing.Point(62, 28)
        Me.TxtPERSON.MaxLength = 2
        Me.TxtPERSON.Name = "TxtPERSON"
        Me.TxtPERSON.Size = New System.Drawing.Size(88, 21)
        Me.TxtPERSON.TabIndex = 100
        Me.TxtPERSON.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(4, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 20)
        Me.Label15.TabIndex = 104
        Me.Label15.Text = "理货组长"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(4, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 20)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "人数"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbWork_No
        '
        Me.CmbWork_No.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWork_No.Location = New System.Drawing.Point(62, 54)
        Me.CmbWork_No.Name = "CmbWork_No"
        Me.CmbWork_No.Size = New System.Drawing.Size(88, 20)
        Me.CmbWork_No.TabIndex = 101
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RBgsqt)
        Me.GroupBox1.Controls.Add(Me.RBbzdb)
        Me.GroupBox1.Controls.Add(Me.RBbzqt)
        Me.GroupBox1.Location = New System.Drawing.Point(150, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(154, 56)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        '
        'RBgsqt
        '
        Me.RBgsqt.BackColor = System.Drawing.Color.Transparent
        Me.RBgsqt.Location = New System.Drawing.Point(102, 10)
        Me.RBgsqt.Name = "RBgsqt"
        Me.RBgsqt.Size = New System.Drawing.Size(50, 46)
        Me.RBgsqt.TabIndex = 2
        Me.RBgsqt.Text = "公司其他人员"
        '
        'RBbzdb
        '
        Me.RBbzdb.BackColor = System.Drawing.Color.Transparent
        Me.RBbzdb.Location = New System.Drawing.Point(2, 10)
        Me.RBbzdb.Name = "RBbzdb"
        Me.RBbzdb.Size = New System.Drawing.Size(50, 46)
        Me.RBbzdb.TabIndex = 0
        Me.RBbzdb.Text = "本班当班人员"
        '
        'RBbzqt
        '
        Me.RBbzqt.BackColor = System.Drawing.Color.Transparent
        Me.RBbzqt.Location = New System.Drawing.Point(52, 10)
        Me.RBbzqt.Name = "RBbzqt"
        Me.RBbzqt.Size = New System.Drawing.Size(50, 46)
        Me.RBbzqt.TabIndex = 1
        Me.RBbzqt.Text = "本部其他人员"
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(338, 514)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(60, 24)
        Me.btQuit.TabIndex = 107
        Me.btQuit.Text = "退出"
        '
        'FrmAttemper_PG
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(688, 541)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GB4)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DTPWATCHDATE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbDAYNIGHTMARK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbWORK_TYPE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.TxtShip_ID)
        Me.Controls.Add(Me.GB1)
        Me.Controls.Add(Me.GB2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAttemper_PG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "值班调度(派工)"
        Me.GB1.ResumeLayout(False)
        Me.GB2.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB4.ResumeLayout(False)
        CType(Me.C1DBG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        CType(Me.C1DBG2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmAttemper_PG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FirmStr = " Order by Ship_Statu,Dept_Code,ship_id desc "  '设计初始条件  在检索后不改变的条件 
        If SysType = "1" Then
            DynaStr = " (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2'))" 'and code_goods='2' 
        Else
            DynaStr = " (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1'))" 'and code_goods='2' 
        End If
        SqlStr = DynaStr & FirmStr
        Call myDataGrid(SqlStr)   '*****************调用船舶信息
        Call FillDAYNIGHTMARK()
        Call FillWORK_TYPE()
        btnSave.Enabled = False
        'btnQuit.Enabled = False
        GB1.Enabled = True
        GB2.Enabled = True
        DTPWATCHDATE.Enabled = False
        CmbWORK_TYPE.Enabled = False
        CmbDAYNIGHTMARK.Enabled = False
        
        CmbWORK_TYPE.Text = G_BC
        DTPWATCHDATE.Value = G_Date
        CmbDAYNIGHTMARK.SelectedValue = G_BB

        If G_DeptCode = "26.11" Then
            TxtCOMPANY_REMARK.Enabled = True
            TxtDEPT_REMARK.Enabled = False
        ElseIf G_DeptCode Like "26.11.*" Then
            TxtCOMPANY_REMARK.Enabled = False
            TxtDEPT_REMARK.Enabled = True
        End If
    End Sub
    
    Private Sub myDataGrid(ByVal Sql As String) '**************船舶信息
        Dim strsql As String
        Dim i As Integer
        strsql = "select * from VIEW_WATCH_RECORD_SHIP where " & Sql   '船舶条件语句 不改部分
        dwship = Getdata(strsql, dsship)
        Try
            Me.C1DBG.DataSource = dwship
            For i = 3 To Me.C1DBG.Columns.Count - 1
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBG.Columns.Item(0).Caption = "中文船名"
            Me.C1DBG.Columns.Item(1).Caption = "航次"
            Me.C1DBG.Columns.Item(2).Caption = "DS"
            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Width = 65
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Width = 42
            Me.C1DBG.Splits(0).DisplayColumns.Item(2).Width = 18

            Me.C1DBG.FetchRowStyles = True
            Me.C1DBG.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle

        If Me.C1DBG.Columns("SHIP_STATU").CellValue(e.Row) = 2 Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        End If

    End Sub
    Private Sub FillINOUTPORT()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select InOutPort,InOutPort_Name from Code_InOutPort"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbINOUTPORT.DataSource = dvc
        Me.CmbINOUTPORT.DisplayMember = "InOutPort_Name"
        Me.CmbINOUTPORT.ValueMember = "InOutPort"
    End Sub
    Private Sub FillLOAD_UNLOAD_PORT()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select CODE_PORT,PORT_CHA from CODE_PORT order by PORT_CHA"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbLOAD_UNLOAD_PORT.DataSource = dvc
        Me.CmbLOAD_UNLOAD_PORT.DisplayMember = "PORT_CHA"
        Me.CmbLOAD_UNLOAD_PORT.ValueMember = "CODE_PORT"
    End Sub
    Private Sub FillNATIONALITY_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select NATIONALITY_CHA,NATIONALITY_ENG from CODE_NATIONALITY order by NATIONALITY_CHA"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbNATIONALITY_CODE.DataSource = dvc
        Me.CmbNATIONALITY_CODE.DisplayMember = "NATIONALITY_CHA"
        Me.CmbNATIONALITY_CODE.ValueMember = "NATIONALITY_ENG"
    End Sub

    Private Sub FillCODE_GOODS()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select Code_Cargo_Type,Cargo_Type from Code_Cargo_Type"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbCODE_GOODS.DataSource = dvc
        Me.CmbCODE_GOODS.DisplayMember = "Cargo_Type"
        Me.CmbCODE_GOODS.ValueMember = "Code_Cargo_Type"
    End Sub
    Private Sub FillMARK_COMPLETE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select Descri,Value from CodeLINER_ID"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbMARK_COMPLETE.DataSource = dvc
        Me.CmbMARK_COMPLETE.DisplayMember = "Descri"
        Me.CmbMARK_COMPLETE.ValueMember = "Value"
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        On Error GoTo Err
        Dim i As Integer
        Dim statu As Integer
        Dim dssp As New DataSet
        Dim dvsp As New DataView

        GB1.Text = "单船记录： " & Me.C1DBG.Columns.Item(0).Text & " " & Me.C1DBG.Columns.Item(1).Text

        Call FillINOUTPORT()
        Call FillLOAD_UNLOAD_PORT()
        Call FillNATIONALITY_CODE()
        Call FillCODE_GOODS()
        Call FillMARK_COMPLETE()

        ID = CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer)
        statu = CType(Me.C1DBG.Columns.Item("SHIP_STATU").Text.ToString, Integer)



        btSave.Enabled = True

        SqlStr = "select * from WATCH_RECORD_SHIP where SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) & "  order by WATCHSHIPDATE desc"
        dwtmp = Getdata(SqlStr, dstmp)
        If dwtmp.Count > 0 Then
            TxtTICKET.Text = dstmp.Tables(0).Rows(0).Item("TICKET")
            TxtPIECE.Text = dstmp.Tables(0).Rows(0).Item("PIECE")
            TxtTONS.Text = dstmp.Tables(0).Rows(0).Item("TONS")
        End If


        SqlStr = "select * from WATCH_RECORD_SHIP where SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) & " and datediff(dd,WATCHSHIPDATE ,'" & DTPWATCHDATE.Value & "')=0 and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
        dwtmp = Getdata(SqlStr, dstmp)
        If dwtmp.Count > 0 Then  '存在对应航次的值班单船记录，提取
            If Len(Trim(dstmp.Tables(0).Rows(0).Item("BERTHNO"))) > 0 Then
                TxtBERTHNO.Text = Trim(dstmp.Tables(0).Rows(0).Item("BERTHNO"))
            Else
                TxtBERTHNO.Text = ""
            End If
            CmbINOUTPORT.SelectedValue = dstmp.Tables(0).Rows(0).Item("INOUTPORT")
            CmbLOAD_UNLOAD_PORT.SelectedValue = dstmp.Tables(0).Rows(0).Item("LOAD_UNLOAD_PORT")
            CmbNATIONALITY_CODE.SelectedValue = dstmp.Tables(0).Rows(0).Item("NATIONALITY_CODE")
            CmbCODE_GOODS.SelectedValue = dstmp.Tables(0).Rows(0).Item("CODE_GOODS")
            TxtTALLY_CARGO.Text = dstmp.Tables(0).Rows(0).Item("TALLY_CARGO")
            TxtTALLY_CARGO_TON.Text = dstmp.Tables(0).Rows(0).Item("TALLY_CARGO_TON")
            TxtTOTAL_NUM.Text = dstmp.Tables(0).Rows(0).Item("TOTAL_NUM")
            TxtTOTAL_NUM_TON.Text = dstmp.Tables(0).Rows(0).Item("TOTAL_NUM_TON")
            TxtREMAIN.Text = dstmp.Tables(0).Rows(0).Item("REMAIN")
            TxtREMAIN_TON.Text = dstmp.Tables(0).Rows(0).Item("REMAIN_TON")
            CmbMARK_COMPLETE.SelectedValue = dstmp.Tables(0).Rows(0).Item("MARK_COMPLETE")
            TxtCOMPANY_REMARK.Text = dstmp.Tables(0).Rows(0).Item("COMPANY_REMARK")
            TxtDEPT_REMARK.Text = dstmp.Tables(0).Rows(0).Item("DEPT_REMARK")
            If G_DeptCode = "26.11" Then  '填充公司备注
                If Len(Trim(TxtCOMPANY_REMARK.Text)) = 0 Then
                    If CmbDAYNIGHTMARK.SelectedValue = "01" Then
                        SqlStr = "select Company_REMARK from WATCH_RECORD_SHIP where SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) & " and datediff(dd,WATCHSHIPDATE, DateAdd(DateInterval.Day, -1, '" & DTPWATCHDATE.Value & "'))=0 and DayNightMark='02' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtCOMPANY_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    ElseIf CmbDAYNIGHTMARK.SelectedValue = "02" Then
                        SqlStr = "select Company_REMARK from WATCH_RECORD_SHIP where SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) & " and datediff(dd,WATCHSHIPDATE, '" & DTPWATCHDATE.Value & "' and DayNightMark='01' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtCOMPANY_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    End If
                End If
            ElseIf G_DeptCode Like "26.11.*" Then  '填充部门备注
                If Len(Trim(TxtDEPT_REMARK.Text)) = 0 Then
                    If CmbDAYNIGHTMARK.SelectedValue = "01" Then
                        SqlStr = "select Dept_Remark from WATCH_RECORD_SHIP where SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) & " and datediff(dd,WATCHSHIPDATE, DateAdd(DateInterval.Day, -1, '" & DTPWATCHDATE.Value & "'))=0 and DayNightMark='02' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtDEPT_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    ElseIf CmbDAYNIGHTMARK.SelectedValue = "02" Then
                        SqlStr = "select Dept_Remark from WATCH_RECORD_SHIP where SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) & " and datediff(dd,WATCHSHIPDATE, '" & DTPWATCHDATE.Value & "' and DayNightMark='01' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtDEPT_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    End If
                End If
            End If
            BtnDelete.Enabled = True
        Else                     '不存在对应航次的值班单船记录，新增
            BtnDelete.Enabled = False
            SqlStr = "select * from VIEW_WATCH_RECORD_SHIP where SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) & ""
            dwtmp = Updatedata(sqlda, SqlStr, dstmp)
            If dwtmp.Count > 0 Then
                If Len(Trim(dstmp.Tables(0).Rows(0).Item("BERTHNO"))) > 0 Then
                    TxtBERTHNO.Text = Trim(dstmp.Tables(0).Rows(0).Item("BERTHNO"))
                Else
                    TxtBERTHNO.Text = ""
                End If
                CmbINOUTPORT.SelectedValue = dstmp.Tables(0).Rows(0).Item("INOUTPORT")
                CmbNATIONALITY_CODE.SelectedValue = dstmp.Tables(0).Rows(0).Item("NATIONALITY_CODE")
                CmbCODE_GOODS.SelectedValue = dstmp.Tables(0).Rows(0).Item("CODE_GOODS")

                TxtTALLY_CARGO.Text = ""
                TxtTALLY_CARGO_TON.Text = ""
                TxtTOTAL_NUM.Text = ""
                TxtTOTAL_NUM_TON.Text = ""
                TxtREMAIN.Text = ""
                TxtREMAIN_TON.Text = ""

                CmbMARK_COMPLETE.SelectedValue = "01"
                dvsp = Getdata("exec sp_WATCH_RECORD_SHIP '" & ID & "','" & CmbINOUTPORT.SelectedValue & "'", dssp)
                'TxtTICKET.Text = dssp.Tables(0).Rows(0).Item(0)
                'TxtPIECE.Text = dssp.Tables(0).Rows(0).Item(1)
                'TxtTONS.Text = dssp.Tables(0).Rows(0).Item(2)
                CmbLOAD_UNLOAD_PORT.SelectedValue = dssp.Tables(0).Rows(0).Item(3)

                TxtCOMPANY_REMARK.Text = ""
                TxtDEPT_REMARK.Text = ""
                If G_DeptCode = "26.11" Then    '填充公司备注
                    If CmbDAYNIGHTMARK.SelectedValue = "01" Then
                        SqlStr = "select Company_REMARK from WATCH_RECORD_SHIP where SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) & " and datediff(dd,WATCHSHIPDATE, DateAdd(DateInterval.Day, -1, '" & DTPWATCHDATE.Value & "'))=0 and DayNightMark='02' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtCOMPANY_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    ElseIf CmbDAYNIGHTMARK.SelectedValue = "02" Then
                        SqlStr = "select Company_REMARK from WATCH_RECORD_SHIP where SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) & " and datediff(dd,WATCHSHIPDATE, '" & DTPWATCHDATE.Value & "' and DayNightMark='01' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtCOMPANY_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    End If
                ElseIf G_DeptCode Like "26.11.*" Then        '填充部门备注
                    If CmbDAYNIGHTMARK.SelectedValue = "01" Then
                        SqlStr = "select Dept_Remark from WATCH_RECORD_SHIP where SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) & " and datediff(dd,WATCHSHIPDATE, DateAdd(DateInterval.Day, -1, '" & DTPWATCHDATE.Value & "'))=0 and DayNightMark='02' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtDEPT_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    ElseIf CmbDAYNIGHTMARK.SelectedValue = "02" Then
                        SqlStr = "select Dept_Remark from WATCH_RECORD_SHIP where SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) & " and datediff(dd,WATCHSHIPDATE, '" & DTPWATCHDATE.Value & "' and DayNightMark='01' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtDEPT_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    End If
                End If
            End If
        End If
        If Len(Trim(TxtTALLY_CARGO.Text)) = 0 Then
            TALLY_CARGO_his = 0
        Else
            TALLY_CARGO_his = Trim(TxtTALLY_CARGO.Text)
        End If
        If Len(Trim(TxtTALLY_CARGO_TON.Text)) = 0 Then
            TALLY_CARGO_TON_his = 0
        Else
            TALLY_CARGO_TON_his = Trim(TxtTALLY_CARGO_TON.Text)
        End If
        Call FillGetdata()

        '************************派工***********************
        'Call FillDAYNIGHTMARK()
        Dim dsClerk As New DataSet
        Dim dwClerk As New DataView
        Dim row As DataRow

        GL_Str = Me.C1DBG.Columns.Item("CHI_VESSEL").Text
        'BtnCLERK.Enabled = False
        If G_DeptCode = "26.11" Then
            SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0  and DEPT_CODE Like '" & G_DeptCode & "%' and SHIP_ID=" & ID & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dwClerk = Updatedata(sqldaClerk, SqlStr, dsClerk)
        Else
            SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0 and WORK_TYPE='" & CmbWORK_TYPE.SelectedValue & "' and DEPT_CODE ='" & G_DeptCode & "' and SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dwClerk = Updatedata(sqldaClerk, SqlStr, dsClerk)
        End If
        If dwClerk.Count > 0 Then                       '********* 派工，编辑 
            ID = dwClerk(0)(0)
        Else
            If G_DeptCode <> "26.11" Then                '********* 派工，增加
                SqlStr = "select * from TALLY_TEAM"
                dwClerk = Updatedata(sqldaClerk, SqlStr, dsClerk)
                row = dsClerk.Tables(0).NewRow()

                row("SHIP_ID") = CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer)
                row("DEPT_CODE") = G_DeptCode
                row("WORK_DAY") = DTPWATCHDATE.Value
                row("DayNightMark") = CmbDAYNIGHTMARK.SelectedValue
                row("WORK_TYPE") = CmbWORK_TYPE.SelectedValue
                row("User_Name") = Trim(G_User)

                dsClerk.Tables(0).Rows.Add(row)
                sqldaClerk.Update(dsClerk)

                SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0 and WORK_TYPE='" & CmbWORK_TYPE.SelectedValue & "' and DEPT_CODE ='" & G_DeptCode & "' and SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
                dwClerk = Updatedata(sqldaClerk, SqlStr, dsClerk)
                ID = dwClerk(0)(0)
            Else
                MsgBox("业务部无法派工！", MsgBoxStyle.Information, "提示")
                Exit Sub
            End If
        End If

        SqlStr = "select * from TALLY_TEAM where team_id=" & ID & ""
        dw = Updatedata(sqlda, SqlStr, ds)
        If dw.Count > 0 Then
            TxtShip_ID.Text = ds.Tables(0).Rows(0).Item("Ship_ID")
            'TxtCHI_VESSEL.Text = GL_Str

            TxtPERSON.Text = ds.Tables(0).Rows(0).Item("PERSON")
            If IsDBNull(ds.Tables(0).Rows(0).Item("Work_No")) = False Then
                Dim dstmp As New DataSet
                Dim dwtmp As New DataView
                dwtmp = Getdata("SELECT DEPT_CODE, TALLY_TEAM, Code_DUTY FROM TALLY_CLERK where work_no='" & ds.Tables(0).Rows(0).Item("Work_No") & "'", dstmp)
                If dwtmp(0)(0) = G_DeptCode And dwtmp(0)(1) = CmbWORK_TYPE.Text And dwtmp(0)(2) = 21 Then
                    Me.RBbzdb.Checked = True
                ElseIf dwtmp(0)(0) = G_DeptCode And dwtmp(0)(1) <> CmbWORK_TYPE.Text Then
                    Me.RBbzqt.Checked = True
                ElseIf dwtmp(0)(0) <> G_DeptCode Then
                    Me.RBgsqt.Checked = True
                End If
                Call FillWork_No()
                CmbWork_No.SelectedValue = ds.Tables(0).Rows(0).Item("Work_No")
            Else
                RBbzdb.Checked = True
                Call FillWork_No()
            End If
        End If

        RBbzdb1.Checked = True
        Call FillCLERK_NAME()

        '***************初始化C1DBG
        SqlStr = "SELECT * FROM TALLY_CLERK_TEAM WHERE TEAM_ID=" & ID & ""
        dw_sub = Getdata(SqlStr, ds_sub)

        Me.C1DBG2.DataSource = dw_sub
        Me.C1DBG2.Splits(0).DisplayColumns.Item(0).Visible = False
        Me.C1DBG2.Splits(0).DisplayColumns.Item(1).Visible = False
        Me.C1DBG2.Columns.Item(2).Caption = "工号"
        Me.C1DBG2.Columns.Item(3).Caption = "姓名"
        Me.C1DBG2.Splits(0).DisplayColumns.Item(2).Width = 100
        Me.C1DBG2.Splits(0).DisplayColumns.Item(3).Width = 100
        Me.C1DBG2.Refresh()
        Call FillDataGrid()

        BtnADD.Enabled = True
        Button1.Enabled = True
        btnSave.Enabled = True
        If G_Lock = 1 Then
            BtnADD.Enabled = False
            Button1.Enabled = False
            btnSave.Enabled = False
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub FillDataGrid()                      '*******************************已派工情况
        Dim ds_tmp As New DataSet
        Dim dw_tmp As New DataView
        If G_DeptCode = "26.11.11" Then
            SqlStr = "select ABSENT_ID,DEPT_CODE,WORK_NO,Code_HOLIDAY_TYPE,Code_workstat from ABSENT where (DEPT_CODE like '" & G_DeptCode & "%' or DEPT_CODE='29.11.11') and datediff(dd,ABSENTDATE,'" & DTPWATCHDATE.Value & "')=0 and WORK_TYPE='" & CmbWORK_TYPE.Text & "' ORDER BY DEPT_CODE,Code_HOLIDAY_TYPE "
        Else
            SqlStr = "select ABSENT_ID,DEPT_CODE,WORK_NO,Code_HOLIDAY_TYPE,Code_workstat from ABSENT where (DEPT_CODE like '" & G_DeptCode & "%' or DEPT_CODE='29.11.12') and datediff(dd,ABSENTDATE,'" & DTPWATCHDATE.Value & "')=0 and WORK_TYPE='" & CmbWORK_TYPE.Text & "' ORDER BY DEPT_CODE,Code_HOLIDAY_TYPE "
        End If
        dw_tmp = Getdata(SqlStr, ds_tmp)

        If dw_tmp.Count > 0 Then
            '***************定义派工情况表
            Dim i As Integer
            Dim dst As New DataSet
            Dim sqla As New SqlClient.SqlDataAdapter
            Dim sqlc As New SqlClient.SqlCommand

            Me.C1DBG1.DataSource = dw_tmp

            'For i = 0 To Me.C1DBG1.Columns.Count - 1
            '    Me.C1DBG1.Splits(0).DisplayColumns.Item(i).Visible = False
            'Next
            Me.C1DBG1.Splits(0).DisplayColumns.Item("ABSENT_ID").Visible = False
            'Me.C1DBG1.Splits(0).DisplayColumns.Item("WORK_NO").Visible = True
            'Me.C1DBG1.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").Visible = True
            Me.C1DBG1.Columns.Item("dept_code").Caption = "部门"
            Me.C1DBG1.Columns.Item("WORK_NO").Caption = "姓名"
            Me.C1DBG1.Columns.Item("Code_HOLIDAY_TYPE").Caption = "假别"
            Me.C1DBG1.Columns.Item("Code_workstat").Caption = "工作状态"
            Me.C1DBG1.Splits(0).DisplayColumns.Item("dept_code").Width = 30
            Me.C1DBG1.Splits(0).DisplayColumns.Item("WORK_NO").Width = 45
            Me.C1DBG1.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").Width = 45
            Me.C1DBG1.Splits(0).DisplayColumns.Item("Code_workstat").Width = 60
            Me.C1DBG1.Refresh()
            '***************理货部
            Me.C1DBG1.Columns.Item("dept_code").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG1.Columns.Item("dept_code").ValueItems.Translate = True
            Me.C1DBG1.Columns.Item("dept_code").ValueItems.Validate = True
            Me.C1DBG1.Splits(0).DisplayColumns.Item("dept_code").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT DEPT_CODE, DEPT_SHORT FROM DEPARTMENT"
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("DEPT_SHORT"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("DEPT_CODE"))
                Me.C1DBG1.Columns.Item("DEPT_CODE").ValueItems.Values.Add(vi)
            Next
            '***************姓名
            Me.C1DBG1.Columns.Item("WORK_NO").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG1.Columns.Item("WORK_NO").ValueItems.Translate = True
            Me.C1DBG1.Columns.Item("WORK_NO").ValueItems.Validate = True
            Me.C1DBG1.Splits(0).DisplayColumns.Item("WORK_NO").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT NAME, WORK_NO FROM TALLY_CLERK"
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("NAME"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("WORK_NO"))
                Me.C1DBG1.Columns.Item("WORK_NO").ValueItems.Values.Add(vi)
            Next

            '***************假别
            Me.C1DBG1.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG1.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Translate = True
            Me.C1DBG1.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Validate = True
            Me.C1DBG1.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT Code_Holiday_Type,Holiday_Type FROM Code_Holiday_Type order by convert(int,Code_Holiday_Type) "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("Holiday_Type"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("Code_Holiday_Type"))
                Me.C1DBG1.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Values.Add(vi)
            Next

            '***************状态
            Me.C1DBG1.Columns.Item("Code_workstat").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG1.Columns.Item("Code_workstat").ValueItems.Translate = True
            Me.C1DBG1.Columns.Item("Code_workstat").ValueItems.Validate = True
            Me.C1DBG1.Splits(0).DisplayColumns.Item("Code_workstat").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT Code_workstat,workstat FROM Code_workstat" ' order by convert(int,Code_workstat) "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("workstat"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("Code_workstat"))
                Me.C1DBG1.Columns.Item("Code_workstat").ValueItems.Values.Add(vi)
            Next
        End If
    End Sub
    Private Sub FillGetdata()
        Dim dssp As New DataSet
        Dim dvsp As New DataView
        If Len(Trim(TxtPIECE.Text)) = 0 Or IsDBNull(TxtPIECE.Text) = True Then
            PIECE = 0
        Else
            PIECE = Trim(TxtPIECE.Text)
        End If
        If Len(Trim(TxtTONS.Text)) = 0 Or IsDBNull(TxtTONS.Text) = True Then
            TONS = 0
        Else
            TONS = Trim(TxtTONS.Text)
        End If

        If Len(Trim(TxtTALLY_CARGO.Text)) = 0 Or IsDBNull(TxtTALLY_CARGO.Text) = True Then
            TALLY_CARGO = 0
            TxtTALLY_CARGO.Text = 0
        Else
            TALLY_CARGO = Trim(TxtTALLY_CARGO.Text)
        End If
        If Len(Trim(TxtTALLY_CARGO_TON.Text)) = 0 Or IsDBNull(TxtTALLY_CARGO_TON.Text) = True Then
            TALLY_CARGO_TON = 0
            TxtTALLY_CARGO_TON.Text = 0
        Else
            TALLY_CARGO_TON = Trim(TxtTALLY_CARGO_TON.Text)
        End If
        TALLY_CARGO = TALLY_CARGO - TALLY_CARGO_his
        TALLY_CARGO_TON = TALLY_CARGO_TON - TALLY_CARGO_TON_his
        'MsgBox(ID & "','" & CmbDAYNIGHTMARK.SelectedValue & "','" & DTPWATCHDATE.Value & "', '" & TALLY_CARGO & "', '" & TALLY_CARGO_TON & "', '" & PIECE & "', '" & TONS & "'")
        dvsp = Getdata("exec get_date '" & Trim(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString) & "','" & CmbDAYNIGHTMARK.SelectedValue & "','" & DTPWATCHDATE.Value & "', '" & TALLY_CARGO & "', '" & TALLY_CARGO_TON & "', '" & PIECE & "', '" & TONS & "'", dssp)
        If dssp.Tables(0).Rows.Count > 0 Then
            'MsgBox(dssp.Tables(0).Rows(0).Item(0))
            TxtTOTAL_NUM.Text = IIf(dssp.Tables(0).Rows(0).Item(0) < 0, 0, dssp.Tables(0).Rows(0).Item(0))
            TxtTOTAL_NUM_TON.Text = IIf(dssp.Tables(0).Rows(0).Item(1) < 0, 0, dssp.Tables(0).Rows(0).Item(1))
            TxtREMAIN.Text = IIf(dssp.Tables(0).Rows(0).Item(2) < 0, 0, dssp.Tables(0).Rows(0).Item(2))
            TxtREMAIN_TON.Text = IIf(dssp.Tables(0).Rows(0).Item(3) < 0, 0, dssp.Tables(0).Rows(0).Item(3))

        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        SqlStr = "select * from WATCH_RECORD_SHIP where SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Double) & " and datediff(dd,WATCHSHIPDATE ,'" & DTPWATCHDATE.Value & "')=0 and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
        dwtmp = Updatedata(sqldatmp, SqlStr, dstmp)
        Try
            If MsgBox("你确认要删除吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                dstmp.Tables(0).Rows(0).Delete()
                sqlda.Update(dstmp)
                Me.Enabled = False
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        On Error GoTo Err
        SqlStr = "select * from WATCH_RECORD_SHIP where datediff(dd,WATCHSHIPDATE,'" & DTPWATCHDATE.Value & "')=0 and  SHIP_ID=" & CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Double) & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
        dw_sub1 = Updatedata(sqlda_sub1, SqlStr, ds_sub1)
        If dw_sub1.Count > 0 Then
            If Len(Trim(TxtBERTHNO.Text)) > 0 Then
                If CmbCODE_GOODS.SelectedValue <> "00" Then
                    If MsgBox("你确认要保存本单船记录吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then

                        ds_sub1.Tables(0).Rows(0).Item("SHIP_ID") = CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Double)
                        ds_sub1.Tables(0).Rows(0).Item("WATCHSHIPDATE") = DTPWATCHDATE.Value
                        ds_sub1.Tables(0).Rows(0).Item("DAYNIGHTMARK") = CmbDAYNIGHTMARK.SelectedValue
                        If Len(Trim(TxtBERTHNO.Text)) > 0 Then
                            If IsNumeric(Trim(TxtBERTHNO.Text)) Then
                                ds_sub1.Tables(0).Rows(0).Item("BERTHNO") = Trim(TxtBERTHNO.Text)
                            Else
                                MsgBox("泊位号一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                Exit Sub
                            End If
                        End If
                        If CmbCODE_GOODS.Text.Trim().Length() > 0 Then
                            ds_sub1.Tables(0).Rows(0).Item("CODE_GOODS") = CmbCODE_GOODS.SelectedValue
                        Else
                            MsgBox("货类一栏应选择数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                        If Len(Trim(TxtTICKET.Text)) > 0 Then
                            If IsNumeric(Trim(TxtTICKET.Text)) Then
                                ds_sub1.Tables(0).Rows(0).Item("TICKET") = Trim(TxtTICKET.Text)
                            Else
                                MsgBox("票数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                Exit Sub
                            End If
                        End If
                        ds_sub1.Tables(0).Rows(0).Item("LOAD_UNLOAD_PORT") = CmbLOAD_UNLOAD_PORT.SelectedValue
                        ds_sub1.Tables(0).Rows(0).Item("INOUTPORT") = CmbINOUTPORT.SelectedValue
                        ds_sub1.Tables(0).Rows(0).Item("NATIONALITY_CODE") = CmbNATIONALITY_CODE.SelectedValue
                        If Len(Trim(TxtPIECE.Text)) > 0 Then
                            If IsNumeric(Trim(TxtPIECE.Text)) Then
                                ds_sub1.Tables(0).Rows(0).Item("PIECE") = Trim(TxtPIECE.Text)
                            Else
                                MsgBox("原载件数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                Exit Sub
                            End If
                        End If
                        If Len(Trim(TxtTONS.Text)) > 0 Then
                            If IsNumeric(Trim(TxtTONS.Text)) Then
                                ds_sub1.Tables(0).Rows(0).Item("TONS") = Trim(TxtTONS.Text)
                            Else
                                MsgBox("原载吨数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                Exit Sub
                            End If
                        End If
                        If Len(Trim(TxtTALLY_CARGO.Text)) > 0 Then
                            If IsNumeric(Trim(TxtTALLY_CARGO.Text)) Then
                                ds_sub1.Tables(0).Rows(0).Item("TALLY_CARGO") = Trim(TxtTALLY_CARGO.Text)
                            Else
                                MsgBox("本班理货件数应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                Exit Sub
                            End If
                        End If
                        If Len(Trim(TxtTALLY_CARGO_TON.Text)) > 0 Then
                            If IsNumeric(Trim(TxtTALLY_CARGO_TON.Text)) Then
                                ds_sub1.Tables(0).Rows(0).Item("TALLY_CARGO_TON") = Trim(TxtTALLY_CARGO_TON.Text)
                            Else
                                MsgBox("本班理货吨数应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                Exit Sub
                            End If
                        End If
                        If Len(Trim(TxtTOTAL_NUM.Text)) > 0 Then
                            If IsNumeric(Trim(TxtTOTAL_NUM.Text)) Then
                                ds_sub1.Tables(0).Rows(0).Item("TOTAL_NUM") = Trim(TxtTOTAL_NUM.Text)
                            Else
                                MsgBox("累计件数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                Exit Sub
                            End If
                        End If
                        If Len(Trim(TxtTOTAL_NUM_TON.Text)) > 0 Then
                            If IsNumeric(Trim(TxtTOTAL_NUM_TON.Text)) Then
                                ds_sub1.Tables(0).Rows(0).Item("TOTAL_NUM_TON") = Trim(TxtTOTAL_NUM_TON.Text)
                            Else
                                MsgBox("累计吨数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                Exit Sub
                            End If
                        End If
                        If Len(Trim(TxtREMAIN.Text)) > 0 Then
                            If IsNumeric(Trim(TxtREMAIN.Text)) Then
                                ds_sub1.Tables(0).Rows(0).Item("REMAIN") = Trim(TxtREMAIN.Text)
                            Else
                                MsgBox("余数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                Exit Sub
                            End If
                        End If
                        If Len(Trim(TxtREMAIN_TON.Text)) > 0 Then
                            If IsNumeric(Trim(TxtREMAIN_TON.Text)) Then
                                ds_sub1.Tables(0).Rows(0).Item("REMAIN_TON") = Trim(TxtREMAIN_TON.Text)
                            Else
                                MsgBox("余数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                Exit Sub
                            End If
                        End If
                        ds_sub1.Tables(0).Rows(0).Item("MARK_COMPLETE") = CmbMARK_COMPLETE.SelectedValue
                        ds_sub1.Tables(0).Rows(0).Item("User_Name") = Trim(G_User)
                        If G_DeptCode = "26.11" Then
                            ds_sub1.Tables(0).Rows(0).Item("Company_REMARK") = TxtCOMPANY_REMARK.Text
                        ElseIf G_DeptCode Like "26.11.*" Then
                            ds_sub1.Tables(0).Rows(0).Item("Dept_Remark") = TxtDEPT_REMARK.Text
                        End If
                        sqlda_sub1.Update(ds_sub1)
                        If Len(Trim(TxtTALLY_CARGO.Text)) = 0 Then
                            TALLY_CARGO_his = 0
                        Else
                            TALLY_CARGO_his = Trim(TxtTALLY_CARGO.Text)
                        End If
                        If Len(Trim(TxtTALLY_CARGO_TON.Text)) = 0 Then
                            TALLY_CARGO_TON_his = 0
                        Else
                            TALLY_CARGO_TON_his = Trim(TxtTALLY_CARGO_TON.Text)
                        End If
                        'btSave.Enabled = False
                        'Call btAdd_Click(sender, e)
                    End If
                Else
                    MsgBox("货类不能为空！")
                End If
            Else
                MsgBox("泊位号不能为空！")
            End If
        Else
            SqlStr = "select * from WATCH_RECORD_SHIP where 1>2"
            dw_sub1 = Updatedata(sqlda_sub1, SqlStr, ds_sub1)
            If Len(Trim(TxtBERTHNO.Text)) > 0 Then
                If CmbCODE_GOODS.SelectedValue <> "00" Then
                    If MsgBox("你确认要保存本单船记录吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                        Dim row As DataRow
                        row = ds_sub1.Tables(0).NewRow()
                        row("SHIP_ID") = CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Double)
                        row("WATCHSHIPDATE") = DTPWATCHDATE.Value
                        row("DAYNIGHTMARK") = CmbDAYNIGHTMARK.SelectedValue
                        row("BERTHNO") = Trim(TxtBERTHNO.Text)
                        If CmbCODE_GOODS.Text.Trim().Length() > 0 Then
                            row("CODE_GOODS") = CmbCODE_GOODS.SelectedValue
                        Else
                            MsgBox("货类一栏应选择数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If

                        If Len(Trim(TxtTICKET.Text)) > 0 Then
                            row("TICKET") = Trim(TxtTICKET.Text)
                        End If
                        row("LOAD_UNLOAD_PORT") = CmbLOAD_UNLOAD_PORT.SelectedValue
                        row("INOUTPORT") = CmbINOUTPORT.SelectedValue
                        row("NATIONALITY_CODE") = CmbNATIONALITY_CODE.SelectedValue
                        If Len(Trim(TxtPIECE.Text)) > 0 Then
                            row("PIECE") = Trim(TxtPIECE.Text)
                        End If
                        If Len(Trim(TxtTONS.Text)) > 0 Then
                            row("TONS") = Trim(TxtTONS.Text)
                        End If
                        If Len(Trim(TxtTALLY_CARGO.Text)) > 0 Then
                            row("TALLY_CARGO") = Trim(TxtTALLY_CARGO.Text)
                        End If
                        If Len(Trim(TxtTALLY_CARGO_TON.Text)) > 0 Then
                            row("TALLY_CARGO_TON") = Trim(TxtTALLY_CARGO_TON.Text)
                        End If
                        If Len(Trim(TxtTOTAL_NUM.Text)) > 0 Then
                            row("TOTAL_NUM") = Trim(TxtTOTAL_NUM.Text)
                        End If
                        If Len(Trim(TxtTOTAL_NUM_TON.Text)) > 0 Then
                            row("TOTAL_NUM_TON") = Trim(TxtTOTAL_NUM_TON.Text)
                        End If
                        If Len(Trim(TxtREMAIN.Text)) > 0 Then
                            row("REMAIN") = Trim(TxtREMAIN.Text)
                        End If
                        If Len(Trim(TxtREMAIN_TON.Text)) > 0 Then
                            row("REMAIN_TON") = Trim(TxtREMAIN_TON.Text)
                        End If
                        row("MARK_COMPLETE") = CmbMARK_COMPLETE.SelectedValue
                        row("User_Name") = Trim(G_User)
                        If G_DeptCode = "26.11" Then
                            row("Company_REMARK") = TxtCOMPANY_REMARK.Text
                        ElseIf G_DeptCode Like "26.11.*" Then
                            row("Dept_Remark") = TxtDEPT_REMARK.Text
                        End If
                        ds_sub1.Tables(0).Rows.Add(row)
                        sqlda_sub1.Update(ds_sub1)
                        If Len(Trim(TxtTALLY_CARGO.Text)) = 0 Then
                            TALLY_CARGO_his = 0
                        Else
                            TALLY_CARGO_his = Trim(TxtTALLY_CARGO.Text)
                        End If
                        If Len(Trim(TxtTALLY_CARGO_TON.Text)) = 0 Then
                            TALLY_CARGO_TON_his = 0
                        Else
                            TALLY_CARGO_TON_his = Trim(TxtTALLY_CARGO_TON.Text)
                        End If
                        'Call btAdd_Click(sender, e)
                    End If
                Else
                    MsgBox("货名代码不能为空！")
                End If
            Else
                MsgBox("泊位号不能为空！")
            End If
        End If
        Exit Sub
Err:
        MsgBox(Err.Description)
        'Resume
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        On Error GoTo Err
        'Call btSave_Click(sender, e)
        If Len(Trim(TxtPERSON.Text)) = 0 Then
            MsgBox("请输入人数！")
            Exit Sub
        End If
        'If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
        Call OperateHistory(G_DeptName, Now, G_User, "修改", "TALLY_TEAM", ID, "team_id")

        ds.Tables(0).Rows(0).Item("Work_No") = CmbWork_No.SelectedValue
        If Len(Trim(TxtPERSON.Text)) > 0 Then
            If IsNumeric(Trim(TxtPERSON.Text)) Then
                ds.Tables(0).Rows(0).Item("PERSON") = Trim(TxtPERSON.Text)
            Else
                MsgBox("人数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                Exit Sub
            End If
        End If
        ds.Tables(0).Rows(0).Item("USER_NAME") = G_User
        sqlda.Update(ds)

        SqlStr = "update absent set Code_workstat='01' from absent where dept_code='" & G_DeptCode & "'and Work_No='" & CmbWork_No.SelectedValue & "' and datediff(dd,absentDate,'" & DTPWATCHDATE.Value & "')=0 and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "' and Work_Type='" & CmbWORK_TYPE.Text & "'"
        ExecSql(SqlStr)

        GL_Str = 1
        'Call btnQuit_Click(sender, e)
        'Else
        'GL_Str = 0
        'End If
        MsgBox("派工已保存！")
        Exit Sub
Err:
        Resume
    End Sub
    Private Sub FillWORK_TYPE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "SELECT WORK_TYPE FROM WORK_BEGIN WHERE DEPT_CODE='" & G_DeptCode & "' ORDER BY TIME_FROM, DayNightMark"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbWORK_TYPE.DataSource = dvc
        Me.CmbWORK_TYPE.DisplayMember = "WORK_TYPE"
        Me.CmbWORK_TYPE.ValueMember = "WORK_TYPE"
    End Sub

    Private Sub FillDAYNIGHTMARK()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "SELECT Code_WorkTime,WorkTime FROM Code_WorkTime"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDAYNIGHTMARK.DataSource = dvc
        Me.CmbDAYNIGHTMARK.DisplayMember = "WorkTime"
        Me.CmbDAYNIGHTMARK.ValueMember = "Code_WorkTime"
    End Sub

    Private Sub FillWork_No()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        If G_DeptCode = "26.11.11" Then
            If Me.RBbzdb.Checked = True Then
                sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE (Code_DUTY ='21' or Code_DUTY ='20') and (DEPT_CODE='" & G_DeptCode & "' or DEPT_CODE='29.11.11') and TALLY_TEAM='" & CmbWORK_TYPE.Text & "' order by NAME "
            End If

            If Me.RBbzqt.Checked = True Then
                sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE (DEPT_CODE='" & G_DeptCode & "' or DEPT_CODE='29.11.11') and TALLY_TEAM!='" & CmbWORK_TYPE.Text & "' order by NAME "
            End If

            If Me.RBgsqt.Checked = True Then
                sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE!='" & G_DeptCode & "' and DEPT_CODE!='26.01' and DEPT_CODE!='26.94' and DEPT_CODE!='26.96' and DEPT_CODE!='26.98' and DEPT_CODE!='26.99' and DEPT_CODE!='27' and DEPT_CODE!='28' and  DEPT_CODE!='29.11.11' order by NAME"
            End If
        Else
            If Me.RBbzdb.Checked = True Then
                sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE  (Code_DUTY ='21' or Code_DUTY ='20')  and (DEPT_CODE='" & G_DeptCode & "' or DEPT_CODE='29.11.12') and TALLY_TEAM='" & CmbWORK_TYPE.Text & "' order by NAME "
            End If

            If Me.RBbzqt.Checked = True Then
                sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE (DEPT_CODE='" & G_DeptCode & "' or DEPT_CODE='29.11.12') and TALLY_TEAM!='" & CmbWORK_TYPE.Text & "' order by NAME "
            End If

            If Me.RBgsqt.Checked = True Then
                sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE!='" & G_DeptCode & "' and DEPT_CODE!='26.01' and DEPT_CODE!='26.94' and DEPT_CODE!='26.96' and DEPT_CODE!='26.98' and DEPT_CODE!='26.99' and DEPT_CODE!='27' and DEPT_CODE!='28' and  DEPT_CODE!='29.11.12' order by NAME"
            End If
        End If
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbWork_No.DataSource = dvc
        Me.CmbWork_No.DisplayMember = "NAME"
        Me.CmbWork_No.ValueMember = "WORK_NO"
    End Sub
    Private Sub FillCLERK_NAME()
        Dim sqldc As String
        Dim dsc As New DataSet
        Dim dvc As DataView
        If G_DeptCode = "26.11.11" Then
            If Me.RBbzdb1.Checked = True Then
                sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE (DEPT_CODE='" & G_DeptCode & "' or DEPT_CODE='29.11.11' ) and TALLY_TEAM='" & CmbWORK_TYPE.Text & "' "
            End If

            If Me.RBbzqt1.Checked = True Then
                sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE (DEPT_CODE='" & G_DeptCode & "' or DEPT_CODE='29.11.11' ) and TALLY_TEAM!='" & CmbWORK_TYPE.Text & "' "
            End If

            If Me.RBgsqt1.Checked = True Then
                sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE!='" & G_DeptCode & "' and DEPT_CODE!='26.01' and DEPT_CODE!='26.94' and DEPT_CODE!='26.96' and DEPT_CODE!='26.98' and DEPT_CODE!='26.99' and DEPT_CODE!='27' and DEPT_CODE!='28' and DEPT_CODE!='29.11.11' order by NAME"
            End If
        Else
            If Me.RBbzdb1.Checked = True Then
                sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE (DEPT_CODE='" & G_DeptCode & "'  or DEPT_CODE='29.11.12') and TALLY_TEAM='" & CmbWORK_TYPE.Text & "' "
            End If

            If Me.RBbzqt1.Checked = True Then
                sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE (DEPT_CODE='" & G_DeptCode & "'  or DEPT_CODE='29.11.12') and TALLY_TEAM!='" & CmbWORK_TYPE.Text & "' "
            End If

            If Me.RBgsqt1.Checked = True Then
                sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE!='" & G_DeptCode & "' and DEPT_CODE!='26.01' and DEPT_CODE!='26.94' and DEPT_CODE!='26.96' and DEPT_CODE!='26.98' and DEPT_CODE!='26.99' and DEPT_CODE!='27' and DEPT_CODE!='28' and DEPT_CODE!='29.11.12' order by NAME"
            End If
        End If
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbCLERK_NAME.DataSource = dvc
        Me.CmbCLERK_NAME.DisplayMember = "NAME"
        Me.CmbCLERK_NAME.ValueMember = "WORK_NO"
    End Sub
    Private Sub RBbzdb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBbzdb.CheckedChanged
        Call FillWork_No()
    End Sub

    Private Sub RBbzqt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBbzqt.CheckedChanged
        Call FillWork_No()
    End Sub

    Private Sub RBgsqt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBgsqt.CheckedChanged
        Call FillWork_No()
    End Sub

    Private Sub RBbzdb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBbzdb1.CheckedChanged
        Call FillCLERK_NAME()
    End Sub

    Private Sub RBbzqt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBbzqt1.CheckedChanged
        Call FillCLERK_NAME()
    End Sub

    Private Sub RBgsqt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBgsqt1.CheckedChanged
        Call FillCLERK_NAME()
    End Sub


    Private Sub BtnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnADD.Click
        SqlStr = "Insert into Tally_Clerk_Team (TEAM_ID,WORK_NO,Name) Values(" & ID & ",'" & Trim(Me.CmbCLERK_NAME.SelectedValue) & "','" & Trim(Me.CmbCLERK_NAME.Text) & "')"
        ExecSql(SqlStr)
        If G_DeptCode = "26.11.11" Then
            SqlStr = "update absent set Code_workstat='01' from absent where (dept_code='" & G_DeptCode & "' or dept_code='29.11.11') and Work_No='" & Trim(Me.CmbCLERK_NAME.SelectedValue) & "' and datediff(dd,absentDate,'" & DTPWATCHDATE.Value & "')=0 and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "' and Work_Type='" & CmbWORK_TYPE.Text & "'"
        Else
            SqlStr = "update absent set Code_workstat='01' from absent where (dept_code='" & G_DeptCode & "' or dept_code='29.11.12') and Work_No='" & Trim(Me.CmbCLERK_NAME.SelectedValue) & "' and datediff(dd,absentDate,'" & DTPWATCHDATE.Value & "')=0 and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "' and Work_Type='" & CmbWORK_TYPE.Text & "'"
        End If
        ExecSql(SqlStr)
        SqlStr = "SELECT * FROM TALLY_CLERK_TEAM WHERE TEAM_ID=" & ID & ""
        dw_sub = Getdata(SqlStr, ds_sub)

        Me.C1DBG2.DataSource = dw_sub
        Me.C1DBG2.Splits(0).DisplayColumns.Item(0).Visible = False
        Me.C1DBG2.Splits(0).DisplayColumns.Item(1).Visible = False
        Me.C1DBG2.Columns.Item(2).Caption = "工号"
        Me.C1DBG2.Columns.Item(3).Caption = "姓名"
        Me.C1DBG2.Splits(0).DisplayColumns.Item(2).Width = 100
        Me.C1DBG2.Splits(0).DisplayColumns.Item(3).Width = 100
        Me.C1DBG2.Refresh()

        Call FillDataGrid()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        SqlStr = "delete from Tally_Clerk_Team where Team_ID=" & ID & " and Work_No='" & Trim(Me.C1DBG2.Columns.Item("Work_No").Text) & "'"
        ExecSql(SqlStr)
        SqlStr = "update absent set Code_workstat='02' from absent where dept_code='" & G_DeptCode & "'and Work_No='" & Trim(Me.CmbCLERK_NAME.SelectedValue) & "' and datediff(dd,absentDate,'" & DTPWATCHDATE.Value & "')=0 and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "' and Work_Type='" & CmbWORK_TYPE.Text & "'"
        ExecSql(SqlStr)
        SqlStr = "SELECT * FROM TALLY_CLERK_TEAM WHERE TEAM_ID=" & ID & ""
        dw_sub = Getdata(SqlStr, ds_sub)

        Me.C1DBG2.DataSource = dw_sub
        Me.C1DBG2.Splits(0).DisplayColumns.Item(0).Visible = False
        Me.C1DBG2.Splits(0).DisplayColumns.Item(1).Visible = False
        Me.C1DBG2.Columns.Item(2).Caption = "工号"
        Me.C1DBG2.Columns.Item(3).Caption = "姓名"
        Me.C1DBG2.Splits(0).DisplayColumns.Item(2).Width = 100
        Me.C1DBG2.Splits(0).DisplayColumns.Item(3).Width = 100
        Me.C1DBG2.Refresh()

        Call FillDataGrid()
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
    Private Sub TxtTALLY_CARGO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTALLY_CARGO.Leave
        Call FillGetdata()
    End Sub

    Private Sub TxtTALLY_CARGO_TON_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTALLY_CARGO_TON.Leave
        Call FillGetdata()
    End Sub
    Private Sub CombLOAD_PORT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbLOAD_UNLOAD_PORT.Leave
        Dim DSSELECT As New DataSet
        Try
            If Len(Trim(CmbLOAD_UNLOAD_PORT.Text)) > 0 Then
                'dw = Getdata("SELECT * FROM CODE_port WHERE code_port='" & Trim(CmbLOAD_UNLOAD_PORT.Text) & "'", DSSELECT)
                dw = Getdata("SELECT * FROM CODE_port WHERE code_port like '%" & Trim(CmbLOAD_UNLOAD_PORT.Text) & "%' or port_cha like '%" & Trim(CmbLOAD_UNLOAD_PORT.Text) & "%' or port_eng like '%" & Trim(CmbLOAD_UNLOAD_PORT.Text) & "%'", DSSELECT)
                If DSSELECT.Tables(0).Rows.Count > 0 Then
                    CmbLOAD_UNLOAD_PORT.SelectedValue = DSSELECT.Tables(0).Rows(0).Item("code_port")
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CmbNATIONALITY_CODE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbNATIONALITY_CODE.Leave
        Dim DSSELECT As New DataSet
        Try
            If Len(Trim(CmbNATIONALITY_CODE.Text)) > 0 Then
                dw = Getdata("SELECT * FROM CODE_NATIONALITY WHERE NATIONALITY_CHA like '%" & Trim(CmbNATIONALITY_CODE.Text) & "%' or NATIONALITY_ENG like '%" & Trim(CmbNATIONALITY_CODE.Text) & "%' or NATIONALITY_English like '%" & Trim(CmbNATIONALITY_CODE.Text) & "%'", DSSELECT)
                If DSSELECT.Tables(0).Rows.Count > 0 Then
                    CmbNATIONALITY_CODE.SelectedValue = DSSELECT.Tables(0).Rows(0).Item("NATIONALITY_ENG")
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TxtBERTHNO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBERTHNO.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbINOUTPORT.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbINOUTPORT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbINOUTPORT.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTICKET.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTICKET_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTICKET.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbLOAD_UNLOAD_PORT.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbLOAD_UNLOAD_PORT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbLOAD_UNLOAD_PORT.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbNATIONALITY_CODE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbNATIONALITY_CODE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbNATIONALITY_CODE.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbCODE_GOODS.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbCODE_GOODS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCODE_GOODS.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPIECE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtPIECE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPIECE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTONS.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTONS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTONS.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTALLY_CARGO.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTALLY_CARGO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTALLY_CARGO.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTALLY_CARGO_TON.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTALLY_CARGO_TON_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTALLY_CARGO_TON.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTOTAL_NUM.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTOTAL_NUM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTOTAL_NUM.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTOTAL_NUM_TON.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTOTAL_NUM_TON_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTOTAL_NUM_TON.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtREMAIN.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtREMAIN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtREMAIN.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtREMAIN_TON.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtREMAIN_TON_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtREMAIN_TON.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbMARK_COMPLETE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbMARK_COMPLETE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbMARK_COMPLETE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDEPT_REMARK.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
