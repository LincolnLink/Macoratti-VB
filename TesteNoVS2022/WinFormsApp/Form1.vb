Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        valor1 = CInt(txtValor1.Text)
        valor2 = CInt(txtValor2.Text)
        Soma(valor1, valor2)
    End Sub

    Private Sub Soma(ByVal v1 As Integer, ByVal v2 As Integer)

        Dim resultado As Integer
        resultado = v1 + v2
        txtResultado.Text = resultado

        'txtResultado.Text = CInt(txtValor1.Text) + CInt(txtValor2.Text)'

    End Sub

End Class
