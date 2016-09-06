<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Telf_GUI
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
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.dgvtelf = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtbuscarmodelo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvtelf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Location = New System.Drawing.Point(114, 247)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(76, 13)
        Me.lblresultado.TabIndex = 31
        Me.lblresultado.Text = "RESULTADO:"
        '
        'dgvtelf
        '
        Me.dgvtelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtelf.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.MARCA, Me.MODELO, Me.PRECIO})
        Me.dgvtelf.Location = New System.Drawing.Point(21, 282)
        Me.dgvtelf.Name = "dgvtelf"
        Me.dgvtelf.Size = New System.Drawing.Size(279, 150)
        Me.dgvtelf.TabIndex = 30
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        '
        'MARCA
        '
        Me.MARCA.HeaderText = "MARCA"
        Me.MARCA.Name = "MARCA"
        '
        'MODELO
        '
        Me.MODELO.HeaderText = "MODELO"
        Me.MODELO.Name = "MODELO"
        '
        'PRECIO
        '
        Me.PRECIO.HeaderText = "PRECIO"
        Me.PRECIO.Name = "PRECIO"
        '
        'txtbuscarmodelo
        '
        Me.txtbuscarmodelo.Location = New System.Drawing.Point(117, 202)
        Me.txtbuscarmodelo.Name = "txtbuscarmodelo"
        Me.txtbuscarmodelo.Size = New System.Drawing.Size(100, 20)
        Me.txtbuscarmodelo.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 26)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Buscar por " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MODELO:"
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(316, 384)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 27
        Me.btnmodificar.Text = "MODIFICAR"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(316, 318)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(75, 23)
        Me.btnborrar.TabIndex = 26
        Me.btnborrar.Text = "BORRAR"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(254, 203)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 25
        Me.btnbuscar.Text = "BUSCAR"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Precio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Marca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Modelo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "CODIGO:"
        '
        'txtmodelo
        '
        Me.txtmodelo.Location = New System.Drawing.Point(117, 100)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(100, 20)
        Me.txtmodelo.TabIndex = 19
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(117, 61)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(100, 20)
        Me.txtmarca.TabIndex = 18
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(117, 26)
        Me.txtcodigo.MaxLength = 8
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 17
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(254, 68)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 16
        Me.btnguardar.Text = "GUARDAR"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(142, 143)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(75, 20)
        Me.txtprecio.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(114, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "S.\"
        '
        'Registro_Telf_GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 449)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.dgvtelf)
        Me.Controls.Add(Me.txtbuscarmodelo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmodelo)
        Me.Controls.Add(Me.txtmarca)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.btnguardar)
        Me.Name = "Registro_Telf_GUI"
        Me.Text = "Registro_Telf_GUI"
        CType(Me.dgvtelf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblresultado As System.Windows.Forms.Label
    Friend WithEvents dgvtelf As System.Windows.Forms.DataGridView
    Friend WithEvents txtbuscarmodelo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmodelo As System.Windows.Forms.TextBox
    Friend WithEvents txtmarca As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
