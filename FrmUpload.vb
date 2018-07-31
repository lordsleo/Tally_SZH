Imports TALLY.DBControl
Imports System.IO

Public Class FrmUpload
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写 dispose 以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmUpload))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(440, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "……"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(262, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "返  回"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(138, 184)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 32)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "上传文件"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "上传文件路径："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(8, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 16)
        Me.Label3.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(408, 21)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = ""
        '
        'FrmUpload
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(484, 244)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUpload"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "文件上传"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim PathStr As String
    Dim FilePath As String
    Dim FileName As String
    Dim Read_FilePath As String

    Private Sub FrmUpload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        readpath()
        If Read_FilePath.Length > 0 Then
            TextBox1.Text = Read_FilePath
        Else
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub readpath()
        Dim strinfo As String
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        FilePath = PathStr + "Tally.ini"

        Try
            Dim sr As New StreamReader(FilePath)
            Do While sr.Peek() > 0
                strinfo = sr.ReadLine()
                If strinfo = "[upload]" Then
                    strinfo = sr.ReadLine()
                    Read_FilePath = strinfo
                    Return
                End If
            Loop
            sr.Close()
        Catch
            MsgBox("读取设置文件信息出错，请检查！", MsgBoxStyle.OKOnly, "提示")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Label3.Text = ""
            Me.Refresh()

            Me.OpenFileDialog1.Title = "Open"
            Me.OpenFileDialog1.Filter = "Excel文件(*.xls)|*.xls|PDF文件(*.pdf)|*.pdf|All files (*.*)|*.*"
            'Me.OpenFileDialog1.ShowDialog()
            Me.OpenFileDialog1.RestoreDirectory = True
            Me.OpenFileDialog1.InitialDirectory = Read_FilePath

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                FilePath = Me.OpenFileDialog1.FileName
                TextBox1.Text = FilePath
            End If

            If File.Exists(FilePath) Then
                Me.Button3.Enabled = True
            Else
                Me.Button3.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("文件选择错误，请检查！", MsgBoxStyle.OKOnly, "提示")
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim ds As New DataSet
            Dim dw As New DataView
            Dim sqlstr As String
            Dim strsql As String
            Dim strDesc As String
            Dim arid As Integer = -1
            If FileName = "" Then
                FileName = Mid(FilePath, InStrRev(FilePath, "\") + 1)
            Else
                FileName = FileName
            End If

            'sqlstr = "SELECT MAX(id) FROM File_bak where SHIP_ID=" & Ship_ID & " and file_name='" & FileName & "'"
            'DBControl.Getdata(sqlstr, ds)
            'If ds.Tables.Count > 0 Then
            '    If IsDBNull(ds.Tables(0).Rows(0)(0)) = False Then
            '        arid = ds.Tables(0).Rows(0)(0)
            '    End If
            'End If

            If len(Trim(FilePath)) > 0 Then
                Dim len As Integer
                Dim fs As New System.IO.FileStream(FilePath, IO.FileMode.OpenOrCreate, IO.FileAccess.Read)
                Dim MyData(fs.Length) As Byte
                fs.Read(MyData, 0, fs.Length)
                len = System.Math.Round(fs.Length / 1024)
                fs.Close()
                fs = Nothing
                Dim sqlconn As New System.Data.SqlClient.SqlConnection(DBControl.connstr)
                Dim sqlcmd As New System.Data.SqlClient.SqlCommand
                sqlcmd.Connection = sqlconn

                'If arid > 0 Then
                '    strsql = "UPDATE File_bak set MODIFI_DATE='" & Now.ToString & "',user_name='" & G_User & "', upload_file=@image where SHIP_ID=" & ID & " and file_name='" & FileName & "'"
                'Else
                'strsql = "INSERT INTO File_bak(SHIP_ID,file_name,upload_date,modifi_date,upload_file,file_size,user_name)"
                'strsql = strsql + " VALUES( " & Ship_ID & ", '" & FileName & "','" & Now.ToString & "' , '" & Now.ToString & "',"
                'strsql = strsql + "  @image," & fs.Length & ", '" & G_User & "')"
                'End If
                'DBControl.ExecSql(strsql)

                strsql = "INSERT INTO File_bak(SHIP_ID,file_name,upload_date,modifi_date,upload_file,file_size,user_name)"
                strsql = strsql + " VALUES( " & Ship_ID & ", '" & FileName & "',"
                strsql = strsql + " '" & Now.ToString & "' , '" & Now.ToString & "',"
                strsql = strsql + "  @image, " & len & ", '" & G_User & "')"

                sqlcmd.CommandText = strsql
                sqlcmd.Parameters.Add("@image", OleDb.OleDbType.Binary).Value = MyData
                sqlconn.Open()
                sqlcmd.ExecuteNonQuery()
                sqlconn.Close()
                MsgBox("文件上传结束！", MsgBoxStyle.OKOnly, "提示")

                '删除本地文件
                File.Delete(FilePath)
            End If
        Catch
            MsgBox("文件上传失败，请检查！", MsgBoxStyle.OKOnly, "提示")
        End Try
        'Try
        '    Dim strsql As String 
        '    Dim ds As New DataSet

        '    strsql = "select ship_id from shipgraph_upload where id=1"
        '    Getdata(strsql, ds)
        '    Label2.Text = ds.Tables(0).Rows(0)(0)

        '    Dim dvup As System.Data.DataView
        '    Dim wc As New System.Net.WebClient

        '    wc.UploadFile(serverurl, FilePath)

        '    Me.Label3.Text = "正在上传文件………"
        '    Me.Refresh()


        '    Me.Label3.Text = "文件上传成功！"
        '    Me.Button3.Enabled = False
        '    Me.Refresh()
        'Catch ex As Exception
        '    Me.Label3.Text = "上传文件时发生错误！"
        '    Me.Refresh()
        'End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

    End Sub

End Class
