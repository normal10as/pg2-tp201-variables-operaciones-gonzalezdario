Module Aritmetica
    Const a As UInteger = 5
    Const b As UInteger = 8
    Const c As Single = 2.12
    Const d As Single = 3.15

    Sub Main()
        System.Console.WriteLine("Suma de dos enteros: " & a & " + " & b & " = " & a + b)
        System.Console.WriteLine("Resta de dos enteros: " & b & " - " & a & " = " & b - a)
        System.Console.WriteLine("Multiplicacion de dos enteros: " & a & " x " & b & " = " & a * b)
        System.Console.WriteLine("Division de dos enteros: " & a & " / " & b & " = " & a / b)

        System.Console.WriteLine()

        System.Console.WriteLine("Suma de dos v.p. flotante: " & c & " + " & d & " = " & c + d)
        System.Console.WriteLine("Resta de dos v.p. flotante: " & d & " - " & c & " = " & d - c)
        System.Console.WriteLine("Multiplicacion de dos v.p. flotante: " & c & " x " & d & " = " & c * d)
        System.Console.WriteLine("Division de dos v.p. flotante: " & c & " / " & d & " = " & c / d)

        System.Console.WriteLine()

        System.Console.WriteLine("Suma de un entero con un v.p. flotante: " & a & " + " & c & " = " & a + c)
        System.Console.WriteLine("Resta de un entero con un v.p. flotante: " & b & " + " & d & " = " & b - d)
        System.Console.WriteLine("Multiplicacion de un entero con un v.p. flotante: " & b & " x " & c & " = " & b * c)
        System.Console.WriteLine("Division de un entero con un v.p. flotante: " & a & " / " & d & " = " & a / d)
    End Sub
End Module
