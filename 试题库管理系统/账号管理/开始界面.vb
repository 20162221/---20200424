Public Class 开始界面
    Public gg As BufferedGraphics
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        题库管理主窗口.Show()
        Me.Hide()
    End Sub

    Private Sub 开始界面_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmd.CommandText = ($"select 姓名 from zh where 账号='{当前登录账号}'")
        Dim ret = cmd.ExecuteScalar
        Me.Text = $"您好！{ret}"
        sqlinit()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim t As New 出卷主窗口
        t.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim t As New 个人信息修改
        t.Show()
        Me.Hide()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub 开始界面_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        gg = BufferedGraphicsManager.Current.Allocate(Me.CreateGraphics, Me.DisplayRectangle)
        刷新显示文字(IO.File.ReadAllText("001.txt"))
    End Sub
    Sub 刷新显示文字(ss)
        gg.Graphics.DrawImage(Image.FromFile("主界面背景图.jpg"), 0, 0, Me.Width, Me.Height)
        gg.Graphics.DrawString("欢迎使用"， New Font("微软雅黑"， 40), Brushes.Black, New PointF(40, 20))
        gg.Graphics.DrawString("试题库管理系统"， New Font("微软雅黑"， 30)， Brushes.Black, New PointF(10, 90))
        gg.Graphics.DrawString(ss, New Font("微软雅黑"， 20), Brushes.Black, New PointF(320, 20))
        gg.Render()
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        刷新显示文字("编辑试题，增删改
浏览试题，按列排序
查询满足特定条件的试题
搜索含有某个关键字的试题
从word文件批量导入试题")
    End Sub
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        刷新显示文字("界面上部分是试题，下部分是试卷
双击试题集合中的某题加入试卷
保存导出word文档
根据不同题型数量随机抽取试题
可看到所选题目加起来的总分")
    End Sub
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        刷新显示文字("可修改头像、姓名、职位等")
    End Sub
    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        刷新显示文字("退出整个程序")
    End Sub
End Class