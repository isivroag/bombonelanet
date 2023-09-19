Imports MySql.Data.MySqlClient
Public Class frmreporte2
    Public folio As String

    Public Sub ticket1()
        Dim sql As String
        Dim conn As New c_mysqlconn
        Dim tabla As New DataTable
        Dim REPORTE As New Rticket2

        sql = " SELECT vticket1.folio_cxc, vticket1.concepto, vticket1.cantidad, vticket1.precio," &
        "vticket1.subtotal, vticket1.folio_pago, vticket1.nom_clie, vticket1.fecha_pago, vticket1.importe_pago," &
        "vticket1.nom_metodo, vticket1.dinero_pago, vticket1.cambio_pago, vticket1.saldoini_cxc, vticket1.saldofin_cxc, vticket1.letra_pago, vticket1.nom_col " &
        "FROM vticket vticket1 " &
        "WHERE vticket1.folio_pago='" & folio & "'" &
        "ORDER BY vticket1.folio_pago"









        'sql = "Select  vpago1.folio_pago, vpago1.folio_cxc, vpago1.id_clie, vpago1.nom_clie, vpago1.fecha_pago, vpago1.importe_pago, vpago1.nom_metodo, vpago1.dinero_pago, vpago1.cambio_pago, vpago1.saldoini_cxc, vpago1.saldofin_cxc, vpago1.letra_pago, vpago1.nom_col From vpago vpago1 where vpago1.folio_pago='" & folio & "'"

        tabla = conn.consulta(sql)
        If tabla.Rows.Count > 0 Then
            ReportViewer.ReportSource = REPORTE
            REPORTE.SetDataSource(tabla)


            'ReportViewer.Refresh()
        Else
            MsgBox("NO EXISTE REGISTROS EN EL CORTE", vbInformation + vbOKOnly, "CORTE DE CAJA")

        End If
    End Sub

    Public Sub CAJA()
        Dim sql As String
        Dim conn As New c_mysqlconn
        Dim tabla As New DataTable
        Dim REPORTE As New RptTicket2




        sql = "SELECT  vpago1.folio_pago, vpago1.folio_cxc, vpago1.id_clie, vpago1.nom_clie, vpago1.fecha_pago, vpago1.importe_pago, vpago1.nom_metodo, vpago1.dinero_pago, vpago1.cambio_pago, vpago1.saldoini_cxc, vpago1.saldofin_cxc, vpago1.letra_pago, vpago1.nom_col From vpago vpago1 where vpago1.folio_pago='" & folio & "'"

        tabla = conn.consulta(sql)
        If tabla.Rows.Count > 0 Then
            ReportViewer.ReportSource = REPORTE
            REPORTE.SetDataSource(tabla)


            'ReportViewer.Refresh()
        Else
            MsgBox("NO EXISTE REGISTROS EN EL CORTE", vbInformation + vbOKOnly, "CORTE DE CAJA")

        End If

    End Sub

    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles ReportViewer.Load

    End Sub

    Private Sub frmreporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "IMPRIMIR")
        For Each Ctrl As Control In Me.ReportViewer.Controls
            If TypeOf Ctrl Is ToolStrip Then
                For Each Obj As Object In CType(Ctrl, ToolStrip).Items
                    If TypeOf Obj Is ToolStripButton Then
                        'Se agrega el disparador del evento
                        AddHandler CType(Obj, ToolStripButton).Click, AddressOf printButton_Click
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub printButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Aqui ponemos el codigo que necesitamos ejecutar

        Dim conn As New c_mysqlconn
        conn.actualizarimpresion(folio)

    End Sub
End Class