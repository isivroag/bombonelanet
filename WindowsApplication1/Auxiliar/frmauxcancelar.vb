Imports MySql.Data.MySqlClient

Public Class frmauxcancelar
    Public folio As Integer
    Public tipo As Integer
    Dim conn As c_mysqlconn
    Dim fecha As DateTime
    Public sql As String
    Dim tabla As DataTable

    Private Sub frmauxcancelar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CANCELAR")


    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If (Len(tmotivo.Text) > 0) Then
            If MsgBox("DESEA ELIMINAR ESTE REGISTRO", vbYesNo + vbQuestion, "ELIMINAR") = vbYes Then


                conn = New c_mysqlconn
                If conn.cancelar(folio, tipo, globalusuario, tmotivo.Text) = True Then

                    MsgBox("REGISTRO ELIMINADO", vbInformation + vbOKOnly, "ELIMINAR")
                    Select Case tipo
                        Case 1
                            frmcntagasto.consulta()
                        Case 2
                            frmcntaretiros.consulta()
                        Case 3
                            conn = New c_mysqlconn
                            tabla = New DataTable
                            'buscar detalle de venta para regresar los productos a inventario
                            tabla = conn.consulta("Select * from transfer_detalle where folio_transfer='" & folio & "'")


                            For Each row As DataRow In tabla.Rows
                                Dim idprod As String
                                Dim cantidad As Double
                                Dim unidad As String
                                idprod = row("id_prod")
                                cantidad = row("cantidad")
                                unidad = row("unidad")

                                Dim movimiento As New c_movimiento
                                Dim final As Double
                                Dim inicial As Double
                                Dim cantgral As Double
                                conn = New c_mysqlconn
                                cantgral = conn.Obtener_Inicial("select cant_prod from producto where id_prod='" & idprod & "'")
                                conn = New c_mysqlconn
                                inicial = conn.Obtener_Inicial("select cant_prod from inventario where id_prod='" & idprod & "' and id_almacen='2'")

                                final = inicial + cantidad
                                cantgral = cantgral + cantidad

                                movimiento.Id_producto = idprod
                                movimiento.Unidad_mov = unidad
                                movimiento.Ini_mov = inicial
                                movimiento.Fin_mov = final
                                movimiento.Cant_mov = cantidad
                                movimiento.Fecha_mov = Format(Now.Date, "yyyy-MM-dd")
                                movimiento.Tipo_mov = 2
                                movimiento.Obs_mov = "CANCELACION TRANSFERENCIA: " & folio
                                movimiento.Id_almacen = 2

                                'FUNCION PARA HABILITAR INVENTARIO
                                conn = New c_mysqlconn
                                conn.insertarmov(movimiento)
                                conn = New c_mysqlconn
                                conn.actualizarproducto(idprod, cantgral)
                                conn = New c_mysqlconn
                                conn.actualizarinv(idprod, 2, final)


                            Next
                            frmcntamovbodega.consulta()
                    End Select
                    Dispose()

                End If

            End If
        End If
    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()

    End Sub
End Class