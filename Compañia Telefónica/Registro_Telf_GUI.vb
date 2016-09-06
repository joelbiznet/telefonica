Imports Compañia_Telefónica_BEAN
Imports Compañia_Telefónica_BUS
Public Class Registro_Telf_GUI
    Private modificar As Boolean = False
    Private Sub LimpiarTexts()
        txtmodelo.Text = String.Empty
        txtcodigo.Text = String.Empty
        txtmarca.Text = String.Empty
        txtprecio.Text = String.Empty
    End Sub

    Private Sub Registro_Telf_GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim telf01 As New ClsTelefonos
        Dim p As New ClsTelf_BUS
        telf01.cod_telf = Trim(txtcodigo.Text)
        telf01.marca = Trim(txtmarca.Text)
        telf01.modelo = Trim(txtmodelo.Text)
        telf01.precio = Trim(txtprecio.Text)
        Try
            If modificar Then
                If p.modificar(telf01) > 0 Then
                    MsgBox("Se modificó correctamente")
                    botones(modificar)
                    dgvtelf.Enabled = modificar
                    btnmodificar.Text = "Modificar"
                Else
                    MsgBox("Error al modificar")
                    Exit Sub
                End If
                modificar = Not modificar
            Else
                If p.guardar(telf01) > 0 Then
                    MsgBox("Se guardó correctamente")
                Else
                    MsgBox("Error al guardar")
                    Exit Sub
                End If
            End If
            LimpiarTexts()
            dgvtelf.Rows.Clear()
            cargarDatos()
            txtcodigo.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarDatos()
        Dim bb As New ClsTelf_BUS
        Dim datos As New Collections.Generic.List(Of ClsTelefonos)
        Try
            datos = bb.dameTodo
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        For Each fila In datos
            dgvtelf.Rows.Add(fila.cod_telf, fila.marca, fila.modelo, fila.precio)
        Next
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim bb As New ClsTelf_BUS
        Dim hallado As New ClsTelefonos
        Dim buscado As String = Trim(txtbuscarmodelo.Text)
        Try
            hallado = bb.dameUno(buscado)
            If hallado.modelo = "nada" Then
                MsgBox("No se encontró " & buscado)
                txtbuscarmodelo.Text = String.Empty
            Else
                lblresultado.Text = hallado.marca & "    " & hallado.modelo
                For Each fila As DataGridViewRow In dgvtelf.Rows
                    fila.Selected = False
                    If UCase(fila.Cells(2).Value) = UCase(buscado) Then
                        fila.Selected = True
                        dgvtelf.CurrentCell = dgvtelf.Rows(fila.Index).Cells(0)
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        Dim ret As Byte = 0
        Dim xcod As String
        Dim xmod As String
        Dim p As New ClsTelf_BUS
        xcod = dgvtelf.CurrentRow.Cells(0).Value
        xmod = dgvtelf.CurrentRow.Cells(2).Value
        ret = MsgBox("Está seguro de borrar " & xmod & " ??", vbYesNo + vbExclamation, xmod & " se borrará")
        If ret = 6 Then
            ret = 0
            Try
                If p.borrar(xcod) = 0 Then
                    MsgBox("Error al borrar " & xmod)
                Else
                    MsgBox("Se borró correctamente " & xmod)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            dgvtelf.Rows.Clear()
            cargarDatos()
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If modificar Then
            btnmodificar.Text = "Modificar"
            LimpiarTexts()
        Else
            btnmodificar.Text = "Cancelar"
            txtcodigo.Text = dgvtelf.CurrentRow.Cells(0).Value
            txtmarca.Text = dgvtelf.CurrentRow.Cells(1).Value
            txtmodelo.Text = dgvtelf.CurrentRow.Cells(2).Value
            txtprecio.Text = dgvtelf.CurrentRow.Cells(3).Value
        End If
        dgvtelf.Enabled = modificar
        botones(modificar)
        modificar = Not modificar
    End Sub
    Private Sub botones(flag As Boolean)
        txtcodigo.Enabled = flag
        btnBuscar.Enabled = flag
        btnBorrar.Enabled = flag
    End Sub
End Class