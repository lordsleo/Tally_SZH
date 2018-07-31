Imports System.Web.Mail
Imports System.IO
Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmCon_Certificate_EDI
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
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btRead As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LSign As System.Windows.Forms.TextBox
    Friend WithEvents LEndTime As System.Windows.Forms.Label
    Friend WithEvents LNextPort As System.Windows.Forms.Label
    Friend WithEvents LShipOwner As System.Windows.Forms.Label
    Friend WithEvents LShipCompany As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbEmail As System.Windows.Forms.ComboBox
    Friend WithEvents txtShipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LJinChu As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LVoyage As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LEnglish As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LChina As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btWriteNew As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents OpenFile As System.Windows.Forms.Button
    Friend WithEvents Send As System.Windows.Forms.Button
    Friend WithEvents PB As System.Windows.Forms.ProgressBar
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtManager As System.Windows.Forms.TextBox
    Friend WithEvents txtTally As System.Windows.Forms.TextBox
    Friend WithEvents dtpBeg As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMake As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.btRead = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.LSign = New System.Windows.Forms.TextBox
        Me.LEndTime = New System.Windows.Forms.Label
        Me.LNextPort = New System.Windows.Forms.Label
        Me.LShipOwner = New System.Windows.Forms.Label
        Me.LShipCompany = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbEmail = New System.Windows.Forms.ComboBox
        Me.txtShipCode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LJinChu = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LVoyage = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LEnglish = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LChina = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btWriteNew = New System.Windows.Forms.Button
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.OpenFile = New System.Windows.Forms.Button
        Me.Send = New System.Windows.Forms.Button
        Me.PB = New System.Windows.Forms.ProgressBar
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtManager = New System.Windows.Forms.TextBox
        Me.txtTally = New System.Windows.Forms.TextBox
        Me.dtpBeg = New System.Windows.Forms.DateTimePicker
        Me.dtpMake = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'btRead
        '
        Me.btRead.Location = New System.Drawing.Point(76, 146)
        Me.btRead.Name = "btRead"
        Me.btRead.Size = New System.Drawing.Size(72, 24)
        Me.btRead.TabIndex = 65
        Me.btRead.Text = "查看报文"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(92, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 14)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "呼号"
        '
        'LSign
        '
        Me.LSign.Location = New System.Drawing.Point(124, 38)
        Me.LSign.Name = "LSign"
        Me.LSign.Size = New System.Drawing.Size(54, 21)
        Me.LSign.TabIndex = 63
        Me.LSign.Text = ""
        '
        'LEndTime
        '
        Me.LEndTime.Location = New System.Drawing.Point(144, 134)
        Me.LEndTime.Name = "LEndTime"
        Me.LEndTime.Size = New System.Drawing.Size(16, 8)
        Me.LEndTime.TabIndex = 62
        Me.LEndTime.Visible = False
        '
        'LNextPort
        '
        Me.LNextPort.Location = New System.Drawing.Point(244, 136)
        Me.LNextPort.Name = "LNextPort"
        Me.LNextPort.Size = New System.Drawing.Size(12, 6)
        Me.LNextPort.TabIndex = 61
        Me.LNextPort.Visible = False
        '
        'LShipOwner
        '
        Me.LShipOwner.Location = New System.Drawing.Point(216, 134)
        Me.LShipOwner.Name = "LShipOwner"
        Me.LShipOwner.Size = New System.Drawing.Size(12, 8)
        Me.LShipOwner.TabIndex = 58
        Me.LShipOwner.Visible = False
        '
        'LShipCompany
        '
        Me.LShipCompany.Location = New System.Drawing.Point(230, 134)
        Me.LShipCompany.Name = "LShipCompany"
        Me.LShipCompany.Size = New System.Drawing.Size(4, 8)
        Me.LShipCompany.TabIndex = 57
        Me.LShipCompany.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(182, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "收文用户"
        '
        'cbEmail
        '
        Me.cbEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmail.Location = New System.Drawing.Point(238, 38)
        Me.cbEmail.Name = "cbEmail"
        Me.cbEmail.Size = New System.Drawing.Size(130, 20)
        Me.cbEmail.TabIndex = 55
        '
        'txtShipCode
        '
        Me.txtShipCode.Location = New System.Drawing.Point(30, 38)
        Me.txtShipCode.Name = "txtShipCode"
        Me.txtShipCode.Size = New System.Drawing.Size(60, 21)
        Me.txtShipCode.TabIndex = 54
        Me.txtShipCode.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 14)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "船码"
        '
        'LJinChu
        '
        Me.LJinChu.Location = New System.Drawing.Point(238, 22)
        Me.LJinChu.Name = "LJinChu"
        Me.LJinChu.Size = New System.Drawing.Size(128, 14)
        Me.LJinChu.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(182, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "进出口"
        '
        'LVoyage
        '
        Me.LVoyage.Location = New System.Drawing.Point(56, 22)
        Me.LVoyage.Name = "LVoyage"
        Me.LVoyage.Size = New System.Drawing.Size(124, 14)
        Me.LVoyage.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "航次"
        '
        'LEnglish
        '
        Me.LEnglish.Location = New System.Drawing.Point(238, 2)
        Me.LEnglish.Name = "LEnglish"
        Me.LEnglish.Size = New System.Drawing.Size(128, 16)
        Me.LEnglish.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(182, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "英文船名"
        '
        'LChina
        '
        Me.LChina.Location = New System.Drawing.Point(56, 2)
        Me.LChina.Name = "LChina"
        Me.LChina.Size = New System.Drawing.Size(124, 16)
        Me.LChina.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "中文船名"
        '
        'btWriteNew
        '
        Me.btWriteNew.Location = New System.Drawing.Point(2, 146)
        Me.btWriteNew.Name = "btWriteNew"
        Me.btWriteNew.Size = New System.Drawing.Size(72, 24)
        Me.btWriteNew.TabIndex = 44
        Me.btWriteNew.Text = "生成报文"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(0, 62)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(304, 21)
        Me.txtFile.TabIndex = 43
        Me.txtFile.Text = ""
        '
        'OpenFile
        '
        Me.OpenFile.Location = New System.Drawing.Point(306, 62)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Size = New System.Drawing.Size(62, 20)
        Me.OpenFile.TabIndex = 42
        Me.OpenFile.Text = "打开文件"
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(150, 146)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(72, 24)
        Me.Send.TabIndex = 41
        Me.Send.Text = "发送报文"
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(0, 172)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(368, 18)
        Me.PB.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(2, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "开工日期"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(182, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 16)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "制单日期"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(2, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "理货组长"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(182, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 16)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "业务主管"
        '
        'txtManager
        '
        Me.txtManager.Location = New System.Drawing.Point(238, 108)
        Me.txtManager.Name = "txtManager"
        Me.txtManager.Size = New System.Drawing.Size(128, 21)
        Me.txtManager.TabIndex = 71
        Me.txtManager.Text = ""
        '
        'txtTally
        '
        Me.txtTally.Location = New System.Drawing.Point(58, 108)
        Me.txtTally.Name = "txtTally"
        Me.txtTally.Size = New System.Drawing.Size(122, 21)
        Me.txtTally.TabIndex = 72
        Me.txtTally.Text = ""
        '
        'dtpBeg
        '
        Me.dtpBeg.Location = New System.Drawing.Point(58, 86)
        Me.dtpBeg.Name = "dtpBeg"
        Me.dtpBeg.Size = New System.Drawing.Size(122, 21)
        Me.dtpBeg.TabIndex = 73
        '
        'dtpMake
        '
        Me.dtpMake.Location = New System.Drawing.Point(240, 86)
        Me.dtpMake.Name = "dtpMake"
        Me.dtpMake.Size = New System.Drawing.Size(126, 21)
        Me.dtpMake.TabIndex = 74
        '
        'FrmCon_Certificate_EDI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(370, 191)
        Me.Controls.Add(Me.dtpMake)
        Me.Controls.Add(Me.dtpBeg)
        Me.Controls.Add(Me.txtTally)
        Me.Controls.Add(Me.txtManager)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.btRead)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LSign)
        Me.Controls.Add(Me.LEndTime)
        Me.Controls.Add(Me.LNextPort)
        Me.Controls.Add(Me.LShipOwner)
        Me.Controls.Add(Me.LShipCompany)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbEmail)
        Me.Controls.Add(Me.txtShipCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LJinChu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LVoyage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LEnglish)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LChina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btWriteNew)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.OpenFile)
        Me.Controls.Add(Me.Send)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmCon_Certificate_EDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "生成理货结果汇总证明报文"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet
    Dim dw As New DataView
    Dim sqlstr As String
    Dim BackUpFile As String
    Dim ConTypeOwner As String
    Dim PortOwner As String

    Private Sub FrmCon_Certificate_EDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds1 As New DataSet
        Dim dw1 As New DataView
        Dim PathStr As String
        Dim FilePath As String

        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "EDIINI.INI"
            Dim sr As New StreamReader(FilePath) '打开报文文件
            txtFile.Text = sr.ReadLine()
            BackUpFile = sr.ReadLine()
            BackUpFile = sr.ReadLine()
            sr.Close()
        Catch
        End Try

        sqlstr = "select * from EMail_Cust order by ID"
        dw1 = Getdata(sqlstr, ds1)
        cbEmail.DataSource = ds1.Tables(0).DefaultView
        cbEmail.DisplayMember = "E_Name"
        cbEmail.ValueMember = "E_Code"
    End Sub

    Private Sub OpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFile.Click
        OpenFileDialog.AddExtension = True
        OpenFileDialog.DefaultExt = "*.*"
        OpenFileDialog.InitialDirectory = txtFile.Text
        OpenFileDialog.ShowDialog()
        txtFile.Text = OpenFileDialog.FileName
    End Sub

    Private Sub Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Send.Click
        Dim ds1 As New DataSet
        Dim dw1 As New DataView
        Dim ds2 As New DataSet
        Dim dw2 As New DataView
        sqlstr = "select * from EMail_Cust where E_Code='" & Trim(cbEmail.SelectedValue) & "'"
        dw1 = Getdata(sqlstr, ds1)
        sqlstr = "select * from EMail_Cust where E_Code='COSTACO'"
        dw2 = Getdata(sqlstr, ds2)

        Call Sendmail(Trim(ds1.Tables(0).Rows(0).Item("E_Mail")), Trim(ds2.Tables(0).Rows(0).Item("E_Mail")))
    End Sub

    Private Sub Sendmail(ByVal Sendto As String, ByVal From As String)
        On Error GoTo Err
        Dim Mail As New MailMessage
        Dim FileName As String
        Dim Subject As String
        Dim OldMark As String '*************捣箱标志
        Dim ds1 As New DataSet
        Dim dw1 As New DataView
        Dim str As String
        Dim i As Integer = 0
        Dim j As Integer = 0
        
        If UCase(Mid(Trim(txtFile.Text), Len(Trim(txtFile.Text)) - 2, 3)) <> "TXT" Then
            
            FileName = txtFile.Text & UCase(LChina.Text) & LVoyage.Text & "TLYRST.txt"
            Subject = "(TLYRST) ShipImage ShipName: " & LEnglish.Text & " VON:" & LVoyage.Text
        
        End If
        'Add a File Attachment if specified
        If FileName <> "" Then
            Mail.Attachments.Add(New MailAttachment(FileName))
        End If
        'setup some e-mail information
        sqlstr = "select * from EMail_Cust where E_Code='" & Trim(cbEmail.SelectedValue) & "'"
        dw1 = Getdata(sqlstr, ds1)
        If dw1.Count > 0 Then i = ds1.Tables(0).Rows(0).Item("ID")
        With Mail
            .From = From
            .To = Sendto
            ds1.Reset()
            sqlstr = "select * from EMail_Cust_detail where EMail_ID=" & i
            dw1 = Getdata(sqlstr, ds1)

            If dw1.Count > 0 Then
                .Cc = dw1(j)(3)
                j = j + 1
                Do While j < dw1.Count
                    .Cc = ";" & dw1(j)(3)
                    j = j + 1
                Loop
            End If

            .Subject = Subject
            .Body = cbEmail.Text & " 你好！" & Chr(13) & Chr(10) & Subject & Chr(13) & Chr(10) & OldMark & Chr(13) & Chr(10) & " COSTACO(LYGWL)" & Chr(13) & Chr(10) & CType(Now, String)
            .Priority = MailPriority.High
        End With
        'send then e-mail message

        'SmtpMail.SmtpServer = MailServer

        SmtpMail.Send(Mail)
        MsgBox("报文已发送，谢谢使用!")
        File.Copy(FileName, BackUpFile & Mid(FileName, Len(substr(FileName)) + 1), True)
        File.Delete(FileName)
        Exit Sub
Err:
        MsgBox(Err.Description)
    End Sub

    Private Sub btRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRead.Click
        Dim PathStr As String
        Dim FilePath As String
        Dim strFile As String

        strFile = txtFile.Text & UCase(LChina.Text) & LVoyage.Text & "TLYRST.txt"

        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "NOTEPAD.EXE"
            Shell(FilePath & " " & strFile, AppWinStyle.NormalFocus, True)
        Catch
        End Try
    End Sub

    Private Sub btWriteNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btWriteNew.Click
        Dim dsTemp As New DataSet
        If Trim(cbEmail.SelectedValue).Length() > 0 Then
            If Getdata("select * from EMail_Cust where E_Code='" & Trim(cbEmail.SelectedValue) & "'", dsTemp).Count > 0 Then
                ConTypeOwner = dsTemp.Tables(0).Rows(0).Item("ConTypeOwner")
                PortOwner = dsTemp.Tables(0).Rows(0).Item("PortOwner")
            Else
                ConTypeOwner = ""
                PortOwner = ""
            End If

            Call WriteHG()

        Else
            MsgBox("请选择收文用户！否则不能生成报文。")
        End If
    End Sub

    Private Sub WriteHG()
        '******************************************海关
        Dim txtLine As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim str As String
        Dim s As String
        Dim dw As New DataView
        Dim DS_DO As New DataSet
        Dim strFile As String
        Dim strTon, strAmount, strT As String


        
        strFile = txtFile.Text & UCase(LChina.Text) & LVoyage.Text & "TLYRST.txt"

        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default())  '打开报文文件

        '**************写00行
        txtLine = "00:TLYRST:TALLY RESULT:9:LYGWL:" & Trim(cbEmail.SelectedValue) & ":" & Trim(CType(Year(Now), String))
        s = Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtLine = txtLine & s & "'"
        sw.WriteLine(txtLine)
        '************写10
        txtLine = "10:" & UCase(Trim(txtShipCode.Text)) & ":" & UCase(Trim(LEnglish.Text)) & ":" & UCase(Trim(LChina.Text)) & ":" & LVoyage.Text & ":" & Trim(LJinChu.Text) & ":'"
        sw.WriteLine(txtLine)
        '************写11
        txtLine = "11:" & dtpBeg.Value.Year.ToString().Trim()
        s = Mid("0" & Trim(CType(Month(dtpBeg.Value), String)), Len("0" & Trim(CType(Month(dtpBeg.Value), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Day(dtpBeg.Value), String)), Len("0" & Trim(CType(Day(dtpBeg.Value), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Hour(dtpBeg.Value), String)), Len("0" & Trim(CType(Hour(dtpBeg.Value), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Minute(dtpBeg.Value), String)), Len("0" & Trim(CType(Minute(dtpBeg.Value), String))) - 1, 2)
        txtLine = txtLine & s & ":" & dtpMake.Value.Year.ToString().Trim()
        s = Mid("0" & Trim(CType(Month(dtpMake.Value), String)), Len("0" & Trim(CType(Month(dtpMake.Value), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Day(dtpMake.Value), String)), Len("0" & Trim(CType(Day(dtpMake.Value), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Hour(dtpMake.Value), String)), Len("0" & Trim(CType(Hour(dtpMake.Value), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Minute(dtpMake.Value), String)), Len("0" & Trim(CType(Minute(dtpMake.Value), String))) - 1, 2)
        txtLine = txtLine & s & "::"
        txtLine = txtLine & UCase(txtTally.Text.Trim()) & ":" & UCase(txtManager.Text.Trim()) & "'"
        sw.WriteLine(txtLine)
        i = 3

       

        DS_DO.Reset()

       
        dw = Getdata("exec sp_cargo_certificate_of_sum '" & Ship_ID & "'", DS_DO)
           

        PB.Maximum = dw.Count
        PB.Value = 0
        j = 0
        If j < dw.Count Then
            PB.Value = j
            
            '************写15
            strAmount = "0"
            strTon = "0"
            If (System.Convert.ToString(DS_DO.Tables(0).Rows(j).Item("amount")).IndexOf("/") > 0) Then
                strT = System.Convert.ToString(DS_DO.Tables(0).Rows(j).Item("amount")).Trim()
                strAmount = strT.Substring(0, strT.IndexOf("/"))
                strTon = strT.Substring(strT.IndexOf("/") + 1)
                txtLine = "15:0:0:0:0:" & strAmount & ":" & strTon & ":0'"
            Else
                txtLine = "15:0:0:0:0:0:0:0'"
            End If
            'txtLine = "15:0:0:0:0:" & DS_DO.Tables(0).Rows(j).Item("amount") & ":0:0'"
            sw.WriteLine(txtLine)
            j = j + 1
            i = i + 1
            PB.Value = j
            '************写21
            strAmount = "0"
            strTon = "0"
            If (System.Convert.ToString(DS_DO.Tables(0).Rows(j).Item("amount")).IndexOf("/") > 0) Then
                strT = System.Convert.ToString(DS_DO.Tables(0).Rows(j).Item("amount")).Trim()
                strAmount = strT.Substring(0, strT.IndexOf("/"))
                strTon = strT.Substring(strT.IndexOf("/") + 1)
                txtLine = "21:0:0:0:0:" & strAmount & ":" & strTon & ":0'"
            Else
                txtLine = "21:0:0:0:0:0:0:0'"
            End If
            'txtLine = "21:0:0:0:0:" & DS_DO.Tables(0).Rows(j).Item("amount") & ":0:0'"
            sw.WriteLine(txtLine)
            j = j + 1
            i = i + 1
            PB.Value = j
            '************写22
            strAmount = "0"
            strTon = "0"
            If (System.Convert.ToString(DS_DO.Tables(0).Rows(j).Item("amount")).IndexOf("/") > 0) Then
                strT = System.Convert.ToString(DS_DO.Tables(0).Rows(j).Item("amount")).Trim()
                strAmount = strT.Substring(0, strT.IndexOf("/"))
                strTon = strT.Substring(strT.IndexOf("/") + 1)
                txtLine = "22:0:0:0:0:" & strAmount & ":" & strTon & ":0'"
            Else
                txtLine = "22:0:0:0:0:0:0:0'"
            End If
            'txtLine = "22:0:0:0:0:" & DS_DO.Tables(0).Rows(j).Item("amount") & ":0:0'"
            sw.WriteLine(txtLine)
            j = j + 1
            i = i + 1
            PB.Value = j
            '************写23
            strAmount = "0"
            strTon = "0"
            If (System.Convert.ToString(DS_DO.Tables(0).Rows(j).Item("amount")).IndexOf("/") > 0) Then
                strT = System.Convert.ToString(DS_DO.Tables(0).Rows(j).Item("amount")).Trim()
                strAmount = strT.Substring(0, strT.IndexOf("/"))
                strTon = strT.Substring(strT.IndexOf("/") + 1)
                txtLine = "22:0:0:0:0:" & strAmount & ":" & strTon & ":0'"
            Else
                txtLine = "22:0:0:0:0:0:0:0'"
            End If
            'txtLine = "23:0:0:0:0:" & DS_DO.Tables(0).Rows(j).Item("amount") & ":0:0'"
            sw.WriteLine(txtLine)
            j = j + 1
            i = i + 1
            PB.Value = j
            '************写24
            strAmount = "0"
            strTon = "0"
            If (System.Convert.ToString(DS_DO.Tables(0).Rows(j).Item("amount")).IndexOf("/") > 0) Then
                strT = System.Convert.ToString(DS_DO.Tables(0).Rows(j).Item("amount")).Trim()
                strAmount = strT.Substring(0, strT.IndexOf("/"))
                strTon = strT.Substring(strT.IndexOf("/") + 1)
                txtLine = "24:0:0:0:0:" & strAmount & ":" & strTon & ":0'"
            Else
                txtLine = "24:0:0:0:0:0:0:0'"
            End If
            'txtLine = "24:0:0:0:0:" & DS_DO.Tables(0).Rows(j).Item("amount") & ":0:0'"
            sw.WriteLine(txtLine)
            j = j + 1
            i = i + 1

        End If
            txtLine = "99:" & Trim(CType(i + 1, String)) & "'"
            sw.WriteLine(txtLine)
            sw.Close()
            MsgBox("生成完成,谢谢! 共生成 " & Trim(CType(i + 1, String)) & " 行报文")

    End Sub

    Private Sub cbEmail_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEmail.SelectedIndexChanged

    End Sub
End Class
