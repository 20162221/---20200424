Public Class 查询
    Public lv As ListView
    Sub New(t As ListView)
        InitializeComponent()
        lv = t
    End Sub
    Private Sub 查询_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each i In Controls
            If (TypeOf i Is ListView) Then
                Dim t As ListView = CType(i, ListView)
                t.Items.Clear()
                cmd.CommandText = $"SELECT DISTINCT {t.Name} FROM tk"
                Dim ret = cmd.ExecuteReader
                While ret.Read
                    t.Items.Add(ret(0).ToString)
                End While
                ret.Close()
                i.CheckBoxes = True
            End If
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            执行SQL刷新($"select * from tk where 题目 like N'%{TextBox1.Text}%'")
            Me.Close()
        Else
            MsgBox("请输入查询内容")
        End If
    End Sub
    Public Sub 执行SQL刷新(SS)
        lv.BeginUpdate()
        lv.Items.Clear()
        cmd.CommandText = SS
        Dim ret = cmd.ExecuteReader
        Dim colorbit = ""
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
            lv.Items.Add(t)
            colorbit = ret(1)
        End While
        lv.EndUpdate()
        ret.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sqltext As New List(Of String)
        For Each i In Controls
            If (TypeOf i Is ListView) Then
                Dim CS As New List(Of String)
                For Each nn As ListViewItem In i.Items
                    If nn.Checked = True Then
                        CS.Add($"[{i.name}]=N'{nn.SubItems(0).Text}'")
                    End If
                Next
                Dim s1 = "(" & Strings.Join(CS.ToArray, " or ") & ")"
                If s1 <> "()" Then sqltext.Add(s1)
            End If
        Next
        Dim joins = Strings.Join(sqltext.ToArray, " and ")
        Dim ttt
        If TextBox1.Text = "" Then
            ttt = $"select * from tk where {joins}"
        Else
            ttt = $"select * from tk where {joins} and 题目 like N'%{TextBox1.Text}%'"
        End If
        If joins = "" Then
            执行SQL刷新($"select * from tk where 题目 like N'%{TextBox1.Text}%'")
            Me.Close()
        Else
            执行SQL刷新(ttt)
            Me.Close()
        End If
    End Sub
End Class