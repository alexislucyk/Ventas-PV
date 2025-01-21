Imports MySql.Data.MySqlClient

Public Class compras
    Dim FechaCompra As String
    Private Sub compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarDB()
        Fecha_Operacion = DateTime.Now.ToString("yyyy/MM/dd")
        FechaCompra = DTPFechaCompra.Value.ToString("yyyy/MM/dd")
        AdapArticFact = New MySqlDataAdapter("SELECT * FROM productos ORDER BY descripcion", Conexion)
        Dim SQLBuilder As New MySqlCommandBuilder(AdapArticFact)
        DT = New DataTable
        AdapArticFact.Fill(DT)
        BindArt.DataSource = DT
    End Sub


    Private Sub txCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Buscar_Cliente()
        End If
    End Sub
    Private Sub Buscar_Cliente()
        Dim cadena As String
        Dim lista As Byte

        cadena = "SELECT * FROM clientes WHERE id='" & txCodigo.Text & "'"
        AdapConsClie = New MySqlDataAdapter(cadena, Conexion)
        DatosConsclie = New DataSet
        AdapConsClie.Fill(DatosConsclie, "clientes")
        lista = DatosConsclie.Tables("clientes").Rows.Count
        If lista <> 0 Then
            txApellido.Text = DatosConsclie.Tables("clientes").Rows(0).Item("apellido")
            txNombre.Text = DatosConsclie.Tables("clientes").Rows(0).Item("nombre")
            txDireccion.Text = DatosConsclie.Tables("clientes").Rows(0).Item("direccion")
            txCuit.Text = DatosConsclie.Tables("clientes").Rows(0).Item("cuit")
            ComboConPago.Focus()
        Else
            MsgBox("No se encontro ningún cliente!")
            txCodigo.Clear()
            txCodigo.Focus()
        End If
    End Sub

    Private Sub txCodProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txCodProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim ConsArtic As String
            Dim Lista As Byte
            ConsArtic = "Select * FROM productos WHERE cod_prod='" & txCodProd.Text & "'"
            AdapConsArtic = New MySqlDataAdapter(ConsArtic, Conexion)
            DatosConsArtic = New DataSet
            AdapConsArtic.Fill(DatosConsArtic, "productos")
            Lista = DatosConsArtic.Tables("productos").Rows.Count

            If Lista <> 0 Then
                txDescripcion.Text = DatosConsArtic.Tables("productos").Rows(0).Item("descripcion")
                txPUnit.Text = DatosConsArtic.Tables("productos").Rows(0).Item("p_venta")
                txCant.Focus()
            Else
                EstadoRegistro = 0
                Dim response
                response = MsgBox("No se encontró el producto", MsgBoxStyle.YesNo, "Sistema de ventas")
                If response = vbYes Then
                    Try

                        MsgBox("Producto agregado.",, "Sistema de ventas")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                End If
                txDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub txCant_KeyDown(sender As Object, e As KeyEventArgs) Handles txCant.KeyDown
        Dim P As Double
        Dim C As Double
        Dim T As Double
        If e.KeyCode = Keys.Enter Then
            P = Convert.ToDouble(txPUnit.Text)
            C = Convert.ToDouble(txCant.Text)
            T = P * C
            txTotal.Text = Format(T, "#,##0.00")

            txTotal.Focus()

        End If


    End Sub
    Private Sub limpiar_text()

        txCodProd.Text = String.Empty
        txDescripcion.Text = String.Empty
        txCant.Text = String.Empty
        txPUnit.Text = String.Empty
        txTotal.Text = String.Empty
        txCodProd.Focus()
    End Sub

    Private Sub txTotal_KeyDown(sender As Object, e As KeyEventArgs) Handles txTotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            TablaDetalle.Rows.Add(txCodProd.Text, txDescripcion.Text, txCant.Text, txPUnit.Text, txTotal.Text)
            Totalizar()
            limpiar_text()
        End If

    End Sub
    Private Sub Totalizar()
        Dim Total As Double = 0
        Mostrar = 0
        Dim Filita As DataGridViewRow = New DataGridViewRow()
        For Each Filita In TablaDetalle.Rows
            Total += Convert.ToDouble(Filita.Cells("Column5").Value)
        Next
        TotalVenta = Total
        Mostrar = Convert.ToString(Total)
        lblTotal.Text = Format(Mostrar, "$ #,##0.00")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GuardaCompra()

    End Sub

    Private Sub GuardaCompra()
        '-------------------- Guarda Compras ----------------------------------------------------------------------------------------
        Dim GuardaF As MySqlCommand = New MySqlCommand("INSERT INTO compras(cod_proveedor,cond_pago,documento,n_documento,total_compra,fecha_compra,fecha_operacion)" &
                                                       "VALUES(@cod_proveedor,@cond_pago,@documento,@n_documento,@total_compra,@fecha,@fechaOp)", Conexion)
        GuardaF.Parameters.Clear()
        GuardaF.Parameters.AddWithValue("@cod_proveedor", txCodigo.Text)
        GuardaF.Parameters.AddWithValue("@cond_pago", ComboConPago.SelectedItem)
        GuardaF.Parameters.AddWithValue("@documento", ComboDocum.SelectedItem)
        GuardaF.Parameters.AddWithValue("@n_documento", txNumComprobante.Text)
        GuardaF.Parameters.AddWithValue("@total_compra", TotalVenta)
        GuardaF.Parameters.AddWithValue("@fecha", FechaCompra)
        GuardaF.Parameters.AddWithValue("@fechaOp", Fecha_Operacion)
        GuardaF.ExecuteNonQuery()

        '------------------- Control de Stock --------------------------------------------------------------------------------------

        Dim Filas1 As DataGridViewRow = New DataGridViewRow
        For Each Filas1 In TablaDetalle.Rows
            If Filas1.IsNewRow Then
                Exit For
            Else
                Dim StCod As String = Filas1.Cells(0).Value
                Dim StPre As String = Filas1.Cells(3).Value
                Dim StCantIngre As String = Filas1.Cells(2).Value
                Actualizar = "UPDATE productos SET p_compra='" & Replace(StPre, ",", ".") & "',stock = stock + '" & StCantIngre &
                            "',fecha_ult_compra='" & FechaCompra &
                            "' WHERE cod_prod='" & StCod & "'"
                Comando = New MySqlCommand(Actualizar, Conexion)
                Comando.ExecuteNonQuery()
            End If
        Next
        '-------------------- Fin de Control de Stock -------------------------------------------------------------------------------
        '-------------------- Ingreso de detalle de compras -------------------------------------------------------------------------

        Dim Ctdo As MySqlCommand = New MySqlCommand("INSERT INTO compras_detalle(cod_prod,descripcion,cant,p_unit,total,n_documento,fecha)" &
                                                       "VALUES(@cod_prod,@descripcion,@cant,@p_unit,@total,@n_documento,@fecha)", Conexion)

        Dim Filas As DataGridViewRow = New DataGridViewRow 'variable que recorre la grilla
        Try
            For Each Filas In TablaDetalle.Rows  'empieza el recorrido de todas la filas de la grilla
                If Filas.IsNewRow Then     'si hay una fila vacia termina el For Each
                    Exit For
                Else
                    Ctdo.Parameters.Clear() ' cada vez que la variable empieza a recorrer la grilla se vacia
                    Ctdo.Parameters.AddWithValue("@cod_prod", Convert.ToString(Filas.Cells(0).Value))
                    Ctdo.Parameters.AddWithValue("@descripcion", Convert.ToString(Filas.Cells(1).Value))
                    Ctdo.Parameters.AddWithValue("@cant", Convert.ToString(Filas.Cells(2).Value))
                    Ctdo.Parameters.AddWithValue("@p_unit", Convert.ToString(Filas.Cells(3).Value))
                    Ctdo.Parameters.AddWithValue("@total", Convert.ToString(Filas.Cells(4).Value))
                    Ctdo.Parameters.AddWithValue("@n_documento", txNumComprobante.Text)
                    Ctdo.Parameters.AddWithValue("@fecha", FechaCompra)
                    Ctdo.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception

        End Try
        '-------------------- Fin de Detalle de compras -----------------------------------------------------------------------------
        'LimpiarTodo()
    End Sub
    Private Sub LimpiarTodo()
        TablaDetalle.Rows.Clear()

    End Sub
    Private Sub CargaEncabezado()
        TablaDetalle.ColumnCount = 5
        TablaDetalle.ColumnHeadersVisible = True
        Dim ColEncaEstilo As New DataGridViewCellStyle()
        ColEncaEstilo.BackColor = Color.Beige
        ColEncaEstilo.Font = New Font("Tahoma", 16, FontStyle.Bold)
        TablaDetalle.ColumnHeadersDefaultCellStyle = ColEncaEstilo

        TablaDetalle.Columns(0).Name = "Codigo"
        TablaDetalle.Columns(1).Name = "descrip"
        TablaDetalle.Columns(2).Name = "cnt"
        TablaDetalle.Columns(3).Name = "p.unit"
        TablaDetalle.Columns(4).Name = "total"




    End Sub
    Private Sub DTPFechaCompra_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaCompra.ValueChanged
        FechaCompra = DTPFechaCompra.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DesconectarDB()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'CargaEncabezado()
    End Sub
End Class