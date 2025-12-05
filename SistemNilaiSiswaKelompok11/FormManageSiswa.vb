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


End Class