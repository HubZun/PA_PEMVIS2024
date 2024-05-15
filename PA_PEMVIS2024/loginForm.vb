Imports MySql.Data.MySqlClient


Public Class loginForm
    Public username, password, role As String
    Public id As Integer

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text.Equals("") Or txtPassword.Text.Equals("") Then
            MessageBox.Show("isi username dan password")
        Else

            cmd = New MySqlCommand("Select * from user where username = '" & txtUsername.Text & "'", conn)
            rd = cmd.ExecuteReader()
            While rd.Read()
                id = rd("id_user")
                username = rd("username")
                password = rd("password")
                role = rd("role")
            End While
            rd.Close()

            If txtUsername.Text.Equals(username) And txtPassword.Text.Equals(password) Then
                If role = "staff" Then
                    MessageBox.Show("Login Berhasil")
                    staffForm.Show()
                    Me.Visible = False
                ElseIf role = "admin" Then
                    MessageBox.Show("Login Berhasil")
                    adminForm.Show()
                    Me.Visible = False
                Else
                    MessageBox.Show("anda tidak punya izin untuk mengakses")
                End If
                
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

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
End Class
