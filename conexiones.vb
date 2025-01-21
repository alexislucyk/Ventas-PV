Imports MySql.Data.MySqlClient
Imports MySql.Data.Types

Module conexiones
    Public Conexion As New MySqlConnection
    Public Comando As New MySqlCommand
    Public SQL As String
    Public AdapArtic As MySqlDataAdapter
    Public AdapConsArtic As MySqlDataAdapter
    Public AdapProvee As MySqlDataAdapter
    Public AdapRubros As MySqlDataAdapter
    Public AdapClie As MySqlDataAdapter
    Public AdapConsClie As MySqlDataAdapter
    Public AdapArticFact As MySqlDataAdapter
    Public DT As DataTable
    Public DtArtic As DataTable
    Public DtClientes As DataTable
    Public DatosProvee As DataSet
    Public DatosRubros As DataSet
    Public DatosConsArtic As DataSet
    Public DatosConsclie As DataSet
    Public EstadoRegistro As String
    Public Actualizar As String
    Public Borrado As String
    Public BindNClie As New BindingSource
    Public BindArt As New BindingSource
    Public BindRubro As New BindingSource
    Public BindNFact As New BindingSource
    Public N_idclie As String
    Public sqlClie As String
    Public Fecha_Operacion As String
    Public Mostrar As Double
    Public TotalCompra As Double
    Public TotalVenta As Double


    Public Sub ConectarDB()
        Conexion = New MySqlConnection("datasource=localhost;user id=root;password=;database=ventas;Allow Zero Datetime=False;Convert Zero Datetime=True")
        Conexion.Open()
    End Sub
    Public Sub DesconectarDB()
        Conexion.Close()
    End Sub
    Public Sub CargarComboRubros(ComboRubros As Object)
        ' Aca llena el combo box con las condiciones de pagos disponibles.
        Dim Consulta As String
        Consulta = "SELECT * FROM rubros"
        AdapRubros = New MySqlDataAdapter(Consulta, Conexion)
        DatosRubros = New DataSet
        DatosRubros.Tables.Add("rubros")
        AdapRubros.Fill(DatosRubros.Tables("rubros"))
        ComboRubros.DataSource = DatosRubros.Tables("rubros")
        ComboRubros.DisplayMember = "nombre"
        ComboRubros.Text = ""
    End Sub

End Module
