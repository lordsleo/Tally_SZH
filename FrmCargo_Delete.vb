Imports TALLY.DBControl
Public Class FrmCargo_Delete
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Friend WithEvents Label5 As System.Windows.Forms.Label
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
    Friend WithEvents txtCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGoods As System.Windows.Forms.ComboBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents txtShort As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtENG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHA As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCargo = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtGoods = New System.Windows.Forms.ComboBox
        Me.btQuit = New System.Windows.Forms.Button
        Me.btResume = New System.Windows.Forms.Button
        Me.txtShort = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtENG = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCHA = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(84, 96)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(186, 20)
        Me.txtCargo.TabIndex = 145
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "�������"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGoods
        '
        Me.txtGoods.Location = New System.Drawing.Point(84, 74)
        Me.txtGoods.Name = "txtGoods"
        Me.txtGoods.Size = New System.Drawing.Size(186, 20)
        Me.txtGoods.TabIndex = 143
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(139, 150)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 141
        Me.btQuit.Text = "ȡ��"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(71, 150)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 140
        Me.btResume.Text = "ȷ��"
        '
        'txtShort
        '
        Me.txtShort.Location = New System.Drawing.Point(84, 118)
        Me.txtShort.MaxLength = 10
        Me.txtShort.Name = "txtShort"
        Me.txtShort.Size = New System.Drawing.Size(186, 21)
        Me.txtShort.TabIndex = 139
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "�Ʒѻ���"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtENG
        '
        Me.txtENG.Location = New System.Drawing.Point(84, 50)
        Me.txtENG.MaxLength = 30
        Me.txtENG.Name = "txtENG"
        Me.txtENG.Size = New System.Drawing.Size(186, 21)
        Me.txtENG.TabIndex = 136
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "����Ӣ������"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCHA
        '
        Me.txtCHA.Location = New System.Drawing.Point(84, 26)
        Me.txtCHA.MaxLength = 30
        Me.txtCHA.Name = "txtCHA"
        Me.txtCHA.Size = New System.Drawing.Size(186, 21)
        Me.txtCHA.TabIndex = 134
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "������������"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(84, 2)
        Me.txtCode.MaxLength = 12
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(186, 21)
        Me.txtCode.TabIndex = 132
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "�������"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 142
        Me.txtID.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "�ص����"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCargo_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(274, 179)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtGoods)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btResume)
        Me.Controls.Add(Me.txtShort)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtENG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCHA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargo_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�������_ɾ��"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCHA.Focus()
        End If
    End Sub
    Private Sub txtCHA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtENG.KeyPress
        If e.KeyChar = Chr(13) Then
            txtENG.Focus()
        End If
    End Sub
    Private Sub txtENG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCHA.KeyPress
        If e.KeyChar = Chr(13) Then
            txtGoods.Focus()
        End If
    End Sub

    Private Sub txtGoods_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGoods.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCargo.Focus()
        End If
    End Sub

    Private Sub txtCargo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCargo.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCargo.Focus()
        End If
    End Sub

    Private Sub txtShort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShort.KeyPress
        If e.KeyChar = Chr(13) Then
            Call btResume_Click(sender, e)
            txtCHA.Focus()
        End If
    End Sub

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim ds1 As New DataSet()
        Dim ds2 As New DataSet()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen

        sqlstr = "select Code_Goods_Type,Goods_Type from Code_Goods_Type Order by Code_Goods_Type"
        dw = Getdata(sqlstr, ds1)
        txtGoods.DataSource = ds1.Tables(0).DefaultView
        txtGoods.DisplayMember = "Goods_Type"
        txtGoods.ValueMember = "Code_Goods_Type"

        sqlstr = "select Code_Cargo_Type,Cargo_Type from Code_Cargo_Type Order by convert(int,Code_Cargo_Type)"
        dw = Getdata(sqlstr, ds2)
        txtCargo.DataSource = ds2.Tables(0).DefaultView
        txtCargo.DisplayMember = "Cargo_Type"
        txtCargo.ValueMember = "Code_Cargo_Type"

        sqlstr = "select * from codegoods where ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtCode.Text = ds.Tables(0).Rows(0).Item("Code")
            txtCHA.Text = ds.Tables(0).Rows(0).Item("Goods")
            txtENG.Text = ds.Tables(0).Rows(0).Item("Goods_ENG")
            txtGoods.SelectedValue = ds.Tables(0).Rows(0).Item("Code_Goods_Type")
            txtCargo.SelectedValue = ds.Tables(0).Rows(0).Item("Code_Cargo_Type")
            txtShort.Text = ds.Tables(0).Rows(0).Item("Goods_Short")
        End If
        txtCode.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub


    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            If MsgBox("��ȷ��Ҫɾ����", MsgBoxStyle.YesNo, "��ʾ") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "ɾ��", "Codegoods", Trim(txtID.Text), "ID")

                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)

                Dim updatetxt As String
                updatetxt = "delete from codegoods where code=''" & Trim(txtCode.Text) & "''"
                CodeOperation("codegoods", updatetxt)

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
