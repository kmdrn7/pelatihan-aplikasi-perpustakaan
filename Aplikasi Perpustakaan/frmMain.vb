Public Class frmMain
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        frmLogin.ShowDialog(Me)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Koneksi()
        If isConnect Then
        Else
            Me.Close()
        End If

        If isLogin Then
        Else
            MasterToolStripMenuItem.Visible = False
            TransaksiToolStripMenuItem.Visible = False
            frmLogin.ShowDialog(Me)
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiswaToolStripMenuItem.Click
        frmSiswa.ShowDialog(Me)
    End Sub

    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        frmBuku.ShowDialog(Me)
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem.Click
        frmPeminjaman.ShowDialog(Me)
    End Sub
End Class
