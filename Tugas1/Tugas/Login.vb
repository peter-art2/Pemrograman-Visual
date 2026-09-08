Imports System.Drawing.Drawing2D

Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, picImage.Width, picImage.Height)
        picImage.Region = New Region(path)
        picImage.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        Dim imgPath As String = $"assets/{cmbRole.Text.ToLower()}.png"
        If IO.File.Exists(imgPath) Then picImage.Image = Image.FromFile(imgPath)
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = " "c) Then e.Handled = True
    End Sub

    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim r = cmbRole.Text, n = txtNama.Text.Trim(), nim = txtNIM.Text.Trim()
        If (r = "Staff" AndAlso n = "Rangga" AndAlso nim = "241712093") OrElse
           (r = "Manager" AndAlso n = "Peter" AndAlso nim = "241712039") Then
            txtNama.Clear() : txtNIM.Clear()
            FrmPajak.Show() : Me.Hide()
        Else
            MessageBox.Show("Kombinasi Role, Nama, atau NIM tidak sesuai!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNIM.Focus()
        End If
    End Sub
End Class