Public Class 登陆
    Private Sub 登陆_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        全局变量.sqlinit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "jiaoshi"
        TextBox2.Text = "1111"
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            PictureBox1.Image = Nothing
            cmd.CommandText = $"select 头像 from zh where 账号='{TextBox1.Text}'"
            Dim t = cmd.ExecuteScalar
            If (t <> "") Then PictureBox1.Image = 读取图片(t)
        Catch ex As Exception
            PictureBox1.Image = Nothing
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("请输入账号或密码")
            Return
        End If
        cmd.CommandText = $"select 账号 from zh where 账号='{TextBox1.Text}'and 密码='{TextBox2.Text}'"
        Dim ret = cmd.ExecuteScalar
        If ret <> "" Then
            当前登录账号 = TextBox1.Text
            开始界面.Show()
            Me.Hide()
        Else
            MsgBox("账号或密码不正确，请重新输入")
        End If
    End Sub
End Class
