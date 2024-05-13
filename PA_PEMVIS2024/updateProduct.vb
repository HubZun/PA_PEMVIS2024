Imports MySql.Data.MySqlClient
Imports System.IO
Public Class updateProduct

    Public Sub clear()
        txtHargaProduk.Clear()
        txtNamaProduk.Clear()
        cboKategoriProduk.SelectedIndex = -1
        cboStatusProduk.SelectedIndex = -1
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        koneksi()
        Dim query = "UPDATE produk SET nama_produk = '" & txtNamaProduk.Text & "', harga_produk = '" & txtHargaProduk.Text & "', kategori_produk = '" & cboKategoriProduk.SelectedItem & "', status_produk = '" & cboStatusProduk.SelectedItem & "', gambar = '" & Label1.Text & "' WHERE id_produk = '" & txtId.Text & "' "
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()
        MsgBox("berhasil diubah")
        adminForm.Show()
        clear()
        rd.Close()

        adminForm.addItemsFromDb()

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Gambar|*.jpg;.png;.jpeg;"
        If openFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim fileName As String = Path.GetFileName(openFileDialog.FileName)
            Label1.Text = fileName
        End If
    End Sub

    Private Sub updateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class