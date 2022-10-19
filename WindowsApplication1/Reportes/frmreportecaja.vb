Imports MySql.Data.MySqlClient
Public Class frmreportecaja
    Public folio As String
    Public Sub caja()
        Dim sql As String
        Dim conn As New c_mysqlconn
        Dim tabla As New DataTable
        Dim REPORTE As New RptCaja




        sql = "  SELECT caja1.id_caja, caja1.fecha, caja1.inicial, caja1.efectivo, caja1.otros, caja1.gastos, caja1.retiros, caja1.final, caja1.tcredito, caja1.tdebito, caja1.depositos, caja1.transferencias, caja1.amex " &
                "FROM   caja caja1 " &
                "WHERE caja1.id_caja='" & folio & "' ORDER BY caja1.id_caja"




        tabla = conn.consulta(sql)
        If tabla.Rows.Count > 0 Then
            ReportViewer.ReportSource = REPORTE
            REPORTE.SetDataSource(tabla)


            'ReportViewer.Refresh()
        Else
            MsgBox("NO EXISTE REGISTROS EN EL CORTE", vbInformation + vbOKOnly, "CORTE DE CAJA")

        End If

    End Sub

    Private Sub frmreportecaja_Load(sender As Object, e As EventArgs) Handles Me.Load
        inicial(sender, e, "IMPRIMIR")
    End Sub


End Class