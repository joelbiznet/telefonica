Imports Compañia_Telefónica_BEAN
Public Class ClsTelf_BD
    Private sql As SqlClient.SqlCommand
    Private cnx As New ClsConexion_Telf
    Private con As SqlClient.SqlConnection
    Private cmd As String
    Private ret As Integer = -1

    Public Function guardar(xtelf As ClsTelefonos) As Integer
        cmd = "INSERT INTO telefono(cod_telf,marca,modelo,precio) VALUES('" & xtelf.cod_telf & "','" & xtelf.marca & "','" & xtelf.modelo & "','" & xtelf.precio & "')"
        con = cnx.abrir
        sql = New SqlClient.SqlCommand(cmd, con)
        ret = sql.ExecuteNonQuery()
        If ret = -1 Then
            Throw New Exception("Error al insertar Teléfono")
        End If
        cnx.cerrar(con)
        Return ret
    End Function

    Public Function borrar(xcod As String) As Integer
        cmd = "DELETE FROM telefono WHERE cod_telf='" & xcod & "'"
        con = cnx.abrir
        sql = New SqlClient.SqlCommand(cmd, con)
        ret = sql.ExecuteNonQuery()
        If ret = -1 Then
            Throw New Exception("Error al Borrar " & xcod)
        End If
        cnx.cerrar(con)
        Return ret
    End Function

    Public Function leeTodo() As Collections.Generic.List(Of ClsTelefonos)
        Dim dato As ClsTelefonos
        Dim transporte As New Collections.Generic.List(Of ClsTelefonos)
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As New System.Data.DataTable
        cmd = "SELECT cod_telf,marca,modelo,precio FROM telefono ORDER BY marca"
        con = cnx.abrir
        da = New SqlClient.SqlDataAdapter(cmd, con)
        da.Fill(dt)
        cnx.cerrar(con)
        If dt.Rows.Count > 0 Then
            For Each fila As DataRow In dt.Rows
                dato = New ClsTelefonos
                dato.cod_telf = fila("cod_telf")
                dato.marca = fila("marca")
                dato.modelo = fila("modelo")
                dato.precio = fila("precio")
                transporte.Add(dato)
            Next
        Else
            Throw New Exception("No hay datos en Teléfonos")
        End If
        Return transporte
    End Function

    Public Function modificar(telfx As ClsTelefonos) As Integer
        cmd = "UPDATE telefono SET marca='" & telfx.marca & "', modelo='" & telfx.modelo & "', precio='" & telfx.precio & "' WHERE cod_telf='" & telfx.cod_telf & "'"
        con = cnx.abrir
        sql = New SqlClient.SqlCommand(cmd, con)
        ret = sql.ExecuteNonQuery()
        If ret = -1 Then
            Throw New Exception("Error al Modificar")
        End If
        cnx.cerrar(con)
        Return ret
    End Function

    Public Function dameUno(ByVal xmod As String) As ClsTelefonos
        Dim dato As New ClsTelefonos
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As New System.Data.DataTable
        dato.cod_telf = "nada"
        dato.marca = "nada"
        dato.modelo = "nada"
        dato.precio = 0
        cmd = "SELECT cod_telf,marca,modelo,precio FROM telefono WHERE modelo='" & xmod & "'"
        con = cnx.abrir
        da = New SqlClient.SqlDataAdapter(cmd, con)
        da.Fill(dt)
        cnx.cerrar(con)
        If dt.Rows.Count > 0 Then
            Dim fila As DataRow = dt.Rows(0)
            dato.cod_telf = fila("cod_telf")
            dato.marca = fila("marca")
            dato.modelo = fila("modelo")
            dato.precio = fila("precio")
        Else
            Throw New Exception("Error al Borrar " & xmod)
        End If
        Return dato
    End Function
End Class
