Imports System.ComponentModel
Imports MySql.Data.MySqlClient


Public Class frmprincipal
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Private Sub mnsalir_Click(sender As Object, e As EventArgs) Handles mnsalir.Click
        Dim Msg As MsgBoxResult
        Msg = MsgBox("¿DESEA SALIR DEL SISTEMA?", vbQuestion + vbYesNo, "SALIR")
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
            End
        Else
            Exit Sub
        End If
    End Sub


    Public Sub consulta()
        conn = New c_mysqlconn
        tabla = New DataTable

        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()

        conn.consulta(grdatos, "select folio_pago,importe_pago from pago where impreso=0 order by folio_pago")
        If grdatos.Rows.Count = 0 Then
            pimpresion.Visible = False
            grdatos.DataSource = Nothing
            grdatos.Rows.Clear()
            grdatos.Columns.Clear()
            grdatos.ColumnCount = 2
        Else
            pimpresion.Visible = True
        End If
        formatogrid()


    End Sub


    Private Sub formatogrid()

        grdatos.Columns(0).HeaderText = "FOLIO"
        grdatos.Columns(1).HeaderText = "IMPORTE"

        grdatos.AutoResizeColumns()

        grdatos.AutoResizeRows()

        grdatos.Columns(1).DefaultCellStyle.Format = "C2"
        grdatos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight



    End Sub



    Private Sub mnccalendario_Click(sender As Object, e As EventArgs) Handles mnccalendario.Click
        frmcalendario.Show()
        frmcalendario.BringToFront()
        'frmcal.Show()
        'frmcal.BringToFront()
    End Sub



    Private Sub mnrecepcion_Click(sender As Object, e As EventArgs) Handles mnrecepcion.Click
        frmrecepcion.Show()
        frmrecepcion.BringToFront()

    End Sub



    Private Sub frmprincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Msg As MsgBoxResult
        Msg = MsgBox("¿DESEA SALIR DEL SISTEMA?", vbQuestion + vbYesNo, "SALIR")
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub mnsalida_Click(sender As Object, e As EventArgs) Handles mnsalida.Click
        frmsalida.Show()

    End Sub



    Private Sub mninventario_Click(sender As Object, e As EventArgs) Handles mninventario.Click
        frminventario.Show()
        frminventario.BringToFront()
    End Sub




    Private Sub MNCATSERV_Click(sender As Object, e As EventArgs) Handles MNCATSERV.Click
        frmcntaservicios.Show()
        frmcntaservicios.BringToFront()
        frmcntaservicios.flag = 1
    End Sub

    Private Sub MNCATPROD_Click(sender As Object, e As EventArgs) Handles MNCATPROD.Click
        frmcntaproducto.Show()
        frmcntaproducto.BringToFront()
        frmcntaproducto.flag = 1
    End Sub

    Private Sub mncobranza_Click(sender As Object, e As EventArgs) Handles mncobranza.Click
        frmcntacuentasclie.Show()
        frmcntacuentasclie.BringToFront()

    End Sub

    Private Sub mncxc_Click(sender As Object, e As EventArgs) Handles mncxc.Click
        frmcntacuentas.Show()
    End Sub

    Private Sub mncingresos_Click(sender As Object, e As EventArgs) Handles mncingresos.Click
        frmcntaingresos.Show()
        frmcntaingresos.BringToFront()
    End Sub

    Private Sub mnventas_Click(sender As Object, e As EventArgs) Handles mnventas.Click
        frmcobranza.Show()
        frmcobranza.BringToFront()

    End Sub

    Private Sub mnhistorial_Click(sender As Object, e As EventArgs)
        frmncntaprospecto.Show()
        frmncntaprospecto.flag = 1
        frmncntaprospecto.BringToFront()

    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub SUBMNCABINAS_Click(sender As Object, e As EventArgs) Handles SUBMNCABINAS.Click
        frmcntacabina.Show()
        frmcntacabina.BringToFront()
        frmcntacabina.flag = 1
    End Sub

    Private Sub SUBMNALMACENES_Click(sender As Object, e As EventArgs) Handles SUBMNALMACENES.Click
        frmcntaalmacenes.Show()
        frmcntaalmacenes.BringToFront()
        frmcntaalmacenes.flag = 1
    End Sub

    Private Sub SUBMNMARCA_Click(sender As Object, e As EventArgs) Handles SUBMNMARCA.Click
        frmcntamarca.Show()
        frmcntamarca.BringToFront()
        frmcntamarca.flag = 1
    End Sub

    Private Sub SUBMNPRIINVENT_Click(sender As Object, e As EventArgs) Handles SUBMNPRIINVENT.Click
        frmpriminvet.Show()
        frmpriminvet.BringToFront()

    End Sub

    Private Sub frmprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "SISTEMA DE CONTROL DE OPERACIONES")
        consulta()
    End Sub

    Private Sub TIPOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TIPOSToolStripMenuItem.Click
        frmcntatipos.Show()
        frmcntatipos.BringToFront()
        frmcntatipos.flag = 1
    End Sub

    Private Sub PROSPECTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROSPECTOSToolStripMenuItem.Click
        frmcntaprospectos.Show()
        frmcntaprospectos.flag = 1
        frmcntaprospectos.BringToFront()
    End Sub

    Private Sub CLIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIENTESToolStripMenuItem.Click
        frmcntawcliente.Show()
        frmcntawcliente.flag = 1
        frmcntawcliente.BringToFront()
    End Sub

    Private Sub COLABORADORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COLABORADORESToolStripMenuItem.Click
        frmcntacolaborador.Show()
        frmcntacolaborador.flag = 1
        frmcntapuesto.BringToFront()
    End Sub

    Private Sub PUESTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PUESTOSToolStripMenuItem.Click
        frmcntapuesto.Show()
        frmcntapuesto.flag = 1
        frmcntapuesto.BringToFront()
    End Sub

    Private Sub submnpartida_Click(sender As Object, e As EventArgs) Handles submnpartida.Click
        frmcntapartida.Show()
        frmcntapartida.BringToFront()
        frmcntapartida.flag = 1
    End Sub

    Private Sub submnproveedor_Click(sender As Object, e As EventArgs) Handles submnproveedor.Click
        frmcntaproveedor.Show()
        frmcntaproveedor.BringToFront()
        frmcntaproveedor.flag = 1
    End Sub

    Private Sub submnegresos_Click(sender As Object, e As EventArgs) Handles submnegresos.Click
        frmcntaegresos.Show()
        frmcntaegresos.BringToFront()
        'frmcntaegresos.flag = 1

    End Sub

    Private Sub mngastos_Click(sender As Object, e As EventArgs) Handles mngastos.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pimpresion_Paint(sender As Object, e As PaintEventArgs) Handles pimpresion.Paint

    End Sub

    Private Sub tconsulta_Tick(sender As Object, e As EventArgs) Handles tconsulta.Tick
        consulta()

    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub

    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick
        imprimir()
    End Sub
    Private Sub imprimir()
        'frmrepo.nombre = "CHEJERE.RptTicket.rdlc"
        'frmrepo.folio_cob = folio_cob

        '  frmrepo.Show()
        ' frmrepo.ticket()
        Dim sucursal As String
        sucursal = My.Settings.sucursal
        Select Case (sucursal)
            Case 1
                Dim x As New frmreporte
                x.folio = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
                x.CAJA()
                x.ShowDialog()
            Case 2
                Dim x As New frmreporte2
                x.folio = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
                x.CAJA()
                x.ShowDialog()
            Case 3
                Dim x As New frmreporte3
                x.folio = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
                x.CAJA()
                x.ShowDialog()
            Case 4
                Dim x As New frmreporte4
                x.folio = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
                x.CAJA()
                x.ShowDialog()
            Case Else
                Dim x As New frmreporte
                x.folio = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
                x.CAJA()
                x.ShowDialog()

        End Select


    End Sub

    Private Sub mncinventarios_Click(sender As Object, e As EventArgs) Handles mncinventarios.Click
        frmcntainventario.Show()
        frmcntainventario.BringToFront()
    End Sub

    Private Sub mncventadet_Click(sender As Object, e As EventArgs) Handles mncventadet.Click
        frmcntavtadet.Show()
        frmcntavtadet.BringToFront()
    End Sub

    Private Sub mncventadetpago_Click(sender As Object, e As EventArgs) Handles mncventadetpago.Click
        frmcntavtadetpago.Show()
        frmcntavtadetpago.BringToFront()
    End Sub

    Private Sub mnabrircaja_Click(sender As Object, e As EventArgs) Handles mnabrircaja.Click
        frmabrircaja.Show()
        frmabrircaja.BringToFront()

    End Sub

    Private Sub mngastocaja_Click(sender As Object, e As EventArgs) Handles mngastocaja.Click
        frmcntagasto.Show()
        frmcntagasto.BringToFront()
    End Sub

    Private Sub mnreportecaja_Click(sender As Object, e As EventArgs) Handles mnreportecaja.Click
        frmrptcaja.Show()
        frmrptcaja.BringToFront()

    End Sub
End Class
