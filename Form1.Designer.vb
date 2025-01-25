<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Button3 = New Button()
        ImageList1 = New ImageList(components)
        Button2 = New Button()
        Button1 = New Button()
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        ConfiguracionesToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        OperacionesToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        IngresarNuevoClienteToolStripMenuItem = New ToolStripMenuItem()
        ConsultaDeClientesToolStripMenuItem = New ToolStripMenuItem()
        ConsultaDeCtaCteClientesToolStripMenuItem = New ToolStripMenuItem()
        ProveedoresToolStripMenuItem = New ToolStripMenuItem()
        IngresarNuevoProveedorToolStripMenuItem = New ToolStripMenuItem()
        ConsultaDeProveedoresToolStripMenuItem = New ToolStripMenuItem()
        ComprasToolStripMenuItem = New ToolStripMenuItem()
        IngresoDeMercaderíaToolStripMenuItem = New ToolStripMenuItem()
        ConsultaDeIngresosToolStripMenuItem = New ToolStripMenuItem()
        VentasToolStripMenuItem = New ToolStripMenuItem()
        NuevaVentaToolStripMenuItem = New ToolStripMenuItem()
        ConsultaDeVentasToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        ABMProductosToolStripMenuItem = New ToolStripMenuItem()
        ABMRubrosDeProductosToolStripMenuItem = New ToolStripMenuItem()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(-1, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(130, 663)
        Panel1.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ImageKey = "Salir.png"
        Button3.ImageList = ImageList1
        Button3.Location = New Point(9, 525)
        Button3.Name = "Button3"
        Button3.Size = New Size(109, 90)
        Button3.TabIndex = 2
        Button3.Text = "Salir"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Button3.UseVisualStyleBackColor = True
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
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ImageKey = "hoja2.png"
        Button2.ImageList = ImageList1
        Button2.Location = New Point(9, 120)
        Button2.Name = "Button2"
        Button2.Size = New Size(109, 90)
        Button2.TabIndex = 1
        Button2.Text = "Precios"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.TextImageRelation = TextImageRelation.ImageAboveText
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ImageKey = "canasto.png"
        Button1.ImageList = ImageList1
        Button1.Location = New Point(9, 15)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 90)
        Button1.TabIndex = 0
        Button1.Text = "Ventas"
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, OperacionesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1234, 24)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ConfiguracionesToolStripMenuItem, ToolStripMenuItem1, SalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(60, 20)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' ConfiguracionesToolStripMenuItem
        ' 
        ConfiguracionesToolStripMenuItem.Image = CType(resources.GetObject("ConfiguracionesToolStripMenuItem.Image"), Image)
        ConfiguracionesToolStripMenuItem.Name = "ConfiguracionesToolStripMenuItem"
        ConfiguracionesToolStripMenuItem.Size = New Size(161, 22)
        ConfiguracionesToolStripMenuItem.Text = "Configuraciones"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(158, 6)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), Image)
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(161, 22)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' OperacionesToolStripMenuItem
        ' 
        OperacionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, ProveedoresToolStripMenuItem, ComprasToolStripMenuItem, VentasToolStripMenuItem, ProductosToolStripMenuItem})
        OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        OperacionesToolStripMenuItem.Size = New Size(85, 20)
        OperacionesToolStripMenuItem.Text = "Operaciones"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {IngresarNuevoClienteToolStripMenuItem, ConsultaDeClientesToolStripMenuItem, ConsultaDeCtaCteClientesToolStripMenuItem})
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(139, 22)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' IngresarNuevoClienteToolStripMenuItem
        ' 
        IngresarNuevoClienteToolStripMenuItem.Name = "IngresarNuevoClienteToolStripMenuItem"
        IngresarNuevoClienteToolStripMenuItem.Size = New Size(224, 22)
        IngresarNuevoClienteToolStripMenuItem.Text = "Ingresar nuevo cliente"
        ' 
        ' ConsultaDeClientesToolStripMenuItem
        ' 
        ConsultaDeClientesToolStripMenuItem.Name = "ConsultaDeClientesToolStripMenuItem"
        ConsultaDeClientesToolStripMenuItem.Size = New Size(224, 22)
        ConsultaDeClientesToolStripMenuItem.Text = "Consulta de clientes"
        ' 
        ' ConsultaDeCtaCteClientesToolStripMenuItem
        ' 
        ConsultaDeCtaCteClientesToolStripMenuItem.Name = "ConsultaDeCtaCteClientesToolStripMenuItem"
        ConsultaDeCtaCteClientesToolStripMenuItem.Size = New Size(224, 22)
        ConsultaDeCtaCteClientesToolStripMenuItem.Text = "Consulta de Cta.Cte Clientes"
        ' 
        ' ProveedoresToolStripMenuItem
        ' 
        ProveedoresToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {IngresarNuevoProveedorToolStripMenuItem, ConsultaDeProveedoresToolStripMenuItem})
        ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        ProveedoresToolStripMenuItem.Size = New Size(139, 22)
        ProveedoresToolStripMenuItem.Text = "Proveedores"
        ' 
        ' IngresarNuevoProveedorToolStripMenuItem
        ' 
        IngresarNuevoProveedorToolStripMenuItem.Name = "IngresarNuevoProveedorToolStripMenuItem"
        IngresarNuevoProveedorToolStripMenuItem.Size = New Size(209, 22)
        IngresarNuevoProveedorToolStripMenuItem.Text = "Ingresar nuevo proveedor"
        ' 
        ' ConsultaDeProveedoresToolStripMenuItem
        ' 
        ConsultaDeProveedoresToolStripMenuItem.Name = "ConsultaDeProveedoresToolStripMenuItem"
        ConsultaDeProveedoresToolStripMenuItem.Size = New Size(209, 22)
        ConsultaDeProveedoresToolStripMenuItem.Text = "Consulta de proveedores"
        ' 
        ' ComprasToolStripMenuItem
        ' 
        ComprasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {IngresoDeMercaderíaToolStripMenuItem, ConsultaDeIngresosToolStripMenuItem})
        ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        ComprasToolStripMenuItem.Size = New Size(139, 22)
        ComprasToolStripMenuItem.Text = "Compras"
        ' 
        ' IngresoDeMercaderíaToolStripMenuItem
        ' 
        IngresoDeMercaderíaToolStripMenuItem.Name = "IngresoDeMercaderíaToolStripMenuItem"
        IngresoDeMercaderíaToolStripMenuItem.Size = New Size(191, 22)
        IngresoDeMercaderíaToolStripMenuItem.Text = "Ingreso de mercadería"
        ' 
        ' ConsultaDeIngresosToolStripMenuItem
        ' 
        ConsultaDeIngresosToolStripMenuItem.Name = "ConsultaDeIngresosToolStripMenuItem"
        ConsultaDeIngresosToolStripMenuItem.Size = New Size(191, 22)
        ConsultaDeIngresosToolStripMenuItem.Text = "Consulta de ingresos"
        ' 
        ' VentasToolStripMenuItem
        ' 
        VentasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NuevaVentaToolStripMenuItem, ConsultaDeVentasToolStripMenuItem})
        VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        VentasToolStripMenuItem.Size = New Size(139, 22)
        VentasToolStripMenuItem.Text = "Ventas"
        ' 
        ' NuevaVentaToolStripMenuItem
        ' 
        NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        NuevaVentaToolStripMenuItem.Size = New Size(174, 22)
        NuevaVentaToolStripMenuItem.Text = "Nueva venta"
        ' 
        ' ConsultaDeVentasToolStripMenuItem
        ' 
        ConsultaDeVentasToolStripMenuItem.Name = "ConsultaDeVentasToolStripMenuItem"
        ConsultaDeVentasToolStripMenuItem.Size = New Size(174, 22)
        ConsultaDeVentasToolStripMenuItem.Text = "Consulta de ventas"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ABMProductosToolStripMenuItem, ABMRubrosDeProductosToolStripMenuItem})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(139, 22)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' ABMProductosToolStripMenuItem
        ' 
        ABMProductosToolStripMenuItem.Name = "ABMProductosToolStripMenuItem"
        ABMProductosToolStripMenuItem.Size = New Size(223, 22)
        ABMProductosToolStripMenuItem.Text = "A-B-M Productos"
        ' 
        ' ABMRubrosDeProductosToolStripMenuItem
        ' 
        ABMRubrosDeProductosToolStripMenuItem.Name = "ABMRubrosDeProductosToolStripMenuItem"
        ABMRubrosDeProductosToolStripMenuItem.Size = New Size(223, 22)
        ABMRubrosDeProductosToolStripMenuItem.Text = "A-B-M Rubros de productos"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1234, 651)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = " :: Sistema de ventas :: Version  2025:06-01"
        Panel1.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguracionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarNuevoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeCtaCteClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarNuevoProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoDeMercaderíaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeIngresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button2 As Button
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents ABMRubrosDeProductosToolStripMenuItem As ToolStripMenuItem
End Class
