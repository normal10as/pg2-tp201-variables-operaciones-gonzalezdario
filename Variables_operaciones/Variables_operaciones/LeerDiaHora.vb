Module LeerDiaHora
    Dim hora As Integer
    Dim dia As Integer
    Sub Main()
        Dim Hoy As Date
        Hoy = Now

        Console.WriteLine("Ingrese un día/1 al 31: ")
        dia = Console.ReadLine()

        Console.WriteLine("Ingrese una Hora/0 a 23hs: ")
        hora = Console.ReadLine()

        Dim nuevo As New DateTime(Hoy.Year, Hoy.Month, dia, hora, Hoy.Minute, Hoy.Second)

        Console.WriteLine("Resultado: " & nuevo)

    End Sub

End Module
