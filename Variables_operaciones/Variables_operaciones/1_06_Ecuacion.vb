Module Ecuacion
    Dim x As Single
    Const a As Byte = 1
    Const b As Byte = 5
    Const c As Byte = 2
    Sub Main()
        System.Console.WriteLine("Ecuacion")
        System.Console.WriteLine("Valor de A = " & a)
        System.Console.WriteLine("Valor de B = " & b)
        System.Console.WriteLine("Valor de C = " & c)

        x = (b ^ 2 - 4 * a * c) / (2 * a)

        System.Console.WriteLine("X = " & x)

    End Sub
End Module
