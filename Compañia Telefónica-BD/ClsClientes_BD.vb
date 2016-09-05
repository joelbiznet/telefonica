Imports Compañia_Telefónica_BEAN
Public Class ClsClientes_BD
    Private sql As SqlClient.SqlCommand
    Private cnx As New ClsConexion_Clientes
    Private con As SqlClient.SqlConnection
    Private cmd As String
    Private ret As Integer = -1
    Private ret2 As Integer = -1

    Public Function guardar(xPersona As ClsClientes) As Integer
        'cmd = "INSERT INTO cliente(dni,nombre,apellido,sexo) VALUES('" & xPersona.dni & "','" & xPersona.nombre & "','" & xPersona.apellido & "','" & xPersona.sexo & "')"
        'con = cnx.abrir
        'sql = New SqlClient.SqlCommand(cmd, con)
        'ret = sql.ExecuteNonQuery()
        'If ret = -1 Then
        'Throw New Exception("Error al insertar Cliente")
        'End If
        'cnx.cerrar(con)
        Return ret = 1
    End Function

    Public Function borrar(xnom As String) As Integer
        'cmd = "DELETE FROM cliente WHERE nombre='" & xnom & "'"
        ' con = cnx.abrir
        ' sql = New SqlClient.SqlCommand(cmd, con)
        'ret = sql.ExecuteNonQuery()
        'If ret = -1 Then
        'Throw New Exception("Error al Borrar " & xnom)
        'End If
        'cnx.cerrar(con)
        Return ret = 1
    End Function

    Public Function leeTodo() As Collections.Generic.List(Of ClsClientes)
        ' Dim dato As ClsClientes
        Dim transporte As New Collections.Generic.List(Of ClsClientes)
        ' Dim da As SqlClient.SqlDataAdapter
        ' Dim dt As New System.Data.DataTable
        ' cmd = "SELECT dni,nombre,apellido,sexo FROM cliente ORDER BY nombre"
        ' con = cnx.abrir
        ' da = New SqlClient.SqlDataAdapter(cmd, con)
        ' da.Fill(dt)
        ' cnx.cerrar(con)
        ' If dt.Rows.Count > 0 Then
        ' For Each fila As DataRow In dt.Rows
        ' dato = New ClsClientes
        ' dato.dni = fila("dni")
        ' dato.nombre = fila("nombre")
        ' dato.apellido = fila("apellido")
        ' dato.sexo = fila("sexo")
        ' transporte.Add(dato)
        'Next
        'Else
        'Throw New Exception("No hay datos en Clientes")
        ' End If
        Return transporte
    End Function

    Public Function modificar(persx As ClsClientes) As Integer
        'cmd = "UPDATE cliente SET nombre='" & persx.nombre & "', apellido='" & persx.apellido & "', sexo='" & persx.sexo & "' WHERE dni='" & persx.dni & "'"
        ' con = cnx.abrir
        ' sql = New SqlClient.SqlCommand(cmd, con)
        ' ret = sql.ExecuteNonQuery()
        ' If ret = -1 Then
        ' Throw New Exception("Error al Modificar")
        ' End If
        ' cnx.cerrar(con)
        Return ret
    End Function

    Public Function dameUno(ByVal xdni As String) As ClsClientes
        Dim dato As New ClsClientes
        ' Dim da As SqlClient.SqlDataAdapter
        ' Dim dt As New System.Data.DataTable
        ' dato.dni = "nada"
        ' dato.nombre = "nada"
        ' dato.apellido = "nada"
        ' dato.sexo = "nada"
        ' cmd = "SELECT dni,nombre,apellido,sexo FROM cliente WHERE dni='" & xdni & "'"
        ' con = cnx.abrir
        ' da = New SqlClient.SqlDataAdapter(cmd, con)
        ' da.Fill(dt)
        ' cnx.cerrar(con)
        ' If dt.Rows.Count > 0 Then
        'Dim fila As DataRow = dt.Rows(0)
        'dato.dni = fila("dni")
        'dato.nombre = fila("nombre")
        'dato.apellido = fila("apellido")
        'dato.sexo = fila("sexo")
        'Else
        ' Throw New Exception("Error al Encontrar " & xdni)
        'End If
        Return dato
    End Function
End Class
