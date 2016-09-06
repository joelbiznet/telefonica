Imports Compañia_Telefónica_BEAN
Imports Compañia_Telefónica_BUS
Public Class Registro_Clientes_GUI
    Private modificar As Boolean = False
    Private Sub LimpiarTexts()
        txtdni.Text = String.Empty
        txtnombre.Text = String.Empty
        txtapellido.Text = String.Empty
        cmbsexo.Text = String.Empty
    End Sub

    Private Sub Registro_Clientes_GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbsexo.Items.Add("Hombre")
        cmbsexo.Items.Add("Mujer")
        cargarDatos()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim cliente01 As New ClsClientes
        Dim p As New ClsCliente_BUS
        cliente01.nombre = Trim(txtnombre.Text)
        cliente01.apellido = Trim(txtapellido.Text)
        cliente01.dni = Trim(txtdni.Text)
        cliente01.sexo = Trim(cmbsexo.Text)
        Try
            If modificar Then
                If p.modificar(cliente01) > 0 Then
                    MsgBox("Se modificó correctamente")
                    botones(modificar)
                    dgvcliente.Enabled = modificar
                    btnmodificar.Text = "Modificar"
                Else
                    MsgBox("Error al modificar")
                    Exit Sub
                End If
                modificar = Not modificar
            Else
                If p.guardar(cliente01) > 0 Then
                    MsgBox("Se guardó correctamente")
                Else
                    MsgBox("Error al guardar")
                    Exit Sub
                End If
            End If
            LimpiarTexts()
            dgvcliente.Rows.Clear()
            cargarDatos()
            txtdni.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cargarDatos()
        Dim bb As New ClsCliente_BUS
        Dim datos As New Collections.Generic.List(Of ClsClientes)
        Try
            datos = bb.dameTodo
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        For Each fila In datos
            dgvcliente.Rows.Add(fila.dni, fila.nombre, fila.apellido, fila.sexo)
        Next

    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim bb As New ClsCliente_BUS
        Dim hallado As New ClsClientes
        Dim buscado As String = Trim(txtbuscarnombre.Text)
        Try
            hallado = bb.dameUno(buscado)
            If hallado.nombre = "nada" Then
                MsgBox("No se encontró " & buscado)
                txtbuscarnombre.Text = String.Empty
            Else
                lblresultado.Text = hallado.nombre & " " & hallado.apellido
                For Each fila As DataGridViewRow In dgvcliente.Rows
                    fila.Selected = False
                    If UCase(fila.Cells(0).Value) = UCase(buscado) Then
                        fila.Selected = True
                        dgvcliente.CurrentCell = dgvcliente.Rows(fila.Index).Cells(0)
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        Dim ret As Byte = 0
        Dim xnom As String
        Dim p As New ClsCliente_BUS
        xnom = dgvcliente.CurrentRow.Cells(1).Value
        ret = MsgBox("Está seguro de borrar " & xnom & " ??", vbYesNo + vbExclamation, xnom & " se borrará")
        If ret = 6 Then
            ret = 0
            Try
                If p.borrar(xnom) = 0 Then
                    MsgBox("Error al borrar " & xnom)
                Else
                    MsgBox("Se borró correctamente " & xnom)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            dgvcliente.Rows.Clear()
            cargarDatos()
        End If

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If modificar Then
            btnmodificar.Text = "Modificar"
            LimpiarTexts()
        Else
            btnmodificar.Text = "Cancelar"
            txtdni.Text = dgvcliente.CurrentRow.Cells(0).Value
            txtnombre.Text = dgvcliente.CurrentRow.Cells(1).Value
            txtapellido.Text = dgvcliente.CurrentRow.Cells(2).Value
            cmbsexo.Text = dgvcliente.CurrentRow.Cells(3).Value
        End If
        dgvcliente.Enabled = modificar
        botones(modificar)
        modificar = Not modificar
    End Sub
    Private Sub botones(flag As Boolean)
        txtdni.Enabled = flag
        btnBuscar.Enabled = flag
        btnBorrar.Enabled = flag
    End Sub
End Class