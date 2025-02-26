Imports System.Runtime.InteropServices.JavaScript.JSType
Imports MySql
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class ventas
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Select Case MsgBox("Desea salir de la factura?", vbYesNo, "Sistema Venta-PV")
            Case vbYes
                DesconectarDB()
                Close()
            Case vbNo
                txCodigo.Focus()
        End Select

    End Sub

    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesconectarDB()
        ConectarDB()
        Fecha_Operacion = DateTime.Now.ToString("dd/MM/yyyy")
        AdapArticFact = New MySqlDataAdapter("SELECT * FROM productos ORDER BY descripcion", Conexion)
        Dim SQLBuilder As New MySqlCommandBuilder(AdapArticFact)
        DT = New DataTable
        AdapArticFact.Fill(DT)
        BindArt.DataSource = DT

        '-- Aca se obtiene el numero de la factura ---------------------------------
        Dim AdapNumFact As New MySqlDataAdapter("SELECT n_documento FROM ventas ORDER BY n_documento", Conexion)
        Dim DT2 As New DataTable
        AdapNumFact.Fill(DT2)
        BindNFact.DataSource = DT2
        BindNFact.MoveLast()    'Se mueve al ultimo resgistro de la tabla y luego le suma 1
        txNFact.Text = BindNFact.Current("n_documento").ToString + 1
        '-----------------------------------------

    End Sub

    Private Sub txCodigo_TextChanged(sender As Object, e As EventArgs) Handles txCodigo.TextChanged

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EstadoRegistro = "Buscar Cliente"
        consulta_clientes.ShowDialog()
        txCodigo.Focus()
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
                'MsgBox("Datos no encontrados.")
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
            txTotal.Text = T

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
        'Suma todos los items de la factura
        Dim Total As Double = 0
        Dim Mostrar As Double = 0
        Dim Filita As DataGridViewRow = New DataGridViewRow()
        For Each Filita In TablaDetalle.Rows
            Total += Convert.ToDouble(Filita.Cells("Column5").Value)
        Next
        TotalVenta = Total
        Mostrar = Convert.ToString(Total)
        txTotalFact.Text = Format(Mostrar, "##,##0.00")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Borra item seleccionado del detalle
        Dim I As Integer
        I = TablaDetalle.CurrentRow.Index
        TablaDetalle.Rows.RemoveAt(I)
        Totalizar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ComboConPago.Text = "CONTADO" Then
            ConectarDB()
            GuardaContado()
            DesconectarDB()
        ElseIf ComboConPago.Text = "CUENTA CORRIENTE" Then
            ConectarDB()
            GuardaContado()
            GuardaCtaCte()
            DesconectarDB()
        End If
        RegenerarFormulario()
    End Sub

    Private Sub GuardaContado()
        Try
            Dim GuardaF As MySqlCommand = New MySqlCommand("INSERT INTO ventas(id_cliente,cond_pago,n_documento,total_venta,fecha_venta)" &
                                                       "VALUES(@id_cliente,@cond_pago,@n_documento,@total_venta,@fecha_venta)", Conexion)
            GuardaF.Parameters.Clear()
            GuardaF.Parameters.AddWithValue("@id_cliente", txCodigo.Text)
            GuardaF.Parameters.AddWithValue("@cond_pago", ComboConPago.Text)
            GuardaF.Parameters.AddWithValue("@n_documento", txNFact.Text)
            GuardaF.Parameters.AddWithValue("@total_venta", TotalVenta)
            GuardaF.Parameters.AddWithValue("@fecha_venta", Date.Now)
            GuardaF.ExecuteNonQuery()
            '------------------- Control de Stock --------------------------------------------------------------------------------------

            Dim Filas1 As DataGridViewRow = New DataGridViewRow
            For Each Filas1 In TablaDetalle.Rows
                If Filas1.IsNewRow Then
                    Exit For
                Else
                    Dim StCan As String = Format(CDbl(Filas1.Cells(2).Value), "0.00")
                    StCan = StCan.Replace(",", ".")
                    Dim StCod As String = Filas1.Cells(0).Value
                    'Dim DesStock As String = "UPDATE artic Set stock = stock - " & StCan & " WHERE codigo= " & StCod
                    Dim DesStock As String = "UPDATE productos Set stock = stock - " & StCan & " WHERE cod_prod= '" & StCod & "'"
                    Dim STK As MySqlCommand = New MySqlCommand(DesStock, Conexion)
                    STK.ExecuteNonQuery()
                End If
            Next
            '-------------------- Fin de Control de Stock -------------------------------------------------------------------------------
            GuardaDetalle()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GuardaDetalle()
        Dim Ctdo As MySqlCommand = New MySqlCommand("INSERT INTO ventas_detalle(cod_prod,descripcion,cant,p_unit,total,n_documento,fecha)" &
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
                    Ctdo.Parameters.AddWithValue("@total", Convert.ToDouble(Filas.Cells(4).Value))
                    Ctdo.Parameters.AddWithValue("@n_documento", txNFact.Text)
                    Ctdo.Parameters.AddWithValue("@fecha", Date.Now)
                    Ctdo.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GuardaCtaCte()
        Try
            Dim RgtCC As MySqlCommand = New MySqlCommand("INSERT INTO ctacte(id_cliente,movimiento,n_documento,debe,haber,fecha)" &
                                                           "VALUES(@id_cliente, @movimiento, @n_documento, @debe, @haber, @fecha)", Conexion)
            RgtCC.Parameters.Clear()
            RgtCC.Parameters.AddWithValue("@id_cliente", txCodigo.Text)
            RgtCC.Parameters.AddWithValue("@movimiento", "FACTURA")
            RgtCC.Parameters.AddWithValue("@n_documento", txNFact.Text)
            RgtCC.Parameters.AddWithValue("@debe", (txTotalFact.Text * -1))
            RgtCC.Parameters.AddWithValue("@haber", 0)
            RgtCC.Parameters.AddWithValue("@fecha", Date.Now)
            RgtCC.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub RegenerarFormulario()
        Me.Close()
        Dim nuevoFormulario As New ventas()
        nuevoFormulario.Show()
        ConectarDB()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EstadoRegistro = "Buscar Producto"
        consulta_precios.ShowDialog()
        txCodProd.Focus()
    End Sub
End Class