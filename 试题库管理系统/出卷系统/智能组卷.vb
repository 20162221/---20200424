Public Class 智能组卷
    Public 上面列表框 As ListView
    Public 下面列表框 As ListView
    Sub New(l1 As ListView, l2 As ListView)
        InitializeComponent()
        上面列表框 = l1
        下面列表框 = l2
    End Sub
    Private Sub 智能组卷_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.CommandText = $"SELECT DISTINCT 考点 FROM tk"
        Dim ret = cmd.ExecuteReader
        While ret.Read
            CheckedListBox1.Items.Add(ret(0).ToString)
        End While
        ret.Close()
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        选择题.Text = get数量("选择题", 上面列表框)
        判断题.Text = get数量("判断题", 上面列表框)
        填空题.Text = get数量("填空题", 上面列表框)
        应用题.Text = get数量("应用题", 上面列表框)
    End Sub
    Function get数量(S As String, T As ListView)
        Dim ret = 0
        For Each i As ListViewItem In T.Items
            For Each N In CheckedListBox1.CheckedItems
                If i.SubItems(1).Text = S And i.SubItems(4).Text = N Then
                    ret += 1
                End If
            Next
        Next
        Return ret
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If get数量("选择题", 上面列表框) < Int(选择题.Text) Then
            MsgBox("题目不够")
            Return
        End If
        If get数量("判断题", 上面列表框) < Int(判断题.Text) Then
            MsgBox("题目不够")
            Return
        End If
        If get数量("填空题", 上面列表框) < Int(填空题.Text) Then
            MsgBox("题目不够")
            Return
        End If
        If get数量("应用题", 上面列表框) < Int(应用题.Text) Then
            MsgBox("题目不够")
            Return
        End If
        插入题目("选择题")
        插入题目("判断题")
        插入题目("填空题")
        插入题目("应用题")
        Me.Close()
    End Sub
    Public Function 插入题目(类型 As String)
        While get数量(类型, 下面列表框) <> Int(Controls.Find(类型, False)(0).Text)
            Dim I = 上面列表框.Items(rnd.Next(0, 上面列表框.Items.Count))
            For Each N In CheckedListBox1.CheckedItems
                If I.SubItems(1).Text = 类型 And N = I.SubItems(4).Text Then
                    下面列表框.Items.Add(New ListViewItem({I.SubItems(0).Text, I.SubItems(1).Text, I.SubItems(2).Text, I.SubItems(3).Text, I.SubItems(4).Text, I.SubItems(5).Text, I.SubItems(6).Text, I.SubItems(7).Text, I.SubItems(8).Text}))
                    I.Remove()
                End If
            Next
        End While
    End Function
End Class