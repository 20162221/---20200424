Public Class 个人信息修改
    Private Sub 个人信息修改_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = 当前登录账号
        cmd.CommandText = $"select * from zh where 账号='{当前登录账号}'"
        Dim ret = cmd.ExecuteReader()
        Dim imgid
        While ret.Read
            TextBox2.Text = ret(1)
            Try
                TextBox3.Text = ret(2)
            Catch ex As Exception
                TextBox3.Text = ""
            End Try
            Try
                ComboBox1.Text = ret(3)
            Catch ex As Exception
                ComboBox1.Text = ""
            End Try
            Try
                imgid = ret(4)
            Catch ex As Exception
                imgid = ""
            End Try
        End While
        PictureBox1.Image = 读取图片(imgid)
        ret.Close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim t As New OpenFileDialog
        t.InitialDirectory = Application.StartupPath
        t.Filter = "图片类型|*.jpg;*.bmp;*gif;*.png|JPG图片|*.jpg|BMP图片|*.bmg|GIF图片|*.gif|PNG图片|*.png"
        t.FilterIndex = 1
        If t.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim imgs = New Bitmap(Image.FromFile(t.FileName), 196, 170)
            Dim id = 上传图片(imgs)
            PictureBox1.Tag = id
            PictureBox1.Image = imgs
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cmd.CommandText = $"UPDATE zh SET 密码=N'{TextBox2.Text}',姓名=N'{TextBox3.Text}',性别=N'{ComboBox1.Text}',头像=N'{PictureBox1.Tag}' WHERE  账号=N'{当前登录账号}'"
            Dim t = cmd.ExecuteNonQuery()
            If t = 1 Then
                MsgBox("修改成功")
            Else
                MsgBox("未进行修改")
            End If
        Catch ex As Exception
            MsgBox("修改失败")
        End Try
    End Sub
    Private Sub 个人信息修改_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        开始界面.Show()
        开始界面.刷新显示文字(IO.File.ReadAllText("001.txt"))
    End Sub
End Class