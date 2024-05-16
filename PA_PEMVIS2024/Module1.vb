Imports MySql.Data.MySqlClient
Module module1
    Public conn As mysqlconnection
    Public cmd As mysqlcommand
    Public rd As mysqldatareader
    Public da As mysqldataadapter
    Public ds As dataset
    Public str As String
    Public daftar_pesanan As New List(Of keranjang)
    Public sum As Double
    Public jumlahUang As Integer
    Public menuPesanan As String
    Public Class keranjang
        Public menu As String
        Public total As Integer
    End Class
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
    Public Sub tambahPesanan(ByVal menuPesanan As String, ByVal jumlahUang As Integer)
        Dim newPesan As New keranjang()
        newPesan.menu = menuPesanan
        newPesan.total = jumlahUang
        daftar_pesanan.Add(newPesan)
    End Sub
    Public Sub hapusPesanan(ByVal menuPesanan As String)
        For Each keranjang In module1.daftar_pesanan
            If keranjang.menu = menuPesanan Then
                module1.daftar_pesanan.Remove(keranjang)
                MessageBox.Show("Data harga Telah diHapus")
                Exit For
            End If
        Next
    End Sub


End Module