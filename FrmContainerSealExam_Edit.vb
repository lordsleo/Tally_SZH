Imports TALLY.DBControl
Public Class FrmContainerSealExam_Edit
    Inherits System.Windows.Forms.Form

    Dim strOgContainer As String
    Dim sqlConBeing As String
    Dim dvConBeing As New DataView()
    Dim iBeingCount As Integer
    Dim flag As Boolean = False

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
    Friend WithEvents txtContainer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents cbSealType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtOriginalSealNO As System.Windows.Forms.TextBox
    Friend WithEvents txtNewSealNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkPlace As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbOgSealCondition As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtContainer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVoyage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtShip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cbSealType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOriginalSealNO = New System.Windows.Forms.TextBox()
        Me.txtNewSealNO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker()
        Me.dtpTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtWorkPlace = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNO = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbOgSealCondition = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtContainer
        '
        Me.txtContainer.Location = New System.Drawing.Point(80, 152)
        Me.txtContainer.MaxLength = 12
        Me.txtContainer.Name = "txtContainer"
        Me.txtContainer.Size = New System.Drawing.Size(130, 21)
        Me.txtContainer.TabIndex = 4
        Me.txtContainer.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "��װ���"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(80, 32)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 1
        Me.txtVoyage.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(80, 8)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 0
        Me.txtShip.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "���Ĵ���"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 204
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'cbSealType
        '
        Me.cbSealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSealType.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbSealType.Location = New System.Drawing.Point(80, 200)
        Me.cbSealType.Name = "cbSealType"
        Me.cbSealType.Size = New System.Drawing.Size(130, 20)
        Me.cbSealType.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 215
        Me.Label6.Text = "��Ǧ������"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOriginalSealNO
        '
        Me.txtOriginalSealNO.Location = New System.Drawing.Point(80, 224)
        Me.txtOriginalSealNO.MaxLength = 20
        Me.txtOriginalSealNO.Name = "txtOriginalSealNO"
        Me.txtOriginalSealNO.Size = New System.Drawing.Size(130, 21)
        Me.txtOriginalSealNO.TabIndex = 7
        Me.txtOriginalSealNO.Text = ""
        '
        'txtNewSealNO
        '
        Me.txtNewSealNO.Location = New System.Drawing.Point(80, 176)
        Me.txtNewSealNO.MaxLength = 20
        Me.txtNewSealNO.Name = "txtNewSealNO"
        Me.txtNewSealNO.Size = New System.Drawing.Size(130, 21)
        Me.txtNewSealNO.TabIndex = 5
        Me.txtNewSealNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 212
        Me.Label4.Text = "ԭǦ���"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 211
        Me.Label5.Text = "��Ǧ���"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 217
        Me.Label7.Text = "��ʼʱ��"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(80, 104)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeBegin.TabIndex = 2
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(80, 128)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeEnd.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 219
        Me.Label8.Text = "����ʱ��"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 221
        Me.Label9.Text = "ԭǦ�����"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 223
        Me.Label10.Text = "��ע"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(10, 288)
        Me.txtRemark.MaxLength = 100
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(200, 46)
        Me.txtRemark.TabIndex = 9
        Me.txtRemark.Text = ""
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(110, 340)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 11
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(42, 340)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 10
        Me.btSave.Text = "ȷ��"
        '
        'txtWorkPlace
        '
        Me.txtWorkPlace.Location = New System.Drawing.Point(80, 80)
        Me.txtWorkPlace.MaxLength = 50
        Me.txtWorkPlace.Name = "txtWorkPlace"
        Me.txtWorkPlace.Size = New System.Drawing.Size(130, 21)
        Me.txtWorkPlace.TabIndex = 254
        Me.txtWorkPlace.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(6, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 256
        Me.Label11.Text = "�����ص�"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNO
        '
        Me.txtNO.Location = New System.Drawing.Point(80, 56)
        Me.txtNO.MaxLength = 10
        Me.txtNO.Name = "txtNO"
        Me.txtNO.Size = New System.Drawing.Size(130, 21)
        Me.txtNO.TabIndex = 253
        Me.txtNO.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 255
        Me.Label12.Text = "���"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbOgSealCondition
        '
        Me.cbOgSealCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOgSealCondition.Location = New System.Drawing.Point(80, 248)
        Me.cbOgSealCondition.Name = "cbOgSealCondition"
        Me.cbOgSealCondition.Size = New System.Drawing.Size(130, 20)
        Me.cbOgSealCondition.TabIndex = 277
        '
        'FrmContainerSealExam_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(220, 371)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbOgSealCondition, Me.txtWorkPlace, Me.Label11, Me.txtNO, Me.Label12, Me.btQuit, Me.btSave, Me.txtRemark, Me.Label10, Me.Label9, Me.dtpTimeEnd, Me.Label8, Me.dtpTimeBegin, Me.Label7, Me.cbSealType, Me.Label6, Me.txtOriginalSealNO, Me.txtNewSealNO, Me.Label4, Me.Label5, Me.txtContainer, Me.Label3, Me.txtVoyage, Me.Label1, Me.txtShip, Me.Label2, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmContainerSealExam_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��װ�����ʩ����Ϣ �޸�"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim strSealNo As String
    Private Sub FrmContainerSealExam_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim dvType As New DataView()
        Dim sqlstr, sqlType As String
        Me.StartPosition = FormStartPosition.CenterScreen

        sqlType = "select Code_Seal_Type,Seal_Type from Code_Seal_Type  "
        sqlstr = "select * from Seal_Exam where SEAL_EXAM_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)

        dvType = Filldata(sqlType)
        cbSealType.DataSource = dvType
        cbSealType.DisplayMember = "Seal_Type"
        cbSealType.ValueMember = "Code_Seal_Type"

        Dim sqlOgSealCondition As String = "SELECT Code_SealCircs, SealCircs_CHI, SealCircs_Eng FROM Code_SealCircs ORDER BY Code_SealCircs"
        Dim dvOgSealCondition As New DataView()
        dvOgSealCondition = Filldata(sqlOgSealCondition)
        Me.cbOgSealCondition.DataSource = dvOgSealCondition
        Me.cbOgSealCondition.DisplayMember = "SealCircs_CHI"
        Me.cbOgSealCondition.ValueMember = "Code_SealCircs"

        dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        dtpTimeEnd.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtShip.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            txtVoyage.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
            txtContainer.Text = ds.Tables(0).Rows(0).Item("CONTAINER_NO")
            strOgContainer = txtContainer.Text

            txtNewSealNO.Text = ds.Tables(0).Rows(0).Item("NEWSEALNO")
            strSealNo = txtNewSealNO.Text

            txtOriginalSealNO.Text = ds.Tables(0).Rows(0).Item("ORIGINESEALNO")
            Me.cbOgSealCondition.SelectedValue = ds.Tables(0).Rows(0).Item("ORIGINESEALNO_CONDITION")
            txtRemark.Text = ds.Tables(0).Rows(0).Item("REMARK")
            txtNO.Text = ds.Tables(0).Rows(0).Item("NO")
            txtWorkPlace.Text = ds.Tables(0).Rows(0).Item("WORK_PLACE")

            cbSealType.SelectedValue = ds.Tables(0).Rows(0).Item("Seal_Type")
            dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")
            dtpTimeEnd.Value = ds.Tables(0).Rows(0).Item("TIME_TO")

            'If Trim(txtNewSealNO.Text) = "" Then
            '    cbSealType.Enabled = False
            'End If
        End If
        txtShip.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Function verifySealSingle(ByVal strSeal As String) As Boolean
        Dim i As Short
        Dim c As Char
        If Len(strSeal) >= 2 Then
            For i = Len(strSeal) To 1 Step -1
                c = Mid(strSeal, i, 1)
                If c >= "0" And c <= "9" Then

                Else
                    If c >= "A" And c <= "Z" Then
                        Exit For
                    Else
                        MessageBox.Show("���ڷǷ��ַ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                        Exit Function
                    End If
                End If
            Next

            If i >= 1 And i < Len(strSeal) Then ' ��exit for ��
                For i = i - 1 To 1 Step -1
                    c = Mid(strSeal, i, 1)
                    If (c >= "A" And c <= "Z") Or (c >= "0" And c <= "9") Then

                    Else
                        Exit For
                    End If
                Next
                If i < 1 Then
                    Return True
                    Exit Function
                Else
                    MessageBox.Show("���ڷǷ��ַ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("�ַ����Ƿ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return False
        Exit Function
    End Function

    Private Function CheckConNO(ByVal sm As String) As Integer 'return 0 ����д� 1 У���д� 2 У����ȷ
        Dim S() As Integer = {10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 34, 35, 36, 37, 38}
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim l As Integer
        i = 0
        str = UCase(sm)
        If Len(Trim(str)) = 12 And Mid(Trim(str), 5, 1) = " " Then
            str = Mid(Trim(str), 1, 4) & Mid(Trim(str), 6, 7)
        ElseIf Len(Trim(str)) <> 11 Then
            Return 0
        End If
        k = 1
        For j = 1 To 4
            If Asc(Mid(Trim(str), j, 1)) >= Asc("A") And Asc(Mid(Trim(str), j, 1)) <= Asc("Z") Then
                i = i + S(Asc(Mid(Trim(str), j, 1).ToUpper) - Asc("A")) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next

        For j = 5 To 10
            If Asc(Mid(Trim(str), j, 1)) >= Asc("0") And Asc(Mid(Trim(str), j, 1)) <= Asc("9") Then
                i = i + CInt(Mid(Trim(str), j, 1)) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next
        If i Mod 11 = CInt(Mid(Trim(str), 11, 1)) Or (i Mod 11) - 10 = CInt(Mid(Trim(str), 11, 1)) Then
            Return 2
        Else
            Return 1
        End If
    End Function

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim strOldSeal, strNewSeal, strsqlNoAndCon, strsqlexist, strsqlstate, strsql As String
        Dim dv As New DataView()
        Dim icheck As Integer
        strNewSeal = UCase(Trim(txtNewSealNO.Text))
        strOldSeal = UCase(Trim(txtOriginalSealNO.Text))
        strsqlNoAndCon = "select * from SEAL_EXAM where SEAL_EXAM_ID <> '" & ID & "' and CHI_VESSEL= '" & Trim(txtShip.Text) & _
            "' and VOYAGE= '" & Trim(txtVoyage.Text) & "' and ( NO = '" & Trim(txtNO.Text) & "' or CONTAINER_NO= '" & Trim(txtContainer.Text) & "')"
        strsql = "select * from SEAL_EXAM where SEAL_EXAM_ID <> '" & ID & "' and "  '�����˵�ǰ��¼�������Ǧ����Ƿ��ظ��������������ε�

        strsqlexist = "select * from SEAL_RECORD where SEALNO = '" & strNewSeal & "'"   '�����Ǧ���Ƿ��ڿ����
        strsqlstate = "select * from SEAL_RECORD where SEALNO = '" & strNewSeal & _
            "' and Dept_Code= '" & G_DeptCode & "' and SEAL_STATE = '2' "  '�����Ǧ���Ƿ��Ǳ�������״̬Ϊ����
        Try
            If Trim(txtShip.Text) <> "" And Trim(txtVoyage.Text) <> "" And Trim(txtNO.Text) <> "" And Trim(txtContainer.Text) <> "" Then
                If DateDiff(DateInterval.Minute, Me.dtpTimeBegin.Value, Me.dtpTimeEnd.Value) >= 0 Then
                    If Filldata(strsqlNoAndCon).Count = 0 Then
                        icheck = CheckConNO(Trim(Me.txtContainer.Text))
                        If iBeingCount = 1 Or icheck = 2 Or icheck = 1 Then
                            If iBeingCount = 0 And icheck = 1 Then
                                If MessageBox.Show("��װ���У�鲻��ȷ��ȷ��������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                                    Exit Sub
                                End If
                            End If
                            If strNewSeal <> "" Then        '�¼�Ǧ��Ų�Ϊ��
                                If verifySealSingle(strNewSeal) Then       'Ǧ�����
                                    dv = Filldata(strsql & " NEWSEALNO = '" & strNewSeal & "'")
                                    If dv.Count = 0 Then        '�¼�Ǧ��δʹ�ù�
                                        If Filldata(strsqlexist).Count = 1 Then     '��Ǧ�������
                                            If strNewSeal <> strSealNo Then     '����޸�����Ǧ���
                                                If Filldata(strsqlstate).Count = 1 Then '��Ǧ��״̬���ͨ��
                                                    '�޸Ĵ�ʩ���¼��Ȼ���ڿ�����ô������޸Ĵ�Ǧ���¼
                                                    If strOldSeal = "" Then
                                                        If Me.cbOgSealCondition.SelectedValue = "00" Then
                                                            EditSealExam(strNewSeal, strOldSeal)         'ֻʩ��
                                                        Else
                                                            MessageBox.Show("�����ʱ����ѡԭǦ�������", "������ʾ")
                                                        End If
                                                    Else
                                                        If verifySealSingle(strOldSeal) Then
                                                            dv = Filldata(strsql & " ORIGINESEALNO = '" & strOldSeal & "'")
                                                            If dv.Count = 0 Then    'ԭǦ���������
                                                                EditSealExam(strNewSeal, strOldSeal)     '������ʩ��
                                                            Else
                                                                MessageBox.Show("�Ѵ������ʩ���¼������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                            End If
                                                        Else
                                                            MessageBox.Show("��Ǧ��Ų��Ϸ���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                        End If
                                                    End If
                                                Else
                                                    MessageBox.Show("��Ǧ��Ų��ڱ����Ż��ѱ�ʹ�û�ע����", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                End If
                                            Else    '���δ�޸���Ǧ��ţ������
                                                '�޸Ĵ�ʩ���¼
                                                If strOldSeal = "" Then
                                                    If Me.cbOgSealCondition.SelectedValue = "00" Then
                                                        EditSealExam(strNewSeal, strOldSeal)         'ֻʩ��
                                                    Else
                                                        MessageBox.Show("�����ʱ����ѡԭǦ�������", "������ʾ")
                                                    End If
                                                Else
                                                    If verifySealSingle(strOldSeal) Then
                                                        dv = Filldata(strsql & " ORIGINESEALNO = '" & strOldSeal & "'")
                                                        If dv.Count = 0 Then    'ԭǦ���������
                                                            EditSealExam(strNewSeal, strOldSeal)     '������ʩ��
                                                        Else
                                                            MessageBox.Show("�Ѵ������ʩ���¼������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                        End If
                                                    Else
                                                        MessageBox.Show("��Ǧ��Ų��Ϸ���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                    End If
                                                End If
                                            End If
                                        Else    '��Ǧ��δ���
                                            '��Ӵ�ʩ���¼��Ȼ���ڿ�������һ��Ǧ���¼
                                            If strOldSeal = "" Then
                                                If Me.cbOgSealCondition.SelectedValue = "00" Then
                                                    EditSealExam(strNewSeal, strOldSeal)         'ֻʩ��
                                                Else
                                                    MessageBox.Show("�����ʱ����ѡԭǦ�������", "������ʾ")
                                                End If
                                            Else
                                                If verifySealSingle(strOldSeal) Then
                                                    dv = Filldata(strsql & " ORIGINESEALNO = '" & strOldSeal & "'")
                                                    If dv.Count = 0 Then    'ԭǦ���������
                                                        EditSealExam(strNewSeal, strOldSeal)     '������ʩ��
                                                    Else
                                                        MessageBox.Show("�Ѵ������ʩ���¼������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                    End If
                                                Else
                                                    MessageBox.Show("��Ǧ��Ų��Ϸ���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                End If
                                            End If
                                        End If
                                    Else
                                        MessageBox.Show("�Ѵ���ʩ���¼������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End If
                                Else
                                    MessageBox.Show("��Ǧ��Ų��Ϸ���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else        '�¼�Ǧ���Ϊ��,ֻ��ⲻʩ�⣬�����Ǧ���
                                If strOldSeal <> "" Then
                                    If cbSealType.SelectedValue = 0 Then
                                        'Ǧ�����
                                        If verifySealSingle(strOldSeal) Then
                                            dv = Filldata(strsql & " ORIGINESEALNO = '" & strOldSeal & "'")
                                            If dv.Count = 0 Then    'ԭǦ���������
                                                EditSealExam(strNewSeal, strOldSeal)     'ֻ���
                                            Else
                                                MessageBox.Show("�Ѵ�������¼������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            End If
                                        Else
                                            MessageBox.Show("��Ǧ��Ų��Ϸ���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        End If
                                    Else
                                        MessageBox.Show("��ʩ��ʱ����ѡ�¼�Ǧ�����ͣ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End If
                                Else
                                    MessageBox.Show("�¾�Ǧ��Ų���ȫΪ�գ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End If
                        Else
                            MessageBox.Show("�ü�װ�����������в����ڻ�����Ų��淶����������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If
                    Else
                        MessageBox.Show("ͬһ�������� �����Ŷ������ظ�������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("��ʼʱ��Ӧ�ڽ���ʱ��֮ǰ��", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("�������� �����Ų���Ϊ�գ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As System.Exception
            'MessageBox.Show(ex.Message, "���⴦��", MessageBoxButtons.OK)
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EditSealExam(ByVal strNewSeal As String, ByVal strOldSeal As String)
        ds.Tables(0).Rows(0).Item("CHI_VESSEL") = Trim(txtShip.Text)
        ds.Tables(0).Rows(0).Item("VOYAGE") = Trim(txtVoyage.Text)
        ds.Tables(0).Rows(0).Item("CONTAINER_NO") = Trim(txtContainer.Text)
        ds.Tables(0).Rows(0).Item("NEWSEALNO") = strNewSeal
        ds.Tables(0).Rows(0).Item("ORIGINESEALNO_CONDITION") = cbOgSealCondition.SelectedValue
        ds.Tables(0).Rows(0).Item("REMARK") = Trim(txtRemark.Text)
        ds.Tables(0).Rows(0).Item("NO") = Trim(txtNO.Text)
        ds.Tables(0).Rows(0).Item("WORK_PLACE") = Trim(txtWorkPlace.Text)

        ds.Tables(0).Rows(0).Item("ORIGINESEALNO") = strOldSeal
        ds.Tables(0).Rows(0).Item("Seal_Type") = cbSealType.SelectedValue
        ds.Tables(0).Rows(0).Item("TIME_FROM") = dtpTimeBegin.Value
        ds.Tables(0).Rows(0).Item("TIME_TO") = dtpTimeEnd.Value

        If MessageBox.Show("ȷ��Ҫ�޸���", "������ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
            '��¼������־
            Call OperateHistory(G_DeptName, Now, G_User, "�޸�", "SEAL_EXAM", Trim(txtID.Text), "SEAL_EXAM_ID")
            sqlda.Update(ds)
            Me.Close()
        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtShip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShip.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtVoyage.Focus()
        End If
    End Sub

    Private Sub txtVoyage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVoyage.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtNO.Focus()
        End If
    End Sub

    Private Sub dtpTimeBegin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpTimeBegin.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpTimeEnd.Focus()
        End If
    End Sub

    Private Sub dtpTimeEnd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpTimeEnd.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtContainer.Focus()
        End If
    End Sub

    Private Sub txtContainer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContainer.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtNewSealNO.Focus()
        End If
    End Sub

    Private Sub txtNewSealNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewSealNO.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbSealType.Focus()
        End If
    End Sub

    Private Sub cbSealType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbSealType.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtOriginalSealNO.Focus()
        End If
    End Sub

    Private Sub txtOriginalSealNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOriginalSealNO.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbOgSealCondition.Focus()
        End If
    End Sub

    Private Sub cbOgSealCondition_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRemark.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtRemark.Focus()
        End If
    End Sub

    Private Sub txtRemark_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRemark.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btSave.Focus()
        End If
    End Sub

    Private Sub btSave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btSave.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Me.btSave_Click(sender, e)
        End If
    End Sub
    Private Sub txtNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNO.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtWorkPlace.Focus()
        End If
    End Sub

    Private Sub txtWorkPlace_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWorkPlace.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpTimeBegin.Focus()
        End If
    End Sub

    Private Sub txtContainer_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContainer.Leave
        If Trim(Me.txtContainer.Text) <> strOgContainer Then    '����ı��˼�װ���
            strOgContainer = Trim(Me.txtContainer.Text)
            sqlConBeing = "SELECT CON_LOAD_TALLY_LIST.CONTAINER_NO, CON_LOAD_TALLY_LIST.NEWSEALNO, CON_LOAD_TALLY_LIST.SIZE_CON,  CON_LOAD_TALLY_LIST.CONTAINER_TYPE FROM CON_LOAD_TALLY_LIST INNER JOIN CON_LOAD_TALLY ON  CON_LOAD_TALLY_LIST.CON_LOAD_TALLY_ID = CON_LOAD_TALLY.CON_LOAD_TALLY_ID WHERE (CON_LOAD_TALLY_LIST.CONTAINER_NO = '" & Trim(Me.txtContainer.Text) & "') AND (CON_LOAD_TALLY.Voyage = '" & Trim(Me.txtVoyage.Text) & "') AND (CON_LOAD_TALLY.CHI_VESSEL = '" & Trim(Me.txtShip.Text) & "')"
            dvConBeing = Filldata(sqlConBeing)
            iBeingCount = dvConBeing.Count
            If iBeingCount = 1 Then
                Me.txtNewSealNO.Text = dvConBeing(0)("NEWSEALNO")
                flag = True     '����Ŵ���
            Else
                flag = False    '����Ŵ���
            End If
        End If
    End Sub
End Class
