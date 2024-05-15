Imports MySql.Data.MySqlClient
Imports System.IO

Public Class adminForm
    Dim count As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrd.Click
        pnlOnBtnPrd.Height = btnPrd.Height
        pnlOnBtnPrd.Top = btnPrd.Top
        pnlProduk.Visible = True
        pnlProfile.Visible = False
        pnlStaff.Visible = False

        pnlOnBtnStf.Height = 0
        pnlOnBtnPrf.Height = 0
    End Sub


    Private Sub btnStff_Click(sender As Object, e As EventArgs) Handles btnStff.Click
        pnlOnBtnStf.Height = btnStff.Height
        pnlOnBtnStf.Top = btnStff.Top
        pnlProduk.Visible = False
        pnlProfile.Visible = False
        pnlStaff.Visible = True

        pnlOnBtnPrd.Height = 0
        pnlOnBtnPrf.Height = 0

    End Sub
    Private Sub btnPrf_Click(sender As Object, e As EventArgs) Handles btnPrf.Click
        pnlOnBtnPrf.Height = btnPrf.Height
        pnlOnBtnPrf.Top = btnPrf.Top

        pnlProduk.Visible = False
        pnlProfile.Visible = True
        pnlStaff.Visible = False

        pnlOnBtnPrd.Height = 0
        pnlOnBtnStf.Height = 0

    End Sub


    Public Sub addItemsFromDb()
        dgvProduk.Rows.Clear()

        Dim query = "select * from produk"
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader
        While rd.Read()
            dgvProduk.Rows.Add(rd.Item(0), rd.Item(1), rd.Item(2), rd.Item(3), rd.Item(4), rd.Item(5))
        End While
    End Sub


    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        addItemsFromDb()
        pnlOnBtnStf.Height = 0
        pnlOnBtnPrf.Height = 0
        pnlOnBtnLgt.Height = 0

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        addProduct.Show()

    End Sub

    Private Sub dgvProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellClick

        If dgvProduk.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvProduk.SelectedRows(0)
            updateProduct.txtId.Text = row.Cells(0).Value
            updateProduct.txtNamaProduk.Text = row.Cells(1).Value
            updateProduct.txtHargaProduk.Text = row.Cells(2).Value
            updateProduct.cboKategoriProduk.Text = row.Cells(3).Value
            updateProduct.cboStatusProduk.Text = row.Cells(4).Value

            Dim data As Byte() = DirectCast(row.Cells(5).Value, Byte())
            Dim ms As New MemoryStream(data)
            updateProduct.PictureBox1.Image = Image.FromStream(ms)

            updateProduct.Show()

        End If

    End Sub

    Private Sub dgvProduk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellContentClick

    End Sub
End Class