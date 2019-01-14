<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SyainM
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SyainName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SyainCd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSyainMaster = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.returnButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SyainName, Me.SyainCd, Me.Department, Me.Address})
        Me.DataGridView1.Location = New System.Drawing.Point(19, 188)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(901, 338)
        Me.DataGridView1.TabIndex = 0
        '
        'SyainName
        '
        Me.SyainName.HeaderText = "社員名"
        Me.SyainName.Name = "SyainName"
        '
        'SyainCd
        '
        Me.SyainCd.HeaderText = "社員コード"
        Me.SyainCd.Name = "SyainCd"
        '
        'Department
        '
        Me.Department.HeaderText = "部署"
        Me.Department.Name = "Department"
        '
        'Address
        '
        Me.Address.HeaderText = "住所"
        Me.Address.Name = "Address"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 38)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ＸＸ支店"
        '
        'lblSyainMaster
        '
        Me.lblSyainMaster.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblSyainMaster.Location = New System.Drawing.Point(12, 21)
        Me.lblSyainMaster.Name = "lblSyainMaster"
        Me.lblSyainMaster.Size = New System.Drawing.Size(272, 46)
        Me.lblSyainMaster.TabIndex = 5
        Me.lblSyainMaster.Text = "社員管理画面"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(108, 81)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 26)
        Me.TextBox1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "社員名"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(270, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "社員コード"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(394, 546)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(336, 24)
        Me.TextBox2.TabIndex = 10
        '
        'Search
        '
        Me.Search.Font = New System.Drawing.Font("MS UI Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Search.Location = New System.Drawing.Point(731, 81)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 26)
        Me.Search.TabIndex = 11
        Me.Search.Text = "検索"
        Me.Search.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(112, 544)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(161, 24)
        Me.TextBox3.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 544)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "社員名"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(283, 546)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 26)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "社員コード"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 575)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 26)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "部署"
        Me.Label6.UseCompatibleTextRendering = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(112, 577)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(161, 24)
        Me.TextBox4.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(286, 577)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "住所"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(394, 577)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(511, 34)
        Me.TextBox5.TabIndex = 18
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(374, 81)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(336, 24)
        Me.TextBox6.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(724, 645)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 29)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "更新"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Location = New System.Drawing.Point(553, 645)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 29)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "新規登録"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'returnButton
        '
        Me.returnButton.Font = New System.Drawing.Font("MS UI Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.returnButton.Location = New System.Drawing.Point(812, 645)
        Me.returnButton.Name = "returnButton"
        Me.returnButton.Size = New System.Drawing.Size(108, 29)
        Me.returnButton.TabIndex = 22
        Me.returnButton.Text = "戻る"
        Me.returnButton.UseVisualStyleBackColor = True
        '
        'SyainM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1023, 686)
        Me.Controls.Add(Me.returnButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblSyainMaster)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "SyainM"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SyainName As DataGridViewTextBoxColumn
    Friend WithEvents SyainCd As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSyainMaster As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Search As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents returnButton As Button
End Class
