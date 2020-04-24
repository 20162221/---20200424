<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 题库管理主窗口
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
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
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
        Me.添加题目ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.添加单题ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.添加文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询题目ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改题目ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改题目类型ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改题目来源ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改考点ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改难度等级ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改分值ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改题目ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改题目候选答案ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改题目正确答案ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除题目ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除左边勾选的ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除数据库全部ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.返回主界面ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.刷新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(539, 297)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(413, 261)
        Me.WebBrowser2.TabIndex = 5
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 296)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(19, 18)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(540, 258)
        Me.WebBrowser1.TabIndex = 3
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 30)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(952, 262)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "数据库id"
        Me.ColumnHeader1.Width = 96
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "题目类型"
        Me.ColumnHeader2.Width = 96
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "题目来源"
        Me.ColumnHeader3.Width = 99
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "难度等级"
        Me.ColumnHeader4.Width = 95
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "考点"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "分值"
        Me.ColumnHeader6.Width = 64
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "题目"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "题目答案候选"
        Me.ColumnHeader8.Width = 134
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "题目正确答案"
        Me.ColumnHeader9.Width = 383
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.添加题目ToolStripMenuItem, Me.查询题目ToolStripMenuItem, Me.修改题目ToolStripMenuItem, Me.删除题目ToolStripMenuItem, Me.返回主界面ToolStripMenuItem, Me.刷新ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(952, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '添加题目ToolStripMenuItem
        '
        Me.添加题目ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.添加单题ToolStripMenuItem, Me.添加文件ToolStripMenuItem})
        Me.添加题目ToolStripMenuItem.Name = "添加题目ToolStripMenuItem"
        Me.添加题目ToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.添加题目ToolStripMenuItem.Text = "添加题目"
        '
        '添加单题ToolStripMenuItem
        '
        Me.添加单题ToolStripMenuItem.Name = "添加单题ToolStripMenuItem"
        Me.添加单题ToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.添加单题ToolStripMenuItem.Text = "添加单题"
        '
        '添加文件ToolStripMenuItem
        '
        Me.添加文件ToolStripMenuItem.Name = "添加文件ToolStripMenuItem"
        Me.添加文件ToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.添加文件ToolStripMenuItem.Text = "添加文件"
        '
        '查询题目ToolStripMenuItem
        '
        Me.查询题目ToolStripMenuItem.Name = "查询题目ToolStripMenuItem"
        Me.查询题目ToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.查询题目ToolStripMenuItem.Text = "查询题目"
        '
        '修改题目ToolStripMenuItem
        '
        Me.修改题目ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.修改题目类型ToolStripMenuItem, Me.修改题目来源ToolStripMenuItem, Me.修改考点ToolStripMenuItem, Me.修改难度等级ToolStripMenuItem, Me.修改分值ToolStripMenuItem, Me.修改题目ToolStripMenuItem1, Me.修改题目候选答案ToolStripMenuItem, Me.修改题目正确答案ToolStripMenuItem})
        Me.修改题目ToolStripMenuItem.Name = "修改题目ToolStripMenuItem"
        Me.修改题目ToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.修改题目ToolStripMenuItem.Text = "修改题目"
        '
        '修改题目类型ToolStripMenuItem
        '
        Me.修改题目类型ToolStripMenuItem.Name = "修改题目类型ToolStripMenuItem"
        Me.修改题目类型ToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.修改题目类型ToolStripMenuItem.Text = "修改题目类型"
        '
        '修改题目来源ToolStripMenuItem
        '
        Me.修改题目来源ToolStripMenuItem.Name = "修改题目来源ToolStripMenuItem"
        Me.修改题目来源ToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.修改题目来源ToolStripMenuItem.Text = "修改题目来源"
        '
        '修改考点ToolStripMenuItem
        '
        Me.修改考点ToolStripMenuItem.Name = "修改考点ToolStripMenuItem"
        Me.修改考点ToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.修改考点ToolStripMenuItem.Text = "修改考点"
        '
        '修改难度等级ToolStripMenuItem
        '
        Me.修改难度等级ToolStripMenuItem.Name = "修改难度等级ToolStripMenuItem"
        Me.修改难度等级ToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.修改难度等级ToolStripMenuItem.Text = "修改难度等级"
        '
        '修改分值ToolStripMenuItem
        '
        Me.修改分值ToolStripMenuItem.Name = "修改分值ToolStripMenuItem"
        Me.修改分值ToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.修改分值ToolStripMenuItem.Text = "修改分值"
        '
        '修改题目ToolStripMenuItem1
        '
        Me.修改题目ToolStripMenuItem1.Name = "修改题目ToolStripMenuItem1"
        Me.修改题目ToolStripMenuItem1.Size = New System.Drawing.Size(212, 26)
        Me.修改题目ToolStripMenuItem1.Text = "修改题目"
        '
        '修改题目候选答案ToolStripMenuItem
        '
        Me.修改题目候选答案ToolStripMenuItem.Name = "修改题目候选答案ToolStripMenuItem"
        Me.修改题目候选答案ToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.修改题目候选答案ToolStripMenuItem.Text = "修改题目候选答案"
        '
        '修改题目正确答案ToolStripMenuItem
        '
        Me.修改题目正确答案ToolStripMenuItem.Name = "修改题目正确答案ToolStripMenuItem"
        Me.修改题目正确答案ToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.修改题目正确答案ToolStripMenuItem.Text = "修改题目正确答案"
        '
        '删除题目ToolStripMenuItem
        '
        Me.删除题目ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.删除左边勾选的ToolStripMenuItem, Me.删除数据库全部ToolStripMenuItem})
        Me.删除题目ToolStripMenuItem.Name = "删除题目ToolStripMenuItem"
        Me.删除题目ToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.删除题目ToolStripMenuItem.Text = "删除题目"
        '
        '删除左边勾选的ToolStripMenuItem
        '
        Me.删除左边勾选的ToolStripMenuItem.Name = "删除左边勾选的ToolStripMenuItem"
        Me.删除左边勾选的ToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.删除左边勾选的ToolStripMenuItem.Text = "删除左边勾选的"
        '
        '删除数据库全部ToolStripMenuItem
        '
        Me.删除数据库全部ToolStripMenuItem.Name = "删除数据库全部ToolStripMenuItem"
        Me.删除数据库全部ToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.删除数据库全部ToolStripMenuItem.Text = "删除数据库全部"
        '
        '返回主界面ToolStripMenuItem
        '
        Me.返回主界面ToolStripMenuItem.Name = "返回主界面ToolStripMenuItem"
        Me.返回主界面ToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.返回主界面ToolStripMenuItem.Text = "返回主界面"
        '
        '刷新ToolStripMenuItem
        '
        Me.刷新ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem"
        Me.刷新ToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.刷新ToolStripMenuItem.Text = "刷新"
        '
        '题库管理主窗口
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 556)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "题库管理主窗口"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "题库管理主窗口"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser2 As WebBrowser
    Friend WithEvents WebBrowser1 As WebBrowser
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
    Friend WithEvents 添加题目ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 添加单题ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 添加文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 查询题目ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改题目ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改题目类型ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改题目来源ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改考点ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改难度等级ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改分值ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改题目ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 修改题目候选答案ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改题目正确答案ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除题目ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除左边勾选的ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除数据库全部ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 返回主界面ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 刷新ToolStripMenuItem As ToolStripMenuItem
End Class
