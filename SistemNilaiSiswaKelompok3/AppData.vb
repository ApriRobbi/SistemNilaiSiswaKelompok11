Module AppData
    'Tupe Enumeration

    Public Enum JenisKelamin
        LakiLaki
        Perempuan
    End Enum

    Public Enum NilaiFinalHuruf
        A
        B
        C
        D
        E
    End Enum

    'Konstanta bobot nilai
    Public Const BOBOT_KEHADIRAN As Double = 0.1
    Public Const BOBOT_TUGAS As Double = 0.2
    Public Const BOBOT_UTS As Double = 0.3
    Public Const BOBOT_UAS As Double = 0.4

    'Class Model
    'Data identitas Siswa
    Public Class Siswa
        Public Property NIM As String
        Public Property Nama As String
        Public Property Kelas As String
        Public Property JenisKelamin As JenisKelamin
    End Class

    Public Class NilaiSiswa
        Public Property NIM As String
        Public Property Nama As String
        Public Property JenisKelamin As String
        Public Property Kelas As String
        Public Property Kehadiran As Double
        Public Property Tugas As Double
        Public Property UTS As Double
        Public Property UAS As Double
        Public Property Total As Double
        Public Property NilaiAkhir As String
    End Class

    'List Global (didalam Memory)
    Public DaftarSiswa As New List(Of Siswa)
    Public DaftarNilai As New List(Of NilaiSiswa)

End Module
