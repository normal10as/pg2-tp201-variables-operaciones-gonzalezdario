Module DiasFaltantes
    Sub Main()
        Dim Hoy As Date
        Hoy = Now
        Dim FinDeAnio As New DateTime(Year(Now()), 12, 31)
        Console.WriteLine("Faltan {0} dias para fin de año.", FinDeAnio.DayOfYear - Hoy.DayOfYear)
        Console.WriteLine("Hoy es {0} y faltan {1} dias para fin de año.", Hoy.Date, FinDeAnio.DayOfYear - Hoy.DayOfYear)
    End Sub
End Module
