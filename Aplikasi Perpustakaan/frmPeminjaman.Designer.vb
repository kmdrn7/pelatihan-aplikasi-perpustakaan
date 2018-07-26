<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeminjaman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GBSiswa = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GBBuku = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ENamaSiswa = New System.Windows.Forms.TextBox()
        Me.btnCariSiswa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EKelas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ESinopsis = New System.Windows.Forms.TextBox()
        Me.btnCariBuku = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ENamaBuku = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ETahun = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EStatus = New System.Windows.Forms.TextBox()
        Me.GBAksi = New System.Windows.Forms.GroupBox()
        Me.btnPeminjaman = New System.Windows.Forms.Button()
        Me.btnPengembalian = New System.Windows.Forms.Button()
        Me.GBPeminjaman = New System.Windows.Forms.GroupBox()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnKembalikan = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EIDSiswa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EIDBuku = New System.Windows.Forms.TextBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DTTglKembali = New System.Windows.Forms.DateTimePicker()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.GBSiswa.SuspendLayout()
        Me.GBBuku.SuspendLayout()
        Me.GBAksi.SuspendLayout()
        Me.GBPeminjaman.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBSiswa
        '
        Me.GBSiswa.Controls.Add(Me.Label7)
        Me.GBSiswa.Controls.Add(Me.EIDSiswa)
        Me.GBSiswa.Controls.Add(Me.Label1)
        Me.GBSiswa.Controls.Add(Me.EKelas)
        Me.GBSiswa.Controls.Add(Me.btnCariSiswa)
        Me.GBSiswa.Controls.Add(Me.Label2)
        Me.GBSiswa.Controls.Add(Me.ENamaSiswa)
        Me.GBSiswa.Controls.Add(Me.GroupBox2)
        Me.GBSiswa.Location = New System.Drawing.Point(12, 12)
        Me.GBSiswa.Name = "GBSiswa"
        Me.GBSiswa.Size = New System.Drawing.Size(396, 230)
        Me.GBSiswa.TabIndex = 0
        Me.GBSiswa.TabStop = False
        Me.GBSiswa.Text = "   Data Siswa"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(471, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 300)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GBBuku
        '
        Me.GBBuku.Controls.Add(Me.DTTglKembali)
        Me.GBBuku.Controls.Add(Me.Label9)
        Me.GBBuku.Controls.Add(Me.Label8)
        Me.GBBuku.Controls.Add(Me.EIDBuku)
        Me.GBBuku.Controls.Add(Me.btnTambah)
        Me.GBBuku.Controls.Add(Me.Label6)
        Me.GBBuku.Controls.Add(Me.EStatus)
        Me.GBBuku.Controls.Add(Me.Label5)
        Me.GBBuku.Controls.Add(Me.ETahun)
        Me.GBBuku.Controls.Add(Me.Label3)
        Me.GBBuku.Controls.Add(Me.ESinopsis)
        Me.GBBuku.Controls.Add(Me.btnCariBuku)
        Me.GBBuku.Controls.Add(Me.Label4)
        Me.GBBuku.Controls.Add(Me.ENamaBuku)
        Me.GBBuku.Controls.Add(Me.GroupBox4)
        Me.GBBuku.Location = New System.Drawing.Point(418, 12)
        Me.GBBuku.Name = "GBBuku"
        Me.GBBuku.Size = New System.Drawing.Size(390, 230)
        Me.GBBuku.TabIndex = 2
        Me.GBBuku.TabStop = False
        Me.GBBuku.Text = "   Data Buku   "
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(471, 87)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(280, 300)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Siswa"
        '
        'ENamaSiswa
        '
        Me.ENamaSiswa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENamaSiswa.Location = New System.Drawing.Point(17, 92)
        Me.ENamaSiswa.Name = "ENamaSiswa"
        Me.ENamaSiswa.ReadOnly = True
        Me.ENamaSiswa.Size = New System.Drawing.Size(288, 25)
        Me.ENamaSiswa.TabIndex = 4
        '
        'btnCariSiswa
        '
        Me.btnCariSiswa.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariSiswa.Location = New System.Drawing.Point(313, 44)
        Me.btnCariSiswa.Name = "btnCariSiswa"
        Me.btnCariSiswa.Size = New System.Drawing.Size(70, 26)
        Me.btnCariSiswa.TabIndex = 13
        Me.btnCariSiswa.Text = "Cari"
        Me.btnCariSiswa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Kelas"
        '
        'EKelas
        '
        Me.EKelas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EKelas.Location = New System.Drawing.Point(17, 140)
        Me.EKelas.Name = "EKelas"
        Me.EKelas.ReadOnly = True
        Me.EKelas.Size = New System.Drawing.Size(288, 25)
        Me.EKelas.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Sinopsis"
        '
        'ESinopsis
        '
        Me.ESinopsis.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESinopsis.Location = New System.Drawing.Point(17, 140)
        Me.ESinopsis.Name = "ESinopsis"
        Me.ESinopsis.ReadOnly = True
        Me.ESinopsis.Size = New System.Drawing.Size(178, 25)
        Me.ESinopsis.TabIndex = 19
        '
        'btnCariBuku
        '
        Me.btnCariBuku.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariBuku.Location = New System.Drawing.Point(309, 44)
        Me.btnCariBuku.Name = "btnCariBuku"
        Me.btnCariBuku.Size = New System.Drawing.Size(70, 26)
        Me.btnCariBuku.TabIndex = 18
        Me.btnCariBuku.Text = "Cari"
        Me.btnCariBuku.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nama Buku"
        '
        'ENamaBuku
        '
        Me.ENamaBuku.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENamaBuku.Location = New System.Drawing.Point(17, 94)
        Me.ENamaBuku.Name = "ENamaBuku"
        Me.ENamaBuku.ReadOnly = True
        Me.ENamaBuku.Size = New System.Drawing.Size(180, 25)
        Me.ENamaBuku.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(204, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Tahun"
        '
        'ETahun
        '
        Me.ETahun.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ETahun.Location = New System.Drawing.Point(207, 94)
        Me.ETahun.Name = "ETahun"
        Me.ETahun.ReadOnly = True
        Me.ETahun.Size = New System.Drawing.Size(172, 25)
        Me.ETahun.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(204, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Status"
        '
        'EStatus
        '
        Me.EStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EStatus.Location = New System.Drawing.Point(207, 140)
        Me.EStatus.Name = "EStatus"
        Me.EStatus.ReadOnly = True
        Me.EStatus.Size = New System.Drawing.Size(172, 25)
        Me.EStatus.TabIndex = 23
        '
        'GBAksi
        '
        Me.GBAksi.Controls.Add(Me.btnKeluar)
        Me.GBAksi.Controls.Add(Me.btnPengembalian)
        Me.GBAksi.Controls.Add(Me.btnPeminjaman)
        Me.GBAksi.Location = New System.Drawing.Point(12, 430)
        Me.GBAksi.Name = "GBAksi"
        Me.GBAksi.Size = New System.Drawing.Size(796, 70)
        Me.GBAksi.TabIndex = 3
        Me.GBAksi.TabStop = False
        Me.GBAksi.Text = "   Aksi   "
        '
        'btnPeminjaman
        '
        Me.btnPeminjaman.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeminjaman.Location = New System.Drawing.Point(17, 21)
        Me.btnPeminjaman.Name = "btnPeminjaman"
        Me.btnPeminjaman.Size = New System.Drawing.Size(140, 35)
        Me.btnPeminjaman.TabIndex = 1
        Me.btnPeminjaman.Text = "Peminjaman"
        Me.btnPeminjaman.UseVisualStyleBackColor = True
        '
        'btnPengembalian
        '
        Me.btnPengembalian.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPengembalian.Location = New System.Drawing.Point(163, 21)
        Me.btnPengembalian.Name = "btnPengembalian"
        Me.btnPengembalian.Size = New System.Drawing.Size(133, 35)
        Me.btnPengembalian.TabIndex = 2
        Me.btnPengembalian.Text = "Pengembalian"
        Me.btnPengembalian.UseVisualStyleBackColor = True
        '
        'GBPeminjaman
        '
        Me.GBPeminjaman.Controls.Add(Me.btnBatal)
        Me.GBPeminjaman.Controls.Add(Me.btnHapus)
        Me.GBPeminjaman.Controls.Add(Me.btnSimpan)
        Me.GBPeminjaman.Controls.Add(Me.btnKembalikan)
        Me.GBPeminjaman.Controls.Add(Me.DG)
        Me.GBPeminjaman.Location = New System.Drawing.Point(12, 248)
        Me.GBPeminjaman.Name = "GBPeminjaman"
        Me.GBPeminjaman.Size = New System.Drawing.Size(796, 176)
        Me.GBPeminjaman.TabIndex = 4
        Me.GBPeminjaman.TabStop = False
        Me.GBPeminjaman.Text = "   Data Peminjaman   "
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Location = New System.Drawing.Point(17, 49)
        Me.DG.MultiSelect = False
        Me.DG.Name = "DG"
        Me.DG.ReadOnly = True
        Me.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG.Size = New System.Drawing.Size(766, 110)
        Me.DG.TabIndex = 0
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(206, 175)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(173, 40)
        Me.btnTambah.TabIndex = 25
        Me.btnTambah.Text = "Tambahkan"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnKembalikan
        '
        Me.btnKembalikan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembalikan.Location = New System.Drawing.Point(296, 17)
        Me.btnKembalikan.Name = "btnKembalikan"
        Me.btnKembalikan.Size = New System.Drawing.Size(99, 26)
        Me.btnKembalikan.TabIndex = 14
        Me.btnKembalikan.Text = "Kembalikan"
        Me.btnKembalikan.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(199, 17)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(87, 26)
        Me.btnSimpan.TabIndex = 15
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(650, 21)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(133, 35)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "ID Siswa"
        '
        'EIDSiswa
        '
        Me.EIDSiswa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EIDSiswa.Location = New System.Drawing.Point(17, 44)
        Me.EIDSiswa.Name = "EIDSiswa"
        Me.EIDSiswa.ReadOnly = True
        Me.EIDSiswa.Size = New System.Drawing.Size(288, 25)
        Me.EIDSiswa.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "ID Buku"
        '
        'EIDBuku
        '
        Me.EIDBuku.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EIDBuku.Location = New System.Drawing.Point(17, 44)
        Me.EIDBuku.Name = "EIDBuku"
        Me.EIDBuku.ReadOnly = True
        Me.EIDBuku.Size = New System.Drawing.Size(286, 25)
        Me.EIDBuku.TabIndex = 26
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(406, 17)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(99, 26)
        Me.btnHapus.TabIndex = 16
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Tanggal Kembali"
        '
        'DTTglKembali
        '
        Me.DTTglKembali.Location = New System.Drawing.Point(17, 193)
        Me.DTTglKembali.Name = "DTTglKembali"
        Me.DTTglKembali.Size = New System.Drawing.Size(178, 22)
        Me.DTTglKembali.TabIndex = 30
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(516, 17)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(99, 26)
        Me.btnBatal.TabIndex = 17
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'frmPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 512)
        Me.Controls.Add(Me.GBPeminjaman)
        Me.Controls.Add(Me.GBAksi)
        Me.Controls.Add(Me.GBBuku)
        Me.Controls.Add(Me.GBSiswa)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPeminjaman"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peminjaman"
        Me.GBSiswa.ResumeLayout(False)
        Me.GBSiswa.PerformLayout()
        Me.GBBuku.ResumeLayout(False)
        Me.GBBuku.PerformLayout()
        Me.GBAksi.ResumeLayout(False)
        Me.GBPeminjaman.ResumeLayout(False)
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBSiswa As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GBBuku As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ENamaSiswa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EKelas As TextBox
    Friend WithEvents btnCariSiswa As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents EStatus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ETahun As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ESinopsis As TextBox
    Friend WithEvents btnCariBuku As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ENamaBuku As TextBox
    Friend WithEvents GBAksi As GroupBox
    Friend WithEvents btnPengembalian As Button
    Friend WithEvents btnPeminjaman As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents GBPeminjaman As GroupBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnKembalikan As Button
    Friend WithEvents DG As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents EIDSiswa As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents EIDBuku As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents DTTglKembali As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBatal As Button
End Class
