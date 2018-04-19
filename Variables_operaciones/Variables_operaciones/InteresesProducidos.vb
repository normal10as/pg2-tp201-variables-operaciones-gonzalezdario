Module InteresesProducidos1
    Dim monto As Integer
    Dim interes As Single
    Dim dias As Integer
    Sub Main()
        Console.WriteLine("Ingrese el monto: ")
        monto = Console.ReadLine()

        Console.WriteLine("Ingrese el interes: ")
        interes = Console.ReadLine()

        Console.WriteLine("Ingrese los dias: ")
        dias = Console.ReadLine()

        Dim InteresesProducidos As Single = (monto * interes * dias) / (360 * 100)

        Console.WriteLine("Intereses Producidos | (monto * interes * dias) / (360 * 100) = " & InteresesProducidos)
    End Sub
End Module
