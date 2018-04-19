Module SumaFecha
    Dim fecha As Date
    Dim dias As Integer
    Dim resultado As Date
    Sub Main()
        Console.WriteLine("Ingrese una fecha:   Estructura DD/MM/AAAA")
        fecha = Console.ReadLine()

        Console.WriteLine("Ingrese dias a sumar :")
        dias = Console.ReadLine()

        resultado = fecha.AddDays(dias)

        Console.WriteLine(resultado)
    End Sub
End Module
