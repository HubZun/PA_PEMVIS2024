Imports MySql.Data.MySqlClient
Imports System.IO

Public Class staffForm
    Public panel As New Panel()
    Private _number As Integer = 0
    Private _namePanel As String = Nothing
    Public nama, harga As String



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
                    .BackColor = Color.Gray
                    .Name = "items" + (_number + 1).ToString
                End With

                panelMenu.Controls.Add(Panel)

                _number += 1
                _namePanel = Panel.Name

            End While
        End If
        rd.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub staffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelMenu.Visible = True
        panelKeranjang.Visible = False
        loadData()
        Label1.Text = loginForm.username

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

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(jumlahUang)
        jumlahUang = 0
        panelKeranjang.Controls.Remove(panel)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class