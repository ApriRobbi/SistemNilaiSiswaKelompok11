Imports System.Drawing.Text

Public Class FormInputNilai
    '=========
    'Buat Helper untuk membersihkan seluruh form
    '=========
    Private Sub BersihkanForm()
        textBoxCariNIM.Clear()
        textBoxNama.Clear()
        textBoxKelas.Clear()
        textBoxJenisKelamin.Clear()
        textBoxKehadiran.Clear()
        textBoxTugas.Clear()
        textBoxUTS.Clear()
        textBoxUAS.Clear()
        textBoxTotal.Clear()
        textBoxNilaiAkhir.Clear()
        textBoxCariNIM.Focus()
    End Sub

    '=========
    'Cari Siswa berdasarkan NIM
    '=========
    Private Function CariSiswaByNIM(nim As String) As Siswa
        For Each siswa As Siswa In DaftarSiswa
            If siswa.NIM = nim Then
                Return siswa
            End If
        Next

        Return Nothing 'kalau nimnya tidak ada maka return nya tidak ketemu
    End Function

    '=========
    'Validasi input nilai kehadiran, tugas, uts, uas
    '=========
    Private Function ValidasiInputNilai() As Boolean
        'pastikan pilih siswa berdasarkan NiM
        If textBoxNama.Text.Trim() = "" Then
            MessageBox.Show("Silahkan cari dan pilih siswa berdasarkan nim terlebih dahulu", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textBoxCariNIM.Focus()
            Return False
        End If

        'Validasi nilai Kehadiran, tugas, UTS dan UAS tidak boleh ada yang kosongn
        If textBoxKehadiran.Text.Trim() = "" OrElse
                textBoxTugas.Text.Trim() = "" OrElse
                textBoxUTS.Text.Trim() = "" OrElse
                textBoxUAS.Text.Trim() = "" Then
            MessageBox.Show("Semua Nilai, Kehadiran, Tugas, UTS dan UAS wajib diisi semua.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        'Check value nilai harus dalam rentang 1 - 100
        Dim kehadiran, tugas, uts, uas As Double
        'Kehadiran harus 1 - 100
        If Not Double.TryParse(textBoxKehadiran.Text, kehadiran) OrElse kehadiran < 0 OrElse kehadiran > 100 Then
            MessageBox.Show("Nilai Kehadiran harus angka 0 - 100.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textBoxKehadiran.Focus()
            Return False
        End If

        'tugas harus 1 - 100
        If Not Double.TryParse(textBoxTugas.Text, tugas) OrElse tugas < 0 OrElse tugas > 100 Then
            MessageBox.Show("Nilai Tugas harus angka 0 - 100.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textBoxTugas.Focus()
            Return False
        End If

        'UTS harus 1 - 100
        If Not Double.TryParse(textBoxUTS.Text, uts) OrElse uts < 0 OrElse uts > 100 Then
            MessageBox.Show("Nilai UTS harus angka 0 - 100.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textBoxUTS.Focus()
            Return False
        End If

        'UAS harus 1 - 100
        If Not Double.TryParse(textBoxUAS.Text, uas) OrElse uas < 0 OrElse uas > 100 Then
            MessageBox.Show("Nilai UAS harus angka 0 - 100.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textBoxUAS.Focus()
            Return False
        End If

        'kalau tidak ada kena validasi diatas, maka return true
        Return True
    End Function


    '=========
    'Hitung total nilai, dan mapping hasil akhirnya ke ENUM dari AppData
    '=========
    Private Function HitungTotalNilai(kehadiran As Double,
                                      tugas As Double,
                                      uts As Double,
                                      uas As Double) As Double

        Dim total As Double
        total = kehadiran * BOBOT_KEHADIRAN +
                tugas * BOBOT_TUGAS +
                uts * BOBOT_UTS +
                uas * BOBOT_UAS

        Return total
    End Function

    'Konversi nilai menjadi huruf
    Private Function KonversiNilaiKeHuruf(total As Double) As String

        Dim huruf As String

        If total >= 85 Then
            huruf = "A"
        ElseIf total >= 75 Then
            huruf = "B"
        ElseIf total >= 65 Then
            huruf = "C"
        ElseIf total >= 50 Then
            huruf = "D"
        Else
            huruf = "E"
        End If

        Return huruf
    End Function

    '=========
    'Form Load saat pertama kali dibuka
    '=========
    Private Sub FormInputNilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BersihkanForm()
    End Sub

    '=========
    'Hanya boleh input Angka untuk Nim dan Nilai
    '=========
    Private Sub HanyaAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxCariNIM.KeyPress,
                                                                                      textBoxKehadiran.KeyPress,
                                                                                      textBoxTugas.KeyPress,
                                                                                      textBoxUTS.KeyPress,
                                                                                      textBoxUAS.KeyPress

        'boleh input tombol kontrol
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        'hanya boleh digit 0 - 9
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True 'cancel karakter yang bukan angka
        End If
    End Sub

    '=========
    'Button Cari NIM
    '=========
    Private Sub buttonCariNIM_Click(sender As Object, e As EventArgs) Handles buttonCariNIM.Click

        Dim nim As String = textBoxCariNIM.Text.Trim()

        If nim = "" Then
            MessageBox.Show("Silahkan isi NIM yang ingin dicari.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            textBoxCariNIM.Focus()
            Exit Sub
        End If

        Dim siswa As Siswa = CariSiswaByNIM(nim)

        If siswa Is Nothing Then
            MessageBox.Show("Siswa dengan NIM tersebut tidak ditemukan. Silahkan tambah siswa di menu Manage Siswa",
                            "Inforamasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            textBoxNama.Clear()
            textBoxKelas.Clear()
            textBoxJenisKelamin.Clear()
        Else
            textBoxNama.Text = siswa.Nama
            textBoxKelas.Text = siswa.Kelas

            If siswa.JenisKelamin = JenisKelamin.LakiLaki Then
                textBoxJenisKelamin.Text = "Laki-Laki"
            Else
                textBoxJenisKelamin.Text = "Perempuan"
            End If
        End If
    End Sub

    '=========
    'Button HITUNG
    '=========
    Private Sub buttonHitung_Click(sender As Object, e As EventArgs) Handles buttonHitung.Click
        If Not ValidasiInputNilai() Then
            Exit Sub
        End If

        Dim kehadiran, tugas, uts, uas As Double

        Double.TryParse(textBoxKehadiran.Text, kehadiran)
        Double.TryParse(textBoxTugas.Text, tugas)
        Double.TryParse(textBoxUTS.Text, uts)
        Double.TryParse(textBoxUAS.Text, uas)

        Dim totalNilai As Double = HitungTotalNilai(kehadiran, tugas, uts, uas)
        Dim totalNilaiDalamHuruf As String = KonversiNilaiKeHuruf(totalNilai)

        textBoxTotal.Text = totalNilai.ToString("F2") 'Dua angka dibelakang koma
        textBoxNilaiAkhir.Text = totalNilaiDalamHuruf
    End Sub

    '=========
    'Button RESET
    '=========
    Private Sub buttonReset_Click(sender As Object, e As EventArgs) Handles buttonReset.Click
        BersihkanForm()
    End Sub

    '=========
    'Button Simpan
    '=========
    Private Sub buttonSimpan_Click(sender As Object, e As EventArgs) Handles buttonSimpan.Click
        If Not ValidasiInputNilai() Then
            Exit Sub
        End If

        Dim nim As String = textBoxCariNIM.Text.Trim()

        'memastikan Siswa ada dari Nim
        Dim siswa As Siswa = CariSiswaByNIM(nim)
        If siswa Is Nothing Then
            MessageBox.Show("Siswa tidak ditemukan. Tidak bisa menuimpan nilai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Parse nilai
        Dim kehadiran, tugas, uts, uas As Double
        Double.TryParse(textBoxKehadiran.Text, kehadiran)
        Double.TryParse(textBoxTugas.Text, tugas)
        Double.TryParse(textBoxUTS.Text, uts)
        Double.TryParse(textBoxUAS.Text, uas)

        Dim totalNilai As Double = HitungTotalNilai(kehadiran, tugas, uts, uas)
        Dim nilaiSiswaDalamHuruf As String = KonversiNilaiKeHuruf(totalNilai)

        'Check apakah NIM sudah punya daftar nilai
        Dim nilaiSiswa As NilaiSiswa = Nothing
        For Each n As NilaiSiswa In DaftarNilai
            If n.NIM = nim Then
                nilaiSiswa = n
                Exit For
            End If
        Next

        If nilaiSiswa Is Nothing Then
            'kalau belum ada, buat baru
            nilaiSiswa = New NilaiSiswa()
            DaftarNilai.Add(nilaiSiswa)
        End If

        'isi data baru atau update data baru
        nilaiSiswa.NIM = siswa.NIM
        nilaiSiswa.Nama = siswa.Nama
        nilaiSiswa.JenisKelamin = textBoxJenisKelamin.Text
        nilaiSiswa.Kelas = siswa.Kelas
        nilaiSiswa.Kehadiran = kehadiran
        nilaiSiswa.Tugas = tugas
        nilaiSiswa.UTS = uts
        nilaiSiswa.UAS = uas
        nilaiSiswa.Total = totalNilai
        nilaiSiswa.NilaiAkhir = nilaiSiswaDalamHuruf

        'Update tampilan textBox total & huruf
        textBoxTotal.Text = totalNilai.ToString("F2")
        textBoxNilaiAkhir.Text = nilaiSiswaDalamHuruf

        MessageBox.Show("Nilai siswa berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'saat selesaii di simpan, maka FormMain akan terupdate
        If Application.OpenForms().OfType(Of FormMain).Any() Then
            Dim f As FormMain = Application.OpenForms().OfType(Of FormMain)().First()
            f.RefreshGridNilai()
        End If
    End Sub
End Class