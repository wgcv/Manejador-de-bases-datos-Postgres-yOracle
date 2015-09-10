Public Class usuario
    Private user As String
    Private clave As String
    Private direccion As String
    Private tipo As Integer
    Private port As String

    Public base As String
    Public Sub usuario(usuario As String, clave As String, direccion As String, base As String, tipo As Integer, port As String)
        ' MyBase.New() siempre debe estar en el constructor
        ' Se llama a un procedimiento interno en el que se asignarán otros valores
        Me.user = usuario
        Me.clave = clave
        Me.direccion = direccion
        Me.base = base
        Me.tipo = tipo
        Me.port = port


    End Sub
    Public Function cadena() As String

        If tipo = 1 Then
            Return "Driver={PostgreSQL ANSI};server=" + direccion + ";port=" + port + ";database=" + base + ";uid=" + user + ";sslmode=disable;readonly=0;protocol=7.4;User ID=" + user + ";password=" + clave + ";"
        End If
        If tipo = 2 Then
            Return "Driver={Microsoft ODBC for Oracle};Server=" + direccion + ":" + port + "/" + base + ";uid=" + user + ";Pwd=" + clave + ";"
        End If
        Return ""

    End Function
End Class
