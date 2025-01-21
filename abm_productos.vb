Imports MySql
Imports MySql.Data.MySqlClient

Public Class abm_productos
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DesconectarDB()
        Close()
    End Sub

    Private Sub abm_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarDB()
        Carga_Productos()
        CargarComboRubros(ComboRubros)
        '**********************************************
        'Aca se carga el control combo de PROVEEDORES
        Dim Consulta As String
        Consulta = "SELECT * FROM proveedores ORDER BY razon ASC"
        AdapProvee = New MySqlDataAdapter(Consulta, Conexion)
        DatosProvee = New DataSet
        DatosProvee.Tables.Add("proveedores")
        AdapProvee.Fill(DatosProvee.Tables("proveedores"))
        ComboProveedores.DataSource = DatosProvee.Tables("proveedores")
        ComboProveedores.DisplayMember = "razon"
        '**********************************************
        'Aca se carga el control combo de RUBROS
        'Dim Consulta2 As String
        'Consulta2 = "SELECT * FROM rubros ORDER BY nombre ASC"
        'AdapRubros = New MySqlDataAdapter(Consulta2, Conexion)
        'DatosRubros = New DataSet
        'DatosRubros.Tables.Add("rubros")
        'AdapRubros.Fill(DatosRubros.Tables("rubros"))
        'ComboRubros.DataSource = DatosRubros.Tables("rubros")
        'ComboRubros.DisplayMember = "nombre"
    End Sub
    Sub Carga_Productos()
        ' Aca se carga la lista de productos
        SQL = "SELECT * FROM productos"
        AdapArtic = New MySqlDataAdapter(SQL, Conexion)
        DtArtic = New DataTable
        AdapArtic.Fill(DtArtic)
        DataGridView1.DataSource = DtArtic
    End Sub

    Sub Consultar_Artic()
        Dim ConsArtic As String
        Dim Lista As Byte
        ConsArtic = "Select * FROM productos WHERE cod_prod='" & txCodigo.Text & "'"
        AdapConsArtic = New MySqlDataAdapter(ConsArtic, Conexion)
        DatosConsArtic = New DataSet
        AdapConsArtic.Fill(DatosConsArtic, "productos")
        Lista = DatosConsArtic.Tables("productos").Rows.Count

        If lista <> 0 Then
            txDescripcion.Text = DatosConsArtic.Tables("productos").Rows(0).Item("descripcion")
            txPrecioCompra.Text = DatosConsArtic.Tables("productos").Rows(0).Item("p_compra")
            txPrecioVenta.Text = DatosConsArtic.Tables("productos").Rows(0).Item("p_venta")
            txStock.Text = DatosConsArtic.Tables("productos").Rows(0).Item("stock")
            txFecha.Value = DatosConsArtic.Tables("productos").Rows(0).Item("fecha_ult_compra")
            ComboRubros.Text = DatosConsArtic.Tables("productos").Rows(0).Item("rubro")
            ComboProveedores.Text = DatosConsArtic.Tables("productos").Rows(0).Item("proveedor")

            EstadoRegistro = 1
        Else
            EstadoRegistro = 0
            'MsgBox("Datos no encontrados.")
            txDescripcion.Focus()
        End If
    End Sub

    Private Sub txCodigo_TextChanged(sender As Object, e As EventArgs) Handles txCodigo.TextChanged

    End Sub

    Private Sub txCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then

            Consultar_Artic
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            EstadoRegistro = 1
            txCodigo.Text = Convert.ToString(DataGridView1.Item("Column1", DataGridView1.SelectedRows(0).Index).Value)
            txDescripcion.Text = Convert.ToString(DataGridView1.Item("Column2", DataGridView1.SelectedRows(0).Index).Value)
            txPrecioCompra.Text = Convert.ToString(DataGridView1.Item("Column3", DataGridView1.SelectedRows(0).Index).Value)
            txPrecioVenta.Text = Convert.ToString(DataGridView1.Item("Column4", DataGridView1.SelectedRows(0).Index).Value)
            txStock.Text = Convert.ToString(DataGridView1.Item("Column5", DataGridView1.SelectedRows(0).Index).Value)
            txFecha.Text = Convert.ToString(DataGridView1.Item("Column6", DataGridView1.SelectedRows(0).Index).Value)
            ComboRubros.Text = Convert.ToString(DataGridView1.Item("Column7", DataGridView1.SelectedRows(0).Index).Value)
            ComboProveedores.Text = Convert.ToString(DataGridView1.Item("Column8", DataGridView1.SelectedRows(0).Index).Value)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Limpiar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response
        response = MsgBox("Desea eliminar el producto seleccionado?", MsgBoxStyle.YesNo, "Sistema de ventas")
        If response = vbYes Then
            Try
                BorrarArt()
                MsgBox("Producto borrado.",, "Sistema de ventas")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Guardar()
        Carga_Productos()
    End Sub
    Private Sub Guardar()
        Dim FECHA As String
        FECHA = txFecha.Value.ToString("yyyy/MM/dd")
        Try
            If EstadoRegistro = 0 Then
                Comando = New MySqlCommand("INSERT INTO productos(cod_prod,descripcion,p_compra,p_venta,stock,fecha_ult_compra,rubro,proveedor)" & Chr(13) &
                    "VALUES(@cod_prod,@descripcion,@p_compra,@p_venta,@stock,@fecha_ult_compra,@rubro,@proveedor)", Conexion)
                Comando.Parameters.AddWithValue("@cod_prod", txCodigo.Text)
                Comando.Parameters.AddWithValue("@descripcion", UCase(txDescripcion.Text))
                Comando.Parameters.AddWithValue("@p_compra", Replace(txPrecioCompra.Text, ",", "."))
                Comando.Parameters.AddWithValue("@p_venta", Replace(txPrecioVenta.Text, ",", "."))
                Comando.Parameters.AddWithValue("@stock", txStock.Text)
                Comando.Parameters.AddWithValue("@fecha_ult_compra", FECHA)
                Comando.Parameters.AddWithValue("@rubro", ComboRubros.Text)
                Comando.Parameters.AddWithValue("@proveedor", ComboProveedores.Text)
                Comando.ExecuteNonQuery()
                Limpiar()
            ElseIf EstadoRegistro = 1 Then
                Actualizar = "UPDATE productos SET descripcion='" & UCase(txDescripcion.Text) &
                    "',p_compra='" & Replace(txPrecioCompra.Text, ",", ".") & "',p_venta='" & Replace(txPrecioVenta.Text, ",", ".") & "',stock='" & txStock.Text & "',fecha_ult_compra='" & FECHA &
                    "',rubro='" & ComboRubros.Text & "',proveedor='" & ComboProveedores.Text & "' WHERE cod_prod='" & txCodigo.Text & "'"
                Comando = New MySqlCommand(Actualizar, Conexion)
                Comando.ExecuteNonQuery()
                Limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BorrarArt()
        Try
            Borrado = "DELETE FROM productos WHERE cod_prod='" & txCodigo.Text & "'"
            Comando = New MySqlCommand(Borrado, Conexion)
            Comando.ExecuteNonQuery()
            Carga_Productos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Limpiar()
        txCodigo.Text = ""
        txCodigo.Focus()
        txDescripcion.Text = ""
        txPrecioCompra.Text = ""
        txPrecioVenta.Text = ""
        txStock.Text = ""
        txFecha.Text = Date.Now
        ComboRubros.Text = ""
        ComboProveedores.Text = ""
    End Sub

    Private Sub txPrecioCompra_TextChanged(sender As Object, e As EventArgs) Handles txPrecioCompra.TextChanged

    End Sub

    Private Sub txPrecioCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles txPrecioCompra.KeyDown

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txBuscador.Visible = True
        Else
            txBuscador.Visible = False
        End If
    End Sub

    Private Sub txBuscador_TextChanged(sender As Object, e As EventArgs) Handles txBuscador.TextChanged
        Dim dtv As New DataView(DtArtic)
        dtv.RowFilter = String.Format("descripcion LIKE '%{0}%'", txBuscador.Text)
        DataGridView1.DataSource = dtv
    End Sub
End Class