Imports TALLY.DBControl
Public Class FrmCARGO_WAITFOR_QUERY
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsberth As New DataSet()
    Dim dshatch_no As New DataSet()
    Dim dsclerk As New DataSet()
    Dim dsclerk2 As New DataSet()
    Dim dsclerk3 As New DataSet()
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
    Friend WithEvents TxtCAUSE As System.Windows.Forms.TextBox
    Friend WithEvents TxtSHIP_WATCH As System.Windows.Forms.TextBox
    Friend WithEvents TxtPERSON As System.Windows.Forms.TextBox
    Friend WithEvents TxtWORK_TYPE As System.Windows.Forms.TextBox
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.TxtCAUSE = New System.Windows.Forms.TextBox()
        Me.TxtSHIP_WATCH = New System.Windows.Forms.TextBox()
        Me.TxtPERSON = New System.Windows.Forms.TextBox()
        Me.TxtWORK_TYPE = New System.Windows.Forms.TextBox()
        Me.TxtTime_from = New System.Windows.Forms.TextBox()
        Me.Txttime_to = New System.Windows.Forms.TextBox()
        Me.DTPSTANDBYDATE = New System.Windows.Forms.DateTimePicker()
        Me.CombTALLY_CLERK3 = New System.Windows.Forms.ComboBox()
        Me.CombTALLY_CLERK2 = New System.Windows.Forms.ComboBox()
        Me.CombTALLY_CLERK1 = New System.Windows.Forms.ComboBox()
        Me.CombHATCH_NO = New System.Windows.Forms.ComboBox()
        Me.CombBERTHNO = New System.Windows.Forms.ComboBox()
        Me.CBMANAGER_DS = New System.Windows.Forms.CheckBox()
        Me.CBNIGHT_MARK = New System.Windows.Forms.CheckBox()
        Me.CBHOLIDAY = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNO = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(221, 220)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 113
        Me.BTQUIT.Text = "取消"
        '
        'TxtCAUSE
        '
        Me.TxtCAUSE.Enabled = False
        Me.TxtCAUSE.Location = New System.Drawing.Point(282, 154)
        Me.TxtCAUSE.MaxLength = 100
        Me.TxtCAUSE.Multiline = True
        Me.TxtCAUSE.Name = "TxtCAUSE"
        Me.TxtCAUSE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtCAUSE.Size = New System.Drawing.Size(210, 46)
        Me.TxtCAUSE.TabIndex = 111
        Me.TxtCAUSE.Text = ""
        '
        'TxtSHIP_WATCH
        '
        Me.TxtSHIP_WATCH.Enabled = False
        Me.TxtSHIP_WATCH.Location = New System.Drawing.Point(282, 126)
        Me.TxtSHIP_WATCH.MaxLength = 10
        Me.TxtSHIP_WATCH.Name = "TxtSHIP_WATCH"
        Me.TxtSHIP_WATCH.Size = New System.Drawing.Size(102, 21)
        Me.TxtSHIP_WATCH.TabIndex = 110
        Me.TxtSHIP_WATCH.Text = ""
        '
        'TxtPERSON
        '
        Me.TxtPERSON.Enabled = False
        Me.TxtPERSON.Location = New System.Drawing.Point(282, 14)
        Me.TxtPERSON.Name = "TxtPERSON"
        Me.TxtPERSON.Size = New System.Drawing.Size(102, 21)
        Me.TxtPERSON.TabIndex = 109
        Me.TxtPERSON.Text = ""
        '
        'TxtWORK_TYPE
        '
        Me.TxtWORK_TYPE.Enabled = False
        Me.TxtWORK_TYPE.Location = New System.Drawing.Point(96, 182)
        Me.TxtWORK_TYPE.MaxLength = 2
        Me.TxtWORK_TYPE.Name = "TxtWORK_TYPE"
        Me.TxtWORK_TYPE.Size = New System.Drawing.Size(108, 21)
        Me.TxtWORK_TYPE.TabIndex = 108
        Me.TxtWORK_TYPE.Text = ""
        '
        'TxtTime_from
        '
        Me.TxtTime_from.Enabled = False
        Me.TxtTime_from.Location = New System.Drawing.Point(96, 126)
        Me.TxtTime_from.MaxLength = 4
        Me.TxtTime_from.Name = "TxtTime_from"
        Me.TxtTime_from.Size = New System.Drawing.Size(108, 21)
        Me.TxtTime_from.TabIndex = 107
        Me.TxtTime_from.Text = ""
        '
        'Txttime_to
        '
        Me.Txttime_to.Enabled = False
        Me.Txttime_to.Location = New System.Drawing.Point(96, 154)
        Me.Txttime_to.MaxLength = 4
        Me.Txttime_to.Name = "Txttime_to"
        Me.Txttime_to.Size = New System.Drawing.Size(108, 21)
        Me.Txttime_to.TabIndex = 106
        Me.Txttime_to.Text = ""
        '
        'DTPSTANDBYDATE
        '
        Me.DTPSTANDBYDATE.CustomFormat = "yyyy-MM-dd"
        Me.DTPSTANDBYDATE.Enabled = False
        Me.DTPSTANDBYDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPSTANDBYDATE.Location = New System.Drawing.Point(96, 98)
        Me.DTPSTANDBYDATE.Name = "DTPSTANDBYDATE"
        Me.DTPSTANDBYDATE.Size = New System.Drawing.Size(108, 21)
        Me.DTPSTANDBYDATE.TabIndex = 105
        '
        'CombTALLY_CLERK3
        '
        Me.CombTALLY_CLERK3.Enabled = False
        Me.CombTALLY_CLERK3.Location = New System.Drawing.Point(282, 98)
        Me.CombTALLY_CLERK3.Name = "CombTALLY_CLERK3"
        Me.CombTALLY_CLERK3.Size = New System.Drawing.Size(102, 20)
        Me.CombTALLY_CLERK3.TabIndex = 104
        '
        'CombTALLY_CLERK2
        '
        Me.CombTALLY_CLERK2.Enabled = False
        Me.CombTALLY_CLERK2.Location = New System.Drawing.Point(282, 70)
        Me.CombTALLY_CLERK2.Name = "CombTALLY_CLERK2"
        Me.CombTALLY_CLERK2.Size = New System.Drawing.Size(102, 20)
        Me.CombTALLY_CLERK2.TabIndex = 103
        '
        'CombTALLY_CLERK1
        '
        Me.CombTALLY_CLERK1.Enabled = False
        Me.CombTALLY_CLERK1.Location = New System.Drawing.Point(282, 42)
        Me.CombTALLY_CLERK1.Name = "CombTALLY_CLERK1"
        Me.CombTALLY_CLERK1.Size = New System.Drawing.Size(102, 20)
        Me.CombTALLY_CLERK1.TabIndex = 102
        '
        'CombHATCH_NO
        '
        Me.CombHATCH_NO.Enabled = False
        Me.CombHATCH_NO.Location = New System.Drawing.Point(96, 70)
        Me.CombHATCH_NO.Name = "CombHATCH_NO"
        Me.CombHATCH_NO.Size = New System.Drawing.Size(108, 20)
        Me.CombHATCH_NO.TabIndex = 101
        '
        'CombBERTHNO
        '
        Me.CombBERTHNO.Enabled = False
        Me.CombBERTHNO.Location = New System.Drawing.Point(96, 42)
        Me.CombBERTHNO.Name = "CombBERTHNO"
        Me.CombBERTHNO.Size = New System.Drawing.Size(108, 20)
        Me.CombBERTHNO.TabIndex = 100
        '
        'CBMANAGER_DS
        '
        Me.CBMANAGER_DS.Enabled = False
        Me.CBMANAGER_DS.Location = New System.Drawing.Point(396, 96)
        Me.CBMANAGER_DS.Name = "CBMANAGER_DS"
        Me.CBMANAGER_DS.Size = New System.Drawing.Size(98, 20)
        Me.CBMANAGER_DS.TabIndex = 99
        Me.CBMANAGER_DS.Text = "理货组长待时"
        Me.CBMANAGER_DS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBNIGHT_MARK
        '
        Me.CBNIGHT_MARK.Enabled = False
        Me.CBNIGHT_MARK.Location = New System.Drawing.Point(396, 56)
        Me.CBNIGHT_MARK.Name = "CBNIGHT_MARK"
        Me.CBNIGHT_MARK.Size = New System.Drawing.Size(98, 20)
        Me.CBNIGHT_MARK.TabIndex = 97
        Me.CBNIGHT_MARK.Text = "夜班"
        Me.CBNIGHT_MARK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBHOLIDAY
        '
        Me.CBHOLIDAY.Enabled = False
        Me.CBHOLIDAY.Location = New System.Drawing.Point(396, 16)
        Me.CBHOLIDAY.Name = "CBHOLIDAY"
        Me.CBHOLIDAY.Size = New System.Drawing.Size(98, 20)
        Me.CBHOLIDAY.TabIndex = 96
        Me.CBHOLIDAY.Text = "节假日"
        Me.CBHOLIDAY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(208, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 22)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "船方值班员"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(208, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 22)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "理货员3"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(208, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 22)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "理货员2"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(208, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 22)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "理货员1"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(208, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 22)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "原因"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(208, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 22)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "待时人数"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 22)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "班次"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 22)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "待时结束时间"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 22)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "待时开始时间"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 22)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "待时日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 22)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "舱别"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "泊位号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNO
        '
        Me.TxtNO.Enabled = False
        Me.TxtNO.Location = New System.Drawing.Point(96, 14)
        Me.TxtNO.MaxLength = 5
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(108, 21)
        Me.TxtNO.TabIndex = 115
        Me.TxtNO.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(12, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 22)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "编号"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCARGO_WAITFOR_QUERY
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(506, 263)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtNO, Me.Label13, Me.BTQUIT, Me.TxtCAUSE, Me.TxtSHIP_WATCH, Me.TxtPERSON, Me.TxtWORK_TYPE, Me.TxtTime_from, Me.Txttime_to, Me.DTPSTANDBYDATE, Me.CombTALLY_CLERK3, Me.CombTALLY_CLERK2, Me.CombTALLY_CLERK1, Me.CombHATCH_NO, Me.CombBERTHNO, Me.CBMANAGER_DS, Me.CBNIGHT_MARK, Me.CBHOLIDAY, Me.Label12, Me.Label11, Me.Label10, Me.Label9, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCARGO_WAITFOR_QUERY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "待时记录_查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCARGO_WAITFOR_QUERY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE_BERTH,NAME_BERTH from CODE_BERTH ", dsberth)
        CombBERTHNO.DataSource = dsberth.Tables(0).DefaultView
        CombBERTHNO.DisplayMember = "NAME_BERTH"
        CombBERTHNO.ValueMember = "CODE_BERTH"

        dw = Getdata("select value,descr from codecabin", dshatch_no)
        CombHATCH_NO.DataSource = dshatch_no.Tables(0).DefaultView
        CombHATCH_NO.DisplayMember = "descr"
        CombHATCH_NO.ValueMember = "value"

        dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk)
        CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
        CombTALLY_CLERK1.DisplayMember = "name"
        CombTALLY_CLERK1.ValueMember = "work_no"

        dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk2)
        CombTALLY_CLERK2.DataSource = dsclerk2.Tables(0).DefaultView
        CombTALLY_CLERK2.DisplayMember = "name"
        CombTALLY_CLERK2.ValueMember = "work_no"

        dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk3)
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
            'Call clerk()

            CombTALLY_CLERK1.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk1"))), "", Trim(ds.Tables(0).Rows(0).Item("tally_clerk1")))
            CombTALLY_CLERK2.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk2"))), "", Trim(ds.Tables(0).Rows(0).Item("tally_clerk2")))
            CombTALLY_CLERK3.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk3"))), "", Trim(ds.Tables(0).Rows(0).Item("tally_clerk3")))
            If ds.Tables(0).Rows(0).Item("HOLIDAY") = 1 Then
                CBHOLIDAY.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("NIGHT_MARK") = 1 Then
                CBNIGHT_MARK.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("MANAGER_DS") = 1 Then
                CBMANAGER_DS.Checked = True
            End If

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
    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()

    End Sub
End Class
