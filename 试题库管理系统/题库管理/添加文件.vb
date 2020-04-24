Imports System.IO
Imports ICSharpCode.SharpZipLib.Zip
Imports NPOI.XWPF.Usermodel

Public Class 添加文件
    Private Sub 添加文件_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        题库管理主窗口.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.InitialDirectory = Application.StartupPath
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                RichTextBox1.Text = ""
                Try
                    Dim s As Stream = File.OpenRead(OpenFileDialog1.FileName)
                    Dim doc As XWPFDocument = New XWPFDocument(s)
                    For Each i In doc.Paragraphs
                        RichTextBox1.AppendText(i.ParagraphText)
                    Next
                    Try
                        读取word图片(OpenFileDialog1.FileName)
                    Catch ex As Exception

                    End Try
                Catch ex As Exception
                    RichTextBox1.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
                End Try
            Catch ex As Exception
            End Try
        End If
    End Sub
    Public Sub 读取word图片(p)
        Dim s = New ZipInputStream(File.OpenRead(p))
        Dim zipentryfromzippedfile As ZipEntry = s.GetNextEntry()
        Dim counts = 0
        While zipentryfromzippedfile Is Nothing = False
            Dim fname = zipentryfromzippedfile.Name
            If Strings.LCase(Path.GetExtension(fname)) = ".jpg" Or Strings.LCase(Path.GetExtension(fname)) = ".gif" Or Strings.LCase(Path.GetExtension(fname)) = ".bmp" Or Strings.LCase(Path.GetExtension(fname)) = ".png" Then
                Dim finfo = New FileInfo("图片\" & Path.GetFileName(fname))
                If (finfo.Directory.Exists) = False Then
                    finfo.Directory.Create()
                End If
                Dim file As FileStream = finfo.Create()
                Dim bufferfromzip(s.Length) As Byte
                s.Read(bufferfromzip, 0, bufferfromzip.Length)
                file.Write(bufferfromzip, 0, bufferfromzip.Length)
                file.Close()
                counts += 1
            End If
            zipentryfromzippedfile = s.GetNextEntry()
        End While
        MsgBox("解包" & counts & "张图片 ")
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RichTextBox1.Text = "" Then
            MsgBox("请先读取文件")
        End If
        ListView1.BeginUpdate()
        Try
            ListView1.Items.Clear()
            Dim arr = Split(RichTextBox1.Text, TextBox1.Text)
            For Each i In arr
                Dim arr2 = Split(i, TextBox2.Text)
                If arr2.Count = 8 Then
                    ListView1.Items.Add(New ListViewItem(arr2))
                End If
            Next
        Catch ex As Exception

        End Try
        ListView1.EndUpdate()
        MsgBox($"一共有{ListView1.Items.Count}条数据")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListView1.Items.Count = 0 Then
            MsgBox("没有有效数据，请先解析")
        End If
        Try
            For Each i As ListViewItem In ListView1.Items
                Try
                    Dim t As New List(Of String)
                    For n = 0 To 7
                        t.Add(i.SubItems(n).Text)
                    Next
                    Dim STR = Strings.Join(t.ToArray, "',N'")
                    cmd.CommandText = $"INSERT INTO tk (题目类型,题目来源,难度等级,考点,分值,题目,题目答案候选,题目正确答案) VALUES (N'{STR}')"
                    cmd.ExecuteNonQuery()
                Catch ex As Exception

                End Try
            Next
            MsgBox("导入成功")
            刷新全部数据(题库管理主窗口.ListView1)
        Catch ex As Exception
        End Try
    End Sub
End Class