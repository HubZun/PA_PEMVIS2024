Imports MySql.Data.MySqlClient
Imports System.IO

Public Class staffForm
    Public panel As New Panel()
    Private _number As Integer = 0
    Private _namePanel As String = Nothing
    Public nama, harga As String
    Dim bayar As Double
    Public kembalian As Double

    Public Sub loadData()
        cmd = New MySqlCommand("select * from produk", conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            While rd.Read()
                Dim index As Integer = 0
                nama = rd("nama_produk")
                harga = rd("harga_produk")


                Dim data As Byte() = DirectCast(rd("gambar"), Byte())
                Dim ms As New MemoryStream(data)
                Dim menu As New loadItems()
                menu.Label1.Text = nama
                menu.Label2.Text = harga
                menu.PictureBox1.Image = Image.FromStream(ms)
                Panel = menu.Panel1()


                With Panel
                    .BackColor = Color.Azure
                    .Name = "items" + (_number + 1).ToString
                End With

                panelMenu.Controls.Add(Panel)

                _number += 1
                _namePanel = Panel.Name

            End While
        End If
        rd.Close()
    End Sub

    Private Sub staffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelMenu.Visible = True
        panelKeranjang.Visible = False
        loadData()
        Label1.Text = loginForm.username
        AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintDocument1_PrintPage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panelMenu.Visible = True
        panelKeranjang.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        panelMenu.Visible = False
        panelKeranjang.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If sum = 0 Then
            MsgBox("Tambahkan Pesanan Terlebih Dahulu")
            Return
        ElseIf TextBox1.Text = "" Then
            MsgBox("Masukkan Pembayaran Terlebih Dahulu")
            Return
        End If

        bayar += TextBox1.Text

        If bayar < sum Then
            MsgBox("Uang Anda Tidak Cukup")
            TextBox1.Clear()
        ElseIf bayar >= sum Then
            Dim waktuSekarang As DateTime = Now

            koneksi()
            cmd = New MySqlCommand("insert into riwayat_pesanan (nama_staff, tanggal, total_harga) values (@nama_staff, @tanggal, @total_harga)", conn)
            cmd.Parameters.AddWithValue("nama_staff", Label1.Text)
            cmd.Parameters.AddWithValue("tanggal", waktuSekarang)
            cmd.Parameters.AddWithValue("total_harga", sum)
            cmd.ExecuteNonQuery()

            If bayar = sum Then
                kembalian = 0
            Else
                kembalian = bayar - sum
            End If

            Me.PrintPreviewDialog1.ShowDialog()

            sum = 0
            Label3.Text = sum
            panelKeranjang.Controls.Remove(Panel1)
            Panel1.Name = Nothing
            daftar_pesanan.Clear()
            TextBox1.Clear()
        End If


    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim font1 As Font = New Font("Poppins", 14, FontStyle.Bold)
        Dim font2 As Font = New Font("Poppins", 14, FontStyle.Regular)
        Dim font3 As Font = New Font("Poppins", 25, FontStyle.Bold)
        Dim b As SolidBrush = New SolidBrush(Color.Black)
        Dim g As Graphics = e.Graphics
        Dim x1 As Integer = 250
        Dim x2 As Integer = 50
        Dim y As Integer = 20
        Dim i As Integer = 1

        y += 15
        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Center
        g.DrawString("CAFE NEUVILLETTE", font3, b, New Point(225, y))
        y += 40
        g.DrawString("Tanggal Pemesanan: " & DateTime.Now.ToString("dd MMMM yyyy"), font2, b, New Point(x1, y))
        y += 30
        g.DrawString("______________________________________________________________", font1, b, New Point(x2, y))
        y += 40
        g.DrawString("Nama Menu ", font1, b, New Point(70, y))
        g.DrawString("Harga", font1, b, New Point(500, y))
        y += 30
        For Each keranjang In module1.daftar_pesanan
            g.DrawString(i & "." & keranjang.menu, font2, b, New Point(70, y))
            g.DrawString(keranjang.total, font2, b, New Point(510, y))
            i += 1
            y += 20
        Next
        g.DrawString("______________________________________________________________", font1, b, New Point(x2, y))
        y += 30
        g.DrawString("Total     :", font1, b, New Point(70, y))
        g.DrawString("Rp " & sum, font1, b, New Point(500, y))
        y += 30
        g.DrawString("Pembayaran:", font2, b, New Point(70, y))
        g.DrawString("Rp " & bayar, font2, b, New Point(500, y))
        y += 30
        g.DrawString("Kembalian :", font1, b, New Point(70, y))
        g.DrawString("Rp " & kembalian, font1, b, New Point(500, y))
        y += 30

    End Sub

End Class