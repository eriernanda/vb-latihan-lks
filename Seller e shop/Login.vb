Imports System.Data.SqlClient
Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bukakoneksi()
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM dbo.akun WHERE username= '" & TextBox1.Text & "' and password= '" & TextBox2.Text & "'", conn)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            MsgBox("Data Belum Lengkap")
        ElseIf (dt.Rows.Count > 0) Then
            MsgBox("Sukses Login")
            Me.Hide()
            MenuUtamaMaster.Show()
        Else
            MsgBox("Useraname atau Password Anda Salah")

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        CheckBox1.Checked = False
        Dim result As DialogResult = MsgBox("Anda Yakin Ingin Keluar ?", MessageBoxButtons.OKCancel + MessageBoxIcon.Information, "E-Shop")
        If result = DialogResult.OK Then
            MsgBox("Adios :)", MessageBoxButtons.OK, "Keluar")
            Me.Close()
        End If
    End Sub
End Class