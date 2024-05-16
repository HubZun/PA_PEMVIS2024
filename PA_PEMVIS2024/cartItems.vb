Public Class cartItems

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        menuPesanan = Label1.Text
        module1.hapusPesanan(menuPesanan)
        sum = 0
        For Each keranjang In module1.daftar_pesanan
            sum += keranjang.total
        Next

        staffForm.Label3.Text = sum
        Label3.Text -= 1

        If Label3.Text = 0 Then
            staffForm.panelKeranjang.Controls.Remove(Panel1)
            Panel1.Name = Nothing
            Label3.Text = 0
            jumlahUang = 0
        End If
        
    End Sub

End Class