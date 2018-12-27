Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SS014\MSSQL\DATA\KulibetResto.mdf;Integrated Security=True")

        Dim command As New SqlCommand("select * from table_admin where Username = Username and Password = Password", connection)

        command.Parameters.Add("Username", SqlDbType.VarChar).Value = user.Text
        command.Parameters.Add("Password", SqlDbType.VarChar).Value = pass.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MessageBox.Show("Username Or Password Are Invalid")

        Else

            MessageBox.Show("Login Successfully")

            Dim frm As New VBNETSQLInsertUpdate_Delete()

            Me.Hide()

            Inputbarang.Show()

        End If
    End Sub
End Class