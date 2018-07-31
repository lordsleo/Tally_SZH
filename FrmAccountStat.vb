Imports Tally.DBControl
Public Class FrmAccountStat
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler dtpBegin.KeyDown, AddressOf FrmAccountStat_KeyDown
        AddHandler dtpEnd.KeyDown, AddressOf FrmAccountStat_KeyDown
        AddHandler txtBeginNo.KeyDown, AddressOf FrmAccountStat_KeyDown
        AddHandler txtEndNo.KeyDown, AddressOf FrmAccountStat_KeyDown


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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnFeeVoyageCargo As System.Windows.Forms.Button
    Friend WithEvents btnFeeVoyageCon As System.Windows.Forms.Button
    Friend WithEvents dtpBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnExportEdit As System.Windows.Forms.Button
    Friend WithEvents btnExportSave As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnSortdefault As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbDept As System.Windows.Forms.ComboBox
    Friend WithEvents btnFeeDeptAgentCargo As System.Windows.Forms.Button
    Friend WithEvents btnFeeDeptAgentCon As System.Windows.Forms.Button
    Friend WithEvents btnFeeAgent As System.Windows.Forms.Button
    Friend WithEvents btnFeeAgentEdi As System.Windows.Forms.Button
    Friend WithEvents btnFeeProduce As System.Windows.Forms.Button
    Friend WithEvents gbDeptCargo As System.Windows.Forms.GroupBox
    Friend WithEvents gbDeptCon As System.Windows.Forms.GroupBox
    Friend WithEvents gbFeeStat As System.Windows.Forms.GroupBox
    Friend WithEvents btnStatConVoyage As System.Windows.Forms.Button
    Friend WithEvents btnStatConRentVoyage As System.Windows.Forms.Button
    Friend WithEvents btnStatConRentAgent As System.Windows.Forms.Button
    Friend WithEvents tbpTime As System.Windows.Forms.TabPage
    Friend WithEvents tbpFileNo As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBeginNo As System.Windows.Forms.TextBox
    Friend WithEvents txtEndNo As System.Windows.Forms.TextBox
    Friend WithEvents tbcStatTerm As System.Windows.Forms.TabControl
    Friend WithEvents btnStatCargoVoyage As System.Windows.Forms.Button
    Friend WithEvents btnStatCargoGoods As System.Windows.Forms.Button
    Friend WithEvents btnStatCargoClass As System.Windows.Forms.Button
    Friend WithEvents btnStatCargoVoyGoods As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAccountStat))
        Me.dtpBegin = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnFeeVoyageCargo = New System.Windows.Forms.Button
        Me.btnFeeVoyageCon = New System.Windows.Forms.Button
        Me.btnExportEdit = New System.Windows.Forms.Button
        Me.btnExportSave = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnQuit = New System.Windows.Forms.Button
        Me.btnSortdefault = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbDept = New System.Windows.Forms.ComboBox
        Me.btnFeeDeptAgentCargo = New System.Windows.Forms.Button
        Me.btnFeeDeptAgentCon = New System.Windows.Forms.Button
        Me.btnFeeAgent = New System.Windows.Forms.Button
        Me.btnFeeAgentEdi = New System.Windows.Forms.Button
        Me.btnFeeProduce = New System.Windows.Forms.Button
        Me.btnStatConRentVoyage = New System.Windows.Forms.Button
        Me.btnStatConVoyage = New System.Windows.Forms.Button
        Me.gbDeptCargo = New System.Windows.Forms.GroupBox
        Me.btnStatCargoVoyGoods = New System.Windows.Forms.Button
        Me.btnStatCargoGoods = New System.Windows.Forms.Button
        Me.btnStatCargoClass = New System.Windows.Forms.Button
        Me.btnStatCargoVoyage = New System.Windows.Forms.Button
        Me.btnStatConRentAgent = New System.Windows.Forms.Button
        Me.gbDeptCon = New System.Windows.Forms.GroupBox
        Me.gbFeeStat = New System.Windows.Forms.GroupBox
        Me.tbcStatTerm = New System.Windows.Forms.TabControl
        Me.tbpTime = New System.Windows.Forms.TabPage
        Me.tbpFileNo = New System.Windows.Forms.TabPage
        Me.txtEndNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBeginNo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDeptCargo.SuspendLayout()
        Me.gbFeeStat.SuspendLayout()
        Me.tbcStatTerm.SuspendLayout()
        Me.tbpTime.SuspendLayout()
        Me.tbpFileNo.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpBegin
        '
        Me.dtpBegin.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBegin.Location = New System.Drawing.Point(68, 4)
        Me.dtpBegin.Name = "dtpBegin"
        Me.dtpBegin.Size = New System.Drawing.Size(120, 21)
        Me.dtpBegin.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "开始时间"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(204, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "结束时间"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpEnd
        '
        Me.dtpEnd.Checked = False
        Me.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(260, 4)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(120, 21)
        Me.dtpEnd.TabIndex = 2
        '
        'C1DBG
        '
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(8, 64)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(891, 476)
        Me.C1DBG.TabIndex = 5
        Me.C1DBG.Text = "C1TrueDBGrid1"
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'btnFeeVoyageCargo
        '
        Me.btnFeeVoyageCargo.Location = New System.Drawing.Point(8, 16)
        Me.btnFeeVoyageCargo.Name = "btnFeeVoyageCargo"
        Me.btnFeeVoyageCargo.Size = New System.Drawing.Size(100, 22)
        Me.btnFeeVoyageCargo.TabIndex = 6
        Me.btnFeeVoyageCargo.Text = "分船次杂货费"
        '
        'btnFeeVoyageCon
        '
        Me.btnFeeVoyageCon.Location = New System.Drawing.Point(112, 16)
        Me.btnFeeVoyageCon.Name = "btnFeeVoyageCon"
        Me.btnFeeVoyageCon.Size = New System.Drawing.Size(100, 22)
        Me.btnFeeVoyageCon.TabIndex = 7
        Me.btnFeeVoyageCon.Text = "分船次集装箱费"
        '
        'btnExportEdit
        '
        Me.btnExportEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExportEdit.Location = New System.Drawing.Point(319, 548)
        Me.btnExportEdit.Name = "btnExportEdit"
        Me.btnExportEdit.Size = New System.Drawing.Size(72, 22)
        Me.btnExportEdit.TabIndex = 8
        Me.btnExportEdit.Text = "导出编辑"
        '
        'btnExportSave
        '
        Me.btnExportSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExportSave.Location = New System.Drawing.Point(399, 548)
        Me.btnExportSave.Name = "btnExportSave"
        Me.btnExportSave.Size = New System.Drawing.Size(72, 22)
        Me.btnExportSave.TabIndex = 9
        Me.btnExportSave.Text = "导出保存"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPrint.Location = New System.Drawing.Point(479, 548)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(72, 22)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "打印"
        Me.btnPrint.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Location = New System.Drawing.Point(567, 548)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(72, 22)
        Me.btnQuit.TabIndex = 11
        Me.btnQuit.Text = "退出"
        '
        'btnSortdefault
        '
        Me.btnSortdefault.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSortdefault.Location = New System.Drawing.Point(19, 548)
        Me.btnSortdefault.Name = "btnSortdefault"
        Me.btnSortdefault.Size = New System.Drawing.Size(72, 22)
        Me.btnSortdefault.TabIndex = 12
        Me.btnSortdefault.Text = "默认排序"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(-148, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "理货部门选择"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbDept
        '
        Me.cbDept.Location = New System.Drawing.Point(-140, 88)
        Me.cbDept.Name = "cbDept"
        Me.cbDept.Size = New System.Drawing.Size(121, 20)
        Me.cbDept.TabIndex = 14
        '
        'btnFeeDeptAgentCargo
        '
        Me.btnFeeDeptAgentCargo.Location = New System.Drawing.Point(8, 12)
        Me.btnFeeDeptAgentCargo.Name = "btnFeeDeptAgentCargo"
        Me.btnFeeDeptAgentCargo.Size = New System.Drawing.Size(88, 22)
        Me.btnFeeDeptAgentCargo.TabIndex = 15
        Me.btnFeeDeptAgentCargo.Text = "分船代杂货费"
        '
        'btnFeeDeptAgentCon
        '
        Me.btnFeeDeptAgentCon.Location = New System.Drawing.Point(1470, 24)
        Me.btnFeeDeptAgentCon.Name = "btnFeeDeptAgentCon"
        Me.btnFeeDeptAgentCon.Size = New System.Drawing.Size(100, 22)
        Me.btnFeeDeptAgentCon.TabIndex = 16
        Me.btnFeeDeptAgentCon.Text = "分船代集装箱费"
        '
        'btnFeeAgent
        '
        Me.btnFeeAgent.Location = New System.Drawing.Point(216, 16)
        Me.btnFeeAgent.Name = "btnFeeAgent"
        Me.btnFeeAgent.Size = New System.Drawing.Size(100, 22)
        Me.btnFeeAgent.TabIndex = 17
        Me.btnFeeAgent.Text = "分船代费"
        '
        'btnFeeAgentEdi
        '
        Me.btnFeeAgentEdi.Location = New System.Drawing.Point(424, 16)
        Me.btnFeeAgentEdi.Name = "btnFeeAgentEdi"
        Me.btnFeeAgentEdi.Size = New System.Drawing.Size(100, 22)
        Me.btnFeeAgentEdi.TabIndex = 18
        Me.btnFeeAgentEdi.Text = "分船代EDI费"
        '
        'btnFeeProduce
        '
        Me.btnFeeProduce.Location = New System.Drawing.Point(320, 16)
        Me.btnFeeProduce.Name = "btnFeeProduce"
        Me.btnFeeProduce.Size = New System.Drawing.Size(100, 22)
        Me.btnFeeProduce.TabIndex = 19
        Me.btnFeeProduce.Text = "生产情况统计"
        '
        'btnStatConRentVoyage
        '
        Me.btnStatConRentVoyage.Location = New System.Drawing.Point(1582, 24)
        Me.btnStatConRentVoyage.Name = "btnStatConRentVoyage"
        Me.btnStatConRentVoyage.Size = New System.Drawing.Size(100, 22)
        Me.btnStatConRentVoyage.TabIndex = 21
        Me.btnStatConRentVoyage.Text = "租箱船舶统计"
        '
        'btnStatConVoyage
        '
        Me.btnStatConVoyage.Location = New System.Drawing.Point(1496, 24)
        Me.btnStatConVoyage.Name = "btnStatConVoyage"
        Me.btnStatConVoyage.Size = New System.Drawing.Size(100, 22)
        Me.btnStatConVoyage.TabIndex = 20
        Me.btnStatConVoyage.Text = "集装箱船舶统计"
        '
        'gbDeptCargo
        '
        Me.gbDeptCargo.Controls.Add(Me.btnStatCargoVoyGoods)
        Me.gbDeptCargo.Controls.Add(Me.btnStatCargoGoods)
        Me.gbDeptCargo.Controls.Add(Me.btnStatCargoClass)
        Me.gbDeptCargo.Controls.Add(Me.btnStatCargoVoyage)
        Me.gbDeptCargo.Controls.Add(Me.btnFeeDeptAgentCargo)
        Me.gbDeptCargo.Location = New System.Drawing.Point(432, 12)
        Me.gbDeptCargo.Name = "gbDeptCargo"
        Me.gbDeptCargo.Size = New System.Drawing.Size(456, 40)
        Me.gbDeptCargo.TabIndex = 22
        Me.gbDeptCargo.TabStop = False
        '
        'btnStatCargoVoyGoods
        '
        Me.btnStatCargoVoyGoods.Location = New System.Drawing.Point(184, 12)
        Me.btnStatCargoVoyGoods.Name = "btnStatCargoVoyGoods"
        Me.btnStatCargoVoyGoods.Size = New System.Drawing.Size(88, 22)
        Me.btnStatCargoVoyGoods.TabIndex = 19
        Me.btnStatCargoVoyGoods.Text = "杂货船货统计"
        '
        'btnStatCargoGoods
        '
        Me.btnStatCargoGoods.Location = New System.Drawing.Point(360, 12)
        Me.btnStatCargoGoods.Name = "btnStatCargoGoods"
        Me.btnStatCargoGoods.Size = New System.Drawing.Size(88, 22)
        Me.btnStatCargoGoods.TabIndex = 18
        Me.btnStatCargoGoods.Text = "杂货货种统计"
        '
        'btnStatCargoClass
        '
        Me.btnStatCargoClass.Location = New System.Drawing.Point(96, 12)
        Me.btnStatCargoClass.Name = "btnStatCargoClass"
        Me.btnStatCargoClass.Size = New System.Drawing.Size(88, 22)
        Me.btnStatCargoClass.TabIndex = 17
        Me.btnStatCargoClass.Text = "杂货货类统计"
        '
        'btnStatCargoVoyage
        '
        Me.btnStatCargoVoyage.Location = New System.Drawing.Point(272, 12)
        Me.btnStatCargoVoyage.Name = "btnStatCargoVoyage"
        Me.btnStatCargoVoyage.Size = New System.Drawing.Size(88, 22)
        Me.btnStatCargoVoyage.TabIndex = 16
        Me.btnStatCargoVoyage.Text = "杂货船舶统计"
        '
        'btnStatConRentAgent
        '
        Me.btnStatConRentAgent.Location = New System.Drawing.Point(1607, 24)
        Me.btnStatConRentAgent.Name = "btnStatConRentAgent"
        Me.btnStatConRentAgent.Size = New System.Drawing.Size(100, 22)
        Me.btnStatConRentAgent.TabIndex = 22
        Me.btnStatConRentAgent.Text = "租箱船代统计"
        '
        'gbDeptCon
        '
        Me.gbDeptCon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDeptCon.Location = New System.Drawing.Point(1362, 20)
        Me.gbDeptCon.Name = "gbDeptCon"
        Me.gbDeptCon.Size = New System.Drawing.Size(0, 80)
        Me.gbDeptCon.TabIndex = 23
        Me.gbDeptCon.TabStop = False
        Me.gbDeptCon.Text = "理货部集装箱统计"
        '
        'gbFeeStat
        '
        Me.gbFeeStat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFeeStat.Controls.Add(Me.btnFeeProduce)
        Me.gbFeeStat.Controls.Add(Me.btnFeeAgentEdi)
        Me.gbFeeStat.Controls.Add(Me.btnFeeAgent)
        Me.gbFeeStat.Controls.Add(Me.btnFeeVoyageCon)
        Me.gbFeeStat.Controls.Add(Me.btnFeeVoyageCargo)
        Me.gbFeeStat.Location = New System.Drawing.Point(1354, 4)
        Me.gbFeeStat.Name = "gbFeeStat"
        Me.gbFeeStat.Size = New System.Drawing.Size(483, 48)
        Me.gbFeeStat.TabIndex = 24
        Me.gbFeeStat.TabStop = False
        Me.gbFeeStat.Text = "业务部计费统计"
        '
        'tbcStatTerm
        '
        Me.tbcStatTerm.Controls.Add(Me.tbpTime)
        Me.tbcStatTerm.Controls.Add(Me.tbpFileNo)
        Me.tbcStatTerm.Location = New System.Drawing.Point(4, 0)
        Me.tbcStatTerm.Name = "tbcStatTerm"
        Me.tbcStatTerm.SelectedIndex = 0
        Me.tbcStatTerm.Size = New System.Drawing.Size(416, 52)
        Me.tbcStatTerm.TabIndex = 25
        '
        'tbpTime
        '
        Me.tbpTime.Controls.Add(Me.dtpBegin)
        Me.tbpTime.Controls.Add(Me.dtpEnd)
        Me.tbpTime.Controls.Add(Me.Label2)
        Me.tbpTime.Controls.Add(Me.Label1)
        Me.tbpTime.Location = New System.Drawing.Point(4, 22)
        Me.tbpTime.Name = "tbpTime"
        Me.tbpTime.Size = New System.Drawing.Size(408, 26)
        Me.tbpTime.TabIndex = 0
        Me.tbpTime.Text = "统计时间"
        '
        'tbpFileNo
        '
        Me.tbpFileNo.Controls.Add(Me.txtEndNo)
        Me.tbpFileNo.Controls.Add(Me.Label4)
        Me.tbpFileNo.Location = New System.Drawing.Point(4, 22)
        Me.tbpFileNo.Name = "tbpFileNo"
        Me.tbpFileNo.Size = New System.Drawing.Size(408, 26)
        Me.tbpFileNo.TabIndex = 1
        '
        'txtEndNo
        '
        Me.txtEndNo.Location = New System.Drawing.Point(-208, 2)
        Me.txtEndNo.Name = "txtEndNo"
        Me.txtEndNo.Size = New System.Drawing.Size(101, 21)
        Me.txtEndNo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(-136, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "结束档案号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBeginNo
        '
        Me.txtBeginNo.Location = New System.Drawing.Point(-140, 24)
        Me.txtBeginNo.Name = "txtBeginNo"
        Me.txtBeginNo.Size = New System.Drawing.Size(101, 21)
        Me.txtBeginNo.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(-88, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "开始档案号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmAccountStat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(911, 573)
        Me.Controls.Add(Me.tbcStatTerm)
        Me.Controls.Add(Me.gbFeeStat)
        Me.Controls.Add(Me.gbDeptCon)
        Me.Controls.Add(Me.gbDeptCargo)
        Me.Controls.Add(Me.btnSortdefault)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnExportSave)
        Me.Controls.Add(Me.btnExportEdit)
        Me.Controls.Add(Me.cbDept)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBeginNo)
        Me.Controls.Add(Me.btnFeeDeptAgentCon)
        Me.Controls.Add(Me.btnStatConRentAgent)
        Me.Controls.Add(Me.btnStatConRentVoyage)
        Me.Controls.Add(Me.btnStatConVoyage)
        Me.Name = "FrmAccountStat"
        Me.Text = "船作业账单计费统计"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDeptCargo.ResumeLayout(False)
        Me.gbFeeStat.ResumeLayout(False)
        Me.tbcStatTerm.ResumeLayout(False)
        Me.tbpTime.ResumeLayout(False)
        Me.tbpFileNo.ResumeLayout(False)
        Me.tbpFileNo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Enum Stats   '统计表类别名称
        Empty
        FeeVoyageCargo
        FeeVoyageCon
        FeeAgentTotal
        FeeAgentEdi
        FeeProduce

        FeeDeptAgentCargo
        FeeDeptAgentCon
        StatConVoyage
        StatConRentVoyage
        StatConRentAgent
        StatCargoVoyage
        StatCargoGoods
        StatCargoClass
        StatCargoVoyGoods

    End Enum
    Public Enum Oper
        None
        Edit
        Save
        Print
    End Enum
    Structure IsChange  '统计条件变化标志
        Dim dtBeginOld As Date
        Dim dtEndOld As Date
        Dim strBeginNoOld As String
        Dim strEndNoOld As String
        Dim strStatTermOld As String    '统计条件
        Dim strDeptOld As String
        Dim blChange As Boolean     '时间条件
        Dim blChange2 As Boolean
        Sub New(ByVal strStatTerm As String, ByVal dtBegin As Date, ByVal dtEnd As Date)
            Me.dtBeginOld = dtBegin
            Me.dtEndOld = dtEnd
            Me.strBeginNoOld = ""
            Me.strEndNoOld = ""
            Me.strStatTermOld = strStatTerm
            Me.blChange = True
        End Sub
        Sub New(ByVal strStatTerm As String, ByVal dtBegin As Date, ByVal dtEnd As Date, ByVal strDept As String)
            Me.dtBeginOld = dtBegin
            Me.dtEndOld = dtEnd
            Me.strBeginNoOld = ""
            Me.strEndNoOld = ""
            Me.strStatTermOld = strStatTerm
            Me.strDeptOld = strDept
            Me.blChange = True
        End Sub
    End Structure

    Dim statClass As Stats = Stats.Empty  '统计表名
    Dim excelOper As Oper = Oper.None   '操作名
    'Dim dtBeginOld, dtEndOld As Date    '老的时间
    Dim blNext As Boolean '检查执行条件是否满足
    'Dim blChange As Boolean '统计条件变化
    Dim btnStatLast As Button   '上一次点击的统计按钮

    Dim changeVoyageCargo As IsChange
    Dim changeVoyageCon As IsChange
    Dim changeAgentTotal As IsChange
    Dim changeAgentEdi As IsChange
    Dim changeProduce As IsChange
    Dim changeDeptAgentCargo As IsChange
    Dim changeDeptAgentCon As IsChange
    Dim changeConVoyage As IsChange
    Dim changeConRentVoyage As IsChange
    Dim changeConRentAgent As IsChange
    Dim changeCargoVoyage As IsChange
    Dim changeCargoGoods As IsChange
    Dim changeCargoClass As IsChange
    Dim changeCargoVoyGoods As IsChange

    Dim sqlFeeVoyageCargo As String
    Dim dvFeeVoyageCargo As DataView
    Dim dsFeeVoyageCargo As New DataSet
    Dim sqlFeeVoyageCon As String
    Dim dvFeeVoyageCon As DataView
    Dim dsFeeVoyageCon As New DataSet
    Dim sqlFeeAgentTotal As String
    Dim dvFeeAgentTotal As DataView
    Dim dsFeeAgentTotal As New DataSet
    Dim sqlFeeAgentEdi As String
    Dim dvFeeAgentEdi As DataView
    Dim dsFeeAgentEdi As New DataSet
    Dim sqlFeeProduce As String
    Dim dvFeeProduce As DataView
    Dim dsFeeProduce As New DataSet

    Dim sqlFeeDeptAgentCargo As String
    Dim dvFeeDeptAgentCargo As DataView
    Dim dsFeeDeptAgentCargo As New DataSet
    Dim sqlFeeDeptAgentCon As String
    Dim dvFeeDeptAgentCon As DataView
    Dim dsFeeDeptAgentCon As New DataSet

    Dim sqlStatConVoyage As String
    Dim dvStatConVoyage As DataView
    Dim dsStatConVoyage As New DataSet
    Dim sqlStatConRentVoyage As String
    Dim dvStatConRentVoyage As DataView
    Dim dsStatConRentVoyage As New DataSet
    Dim sqlStatConRentAgent As String
    Dim dvStatConRentAgent As DataView
    Dim dsStatConRentAgent As New DataSet
    Dim sqlStatCargoVoyage As String
    Dim dvStatCargoVoyage As DataView
    Dim dsStatCargoVoyage As New DataSet
    Dim sqlStatCargoGoods As String
    Dim dvStatCargoGoods As DataView
    Dim dsStatCargoGoods As New DataSet
    Dim sqlStatCargoClass As String
    Dim dvStatCargoClass As DataView
    Dim dsStatCargoClass As New DataSet
    Dim sqlStatCargoVoyGoods As String
    Dim dvStatCargoVoyGoods As DataView
    Dim dsStatCargoVoyGoods As New DataSet

    Dim dtFileNoBegin, dtFileNoEnd As Date  '档案号的起止时间

    Private Sub FrmAccountStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpBegin.Value = Me.dtpBegin.Value.Date.AddMonths(-1).AddDays(-Me.dtpBegin.Value.Day).AddHours(18)
        Me.dtpEnd.Value = Me.dtpEnd.Value.Date.AddDays(-Me.dtpEnd.Value.Day).AddHours(18)
        'dtBeginOld = Me.dtpBegin.Value
        'dtEndOld = Me.dtpEnd.Value
        Dim sqlDept As String
        Dim dvDept As DataView
        sqlDept = "SELECT DEPT_CODE, DEPT_NAME FROM dbo.DEPARTMENT WHERE DEPT_CODE = '00' OR DEPT_CODE LIKE '26.11.1%'"
        dvDept = Filldata(sqlDept)
        Me.cbDept.DataSource = dvDept
        Me.cbDept.DisplayMember = "DEPT_NAME"
        Me.cbDept.ValueMember = "DEPT_CODE"
        If G_DeptCode Like "26.11.1*" Then  '下属作业部门
            Me.tbpFileNo.Visible = False    '不能按档案号统计
            Me.gbFeeStat.Enabled = False    '不能做业务部的统计
            Me.cbDept.Enabled = False   '部门不可选,只能统计本部门数据
            Me.cbDept.SelectedValue = G_DeptCode
            If Me.cbDept.SelectedIndex = -1 Then
                Me.cbDept.SelectedIndex = 0
            End If
            If G_DeptCode = "26.11.11" Then '杂货部不用集装箱
                Me.gbDeptCon.Enabled = False
            End If
        End If
        changeVoyageCargo = New IsChange(Me.tbpTime.Name, Me.dtpBegin.Value, Me.dtpEnd.Value)
        changeVoyageCon = New IsChange(Me.tbpTime.Name, Me.dtpBegin.Value, Me.dtpEnd.Value)
        changeAgentTotal = New IsChange(Me.tbpTime.Name, Me.dtpBegin.Value, Me.dtpEnd.Value)
        changeAgentEdi = New IsChange(Me.tbpTime.Name, Me.dtpBegin.Value, Me.dtpEnd.Value)
        changeProduce = New IsChange(Me.tbpTime.Name, Me.dtpBegin.Value, Me.dtpEnd.Value)
        changeDeptAgentCargo = New IsChange(Me.tbpTime.Name, Me.dtpBegin.Value, Me.dtpEnd.Value, Me.cbDept.SelectedValue)
        changeDeptAgentCon = New IsChange(Me.tbpTime.Name, Me.dtpBegin.Value, Me.dtpEnd.Value, Me.cbDept.SelectedValue)
        changeConVoyage = New IsChange(Me.tbpTime.Name, Me.dtpBegin.Value, Me.dtpEnd.Value, Me.cbDept.SelectedValue)
        changeConRentVoyage = New IsChange(Me.tbpTime.Name, Me.dtpBegin.Value, Me.dtpEnd.Value, Me.cbDept.SelectedValue)
        changeConRentAgent = New IsChange(Me.tbpTime.Name, Me.dtpBegin.Value, Me.dtpEnd.Value, Me.cbDept.SelectedValue)
        changeCargoVoyage = New IsChange(Me.tbpTime.Name, Me.dtpBegin.Value, Me.dtpEnd.Value, Me.cbDept.SelectedValue)
        changeCargoGoods = New IsChange(Me.tbpTime.Name, Me.dtpBegin.Value, Me.dtpEnd.Value, Me.cbDept.SelectedValue)
        changeCargoClass = New IsChange(Me.tbpTime.Name, Me.dtpBegin.Value, Me.dtpEnd.Value, Me.cbDept.SelectedValue)
        changeCargoVoyGoods = New IsChange(Me.tbpTime.Name, Me.dtpBegin.Value, Me.dtpEnd.Value, Me.cbDept.SelectedValue)
    End Sub

    Private Sub FrmAccountStat_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub

    Private Function GetFileNoDate(ByVal statChange As IsChange) As String     '获得档案号的计费时间显示
        Dim sqlGetFileNoTime As String
        Dim dvGetFileNoTime As DataView
        sqlGetFileNoTime = "select Min(ListDate) BeginTime,Max(ListDate) EndTime from Bill_List where No>'" & statChange.strBeginNoOld & "' and No<='" & statChange.strEndNoOld & "'"
        dvGetFileNoTime = Filldata(sqlGetFileNoTime)
        If Not IsDBNull(dvGetFileNoTime(0)("BeginTime")) Then
            dtFileNoBegin = dvGetFileNoTime(0)("BeginTime")
            dtFileNoEnd = dvGetFileNoTime(0)("EndTime")
            If dtFileNoBegin.AddDays(7).Month >= dtFileNoEnd.Month Then '除非开始时间是12月份的最后七天之前的,否则完全正确.
                Return dtFileNoEnd.ToString("yyyy年MM月")
            Else
                Return dtFileNoBegin.AddDays(7).ToString("yyyy年MM月") & "—" & dtFileNoEnd.ToString("MM月")
            End If
        End If
    End Function

    Private Sub OperCheck(ByRef change As IsChange) '操作检查
        If Me.tbcStatTerm.SelectedTab Is Me.tbpTime Then    '按时间查询
            If Me.dtpBegin.Value <= Me.dtpEnd.Value Then
                blNext = True
            Else
                MessageBox.Show("开始时间不得晚于结束时间", "提示")
                Me.dtpBegin.Focus()
                blNext = False
            End If
            If blNext Then
                If change.dtBeginOld <> Me.dtpBegin.Value Then
                    change.dtBeginOld = Me.dtpBegin.Value
                    change.blChange = True
                End If
                If change.dtEndOld <> Me.dtpEnd.Value Then
                    change.dtEndOld = Me.dtpEnd.Value
                    change.blChange = True
                End If
                If change.strDeptOld <> "" Then
                    If change.strDeptOld <> Me.cbDept.SelectedValue Then
                        change.strDeptOld = Me.cbDept.SelectedValue
                        change.blChange = True
                    End If
                End If
            End If
        ElseIf Me.tbcStatTerm.SelectedTab Is Me.tbpFileNo Then  '按档案号查询
            If Me.txtBeginNo.Text Like "########" Then
                If Me.txtEndNo.Text Like "########" Then
                    If Me.txtBeginNo.Text < Me.txtEndNo.Text Then
                        blNext = True
                    Else
                        MessageBox.Show("开始档案号应该小于结束号", "提示")
                        Me.txtBeginNo.Focus()
                        blNext = False
                    End If
                Else
                    MessageBox.Show("结束档案号应为八位数字", "提示")
                    Me.txtEndNo.Focus()
                    blNext = False
                End If
            Else
                MessageBox.Show("开始档案号应为八位数字", "提示")
                Me.txtBeginNo.Focus()
                blNext = False
            End If
            If blNext Then
                If change.strBeginNoOld <> Me.txtBeginNo.Text Then
                    change.strBeginNoOld = Me.txtBeginNo.Text
                    change.blChange = True
                End If
                If change.strEndNoOld <> Me.txtEndNo.Text Then
                    change.strEndNoOld = Me.txtEndNo.Text
                    change.blChange = True
                End If
                If change.strDeptOld <> "" Then
                    If change.strDeptOld <> Me.cbDept.SelectedValue Then
                        change.strDeptOld = Me.cbDept.SelectedValue
                        change.blChange = True
                    End If
                End If
            End If
        End If
        If blNext Then
            If change.strStatTermOld <> Me.tbcStatTerm.SelectedTab.Name Then
                change.strStatTermOld = Me.tbcStatTerm.SelectedTab.Name
                change.blChange = True
            End If
        End If
    End Sub

    Private Sub btnFeeVoyageCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeeVoyageCon.Click
        OperCheck(changeVoyageCon)
        If blNext Then
            If changeVoyageCon.blChange OrElse IsNothing(dvFeeVoyageCon) Then   '改变统计条件或者是首次做该报表的统计
                Dim strDynamicTerm As String
                If Me.tbcStatTerm.SelectedTab Is Me.tbpTime Then
                    strDynamicTerm = " WORKTIME_END>='" & Me.dtpBegin.Value & "' and WORKTIME_END<'" & Me.dtpEnd.Value & "' "
                ElseIf Me.tbcStatTerm.SelectedTab Is Me.tbpFileNo Then
                    strDynamicTerm = " FILE_NO>='" & Me.txtBeginNo.Text & "' and FILE_NO<='" & Me.txtEndNo.Text & "' "
                Else
                    Exit Sub
                End If
                sqlFeeVoyageCon = "SELECT SHIP_ID,FILE_NO,CHI_VESSEL,VOYAGE,SHIP_TYPE,InOutPort_Name,TeuSum,FullSum,EmptySum,Weight,MONEY,Base,Night,Holiday,Paper,Traffic,Seal,ConLoad,OutReship,Other,SHIPAGENT_SHORT, WORKTIME_END FROM View_FeeVoyageCon where " & strDynamicTerm & " order by FILE_NO"
                dvFeeVoyageCon = Getdata(sqlFeeVoyageCon, dsFeeVoyageCon)
                changeVoyageCon.blChange = False
            End If
            Me.C1DBG.DataSource = dvFeeVoyageCon
            If statClass <> Stats.FeeVoyageCon Then '改变了统计报表
                If statClass <> Stats.Empty Then    '非首次统计操作
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                btnStatLast = Me.btnFeeVoyageCon
                Me.btnFeeVoyageCon.ForeColor = Color.Red
                statClass = Stats.FeeVoyageCon
                'Grid设置
                Me.C1DBG.Caption = Me.btnFeeVoyageCon.Text
                Me.C1DBG.Columns("FILE_NO").Caption = "档案号"
                Me.C1DBG.Columns("CHI_VESSEL").Caption = "船名"
                Me.C1DBG.Columns("VOYAGE").Caption = "航次"
                Me.C1DBG.Columns("SHIP_TYPE").Caption = "外/国"
                Me.C1DBG.Columns("InOutPort_Name").Caption = "进/出"
                Me.C1DBG.Columns("TeuSum").Caption = "标箱"
                Me.C1DBG.Columns("FullSum").Caption = "重箱"
                Me.C1DBG.Columns("EmptySum").Caption = "空箱"
                Me.C1DBG.Columns("Weight").Caption = "吨数"
                Me.C1DBG.Columns("MONEY").Caption = "收入"
                Me.C1DBG.Columns("Base").Caption = "基本"
                Me.C1DBG.Columns("Night").Caption = "夜班"
                Me.C1DBG.Columns("Holiday").Caption = "假日"
                Me.C1DBG.Columns("Paper").Caption = "单证"
                Me.C1DBG.Columns("Traffic").Caption = "交通"
                Me.C1DBG.Columns("Seal").Caption = "铅封"
                Me.C1DBG.Columns("ConLoad").Caption = "CFS"
                Me.C1DBG.Columns("OutReship").Caption = "翻舱"
                Me.C1DBG.Columns("Other").Caption = "其它"
                Me.C1DBG.Columns("SHIPAGENT_SHORT").Caption = "船代"
                Me.C1DBG.Columns("WORKTIME_END").Caption = "完船日期"
                Me.C1DBG.Splits(0).DisplayColumns("SHIP_ID").Visible = False
                Me.C1DBG.Columns("WORKTIME_END").NumberFormat = "yy年MM月dd日"
            End If
            SetDGWidth(Me.C1DBG, 4)
            'Grid单列统计
            Me.C1DBG.Columns("TeuSum").FooterText = GetDataSum(dvFeeVoyageCon, "TeuSum")
            Me.C1DBG.Columns("FullSum").FooterText = GetDataSum(dvFeeVoyageCon, "FullSum")
            Me.C1DBG.Columns("EmptySum").FooterText = GetDataSum(dvFeeVoyageCon, "EmptySum")
            Me.C1DBG.Columns("Weight").FooterText = GetDataSum(dvFeeVoyageCon, "Weight")
            Me.C1DBG.Columns("MONEY").FooterText = GetDataSum(dvFeeVoyageCon, "MONEY")
            Me.C1DBG.Columns("Base").FooterText = GetDataSum(dvFeeVoyageCon, "Base")
            Me.C1DBG.Columns("Night").FooterText = GetDataSum(dvFeeVoyageCon, "Night")
            Me.C1DBG.Columns("Holiday").FooterText = GetDataSum(dvFeeVoyageCon, "Holiday")
            Me.C1DBG.Columns("Paper").FooterText = GetDataSum(dvFeeVoyageCon, "Paper")
            Me.C1DBG.Columns("Traffic").FooterText = GetDataSum(dvFeeVoyageCon, "Traffic")
            Me.C1DBG.Columns("Seal").FooterText = GetDataSum(dvFeeVoyageCon, "Seal")
            Me.C1DBG.Columns("ConLoad").FooterText = GetDataSum(dvFeeVoyageCon, "ConLoad")
            Me.C1DBG.Columns("OutReship").FooterText = GetDataSum(dvFeeVoyageCon, "OutReship")
            Me.C1DBG.Columns("Other").FooterText = GetDataSum(dvFeeVoyageCon, "Other")
            Me.C1DBG.Columns("CHI_VESSEL").FooterText = "合计" & dvFeeVoyageCon.Count & "班"
            Me.C1DBG.FilterBar = False
        End If
    End Sub

    Private Sub DealFeeVoyageCon(ByVal xlApp As Excel.ApplicationClass)
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Dim i, j As Integer
        PathStr = substr(PathStr)
        Dim strExcelName As String = "FeeVoyageCon.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "业务费收集"
        xlBook = xlApp.Workbooks.Add(strPath)
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        Dim rowStart As Integer = 2 'Excel中循环起始行位置
        For i = 0 To dvFeeVoyageCon.Count - 1
            Dim str As String = Me.C1DBG.Columns("FILE_NO").CellText(i)
            If str.Length >= 8 Then
                xlSheet.Cells(i + rowStart, "A") = str.Substring(str.Length - 4)
            Else
                xlSheet.Cells(i + rowStart, "A") = str
            End If
            xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
            xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("VOYAGE").CellText(i)
            xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("SHIP_TYPE").CellText(i)
            xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("InOutPort_Name").CellText(i)

            xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("TeuSum").CellText(i)
            xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("FullSum").CellText(i)
            xlSheet.Cells(i + rowStart, "I") = Me.C1DBG.Columns("EmptySum").CellText(i)

            xlSheet.Cells(i + rowStart, "K") = Me.C1DBG.Columns("Weight").CellText(i)
            xlSheet.Cells(i + rowStart, "L") = Me.C1DBG.Columns("MONEY").CellText(i)
            xlSheet.Cells(i + rowStart, "M") = Me.C1DBG.Columns("Base").CellText(i)
            xlSheet.Cells(i + rowStart, "N") = Me.C1DBG.Columns("Night").CellText(i)
            xlSheet.Cells(i + rowStart, "O") = Me.C1DBG.Columns("Holiday").CellText(i)
            xlSheet.Cells(i + rowStart, "P") = Me.C1DBG.Columns("Paper").CellText(i)
            xlSheet.Cells(i + rowStart, "Q") = Me.C1DBG.Columns("Traffic").CellText(i)
            xlSheet.Cells(i + rowStart, "R") = Me.C1DBG.Columns("Seal").CellText(i)
            xlSheet.Cells(i + rowStart, "S") = Me.C1DBG.Columns("ConLoad").CellText(i)

            xlSheet.Cells(i + rowStart, "U") = Me.C1DBG.Columns("OutReship").CellText(i)
            xlSheet.Cells(i + rowStart, "V") = Me.C1DBG.Columns("Other").CellText(i)

            xlSheet.Cells(i + rowStart, "X") = Me.C1DBG.Columns("SHIPAGENT_SHORT").CellText(i)
            xlSheet.Cells(i + rowStart, "Y") = Me.C1DBG.Columns("WORKTIME_END").CellText(i)
        Next
        xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("TeuSum").FooterText
        xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("FullSum").FooterText
        xlSheet.Cells(i + rowStart, "I") = Me.C1DBG.Columns("EmptySum").FooterText

        xlSheet.Cells(i + rowStart, "K") = Me.C1DBG.Columns("Weight").FooterText
        xlSheet.Cells(i + rowStart, "L") = Me.C1DBG.Columns("MONEY").FooterText
        xlSheet.Cells(i + rowStart, "M") = Me.C1DBG.Columns("Base").FooterText
        xlSheet.Cells(i + rowStart, "N") = Me.C1DBG.Columns("Night").FooterText
        xlSheet.Cells(i + rowStart, "O") = Me.C1DBG.Columns("Holiday").FooterText
        xlSheet.Cells(i + rowStart, "P") = Me.C1DBG.Columns("Paper").FooterText
        xlSheet.Cells(i + rowStart, "Q") = Me.C1DBG.Columns("Traffic").FooterText
        xlSheet.Cells(i + rowStart, "R") = Me.C1DBG.Columns("Seal").FooterText
        xlSheet.Cells(i + rowStart, "S") = Me.C1DBG.Columns("ConLoad").FooterText

        xlSheet.Cells(i + rowStart, "U") = Me.C1DBG.Columns("OutReship").FooterText
        xlSheet.Cells(i + rowStart, "V") = Me.C1DBG.Columns("Other").FooterText

        xlSheet.Cells(i + rowStart, "A") = "合计"
        xlSheet.Cells(i + rowStart, "B") = dvFeeVoyageCon.Count()
        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "Z")).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "Z")).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "Z")).Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlDot
        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "Z")).Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlDot
        xlSheet.Range(xlSheet.Cells(i + rowStart, "A"), xlSheet.Cells(i + rowStart, "Z")).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        xlSheet.Range(xlSheet.Cells(i + rowStart, "A"), xlSheet.Cells(i + rowStart, "Z")).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    End Sub

    Private Sub btnSortdefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortdefault.Click
        Select Case statClass
            Case Stats.FeeVoyageCargo
                dvFeeVoyageCargo.Sort = "FILE_NO"
            Case Stats.FeeVoyageCon
                dvFeeVoyageCon.Sort = "FILE_NO"
            Case Stats.FeeAgentTotal
                dvFeeAgentTotal.Sort = "Front"
            Case Stats.FeeAgentEdi
                dvFeeAgentEdi.Sort = "SHIPAGENT_SHORT"
            Case Stats.FeeProduce
                dvFeeProduce.Sort = ""
            Case Stats.FeeDeptAgentCargo
                dvFeeDeptAgentCargo.Sort = ""
            Case Stats.FeeDeptAgentCon
                dvFeeDeptAgentCon.Sort = ""
            Case Stats.StatConVoyage
                dvStatConVoyage.Sort = "Ship_ID"
            Case Stats.StatConRentVoyage
                dvStatConRentVoyage.Sort = "SHIPAGENT_SHORT,SHIP_ID,RentShipAgent"
            Case Stats.StatConRentAgent
                dvStatConRentAgent.Sort = ""
            Case Stats.StatCargoVoyage
                dvStatCargoVoyage.Sort = ""
            Case Stats.StatCargoClass
                dvStatCargoClass.Sort = ""
            Case Stats.StatCargoGoods
                dvStatCargoGoods.Sort = ""
            Case Stats.StatCargoVoyGoods
                dvStatCargoVoyGoods.Sort = ""

            Case Stats.Empty
            Case Else
        End Select
    End Sub

    Private Sub btnExportEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportEdit.Click
        excelOper = Oper.Edit
        CreateReports()
    End Sub

    Private Sub btnExportSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportSave.Click
        excelOper = Oper.Save
        CreateReports()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        excelOper = Oper.Print
        CreateReports()
    End Sub

    Dim PathStr As String = System.Reflection.Assembly.GetExecutingAssembly.Location
    Private Sub CreateReports()
        If statClass <> Stats.Empty Then
            DealReport()
            GC.Collect()
        End If
    End Sub
    Private Sub DealReport()    '生成Excel的框架
        Try
            Dim xlApp As Excel.Application
            xlApp = New Excel.ApplicationClass
            Dim xlBook As Excel.Workbook
            Dim xlSheet As Excel.Worksheet
            Select Case statClass
                Case Stats.FeeVoyageCargo
                    DealFeeVoyageCargo(xlApp)
                Case Stats.FeeVoyageCon
                    DealFeeVoyageCon(xlApp)
                Case Stats.FeeAgentTotal
                    DealFeeAgentTotal(xlApp)
                Case Stats.FeeAgentEdi
                    DealFeeAgentEdi(xlApp)
                Case Stats.FeeProduce
                    DealFeeProduce(xlApp)
                Case Stats.FeeDeptAgentCargo
                    DealFeeDeptAgentCargo(xlApp)
                Case Stats.FeeDeptAgentCon
                    DealFeeDeptAgentCon(xlApp)
                Case Stats.StatConVoyage
                    DealStatConVoyage(xlApp)
                Case Stats.StatConRentVoyage
                    DealStatConRentVoyage(xlApp)
                Case Stats.StatConRentAgent
                    DealStatConRentAgent(xlApp)
                Case Stats.StatCargoVoyage
                    DealStatCargoVoyage(xlApp)
                Case Stats.StatCargoClass
                    DealStatCargoClass(xlApp)
                Case Stats.StatCargoGoods
                    DealStatCargoGoods(xlApp)
                Case Stats.StatCargoVoyGoods
                    DealStatCargoVoyGoods(xlApp)

                Case Stats.Empty
                Case Else
            End Select
            If excelOper = Oper.Edit Then   '导出编辑
                xlApp.Visible = True
            ElseIf excelOper = Oper.Save Then '导出保存
                Dim sfDialog As SaveFileDialog = New SaveFileDialog
                sfDialog.FileName = ""
                sfDialog.InitialDirectory = PathStr & "\report\"
                If System.IO.Directory.Exists(sfDialog.InitialDirectory) = False Then
                    System.IO.Directory.CreateDirectory(sfDialog.InitialDirectory)
                End If
                sfDialog.RestoreDirectory = True
                sfDialog.AddExtension = True
                sfDialog.DefaultExt = ".xls"
                sfDialog.Filter = "Excel文件(*.xls)|*.xls"
                If sfDialog.ShowDialog() = DialogResult.OK Then
                    xlBook.SaveCopyAs(sfDialog.FileName)
                End If
                xlBook.Close(False, Type.Missing, Type.Missing) '关闭工作簿
                xlApp.Quit()
            ElseIf excelOper = Oper.Print Then '打印
                xlSheet.PrintOut(1, Type.Missing, 1, False, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
                xlBook.Close(False, Type.Missing, Type.Missing) '关闭工作簿
                xlApp.Quit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnFeeVoyageCargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeeVoyageCargo.Click
        OperCheck(changeVoyageCargo)
        If blNext Then
            If changeVoyageCargo.blChange OrElse IsNothing(dvFeeVoyageCargo) Then   '改变统计条件或者是首次做该报表的统计
                Dim strDynamicTerm As String
                If Me.tbcStatTerm.SelectedTab Is Me.tbpTime Then
                    strDynamicTerm = " WORKTIME_END>='" & Me.dtpBegin.Value & "' and WORKTIME_END<'" & Me.dtpEnd.Value & "' "
                ElseIf Me.tbcStatTerm.SelectedTab Is Me.tbpFileNo Then
                    strDynamicTerm = " FILE_NO>='" & Me.txtBeginNo.Text & "' and FILE_NO<='" & Me.txtEndNo.Text & "' "
                Else
                    Exit Sub
                End If
                sqlFeeVoyageCargo = "SELECT SHIP_ID,DEPT_SHORT,FILE_NO,CHI_VESSEL,VOYAGE,SHIP_TYPE,InOutPort_Name,Amount,Tons,MONEY,Base,Night,Holiday,Paper,Traffic,Mark,Wait,NoNormal,OutReship,Overstep,Other,SHIPAGENT_SHORT, WORKTIME_END FROM View_FeeVoyageCargo where " & strDynamicTerm & " order by FILE_NO"
                dvFeeVoyageCargo = Getdata(sqlFeeVoyageCargo, dsFeeVoyageCargo)
                changeVoyageCargo.blChange = False
            End If
            Me.C1DBG.DataSource = dvFeeVoyageCargo
            If statClass <> Stats.FeeVoyageCargo Then   '改变了统计报表
                If statClass <> Stats.Empty Then    '非首次统计操作
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                btnStatLast = Me.btnFeeVoyageCargo
                Me.btnFeeVoyageCargo.ForeColor = Color.Red
                statClass = Stats.FeeVoyageCargo
                'Grid设置
                Me.C1DBG.Caption = Me.btnFeeVoyageCargo.Text
                Me.C1DBG.Columns("DEPT_SHORT").Caption = "部"
                Me.C1DBG.Columns("FILE_NO").Caption = "档案号"
                Me.C1DBG.Columns("CHI_VESSEL").Caption = "船名"
                Me.C1DBG.Columns("VOYAGE").Caption = "航次"
                Me.C1DBG.Columns("SHIP_TYPE").Caption = "外/国"
                Me.C1DBG.Columns("InOutPort_Name").Caption = "进/出"
                Me.C1DBG.Columns("Amount").Caption = "件数"
                Me.C1DBG.Columns("Tons").Caption = "吨数"
                Me.C1DBG.Columns("MONEY").Caption = "收入"
                Me.C1DBG.Columns("Base").Caption = "基本"
                Me.C1DBG.Columns("Night").Caption = "夜班"
                Me.C1DBG.Columns("Holiday").Caption = "假日"
                Me.C1DBG.Columns("Paper").Caption = "单证"
                Me.C1DBG.Columns("Traffic").Caption = "交通"
                Me.C1DBG.Columns("Mark").Caption = "分标志"
                Me.C1DBG.Columns("Wait").Caption = "待时"
                Me.C1DBG.Columns("NoNormal").Caption = "非一般"
                Me.C1DBG.Columns("OutReship").Caption = "翻舱"
                Me.C1DBG.Columns("Overstep").Caption = "超重"
                Me.C1DBG.Columns("Other").Caption = "其它"
                Me.C1DBG.Columns("SHIPAGENT_SHORT").Caption = "船代"
                Me.C1DBG.Columns("WORKTIME_END").Caption = "完船日期"
                Me.C1DBG.Splits(0).DisplayColumns("SHIP_ID").Visible = False
                Me.C1DBG.Columns("WORKTIME_END").NumberFormat = "yy年MM月dd日"
            End If
            SetDGWidth(Me.C1DBG, 4)
            'Grid单列统计
            Me.C1DBG.Columns("Amount").FooterText = GetDataSum(dvFeeVoyageCargo, "Amount")
            Me.C1DBG.Columns("Tons").FooterText = GetDataSum(dvFeeVoyageCargo, "Tons")
            Me.C1DBG.Columns("MONEY").FooterText = GetDataSum(dvFeeVoyageCargo, "MONEY")
            Me.C1DBG.Columns("Base").FooterText = GetDataSum(dvFeeVoyageCargo, "Base")
            Me.C1DBG.Columns("Night").FooterText = GetDataSum(dvFeeVoyageCargo, "Night")
            Me.C1DBG.Columns("Holiday").FooterText = GetDataSum(dvFeeVoyageCargo, "Holiday")
            Me.C1DBG.Columns("Paper").FooterText = GetDataSum(dvFeeVoyageCargo, "Paper")
            Me.C1DBG.Columns("Traffic").FooterText = GetDataSum(dvFeeVoyageCargo, "Traffic")
            Me.C1DBG.Columns("Mark").FooterText = GetDataSum(dvFeeVoyageCargo, "Mark")
            Me.C1DBG.Columns("Wait").FooterText = GetDataSum(dvFeeVoyageCargo, "Wait")
            Me.C1DBG.Columns("NoNormal").FooterText = GetDataSum(dvFeeVoyageCargo, "NoNormal")
            Me.C1DBG.Columns("OutReship").FooterText = GetDataSum(dvFeeVoyageCargo, "OutReship")
            Me.C1DBG.Columns("Overstep").FooterText = GetDataSum(dvFeeVoyageCargo, "Overstep")
            Me.C1DBG.Columns("Other").FooterText = GetDataSum(dvFeeVoyageCargo, "Other")
            Me.C1DBG.Columns("CHI_VESSEL").FooterText = "合计" & dvFeeVoyageCargo.Count & "班"
            Me.C1DBG.FilterBar = False
        End If
    End Sub

    Private Sub DealFeeVoyageCargo(ByVal xlApp As Excel.ApplicationClass)
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Dim i, j As Integer
        PathStr = substr(PathStr)
        Dim strExcelName As String = "FeeVoyageCargo.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "业务费收件"
        xlBook = xlApp.Workbooks.Add(strPath)
        'xlSheet=(Excel.Worksheet)xlBook.Worksheets(strSheetName)
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        Dim rowStart As Integer = 2 'Excel中循环起始行位置
        For i = 0 To dvFeeVoyageCargo.Count - 1
            xlSheet.Cells(i + rowStart, "A") = Me.C1DBG.Columns("DEPT_SHORT").CellText(i)
            Dim str As String = Me.C1DBG.Columns("FILE_NO").CellText(i)
            If str.Length >= 8 Then
                xlSheet.Cells(i + rowStart, "B") = str.Substring(str.Length - 4)
            Else
                xlSheet.Cells(i + rowStart, "B") = str
            End If
            xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
            xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("SHIP_TYPE").CellText(i)
            xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("InOutPort_Name").CellText(i)
            xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("Amount").CellText(i)
            xlSheet.Cells(i + rowStart, "I") = Me.C1DBG.Columns("Tons").CellText(i)

            xlSheet.Cells(i + rowStart, "K") = Me.C1DBG.Columns("MONEY").CellText(i)
            xlSheet.Cells(i + rowStart, "L") = Me.C1DBG.Columns("Base").CellText(i)
            xlSheet.Cells(i + rowStart, "M") = Me.C1DBG.Columns("Night").CellText(i)
            xlSheet.Cells(i + rowStart, "N") = Me.C1DBG.Columns("Holiday").CellText(i)
            xlSheet.Cells(i + rowStart, "O") = Me.C1DBG.Columns("Paper").CellText(i)
            xlSheet.Cells(i + rowStart, "P") = Me.C1DBG.Columns("Traffic").CellText(i)
            xlSheet.Cells(i + rowStart, "Q") = Me.C1DBG.Columns("Mark").CellText(i)
            xlSheet.Cells(i + rowStart, "R") = Me.C1DBG.Columns("Wait").CellText(i)
            xlSheet.Cells(i + rowStart, "S") = Me.C1DBG.Columns("NoNormal").CellText(i)

            xlSheet.Cells(i + rowStart, "U") = Me.C1DBG.Columns("OutReship").CellText(i)

            xlSheet.Cells(i + rowStart, "W") = Me.C1DBG.Columns("Overstep").CellText(i)
            xlSheet.Cells(i + rowStart, "X") = Me.C1DBG.Columns("Other").CellText(i)

            xlSheet.Cells(i + rowStart, "Z") = Me.C1DBG.Columns("SHIPAGENT_SHORT").CellText(i)
            xlSheet.Cells(i + rowStart, "AA") = Me.C1DBG.Columns("WORKTIME_END").CellText(i)
        Next
        xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("Amount").FooterText
        xlSheet.Cells(i + rowStart, "I") = Me.C1DBG.Columns("Tons").FooterText

        xlSheet.Cells(i + rowStart, "K") = Me.C1DBG.Columns("MONEY").FooterText
        xlSheet.Cells(i + rowStart, "L") = Me.C1DBG.Columns("Base").FooterText
        xlSheet.Cells(i + rowStart, "M") = Me.C1DBG.Columns("Night").FooterText
        xlSheet.Cells(i + rowStart, "N") = Me.C1DBG.Columns("Holiday").FooterText
        xlSheet.Cells(i + rowStart, "O") = Me.C1DBG.Columns("Paper").FooterText
        xlSheet.Cells(i + rowStart, "P") = Me.C1DBG.Columns("Traffic").FooterText
        xlSheet.Cells(i + rowStart, "Q") = Me.C1DBG.Columns("Mark").FooterText
        xlSheet.Cells(i + rowStart, "R") = Me.C1DBG.Columns("Wait").FooterText
        xlSheet.Cells(i + rowStart, "S") = Me.C1DBG.Columns("NoNormal").FooterText

        xlSheet.Cells(i + rowStart, "U") = Me.C1DBG.Columns("OutReship").FooterText
        xlSheet.Cells(i + rowStart, "W") = Me.C1DBG.Columns("Overstep").FooterText
        xlSheet.Cells(i + rowStart, "X") = Me.C1DBG.Columns("Other").FooterText

        xlSheet.Range(xlSheet.Cells(i + rowStart, "A"), xlSheet.Cells(i + rowStart, "B")).Merge()
        xlSheet.Cells(i + rowStart, "A") = "合计"
        xlSheet.Cells(i + rowStart, "C") = dvFeeVoyageCargo.Count()
        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "AA")).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "AA")).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "AA")).Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlDot
        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "AA")).Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlDot
        xlSheet.Range(xlSheet.Cells(i + rowStart, "A"), xlSheet.Cells(i + rowStart, "AA")).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        xlSheet.Range(xlSheet.Cells(i + rowStart, "A"), xlSheet.Cells(i + rowStart, "AA")).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
    '特别的dv的列数值合计,iEnd=-1表示默认按dvData.Count计数
    Public Shared Function GetDataSumEsp(ByVal dvData As DataView, ByVal strColName As String, Optional ByVal iStart As Integer = 0, Optional ByVal iEnd As Integer = -1) As Decimal
        Dim i As Integer
        Dim fTotal As Decimal
        If iEnd = -1 Then
            For i = iStart To dvData.Count - 1
                If Convert.IsDBNull(dvData(i)(strColName)) = False Then
                    fTotal += dvData(i)(strColName)
                End If
            Next
        Else
            For i = iStart To iEnd
                If Convert.IsDBNull(dvData(i)(strColName)) = False Then
                    fTotal += dvData(i)(strColName)
                End If
            Next
        End If
        Return fTotal
    End Function

    Private Sub btnFeeDeptAgentCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeeDeptAgentCon.Click
        OperCheck(changeDeptAgentCon)
        If blNext Then
            If changeDeptAgentCon.blChange OrElse IsNothing(dvFeeDeptAgentCon) Then   '改变统计条件或者是首次做该报表的统计
                Dim strDept As String
                strDept = Me.cbDept.SelectedValue
                If strDept = "00" Then
                    strDept = "0"
                End If
                sqlFeeDeptAgentCon = "SP_FeeAgentConDept '" & Me.dtpBegin.Value & "','" & Me.dtpEnd.Value & "','" & strDept & "'"
                dvFeeDeptAgentCon = Getdata(sqlFeeDeptAgentCon, dsFeeDeptAgentCon)
                changeDeptAgentCon.blChange = False
            End If
            Me.C1DBG.DataSource = dvFeeDeptAgentCon
            If statClass <> Stats.FeeDeptAgentCon Then '改变了统计报表
                If statClass <> Stats.Empty Then    '非首次统计操作
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                btnStatLast = Me.btnFeeDeptAgentCon
                Me.btnFeeDeptAgentCon.ForeColor = Color.Red
                statClass = Stats.FeeDeptAgentCon
                'Grid设置
                Me.C1DBG.Caption = Me.btnFeeDeptAgentCon.Text
                Me.C1DBG.Columns("Front").Caption = "项目"
                Me.C1DBG.Columns("VoySum").Caption = "艘次"
                Me.C1DBG.Columns("VoySumTotal").Caption = "累计艘次"
                Me.C1DBG.Columns("TeuSum").Caption = "标箱"
                Me.C1DBG.Columns("TeuSumTotal").Caption = "累计标箱"
                Me.C1DBG.Columns("Weight").Caption = "吨数"
                Me.C1DBG.Columns("WeightTotal").Caption = "累计吨数"
                Me.C1DBG.Columns("Money").Caption = "收入"
                Me.C1DBG.Columns("Edi").Caption = "EDI"
                Me.C1DBG.Columns("AllFee").Caption = "合计"
                'Me.C1DBG.Columns("MoneyTotal").Caption = "累计收入"
                'Me.C1DBG.Columns("EdiTotal").Caption = "EDI累计"
                Me.C1DBG.Columns("AllFeeTotal").Caption = "累计收入"
                Me.C1DBG.Splits(0).DisplayColumns("Code").Visible = False
                Me.C1DBG.Splits(0).DisplayColumns("MoneyTotal").Visible = False
                Me.C1DBG.Splits(0).DisplayColumns("EdiTotal").Visible = False
            End If
            SetDGWidth(Me.C1DBG, 4)
            'Grid单列统计
            Me.C1DBG.Columns("VoySum").FooterText = GetDataSumEsp(dvFeeDeptAgentCon, "VoySum", 3)
            Me.C1DBG.Columns("VoySumTotal").FooterText = GetDataSumEsp(dvFeeDeptAgentCon, "VoySumTotal", 3)
            Me.C1DBG.Columns("TeuSum").FooterText = GetDataSumEsp(dvFeeDeptAgentCon, "TeuSum", 3)
            Me.C1DBG.Columns("TeuSumTotal").FooterText = GetDataSumEsp(dvFeeDeptAgentCon, "TeuSumTotal", 3)
            Me.C1DBG.Columns("Weight").FooterText = GetDataSumEsp(dvFeeDeptAgentCon, "Weight", 3)
            Me.C1DBG.Columns("WeightTotal").FooterText = GetDataSumEsp(dvFeeDeptAgentCon, "WeightTotal", 3)
            Me.C1DBG.Columns("Money").FooterText = GetDataSumEsp(dvFeeDeptAgentCon, "Money", 3)
            Me.C1DBG.Columns("Edi").FooterText = GetDataSumEsp(dvFeeDeptAgentCon, "Edi", 3)
            Me.C1DBG.Columns("AllFee").FooterText = Convert.ToDecimal(Me.C1DBG.Columns("Money").FooterText) + Me.C1DBG.Columns("Edi").FooterText
            'Me.C1DBG.Columns("MoneyTotal").FooterText = GetDataSumEsp(dvFeeDeptAgentCon, "MoneyTotal", 3)
            'Me.C1DBG.Columns("EdiTotal").FooterText = GetDataSumEsp(dvFeeDeptAgentCon, "EdiTotal", 3)
            Me.C1DBG.Columns("AllFeeTotal").FooterText = GetDataSumEsp(dvFeeDeptAgentCon, "AllFeeTotal", 3)
            Me.C1DBG.Columns("Front").FooterText = "合计" & dvFeeDeptAgentCon.Count - 3 & "家"
            Me.C1DBG.FilterBar = False
        End If
    End Sub

    Private Sub DealFeeDeptAgentCon(ByVal xlApp As Excel.ApplicationClass)
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Dim i, j As Integer
        PathStr = substr(PathStr)
        Dim strExcelName As String = "FeeDeptAgentCon.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "分船代集装箱费统计"
        xlBook = xlApp.Workbooks.Add(strPath)
        'xlSheet=(Excel.Worksheet)xlBook.Worksheets(strSheetName)
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        Dim rowStart As Integer = 7 'Excel中循环起始行位置
        For i = 0 To dvFeeDeptAgentCon.Count - 1
            xlSheet.Cells(i + rowStart, "A") = Me.C1DBG.Columns("Front").CellText(i)
            xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("VoySum").CellText(i)
            xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("VoySumTotal").CellText(i)
            xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("TeuSum").CellText(i)
            xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("TeuSumTotal").CellText(i)
            xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("Weight").CellText(i)
            xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("WeightTotal").CellText(i)
            xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("Money").CellText(i)
            xlSheet.Cells(i + rowStart, "I") = Me.C1DBG.Columns("Edi").CellText(i)
            xlSheet.Cells(i + rowStart, "J") = Me.C1DBG.Columns("AllFee").CellText(i)
            xlSheet.Cells(i + rowStart, "K") = Me.C1DBG.Columns("AllFeeTotal").CellText(i)
        Next
        xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("VoySum").FooterText
        xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("VoySumTotal").FooterText
        xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("TeuSum").FooterText
        xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("TeuSumTotal").FooterText
        xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("Weight").FooterText
        xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("WeightTotal").FooterText
        xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("Money").FooterText
        xlSheet.Cells(i + rowStart, "I") = Me.C1DBG.Columns("Edi").FooterText
        xlSheet.Cells(i + rowStart, "J") = Me.C1DBG.Columns("AllFee").FooterText
        xlSheet.Cells(i + rowStart, "K") = Me.C1DBG.Columns("AllFeeTotal").FooterText
        If Me.cbDept.SelectedIndex > 0 Then
            xlSheet.Cells(2, "H") = Me.cbDept.Text
        End If
        If changeDeptAgentCon.dtBeginOld.AddDays(7).Month >= changeDeptAgentCon.dtEndOld.Month Then
            xlSheet.Cells(3, "J") = changeDeptAgentCon.dtEndOld.ToString("yyyy年MM月")
        Else
            xlSheet.Cells(3, "J") = changeDeptAgentCon.dtBeginOld.AddDays(7).ToString("yyyy年MM月") & "—" & changeDeptAgentCon.dtEndOld.ToString("MM月")
        End If
        xlSheet.Cells(i + rowStart + 1, "A") = "部门经理："
        xlSheet.Cells(i + rowStart + 1, "F") = "统计员："
        xlSheet.Cells(i + rowStart + 1, "J") = "制表时间：" & Now.ToShortDateString()

        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "L")).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub

    Private Sub cbDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDept.SelectedIndexChanged

    End Sub

    Private Sub btnFeeDeptAgentCargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeeDeptAgentCargo.Click
        OperCheck(changeDeptAgentCargo)
        If blNext Then
            If changeDeptAgentCargo.blChange OrElse IsNothing(dvFeeDeptAgentCargo) Then   '改变统计条件或者是首次做该报表的统计
                Dim strDept As String
                strDept = Me.cbDept.SelectedValue
                If strDept = "00" Then
                    strDept = "0"
                End If
                sqlFeeDeptAgentCargo = "SP_FeeAgentCargoDept '" & Me.dtpBegin.Value & "','" & Me.dtpEnd.Value & "','" & strDept & "'"
                dvFeeDeptAgentCargo = Getdata(sqlFeeDeptAgentCargo, dsFeeDeptAgentCargo)
                changeDeptAgentCargo.blChange = False
            End If
            Me.C1DBG.DataSource = dvFeeDeptAgentCargo
            If statClass <> Stats.FeeDeptAgentCargo Then '改变了统计报表
                If statClass <> Stats.Empty Then    '非首次统计操作
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                btnStatLast = Me.btnFeeDeptAgentCargo
                Me.btnFeeDeptAgentCargo.ForeColor = Color.Red
                statClass = Stats.FeeDeptAgentCargo
                'Grid设置
                Me.C1DBG.Caption = Me.btnFeeDeptAgentCargo.Text
                Me.C1DBG.Columns("Front").Caption = "项目"
                Me.C1DBG.Columns("VoySum").Caption = "艘次"
                Me.C1DBG.Columns("VoySumTotal").Caption = "累计艘次"
                Me.C1DBG.Columns("Weight").Caption = "吨数"
                Me.C1DBG.Columns("WeightTotal").Caption = "累计吨数"
                Me.C1DBG.Columns("Money").Caption = "收入"
                Me.C1DBG.Columns("MoneyTotal").Caption = "累计收入"
                Me.C1DBG.Splits(0).DisplayColumns("Code").Visible = False
            End If
            SetDGWidth(Me.C1DBG, 4)
            'Grid单列统计
            Me.C1DBG.Columns("VoySum").FooterText = GetDataSumEsp(dvFeeDeptAgentCargo, "VoySum", 3)
            Me.C1DBG.Columns("VoySumTotal").FooterText = GetDataSumEsp(dvFeeDeptAgentCargo, "VoySumTotal", 3)
            Me.C1DBG.Columns("Weight").FooterText = GetDataSumEsp(dvFeeDeptAgentCargo, "Weight", 3)
            Me.C1DBG.Columns("WeightTotal").FooterText = GetDataSumEsp(dvFeeDeptAgentCargo, "WeightTotal", 3)
            Me.C1DBG.Columns("Money").FooterText = GetDataSumEsp(dvFeeDeptAgentCargo, "Money", 3)
            Me.C1DBG.Columns("MoneyTotal").FooterText = GetDataSumEsp(dvFeeDeptAgentCargo, "MoneyTotal", 3)
            Me.C1DBG.Columns("Front").FooterText = "合计" & dvFeeDeptAgentCargo.Count - 3 & "家"
            Me.C1DBG.FilterBar = False
        End If
    End Sub

    Private Sub DealFeeDeptAgentCargo(ByVal xlApp As Excel.ApplicationClass)
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Dim i, j As Integer
        PathStr = substr(PathStr)
        Dim strExcelName As String = "FeeDeptAgentCargo.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "分船代件杂货费统计"
        xlBook = xlApp.Workbooks.Add(strPath)
        'xlSheet=(Excel.Worksheet)xlBook.Worksheets(strSheetName)
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        Dim rowStart As Integer = 7 'Excel中循环起始行位置
        For i = 0 To dvFeeDeptAgentCargo.Count - 1
            xlSheet.Cells(i + rowStart, "A") = Me.C1DBG.Columns("Front").CellText(i)
            xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("VoySum").CellText(i)
            xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("VoySumTotal").CellText(i)
            xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("Weight").CellText(i)
            xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("WeightTotal").CellText(i)
            xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("Money").CellText(i)
            xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("MoneyTotal").CellText(i)
        Next
        xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("VoySum").FooterText
        xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("VoySumTotal").FooterText
        xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("Weight").FooterText
        xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("WeightTotal").FooterText
        xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("Money").FooterText
        xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("MoneyTotal").FooterText
        If Me.cbDept.SelectedIndex > 0 Then
            xlSheet.Cells(2, "F") = Me.cbDept.Text
        End If
        If changeDeptAgentCargo.dtBeginOld.AddDays(7).Month >= changeDeptAgentCargo.dtEndOld.Month Then
            xlSheet.Cells(3, "G") = changeDeptAgentCargo.dtEndOld.ToString("yyyy年MM月")
        Else
            xlSheet.Cells(3, "G") = changeDeptAgentCargo.dtBeginOld.AddDays(7).ToString("yyyy年MM月") & "—" & changeDeptAgentCargo.dtEndOld.ToString("MM月")
        End If
        xlSheet.Cells(i + rowStart + 1, "A") = "部门经理："
        xlSheet.Cells(i + rowStart + 1, "D") = "统计员："
        xlSheet.Cells(i + rowStart + 1, "G") = "制表时间：" & Now.ToShortDateString()

        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "H")).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub

    Private Sub btnFeeAgent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeeAgent.Click
        OperCheck(changeAgentTotal)
        If blNext Then
            If changeAgentTotal.blChange OrElse IsNothing(dvFeeAgentTotal) Then   '改变统计条件或者是首次做该报表的统计
                Dim blTermMark As Integer
                If Me.tbcStatTerm.SelectedTab Is Me.tbpTime Then
                    blTermMark = 0
                ElseIf Me.tbcStatTerm.SelectedTab Is Me.tbpFileNo Then
                    blTermMark = 1
                Else
                    Exit Sub
                End If
                sqlFeeAgentTotal = "SP_FeeAgentTotal " & blTermMark & ",'" & Me.dtpBegin.Value & "','" & Me.dtpEnd.Value & "','" & Me.txtBeginNo.Text & "','" & Me.txtEndNo.Text & "'"
                dvFeeAgentTotal = Getdata(sqlFeeAgentTotal, dsFeeAgentTotal)
                changeAgentTotal.blChange = False
            End If
            Me.C1DBG.DataSource = dvFeeAgentTotal
            If statClass <> Stats.FeeAgentTotal Then '改变了统计报表
                If statClass <> Stats.Empty Then    '非首次统计操作
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                btnStatLast = Me.btnFeeAgent
                Me.btnFeeAgent.ForeColor = Color.Red
                statClass = Stats.FeeAgentTotal
                'Grid设置
                Me.C1DBG.Caption = Me.btnFeeAgent.Text
                Me.C1DBG.Columns("Front").Caption = "船代"
                Me.C1DBG.Columns("VoySumC").Caption = "件艘次"
                Me.C1DBG.Columns("VoySumTotalC").Caption = "累计"
                Me.C1DBG.Columns("WeightC").Caption = "件吨数"
                Me.C1DBG.Columns("WeightTotalC").Caption = "累计"
                Me.C1DBG.Columns("MoneyC").Caption = "件收入"
                Me.C1DBG.Columns("MoneyTotalC").Caption = "累计"
                Me.C1DBG.Columns("VoySumT").Caption = "集艘次"
                Me.C1DBG.Columns("VoySumTotalT").Caption = "累计"
                Me.C1DBG.Columns("TeuSumT").Caption = "集标箱"
                Me.C1DBG.Columns("TeuSumTotalT").Caption = "累计"
                Me.C1DBG.Columns("WeightT").Caption = "集吨数"
                Me.C1DBG.Columns("WeightTotalT").Caption = "累计"
                Me.C1DBG.Columns("MoneyT").Caption = "集收入"
                Me.C1DBG.Columns("MoneyTotalT").Caption = "累计"
                Me.C1DBG.Columns("EdiT").Caption = "EDI"
                Me.C1DBG.Columns("EdiTotalT").Caption = "累计"
                Me.C1DBG.Columns("VoySumTotal").Caption = "艘次累计"
                Me.C1DBG.Columns("MoneyTotal").Caption = "收入累计"
                Me.C1DBG.Splits(0).DisplayColumns("Code").Visible = False
            End If
            SetDGWidth(Me.C1DBG, 4)
            'Grid单列统计
            Me.C1DBG.Columns("VoySumC").FooterText = GetDataSum(dvFeeAgentTotal, "VoySumC")
            Me.C1DBG.Columns("VoySumTotalC").FooterText = GetDataSum(dvFeeAgentTotal, "VoySumTotalC")
            Me.C1DBG.Columns("WeightC").FooterText = GetDataSum(dvFeeAgentTotal, "WeightC")
            Me.C1DBG.Columns("WeightTotalC").FooterText = GetDataSum(dvFeeAgentTotal, "WeightTotalC")
            Me.C1DBG.Columns("MoneyC").FooterText = GetDataSum(dvFeeAgentTotal, "MoneyC")
            Me.C1DBG.Columns("MoneyTotalC").FooterText = GetDataSum(dvFeeAgentTotal, "MoneyTotalC")
            Me.C1DBG.Columns("VoySumT").FooterText = GetDataSum(dvFeeAgentTotal, "VoySumT")
            Me.C1DBG.Columns("VoySumTotalT").FooterText = GetDataSum(dvFeeAgentTotal, "VoySumTotalT")
            Me.C1DBG.Columns("TeuSumT").FooterText = GetDataSum(dvFeeAgentTotal, "TeuSumT")
            Me.C1DBG.Columns("TeuSumTotalT").FooterText = GetDataSum(dvFeeAgentTotal, "TeuSumTotalT")
            Me.C1DBG.Columns("WeightT").FooterText = GetDataSum(dvFeeAgentTotal, "WeightT")
            Me.C1DBG.Columns("WeightTotalT").FooterText = GetDataSum(dvFeeAgentTotal, "WeightTotalT")
            Me.C1DBG.Columns("MoneyT").FooterText = GetDataSum(dvFeeAgentTotal, "MoneyT")
            Me.C1DBG.Columns("MoneyTotalT").FooterText = GetDataSum(dvFeeAgentTotal, "MoneyTotalT")
            Me.C1DBG.Columns("EdiT").FooterText = GetDataSum(dvFeeAgentTotal, "EdiT")
            Me.C1DBG.Columns("EdiTotalT").FooterText = GetDataSum(dvFeeAgentTotal, "EdiTotalT")
            Me.C1DBG.Columns("VoySumTotal").FooterText = GetDataSum(dvFeeAgentTotal, "VoySumTotal")
            Me.C1DBG.Columns("MoneyTotal").FooterText = GetDataSum(dvFeeAgentTotal, "MoneyTotal")
            Me.C1DBG.Columns("Front").FooterText = "合计" & dvFeeAgentTotal.Count & "家"
            dvFeeAgentTotal.Sort = "Front"
            Me.C1DBG.FilterBar = False
        End If
    End Sub

    Private Sub DealFeeAgentTotal(ByVal xlApp As Excel.ApplicationClass)
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Dim i, j As Integer
        PathStr = substr(PathStr)
        Dim strExcelName As String = "FeeAgentTotal.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "分船代理货统计"
        xlBook = xlApp.Workbooks.Add(strPath)
        'xlSheet=(Excel.Worksheet)xlBook.Worksheets(strSheetName)
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        Dim rowStart As Integer = 7 'Excel中循环起始行位置
        For i = 0 To dvFeeAgentTotal.Count - 1
            xlSheet.Cells(i + rowStart, "A") = i + 1
            xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("Front").CellText(i)
            xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("VoySumC").CellText(i)
            xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("VoySumTotalC").CellText(i)
            xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("WeightC").CellText(i)
            xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("WeightTotalC").CellText(i)
            xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("MoneyC").CellText(i)
            xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("MoneyTotalC").CellText(i)

            xlSheet.Cells(i + rowStart, "I") = Me.C1DBG.Columns("VoySumT").CellText(i)
            xlSheet.Cells(i + rowStart, "J") = Me.C1DBG.Columns("VoySumTotalT").CellText(i)
            xlSheet.Cells(i + rowStart, "K") = Me.C1DBG.Columns("TeuSumT").CellText(i)
            xlSheet.Cells(i + rowStart, "L") = Me.C1DBG.Columns("TeuSumTotalT").CellText(i)
            xlSheet.Cells(i + rowStart, "M") = Me.C1DBG.Columns("WeightT").CellText(i)
            xlSheet.Cells(i + rowStart, "N") = Me.C1DBG.Columns("WeightTotalT").CellText(i)
            xlSheet.Cells(i + rowStart, "O") = Me.C1DBG.Columns("MoneyT").CellText(i)
            xlSheet.Cells(i + rowStart, "P") = Me.C1DBG.Columns("MoneyTotalT").CellText(i)
            xlSheet.Cells(i + rowStart, "Q") = Me.C1DBG.Columns("EdiT").CellText(i)
            xlSheet.Cells(i + rowStart, "R") = Me.C1DBG.Columns("EdiTotalT").CellText(i)
            xlSheet.Cells(i + rowStart, "S") = Me.C1DBG.Columns("MoneyTotal").CellText(i)
        Next
        xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("VoySumC").FooterText
        xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("VoySumTotalC").FooterText
        xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("WeightC").FooterText
        xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("WeightTotalC").FooterText
        xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("MoneyC").FooterText
        xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("MoneyTotalC").FooterText

        xlSheet.Cells(i + rowStart, "I") = Me.C1DBG.Columns("VoySumT").FooterText
        xlSheet.Cells(i + rowStart, "J") = Me.C1DBG.Columns("VoySumTotalT").FooterText
        xlSheet.Cells(i + rowStart, "K") = Me.C1DBG.Columns("TeuSumT").FooterText
        xlSheet.Cells(i + rowStart, "L") = Me.C1DBG.Columns("TeuSumTotalT").FooterText
        xlSheet.Cells(i + rowStart, "M") = Me.C1DBG.Columns("WeightT").FooterText
        xlSheet.Cells(i + rowStart, "N") = Me.C1DBG.Columns("WeightTotalT").FooterText
        xlSheet.Cells(i + rowStart, "O") = Me.C1DBG.Columns("MoneyT").FooterText
        xlSheet.Cells(i + rowStart, "P") = Me.C1DBG.Columns("MoneyTotalT").FooterText
        xlSheet.Cells(i + rowStart, "Q") = Me.C1DBG.Columns("EdiT").FooterText
        xlSheet.Cells(i + rowStart, "R") = Me.C1DBG.Columns("EdiTotalT").FooterText
        xlSheet.Cells(i + rowStart, "S") = Me.C1DBG.Columns("MoneyTotal").FooterText

        xlSheet.Range(xlSheet.Cells(i + rowStart, "A"), xlSheet.Cells(i + rowStart, "B")).Merge()
        xlSheet.Range(xlSheet.Cells(i + rowStart, "A"), xlSheet.Cells(i + rowStart, "B")).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xlSheet.Cells(i + rowStart, "A") = "合计"

        Dim strStatDate As String   '统计年月
        If changeAgentTotal.strStatTermOld = Me.tbpTime.Name Then
            If changeAgentTotal.dtBeginOld.AddDays(7).Month >= changeAgentTotal.dtEndOld.Month Then
                strStatDate = changeAgentTotal.dtEndOld.ToString("yyyy年MM月")
            Else
                strStatDate = changeAgentTotal.dtBeginOld.AddDays(7).ToString("yyyy年MM月") & "—" & changeAgentTotal.dtEndOld.ToString("MM月")
            End If
        Else
            strStatDate = GetFileNoDate(changeAgentTotal)
        End If
        xlSheet.Cells(3, "J") = strStatDate

        xlSheet.Cells(3, "Q") = Now.ToShortDateString()
        'xlSheet.Cells(i + rowStart + 1, "A") = "部门经理："
        'xlSheet.Cells(i + rowStart + 1, "D") = "统计员："

        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart, "S")).Borders.LineStyle = Excel.XlLineStyle.xlContinuous

    End Sub

    Private Sub btnFeeAgentEdi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeeAgentEdi.Click
        OperCheck(changeAgentEdi)
        If blNext Then
            If changeAgentEdi.blChange OrElse IsNothing(dvFeeAgentEdi) Then   '改变统计条件或者是首次做该报表的统计
                Dim blTermMark As Integer
                If Me.tbcStatTerm.SelectedTab Is Me.tbpTime Then
                    blTermMark = 0
                ElseIf Me.tbcStatTerm.SelectedTab Is Me.tbpFileNo Then
                    blTermMark = 1
                Else
                    Exit Sub
                End If
                sqlFeeAgentEdi = "SP_FeeAgentEdi " & blTermMark & ",'" & Me.dtpBegin.Value & "','" & Me.dtpEnd.Value & "','" & Me.txtBeginNo.Text & "','" & Me.txtEndNo.Text & "'"
                dvFeeAgentEdi = Getdata(sqlFeeAgentEdi, dsFeeAgentEdi)
                changeAgentEdi.blChange = False
            End If
            Me.C1DBG.DataSource = dvFeeAgentEdi
            If statClass <> Stats.FeeAgentEdi Then  '改变了统计报表
                If statClass <> Stats.Empty Then    '非首次统计操作
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                btnStatLast = Me.btnFeeAgentEdi
                Me.btnFeeAgentEdi.ForeColor = Color.Red
                statClass = Stats.FeeAgentEdi
                'Grid设置
                Me.C1DBG.Caption = Me.btnFeeAgentEdi.Text
                Me.C1DBG.Columns("SHIPAGENT_SHORT").Caption = "船代名称"
                Me.C1DBG.Columns("VoySum").Caption = "艘次"
                Me.C1DBG.Columns("VoySumTotal").Caption = "累计艘次"
                Me.C1DBG.Columns("TeuSum").Caption = "标箱"
                Me.C1DBG.Columns("TeuSumTotal").Caption = "累计标箱"
                Me.C1DBG.Columns("Edi").Caption = "收入"
                Me.C1DBG.Columns("EdiTotal").Caption = "收入累计"
                Me.C1DBG.Splits(0).DisplayColumns("Agent").Visible = False
            End If
            SetDGWidth(Me.C1DBG, 4)
            'Grid单列统计
            Me.C1DBG.Columns("VoySum").FooterText = GetDataSum(dvFeeAgentEdi, "VoySum")
            Me.C1DBG.Columns("VoySumTotal").FooterText = GetDataSum(dvFeeAgentEdi, "VoySumTotal")
            Me.C1DBG.Columns("TeuSum").FooterText = GetDataSum(dvFeeAgentEdi, "TeuSum")
            Me.C1DBG.Columns("TeuSumTotal").FooterText = GetDataSum(dvFeeAgentEdi, "TeuSumTotal")
            Me.C1DBG.Columns("Edi").FooterText = GetDataSum(dvFeeAgentEdi, "Edi")
            Me.C1DBG.Columns("EdiTotal").FooterText = GetDataSum(dvFeeAgentEdi, "EdiTotal")
            Me.C1DBG.Columns("SHIPAGENT_SHORT").FooterText = "合计" & dvFeeAgentEdi.Count & "家"
            Me.C1DBG.FilterBar = False
        End If
    End Sub

    Private Sub DealFeeAgentEdi(ByVal xlApp As Excel.ApplicationClass)
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Dim i, j As Integer
        PathStr = substr(PathStr)
        Dim strExcelName As String = "FeeAgentEdi.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "分船代Edi费统计"
        xlBook = xlApp.Workbooks.Add(strPath)
        'xlSheet=(Excel.Worksheet)xlBook.Worksheets(strSheetName)
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        Dim rowStart As Integer = 7 'Excel中循环起始行位置
        For i = 0 To dvFeeAgentEdi.Count - 1
            xlSheet.Cells(i + rowStart, "A") = i + 1
            xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("SHIPAGENT_SHORT").CellText(i)
            xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("VoySum").CellText(i)
            xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("VoySumTotal").CellText(i)
            xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("TeuSum").CellText(i)
            xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("TeuSumTotal").CellText(i)
            xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("Edi").CellText(i)
            xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("EdiTotal").CellText(i)
        Next
        xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("VoySum").FooterText
        xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("VoySumTotal").FooterText
        xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("TeuSum").FooterText
        xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("TeuSumTotal").FooterText
        xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("Edi").FooterText
        xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("EdiTotal").FooterText
        xlSheet.Range(xlSheet.Cells(i + rowStart, "A"), xlSheet.Cells(i + rowStart, "B")).Merge()
        xlSheet.Range(xlSheet.Cells(i + rowStart, "A"), xlSheet.Cells(i + rowStart, "A")).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xlSheet.Cells(i + rowStart, "A") = "合计"

        If changeAgentEdi.strStatTermOld = Me.tbpTime.Name Then
            If changeAgentEdi.dtBeginOld.AddDays(7).Month >= changeAgentEdi.dtEndOld.Month Then
                xlSheet.Cells(3, "D") = changeAgentEdi.dtEndOld.ToString("yyyy年MM月")
            Else
                xlSheet.Cells(3, "D") = changeAgentEdi.dtBeginOld.AddDays(7).ToString("yyyy年MM月") & "—" & changeAgentEdi.dtEndOld.ToString("MM月")
            End If
        Else
            xlSheet.Cells(3, "D") = GetFileNoDate(changeAgentEdi)
        End If
        xlSheet.Cells(3, "H") = Now.ToShortDateString()
        xlSheet.Cells(i + rowStart + 1, "B") = "统计："
        xlSheet.Cells(i + rowStart + 1, "F") = "复核："
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "B"), xlSheet.Cells(i + rowStart + 1, "B")).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "F"), xlSheet.Cells(i + rowStart + 1, "F")).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart, "I")).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub

    Private Sub btnFeeProduce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeeProduce.Click
        OperCheck(changeProduce)
        If blNext Then
            If changeProduce.blChange OrElse IsNothing(dvFeeProduce) Then   '改变统计条件或者是首次做该报表的统计
                sqlFeeProduce = "SP_FeeProduce '" & Me.dtpBegin.Value & "','" & Me.dtpEnd.Value & "'"
                dvFeeProduce = Getdata(sqlFeeProduce, dsFeeProduce)
                changeProduce.blChange = False
            End If
            Me.C1DBG.DataSource = dvFeeProduce
            If statClass <> Stats.FeeProduce Then  '改变了统计报表
                If statClass <> Stats.Empty Then    '非首次统计操作
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                btnStatLast = Me.btnFeeProduce
                Me.btnFeeProduce.ForeColor = Color.Red
                statClass = Stats.FeeProduce
                'Grid设置
                Me.C1DBG.Caption = Me.btnFeeProduce.Text
                Me.C1DBG.Columns("Front").Caption = "项目"
                Me.C1DBG.Columns("Lian").Caption = "连云本月"
                Me.C1DBG.Columns("LianTotal").Caption = "连云累计"
                Me.C1DBG.Columns("Miao").Caption = "庙岭本月"
                Me.C1DBG.Columns("MiaoTotal").Caption = "庙岭累计"
                Me.C1DBG.Columns("Comp").Caption = "公司本月"
                Me.C1DBG.Columns("CompTotal").Caption = "公司累计"
                Me.C1DBG.Columns("LastSum").Caption = "去年本月"
                Me.C1DBG.Columns("LastSumTotal").Caption = "去年累计"
                Me.C1DBG.Columns("IncreaseRate").Caption = "同比增幅"
                Me.C1DBG.Columns("IncreaseRateTotal").Caption = "累比增幅"
                Me.C1DBG.Splits(0).DisplayColumns("Code").Visible = False
                Me.C1DBG.Columns("IncreaseRate").NumberFormat = "Percent"
                Me.C1DBG.Columns("IncreaseRateTotal").NumberFormat = "Percent"
            End If
            SetDGWidth(Me.C1DBG, 4)
            Me.C1DBG.FilterBar = False
        End If
    End Sub

    Private Sub DealFeeProduce(ByVal xlApp As Excel.ApplicationClass)
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Dim i, j As Integer
        PathStr = substr(PathStr)
        Dim strExcelName As String = "FeeProduce.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "生产情况统计表一"
        xlBook = xlApp.Workbooks.Add(strPath)
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        dvFeeProduce.Sort = ""
        Dim rowStart As Integer = 6 'Excel中循环起始行位置
        j = 0
        For i = 0 To 12 - 1
            If i <> 5 Then
                xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("Lian").CellText(j)
                xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("lianTotal").CellText(j)
                xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("Miao").CellText(j)
                xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("MiaoTotal").CellText(j)
                xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("Comp").CellText(j)
                xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("CompTotal").CellText(j)
                j += 1
            Else    '件数合计等于件货件数
                xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("Lian").CellText(3)
                xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("lianTotal").CellText(3)
                xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("Miao").CellText(3)
                xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("MiaoTotal").CellText(3)
                xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("Comp").CellText(3)
                xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("CompTotal").CellText(3)
            End If
        Next
        xlSheet.Cells(19, "C") = Decimal.Round(Me.C1DBG.Columns("LastSum").CellValue(7) / 10000, 2)
        xlSheet.Cells(19, "D") = Decimal.Round(Me.C1DBG.Columns("LastSum").CellValue(10) / 10000, 2)
        xlSheet.Cells(19, "E") = Me.C1DBG.Columns("LastSum").CellValue(4)
        xlSheet.Cells(19, "F") = Me.C1DBG.Columns("LastSum").CellValue(2)
        xlSheet.Cells(22, "C") = Decimal.Round(Me.C1DBG.Columns("LastSumTotal").CellValue(7) / 10000, 2)
        xlSheet.Cells(22, "D") = Decimal.Round(Me.C1DBG.Columns("LastSumTotal").CellValue(10) / 10000, 2)
        xlSheet.Cells(22, "E") = Me.C1DBG.Columns("LastSumTotal").CellValue(4)
        xlSheet.Cells(22, "F") = Me.C1DBG.Columns("LastSumTotal").CellValue(2)

        xlSheet.Cells(1, "A") = changeProduce.dtBeginOld.AddDays(7).ToString("yyyy年MM月")
        xlSheet.Cells(19, "A") = changeProduce.dtBeginOld.AddDays(7).AddYears(-1).ToString("yyyy年MM月")
        xlSheet.Cells(20, "A") = changeProduce.dtBeginOld.AddMonths(7).ToString("yyyy年MM月")
        xlSheet.Cells(22, "A") = changeProduce.dtBeginOld.AddDays(7).AddYears(-1).ToString("yyyy年01-MM月")
        xlSheet.Cells(23, "A") = changeProduce.dtBeginOld.AddDays(7).ToString("yyyy年01-MM月")
        xlSheet.Cells(26, "B") = Now.ToShortDateString()
        xlSheet.Cells(26, "G") = G_User
    End Sub

    Private Sub btnStatConVoyage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatConVoyage.Click
        OperCheck(changeConVoyage)
        If blNext Then
            If changeConVoyage.blChange OrElse IsNothing(dvStatConVoyage) Then   '改变统计条件或者是首次做该报表的统计
                Dim strDept As String
                strDept = Me.cbDept.SelectedValue
                If strDept = "00" Then
                    strDept = ""
                Else
                    strDept = " and DEPT_CODE='" & strDept & "'"
                End If
                sqlStatConVoyage = "SELECT SHIP_ID,CHI_VESSEL, VOYAGE, InOutName, Full20, Full40, Full45, Empty20,Empty40, Empty45, ConSum, TeuSum, Weight,SHIPAGENT_SHORT,SHIPOWNER_SHORT,WORKTIME_END FROM View_StatConVoyage where WORKTIME_END>='" & Me.dtpBegin.Value & "' and WORKTIME_END<'" & Me.dtpEnd.Value & "' " & strDept & " order by SHIP_ID"
                dvStatConVoyage = Getdata(sqlStatConVoyage, dsStatConVoyage)
                changeConVoyage.blChange = False
            End If
            Me.C1DBG.DataSource = dvStatConVoyage
            If statClass <> Stats.StatConVoyage Then '改变了统计报表
                If statClass <> Stats.Empty Then    '非首次统计操作
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                btnStatLast = Me.btnStatConVoyage
                Me.btnStatConVoyage.ForeColor = Color.Red
                statClass = Stats.StatConVoyage
                'Grid设置
                Me.C1DBG.Caption = Me.btnStatConVoyage.Text
                Me.C1DBG.Columns("CHI_VESSEL").Caption = "船名"
                Me.C1DBG.Columns("VOYAGE").Caption = "航次"
                Me.C1DBG.Columns("InOutName").Caption = "进/出"
                Me.C1DBG.Columns("Full20").Caption = "重20"
                Me.C1DBG.Columns("Full40").Caption = "重40"
                Me.C1DBG.Columns("Full45").Caption = "重45"
                Me.C1DBG.Columns("Empty20").Caption = "空20"
                Me.C1DBG.Columns("Empty40").Caption = "空40"
                Me.C1DBG.Columns("Empty45").Caption = "空45"
                Me.C1DBG.Columns("ConSum").Caption = "自然箱"
                Me.C1DBG.Columns("TeuSum").Caption = "标箱"
                Me.C1DBG.Columns("Weight").Caption = "吨数"
                Me.C1DBG.Columns("SHIPAGENT_SHORT").Caption = "船代"
                Me.C1DBG.Columns("SHIPOWNER_SHORT").Caption = "船公司"
                Me.C1DBG.Columns("WORKTIME_END").Caption = "完船日期"
                Me.C1DBG.Splits(0).DisplayColumns("SHIP_ID").Visible = False
                Me.C1DBG.Columns("WORKTIME_END").NumberFormat = "yy年MM月dd日"
            End If
            SetDGWidth(Me.C1DBG, 4)
            'Grid单列统计
            Me.C1DBG.Columns("Full20").FooterText = GetDataSum(dvStatConVoyage, "Full20")
            Me.C1DBG.Columns("Full40").FooterText = GetDataSum(dvStatConVoyage, "Full40")
            Me.C1DBG.Columns("Full45").FooterText = GetDataSum(dvStatConVoyage, "Full45")
            Me.C1DBG.Columns("Empty20").FooterText = GetDataSum(dvStatConVoyage, "Empty20")
            Me.C1DBG.Columns("Empty40").FooterText = GetDataSum(dvStatConVoyage, "Empty40")
            Me.C1DBG.Columns("Empty45").FooterText = GetDataSum(dvStatConVoyage, "Empty45")
            Me.C1DBG.Columns("ConSum").FooterText = GetDataSum(dvStatConVoyage, "ConSum")
            Me.C1DBG.Columns("TeuSum").FooterText = GetDataSum(dvStatConVoyage, "TeuSum")
            Me.C1DBG.Columns("Weight").FooterText = GetDataSum(dvStatConVoyage, "Weight")
            Me.C1DBG.Columns("CHI_VESSEL").FooterText = "合计" & dvStatConVoyage.Count & "艘"
            Me.C1DBG.FilterBar = True
        End If
    End Sub

    Private Sub DealStatConVoyage(ByVal xlApp As Excel.ApplicationClass)
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Dim i, j As Integer
        PathStr = substr(PathStr)
        Dim strExcelName As String = "StatConVoyage.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "集装箱船舶统计"
        xlBook = xlApp.Workbooks.Add(strPath)
        'xlSheet=(Excel.Worksheet)xlBook.Worksheets(strSheetName)
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        Dim rowStart As Integer = 7 'Excel中循环起始行位置
        For i = 0 To dvStatConVoyage.Count - 1
            xlSheet.Cells(i + rowStart, "A") = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
            xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("VOYAGE").CellText(i)
            xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("InOutName").CellText(i)
            xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("Full20").CellText(i)
            xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("Full40").CellText(i)
            xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("Full45").CellText(i)
            xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("Empty20").CellText(i)
            xlSheet.Cells(i + rowStart, "I") = Me.C1DBG.Columns("Empty40").CellText(i)
            xlSheet.Cells(i + rowStart, "J") = Me.C1DBG.Columns("Empty45").CellText(i)
            xlSheet.Cells(i + rowStart, "K") = Me.C1DBG.Columns("ConSum").CellText(i)
            xlSheet.Cells(i + rowStart, "L") = Me.C1DBG.Columns("TeuSum").CellText(i)
            xlSheet.Cells(i + rowStart, "M") = Me.C1DBG.Columns("Weight").CellText(i)
            xlSheet.Cells(i + rowStart, "N") = Me.C1DBG.Columns("SHIPAGENT_SHORT").CellText(i)
            xlSheet.Cells(i + rowStart, "O") = Me.C1DBG.Columns("SHIPOWNER_SHORT").CellText(i)
            xlSheet.Cells(i + rowStart, "P") = Me.C1DBG.Columns("WORKTIME_END").CellText(i)
        Next
        xlSheet.Cells(i + rowStart, "A") = Me.C1DBG.Columns("CHI_VESSEL").FooterText
        xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("Full20").FooterText
        xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("Full40").FooterText
        xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("Full45").FooterText
        xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("Empty20").FooterText
        xlSheet.Cells(i + rowStart, "I") = Me.C1DBG.Columns("Empty40").FooterText
        xlSheet.Cells(i + rowStart, "J") = Me.C1DBG.Columns("Empty45").FooterText
        xlSheet.Cells(i + rowStart, "K") = Me.C1DBG.Columns("ConSum").FooterText
        xlSheet.Cells(i + rowStart, "L") = Me.C1DBG.Columns("TeuSum").FooterText
        xlSheet.Cells(i + rowStart, "M") = Me.C1DBG.Columns("Weight").FooterText
        If Me.cbDept.SelectedIndex > 0 Then
            xlSheet.Cells(2, "A") = Me.cbDept.Text
        End If
        If changeConVoyage.dtBeginOld.AddDays(7).Month >= changeConVoyage.dtEndOld.Month Then
            xlSheet.Cells(3, "N") = changeConVoyage.dtEndOld.ToString("yyyy年MM月")
        Else
            xlSheet.Cells(3, "N") = changeConVoyage.dtBeginOld.AddDays(7).ToString("yyyy年MM月") & "—" & changeConVoyage.dtEndOld.ToString("MM月")
        End If
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "A"), xlSheet.Cells(i + rowStart + 1, "B")).Merge()
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "C"), xlSheet.Cells(i + rowStart + 1, "D")).Merge()
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "G"), xlSheet.Cells(i + rowStart + 1, "H")).Merge()
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "I"), xlSheet.Cells(i + rowStart + 1, "J")).Merge()
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "N"), xlSheet.Cells(i + rowStart + 1, "O")).Merge()
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "A"), xlSheet.Cells(i + rowStart + 1, "A")).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "G"), xlSheet.Cells(i + rowStart + 1, "G")).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "C"), xlSheet.Cells(i + rowStart + 1, "C")).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "I"), xlSheet.Cells(i + rowStart + 1, "I")).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        xlSheet.Cells(i + rowStart + 1, "A") = "部门经理："
        xlSheet.Cells(i + rowStart + 1, "G") = "统计员："
        xlSheet.Cells(i + rowStart + 1, "N") = "制表时间：" & Now.ToShortDateString()

        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "P")).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub

    Private Sub btnStatConRentVoyage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatConRentVoyage.Click
        OperCheck(changeConRentVoyage)
        If blNext Then
            If changeConRentVoyage.blChange OrElse IsNothing(dvStatConRentVoyage) Then   '改变统计条件或者是首次做该报表的统计
                Dim strDept As String
                strDept = Me.cbDept.SelectedValue
                If strDept = "00" Then
                    strDept = ""
                Else
                    strDept = " and DEPT_CODE='" & strDept & "'"
                End If
                sqlStatConRentVoyage = "SELECT SHIP_ID,SHIPAGENT_SHORT,CHI_VESSEL, VOYAGE, InOutName,RentShipAgent,Full20, Full40, Full45, Empty20,Empty40, Empty45, ConSum,TeuSum,WORKTIME_END FROM View_StatConRentVoyage where WORKTIME_END>='" & Me.dtpBegin.Value & "' and WORKTIME_END<'" & Me.dtpEnd.Value & "' " & strDept & " order by SHIPAGENT_SHORT,SHIP_ID,RentShipAgent"
                dvStatConRentVoyage = Getdata(sqlStatConRentVoyage, dsStatConRentVoyage)
                changeConRentVoyage.blChange = False
            End If
            Me.C1DBG.DataSource = dvStatConRentVoyage
            If statClass <> Stats.StatConRentVoyage Then '改变了统计报表
                If statClass <> Stats.Empty Then    '非首次统计操作
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                btnStatLast = Me.btnStatConRentVoyage
                Me.btnStatConRentVoyage.ForeColor = Color.Red
                statClass = Stats.StatConRentVoyage
                'Grid设置
                Me.C1DBG.Caption = Me.btnStatConRentVoyage.Text
                Me.C1DBG.Columns("SHIPAGENT_SHORT").Caption = "船代"
                Me.C1DBG.Columns("CHI_VESSEL").Caption = "船名"
                Me.C1DBG.Columns("VOYAGE").Caption = "航次"
                Me.C1DBG.Columns("InOutName").Caption = "进/出"
                Me.C1DBG.Columns("RentShipAgent").Caption = "互租单位"
                Me.C1DBG.Columns("Full20").Caption = "重20"
                Me.C1DBG.Columns("Full40").Caption = "重40"
                Me.C1DBG.Columns("Full45").Caption = "重45"
                Me.C1DBG.Columns("Empty20").Caption = "空20"
                Me.C1DBG.Columns("Empty40").Caption = "空40"
                Me.C1DBG.Columns("Empty45").Caption = "空45"
                Me.C1DBG.Columns("ConSum").Caption = "自然箱"
                Me.C1DBG.Columns("TeuSum").Caption = "标箱"
                Me.C1DBG.Columns("WORKTIME_END").Caption = "完船日期"
                Me.C1DBG.Splits(0).DisplayColumns("SHIP_ID").Visible = False
                Me.C1DBG.Columns("WORKTIME_END").NumberFormat = "yy年MM月dd日"
            End If
            SetDGWidth(Me.C1DBG, 4)
            'Grid单列统计
            Me.C1DBG.Columns("Full20").FooterText = GetDataSum(dvStatConRentVoyage, "Full20")
            Me.C1DBG.Columns("Full40").FooterText = GetDataSum(dvStatConRentVoyage, "Full40")
            Me.C1DBG.Columns("Full45").FooterText = GetDataSum(dvStatConRentVoyage, "Full45")
            Me.C1DBG.Columns("Empty20").FooterText = GetDataSum(dvStatConRentVoyage, "Empty20")
            Me.C1DBG.Columns("Empty40").FooterText = GetDataSum(dvStatConRentVoyage, "Empty40")
            Me.C1DBG.Columns("Empty45").FooterText = GetDataSum(dvStatConRentVoyage, "Empty45")
            Me.C1DBG.Columns("ConSum").FooterText = GetDataSum(dvStatConRentVoyage, "ConSum")
            Me.C1DBG.Columns("TeuSum").FooterText = GetDataSum(dvStatConRentVoyage, "TeuSum")
            Me.C1DBG.Columns("SHIPAGENT_SHORT").FooterText = "合计" & dvStatConRentVoyage.Count & "项"
            Me.C1DBG.FilterBar = False
        End If
    End Sub

    Private Sub DealStatConRentVoyage(ByVal xlApp As Excel.ApplicationClass)
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Dim i, j As Integer
        PathStr = substr(PathStr)
        Dim strExcelName As String = "StatConRentVoyage.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "租箱船舶统计"
        xlBook = xlApp.Workbooks.Add(strPath)
        'xlSheet=(Excel.Worksheet)xlBook.Worksheets(strSheetName)
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        Dim rowStart As Integer = 7 'Excel中循环起始行位置
        For i = 0 To dvStatConRentVoyage.Count - 1
            xlSheet.Cells(i + rowStart, "A") = Me.C1DBG.Columns("SHIPAGENT_SHORT").CellText(i)
            xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
            xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("VOYAGE").CellText(i)
            xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("InOutName").CellText(i)
            xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("RentShipAgent").CellText(i)
            xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("Full20").CellText(i)
            xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("Full40").CellText(i)
            xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("Full45").CellText(i)
            xlSheet.Cells(i + rowStart, "I") = Me.C1DBG.Columns("Empty20").CellText(i)
            xlSheet.Cells(i + rowStart, "J") = Me.C1DBG.Columns("Empty40").CellText(i)
            xlSheet.Cells(i + rowStart, "K") = Me.C1DBG.Columns("Empty45").CellText(i)
            xlSheet.Cells(i + rowStart, "L") = Me.C1DBG.Columns("ConSum").CellText(i)
            xlSheet.Cells(i + rowStart, "M") = Me.C1DBG.Columns("TeuSum").CellText(i)
        Next
        xlSheet.Cells(i + rowStart, "A") = Me.C1DBG.Columns("SHIPAGENT_SHORT").FooterText
        xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("Full20").FooterText
        xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("Full40").FooterText
        xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("Full45").FooterText
        xlSheet.Cells(i + rowStart, "I") = Me.C1DBG.Columns("Empty20").FooterText
        xlSheet.Cells(i + rowStart, "J") = Me.C1DBG.Columns("Empty40").FooterText
        xlSheet.Cells(i + rowStart, "K") = Me.C1DBG.Columns("Empty45").FooterText
        xlSheet.Cells(i + rowStart, "L") = Me.C1DBG.Columns("ConSum").FooterText
        xlSheet.Cells(i + rowStart, "M") = Me.C1DBG.Columns("TeuSum").FooterText
        If Me.cbDept.SelectedIndex > 0 Then
            xlSheet.Cells(2, "A") = Me.cbDept.Text
        End If
        If changeConRentVoyage.dtBeginOld.AddDays(7).Month >= changeConRentVoyage.dtEndOld.Month Then
            xlSheet.Cells(3, "J") = changeConRentVoyage.dtEndOld.ToString("yyyy年MM月")
        Else
            xlSheet.Cells(3, "J") = changeConRentVoyage.dtBeginOld.AddDays(7).ToString("yyyy年MM月") & "—" & changeConRentVoyage.dtEndOld.ToString("MM月")
        End If
        xlSheet.Cells(i + rowStart + 1, "A") = "部门经理："
        xlSheet.Cells(i + rowStart + 1, "E") = "统计员："
        xlSheet.Cells(i + rowStart + 1, "J") = "制表时间：" & Now.ToShortDateString()

        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "M")).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub

    Private Sub btnStatConRentAgent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatConRentAgent.Click
        OperCheck(changeConRentAgent)
        If blNext Then
            If changeConRentAgent.blChange OrElse IsNothing(dvStatConRentAgent) Then   '改变统计条件或者是首次做该报表的统计
                Dim strDept As String
                strDept = Me.cbDept.SelectedValue
                If strDept = "00" Then
                    strDept = "0"
                End If
                sqlStatConRentAgent = "SP_StatConRentAgent '" & Me.dtpBegin.Value & "','" & Me.dtpEnd.Value & "','" & strDept & "'"
                dvStatConRentAgent = Getdata(sqlStatConRentAgent, dsStatConRentAgent)
                changeConRentAgent.blChange = False
            End If
            Me.C1DBG.DataSource = dvStatConRentAgent
            If statClass <> Stats.StatConRentAgent Then '改变了统计报表
                If statClass <> Stats.Empty Then    '非首次统计操作
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                btnStatLast = Me.btnStatConRentAgent
                Me.btnStatConRentAgent.ForeColor = Color.Red
                statClass = Stats.StatConRentAgent
                'Grid设置
                Me.C1DBG.Caption = Me.btnStatConRentAgent.Text
                Me.C1DBG.Columns("SHIPAGENT_SHORT").Caption = "船代"
                Me.C1DBG.Columns("RentShipAgent").Caption = "互租单位"
                Me.C1DBG.Columns("ConSum").Caption = "自然箱"
                Me.C1DBG.Columns("ConSumTotal").Caption = "累计箱数"
                Me.C1DBG.Columns("TeuSum").Caption = "标箱"
                Me.C1DBG.Columns("TeuSumTotal").Caption = "累计标箱"
                Me.C1DBG.Splits(0).DisplayColumns("AGENT").Visible = False
                Me.C1DBG.Splits(0).DisplayColumns("Code_Ship_Agent").Visible = False
                Me.C1DBG.Splits(0).DisplayColumns("Weight").Visible = False
                Me.C1DBG.Splits(0).DisplayColumns("WeightTotal").Visible = False
            End If
            SetDGWidth(Me.C1DBG, 4)
            'Grid单列统计
            Me.C1DBG.Columns("ConSum").FooterText = GetDataSum(dvStatConRentAgent, "ConSum")
            Me.C1DBG.Columns("ConSumTotal").FooterText = GetDataSum(dvStatConRentAgent, "ConSumTotal")
            Me.C1DBG.Columns("TeuSum").FooterText = GetDataSum(dvStatConRentAgent, "TeuSum")
            Me.C1DBG.Columns("TeuSumTotal").FooterText = GetDataSum(dvStatConRentAgent, "TeuSumTotal")
            Me.C1DBG.Columns("SHIPAGENT_SHORT").FooterText = "合计" & dvStatConRentAgent.Count & "项"
            Me.C1DBG.FilterBar = False
        End If
    End Sub

    Private Sub DealStatConRentAgent(ByVal xlApp As Excel.ApplicationClass)
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Dim i, j As Integer
        PathStr = substr(PathStr)
        Dim strExcelName As String = "StatConRentAgent.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "租箱船代统计"
        xlBook = xlApp.Workbooks.Add(strPath)
        'xlSheet=(Excel.Worksheet)xlBook.Worksheets(strSheetName)
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        Dim rowStart As Integer = 7 'Excel中循环起始行位置
        For i = 0 To dvStatConRentAgent.Count - 1
            xlSheet.Cells(i + rowStart, "A") = Me.C1DBG.Columns("SHIPAGENT_SHORT").CellText(i)
            xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("RentShipAgent").CellText(i)
            xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("ConSum").CellText(i)
            xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("ConSumTotal").CellText(i)
            xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("TeuSum").CellText(i)
            xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("TeuSumTotal").CellText(i)
        Next
        xlSheet.Cells(i + rowStart, "A") = Me.C1DBG.Columns("SHIPAGENT_SHORT").FooterText
        xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("ConSum").FooterText
        xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("ConSumTotal").FooterText
        xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("TeuSum").FooterText
        xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("TeuSumTotal").FooterText
        If Me.cbDept.SelectedIndex > 0 Then
            xlSheet.Cells(2, "E") = Me.cbDept.Text
        End If
        If changeConRentAgent.dtBeginOld.AddDays(7).Month >= changeConRentAgent.dtEndOld.Month Then
            xlSheet.Cells(3, "F") = changeConRentAgent.dtEndOld.ToString("yyyy年MM月")
        Else
            xlSheet.Cells(3, "F") = changeConRentAgent.dtBeginOld.AddDays(7).ToString("yyyy年MM月") & "—" & changeConRentAgent.dtEndOld.ToString("MM月")
        End If
        xlSheet.Cells(i + rowStart + 1, "A") = "部门经理："
        xlSheet.Cells(i + rowStart + 1, "C") = "统计员："
        xlSheet.Cells(i + rowStart + 1, "F") = "制表时间：" & Now.ToShortDateString()

        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "G")).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub

    Private Sub tbcStatTerm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcStatTerm.SelectedIndexChanged
        If Me.tbcStatTerm.SelectedTab Is Me.tbpTime Then
            Me.gbDeptCargo.Enabled = True
            Me.gbDeptCon.Enabled = True
            Me.btnFeeAgent.Enabled = True
        ElseIf Me.tbcStatTerm.SelectedTab Is Me.tbpFileNo Then
            Me.gbDeptCargo.Enabled = False
            Me.gbDeptCon.Enabled = False
            Me.btnFeeAgent.Enabled = False
        Else
            Exit Sub
        End If
    End Sub

    Private Sub FrmAccountStat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.dtpBegin.Focused Then
                Me.dtpEnd.Focus()
            ElseIf Me.txtBeginNo.Focused Then
                Me.txtEndNo.Focus()
            End If
        End If
    End Sub

    Private Sub C1DBG_AfterFilter(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs) Handles C1DBG.AfterFilter
        Select Case statClass
            Case Stats.FeeVoyageCargo

            Case Stats.FeeVoyageCon

            Case Stats.FeeAgentTotal

            Case Stats.FeeAgentEdi

            Case Stats.FeeProduce

            Case Stats.FeeDeptAgentCargo

            Case Stats.FeeDeptAgentCon

            Case Stats.StatConVoyage
                Me.C1DBG.Columns("Full20").FooterText = GetDataSum(dvStatConVoyage, "Full20")
                Me.C1DBG.Columns("Full40").FooterText = GetDataSum(dvStatConVoyage, "Full40")
                Me.C1DBG.Columns("Full45").FooterText = GetDataSum(dvStatConVoyage, "Full45")
                Me.C1DBG.Columns("Empty20").FooterText = GetDataSum(dvStatConVoyage, "Empty20")
                Me.C1DBG.Columns("Empty40").FooterText = GetDataSum(dvStatConVoyage, "Empty40")
                Me.C1DBG.Columns("Empty45").FooterText = GetDataSum(dvStatConVoyage, "Empty45")
                Me.C1DBG.Columns("ConSum").FooterText = GetDataSum(dvStatConVoyage, "ConSum")
                Me.C1DBG.Columns("TeuSum").FooterText = GetDataSum(dvStatConVoyage, "TeuSum")
                Me.C1DBG.Columns("Weight").FooterText = GetDataSum(dvStatConVoyage, "Weight")
                Me.C1DBG.Columns("CHI_VESSEL").FooterText = "合计" & dvStatConVoyage.Count & "艘"
            Case Stats.StatConRentVoyage

            Case Stats.StatConRentAgent

            Case Stats.StatCargoVoyage
            Case Stats.StatCargoClass
            Case Stats.StatCargoGoods
            Case Stats.StatCargoVoyGoods
                Me.C1DBG.Columns("Amount").FooterText = GetDataSum(dvStatCargoVoyGoods, "Amount")
                Me.C1DBG.Columns("Tons").FooterText = GetDataSum(dvStatCargoVoyGoods, "Tons")
                Me.C1DBG.Columns("CHI_VESSEL").FooterText = "合计" & dvStatCargoVoyGoods.Count & "项"
            Case Stats.Empty
            Case Else
        End Select
    End Sub

    Private Sub txtBeginNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBeginNo.Leave
        Me.txtBeginNo.Text = Me.txtBeginNo.Text.Trim
    End Sub

    Private Sub txtEndNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEndNo.Leave
        Me.txtEndNo.Text = Me.txtEndNo.Text.Trim
    End Sub

    Private Sub btnStatCargoVoyage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatCargoVoyage.Click
        OperCheck(changeCargoVoyage)
        If blNext Then
            If changeCargoVoyage.blChange OrElse IsNothing(dvStatCargoVoyage) Then   '改变统计条件或者是首次做该报表的统计
                Dim strDept As String
                strDept = Me.cbDept.SelectedValue
                If strDept = "00" Then
                    strDept = ""
                Else
                    strDept = " and DEPT_CODE='" & strDept & "'"
                End If
                sqlStatCargoVoyage = "SELECT SHIP_ID,CHI_VESSEL,VOYAGE,Cargo_Type,SHIPAGENT_SHORT,InOut,PORT_CHA,BERTHNO,AmountOri,TonsOri,TallyAmount,TallyTons,MONEY,WORKTIME_BEGIN,BeginHeader,WORKTIME_END,EndHeader FROM View_StatCargoVoyage where WORKTIME_END>='" & Me.dtpBegin.Value & "' and WORKTIME_END<'" & Me.dtpEnd.Value & "' " & strDept & " order by SHIP_ID"
                dvStatCargoVoyage = Getdata(sqlStatCargoVoyage, dsStatCargoVoyage)
                changeCargoVoyage.blChange = False
            End If
            Me.C1DBG.DataSource = dvStatCargoVoyage
            If statClass <> Stats.StatCargoVoyage Then '改变了统计报表
                If statClass <> Stats.Empty Then    '非首次统计操作
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                btnStatLast = Me.btnStatCargoVoyage
                Me.btnStatCargoVoyage.ForeColor = Color.Red
                statClass = Stats.StatCargoVoyage
                'Grid设置
                Me.C1DBG.Caption = Me.btnStatCargoVoyage.Text
                Me.C1DBG.Columns("CHI_VESSEL").Caption = "船名"
                Me.C1DBG.Columns("VOYAGE").Caption = "航次"
                Me.C1DBG.Columns("Cargo_Type").Caption = "货类"
                Me.C1DBG.Columns("SHIPAGENT_SHORT").Caption = "船代"
                Me.C1DBG.Columns("InOut").Caption = "进出"
                Me.C1DBG.Columns("PORT_CHA").Caption = "装卸港"
                Me.C1DBG.Columns("BERTHNO").Caption = "泊位"
                Me.C1DBG.Columns("AmountOri").Caption = "原配件数"
                Me.C1DBG.Columns("TonsOri").Caption = "原配吨数"
                Me.C1DBG.Columns("TallyAmount").Caption = "理货件数"
                Me.C1DBG.Columns("TallyTons").Caption = "理货吨数"
                Me.C1DBG.Columns("MONEY").Caption = "理货收入"
                Me.C1DBG.Columns("WORKTIME_BEGIN").Caption = "开工时间"
                Me.C1DBG.Columns("BeginHeader").Caption = "接船组长"
                Me.C1DBG.Columns("WORKTIME_END").Caption = "完工时间"
                Me.C1DBG.Columns("EndHeader").Caption = "完船组长"
                Me.C1DBG.Splits(0).DisplayColumns("SHIP_ID").Visible = False
                Me.C1DBG.Columns("WORKTIME_BEGIN").NumberFormat = "yy年MM月dd日"
                Me.C1DBG.Columns("WORKTIME_END").NumberFormat = "yy年MM月dd日"
            End If
            SetDGWidth(Me.C1DBG, 0)
            'Grid单列统计
            Me.C1DBG.Columns("AmountOri").FooterText = GetDataSum(dvStatCargoVoyage, "AmountOri")
            Me.C1DBG.Columns("TonsOri").FooterText = GetDataSum(dvStatCargoVoyage, "TonsOri")
            Me.C1DBG.Columns("TallyAmount").FooterText = GetDataSum(dvStatCargoVoyage, "TallyAmount")
            Me.C1DBG.Columns("TallyTons").FooterText = GetDataSum(dvStatCargoVoyage, "TallyTons")
            Me.C1DBG.Columns("MONEY").FooterText = GetDataSum(dvStatCargoVoyage, "MONEY")
            Me.C1DBG.Columns("CHI_VESSEL").FooterText = "合计" & dvStatCargoVoyage.Count & "艘"
            Me.C1DBG.FilterBar = False
        End If
    End Sub


    Private Sub DealStatCargoVoyage(ByVal xlApp As Excel.ApplicationClass)
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Dim i, j As Integer
        PathStr = substr(PathStr)
        Dim strExcelName As String = "StatCargoVoyage.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "件杂货船舶统计"
        xlBook = xlApp.Workbooks.Add(strPath)
        'xlSheet=(Excel.Worksheet)xlBook.Worksheets(strSheetName)
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        Dim rowStart As Integer = 7 'Excel中循环起始行位置
        For i = 0 To dvStatCargoVoyage.Count - 1
            xlSheet.Cells(i + rowStart, "A") = i + 1
            xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
            xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("VOYAGE").CellText(i)
            xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("Cargo_Type").CellText(i)
            xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("SHIPAGENT_SHORT").CellText(i)
            xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("InOut").CellText(i)
            xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("PORT_CHA").CellText(i)
            xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("BERTHNO").CellText(i)
            xlSheet.Cells(i + rowStart, "I") = Me.C1DBG.Columns("AmountOri").CellText(i)
            xlSheet.Cells(i + rowStart, "J") = Me.C1DBG.Columns("TonsOri").CellText(i)
            xlSheet.Cells(i + rowStart, "K") = Me.C1DBG.Columns("TallyAmount").CellText(i)
            xlSheet.Cells(i + rowStart, "L") = Me.C1DBG.Columns("TallyTons").CellText(i)
            xlSheet.Cells(i + rowStart, "M") = Me.C1DBG.Columns("MONEY").CellText(i)
            xlSheet.Cells(i + rowStart, "N") = Me.C1DBG.Columns("WORKTIME_BEGIN").CellText(i)
            xlSheet.Cells(i + rowStart, "O") = Me.C1DBG.Columns("BeginHeader").CellText(i)
            xlSheet.Cells(i + rowStart, "P") = Me.C1DBG.Columns("WORKTIME_END").CellText(i)
            xlSheet.Cells(i + rowStart, "Q") = Me.C1DBG.Columns("EndHeader").CellText(i)
        Next
        xlSheet.Range(xlSheet.Cells(i + rowStart, "A"), xlSheet.Cells(i + rowStart, "B")).Merge()
        xlSheet.Cells(i + rowStart, "A") = Me.C1DBG.Columns("CHI_VESSEL").FooterText
        xlSheet.Cells(i + rowStart, "I") = Me.C1DBG.Columns("AmountOri").FooterText
        xlSheet.Cells(i + rowStart, "J") = Me.C1DBG.Columns("TonsOri").FooterText
        xlSheet.Cells(i + rowStart, "K") = Me.C1DBG.Columns("TallyAmount").FooterText
        xlSheet.Cells(i + rowStart, "L") = Me.C1DBG.Columns("TallyTons").FooterText
        xlSheet.Cells(i + rowStart, "M") = Me.C1DBG.Columns("MONEY").FooterText
        If Me.cbDept.SelectedIndex > 0 Then
            xlSheet.Cells(2, "A") = Me.cbDept.Text
        End If
        If changeCargoVoyage.dtBeginOld.AddDays(7).Month >= changeCargoVoyage.dtEndOld.Month Then
            xlSheet.Cells(3, "N") = changeCargoVoyage.dtEndOld.ToString("yyyy年MM月")
        Else
            xlSheet.Cells(3, "N") = changeCargoVoyage.dtBeginOld.AddDays(7).ToString("yyyy年MM月") & "—" & changeCargoVoyage.dtEndOld.ToString("MM月")
        End If
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "A"), xlSheet.Cells(i + rowStart + 1, "B")).Merge()
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "C"), xlSheet.Cells(i + rowStart + 1, "D")).Merge()
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "G"), xlSheet.Cells(i + rowStart + 1, "I")).Merge()
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "J"), xlSheet.Cells(i + rowStart + 1, "K")).Merge()
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "N"), xlSheet.Cells(i + rowStart + 1, "P")).Merge()
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "A"), xlSheet.Cells(i + rowStart + 1, "A")).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "G"), xlSheet.Cells(i + rowStart + 1, "G")).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "C"), xlSheet.Cells(i + rowStart + 1, "C")).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "J"), xlSheet.Cells(i + rowStart + 1, "J")).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        xlSheet.Cells(i + rowStart + 1, "A") = "部门经理："
        xlSheet.Cells(i + rowStart + 1, "G") = "统计员："
        xlSheet.Cells(i + rowStart + 1, "N") = "制表时间：" & Now.ToShortDateString()

        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "Q")).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub

    Private Sub btnStatCargoClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatCargoClass.Click
        OperCheck(changeCargoClass)
        If blNext Then
            If changeCargoClass.blChange OrElse IsNothing(dvStatCargoClass) Then   '改变统计条件或者是首次做该报表的统计
                Dim strDept As String
                strDept = Me.cbDept.SelectedValue
                If strDept = "00" Then
                    strDept = "0"
                End If
                sqlStatCargoClass = "SP_StatCargoClass '" & Me.dtpBegin.Value & "','" & Me.dtpEnd.Value & "','" & strDept & "'"
                dvStatCargoClass = Getdata(sqlStatCargoClass, dsStatCargoClass)
                changeCargoClass.blChange = False
            End If
            Me.C1DBG.DataSource = dvStatCargoClass
            If statClass <> Stats.StatCargoClass Then '改变了统计报表
                If statClass <> Stats.Empty Then    '非首次统计操作
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                btnStatLast = Me.btnStatCargoClass
                Me.btnStatCargoClass.ForeColor = Color.Red
                statClass = Stats.StatCargoClass
                'Grid设置
                Me.C1DBG.Caption = Me.btnStatCargoClass.Text
                Me.C1DBG.Columns("TypeName").Caption = "货类"
                Me.C1DBG.Columns("Amount").Caption = "件数"
                Me.C1DBG.Columns("AmountTotal").Caption = "累计件数"
                Me.C1DBG.Columns("Tons").Caption = "吨数"
                Me.C1DBG.Columns("TonsTotal").Caption = "累计吨数"
                Me.C1DBG.Columns("SumRate").Caption = "吨数占总比"
                Me.C1DBG.Columns("SumRateTotal").Caption = "累计吨占总比"
                Me.C1DBG.Columns("TonsLast").Caption = "去年累计吨"
                Me.C1DBG.Columns("RateLast").Caption = "累计吨同比"
                Me.C1DBG.Splits(0).DisplayColumns("Type").Visible = False
                Me.C1DBG.Splits(0).DisplayColumns("TonsLast").Visible = False
                Me.C1DBG.Columns("SumRate").NumberFormat = "Percent"
                Me.C1DBG.Columns("SumRateTotal").NumberFormat = "Percent"
                Me.C1DBG.Columns("RateLast").NumberFormat = "Percent"
            End If
            SetDGWidth(Me.C1DBG)
            'Grid单列统计
            Me.C1DBG.Columns("Amount").FooterText = GetDataSum(dvStatCargoClass, "Amount")
            Me.C1DBG.Columns("AmountTotal").FooterText = GetDataSum(dvStatCargoClass, "AmountTotal")
            Me.C1DBG.Columns("Tons").FooterText = GetDataSum(dvStatCargoClass, "Tons")
            Me.C1DBG.Columns("TonsTotal").FooterText = GetDataSum(dvStatCargoClass, "TonsTotal")
            Me.C1DBG.Columns("SumRate").FooterText = GetDataSum(dvStatCargoClass, "SumRate")
            Me.C1DBG.Columns("SumRateTotal").FooterText = GetDataSum(dvStatCargoClass, "SumRateTotal")
            Me.C1DBG.Columns("TonsLast").FooterText = GetDataSum(dvStatCargoClass, "TonsLast")
            Me.C1DBG.Columns("TypeName").FooterText = "合计" & dvStatCargoClass.Count & "类"
            Me.C1DBG.FilterBar = False
        End If
    End Sub

    Private Sub DealStatCargoClass(ByVal xlApp As Excel.ApplicationClass)
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Dim i, j As Integer
        PathStr = substr(PathStr)
        Dim strExcelName As String = "StatCargoClass.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "件杂货货类统计"
        xlBook = xlApp.Workbooks.Add(strPath)
        'xlSheet=(Excel.Worksheet)xlBook.Worksheets(strSheetName)
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        Dim rowStart As Integer = 7 'Excel中循环起始行位置
        For i = 0 To dvStatCargoClass.Count - 1
            xlSheet.Cells(i + rowStart, "A") = i + 1
            xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("TypeName").CellText(i)
            xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("Amount").CellText(i)
            xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("AmountTotal").CellText(i)
            xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("Tons").CellText(i)
            xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("TonsTotal").CellText(i)
            xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("SumRateTotal").CellText(i)
            xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("RateLast").CellText(i)
        Next
        xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("TypeName").FooterText
        xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("Amount").FooterText
        xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("AmountTotal").FooterText
        xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("Tons").FooterText
        xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("TonsTotal").FooterText
        xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("SumRateTotal").FooterText
        If Me.cbDept.SelectedIndex > 0 Then
            xlSheet.Cells(3, "A") = Me.cbDept.Text
        End If
        If changeCargoClass.dtBeginOld.AddDays(7).Month >= changeCargoClass.dtEndOld.Month Then
            xlSheet.Cells(3, "F") = changeCargoClass.dtEndOld.ToString("yyyy年MM月")
        Else
            xlSheet.Cells(3, "F") = changeCargoClass.dtBeginOld.AddDays(7).ToString("yyyy年MM月") & "—" & changeCargoClass.dtEndOld.ToString("MM月")
        End If
        xlSheet.Cells(i + rowStart + 1, "B") = "部门经理："
        xlSheet.Cells(i + rowStart + 1, "D") = "统计员："
        xlSheet.Cells(i + rowStart + 1, "F") = "制表时间：" & Now.ToShortDateString()

        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "H")).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub

    Private Sub btnStatCargoGoods_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatCargoGoods.Click
        OperCheck(changeCargoGoods)
        If blNext Then
            If changeCargoGoods.blChange OrElse IsNothing(dvStatCargoGoods) Then   '改变统计条件或者是首次做该报表的统计
                Dim strDept As String
                strDept = Me.cbDept.SelectedValue
                If strDept = "00" Then
                    strDept = "0"
                End If
                sqlStatCargoGoods = "SP_StatCargoGoods '" & Me.dtpBegin.Value & "','" & Me.dtpEnd.Value & "','" & strDept & "'"
                dvStatCargoGoods = Getdata(sqlStatCargoGoods, dsStatCargoGoods)
                changeCargoGoods.blChange = False
            End If
            Me.C1DBG.DataSource = dvStatCargoGoods
            If statClass <> Stats.StatCargoGoods Then '改变了统计报表
                If statClass <> Stats.Empty Then    '非首次统计操作
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                btnStatLast = Me.btnStatCargoGoods
                Me.btnStatCargoGoods.ForeColor = Color.Red
                statClass = Stats.StatCargoGoods
                'Grid设置
                Me.C1DBG.Caption = Me.btnStatCargoGoods.Text
                Me.C1DBG.Columns("Goods_Cha").Caption = "货名"
                Me.C1DBG.Columns("Amount").Caption = "件数"
                Me.C1DBG.Columns("AmountTotal").Caption = "累计件数"
                Me.C1DBG.Columns("Tons").Caption = "吨数"
                Me.C1DBG.Columns("TonsTotal").Caption = "累计吨数"
                Me.C1DBG.Columns("SumRate").Caption = "吨数占总比"
                Me.C1DBG.Columns("SumRateTotal").Caption = "累计吨占总比"
                Me.C1DBG.Columns("TonsLast").Caption = "去年累计吨"
                Me.C1DBG.Columns("RateLast").Caption = "累计吨同比"
                Me.C1DBG.Splits(0).DisplayColumns("TonsLast").Visible = False
                Me.C1DBG.Columns("SumRate").NumberFormat = "Percent"
                Me.C1DBG.Columns("SumRateTotal").NumberFormat = "Percent"
                Me.C1DBG.Columns("RateLast").NumberFormat = "Percent"
            End If
            SetDGWidth(Me.C1DBG)
            'Grid单列统计
            Me.C1DBG.Columns("Amount").FooterText = GetDataSum(dvStatCargoGoods, "Amount")
            Me.C1DBG.Columns("AmountTotal").FooterText = GetDataSum(dvStatCargoGoods, "AmountTotal")
            Me.C1DBG.Columns("Tons").FooterText = GetDataSum(dvStatCargoGoods, "Tons")
            Me.C1DBG.Columns("TonsTotal").FooterText = GetDataSum(dvStatCargoGoods, "TonsTotal")
            Me.C1DBG.Columns("SumRate").FooterText = GetDataSum(dvStatCargoGoods, "SumRate")
            Me.C1DBG.Columns("SumRateTotal").FooterText = GetDataSum(dvStatCargoGoods, "SumRateTotal")
            Me.C1DBG.Columns("TonsLast").FooterText = GetDataSum(dvStatCargoGoods, "TonsLast")
            Me.C1DBG.Columns("Goods_Cha").FooterText = "合计" & dvStatCargoGoods.Count & "种"
            Me.C1DBG.FilterBar = False
        End If
    End Sub

    Private Sub DealStatCargoGoods(ByVal xlApp As Excel.ApplicationClass)
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Dim i, j As Integer
        PathStr = substr(PathStr)
        Dim strExcelName As String = "StatCargoGoods.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "件杂货货种统计"
        xlBook = xlApp.Workbooks.Add(strPath)
        'xlSheet=(Excel.Worksheet)xlBook.Worksheets(strSheetName)
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        Dim rowStart As Integer = 7 'Excel中循环起始行位置
        For i = 0 To dvStatCargoGoods.Count - 1
            xlSheet.Cells(i + rowStart, "A") = i + 1
            xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("Goods_Cha").CellText(i)
            xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("Amount").CellText(i)
            xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("AmountTotal").CellText(i)
            xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("Tons").CellText(i)
            xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("TonsTotal").CellText(i)
            xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("SumRateTotal").CellText(i)
            xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("RateLast").CellText(i)
        Next
        xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("Goods_Cha").FooterText
        xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("Amount").FooterText
        xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("AmountTotal").FooterText
        xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("Tons").FooterText
        xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("TonsTotal").FooterText
        xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("SumRateTotal").FooterText
        If Me.cbDept.SelectedIndex > 0 Then
            xlSheet.Cells(3, "A") = Me.cbDept.Text
        End If
        If changeCargoGoods.dtBeginOld.AddDays(7).Month >= changeCargoGoods.dtEndOld.Month Then
            xlSheet.Cells(3, "F") = changeCargoGoods.dtEndOld.ToString("yyyy年MM月")
        Else
            xlSheet.Cells(3, "F") = changeCargoGoods.dtBeginOld.AddDays(7).ToString("yyyy年MM月") & "—" & changeCargoGoods.dtEndOld.ToString("MM月")
        End If
        xlSheet.Cells(i + rowStart + 1, "B") = "部门经理："
        xlSheet.Cells(i + rowStart + 1, "D") = "统计员："
        xlSheet.Cells(i + rowStart + 1, "F") = "制表时间：" & Now.ToShortDateString()

        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "H")).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub

    Private Sub btnStatCargoVoyGoods_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatCargoVoyGoods.Click
        OperCheck(changeCargoVoyGoods)
        If blNext Then
            If changeCargoVoyGoods.blChange OrElse IsNothing(dvStatCargoVoyGoods) Then   '改变统计条件或者是首次做该报表的统计
                Dim strDept As String
                strDept = Me.cbDept.SelectedValue
                If strDept = "00" Then
                    strDept = ""
                Else
                    strDept = " and DEPT_CODE='" & strDept & "'"
                End If
                sqlStatCargoVoyGoods = "SELECT SHIP_ID,Chi_Vessel,Voyage,InOut,Port_Cha,GOODS_CHA,Amount,Tons,ShipAgent_Short,WorkDate FROM View_StatCargoVoyGoods where WorkDate>='" & Me.dtpBegin.Value & "' and WorkDate<'" & Me.dtpEnd.Value & "' " & strDept & " order by SHIP_ID,WorkDate"
                dvStatCargoVoyGoods = Getdata(sqlStatCargoVoyGoods, dsStatCargoVoyGoods)
                changeCargoVoyGoods.blChange = False
            End If
            Me.C1DBG.DataSource = dvStatCargoVoyGoods
            If statClass <> Stats.StatCargoVoyGoods Then '改变了统计报表
                If statClass <> Stats.Empty Then    '非首次统计操作
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                btnStatLast = Me.btnStatCargoVoyGoods
                Me.btnStatCargoVoyGoods.ForeColor = Color.Red
                statClass = Stats.StatCargoVoyGoods
                'Grid设置
                Me.C1DBG.Caption = Me.btnStatCargoVoyGoods.Text
                Me.C1DBG.Columns("CHI_VESSEL").Caption = "船名"
                Me.C1DBG.Columns("VOYAGE").Caption = "航次"
                Me.C1DBG.Columns("InOut").Caption = "进出"
                Me.C1DBG.Columns("PORT_CHA").Caption = "装卸港"
                Me.C1DBG.Columns("GOODS_CHA").Caption = "货名"
                Me.C1DBG.Columns("Amount").Caption = "件数"
                Me.C1DBG.Columns("Tons").Caption = "吨数"
                Me.C1DBG.Columns("ShipAgent_Short").Caption = "船代"
                Me.C1DBG.Columns("WorkDate").Caption = "日期"
                Me.C1DBG.Splits(0).DisplayColumns("SHIP_ID").Visible = False
                Me.C1DBG.Columns("WorkDate").NumberFormat = "yy年MM月dd日"
            End If
            SetDGWidth(Me.C1DBG)
            'Grid单列统计
            Me.C1DBG.Columns("Amount").FooterText = GetDataSum(dvStatCargoVoyGoods, "Amount")
            Me.C1DBG.Columns("Tons").FooterText = GetDataSum(dvStatCargoVoyGoods, "Tons")
            Me.C1DBG.Columns("CHI_VESSEL").FooterText = "合计" & dvStatCargoVoyGoods.Count & "项"
            Me.C1DBG.FilterBar = True
        End If
    End Sub

    Private Sub DealStatCargoVoyGoods(ByVal xlApp As Excel.ApplicationClass)
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Dim i, j As Integer
        PathStr = substr(PathStr)
        Dim strExcelName As String = "StatCargoVoyGoods.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "件杂货船货统计"
        xlBook = xlApp.Workbooks.Add(strPath)
        'xlSheet=(Excel.Worksheet)xlBook.Worksheets(strSheetName)
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        Dim rowStart As Integer = 7 'Excel中循环起始行位置
        For i = 0 To dvStatCargoVoyGoods.Count - 1
            xlSheet.Cells(i + rowStart, "A") = i + 1
            xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
            xlSheet.Cells(i + rowStart, "C") = Me.C1DBG.Columns("VOYAGE").CellText(i)
            xlSheet.Cells(i + rowStart, "D") = Me.C1DBG.Columns("PORT_CHA").CellText(i)
            xlSheet.Cells(i + rowStart, "E") = Me.C1DBG.Columns("GOODS_CHA").CellText(i)
            xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("Amount").CellText(i)
            xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("Tons").CellText(i)
            xlSheet.Cells(i + rowStart, "H") = Me.C1DBG.Columns("ShipAgent_Short").CellText(i)
        Next
        xlSheet.Cells(i + rowStart, "B") = Me.C1DBG.Columns("CHI_VESSEL").FooterText
        xlSheet.Cells(i + rowStart, "F") = Me.C1DBG.Columns("Amount").FooterText
        xlSheet.Cells(i + rowStart, "G") = Me.C1DBG.Columns("Tons").FooterText
        If Me.cbDept.SelectedIndex > 0 Then
            xlSheet.Cells(3, "A") = Me.cbDept.Text
        End If
        If changeCargoVoyGoods.dtBeginOld.AddDays(7).Month >= changeCargoVoyGoods.dtEndOld.Month Then
            xlSheet.Cells(3, "G") = changeCargoVoyGoods.dtEndOld.ToString("yyyy年MM月")
        Else
            xlSheet.Cells(3, "G") = changeCargoVoyGoods.dtBeginOld.AddDays(7).ToString("yyyy年MM月") & "—" & changeCargoVoyGoods.dtEndOld.ToString("MM月")
        End If
        xlSheet.Cells(i + rowStart + 1, "B") = "部门经理："
        xlSheet.Cells(i + rowStart + 1, "E") = "统计员："
        xlSheet.Cells(i + rowStart + 1, "G") = "制表时间：" & Now.ToShortDateString()
        xlSheet.Range(xlSheet.Cells(i + rowStart + 1, "G"), xlSheet.Cells(i + rowStart + 1, "H")).Merge()

        xlSheet.Range(xlSheet.Cells(rowStart, "A"), xlSheet.Cells(i + rowStart - 1, "H")).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub

    Private Sub gbDeptCargo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbDeptCargo.Enter

    End Sub
End Class
