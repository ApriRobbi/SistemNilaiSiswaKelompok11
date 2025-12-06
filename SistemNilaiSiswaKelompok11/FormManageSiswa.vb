Public Class FormManageSiswa
    'Private Sub radioButLaki_CheckedChanged(sender As Object, e As EventArgs) Handles radioButLaki.CheckedChanged
    'End Sub

    'Private Sub FormManageSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'End Sub

    'Hard code isi drop down Kelas
    Private Sub IsiComboKelas()
        comboBoxKelas.Items.Clear()
        comboBoxKelas.Items.Add("X IPA - 1")
        comboBoxKelas.Items.Add("X IPA - 2")
        comboBoxKelas.Items.Add("X IPS - 1")
        comboBoxKelas.Items.Add("X IPS - 2")
        comboBoxKelas.Items.Add("XI IPA - 1")
        comboBoxKelas.Items.Add("XI IPA - 2")
        comboBoxKelas.Items.Add("XI IPS - 1")
        comboBoxKelas.Items.Add("XI IPS - 2")
        comboBoxKelas.Items.Add("XII IPA - 1")
        comboBoxKelas.Items.Add("XII IPA - 2")
        comboBoxKelas.Items.Add("XII IPS - 1")
        comboBoxKelas.Items.Add("XII IPS - 2")
    End Sub

    'Buat seluruh button setelah di click maka akan terhapus isi form nya
    Private Sub ClearInputAfterClick()
        textNama.Clear()
        textNIM.Clear()
        'untuk dropdown dibuat -1 supaya tidak memilih apapun atau clear setelah button di click
        comboBoxKelas.SelectedIndex = -1
        radioButLaki.Checked = False
        radioButPerempuan.Checked = False
        textNIM.Enabled = True
        textNama.Focus()
    End Sub

    'Karena Jenis kelamin mengambil data dari Enum JenisKelamin, maka dibuat dulu helpernya
    Private Function GetJenisKelaminDariInput() As JenisKelamin?
        If radioButLaki.Checked Then
            Return JenisKelamin.LakiLaki
        ElseIf radioButPerempuan.Checked Then
            Return JenisKelamin.Perempuan
        Else
            Return Nothing 'menandakan jenis kelamin belum dipilih
        End If
    End Function

    'Melakukan set radio button dari Enum Jenis kelamin
    Private Sub SetRadioButtonFromEnumJenisKelamin(jenisKelamin As JenisKelamin)
        If jenisKelamin = JenisKelamin.LakiLaki Then
            radioButLaki.Checked = True
        ElseIf jenisKelamin = JenisKelamin.Perempuan Then
            radioButPerempuan.Checked = True
        End If
    End Sub

    'Data disimpan dalam list global, lalu setiap ada perubahan maka diisi ulang grid nya
    'tahap ini juga yang menentukan value dari Jenis kelamin
    Private Sub RefreshGridSiswa()
        dgvSiswa.Rows.Clear()

        For Each siswa As Siswa In DaftarSiswa
            Dim jenisKelaminTeks As String = If(siswa.JenisKelamin = JenisKelamin.LakiLaki, "Laki-Laki", "Perempuan") 'bentuk if else
            dgvSiswa.Rows.Add(siswa.NIM, siswa.Nama, siswa.Kelas, jenisKelaminTeks)
        Next
    End Sub

    'code saat Form di buka
    Private Sub FormManageSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiComboKelas() 'isi dropdown kelas dari yang di set di atas
        ClearInputAfterClick() 'panggil function Clear input, setelah button di click maka akan menghapus seuluruh inputan
        RefreshGridSiswa()
    End Sub

    'Function untuk validasi
    Private Function ValidasiInputSiswa() As Boolean
        'validasi Nama adalah field mandatory
        If textNama.Text.Trim() = "" Then
            MessageBox.Show("Nama masih kosong, silahkan isi Nama terlebih dahulu", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textNama.Focus()
            Return False
        End If

        'Validasi NIM adalah field mandatory
        If textNIM.Text.Trim() = "" Then
            MessageBox.Show("NIM masih kosong, silahkan isi NIM terlebih dahulu", "validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textNIM.Focus()
            Return False
        End If

        'validasi Dropdown Kelas mandatory
        If comboBoxKelas.SelectedIndex = -1 Then
            MessageBox.Show("Kelas belum dipilih", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            comboBoxKelas.Focus()
            Return False
        End If

        Dim jenisKelamin As JenisKelamin? = GetJenisKelaminDariInput()
        If jenisKelamin Is Nothing Then
            MessageBox.Show("Jenis kelamin Belum dipilih", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    'Validasi Check NIM sudah dipakai atau belum
    Private Function NIMSudahAda(nim As String) As Boolean
        'untuk setiap Siswa dari DaftarSiswa di check apakah NIM sudah ada?
        'Kalau sudah ada maka return true
        'Kalau belum ada return False
        For Each siswa As Siswa In DaftarSiswa
            If siswa.NIM = nim Then
                Return True
            End If
        Next
        Return False
    End Function

    'Validasi input NIM hanya boleh ANGKA, kalau user mengisi selain anka maka value tidak akan masuk ke textBox
    Private Sub textNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textNIM.KeyPress
        'jika bukan angka dan bukan tombol control(delete, backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True 'Mencegah karakter masuk
        End If
    End Sub

    'Membuat Input NAMA menjadi uppercase
    Private Sub textNama_TextChanged(sender As Object, e As EventArgs) Handles textNama.TextChanged
        Dim posisiStart As Integer = textNama.SelectionStart
        textNama.Text = textNama.Text.ToUpper()
        textNama.SelectionStart = posisiStart
    End Sub

    'Handling button TAMBAH
    Private Sub buttonTambah_Click(sender As Object, e As EventArgs) Handles buttonTambah.Click
        'Validasi Input, panggil function yang sudah dibuat diatas
        If Not ValidasiInputSiswa() Then
            Exit Sub
        End If

        'declare Nim untuk validasi NIM tidak boleh duplikat
        Dim nim As String = textNIM.Text.Trim()
        If NIMSudahAda(nim) Then
            MessageBox.Show("NIM sudah terdaftar", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textNIM.Focus()
            Exit Sub
        End If

        'mengambil jenis kelamin dari radio button
        Dim jenisKelamin As JenisKelamin = GetJenisKelaminDariInput().Value
        'Buat Object Siswa baru untuk diisi datanya dari semua form
        Dim siswa As New Siswa()
        siswa.NIM = nim
        siswa.Nama = textNama.Text.Trim()
        siswa.Kelas = comboBoxKelas.SelectedItem.ToString()
        siswa.JenisKelamin = jenisKelamin

        'Tambah ke list global
        DaftarSiswa.Add(siswa)

        'refresh grid
        RefreshGridSiswa()

        'Bersihkan Field Input
        ClearInputAfterClick()

        textNIM.Enabled = True

        MessageBox.Show("Data siswa berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Saat data grid view di click, maka akan menampilkan value di form sesuai yang di click
    Private Sub dgvSiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiswa.CellClick
        If e.RowIndex < 0 Then Exit Sub 'Melakukan click Header

        Dim row As DataGridViewRow = dgvSiswa.Rows(e.RowIndex)
        Dim nim As String = row.Cells("columnNIM").Value.ToString()

        'Mencari object siswa dari daftar berdasarkan NIM
        Dim siswaDipilihDariNim As Siswa = Nothing
        For Each siswa As Siswa In DaftarSiswa
            If siswa.NIM = nim Then
                siswaDipilihDariNim = siswa
                Exit For
            End If
        Next

        If siswaDipilihDariNim IsNot Nothing Then
            textNIM.Text = siswaDipilihDariNim.NIM
            textNama.Text = siswaDipilihDariNim.Nama
            comboBoxKelas.SelectedItem = siswaDipilihDariNim.Kelas
            SetRadioButtonFromEnumJenisKelamin(siswaDipilihDariNim.JenisKelamin)
            textNIM.Enabled = False ' Saat Data Grid View di click maka akan mendisable textbox NIM
        End If
    End Sub

    'Button Edit
    'Wajib pilih dulu NIM dari Data Grid View
    'validasi input lagi
    'cari siswa berdasarkan NIM karena NIM sudah sudah diset tidak boleh ada yang duplicate
    Private Sub buttonEdit_Click(sender As Object, e As EventArgs) Handles buttonEdit.Click
        If dgvSiswa.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data siswa yang di edit dari tabel dibawah, silahkan click NIM dari data dibawah",
                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Not ValidasiInputSiswa() Then
            Exit Sub
        End If

        Dim nim As String = textNIM.Text.Trim()
        'Cari siswa dari List
        Dim siswaEdit As Siswa = Nothing
        For Each siswa As Siswa In DaftarSiswa
            If siswa.NIM = nim Then
                siswaEdit = siswa
                Exit For
            End If
        Next

        If siswaEdit Is Nothing Then
            MessageBox.Show("Data siiswa tidak ditemukan di list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Update Datanya
        siswaEdit.Nama = textNama.Text.Trim()
        siswaEdit.Kelas = comboBoxKelas.SelectedItem.ToString()
        siswaEdit.JenisKelamin = GetJenisKelaminDariInput().Value

        'refresh grid
        RefreshGridSiswa()

        MessageBox.Show("Data siswa berhhasil di edit.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Hapus Button
    Private Sub buttonHapus_Click(sender As Object, e As EventArgs) Handles buttonHapus.Click
        If dgvSiswa.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data siswa yang ingin dihapus dari table.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Declare nim yang dipilih
        Dim nim As String = textNIM.Text.Trim()
        If nim = "" Then
            MessageBox.Show("Data NIM Kosong. Silahkan Klik baris NIM siswa terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Confirmasi Hapus setelah user melakukan click button hapus
        Dim hasil As DialogResult = MessageBox.Show(
            "Apakah Anda yakin ingin menghapus siswa dengan Nim: " & nim & " ?",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        'kalau dalam messagebox confirmasi hapus dipilih No, maka exit sub
        If hasil = DialogResult.No Then Exit Sub

        'Kalauu pilih Yes, hapus siswa dari list
        Dim siswaDiHapus As Siswa = Nothing
        For Each siswa As Siswa In DaftarSiswa
            If siswa.NIM = nim Then
                siswaDiHapus = siswa
                Exit For
            End If
        Next

        If siswaDiHapus IsNot Nothing Then
            DaftarSiswa.Remove(siswaDiHapus)
            RefreshGridSiswa()
            ClearInputAfterClick()
            textNIM.Enabled = True
            MessageBox.Show("Data siswa berhasil di hapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Data sisiwa tiidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class