Imports System.IO
Imports NPOI.XWPF.Usermodel

Public Class 出卷主窗口
    Private Sub 出卷主窗口_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        刷新全部数据(ListView1)
        ListView1.CheckBoxes = True
    End Sub

    Private Sub 返回主界面ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 返回主界面ToolStripMenuItem.Click
        Me.Hide()
        开始界面.Show()
        开始界面.刷新显示文字(IO.File.ReadAllText("001.txt"))
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

    Private Sub ListView2_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView2.ColumnClick
        Dim columnsort As New ColumnSort(e.Column)
        columnsort.bAscending = (ListView2.Sorting = SortOrder.Ascending)
        If columnsort.bAscending Then
            ListView2.Sorting = SortOrder.Descending
        Else
            ListView2.Sorting = SortOrder.Ascending
        End If
        ListView2.ListViewItemSorter = columnsort
        ListView2.ListViewItemSorter = Nothing
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count = 0 Then
            Return
        End If
        Dim strs = listviewitem转html(ListView1.SelectedItems(0))
        WebBrowser1.DocumentText = 转为html代码(strs.ToString)
        WebBrowser2.DocumentText = 转为html代码("正确答案: " & ListView1.SelectedItems(0).SubItems(8).Text)
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count = 0 Then
            Return
        End If
        Dim strs = listviewitem转html(ListView2.SelectedItems(0))
        WebBrowser3.DocumentText = 转为html代码(strs.ToString)
        WebBrowser4.DocumentText = 转为html代码("正确答案: " & ListView2.SelectedItems(0).SubItems(8).Text)
    End Sub

    Private Sub 出卷主窗口_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        开始界面.Show()
        开始界面.刷新显示文字(IO.File.ReadAllText("主界面右边显示的文字.txt"))
    End Sub

    Private Sub 智能组卷ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 智能组卷ToolStripMenuItem.Click
        刷新全部数据(ListView1)
        ListView2.Items.Clear()
        Dim t As New 智能组卷(ListView1, ListView2)
        t.ShowDialog()
    End Sub
    Public Function 获得分数和() As Integer
        Dim p = 0
        For Each i As ListViewItem In ListView2.Items
            p += Int(i.SubItems(5).Text)
        Next
        Return p
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim P = 0
            For Each i As ListViewItem In ListView2.Items
                P += Int(i.SubItems(5).Text)
            Next
            Label23.Text = "当前分数和：" & P
        Catch ex As Exception

        End Try
    End Sub

    Private Sub 查询筛选_Click(sender As Object, e As EventArgs) Handles 查询筛选.Click
        Dim p As New 查询(ListView1)
        p.ShowDialog()
    End Sub

    Private Sub 取消全部勾选ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 取消全部勾选ToolStripMenuItem.Click
        For Each i As ListViewItem In ListView1.Items
            i.Checked = False
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListView2.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each i As ListViewItem In ListView2.Items
            If i.Checked = True Then
                i.Remove()
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        导出doc(ListView2, 标题.Text, 学年.Text, 学期.Text, 课程.Text, 类型.Text, AB卷.Text, 闭开.Text, 适用于.Text, 分钟.Text, 获得分数和(), 学号.Text, 姓名.Text)
    End Sub
    Public Function 导出doc(lists As ListView, 标题 As String, 学年 As String, 学期 As String, 课程 As String, 类型 As String, AB卷 As String, 闭开 As String, 适用于 As String, 分钟 As String, 总分 As String, 学号 As String, 姓名 As String)
        Dim doc = New XWPFDocument()

        Dim p1 As XWPFParagraph = doc.CreateParagraph()
        p1.Alignment = ParagraphAlignment.CENTER
        Dim runTitle = p1.CreateRun()
        runTitle.IsBold = True
        runTitle.SetText(标题)
        runTitle.FontSize = 26
        runTitle.SetFontFamily("宋体", FontCharRange.None)

        Dim p3 As XWPFParagraph = doc.CreateParagraph()
        p3.Alignment = ParagraphAlignment.CENTER
        Dim runTitle3 = p3.CreateRun()
        runTitle3.IsBold = True
        runTitle3.AppendText($"{学年}学年 {学期}学期  课程名称{课程} ({类型}.{AB卷}.{闭开})")
        runTitle3.AddCarriageReturn()
        runTitle3.AppendText($"    适用于 {适用于}  考试时间：{分钟}分钟 总分{总分}分")
        runTitle3.AddCarriageReturn()
        runTitle3.AppendText($"考生姓名：(  {学号}   )  考生学号 ：(   {姓名}  )")
        runTitle3.FontSize = 12
        runTitle3.SetFontFamily("宋体", FontCharRange.None)

        Dim 索引 = 1
        Dim 题目类型 = ""
        Dim 题目类型索引 = 0
        Dim strS = "一二三四五六七八九十一二三四五六七八九十一二三四五六七八九十"
        For Each i As ListViewItem In lists.Items
            Dim p2 = doc.CreateParagraph()
            If 题目类型 <> i.SubItems(1).Text Or 题目类型 = "" Then
                Dim 题目索引 = p2.CreateRun()
                题目索引.FontSize = 14
                题目索引.SetFontFamily("微软雅黑", FontCharRange.None)
                Try
                    题目索引.AppendText(strS(题目类型索引) & ". " & i.SubItems(1).Text)
                Catch ex As Exception
                End Try
                题目索引.AddCarriageReturn()
                题目类型 = i.SubItems(1).Text
                题目类型索引 += 1
            End If
            Dim 题目 = p2.CreateRun()
            题目.FontSize = 11
            题目.SetFontFamily("微软雅黑", FontCharRange.None)
            Dim 题目内容 = i.SubItems(6).Text
            If InStr(题目内容, "<img") >= 1 Then
                Dim ARR = Split(题目内容, "<img")
                题目.AppendText($"第{索引}题. ")
                题目.AppendText(ARR(0))
                For iii = 1 To ARR.Count - 1
                    Dim FS = New FileStream(Application.StartupPath & "\图片\" & Strings.Replace(Split(ARR(iii), ">")(0), " ", ""), FileMode.Open, FileAccess.Read)
                    题目.AddPicture(FS, PictureType.PNG, Split(ARR(iii), ">")(0), 50 * 9525, 50 * 9525)
                    题目.AppendText(Split(ARR(iii), ">")(1))
                Next
            Else
                题目.AppendText($"第{索引}题. {i.SubItems(6).Text}")
            End If
            题目.AddCarriageReturn()
            If i.SubItems(1).Text = "选择题" Then
                Dim arr = Split(i.SubItems(7).Text, ";")
                For n = 0 To arr.Count - 1
                    If InStr(arr(n), "<img") >= 1 Then
                        题目.AppendText(Chr(65 + n) & ": ")
                        Dim ARR2 = Split(arr(n), "<img")
                        题目.AppendText(ARR2(0))
                        For iii = 1 To ARR2.Count - 1
                            Dim FS = New FileStream(Application.StartupPath & "\图片\" & Strings.Replace(Split(ARR2(iii), ">")(0), " ", ""), FileMode.Open, FileAccess.Read)
                            题目.AddPicture(FS, PictureType.PNG, Split(ARR2(iii), ">")(0), 50 * 9525, 50 * 9525)
                            题目.AppendText(Split(ARR2(iii), ">")(1))
                        Next
                        题目.AppendText("   ")
                    Else
                        题目.AppendText(Chr(65 + n) & ": " & arr(n) & "   ")
                    End If
                Next
                题目.AddCarriageReturn()
            End If
            If i.SubItems(1).Text = "判断题" Then
                题目.AppendText("对(  )      错(  )")
            End If
            索引 += 1
        Next
        Dim MS As FileStream
        Dim FNAME = $"{标题}{课程}{类型}{AB卷}" & ".doc"
        Try
            MS = File.OpenWrite(FNAME)
        Catch ex As Exception
            FNAME = Guid.NewGuid.ToString & ".doc"
            MS = File.OpenWrite(FNAME)
        End Try
        doc.Write(MS)
        MS.Close()
        Process.Start(FNAME)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each i As ListViewItem In ListView1.SelectedItems
            i.Checked = True
        Next
        For Each i As ListViewItem In ListView1.Items
            If i.Checked = True Then
                For Each n As ListViewItem In ListView2.Items
                    If i.SubItems(6).Text = n.SubItems(6).Text Then
                        If MsgBox(i.SubItems(6).Text & vbCrLf & "重复,是否忽略", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then
                            Return
                        End If
                    End If
                Next
            End If
        Next
        ListView2.BeginUpdate()
        For Each i As ListViewItem In ListView1.Items
            If i.Checked = True Then
                ListView2.Items.Add(New ListViewItem({i.SubItems(0).Text, i.SubItems(1).Text, i.SubItems(2).Text, i.SubItems(3).Text, i.SubItems(4).Text, i.SubItems(5).Text, i.SubItems(6).Text, i.SubItems(7).Text, i.SubItems(8).Text}))
                i.Remove()
            End If
        Next
        ListView2.EndUpdate()
    End Sub
End Class