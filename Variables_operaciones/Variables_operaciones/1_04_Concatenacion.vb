Module Concatenacion
    Dim NombreEmpresa As String = "Pepe Inc"
    Dim NombreCalle As String = "Calle Falsa"
    Dim AlturaCalle As UShort = 123
    Dim InicioClases As Date

    Sub Main()
        System.Console.WriteLine(InicioClases)
        System.Console.WriteLine(NombreEmpresa + " | " + NombreCalle + " | " + Convert.ToString(AlturaCalle) + " | " + Convert.ToString(InicioClases))
        System.Console.WriteLine(NombreEmpresa & " | " & NombreCalle & " | " & AlturaCalle & " | " & InicioClases)
    End Sub
End Module
