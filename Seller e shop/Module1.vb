﻿Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Module Module1
    Public comSQL As New SqlClient.SqlCommand
    Public sql As String
    Public conn As New SqlConnection
    Public str As String = "Data Source=DESKTOP-J6FMQ4C;Initial Catalog=hotel;Integrated Security=True"

    Public Sub bukakoneksi()
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = str

            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Koneksi Gagal: " & ex.ToString)
            End Try

        End If
    End Sub

    Public Sub tutupkoneksi()
        If conn.State = ConnectionState.Open Then

            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("Gagal menutup koneksi: " & ex.ToString)
            End Try

        End If
    End Sub
End Module
