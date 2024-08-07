Imports MySql.Data.MySqlClient

Public Class Form3
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

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedId As Object = ComboBox1.SelectedValue
        If Not IsDBNull(selectedId) AndAlso selectedId IsNot Nothing Then
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim connection As New MySqlConnection(connectionString)
                Dim command As New MySqlCommand("DELETE FROM biodata WHERE id = @id", connection)
                command.Parameters.AddWithValue("@id", selectedId)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil dihapus!")
                    LoadData()
                    parentForm.LoadData()
                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End If
        Else
            MessageBox.Show("Pilih biodata terlebih dahulu.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class