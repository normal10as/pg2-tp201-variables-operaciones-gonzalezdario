Module SumatoriaMedia
    Sub Main()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer

        Console.WriteLine("Ingrese un valor :  ")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese un valor :  ")
        b = Console.ReadLine()
        Console.WriteLine("Ingrese un valor :  ")
        c = Console.ReadLine()
        Console.WriteLine("Ingrese un valor :  ")
        d = Console.ReadLine()

        Dim z As Integer = a + b + c + d
        Console.WriteLine("Sumatoria: " & z)
        Console.WriteLine("Media: " & z / 4)

    End Sub
End Module
