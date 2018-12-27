Imports System.Data
Imports System.Data.SqlClient
Public Class Inputbarang
    Dim koneksi = Module1.koneksiSQL
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonInput.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SS014\MSSQL\DATA\Kulibet_Resto.mdf;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO tbl_inputbarang([KodeBarang], [Nama_Barang], [Satuan], [Harga_Jual], [Stok], [HPP]) VALUES('" & kodebarang.Text & "','" & nmbarang.Text & "','" & hargajual.Text & "','" & hpp.Text & "','" & stok.Text & "','" & satuan.Text & "')"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try


    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, koneksiSQL)

        koneksiSQL.Open()

        command.ExecuteNonQuery()

        koneksiSQL.Close()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Dim updateQuery As String = "Update table_inputbarang Nama_Barang = '" & nmbarang.Text & "' ,Satuan = '" & satuan.Text & "',Harga_Jual = " & hargajual.Text & "',HPP = " & hpp.Text & "',Stok = " & stok.Text & " WHERE KodeBarang =" & kodebarang.Text & ""
        ExecuteQuery(updateQuery)
        MessageBox.Show("Data Updated")

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim deleteQuery As String = "delete from table_inputbarang Where KodeBArang = " & kodebarang.Text
        ExecuteQuery(deleteQuery)
        MessageBox.Show("User deleted")

    End Sub
End Class