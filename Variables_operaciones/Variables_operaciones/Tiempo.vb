Module Tiempo
    Dim Hoy As Date
    Sub Main()
        Hoy = Now
        Console.WriteLine("Día: " & Hoy.Day)
        Console.WriteLine("Mes: " & Hoy.Month)
        Console.WriteLine("Hora: " & Hoy.Hour)
        Console.WriteLine("Minuto: " & Hoy.Minute)
    End Sub
End Module
