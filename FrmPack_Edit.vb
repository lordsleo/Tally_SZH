Imports TALLY.DBControl
Public Class FrmPack_Edit
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter
    Dim txt1, txt2, txt3 As String '����Ƿ��������޸�������
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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtENG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtShort As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button
        Me.btResume = New System.Windows.Forms.Button
        Me.txtENG = New System.Windows.Forms.TextBox
        Me.txtCHA = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtShort = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(137, 144)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 116
        Me.btQuit.Text = "ȡ��"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(57, 144)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 115
        Me.btResume.Text = "ȷ��"
        '
        'txtENG
        '
        Me.txtENG.Location = New System.Drawing.Point(86, 76)
        Me.txtENG.MaxLength = 40
        Me.txtENG.Name = "txtENG"
        Me.txtENG.Size = New System.Drawing.Size(170, 21)
        Me.txtENG.TabIndex = 113
        Me.txtENG.Text = ""
        '
        'txtCHA
        '
        Me.txtCHA.Location = New System.Drawing.Point(86, 44)
        Me.txtCHA.MaxLength = 40
        Me.txtCHA.Name = "txtCHA"
        Me.txtCHA.Size = New System.Drawing.Size(170, 21)
        Me.txtCHA.TabIndex = 112
        Me.txtCHA.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "��װӢ������"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "��װ��������"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(86, 10)
        Me.txtCode.MaxLength = 2
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(170, 21)
        Me.txtCode.TabIndex = 109
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "��װ����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(4, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 117
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtShort
        '
        Me.txtShort.Location = New System.Drawing.Point(86, 112)
        Me.txtShort.MaxLength = 40
        Me.txtShort.Name = "txtShort"
        Me.txtShort.Size = New System.Drawing.Size(170, 21)
        Me.txtShort.TabIndex = 113
        Me.txtShort.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "��װӢ����д"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmPack_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(258, 184)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btResume)
        Me.Controls.Add(Me.txtENG)
        Me.Controls.Add(Me.txtCHA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtShort)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPack_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��װ��Ϣ_�༭"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select * from Code_Pack where Pack_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("Pack_ID")
            txtCode.Text = ds.Tables(0).Rows(0).Item("Code_Pack")
            txtCHA.Text = ds.Tables(0).Rows(0).Item("Pack_Cha")
            txtENG.Text = ds.Tables(0).Rows(0).Item("Pack_Eng")
            txtShort.Text = ds.Tables(0).Rows(0).Item("PACK_SHORT")

            txt1 = ds.Tables(0).Rows(0).Item("Pack_Cha")
            txt2 = ds.Tables(0).Rows(0).Item("Pack_Eng")
            txt3 = ds.Tables(0).Rows(0).Item("PACK_SHORT")
        End If
        txtCHA.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            If MsgBox("��ȷ��Ҫ�޸���", MsgBoxStyle.YesNo, "��ʾ") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "�޸�", "Code_Pack", Trim(txtID.Text), "Pack_ID")

                ds.Tables(0).Rows(0).Item("Pack_CHA") = txtCHA.Text
                ds.Tables(0).Rows(0).Item("Pack_ENG") = txtENG.Text
                ds.Tables(0).Rows(0).Item("PACK_SHORT") = txtShort.Text
                sqlda.Update(ds)

                If Not (txt1 = Trim(txtCHA.Text) And txt2 = Trim(txtENG.Text) And txt3 = Trim(txtShort.Text)) Then
                    Dim updatetxt As String
                    updatetxt = "update code_pack set pack_cha=''" & Trim(txtCHA.Text) & "'',pack_eng=''" & Trim(txtENG.Text) & "'',pack_short=''" & Trim(txtShort.Text) & "'' where code_pack=''" & Trim(txtCode.Text) & "''"
                    CodeOperation("code_pack", updatetxt)
                End If

                Call btQuit_Click(sender, e)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCHA.Focus()
        End If
    End Sub

    Private Sub txtCHA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCHA.KeyPress
        If e.KeyChar = Chr(13) Then
            txtENG.Focus()
        End If
    End Sub

    Private Sub txtENG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtENG.KeyPress
        If e.KeyChar = Chr(13) Then
            btResume.Focus()
        End If
    End Sub
End Class
