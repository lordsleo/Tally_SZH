Imports TALLY.DBControl
Public Class FrmSEAL_EXAM_QUERY
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dshatch_no As New DataSet()
    Dim dsWORKTYPE As New DataSet()
    Dim dsSEAL_TYPE As New DataSet()
    Dim DSORIGINESEALNO_CONDITION As New DataSet
    Dim dsclerk As New DataSet

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
    Friend WithEvents CombORIGINESEALNO_CONDITION As System.Windows.Forms.ComboBox
    Friend WithEvents TxtREMARK As System.Windows.Forms.TextBox
    Friend WithEvents DTPTIME_TO As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPTIME_FROM As System.Windows.Forms.DateTimePicker
    Friend WithEvents CombSEAL_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents CombHATCH_NO As System.Windows.Forms.ComboBox
    Friend WithEvents TxtORIGINESEALNO As System.Windows.Forms.TextBox
    Friend WithEvents TxtNEWSEALNO As System.Windows.Forms.TextBox
    Friend WithEvents TxtCONTAINER_NO As System.Windows.Forms.TextBox
    Friend WithEvents TxtWORK_PLACE As System.Windows.Forms.TextBox
    Friend WithEvents CombWORKTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
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
    Friend WithEvents CombTALLY_CLERK As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.CombORIGINESEALNO_CONDITION = New System.Windows.Forms.ComboBox
        Me.TxtREMARK = New System.Windows.Forms.TextBox
        Me.DTPTIME_TO = New System.Windows.Forms.DateTimePicker
        Me.DTPTIME_FROM = New System.Windows.Forms.DateTimePicker
        Me.CombSEAL_TYPE = New System.Windows.Forms.ComboBox
        Me.CombHATCH_NO = New System.Windows.Forms.ComboBox
        Me.TxtORIGINESEALNO = New System.Windows.Forms.TextBox
        Me.TxtNEWSEALNO = New System.Windows.Forms.TextBox
        Me.TxtCONTAINER_NO = New System.Windows.Forms.TextBox
        Me.TxtWORK_PLACE = New System.Windows.Forms.TextBox
        Me.CombWORKTYPE = New System.Windows.Forms.ComboBox
        Me.TxtNO = New System.Windows.Forms.TextBox
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
        Me.CombTALLY_CLERK = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(226, 224)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 93
        Me.BTQUIT.Text = "取消"
        '
        'CombORIGINESEALNO_CONDITION
        '
        Me.CombORIGINESEALNO_CONDITION.Enabled = False
        Me.CombORIGINESEALNO_CONDITION.Location = New System.Drawing.Point(336, 114)
        Me.CombORIGINESEALNO_CONDITION.Name = "CombORIGINESEALNO_CONDITION"
        Me.CombORIGINESEALNO_CONDITION.Size = New System.Drawing.Size(170, 20)
        Me.CombORIGINESEALNO_CONDITION.TabIndex = 141
        '
        'TxtREMARK
        '
        Me.TxtREMARK.Enabled = False
        Me.TxtREMARK.Location = New System.Drawing.Point(110, 168)
        Me.TxtREMARK.MaxLength = 100
        Me.TxtREMARK.Multiline = True
        Me.TxtREMARK.Name = "TxtREMARK"
        Me.TxtREMARK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtREMARK.Size = New System.Drawing.Size(396, 42)
        Me.TxtREMARK.TabIndex = 140
        Me.TxtREMARK.Text = ""
        '
        'DTPTIME_TO
        '
        Me.DTPTIME_TO.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.DTPTIME_TO.Enabled = False
        Me.DTPTIME_TO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTIME_TO.Location = New System.Drawing.Point(110, 88)
        Me.DTPTIME_TO.Name = "DTPTIME_TO"
        Me.DTPTIME_TO.Size = New System.Drawing.Size(122, 21)
        Me.DTPTIME_TO.TabIndex = 139
        '
        'DTPTIME_FROM
        '
        Me.DTPTIME_FROM.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.DTPTIME_FROM.Enabled = False
        Me.DTPTIME_FROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTIME_FROM.Location = New System.Drawing.Point(110, 62)
        Me.DTPTIME_FROM.Name = "DTPTIME_FROM"
        Me.DTPTIME_FROM.Size = New System.Drawing.Size(122, 21)
        Me.DTPTIME_FROM.TabIndex = 138
        '
        'CombSEAL_TYPE
        '
        Me.CombSEAL_TYPE.Enabled = False
        Me.CombSEAL_TYPE.Location = New System.Drawing.Point(336, 60)
        Me.CombSEAL_TYPE.Name = "CombSEAL_TYPE"
        Me.CombSEAL_TYPE.Size = New System.Drawing.Size(170, 20)
        Me.CombSEAL_TYPE.TabIndex = 137
        '
        'CombHATCH_NO
        '
        Me.CombHATCH_NO.Enabled = False
        Me.CombHATCH_NO.Location = New System.Drawing.Point(110, 114)
        Me.CombHATCH_NO.Name = "CombHATCH_NO"
        Me.CombHATCH_NO.Size = New System.Drawing.Size(122, 20)
        Me.CombHATCH_NO.TabIndex = 136
        '
        'TxtORIGINESEALNO
        '
        Me.TxtORIGINESEALNO.Enabled = False
        Me.TxtORIGINESEALNO.Location = New System.Drawing.Point(336, 86)
        Me.TxtORIGINESEALNO.MaxLength = 20
        Me.TxtORIGINESEALNO.Name = "TxtORIGINESEALNO"
        Me.TxtORIGINESEALNO.Size = New System.Drawing.Size(170, 21)
        Me.TxtORIGINESEALNO.TabIndex = 135
        Me.TxtORIGINESEALNO.Text = ""
        '
        'TxtNEWSEALNO
        '
        Me.TxtNEWSEALNO.Enabled = False
        Me.TxtNEWSEALNO.Location = New System.Drawing.Point(336, 34)
        Me.TxtNEWSEALNO.MaxLength = 20
        Me.TxtNEWSEALNO.Name = "TxtNEWSEALNO"
        Me.TxtNEWSEALNO.Size = New System.Drawing.Size(170, 21)
        Me.TxtNEWSEALNO.TabIndex = 134
        Me.TxtNEWSEALNO.Text = ""
        '
        'TxtCONTAINER_NO
        '
        Me.TxtCONTAINER_NO.Enabled = False
        Me.TxtCONTAINER_NO.Location = New System.Drawing.Point(336, 8)
        Me.TxtCONTAINER_NO.MaxLength = 11
        Me.TxtCONTAINER_NO.Name = "TxtCONTAINER_NO"
        Me.TxtCONTAINER_NO.Size = New System.Drawing.Size(170, 21)
        Me.TxtCONTAINER_NO.TabIndex = 133
        Me.TxtCONTAINER_NO.Text = ""
        '
        'TxtWORK_PLACE
        '
        Me.TxtWORK_PLACE.Enabled = False
        Me.TxtWORK_PLACE.Location = New System.Drawing.Point(110, 140)
        Me.TxtWORK_PLACE.Name = "TxtWORK_PLACE"
        Me.TxtWORK_PLACE.Size = New System.Drawing.Size(238, 21)
        Me.TxtWORK_PLACE.TabIndex = 132
        Me.TxtWORK_PLACE.Text = ""
        '
        'CombWORKTYPE
        '
        Me.CombWORKTYPE.Enabled = False
        Me.CombWORKTYPE.Location = New System.Drawing.Point(110, 36)
        Me.CombWORKTYPE.Name = "CombWORKTYPE"
        Me.CombWORKTYPE.Size = New System.Drawing.Size(122, 20)
        Me.CombWORKTYPE.TabIndex = 131
        '
        'TxtNO
        '
        Me.TxtNO.Enabled = False
        Me.TxtNO.Location = New System.Drawing.Point(110, 8)
        Me.TxtNO.MaxLength = 10
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(122, 21)
        Me.TxtNO.TabIndex = 130
        Me.TxtNO.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(12, 178)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 20)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "备注"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(238, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 20)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "原铅封完好情况"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(238, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 20)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "新加铅封类型"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(238, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "原铅封号"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(238, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 125
        Me.Label8.Text = "新加铅封号"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(238, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 20)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "箱号"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "舱别"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "工作地点"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "结束时间"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "开始时间"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "拆装箱装卸船别"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "记录编号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombTALLY_CLERK
        '
        Me.CombTALLY_CLERK.Location = New System.Drawing.Point(398, 140)
        Me.CombTALLY_CLERK.Name = "CombTALLY_CLERK"
        Me.CombTALLY_CLERK.Size = New System.Drawing.Size(108, 20)
        Me.CombTALLY_CLERK.TabIndex = 143
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(350, 140)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 22)
        Me.Label14.TabIndex = 142
        Me.Label14.Text = "理货员"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmSEAL_EXAM_QUERY
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(516, 261)
        Me.Controls.Add(Me.CombTALLY_CLERK)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CombORIGINESEALNO_CONDITION)
        Me.Controls.Add(Me.TxtREMARK)
        Me.Controls.Add(Me.DTPTIME_TO)
        Me.Controls.Add(Me.DTPTIME_FROM)
        Me.Controls.Add(Me.CombSEAL_TYPE)
        Me.Controls.Add(Me.CombHATCH_NO)
        Me.Controls.Add(Me.TxtORIGINESEALNO)
        Me.Controls.Add(Me.TxtNEWSEALNO)
        Me.Controls.Add(Me.TxtCONTAINER_NO)
        Me.Controls.Add(Me.TxtWORK_PLACE)
        Me.Controls.Add(Me.CombWORKTYPE)
        Me.Controls.Add(Me.TxtNO)
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
        Me.Controls.Add(Me.BTQUIT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSEAL_EXAM_QUERY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "验封施封记录_查看"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub

    Private Sub FrmSEAL_EXAM_QUERY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select value,descr from codecabin", dshatch_no)
        CombHATCH_NO.DataSource = dshatch_no.Tables(0).DefaultView
        CombHATCH_NO.DisplayMember = "descr"
        CombHATCH_NO.ValueMember = "value"

        dw = Getdata("select Code_WorkType,WorkType from Code_WorkType", dsWORKTYPE)
        CombWORKTYPE.DataSource = dsWORKTYPE.Tables(0).DefaultView
        CombWORKTYPE.DisplayMember = "WorkType"
        CombWORKTYPE.ValueMember = "Code_WorkType"

        dw = Getdata("select Code_Seal_Type,Seal_Type from Code_Seal_Type", dsSEAL_TYPE)
        CombSEAL_TYPE.DataSource = dsSEAL_TYPE.Tables(0).DefaultView
        CombSEAL_TYPE.DisplayMember = "Seal_Type"
        CombSEAL_TYPE.ValueMember = "Code_Seal_Type"

        dw = Getdata("select work_no,name from TALLY_CLERK order by name", dsclerk)
        CombTALLY_CLERK.DataSource = dsclerk.Tables(0).DefaultView
        CombTALLY_CLERK.DisplayMember = "name"
        CombTALLY_CLERK.ValueMember = "work_no"

        dw = Getdata("select Code_SealCircs,SealCircs_CHI from Code_SealCircs", DSORIGINESEALNO_CONDITION)
        CombORIGINESEALNO_CONDITION.DataSource = DSORIGINESEALNO_CONDITION.Tables(0).DefaultView
        CombORIGINESEALNO_CONDITION.DisplayMember = "SealCircs_CHI"
        CombORIGINESEALNO_CONDITION.ValueMember = "Code_SealCircs"

        dw = Updatedata(sqlda, "select * from SEAL_EXAM where SEAL_EXAM_ID='" & ID & "'", ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            DTPTIME_FROM.Value = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_from"))), Now, Trim(ds.Tables(0).Rows(0).Item("time_from")))
            DTPTIME_TO.Value = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_to"))), Now, Trim(ds.Tables(0).Rows(0).Item("time_to")))
            CombHATCH_NO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("hatch_no"))), "", Trim(ds.Tables(0).Rows(0).Item("hatch_no")))
            CombWORKTYPE.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("WORKTYPE"))), "", Trim(ds.Tables(0).Rows(0).Item("WORKTYPE")))
            TxtWORK_PLACE.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("WORK_PLACE"))), "", Trim(ds.Tables(0).Rows(0).Item("WORK_PLACE")))
            CombSEAL_TYPE.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("SEAL_TYPE"))), "", Trim(ds.Tables(0).Rows(0).Item("SEAL_TYPE")))
            CombORIGINESEALNO_CONDITION.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("ORIGINESEALNO_CONDITION"))), "00", Trim(ds.Tables(0).Rows(0).Item("ORIGINESEALNO_CONDITION")))
            TxtREMARK.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("REMARK"))), "", Trim(ds.Tables(0).Rows(0).Item("REMARK")))
            TxtCONTAINER_NO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("CONTAINER_NO"))), "", Trim(ds.Tables(0).Rows(0).Item("CONTAINER_NO")))
            TxtNO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("no"))), "", Trim(ds.Tables(0).Rows(0).Item("no")))
            TxtNEWSEALNO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("NEWSEALNO"))), "", Trim(ds.Tables(0).Rows(0).Item("NEWSEALNO")))
            TxtORIGINESEALNO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("ORIGINESEALNO"))), "", Trim(ds.Tables(0).Rows(0).Item("ORIGINESEALNO")))
            CombTALLY_CLERK.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("TALLY_CLERK"))), "", Trim(ds.Tables(0).Rows(0).Item("TALLY_CLERK")))
        Else
            CombTALLY_CLERK.SelectedValue = ""
        End If




        Exit Sub
Err:
        Resume Next
    End Sub
End Class
