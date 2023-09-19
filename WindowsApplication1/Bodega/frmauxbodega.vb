Imports MySql.Data.MySqlClient
Public Class frmauxbodega
    Dim conn As New c_mysqlconn
    Dim tabla As New DataTable
    Dim producto As New c_transfer_detalle
    Public almacen As Int64
    Public Sub bproducto(ByVal datos As c_transfer_detalle, ByVal existencia As Double)
        producto = New c_transfer_detalle
        producto = datos
        tclave.Text = producto.Clave_prod
        tconcepto.Text = producto.Concepto
        tcantidad.Text = 1
        tpreciol.Text = producto.Costo
        texistencia.Text = existencia


    End Sub
    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub tcantidad_LostFocus(sender As Object, e As EventArgs) Handles tcantidad.LostFocus
        If Len(tpreciol.Text) > 0 And Len(tcantidad.Text) > 0 Then
            If CDbl(tpreciol.Text) > 0 And CDbl(tcantidad.Text) > 0 Then
                If CDbl(tcantidad.Text) > CDbl(texistencia.Text) Then
                    MsgBox("NO ES POSIBLE TRANSFERIR UNA CANTIDAD MAYOR A LAS EXISTENCIAS" & Chr(13) & "FAVOR DE REVISAR SUS DATOS", vbCritical + vbOKOnly, "EXISTENCIAS INSUFICIENTES")
                Else
                    ttotal.Text = CDbl(tpreciol.Text) * CDbl(tcantidad.Text)


                End If
            End If
        End If
        'calcular()
    End Sub
    Private Sub ttotal_LostFocus(sender As Object, e As EventArgs) Handles ttotal.LostFocus
        calcularinverso()
    End Sub


    Private Sub calcular()

        If Len(tpreciol.Text) > 0 And Len(tcantidad.Text) > 0 Then
            If CDbl(tpreciol.Text) > 0 And CDbl(tcantidad.Text) > 0 Then
                ttotal.Text = CDbl(tpreciol.Text) * CDbl(tcantidad.Text)

            End If
        End If
    End Sub

    Private Sub calcularinverso()
        If Len(ttotal.Text) > 0 Then

            If Len(ttotal.Text) > 0 Then
                If CDbl(ttotal.Text) > 0 Then

                    tpreciol.Text = Math.Round(CDbl(ttotal.Text) / CDbl(tcantidad.Text), 2)
                Else
                    tpreciol.Text = tpreciol.Text
                End If

            Else
                tpreciol.Text = tpreciol.Text
            End If


        End If

    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        Dim existencias As Double
        Dim cantprod As Double
        Dim existenciadbd As Double

        existencias = CDbl(texistencia.Text)
        cantprod = CDbl(tcantidad.Text)

        conn = New c_mysqlconn
        existenciadbd = conn.Obtener_dato("select cant_prod as dato from inventario where id_prod='" & producto.Id_prod & "' and id_almacen='" & almacen & "'")
        If (existencias <> existenciadbd) Then
            MsgBox("LA EXISTENCIAS DE ESTE PRODUCTO HAN CAMBIADO DESDE QUE INICIO LA TRANSFERENCIA" & Chr(13) & "FAVOR DE REVISAR SUS DATOS", vbExclamation + vbOKOnly, "EXISTENCIAS HAN CAMBIADO")
            texistencia.Text = existenciadbd
            texistencia.BackColor = Color.Yellow
            calcular()
        Else
            frmmovalmacenp.agregarp(producto, tcantidad.Text, tpreciol.Text)
            Dispose()
        End If


    End Sub
    Private Sub frmauxbodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "DETALLE DE CONCEPTO")
    End Sub

    Private Sub tcantidad_TextChanged(sender As Object, e As EventArgs) Handles tcantidad.TextChanged

    End Sub

    Private Sub tpreciol_TextChanged(sender As Object, e As EventArgs) Handles tpreciol.TextChanged

    End Sub

    Private Sub tpreciol_LostFocus(sender As Object, e As EventArgs) Handles tpreciol.LostFocus
        If Len(tpreciol.Text) > 0 And Len(tcantidad.Text) > 0 Then
            If CDbl(tpreciol.Text) > 0 And CDbl(tcantidad.Text) > 0 Then
                ttotal.Text = CDbl(tpreciol.Text) * CDbl(tcantidad.Text)

            End If
        End If
    End Sub

    Private Sub ttotal_TextChanged(sender As Object, e As EventArgs) Handles ttotal.TextChanged

    End Sub
End Class