Imports TALLY.DBControl
Public Class FrmSealInspect_Query
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
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

    '注意：以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbSealState As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtContainer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNO As System.Windows.Forms.TextBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents txtCabin As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSealDate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtKillReason As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkPlace As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTimeBegin As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTimeEnd As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtOriginalSeal As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtOgSealState As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDept As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSealType As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbSealState = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSealNO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtContainer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVoyage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtShip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtCabin = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSealDate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPerson = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKillReason = New System.Windows.Forms.TextBox()
        Me.txtWorkPlace = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTimeBegin = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTimeEnd = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOriginalSeal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtOgSealState = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDept = New System.Windows.Forms.TextBox()
        Me.txtWorkName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSealType = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Location = New System.Drawing.Point(182, 300)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(65, 24)
        Me.btnQuit.TabIndex = 18
        Me.btnQuit.Text = "返回"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(214, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 227
        Me.Label7.Text = "部门"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSealState
        '
        Me.cbSealState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSealState.Items.AddRange(New Object() {"在库", "出库", "在用", "注销"})
        Me.cbSealState.Location = New System.Drawing.Point(288, 30)
        Me.cbSealState.Name = "cbSealState"
        Me.cbSealState.Size = New System.Drawing.Size(130, 20)
        Me.cbSealState.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(214, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 225
        Me.Label6.Text = "铅封状态"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSealNO
        '
        Me.txtSealNO.Location = New System.Drawing.Point(288, 6)
        Me.txtSealNO.MaxLength = 20
        Me.txtSealNO.Name = "txtSealNO"
        Me.txtSealNO.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNO.TabIndex = 10
        Me.txtSealNO.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(214, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 221
        Me.Label5.Text = "铅封号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContainer
        '
        Me.txtContainer.Location = New System.Drawing.Point(78, 78)
        Me.txtContainer.MaxLength = 11
        Me.txtContainer.Name = "txtContainer"
        Me.txtContainer.Size = New System.Drawing.Size(130, 21)
        Me.txtContainer.TabIndex = 3
        Me.txtContainer.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 219
        Me.Label3.Text = "集装箱号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(78, 30)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 1
        Me.txtVoyage.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 217
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(78, 6)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 0
        Me.txtShip.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 215
        Me.Label2.Text = "中文船名"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 214
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtCabin
        '
        Me.txtCabin.Location = New System.Drawing.Point(78, 54)
        Me.txtCabin.MaxLength = 10
        Me.txtCabin.Name = "txtCabin"
        Me.txtCabin.Size = New System.Drawing.Size(130, 21)
        Me.txtCabin.TabIndex = 2
        Me.txtCabin.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(4, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 230
        Me.Label8.Text = "舱别"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSealDate
        '
        Me.txtSealDate.Location = New System.Drawing.Point(288, 54)
        Me.txtSealDate.MaxLength = 20
        Me.txtSealDate.Name = "txtSealDate"
        Me.txtSealDate.Size = New System.Drawing.Size(130, 21)
        Me.txtSealDate.TabIndex = 12
        Me.txtSealDate.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(214, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 232
        Me.Label9.Text = "日期"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPerson
        '
        Me.txtPerson.Location = New System.Drawing.Point(288, 126)
        Me.txtPerson.MaxLength = 10
        Me.txtPerson.Name = "txtPerson"
        Me.txtPerson.Size = New System.Drawing.Size(130, 21)
        Me.txtPerson.TabIndex = 15
        Me.txtPerson.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(214, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 234
        Me.Label10.Text = "责任人"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKillReason
        '
        Me.txtKillReason.Location = New System.Drawing.Point(218, 172)
        Me.txtKillReason.MaxLength = 30
        Me.txtKillReason.Multiline = True
        Me.txtKillReason.Name = "txtKillReason"
        Me.txtKillReason.Size = New System.Drawing.Size(200, 48)
        Me.txtKillReason.TabIndex = 16
        Me.txtKillReason.Text = ""
        '
        'txtWorkPlace
        '
        Me.txtWorkPlace.Location = New System.Drawing.Point(78, 102)
        Me.txtWorkPlace.MaxLength = 50
        Me.txtWorkPlace.Name = "txtWorkPlace"
        Me.txtWorkPlace.Size = New System.Drawing.Size(130, 21)
        Me.txtWorkPlace.TabIndex = 4
        Me.txtWorkPlace.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(4, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 238
        Me.Label12.Text = "工作地点"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTimeBegin
        '
        Me.txtTimeBegin.Location = New System.Drawing.Point(78, 150)
        Me.txtTimeBegin.MaxLength = 20
        Me.txtTimeBegin.Name = "txtTimeBegin"
        Me.txtTimeBegin.Size = New System.Drawing.Size(130, 21)
        Me.txtTimeBegin.TabIndex = 6
        Me.txtTimeBegin.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(4, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 18)
        Me.Label13.TabIndex = 240
        Me.Label13.Text = "开始时间"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTimeEnd
        '
        Me.txtTimeEnd.Location = New System.Drawing.Point(78, 174)
        Me.txtTimeEnd.MaxLength = 20
        Me.txtTimeEnd.Name = "txtTimeEnd"
        Me.txtTimeEnd.Size = New System.Drawing.Size(130, 21)
        Me.txtTimeEnd.TabIndex = 7
        Me.txtTimeEnd.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(4, 176)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 242
        Me.Label14.Text = "结束时间"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOriginalSeal
        '
        Me.txtOriginalSeal.Location = New System.Drawing.Point(78, 198)
        Me.txtOriginalSeal.MaxLength = 20
        Me.txtOriginalSeal.Name = "txtOriginalSeal"
        Me.txtOriginalSeal.Size = New System.Drawing.Size(130, 21)
        Me.txtOriginalSeal.TabIndex = 8
        Me.txtOriginalSeal.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(4, 200)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 244
        Me.Label15.Text = "原铅封号"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOgSealState
        '
        Me.txtOgSealState.Location = New System.Drawing.Point(8, 244)
        Me.txtOgSealState.MaxLength = 100
        Me.txtOgSealState.Multiline = True
        Me.txtOgSealState.Name = "txtOgSealState"
        Me.txtOgSealState.Size = New System.Drawing.Size(200, 48)
        Me.txtOgSealState.TabIndex = 9
        Me.txtOgSealState.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(4, 224)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 246
        Me.Label16.Text = "原铅封情况"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(218, 246)
        Me.txtRemark.MaxLength = 100
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(200, 48)
        Me.txtRemark.TabIndex = 17
        Me.txtRemark.Text = ""
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(214, 226)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 248
        Me.Label17.Text = "备注"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(288, 102)
        Me.txtDept.MaxLength = 12
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(130, 21)
        Me.txtDept.TabIndex = 14
        Me.txtDept.Text = ""
        '
        'txtWorkName
        '
        Me.txtWorkName.Location = New System.Drawing.Point(78, 126)
        Me.txtWorkName.MaxLength = 4
        Me.txtWorkName.Name = "txtWorkName"
        Me.txtWorkName.Size = New System.Drawing.Size(130, 21)
        Me.txtWorkName.TabIndex = 5
        Me.txtWorkName.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 251
        Me.Label4.Text = "工作类型"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSealType
        '
        Me.txtSealType.Location = New System.Drawing.Point(288, 78)
        Me.txtSealType.MaxLength = 10
        Me.txtSealType.Name = "txtSealType"
        Me.txtSealType.Size = New System.Drawing.Size(130, 21)
        Me.txtSealType.TabIndex = 13
        Me.txtSealType.Text = ""
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(214, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 253
        Me.Label18.Text = "铅封类型"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(214, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 236
        Me.Label11.Text = "注销原因"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmSealInspect_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(424, 327)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtSealType, Me.Label18, Me.txtWorkName, Me.Label4, Me.txtDept, Me.txtRemark, Me.Label17, Me.txtOgSealState, Me.Label16, Me.txtOriginalSeal, Me.Label15, Me.txtTimeEnd, Me.Label14, Me.txtTimeBegin, Me.Label13, Me.txtWorkPlace, Me.Label12, Me.txtKillReason, Me.Label11, Me.txtPerson, Me.Label10, Me.txtSealDate, Me.Label9, Me.txtCabin, Me.Label8, Me.btnQuit, Me.Label7, Me.cbSealState, Me.Label6, Me.txtSealNO, Me.Label5, Me.txtContainer, Me.Label3, Me.txtVoyage, Me.Label1, Me.txtShip, Me.Label2, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSealInspect_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "铅封查询信息 查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()

    Private Sub FrmSealInspect_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String

        sqlstr = "select * from View_SEALRECORD where ID=" & ID & ""
        dw = Getdata(sqlstr, ds)
        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtShip.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            txtVoyage.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
            txtCabin.Text = ds.Tables(0).Rows(0).Item("HATCH_NO")
            txtContainer.Text = ds.Tables(0).Rows(0).Item("CONTAINER_NO")
            txtWorkPlace.Text = ds.Tables(0).Rows(0).Item("WORK_PLACE")
            txtWorkName.Text = ds.Tables(0).Rows(0).Item("WorkType_Name")
            txtTimeBegin.Text = ds.Tables(0).Rows(0).Item("TIME_FROM")
            txtTimeEnd.Text = ds.Tables(0).Rows(0).Item("TIME_TO")
            txtOriginalSeal.Text = ds.Tables(0).Rows(0).Item("ORIGINESEALNO")
            txtOgSealState.Text = ds.Tables(0).Rows(0).Item("ORIGINESEALNO_CONDITION")

            txtSealNO.Text = ds.Tables(0).Rows(0).Item("SEALNO")
            cbSealState.SelectedIndex = ds.Tables(0).Rows(0).Item("SEAL_STATE") - 1
            txtSealDate.Text = ds.Tables(0).Rows(0).Item("SEALDATE")
            txtSealType.Text = ds.Tables(0).Rows(0).Item("SealType_Name")
            txtDept.Text = ds.Tables(0).Rows(0).Item("DEPT_Name")
            txtPerson.Text = ds.Tables(0).Rows(0).Item("USER_PERSON")
            txtKillReason.Text = ds.Tables(0).Rows(0).Item("LOGOFF_REASON")
            txtRemark.Text = ds.Tables(0).Rows(0).Item("REMARK")
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
