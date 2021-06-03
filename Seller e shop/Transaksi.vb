Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Transaksi
    Dim jml, hrg, ttl As Integer
    Private Sub tampil()
        bukakoneksi()
        sql = "SELECT *  From dbo.reservasi"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
            DataGridView1.DataSource = dt
        Next
        tutupkoneksi()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox3.Text = ""
        DateTimePicker1.Value = ""
        DateTimePicker2.Value = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tampil()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bukakoneksi()
        sql = "INSERT INTO dbo.reservasi (no_reservasi,id_pelanggan,no_kamar,checkin,total,checkout) VALUES (" &
            "'" & ComboBox1.Text & "'," &
            "'" & ComboBox3.Text & "'," &
            "'" & ComboBox2.Text & "'," &
            "'" & DateTimePicker1.Value & "'," &
            "'" & DateTimePicker1.Value & "'," &
            "'" & ComboBox2.Text & "'," &
            "'" & DateTimePicker2.Value & ")"

        comSQL = New SqlCommand(sql, conn)

        Try
            comSQL.ExecuteNonQuery()
            MsgBox("Transaksi Berhasil")

        Catch ex As Exception
            MsgBox("simpan gagal: " & ex.ToString)

        End Try
        tutupkoneksi()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet.pemesanan' table. You can move, or remove it, as needed.
        Me.PemesananTableAdapter.Fill(Me.HotelDataSet.pemesanan)

    End Sub
End Class