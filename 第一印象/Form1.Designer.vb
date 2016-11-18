<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.FirstNameBox = New System.Windows.Forms.TextBox()
        Me.SecondNameBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MainLabel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'FirstNameBox
        '
        Me.FirstNameBox.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FirstNameBox.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.FirstNameBox.Location = New System.Drawing.Point(25, 36)
        Me.FirstNameBox.Name = "FirstNameBox"
        Me.FirstNameBox.Size = New System.Drawing.Size(100, 29)
        Me.FirstNameBox.TabIndex = 0
        Me.FirstNameBox.Text = "Leon"
        Me.FirstNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SecondNameBox
        '
        Me.SecondNameBox.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SecondNameBox.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.SecondNameBox.Location = New System.Drawing.Point(160, 36)
        Me.SecondNameBox.Name = "SecondNameBox"
        Me.SecondNameBox.Size = New System.Drawing.Size(100, 29)
        Me.SecondNameBox.TabIndex = 1
        Me.SecondNameBox.Text = "Mathilda"
        Me.SecondNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "对"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "的第一印象打分："
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(254, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "计算"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ScoreLabel
        '
        Me.ScoreLabel.Font = New System.Drawing.Font("微软雅黑", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ScoreLabel.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.ScoreLabel.Location = New System.Drawing.Point(17, 107)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(243, 124)
        Me.ScoreLabel.TabIndex = 6
        Me.ScoreLabel.Text = "--"
        Me.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(254, 36)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "交换"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MainLabel
        '
        Me.MainLabel.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.MainLabel.Location = New System.Drawing.Point(281, 12)
        Me.MainLabel.Multiline = True
        Me.MainLabel.Name = "MainLabel"
        Me.MainLabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MainLabel.Size = New System.Drawing.Size(254, 321)
        Me.MainLabel.TabIndex = 8
        Me.MainLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 345)
        Me.Controls.Add(Me.MainLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SecondNameBox)
        Me.Controls.Add(Me.FirstNameBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "测试第一印象得分："
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNameBox As TextBox
    Friend WithEvents SecondNameBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents MainLabel As TextBox
End Class
