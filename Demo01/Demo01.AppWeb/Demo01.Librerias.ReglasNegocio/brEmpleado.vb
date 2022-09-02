Imports System.Collections.Generic 'List(Of)
Imports Demo01.Librerias.EntidadesNegocio 'beEmpleado
Imports Demo01.Librerias.AccesoDatos 'daEmpleado

Public Class brEmpleado
    Public Function Listar() As List(Of beEmpleado)
        Dim ibeEmpleado As List(Of beEmpleado) = Nothing
        Dim odaEmpleado As New daEmpleado
        ibeEmpleado = odaEmpleado.Listar()
        Return ibeEmpleado
    End Function
End Class
