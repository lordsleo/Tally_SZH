Imports TALLY.DBControl
Public Class FrmBILL_RECEIVABLE_Edit
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()

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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents txtACCONT_ARREARAGE As System.Windows.Forms.TextBox
    Friend WithEvents txtACCOUNT_OCCUR As System.Windows.Forms.TextBox
    Friend WithEvents txtACCOUNT_LAST As System.Windows.Forms.TextBox
    Friend WithEvents CmbACCOUNT_COMPANY As System.Windows.Forms.ComboBox
    Friend WithEvents TxtACCOUNT_IN As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtACCONT_ARREARAGE = New System.Windows.Forms.TextBox()
        Me.txtACCOUNT_OCCUR = New System.Windows.Forms.TextBox()
        Me.txtACCOUNT_LAST = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btResume = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.CmbACCOUNT_COMPANY = New System.Windows.Forms.ComboBox()
        Me.TxtACCOUNT_IN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtACCONT_ARREARAGE
        '
        Me.txtACCONT_ARREARAGE.Location = New System.Drawing.Point(186, 101)
        Me.txtACCONT_ARREARAGE.MaxLength = 10
        Me.txtACCONT_ARREARAGE.Name = "txtACCONT_ARREARAGE"
        Me.txtACCONT_ARREARAGE.Size = New System.Drawing.Size(24, 21)
        Me.txtACCONT_ARREARAGE.TabIndex = 4
        Me.txtACCONT_ARREARAGE.Text = ""
        Me.txtACCONT_ARREARAGE.Visible = False
        '
        'txtACCOUNT_OCCUR
        '
        Me.txtACCOUNT_OCCUR.Location = New System.Drawing.Point(80, 53)
        Me.txtACCOUNT_OCCUR.MaxLength = 10
        Me.txtACCOUNT_OCCUR.Name = "txtACCOUNT_OCCUR"
        Me.txtACCOUNT_OCCUR.Size = New System.Drawing.Size(130, 21)
        Me.txtACCOUNT_OCCUR.TabIndex = 2
        Me.txtACCOUNT_OCCUR.Text = ""
        '
        'txtACCOUNT_LAST
        '
        Me.txtACCOUNT_LAST.Location = New System.Drawing.Point(80, 29)
        Me.txtACCOUNT_LAST.MaxLength = 10
        Me.txtACCOUNT_LAST.Name = "txtACCOUNT_LAST"
        Me.txtACCOUNT_LAST.Size = New System.Drawing.Size(130, 21)
        Me.txtACCOUNT_LAST.TabIndex = 1
        Me.txtACCOUNT_LAST.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "���µ���"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "���·���"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "����Ƿ��"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "������λ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(114, 106)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 5
        Me.btQuit.Text = "ȡ��"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(46, 106)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 4
        Me.btResume.Text = "ȷ��"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(18, 106)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(20, 21)
        Me.txtID.TabIndex = 103
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'CmbACCOUNT_COMPANY
        '
        Me.CmbACCOUNT_COMPANY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbACCOUNT_COMPANY.Enabled = False
        Me.CmbACCOUNT_COMPANY.Location = New System.Drawing.Point(80, 6)
        Me.CmbACCOUNT_COMPANY.Name = "CmbACCOUNT_COMPANY"
        Me.CmbACCOUNT_COMPANY.Size = New System.Drawing.Size(130, 20)
        Me.CmbACCOUNT_COMPANY.TabIndex = 0
        '
        'TxtACCOUNT_IN
        '
        Me.TxtACCOUNT_IN.Location = New System.Drawing.Point(80, 77)
        Me.TxtACCOUNT_IN.MaxLength = 10
        Me.TxtACCOUNT_IN.Name = "TxtACCOUNT_IN"
        Me.TxtACCOUNT_IN.Size = New System.Drawing.Size(130, 21)
        Me.TxtACCOUNT_IN.TabIndex = 3
        Me.TxtACCOUNT_IN.Text = ""
        '
        'FrmBILL_RECEIVABLE_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(216, 137)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtACCOUNT_IN, Me.CmbACCOUNT_COMPANY, Me.txtACCONT_ARREARAGE, Me.txtACCOUNT_OCCUR, Me.txtACCOUNT_LAST, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.btQuit, Me.btResume, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBILL_RECEIVABLE_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ӧ�տ����_�༭"
        Me.ResumeLayout(False)

    End Sub

#End Region
    
    Private Sub FrmBILL_RECEIVABLE_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        Call FillACCOUNT_COMPANY()
        sqlstr = "select * from BILL_RECEIVABLE where BILL_RECEIVABLE_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("BILL_RECEIVABLE_ID")
            CmbACCOUNT_COMPANY.SelectedValue = ds.Tables(0).Rows(0).Item("ACCOUNT_COMPANY")
            txtACCOUNT_LAST.Text = ds.Tables(0).Rows(0).Item("ACCOUNT_LAST")
            txtACCOUNT_OCCUR.Text = ds.Tables(0).Rows(0).Item("ACCOUNT_OCCUR")
            TxtACCOUNT_IN.Text = ds.Tables(0).Rows(0).Item("ACCOUNT_IN")
            txtACCONT_ARREARAGE.Text = ds.Tables(0).Rows(0).Item("ACCONT_ARREARAGE")

        End If
        CmbACCOUNT_COMPANY.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            If MsgBox("��ȷ��Ҫ�޸���", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "��ʾ") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "�޸�", "BILL_RECEIVABLE", Trim(txtID.Text), "BILL_RECEIVABLE_ID")

                If CmbACCOUNT_COMPANY.SelectedValue <> "00" Then
                    Dim ACCONT_ARREARAGE As String
                    ds.Tables(0).Rows(0).Item("ACCOUNT_COMPANY") = CmbACCOUNT_COMPANY.SelectedValue

                    If Len(Trim(txtACCOUNT_LAST.Text)) > 0 Then
                        If IsNumeric(Trim(txtACCOUNT_LAST.Text)) Then
                            ds.Tables(0).Rows(0).Item("ACCOUNT_LAST") = Trim(txtACCOUNT_LAST.Text)
                        Else
                            MsgBox("����Ƿ��һ��Ӧ���������������ݣ�", MsgBoxStyle.Exclamation, "��ʾ")
                            Exit Sub
                        End If
                    Else
                        ds.Tables(0).Rows(0).Item("ACCOUNT_LAST") = 0
                    End If
                    If Len(Trim(txtACCOUNT_OCCUR.Text)) > 0 Then
                        If IsNumeric(Trim(txtACCOUNT_OCCUR.Text)) Then
                            ds.Tables(0).Rows(0).Item("ACCOUNT_OCCUR") = Trim(txtACCOUNT_OCCUR.Text)
                        Else
                            MsgBox("���·���һ��Ӧ���������������ݣ�", MsgBoxStyle.Exclamation, "��ʾ")
                            Exit Sub
                        End If
                    Else
                        ds.Tables(0).Rows(0).Item("ACCOUNT_OCCUR") = 0
                    End If
                    If Len(Trim(TxtACCOUNT_IN.Text)) > 0 Then
                        If IsNumeric(Trim(TxtACCOUNT_IN.Text)) Then
                            ds.Tables(0).Rows(0).Item("ACCOUNT_IN") = Trim(TxtACCOUNT_IN.Text)
                        Else
                            MsgBox("���µ���һ��Ӧ���������������ݣ�", MsgBoxStyle.Exclamation, "��ʾ")
                            Exit Sub
                        End If
                    Else
                        ds.Tables(0).Rows(0).Item("ACCOUNT_IN") = 0
                    End If

                    ACCONT_ARREARAGE = CType(txtACCOUNT_LAST.Text, Double) + CType(txtACCOUNT_OCCUR.Text, Double) - CType(TxtACCOUNT_IN.Text, Double)
                    txtACCONT_ARREARAGE.Text = ACCONT_ARREARAGE

                    If Len(Trim(txtACCONT_ARREARAGE.Text)) > 0 Then
                        ds.Tables(0).Rows(0).Item("ACCONT_ARREARAGE") = txtACCONT_ARREARAGE.Text
                    Else
                        ds.Tables(0).Rows(0).Item("ACCONT_ARREARAGE") = 0
                    End If

                    ds.Tables(0).Rows(0).Item("USER_NAME") = G_User

                    sqlda.Update(ds)
                    Call btQuit_Click(sender, e)
                Else
                    MsgBox("��ѡ��������λ��", MsgBoxStyle.Information, "��ʾ")
                End If

            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FillACCOUNT_COMPANY()
        Dim sqldc As String
        Dim dvc As New DataView()
        Dim dsc As New DataSet()
        sqldc = "select CODE_SHIP_AGENT,SHIPAGENT_SHORT from CODE_SHIP_AGENT"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbACCOUNT_COMPANY.DataSource = dvc
        Me.CmbACCOUNT_COMPANY.DisplayMember = "SHIPAGENT_SHORT"
        Me.CmbACCOUNT_COMPANY.ValueMember = "CODE_SHIP_AGENT"
    End Sub

    'Private Sub txtACCOUNT_LAST_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtACCOUNT_LAST.TextChanged
    '    Call ACCONT_ARREARAGE_SUM()
    'End Sub

    'Private Sub txtACCOUNT_OCCUR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtACCOUNT_OCCUR.TextChanged
    '    Call ACCONT_ARREARAGE_SUM()
    'End Sub

    'Private Sub TxtACCOUNT_IN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtACCOUNT_IN.TextChanged
    '    Call ACCONT_ARREARAGE_SUM()
    'End Sub

    'Private Sub ACCONT_ARREARAGE_SUM()

    '    Dim ACCONT_ARREARAGE As String

    '    ACCONT_ARREARAGE = CType(txtACCOUNT_LAST.Text, Double) + CType(txtACCOUNT_OCCUR.Text, Double) - CType(TxtACCOUNT_IN.Text, Double)
    '    txtACCONT_ARREARAGE.Text = ACCONT_ARREARAGE
    'End Sub

End Class
