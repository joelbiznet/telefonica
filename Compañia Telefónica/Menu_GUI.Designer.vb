<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_GUI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.btnventas = New System.Windows.Forms.Button()
        Me.btntelf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnclientes
        '
        Me.btnclientes.Location = New System.Drawing.Point(19, 30)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(94, 65)
        Me.btnclientes.TabIndex = 0
        Me.btnclientes.Text = "Clientes"
        Me.btnclientes.UseVisualStyleBackColor = True
        '
        'btnventas
        '
        Me.btnventas.Location = New System.Drawing.Point(90, 138)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(94, 65)
        Me.btnventas.TabIndex = 1
        Me.btnventas.Text = "Ventas"
        Me.btnventas.UseVisualStyleBackColor = True
        '
        'btntelf
        '
        Me.btntelf.Location = New System.Drawing.Point(155, 30)
        Me.btntelf.Name = "btntelf"
        Me.btntelf.Size = New System.Drawing.Size(94, 65)
        Me.btntelf.TabIndex = 2
        Me.btntelf.Text = "Telefonos"
        Me.btntelf.UseVisualStyleBackColor = True
        '
        'Menu_GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 221)
        Me.Controls.Add(Me.btntelf)
        Me.Controls.Add(Me.btnventas)
        Me.Controls.Add(Me.btnclientes)
        Me.Name = "Menu_GUI"
        Me.Text = "MENÚ"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnclientes As System.Windows.Forms.Button
    Friend WithEvents btnventas As System.Windows.Forms.Button
    Friend WithEvents btntelf As System.Windows.Forms.Button

End Class
