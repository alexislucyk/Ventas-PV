<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consulta_precios
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        txCodigo = New TextBox()
        txDescri = New TextBox()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(12, 71)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(836, 346)
        DataGridView1.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "cod_prod"
        Column1.HeaderText = "Código"
        Column1.Name = "Column1"
        Column1.Width = 130
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "descripcion"
        Column2.HeaderText = "Descripción"
        Column2.Name = "Column2"
        Column2.Width = 450
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "p_venta"
        Column3.HeaderText = "Precio"
        Column3.Name = "Column3"
        Column3.Width = 90
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "stock"
        Column4.HeaderText = "Stock"
        Column4.Name = "Column4"
        Column4.Width = 60
        ' 
        ' Column5
        ' 
        Column5.DataPropertyName = "fecha_ult_compra"
        Column5.HeaderText = "F.Ult.Compra"
        Column5.Name = "Column5"
        Column5.Width = 110
        ' 
        ' txCodigo
        ' 
        txCodigo.BackColor = SystemColors.ControlLightLight
        txCodigo.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txCodigo.ForeColor = Color.Black
        txCodigo.Location = New Point(12, 38)
        txCodigo.Name = "txCodigo"
        txCodigo.Size = New Size(163, 27)
        txCodigo.TabIndex = 2
        ' 
        ' txDescri
        ' 
        txDescri.BackColor = SystemColors.ControlLightLight
        txDescri.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txDescri.ForeColor = Color.Black
        txDescri.Location = New Point(181, 38)
        txDescri.Name = "txDescri"
        txDescri.Size = New Size(563, 27)
        txDescri.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(771, 423)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 4
        Button2.Text = "Cerrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(23, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 20)
        Label1.TabIndex = 5
        Label1.Text = "Código"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(191, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 6
        Label2.Text = "Descripción"
        ' 
        ' consulta_precios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(858, 455)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(txDescri)
        Controls.Add(txCodigo)
        Controls.Add(DataGridView1)
        Name = "consulta_precios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Consulta de precios"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txCodigo As TextBox
    Friend WithEvents txDescri As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
