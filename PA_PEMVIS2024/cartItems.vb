Public Class cartItems

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text -= 1

        If Label3.Text = 0 Then
            staffForm.panelKeranjang.Controls.Remove(Panel1)
            Panel1.Name = Nothing
            Label3.Text = 0
            jumlahUang = 0
        End If
        
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub cartItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class