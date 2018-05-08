Module InteresesProducidos1
    Dim monto As Decimal
    Dim interesanual As Single
    Dim tiempo As UShort
    Sub Main()
        Console.WriteLine("Ingrese el monto: ")
        monto = Console.ReadLine()

        Console.WriteLine("Ingrese el interes: ")
        interesanual = Console.ReadLine()

        Console.WriteLine("Ingrese los dias: ")
        tiempo = Console.ReadLine()

        Dim InteresesProducidos As Single = (monto * interesanual * tiempo) / (360 * 100)

        Console.WriteLine("Intereses Producidos | (monto * interes anual * dias) / (360 * 100) = " & InteresesProducidos)
        Console.WriteLine("Monto + Intereses Producidos: " & monto + InteresesProducidos)
    End Sub
End Module
