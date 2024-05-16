Module uidBuildervb

    Sub getRandomUID()
        Dim randomUID As String

        Dim random As New Random()
        Dim randomString As String = ""

        For i As Integer = 0 To 5 ' Generate 16 characters
            Dim randomNumber As Integer = random.Next(0, 62) ' Range for alphanumeric characters (0-9, a-z, A-Z)
            If randomNumber < 10 Then ' Numbers (0-9)
                randomString += randomNumber.ToString()
            ElseIf randomNumber < 36 Then ' Lowercase letters (a-z)
                randomString += Chr(randomNumber - 10 + 97).ToString()
            Else ' Uppercase letters (A-Z)
                randomString += Chr(randomNumber - 36 + 65).ToString()
            End If
        Next

        randomUID = "ID" & randomString

        cmd = New MySqlCommand("Select * from tiket where kodeTiket = '" & randomUID & "'", conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            While rd.Read
                If rd("KodeTiket") = randomUID Then
                    'MsgBox("sama")
                    getRandomUID()

                End If
            End While
        End If
        rd.Close()
        'Console.WriteLine(randomUID)

    End Sub

End Module
