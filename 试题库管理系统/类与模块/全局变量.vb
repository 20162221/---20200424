Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Module 全局变量
    Public sql As SqlConnection
    Public cmd As SqlCommand
    Public rnd As New Random
    Public 当前登录账号 As String
    Public Function sqlinit()
        sql = New SqlConnection($"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\试题库管理系统.mdf;Integrated Security=True;MultipleActiveResultSets=true")
        sql.Open()
        cmd = New SqlCommand
        cmd.Connection = sql
    End Function
    Public Sub 刷新全部数据(listviewtemp As ListView)
        listviewtemp.BeginUpdate()
        listviewtemp.Items.Clear()
        cmd.CommandText = "select * from tk order by id"
        Dim ret = cmd.ExecuteReader
        Dim colorbit
        Dim COLORS = Color.FromArgb(rnd.Next(200, 255), rnd.Next(200, 255), rnd.Next(200, 255))
        While ret.Read
            If colorbit <> ret(1).ToString Then
                COLORS = Color.FromArgb(rnd.Next(200, 255), rnd.Next(200, 255), rnd.Next(200, 255))
            End If
            Dim t As New ListViewItem(ret(0).ToString)
            For i = 1 To ret.FieldCount - 1
                t.SubItems.Add(ret(i).ToString)
            Next
            t.BackColor = COLORS
            listviewtemp.Items.Add(t)
            colorbit = ret(1)
        End While
        ret.Close()
        listviewtemp.EndUpdate()
    End Sub
    Public Function 读取图片(id) As Image
        If IsDBNull(id) OrElse id = "" Then
            Return Nothing
        End If
        Dim cmds As New SqlCommand($"select img from 图片表 where id='{id}'", sql)
        Dim dr = cmds.ExecuteReader
        If dr.Read = False Then
            dr.Close()
            Return Nothing
        End If
        Dim imagebytes As Byte() = dr.GetValue(0)
        dr.Close()
        cmds.Dispose()
        Dim MS As MemoryStream = New MemoryStream(imagebytes)
        Return New Bitmap(MS)
    End Function
    Public Function 上传图片(bmp As Image) As String
        Try
            Dim id = Guid.NewGuid.ToString
            Dim t = New SqlCommand($"insert into 图片表 values(N'{id}',@ImageList)", sql)
            t.Parameters.Add("ImageList", SqlDbType.Image)
            Dim ms As MemoryStream = New MemoryStream()
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            t.Parameters("ImageList").Value = ms.GetBuffer
            t.ExecuteNonQuery()
            ms.Close()
            Return id
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function listviewitem转html(I As ListViewItem) As String
        Dim strs As New StringBuilder
        strs.Append(" " & I.SubItems(1).Text)
        strs.Append(" 来源(" & I.SubItems(2).Text & ")")
        strs.Append(" 难度" & I.SubItems(3).Text)
        strs.Append(" 考点:" & I.SubItems(4).Text & "")
        strs.Append(" 分数:" & I.SubItems(5).Text & "分")
        strs.Append("<br>")
        strs.Append(I.SubItems(6).Text)
        strs.Append("<br>")
        If I.SubItems(1).Text = "选择题" Then
            Dim arr = Split(I.SubItems(7).Text, ";")
            Dim str = ""
            For n = 0 To arr.Count - 1
                str += "<br>" & Chr(65 + n) & ": " & arr(n) & "   "
            Next
            strs.Append(str)
            strs.Append("<br>")
        End If
        If I.SubItems(1).Text = "判断题" Then
            strs.Append("对(  )      错(  )")
        End If
        Return strs.ToString
    End Function
    Public Function 转为html代码(s As String)
        Dim t = Replace(s, "<img ", $"<img src=""{Application.StartupPath}\图片\")
        t = Strings.Replace(t, "<br>", "$%^&*(")
        t = Strings.Replace(t, ">", """>")
        t = Strings.Replace(t, "$%^&*(", "<br>")
        Return t
    End Function
End Module
