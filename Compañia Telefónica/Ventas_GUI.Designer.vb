<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas_GUI
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.btnbuscardni = New System.Windows.Forms.Button()
        Me.btnbuscartelf = New System.Windows.Forms.Button()
        Me.dgvventa = New System.Windows.Forms.DataGridView()
        Me.btncomprar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nupcantidad = New System.Windows.Forms.NumericUpDown()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblresultadodni = New System.Windows.Forms.Label()
        Me.lblresultadocodigo = New System.Windows.Forms.Label()
        CType(Me.dgvventa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "DNI:"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(115, 29)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(100, 20)
        Me.txtdni.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "CODIGO:"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(115, 110)
        Me.txtcodigo.MaxLength = 8
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 22
        '
        'btnbuscardni
        '
        Me.btnbuscardni.Location = New System.Drawing.Point(243, 27)
        Me.btnbuscardni.Name = "btnbuscardni"
        Me.btnbuscardni.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscardni.TabIndex = 24
        Me.btnbuscardni.Text = "BUSCAR"
        Me.btnbuscardni.UseVisualStyleBackColor = True
        '
        'btnbuscartelf
        '
        Me.btnbuscartelf.Location = New System.Drawing.Point(243, 108)
        Me.btnbuscartelf.Name = "btnbuscartelf"
        Me.btnbuscartelf.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscartelf.TabIndex = 25
        Me.btnbuscartelf.Text = "BUSCAR"
        Me.btnbuscartelf.UseVisualStyleBackColor = True
        '
        'dgvventa
        '
        Me.dgvventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvventa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNI, Me.CODIGO, Me.CANTIDAD})
        Me.dgvventa.Location = New System.Drawing.Point(21, 246)
        Me.dgvventa.Name = "dgvventa"
        Me.dgvventa.Size = New System.Drawing.Size(330, 141)
        Me.dgvventa.TabIndex = 34
        '
        'btncomprar
        '
        Me.btncomprar.Location = New System.Drawing.Point(357, 261)
        Me.btncomprar.Name = "btncomprar"
        Me.btncomprar.Size = New System.Drawing.Size(91, 36)
        Me.btncomprar.TabIndex = 35
        Me.btncomprar.Text = "COMPRAR"
        Me.btncomprar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Cantidad:"
        '
        'nupcantidad
        '
        Me.nupcantidad.Location = New System.Drawing.Point(115, 195)
        Me.nupcantidad.Name = "nupcantidad"
        Me.nupcantidad.Size = New System.Drawing.Size(44, 20)
        Me.nupcantidad.TabIndex = 37
        Me.nupcantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(357, 328)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(91, 36)
        Me.btnborrar.TabIndex = 38
        Me.btnborrar.Text = "BORRAR"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'DNI
        '
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "CODIGO TELF"
        Me.CODIGO.Name = "CODIGO"
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        '
        'lblresultadodni
        '
        Me.lblresultadodni.AutoSize = True
        Me.lblresultadodni.Location = New System.Drawing.Point(112, 75)
        Me.lblresultadodni.Name = "lblresultadodni"
        Me.lblresultadodni.Size = New System.Drawing.Size(73, 13)
        Me.lblresultadodni.TabIndex = 39
        Me.lblresultadodni.Text = "RESULTADO"
        '
        'lblresultadocodigo
        '
        Me.lblresultadocodigo.AutoSize = True
        Me.lblresultadocodigo.Location = New System.Drawing.Point(112, 156)
        Me.lblresultadocodigo.Name = "lblresultadocodigo"
        Me.lblresultadocodigo.Size = New System.Drawing.Size(73, 13)
        Me.lblresultadocodigo.TabIndex = 40
        Me.lblresultadocodigo.Text = "RESULTADO"
        '
        'Ventas_GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 399)
        Me.Controls.Add(Me.lblresultadocodigo)
        Me.Controls.Add(Me.lblresultadodni)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.nupcantidad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btncomprar)
        Me.Controls.Add(Me.dgvventa)
        Me.Controls.Add(Me.btnbuscartelf)
        Me.Controls.Add(Me.btnbuscardni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdni)
        Me.Name = "Ventas_GUI"
        Me.Text = "Ventas_GUI"
        CType(Me.dgvventa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscardni As System.Windows.Forms.Button
    Friend WithEvents btnbuscartelf As System.Windows.Forms.Button
    Friend WithEvents dgvventa As System.Windows.Forms.DataGridView
    Friend WithEvents btncomprar As System.Windows.Forms.Button
    Friend WithEvents DNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nupcantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents lblresultadodni As System.Windows.Forms.Label
    Friend WithEvents lblresultadocodigo As System.Windows.Forms.Label
End Class
