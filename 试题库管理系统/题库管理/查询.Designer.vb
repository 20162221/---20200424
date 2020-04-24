<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 查询
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.分值 = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.考点 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.难度等级 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.题目类型 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(502, 464)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 44)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "查询"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(216, 466)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(289, 42)
        Me.TextBox1.TabIndex = 20
        '
        '分值
        '
        Me.分值.CheckBoxes = True
        Me.分值.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.分值.FullRowSelect = True
        Me.分值.HideSelection = False
        Me.分值.Location = New System.Drawing.Point(328, 259)
        Me.分值.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.分值.Name = "分值"
        Me.分值.Size = New System.Drawing.Size(270, 180)
        Me.分值.TabIndex = 19
        Me.分值.UseCompatibleStateImageBehavior = False
        Me.分值.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "请勾选分值"
        Me.ColumnHeader4.Width = 102
        '
        '考点
        '
        Me.考点.CheckBoxes = True
        Me.考点.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.考点.FullRowSelect = True
        Me.考点.HideSelection = False
        Me.考点.Location = New System.Drawing.Point(328, 36)
        Me.考点.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.考点.Name = "考点"
        Me.考点.Size = New System.Drawing.Size(270, 180)
        Me.考点.TabIndex = 18
        Me.考点.UseCompatibleStateImageBehavior = False
        Me.考点.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "请勾选难度"
        Me.ColumnHeader3.Width = 115
        '
        '难度等级
        '
        Me.难度等级.CheckBoxes = True
        Me.难度等级.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.难度等级.FullRowSelect = True
        Me.难度等级.HideSelection = False
        Me.难度等级.Location = New System.Drawing.Point(15, 259)
        Me.难度等级.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.难度等级.Name = "难度等级"
        Me.难度等级.Size = New System.Drawing.Size(271, 180)
        Me.难度等级.TabIndex = 17
        Me.难度等级.UseCompatibleStateImageBehavior = False
        Me.难度等级.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "请勾选难度"
        Me.ColumnHeader2.Width = 119
        '
        '题目类型
        '
        Me.题目类型.CheckBoxes = True
        Me.题目类型.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.题目类型.FullRowSelect = True
        Me.题目类型.HideSelection = False
        Me.题目类型.Location = New System.Drawing.Point(15, 36)
        Me.题目类型.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.题目类型.Name = "题目类型"
        Me.题目类型.Size = New System.Drawing.Size(271, 180)
        Me.题目类型.TabIndex = 16
        Me.题目类型.UseCompatibleStateImageBehavior = False
        Me.题目类型.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "请勾选题型"
        Me.ColumnHeader1.Width = 129
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 475)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "根据题目模糊查询"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(324, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "按分值"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "按难度"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(324, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "按考点"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "按题型"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(15, 525)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(583, 55)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "分类模糊查询"
        Me.Button2.UseVisualStyleBackColor = True
        '
        '查询
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 579)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.分值)
        Me.Controls.Add(Me.考点)
        Me.Controls.Add(Me.难度等级)
        Me.Controls.Add(Me.题目类型)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "查询"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "查询"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents 分值 As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents 考点 As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents 难度等级 As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents 题目类型 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
