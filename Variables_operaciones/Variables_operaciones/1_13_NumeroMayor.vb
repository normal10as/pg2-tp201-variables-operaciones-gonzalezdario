Module NumeroMayor
    Sub Main()
        Dim mayor As Integer
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        Console.WriteLine("Ingrese un valor :  ")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese un valor :  ")
        b = Console.ReadLine()
        Console.WriteLine("Ingrese un valor :  ")
        c = Console.ReadLine()

        mayor = a

        If b > mayor Then
            mayor = b
        End If

        If c > mayor Then
            mayor = c
        End If

        Console.WriteLine("El numero mayor es: " & mayor)
    End Sub
End Module
