Imports Compañia_Telefónica_BEAN
Public Class ClsVentas_BD
    Private sql As SqlClient.SqlCommand
    Private cnx As New ClsConexion_Ventas
    Private cnxcli As New ClsConexion_Clientes
    Private cnxtelf As New ClsConexion_Telf
    Private con As SqlClient.SqlConnection
    Private cmd As String
    Private ret As Integer = -1

    Public Function guardar(xvent As ClsVentas) As Integer
        cmd = "INSERT INTO venta(dni,cod_telf,cantidad) VALUES('" & xvent.dni & "','" & xvent.cod_telf & "','" & xvent.cantidad & "')"
        con = cnx.abrir
        sql = New SqlClient.SqlCommand(cmd, con)
        ret = sql.ExecuteNonQuery()
        If ret = -1 Then
            Throw New Exception("Error al insertar Venta")
        End If
        cnx.cerrar(con)
        Return ret
    End Function

    Public Function borrar(xdni As String) As Integer
        cmd = "DELETE FROM venta WHERE dni='" & xdni & "'"
        con = cnx.abrir
        sql = New SqlClient.SqlCommand(cmd, con)
        ret = sql.ExecuteNonQuery()
        If ret = -1 Then
            Throw New Exception("Error al Borrar venta con" & xdni)
        End If
        cnx.cerrar(con)
        Return ret
    End Function

    Public Function leeTodo() As Collections.Generic.List(Of ClsVentas)
        Dim dato As ClsVentas
        Dim transporte As New Collections.Generic.List(Of ClsVentas)
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As New System.Data.DataTable
        cmd = "SELECT dni,cod_telf,cantidad FROM venta ORDER BY dni"
        con = cnx.abrir
        da = New SqlClient.SqlDataAdapter(cmd, con)
        da.Fill(dt)
        cnx.cerrar(con)
        If dt.Rows.Count > 0 Then
            For Each fila As DataRow In dt.Rows
                dato = New ClsVentas
                dato.dni = fila("dni")
                dato.cod_telf = fila("cod_telf")
                dato.cantidad = fila("cantidad")
                transporte.Add(dato)
            Next
        Else
            Throw New Exception("No hay datos en Ventas")
        End If
        Return transporte
    End Function
    Public Function dameUnocli(ByVal xdni As String) As ClsClientes
        Dim dato As New ClsClientes
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As New System.Data.DataTable
        dato.nombre = "nada"
        dato.apellido = "nada"
        cmd = "SELECT nombre,apellido FROM cliente WHERE dni='" & xdni & "'"
        con = cnxcli.abrir
        da = New SqlClient.SqlDataAdapter(cmd, con)
        da.Fill(dt)
        cnxcli.cerrar(con)
        If dt.Rows.Count > 0 Then
            Dim fila As DataRow = dt.Rows(0)
            dato.nombre = fila("nombre")
            dato.apellido = fila("apellido")
        Else
            Throw New Exception("Error al Encontrar " & xdni)
        End If
        Return dato
    End Function
    Public Function dameUnotelf(ByVal xcod As String) As ClsTelefonos
        Dim dato As New ClsTelefonos
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As New System.Data.DataTable
        dato.marca = "nada"
        dato.modelo = "nada"
        cmd = "SELECT marca,modelo FROM telefono WHERE cod_telf='" & xcod & "'"
        con = cnxtelf.abrir
        da = New SqlClient.SqlDataAdapter(cmd, con)
        da.Fill(dt)
        cnxtelf.cerrar(con)
        If dt.Rows.Count > 0 Then
            Dim fila As DataRow = dt.Rows(0)
            dato.marca = fila("marca")
            dato.modelo = fila("modelo")
        Else
            Throw New Exception("Error al Encontrar " & xcod)
        End If
        Return dato
    End Function
End Class
