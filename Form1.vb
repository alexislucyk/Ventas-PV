Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        DesconectarDB()
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        consulta_precios.MdiParent = Me
        consulta_precios.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ConectarDB()
    End Sub

    Private Sub ABMProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMProductosToolStripMenuItem.Click
        abm_productos.MdiParent = Me
        abm_productos.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'DesconectarDB()
        End
    End Sub

    Private Sub IngresarNuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarNuevoClienteToolStripMenuItem.Click
        abm_clientes.MdiParent = Me
        abm_clientes.Show()
    End Sub

    Private Sub ConsultaDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeClientesToolStripMenuItem.Click
        consulta_clientes.MdiParent = Me
        consulta_clientes.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ventas.MdiParent = Me
        ventas.Show()
    End Sub

    Private Sub ABMRubrosDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMRubrosDeProductosToolStripMenuItem.Click
        abm_rubros_prod.MdiParent = Me
        abm_rubros_prod.Show()
    End Sub

    Private Sub IngresoDeMercaderíaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeMercaderíaToolStripMenuItem.Click
        compras.MdiParent = Me
        compras.Show()
    End Sub


End Class
