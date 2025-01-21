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
                If tieneCta = "SI" Then
                    chkHabilitaCta.Checked = True
                Else
                    chkHabilitaCta.Checked = False
                End If
                EstadoRegistro = 1
            Else
                EstadoRegistro = 0

                txApellido.Text = ""
                txNombre.Text = ""
                txDireccion.Text = ""
                txCuit.Text = ""
                txTelefono.Text = ""
                ComboEstado.Text = ""
                chkHabilitaCta.Checked = False
                txApellido.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guardar()
        Try
            If EstadoRegistro = 0 Then
                Comando = New MySqlCommand("INSERT INTO clientes(id,apellido,nombre,direccion,cuit,telefono,estado)" & Chr(13) &
                    "VALUES(@id,@apellido,@nombre,@direccion,@cuit,@telefono,@estado)", Conexion)
                Comando.Parameters.AddWithValue("@id", txCodigo.Text)
                Comando.Parameters.AddWithValue("@apellido", UCase(txApellido.Text))
                Comando.Parameters.AddWithValue("@nombre", UCase(txNombre.Text))
                Comando.Parameters.AddWithValue("@direccion", UCase(txDireccion.Text))
                Comando.Parameters.AddWithValue("@cuit", txCuit.Text)
                Comando.Parameters.AddWithValue("@telefono", txTelefono.Text)
                Comando.Parameters.AddWithValue("@estado", ComboEstado.Text)
                Comando.ExecuteNonQuery()
                Limpiar()
            ElseIf EstadoRegistro = 1 Then
                Actualizar = "UPDATE clientes SET apellido='" & UCase(txApellido.Text) &
                    "',nombre='" & UCase(txNombre.Text) & "',direccion='" & UCase(txDireccion.Text) & "',cuit='" & txCuit.Text &
                    "',telefono='" & txTelefono.Text & "',estado='" & ComboEstado.Text & "' WHERE id='" & txCodigo.Text & "'"
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
        ConectarDB()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Limpiar()
        Nuevo_id_clie()
        txApellido.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Guardar()
    End Sub
End Class