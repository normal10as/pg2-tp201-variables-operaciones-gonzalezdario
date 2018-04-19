Module ValorAproximadoRedondeo
    Sub Main()
        Dim a As Single

        Console.WriteLine("Ingrese un numero real (x): ")
        a = Console.ReadLine()

        Console.WriteLine("Valor aproximado por exceso de X = " & Math.Ceiling(a))
        Console.WriteLine("Valor aproximado por defecto de X = " & Math.Floor(a))
        Console.WriteLine("Valor redondeado de x = " & Math.Round(a))
    End Sub
End Module
