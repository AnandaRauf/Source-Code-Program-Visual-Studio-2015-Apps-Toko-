<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inputbarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inputbarang))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.hpp = New System.Windows.Forms.TextBox()
        Me.hargajual = New System.Windows.Forms.TextBox()
        Me.kodebarang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.satuan = New System.Windows.Forms.TextBox()
        Me.nmbarang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridInputBarang = New System.Windows.Forms.DataGridView()
        Me.ButtonInput = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.stok = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridInputBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.stok)
        Me.GroupBox1.Controls.Add(Me.hpp)
        Me.GroupBox1.Controls.Add(Me.hargajual)
        Me.GroupBox1.Controls.Add(Me.kodebarang)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.satuan)
        Me.GroupBox1.Controls.Add(Me.nmbarang)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 235)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'hpp
        '
        Me.hpp.Location = New System.Drawing.Point(80, 131)
        Me.hpp.Name = "hpp"
        Me.hpp.Size = New System.Drawing.Size(130, 20)
        Me.hpp.TabIndex = 13
        '
        'hargajual
        '
        Me.hargajual.Location = New System.Drawing.Point(208, 96)
        Me.hargajual.Name = "hargajual"
        Me.hargajual.Size = New System.Drawing.Size(130, 20)
        Me.hargajual.TabIndex = 12
        '
        'kodebarang
        '
        Me.kodebarang.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kodebarang.Location = New System.Drawing.Point(164, 28)
        Me.kodebarang.Name = "kodebarang"
        Me.kodebarang.Size = New System.Drawing.Size(192, 21)
        Me.kodebarang.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Kode  Barang :"
        '
        'satuan
        '
        Me.satuan.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.satuan.Location = New System.Drawing.Point(100, 195)
        Me.satuan.Name = "satuan"
        Me.satuan.Size = New System.Drawing.Size(59, 21)
        Me.satuan.TabIndex = 9
        '
        'nmbarang
        '
        Me.nmbarang.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmbarang.Location = New System.Drawing.Point(164, 58)
        Me.nmbarang.Name = "nmbarang"
        Me.nmbarang.Size = New System.Drawing.Size(192, 21)
        Me.nmbarang.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Satuan :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stok :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "HPP :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Harga Jual Barang :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Barang :"
        '
        'DataGridInputBarang
        '
        Me.DataGridInputBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridInputBarang.Location = New System.Drawing.Point(12, 253)
        Me.DataGridInputBarang.Name = "DataGridInputBarang"
        Me.DataGridInputBarang.Size = New System.Drawing.Size(434, 150)
        Me.DataGridInputBarang.TabIndex = 1
        '
        'ButtonInput
        '
        Me.ButtonInput.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInput.Location = New System.Drawing.Point(31, 424)
        Me.ButtonInput.Name = "ButtonInput"
        Me.ButtonInput.Size = New System.Drawing.Size(75, 28)
        Me.ButtonInput.TabIndex = 2
        Me.ButtonInput.Text = " Input"
        Me.ButtonInput.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.Location = New System.Drawing.Point(139, 424)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 28)
        Me.ButtonEdit.TabIndex = 3
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(263, 424)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 28)
        Me.ButtonDelete.TabIndex = 4
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(371, 424)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 28)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'stok
        '
        Me.stok.Location = New System.Drawing.Point(80, 163)
        Me.stok.Name = "stok"
        Me.stok.Size = New System.Drawing.Size(55, 20)
        Me.stok.TabIndex = 14
        '
        'Inputbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(458, 502)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonInput)
        Me.Controls.Add(Me.DataGridInputBarang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inputbarang"
        Me.Text = "Inputbarang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridInputBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridInputBarang As DataGridView
    Friend WithEvents ButtonInput As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents satuan As TextBox
    Friend WithEvents nmbarang As TextBox
    Friend WithEvents kodebarang As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents hpp As TextBox
    Friend WithEvents hargajual As TextBox
    Friend WithEvents stok As TextBox
End Class
