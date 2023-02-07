Imports MySql.Data.MySqlClient
Public Class frmmovalmacenp
    Dim conn As c_mysqlconn
    Dim tabla As New DataTable
    Dim table As New DataTable
    Dim dato As New c_transfer
    Dim registro As New c_transfer_detalle
    Public folio As Int64
    Public id_prod As Int64
    Public claveprod As String
    Public prod As String
    Public costo As Double
    Public subtotal As Double
    Public flag As Integer
    Public idorg As Integer
    Public origen As String


    Private Sub verificar()
        conn = New c_mysqlconn
        idorg = 0
        idorg = conn.Obtener_dato("select id_almacen as dato from almacen where inv_almacen=1")
        If idorg = 0 Then
            MsgBox("NO EXISTE UN ALMACEN PRINCIPAL", vbCritical + vbOKOnly, "OPERACION NO PERMITIDA")
            Dispose()


        End If
    End Sub
    Private Sub combo()


        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from almacen where estado_almacen=1 and inv_almacen=1 order by id_almacen")
        calmaceno.Items.Clear()
        For Each row As DataRow In tabla.Rows
            calmaceno.Items.Add(row("id_almacen") & " " & row("nom_almacen"))
            idorg = row("id_almacen")
            origen = row("nom_almacen")
        Next row
        calmaceno.Text = idorg & " " & origen

        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from almacen where estado_almacen=1 and inv_almacen<>1 order by id_almacen")

        calmacend.Items.Clear()
        For Each row As DataRow In tabla.Rows
            calmacend.Items.Add(row("id_almacen") & " " & row("nom_almacen"))

        Next row
    End Sub
    Private Sub formatogrid()

        grdatos.Columns(0).HeaderText = "REG"
        grdatos.Columns(1).HeaderText = "FOLIO TRANSFER"

        grdatos.Columns(2).HeaderText = "ID_PROD"
        grdatos.Columns(3).HeaderText = "CLAVE"
        grdatos.Columns(4).HeaderText = "CONCEPTO"
        grdatos.Columns(5).HeaderText = "CANTIDAD"
        grdatos.Columns(6).HeaderText = "UNIDAD"
        grdatos.Columns(7).HeaderText = "COSTO"
        grdatos.Columns(8).HeaderText = "SUBTOTAL"

        grdatos.Columns(4).DefaultCellStyle.WrapMode = DataGridViewTriState.True

        grdatos.AutoResizeColumns()
        grdatos.Columns(4).Width = 200
        grdatos.AutoResizeRows()
        'grdetalle.Columns(2).Width = 70
        grdatos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdatos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdatos.Columns(7).DefaultCellStyle.Format = "C2"

        grdatos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdatos.Columns(8).DefaultCellStyle.Format = "C2"

        grdatos.Columns(0).Visible = False
        grdatos.Columns(1).Visible = False
        grdatos.Columns(2).Visible = False




    End Sub
    Private Sub frmmovalmacenp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "MOVIMIENTOS ALMACEN PRINCIPAL")
        ExtendedMethods.DoubleBuffered(grdatos, True)
        tfecha.Text = Format(Now, "yyyy-MM-dd")
        grdatos.ColumnCount = 9
        formatogrid()
        ttotal.Text = "0"
        verificar()
        combo()

    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()

    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click

        frmcntaprodbodega.Show()
        frmcntaprodbodega.almacen = idorg
        frmcntaprodbodega.consulta()
        frmcntaprodbodega.BringToFront()

    End Sub
    Public Sub agregarp(ByVal detalle As c_transfer_detalle, ByVal cantidad As Double, ByVal precio As Double)



        Dim valor As String = Convert.ToDouble(detalle.Id_prod)

        For Each row As DataGridViewRow In grdatos.Rows

            If valor = Convert.ToDouble(row.Cells(2).Value) Then
                MsgBox("EL PRODUCTO YA SE ENCUENTRA EN LA LISTA", vbInformation + vbOKOnly, "PRODUCTO DUPLICADO")
                Exit Sub
            End If

        Next


        grdatos.VirtualMode = False

        grdatos.Rows.Add(0, 0, detalle.Id_prod, detalle.Clave_prod, detalle.Concepto, cantidad, detalle.Unidad, precio.ToString, precio * cantidad)


        formatogrid()
        sumartotal()
    End Sub

    Private Sub sumartotal()
        Dim suma As Double = 0
        For Each row As DataGridViewRow In grdatos.Rows

            suma += Convert.ToDouble(row.Cells(8).Value)

        Next
        ttotal.Text = suma


        ttotal.Text = FormatCurrency(ttotal.Text, 2)


    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Len(calmaceno.Text) = 0 Or Len(calmacend.Text) = 0 Or grdatos.RowCount = 0 Then
            MsgBox("NO ES POSIBLE REGITRAR LA OPERACION, ES NECESARIA MAS INFORMACIÓN", vbInformation + vbOKOnly, "ADVERTENCIA")
            Exit Sub
        End If


        Dim cuenta As New c_transfer

        cuenta.Fecha_trans = CDate(tfecha.Text)
        cuenta.Importe = CDbl(ttotal.Text)
        cuenta.Origen = sacarclave(calmaceno.Text)
        cuenta.Destino = sacarclave(calmacend.Text)
        cuenta.Obs_trans = tconcepto.Text

        conn = New c_mysqlconn


        If flag = 1 Then
            conn.insertarnuevo(cuenta)


            conn = New c_mysqlconn
            folio = conn.Obtener_ID("select max(folio_trans) as max_id from transfer")
            tfolio.Text = folio
            MsgBox("INFORMACION REGISTRADA EXITOSAMENTE", vbInformation + vbOKOnly, "MOV BODEGA")

            For Each row As DataGridViewRow In grdatos.Rows

                Dim registro As New c_transfer_detalle
                registro.Folio_transfer = folio
                registro.Id_prod = row.Cells(2).Value
                registro.Clave_prod = row.Cells(3).Value
                registro.Concepto = row.Cells(4).Value
                registro.Cantidad = row.Cells(5).Value
                registro.Unidad = row.Cells(6).Value
                registro.Costo = row.Cells(7).Value
                registro.Importe = row.Cells(8).Value


                conn = New c_mysqlconn

                If conn.insertardetbodega(registro) = True Then


                    Dim movimiento As New c_movimiento
                    Dim finalo As Double
                    Dim inicialo As Double
                    Dim cantgral As Double
                    conn = New c_mysqlconn
                    cantgral = conn.Obtener_Inicial("select cant_prod from producto where id_prod='" & row.Cells(2).Value & "'")
                    cantgral = cantgral - row.Cells(5).Value

                    'SALIDA SUC ORIGEN
                    conn = New c_mysqlconn
                    inicialo = conn.Obtener_Inicial("select cant_prod from inventario where id_prod='" & row.Cells(2).Value & "' and id_almacen='" & sacarclave(calmaceno.Text) & "'")
                    finalo = inicialo - row.Cells(5).Value
                    movimiento.Id_producto = row.Cells(2).Value
                    movimiento.Unidad_mov = row.Cells(6).Value
                    movimiento.Ini_mov = inicialo
                    movimiento.Fin_mov = finalo
                    movimiento.Cant_mov = row.Cells(5).Value
                    movimiento.Fecha_mov = Format(Now.Date, "yyyy-MM-dd")
                    movimiento.Tipo_mov = 3
                    movimiento.Obs_mov = "TRANSFERENCIA FOLIO " & tfolio.Text
                    movimiento.Id_almacen = sacarclave(calmaceno.Text)



                    'FUNCION PARA HABILITAR INVENTARIO
                    conn = New c_mysqlconn
                        conn.insertarmov(movimiento)

                    conn = New c_mysqlconn
                    conn.actualizarinv(row.Cells(2).Value, sacarclave(calmaceno.Text), finalo)


                    If (chentrada.Checked) Then



                        conn = New c_mysqlconn
                        tabla.Clear()
                        tabla = conn.consulta("select * from inventario where id_prod='" & row.Cells(2).Value & "' and id_almacen='" & sacarclave(calmacend.Text) & "'")
                        Dim registroe As Integer = 0
                        If tabla.Rows.Count > 0 Then
                            registroe = 1
                        End If


                        Dim finald As Double
                        Dim iniciald As Double
                        movimiento = New c_movimiento
                        'ENTRADA SUC DESTINO
                        conn = New c_mysqlconn
                        iniciald = conn.Obtener_Inicial("select cant_prod from inventario where id_prod='" & row.Cells(2).Value & "' and id_almacen='" & sacarclave(calmacend.Text) & "'")
                        finald = iniciald + row.Cells(5).Value


                        movimiento.Id_producto = row.Cells(2).Value
                        movimiento.Unidad_mov = row.Cells(6).Value
                        movimiento.Ini_mov = iniciald
                        movimiento.Fin_mov = finald
                        movimiento.Cant_mov = row.Cells(5).Value
                        movimiento.Fecha_mov = Format(Now.Date, "yyyy-MM-dd")
                        movimiento.Tipo_mov = 2
                        movimiento.Obs_mov = "TRANSFERENCIA FOLIO " & tfolio.Text
                        movimiento.Id_almacen = sacarclave(calmacend.Text)

                        conn = New c_mysqlconn
                        conn.insertarmov(movimiento)

                        conn = New c_mysqlconn

                        If registroe = 1 Then
                            conn.actualizarinv(row.Cells(2).Value, sacarclave(calmacend.Text), finald)
                        Else
                            conn.primerinv(row.Cells(2).Value, sacarclave(calmacend.Text), finald, movimiento.Unidad_mov)
                        End If


                    Else
                        conn = New c_mysqlconn
                        conn.actualizarproducto(row.Cells(2).Value, cantgral)
                    End If





                End If

            Next
        End If

    End Sub
End Class