Imports System.Runtime.InteropServices.JavaScript.JSType
Imports MySql
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class ventas
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DesconectarDB()
        Close()
    End Sub

    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarDB()
        Fecha_Operacion = DateTime.Now.ToString("dd/MM/yyyy")
        AdapArticFact = New MySqlDataAdapter("SELECT * FROM productos ORDER BY descripcion", Conexion)
        Dim SQLBuilder As New MySqlCommandBuilder(AdapArticFact)
        DT = New DataTable
        AdapArticFact.Fill(DT)
        BindArt.DataSource = DT

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

    Private Sub txCodProd_TextChanged(sender As Object, e As EventArgs) Handles txCodProd.TextChanged

    End Sub

    Private Sub txCant_TextChanged(sender As Object, e As EventArgs) Handles txCant.TextChanged

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
        Dim Total As Double = 0
        Dim Mostrar As Double = 0
        Dim Filita As DataGridViewRow = New DataGridViewRow()
        For Each Filita In TablaDetalle.Rows
            Total += Convert.ToDouble(Filita.Cells("Column5").Value)
        Next
        Mostrar = Convert.ToString(Total)
        Button2.Text = Format(Mostrar, "$ #,##0.000")
    End Sub

End Class