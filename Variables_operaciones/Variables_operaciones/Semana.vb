Module Semana
    Dim SemanasLaborales As Byte
    Const DiasAño As UShort = 365
    Const DiasSemana As Byte = 7
    Const DiasLaborales As Byte = 241 'valor aleatorio

    Sub Main()
        SemanasLaborales = DiasLaborales / DiasSemana

        System.Console.WriteLine("Cantidad de Semanas del Año: " & DiasAño / DiasSemana)
        System.Console.WriteLine("Cantidad de Semanas Laborales: " & SemanasLaborales)
    End Sub
End Module
