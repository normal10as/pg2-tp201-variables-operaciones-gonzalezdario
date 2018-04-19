Module NumeroReal
    Sub Main()
        Dim a As Integer

        Console.WriteLine("Ingrese un numero (x): ")
        a = Console.ReadLine()

        Console.WriteLine("Valor Absoluto de X = " & Math.Abs(a))
        Console.WriteLine("X elevado a 10 = " & Math.Pow(a, 10))
        Console.WriteLine("Raiz Cuadrada de x = " & Math.Sqrt(a))
    End Sub
End Module
