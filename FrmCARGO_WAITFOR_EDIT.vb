Imports TALLY.DBControl
Public Class FrmCARGO_WAITFOR_EDIT
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsberth As New DataSet()
    Dim dshatch_no As New DataSet()
    Dim dsclerk As New DataSet()
    Dim dsclerk2 As New DataSet()
    Dim dsclerk3 As New DataSet
    Dim dss As New DataSet

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
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents TxtCAUSE As System.Windows.Forms.TextBox
    Friend WithEvents TxtSHIP_WATCH As System.Windows.Forms.TextBox
    Friend WithEvents TxtPERSON As System.Windows.Forms.TextBox
    Friend WithEvents TxtTime_from As System.Windows.Forms.TextBox
    Friend WithEvents Txttime_to As System.Windows.Forms.TextBox
    Friend WithEvents DTPSTANDBYDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CombTALLY_CLERK3 As System.Windows.Forms.ComboBox
    Friend WithEvents CombTALLY_CLERK2 As System.Windows.Forms.ComboBox
    Friend WithEvents CombTALLY_CLERK1 As System.Windows.Forms.ComboBox
    Friend WithEvents CombHATCH_NO As System.Windows.Forms.ComboBox
    Friend WithEvents CombBERTHNO As System.Windows.Forms.ComboBox
    Friend WithEvents CBMANAGER_DS As System.Windows.Forms.CheckBox
    Friend WithEvents CBNIGHT_MARK As System.Windows.Forms.CheckBox
    Friend WithEvents CBHOLIDAY As System.Windows.Forms.CheckBox
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
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtWORK_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents txtteam_no As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.BTOK = New System.Windows.Forms.Button
        Me.TxtCAUSE = New System.Windows.Forms.TextBox
        Me.TxtSHIP_WATCH = New System.Windows.Forms.TextBox
        Me.TxtPERSON = New System.Windows.Forms.TextBox
        Me.TxtTime_from = New System.Windows.Forms.TextBox
        Me.Txttime_to = New System.Windows.Forms.TextBox
        Me.DTPSTANDBYDATE = New System.Windows.Forms.DateTimePicker
        Me.CombTALLY_CLERK3 = New System.Windows.Forms.ComboBox
        Me.CombTALLY_CLERK2 = New System.Windows.Forms.ComboBox
        Me.CombTALLY_CLERK1 = New System.Windows.Forms.ComboBox
        Me.CombHATCH_NO = New System.Windows.Forms.ComboBox
        Me.CombBERTHNO = New System.Windows.Forms.ComboBox
        Me.CBMANAGER_DS = New System.Windows.Forms.CheckBox
        Me.CBNIGHT_MARK = New System.Windows.Forms.CheckBox
        Me.CBHOLIDAY = New System.Windows.Forms.CheckBox
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
        Me.TxtNO = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtWORK_TYPE = New System.Windows.Forms.ComboBox
        Me.txtteam_no = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(258, 266)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 83
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(186, 266)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 82
        Me.BTOK.Text = "确认"
        '
        'TxtCAUSE
        '
        Me.TxtCAUSE.Location = New System.Drawing.Point(96, 210)
        Me.TxtCAUSE.MaxLength = 100
        Me.TxtCAUSE.Multiline = True
        Me.TxtCAUSE.Name = "TxtCAUSE"
        Me.TxtCAUSE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtCAUSE.Size = New System.Drawing.Size(308, 48)
        Me.TxtCAUSE.TabIndex = 81
        Me.TxtCAUSE.Text = ""
        '
        'TxtSHIP_WATCH
        '
        Me.TxtSHIP_WATCH.Location = New System.Drawing.Point(282, 152)
        Me.TxtSHIP_WATCH.MaxLength = 10
        Me.TxtSHIP_WATCH.Name = "TxtSHIP_WATCH"
        Me.TxtSHIP_WATCH.Size = New System.Drawing.Size(102, 21)
        Me.TxtSHIP_WATCH.TabIndex = 80
        Me.TxtSHIP_WATCH.Text = ""
        '
        'TxtPERSON
        '
        Me.TxtPERSON.Location = New System.Drawing.Point(282, 40)
        Me.TxtPERSON.Name = "TxtPERSON"
        Me.TxtPERSON.Size = New System.Drawing.Size(102, 21)
        Me.TxtPERSON.TabIndex = 79
        Me.TxtPERSON.Text = ""
        '
        'TxtTime_from
        '
        Me.TxtTime_from.Location = New System.Drawing.Point(96, 124)
        Me.TxtTime_from.MaxLength = 4
        Me.TxtTime_from.Name = "TxtTime_from"
        Me.TxtTime_from.Size = New System.Drawing.Size(108, 21)
        Me.TxtTime_from.TabIndex = 77
        Me.TxtTime_from.Text = ""
        '
        'Txttime_to
        '
        Me.Txttime_to.Location = New System.Drawing.Point(96, 152)
        Me.Txttime_to.MaxLength = 4
        Me.Txttime_to.Name = "Txttime_to"
        Me.Txttime_to.Size = New System.Drawing.Size(108, 21)
        Me.Txttime_to.TabIndex = 76
        Me.Txttime_to.Text = ""
        '
        'DTPSTANDBYDATE
        '
        Me.DTPSTANDBYDATE.CustomFormat = "yyyy-MM-dd"
        Me.DTPSTANDBYDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPSTANDBYDATE.Location = New System.Drawing.Point(96, 96)
        Me.DTPSTANDBYDATE.Name = "DTPSTANDBYDATE"
        Me.DTPSTANDBYDATE.Size = New System.Drawing.Size(108, 21)
        Me.DTPSTANDBYDATE.TabIndex = 75
        Me.DTPSTANDBYDATE.Value = New Date(2004, 4, 28, 0, 0, 0, 0)
        '
        'CombTALLY_CLERK3
        '
        Me.CombTALLY_CLERK3.Location = New System.Drawing.Point(282, 124)
        Me.CombTALLY_CLERK3.Name = "CombTALLY_CLERK3"
        Me.CombTALLY_CLERK3.Size = New System.Drawing.Size(102, 20)
        Me.CombTALLY_CLERK3.TabIndex = 74
        '
        'CombTALLY_CLERK2
        '
        Me.CombTALLY_CLERK2.Location = New System.Drawing.Point(282, 96)
        Me.CombTALLY_CLERK2.Name = "CombTALLY_CLERK2"
        Me.CombTALLY_CLERK2.Size = New System.Drawing.Size(102, 20)
        Me.CombTALLY_CLERK2.TabIndex = 73
        '
        'CombTALLY_CLERK1
        '
        Me.CombTALLY_CLERK1.Location = New System.Drawing.Point(282, 68)
        Me.CombTALLY_CLERK1.Name = "CombTALLY_CLERK1"
        Me.CombTALLY_CLERK1.Size = New System.Drawing.Size(102, 20)
        Me.CombTALLY_CLERK1.TabIndex = 72
        '
        'CombHATCH_NO
        '
        Me.CombHATCH_NO.Location = New System.Drawing.Point(96, 68)
        Me.CombHATCH_NO.Name = "CombHATCH_NO"
        Me.CombHATCH_NO.Size = New System.Drawing.Size(108, 20)
        Me.CombHATCH_NO.TabIndex = 71
        '
        'CombBERTHNO
        '
        Me.CombBERTHNO.Location = New System.Drawing.Point(96, 40)
        Me.CombBERTHNO.Name = "CombBERTHNO"
        Me.CombBERTHNO.Size = New System.Drawing.Size(108, 20)
        Me.CombBERTHNO.TabIndex = 70
        '
        'CBMANAGER_DS
        '
        Me.CBMANAGER_DS.Location = New System.Drawing.Point(396, 94)
        Me.CBMANAGER_DS.Name = "CBMANAGER_DS"
        Me.CBMANAGER_DS.Size = New System.Drawing.Size(98, 20)
        Me.CBMANAGER_DS.TabIndex = 69
        Me.CBMANAGER_DS.Text = "理货组长待时"
        Me.CBMANAGER_DS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBNIGHT_MARK
        '
        Me.CBNIGHT_MARK.Location = New System.Drawing.Point(396, 54)
        Me.CBNIGHT_MARK.Name = "CBNIGHT_MARK"
        Me.CBNIGHT_MARK.Size = New System.Drawing.Size(98, 20)
        Me.CBNIGHT_MARK.TabIndex = 67
        Me.CBNIGHT_MARK.Text = "夜班"
        Me.CBNIGHT_MARK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBHOLIDAY
        '
        Me.CBHOLIDAY.Location = New System.Drawing.Point(396, 14)
        Me.CBHOLIDAY.Name = "CBHOLIDAY"
        Me.CBHOLIDAY.Size = New System.Drawing.Size(98, 20)
        Me.CBHOLIDAY.TabIndex = 66
        Me.CBHOLIDAY.Text = "节假日"
        Me.CBHOLIDAY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(208, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 22)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "船方值班员"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(208, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 22)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "理货员3"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(208, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 22)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "理货员2"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(208, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 22)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "理货员1"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(22, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 22)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "原因"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(208, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 22)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "待时人数"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 22)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "班次"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 22)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "待时结束时间"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 22)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "待时开始时间"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 22)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "待时日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 22)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "舱别"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "泊位号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNO
        '
        Me.TxtNO.Location = New System.Drawing.Point(96, 12)
        Me.TxtNO.MaxLength = 5
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(108, 21)
        Me.TxtNO.TabIndex = 85
        Me.TxtNO.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(12, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 22)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "编号"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtWORK_TYPE
        '
        Me.TxtWORK_TYPE.Items.AddRange(New Object() {"甲", "乙", "丙"})
        Me.TxtWORK_TYPE.Location = New System.Drawing.Point(96, 180)
        Me.TxtWORK_TYPE.Name = "TxtWORK_TYPE"
        Me.TxtWORK_TYPE.Size = New System.Drawing.Size(108, 20)
        Me.TxtWORK_TYPE.TabIndex = 87
        '
        'txtteam_no
        '
        Me.txtteam_no.Location = New System.Drawing.Point(282, 12)
        Me.txtteam_no.MaxLength = 5
        Me.txtteam_no.Name = "txtteam_no"
        Me.txtteam_no.Size = New System.Drawing.Size(102, 21)
        Me.txtteam_no.TabIndex = 89
        Me.txtteam_no.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(208, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 22)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "工班号"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCARGO_WAITFOR_EDIT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(506, 309)
        Me.Controls.Add(Me.txtteam_no)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtWORK_TYPE)
        Me.Controls.Add(Me.TxtNO)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.BTOK)
        Me.Controls.Add(Me.TxtCAUSE)
        Me.Controls.Add(Me.TxtSHIP_WATCH)
        Me.Controls.Add(Me.TxtPERSON)
        Me.Controls.Add(Me.TxtTime_from)
        Me.Controls.Add(Me.Txttime_to)
        Me.Controls.Add(Me.DTPSTANDBYDATE)
        Me.Controls.Add(Me.CombTALLY_CLERK3)
        Me.Controls.Add(Me.CombTALLY_CLERK2)
        Me.Controls.Add(Me.CombTALLY_CLERK1)
        Me.Controls.Add(Me.CombHATCH_NO)
        Me.Controls.Add(Me.CombBERTHNO)
        Me.Controls.Add(Me.CBMANAGER_DS)
        Me.Controls.Add(Me.CBNIGHT_MARK)
        Me.Controls.Add(Me.CBHOLIDAY)
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
        Me.Name = "FrmCARGO_WAITFOR_EDIT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "待时记录_编辑"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCARGO_WAITFOR_EDIT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE_BERTH,NAME_BERTH from CODE_BERTH", dsberth)
        CombBERTHNO.DataSource = dsberth.Tables(0).DefaultView
        CombBERTHNO.DisplayMember = "NAME_BERTH"
        CombBERTHNO.ValueMember = "CODE_BERTH"

        dw = Getdata("select value,descr from codecabin", dshatch_no)
        CombHATCH_NO.DataSource = dshatch_no.Tables(0).DefaultView
        CombHATCH_NO.DisplayMember = "descr"
        CombHATCH_NO.ValueMember = "value"

        dw = Getdata("select work_no,name from TALLY_CLERK order by name", dsclerk)
        CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
        CombTALLY_CLERK1.DisplayMember = "name"
        CombTALLY_CLERK1.ValueMember = "work_no"

        dw = Getdata("select work_no,name from TALLY_CLERK order by name", dsclerk2)
        CombTALLY_CLERK2.DataSource = dsclerk2.Tables(0).DefaultView
        CombTALLY_CLERK2.DisplayMember = "name"
        CombTALLY_CLERK2.ValueMember = "work_no"

        dw = Getdata("select work_no,name from TALLY_CLERK order by name", dsclerk3)
        CombTALLY_CLERK3.DataSource = dsclerk3.Tables(0).DefaultView
        CombTALLY_CLERK3.DisplayMember = "name"
        CombTALLY_CLERK3.ValueMember = "work_no"


        dw = Updatedata(sqlda, "select * from cargo_waitfor where CARGO_WAITFOR_ID='" & ID & "'", ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            TxtTime_from.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_from"))), "", Trim(ds.Tables(0).Rows(0).Item("time_from")))
            Txttime_to.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_to"))), "", Trim(ds.Tables(0).Rows(0).Item("time_to")))
            CombHATCH_NO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("hatch_no"))), "", Trim(ds.Tables(0).Rows(0).Item("hatch_no")))
            CombBERTHNO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("BERTHNO"))), "", Trim(ds.Tables(0).Rows(0).Item("BERTHNO")))
            TxtSHIP_WATCH.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("SHIP_WATCH"))), "", Trim(ds.Tables(0).Rows(0).Item("SHIP_WATCH")))
            DTPSTANDBYDATE.Value = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("STANDBYDATE"))), Now, Trim(ds.Tables(0).Rows(0).Item("STANDBYDATE")))
            TxtPERSON.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("PERSON"))), Now, Trim(ds.Tables(0).Rows(0).Item("PERSON")))
            TxtWORK_TYPE.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("WORK_TYPE"))), "", Trim(ds.Tables(0).Rows(0).Item("WORK_TYPE")))
            TxtSHIP_WATCH.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("SHIP_WATCH"))), "", Trim(ds.Tables(0).Rows(0).Item("SHIP_WATCH")))
            TxtCAUSE.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("CAUSE"))), "", Trim(ds.Tables(0).Rows(0).Item("CAUSE")))
            TxtNO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("no"))), "", Trim(ds.Tables(0).Rows(0).Item("no")))
            txtteam_no.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("team_no"))), "", Trim(ds.Tables(0).Rows(0).Item("team_no")))
            'Call clerk()

            CombTALLY_CLERK1.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk1"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk1")))
            CombTALLY_CLERK2.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk2"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk2")))
            CombTALLY_CLERK3.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk3"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk3")))
            If ds.Tables(0).Rows(0).Item("HOLIDAY") = 1 Then
                CBHOLIDAY.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("NIGHT_MARK") = 1 Then
                CBNIGHT_MARK.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("MANAGER_DS") = 1 Then
                CBMANAGER_DS.Checked = True
            End If
            Call CBNIGHT_SELECT()

        End If


        Exit Sub
Err:
        Resume Next
    End Sub
    Private Sub clerk()
        Try

            dw = Getdata("exec sp_waitfor_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & TxtTime_from.Text & "','" & DTPSTANDBYDATE.Value & "'", dsclerk)
            CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
            CombTALLY_CLERK1.DisplayMember = "name"
            CombTALLY_CLERK1.ValueMember = "work_no"


            dw = Getdata("exec sp_waitfor_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & TxtTime_from.Text & "','" & DTPSTANDBYDATE.Value & "'", dsclerk2)
            CombTALLY_CLERK2.DataSource = dsclerk2.Tables(0).DefaultView
            CombTALLY_CLERK2.DisplayMember = "name"
            CombTALLY_CLERK2.ValueMember = "work_no"

            dw = Getdata("exec sp_waitfor_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & TxtTime_from.Text & "','" & DTPSTANDBYDATE.Value & "'", dsclerk3)
            CombTALLY_CLERK3.DataSource = dsclerk3.Tables(0).DefaultView
            CombTALLY_CLERK3.DisplayMember = "name"
            CombTALLY_CLERK3.ValueMember = "work_no"

        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub CBNIGHT_SELECT()
        CBNIGHT_MARK.Enabled = True
        If Len(Trim(TxtTime_from.Text)) = 4 Then
            If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(TxtTime_from.Text), 3, 2), Integer) < 60 Then
                If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) >= 6 And CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 22 Then
                    CBNIGHT_MARK.Checked = False
                    CBNIGHT_MARK.Enabled = False
                End If
                If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 6 Or CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) = 22 Or CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) = 23 Then
                    CBNIGHT_MARK.Checked = True
                    CBNIGHT_MARK.Enabled = True
                End If
            Else
                MsgBox("开始时间输入有误！")
                TxtTime_from.Focus()
            End If
        Else
            MsgBox("开始时间输入有误！")
            TxtTime_from.Focus()
        End If
    End Sub
    Private Sub DTPSTANDBYDATE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPSTANDBYDATE.Leave

        'Call clerk()
        'CombTALLY_CLERK1.SelectedValue = ""
        'CombTALLY_CLERK2.SelectedValue = ""
        'CombTALLY_CLERK3.SelectedValue = ""
        'If dsclerk.Tables(0).Rows.Count > 0 Then
        '    TxtWORK_TYPE.Text = dsclerk.Tables(0).Rows(0).Item("work_type")
        'End If

    End Sub

    Private Sub TxtTime_from_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTime_from.Leave

        'Call clerk()
        'CombTALLY_CLERK1.SelectedValue = ""
        'CombTALLY_CLERK2.SelectedValue = ""
        'CombTALLY_CLERK3.SelectedValue = ""
        'If dsclerk.Tables(0).Rows.Count > 0 Then
        '    TxtWORK_TYPE.Text = dsclerk.Tables(0).Rows(0).Item("work_type")
        'End If
        Call CBNIGHT_SELECT()

    End Sub
    Private Sub CombBERTHNO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombBERTHNO.Leave
        Dim DSSELECT As New DataSet()
        Try
            If Len(Trim(CombBERTHNO.Text)) > 0 Then
                If Mid(Trim(CombBERTHNO.Text), 1, 1) = "0" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "1" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "2" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "3" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "4" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "5" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "6" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "7" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "8" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "9" Then
                    dw = Getdata("SELECT * FROM CODE_BERTH WHERE CODE_BERTH='" & Trim(CombBERTHNO.Text) & "'", DSSELECT)
                    If DSSELECT.Tables(0).Rows.Count > 0 Then
                        CombBERTHNO.SelectedValue = Trim(CombBERTHNO.Text)
                    Else
                        MsgBox("没有该泊位号，请检查输入是否正确！")
                        CombBERTHNO.Focus()
                    End If
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CombHATCH_NO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombHATCH_NO.Leave
        Dim DSSELECT As New DataSet()
        Try
            If Len(Trim(CombHATCH_NO.Text)) > 0 Then
                If Mid(Trim(CombHATCH_NO.Text), 1, 1) = "0" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "1" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "2" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "3" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "4" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "5" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "6" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "7" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "8" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "9" Then
                    If Len(Trim(CombHATCH_NO.Text)) = 1 Then
                        CombHATCH_NO.Text = "0" + CType(Trim(CombHATCH_NO.Text), String)
                    End If
                    dw = Getdata("SELECT * FROM CODECABIN WHERE VALUE='" & Trim(CombHATCH_NO.Text) & "'  or DESCR='" & Trim(CombHATCH_NO.Text) & "'", DSSELECT)
                    If DSSELECT.Tables(0).Rows.Count > 0 Then
                        CombHATCH_NO.SelectedValue = DSSELECT.Tables(0).Rows(0).Item("value")
                    Else
                        MsgBox("没有该舱别，请检查输入是否正确！")
                        CombHATCH_NO.Focus()
                    End If
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()

    End Sub
    Private Sub txtno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNO.KeyPress
        If e.KeyChar = Chr(13) Then
            CombBERTHNO.Focus()
        End If
    End Sub
    Private Sub CombBERTHNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombBERTHNO.KeyPress
        If e.KeyChar = Chr(13) Then
            CombHATCH_NO.Focus()
        End If
    End Sub
    Private Sub CombHATCH_NO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombHATCH_NO.KeyPress
        If e.KeyChar = Chr(13) Then
            DTPSTANDBYDATE.Focus()
        End If
    End Sub
    Private Sub DTPSTANDBYDATE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPSTANDBYDATE.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtTime_from.Focus()
        End If
    End Sub
    Private Sub TxtTime_from_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTime_from.KeyPress
        If e.KeyChar = Chr(13) Then
            Txttime_to.Focus()
        End If
    End Sub
    Private Sub TxtTime_to_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txttime_to.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtWORK_TYPE.Focus()
        End If
    End Sub
    Private Sub TxtWORK_TYPE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtWORK_TYPE.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPERSON.Focus()
        End If
    End Sub
    Private Sub TxtPERSON_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPERSON.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK1.Focus()
        End If
    End Sub
    Private Sub CombTALLY_CLERK1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK1.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK2.Focus()
        End If
    End Sub
    Private Sub CombTALLY_CLERK2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK2.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK3.Focus()
        End If
    End Sub
    Private Sub CombTALLY_CLERK3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK3.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtSHIP_WATCH.Focus()
        End If
    End Sub
    Private Sub TxtSHIP_WATCH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSHIP_WATCH.KeyPress
        If e.KeyChar = Chr(13) Then
            CBHOLIDAY.Focus()
        End If
    End Sub
    Private Sub CBHOLIDAY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBHOLIDAY.KeyPress
        If e.KeyChar = Chr(13) Then
            CBNIGHT_MARK.Focus()
        End If
    End Sub
    Private Sub CBNIGHT_MARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBNIGHT_MARK.KeyPress
        If e.KeyChar = Chr(13) Then
            CBMANAGER_DS.Focus()
        End If
    End Sub
    Private Sub CBMANAGER_DS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBMANAGER_DS.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtCAUSE.Focus()
        End If
    End Sub
    Private Sub TxtCAUSE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCAUSE.KeyPress
        If e.KeyChar = Chr(13) Then
            BTOK.Focus()
        End If
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Try
            If Len(Trim(TxtTime_from.Text)) = 4 Then
                If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(TxtTime_from.Text), 3, 2), Integer) < 60 Then
                    If Len(Trim(Txttime_to.Text)) = 4 Then
                        If CType(Mid(Trim(Txttime_to.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(Txttime_to.Text), 3, 2), Integer) < 60 Then
                            If Len(Trim(DTPSTANDBYDATE.Value)) > 0 Then
                                If CombTALLY_CLERK1.Text.Trim().Length() > 0 Then
                                    If MsgBox("确认要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                                        OperateHistory(G_DeptName, Now, G_User, "编辑", "cargo_waitfor", ID, "cargo_waitfor_id")
                                        ds.Tables(0).Rows(0).Item("time_from") = Trim(TxtTime_from.Text)
                                        ds.Tables(0).Rows(0).Item("time_to") = Trim(Txttime_to.Text)
                                        ds.Tables(0).Rows(0).Item("TALLY_CLERK1") = IIf(Len(Trim(CombTALLY_CLERK1.SelectedValue)) > 0, Trim(CombTALLY_CLERK1.SelectedValue), "00")
                                        ds.Tables(0).Rows(0).Item("TALLY_CLERK2") = IIf(Len(Trim(CombTALLY_CLERK2.SelectedValue)) > 0, Trim(CombTALLY_CLERK2.SelectedValue), "00")
                                        ds.Tables(0).Rows(0).Item("TALLY_CLERK3") = IIf(Len(Trim(CombTALLY_CLERK3.SelectedValue)) > 0, Trim(CombTALLY_CLERK3.SelectedValue), "00")
                                        ds.Tables(0).Rows(0).Item("USER_NAME") = Trim(G_User)
                                        ds.Tables(0).Rows(0).Item("BERTHNO") = CombBERTHNO.SelectedValue
                                        ds.Tables(0).Rows(0).Item("HATCH_NO") = CombHATCH_NO.SelectedValue
                                        ds.Tables(0).Rows(0).Item("STANDBYDATE") = DTPSTANDBYDATE.Value
                                        ds.Tables(0).Rows(0).Item("WORK_TYPE") = Trim(TxtWORK_TYPE.Text)
                                        ds.Tables(0).Rows(0).Item("PERSON") = Trim(TxtPERSON.Text)
                                        ds.Tables(0).Rows(0).Item("SHIP_WATCH") = Trim(TxtSHIP_WATCH.Text)
                                        ds.Tables(0).Rows(0).Item("CAUSE") = Trim(TxtCAUSE.Text)
                                        ds.Tables(0).Rows(0).Item("no") = Trim(TxtNO.Text)
                                        ds.Tables(0).Rows(0).Item("team_no") = Trim(txtteam_no.Text)

                                        If CBHOLIDAY.Checked = True Then
                                            ds.Tables(0).Rows(0).Item("holiday") = "1"
                                        Else
                                            ds.Tables(0).Rows(0).Item("holiday") = "0"
                                        End If
                                        If CBNIGHT_MARK.Checked = True Then
                                            ds.Tables(0).Rows(0).Item("NIGHT_MARK") = "1"
                                        Else
                                            ds.Tables(0).Rows(0).Item("NIGHT_MARK") = "0"
                                        End If
                                        If CBMANAGER_DS.Checked = True Then
                                            ds.Tables(0).Rows(0).Item("MANAGER_DS") = "1"
                                        Else
                                            ds.Tables(0).Rows(0).Item("MANAGER_DS") = "0"
                                        End If
                                        sqlda.Update(ds)
                                        Call BTQUIT_Click(sender, e)

                                    End If
                                Else
                                    MsgBox("理货员不能为空。")
                                End If
                            Else
                                MsgBox("待时日期不能为空！")
                            End If
                        Else
                            MsgBox("待时结束时间填写错误！请填写4位数字，不加冒号。")
                        End If
                    Else
                        MsgBox("待时结束时间填写错误！请填写4位数字，不加冒号。")
                    End If
                Else
                    MsgBox("待时开始时间填写错误！请填写4位数字，不加冒号。")
                End If
            Else
                MsgBox("待时开始时间填写错误！请填写4位数字，不加冒号。")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CombTALLY_CLERK1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombTALLY_CLERK1.Leave
        Dim str As String

        If CombTALLY_CLERK1.Text.Trim().Length > 0 Then
            If (Asc(Mid(CombTALLY_CLERK1.Text.Trim(), 1, 1)) >= Asc("a") And Asc(Mid(CombTALLY_CLERK1.Text.Trim(), 1, 1)) <= Asc("z")) Or (Asc(Mid(CombTALLY_CLERK1.Text.Trim(), 1, 1)) >= Asc("A") And Asc(Mid(CombTALLY_CLERK1.Text.Trim(), 1, 1)) <= Asc("Z")) Then
                dss.Reset()
                str = "SELECT NAME, WORK_NO,Tally_Short FROM TALLY_CLERK where Tally_Short='" & CombTALLY_CLERK1.Text.Trim() & "'  order by NAME"
                dw = Getdata(str, dss)
                If dw.Count > 0 Then
                    'CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
                    'CombTALLY_CLERK1.DisplayMember = "NAME"
                    'CombTALLY_CLERK1.ValueMember = "WORK_NO"
                    CombTALLY_CLERK1.SelectedValue = dss.Tables(0).Rows(0)("WORK_NO")
                End If
            End If
        End If
    End Sub

    Private Sub CombTALLY_CLERK2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombTALLY_CLERK2.Leave
        Dim str As String

        If CombTALLY_CLERK2.Text.Trim().Length > 0 Then
            If (Asc(Mid(CombTALLY_CLERK2.Text.Trim(), 1, 1)) >= Asc("a") And Asc(Mid(CombTALLY_CLERK2.Text.Trim(), 1, 1)) <= Asc("z")) Or (Asc(Mid(CombTALLY_CLERK2.Text.Trim(), 1, 1)) >= Asc("A") And Asc(Mid(CombTALLY_CLERK2.Text.Trim(), 1, 1)) <= Asc("Z")) Then
                dss.Reset()
                str = "SELECT NAME, WORK_NO,Tally_Short FROM TALLY_CLERK where Tally_Short='" & CombTALLY_CLERK2.Text.Trim() & "'  order by NAME"
                dw = Getdata(str, dss)
                If dw.Count > 0 Then
                    'CombTALLY_CLERK2.DataSource = dsclerk2.Tables(0).DefaultView
                    'CombTALLY_CLERK2.DisplayMember = "NAME"
                    'CombTALLY_CLERK2.ValueMember = "WORK_NO"
                    CombTALLY_CLERK2.SelectedValue = dss.Tables(0).Rows(0)("WORK_NO")
                End If
            End If
        End If
    End Sub

    Private Sub CombTALLY_CLERK3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombTALLY_CLERK3.Leave
        Dim str As String

        If CombTALLY_CLERK3.Text.Trim().Length > 0 Then
            If (Asc(Mid(CombTALLY_CLERK3.Text.Trim(), 1, 1)) >= Asc("a") And Asc(Mid(CombTALLY_CLERK3.Text.Trim(), 1, 1)) <= Asc("z")) Or (Asc(Mid(CombTALLY_CLERK3.Text.Trim(), 1, 1)) >= Asc("A") And Asc(Mid(CombTALLY_CLERK3.Text.Trim(), 1, 1)) <= Asc("Z")) Then
                dss.Reset()
                str = "SELECT NAME, WORK_NO,Tally_Short FROM TALLY_CLERK where Tally_Short='" & CombTALLY_CLERK3.Text.Trim() & "'  order by NAME"
                dw = Getdata(str, dss)
                If dw.Count > 0 Then
                    'CombTALLY_CLERK3.DataSource = dsclerk3.Tables(0).DefaultView
                    'CombTALLY_CLERK3.DisplayMember = "NAME"
                    'CombTALLY_CLERK3.ValueMember = "WORK_NO"
                    CombTALLY_CLERK3.SelectedValue = dss.Tables(0).Rows(0)("WORK_NO")
                End If
            End If
        End If
    End Sub
End Class
