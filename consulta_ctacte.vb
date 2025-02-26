Imports MySql.Data.MySqlClient

Public Class consulta_ctacte
    Dim Fdesde As String
    Dim Fhasta As String
    Public Consql As String
    Public DT As DataTable
    Public DA As MySqlDataAdapter
    Public Bind As New BindingSource
    Private Sub consulta_ctacte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarDB()
        Dim rtn As New Date
        rtn = Date.Now
        rtn = rtn.AddDays(-rtn.Day + 1)  'Aqui obtiene el primer dia del mes actual
        DTPdesde.Value = rtn             'Aqui asigna el primer dia obtenido a "Fecha Desde"
    End Sub

    Private Sub Consultar()
        Fdesde = DTPdesde.Value.ToString("yyyy/MM/dd")
        Fhasta = DTPhasta.Value.ToString("yyyy/MM/dd")
        'Dim sal As Double
        If txCodigo.Text = "" Then
            MessageBox.Show("Debe ingresar cliente.!!")
        Else
            Consql = ("Select ctacte.fecha,ctacte.debe,ctacte.haber,CONCAT(ctacte.movimiento,' ',ctacte.n_documento) AS Detalle " &
                      "FROM ctacte WHERE fecha Between '" & Fdesde &
                      "' And '" & Fhasta & "' And id_cliente='" & txCodigo.Text & "' Order by fecha")
            Filtro()
            CargaSaldo()
        End If
    End Sub
    Sub Filtro()
        DA = New MySqlDataAdapter(Consql, Conexion)
        DT = New DataTable
        DA.Fill(DT)
        Bind.DataSource = DT
        DGV.DataSource = Bind
        With DGV  ' Se ordenan las columnas
            .Columns("Column1").DisplayIndex = 0
            .Columns("Column2").DisplayIndex = 1
            .Columns("Column3").DisplayIndex = 2
            .Columns("Column3").DefaultCellStyle.ForeColor = Color.Red
            .Columns("Column4").DisplayIndex = 3
            .Columns("Saldo").DisplayIndex = 4
        End With
    End Sub
    Sub CargaSaldo()
        Dim SaldoAcum As Integer = 0
        Dim Filas As DataGridViewRow = New DataGridViewRow
        Try
            For Each Filas In DGV.Rows
                If Filas.IsNewRow Then
                    Exit For
                Else
                    Dim D As Integer = 0
                    Int32.TryParse(Filas.Cells("Column3").Value, D)

                    Dim H As Integer = 0
                    Int32.TryParse(Filas.Cells("Column4").Value, H)

                    SaldoAcum = SaldoAcum + D - H
                    Filas.Cells("Saldo").Value = CStr(SaldoAcum)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Consultar()
    End Sub
End Class