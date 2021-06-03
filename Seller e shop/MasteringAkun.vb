Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Mastering_Akun
    Private Sub tampil()
        bukakoneksi()
        sql = "Select * From dbo.akun"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        For Each dt In ds.Tables
            DataGridView1.DataSource = dt
        Next
        tutupkoneksi()
    End Sub
    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        bukakoneksi()
        sql = "INSERT INTO dbo.akun VALUES (" &
            "'" & TextBox1.Text & "'," &
            "'" & TextBox2.Text & "'," &
            "'" & ComboBox1.Text & "')"

        comSQL = New SqlCommand(sql, conn)

        Try
            comSQL.ExecuteNonQuery()
            MsgBox("Berhasil Menambahkan Akun")
        Catch ex As Exception
            MsgBox("Gagal Menambahkan: " & ex.ToString)

        End Try
        tutupkoneksi()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        bukakoneksi()
        sql = "UPDATE dbo.akun SET " &
            "username='" & TextBox1.Text & "'," &
            "password='" & TextBox2.Text & "'," &
            "username='" & ComboBox1.Text & "'," &
            "WHERE kd_barang='" & TextBox1.Text & "'"

        comSQL = New SqlCommand(sql, conn)

        Try
            comSQL.ExecuteNonQuery()
            MsgBox("Berhasil Menyunting")
        Catch ex As Exception
            MsgBox("Gagal Menyunting: " & ex.ToString)

        End Try
        tutupkoneksi()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        bukakoneksi()

        sql = "DELETE from dbo.akun WHERE username='" & TextBox1.Text & "'"

        comSQL = New SqlCommand(sql, conn)

        Try
            comSQL.ExecuteNonQuery()
            MsgBox("Berhasil Menghapus")
        Catch ex As Exception
            MsgBox("Gagal Menghapus: " & ex.ToString)
        End Try
        tutupkoneksi()

    End Sub

    Private Sub Read_Click(sender As Object, e As EventArgs) Handles Read.Click
        tampil()
    End Sub
End Class