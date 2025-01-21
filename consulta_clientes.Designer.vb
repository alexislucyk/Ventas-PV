<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consulta_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consulta_clientes))
        txNombre = New TextBox()
        Label3 = New Label()
        txApellido = New TextBox()
        Label2 = New Label()
        Button4 = New Button()
        ImageList1 = New ImageList(components)
        GridClientes = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        CType(GridClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txNombre
        ' 
        txNombre.Location = New Point(355, 19)
        txNombre.Name = "txNombre"
        txNombre.Size = New Size(332, 23)
        txNombre.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(292, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 11
        Label3.Text = "Nombre"
        ' 
        ' txApellido
        ' 
        txApellido.Location = New Point(81, 19)
        txApellido.Name = "txApellido"
        txApellido.Size = New Size(186, 23)
        txApellido.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 10
        Label2.Text = "Apellido"
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ImageKey = "Salir.png"
        Button4.ImageList = ImageList1
        Button4.Location = New Point(609, 310)
        Button4.Name = "Button4"
        Button4.Size = New Size(79, 66)
        Button4.TabIndex = 12
        Button4.Text = "Cerrar"
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Button4.UseVisualStyleBackColor = True
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "aceptar.png")
        ImageList1.Images.SetKeyName(1, "admin.png")
        ImageList1.Images.SetKeyName(2, "agenda.png")
        ImageList1.Images.SetKeyName(3, "borrar.png")
        ImageList1.Images.SetKeyName(4, "buscar.png")
        ImageList1.Images.SetKeyName(5, "cajas.png")
        ImageList1.Images.SetKeyName(6, "canasto.png")
        ImageList1.Images.SetKeyName(7, "cliente.png")
        ImageList1.Images.SetKeyName(8, "config.png")
        ImageList1.Images.SetKeyName(9, "editar.png")
        ImageList1.Images.SetKeyName(10, "etiqueta.png")
        ImageList1.Images.SetKeyName(11, "filtro.png")
        ImageList1.Images.SetKeyName(12, "guardar.png")
        ImageList1.Images.SetKeyName(13, "hoja.png")
        ImageList1.Images.SetKeyName(14, "hoja2.png")
        ImageList1.Images.SetKeyName(15, "lupa.png")
        ImageList1.Images.SetKeyName(16, "nuevo_reg.png")
        ImageList1.Images.SetKeyName(17, "papelera.png")
        ImageList1.Images.SetKeyName(18, "pdf.png")
        ImageList1.Images.SetKeyName(19, "pilot.png")
        ImageList1.Images.SetKeyName(20, "Salir.png")
        ImageList1.Images.SetKeyName(21, "stock.png")
        ImageList1.Images.SetKeyName(22, "suit.png")
        ImageList1.Images.SetKeyName(23, "volver.png")
        ' 
        ' GridClientes
        ' 
        GridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        GridClientes.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        GridClientes.Location = New Point(18, 56)
        GridClientes.Name = "GridClientes"
        GridClientes.RowTemplate.Height = 25
        GridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GridClientes.Size = New Size(670, 248)
        GridClientes.TabIndex = 13
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "id"
        Column1.HeaderText = "Código"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "apellido"
        Column2.HeaderText = "Apellido"
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "nombre"
        Column3.HeaderText = "Nombre"
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "direccion"
        Column4.HeaderText = "Direccion"
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.DataPropertyName = "cuit"
        Column5.HeaderText = "Cuit"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.DataPropertyName = "telefono"
        Column6.HeaderText = "Telefono"
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.DataPropertyName = "estado"
        Column7.HeaderText = "Estado"
        Column7.Name = "Column7"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ImageKey = "volver.png"
        Button1.ImageList = ImageList1
        Button1.Location = New Point(18, 310)
        Button1.Name = "Button1"
        Button1.Size = New Size(51, 40)
        Button1.TabIndex = 14
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' consulta_clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(699, 381)
        ControlBox = False
        Controls.Add(Button1)
        Controls.Add(GridClientes)
        Controls.Add(Button4)
        Controls.Add(txNombre)
        Controls.Add(Label3)
        Controls.Add(txApellido)
        Controls.Add(Label2)
        Name = "consulta_clientes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Consulta de clientes"
        CType(GridClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents GridClientes As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
