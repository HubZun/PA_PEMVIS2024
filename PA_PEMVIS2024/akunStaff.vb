Imports MySql.Data.MySqlClient

Public Class akunStaff
    Dim empty, valid As Boolean

    Private Sub isEmpty()
        empty = False
        If txtUsername.Text = "" Then
            MsgBox("username kosong")
            Return
        ElseIf txtPassword.Text = "" Then
            MsgBox("password kosong")
            Return

        ElseIf txtKonfirmasi.Text = "" Then
            MsgBox("konfirmasi password kosong")
            Return

        End If

        empty = True

    End Sub

    Private Sub validatePass()

        If txtPassword.Text <> txtKonfirmasi.Text Then
            MsgBox("konfirmasi passsword tidak sama")
            txtPassword.Clear()
            txtKonfirmasi.Clear()
            txtPassword.Select()
            valid = False
        Else
            valid = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        isEmpty()
        validatePass()


        If empty And valid Then
            cmd = New MySqlCommand("insert into user values(@id,@username,@password,@role)", conn)
            cmd.Parameters.AddWithValue("id", "")
            cmd.Parameters.AddWithValue("username", txtUsername.Text)
            cmd.Parameters.AddWithValue("password", txtPassword.Text)
            cmd.Parameters.AddWithValue("role", "staff")
            cmd.ExecuteNonQuery()


            MsgBox("berhasil buat akun")
            txtUsername.Clear()
            txtPassword.Clear()
            txtKonfirmasi.Clear()

            adminForm.addItemsStaffFromDb()

            Me.Close()


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class