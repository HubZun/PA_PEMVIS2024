Imports MySql.Data.MySqlClient
Imports System.IO

Public Class addProduct

    Public Sub clear()
        txtHargaProduk.Clear()
        txtNamaProduk.Clear()
        cboKategoriProduk.SelectedIndex = -1
        cboStatusProduk.SelectedIndex = -1
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        koneksi()
        Try
            Dim ms As New System.IO.MemoryStream()
            PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = ms.GetBuffer()
            ms.Close()

            cmd = New MySqlCommand("insert into produk (nama_produk,harga_produk,kategori_produk,status_produk,gambar) values (@nama_produk,@harga_produk,@kategori_produk,@status_produk,@gambar)", conn)
            cmd.Parameters.AddWithValue("nama_produk", txtNamaProduk.Text)
            cmd.Parameters.AddWithValue("harga_produk", txtHargaProduk.Text)
            cmd.Parameters.AddWithValue("kategori_produk", cboKategoriProduk.Text)
            cmd.Parameters.AddWithValue("status_produk", cboStatusProduk.Text)
            cmd.Parameters.AddWithValue("gambar", arrImage)
            cmd.ExecuteNonQuery()

            MsgBox("berhasil simpan gambar")
            PictureBox1.Image = Nothing
            txtHargaProduk.Text = ""
            txtNamaProduk.Text = ""
            cboKategoriProduk.TabIndex = 0
            cboStatusProduk.TabIndex = 0
            Me.Close()
            

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
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
End Class