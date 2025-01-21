<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consulta_compras
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
        Tabla = New DataGridView()
        TablaDetalle = New DataGridView()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        CType(Tabla, ComponentModel.ISupportInitialize).BeginInit()
        CType(TablaDetalle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Tabla
        ' 
        Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Tabla.Location = New Point(62, 95)
        Tabla.Name = "Tabla"
        Tabla.RowTemplate.Height = 25
        Tabla.Size = New Size(787, 160)
        Tabla.TabIndex = 0
        ' 
        ' TablaDetalle
        ' 
        TablaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TablaDetalle.Location = New Point(62, 277)
        TablaDetalle.Name = "TablaDetalle"
        TablaDetalle.RowTemplate.Height = 25
        TablaDetalle.Size = New Size(787, 264)
        TablaDetalle.TabIndex = 1
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(691, 17)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(158, 26)
        DateTimePicker1.TabIndex = 2
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(691, 49)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(158, 26)
        DateTimePicker2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(614, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 4
        Label1.Text = "Fecha Desde"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(614, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 5
        Label2.Text = "Fecha Hasta"
        ' 
        ' consulta_compras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(987, 588)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(TablaDetalle)
        Controls.Add(Tabla)
        Name = "consulta_compras"
        Text = "consulta_compras"
        CType(Tabla, ComponentModel.ISupportInitialize).EndInit()
        CType(TablaDetalle, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Tabla As DataGridView
    Friend WithEvents TablaDetalle As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
