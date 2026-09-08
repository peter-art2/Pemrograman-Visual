Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()

        Dim awal As Integer
        Dim akhir As Integer

        If Integer.TryParse(TextBox1.Text, awal) AndAlso Integer.TryParse(TextBox2.Text, akhir) Then
            If awal <= akhir Then
                For i As Integer = awal To akhir
                    ListBox1.Items.Add(i)
                Next
            Else
                For i As Integer = awal To akhir Step -1
                    ListBox1.Items.Add(i)
                Next
            End If
        Else
            MessageBox.Show("Masukkan angka yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class