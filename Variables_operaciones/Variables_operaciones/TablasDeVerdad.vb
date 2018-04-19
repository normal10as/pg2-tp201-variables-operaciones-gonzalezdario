Module TablasDeVerdad
    Dim a As Boolean = True
    Dim b As Boolean = False

    Sub Main()
        Console.WriteLine("Compuerta AND------")
        Console.WriteLine("V | F | " & (a And b))
        Console.WriteLine("F | V | " & (b And a))
        Console.WriteLine("F | F | " & (b And b))
        Console.WriteLine("V | V | " & (a And a))

        Console.WriteLine()
        Console.WriteLine("Compuerta OR-------")
        Console.WriteLine("V | F | " & (a Or b))
        Console.WriteLine("F | V | " & (b Or a))
        Console.WriteLine("F | F | " & (b Or b))
        Console.WriteLine("V | V | " & (a Or a))

        Console.WriteLine()
        Console.WriteLine("Compuerta XOR------")
        Console.WriteLine("V | F | " & (a Xor b))
        Console.WriteLine("F | V | " & (b Xor a))
        Console.WriteLine("F | F | " & (b Xor b))
        Console.WriteLine("V | V | " & (a Xor a))

        Console.WriteLine()
        Console.WriteLine("Compuerta NOT------")
        Console.WriteLine("V | " & (Not a))
        Console.WriteLine("F | " & (Not b))
    End Sub

End Module
