Imports TALLY.DBControl
Public Class Frmnewgoods_Add
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
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtShort As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtENG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHA As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.btAdd = New System.Windows.Forms.Button
        Me.txtShort = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtENG = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCHA = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtCargo = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(172, 144)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 110
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(104, 144)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 109
        Me.btSave.Text = "ȷ��"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(36, 144)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 108
        Me.btAdd.Text = "���"
        '
        'txtShort
        '
        Me.txtShort.Location = New System.Drawing.Point(86, 112)
        Me.txtShort.MaxLength = 4
        Me.txtShort.Name = "txtShort"
        Me.txtShort.Size = New System.Drawing.Size(182, 21)
        Me.txtShort.TabIndex = 107
        Me.txtShort.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "����˳��"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtENG
        '
        Me.txtENG.Location = New System.Drawing.Point(86, 64)
        Me.txtENG.MaxLength = 30
        Me.txtENG.Name = "txtENG"
        Me.txtENG.Size = New System.Drawing.Size(182, 21)
        Me.txtENG.TabIndex = 104
        Me.txtENG.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "����Ӣ������"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCHA
        '
        Me.txtCHA.Location = New System.Drawing.Point(86, 40)
        Me.txtCHA.MaxLength = 30
        Me.txtCHA.Name = "txtCHA"
        Me.txtCHA.Size = New System.Drawing.Size(182, 21)
        Me.txtCHA.TabIndex = 102
        Me.txtCHA.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "������������"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(86, 16)
        Me.txtCode.MaxLength = 12
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(182, 21)
        Me.txtCode.TabIndex = 100
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "�������"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(4, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 111
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(86, 88)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(182, 20)
        Me.txtCargo.TabIndex = 114
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "��������"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Frmnewgoods_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(272, 181)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.txtShort)
        Me.Controls.Add(Me.Label5)
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
        Me.Name = "Frmnewgoods_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��������_����"
        Me.ResumeLayout(False)

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
            'txtGoods.Focus()
        End If
    End Sub

    Private Sub txtGoods_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
            Call btSave_Click(sender, e)
            txtCode.Focus()
        End If
    End Sub

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen

        sqlstr = "SELECT goods_type_code, goods_type_name FROM newcodegoodstype "
        dw = Getdata(sqlstr, ds2)
        txtCargo.DataSource = ds2.Tables(0).DefaultView
        txtCargo.DisplayMember = "goods_type_name"
        txtCargo.ValueMember = "goods_type_code"

        sqlstr = "select * from newcodegoods where ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtCode.Text = ds.Tables(0).Rows(0).Item("code_goods")
            txtCHA.Text = ds.Tables(0).Rows(0).Item("goods_name")
            txtENG.Text = ds.Tables(0).Rows(0).Item("goods")
            txtCargo.SelectedValue = ds.Tables(0).Rows(0).Item("goods_type")
            'txtShort.Text = ds.Tables(0).Rows(0).Item("Goods_Short")
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
            Dim dsSave As New DataSet
            If Getdata("select * from newcodegoods where code_goods='" & Trim(txtCode.Text) & "'", dsSave).Count > 0 Then
                MsgBox("�����Ѵ��ڴ˻��������Ϣ,��ע����!")
                Exit Sub
            End If
            If Len(Trim(txtCode.Text)) > 0 And Len(Trim(txtCHA.Text)) > 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()

                row("code_goods") = Trim(txtCode.Text)
                row("goods_name") = Trim(txtCHA.Text)
                row("goods") = Trim(txtENG.Text)
                row("goods_type") = Trim(txtCargo.SelectedValue)

                '             System.Text.RegularExpressions.Regex(reg1)
                '	= new System.Text.RegularExpressions.Regex(@"^[-]?\d+[.]?\d*$");
                'return reg1.IsMatch(str); 

                row("sequence") = Trim(txtShort.Text)
                'row("User_Name") = Trim(G_User)


                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
                Me.Close()
            Else
                MsgBox("����,���Ʋ���Ϊ��!", MsgBoxStyle.Critical, "��ʾ")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
