Imports System.Data.SqlClient

Public Class frmCariBuku

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
        sql = "SELECT * FROM tbl_buku WHERE buku LIKE '%" & Ecari.Text & "%' OR sinopsis LIKE '%" & Ecari.Text & "%' OR tahun LIKE '%" & Ecari.Text & "%'"
        Try
            CMD.Connection = conn
            CMD.CommandType = CommandType.Text
            CMD.CommandText = sql

            DA.SelectCommand = CMD
            DS.Clear()
            DA.Fill(DS, "tbl_buku")

            DG.DataSource = DS.Tables("tbl_buku")
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

    Private Sub frmCariBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetForm()
        refreshGrid()
    End Sub

    Private Sub DG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellClick
        Try
            frmPeminjaman.EIDBuku.Text = DG.Item(0, e.RowIndex).Value
            frmPeminjaman.ENamaBuku.Text = DG.Item(1, e.RowIndex).Value
            frmPeminjaman.ESinopsis.Text = DG.Item(2, e.RowIndex).Value
            frmPeminjaman.ETahun.Text = DG.Item(3, e.RowIndex).Value
            frmPeminjaman.EStatus.Text = DG.Item(4, e.RowIndex).Value
        Catch ex As Exception
            MessageBox.Show("Error ketika memilih data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Close()
        End Try
    End Sub
End Class