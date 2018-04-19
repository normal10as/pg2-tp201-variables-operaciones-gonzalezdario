Module Variables
    Private Nombre As String
    Friend TipoDocumento As String
    Friend NumeroDocumento As UInteger
    Private Localidad As String
    Friend FechaNacimiento As Date
    Dim Edad As Byte
    Private AlturaCorporalCm As Byte
    Private EstadoCivil As String
    Private Argentino As Boolean

    Sub Main()
        Nombre = "Pepe"
        TipoDocumento = "DNI"
        NumeroDocumento = 40456768
        Localidad = "Apostoles"
        Edad = 27
        AlturaCorporalCm = 175
        EstadoCivil = "Casado"
        Argentino = True

        System.Console.WriteLine("Nombre: " & Nombre)
        System.Console.WriteLine("Tipo de Documento: " & TipoDocumento)
        System.Console.WriteLine("Numero de Documento: " & NumeroDocumento)
        System.Console.WriteLine("Localidad: " & Localidad)
        System.Console.WriteLine("Fecha de Nacimiento: " & FechaNacimiento)
        System.Console.WriteLine("Edad: " & Edad)
        System.Console.WriteLine("Altura Corporal/Cm: " & AlturaCorporalCm)
        System.Console.WriteLine("Estado Civil: " & EstadoCivil)
        System.Console.WriteLine("Argentino: " & Argentino)
    End Sub
End Module
