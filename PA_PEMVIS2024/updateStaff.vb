Imports MySql.Data.MySqlClient

Public Class updateStaff
    Dim username, password As String

    Dim isBerubah As Boolean

    Private Function isEmpty()
        If txtUsername.Text = "" Then
            MsgBox("Username kosong")
            Return False
        ElseIf txtPassword.Text = "" Then
            MsgBox("password kosong")
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim empty = isEmpty()
        If empty Then
            cmd = New MySqlCommand("update user set username = '" & txtUsername.Text & "', password = '" & txtPassword.Text & "'", conn)
            rd = cmd.ExecuteReader
            MsgBox("berhasil diubah")

            rd.Close()

            adminForm.addItemsStaffFromDb()

            Me.Close()

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim empty = isEmpty()

        If empty Then
            valid()
            If isBerubah Then
                cmd = New MySqlCommand("delete from user where id_user = " & lblId.Text & "", conn)
                rd = cmd.ExecuteReader
                MsgBox("berhasil dihapus")
                txtUsername.Clear()
                txtPassword.Clear()
                rd.Close()
                adminForm.addItemsStaffFromDb()

                Me.Close()

            Else
                MsgBox("Username / password diubah!")


               
            End If
            

        End If

    End Sub

    Private Sub valid()
        'mengecek jika ada perubahan pada txtusername / txtpassword, maka tidak bisa diubah

        cmd = New MySqlCommand("select * from user where id_user =" & lblId.Text & "", conn)
        rd = cmd.ExecuteReader
        While rd.Read
            If rd.Item(1) = txtUsername.Text And rd.Item(2) = txtPassword.Text Then
                isBerubah = True
            Else
                isBerubah = False

            End If

        End While
        rd.Close()


    End Sub
    

    Private Sub updateStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class