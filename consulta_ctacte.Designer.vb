<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consulta_ctacte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consulta_ctacte))
        DTPdesde = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        DTPhasta = New DateTimePicker()
        txApellido = New TextBox()
        Label3 = New Label()
        txCodigo = New TextBox()
        Label4 = New Label()
        Button5 = New Button()
        ImageList1 = New ImageList(components)
        Button4 = New Button()
        DGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Saldo = New DataGridViewTextBoxColumn()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DTPdesde
        ' 
        DTPdesde.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DTPdesde.Format = DateTimePickerFormat.Short
        DTPdesde.Location = New Point(751, 9)
        DTPdesde.Name = "DTPdesde"
        DTPdesde.Size = New Size(138, 21)
        DTPdesde.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(692, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 1
        Label1.Text = "Desde"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(692, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 3
        Label2.Text = "Hasta"
        ' 
        ' DTPhasta
        ' 
        DTPhasta.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DTPhasta.Format = DateTimePickerFormat.Short
        DTPhasta.Location = New Point(751, 42)
        DTPhasta.Name = "DTPhasta"
        DTPhasta.Size = New Size(138, 21)
        DTPhasta.TabIndex = 2
        ' 
        ' txApellido
        ' 
        txApellido.Location = New Point(64, 42)
        txApellido.Name = "txApellido"
        txApellido.Size = New Size(305, 23)
        txApellido.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 9
        Label3.Text = "Apellido"
        ' 
        ' txCodigo
        ' 
        txCodigo.Location = New Point(64, 13)
        txCodigo.Name = "txCodigo"
        txCodigo.Size = New Size(105, 23)
        txCodigo.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 15)
        Label4.TabIndex = 8
        Label4.Text = "Código"
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ImageKey = "lupa.png"
        Button5.ImageList = ImageList1
        Button5.Location = New Point(590, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(79, 66)
        Button5.TabIndex = 11
        Button5.Text = "Buscar"
        Button5.TextAlign = ContentAlignment.BottomCenter
        Button5.TextImageRelation = TextImageRelation.ImageAboveText
        Button5.UseVisualStyleBackColor = True
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
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ImageKey = "Salir.png"
        Button4.ImageList = ImageList1
        Button4.Location = New Point(810, 381)
        Button4.Name = "Button4"
        Button4.Size = New Size(79, 66)
        Button4.TabIndex = 13
        Button4.Text = "Cerrar"
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DGV
        ' 
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Saldo})
        DGV.Location = New Point(3, 83)
        DGV.Name = "DGV"
        DGV.RowHeadersVisible = False
        DGV.RowTemplate.Height = 25
        DGV.Size = New Size(886, 292)
        DGV.TabIndex = 14
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "fecha"
        Column1.HeaderText = "Fecha"
        Column1.Name = "Column1"
        Column1.Width = 110
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "detalle"
        Column2.HeaderText = "Movimiento"
        Column2.Name = "Column2"
        Column2.Width = 360
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "debe"
        Column3.HeaderText = "Debe"
        Column3.Name = "Column3"
        Column3.Width = 130
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "haber"
        Column4.HeaderText = "Haber"
        Column4.Name = "Column4"
        Column4.Width = 130
        ' 
        ' Saldo
        ' 
        Saldo.DataPropertyName = "saldo"
        Saldo.HeaderText = "Saldo"
        Saldo.Name = "Saldo"
        Saldo.Width = 130
        ' 
        ' consulta_ctacte
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(895, 453)
        Controls.Add(DGV)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(txApellido)
        Controls.Add(Label3)
        Controls.Add(txCodigo)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(DTPhasta)
        Controls.Add(Label1)
        Controls.Add(DTPdesde)
        Name = "consulta_ctacte"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Consulta de Cta.Cte."
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DTPdesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DTPhasta As DateTimePicker
    Friend WithEvents txApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button4 As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
End Class
