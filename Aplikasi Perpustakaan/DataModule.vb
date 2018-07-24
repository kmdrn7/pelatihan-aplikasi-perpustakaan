Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Module DataModule

    Public conn As New SqlConnection
    Public path As String = "data source = DESKTOP-51456GO\SQLEXPRESS; initial catalog = db_perpustakaan; user = sa; password = andika12345"

    Public CMD As New SqlCommand
    Public DA As New SqlDataAdapter
    Public DS As New DataSet
    Public DT As New DataTable
    Public DR As SqlDataReader

    Public isLogin As Boolean
    Public isConnect As Boolean

    Public Sub Koneksi()
        If conn.State = ConnectionState.Closed Then
            Try
                conn.ConnectionString = path
                conn.Open()
                isConnect = True
            Catch ex As Exception
                MessageBox.Show("Error koneksi ke database " & vbNewLine & vbNewLine & ex.Message)
                isConnect = False
            End Try
        End If
    End Sub

End Module
