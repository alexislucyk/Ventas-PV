<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_productos
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abm_productos))
        Button1 = New Button()
        Label1 = New Label()
        txCodigo = New TextBox()
        txDescripcion = New TextBox()
        Label2 = New Label()
        txPrecioCompra = New TextBox()
        Label3 = New Label()
        txPrecioVenta = New TextBox()
        Label4 = New Label()
        txStock = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txFecha = New DateTimePicker()
        ComboRubros = New ComboBox()
        ComboProveedores = New ComboBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Button2 = New Button()
        ImageList1 = New ImageList(components)
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        CheckBox1 = New CheckBox()
        txBuscador = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(392, 18)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(56, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 1
        Label1.Text = "Código"
        ' 
        ' txCodigo
        ' 
        txCodigo.Location = New Point(119, 20)
        txCodigo.Name = "txCodigo"
        txCodigo.Size = New Size(263, 23)
        txCodigo.TabIndex = 2
        ' 
        ' txDescripcion
        ' 
        txDescripcion.Location = New Point(119, 52)
        txDescripcion.Multiline = True
        txDescripcion.Name = "txDescripcion"
        txDescripcion.Size = New Size(348, 76)
        txDescripcion.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 3
        Label2.Text = "Descripción"
        ' 
        ' txPrecioCompra
        ' 
        txPrecioCompra.Location = New Point(602, 55)
        txPrecioCompra.Name = "txPrecioCompra"
        txPrecioCompra.Size = New Size(131, 23)
        txPrecioCompra.TabIndex = 6
        txPrecioCompra.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(498, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 5
        Label3.Text = "Precio compra"
        ' 
        ' txPrecioVenta
        ' 
        txPrecioVenta.Location = New Point(602, 84)
        txPrecioVenta.Name = "txPrecioVenta"
        txPrecioVenta.Size = New Size(131, 23)
        txPrecioVenta.TabIndex = 8
        txPrecioVenta.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(510, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 7
        Label4.Text = "Precio venta"
        ' 
        ' txStock
        ' 
        txStock.Location = New Point(602, 113)
        txStock.Name = "txStock"
        txStock.Size = New Size(131, 23)
        txStock.TabIndex = 10
        txStock.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(546, 116)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 9
        Label5.Text = "Stock"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(5, 140)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 15)
        Label6.TabIndex = 11
        Label6.Text = "F.Ultima Compra"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(64, 175)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 13
        Label7.Text = "Rubro"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(42, 204)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 15)
        Label8.TabIndex = 15
        Label8.Text = "Proveedor"
        ' 
        ' txFecha
        ' 
        txFecha.Format = DateTimePickerFormat.Short
        txFecha.Location = New Point(119, 134)
        txFecha.Name = "txFecha"
        txFecha.Size = New Size(263, 23)
        txFecha.TabIndex = 17
        ' 
        ' ComboRubros
        ' 
        ComboRubros.FormattingEnabled = True
        ComboRubros.Location = New Point(119, 167)
        ComboRubros.Name = "ComboRubros"
        ComboRubros.Size = New Size(263, 23)
        ComboRubros.TabIndex = 18
        ' 
        ' ComboProveedores
        ' 
        ComboProveedores.FormattingEnabled = True
        ComboProveedores.Location = New Point(119, 196)
        ComboProveedores.Name = "ComboProveedores"
        ComboProveedores.Size = New Size(263, 23)
        ComboProveedores.TabIndex = 19
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8})
        DataGridView1.Location = New Point(5, 225)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(742, 267)
        DataGridView1.TabIndex = 20
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "cod_prod"
        Column1.HeaderText = "Código"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "Descripcion"
        Column2.HeaderText = "Descripcion"
        Column2.Name = "Column2"
        Column2.Width = 350
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "p_compra"
        Column3.HeaderText = "P.Compra"
        Column3.Name = "Column3"
        Column3.Width = 70
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "p_venta"
        Column4.HeaderText = "P.Venta"
        Column4.Name = "Column4"
        Column4.Width = 70
        ' 
        ' Column5
        ' 
        Column5.DataPropertyName = "stock"
        Column5.HeaderText = "Stock"
        Column5.Name = "Column5"
        Column5.Width = 50
        ' 
        ' Column6
        ' 
        Column6.DataPropertyName = "fecha_ult_compra"
        Column6.HeaderText = "F.Ult.Compra"
        Column6.Name = "Column6"
        Column6.Width = 80
        ' 
        ' Column7
        ' 
        Column7.DataPropertyName = "rubro"
        Column7.HeaderText = "Rubro"
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.DataPropertyName = "proveedor"
        Column8.HeaderText = "Proveedor"
        Column8.Name = "Column8"
        Column8.Width = 130
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ImageKey = "borrar.png"
        Button2.ImageList = ImageList1
        Button2.Location = New Point(405, 153)
        Button2.Name = "Button2"
        Button2.Size = New Size(79, 66)
        Button2.TabIndex = 21
        Button2.Text = "Borrar"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.TextImageRelation = TextImageRelation.ImageAboveText
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "aceptar.png")
        ImageList1.Images.SetKeyName(1, "admin.png")
        ImageList1.Images.SetKeyName(2, "agenda.png")
        ImageList1.Images.SetKeyName(3, "borrar.png")
        ImageList1.Images.SetKeyName(4, "cajas.png")
        ImageList1.Images.SetKeyName(5, "canasto.png")
        ImageList1.Images.SetKeyName(6, "cliente.png")
        ImageList1.Images.SetKeyName(7, "config.png")
        ImageList1.Images.SetKeyName(8, "editar.png")
        ImageList1.Images.SetKeyName(9, "etiqueta.png")
        ImageList1.Images.SetKeyName(10, "filtro.png")
        ImageList1.Images.SetKeyName(11, "guardar.png")
        ImageList1.Images.SetKeyName(12, "hoja.png")
        ImageList1.Images.SetKeyName(13, "hoja2.png")
        ImageList1.Images.SetKeyName(14, "papelera.png")
        ImageList1.Images.SetKeyName(15, "pdf.png")
        ImageList1.Images.SetKeyName(16, "pilot.png")
        ImageList1.Images.SetKeyName(17, "Salir.png")
        ImageList1.Images.SetKeyName(18, "stock.png")
        ImageList1.Images.SetKeyName(19, "suit.png")
        ImageList1.Images.SetKeyName(20, "nuevo_reg.png")
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ImageKey = "aceptar.png"
        Button3.ImageList = ImageList1
        Button3.Location = New Point(576, 153)
        Button3.Name = "Button3"
        Button3.Size = New Size(79, 66)
        Button3.TabIndex = 22
        Button3.Text = "Guardar"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ImageKey = "Salir.png"
        Button4.ImageList = ImageList1
        Button4.Location = New Point(661, 153)
        Button4.Name = "Button4"
        Button4.Size = New Size(79, 66)
        Button4.TabIndex = 23
        Button4.Text = "Cerrar"
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ImageKey = "nuevo_reg.png"
        Button5.ImageList = ImageList1
        Button5.Location = New Point(491, 153)
        Button5.Name = "Button5"
        Button5.Size = New Size(79, 66)
        Button5.TabIndex = 24
        Button5.Text = "Nuevo"
        Button5.TextAlign = ContentAlignment.BottomCenter
        Button5.TextImageRelation = TextImageRelation.ImageAboveText
        Button5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(492, 7)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(127, 19)
        CheckBox1.TabIndex = 25
        CheckBox1.Text = "Buscar por nombre"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' txBuscador
        ' 
        txBuscador.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        txBuscador.Location = New Point(491, 23)
        txBuscador.Name = "txBuscador"
        txBuscador.Size = New Size(242, 23)
        txBuscador.TabIndex = 26
        txBuscador.Visible = False
        ' 
        ' abm_productos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(758, 504)
        ControlBox = False
        Controls.Add(txBuscador)
        Controls.Add(CheckBox1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(ComboProveedores)
        Controls.Add(ComboRubros)
        Controls.Add(txFecha)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(txStock)
        Controls.Add(Label5)
        Controls.Add(txPrecioVenta)
        Controls.Add(Label4)
        Controls.Add(txPrecioCompra)
        Controls.Add(Label3)
        Controls.Add(txDescripcion)
        Controls.Add(Label2)
        Controls.Add(txCodigo)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "abm_productos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Alta, Baja y Modificación de productos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txCodigo As TextBox
    Friend WithEvents txDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txPrecioCompra As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txPrecioVenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txStock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txFecha As DateTimePicker
    Friend WithEvents ComboRubros As ComboBox
    Friend WithEvents ComboProveedores As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txBuscador As TextBox
End Class
