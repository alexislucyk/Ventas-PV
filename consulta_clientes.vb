Imports MySql.Data.MySqlClient
Public Class consulta_clientes

    Private Sub consulta_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConectarDB()
            sqlClie = "SELECT * FROM clientes"
            AdapClie = New MySqlDataAdapter(sqlClie, Conexion)
            DtClientes = New DataTable
            AdapClie.Fill(DtClientes)
            GridClientes.DataSource = DtClientes
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txApellido_TextChanged(sender As Object, e As EventArgs) Handles txApellido.TextChanged
        Dim dtv As New DataView(DtClientes)
        dtv.RowFilter = String.Format("apellido LIKE '%{0}%'", txApellido.Text)
        GridClientes.DataSource = dtv
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()

    End Sub

    Private Sub txNombre_TextChanged(sender As Object, e As EventArgs) Handles txNombre.TextChanged

        Dim dtv2 As New DataView(DtClientes)
        dtv2.RowFilter = String.Format("nombre LIKE '%{0}%'", txNombre.Text)
        GridClientes.DataSource = dtv2
    End Sub

    Private Sub txNombre_Click(sender As Object, e As EventArgs) Handles txNombre.Click
        txApellido.Text = ""
    End Sub

    Private Sub txApellido_Click(sender As Object, e As EventArgs) Handles txApellido.Click
        txNombre.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EstadoRegistro = "Buscar Cliente" Then
            ventas.txCodigo.Text = GridClientes.CurrentRow.Cells(0).Value
            EstadoRegistro = ""
            Close()
        End If
    End Sub
End Class