Imports MySql.Data.MySqlClient


Public Class adminProfile
    Dim idUser As String = login.id
    Dim empty, valid, isOldPass As Boolean

    Private Sub isEmpty()
        'cek jika field belum diisi
        empty = False
        If txtOldPass.Text = "" Then
            MsgBox("old password tidak boleh kosong")
            txtOldPass.Select()

            Return
        ElseIf txtNewPass.Text = "" Then
            MsgBox("new password tidak boleh kosong")
            txtNewPass.Select()

            Return
        ElseIf txtConfrmPass.Text = "" Then
            MsgBox("confirmasi password tidak boleh kosong")
            txtConfrmPass.Select()

            Return

        End If
        empty = True

    End Sub

    Private Sub validateOldPass()
        'cek jika field old passwd tidak sama dengan di database, dan cek password baru tidak boleh sama yang sebelumnya

        cmd = New MySqlCommand("select * from user where id_user = '" & idUser & "'", conn)
        rd = cmd.ExecuteReader

        While rd.Read
            If rd("password") <> txtOldPass.Text Then
                MsgBox("Old Password Salah!")
                isOldPass = False
                rd.Close()

                Return
            ElseIf rd("password") = txtNewPass.Text Then
                MsgBox("password tidak boleh sama dengan yang lama")
                isOldPass = False
                rd.Close()

                Return



            End If
        End While
        isOldPass = True
        rd.Close()

    End Sub

    Private Sub validateSamePass()
        'cek new password dan confirm new password apakah sama

        valid = False
        If txtNewPass.Text <> txtConfrmPass.Text Then
            MsgBox("password / confirmasi password tidak sama")

            Return
        Else
            valid = True
        End If

    End Sub


    Private Sub adminProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Console.WriteLine(idUser)

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        isEmpty()
        If empty Then
            validateSamePass()
            If valid Then
                validateOldPass()
                If isOldPass Then

                    cmd = New MySqlCommand("update user set password = '" & txtNewPass.Text & "' where id_user = " & idUser & "", conn)
                    rd = cmd.ExecuteReader()
                    MsgBox("berhasil di update")
                    Me.Close()

                    txtOldPass.Clear()
                    txtNewPass.Clear()
                    txtConfrmPass.Clear()


                    rd.Close()
                End If
               
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class