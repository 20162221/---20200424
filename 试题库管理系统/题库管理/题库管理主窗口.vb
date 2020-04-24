Public Class 题库管理主窗口
    Private Sub 刷新ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 刷新ToolStripMenuItem.Click
        刷新全部数据(ListView1)
        MsgBox($"刷新完成，一共有{ListView1.Items.Count}条数据")
    End Sub

    Private Sub 添加文件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 添加文件ToolStripMenuItem.Click
        Dim t As New 添加文件
        t.Show()
        Me.Hide()
    End Sub

    Private Sub 添加单题ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 添加单题ToolStripMenuItem.Click
        Dim t As New 添加单题
        t.ShowDialog()
    End Sub

    Private Sub 查询题目ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查询题目ToolStripMenuItem.Click
        Dim p As New 查询(ListView1)
        p.ShowDialog()
    End Sub

    Private Sub 返回主界面ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 返回主界面ToolStripMenuItem.Click
        Me.Hide()
        开始界面.Show()
        开始界面.刷新显示文字(IO.File.ReadAllText("001.txt"))
    End Sub
    Private Sub 题库管理主窗口_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        刷新全部数据(ListView1)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count = 0 Then
            Return
        End If
        Dim strs = listviewitem转html(ListView1.SelectedItems(0))
        WebBrowser1.DocumentText = 转为html代码(strs.ToString)
        WebBrowser2.DocumentText = 转为html代码("正确答案: " & ListView1.SelectedItems(0).SubItems(8).Text)
    End Sub

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        Dim columnsort As New ColumnSort(e.Column)
        columnsort.bAscending = (ListView1.Sorting = SortOrder.Ascending)
        If columnsort.bAscending Then
            ListView1.Sorting = SortOrder.Descending
        Else
            ListView1.Sorting = SortOrder.Ascending
        End If
        ListView1.ListViewItemSorter = columnsort
        ListView1.ListViewItemSorter = Nothing
    End Sub

    Private Sub 删除左边勾选的ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除左边勾选的ToolStripMenuItem.Click
        Try
            For Each i As ListViewItem In ListView1.Items
                If i.Checked = True Then
                    Dim id = i.SubItems(0).Text
                    cmd.CommandText = $"delete tk where Id={id}"
                    If cmd.ExecuteNonQuery = 1 Then
                        i.Remove()
                    End If
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub 删除数据库全部ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除数据库全部ToolStripMenuItem.Click
        Try
            cmd.CommandText = $"DBCC CHECKIDENT ('tk',RESEED,0);delete tk;"
            cmd.ExecuteNonQuery()
            刷新全部数据(ListView1)
            MsgBox($"删除成功")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub 修改题目ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改题目类型ToolStripMenuItem.Click, 修改题目来源ToolStripMenuItem.Click, 修改考点ToolStripMenuItem.Click, 修改题目正确答案ToolStripMenuItem.Click, 修改题目ToolStripMenuItem1.Click, 修改难度等级ToolStripMenuItem.Click, 修改分值ToolStripMenuItem.Click
        Dim 字段 = Strings.Replace(sender.text, "修改", "")
        Try
            Dim id = ListView1.SelectedItems(0).SubItems(0).Text
            cmd.CommandText = $"select {字段}  from tk where Id={id}"
            Dim value = cmd.ExecuteScalar
            Dim ret = InputBox($"输入需要修改的值，原来值是{vbCrLf}{value}"， $"修改{字段}", value)
            If ret = "" Then
                MsgBox("取消修改")
            Else
                cmd.CommandText = $"UPDATE tk SET {字段} = N'{ret}' WHERE Id={id}"
                If cmd.ExecuteNonQuery() Then
                    For n = 0 To ListView1.SelectedItems(0).SubItems.Count - 1
                        If ListView1.Columns(n).Text = 字段 Then
                            ListView1.SelectedItems(0).SubItems(n).Text = ret
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox("没有选择数据，无法修改")
        End Try
    End Sub
End Class