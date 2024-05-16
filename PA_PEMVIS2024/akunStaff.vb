Public Class akunStaff

    Private Sub isEmpty()
        If txtUsername.Text = "" Then
            MsgBox("username kosong")
            txtUsername.Select()
        ElseIf txtPassword.Text = "" Then
            MsgBox("password kosong")
            txtPassword.Select()
        ElseIf txtKonfirmasiPassword.Text = "" Then
            MsgBox("konfirmasi password kosong")
            txtKonfirmasiPassword.Select()
        End If

    End Sub

    Private Sub validatePass()
        'password harus panjang 5 karakter

    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        isEmpty()


    End Sub
End Class