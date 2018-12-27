<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kasir))
        Me.Makanan = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Minuman = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Makanan.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Minuman.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Makanan
        '
        Me.Makanan.Controls.Add(Me.CheckBox2)
        Me.Makanan.Controls.Add(Me.CheckBox1)
        Me.Makanan.Controls.Add(Me.NumericUpDown1)
        Me.Makanan.Controls.Add(Me.Label7)
        Me.Makanan.Controls.Add(Me.Label3)
        Me.Makanan.Controls.Add(Me.Label2)
        Me.Makanan.Controls.Add(Me.ComboBox1)
        Me.Makanan.Controls.Add(Me.Label1)
        Me.Makanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Makanan.Location = New System.Drawing.Point(19, 22)
        Me.Makanan.Name = "Makanan"
        Me.Makanan.Size = New System.Drawing.Size(410, 240)
        Me.Makanan.TabIndex = 0
        Me.Makanan.TabStop = False
        Me.Makanan.Text = "Makanan"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(247, 147)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(123, 17)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Tambahan Minuman"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(247, 108)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Tambahan Makanan"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(157, 105)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(59, 20)
        Me.NumericUpDown1.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(192, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "...."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(16, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jumlah Porsi  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Harga Makanan  :"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Ayam Goreng Kampung", " Ayam Goreng Biasa", "Sate Udang Goreng", "Sate Kikil", "Ampela Goreng", " Ati Goreng", " Paru Goreng", " Empal Goreng", "Soto Mie", "Soto Betawi", " Laksa Betawi", " Asinan", "Tahu", "Tempe", "Nasi Uduk", "Nasi Putih"})
        Me.ComboBox1.Location = New System.Drawing.Point(184, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(209, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Makanan :"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(200, 172)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(148, 20)
        Me.TextBox3.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(16, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Uang Pelanggan  :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(200, 132)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(16, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Pembayaran :"
        '
        'Minuman
        '
        Me.Minuman.Controls.Add(Me.NumericUpDown2)
        Me.Minuman.Controls.Add(Me.Button4)
        Me.Minuman.Controls.Add(Me.Button3)
        Me.Minuman.Controls.Add(Me.Button2)
        Me.Minuman.Controls.Add(Me.Button1)
        Me.Minuman.Controls.Add(Me.TextBox3)
        Me.Minuman.Controls.Add(Me.Label5)
        Me.Minuman.Controls.Add(Me.ComboBox4)
        Me.Minuman.Controls.Add(Me.TextBox1)
        Me.Minuman.Controls.Add(Me.Label6)
        Me.Minuman.Controls.Add(Me.Label4)
        Me.Minuman.Controls.Add(Me.Label12)
        Me.Minuman.Controls.Add(Me.Label9)
        Me.Minuman.Controls.Add(Me.Label8)
        Me.Minuman.Location = New System.Drawing.Point(19, 268)
        Me.Minuman.Name = "Minuman"
        Me.Minuman.Size = New System.Drawing.Size(410, 255)
        Me.Minuman.TabIndex = 1
        Me.Minuman.TabStop = False
        Me.Minuman.Text = "Minuman"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(157, 98)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(59, 20)
        Me.NumericUpDown2.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(329, 214)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 29)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(231, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 29)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(119, 214)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 34)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Tambah Pesanan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Air Mineral", "Teh Tawar", "Es Teh Tawar", "Es Teh Manis", "Teh Manis Hangat", "Es Jeruk", "Jeruk Hangat", "Bir Pletok Es", "Bir Pletok Hangat", "Jus Jeruk", "Jus Kedondong"})
        Me.ComboBox4.Location = New System.Drawing.Point(184, 32)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(209, 21)
        Me.ComboBox4.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(16, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Jumlah Gelas  :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(197, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 15)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "...."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(16, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 21)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Nama Minuman :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(16, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Harga Minuman  :"
        '
        'Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(441, 528)
        Me.Controls.Add(Me.Minuman)
        Me.Controls.Add(Me.Makanan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Kasir"
        Me.Text = "Kasir"
        Me.Makanan.ResumeLayout(False)
        Me.Makanan.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Minuman.ResumeLayout(False)
        Me.Minuman.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Makanan As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Minuman As GroupBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
End Class
