Imports TALLY.DBControl
Public Class FrmCargoDamagedDegree_Add
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
    Friend WithEvents txtShort As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents txtENG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtShort = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.txtENG = New System.Windows.Forms.TextBox()
        Me.txtCHA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtShort
        '
        Me.txtShort.Location = New System.Drawing.Point(86, 86)
        Me.txtShort.MaxLength = 4
        Me.txtShort.Name = "txtShort"
        Me.txtShort.Size = New System.Drawing.Size(150, 21)
        Me.txtShort.TabIndex = 133
        Me.txtShort.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "���Ǵ�"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(154, 114)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 130
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(86, 114)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 129
        Me.btSave.Text = "ȷ��"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(18, 114)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 128
        Me.btAdd.Text = "���"
        '
        'txtENG
        '
        Me.txtENG.Location = New System.Drawing.Point(86, 58)
        Me.txtENG.MaxLength = 100
        Me.txtENG.Name = "txtENG"
        Me.txtENG.Size = New System.Drawing.Size(150, 21)
        Me.txtENG.TabIndex = 127
        Me.txtENG.Text = ""
        '
        'txtCHA
        '
        Me.txtCHA.Location = New System.Drawing.Point(86, 30)
        Me.txtCHA.MaxLength = 40
        Me.txtCHA.Name = "txtCHA"
        Me.txtCHA.Size = New System.Drawing.Size(150, 21)
        Me.txtCHA.TabIndex = 126
        Me.txtCHA.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "��λӢ������"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "��λ��������"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(86, 2)
        Me.txtCode.MaxLength = 4
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(150, 21)
        Me.txtCode.TabIndex = 123
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "��λ����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(4, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 131
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'FrmCargoDamagedDegree_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(238, 141)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtShort, Me.Label4, Me.btQuit, Me.btSave, Me.btAdd, Me.txtENG, Me.txtCHA, Me.Label3, Me.Label2, Me.txtCode, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoDamagedDegree_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�������̶Ȳ�λ��Ϣ_����"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select * from CODE_CARGO_DAMAGED_Degree where CARGO_DAMAGED_Degree_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("CARGO_DAMAGED_Degree_ID")
            txtCode.Text = ds.Tables(0).Rows(0).Item("CODE_CARGO_DAMAGED_Degree")
            txtCHA.Text = ds.Tables(0).Rows(0).Item("CARGO_DAMAGED_Degree_CHA")
            txtENG.Text = ds.Tables(0).Rows(0).Item("CARGO_DAMAGED_Degree_ENG")
            txtShort.Text = ds.Tables(0).Rows(0).Item("CARGO_DAMAGED_Degree_SHORT")
        End If


        txtCode.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        txtCode.Text = ""
        txtCHA.Text = ""
        txtENG.Text = ""
        txtShort.Text = ""
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim dsSave As New DataSet()
            If Getdata("select * from CODE_CARGO_DAMAGED_Degree where CODE_CARGO_DAMAGED_Degree='" & Trim(txtCode.Text) & "'", dsSave).Count > 0 Then
                MsgBox("�����Ѵ��ڴ˻������̶Ȳ�λ��Ϣ,��ע����!")
                Exit Sub
            End If
            If Len(Trim(txtCode.Text)) > 0 And Len(Trim(txtCHA.Text)) > 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()

                row("CODE_CARGO_DAMAGED_Degree") = Trim(txtCode.Text)
                row("CARGO_DAMAGED_Degree_CHA") = Trim(txtCHA.Text)
                row("CARGO_DAMAGED_Degree_ENG") = Trim(txtENG.Text)
                row("CARGO_DAMAGED_Degree_SHORT") = Trim(txtShort.Text)
                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
                Me.Close()
            Else
                MsgBox("�̶Ȳ�λ���벻��Ϊ��!", MsgBoxStyle.Critical, "��ʾ")
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
            txtShort.Focus()
        End If
    End Sub
    Private Sub txtShort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShort.KeyPress
        If e.KeyChar = Chr(13) Then
            btSave.Focus()
        End If
    End Sub
End Class
