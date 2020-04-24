Public Class 添加单题
    Private Sub 添加单题_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each i In Controls
            If (TypeOf i Is ComboBox) Then
                Dim t As ComboBox = CType(i, ComboBox)
                t.Items.Clear()
                cmd.CommandText = $"SELECT DISTINCT {t.Name} FROM tk"
                Dim ret = cmd.ExecuteReader
                While ret.Read
                    t.Items.Add(ret(0).ToString)
                End While
                ret.Close()
            End If
        Next
    End Sub
    Private Sub 题目类型_SelectedIndexChanged(sender As Object, e As EventArgs) Handles 题目类型.SelectedIndexChanged
        If 题目类型.Text = "判断题" Then
            TextBox6.Text = "对" & vbCrLf & "错"
        End If
        If 题目类型.Text = "选择题" Then
            TextBox6.Text = "请用;分割比如1;2;3;4"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If 题目类型.Text = "" Then
                MsgBox("请选择题目类型")
                Return
            End If
            If TextBox1.Text = "" Then
                MsgBox("请输入题目来源")
                Return
            End If
            If TextBox2.Text = "" Then
                MsgBox("请输入难度等级")
                Return
            End If
            If 考点.Text = "" Then
                MsgBox("请选择考点")
                Return
            End If
            If TextBox4.Text = "" Then
                MsgBox("请输入分值")
                Return
            End If
            If 题目.Text = "" Then
                MsgBox("请输入题目")
                Return
            End If
            If TextBox7.Text = "" Then
                MsgBox("请输入正确答案")
                Return
            End If
            cmd.CommandText = $"insert into tk values(N'{题目类型.Text}',N'{TextBox1.Text}',N'{TextBox2.Text}',N'{考点.Text}',N'{TextBox4.Text}',N'{题目.Text}',N'{TextBox6.Text}',N'{TextBox7.Text}')"
            Dim t = cmd.ExecuteNonQuery()
            If t = 1 Then
                MsgBox("添加成功")
            End If
            刷新全部数据(题库管理主窗口.ListView1)
        Catch ex As Exception
        End Try
    End Sub
End Class