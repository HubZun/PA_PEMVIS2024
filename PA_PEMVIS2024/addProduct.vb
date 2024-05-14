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
        Dim query = "insert into produk values ('','" & txtNamaProduk.Text & "', '" & txtHargaProduk.Text & "' , '" & cboKategoriProduk.SelectedItem & "' , '" & cboStatusProduk.SelectedItem & "', '" & Label1.Text & "')"
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()
        MsgBox("berhasil ditambah")
        clear()
        rd.Close()

        adminForm.addItemsFromDb()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Gambar|*.jpg;.png;.jpeg;"

        If openFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim fileName As String = Path.GetFileName(openFileDialog.FileName)
            Label1.Text = fileName
        End If
    End Sub
End Class