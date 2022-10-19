Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmtransferencia
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_producto
    Dim tabla As New DataTable
    Public flag As Integer
    Public existencia As Double
    Dim movimiento As New c_movimiento

    Private Sub buscard()
        conn = New c_mysqlconn
        tabla.Clear()
        existencia = conn.Obtener_dato("select cant_prod as dato from inventario where id_prod='" & datos.Id_prod & "' and id_almacen='" & sacarclave(calmacend.Text) & "'")

        texistenciad.Text = existencia

    End Sub
    Private Sub calmacend_Click(sender As Object, e As EventArgs) Handles calmacend.Click
        buscard()
    End Sub

    Private Sub buscaro()
        conn = New c_mysqlconn
        tabla.Clear()
        existencia = conn.Obtener_dato("select cant_prod as dato from inventario where id_prod='" & datos.Id_prod & "' and id_almacen='" & sacarclave(calmaceno.Text) & "'")

        texistenciao.Text = existencia

    End Sub
    Private Sub calmaceno_Click(sender As Object, e As EventArgs) Handles calmaceno.Click
        buscaro()
    End Sub
    Private Sub combo()


        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from almacen where estado_almacen=1 order by id_almacen")
        calmaceno.Items.Clear()
        calmacend.Items.Clear()
        For Each row As DataRow In tabla.Rows
            calmaceno.Items.Add(row("id_almacen") & " " & row("nom_almacen"))
            calmacend.Items.Add(row("id_almacen") & " " & row("nom_almacen"))
        Next row
    End Sub
    Public Sub mostrar(ByVal insumo As c_producto)
        datos = insumo
        tid.Text = insumo.Id_prod
        tnombre.Text = insumo.Nom_prod

    End Sub
    Private Sub tcant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcant.KeyPress
        solonumeros(sender, e)
    End Sub
    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()

    End Sub

    Private Sub frmtransferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "TRANSFERENCIAS")
        combo()
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Len(tcant.Text) > 0 And Len(calmacend.Text) > 0 And Len(calmaceno.Text) > 0 Then
            If CDbl(tcant.Text) > 0 Then
                If calmaceno.Text <> calmacend.Text Then
                    If CDbl(tcant.Text) <= CDbl(texistenciao.Text) Then

#Region "salida"


                        movimiento.Id_producto = datos.Id_prod
                        movimiento.Id_almacen = sacarclave(calmaceno.Text)
                        movimiento.Fecha_mov = Date.Today.Date.ToString
                        movimiento.Tipo_mov = 3
                        movimiento.Ini_mov = texistenciao.Text
                        movimiento.Unidad_mov = datos.Unidad_prod
                        movimiento.Cant_mov = Convert.ToDouble(tcant.Text)


                        movimiento.Fin_mov = Convert.ToDouble(movimiento.Ini_mov) - Convert.ToDouble(tcant.Text)

                        movimiento.Obs_mov = "TRANSFERENCIA HACIA EL ALMACEN " & contenido(calmacend.Text)


                        conn = New c_mysqlconn
                        tabla.Clear()
                        tabla = conn.consulta("select * from inventario where id_prod='" & datos.Id_prod & "' and id_almacen='" & sacarclave(calmaceno.Text) & "'")
                        Dim registroe As Integer = 0
                        If tabla.Rows.Count > 0 Then
                            registroe = 1
                        End If

                        If conn.insertarmov(movimiento) Then
                            conn = New c_mysqlconn
                            If registroe = 1 Then
                                conn.actualizarinv(movimiento.Id_producto, movimiento.Id_almacen, movimiento.Fin_mov)
                            Else
                                conn.primerinv(movimiento.Id_producto, movimiento.Id_almacen, movimiento.Fin_mov, movimiento.Unidad_mov)
                            End If
#Region "entrada"
                            movimiento.Id_producto = datos.Id_prod
                            movimiento.Id_almacen = sacarclave(calmacend.Text)
                            movimiento.Fecha_mov = Date.Today.Date.ToString
                            movimiento.Tipo_mov = 2
                            movimiento.Ini_mov = texistenciad.Text
                            movimiento.Unidad_mov = datos.Unidad_prod
                            movimiento.Cant_mov = Convert.ToDouble(tcant.Text)

                            movimiento.Fin_mov = Convert.ToDouble(movimiento.Ini_mov) + Convert.ToDouble(tcant.Text)

                            movimiento.Obs_mov = "TRANSFERENCIA DESDE EL ALMACEN " & contenido(calmaceno.Text)


                            conn = New c_mysqlconn
                            tabla.Clear()
                            tabla = conn.consulta("select * from inventario where id_prod='" & datos.Id_prod & "' and id_almacen='" & sacarclave(calmacend.Text) & "'")
                            Dim registrod As Integer = 0
                            If tabla.Rows.Count > 0 Then
                                registrod = 1
                            End If

                            If conn.insertarmov(movimiento) Then
                                conn = New c_mysqlconn
                                If registrod = 1 Then
                                    conn.actualizarinv(movimiento.Id_producto, movimiento.Id_almacen, movimiento.Fin_mov)
                                Else
                                    conn.primerinv(movimiento.Id_producto, movimiento.Id_almacen, movimiento.Fin_mov, movimiento.Unidad_mov)
                                End If

                            End If
                            MessageBox.Show("Datos Guardados")
                            If flag = 1 Then
                                frminventario.consulta()

                            End If


                            Me.Dispose()
#End Region
                        End If
#End Region
                    Else
                        MsgBox("CANTIDAD DE INSUMOS EXCEDE LAS EXISTENCIAS DEL ALMACEN ORIGEN", vbCritical + vbOKOnly, "TRANSFERENCIAS")
                    End If
                Else
                    MsgBox("NO ES POSIBLE TRANSFERIR INSUMOS AL MISMO ALMACEN", vbCritical + vbOKOnly, "TRANSFERENCIAS")
                End If
            Else
                MsgBox("LA CANTIDAD DE INSUMOS A TRASLADAR DEBE SER DIFERENTE DE 0", vbCritical + vbOKOnly, "TRANSFERENCIAS")
            End If
        Else
            MsgBox("INFORMACIÓN INSUFICIENTE, REVISE SUS DATOS", vbCritical + vbOKOnly, "TRANSFERENCIAS")
        End If

    End Sub
    Private Sub calmaceno_TextChanged(sender As Object, e As EventArgs) Handles calmaceno.TextChanged
        buscaro()
    End Sub

    Private Sub calmacend_TextChanged(sender As Object, e As EventArgs) Handles calmacend.TextChanged
        buscard()
    End Sub

    Private Sub tcant_TextChanged(sender As Object, e As EventArgs) Handles tcant.TextChanged

    End Sub
End Class