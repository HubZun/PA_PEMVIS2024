Imports MySql.Data.MySqlClient
Module module1
    Public conn As mysqlconnection
    Public cmd As mysqlcommand
    Public rd As mysqldatareader
    Public da As mysqldataadapter
    Public ds As dataset
    Public str As String
    Sub koneksi()
        Try
            Dim str As String =
            "server=localhost;userid=root;password=;database=kasircafe_db"
            conn = New mysqlconnection(str)
            If conn.state = connectionstate.closed Then
                conn.open()
            End If
        Catch ex As exception
            messagebox.show(ex.message)
        End Try
    End Sub
End Module