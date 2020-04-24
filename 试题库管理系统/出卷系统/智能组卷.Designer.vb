<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 智能组卷
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
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.应用题 = New System.Windows.Forms.TextBox()
        Me.判断题 = New System.Windows.Forms.TextBox()
        Me.填空题 = New System.Windows.Forms.TextBox()
        Me.选择题 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(16, 144)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(315, 244)
        Me.CheckedListBox1.TabIndex = 50
        '
        '应用题
        '
        Me.应用题.Location = New System.Drawing.Point(244, 111)
        Me.应用题.Margin = New System.Windows.Forms.Padding(4)
        Me.应用题.Name = "应用题"
        Me.应用题.Size = New System.Drawing.Size(83, 25)
        Me.应用题.TabIndex = 48
        '
        '判断题
        '
        Me.判断题.Location = New System.Drawing.Point(244, 60)
        Me.判断题.Margin = New System.Windows.Forms.Padding(4)
        Me.判断题.Name = "判断题"
        Me.判断题.Size = New System.Drawing.Size(83, 25)
        Me.判断题.TabIndex = 49
        '
        '填空题
        '
        Me.填空题.Location = New System.Drawing.Point(73, 111)
        Me.填空题.Margin = New System.Windows.Forms.Padding(4)
        Me.填空题.Name = "填空题"
        Me.填空题.Size = New System.Drawing.Size(83, 25)
        Me.填空题.TabIndex = 46
        '
        '选择题
        '
        Me.选择题.Location = New System.Drawing.Point(73, 60)
        Me.选择题.Margin = New System.Windows.Forms.Padding(4)
        Me.选择题.Name = "选择题"
        Me.选择题.Size = New System.Drawing.Size(83, 25)
        Me.选择题.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(184, 114)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "应用题"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 63)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "判断题"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "填空题"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "选择题"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "请输入试题数量"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(16, 396)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(315, 85)
        Me.Button4.TabIndex = 51
        Me.Button4.Text = "添加"
        Me.Button4.UseVisualStyleBackColor = True
        '
        '智能组卷
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 488)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.应用题)
        Me.Controls.Add(Me.判断题)
        Me.Controls.Add(Me.填空题)
        Me.Controls.Add(Me.选择题)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "智能组卷"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "智能组卷"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents 应用题 As TextBox
    Friend WithEvents 判断题 As TextBox
    Friend WithEvents 填空题 As TextBox
    Friend WithEvents 选择题 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
End Class
