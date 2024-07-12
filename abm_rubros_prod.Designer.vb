<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_rubros_prod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abm_rubros_prod))
        Button5 = New Button()
        ImageList1 = New ImageList(components)
        btGuardar = New Button()
        ComboRubros = New ComboBox()
        Label7 = New Label()
        txNombreRubro = New TextBox()
        Label2 = New Label()
        txIdRubro = New TextBox()
        Label1 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ImageKey = "nuevo_reg.png"
        Button5.ImageList = ImageList1
        Button5.Location = New Point(117, 163)
        Button5.Name = "Button5"
        Button5.Size = New Size(79, 66)
        Button5.TabIndex = 27
        Button5.Text = "Agregar"
        Button5.TextAlign = ContentAlignment.BottomCenter
        Button5.TextImageRelation = TextImageRelation.ImageAboveText
        Button5.UseVisualStyleBackColor = True
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth16Bit
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
        ' btGuardar
        ' 
        btGuardar.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btGuardar.ImageKey = "guardar.png"
        btGuardar.ImageList = ImageList1
        btGuardar.Location = New Point(202, 163)
        btGuardar.Name = "btGuardar"
        btGuardar.Size = New Size(79, 66)
        btGuardar.TabIndex = 28
        btGuardar.Text = "Guardar"
        btGuardar.TextAlign = ContentAlignment.BottomCenter
        btGuardar.TextImageRelation = TextImageRelation.ImageAboveText
        btGuardar.UseVisualStyleBackColor = True
        ' 
        ' ComboRubros
        ' 
        ComboRubros.FormattingEnabled = True
        ComboRubros.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        ComboRubros.Location = New Point(70, 116)
        ComboRubros.Name = "ComboRubros"
        ComboRubros.Size = New Size(179, 23)
        ComboRubros.TabIndex = 25
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(70, 98)
        Label7.Name = "Label7"
        Label7.Size = New Size(144, 15)
        Label7.TabIndex = 33
        Label7.Text = "Listado de rubros actuales"
        ' 
        ' txNombreRubro
        ' 
        txNombreRubro.Location = New Point(70, 52)
        txNombreRubro.Name = "txNombreRubro"
        txNombreRubro.Size = New Size(305, 23)
        txNombreRubro.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(7, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 24
        Label2.Text = "Rubro"
        ' 
        ' txIdRubro
        ' 
        txIdRubro.Location = New Point(70, 14)
        txIdRubro.Name = "txIdRubro"
        txIdRubro.Size = New Size(105, 23)
        txIdRubro.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(7, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 15)
        Label1.TabIndex = 21
        Label1.Text = "ID Rubro"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ImageIndex = 20
        Button2.ImageList = ImageList1
        Button2.Location = New Point(296, 163)
        Button2.Name = "Button2"
        Button2.Size = New Size(79, 66)
        Button2.TabIndex = 35
        Button2.Text = "Cerrar"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.TextImageRelation = TextImageRelation.ImageAboveText
        Button2.UseVisualStyleBackColor = True
        ' 
        ' abm_rubros_prod
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(390, 239)
        Controls.Add(Button2)
        Controls.Add(Button5)
        Controls.Add(btGuardar)
        Controls.Add(ComboRubros)
        Controls.Add(Label7)
        Controls.Add(txNombreRubro)
        Controls.Add(Label2)
        Controls.Add(txIdRubro)
        Controls.Add(Label1)
        Name = "abm_rubros_prod"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Alta, Baja y Modificación de Rubros de Productos"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button5 As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents ComboRubros As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txNombreRubro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txIdRubro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ImageList1 As ImageList
End Class
