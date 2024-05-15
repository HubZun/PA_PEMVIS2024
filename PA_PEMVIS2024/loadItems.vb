Public Class loadItems
    Dim nama, harga As String
    Dim noPanel As Integer = 0
    Public panel As New Panel()
    Dim cart As New cartItems()
    Dim namaPanel As String = Nothing
    Dim uang As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If panel.Name = "items" + (noPanel).ToString Then
            cart.Label3.Text += 1


        Else
            nama = Label1.Text
            harga = Label2.Text

            cart.Label1.Text = nama
            cart.Label2.Text = harga
            cart.Label3.Text = 1
            cart.PictureBox1.Image = PictureBox1.Image
            panel = cart.Panel1()

            panel.Name = "items" + (noPanel + 1).ToString

            staffForm.panelKeranjang.Controls.Add(panel)

            noPanel += 1
            namaPanel = panel.Name
        End If
        uang = Val(cart.Label2.Text) * Val(cart.Label3.Text)

        jumlahUang = jumlahUang + uang


    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub loadItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class