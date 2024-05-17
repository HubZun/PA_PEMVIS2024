Imports MySql.Data.MySqlClient
Imports System.IO

Public Class addProduct
    Dim randomUID As String
    Dim empty As Boolean

    Sub getRandomUID()
        Dim random As New Random()
        Dim randomString As String = ""

        For i As Integer = 0 To 5 ' Generate 16 characters
            Dim randomNumber As Integer = random.Next(0, 62) ' Range for alphanumeric characters (0-9, a-z, A-Z)
            If randomNumber < 10 Then ' Numbers (0-9)
                randomString += randomNumber.ToString()
            ElseIf randomNumber < 36 Then ' Lowercase letters (a-z)
                randomString += Chr(randomNumber - 10 + 97).ToString()
            Else ' Uppercase letters (A-Z)
                randomString += Chr(randomNumber - 36 + 65).ToString()
            End If
        Next

        randomUID = "PRD" & randomString

        cmd = New MySqlCommand("Select * from produk where id_produk = '" & randomUID & "'", conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            While rd.Read
                If rd("id_produk") = randomUID Then
                    'MsgBox("sama")
                    getRandomUID()

                End If
            End While
        End If
        rd.Close()
        Console.WriteLine(randomUID)

    End Sub


    Public Sub clear()
        txtHargaProduk.Clear()
        txtNamaProduk.Clear()
        cboKategoriProduk.SelectedIndex = -1
        cboStatusProduk.SelectedIndex = -1
    End Sub

    Private Sub isEmpty()
        If txtNamaProduk.Text = "" Then
            MsgBox("Nama kosong")
            Return
        ElseIf txtHargaProduk.Text = "" Then
            MsgBox("harga kosong")
            Return

        ElseIf cboKategoriProduk.SelectedItem = "" Then
            MsgBox("kategori belum dipilih")
            Return


        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        isEmpty()

        getRandomUID()

        Try
            Dim ms As New System.IO.MemoryStream()
            PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = ms.GetBuffer()
            ms.Close()

            cmd = New MySqlCommand("insert into produk (id_produk,nama_produk,harga_produk,kategori_produk,status_produk,gambar) values (@id_produk,@nama_produk,@harga_produk,@kategori_produk,@status_produk,@gambar)", conn)
            cmd.Parameters.AddWithValue("id_produk", randomUID)

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

            adminForm.addItemsFromDb()

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

    Private Sub addProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

    End Sub

    Private Sub txtHargaProduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaProduk.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> ControlChars.Back Then
            e.Handled = True

        End If
    End Sub

    
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class