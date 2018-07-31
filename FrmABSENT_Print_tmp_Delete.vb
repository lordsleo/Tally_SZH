Imports TALLY.DBControl
Public Class FrmABSENT_Print_tmp_Delete
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()

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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtWORK_overtime_sum As System.Windows.Forms.TextBox
    Friend WithEvents DTPABSENT_Month As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbWORK_NAME As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtWORK_DAYNIGHT_F As System.Windows.Forms.TextBox
    Friend WithEvents TxtWORK_DAYNIGHT_H As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox10 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox11 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox12 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox13 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox14 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox15 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox16 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox17 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox18 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox19 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox20 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox21 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox22 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox23 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox24 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox25 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox26 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox27 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox28 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox29 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox30 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox31 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button
        Me.btResume = New System.Windows.Forms.Button
        Me.txtID = New System.Windows.Forms.TextBox
        Me.DTPABSENT_Month = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtWORK_overtime_sum = New System.Windows.Forms.TextBox
        Me.CmbWORK_NAME = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtWORK_DAYNIGHT_F = New System.Windows.Forms.TextBox
        Me.TxtWORK_DAYNIGHT_H = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtMark = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.ComboBox6 = New System.Windows.Forms.ComboBox
        Me.ComboBox7 = New System.Windows.Forms.ComboBox
        Me.ComboBox8 = New System.Windows.Forms.ComboBox
        Me.ComboBox9 = New System.Windows.Forms.ComboBox
        Me.ComboBox10 = New System.Windows.Forms.ComboBox
        Me.ComboBox11 = New System.Windows.Forms.ComboBox
        Me.ComboBox12 = New System.Windows.Forms.ComboBox
        Me.ComboBox13 = New System.Windows.Forms.ComboBox
        Me.ComboBox14 = New System.Windows.Forms.ComboBox
        Me.ComboBox15 = New System.Windows.Forms.ComboBox
        Me.ComboBox16 = New System.Windows.Forms.ComboBox
        Me.ComboBox17 = New System.Windows.Forms.ComboBox
        Me.ComboBox18 = New System.Windows.Forms.ComboBox
        Me.ComboBox19 = New System.Windows.Forms.ComboBox
        Me.ComboBox20 = New System.Windows.Forms.ComboBox
        Me.ComboBox21 = New System.Windows.Forms.ComboBox
        Me.ComboBox22 = New System.Windows.Forms.ComboBox
        Me.ComboBox23 = New System.Windows.Forms.ComboBox
        Me.ComboBox24 = New System.Windows.Forms.ComboBox
        Me.ComboBox25 = New System.Windows.Forms.ComboBox
        Me.ComboBox26 = New System.Windows.Forms.ComboBox
        Me.ComboBox27 = New System.Windows.Forms.ComboBox
        Me.ComboBox28 = New System.Windows.Forms.ComboBox
        Me.ComboBox29 = New System.Windows.Forms.ComboBox
        Me.ComboBox30 = New System.Windows.Forms.ComboBox
        Me.ComboBox31 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(237, 417)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 39
        Me.btQuit.Text = "取消"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(167, 417)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 38
        Me.btResume.Text = "确认"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(368, 416)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(20, 21)
        Me.txtID.TabIndex = 103
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'DTPABSENT_Month
        '
        Me.DTPABSENT_Month.CustomFormat = "yyyy-MM"
        Me.DTPABSENT_Month.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPABSENT_Month.Location = New System.Drawing.Point(364, 6)
        Me.DTPABSENT_Month.Name = "DTPABSENT_Month"
        Me.DTPABSENT_Month.Size = New System.Drawing.Size(98, 21)
        Me.DTPABSENT_Month.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(320, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "日期"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "姓名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(305, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "加班天数"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtWORK_overtime_sum
        '
        Me.TxtWORK_overtime_sum.Location = New System.Drawing.Point(364, 342)
        Me.TxtWORK_overtime_sum.Name = "TxtWORK_overtime_sum"
        Me.TxtWORK_overtime_sum.Size = New System.Drawing.Size(98, 21)
        Me.TxtWORK_overtime_sum.TabIndex = 36
        Me.TxtWORK_overtime_sum.Text = ""
        '
        'CmbWORK_NAME
        '
        Me.CmbWORK_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbWORK_NAME.Location = New System.Drawing.Point(52, 6)
        Me.CmbWORK_NAME.Name = "CmbWORK_NAME"
        Me.CmbWORK_NAME.Size = New System.Drawing.Size(98, 20)
        Me.CmbWORK_NAME.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "小夜班"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(156, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "大夜班"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtWORK_DAYNIGHT_F
        '
        Me.TxtWORK_DAYNIGHT_F.Location = New System.Drawing.Point(204, 341)
        Me.TxtWORK_DAYNIGHT_F.Name = "TxtWORK_DAYNIGHT_F"
        Me.TxtWORK_DAYNIGHT_F.Size = New System.Drawing.Size(98, 21)
        Me.TxtWORK_DAYNIGHT_F.TabIndex = 35
        Me.TxtWORK_DAYNIGHT_F.Text = ""
        '
        'TxtWORK_DAYNIGHT_H
        '
        Me.TxtWORK_DAYNIGHT_H.Location = New System.Drawing.Point(53, 341)
        Me.TxtWORK_DAYNIGHT_H.Name = "TxtWORK_DAYNIGHT_H"
        Me.TxtWORK_DAYNIGHT_H.Size = New System.Drawing.Size(98, 21)
        Me.TxtWORK_DAYNIGHT_H.TabIndex = 34
        Me.TxtWORK_DAYNIGHT_H.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 39)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "备注"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtMark
        '
        Me.TxtMark.Location = New System.Drawing.Point(54, 369)
        Me.TxtMark.MaxLength = 10
        Me.TxtMark.Multiline = True
        Me.TxtMark.Name = "TxtMark"
        Me.TxtMark.Size = New System.Drawing.Size(408, 39)
        Me.TxtMark.TabIndex = 37
        Me.TxtMark.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(164, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 20)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "部门"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(206, 6)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(98, 20)
        Me.CmbDEPT_CODE.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(4, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 20)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "1号"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(4, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 20)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "2号"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(4, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 20)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "3号"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(4, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 20)
        Me.Label11.TabIndex = 127
        Me.Label11.Text = "4号"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(4, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 20)
        Me.Label12.TabIndex = 128
        Me.Label12.Text = "5号"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(4, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 20)
        Me.Label13.TabIndex = 129
        Me.Label13.Text = "6号"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(4, 202)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 20)
        Me.Label14.TabIndex = 130
        Me.Label14.Text = "7号"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(4, 230)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 20)
        Me.Label15.TabIndex = 131
        Me.Label15.Text = "8号"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(4, 258)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 20)
        Me.Label16.TabIndex = 132
        Me.Label16.Text = "9号"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(4, 286)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 20)
        Me.Label17.TabIndex = 133
        Me.Label17.Text = "10号"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(164, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 20)
        Me.Label18.TabIndex = 134
        Me.Label18.Text = "11号"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(164, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 20)
        Me.Label19.TabIndex = 135
        Me.Label19.Text = "12号"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(164, 90)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 20)
        Me.Label20.TabIndex = 136
        Me.Label20.Text = "13号"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(164, 118)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 20)
        Me.Label21.TabIndex = 137
        Me.Label21.Text = "14号"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(164, 146)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 20)
        Me.Label22.TabIndex = 138
        Me.Label22.Text = "15号"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(164, 174)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 20)
        Me.Label23.TabIndex = 139
        Me.Label23.Text = "16号"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(164, 202)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 20)
        Me.Label24.TabIndex = 140
        Me.Label24.Text = "17号"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(164, 230)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 20)
        Me.Label25.TabIndex = 141
        Me.Label25.Text = "18号"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(164, 258)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 20)
        Me.Label26.TabIndex = 142
        Me.Label26.Text = "19号"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(164, 286)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(40, 20)
        Me.Label27.TabIndex = 143
        Me.Label27.Text = "20号"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(320, 34)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(42, 20)
        Me.Label28.TabIndex = 144
        Me.Label28.Text = "21号"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(320, 62)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 20)
        Me.Label29.TabIndex = 145
        Me.Label29.Text = "22号"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(320, 90)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(42, 20)
        Me.Label30.TabIndex = 146
        Me.Label30.Text = "23号"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(320, 118)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(42, 20)
        Me.Label31.TabIndex = 147
        Me.Label31.Text = "24号"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(320, 146)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(42, 20)
        Me.Label32.TabIndex = 148
        Me.Label32.Text = "25号"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(320, 174)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(42, 20)
        Me.Label33.TabIndex = 149
        Me.Label33.Text = "26号"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(320, 202)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(42, 20)
        Me.Label34.TabIndex = 150
        Me.Label34.Text = "27号"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(320, 230)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(42, 20)
        Me.Label35.TabIndex = 151
        Me.Label35.Text = "28号"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(320, 258)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(42, 20)
        Me.Label36.TabIndex = 152
        Me.Label36.Text = "29号"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(320, 286)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(42, 20)
        Me.Label37.TabIndex = 153
        Me.Label37.Text = "30号"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(320, 314)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(42, 20)
        Me.Label38.TabIndex = 154
        Me.Label38.Text = "31号"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(52, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox1.TabIndex = 3
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Location = New System.Drawing.Point(52, 62)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox2.TabIndex = 4
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Location = New System.Drawing.Point(52, 90)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox3.TabIndex = 5
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Location = New System.Drawing.Point(52, 118)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox4.TabIndex = 6
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.Location = New System.Drawing.Point(52, 146)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox5.TabIndex = 7
        '
        'ComboBox6
        '
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.Location = New System.Drawing.Point(52, 174)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox6.TabIndex = 8
        '
        'ComboBox7
        '
        Me.ComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox7.Location = New System.Drawing.Point(52, 202)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox7.TabIndex = 9
        '
        'ComboBox8
        '
        Me.ComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox8.Location = New System.Drawing.Point(52, 230)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox8.TabIndex = 10
        '
        'ComboBox9
        '
        Me.ComboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox9.Location = New System.Drawing.Point(52, 258)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox9.TabIndex = 11
        '
        'ComboBox10
        '
        Me.ComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox10.Location = New System.Drawing.Point(52, 286)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox10.TabIndex = 12
        '
        'ComboBox11
        '
        Me.ComboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox11.Location = New System.Drawing.Point(206, 34)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox11.TabIndex = 13
        '
        'ComboBox12
        '
        Me.ComboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox12.Location = New System.Drawing.Point(206, 62)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox12.TabIndex = 14
        '
        'ComboBox13
        '
        Me.ComboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox13.Location = New System.Drawing.Point(206, 90)
        Me.ComboBox13.Name = "ComboBox13"
        Me.ComboBox13.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox13.TabIndex = 15
        '
        'ComboBox14
        '
        Me.ComboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox14.Location = New System.Drawing.Point(206, 118)
        Me.ComboBox14.Name = "ComboBox14"
        Me.ComboBox14.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox14.TabIndex = 16
        '
        'ComboBox15
        '
        Me.ComboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox15.Location = New System.Drawing.Point(206, 146)
        Me.ComboBox15.Name = "ComboBox15"
        Me.ComboBox15.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox15.TabIndex = 17
        '
        'ComboBox16
        '
        Me.ComboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox16.Location = New System.Drawing.Point(206, 174)
        Me.ComboBox16.Name = "ComboBox16"
        Me.ComboBox16.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox16.TabIndex = 18
        '
        'ComboBox17
        '
        Me.ComboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox17.Location = New System.Drawing.Point(206, 202)
        Me.ComboBox17.Name = "ComboBox17"
        Me.ComboBox17.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox17.TabIndex = 19
        '
        'ComboBox18
        '
        Me.ComboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox18.Location = New System.Drawing.Point(206, 230)
        Me.ComboBox18.Name = "ComboBox18"
        Me.ComboBox18.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox18.TabIndex = 20
        '
        'ComboBox19
        '
        Me.ComboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox19.Location = New System.Drawing.Point(206, 258)
        Me.ComboBox19.Name = "ComboBox19"
        Me.ComboBox19.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox19.TabIndex = 21
        '
        'ComboBox20
        '
        Me.ComboBox20.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox20.Location = New System.Drawing.Point(206, 286)
        Me.ComboBox20.Name = "ComboBox20"
        Me.ComboBox20.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox20.TabIndex = 22
        '
        'ComboBox21
        '
        Me.ComboBox21.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox21.Location = New System.Drawing.Point(364, 34)
        Me.ComboBox21.Name = "ComboBox21"
        Me.ComboBox21.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox21.TabIndex = 23
        '
        'ComboBox22
        '
        Me.ComboBox22.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox22.Location = New System.Drawing.Point(364, 62)
        Me.ComboBox22.Name = "ComboBox22"
        Me.ComboBox22.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox22.TabIndex = 24
        '
        'ComboBox23
        '
        Me.ComboBox23.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox23.Location = New System.Drawing.Point(364, 90)
        Me.ComboBox23.Name = "ComboBox23"
        Me.ComboBox23.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox23.TabIndex = 25
        '
        'ComboBox24
        '
        Me.ComboBox24.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox24.Location = New System.Drawing.Point(364, 118)
        Me.ComboBox24.Name = "ComboBox24"
        Me.ComboBox24.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox24.TabIndex = 26
        '
        'ComboBox25
        '
        Me.ComboBox25.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox25.Location = New System.Drawing.Point(364, 146)
        Me.ComboBox25.Name = "ComboBox25"
        Me.ComboBox25.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox25.TabIndex = 27
        '
        'ComboBox26
        '
        Me.ComboBox26.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox26.Location = New System.Drawing.Point(364, 174)
        Me.ComboBox26.Name = "ComboBox26"
        Me.ComboBox26.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox26.TabIndex = 28
        '
        'ComboBox27
        '
        Me.ComboBox27.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox27.Location = New System.Drawing.Point(364, 202)
        Me.ComboBox27.Name = "ComboBox27"
        Me.ComboBox27.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox27.TabIndex = 29
        '
        'ComboBox28
        '
        Me.ComboBox28.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox28.Location = New System.Drawing.Point(364, 230)
        Me.ComboBox28.Name = "ComboBox28"
        Me.ComboBox28.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox28.TabIndex = 30
        '
        'ComboBox29
        '
        Me.ComboBox29.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox29.Location = New System.Drawing.Point(364, 258)
        Me.ComboBox29.Name = "ComboBox29"
        Me.ComboBox29.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox29.TabIndex = 31
        '
        'ComboBox30
        '
        Me.ComboBox30.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox30.Location = New System.Drawing.Point(364, 286)
        Me.ComboBox30.Name = "ComboBox30"
        Me.ComboBox30.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox30.TabIndex = 32
        '
        'ComboBox31
        '
        Me.ComboBox31.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox31.Location = New System.Drawing.Point(364, 314)
        Me.ComboBox31.Name = "ComboBox31"
        Me.ComboBox31.Size = New System.Drawing.Size(98, 20)
        Me.ComboBox31.TabIndex = 33
        '
        'FrmABSENT_Print_tmp_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(468, 451)
        Me.Controls.Add(Me.ComboBox31)
        Me.Controls.Add(Me.ComboBox30)
        Me.Controls.Add(Me.ComboBox29)
        Me.Controls.Add(Me.ComboBox28)
        Me.Controls.Add(Me.ComboBox27)
        Me.Controls.Add(Me.ComboBox26)
        Me.Controls.Add(Me.ComboBox25)
        Me.Controls.Add(Me.ComboBox24)
        Me.Controls.Add(Me.ComboBox23)
        Me.Controls.Add(Me.ComboBox22)
        Me.Controls.Add(Me.ComboBox21)
        Me.Controls.Add(Me.ComboBox20)
        Me.Controls.Add(Me.ComboBox19)
        Me.Controls.Add(Me.ComboBox18)
        Me.Controls.Add(Me.ComboBox17)
        Me.Controls.Add(Me.ComboBox16)
        Me.Controls.Add(Me.ComboBox15)
        Me.Controls.Add(Me.ComboBox14)
        Me.Controls.Add(Me.ComboBox13)
        Me.Controls.Add(Me.ComboBox12)
        Me.Controls.Add(Me.ComboBox11)
        Me.Controls.Add(Me.ComboBox9)
        Me.Controls.Add(Me.ComboBox8)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbDEPT_CODE)
        Me.Controls.Add(Me.CmbWORK_NAME)
        Me.Controls.Add(Me.DTPABSENT_Month)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btResume)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtWORK_overtime_sum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtWORK_DAYNIGHT_F)
        Me.Controls.Add(Me.TxtWORK_DAYNIGHT_H)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtMark)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmABSENT_Print_tmp_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "机关考勤_删除"
        Me.ResumeLayout(False)

    End Sub

#End Region
    
    Private Sub FrmABSENT_Print_tmp_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Call FillWORK_NAME()
        Call FillDEPT_CODE()
        Call FillCode_HOLIDAY_TYPE()

        sqlstr = "select * from ABSENT_history where ABSENT_history_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("ABSENT_history_ID")
            CmbDEPT_CODE.SelectedValue = ds.Tables(0).Rows(0).Item("DEPT_CODE")
            CmbWORK_NAME.SelectedValue = ds.Tables(0).Rows(0).Item("WORK_NO")
            DTPABSENT_Month.Value = ds.Tables(0).Rows(0).Item("ABSENT_Month")

            ComboBox1.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_1")
            ComboBox2.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_2")
            ComboBox3.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_3")
            ComboBox4.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_4")
            ComboBox5.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_5")
            ComboBox6.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_6")
            ComboBox7.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_7")
            ComboBox8.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_8")
            ComboBox9.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_9")
            ComboBox10.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_10")
            ComboBox11.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_11")
            ComboBox12.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_12")
            ComboBox13.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_13")
            ComboBox14.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_14")
            ComboBox15.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_15")
            ComboBox16.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_16")
            ComboBox17.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_17")
            ComboBox18.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_18")
            ComboBox19.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_19")
            ComboBox20.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_20")
            ComboBox21.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_21")
            ComboBox22.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_22")
            ComboBox23.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_23")
            ComboBox24.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_24")
            ComboBox25.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_25")
            ComboBox26.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_26")
            ComboBox27.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_27")
            ComboBox28.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_28")


            ComboBox29.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_29")
            ComboBox30.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_30")
            ComboBox31.SelectedValue = ds.Tables(0).Rows(0).Item("DATE_31")

            TxtWORK_DAYNIGHT_H.Text = ds.Tables(0).Rows(0).Item("WORK_DAYNIGHT_H")
            TxtWORK_DAYNIGHT_F.Text = ds.Tables(0).Rows(0).Item("WORK_DAYNIGHT_F")
            If Len(Trim(ds.Tables(0).Rows(0).Item("WORK_overtime_sum"))) > 0 Then
                TxtWORK_overtime_sum.Text = ds.Tables(0).Rows(0).Item("WORK_overtime_sum")
            End If
            If Len(Trim(ds.Tables(0).Rows(0).Item("Mark"))) > 0 Then
                TxtMark.Text = ds.Tables(0).Rows(0).Item("Mark")
            End If
        End If
        TxtWORK_overtime_sum.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            If MsgBox("你确认要删除吗？", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "提示") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "删除", "ABSENT_history", Trim(txtID.Text), "ABSENT_history_ID")

                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)

                Call btQuit_Click(sender, e)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillWORK_NAME()
        Dim sqldc As String
        Dim dvc As New DataView()
        Dim dsc As New DataSet()
        sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE='" & G_DeptCode & "' order by NAME "

        Me.CmbWORK_NAME.DataSource = DBControl.Getdata(sqldc, dsc)
        Me.CmbWORK_NAME.DisplayMember = "NAME"
        Me.CmbWORK_NAME.ValueMember = "WORK_NO"
    End Sub

    Private Sub FillDEPT_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDEPT_CODE.DataSource = dvc
        Me.CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE.ValueMember = "DEPT_CODE"
    End Sub

    Private Sub FillCode_HOLIDAY_TYPE()
        Dim sqldc As String
        Dim dvc As New DataView()
        Dim dsc1 As New DataSet()
        Dim dsc2 As New DataSet()
        Dim dsc3 As New DataSet()
        Dim dsc4 As New DataSet()
        Dim dsc5 As New DataSet()
        Dim dsc6 As New DataSet()
        Dim dsc7 As New DataSet()
        Dim dsc8 As New DataSet()
        Dim dsc9 As New DataSet()
        Dim dsc10 As New DataSet()
        Dim dsc11 As New DataSet()
        Dim dsc12 As New DataSet()
        Dim dsc13 As New DataSet()
        Dim dsc14 As New DataSet()
        Dim dsc15 As New DataSet()
        Dim dsc16 As New DataSet()
        Dim dsc17 As New DataSet()
        Dim dsc18 As New DataSet()
        Dim dsc19 As New DataSet()
        Dim dsc20 As New DataSet()
        Dim dsc21 As New DataSet()
        Dim dsc22 As New DataSet()
        Dim dsc23 As New DataSet()
        Dim dsc24 As New DataSet()
        Dim dsc25 As New DataSet()
        Dim dsc26 As New DataSet()
        Dim dsc27 As New DataSet()
        Dim dsc28 As New DataSet()
        Dim dsc29 As New DataSet()
        Dim dsc30 As New DataSet()
        Dim dsc31 As New DataSet()

        sqldc = "SELECT Sign,Holiday_Type FROM Code_Holiday_Type "
        'WHERE ( Code_HOLIDAY_TYPE between 1 and 89 ) "

        dvc = DBControl.Getdata(sqldc, dsc1)
        Me.ComboBox1.DataSource = dsc1.Tables(0).DefaultView
        Me.ComboBox1.DisplayMember = "Holiday_Type"
        Me.ComboBox1.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc2)
        Me.ComboBox2.DataSource = dsc2.Tables(0).DefaultView
        Me.ComboBox2.DisplayMember = "Holiday_Type"
        Me.ComboBox2.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc3)
        Me.ComboBox3.DataSource = dsc3.Tables(0).DefaultView
        Me.ComboBox3.DisplayMember = "Holiday_Type"
        Me.ComboBox3.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc4)
        Me.ComboBox4.DataSource = dsc4.Tables(0).DefaultView
        Me.ComboBox4.DisplayMember = "Holiday_Type"
        Me.ComboBox4.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc5)
        Me.ComboBox5.DataSource = dsc5.Tables(0).DefaultView
        Me.ComboBox5.DisplayMember = "Holiday_Type"
        Me.ComboBox5.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc6)
        Me.ComboBox6.DataSource = dsc6.Tables(0).DefaultView
        Me.ComboBox6.DisplayMember = "Holiday_Type"
        Me.ComboBox6.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc7)
        Me.ComboBox7.DataSource = dsc7.Tables(0).DefaultView
        Me.ComboBox7.DisplayMember = "Holiday_Type"
        Me.ComboBox7.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc8)
        Me.ComboBox8.DataSource = dsc8.Tables(0).DefaultView
        Me.ComboBox8.DisplayMember = "Holiday_Type"
        Me.ComboBox8.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc9)
        Me.ComboBox9.DataSource = dsc9.Tables(0).DefaultView
        Me.ComboBox9.DisplayMember = "Holiday_Type"
        Me.ComboBox9.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc10)
        Me.ComboBox10.DataSource = dsc10.Tables(0).DefaultView
        Me.ComboBox10.DisplayMember = "Holiday_Type"
        Me.ComboBox10.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc11)
        Me.ComboBox11.DataSource = dsc11.Tables(0).DefaultView
        Me.ComboBox11.DisplayMember = "Holiday_Type"
        Me.ComboBox11.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc12)
        Me.ComboBox12.DataSource = dsc12.Tables(0).DefaultView
        Me.ComboBox12.DisplayMember = "Holiday_Type"
        Me.ComboBox12.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc13)
        Me.ComboBox13.DataSource = dsc13.Tables(0).DefaultView
        Me.ComboBox13.DisplayMember = "Holiday_Type"
        Me.ComboBox13.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc14)
        Me.ComboBox14.DataSource = dsc14.Tables(0).DefaultView
        Me.ComboBox14.DisplayMember = "Holiday_Type"
        Me.ComboBox14.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc15)
        Me.ComboBox15.DataSource = dsc15.Tables(0).DefaultView
        Me.ComboBox15.DisplayMember = "Holiday_Type"
        Me.ComboBox15.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc16)
        Me.ComboBox16.DataSource = dsc16.Tables(0).DefaultView
        Me.ComboBox16.DisplayMember = "Holiday_Type"
        Me.ComboBox16.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc17)
        Me.ComboBox17.DataSource = dsc17.Tables(0).DefaultView
        Me.ComboBox17.DisplayMember = "Holiday_Type"
        Me.ComboBox17.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc18)
        Me.ComboBox18.DataSource = dsc18.Tables(0).DefaultView
        Me.ComboBox18.DisplayMember = "Holiday_Type"
        Me.ComboBox18.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc19)
        Me.ComboBox19.DataSource = dsc19.Tables(0).DefaultView
        Me.ComboBox19.DisplayMember = "Holiday_Type"
        Me.ComboBox19.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc20)
        Me.ComboBox20.DataSource = dsc20.Tables(0).DefaultView
        Me.ComboBox20.DisplayMember = "Holiday_Type"
        Me.ComboBox20.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc21)
        Me.ComboBox21.DataSource = dsc21.Tables(0).DefaultView
        Me.ComboBox21.DisplayMember = "Holiday_Type"
        Me.ComboBox21.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc22)
        Me.ComboBox22.DataSource = dsc22.Tables(0).DefaultView
        Me.ComboBox22.DisplayMember = "Holiday_Type"
        Me.ComboBox22.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc23)
        Me.ComboBox23.DataSource = dsc23.Tables(0).DefaultView
        Me.ComboBox23.DisplayMember = "Holiday_Type"
        Me.ComboBox23.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc24)
        Me.ComboBox24.DataSource = dsc24.Tables(0).DefaultView
        Me.ComboBox24.DisplayMember = "Holiday_Type"
        Me.ComboBox24.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc25)
        Me.ComboBox25.DataSource = dsc25.Tables(0).DefaultView
        Me.ComboBox25.DisplayMember = "Holiday_Type"
        Me.ComboBox25.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc26)
        Me.ComboBox26.DataSource = dsc26.Tables(0).DefaultView
        Me.ComboBox26.DisplayMember = "Holiday_Type"
        Me.ComboBox26.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc27)
        Me.ComboBox27.DataSource = dsc27.Tables(0).DefaultView
        Me.ComboBox27.DisplayMember = "Holiday_Type"
        Me.ComboBox27.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc28)
        Me.ComboBox28.DataSource = dsc28.Tables(0).DefaultView
        Me.ComboBox28.DisplayMember = "Holiday_Type"
        Me.ComboBox28.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc29)
        Me.ComboBox29.DataSource = dsc29.Tables(0).DefaultView
        Me.ComboBox29.DisplayMember = "Holiday_Type"
        Me.ComboBox29.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc30)
        Me.ComboBox30.DataSource = dsc30.Tables(0).DefaultView
        Me.ComboBox30.DisplayMember = "Holiday_Type"
        Me.ComboBox30.ValueMember = "Sign"
        dvc = DBControl.Getdata(sqldc, dsc31)
        Me.ComboBox31.DataSource = dsc31.Tables(0).DefaultView
        Me.ComboBox31.DisplayMember = "Holiday_Type"
        Me.ComboBox31.ValueMember = "Sign"

    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
