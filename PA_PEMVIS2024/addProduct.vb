Imports MySql.Data.MySqlClient

Public Class addProduct

    Public Sub clear()
        txtHargaProduk.Clear()
        txtNamaProduk.Clear()
        cboKategoriProduk.SelectedIndex = -1
        cboStatusProduk.SelectedIndex = -1

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        koneksi()
        Dim query = "insert into produk values ('','" & txtNamaProduk.Text & "', '" & txtHargaProduk.Text & "' , '" & cboKategoriProduk.SelectedItem & "' , '" & cboStatusProduk.SelectedItem & "')"
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()


        MsgBox("berhasil ditambah")
        clear()



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()


    End Sub
End Class