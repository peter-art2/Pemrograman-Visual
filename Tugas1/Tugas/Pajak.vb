Imports System.Globalization

Public Class FrmPajak
    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Decimal
        If Not Decimal.TryParse(txtPendapatan.Text, pendapatan) Then
            MessageBox.Show("Masukkan pendapatan yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPendapatan.Focus() : Return
        End If

        Dim tarif As Decimal = 0D
        Select Case pendapatan
            Case Is > 100000000D : tarif = 0.3D
            Case Is > 30000000D : tarif = 0.2D
            Case Is > 5000000D : tarif = 0.1D
        End Select

        Dim pajak As Decimal = pendapatan * tarif
        Dim hasil As String = pajak.ToString("N0", CultureInfo.GetCultureInfo("id-ID"))
        MessageBox.Show($"Pajak yang harus dibayar: Rp {hasil}", "Hasil Perhitungan Pajak", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
        FrmLogin.Show()
    End Sub
End Class