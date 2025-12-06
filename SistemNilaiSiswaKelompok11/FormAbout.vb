Public Class FormAbout
    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Me.Close()  'Menutup dialog
    End Sub
End Class