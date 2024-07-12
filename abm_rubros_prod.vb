Imports MySql.Data.MySqlClient

Public Class abm_rubros_prod
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DesconectarDB()
        Close()
    End Sub

    Private Sub abm_rubros_prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarDB()
        CargarComboRubros(ComboRubros)
    End Sub

    Private Sub ConsultarRubro()
        Dim consulta As String
        Dim lista As Byte
        consulta = "SELECT * FROM rubros WHERE id='" & txIdRubro.Text & "'"
        AdapRubros = New MySqlDataAdapter(consulta, Conexion)
        DatosRubros = New DataSet
        AdapRubros.Fill(DatosRubros, "rubros")
        lista = DatosRubros.Tables("rubros").Rows.Count
        If lista <> 0 Then
            txNombreRubro.Text = DatosRubros.Tables("rubros").Rows(0).Item("nombre")
            EstadoRegistro = 1
        Else
            EstadoRegistro = 0
            txNombreRubro.Focus()
        End If
    End Sub

    Private Sub txIdRubro_KeyDown(sender As Object, e As KeyEventArgs) Handles txIdRubro.KeyDown
        If e.KeyCode = Keys.Enter Then
            ConsultarRubro()
        End If
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Guardar()
    End Sub
    Private Sub Guardar()
        Try
            If EstadoRegistro = 0 Then
                Comando = New MySqlCommand("INSERT INTO rubros(id,nombre)" & Chr(13) &
                    "VALUES(@id,@nombre,)", Conexion)
                Comando.Parameters.AddWithValue("@id", txIdRubro.Text)
                Comando.Parameters.AddWithValue("@nombre", UCase(txNombreRubro.Text))
                Comando.ExecuteNonQuery()
                txIdRubro.Text = String.Empty
                txNombreRubro.Text = String.Empty
            ElseIf EstadoRegistro = 1 Then
                Actualizar = "UPDATE rubros SET nombre='" & UCase(txNombreRubro.Text) & "' WHERE id='" & txIdRubro.Text & "'"
                Comando = New MySqlCommand(Actualizar, Conexion)
                Comando.ExecuteNonQuery()
                txIdRubro.Text = String.Empty
                txNombreRubro.Text = String.Empty
            End If
            CargarComboRubros(ComboRubros)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Nuevo_id_rubro()
    End Sub
    Private Sub Nuevo_id_rubro()
        Dim AdapIdRubro As New MySqlDataAdapter("SELECT id FROM rubros ORDER BY id", Conexion)
        Dim DT As New DataTable
        AdapIdRubro.Fill(DT)
        BindRubro.DataSource = DT
        BindRubro.MoveLast()
        N_idclie = BindRubro.Current("id").ToString + 1
        txIdRubro.Text = N_idclie
    End Sub
End Class