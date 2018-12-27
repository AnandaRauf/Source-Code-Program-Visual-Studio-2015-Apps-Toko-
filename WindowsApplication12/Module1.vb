Imports System.Data.SqlClient
Module Module1
    Public koneksiSQL As SqlConnection

    Sub konekdatabase()
        Try
            koneksiSQL = New SqlConnection(“Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SS014\MSSQL\DATA\KulibetResto.mdf;Integrated Security=True”)
            koneksiSQL.Open()
        Catch ex As Exception
            MsgBox(“Tidak dapat tehubung ke Database”, MsgBoxStyle.Critical, “Gagal”)
        End Try
    End Sub
    Public Sub jalankansql(ByVal sql As String)
        Dim SQLCmd As New SqlCommand
        konekdatabase()
        Try
            SQLCmd.Connection = koneksiSQL
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.CommandText = sql
            SQLCmd.ExecuteNonQuery()
            SQLCmd.Dispose()
            koneksiSQL.Close()

            MsgBox(“Data Sudah Disimpan”, vbInformation)
        Catch ex As Exception
            MsgBox(“Tidak Bisa Menyimpan ” _
            + “data ke Server” & ex.Message)
        End Try
    End Sub
End Module

