Imports Compañia_Telefónica_BEAN
Imports Compañia_Telefónica_BD
Public Class ClsTelf_BUS
    Private b As New ClsTelf_BD
    Public Function guardar(telfx As ClsTelefonos) As Integer
        Dim ret As Int16 = -1

        If Len(telfx.cod_telf) = 0 Then
            Throw New Exception("CODIGO vacio")
        ElseIf Len(telfx.marca) = 0 Then
            Throw New Exception("Marca vacio")
        ElseIf Len(telfx.modelo) = 0 Then
            Throw New Exception("Modelo vacio")
        ElseIf Len(telfx.precio) = 0 Then
            Throw New Exception("Precio vacio")
        Else
            ret = b.guardar(telfx)
        End If
        Return ret
    End Function

    Public Function dameTodo() As Collections.Generic.List(Of ClsTelefonos)
        Return b.leeTodo
    End Function

    Public Function dameUno(ByVal xmod As String) As ClsTelefonos
        Dim dat As ClsTelefonos
        If Len(xmod) = 0 Then
            Throw New Exception("MODELO a buscar vacio")
        Else
            dat = b.dameUno(xmod)
        End If
        Return dat
    End Function

    Public Function borrar(xcod As String) As Integer
        Return b.borrar(xcod)
    End Function

    Public Function modificar(telfx As ClsTelefonos) As Integer
        Return b.modificar(telfx)
    End Function
End Class
