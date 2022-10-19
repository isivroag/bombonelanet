Imports MySql.Data.MySqlClient

Public Class frmcobranza
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Dim table As DataTable
    Public id_clie As Int64
    Public folio_vis As Int64
    Public folio_cxc As Int64
    Public id_serv As Int64
    Public flag As Integer
    Public saldo As Double
    Dim folpaquete As Int64

    Public Sub mostrar()
        conn = New c_mysqlconn
        table = New DataTable
        table = conn.consulta("select * from cxc where folio_cxc='" & folio_cxc & "'")
        If table.Rows.Count > 0 Then
            tfolio.Text = table.Rows(0).Item("folio_cxc")
            tid_clie.Text = table.Rows(0).Item("id_clie")
            id_clie = table.Rows(0).Item("id_clie")
            ttotal.Text = table.Rows(0).Item("total_cxc")
            tfecha.Text = table.Rows(0).Item("fecha_cxc")
            ccol.Text = table.Rows(0).Item("id_col") & " " & table.Rows(0).Item("nom_col")
            tletras.Text = EnLetras(ttotal.Text)
            saldo = table.Rows(0).Item("saldo_cxc")
            tconcepto.Text = table.Rows(0).Item("concepto_cxc")
            tdescuento.Text = table.Rows(0).Item("descuento_cxc")
            tsubtotal.Text = table.Rows(0).Item("subtotal_cxc")

        End If

        buscarcliente()

        conn = New c_mysqlconn
        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()



        conn.consulta(grdatos, "select id_reg,id_item,id_pqt,clave,concepto,cantidad,precio,subtotal,estado_det,tipo_item from det_cxc where folio_cxc='" & folio_cxc & "' order by id_reg")
        If grdatos.Rows.Count = 0 Then

            grdatos.DataSource = Nothing
            grdatos.Rows.Clear()
            grdatos.Columns.Clear()
            grdatos.ColumnCount = 10
        End If
        formatogrid()
    End Sub


    Public Sub agregarp(ByVal detalle As c_producto, ByVal cantidad As Double, ByVal precio As Double)

        'For Each row As DataGridViewRow In grdatos.Rows
        ' If Convert.ToString(row.Cells(9).Value) = "SERVICIO" Then
        ' MessageBox.Show("Las operaciones por servicio solo pueden contener un concepto" & Chr(13) & " Si necesita cobrar mas conceptos puede generar una nueva venta", "Cobranza", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        'Exit Sub
        'End If


        'Next

        Dim valor As String = Convert.ToString(detalle.Id_prod)

        '        Dim UltimaFila As Integer
        '       UltimaFila = grdatos.Rows.Count - 1

        'For Each row As DataGridViewRow In grdatos.Rows

        'If Convert.ToString(row.Cells(1).Value) = valor And Convert.ToString(row.Cells(9).Value) = "PRODUCTO" Then
        'MessageBox.Show("El Item ya ha sido agregado al detalle", "Datos duplicados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        'Exit Sub
        'End If
        'Next

        grdatos.VirtualMode = False

        grdatos.Rows.Add(0, detalle.Id_prod, 0, detalle.Clave_prod, detalle.Nom_prod, cantidad, precio.ToString, precio * cantidad, 1, "PRODUCTO")

        'grdatos.Rows.Add()
        'fila = grdatos.Rows.Count - 1
        'grdatos.Item(fila, 1).Value = detalle.id_item

        'grdatos.Item(1, fila).Value = detalle.item
        'grdatos.Item(1, fila).Value = detalle.cant_item
        'grdatos.Item(1, fila).Value = detalle.id_umed
        'grdatos.Item(1, fila).Value = detalle.medida
        'grdatos.Item(1, fila).Value = detalle.total_detalle
        formatogrid()
        sumartotal()
    End Sub
    Public Sub agregar(ByVal detalle As c_paquete, ByVal cantidad As Double, precio As Double)

        ' solo un servicio
        'For Each row As DataGridViewRow In grdatos.Rows
        ' If Convert.ToString(row.Cells(9).Value) = "SERVICIO" Or Convert.ToString(row.Cells(9).Value) = "PRODUCTO" Then
        'MessageBox.Show("Las operaciones por servicio solo pueden contener un concepto" & Chr(13) & " Si necesita cobrar mas conceptos puede generar una nueva venta", "Cobranza", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        'Exit Sub
        'End If


        'Next

        Dim valor As String = Convert.ToString(detalle.Id_pqt)

        Dim UltimaFila As Integer
        UltimaFila = grdatos.Rows.Count - 1

        'For Each row As DataGridViewRow In grdatos.Rows

        '      If Convert.ToString(row.Cells(1).Value) = valor And Convert.ToString(row.Cells(9).Value) = "SERVICIO" Then
        '     MessageBox.Show("El Item ya ha sido agregado al detalle", "Datos duplicados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        '    Exit Sub
        '   End If
        '  Next



        grdatos.VirtualMode = False
        conn = New c_mysqlconn
        tabla = New DataTable
        tabla = conn.consulta("select * from servicio where id_serv='" & detalle.Id_serv & "'")
        Dim servicio As String = ""

        If tabla.Rows.Count > 0 Then

            servicio = tabla.Rows(0).Item("nom_serv")
        End If
        grdatos.Rows.Add(0, detalle.Id_serv, detalle.Id_pqt, detalle.Clave_pqt, servicio & " " & detalle.Desc_pqt, cantidad, precio.ToString, precio * cantidad, 1, "SERVICIO")

        'grdatos.Rows.Add()
        'fila = grdatos.Rows.Count - 1
        'grdatos.Item(fila, 1).Value = detalle.id_item

        'grdatos.Item(1, fila).Value = detalle.item
        'grdatos.Item(1, fila).Value = detalle.cant_item
        'grdatos.Item(1, fila).Value = detalle.id_umed
        'grdatos.Item(1, fila).Value = detalle.medida
        'grdatos.Item(1, fila).Value = detalle.total_detalle
        formatogrid()
        sumartotal()
    End Sub

    Private Sub sumartotal()
        Dim suma As Double = 0
        For Each row As DataGridViewRow In grdatos.Rows

            suma += Convert.ToDouble(row.Cells(7).Value)

        Next
        tsubtotal.Text = suma


        tsubtotal.Text = FormatCurrency(tsubtotal.Text, 2)

        calcular()

    End Sub
    Private Sub formatogrid()

        grdatos.Columns(0).HeaderText = "FOLIO"
        grdatos.Columns(1).HeaderText = "ID_SERV"
        grdatos.Columns(2).HeaderText = "ID_PQT"
        grdatos.Columns(3).HeaderText = "CLAVE"
        grdatos.Columns(4).HeaderText = "CONCEPTO"
        grdatos.Columns(5).HeaderText = "CANTIDAD"
        grdatos.Columns(6).HeaderText = "PRECIO"
        grdatos.Columns(7).HeaderText = "SUBTOTAL"
        grdatos.Columns(8).HeaderText = "ESTADO"
        grdatos.Columns(9).HeaderText = "TIPO"

        grdatos.Columns(4).DefaultCellStyle.WrapMode = DataGridViewTriState.True

        grdatos.AutoResizeColumns()
        grdatos.Columns(4).Width = 200
        grdatos.AutoResizeRows()
        'grdetalle.Columns(2).Width = 70
        grdatos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdatos.Columns(6).DefaultCellStyle.Format = "C2"
        grdatos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdatos.Columns(7).DefaultCellStyle.Format = "C2"
        grdatos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        grdatos.Columns(0).Visible = False
        grdatos.Columns(1).Visible = False
        grdatos.Columns(2).Visible = False
        'grdatos.Columns(3).Visible = False
        grdatos.Columns(8).Visible = False
        grdatos.Columns(9).Visible = False




    End Sub
    Public Sub buscarcliente()
        conn = New c_mysqlconn
        tabla = New DataTable
        tabla = conn.consulta("select * from cliente where id_clie='" & id_clie & "'")
        If tabla.Rows.Count > 0 Then
            tnombre.Text = tabla.Rows(0).Item("nom_clie")
            tid_clie.Text = id_clie
        Else
            tnombre.Text = ""
        End If

    End Sub
    Public Sub combo()
        Dim sql As String

        sql = "SELECT id_col,nom_col FROM colaborador where estado_col='1' ORDER BY id_col "
        tabla = New DataTable
        conn = New c_mysqlconn

        ccol.Items.Clear()

        tabla = conn.consulta(sql)
        For Each row As DataRow In tabla.Rows
            ccol.Items.Add(row("id_col") & " " & row("nom_col"))
        Next


    End Sub
    Private Sub frmcobranza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "VENTAS")
        ExtendedMethods.DoubleBuffered(grdatos, True)
        tfecha.Text = Format(Now, "yyyy-MM-dd")
        grdatos.ColumnCount = 10
        formatogrid()
        ttotal.Text = "0"
        tletras.Text = EnLetras(ttotal.Text)
        combo()
        folio_vis = 0
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()
    End Sub
    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        deshabilitar()
        bnuevo.Visible = True
        bguardar.Visible = False
        bpagar.Visible = False
        bcancelar.Visible = False
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        frmelegirconcepto.Show()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmcntacliente.Show()
        frmcntacliente.BringToFront()
        frmcntacliente.flag = 4
    End Sub
    Private Sub limpiar()
        tfolio.Text = ""
        tfecha.Text = Format(Now, "yyyy-MM-dd")
        tid_clie.Text = ""
        tnombre.Text = ""
        ttotal.Text = "0.00"
        tsubtotal.Text = "0.00"
        tdescuento.Text = "0.00"
        tconcepto.Text = ""
        tletras.Text = ""

        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.ColumnCount = 10
        formatogrid()


    End Sub
    Public Sub bnuevo_Click(sender As Object, e As EventArgs) Handles bnuevo.Click

        habilitar()
        limpiar()
        flag = 1
        bguardar.Visible = True
        bnuevo.Visible = False
        bpagar.Visible = False
        bcancelar.Visible = True
    End Sub

    Private Sub habilitar()
        Panel1.Enabled = True
    End Sub
    Private Sub deshabilitar()
        Panel1.Enabled = False

    End Sub


    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Len(tid_clie.Text) = 0 Or Len(ccol.Text) = 0 Or grdatos.RowCount = 0 Then
            MsgBox("NO ES POSIBLE REGITRAR LA VENTA, ES NECESARIA MAS INFORMACIÓN", vbInformation + vbOKOnly, "COBRANZA")
            Exit Sub
        End If


        Dim cuenta As New c_cxc
        cuenta.Id_clie = tid_clie.Text
        cuenta.Fecha_cxc = CDate(tfecha.Text)
        cuenta.Total_cxc = CDbl(ttotal.Text)
        cuenta.Saldo_cxc = CDbl(ttotal.Text)
        cuenta.Id_col = sacarclave(ccol.Text)
        cuenta.Nom_col = contenido(ccol.Text)
        cuenta.Concepto_cxc = tconcepto.Text
        cuenta.Subtotal_cxc = CDbl(tsubtotal.Text)
        cuenta.Descuento_cxc = CDbl(tdescuento.Text)
        saldo = cuenta.Saldo_cxc
        conn = New c_mysqlconn


        If flag = 1 Then
            conn.insertarnuevo(cuenta)


            conn = New c_mysqlconn
            folio_cxc = conn.Obtener_ID("select max(folio_cxc) as max_id from cxc")
            tfolio.Text = folio_cxc
            MsgBox("INFORMACION REGISTRADA EXITOSAMENTE", vbInformation + vbOKOnly, "COBRANZA")

            For Each row As DataGridViewRow In grdatos.Rows

                Dim registro As New c_det_cxc
                registro.Folio_cxc = folio_cxc
                registro.Id_item = row.Cells(1).Value
                registro.Id_pqt = row.Cells(2).Value
                registro.Clave = row.Cells(3).Value
                registro.Concepto = row.Cells(4).Value
                registro.Cantidad = row.Cells(5).Value
                registro.Precio = row.Cells(6).Value
                registro.Subtotal = row.Cells(7).Value
                registro.Tipo_item = row.Cells(9).Value

                conn = New c_mysqlconn

                If conn.insertardet(registro) = True Then

                    If row.Cells(9).Value = "PRODUCTO" Then
                        Dim movimiento As New c_movimiento
                        Dim final As Double
                        Dim inicial As Double
                        Dim cantgral As Double
                        conn = New c_mysqlconn
                        cantgral = conn.Obtener_Inicial("select cant_prod from producto where id_prod='" & row.Cells(1).Value & "'")
                        conn = New c_mysqlconn
                        inicial = conn.Obtener_Inicial("select cant_prod from inventario where id_prod='" & row.Cells(1).Value & "' and id_almacen='" & My.Settings.varalmacen & "'")

                        final = inicial - row.Cells(5).Value
                        cantgral = cantgral - row.Cells(5).Value

                        movimiento.Id_producto = row.Cells(1).Value
                        movimiento.Unidad_mov = row.Cells(5).Value
                        movimiento.Ini_mov = inicial
                        movimiento.Fin_mov = final
                        movimiento.Cant_mov = row.Cells(5).Value
                        movimiento.Fecha_mov = Format(Now.Date, "yyyy-MM-dd")
                        movimiento.Tipo_mov = 4
                        movimiento.Obs_mov = "VENTA FOLIO " & tfolio.Text
                        movimiento.Id_almacen = My.Settings.varalmacen


                        'FUNCION PARA HABILITAR INVENTARIO
                        conn = New c_mysqlconn
                        conn.insertarmov(movimiento)
                        conn = New c_mysqlconn
                        conn.actualizarproducto(row.Cells(1).Value, cantgral)
                        conn = New c_mysqlconn
                        conn.actualizarinv(row.Cells(1).Value, My.Settings.varalmacen, final)
                    Else
                        Dim paquete As New c_paquete_cont
                        Dim sesiones As Integer
                        conn = New c_mysqlconn



                        paquete.Id_clie = tid_clie.Text
                        paquete.Id_serv = row.Cells(1).Value
                        paquete.Id_pqt = row.Cells(2).Value
                        sesiones = conn.Obtener_dato("select sesiones_pqt as dato from paquete where id_serv='" & paquete.Id_serv & "' and id_pqt='" & paquete.Id_pqt & "'")

                        paquete.Numero_s = sesiones

                        paquete.Restante_s = sesiones
                        paquete.Fecha_ini = Now.Date
                        paquete.Fecha_max = DateAdd(DateInterval.Month, 6, Now.Date)
                        paquete.Id_col = sacarclave(ccol.Text)
                        paquete.Nom_col = contenido(ccol.Text)
                        'paquete.Precio = row.Cells(6).Value
                        'paquete.Saldo = row.Cells(6).Value
                        'paquete.Pagado = 0
                        paquete.Estado_serv = "VIGENTE"



                        conn = New c_mysqlconn

                        conn.nuevocontrato(paquete)
                        conn = New c_mysqlconn
                        folpaquete = conn.Obtener_ID("SELECT max(id_cont) as max_id FROM paquete_cont")

                        conn = New c_mysqlconn
                        conn.paqueteventa(tfolio.Text, folpaquete)


                    End If
                    If folio_vis <> 0 Then

                        conn = New c_mysqlconn
                        conn.darsalida(folio_vis, folpaquete)

                        conn = New c_mysqlconn
                        conn.visitacontrato(folpaquete)


                        frmsalida.consulta()
                    End If
                End If
                bpagar.Visible = True
                pagar()
                deshabilitar()
                bnuevo.Visible = True
                bguardar.Visible = False
                bcancelar.Visible = False
            Next
        End If

    End Sub

    Private Sub pagar()
        frmpago.Show()
        frmpago.folio_cxc = tfolio.Text
        frmpago.total = CDbl(ttotal.Text)
        frmpago.tsaldo.Text = CDbl(saldo)
        frmpago.tfecha.Value = tfecha.Value
        frmpago.saldo = CDbl(saldo)
        frmpago.flagorg = 1
    End Sub

    Private Sub bpagar_Click(sender As Object, e As EventArgs) Handles bpagar.Click
        pagar()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If grdatos.Rows.Count > 0 Then
            grdatos.Rows.Remove(grdatos.CurrentRow())
        End If
        sumartotal()
    End Sub

    Private Sub calcularinverso()
        If Len(ttotal.Text) > 0 Then
            If chdescuento.Checked Then
                If Len(ttotal.Text) > 0 Then
                    If CDbl(ttotal.Text) > 0 Then
                        tdescuento.Text = Math.Round(100 - ((CDbl(ttotal.Text) / CDbl(tsubtotal.Text)) * 100), 2)
                    Else
                        ttotal.Text = tsubtotal.Text
                    End If

                Else
                    ttotal.Text = tsubtotal.Text
                End If
            Else
                If Len(ttotal.Text) > 0 Then
                    If CDbl(ttotal.Text) > 0 Then
                        tdescuento.Text = CDbl(tsubtotal.Text) - CDbl(ttotal.Text)
                    Else
                        ttotal.Text = tsubtotal.Text
                    End If

                Else
                    ttotal.Text = tsubtotal.Text
                End If
            End If

        End If
        ttotal.Text = FormatCurrency(ttotal.Text, 2)
        tletras.Text = EnLetras(ttotal.Text)

    End Sub
    Private Sub calcular()
        If Len(tsubtotal.Text) > 0 Then
            If chdescuento.Checked Then
                If Len(tdescuento.Text) > 0 Then
                    If CDbl(tdescuento.Text) > 0 And CDbl(tdescuento.Text) < 100 Then
                        ttotal.Text = Math.Round(CDbl(tsubtotal.Text) * (1 - (CDbl(tdescuento.Text) / 100)), 2)
                    Else
                        ttotal.Text = tsubtotal.Text
                    End If

                Else
                    ttotal.Text = tsubtotal.Text
                End If
            Else
                If Len(tdescuento.Text) > 0 Then
                    If CDbl(tdescuento.Text) > 0 Then
                        ttotal.Text = CDbl(tsubtotal.Text) - CDbl(tdescuento.Text)
                    Else
                        ttotal.Text = tsubtotal.Text
                    End If

                Else
                    ttotal.Text = tsubtotal.Text
                End If
            End If

        End If
        ttotal.Text = FormatCurrency(ttotal.Text, 2)
        tletras.Text = EnLetras(ttotal.Text)

    End Sub

    Private Sub tdescuento_LostFocus(sender As Object, e As EventArgs) Handles tdescuento.LostFocus

        calcular()
    End Sub
    Private Sub ttotal_LostFocus(sender As Object, e As EventArgs) Handles ttotal.LostFocus
        calcularinverso()
    End Sub

    Private Sub chdescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chdescuento.CheckedChanged
        calcular()
    End Sub

    Private Sub tdescuento_TextChanged(sender As Object, e As EventArgs) Handles tdescuento.TextChanged

    End Sub
End Class