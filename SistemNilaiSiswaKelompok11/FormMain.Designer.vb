<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDataSiswa = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInputNilai = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAboutApp = New System.Windows.Forms.ToolStripMenuItem()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.labelSubTitle = New System.Windows.Forms.Label()
        Me.buttonDataSiswa = New System.Windows.Forms.Button()
        Me.buttonInputNilai = New System.Windows.Forms.Button()
        Me.labelLaporan = New System.Windows.Forms.Label()
        Me.dgvNilai = New System.Windows.Forms.DataGridView()
        Me.columnNIM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnJenisKelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnKelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnKehadiran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnTugas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnUTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnUAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnTotalNilai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNilaiAkhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelLaporan = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvNilai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLaporan.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.menuTools, Me.menuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1912, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFileExit})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(37, 20)
        Me.menuFile.Text = "File"
        '
        'menuFileExit
        '
        Me.menuFileExit.Name = "menuFileExit"
        Me.menuFileExit.Size = New System.Drawing.Size(180, 22)
        Me.menuFileExit.Text = "Exit"
        '
        'menuTools
        '
        Me.menuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDataSiswa, Me.menuInputNilai})
        Me.menuTools.Name = "menuTools"
        Me.menuTools.Size = New System.Drawing.Size(47, 20)
        Me.menuTools.Text = "Tools"
        '
        'menuDataSiswa
        '
        Me.menuDataSiswa.Name = "menuDataSiswa"
        Me.menuDataSiswa.Size = New System.Drawing.Size(180, 22)
        Me.menuDataSiswa.Text = "Data Siswa"
        '
        'menuInputNilai
        '
        Me.menuInputNilai.Name = "menuInputNilai"
        Me.menuInputNilai.Size = New System.Drawing.Size(180, 22)
        Me.menuInputNilai.Text = "Input Nilai"
        '
        'menuHelp
        '
        Me.menuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuAboutApp})
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New System.Drawing.Size(44, 20)
        Me.menuHelp.Text = "Help"
        '
        'menuAboutApp
        '
        Me.menuAboutApp.Name = "menuAboutApp"
        Me.menuAboutApp.Size = New System.Drawing.Size(132, 22)
        Me.menuAboutApp.Text = "About App"
        '
        'labelTitle
        '
        Me.labelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.labelTitle.Location = New System.Drawing.Point(0, 24)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(1912, 50)
        Me.labelTitle.TabIndex = 1
        Me.labelTitle.Text = "SISTEM INFORMASI NILAI SISWA"
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelSubTitle
        '
        Me.labelSubTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelSubTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.labelSubTitle.Location = New System.Drawing.Point(0, 74)
        Me.labelSubTitle.Name = "labelSubTitle"
        Me.labelSubTitle.Size = New System.Drawing.Size(1912, 25)
        Me.labelSubTitle.TabIndex = 2
        Me.labelSubTitle.Text = "E D U C A T I O N   M A N A G E M E N T"
        Me.labelSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buttonDataSiswa
        '
        Me.buttonDataSiswa.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.buttonDataSiswa.Location = New System.Drawing.Point(753, 139)
        Me.buttonDataSiswa.Margin = New System.Windows.Forms.Padding(40)
        Me.buttonDataSiswa.Name = "buttonDataSiswa"
        Me.buttonDataSiswa.Size = New System.Drawing.Size(140, 40)
        Me.buttonDataSiswa.TabIndex = 3
        Me.buttonDataSiswa.Text = "Manage Siswa"
        Me.buttonDataSiswa.UseVisualStyleBackColor = True
        '
        'buttonInputNilai
        '
        Me.buttonInputNilai.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.buttonInputNilai.Location = New System.Drawing.Point(1043, 139)
        Me.buttonInputNilai.Margin = New System.Windows.Forms.Padding(40)
        Me.buttonInputNilai.Name = "buttonInputNilai"
        Me.buttonInputNilai.Size = New System.Drawing.Size(140, 40)
        Me.buttonInputNilai.TabIndex = 4
        Me.buttonInputNilai.Text = "Input Nilai"
        Me.buttonInputNilai.UseVisualStyleBackColor = True
        '
        'labelLaporan
        '
        Me.labelLaporan.AutoSize = True
        Me.labelLaporan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.labelLaporan.Location = New System.Drawing.Point(31, 9)
        Me.labelLaporan.Name = "labelLaporan"
        Me.labelLaporan.Size = New System.Drawing.Size(184, 21)
        Me.labelLaporan.TabIndex = 5
        Me.labelLaporan.Text = "LAPORAN NILAI SISWA"
        '
        'dgvNilai
        '
        Me.dgvNilai.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvNilai.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNilai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNilai.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNilai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnNIM, Me.columnNama, Me.columnJenisKelamin, Me.columnKelas, Me.columnKehadiran, Me.columnTugas, Me.columnUTS, Me.columnUAS, Me.columnTotalNilai, Me.columnNilaiAkhir})
        Me.dgvNilai.EnableHeadersVisualStyles = False
        Me.dgvNilai.Location = New System.Drawing.Point(35, 47)
        Me.dgvNilai.Name = "dgvNilai"
        Me.dgvNilai.ReadOnly = True
        Me.dgvNilai.RowHeadersVisible = False
        Me.dgvNilai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNilai.Size = New System.Drawing.Size(1840, 255)
        Me.dgvNilai.TabIndex = 6
        '
        'columnNIM
        '
        Me.columnNIM.HeaderText = "NIM"
        Me.columnNIM.MinimumWidth = 150
        Me.columnNIM.Name = "columnNIM"
        Me.columnNIM.ReadOnly = True
        '
        'columnNama
        '
        Me.columnNama.HeaderText = "Nama"
        Me.columnNama.MinimumWidth = 150
        Me.columnNama.Name = "columnNama"
        Me.columnNama.ReadOnly = True
        '
        'columnJenisKelamin
        '
        Me.columnJenisKelamin.HeaderText = "Jenis Kelamin"
        Me.columnJenisKelamin.MinimumWidth = 150
        Me.columnJenisKelamin.Name = "columnJenisKelamin"
        Me.columnJenisKelamin.ReadOnly = True
        '
        'columnKelas
        '
        Me.columnKelas.HeaderText = "Kelas"
        Me.columnKelas.Name = "columnKelas"
        Me.columnKelas.ReadOnly = True
        '
        'columnKehadiran
        '
        Me.columnKehadiran.HeaderText = "Kehadiran"
        Me.columnKehadiran.Name = "columnKehadiran"
        Me.columnKehadiran.ReadOnly = True
        '
        'columnTugas
        '
        Me.columnTugas.HeaderText = "Nilai Tugas"
        Me.columnTugas.Name = "columnTugas"
        Me.columnTugas.ReadOnly = True
        '
        'columnUTS
        '
        Me.columnUTS.HeaderText = "Nilai UTS"
        Me.columnUTS.Name = "columnUTS"
        Me.columnUTS.ReadOnly = True
        '
        'columnUAS
        '
        Me.columnUAS.HeaderText = "Nilai UAS"
        Me.columnUAS.Name = "columnUAS"
        Me.columnUAS.ReadOnly = True
        '
        'columnTotalNilai
        '
        Me.columnTotalNilai.HeaderText = "Total Nilai"
        Me.columnTotalNilai.Name = "columnTotalNilai"
        Me.columnTotalNilai.ReadOnly = True
        '
        'columnNilaiAkhir
        '
        Me.columnNilaiAkhir.HeaderText = "Nilai Akhir"
        Me.columnNilaiAkhir.Name = "columnNilaiAkhir"
        Me.columnNilaiAkhir.ReadOnly = True
        '
        'panelLaporan
        '
        Me.panelLaporan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelLaporan.BackColor = System.Drawing.Color.Gainsboro
        Me.panelLaporan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelLaporan.Controls.Add(Me.dgvNilai)
        Me.panelLaporan.Controls.Add(Me.labelLaporan)
        Me.panelLaporan.Location = New System.Drawing.Point(7, 222)
        Me.panelLaporan.Name = "panelLaporan"
        Me.panelLaporan.Size = New System.Drawing.Size(1893, 332)
        Me.panelLaporan.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 580)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1912, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "© 2025 Sistem Informasi Nilai Siswa – Project UTS Pemrograman Visual"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1912, 600)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelLaporan)
        Me.Controls.Add(Me.buttonInputNilai)
        Me.Controls.Add(Me.buttonDataSiswa)
        Me.Controls.Add(Me.labelSubTitle)
        Me.Controls.Add(Me.labelTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Informasi Nilai Siswa"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvNilai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLaporan.ResumeLayout(False)
        Me.panelLaporan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuFile As ToolStripMenuItem
    Friend WithEvents menuFileExit As ToolStripMenuItem
    Friend WithEvents menuTools As ToolStripMenuItem
    Friend WithEvents menuDataSiswa As ToolStripMenuItem
    Friend WithEvents menuInputNilai As ToolStripMenuItem
    Friend WithEvents menuHelp As ToolStripMenuItem
    Friend WithEvents menuAboutApp As ToolStripMenuItem
    Friend WithEvents labelTitle As Label
    Friend WithEvents labelSubTitle As Label
    Friend WithEvents buttonDataSiswa As Button
    Friend WithEvents buttonInputNilai As Button
    Friend WithEvents labelLaporan As Label
    Friend WithEvents dgvNilai As DataGridView
    Friend WithEvents panelLaporan As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents columnNIM As DataGridViewTextBoxColumn
    Friend WithEvents columnNama As DataGridViewTextBoxColumn
    Friend WithEvents columnJenisKelamin As DataGridViewTextBoxColumn
    Friend WithEvents columnKelas As DataGridViewTextBoxColumn
    Friend WithEvents columnKehadiran As DataGridViewTextBoxColumn
    Friend WithEvents columnTugas As DataGridViewTextBoxColumn
    Friend WithEvents columnUTS As DataGridViewTextBoxColumn
    Friend WithEvents columnUAS As DataGridViewTextBoxColumn
    Friend WithEvents columnTotalNilai As DataGridViewTextBoxColumn
    Friend WithEvents columnNilaiAkhir As DataGridViewTextBoxColumn
End Class
