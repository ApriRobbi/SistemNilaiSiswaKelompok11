Public Class FormMain
    '==========
    'Refresh data nilai ke grid view
    '==========
    Public Sub RefreshGridNilai()
        dgvNilai.Rows.Clear()

        For Each nilai As NilaiSiswa In DaftarNilai
            dgvNilai.Rows.Add(
                nilai.NIM,
                nilai.Nama,
                nilai.JenisKelamin,
                nilai.Kelas,
                nilai.Kehadiran,
                nilai.Tugas,
                nilai.UTS,
                nilai.UAS,
                nilai.Total.ToString("F2"),
                nilai.NilaiAkhir
            )
        Next
    End Sub

    'saat load FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGridNilai()
    End Sub

    'Memanggil FormInputNilai dari button Input Nilai
    Private Sub buttonInputNilai_Click(sender As Object, e As EventArgs) Handles buttonInputNilai.Click
        Dim f As New FormInputNilai()
        f.ShowDialog()
        RefreshGridNilai()
    End Sub

    'Memanggil FormInputNilai dari menu
    Private Sub menuInputNilai_Click(sender As Object, e As EventArgs) Handles menuInputNilai.Click
        Dim f As New FormInputNilai()
        f.ShowDialog()
        RefreshGridNilai()
    End Sub

    'Memanggil FormManageSiswa dari button Manage Siswa
    Private Sub buttonDataSiswa_Click(sender As Object, e As EventArgs) Handles buttonDataSiswa.Click
        Dim f As New FormManageSiswa()
        f.ShowDialog()
    End Sub

    'Memanggil FormManageSiswa dari Menu Data Siswa
    Private Sub menuDataSiswa_Clik(sender As Object, e As EventArgs) Handles menuDataSiswa.Click
        Dim f As New FormManageSiswa()
        f.ShowDialog()
    End Sub

    'Handle menu exit
    Private Sub menuFileExit_Click(sender As Object, e As EventArgs) Handles menuFileExit.Click
        Application.Exit()
    End Sub

    'Handle menu about app
    Private Sub menuAboutApp_Click(sender As Object, e As EventArgs) Handles menuAboutApp.Click
        Dim info As String =
        "APLIKASI SISTEM INFORMASI NILAI SISWA" & vbCrLf &
        "-------------------------------------------" & vbCrLf &
        "Dibuat oleh:" & vbCrLf &
        "1. Nama Anggota 1 - NIM" & vbCrLf &
        "2. Nama Anggota 2 - NIM" & vbCrLf &
        "3. Nama Anggota 3 - NIM" & vbCrLf &
        "4. Nama Anggota 4 - NIM (opsional)" & vbCrLf &
        vbCrLf &
        "Project UTS Pemrograman Visual 2025" & vbCrLf &
        "Dosen Pengampu: Nama Dosen"

        MessageBox.Show(info, "About This Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
