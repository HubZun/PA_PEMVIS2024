Imports MySql.Data.MySqlClient

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
        Dim query = "select * from produk"
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader
        While rd.Read()
            dgvProduk.Rows.Add(rd.Item(1), rd.Item(2), rd.Item(3), rd.Item(4))


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


End Class