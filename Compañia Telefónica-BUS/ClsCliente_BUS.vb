Imports Compañia_Telefónica_BEAN
Imports Compañia_Telefónica_BD
Public Class ClsCliente_BUS

    Public Function guardar(persx As ClsClientes) As Integer
        Dim ret As Int16 = -1
        Dim b As New ClsClientes_BD
        If Len(persx.dni) = 0 Then
            Throw New Exception("DNI vacio")
        ElseIf Len(persx.nombre) = 0 Then
            Throw New Exception("Nombre vacio")
        ElseIf Len(persx.apellido) = 0 Then
            Throw New Exception("Apellido vacio")
        ElseIf Len(persx.sexo) = 0 Then
            Throw New Exception("Sexo vacio")
        Else
            ret = b.guardar(persx)
        End If
        Return ret
    End Function

    Public Function dameTodo() As Collections.Generic.List(Of ClsClientes)
        Dim b As New ClsClientes_BD
        Return b.leeTodo
    End Function

    Public Function dameUno(ByVal xdni As String) As ClsClientes
        Dim b As New ClsClientes_BD
        Dim dat As ClsClientes
        If Len(xdni) = 0 Then
            Throw New Exception("DNI a buscar vacio")
        Else
            dat = b.dameUno(xdni)
        End If
        Return dat
    End Function

    Public Function borrar(xnom As String) As Integer
        Dim b As New ClsClientes_BD
        Return b.borrar(xnom)
    End Function


    Public Function modificar(persx As ClsClientes) As Integer
        Dim b As New ClsClientes_BD
        Return b.modificar(persx)
    End Function

End Class
