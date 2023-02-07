Imports MySql.Data.MySqlClient
Public Class frmauxbodega
    Dim conn As New c_mysqlconn
    Dim tabla As New DataTable
    Dim producto As New c_transfer_detalle
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
                ttotal.Text = CDbl(tpreciol.Text) * CDbl(tcantidad.Text)

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


        frmmovalmacenp.agregarp(producto, tcantidad.Text, tpreciol.Text)


        Dispose()
    End Sub
    Private Sub frmauxbodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "DETALLE DE CONCEPTO")
    End Sub


End Class