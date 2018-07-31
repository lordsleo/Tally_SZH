Imports TALLY.DBControl
Public Class FrmPAY_PERFORMANCE_Dialog
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents DTPABSENTDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DTPABSENTDATE = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btResume = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'DTPABSENTDATE
        '
        Me.DTPABSENTDATE.CustomFormat = "yyyy-MM"
        Me.DTPABSENTDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPABSENTDATE.Location = New System.Drawing.Point(60, 30)
        Me.DTPABSENTDATE.Name = "DTPABSENTDATE"
        Me.DTPABSENTDATE.Size = New System.Drawing.Size(88, 21)
        Me.DTPABSENTDATE.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "����"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(82, 64)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 1
        Me.btQuit.Text = "ȡ��"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(14, 64)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 0
        Me.btResume.Text = "ȷ��"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(60, 6)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(88, 20)
        Me.CmbDEPT_CODE.TabIndex = 2
        '
        'FrmPAY_PERFORMANCE_Dialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(164, 97)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbDEPT_CODE)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btResume)
        Me.Controls.Add(Me.DTPABSENTDATE)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPAY_PERFORMANCE_Dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��Ч����_����"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmABSENT_Print_Dialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillDEPT_CODE()

    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        If MsgBox("��ȷ��Ҫ������¼�Ч����������", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "��ʾ") = MsgBoxResult.Yes Then

            ExecSql("exec sp_PAY_PERFORMANCE '" & G_DeptCode & "','" & DTPABSENTDATE.Value & "'")
            GL_Date = DTPABSENTDATE.Value
            Me.Close()
        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FillDEPT_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT where DEPT_CODE='" & G_DeptCode & "' "
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDEPT_CODE.DataSource = dvc
        Me.CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE.ValueMember = "DEPT_CODE"
    End Sub

End Class
