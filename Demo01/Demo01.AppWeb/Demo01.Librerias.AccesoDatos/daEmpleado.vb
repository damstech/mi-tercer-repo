Imports System.Data 'CommandType
Imports System.Data.SqlClient 'sqlconnection,sqlcommand,sqlDataReades
Imports System.Collections.Generic 'List(Of)
Imports Demo01.Librerias.EntidadesNegocio 'beEmpleados
Imports System.Configuration 'ConfigurationManager


Public Class daEmpleado
    Public Function Listar() As List(Of beEmpleado)
        Dim lbeEmpleado As List(Of beEmpleado) = Nothing
        Dim strConexion As String = ConfigurationManager.ConnectionStrings("conNW").ConnectionString
        Using con As New SqlConnection(strConexion)
            con.Open()
            Dim cmd As New SqlCommand("uspSabados001", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim drd As SqlDataReader = cmd.ExecuteReader()
            If drd IsNot Nothing Then
                lbeEmpleado = New List(Of beEmpleado)
                Dim obeEmpleado As beEmpleado
                Dim posidEmpleado As Integer = drd.GetOrdinal("EmployeeID")
                Dim posApellido As Integer = drd.GetOrdinal("LastName")
                Dim posNombre As Integer = drd.GetOrdinal("Firstname")
                Dim posFechaNacimiento As Integer = drd.GetOrdinal("BirthDate")
                While drd.Read
                    obeEmpleado = New beEmpleado
                    obeEmpleado.IdEmpleado = drd.Getint32(posidEmpleado)
                    obeEmpleado.Apellido = drd.GetString(posApellido)
                    obeEmpleado.Nombre = drd.GetString(posNombre)
                    obeEmpleado.FechaNacimiento = drd.GetDateTime(posFechaNacimiento)
                    lbeEmpleado.Add(obeEmpleado)
                End While
                drd.Close()
            End If
        End Using 'con.close() con.Dispose() con=Nothing
        Return lbeEmpleado
    End Function
End Class
