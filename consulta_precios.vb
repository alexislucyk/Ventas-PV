﻿Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Public Class consulta_precios
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close
    End Sub

    Private Sub consulta_precios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If EstadoRegistro = "Buscar Producto" Then
            Button1.Visible = True
        Else
            Button1.Visible = False
        End If
        ConectarDB()
        SQL = "SELECT cod_prod,descripcion,p_venta,stock,fecha_ult_compra FROM productos"
        AdapArtic = New MySqlDataAdapter(SQL, Conexion)
        DtArtic = New DataTable
        AdapArtic.Fill(DtArtic)
        DataGridView1.DataSource = DtArtic
        DesconectarDB()
    End Sub

    Private Sub txDescri_TextChanged(sender As Object, e As EventArgs) Handles txDescri.TextChanged
        txCodigo.Text = ""
        Dim DTV As New DataView(DtArtic)
        DTV.RowFilter = String.Format("descripcion LIKE '%{0}%'", txDescri.Text)
        DataGridView1.DataSource = DTV
    End Sub

    Private Sub txCodigo_TextChanged(sender As Object, e As EventArgs) Handles txCodigo.TextChanged
        txDescri.Text = ""
        Dim DTV As New DataView(DtArtic)
        DTV.RowFilter = String.Format("cod_prod LIKE '%{0}%'", txCodigo.Text)
        DataGridView1.DataSource = DTV
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EstadoRegistro = "Buscar Producto" Then
            ventas.txCodProd.Text = DataGridView1.CurrentRow.Cells(0).Value
            EstadoRegistro = ""
            Close()
        End If
    End Sub
End Class