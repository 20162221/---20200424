<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 出卷主窗口
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.查询筛选 = New System.Windows.Forms.ToolStripMenuItem()
        Me.智能组卷ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.返回主界面ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.取消全部勾选ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.WebBrowser3 = New System.Windows.Forms.WebBrowser()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WebBrowser4 = New System.Windows.Forms.WebBrowser()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.姓名 = New System.Windows.Forms.TextBox()
        Me.学号 = New System.Windows.Forms.TextBox()
        Me.班级 = New System.Windows.Forms.TextBox()
        Me.分钟 = New System.Windows.Forms.TextBox()
        Me.适用于 = New System.Windows.Forms.TextBox()
        Me.闭开 = New System.Windows.Forms.ComboBox()
        Me.AB卷 = New System.Windows.Forms.ComboBox()
        Me.类型 = New System.Windows.Forms.ComboBox()
        Me.课程 = New System.Windows.Forms.TextBox()
        Me.学期 = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.学年 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.标题 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(877, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "加入当前试卷"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(1010, 211)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(388, 167)
        Me.WebBrowser2.TabIndex = 40
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(1010, 34)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(388, 146)
        Me.WebBrowser1.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1018, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "题目"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1018, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "答案"
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 31)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1004, 347)
        Me.ListView1.TabIndex = 36
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "题目类型"
        Me.ColumnHeader2.Width = 88
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "题目来源"
        Me.ColumnHeader3.Width = 85
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "难度等级"
        Me.ColumnHeader4.Width = 87
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "考点"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "分值"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "题目"
        Me.ColumnHeader7.Width = 160
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "题目答案候选"
        Me.ColumnHeader8.Width = 144
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "题目正确答案"
        Me.ColumnHeader9.Width = 387
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.查询筛选, Me.智能组卷ToolStripMenuItem, Me.返回主界面ToolStripMenuItem, Me.取消全部勾选ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1398, 28)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '查询筛选
        '
        Me.查询筛选.Name = "查询筛选"
        Me.查询筛选.Size = New System.Drawing.Size(83, 24)
        Me.查询筛选.Text = "查询筛选"
        '
        '智能组卷ToolStripMenuItem
        '
        Me.智能组卷ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.智能组卷ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.智能组卷ToolStripMenuItem.Name = "智能组卷ToolStripMenuItem"
        Me.智能组卷ToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.智能组卷ToolStripMenuItem.Text = "智能组卷"
        '
        '返回主界面ToolStripMenuItem
        '
        Me.返回主界面ToolStripMenuItem.Name = "返回主界面ToolStripMenuItem"
        Me.返回主界面ToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.返回主界面ToolStripMenuItem.Text = "返回主界面"
        '
        '取消全部勾选ToolStripMenuItem
        '
        Me.取消全部勾选ToolStripMenuItem.Name = "取消全部勾选ToolStripMenuItem"
        Me.取消全部勾选ToolStripMenuItem.Size = New System.Drawing.Size(113, 24)
        Me.取消全部勾选ToolStripMenuItem.Text = "取消全部勾选"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(210, 384)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 23)
        Me.Button4.TabIndex = 49
        Me.Button4.Text = "删除左边勾选"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 384)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 23)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "清空全部"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'WebBrowser3
        '
        Me.WebBrowser3.Location = New System.Drawing.Point(1003, 406)
        Me.WebBrowser3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser3.Name = "WebBrowser3"
        Me.WebBrowser3.Size = New System.Drawing.Size(388, 144)
        Me.WebBrowser3.TabIndex = 47
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(715, 388)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 15)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Label23"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1007, 553)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 15)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "答案"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1007, 388)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "题目"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(884, 384)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 23)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "导出当前试卷"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "导出的试题库"
        '
        'ListView2
        '
        Me.ListView2.CheckBoxes = True
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(0, 413)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(1004, 291)
        Me.ListView2.TabIndex = 50
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "id"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "题目类型"
        Me.ColumnHeader11.Width = 107
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "题目来源"
        Me.ColumnHeader12.Width = 105
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "难度等级"
        Me.ColumnHeader13.Width = 102
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "考点"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "分值"
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "题目"
        Me.ColumnHeader16.Width = 172
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "题目答案候选"
        Me.ColumnHeader17.Width = 236
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "题目正确答案"
        Me.ColumnHeader18.Width = 155
        '
        'WebBrowser4
        '
        Me.WebBrowser4.Location = New System.Drawing.Point(1004, 571)
        Me.WebBrowser4.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser4.Name = "WebBrowser4"
        Me.WebBrowser4.Size = New System.Drawing.Size(382, 133)
        Me.WebBrowser4.TabIndex = 51
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.姓名)
        Me.GroupBox1.Controls.Add(Me.学号)
        Me.GroupBox1.Controls.Add(Me.班级)
        Me.GroupBox1.Controls.Add(Me.分钟)
        Me.GroupBox1.Controls.Add(Me.适用于)
        Me.GroupBox1.Controls.Add(Me.闭开)
        Me.GroupBox1.Controls.Add(Me.AB卷)
        Me.GroupBox1.Controls.Add(Me.类型)
        Me.GroupBox1.Controls.Add(Me.课程)
        Me.GroupBox1.Controls.Add(Me.学期)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.学年)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.标题)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 710)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1398, 72)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "试题信息"
        '
        '姓名
        '
        Me.姓名.Location = New System.Drawing.Point(1296, 43)
        Me.姓名.Name = "姓名"
        Me.姓名.Size = New System.Drawing.Size(96, 25)
        Me.姓名.TabIndex = 23
        '
        '学号
        '
        Me.学号.Location = New System.Drawing.Point(1190, 43)
        Me.学号.Name = "学号"
        Me.学号.Size = New System.Drawing.Size(100, 25)
        Me.学号.TabIndex = 22
        '
        '班级
        '
        Me.班级.Location = New System.Drawing.Point(1084, 43)
        Me.班级.Name = "班级"
        Me.班级.Size = New System.Drawing.Size(100, 25)
        Me.班级.TabIndex = 21
        '
        '分钟
        '
        Me.分钟.Location = New System.Drawing.Point(978, 43)
        Me.分钟.Name = "分钟"
        Me.分钟.Size = New System.Drawing.Size(100, 25)
        Me.分钟.TabIndex = 20
        Me.分钟.Text = "120"
        '
        '适用于
        '
        Me.适用于.Location = New System.Drawing.Point(872, 43)
        Me.适用于.Name = "适用于"
        Me.适用于.Size = New System.Drawing.Size(100, 25)
        Me.适用于.TabIndex = 19
        Me.适用于.Text = "电脑和系统"
        '
        '闭开
        '
        Me.闭开.FormattingEnabled = True
        Me.闭开.Items.AddRange(New Object() {"开卷", "闭卷"})
        Me.闭开.Location = New System.Drawing.Point(745, 45)
        Me.闭开.Name = "闭开"
        Me.闭开.Size = New System.Drawing.Size(121, 23)
        Me.闭开.TabIndex = 18
        Me.闭开.Text = "开卷"
        '
        'AB卷
        '
        Me.AB卷.FormattingEnabled = True
        Me.AB卷.Items.AddRange(New Object() {"A卷", "B卷"})
        Me.AB卷.Location = New System.Drawing.Point(618, 45)
        Me.AB卷.Name = "AB卷"
        Me.AB卷.Size = New System.Drawing.Size(121, 23)
        Me.AB卷.TabIndex = 17
        Me.AB卷.Text = "A卷"
        '
        '类型
        '
        Me.类型.FormattingEnabled = True
        Me.类型.Items.AddRange(New Object() {"期中", "期末"})
        Me.类型.Location = New System.Drawing.Point(491, 45)
        Me.类型.Name = "类型"
        Me.类型.Size = New System.Drawing.Size(121, 23)
        Me.类型.TabIndex = 16
        Me.类型.Text = "期末"
        '
        '课程
        '
        Me.课程.Location = New System.Drawing.Point(385, 43)
        Me.课程.Name = "课程"
        Me.课程.Size = New System.Drawing.Size(100, 25)
        Me.课程.TabIndex = 15
        Me.课程.Text = "数据库"
        '
        '学期
        '
        Me.学期.FormattingEnabled = True
        Me.学期.Items.AddRange(New Object() {"第一学期", "第二学期"})
        Me.学期.Location = New System.Drawing.Point(258, 45)
        Me.学期.Name = "学期"
        Me.学期.Size = New System.Drawing.Size(121, 23)
        Me.学期.TabIndex = 14
        Me.学期.Text = "第一学期"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(1293, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 15)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "姓名"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(1187, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(37, 15)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "学号"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(1081, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 15)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "班级"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(975, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 15)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "分钟"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(874, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 15)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "适用于"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(742, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 15)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "闭/开卷"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(614, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 15)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "A/B卷"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(488, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 15)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "类型"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(382, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 15)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "课程"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(255, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "学期"
        '
        '学年
        '
        Me.学年.Location = New System.Drawing.Point(152, 45)
        Me.学年.Name = "学年"
        Me.学年.Size = New System.Drawing.Size(100, 25)
        Me.学年.TabIndex = 3
        Me.学年.Text = "2020-2021"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(149, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "学年"
        '
        '标题
        '
        Me.标题.Location = New System.Drawing.Point(15, 43)
        Me.标题.Name = "标题"
        Me.标题.Size = New System.Drawing.Size(131, 25)
        Me.标题.TabIndex = 1
        Me.标题.Text = "北京电子科技学院"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "标题"
        '
        'Timer1
        '
        '
        '出卷主窗口
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1398, 794)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WebBrowser4)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.WebBrowser3)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "出卷主窗口"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "出卷主窗口"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents WebBrowser2 As WebBrowser
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 查询筛选 As ToolStripMenuItem
    Friend WithEvents 智能组卷ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 返回主界面ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 取消全部勾选ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents WebBrowser3 As WebBrowser
    Friend WithEvents Label23 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents WebBrowser4 As WebBrowser
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents 姓名 As TextBox
    Friend WithEvents 学号 As TextBox
    Friend WithEvents 班级 As TextBox
    Friend WithEvents 分钟 As TextBox
    Friend WithEvents 适用于 As TextBox
    Friend WithEvents 闭开 As ComboBox
    Friend WithEvents AB卷 As ComboBox
    Friend WithEvents 类型 As ComboBox
    Friend WithEvents 课程 As TextBox
    Friend WithEvents 学期 As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents 学年 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents 标题 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Timer1 As Timer
End Class
