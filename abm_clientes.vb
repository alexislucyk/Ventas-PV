Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class abm_clientes
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub txCodigo_TextChanged(sender As Object, e As EventArgs) Handles txCodigo.TextChanged

    End Sub

    Private Sub txCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Consultar_Cliente()
        End If
    End Sub

    Private Sub Consultar_Cliente()
        Dim consulta As String
        Dim lista As Byte
        Dim tieneCta As String

        Try
            consulta = "SELECT * FROM clientes WHERE id='" & txCodigo.Text & "'"
            AdapConsClie = New MySqlDataAdapter(consulta, Conexion)
            DatosConsclie = New DataSet
            AdapConsClie.Fill(DatosConsclie, "clientes")
            lista = DatosConsclie.Tables("clientes").Rows.Count
            If lista <> 0 Then
                txApellido.Text = DatosConsclie.Tables("clientes").Rows(0).Item("apellido")
                txNombre.Text = DatosConsclie.Tables("clientes").Rows(0).Item("nombre")
                txDireccion.Text = DatosConsclie.Tables("clientes").Rows(0).Item("direccion")
                txCuit.Text = DatosConsclie.Tables("clientes").Rows(0).Item("cuit")
                txTelefono.Text = DatosConsclie.Tables("clientes").Rows(0).Item("telefono")
                ComboEstado.Text = DatosConsclie.Tables("clientes").Rows(0).Item("estado")
                tieneCta = DatosConsclie.Tables("clientes").Rows(0).Item("habilita_cta")
                ComboRelacion.Text = DatosConsclie.Tables("clientes").Rows(0).Item("relacion")
                If tieneCta = "SI" Then
                    chkHabilitaCta.Checked = True
                Else
                    chkHabilitaCta.Checked = False
                End If
                EstadoRegistro = 1
            Else
                EstadoRegistro = 0

                Limpiar()

                txApellido.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guardar()
        Try
            If EstadoRegistro = 0 Then
                HabilitarCTACTE(chkHabilitaCta)

                Comando = New MySqlCommand("INSERT INTO clientes(id,apellido,nombre,direccion,cuit,telefono,estado,habilita_cta,relacion)" & Chr(13) &
                    "VALUES(@id,@apellido,@nombre,@direccion,@cuit,@telefono,@estado,@habilita_cta,@relacion)", Conexion)
                Comando.Parameters.AddWithValue("@id", txCodigo.Text)
                Comando.Parameters.AddWithValue("@apellido", UCase(txApellido.Text))
                Comando.Parameters.AddWithValue("@nombre", UCase(txNombre.Text))
                Comando.Parameters.AddWithValue("@direccion", UCase(txDireccion.Text))
                Comando.Parameters.AddWithValue("@cuit", txCuit.Text)
                Comando.Parameters.AddWithValue("@telefono", txTelefono.Text)
                Comando.Parameters.AddWithValue("@estado", ComboEstado.Text)
                Comando.Parameters.AddWithValue("@habilita_cta", TieneCtaCte)
                Comando.Parameters.AddWithValue("@relacion", ComboRelacion.Text)
                Comando.ExecuteNonQuery()
                Limpiar()
            ElseIf EstadoRegistro = 1 Then
                HabilitarCTACTE(chkHabilitaCta)
                Actualizar = "UPDATE clientes SET apellido='" & UCase(txApellido.Text) &
                    "',nombre='" & UCase(txNombre.Text) & "',direccion='" & UCase(txDireccion.Text) & "',cuit='" & txCuit.Text &
                    "',telefono='" & txTelefono.Text & "',estado='" & ComboEstado.Text & "',habilita_cta='" & TieneCtaCte & "',relacion='" & ComboRelacion.Text &
                    "' WHERE id='" & txCodigo.Text & "'"
                Comando = New MySqlCommand(Actualizar, Conexion)
                Comando.ExecuteNonQuery()
                Limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GuardarProveedor()
        Dim razon_prov As String
        razon_prov = UCase(txApellido.Text) & " " & UCase(txNombre.Text)
        Try
            If EstadoRegistroProv = 0 Then
                Comando = New MySqlCommand("INSERT INTO proveedores(cod_prov,razon,cuit,telefono)" & Chr(13) &
                                            "VALUES(@cod_prov,@razon,@cuit,@telefono)", Conexion)
                Comando.Parameters.AddWithValue("@cod_prov", txCodigo.Text)
                Comando.Parameters.AddWithValue("@razon", razon_prov)
                Comando.Parameters.AddWithValue("@cuit", txCuit.Text)
                Comando.Parameters.AddWithValue("@telefono", txTelefono.Text)
                Comando.ExecuteNonQuery()
                Limpiar()
            ElseIf EstadoRegistroProv = 1 Then
                Actualizar = "UPDATE proveedores SET razon='" & razon_prov &
                    "',cuit='" & txCuit.Text &
                    "',telefono='" & txTelefono.Text &
                    "' WHERE cod_prov='" & txCodigo.Text & "'"
                Comando = New MySqlCommand(Actualizar, Conexion)
                Comando.ExecuteNonQuery()
                Limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        txCodigo.Text = ""
        txApellido.Text = ""
        txNombre.Text = ""
        txDireccion.Text = ""
        txCuit.Text = ""
        txTelefono.Text = ""
        ComboEstado.Text = ""
        ComboRelacion.Text = ""
        chkHabilitaCta.Checked = False
    End Sub
    Private Sub Nuevo_id_clie()
        Dim AdapCodClie As New MySqlDataAdapter("SELECT id FROM clientes ORDER BY id", Conexion)
        Dim DT As New DataTable
        AdapCodClie.Fill(DT)
        BindNClie.DataSource = DT
        BindNClie.MoveLast()
        N_idclie = BindNClie.Current("id").ToString + 1
        txCodigo.Text = N_idclie
    End Sub
    Private Sub abm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConectarDB()
            CargarClientes()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CargarClientes()
        sqlClie = "SELECT * FROM clientes"
        AdapClie = New MySqlDataAdapter(sqlClie, Conexion)
        DtClientes = New DataTable
        AdapClie.Fill(DtClientes)
        GridClientes.DataSource = DtClientes
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Limpiar()
        Nuevo_id_clie()
        txApellido.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboRelacion.Text = "CLIENTE" Then
            Guardar()
            CargarClientes()
        ElseIf ComboRelacion.Text = "PROVEEDOR" Then

            BuscarEnTablaProveedor()
            GuardarProveedor()
            Guardar()
            CargarClientes()
        End If
    End Sub
    Private Sub GridClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridClientes.CellClick

        If GridClientes.SelectedRows.Count > 0 Then
            Dim tieneCta As String
            txCodigo.Text = Convert.ToString(GridClientes.Item("Column1", GridClientes.SelectedRows(0).Index).Value)
            txApellido.Text = Convert.ToString(GridClientes.Item("Column2", GridClientes.SelectedRows(0).Index).Value)
            txNombre.Text = Convert.ToString(GridClientes.Item("Column3", GridClientes.SelectedRows(0).Index).Value)
            txDireccion.Text = Convert.ToString(GridClientes.Item("Column4", GridClientes.SelectedRows(0).Index).Value)
            txCuit.Text = Convert.ToString(GridClientes.Item("Column5", GridClientes.SelectedRows(0).Index).Value)
            txTelefono.Text = Convert.ToString(GridClientes.Item("Column6", GridClientes.SelectedRows(0).Index).Value)
            ComboEstado.Text = Convert.ToString(GridClientes.Item("Column7", GridClientes.SelectedRows(0).Index).Value)
            ComboRelacion.Text = Convert.ToString(GridClientes.Item("Column8", GridClientes.SelectedRows(0).Index).Value)
            tieneCta = Convert.ToString(GridClientes.Item("Column9", GridClientes.SelectedRows(0).Index).Value)
            If tieneCta = "SI" Then
                chkHabilitaCta.Checked = True
            Else
                chkHabilitaCta.Checked = False
            End If
            EstadoRegistro = 1
        End If
    End Sub
    Private Sub BuscarEnTablaProveedor()
        Dim consulta2 As String
        Dim lista2 As Byte

        Try
            consulta2 = "SELECT * FROM proveedores WHERE cod_prov='" & txCodigo.Text & "'"
            AdapConsClie = New MySqlDataAdapter(consulta2, Conexion)
            DatosConsclie = New DataSet
            AdapConsClie.Fill(DatosConsclie, "proveedores")
            lista2 = DatosConsclie.Tables("proveedores").Rows.Count
            If lista2 <> 0 Then
                EstadoRegistroProv = 1
            Else
                EstadoRegistroProv = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class