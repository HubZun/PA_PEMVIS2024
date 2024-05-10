Imports MySql.Data.MySqlClient


Public Class Form1
    Public username, password As String
    Public id As Integer

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs)
        Form2.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text.Equals("") Or txtPassword.Text.Equals("") Then
            MessageBox.Show("isi username dan password")
        Else
            koneksi()
            cmd = New MySqlCommand("Select * from user where username = '" & txtUsername.Text & "'", conn)
            rd = cmd.ExecuteReader()
            While rd.Read()
                id = rd("id_user")
                username = rd("username")
                password = rd("password")
            End While
            rd.Close()

            If txtUsername.Text.Equals(username) And txtPassword.Text.Equals(password) Then
                MessageBox.Show("Login Berhasil")
                staffForm.Show()
                Me.Visible = False
            Else
                MessageBox.Show("Akun tidak ditemukan")
            End If
        End If

        

    End Sub

    

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.Aqua

    End Sub

   


    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.Blue

    End Sub
End Class
