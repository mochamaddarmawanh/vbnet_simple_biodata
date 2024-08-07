Imports MySql.Data.MySqlClient

Public Class Form1
    Private connectionString As String = "Server=localhost;Database=vbnet_biodata;User ID=root;Password=;"

    Public Sub LoadData()

        Dim connection As New MySqlConnection(connectionString)
        Dim adapter As New MySqlDataAdapter("SELECT * FROM biodata", connection)
        Dim dataTable As New DataTable()

        Try
            connection.Open()
            adapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or Not (RadioButton1.Checked Or RadioButton2.Checked) Or MaskedTextBox1.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Pastikan semua field sudah terisi!")
        Else
            Dim connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("INSERT INTO biodata (name, address, hobby, gender, age, religion) VALUES (@value1, @value2, @value3, @radioValue, @maskedValue, @comboValue)", connection)

            ' mencegah SQL Injection
            command.Parameters.AddWithValue("@value1", TextBox1.Text)
            command.Parameters.AddWithValue("@value2", TextBox2.Text)
            command.Parameters.AddWithValue("@value3", TextBox3.Text)
            command.Parameters.AddWithValue("@radioValue", If(RadioButton1.Checked, RadioButton1.Text, RadioButton2.Text))
            command.Parameters.AddWithValue("@maskedValue", MaskedTextBox1.Text)
            command.Parameters.AddWithValue("@comboValue", ComboBox1.Text)

            Try
                connection.Open()
                command.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan!")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                MaskedTextBox1.Text = ""
                ComboBox1.Text = ""
                LoadData()
            Catch ex As MySqlException
                MsgBox("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form2 As New Form2(Me)
        form2.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form3 As New Form3(Me)
        form3.ShowDialog()
    End Sub
End Class
