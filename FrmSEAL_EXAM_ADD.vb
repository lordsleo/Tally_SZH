Imports TALLY.DBControl
Public Class FrmSEAL_EXAM_ADD
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dshatch_no As New DataSet()
    Dim dsWORKTYPE As New DataSet()
    Dim dsSEAL_TYPE As New DataSet()
    Dim DSORIGINESEALNO_CONDITION As New DataSet
    Dim dsclerk As New DataSet
    Dim dss As New DataSet

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע�⣺���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
    Friend WithEvents CombWORKTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtWORK_PLACE As System.Windows.Forms.TextBox
    Friend WithEvents TxtCONTAINER_NO As System.Windows.Forms.TextBox
    Friend WithEvents TxtNEWSEALNO As System.Windows.Forms.TextBox
    Friend WithEvents TxtORIGINESEALNO As System.Windows.Forms.TextBox
    Friend WithEvents CombHATCH_NO As System.Windows.Forms.ComboBox
    Friend WithEvents DTPTIME_FROM As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPTIME_TO As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtREMARK As System.Windows.Forms.TextBox
    Friend WithEvents BTADD As System.Windows.Forms.Button
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents CombSEAL_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents CombORIGINESEALNO_CONDITION As System.Windows.Forms.ComboBox
    Friend WithEvents CombTALLY_CLERK As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtNO = New System.Windows.Forms.TextBox
        Me.CombWORKTYPE = New System.Windows.Forms.ComboBox
        Me.TxtWORK_PLACE = New System.Windows.Forms.TextBox
        Me.TxtCONTAINER_NO = New System.Windows.Forms.TextBox
        Me.TxtNEWSEALNO = New System.Windows.Forms.TextBox
        Me.TxtORIGINESEALNO = New System.Windows.Forms.TextBox
        Me.CombHATCH_NO = New System.Windows.Forms.ComboBox
        Me.CombSEAL_TYPE = New System.Windows.Forms.ComboBox
        Me.DTPTIME_FROM = New System.Windows.Forms.DateTimePicker
        Me.DTPTIME_TO = New System.Windows.Forms.DateTimePicker
        Me.TxtREMARK = New System.Windows.Forms.TextBox
        Me.BTADD = New System.Windows.Forms.Button
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.BTOK = New System.Windows.Forms.Button
        Me.CombORIGINESEALNO_CONDITION = New System.Windows.Forms.ComboBox
        Me.CombTALLY_CLERK = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "��¼���"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "��װ��װж����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "��ʼʱ��"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "����ʱ��"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "�����ص�"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "�ձ�"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(236, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "���"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(236, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "�¼�Ǧ���"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(236, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "ԭǦ���"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(236, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "�¼�Ǧ������"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(236, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "ԭǦ��������"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(10, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "��ע"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNO
        '
        Me.TxtNO.Location = New System.Drawing.Point(108, 10)
        Me.TxtNO.MaxLength = 10
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(122, 21)
        Me.TxtNO.TabIndex = 12
        Me.TxtNO.Text = ""
        '
        'CombWORKTYPE
        '
        Me.CombWORKTYPE.Location = New System.Drawing.Point(108, 38)
        Me.CombWORKTYPE.Name = "CombWORKTYPE"
        Me.CombWORKTYPE.Size = New System.Drawing.Size(122, 20)
        Me.CombWORKTYPE.TabIndex = 13
        '
        'TxtWORK_PLACE
        '
        Me.TxtWORK_PLACE.Location = New System.Drawing.Point(108, 142)
        Me.TxtWORK_PLACE.Name = "TxtWORK_PLACE"
        Me.TxtWORK_PLACE.Size = New System.Drawing.Size(238, 21)
        Me.TxtWORK_PLACE.TabIndex = 14
        Me.TxtWORK_PLACE.Text = ""
        '
        'TxtCONTAINER_NO
        '
        Me.TxtCONTAINER_NO.Location = New System.Drawing.Point(334, 10)
        Me.TxtCONTAINER_NO.MaxLength = 11
        Me.TxtCONTAINER_NO.Name = "TxtCONTAINER_NO"
        Me.TxtCONTAINER_NO.Size = New System.Drawing.Size(170, 21)
        Me.TxtCONTAINER_NO.TabIndex = 15
        Me.TxtCONTAINER_NO.Text = ""
        '
        'TxtNEWSEALNO
        '
        Me.TxtNEWSEALNO.Location = New System.Drawing.Point(334, 36)
        Me.TxtNEWSEALNO.MaxLength = 20
        Me.TxtNEWSEALNO.Name = "TxtNEWSEALNO"
        Me.TxtNEWSEALNO.Size = New System.Drawing.Size(170, 21)
        Me.TxtNEWSEALNO.TabIndex = 16
        Me.TxtNEWSEALNO.Text = ""
        '
        'TxtORIGINESEALNO
        '
        Me.TxtORIGINESEALNO.Location = New System.Drawing.Point(334, 88)
        Me.TxtORIGINESEALNO.MaxLength = 20
        Me.TxtORIGINESEALNO.Name = "TxtORIGINESEALNO"
        Me.TxtORIGINESEALNO.Size = New System.Drawing.Size(170, 21)
        Me.TxtORIGINESEALNO.TabIndex = 17
        Me.TxtORIGINESEALNO.Text = ""
        '
        'CombHATCH_NO
        '
        Me.CombHATCH_NO.Location = New System.Drawing.Point(108, 116)
        Me.CombHATCH_NO.Name = "CombHATCH_NO"
        Me.CombHATCH_NO.Size = New System.Drawing.Size(122, 20)
        Me.CombHATCH_NO.TabIndex = 18
        '
        'CombSEAL_TYPE
        '
        Me.CombSEAL_TYPE.Location = New System.Drawing.Point(334, 62)
        Me.CombSEAL_TYPE.Name = "CombSEAL_TYPE"
        Me.CombSEAL_TYPE.Size = New System.Drawing.Size(170, 20)
        Me.CombSEAL_TYPE.TabIndex = 19
        '
        'DTPTIME_FROM
        '
        Me.DTPTIME_FROM.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.DTPTIME_FROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTIME_FROM.Location = New System.Drawing.Point(108, 64)
        Me.DTPTIME_FROM.Name = "DTPTIME_FROM"
        Me.DTPTIME_FROM.Size = New System.Drawing.Size(122, 21)
        Me.DTPTIME_FROM.TabIndex = 20
        '
        'DTPTIME_TO
        '
        Me.DTPTIME_TO.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.DTPTIME_TO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTIME_TO.Location = New System.Drawing.Point(108, 90)
        Me.DTPTIME_TO.Name = "DTPTIME_TO"
        Me.DTPTIME_TO.Size = New System.Drawing.Size(122, 21)
        Me.DTPTIME_TO.TabIndex = 21
        '
        'TxtREMARK
        '
        Me.TxtREMARK.Location = New System.Drawing.Point(108, 170)
        Me.TxtREMARK.MaxLength = 100
        Me.TxtREMARK.Multiline = True
        Me.TxtREMARK.Name = "TxtREMARK"
        Me.TxtREMARK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtREMARK.Size = New System.Drawing.Size(396, 42)
        Me.TxtREMARK.TabIndex = 23
        Me.TxtREMARK.Text = ""
        '
        'BTADD
        '
        Me.BTADD.Location = New System.Drawing.Point(151, 226)
        Me.BTADD.Name = "BTADD"
        Me.BTADD.Size = New System.Drawing.Size(65, 24)
        Me.BTADD.TabIndex = 67
        Me.BTADD.Text = "���"
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(297, 226)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 66
        Me.BTQUIT.Text = "ȡ��"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(225, 226)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 65
        Me.BTOK.Text = "ȷ��"
        '
        'CombORIGINESEALNO_CONDITION
        '
        Me.CombORIGINESEALNO_CONDITION.Location = New System.Drawing.Point(334, 116)
        Me.CombORIGINESEALNO_CONDITION.Name = "CombORIGINESEALNO_CONDITION"
        Me.CombORIGINESEALNO_CONDITION.Size = New System.Drawing.Size(170, 20)
        Me.CombORIGINESEALNO_CONDITION.TabIndex = 68
        '
        'CombTALLY_CLERK
        '
        Me.CombTALLY_CLERK.Location = New System.Drawing.Point(396, 142)
        Me.CombTALLY_CLERK.Name = "CombTALLY_CLERK"
        Me.CombTALLY_CLERK.Size = New System.Drawing.Size(108, 20)
        Me.CombTALLY_CLERK.TabIndex = 87
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(348, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 22)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "���Ա"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmSEAL_EXAM_ADD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 263)
        Me.Controls.Add(Me.CombTALLY_CLERK)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CombORIGINESEALNO_CONDITION)
        Me.Controls.Add(Me.BTADD)
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.BTOK)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSEAL_EXAM_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "���ʩ���¼_����"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmSEAL_EXAM_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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


        dw = Updatedata(sqlda, "select * from seal_exam where seal_exam_ID='" & ID & "'", ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            DTPTIME_FROM.Value = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_from"))), Now, Trim(ds.Tables(0).Rows(0).Item("time_from")))
            DTPTIME_TO.Value = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_to"))), Now, Trim(ds.Tables(0).Rows(0).Item("time_to")))
            CombHATCH_NO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("hatch_no"))), "", Trim(ds.Tables(0).Rows(0).Item("hatch_no")))
            CombWORKTYPE.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("WORKTYPE"))), "", Trim(ds.Tables(0).Rows(0).Item("WORKTYPE")))
            TxtWORK_PLACE.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("WORK_PLACE"))), "", Trim(ds.Tables(0).Rows(0).Item("WORK_PLACE")))
            CombHATCH_NO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("HATCH_NO"))), "", Trim(ds.Tables(0).Rows(0).Item("HATCH_NO")))
            CombSEAL_TYPE.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("SEAL_TYPE"))), "", Trim(ds.Tables(0).Rows(0).Item("SEAL_TYPE")))
            CombORIGINESEALNO_CONDITION.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("ORIGINESEALNO_CONDITION"))), "00", Trim(ds.Tables(0).Rows(0).Item("ORIGINESEALNO_CONDITION")))
            TxtREMARK.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("REMARK"))), "", Trim(ds.Tables(0).Rows(0).Item("REMARK")))
            CombTALLY_CLERK.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("TALLY_CLERK"))), "", Trim(ds.Tables(0).Rows(0).Item("TALLY_CLERK")))
        Else
            CombTALLY_CLERK.SelectedValue = ""
        End If
        Exit Sub
Err:
        Resume Next
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
                        MsgBox("û�иòձ����������Ƿ���ȷ��")
                        CombHATCH_NO.Focus()
                    End If
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BTADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTADD.Click
        TxtNO.Text = ""
        TxtWORK_PLACE.Text = ""
        TxtCONTAINER_NO.Text = ""
        TxtNEWSEALNO.Text = ""
        TxtORIGINESEALNO.Text = ""
        CombORIGINESEALNO_CONDITION.SelectedValue = "00"
        TxtREMARK.Text = ""
        CombTALLY_CLERK.SelectedValue = ""

    End Sub
    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Try
            If Len(Trim(CombWORKTYPE.SelectedValue)) > 0 Then
                If Len(DTPTIME_FROM.Value) > 0 Then


                    If Len(Trim(TxtNEWSEALNO.Text)) > 0 Then
                        Dim dsseal As New DataSet()
                        Dim sqldaseal As New SqlClient.SqlDataAdapter()

                        dw = Updatedata(sqldaseal, "select * from seal_record where sealno='" & TxtNEWSEALNO.Text & "'", dsseal)
                        If dsseal.Tables(0).Rows.Count > 0 Then
                            If dsseal.Tables(0).Rows(0).Item("SEAL_STATE") = "1" Then
                                MsgBox("�Բ��𣬸��¼�Ǧ����δ���⣬���ʵ��")
                                Exit Sub
                            ElseIf dsseal.Tables(0).Rows(0).Item("SEAL_STATE") = "3" Then
                                MsgBox("�Բ��𣬸��¼�Ǧ����ʹ�ã����ʵ��")
                                Exit Sub
                            ElseIf dsseal.Tables(0).Rows(0).Item("SEAL_STATE") = "4" Then
                                MsgBox("�Բ��𣬸��¼�Ǧ����ѱ�ע�������ʵ��")
                                Exit Sub
                            ElseIf dsseal.Tables(0).Rows(0).Item("SEAL_STATE") = "2" Then
                                OperateHistory(G_DeptName, Now, G_User, "�༭", "seal_record", ID, "SEAL_RECORD_ID")
                                dsseal.Tables(0).Rows(0).Item("SHIP_ID") = Trim(Ship_ID)
                                dsseal.Tables(0).Rows(0).Item("SEAL_STATE") = "3"
                                dsseal.Tables(0).Rows(0).Item("CONTAINER_NO") = IIf(Len(Trim(TxtCONTAINER_NO.Text)) > 0, Trim(TxtCONTAINER_NO.Text), "")
                                dsseal.Tables(0).Rows(0).Item("HATCH_NO") = IIf(Len(Trim(CombHATCH_NO.SelectedValue)) > 0, Trim(CombHATCH_NO.SelectedValue), "0")
                                dsseal.Tables(0).Rows(0).Item("Dept_Code") = Trim(G_DeptCode)
                                sqldaseal.Update(dsseal)
                            Else
                                MsgBox("���¼�Ǧ���״̬���꣬���Ƚ���״̬��Ϊ���⣬��ʹ�ã�")
                                Exit Sub
                            End If
                        Else
                            MsgBox("û�и�Ǧ��ţ����ʵ��")
                            Exit Sub
                        End If
                    End If

                    Dim row As DataRow
                    row = ds.Tables(0).NewRow
                    row("SHIP_ID") = Trim(Ship_ID)
                    row("SEAL_TYPE") = IIf(Len(Trim(CombSEAL_TYPE.SelectedValue)) > 0, Trim(CombSEAL_TYPE.SelectedValue), "")
                    row("HATCH_NO") = IIf(Len(Trim(CombHATCH_NO.SelectedValue)) > 0, Trim(CombHATCH_NO.SelectedValue), "")
                    row("time_from") = DTPTIME_FROM.Value
                    row("time_to") = DTPTIME_TO.Value
                    row("WORK_PLACE") = IIf(Len(Trim(TxtWORK_PLACE.Text)) > 0, Trim(TxtWORK_PLACE.Text), "")
                    row("WORKTYPE") = IIf(Len(Trim(CombWORKTYPE.SelectedValue)) > 0, Trim(CombWORKTYPE.SelectedValue), "0")
                    row("NO") = IIf(Len(Trim(TxtNO.Text)) > 0, Trim(TxtNO.Text), "")
                    row("CONTAINER_NO") = IIf(Len(Trim(TxtCONTAINER_NO.Text)) > 0, Trim(TxtCONTAINER_NO.Text), "")
                    row("NEWSEALNO") = IIf(Len(Trim(TxtNEWSEALNO.Text)) > 0, Trim(TxtNEWSEALNO.Text), "")
                    row("ORIGINESEALNO") = IIf(Len(Trim(TxtORIGINESEALNO.Text)) > 0, Trim(TxtORIGINESEALNO.Text), "")
                    row("ORIGINESEALNO_CONDITION") = IIf(Len(Trim(CombORIGINESEALNO_CONDITION.SelectedValue)) > 0, Trim(CombORIGINESEALNO_CONDITION.SelectedValue), "00")
                    row("REMARK") = IIf(Len(Trim(TxtREMARK.Text)) > 0, Trim(TxtREMARK.Text), "")
                    row("Tally_Clerk") = IIf(Len(Trim(CombTALLY_CLERK.SelectedValue)) > 0, Trim(CombTALLY_CLERK.SelectedValue), "00")
                    row("Dept_Code") = Trim(G_DeptCode)
                    row("user_name") = Trim(G_User)
                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)

                    Call BTQUIT_Click(sender, e)
                Else
                    MsgBox("��ʼ���ڲ���Ϊ�գ�")
                End If
            Else
                MsgBox("��װ��װж������Ϊ�գ�")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub
    Private Sub TxtNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNO.KeyPress
        If e.KeyChar = Chr(13) Then
            CombWORKTYPE.Focus()
        End If
    End Sub
    Private Sub CombWORKTYPE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombWORKTYPE.KeyPress
        If e.KeyChar = Chr(13) Then
            DTPTIME_FROM.Focus()
        End If
    End Sub
    Private Sub DTPTIME_FROM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPTIME_FROM.KeyPress
        If e.KeyChar = Chr(13) Then
            DTPTIME_TO.Focus()
        End If
    End Sub
    Private Sub DTPTIME_TO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPTIME_TO.KeyPress
        If e.KeyChar = Chr(13) Then
            CombHATCH_NO.Focus()
        End If
    End Sub
    Private Sub CombHATCH_NO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombHATCH_NO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtCONTAINER_NO.Focus()
        End If
    End Sub
    Private Sub TxtCONTAINER_NO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCONTAINER_NO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNEWSEALNO.Focus()
        End If
    End Sub
    Private Sub TxtNEWSEALNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNEWSEALNO.KeyPress
        If e.KeyChar = Chr(13) Then
            CombSEAL_TYPE.Focus()
        End If
    End Sub
    Private Sub CombSEAL_TYPE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombSEAL_TYPE.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtORIGINESEALNO.Focus()
        End If
    End Sub
    Private Sub TxtORIGINESEALNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtORIGINESEALNO.KeyPress
        If e.KeyChar = Chr(13) Then
            CombORIGINESEALNO_CONDITION.Focus()
        End If
    End Sub
    Private Sub combORIGINESEALNO_CONDITION_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombORIGINESEALNO_CONDITION.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtWORK_PLACE.Focus()
        End If
    End Sub
    Private Sub TxtWORK_PLACE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtWORK_PLACE.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK.Focus()
        End If
    End Sub
    Private Sub TxtREMARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtREMARK.KeyPress
        If e.KeyChar = Chr(13) Then
            BTOK.Focus()
        End If
    End Sub

    Private Sub CombTALLY_CLERK_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombTALLY_CLERK.Leave
        Dim str As String

        If CombTALLY_CLERK.Text.Trim().Length > 0 Then
            If (Asc(Mid(CombTALLY_CLERK.Text.Trim(), 1, 1)) >= Asc("a") And Asc(Mid(CombTALLY_CLERK.Text.Trim(), 1, 1)) <= Asc("z")) Or (Asc(Mid(CombTALLY_CLERK.Text.Trim(), 1, 1)) >= Asc("A") And Asc(Mid(CombTALLY_CLERK.Text.Trim(), 1, 1)) <= Asc("Z")) Then
                dss.Reset()
                str = "SELECT NAME, WORK_NO,Tally_Short FROM TALLY_CLERK where Tally_Short='" & CombTALLY_CLERK.Text.Trim() & "'  order by NAME"
                dw = Getdata(str, dss)
                If dw.Count > 0 Then
                    'CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
                    'CombTALLY_CLERK1.DisplayMember = "NAME"
                    'CombTALLY_CLERK1.ValueMember = "WORK_NO"
                    CombTALLY_CLERK.SelectedValue = dss.Tables(0).Rows(0)("WORK_NO")
                End If
            End If
        End If
    End Sub

    Private Sub CombTALLY_CLERK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtREMARK.Focus()
        End If
    End Sub
End Class
