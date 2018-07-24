<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSiswa
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
        Me.GBData = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ecari = New System.Windows.Forms.TextBox()
        Me.LJumlah = New System.Windows.Forms.Label()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.GBInfo = New System.Windows.Forms.GroupBox()
        Me.EUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EKelas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ENama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GBAksi = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnBaru = New System.Windows.Forms.Button()
        Me.EPass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.GBData.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBInfo.SuspendLayout()
        Me.GBAksi.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBData
        '
        Me.GBData.Controls.Add(Me.Label2)
        Me.GBData.Controls.Add(Me.Ecari)
        Me.GBData.Controls.Add(Me.LJumlah)
        Me.GBData.Controls.Add(Me.DG)
        Me.GBData.Location = New System.Drawing.Point(12, 12)
        Me.GBData.Name = "GBData"
        Me.GBData.Size = New System.Drawing.Size(490, 370)
        Me.GBData.TabIndex = 0
        Me.GBData.TabStop = False
        Me.GBData.Text = "   Data Siswa   "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pencarian Data"
        '
        'Ecari
        '
        Me.Ecari.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ecari.Location = New System.Drawing.Point(102, 24)
        Me.Ecari.Name = "Ecari"
        Me.Ecari.Size = New System.Drawing.Size(374, 25)
        Me.Ecari.TabIndex = 2
        '
        'LJumlah
        '
        Me.LJumlah.AutoSize = True
        Me.LJumlah.Location = New System.Drawing.Point(12, 348)
        Me.LJumlah.Name = "LJumlah"
        Me.LJumlah.Size = New System.Drawing.Size(79, 13)
        Me.LJumlah.TabIndex = 1
        Me.LJumlah.Text = "Jumlah Data : "
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Location = New System.Drawing.Point(12, 60)
        Me.DG.Name = "DG"
        Me.DG.ReadOnly = True
        Me.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG.Size = New System.Drawing.Size(464, 281)
        Me.DG.TabIndex = 0
        '
        'GBInfo
        '
        Me.GBInfo.Controls.Add(Me.btnSimpan)
        Me.GBInfo.Controls.Add(Me.btnBatal)
        Me.GBInfo.Controls.Add(Me.EPass)
        Me.GBInfo.Controls.Add(Me.Label6)
        Me.GBInfo.Controls.Add(Me.EUser)
        Me.GBInfo.Controls.Add(Me.Label5)
        Me.GBInfo.Controls.Add(Me.EKelas)
        Me.GBInfo.Controls.Add(Me.Label4)
        Me.GBInfo.Controls.Add(Me.ENama)
        Me.GBInfo.Controls.Add(Me.Label3)
        Me.GBInfo.Location = New System.Drawing.Point(515, 12)
        Me.GBInfo.Name = "GBInfo"
        Me.GBInfo.Size = New System.Drawing.Size(273, 370)
        Me.GBInfo.TabIndex = 1
        Me.GBInfo.TabStop = False
        Me.GBInfo.Text = "   Informasi Siswa   "
        '
        'EUser
        '
        Me.EUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EUser.Location = New System.Drawing.Point(19, 142)
        Me.EUser.Name = "EUser"
        Me.EUser.Size = New System.Drawing.Size(233, 25)
        Me.EUser.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Username"
        '
        'EKelas
        '
        Me.EKelas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EKelas.Location = New System.Drawing.Point(19, 91)
        Me.EKelas.Name = "EKelas"
        Me.EKelas.Size = New System.Drawing.Size(233, 25)
        Me.EKelas.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kelas"
        '
        'ENama
        '
        Me.ENama.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENama.Location = New System.Drawing.Point(19, 41)
        Me.ENama.Name = "ENama"
        Me.ENama.Size = New System.Drawing.Size(233, 25)
        Me.ENama.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama"
        '
        'GBAksi
        '
        Me.GBAksi.Controls.Add(Me.btnKeluar)
        Me.GBAksi.Controls.Add(Me.btnHapus)
        Me.GBAksi.Controls.Add(Me.btnUbah)
        Me.GBAksi.Controls.Add(Me.btnBaru)
        Me.GBAksi.Location = New System.Drawing.Point(12, 388)
        Me.GBAksi.Name = "GBAksi"
        Me.GBAksi.Size = New System.Drawing.Size(776, 64)
        Me.GBAksi.TabIndex = 2
        Me.GBAksi.TabStop = False
        Me.GBAksi.Text = "   Aksi   "
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(663, 18)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(102, 35)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(227, 19)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(102, 35)
        Me.btnHapus.TabIndex = 2
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Location = New System.Drawing.Point(119, 19)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(102, 35)
        Me.btnUbah.TabIndex = 1
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnBaru
        '
        Me.btnBaru.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaru.Location = New System.Drawing.Point(11, 18)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(102, 35)
        Me.btnBaru.TabIndex = 0
        Me.btnBaru.Text = "Baru"
        Me.btnBaru.UseVisualStyleBackColor = True
        '
        'EPass
        '
        Me.EPass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EPass.Location = New System.Drawing.Point(19, 194)
        Me.EPass.Name = "EPass"
        Me.EPass.Size = New System.Drawing.Size(233, 25)
        Me.EPass.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Password"
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(19, 326)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(84, 35)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(109, 326)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(143, 35)
        Me.btnSimpan.TabIndex = 13
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'frmSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 464)
        Me.Controls.Add(Me.GBAksi)
        Me.Controls.Add(Me.GBInfo)
        Me.Controls.Add(Me.GBData)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSiswa"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Siswa"
        Me.GBData.ResumeLayout(False)
        Me.GBData.PerformLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBInfo.ResumeLayout(False)
        Me.GBInfo.PerformLayout()
        Me.GBAksi.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBData As GroupBox
    Friend WithEvents GBInfo As GroupBox
    Friend WithEvents GBAksi As GroupBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnBaru As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Ecari As TextBox
    Friend WithEvents LJumlah As Label
    Friend WithEvents DG As DataGridView
    Friend WithEvents EUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EKelas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ENama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents EPass As TextBox
    Friend WithEvents Label6 As Label
End Class
