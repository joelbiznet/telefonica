Imports Compañia_Telefónica_BEAN
Imports Compañia_Telefónica_BD
Public Class ClsVentas_BUS
    Private b As New ClsVentas_BD
    Public Function guardar(ventx As ClsVentas) As Integer
        Dim ret As Int16 = -1

        If Len(ventx.dni) = 0 Then
            Throw New Exception("DNI vacio")
        ElseIf Len(ventx.cod_telf) = 0 Then
            Throw New Exception("CODIGO TELEFONO vacio")
        ElseIf Len(ventx.cantidad) = 0 Then
            Throw New Exception("CANTIDAD vacio")
        Else
            ret = b.guardar(ventx)
        End If
        Return ret
    End Function

    Public Function dameTodo() As Collections.Generic.List(Of ClsVentas)
        Return b.leeTodo
    End Function

    Public Function dameUnocli(ByVal xdni As String) As ClsClientes
        Dim dat As ClsClientes
        If Len(xdni) = 0 Then
            Throw New Exception("DNI a buscar vacio")
        Else
            dat = b.dameUnocli(xdni)
        End If
        Return dat
    End Function
    Public Function dameUnotelf(ByVal xcod As String) As ClsTelefonos
        Dim dat As ClsTelefonos
        If Len(xcod) = 0 Then
            Throw New Exception("CODIGO TELEFONO a buscar vacio")
        Else
            dat = b.dameUnotelf(xcod)
        End If
        Return dat
    End Function

    Public Function borrar(xdni As String) As Integer
        Return b.borrar(xdni)
    End Function
End Class
