Imports TALLY.DBControl
Public Class FrmDuty_Delete
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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents txtENG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btResume = New System.Windows.Forms.Button()
        Me.txtENG = New System.Windows.Forms.TextBox()
        Me.txtCHA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(102, 108)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 117
        Me.btQuit.Text = "ȡ��"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(34, 108)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 116
        Me.btResume.Text = "ȷ��"
        '
        'txtENG
        '
        Me.txtENG.Location = New System.Drawing.Point(88, 78)
        Me.txtENG.MaxLength = 20
        Me.txtENG.Name = "txtENG"
        Me.txtENG.Size = New System.Drawing.Size(106, 21)
        Me.txtENG.TabIndex = 114
        Me.txtENG.Text = ""
        '
        'txtCHA
        '
        Me.txtCHA.Location = New System.Drawing.Point(88, 44)
        Me.txtCHA.MaxLength = 20
        Me.txtCHA.Name = "txtCHA"
        Me.txtCHA.Size = New System.Drawing.Size(106, 21)
        Me.txtCHA.TabIndex = 113
        Me.txtCHA.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "ְ��Ӣ������"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "ְ����������"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(88, 12)
        Me.txtCode.MaxLength = 2
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(106, 21)
        Me.txtCode.TabIndex = 110
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "ְ�����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 115
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'FrmDuty_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(198, 137)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btQuit, Me.btResume, Me.txtENG, Me.txtCHA, Me.Label3, Me.Label2, Me.txtCode, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDuty_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ְ����Ϣ_ɾ��"
        Me.ResumeLayout(False)

    End Sub

#End Region
    
    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select * from Code_Duty where Duty_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("Duty_ID")
            txtCode.Text = ds.Tables(0).Rows(0).Item("Code_Duty")
            txtCHA.Text = ds.Tables(0).Rows(0).Item("Duty_Cha")
            txtENG.Text = ds.Tables(0).Rows(0).Item("Duty_Eng")

        End If


        txtCHA.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub
    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            If MsgBox("��ȷ��Ҫɾ����", MsgBoxStyle.YesNo, "��ʾ") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "ɾ��", "Code_Duty", Trim(txtID.Text), "Duty_ID")

                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)
                Call btQuit_Click(sender, e)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
