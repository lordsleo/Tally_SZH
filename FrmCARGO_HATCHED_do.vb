Imports TALLY.DBControl
Imports Microsoft.VisualBasic

Public Class FrmCARGO_HATCHED_do
    Inherits System.Windows.Forms.Form
    Dim dshatch As New DataSet()
    Dim dw As New DataView()
    Dim ds_unloadport As New DataSet()
    Dim port As String
   
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
    Friend WithEvents BtDO As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Combunload As System.Windows.Forms.ComboBox
    Friend WithEvents BTquit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtDO = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Combunload = New System.Windows.Forms.ComboBox
        Me.BTquit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtDO
        '
        Me.BtDO.Location = New System.Drawing.Point(32, 56)
        Me.BtDO.Name = "BtDO"
        Me.BtDO.Size = New System.Drawing.Size(70, 24)
        Me.BtDO.TabIndex = 0
        Me.BtDO.Text = "�������"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "��ѡ��ж����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Combunload
        '
        Me.Combunload.Location = New System.Drawing.Point(110, 18)
        Me.Combunload.Name = "Combunload"
        Me.Combunload.Size = New System.Drawing.Size(102, 20)
        Me.Combunload.TabIndex = 5
        '
        'BTquit
        '
        Me.BTquit.Location = New System.Drawing.Point(122, 56)
        Me.BTquit.Name = "BTquit"
        Me.BTquit.Size = New System.Drawing.Size(70, 24)
        Me.BTquit.TabIndex = 6
        Me.BTquit.Text = "ȡ��"
        '
        'FrmCARGO_HATCHED_do
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(224, 103)
        Me.Controls.Add(Me.BTquit)
        Me.Controls.Add(Me.Combunload)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtDO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCARGO_HATCHED_do"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "����ֲյ�_����"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BtDO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDO.Click
        Dim ds_eng As New DataSet()
        If Len(Combunload.SelectedValue) > 0 Then
            ds_sship.Reset()
            DS_DO.Reset()
            dw = Getdata("select PORT_ENG,port_cha from code_port where CODE_PORT='" & Combunload.SelectedValue & "'", ds_eng)
            dw = Getdata("select * from view_outhatch_sship where ship_id='" & Ship_ID & "'", ds_sship)
            'If ds_sship.Tables(0).Rows.Count > 0 Then
            '    trade = ds_sship.Tables(0).Rows(0).Item("s_trade")
                'If trade = "1" Then
                '    dw = Getdata("exec sp_cargo_outhatch '" & Ship_ID & "','" & Combunload.SelectedValue & "'", DS_DO)
                '    mark = "1"
                '    If ds_eng.Tables(0).Rows.Count > 0 Then
                '        UNLOADPORT = ds_eng.Tables(0).Rows(0).Item("port_cha")
                '    End If
                '    Me.Close()
                'ElseIf trade = "2" Then
            ' dw = Getdata("exec sp_cargo_outhatch_eng '" & Ship_ID & "','" & Combunload.SelectedValue & "'", DS_DO)
            dw = Getdata("exec sp_cargo_outhatch_new '" & Ship_ID & "','" & Combunload.SelectedValue & "'", DS_DO)
                mark = "1"
                If ds_eng.Tables(0).Rows.Count > 0 Then
                    UNLOADPORT = ds_eng.Tables(0).Rows(0).Item("port_eng")
                End If
                Me.Close()
                Exit Sub
                'End If
            'End If
        Else
            MsgBox("��ѡ��ж���ۣ�")
        End If
    End Sub

    Private Sub Btprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If trade = "1" Then
        '        Call china()
        '    ElseIf trade = "2" Then
        '        Call eng()
        '    End If
        'Catch
        '    xlApp.Quit()
        '    SendKeys.Send("n")
        'End Try
    End Sub

    Private Sub FrmCARGO_HATCHED_do_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dw = Getdata("exec sp_cargo_hatched_unload '" & Ship_ID & "'", ds_unloadport)
        Combunload.DataSource = ds_unloadport.Tables(0).DefaultView
        Combunload.DisplayMember = "port_cha"
        Combunload.ValueMember = "port"
        mark = "0"
    End Sub

    Private Sub BTquit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTquit.Click
        mark = "0"
        Me.Close()
    End Sub
End Class
