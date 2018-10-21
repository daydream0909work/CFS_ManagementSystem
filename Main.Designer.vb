<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SyainMaster = New System.Windows.Forms.Label()
        Me.SyainM_Kansai = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SendMail = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SyainMaster
        '
        Me.SyainMaster.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SyainMaster.Location = New System.Drawing.Point(11, 9)
        Me.SyainMaster.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SyainMaster.Name = "SyainMaster"
        Me.SyainMaster.Size = New System.Drawing.Size(163, 31)
        Me.SyainMaster.TabIndex = 6
        Me.SyainMaster.Text = "株式会社CFS"
        '
        'SyainM_Kansai
        '
        Me.SyainM_Kansai.Location = New System.Drawing.Point(6, 34)
        Me.SyainM_Kansai.Name = "SyainM_Kansai"
        Me.SyainM_Kansai.Size = New System.Drawing.Size(309, 45)
        Me.SyainM_Kansai.TabIndex = 7
        Me.SyainM_Kansai.Text = "関西支店"
        Me.SyainM_Kansai.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.SyainM_Kansai)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 300)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "社員管理"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(309, 45)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "東京支店"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Location = New System.Drawing.Point(367, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 300)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "総務"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 85)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(309, 45)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "東京支店"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 34)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(309, 45)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "関西支店"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SendMail
        '
        Me.SendMail.Location = New System.Drawing.Point(479, 410)
        Me.SendMail.Name = "SendMail"
        Me.SendMail.Size = New System.Drawing.Size(309, 28)
        Me.SendMail.TabIndex = 10
        Me.SendMail.Text = "管理者に問い合わせ"
        Me.SendMail.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SendMail)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.SyainMaster)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Main"
        Me.Text = "Mainvb"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SyainMaster As Label
    Friend WithEvents SyainM_Kansai As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents SendMail As Button
End Class
