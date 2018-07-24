Public Class frmBuku

    Dim id As String
    Dim sql As String
    Dim simpan As Boolean

    Private Sub refreshGrid()
        Koneksi()
        sql = "SELECT * FROM tbl_buku WHERE buku LIKE '%" & Ecari.Text & "%' OR tahun LIKE '%" & Ecari.Text & "%' OR sinopsis LIKE '%" & Ecari.Text & "%'"
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
        ENama.Clear()
        ESinopsis.Clear()
        ETahun.Clear()

        GBData.Enabled = True
        GBInfo.Enabled = False

        btnBaru.Enabled = True
        btnUbah.Enabled = True
        btnHapus.Enabled = True

        Ecari.Focus()
    End Sub

    Private Sub frmSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetForm()
        refreshGrid()
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        btnBaru.Enabled = False
        btnUbah.Enabled = False
        btnHapus.Enabled = False

        GBData.Enabled = False
        GBInfo.Enabled = True

        ENama.Clear()
        ESinopsis.Clear()
        ETahun.Clear()

        ENama.Focus()

        simpan = True
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If id <> "" And ENama.Text <> "" Then
            btnBaru.Enabled = False
            btnUbah.Enabled = False
            btnHapus.Enabled = False

            GBData.Enabled = False
            GBInfo.Enabled = True

            ENama.Focus()

            simpan = False
        Else
            MessageBox.Show("Belum ada data yang dipilih!")
            DG.Focus()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Koneksi()
        If id <> "" And ENama.Text <> "" Then
            If MessageBox.Show("Hapus data yang dipilih?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                sql = "DELETE FROM tbl_buku where id_buku = '" & id & "'"
                Try
                    CMD.Connection = conn
                    CMD.CommandType = CommandType.Text
                    CMD.CommandText = sql
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    resetForm()
                    refreshGrid()
                Catch ex As Exception
                    MessageBox.Show("Error saat menghapus" & vbNewLine & vbNewLine & ex.Message)
                Finally
                    CMD.Dispose()
                    conn.Close()
                End Try
            End If
        Else
            MessageBox.Show("Belum ada data yang dipilih!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DG.Focus()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Koneksi()
        If ENama.Text <> "" And ESinopsis.Text <> "" And ETahun.Text <> "" Then

            If simpan Then

                sql = "insert into tbl_buku "
                sql &= "(buku, sinopsis, tahun, status) "
                sql &= "values ('" & ENama.Text & "', '" & ESinopsis.Text & "', '" & ETahun.Text & "', 1)"

                Try
                    CMD.Connection = conn
                    CMD.CommandType = CommandType.Text
                    CMD.CommandText = sql
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    resetForm()
                    refreshGrid()
                Catch ex As Exception
                    MessageBox.Show("Error saat meyimpan data" & vbNewLine & vbNewLine & ex.Message)
                Finally
                    CMD.Dispose()
                    conn.Close()
                End Try

            Else

                sql = "update tbl_buku set "
                sql &= "buku = '" & ENama.Text & "', sinopsis  = '" & ESinopsis.Text & "', tahun = '" & ETahun.Text & "' "
                sql &= "where id_buku = '" & id & "'"

                Try
                    CMD.Connection = conn
                    CMD.CommandType = CommandType.Text
                    CMD.CommandText = sql
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    resetForm()
                    refreshGrid()
                Catch ex As Exception
                    MessageBox.Show("Error saat mengubah data" & vbNewLine & vbNewLine & ex.Message)
                Finally
                    CMD.Dispose()
                    conn.Close()
                End Try

            End If

        Else
            MessageBox.Show("Lengkapi kembali data anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ENama.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim proses As String

        If simpan Then
            proses = "penambahan data baru"
        Else
            proses = "pengubahan data"
        End If

        If MessageBox.Show("Batalkan proses " & proses & "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            resetForm()
            refreshGrid()
        End If
    End Sub

    Private Sub Ecari_TextChanged(sender As Object, e As EventArgs) Handles Ecari.TextChanged
        refreshGrid()
    End Sub

    Private Sub DG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellClick
        Try
            id = DG.Item(0, e.RowIndex).Value
            ENama.Text = DG.Item(1, e.RowIndex).Value
            ESinopsis.Text = DG.Item(2, e.RowIndex).Value
            ETahun.Text = DG.Item(3, e.RowIndex).Value
        Catch ex As Exception
            MessageBox.Show("Error ketika memilih data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class