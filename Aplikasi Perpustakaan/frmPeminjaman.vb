Public Class frmPeminjaman

    Dim id As String
    Dim id_buku As String
    Dim id_peminjaman As String
    Dim sql As String
    Dim simpan As Boolean

    Private Sub refreshGrid()
        Koneksi()
        sql = "SELECT * FROM q_peminjaman WHERE id_siswa like '" & EIDSiswa.Text & "' AND flag = '1'"
        Try
            CMD.Connection = conn
            CMD.CommandType = CommandType.Text
            CMD.CommandText = sql

            DA.SelectCommand = CMD
            DS.Clear()
            DA.Fill(DS, "q_peminjaman")

            DG.DataSource = DS.Tables("q_peminjaman")
        Catch ex As Exception
            MessageBox.Show("Error saat fetchdata " & vbNewLine & vbNewLine & ex.Message)
        Finally
            CMD.Dispose()
            conn.Close()
            DA.Dispose()
        End Try
    End Sub

    Private Sub resetForm()
        EIDSiswa.Clear()
        ENamaSiswa.Clear()
        EKelas.Clear()
        EIDBuku.Clear()
        ENamaBuku.Clear()
        ETahun.Clear()
        ESinopsis.Clear()
        EStatus.Clear()

        GBBuku.Enabled = False
        GBSiswa.Enabled = False
        GBPeminjaman.Enabled = False
        GBAksi.Enabled = True

        btnPeminjaman.Enabled = True
        btnPengembalian.Enabled = True
        btnSimpan.Enabled = True
        btnPengembalian.Enabled = True

        id = ""
    End Sub

    Private Sub btnCariSiswa_Click(sender As Object, e As EventArgs) Handles btnCariSiswa.Click
        frmCariSiswa.ShowDialog(Me)
    End Sub

    Private Sub btnCariBuku_Click(sender As Object, e As EventArgs) Handles btnCariBuku.Click
        frmCariBuku.ShowDialog(Me)
    End Sub

    Private Sub frmPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetForm()
        refreshGrid()
    End Sub

    Private Sub btnPeminjaman_Click(sender As Object, e As EventArgs) Handles btnPeminjaman.Click
        btnPeminjaman.Enabled = False
        btnPengembalian.Enabled = False
        btnKembalikan.Enabled = False

        GBSiswa.Enabled = True
        GBBuku.Enabled = True
        GBPeminjaman.Enabled = True

        EIDSiswa.Focus()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub EIDSiswa_TextChanged(sender As Object, e As EventArgs) Handles EIDSiswa.TextChanged
        refreshGrid()
        id = EIDSiswa.Text
    End Sub

    Private Sub EIDBuku_TextChanged(sender As Object, e As EventArgs) Handles EIDBuku.TextChanged
        id_buku = EIDBuku.Text
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Koneksi()
        If EIDSiswa.Text <> "" And EIDBuku.Text <> "" Then
            If EStatus.Text <> "1" Then
                MessageBox.Show("Buku yang akan dipinjam tidak tersedia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                sql = "insert into tbl_peminjaman "
                sql &= "(id_siswa, id_buku, tgl_pinjam, tgl_kembali, flag) "
                sql &= "values ('" & EIDSiswa.Text & "', '" & EIDBuku.Text & "', '" & Format(Date.Today, "MM/dd/yyyy").ToString & "', '" & Format(DTTglKembali.Value, "MM/dd/yyyy").ToString & "', 1)"

                Try
                    CMD.Connection = conn
                    CMD.CommandType = CommandType.Text
                    CMD.CommandText = sql
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    sql = "update tbl_buku "
                    sql &= "set status = 0 where id_buku=" & EIDBuku.Text

                    CMD.Connection = conn
                    CMD.CommandType = CommandType.Text
                    CMD.CommandText = sql
                    CMD.ExecuteNonQuery()

                    EIDBuku.Clear()
                    ENamaBuku.Clear()
                    ESinopsis.Clear()
                    ETahun.Clear()
                    EStatus.Clear()

                    refreshGrid()
                Catch ex As Exception
                    MessageBox.Show("Error saat meyimpan data" & vbNewLine & vbNewLine & ex.Message)
                Finally
                    CMD.Dispose()
                    conn.Close()
                End Try

            End If
        Else
            MessageBox.Show("Pilih siswa beserta buku yang diinginkan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EIDBuku.Focus()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Koneksi()
        If id_peminjaman <> "" And id_buku <> "" Then
            sql = "delete from tbl_peminjaman where id_peminjaman = " & id_peminjaman

            Try
                CMD.Connection = conn
                CMD.CommandType = CommandType.Text
                CMD.CommandText = sql
                CMD.ExecuteNonQuery()

                sql = "update tbl_buku "
                sql &= "set status = 1 where id_buku=" & id_buku

                CMD.Connection = conn
                CMD.CommandType = CommandType.Text
                CMD.CommandText = sql
                CMD.ExecuteNonQuery()

                MessageBox.Show("Buku berhasil di hapus dari tabel", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                EIDBuku.Clear()
                ENamaBuku.Clear()
                ESinopsis.Clear()
                ETahun.Clear()
                EStatus.Clear()

                refreshGrid()
            Catch ex As Exception
                MessageBox.Show("Error saat meyimpan data" & vbNewLine & vbNewLine & ex.Message)
            Finally
                CMD.Dispose()
                conn.Close()
            End Try
        Else
            MessageBox.Show("Belum ada data yang dipilih")
        End If
    End Sub

    Private Sub DG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellClick
        Try
            id_peminjaman = DG.Item(6, e.RowIndex).Value
            id_buku = DG.Item(8, e.RowIndex).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        resetForm()
        refreshGrid()
    End Sub

    Private Sub btnPengembalian_Click(sender As Object, e As EventArgs) Handles btnPengembalian.Click
        btnPeminjaman.Enabled = False
        btnPengembalian.Enabled = False
        btnKembalikan.Enabled = True
        btnHapus.Enabled = False

        GBSiswa.Enabled = True
        GBBuku.Enabled = True
        GBPeminjaman.Enabled = True

        EIDSiswa.Focus()
    End Sub

    Private Sub btnKembalikan_Click(sender As Object, e As EventArgs) Handles btnKembalikan.Click
        Koneksi()
        If id_peminjaman <> "" And id_buku <> "" Then
            If MessageBox.Show("Kembalikan buku yang dipilih?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                sql = "update tbl_peminjaman set flag=0 where id_peminjaman = " & id_peminjaman

                Try
                    CMD.Connection = conn
                    CMD.CommandType = CommandType.Text
                    CMD.CommandText = sql
                    CMD.ExecuteNonQuery()

                    sql = "update tbl_buku "
                    sql &= "set status = 1 where id_buku=" & id_buku

                    CMD.Connection = conn
                    CMD.CommandType = CommandType.Text
                    CMD.CommandText = sql
                    CMD.ExecuteNonQuery()

                    MessageBox.Show("Buku berhasil dikembalikan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    EIDBuku.Clear()
                    ENamaBuku.Clear()
                    ESinopsis.Clear()
                    ETahun.Clear()
                    EStatus.Clear()

                    refreshGrid()
                Catch ex As Exception
                    MessageBox.Show("Error saat meyimpan data" & vbNewLine & vbNewLine & ex.Message)
                Finally
                    CMD.Dispose()
                    conn.Close()
                End Try
            End If
        Else
            MessageBox.Show("Belum ada data yang dipilih")
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        resetForm()
        refreshGrid()
    End Sub
End Class