Imports TALLY.DBControl
Public Class Frm_file_no
    Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д dispose ����������б�
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

    'ע��: ���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnCancle As System.Windows.Forms.Button
    Friend WithEvents txtFileNo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnEnter = New System.Windows.Forms.Button
        Me.btnCancle = New System.Windows.Forms.Button
        Me.txtFileNo = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(66, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "������"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(74, 98)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(65, 24)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "ȷ��"
        '
        'btnCancle
        '
        Me.btnCancle.Location = New System.Drawing.Point(142, 98)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(65, 24)
        Me.btnCancle.TabIndex = 1
        Me.btnCancle.Text = "ȡ��"
        '
        'txtFileNo
        '
        Me.txtFileNo.Location = New System.Drawing.Point(115, 38)
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.TabIndex = 2
        Me.txtFileNo.Text = ""
        '
        'Frm_file_no
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(280, 167)
        Me.Controls.Add(Me.txtFileNo)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_file_no"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "������"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet
    Dim dsFileNo As New DataSet
    Dim strsql As String
    Dim sqlad As New SqlClient.SqlDataAdapter
    Dim strFile_no As String
    Private Sub Frm_file_no_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strsql = "select top 1 FILE_NO from sship group by file_No  having right(file_no,2)=max(right(file_no,2)) and left(file_no,4)=max(left(file_no,4)) order by right(file_no,2) desc,left(file_no,4) desc"
        Getdata(strsql, ds) 'ȡ����ǰ�����ĵ������
        strsql = "select ship_id,file_no from sship where ship_id=" & Ship_ID
        Updatedata(sqlad, strsql, dsFileNo)
        '������=��ţ���λ��/��ţ�����λ��
        If ds.Tables(0).Rows.Count > 0 Then
            If (ds.Tables(0).Rows(0).Item(0) Is System.DBNull.Value) = False Then
                '���ݿ���������
                strFile_no = ds.Tables(0).Rows(0).Item(0)
                If Len(Trim(strFile_no)) > 0 Then
                    '���ݿ������ݲ�Ϊ�ո񣬷ǿ�
                    If Len(CInt(Mid(strFile_no, 1, 4)) + 1) = 4 Then
                        strFile_no = "000" & (CInt(Mid(strFile_no, 1, 4)) + 1) & Microsoft.VisualBasic.Right(strFile_no, 3)
                    ElseIf Len(CInt(Mid(strFile_no, 1, 4)) + 1) = 5 Then
                        strFile_no = "00" & (CInt(Mid(strFile_no, 1, 4)) + 1) & Microsoft.VisualBasic.Right(strFile_no, 3)
                    ElseIf Len(CInt(Mid(strFile_no, 1, 4)) + 1) = 6 Then
                        strFile_no = "0" & (CInt(Mid(strFile_no, 1, 4)) + 1) & Microsoft.VisualBasic.Right(strFile_no, 3)
                    Else
                        strFile_no = (CInt(Mid(strFile_no, 1, 4)) + 1) & Microsoft.VisualBasic.Right(strFile_no, 3)
                    End If
                    Me.txtFileNo.Text = strFile_no
                End If
            End If
        Else
            Me.txtFileNo.Text = "0001/04"
        End If
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        dsFileNo.Tables(0).Rows(0).Item(1) = Me.txtFileNo.Text
        Try
            sqlad.Update(dsFileNo)
        Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancle.Click
        Me.Close()
    End Sub
End Class
