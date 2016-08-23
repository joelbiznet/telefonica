Public Class Menu_GUI

    Private Sub btnclientes_Click(sender As Object, e As EventArgs) Handles btnclientes.Click
        Dim cli As New Registro_Clientes_GUI
        cli.Show()
    End Sub

    Private Sub btntelf_Click(sender As Object, e As EventArgs) Handles btntelf.Click
        Dim telf As New Registro_Telf_GUI
        telf.Show()
    End Sub

    Private Sub btnventas_Click(sender As Object, e As EventArgs) Handles btnventas.Click
        Dim venta As New Ventas_GUI
        venta.Show()
    End Sub
End Class
