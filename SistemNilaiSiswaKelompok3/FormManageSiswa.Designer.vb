<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageSiswa
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grupBoxInput = New System.Windows.Forms.GroupBox()
        Me.grouBoxJenisKelamin = New System.Windows.Forms.GroupBox()
        Me.radioButPerempuan = New System.Windows.Forms.RadioButton()
        Me.radioButLaki = New System.Windows.Forms.RadioButton()
        Me.comboBoxKelas = New System.Windows.Forms.ComboBox()
        Me.labelKelas = New System.Windows.Forms.Label()
        Me.textNIM = New System.Windows.Forms.TextBox()
        Me.labelNIM = New System.Windows.Forms.Label()
        Me.textNama = New System.Windows.Forms.TextBox()
        Me.labelNama = New System.Windows.Forms.Label()
        Me.buttonTambah = New System.Windows.Forms.Button()
        Me.buttonEdit = New System.Windows.Forms.Button()
        Me.buttonHapus = New System.Windows.Forms.Button()
        Me.dgvSiswa = New System.Windows.Forms.DataGridView()
        Me.columnNIM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnKelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnJenisKelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tooltipNIM = New System.Windows.Forms.ToolTip(Me.components)
        Me.grupBoxInput.SuspendLayout()
        Me.grouBoxJenisKelamin.SuspendLayout()
        CType(Me.dgvSiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupBoxInput
        '
        Me.grupBoxInput.Controls.Add(Me.grouBoxJenisKelamin)
        Me.grupBoxInput.Controls.Add(Me.comboBoxKelas)
        Me.grupBoxInput.Controls.Add(Me.labelKelas)
        Me.grupBoxInput.Controls.Add(Me.textNIM)
        Me.grupBoxInput.Controls.Add(Me.labelNIM)
        Me.grupBoxInput.Controls.Add(Me.textNama)
        Me.grupBoxInput.Controls.Add(Me.labelNama)
        Me.grupBoxInput.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupBoxInput.Location = New System.Drawing.Point(12, 12)
        Me.grupBoxInput.Name = "grupBoxInput"
        Me.grupBoxInput.Size = New System.Drawing.Size(330, 165)
        Me.grupBoxInput.TabIndex = 0
        Me.grupBoxInput.TabStop = False
        Me.grupBoxInput.Text = "Input Data Siswa"
        '
        'grouBoxJenisKelamin
        '
        Me.grouBoxJenisKelamin.Controls.Add(Me.radioButPerempuan)
        Me.grouBoxJenisKelamin.Controls.Add(Me.radioButLaki)
        Me.grouBoxJenisKelamin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grouBoxJenisKelamin.Location = New System.Drawing.Point(3, 111)
        Me.grouBoxJenisKelamin.Name = "grouBoxJenisKelamin"
        Me.grouBoxJenisKelamin.Size = New System.Drawing.Size(221, 53)
        Me.grouBoxJenisKelamin.TabIndex = 3
        Me.grouBoxJenisKelamin.TabStop = False
        Me.grouBoxJenisKelamin.Text = "Jenis Kelamin"
        '
        'radioButPerempuan
        '
        Me.radioButPerempuan.AutoSize = True
        Me.radioButPerempuan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButPerempuan.Location = New System.Drawing.Point(95, 24)
        Me.radioButPerempuan.Name = "radioButPerempuan"
        Me.radioButPerempuan.Size = New System.Drawing.Size(86, 19)
        Me.radioButPerempuan.TabIndex = 1
        Me.radioButPerempuan.TabStop = True
        Me.radioButPerempuan.Text = "Perempuan"
        Me.radioButPerempuan.UseVisualStyleBackColor = True
        '
        'radioButLaki
        '
        Me.radioButLaki.AutoSize = True
        Me.radioButLaki.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButLaki.Location = New System.Drawing.Point(9, 24)
        Me.radioButLaki.Name = "radioButLaki"
        Me.radioButLaki.Size = New System.Drawing.Size(72, 19)
        Me.radioButLaki.TabIndex = 0
        Me.radioButLaki.TabStop = True
        Me.radioButLaki.Text = "Laki-Laki"
        Me.radioButLaki.UseVisualStyleBackColor = True
        '
        'comboBoxKelas
        '
        Me.comboBoxKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxKelas.FormattingEnabled = True
        Me.comboBoxKelas.Location = New System.Drawing.Point(63, 82)
        Me.comboBoxKelas.Name = "comboBoxKelas"
        Me.comboBoxKelas.Size = New System.Drawing.Size(121, 23)
        Me.comboBoxKelas.TabIndex = 2
        '
        'labelKelas
        '
        Me.labelKelas.AutoSize = True
        Me.labelKelas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelKelas.Location = New System.Drawing.Point(9, 85)
        Me.labelKelas.Name = "labelKelas"
        Me.labelKelas.Size = New System.Drawing.Size(43, 15)
        Me.labelKelas.TabIndex = 4
        Me.labelKelas.Text = "KELAS:"
        '
        'textNIM
        '
        Me.textNIM.Location = New System.Drawing.Point(63, 51)
        Me.textNIM.MaxLength = 10
        Me.textNIM.Name = "textNIM"
        Me.textNIM.Size = New System.Drawing.Size(200, 23)
        Me.textNIM.TabIndex = 1
        Me.tooltipNIM.SetToolTip(Me.textNIM, "Masukan NIM Unik")
        '
        'labelNIM
        '
        Me.labelNIM.AutoSize = True
        Me.labelNIM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNIM.Location = New System.Drawing.Point(9, 54)
        Me.labelNIM.Name = "labelNIM"
        Me.labelNIM.Size = New System.Drawing.Size(33, 15)
        Me.labelNIM.TabIndex = 2
        Me.labelNIM.Text = "NIM:"
        '
        'textNama
        '
        Me.textNama.Location = New System.Drawing.Point(63, 19)
        Me.textNama.Name = "textNama"
        Me.textNama.Size = New System.Drawing.Size(200, 23)
        Me.textNama.TabIndex = 0
        '
        'labelNama
        '
        Me.labelNama.AutoSize = True
        Me.labelNama.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNama.Location = New System.Drawing.Point(9, 22)
        Me.labelNama.Name = "labelNama"
        Me.labelNama.Size = New System.Drawing.Size(46, 15)
        Me.labelNama.TabIndex = 0
        Me.labelNama.Text = "NAMA:"
        '
        'buttonTambah
        '
        Me.buttonTambah.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonTambah.Location = New System.Drawing.Point(12, 183)
        Me.buttonTambah.Name = "buttonTambah"
        Me.buttonTambah.Size = New System.Drawing.Size(100, 36)
        Me.buttonTambah.TabIndex = 0
        Me.buttonTambah.Text = "TAMBAH"
        Me.buttonTambah.UseVisualStyleBackColor = True
        '
        'buttonEdit
        '
        Me.buttonEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonEdit.Location = New System.Drawing.Point(127, 183)
        Me.buttonEdit.Name = "buttonEdit"
        Me.buttonEdit.Size = New System.Drawing.Size(100, 36)
        Me.buttonEdit.TabIndex = 1
        Me.buttonEdit.Text = "EDIT"
        Me.buttonEdit.UseVisualStyleBackColor = True
        '
        'buttonHapus
        '
        Me.buttonHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonHapus.Location = New System.Drawing.Point(242, 183)
        Me.buttonHapus.Name = "buttonHapus"
        Me.buttonHapus.Size = New System.Drawing.Size(100, 36)
        Me.buttonHapus.TabIndex = 2
        Me.buttonHapus.Text = "HAPUS"
        Me.buttonHapus.UseVisualStyleBackColor = True
        '
        'dgvSiswa
        '
        Me.dgvSiswa.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvSiswa.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSiswa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSiswa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSiswa.ColumnHeadersHeight = 30
        Me.dgvSiswa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnNIM, Me.columnNama, Me.columnKelas, Me.columnJenisKelamin})
        Me.dgvSiswa.Location = New System.Drawing.Point(14, 6)
        Me.dgvSiswa.Name = "dgvSiswa"
        Me.dgvSiswa.ReadOnly = True
        Me.dgvSiswa.RowHeadersVisible = False
        Me.dgvSiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSiswa.Size = New System.Drawing.Size(754, 265)
        Me.dgvSiswa.TabIndex = 0
        '
        'columnNIM
        '
        Me.columnNIM.HeaderText = "NIM"
        Me.columnNIM.Name = "columnNIM"
        Me.columnNIM.ReadOnly = True
        '
        'columnNama
        '
        Me.columnNama.HeaderText = "Nama"
        Me.columnNama.Name = "columnNama"
        Me.columnNama.ReadOnly = True
        '
        'columnKelas
        '
        Me.columnKelas.HeaderText = "Kelas"
        Me.columnKelas.Name = "columnKelas"
        Me.columnKelas.ReadOnly = True
        '
        'columnJenisKelamin
        '
        Me.columnJenisKelamin.HeaderText = "Jenis Kelamin"
        Me.columnJenisKelamin.Name = "columnJenisKelamin"
        Me.columnJenisKelamin.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.dgvSiswa)
        Me.Panel1.Location = New System.Drawing.Point(-2, 225)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(777, 274)
        Me.Panel1.TabIndex = 5
        '
        'FormManageSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 511)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.buttonHapus)
        Me.Controls.Add(Me.buttonEdit)
        Me.Controls.Add(Me.buttonTambah)
        Me.Controls.Add(Me.grupBoxInput)
        Me.Name = "FormManageSiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kelola Data Siswa"
        Me.grupBoxInput.ResumeLayout(False)
        Me.grupBoxInput.PerformLayout()
        Me.grouBoxJenisKelamin.ResumeLayout(False)
        Me.grouBoxJenisKelamin.PerformLayout()
        CType(Me.dgvSiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grupBoxInput As GroupBox
    Friend WithEvents comboBoxKelas As ComboBox
    Friend WithEvents labelKelas As Label
    Friend WithEvents textNIM As TextBox
    Friend WithEvents labelNIM As Label
    Friend WithEvents textNama As TextBox
    Friend WithEvents labelNama As Label
    Friend WithEvents radioButPerempuan As RadioButton
    Friend WithEvents radioButLaki As RadioButton
    Friend WithEvents buttonTambah As Button
    Friend WithEvents buttonEdit As Button
    Friend WithEvents buttonHapus As Button
    Friend WithEvents dgvSiswa As DataGridView
    Friend WithEvents columnNIM As DataGridViewTextBoxColumn
    Friend WithEvents columnNama As DataGridViewTextBoxColumn
    Friend WithEvents columnKelas As DataGridViewTextBoxColumn
    Friend WithEvents columnJenisKelamin As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grouBoxJenisKelamin As GroupBox
    Friend WithEvents tooltipNIM As ToolTip
End Class
