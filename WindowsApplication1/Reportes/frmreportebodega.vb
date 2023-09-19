Imports MySql.Data.MySqlClient
Public Class frmreportebodega
    Public folio As String

    Public Sub documento()
        Dim sql As String
        Dim conn As New c_mysqlconn
        Dim tabla As New DataTable
        Dim REPORTE As New rptbodega

        sql = "SELECT vbodega1.folio_trans, vbodega1.fecha_trans, vbodega1.obs_trans, vbodega1.importetransfer, vbodega1.clave_prod, vbodega1.concepto, vbodega1.cantidad, vbodega1.unidad, vbodega1.costo, vbodega1.importe, vbodega1.nom_origen, vbodega1.nom_destino " &
            "FROM vbodega vbodega1 " &
            "WHERE vbodega1.folio_trans='" & folio & "' " &
            "ORDER BY vbodega1.id_reg"

        tabla = conn.consulta(sql)
        If tabla.Rows.Count > 0 Then
            ReportViewer.ReportSource = REPORTE
            REPORTE.SetDataSource(tabla)


            'ReportViewer.Refresh()
        Else
            MsgBox("NO EXISTE REGISTROS EN EL CORTE", vbInformation + vbOKOnly, "CORTE DE CAJA")

        End If
    End Sub

    Private Sub frmreportebodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "IMPRIMIR")
    End Sub
End Class