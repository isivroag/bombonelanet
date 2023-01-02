Imports MySql.Data.MySqlClient
Public Class frmreporteretiro
    Public folio As String

    Public Sub retiro()
        Dim sql As String
        Dim conn As New c_mysqlconn
        Dim tabla As New DataTable
        Dim REPORTE As New RptRetiro




        sql = "SELECT retiro1.id_retiro, retiro1.fecha, retiro1.monto, retiro1.fechaop, retiro1.montoant, retiro1.montodesp FROM retiro retiro1 where retiro1.id_retiro='" & folio & "'"

        tabla = conn.consulta(sql)
        If tabla.Rows.Count > 0 Then
            ReportViewer.ReportSource = REPORTE
            REPORTE.SetDataSource(tabla)


            'ReportViewer.Refresh()
        Else
            MsgBox("NO EXISTE REGISTROS", vbInformation + vbOKOnly, "RETIRO DE CAJA")

        End If

    End Sub
    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles ReportViewer.Load

    End Sub

    Private Sub frmreporteretiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "IMPRIMIR")
    End Sub
End Class