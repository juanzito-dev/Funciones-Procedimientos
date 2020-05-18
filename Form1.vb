Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Numero1 As Integer = 1
        Dim Numero2 As Integer = 2
        Dim Numero3 As Integer = 3
        Suma_Multi(Numero1, Numero2, Numero3)
    End Sub
    Private Sub Suma_Multi(ByVal Numero1 As Integer, ByVal Numero2 As Integer, ByVal Numero3 As Integer)

        Dim resultado As Integer
        resultado = (Numero1 + Numero2) * Numero3
        MsgBox(resultado)
        Me.Close()
    End Sub


End Class
