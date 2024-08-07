<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        MaskedTextBox1 = New MaskedTextBox()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        GroupBox5 = New GroupBox()
        TextBox2 = New TextBox()
        GroupBox6 = New GroupBox()
        GroupBox7 = New GroupBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        GroupBox8 = New GroupBox()
        GroupBox9 = New GroupBox()
        DataGridView1 = New DataGridView()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox7.SuspendLayout()
        GroupBox8.SuspendLayout()
        GroupBox9.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(8, 29)
        RadioButton1.Margin = New Padding(3, 4, 3, 4)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(80, 21)
        RadioButton1.TabIndex = 8
        RadioButton1.TabStop = True
        RadioButton1.Text = "Laki-laki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(106, 29)
        RadioButton2.Margin = New Padding(3, 4, 3, 4)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(96, 21)
        RadioButton2.TabIndex = 9
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.BorderStyle = BorderStyle.None
        MaskedTextBox1.Location = New Point(8, 29)
        MaskedTextBox1.Margin = New Padding(3, 4, 3, 4)
        MaskedTextBox1.Mask = "000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(381, 18)
        MaskedTextBox1.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(7, 29)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(381, 18)
        TextBox1.TabIndex = 11
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Islam", "Katolik", "Protestan", "Buddha", "Hindu", "Konghucu"})
        ComboBox1.Location = New Point(7, 29)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(381, 25)
        ComboBox1.TabIndex = 12
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Font = New Font("Times New Roman", 9F)
        GroupBox1.Location = New Point(6, 43)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(394, 60)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Nama Lengkap"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Font = New Font("Times New Roman", 9F)
        GroupBox2.Location = New Point(6, 111)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(394, 73)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "Jenis Kelamin"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(MaskedTextBox1)
        GroupBox3.Font = New Font("Times New Roman", 9F)
        GroupBox3.Location = New Point(6, 192)
        GroupBox3.Margin = New Padding(3, 4, 3, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 4, 3, 4)
        GroupBox3.Size = New Size(394, 60)
        GroupBox3.TabIndex = 15
        GroupBox3.TabStop = False
        GroupBox3.Text = "Umur"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(ComboBox1)
        GroupBox4.Font = New Font("Times New Roman", 9F)
        GroupBox4.Location = New Point(6, 260)
        GroupBox4.Margin = New Padding(3, 4, 3, 4)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 4, 3, 4)
        GroupBox4.Size = New Size(394, 73)
        GroupBox4.TabIndex = 16
        GroupBox4.TabStop = False
        GroupBox4.Text = "Agama"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(TextBox2)
        GroupBox5.Font = New Font("Times New Roman", 9F)
        GroupBox5.Location = New Point(6, 341)
        GroupBox5.Margin = New Padding(3, 4, 3, 4)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(3, 4, 3, 4)
        GroupBox5.Size = New Size(394, 120)
        GroupBox5.TabIndex = 17
        GroupBox5.TabStop = False
        GroupBox5.Text = "Alamat Lengkap"
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(7, 29)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ScrollBars = ScrollBars.Vertical
        TextBox2.Size = New Size(381, 77)
        TextBox2.TabIndex = 0
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(GroupBox7)
        GroupBox6.Controls.Add(GroupBox1)
        GroupBox6.Controls.Add(GroupBox4)
        GroupBox6.Controls.Add(GroupBox3)
        GroupBox6.Controls.Add(GroupBox5)
        GroupBox6.Controls.Add(GroupBox2)
        GroupBox6.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox6.Location = New Point(12, 12)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(410, 544)
        GroupBox6.TabIndex = 18
        GroupBox6.TabStop = False
        GroupBox6.Text = "~ BIODATA ~"
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(TextBox3)
        GroupBox7.Font = New Font("Times New Roman", 9F)
        GroupBox7.Location = New Point(6, 469)
        GroupBox7.Margin = New Padding(3, 4, 3, 4)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Padding = New Padding(3, 4, 3, 4)
        GroupBox7.Size = New Size(394, 60)
        GroupBox7.TabIndex = 14
        GroupBox7.TabStop = False
        GroupBox7.Text = "Hobi"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Location = New Point(7, 29)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(381, 18)
        TextBox3.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 9F)
        Button1.Location = New Point(8, 45)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 19
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 9F)
        Button2.Location = New Point(108, 45)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 20
        Button2.Text = "Ubah"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 9F)
        Button3.Location = New Point(208, 45)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 21
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Times New Roman", 9F)
        Button4.Location = New Point(308, 45)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 22
        Button4.Text = "Keluar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox8
        ' 
        GroupBox8.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        GroupBox8.Controls.Add(Button1)
        GroupBox8.Controls.Add(Button4)
        GroupBox8.Controls.Add(Button2)
        GroupBox8.Controls.Add(Button3)
        GroupBox8.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox8.Location = New Point(12, 594)
        GroupBox8.Name = "GroupBox8"
        GroupBox8.Size = New Size(410, 80)
        GroupBox8.TabIndex = 23
        GroupBox8.TabStop = False
        GroupBox8.Text = "~ AKSI ~"
        ' 
        ' GroupBox9
        ' 
        GroupBox9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox9.Controls.Add(DataGridView1)
        GroupBox9.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox9.Location = New Point(428, 12)
        GroupBox9.Name = "GroupBox9"
        GroupBox9.Size = New Size(502, 662)
        GroupBox9.TabIndex = 25
        GroupBox9.TabStop = False
        GroupBox9.Text = "~ DATA ~"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 43)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(490, 613)
        DataGridView1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(942, 689)
        Controls.Add(GroupBox9)
        Controls.Add(GroupBox8)
        Controls.Add(GroupBox6)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        GroupBox8.ResumeLayout(False)
        GroupBox9.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView

End Class
