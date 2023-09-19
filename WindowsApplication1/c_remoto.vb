Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class c_remoto
    Public _sql As String
    Public _conexion As New MySqlConnection
    Private adaptador As New MySqlDataAdapter
    Private ta As New DataTable


    Public dtsdatos As New DataSet
    Public dtvdatos As New DataView
    Private Sub conexion()
        _sql = "server=" & My.Settings.wserver & "; Uid=" & My.Settings.wuser & "; Pwd=" & My.Settings.wpwd & ";database=" & My.Settings.wdb & ""
        _conexion = New MySqlConnection(_sql)
    End Sub
    Public Sub desconectar()
        _conexion.Close()

    End Sub


    Public Function actualizarcaja(ByVal datos As c_caja, ByVal sucursal As Int64) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("replace into caja Set id_sucursal=@id_sucursal,inicial=@monto,fecha=@fecha,efectivo=@efectivo,depositos=@deposito,transferencias=@transferencias,tdebito=@tdebito,tcredito=@tcredito,amex=@amex,otros=@otros,gastos=@gastos,retiros=@retiros,final=@final", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_sucursal", MySqlDbType.Int64).Value = sucursal
            adaptador.UpdateCommand.Parameters.Add("@id_caja", MySqlDbType.Int64).Value = datos.Id_caja
            adaptador.UpdateCommand.Parameters.Add("@fecha", MySqlDbType.Date).Value = datos.Fecha
            adaptador.UpdateCommand.Parameters.Add("@monto", MySqlDbType.Double).Value = datos.Inicial
            adaptador.UpdateCommand.Parameters.Add("@efectivo", MySqlDbType.Double).Value = datos.Efectivo

            adaptador.UpdateCommand.Parameters.Add("@deposito", MySqlDbType.Double).Value = datos.Deposito
            adaptador.UpdateCommand.Parameters.Add("@transferencias", MySqlDbType.Double).Value = datos.Transferencia
            adaptador.UpdateCommand.Parameters.Add("@tdebito", MySqlDbType.Double).Value = datos.Tdebito
            adaptador.UpdateCommand.Parameters.Add("@tcredito", MySqlDbType.Double).Value = datos.Tcredito
            adaptador.UpdateCommand.Parameters.Add("@amex", MySqlDbType.Double).Value = datos.Amex

            adaptador.UpdateCommand.Parameters.Add("@otros", MySqlDbType.Double).Value = datos.Otros
            adaptador.UpdateCommand.Parameters.Add("@gastos", MySqlDbType.Double).Value = datos.Gastos
            adaptador.UpdateCommand.Parameters.Add("@retiros", MySqlDbType.Double).Value = datos.Retiros
            adaptador.UpdateCommand.Parameters.Add("@final", MySqlDbType.Double).Value = datos.Final

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
End Class
