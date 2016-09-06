Imports Compañia_Telefónica_BEAN
Imports Compañia_Telefónica_BUS
Public Class Ventas_GUI

    Private Sub btnbuscardni_Click(sender As Object, e As EventArgs) Handles btnbuscardni.Click
        Dim bb As New ClsVentas_BUS
        Dim hallado As New ClsClientes
        Dim buscado As String = Trim(txtdni.Text)
        Try
            hallado = bb.dameUnocli(buscado)
            If hallado.dni = "nada" Then
                MsgBox("No se encontró " & buscado)
                txtdni.Text = String.Empty
            Else
                lblresultadodni.Text = hallado.nombre & " " & hallado.apellido
                'For Each fila As DataGridViewRow In dgvventa.Rows
                '    fila.Selected = False
                '    If UCase(fila.Cells(0).Value) = UCase(buscado) Then
                '        fila.Selected = True
                '        dgvcliente.CurrentCell = dgvcliente.Rows(fila.Index).Cells(0)
                '    End If
                'Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnbuscartelf_Click(sender As Object, e As EventArgs) Handles btnbuscartelf.Click
        Dim bb As New ClsVentas_BUS
        Dim hallado As New ClsTelefonos
        Dim buscado As String = Trim(txtcodigo.Text)
        Try
            hallado = bb.dameUnotelf(buscado)
            If hallado.cod_telf = "nada" Then
                MsgBox("No se encontró " & buscado)
                txtcodigo.Text = String.Empty
            Else
                lblresultadocodigo.Text = hallado.marca & "    " & hallado.modelo
                'For Each fila As DataGridViewRow In dgvtelf.Rows
                '    fila.Selected = False
                '    If UCase(fila.Cells(2).Value) = UCase(buscado) Then
                '        fila.Selected = True
                '        dgvtelf.CurrentCell = dgvtelf.Rows(fila.Index).Cells(0)
                '    End If
                'Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btncomprar_Click(sender As Object, e As EventArgs) Handles btncomprar.Click
        Dim venta01 As New ClsVentas
        Dim p As New ClsVentas_BUS
        venta01.dni = Trim(txtdni.Text)
        venta01.cod_telf = Trim(txtcodigo.Text)
        venta01.cantidad = Trim(nupcantidad.Text)
        Try
            'If modificar Then
            '    If p.modificar(venta01) > 0 Then
            '        MsgBox("Se modificó correctamente")
            '        botones(modificar)
            '        dgvcliente.Enabled = modificar
            '        btnmodificar.Text = "Modificar"
            '    Else
            '        MsgBox("Error al modificar")
            '        Exit Sub
            '    End If
            '    modificar = Not modificar
            'Else
            If p.guardar(venta01) > 0 Then
                MsgBox("Se guardó correctamente")
            Else
                MsgBox("Error al guardar")
                Exit Sub
            End If
            'End If
            LimpiarTexts()
            dgvventa.Rows.Clear()
            cargarDatos()
            txtdni.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        Dim ret As Byte = 0
        Dim xdni As String
        Dim p As New ClsVentas_BUS
        xdni = dgvventa.CurrentRow.Cells(0).Value
        ret = MsgBox("Está seguro de borrar venta con " & xdni & " ??", vbYesNo + vbExclamation, xdni & " se borrará")
        If ret = 6 Then
            ret = 0
            Try
                If p.borrar(xdni) = 0 Then
                    MsgBox("Error al borrar venta con " & xdni)
                Else
                    MsgBox("Se borró correctamente venta con " & xdni)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            dgvventa.Rows.Clear()
            cargarDatos()
        End If
    End Sub
    Private Sub LimpiarTexts()
        txtdni.Text = String.Empty
        txtcodigo.Text = String.Empty
        nupcantidad.Text = String.Empty
    End Sub
    Private Sub cargarDatos()
        Dim bb As New ClsVentas_BUS
        Dim datos As New Collections.Generic.List(Of ClsVentas)
        Try
            datos = bb.dameTodo
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        For Each fila In datos
            dgvventa.Rows.Add(fila.dni, fila.cod_telf, fila.cantidad)
        Next

    End Sub

    Private Sub Ventas_GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub
End Class