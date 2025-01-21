<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ventas))
        ImageList1 = New ImageList(components)
        Button3 = New Button()
        TablaDetalle = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Button2 = New Button()
        txCuit = New TextBox()
        Label5 = New Label()
        txDireccion = New TextBox()
        Label4 = New Label()
        txNombre = New TextBox()
        Label3 = New Label()
        txApellido = New TextBox()
        Label2 = New Label()
        txCodigo = New TextBox()
        Label1 = New Label()
        ComboConPago = New ComboBox()
        Label7 = New Label()
        GroupBox1 = New GroupBox()
        Button5 = New Button()
        txTotal = New TextBox()
        Label11 = New Label()
        txPUnit = New TextBox()
        Label10 = New Label()
        txCant = New TextBox()
        Label9 = New Label()
        txDescripcion = New TextBox()
        Label8 = New Label()
        txCodProd = New TextBox()
        Label6 = New Label()
        Button1 = New Button()
        Button4 = New Button()
        Button6 = New Button()
        txNFact = New Button()
        txTotalFact = New TextBox()
        CType(TablaDetalle, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
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
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ImageKey = "Salir.png"
        Button3.ImageList = ImageList1
        Button3.Location = New Point(1, 403)
        Button3.Name = "Button3"
        Button3.Size = New Size(60, 52)
        Button3.TabIndex = 3
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TablaDetalle
        ' 
        TablaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TablaDetalle.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        TablaDetalle.Location = New Point(1, 202)
        TablaDetalle.Name = "TablaDetalle"
        TablaDetalle.RowHeadersVisible = False
        TablaDetalle.RowTemplate.Height = 25
        TablaDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        TablaDetalle.Size = New Size(760, 195)
        TablaDetalle.TabIndex = 10
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "CODIGO"
        Column1.Name = "Column1"
        Column1.Width = 140
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "DESCRIPCION"
        Column2.Name = "Column2"
        Column2.Width = 320
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "CANT."
        Column3.Name = "Column3"
        Column3.Width = 70
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "P.UNIT"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "TOTAL"
        Column5.Name = "Column5"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(393, 403)
        Button2.Name = "Button2"
        Button2.Size = New Size(368, 35)
        Button2.TabIndex = 13
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txCuit
        ' 
        txCuit.Location = New Point(75, 94)
        txCuit.Name = "txCuit"
        txCuit.Size = New Size(178, 23)
        txCuit.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 15)
        Label5.TabIndex = 23
        Label5.Text = "Cuit"
        ' 
        ' txDireccion
        ' 
        txDireccion.Location = New Point(446, 37)
        txDireccion.Multiline = True
        txDireccion.Name = "txDireccion"
        txDireccion.Size = New Size(305, 51)
        txDireccion.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(383, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 22
        Label4.Text = "Dirección"
        ' 
        ' txNombre
        ' 
        txNombre.Location = New Point(75, 65)
        txNombre.Name = "txNombre"
        txNombre.Size = New Size(305, 23)
        txNombre.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 21
        Label3.Text = "Nombre"
        ' 
        ' txApellido
        ' 
        txApellido.Location = New Point(75, 37)
        txApellido.Name = "txApellido"
        txApellido.Size = New Size(305, 23)
        txApellido.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 20
        Label2.Text = "Apellido"
        ' 
        ' txCodigo
        ' 
        txCodigo.Location = New Point(75, 9)
        txCodigo.Name = "txCodigo"
        txCodigo.Size = New Size(105, 23)
        txCodigo.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 18
        Label1.Text = "Código"
        ' 
        ' ComboConPago
        ' 
        ComboConPago.FormattingEnabled = True
        ComboConPago.Items.AddRange(New Object() {"CONTADO", "CUENTA CORRIENTE"})
        ComboConPago.Location = New Point(446, 97)
        ComboConPago.Name = "ComboConPago"
        ComboConPago.Size = New Size(179, 23)
        ComboConPago.TabIndex = 24
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(381, 97)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 15)
        Label7.TabIndex = 25
        Label7.Text = "Cond.Pago"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(txTotal)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(txPUnit)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(txCant)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(txDescripcion)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(txCodProd)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Location = New Point(4, 126)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(756, 70)
        GroupBox1.TabIndex = 26
        GroupBox1.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.AutoSize = True
        Button5.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ImageKey = "(ninguna)"
        Button5.ImageList = ImageList1
        Button5.Location = New Point(72, 15)
        Button5.Name = "Button5"
        Button5.Size = New Size(49, 23)
        Button5.TabIndex = 29
        Button5.Text = "Buscar"
        Button5.TextImageRelation = TextImageRelation.ImageAboveText
        Button5.UseVisualStyleBackColor = True
        ' 
        ' txTotal
        ' 
        txTotal.Location = New Point(639, 37)
        txTotal.Name = "txTotal"
        txTotal.Size = New Size(89, 23)
        txTotal.TabIndex = 27
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(640, 19)
        Label11.Name = "Label11"
        Label11.Size = New Size(32, 15)
        Label11.TabIndex = 28
        Label11.Text = "Total"
        ' 
        ' txPUnit
        ' 
        txPUnit.Location = New Point(536, 37)
        txPUnit.Name = "txPUnit"
        txPUnit.Size = New Size(97, 23)
        txPUnit.TabIndex = 25
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(537, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(39, 15)
        Label10.TabIndex = 26
        Label10.Text = "P.Unit"
        ' 
        ' txCant
        ' 
        txCant.Location = New Point(465, 37)
        txCant.Name = "txCant"
        txCant.Size = New Size(65, 23)
        txCant.TabIndex = 23
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(466, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(35, 15)
        Label9.TabIndex = 24
        Label9.Text = "Cant."
        ' 
        ' txDescripcion
        ' 
        txDescripcion.Location = New Point(126, 37)
        txDescripcion.Name = "txDescripcion"
        txDescripcion.Size = New Size(333, 23)
        txDescripcion.TabIndex = 21
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(127, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 15)
        Label8.TabIndex = 22
        Label8.Text = "Descripcion"
        ' 
        ' txCodProd
        ' 
        txCodProd.Location = New Point(5, 37)
        txCodProd.Name = "txCodProd"
        txCodProd.Size = New Size(115, 23)
        txCodProd.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 15)
        Label6.TabIndex = 20
        Label6.Text = "Código"
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ImageKey = "(ninguna)"
        Button1.ImageList = ImageList1
        Button1.Location = New Point(186, 9)
        Button1.Name = "Button1"
        Button1.Size = New Size(61, 23)
        Button1.TabIndex = 27
        Button1.Text = "Buscar cli"
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ImageKey = "guardar.png"
        Button4.ImageList = ImageList1
        Button4.Location = New Point(75, 403)
        Button4.Name = "Button4"
        Button4.Size = New Size(60, 52)
        Button4.TabIndex = 28
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.AutoSize = True
        Button6.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.ImageKey = "(ninguna)"
        Button6.ImageList = ImageList1
        Button6.Location = New Point(1, 374)
        Button6.Name = "Button6"
        Button6.Size = New Size(78, 23)
        Button6.TabIndex = 30
        Button6.Text = "Eliminar Item"
        Button6.TextImageRelation = TextImageRelation.ImageAboveText
        Button6.UseVisualStyleBackColor = True
        ' 
        ' txNFact
        ' 
        txNFact.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txNFact.Location = New Point(611, 1)
        txNFact.Name = "txNFact"
        txNFact.Size = New Size(140, 26)
        txNFact.TabIndex = 31
        txNFact.UseVisualStyleBackColor = True
        ' 
        ' txTotalFact
        ' 
        txTotalFact.Location = New Point(271, 415)
        txTotalFact.Name = "txTotalFact"
        txTotalFact.Size = New Size(89, 23)
        txTotalFact.TabIndex = 32
        ' 
        ' ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(763, 458)
        ControlBox = False
        Controls.Add(txTotalFact)
        Controls.Add(txNFact)
        Controls.Add(Button6)
        Controls.Add(Button4)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(ComboConPago)
        Controls.Add(Label7)
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
        Controls.Add(Button2)
        Controls.Add(TablaDetalle)
        Controls.Add(Button3)
        Name = "ventas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Factura"
        CType(TablaDetalle, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button3 As Button
    Friend WithEvents TablaDetalle As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents txCuit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents ComboConPago As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txTotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txPUnit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txCant As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txDescripcion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txCodProd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents txNFact As Button
    Friend WithEvents txTotalFact As TextBox
End Class
