Imports MySql.Data.MySqlClient

Public Class Form2
    Private parentForm As Form1
    Private connectionString As String = "Server=localhost;Database=vbnet_biodata;User ID=root;Password=;"

    Public Sub New(parent As Form1)
        InitializeComponent()
        parentForm = parent
    End Sub

    Private Sub LoadData()
        Dim connection As New MySqlConnection(connectionString)
        Dim adapter As New MySqlDataAdapter("SELECT * FROM biodata", connection)
        Dim dataTable As New DataTable()

        Try
            connection.Open()
            adapter.Fill(dataTable)

            dataTable.Columns.Add("displayValue", GetType(String), "id + ' - ' + name")

            Dim placeholderRow As DataRow = dataTable.NewRow()
            placeholderRow("id") = DBNull.Value
            placeholderRow("displayValue") = "Pilih biodata"
            dataTable.Rows.InsertAt(placeholderRow, 0)

            ComboBox1.DataSource = dataTable
            ComboBox1.DisplayMember = "displayValue"
            ComboBox1.ValueMember = "id"

            ComboBox1.SelectedIndex = 0

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Enabled_switch(state As Boolean)
        If state = False Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            MaskedTextBox1.Text = ""
            ComboBox2.Text = ""
        End If

        TextBox1.Enabled = state
        TextBox2.Enabled = state
        TextBox3.Enabled = state
        RadioButton1.Enabled = state
        RadioButton2.Enabled = state
        MaskedTextBox1.Enabled = state
        ComboBox2.Enabled = state
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Enabled_switch(False)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selected_index As Integer = ComboBox1.SelectedIndex
        Dim selected_value As Object = ComboBox1.SelectedValue

        If selected_index > 0 AndAlso Not IsDBNull(selected_value) Then
            Enabled_switch(True)

            Dim connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("SELECT * FROM biodata WHERE id = @selected_value", connection)
            command.Parameters.AddWithValue("@selected_value", selected_value)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    TextBox1.Text = reader("name").ToString()
                    TextBox2.Text = reader("address").ToString()
                    TextBox3.Text = reader("hobby").ToString()

                    Dim gender As String = reader("gender").ToString()
                    RadioButton1.Checked = (gender = "m")
                    RadioButton2.Checked = (gender = "f")

                    MaskedTextBox1.Text = reader("age").ToString()
                    ComboBox2.Text = reader("religion").ToString().ToLower()
                End If

                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            Enabled_switch(False)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or Not (RadioButton1.Checked Or RadioButton2.Checked) Or MaskedTextBox1.Text = "" Or ComboBox1.SelectedIndex = 0 Then
            MsgBox("Pastikan semua field sudah terisi!")
        Else
            Dim connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("UPDATE biodata SET name = @value1, address = @value2, hobby = @value3, gender = @radioValue, age = @maskedValue, religion = @comboValue WHERE id = @selectedValue", connection)

            ' mencegah SQL Injection
            command.Parameters.AddWithValue("@value1", TextBox1.Text)
            command.Parameters.AddWithValue("@value2", TextBox2.Text)
            command.Parameters.AddWithValue("@value3", TextBox3.Text)
            command.Parameters.AddWithValue("@radioValue", If(RadioButton1.Checked, "m", "f"))
            command.Parameters.AddWithValue("@maskedValue", MaskedTextBox1.Text)
            command.Parameters.AddWithValue("@comboValue", ComboBox2.Text.ToLower())
            command.Parameters.AddWithValue("@selectedValue", ComboBox1.SelectedValue)

            Try
                connection.Open()
                command.ExecuteNonQuery()
                MsgBox("Data berhasil diperbarui!")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                MaskedTextBox1.Text = ""
                ComboBox1.SelectedIndex = 0
                ComboBox2.SelectedIndex = -1
                LoadData()
                parentForm.LoadData()
            Catch ex As MySqlException
                MsgBox("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
