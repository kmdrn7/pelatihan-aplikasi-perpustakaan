Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Euser.Text <> "" And Epass.Text <> "" Then
            Koneksi()
            Dim sql As String = "SELECT * FROM tbl_admin WHERE username='" & Euser.Text & "' AND password ='" & Epass.Text & "'"
            Try
                CMD.Connection = conn
                CMD.CommandType = CommandType.Text
                CMD.CommandText = sql

                DT.Clear()
                DA.SelectCommand = CMD
                DA.Fill(DT)

                If DT.Rows.Count > 0 Then
                    MessageBox.Show("Selamat datang " & Euser.Text)
                    Me.Close()
                    frmMain.MasterToolStripMenuItem.Visible = True
                    frmMain.TransaksiToolStripMenuItem.Visible = True
                End If
            Catch ex As Exception
                MessageBox.Show("Error saat login" & vbNewLine & vbNewLine & ex.Message)
            Finally
                CMD.Dispose()
                conn.Close()
                DA.Dispose()
            End Try
        Else
            MessageBox.Show("Username dan password tidak boleh kosong")
        End If
    End Sub
End Class