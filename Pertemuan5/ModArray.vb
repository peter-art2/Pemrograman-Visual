Module ModArray


    Function hitung(panjang As Integer, lebar As Integer) As Integer
        If panjang > 50 Then
            Return panjang * lebar
        Else
            Return 2 * panjang + 2 * lebar

        End If
    End Function

    Public nilai() As Integer = {80, 90, 100}
    Public nilai2d(,) As Integer = {{80, 90, 100}, {70, 80, 90}, {60, 70, 80}}

End Module
