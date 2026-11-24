Public Class Form1
    Private Sub lblNama_Click(sender As Object, e As EventArgs) Handles lblNama.Click

    End Sub

    Private Sub lblNIM_Click(sender As Object, e As EventArgs) Handles lblNIM.Click

    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MessageBox.Show("Halo Selamat Datang !" & vbCrLf &
                        "Nama :" & txtNama.Text & vbCrLf &
                        "NIM:" & txtNIM.Text & vbCrLf &
                        "KOM:" & txtKOM.Text
                        )
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click

    End Sub
End Class
