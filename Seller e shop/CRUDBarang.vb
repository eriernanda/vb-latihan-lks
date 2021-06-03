Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form2
    Private Sub tampil()
        bukakoneksi()
        sql = "SELECT *  From dbo.barang"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
            DataGridView1.DataSource = dt
        Next
        tutupkoneksi()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tampil()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bukakoneksi()
        sql = "INSERT INTO dbo.barang (kd_barang,nm_produk,produsen,harga,jml_barang) VALUES (" &
            "'" & TextBox1.Text & "'," &
            "'" & TextBox2.Text & "'," &
            "'" & TextBox3.Text & "'," &
            "'" & TextBox4.Text & "'," &
            "'" & TextBox5.Text & "')"

        comSQL = New SqlCommand(sql, conn)

        Try
            comSQL.ExecuteNonQuery()
            MsgBox("Berhasil Menyimpan")
        Catch ex As Exception
            MsgBox("simpan gagal: " & ex.ToString)

        End Try
        tutupkoneksi()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bukakoneksi()
        sql = "UPDATE dbo.barang SET " &
            "nm_produk='" & TextBox2.Text & "'," &
            "produsen='" & TextBox3.Text & "'," &
            "harga='" & TextBox4.Text & "'," &
            "jml_barang='" & TextBox5.Text & "'" &
            "WHERE kd_barang='" & TextBox1.Text & "'"

        comSQL = New SqlCommand(sql, conn)

        Try
            comSQL.ExecuteNonQuery()
            MsgBox("Berhasil Mengubah")
        Catch ex As Exception
            MsgBox("ubah gagal: " & ex.ToString)

        End Try
        tutupkoneksi()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bukakoneksi()
        sql = "DELETE FROM dbo.barang WHERE kd_barang='" & TextBox1.Text & "'"

        comSQL = New SqlCommand(sql, conn)

        Try
            comSQL.ExecuteNonQuery()
            MsgBox("Berhasil Menghapus")
        Catch ex As Exception
            MsgBox("Gagal Menghapus :" & ex.ToString)
        End Try
        tutupkoneksi()
    End Sub
End Class