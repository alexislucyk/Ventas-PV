<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abm_clientes))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txCodigo = New TextBox()
        Label1 = New Label()
        txApellido = New TextBox()
        Label2 = New Label()
        txNombre = New TextBox()
        Label3 = New Label()
        txDireccion = New TextBox()
        Label4 = New Label()
        txCuit = New TextBox()
        Label5 = New Label()
        txTelefono = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        ComboEstado = New ComboBox()
        ImageList1 = New ImageList(components)
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        chkHabilitaCta = New CheckBox()
        ComboRelacion = New ComboBox()
        Label8 = New Label()
        GridClientes = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        CType(GridClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txCodigo
        ' 
        txCodigo.Location = New Point(62, 16)
        txCodigo.Name = "txCodigo"
        txCodigo.Size = New Size(105, 23)
        txCodigo.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 3
        Label1.Text = "Código"
        ' 
        ' txApellido
        ' 
        txApellido.Location = New Point(62, 45)
        txApellido.Name = "txApellido"
        txApellido.Size = New Size(305, 23)
        txApellido.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(5, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 5
        Label2.Text = "Apellido"
        ' 
        ' txNombre
        ' 
        txNombre.Location = New Point(62, 74)
        txNombre.Name = "txNombre"
        txNombre.Size = New Size(305, 23)
        txNombre.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(5, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 7
        Label3.Text = "Nombre"
        ' 
        ' txDireccion
        ' 
        txDireccion.Location = New Point(439, 39)
        txDireccion.Multiline = True
        txDireccion.Name = "txDireccion"
        txDireccion.Size = New Size(305, 58)
        txDireccion.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(376, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 9
        Label4.Text = "Dirección"
        ' 
        ' txCuit
        ' 
        txCuit.Location = New Point(62, 103)
        txCuit.Name = "txCuit"
        txCuit.Size = New Size(178, 23)
        txCuit.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 111)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 15)
        Label5.TabIndex = 11
        Label5.Text = "Cuit"
        ' 
        ' txTelefono
        ' 
        txTelefono.Location = New Point(315, 103)
        txTelefono.Name = "txTelefono"
        txTelefono.Size = New Size(179, 23)
        txTelefono.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(261, 111)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 15)
        Label6.TabIndex = 13
        Label6.Text = "Telefono"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(14, 140)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 15)
        Label7.TabIndex = 15
        Label7.Text = "Estado"
        ' 
        ' ComboEstado
        ' 
        ComboEstado.FormattingEnabled = True
        ComboEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        ComboEstado.Location = New Point(62, 132)
        ComboEstado.Name = "ComboEstado"
        ComboEstado.Size = New Size(179, 23)
        ComboEstado.TabIndex = 6
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
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ImageKey = "nuevo_reg.png"
        Button5.ImageList = ImageList1
        Button5.Location = New Point(495, 415)
        Button5.Name = "Button5"
        Button5.Size = New Size(79, 66)
        Button5.TabIndex = 8
        Button5.Text = "Agregar"
        Button5.TextAlign = ContentAlignment.BottomCenter
        Button5.TextImageRelation = TextImageRelation.ImageAboveText
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ImageKey = "Salir.png"
        Button4.ImageList = ImageList1
        Button4.Location = New Point(665, 415)
        Button4.Name = "Button4"
        Button4.Size = New Size(79, 66)
        Button4.TabIndex = 10
        Button4.Text = "Cerrar"
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ImageKey = "guardar.png"
        Button3.ImageList = ImageList1
        Button3.Location = New Point(580, 415)
        Button3.Name = "Button3"
        Button3.Size = New Size(79, 66)
        Button3.TabIndex = 9
        Button3.Text = "Guardar"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Button3.UseVisualStyleBackColor = True
        ' 
        ' chkHabilitaCta
        ' 
        chkHabilitaCta.AutoSize = True
        chkHabilitaCta.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point)
        chkHabilitaCta.Location = New Point(558, 120)
        chkHabilitaCta.Name = "chkHabilitaCta"
        chkHabilitaCta.Size = New Size(147, 25)
        chkHabilitaCta.TabIndex = 17
        chkHabilitaCta.Text = "Habilitar Cta.Cte."
        chkHabilitaCta.UseVisualStyleBackColor = True
        ' 
        ' ComboRelacion
        ' 
        ComboRelacion.FormattingEnabled = True
        ComboRelacion.Items.AddRange(New Object() {"CLIENTE", "PROVEEDOR"})
        ComboRelacion.Location = New Point(315, 132)
        ComboRelacion.Name = "ComboRelacion"
        ComboRelacion.Size = New Size(179, 23)
        ComboRelacion.TabIndex = 41
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(261, 140)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 15)
        Label8.TabIndex = 42
        Label8.Text = "Relación"
        ' 
        ' GridClientes
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        GridClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        GridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        GridClientes.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        GridClientes.DefaultCellStyle = DataGridViewCellStyle2
        GridClientes.Location = New Point(5, 161)
        GridClientes.Name = "GridClientes"
        GridClientes.RowHeadersVisible = False
        GridClientes.RowTemplate.Height = 25
        GridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GridClientes.Size = New Size(739, 248)
        GridClientes.TabIndex = 43
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
        ' Column8
        ' 
        Column8.DataPropertyName = "relacion"
        Column8.HeaderText = "Relacion"
        Column8.Name = "Column8"
        ' 
        ' Column9
        ' 
        Column9.DataPropertyName = "habilita_cta"
        Column9.HeaderText = "Cta.Cte."
        Column9.Name = "Column9"
        ' 
        ' abm_clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(750, 481)
        ControlBox = False
        Controls.Add(GridClientes)
        Controls.Add(ComboRelacion)
        Controls.Add(Label8)
        Controls.Add(chkHabilitaCta)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(ComboEstado)
        Controls.Add(Label7)
        Controls.Add(txTelefono)
        Controls.Add(Label6)
        Controls.Add(txCuit)
        Controls.Add(Label5)
        Controls.Add(txDireccion)
        Controls.Add(Label4)
        Controls.Add(txNombre)
        Controls.Add(Label3)
        Controls.Add(txApellido)
        Controls.Add(Label2)
        Controls.Add(txCodigo)
        Controls.Add(Label1)
        Name = "abm_clientes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Alta, baja y modificación de clientes y proveedores"
        CType(GridClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txCuit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboEstado As ComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents chkHabilitaCta As CheckBox
    Friend WithEvents ComboRelacion As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GridClientes As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
