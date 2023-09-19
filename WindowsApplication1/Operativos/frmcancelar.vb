Imports MySql.Data.MySqlClient

Public Class frmcancelar
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Public username As String
    Public Sub combo()
        Dim sql As String

        sql = "SELECT id_col,nom_col FROM colaborador where estado_col='1' ORDER BY id_col "
        tabla = New DataTable
        conn = New c_mysqlconn

        ccol.Items.Clear()

        tabla = conn.consulta(sql)
        For Each row As DataRow In tabla.Rows
            ccol.Items.Add(row("nom_col"))
        Next


    End Sub


    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Len(ccol.Text) > 0 And Len(tmotivo.Text) > 0 Then

            If MsgBox("¿Esta seguro de Cancelar el registro?", vbQuestion + vbYesNo, "CANCELACION") = vbYes Then
                Select Case sacarclave(ttipo.Text)
                    Case 1
                        conn = New c_mysqlconn
                        tabla = New DataTable
                        'buscar detalle de venta para regresar los productos a inventario
                        tabla = conn.consulta("Select * from vproductoventa where folio_cxc='" & tfolio.Text & "'")


                        For Each row As DataRow In tabla.Rows
                            Dim idprod As String
                            Dim cantidad As Double
                            Dim unidad As String
                            idprod = row("id_item")
                            cantidad = row("cantidad")
                            unidad = row("unidad_prod")



                            Dim movimiento As New c_movimiento
                            Dim final As Double
                            Dim inicial As Double
                            Dim cantgral As Double
                            conn = New c_mysqlconn
                            cantgral = conn.Obtener_Inicial("select cant_prod from producto where id_prod='" & idprod & "'")
                            conn = New c_mysqlconn
                            inicial = conn.Obtener_Inicial("select cant_prod from inventario where id_prod='" & idprod & "' and id_almacen='" & My.Settings.varalmacen & "'")

                            final = inicial + cantidad
                            cantgral = cantgral + cantidad

                            movimiento.Id_producto = idprod
                            movimiento.Unidad_mov = unidad
                            movimiento.Ini_mov = inicial
                            movimiento.Fin_mov = final
                            movimiento.Cant_mov = cantidad
                            movimiento.Fecha_mov = Format(Now.Date, "yyyy-MM-dd")
                            movimiento.Tipo_mov = 2
                            movimiento.Obs_mov = "CANCELACION VENTA: " & tfolio.Text
                            movimiento.Id_almacen = My.Settings.varalmacen


                            'FUNCION PARA HABILITAR INVENTARIO
                            conn = New c_mysqlconn
                            conn.insertarmov(movimiento)
                            conn = New c_mysqlconn
                            conn.actualizarproducto(idprod, cantgral)
                            conn = New c_mysqlconn
                            conn.actualizarinv(idprod, My.Settings.varalmacen, final)


                        Next


                        'cancelar la venta
                        conn = New c_mysqlconn
                        If conn.cancelar(tfolio.Text, sacarclave(ttipo.Text), tfecha.Value, ccol.Text, username, tmotivo.Text) Then
                            MsgBox("VENTA CANCELADA", vbInformation + vbOKOnly, "CANCELACION")
                            frmcntacuentasclie.consulta()
                            Dispose()
                        End If

                    Case 2
                        conn = New c_mysqlconn
                        Dim foliocxc As String
                        Dim monto As Double
                        'buscar el monto del pago
                        foliocxc = conn.Obtener_dato("select folio_cxc as dato from pago where folio_pago='" & tfolio.Text & "'")
                        'buscar monto del pago
                        conn = New c_mysqlconn
                        monto = conn.Obtener_dato("select importe_pago as dato from pago where folio_pago='" & tfolio.Text & "'")
                        'aumentar el saldo a la venta
                        conn = New c_mysqlconn
                        If conn.aumentarsaldo(foliocxc, monto) Then

                            conn = New c_mysqlconn
                            If conn.cancelar(tfolio.Text, sacarclave(ttipo.Text), tfecha.Value, ccol.Text, username, tmotivo.Text) Then
                                MsgBox("PAGO CANCELADO", vbInformation + vbOKOnly, "CANCELACION")
                                frmverpagos.consulta()
                                frmcntacuentasclie.consulta()
                                Dispose()
                            End If

                        End If
                        'cancelar el pago

                End Select

            End If
        Else
            MsgBox("Es necesario registrar el motivo de cancelación y el solicitante", vbExclamation + vbOKOnly, "CANCELACION")
        End If

    End Sub

    Private Sub frmcancelar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CANCELACION")
        combo()
    End Sub

    Private Sub ltitulo_Click(sender As Object, e As EventArgs) Handles ltitulo.Click

    End Sub
End Class
