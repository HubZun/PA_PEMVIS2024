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

        Dim ms As New System.IO.MemoryStream()
        PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = ms.GetBuffer()
        ms.Close()

        Dim query = "UPDATE produk SET nama_produk = '" & txtNamaProduk.Text & "', harga_produk = '" & txtHargaProduk.Text & "', kategori_produk = '" & cboKategoriProduk.SelectedItem & "', status_produk = '" & cboStatusProduk.SelectedItem & "', gambar =  @gambar  WHERE id_produk = '" & txtId.Text & "' "
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("gambar", arrImage)

        rd = cmd.ExecuteReader()
        MsgBox("berhasil diubah")
        adminForm.Show()
        clear()
        rd.Close()

        adminForm.addItemsFromDb()

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFile As New OpenFileDialog()
        Try
            openFile.Filter = "JPEG(*.jpeg;*.jpg)|*.jpg|PNG(+.png)|*.png"
            If openFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(openFile.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub updateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        koneksi()
        Dim CMD As MySqlCommand
        CMD = New MySqlCommand("DELETE FROM produk WHERE id_produk='" & txtId.Text & "'", conn)
        CMD.ExecuteNonQuery()
        MsgBox("berhasil dihapus")
        adminForm.Show()
        clear()
        rd.Close()
        adminForm.addItemsFromDb()
        Me.Close()
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class