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
        Button1 = New Button()
        chkHabilitaCta = New CheckBox()
        SuspendLayout()
        ' 
        ' txCodigo
        ' 
        txCodigo.Location = New Point(91, 33)
        txCodigo.Name = "txCodigo"
        txCodigo.Size = New Size(105, 23)
        txCodigo.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 3
        Label1.Text = "Código"
        ' 
        ' txApellido
        ' 
        txApellido.Location = New Point(91, 71)
        txApellido.Name = "txApellido"
        txApellido.Size = New Size(305, 23)
        txApellido.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 5
        Label2.Text = "Apellido"
        ' 
        ' txNombre
        ' 
        txNombre.Location = New Point(91, 110)
        txNombre.Name = "txNombre"
        txNombre.Size = New Size(305, 23)
        txNombre.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(28, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 7
        Label3.Text = "Nombre"
        ' 
        ' txDireccion
        ' 
        txDireccion.Location = New Point(91, 191)
        txDireccion.Multiline = True
        txDireccion.Name = "txDireccion"
        txDireccion.Size = New Size(305, 58)
        txDireccion.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(28, 194)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 9
        Label4.Text = "Dirección"
        ' 
        ' txCuit
        ' 
        txCuit.Location = New Point(91, 152)
        txCuit.Name = "txCuit"
        txCuit.Size = New Size(178, 23)
        txCuit.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(28, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 15)
        Label5.TabIndex = 11
        Label5.Text = "Cuit"
        ' 
        ' txTelefono
        ' 
        txTelefono.Location = New Point(90, 267)
        txTelefono.Name = "txTelefono"
        txTelefono.Size = New Size(179, 23)
        txTelefono.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(27, 270)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 15)
        Label6.TabIndex = 13
        Label6.Text = "Telefono"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(27, 310)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 15)
        Label7.TabIndex = 15
        Label7.Text = "Estado"
        ' 
        ' ComboEstado
        ' 
        ComboEstado.FormattingEnabled = True
        ComboEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        ComboEstado.Location = New Point(90, 310)
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
        Button5.Location = New Point(147, 358)
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
        Button4.Location = New Point(317, 358)
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
        Button3.Location = New Point(232, 358)
        Button3.Name = "Button3"
        Button3.Size = New Size(79, 66)
        Button3.TabIndex = 9
        Button3.Text = "Guardar"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ImageKey = "buscar.png"
        Button1.ImageList = ImageList1
        Button1.Location = New Point(253, 17)
        Button1.Name = "Button1"
        Button1.Size = New Size(58, 39)
        Button1.TabIndex = 16
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' chkHabilitaCta
        ' 
        chkHabilitaCta.AutoSize = True
        chkHabilitaCta.Location = New Point(291, 271)
        chkHabilitaCta.Name = "chkHabilitaCta"
        chkHabilitaCta.Size = New Size(116, 19)
        chkHabilitaCta.TabIndex = 17
        chkHabilitaCta.Text = "Habilitar Cta.Cte."
        chkHabilitaCta.UseVisualStyleBackColor = True
        ' 
        ' abm_clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(424, 437)
        ControlBox = False
        Controls.Add(chkHabilitaCta)
        Controls.Add(Button1)
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
        Text = "Alta, baja y modificación de clientes"
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
    Friend WithEvents Button1 As Button
    Friend WithEvents chkHabilitaCta As CheckBox
End Class
