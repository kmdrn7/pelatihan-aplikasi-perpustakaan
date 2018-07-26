Imports System.Data.SqlClient

Public Class frmCariSiswa
    Dim id As String
    Dim sql As String
    Dim simpan As Boolean

    Public CMD As New SqlCommand
    Public DA As New SqlDataAdapter
    Public DS As New DataSet
    Public DT As New DataTable
    Public DR As SqlDataReader

    Private Sub refreshGrid()
        Koneksi()
        sql = "SELECT * FROM tbl_siswa WHERE nama LIKE '%" & Ecari.Text & "%' OR kelas LIKE '%" & Ecari.Text & "%' OR username LIKE '%" & Ecari.Text & "%'"
        Try
            CMD.Connection = conn
            CMD.CommandType = CommandType.Text
            CMD.CommandText = sql

            DA.SelectCommand = CMD
            DS.Clear()
            DA.Fill(DS, "tbl_siswa")

            DG.DataSource = DS.Tables("tbl_siswa")
            LJumlah.Text = "Jumlah Data : " & DG.RowCount
        Catch ex As Exception
            MessageBox.Show("Error saat fetchdata" & vbNewLine & vbNewLine & ex.Message)
        Finally
            CMD.Dispose()
            conn.Close()
            DA.Dispose()
        End Try
    End Sub

    Private Sub resetForm()
        Ecari.Clear()
        Ecari.Focus()
    End Sub

    Private Sub frmCariSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetForm()
        refreshGrid()
    End Sub

    Private Sub DG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellClick
        Try
            frmPeminjaman.ENamaSiswa.Text = DG.Item(1, e.RowIndex).Value
            frmPeminjaman.EKelas.Text = DG.Item(2, e.RowIndex).Value
            frmPeminjaman.EIDSiswa.Text = DG.Item(0, e.RowIndex).Value
        Catch ex As Exception
            MessageBox.Show("Error ketika memilih data " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Close()
        End Try
    End Sub

    Private Sub Ecari_TextChanged(sender As Object, e As EventArgs) Handles Ecari.TextChanged
        refreshGrid()
    End Sub
End Class