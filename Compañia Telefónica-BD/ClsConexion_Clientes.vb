﻿Public Class ClsConexion_Clientes
    Public Function abrir() As SqlClient.SqlConnection
        Dim cnx As New SqlClient.SqlConnection
        cnx.ConnectionString = "Server=EDUARDO\SQLEXPRESS;Database=clientes;user id=admin1;password=123456"
        Try
            cnx.Open()
        Catch ex As Exception
            Throw New Exception("Error abrir conexion")
        End Try
        Return cnx
    End Function

    Public Sub cerrar(cnx As SqlClient.SqlConnection)
        cnx.Close()
    End Sub
End Class
