<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputNilai
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
        Me.components = New System.ComponentModel.Container()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.groupBoxCariSiswa = New System.Windows.Forms.GroupBox()
        Me.textBoxJenisKelamin = New System.Windows.Forms.TextBox()
        Me.labelJenisKelamin = New System.Windows.Forms.Label()
        Me.textBoxKelas = New System.Windows.Forms.TextBox()
        Me.labelKelas = New System.Windows.Forms.Label()
        Me.textBoxNama = New System.Windows.Forms.TextBox()
        Me.labelNama = New System.Windows.Forms.Label()
        Me.buttonCariNIM = New System.Windows.Forms.Button()
        Me.textBoxCariNIM = New System.Windows.Forms.TextBox()
        Me.labelCariNIM = New System.Windows.Forms.Label()
        Me.groupBoxInputNilai = New System.Windows.Forms.GroupBox()
        Me.textBoxUAS = New System.Windows.Forms.TextBox()
        Me.labelUAS = New System.Windows.Forms.Label()
        Me.textBoxUTS = New System.Windows.Forms.TextBox()
        Me.labelUTS = New System.Windows.Forms.Label()
        Me.textBoxTugas = New System.Windows.Forms.TextBox()
        Me.labelTugas = New System.Windows.Forms.Label()
        Me.textBoxKehadiran = New System.Windows.Forms.TextBox()
        Me.labelKehadiran = New System.Windows.Forms.Label()
        Me.groupBoxHasil = New System.Windows.Forms.GroupBox()
        Me.textBoxNilaiAkhir = New System.Windows.Forms.TextBox()
        Me.labelNilaiAkhir = New System.Windows.Forms.Label()
        Me.textBoxTotal = New System.Windows.Forms.TextBox()
        Me.labelTotal = New System.Windows.Forms.Label()
        Me.buttonReset = New System.Windows.Forms.Button()
        Me.buttonHitung = New System.Windows.Forms.Button()
        Me.buttonSimpan = New System.Windows.Forms.Button()
        Me.tooltipKehadiran = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltipTugas = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltipUTS = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltipUAS = New System.Windows.Forms.ToolTip(Me.components)
        Me.groupBoxCariSiswa.SuspendLayout()
        Me.groupBoxInputNilai.SuspendLayout()
        Me.groupBoxHasil.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTitle
        '
        Me.labelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.Location = New System.Drawing.Point(0, 0)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(784, 40)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "INPUT NILAI SISWA"
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupBoxCariSiswa
        '
        Me.groupBoxCariSiswa.Controls.Add(Me.textBoxJenisKelamin)
        Me.groupBoxCariSiswa.Controls.Add(Me.labelJenisKelamin)
        Me.groupBoxCariSiswa.Controls.Add(Me.textBoxKelas)
        Me.groupBoxCariSiswa.Controls.Add(Me.labelKelas)
        Me.groupBoxCariSiswa.Controls.Add(Me.textBoxNama)
        Me.groupBoxCariSiswa.Controls.Add(Me.labelNama)
        Me.groupBoxCariSiswa.Controls.Add(Me.buttonCariNIM)
        Me.groupBoxCariSiswa.Controls.Add(Me.textBoxCariNIM)
        Me.groupBoxCariSiswa.Controls.Add(Me.labelCariNIM)
        Me.groupBoxCariSiswa.Location = New System.Drawing.Point(203, 58)
        Me.groupBoxCariSiswa.Name = "groupBoxCariSiswa"
        Me.groupBoxCariSiswa.Size = New System.Drawing.Size(374, 150)
        Me.groupBoxCariSiswa.TabIndex = 1
        Me.groupBoxCariSiswa.TabStop = False
        Me.groupBoxCariSiswa.Text = "CARI SISWA"
        '
        'textBoxJenisKelamin
        '
        Me.textBoxJenisKelamin.Location = New System.Drawing.Point(104, 108)
        Me.textBoxJenisKelamin.Name = "textBoxJenisKelamin"
        Me.textBoxJenisKelamin.ReadOnly = True
        Me.textBoxJenisKelamin.Size = New System.Drawing.Size(187, 23)
        Me.textBoxJenisKelamin.TabIndex = 8
        '
        'labelJenisKelamin
        '
        Me.labelJenisKelamin.AutoSize = True
        Me.labelJenisKelamin.Location = New System.Drawing.Point(7, 112)
        Me.labelJenisKelamin.Name = "labelJenisKelamin"
        Me.labelJenisKelamin.Size = New System.Drawing.Size(91, 15)
        Me.labelJenisKelamin.TabIndex = 7
        Me.labelJenisKelamin.Text = "JENIS KELAMIN:"
        '
        'textBoxKelas
        '
        Me.textBoxKelas.Location = New System.Drawing.Point(104, 79)
        Me.textBoxKelas.Name = "textBoxKelas"
        Me.textBoxKelas.ReadOnly = True
        Me.textBoxKelas.Size = New System.Drawing.Size(187, 23)
        Me.textBoxKelas.TabIndex = 6
        '
        'labelKelas
        '
        Me.labelKelas.AutoSize = True
        Me.labelKelas.Location = New System.Drawing.Point(7, 83)
        Me.labelKelas.Name = "labelKelas"
        Me.labelKelas.Size = New System.Drawing.Size(43, 15)
        Me.labelKelas.TabIndex = 5
        Me.labelKelas.Text = "KELAS:"
        '
        'textBoxNama
        '
        Me.textBoxNama.Location = New System.Drawing.Point(104, 50)
        Me.textBoxNama.Name = "textBoxNama"
        Me.textBoxNama.ReadOnly = True
        Me.textBoxNama.Size = New System.Drawing.Size(187, 23)
        Me.textBoxNama.TabIndex = 4
        '
        'labelNama
        '
        Me.labelNama.AutoSize = True
        Me.labelNama.Location = New System.Drawing.Point(7, 54)
        Me.labelNama.Name = "labelNama"
        Me.labelNama.Size = New System.Drawing.Size(46, 15)
        Me.labelNama.TabIndex = 3
        Me.labelNama.Text = "NAMA:"
        '
        'buttonCariNIM
        '
        Me.buttonCariNIM.Location = New System.Drawing.Point(297, 22)
        Me.buttonCariNIM.Name = "buttonCariNIM"
        Me.buttonCariNIM.Size = New System.Drawing.Size(61, 24)
        Me.buttonCariNIM.TabIndex = 2
        Me.buttonCariNIM.Text = "CARI"
        Me.buttonCariNIM.UseVisualStyleBackColor = True
        '
        'textBoxCariNIM
        '
        Me.textBoxCariNIM.Location = New System.Drawing.Point(104, 23)
        Me.textBoxCariNIM.Name = "textBoxCariNIM"
        Me.textBoxCariNIM.Size = New System.Drawing.Size(187, 23)
        Me.textBoxCariNIM.TabIndex = 1
        '
        'labelCariNIM
        '
        Me.labelCariNIM.AutoSize = True
        Me.labelCariNIM.Location = New System.Drawing.Point(9, 28)
        Me.labelCariNIM.Name = "labelCariNIM"
        Me.labelCariNIM.Size = New System.Drawing.Size(33, 15)
        Me.labelCariNIM.TabIndex = 0
        Me.labelCariNIM.Text = "NIM:"
        '
        'groupBoxInputNilai
        '
        Me.groupBoxInputNilai.Controls.Add(Me.textBoxUAS)
        Me.groupBoxInputNilai.Controls.Add(Me.labelUAS)
        Me.groupBoxInputNilai.Controls.Add(Me.textBoxUTS)
        Me.groupBoxInputNilai.Controls.Add(Me.labelUTS)
        Me.groupBoxInputNilai.Controls.Add(Me.textBoxTugas)
        Me.groupBoxInputNilai.Controls.Add(Me.labelTugas)
        Me.groupBoxInputNilai.Controls.Add(Me.textBoxKehadiran)
        Me.groupBoxInputNilai.Controls.Add(Me.labelKehadiran)
        Me.groupBoxInputNilai.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxInputNilai.Location = New System.Drawing.Point(127, 231)
        Me.groupBoxInputNilai.Name = "groupBoxInputNilai"
        Me.groupBoxInputNilai.Size = New System.Drawing.Size(258, 165)
        Me.groupBoxInputNilai.TabIndex = 2
        Me.groupBoxInputNilai.TabStop = False
        Me.groupBoxInputNilai.Text = "INPUT NILAI"
        '
        'textBoxUAS
        '
        Me.textBoxUAS.Location = New System.Drawing.Point(113, 131)
        Me.textBoxUAS.Name = "textBoxUAS"
        Me.textBoxUAS.Size = New System.Drawing.Size(100, 25)
        Me.textBoxUAS.TabIndex = 7
        '
        'labelUAS
        '
        Me.labelUAS.AutoSize = True
        Me.labelUAS.Location = New System.Drawing.Point(12, 131)
        Me.labelUAS.Name = "labelUAS"
        Me.labelUAS.Size = New System.Drawing.Size(76, 19)
        Me.labelUAS.TabIndex = 6
        Me.labelUAS.Text = "Nilai UAS : "
        '
        'textBoxUTS
        '
        Me.textBoxUTS.Location = New System.Drawing.Point(113, 100)
        Me.textBoxUTS.Name = "textBoxUTS"
        Me.textBoxUTS.Size = New System.Drawing.Size(100, 25)
        Me.textBoxUTS.TabIndex = 5
        '
        'labelUTS
        '
        Me.labelUTS.AutoSize = True
        Me.labelUTS.Location = New System.Drawing.Point(12, 100)
        Me.labelUTS.Name = "labelUTS"
        Me.labelUTS.Size = New System.Drawing.Size(74, 19)
        Me.labelUTS.TabIndex = 4
        Me.labelUTS.Text = "Nilai UTS : "
        '
        'textBoxTugas
        '
        Me.textBoxTugas.Location = New System.Drawing.Point(113, 69)
        Me.textBoxTugas.Name = "textBoxTugas"
        Me.textBoxTugas.Size = New System.Drawing.Size(100, 25)
        Me.textBoxTugas.TabIndex = 3
        '
        'labelTugas
        '
        Me.labelTugas.AutoSize = True
        Me.labelTugas.Location = New System.Drawing.Point(12, 69)
        Me.labelTugas.Name = "labelTugas"
        Me.labelTugas.Size = New System.Drawing.Size(86, 19)
        Me.labelTugas.TabIndex = 2
        Me.labelTugas.Text = "Nilai Tugas : "
        '
        'textBoxKehadiran
        '
        Me.textBoxKehadiran.Location = New System.Drawing.Point(113, 38)
        Me.textBoxKehadiran.Name = "textBoxKehadiran"
        Me.textBoxKehadiran.Size = New System.Drawing.Size(100, 25)
        Me.textBoxKehadiran.TabIndex = 1
        Me.tooltipUAS.SetToolTip(Me.textBoxKehadiran, "Masukan angka 1-100")
        Me.tooltipTugas.SetToolTip(Me.textBoxKehadiran, "Masukan angka 1-100")
        Me.tooltipKehadiran.SetToolTip(Me.textBoxKehadiran, "Masukan angka 1-100")
        Me.tooltipUTS.SetToolTip(Me.textBoxKehadiran, "Masukan angka 1-100")
        '
        'labelKehadiran
        '
        Me.labelKehadiran.AutoSize = True
        Me.labelKehadiran.Location = New System.Drawing.Point(12, 40)
        Me.labelKehadiran.Name = "labelKehadiran"
        Me.labelKehadiran.Size = New System.Drawing.Size(104, 19)
        Me.labelKehadiran.TabIndex = 0
        Me.labelKehadiran.Text = "Kehadiran (%) : "
        '
        'groupBoxHasil
        '
        Me.groupBoxHasil.Controls.Add(Me.textBoxNilaiAkhir)
        Me.groupBoxHasil.Controls.Add(Me.labelNilaiAkhir)
        Me.groupBoxHasil.Controls.Add(Me.textBoxTotal)
        Me.groupBoxHasil.Controls.Add(Me.labelTotal)
        Me.groupBoxHasil.Location = New System.Drawing.Point(438, 231)
        Me.groupBoxHasil.Name = "groupBoxHasil"
        Me.groupBoxHasil.Size = New System.Drawing.Size(239, 119)
        Me.groupBoxHasil.TabIndex = 3
        Me.groupBoxHasil.TabStop = False
        Me.groupBoxHasil.Text = "HASIL NILAI"
        '
        'textBoxNilaiAkhir
        '
        Me.textBoxNilaiAkhir.Location = New System.Drawing.Point(81, 65)
        Me.textBoxNilaiAkhir.Name = "textBoxNilaiAkhir"
        Me.textBoxNilaiAkhir.ReadOnly = True
        Me.textBoxNilaiAkhir.Size = New System.Drawing.Size(100, 23)
        Me.textBoxNilaiAkhir.TabIndex = 9
        '
        'labelNilaiAkhir
        '
        Me.labelNilaiAkhir.AutoSize = True
        Me.labelNilaiAkhir.Location = New System.Drawing.Point(6, 69)
        Me.labelNilaiAkhir.Name = "labelNilaiAkhir"
        Me.labelNilaiAkhir.Size = New System.Drawing.Size(71, 15)
        Me.labelNilaiAkhir.TabIndex = 8
        Me.labelNilaiAkhir.Text = "Nilai Akhir : "
        '
        'textBoxTotal
        '
        Me.textBoxTotal.Location = New System.Drawing.Point(81, 38)
        Me.textBoxTotal.Name = "textBoxTotal"
        Me.textBoxTotal.ReadOnly = True
        Me.textBoxTotal.Size = New System.Drawing.Size(100, 23)
        Me.textBoxTotal.TabIndex = 7
        '
        'labelTotal
        '
        Me.labelTotal.AutoSize = True
        Me.labelTotal.Location = New System.Drawing.Point(6, 44)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(69, 15)
        Me.labelTotal.TabIndex = 6
        Me.labelTotal.Text = "Total Nilai : "
        '
        'buttonReset
        '
        Me.buttonReset.Location = New System.Drawing.Point(438, 360)
        Me.buttonReset.Name = "buttonReset"
        Me.buttonReset.Size = New System.Drawing.Size(75, 23)
        Me.buttonReset.TabIndex = 4
        Me.buttonReset.Text = "RESET"
        Me.buttonReset.UseVisualStyleBackColor = True
        '
        'buttonHitung
        '
        Me.buttonHitung.Location = New System.Drawing.Point(521, 360)
        Me.buttonHitung.Name = "buttonHitung"
        Me.buttonHitung.Size = New System.Drawing.Size(75, 23)
        Me.buttonHitung.TabIndex = 5
        Me.buttonHitung.Text = "HITUNG"
        Me.buttonHitung.UseVisualStyleBackColor = True
        '
        'buttonSimpan
        '
        Me.buttonSimpan.Location = New System.Drawing.Point(602, 360)
        Me.buttonSimpan.Name = "buttonSimpan"
        Me.buttonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.buttonSimpan.TabIndex = 6
        Me.buttonSimpan.Text = "SIMPAN"
        Me.buttonSimpan.UseVisualStyleBackColor = True
        '
        'tooltipKehadiran
        '
        Me.tooltipKehadiran.ToolTipTitle = "Masukan angka 1-100"
        '
        'tooltipTugas
        '
        Me.tooltipTugas.ToolTipTitle = "Masukan angka 1-100"
        '
        'tooltipUTS
        '
        Me.tooltipUTS.Tag = "Masukan angka 1-100"
        '
        'tooltipUAS
        '
        Me.tooltipUAS.Tag = "Masukan angka 1-100"
        '
        'FormInputNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 511)
        Me.Controls.Add(Me.buttonSimpan)
        Me.Controls.Add(Me.buttonHitung)
        Me.Controls.Add(Me.buttonReset)
        Me.Controls.Add(Me.groupBoxHasil)
        Me.Controls.Add(Me.groupBoxInputNilai)
        Me.Controls.Add(Me.groupBoxCariSiswa)
        Me.Controls.Add(Me.labelTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormInputNilai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Input Nilai Siswa"
        Me.groupBoxCariSiswa.ResumeLayout(False)
        Me.groupBoxCariSiswa.PerformLayout()
        Me.groupBoxInputNilai.ResumeLayout(False)
        Me.groupBoxInputNilai.PerformLayout()
        Me.groupBoxHasil.ResumeLayout(False)
        Me.groupBoxHasil.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents labelTitle As Label
    Friend WithEvents groupBoxCariSiswa As GroupBox
    Friend WithEvents labelNama As Label
    Friend WithEvents buttonCariNIM As Button
    Friend WithEvents textBoxCariNIM As TextBox
    Friend WithEvents labelCariNIM As Label
    Friend WithEvents textBoxNama As TextBox
    Friend WithEvents textBoxKelas As TextBox
    Friend WithEvents labelKelas As Label
    Friend WithEvents textBoxJenisKelamin As TextBox
    Friend WithEvents labelJenisKelamin As Label
    Friend WithEvents groupBoxInputNilai As GroupBox
    Friend WithEvents textBoxUTS As TextBox
    Friend WithEvents labelUTS As Label
    Friend WithEvents textBoxTugas As TextBox
    Friend WithEvents labelTugas As Label
    Friend WithEvents textBoxKehadiran As TextBox
    Friend WithEvents labelKehadiran As Label
    Friend WithEvents groupBoxHasil As GroupBox
    Friend WithEvents textBoxNilaiAkhir As TextBox
    Friend WithEvents labelNilaiAkhir As Label
    Friend WithEvents textBoxTotal As TextBox
    Friend WithEvents labelTotal As Label
    Friend WithEvents textBoxUAS As TextBox
    Friend WithEvents labelUAS As Label
    Friend WithEvents buttonReset As Button
    Friend WithEvents buttonHitung As Button
    Friend WithEvents buttonSimpan As Button
    Friend WithEvents tooltipKehadiran As ToolTip
    Friend WithEvents tooltipTugas As ToolTip
    Friend WithEvents tooltipUTS As ToolTip
    Friend WithEvents tooltipUAS As ToolTip
End Class
