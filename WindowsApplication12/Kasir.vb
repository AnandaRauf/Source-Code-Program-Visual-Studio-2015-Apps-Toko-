Public Class Kasir
    Public hrgamkn1, hrgamnm2 As Integer


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Select Case ComboBox4.Text
            Case "Air Mineral"
                Label12.Text = "Rp.3000"
                hrgamnm2 = 3000
            Case "Teh Tawar"
                Label12.Text = "Rp.1500"
                hrgamnm2 = 1500
            Case "Es Teh Tawar"
                Label12.Text = "Rp.2000"
                hrgamnm2 = 2000

            Case "Es Teh Manis"
                Label12.Text = "Rp.3000"
                hrgamnm2 = 3000
            Case "Teh Manis Hangat"
                Label12.Text = "Rp.2500"
                hrgamnm2 = 2500
            Case "Es Jeruk"
                Label12.Text = "Rp.8000"
                hrgamnm2 = 8000
            Case "Jeruk Hangat"
                Label12.Text = "Rp.7000"
                hrgamnm2 = 7000
            Case "Bir Pletok Es"
                Label12.Text = "Rp.11000"
                hrgamnm2 = 11000
            Case "Bir Pletok Hangat"
                Label12.Text = "Rp.10000"
                hrgamnm2 = 10000
            Case "Jus Jeruk"
                Label12.Text = "Rp.10000"
                hrgamnm2 = 10000
            Case "Jus Kedondong"
                Label12.Text = "Rp.10000"
                hrgamnm2 = 10000
        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim porsimkn1, porsimnm1, porsimkn2, porsimnm2, jumlah As Integer
        porsimkn1 = NumericUpDown1.Value
        porsimnm2 = NumericUpDown2.Value


        jumlah = (hrgamkn1 * porsimkn1) + +(hrgamnm2 * porsimnm1) + (hrgamnm2 * porsimnm2) + (CheckBox2.Checked) - (TextBox3.Text)
        TextBox1.Text = jumlah
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = True

        Makanan.Visible = True
        Minuman.Visible = False








    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        CheckBox2.Checked = True

        Minuman.Visible = True



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Ayam Goreng Kampung"
                Label7.Text = "Rp.15000"
                hrgamkn1 = 15000
            Case "Ayam Goreng Biasa"
                Label7.Text = "Rp.13000"
                hrgamkn1 = 13000
            Case "Sate Udang Goreng"
                Label7.Text = "Rp.15000"
                hrgamkn1 = 15000
            Case "Sate Kikil"
                Label7.Text = "Rp.7000"
                hrgamkn1 = 7000
            Case "Ampela Goreng"
                Label7.Text = "Rp.3000"
                hrgamkn1 = 3000
            Case "Ati Goreng"
                Label7.Text = "Rp.3000"
                hrgamkn1 = 3000
            Case "Paru Goreng"
                Label7.Text = "Rp.8000"
                hrgamkn1 = 8000
            Case "Empal Goreng"
                Label7.Text = "Rp.15000"
                hrgamkn1 = 15000
            Case "Soto Mie"
                Label7.Text = "Rp.15000"
                hrgamkn1 = 15000
            Case "Soto Betawi"
                Label7.Text = "Rp.25000"
                hrgamkn1 = 25000
            Case "Laksa Betawi"
                Label7.Text = "Rp.20000"
                hrgamkn1 = 20000
            Case "Asinan"
                Label7.Text = "Rp.7000"
                hrgamkn1 = 7000
            Case "Tahu"
                Label7.Text = "Rp.2500"
                hrgamkn1 = 2500
            Case "Tempe"
                Label7.Text = "Rp.2500"
                hrgamkn1 = 2500
            Case "Nasi Uduk"
                Label7.Text = "Rp.5000"
                hrgamkn1 = 5000
            Case "Nasi Putih"
                Label7.Text = "Rp.5000"
                hrgamkn1 = 5000


        End Select
    End Sub

End Class