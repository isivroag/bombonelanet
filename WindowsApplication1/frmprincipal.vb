Imports System.ComponentModel
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient


Public Class frmprincipal
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Public username As String
    Public rol As Int32
    Public nrol As String
    Public Sub permisos()

        Select Case rol
            Case 1
                For Each men As ToolStripMenuItem In MenuStrip.Items
                    If men.Name = "mncalendario" Or men.Name = "mnrecepcion" Or men.Name = "mnsalida" Or
                        men.Name = "mnhistorial" Or men.Name = "mntools" Or men.Name = "mnconfiguracion" Or
                        men.Name = "mninventario" Or men.Name = "mngastos" Or men.Name = "mnbodega" Then
                        men.Visible = False
                    Else
                        men.Visible = True
                    End If

                Next

                For Each men As ToolStripMenuItem In mncatalogos.DropDownItems
                    If men.Name = "smnmarca" Or men.Name = "smntipo" Then
                        men.Visible = False
                    Else
                        men.Visible = True
                    End If
                Next

                For Each men As ToolStripMenuItem In mncaja.DropDownItems
                    If men.Name = "smnretirocaja" Then
                        men.Visible = False
                    Else
                        men.Visible = True
                    End If
                Next

                For Each men As ToolStripMenuItem In mnpersonas.DropDownItems
                    If men.Name = "smncolaboradores" Or men.Name = "smnpuestos" Then
                        men.Visible = False
                    Else
                        men.Visible = True
                    End If
                Next

                For Each men As ToolStripMenuItem In mnreportes.DropDownItems
                    If men.Name = "mncventascan" Or men.Name = "mncticketscan" Then
                        men.Visible = False
                    Else
                        men.Visible = True
                    End If
                Next


            Case 2
                For Each men As ToolStripMenuItem In MenuStrip.Items
                    If men.Name = "mncalendario" Or men.Name = "mnrecepcion" Or men.Name = "mnsalida" Or men.Name = "mnhistorial" Or men.Name = "mntools" Then
                        men.Visible = False
                    Else
                        men.Visible = True
                    End If

                Next

            Case 3
                For Each men As ToolStripMenuItem In MenuStrip.Items
                    If men.Name = "mncalendario" Or men.Name = "mnrecepcion" Or men.Name = "mnsalida" Or men.Name = "mnhistorial" Or men.Name = "mntools" Then
                        men.Visible = False
                    Else
                        men.Visible = True
                    End If
                Next



        End Select



    End Sub

    Public Sub barra()
        lbarusuario.Text = username & " ( " & nrol & " )"
    End Sub
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



    Private Sub mnccalendario_Click(sender As Object, e As EventArgs) Handles mncalendario.Click
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




    Private Sub MNCATSERV_Click(sender As Object, e As EventArgs) Handles smnservicios.Click
        If rol = 2 Or rol = 3 Then
            frmcntaservicios.Show()
            frmcntaservicios.BringToFront()
            frmcntaservicios.flag = 1
        Else
            Dim form2 As New frmcntaservicios()
            form2.Show()
        End If

    End Sub

    Private Sub MNCATPROD_Click(sender As Object, e As EventArgs) Handles smnproductos.Click
        If rol = 2 Or rol = 3 Then
            frmcntaproducto.Show()
            frmcntaproducto.BringToFront()
            frmcntaproducto.flag = 1
        Else
            Dim form2 As New frmcntaproducto()

            ' Recorre todos los controles del formulario y oculta los botones


            ' Muestra el formulario modalmemte (bloquea la interacción con otros formularios)
            form2.Show()
        End If
    End Sub

    Private Sub mncobranza_Click(sender As Object, e As EventArgs) Handles mncobranza.Click
        frmcntacuentasclie.Show()
        frmcntacuentasclie.BringToFront()

    End Sub

    Private Sub mncxc_Click(sender As Object, e As EventArgs) Handles mncxc.Click
        frmcntacuentas.Show()
        frmcntacuentas.BringToFront()
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

    Private Sub SUBMNCABINAS_Click(sender As Object, e As EventArgs) Handles smnareas.Click
        frmcntacabina.Show()
        frmcntacabina.BringToFront()
        frmcntacabina.flag = 1
    End Sub

    Private Sub SUBMNALMACENES_Click(sender As Object, e As EventArgs) Handles smnalmacenes.Click
        frmcntaalmacenes.Show()
        frmcntaalmacenes.BringToFront()
        frmcntaalmacenes.flag = 1
    End Sub

    Private Sub SUBMNMARCA_Click(sender As Object, e As EventArgs) Handles smnmarca.Click
        frmcntamarca.Show()
        frmcntamarca.BringToFront()
        frmcntamarca.flag = 1
    End Sub

    Private Sub SUBMNPRIINVENT_Click(sender As Object, e As EventArgs) Handles SUBMNPRIINVENT.Click
        frmpriminvet.Show()
        frmpriminvet.BringToFront()

    End Sub

    Private Sub frmprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicialm(sender, e, "SISTEMA DE CONTROL DE OPERACIONES")
        consulta()
    End Sub

    Private Sub TIPOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles smntipo.Click
        frmcntatipos.Show()
        frmcntatipos.BringToFront()
        frmcntatipos.flag = 1
    End Sub

    Private Sub PROSPECTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles smnprospectos.Click
        frmcntaprospectos.Show()
        frmcntaprospectos.flag = 1
        frmcntaprospectos.BringToFront()
    End Sub

    Private Sub CLIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles smnclientes.Click
        frmcntawcliente.Show()
        frmcntawcliente.flag = 1
        frmcntawcliente.BringToFront()
    End Sub

    Private Sub COLABORADORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles smncolaboradores.Click
        frmcntacolaborador.Show()
        frmcntacolaborador.flag = 1
        frmcntapuesto.BringToFront()
    End Sub

    Private Sub PUESTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles smnpuestos.Click
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
            Case 1, 8
                Dim x As New frmreporte
                x.folio = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
                x.ticket1()
                x.ShowDialog()
            Case 2, 9
                Dim x As New frmreporte2
                x.folio = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
                x.ticket1()
                x.ShowDialog()
            Case 3
                Dim x As New frmreporte3
                x.folio = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
                x.ticket1()
                x.ShowDialog()
            Case 4
                Dim x As New frmreporte4
                x.folio = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
                x.ticket1()
                x.ShowDialog()
            Case 5
                Dim x As New frmreporte5
                x.folio = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
                x.ticket1()
                x.ShowDialog()
            Case 6
                Dim x As New frmreporte6
                x.folio = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
                x.ticket1()
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

    Private Sub mnabrircaja_Click(sender As Object, e As EventArgs) Handles smnabrircaja.Click
        frmabrircaja.Show()
        frmabrircaja.BringToFront()

    End Sub

    Private Sub mngastocaja_Click(sender As Object, e As EventArgs) Handles smngastocaja.Click
        frmcntagasto.Show()
        frmcntagasto.BringToFront()
    End Sub

    Private Sub mnreportecaja_Click(sender As Object, e As EventArgs) Handles smnreportecaja.Click
        frmrptcaja.Show()
        frmrptcaja.BringToFront()

    End Sub

    Private Sub mnretirocaja_Click(sender As Object, e As EventArgs) Handles smnretirocaja.Click
        frmcntaretiros.Show()
        frmcntaretiros.BringToFront()
    End Sub

    Private Sub mnctickets_Click(sender As Object, e As EventArgs) Handles mnctickets.Click
        frmcntatickets.Show()
        frmcntatickets.BringToFront()

    End Sub

    Private Sub mnccumple_Click(sender As Object, e As EventArgs) Handles mnccumple.Click
        frmcumple.Show()
        frmcumple.BringToFront()

    End Sub

    Private Sub Tnmbodega_Click(sender As Object, e As EventArgs) Handles mnbodega.Click
        frmcntamovbodega.Show()
        frmcntamovbodega.BringToFront()

    End Sub

    Private Sub mncambiar_Click(sender As Object, e As EventArgs) Handles mncambiar.Click
        frmlogin.Show()
        Dispose()

    End Sub

    Private Sub mncventas_Click(sender As Object, e As EventArgs) Handles mncventascan.Click
        frmcntavtacan.Show()
        frmcntavtacan.BringToFront()

    End Sub

    Private Sub mncticketscan_Click(sender As Object, e As EventArgs) Handles mncticketscan.Click
        frmticketscan.Show()
        frmticketscan.BringToFront()

    End Sub
End Class
