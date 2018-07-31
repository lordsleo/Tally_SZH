Imports System.Data.SqlClient
Public Class DBControl
    Public Shared connstr As String

    '填充DATASET,不对数据做增、删、改操作
    Public Shared Function Filldata(ByVal sqlstr As String) As DataView
        Dim sqlcmd As New SqlClient.SqlCommand()
        Dim sqlcon As New SqlClient.SqlConnection(connstr)
        Dim sqlad As New SqlClient.SqlDataAdapter()
        Dim ds As New DataSet()
        ds.Reset()
        sqlcmd.CommandTimeout = 300
        sqlcmd.CommandText = sqlstr
        sqlcmd.Connection = sqlcon
        sqlad.SelectCommand = sqlcmd
        sqlad.Fill(ds)
        Return ds.Tables(0).DefaultView

    End Function

    '获取数据,与RunUpdata配合使用可以实现对DataGrid的数据更新
    Public Shared Function Getdata(ByVal sqlstr As String, ByVal ds As DataSet) As DataView
        Dim sqlconn As New SqlClient.SqlConnection(connstr)
        Dim sqlcmd As New SqlClient.SqlCommand()
        Dim sqlad As New SqlClient.SqlDataAdapter()
        sqlcmd.CommandTimeout = 300
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandText = sqlstr
        sqlad.SelectCommand = sqlcmd
        ds.Reset()
        sqlad.Fill(ds)
        Return ds.Tables(0).DefaultView
    End Function

    Public Shared Sub ExecTextSql(ByVal bytes As Byte(), ByVal sqlstr As String)
        Dim sqlcmd As New SqlClient.SqlCommand(sqlstr, sqlconn)
        'Dim sqlcmd As New SqlClient.SqlCommand(sqlstr, sqlconn)
        sqlcmd.CommandTimeout = 300
        sqlcmd.CommandType = CommandType.Text
        Try
            sqlconn.Open()
            sqlcmd.CommandText = sqlstr
            Dim spFile As New SqlParameter("@file", SqlDbType.Image)
            spFile.Value = bytes
            sqlcmd.Parameters.Add(spFile)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        sqlconn.Close()
    End Sub

    '与GetData配合使用可以实现对DataGrid的数据更新
    Public Shared Function RunUpdata(ByVal sqlstr As String, ByVal ds As DataSet)
        Dim sqlconn As New SqlClient.SqlConnection(connstr)
        Dim sqlcmd As New SqlClient.SqlCommand()
        Dim sqlad As New SqlClient.SqlDataAdapter()
        sqlcmd.CommandTimeout = 300
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandText = sqlstr
        sqlad.SelectCommand = sqlcmd
        Dim sqlcmdbuild As New SqlClient.SqlCommandBuilder(sqlad)
        sqlcmdbuild.RefreshSchema()
        sqlad.Fill(ds)
        sqlad.Update(ds)
    End Function

    '使用DATATABLE,主要用于单记录
    Public Shared Function Updatedata(ByVal sqlad As SqlClient.SqlDataAdapter, ByVal sqlstr As String, ByVal ds As DataSet) As DataView
        Dim sqlconn As New SqlClient.SqlConnection(connstr)
        Dim sqlcmd As New SqlClient.SqlCommand()
        ds.Reset()
        sqlcmd.CommandTimeout = 300
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandText = sqlstr
        sqlad.SelectCommand = sqlcmd
        Dim sqlcmdbuild As New SqlClient.SqlCommandBuilder(sqlad)
        sqlcmdbuild.RefreshSchema()
        sqlad.Fill(ds)
        Return ds.Tables(0).DefaultView
    End Function


    '执行SQL语句，也可执行存储过程
    Public Shared Sub ExecSql(ByVal sqlstr As String)
        Dim sqlconn As New SqlClient.SqlConnection(connstr)
        Dim sqlcmd As New SqlClient.SqlCommand(sqlstr, sqlconn)
        sqlconn.Open()
        sqlcmd.CommandTimeout = 300
        sqlcmd.ExecuteNonQuery()
        sqlconn.Close()
    End Sub

    '执行SQL语句，也可执行存储过程conn_ver
    Public Shared Sub ExecSql_ver(ByVal sqlstr As String)
        Dim sqlconn As New SqlClient.SqlConnection(conn_ver)
        Dim sqlcmd As New SqlClient.SqlCommand(sqlstr, sqlconn)
        sqlconn.Open()
        sqlcmd.CommandTimeout = 300
        sqlcmd.ExecuteNonQuery()
        sqlconn.Close()
    End Sub

    '字符串中字母  转换为大写
    Public Shared Function Upper(ByVal str As String) As String
        Dim i As Integer
        Dim s As String
        Dim t As String
        t = ""
        For i = 1 To Len(str)
            s = Mid(str, i, 1)
            If (Asc(s) >= Asc("a") And Asc(s) <= Asc("z")) Then
                t = t & Strings.UCase(s)
            Else
                t = t & s
            End If
        Next
        Upper = t
    End Function

    '取出当前文件的路径
    Public Shared Function substr(ByVal str As String) As String
        Dim i As Integer
        Dim s As String
        s = str
        Do While Right(s, 1) <> "\"
            s = Mid(s, 1, Len(s) - 1)
        Loop
        substr = s
    End Function

    '查找点数
    Public Shared Function FindDotInStr(ByVal FInputStr As String) As Integer
        Dim BeginPos, CurrentPos As Integer
        Dim InputStr As String
        Dim SearchStr As String
        Dim DotNum As Integer  '计数"."字符个数

        SearchStr = "."
        InputStr = FInputStr
        BeginPos = 1
        DotNum = 0
        Do While True
            CurrentPos = InStr(BeginPos, InputStr, SearchStr)
            '碰到一个"."字符,DotNum加一,直到无"."字符退出
            If CurrentPos > 0 Then
                BeginPos = CurrentPos + 1
                DotNum = DotNum + 1
            Else
                Exit Do
            End If
        Loop
        FindDotInStr = DotNum
    End Function

    '操作日志
    Public Shared Sub OperateHistory(ByVal Dept_Name As String, ByVal OperateTime As String, ByVal OperateWorker As String, ByVal OperateType As String, ByVal OperateTable As String, ByVal ID As String, ByVal IDCol As String)
        On Error GoTo Err
        Dim strsql As String
        Dim demo As String
        Dim col As Integer
        Dim ds As New DataSet()
        If Getdata("select * from " & OperateTable & " where " & IDCol & " =" & ID, ds).Count > 0 Then
            demo = ""
            For col = 0 To ds.Tables(0).Columns.Count - 1
                demo = demo + IIf(IsDBNull(ds.Tables(0).Rows(0)(col)), "", CType(ds.Tables(0).Rows(0)(col), String)) + ","
            Next
            strsql = "insert into OperateHistory (Dept_Name,OperateTime,OperateWorker,OperateType,OperateDemo,OperateTable) values('" & Dept_Name & "','" & OperateTime & "','" & OperateWorker & "','" & OperateType & "','" & demo & "','" & OperateTable & "') "
        End If
        ExecSql(strsql)
Err:
        demo = demo + ","
        Resume Next
    End Sub


    Public Shared Function MakeBigWord(ByVal Digital_Num As Double) As String
        Dim base_number As Integer
        Dim old_number As Integer
        Dim int_number As Integer
        Dim float_number As Single
        Dim input_number As Double
        Dim unit_money(4) As String
        Dim big_write(10) As String
        Dim float_write(2) As Integer
        Dim digital_word(8) As Integer
        Dim money_int As String
        Dim money_float As String
        Dim digital As Integer
        Dim wei As Integer
        Dim mark_zero As Integer
        Dim sumno As Integer
        Dim not_zero_wei As Integer
        Dim ii As Integer

        input_number = Digital_Num

        If input_number > 99999999.99 Then    '本函数只能转换一亿元以下的数字
            MsgBox("转换为大写金额的数字太大，不能完成！")
            Return ""
            Exit Function
        End If
        unit_money(0) = ""         '暂无用
        unit_money(1) = "拾"         '暂无用
        unit_money(2) = "佰"         '暂无用
        unit_money(3) = "仟"         '暂无用

        big_write(0) = "零"         '数字转换成的大写
        big_write(1) = "壹"
        big_write(2) = "贰"
        big_write(3) = "叁"
        big_write(4) = "肆"
        big_write(5) = "伍"
        big_write(6) = "陆"
        big_write(7) = "柒"
        big_write(8) = "捌"
        big_write(9) = "玖"

        int_number = Fix(input_number)   '取整数部分

        float_number = Math.Round(input_number - int_number, 2)   '取小数部分

        base_number = 10000000
        wei = 7
        Do While base_number >= 1                        '最多取7位数字
            digital = Fix(int_number / base_number)
            If digital > 0 Then
                int_number = int_number - digital * base_number
                digital_word(wei) = digital
            Else
                digital_word(wei) = 0
            End If

            base_number = Fix(base_number / 10)
            wei = wei - 1
        Loop
        money_float = ""
        float_write(0) = Fix(Math.Round(float_number * 10, 2))        '取两位小数
        float_write(1) = Fix(Math.Round(float_number * 100 - float_write(0) * 10, 2))

        If float_number > 0 Then       '先转换小数部分
            If float_write(0) > 0 Then
                money_float = big_write(float_write(0)) + "角"
            Else
                money_float = "零"
            End If
            If float_write(1) > 0 Then
                money_float = money_float + big_write(float_write(1)) + "分"
            End If
            money_float = money_float + "整"
        Else
            money_float = money_float + "整"
        End If

        mark_zero = 0
        money_int = "元"                   '转换整数部分,从个位数开始
        If digital_word(0) > 0 Then
            money_int = big_write(digital_word(0)) + money_int
            mark_zero = 0
        Else
            mark_zero = 1
        End If
        If digital_word(1) > 0 Then
            money_int = big_write(digital_word(1)) + "拾" + money_int
            mark_zero = 0
        Else
            If mark_zero = 0 Then
                money_int = "零" + money_int
                mark_zero = 1
            End If
        End If

        If digital_word(2) > 0 Then
            money_int = big_write(digital_word(2)) + "佰" + money_int
            mark_zero = 0
        Else
            If mark_zero = 0 Then
                money_int = "零" + money_int
                mark_zero = 1
            End If
        End If

        If digital_word(3) > 0 Then
            money_int = big_write(digital_word(3)) + "仟" + money_int
            mark_zero = 0
        Else
            If mark_zero = 0 Then
                money_int = "零" + money_int
                mark_zero = 1
            End If
        End If


        If input_number > 10000 Then     '在万位加上万字
            money_int = "万" + money_int
        End If
        If input_number > 10000 Then
            mark_zero = 0
            If digital_word(4) > 0 Then
                money_int = big_write(digital_word(4)) + money_int
                mark_zero = 0
            Else
                mark_zero = 1
            End If
            If digital_word(5) > 0 Then
                money_int = big_write(digital_word(5)) + "拾" + money_int
                mark_zero = 0
            Else
                If mark_zero = 0 Then
                    mark_zero = 1
                    money_int = "零" + money_int
                End If
            End If
            If digital_word(6) > 0 Then
                money_int = big_write(digital_word(6)) + "佰" + money_int
                mark_zero = 0
            Else
                If mark_zero = 0 Then
                    mark_zero = 1
                    money_int = "零" + money_int
                End If
            End If

            If digital_word(7) > 0 Then
                money_int = big_write(digital_word(7)) + "仟" + money_int
                mark_zero = 0
            End If

        End If

        If Mid(Trim(money_int + money_float), 1, 1) = "零" Then
            Return Mid(Trim(money_int + money_float), 2, Len(money_int + money_float) - 1)
        Else
            Return Trim(money_int + money_float)
        End If


    End Function
    Public Shared Sub KillExcelProcess()   '清除EXCEL进程
        Dim p As System.Diagnostics.Process
        Dim i As Int16
        Dim ExistsExcel As Int16
        For Each p In System.Diagnostics.Process.GetProcesses()
            If p.ProcessName.ToUpper() = "EXCEL" Then
                ExistsExcel = 0
                For i = 0 To 9
                    If p.Id = ProcessIDs(i) Then
                        ExistsExcel = ExistsExcel + 1
                    End If
                Next
                If ExistsExcel = 0 Then
                    p.Kill()
                End If
            End If
        Next
    End Sub
    Public Shared Sub RecordExcelProcess()    '记录EXCEL进程
        Dim p As System.Diagnostics.Process
        Dim i As Int16
        i = 0
        For Each p In System.Diagnostics.Process.GetProcesses()
            If i < 10 Then
                If p.ProcessName.ToUpper() = "EXCEL" Then
                    ProcessIDs(i) = p.Id
                    i = i + 1
                End If
            End If
        Next
    End Sub

    Public Shared Sub KillTotalExcelProcess() '清除所有EXCEL进程
        Dim p As System.Diagnostics.Process
        For Each p In System.Diagnostics.Process.GetProcesses()
            If p.ProcessName.ToUpper() = "EXCEL" Then
                p.Kill()
            End If
        Next
    End Sub
    Public Shared Sub SetDGCombox(ByVal C1DG As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal strColName As String, ByVal sqlData As String, Optional ByVal blTranslate As Boolean = True, Optional ByVal iMaxItems As Integer = 15)
        Dim i As Integer
        Dim vi As C1.Win.C1TrueDBGrid.ValueItem
        C1DG.Columns(strColName).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
        C1DG.Columns(strColName).ValueItems.Translate = blTranslate
        C1DG.Columns(strColName).ValueItems.MaxComboItems = iMaxItems
        Dim dvData As DataView = Filldata(sqlData)
        For i = 0 To dvData.Count - 1
            vi = New C1.Win.C1TrueDBGrid.ValueItem
            If blTranslate Then
                If Not IsDBNull(dvData(i)(0)) AndAlso Not IsDBNull(dvData(i)(1)) Then
                    vi.DisplayValue = dvData(i)(1)
                    vi.Value = dvData(i)(0)
                    C1DG.Columns(strColName).ValueItems.Values.Add(vi)
                End If
            Else
                If Not IsDBNull(dvData(i)(0)) Then
                    vi.Value = dvData(i)(0)
                    C1DG.Columns(strColName).ValueItems.Values.Add(vi)
                End If
            End If
        Next
    End Sub

    '设置C1的列宽
    Public Shared Sub SetDGWidth(ByVal C1DG As C1.Win.C1TrueDBGrid.C1TrueDBGrid, Optional ByVal iVarSize As Integer = 5)
        Try '合适的
            Dim j As Integer
            For j = 0 To C1DG.Columns.Count - 1
                C1DG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                C1DG.Splits(0).DisplayColumns.Item(j).AutoSize()
                If C1DG.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                    C1DG.Splits(0).DisplayColumns.Item(j).Width = 40 + iVarSize
                ElseIf C1DG.Splits(0).DisplayColumns.Item(j).Width < 80 Then
                    C1DG.Splits(0).DisplayColumns.Item(j).Width += iVarSize
                ElseIf C1DG.Splits(0).DisplayColumns.Item(j).Width < 110 Then
                    C1DG.Splits(0).DisplayColumns.Item(j).Width += iVarSize / 2
                Else
                    C1DG.Splits(0).DisplayColumns.Item(j).Width = 110
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Sub SetDGWidth2(ByVal C1DG As C1.Win.C1TrueDBGrid.C1TrueDBGrid, Optional ByVal iVarSize As Integer = 0)
        Try '紧凑的
            Dim j As Integer
            For j = 0 To C1DG.Columns.Count - 1
                C1DG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                C1DG.Splits(0).DisplayColumns.Item(j).AutoSize()
                If C1DG.Splits(0).DisplayColumns.Item(j).Width < 70 Then
                    C1DG.Splits(0).DisplayColumns.Item(j).Width += iVarSize
                ElseIf C1DG.Splits(0).DisplayColumns.Item(j).Width > 100 Then
                    C1DG.Splits(0).DisplayColumns.Item(j).Width = 100
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'dv的列数值合计
    Public Shared Function GetDataSum(ByVal dvData As DataView, ByVal strColName As String) As Decimal
        Dim i As Integer
        Dim fTotal As Decimal
        For i = 0 To dvData.Count - 1
            If Convert.IsDBNull(dvData(i)(strColName)) = False Then
                fTotal += dvData(i)(strColName)
            End If
        Next
        Return fTotal
    End Function
    Public Shared Function GetDataSum(ByVal dvData As DataView, ByVal strColIndex As Integer) As Decimal
        Dim i As Integer
        Dim fTotal As Decimal
        For i = 0 To dvData.Count - 1
            If Convert.IsDBNull(dvData(i)(strColIndex)) = False Then
                fTotal += dvData(i)(strColIndex)
            End If
        Next
        Return fTotal
    End Function

    '判断C1单元格是否有空
    Public Shared Function ColHasEmpty(ByVal C1One As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal dvOne As DataView, ByVal strColName As String, Optional ByVal blMsg As Boolean = True) As Boolean
        Dim i As Integer
        For i = 0 To dvOne.Count - 1
            C1One.Row = i
            If C1One.Columns(strColName).Text.Length = 0 Then
                Exit For
            End If
        Next
        If i < dvOne.Count Then
            If blMsg Then
                C1One.Focus()
                MessageBox.Show("该行" & C1One.Columns(strColName).Caption & "不可为空", "提示")
            End If
            Return True
        Else
            Return False
        End If
    End Function

    '判断单列是否重复
    Public Shared Function ColHasRepeat(ByVal C1One As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal dvOne As DataView, ByVal strColName As String, Optional ByVal blMsg As Boolean = True) As Boolean
        Dim i, j As Integer
        For i = 0 To dvOne.Count - 1
            C1One.Row = i
            For j = i + 1 To dvOne.Count - 1
                If C1One.Columns(strColName).Text = C1One.Columns(strColName).CellText(j) Then
                    Exit For
                End If
            Next
            If j < dvOne.Count Then
                Exit For
            End If
        Next
        If i < dvOne.Count Then
            If blMsg Then
                C1One.Focus()
                C1One.SelectedRows.Clear()
                C1One.SelectedRows.Add(i)
                C1One.SelectedRows.Add(j)
                MessageBox.Show("第" & (i + 1) & "第" & (j + 1) & "行" & C1One.Columns(strColName).Caption & "重复", "提示")
            End If
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Sub SetDGWidth3(ByVal C1DG As C1.Win.C1TrueDBGrid.C1TrueDBGrid, Optional ByVal iScale As Decimal = 0.1)
        Try '按比例设定 普遍适用
            Dim i As Integer
            For i = 0 To C1DG.Columns.Count - 1
                C1DG.Splits(0).DisplayColumns.Item(i).AutoSize()
                If C1DG.Splits(0).DisplayColumns(i).Width * iScale <= 2 Then
                    C1DG.Splits(0).DisplayColumns(i).Width += 2
                Else
                    C1DG.Splits(0).DisplayColumns(i).Width += Convert.ToInt32(C1DG.Splits(0).DisplayColumns(i).Width * iScale)
                End If
                If C1DG.Splits(0).DisplayColumns(i).Width > 110 Then
                    C1DG.Splits(0).DisplayColumns(i).Width = 110
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '港口,货物,包装的代码增,删,改
    Public Shared Sub CodeOperation(ByVal tableName As String, ByVal sqltxt As String)
        Try
            Dim i As Integer
            Dim ds As New DataSet
            Getdata("select client_hdinfo from szh_client where client_mark=1 ", ds)
            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    ExecSql("insert into szh_client_updateinfo(update_table_info,client_hdinfo,update_text,operate_date)values('" & tableName & "','" & ds.Tables(0).Rows(i)(0) & "','" & sqltxt & "','" & Now().ToString() & "')")
                Next
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
