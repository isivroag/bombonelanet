
Public Class frmauxcobranza
    Dim paquete As c_paquete
    Dim producto As c_producto
    Dim tipo As Integer
    Dim existencias As Double
    Public Sub bproducto(ByVal datos As c_producto)
        producto = New c_producto
        producto = datos
        tclave.Text = producto.Clave_prod
        tconcepto.Text = producto.Nom_prod
        tcantidad.Text = 1
        tpreciol.Text = producto.Precio_prod
        existencias = producto.Cant_prod
        tsesiones.Text = 0
        tsesiones.Visible = False
        lsesiones.Visible = False
        calcular()
        tipo = 2
    End Sub

    Public Sub datos(ByVal datos As c_paquete)
        paquete = New c_paquete
        paquete = datos
        tclave.Text = paquete.Clave_pqt
        tconcepto.Text = paquete.Desc_pqt
        tcantidad.Text = 1
        tpreciol.Text = paquete.Precio_pqt
        tsesiones.Text = paquete.Sesiones_pqt
        calcular()
        tipo = 1
    End Sub

    Private Sub calcular()
        If Len(tpreciol.Text) > 0 Then
            If chdescuento.Checked Then
                If Len(tdesc.Text) > 0 Then
                    If CDbl(tdesc.Text) > 0 Then
                        tprecio.Text = Math.Round(CDbl(tpreciol.Text) * (1 - (CDbl(tdesc.Text) / 100)), 2)
                    Else
                        tprecio.Text = tpreciol.Text
                    End If

                Else
                        tprecio.Text = tpreciol.Text
                End If
            Else
                If Len(tdesc.Text) > 0 Then
                    If CDbl(tdesc.Text) > 0 Then
                        tprecio.Text = CDbl(tpreciol.Text) - CDbl(tdesc.Text)
                    Else
                        tprecio.Text = tpreciol.Text
                    End If

                Else
                    tprecio.Text = tpreciol.Text
                End If
            End If

        End If
        If Len(tprecio.Text) > 0 And Len(tcantidad.Text) > 0 Then
            If CDbl(tprecio.Text) > 0 And CDbl(tcantidad.Text) > 0 Then
                ttotal.Text = CDbl(tprecio.Text) * CDbl(tcantidad.Text)

            End If
        End If
    End Sub

    Private Sub calcularinverso()
        If Len(ttotal.Text) > 0 Then
            If chdescuento.Checked Then
                If Len(ttotal.Text) > 0 Then
                    If CDbl(ttotal.Text) > 0 Then
                        tdesc.Text = Math.Round(100 - (((CDbl(ttotal.Text) / CDbl(tcantidad.Text)) / CDbl(tpreciol.Text)) * 100), 2)
                        tprecio.Text = Math.Round(CDbl(ttotal.Text) / CDbl(tcantidad.Text), 2)
                    Else
                        tprecio.Text = tpreciol.Text
                    End If

                Else
                    tprecio.Text = tpreciol.Text
                End If
            Else
                If Len(ttotal.Text) > 0 Then
                    If CDbl(ttotal.Text) > 0 Then
                        tdesc.Text = Math.Round(CDbl(tpreciol.Text) - (CDbl(ttotal.Text) / CDbl(tcantidad.Text)), 2)
                        tprecio.Text = Math.Round(CDbl(ttotal.Text) / CDbl(tcantidad.Text), 2)
                    Else
                        tprecio.Text = tpreciol.Text
                    End If

                Else
                    tprecio.Text = tpreciol.Text
                End If
            End If

        End If
        '   If Len(tprecio.Text) > 0 And Len(tcantidad.Text) > 0 Then
        '      If CDbl(tprecio.Text) > 0 And CDbl(tcantidad.Text) > 0 Then
        '          ttotal.Text = CDbl(tprecio.Text) * CDbl(tcantidad.Text)

        '        End If
        '       End If
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        Select Case tipo
            Case 1
                frmcobranza.agregar(paquete, tcantidad.Text, tprecio.Text)
            Case 2
                If (existencias >= tcantidad.Text) Then
                    frmcobranza.agregarp(producto, tcantidad.Text, tprecio.Text)
                Else
                    MsgBox("NO ES POSIBLE VENDER MAS PRODUCTO DEL QUE SE ENCUENTRA EN INVENTARIO" & Chr(13) & "VERIFIQUE SU INFORMACIÓN", vbExclamation + vbOKOnly, "OPERACION NO PERMITIDA")
                    Exit Sub
                End If




        End Select

        Dispose()
    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub frmauxcobranza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "DETALLE DE CONCEPTO")

    End Sub

    Private Sub tdesc_LostFocus(sender As Object, e As EventArgs) Handles tdesc.LostFocus
        calcular()
    End Sub

    Private Sub chdescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chdescuento.CheckedChanged
        calcular()
    End Sub

    Private Sub tcantidad_LostFocus(sender As Object, e As EventArgs) Handles tcantidad.LostFocus
        If Len(tprecio.Text) > 0 And Len(tcantidad.Text) > 0 Then
            If CDbl(tprecio.Text) > 0 And CDbl(tcantidad.Text) > 0 Then
                ttotal.Text = CDbl(tprecio.Text) * CDbl(tcantidad.Text)

            End If
        End If
        'calcular()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ttotal_TextChanged(sender As Object, e As EventArgs) Handles ttotal.TextChanged

    End Sub

    Private Sub ttotal_LostFocus(sender As Object, e As EventArgs) Handles ttotal.LostFocus
        calcularinverso()
    End Sub

    Private Sub chcortesia_CheckedChanged(sender As Object, e As EventArgs) Handles chcortesia.CheckedChanged
        If chcortesia.Checked Then
            tdesc.Text = tprecio.Text
            tprecio.Text = 0
            ttotal.Text = 0
            tdesc.Enabled = False
            ttotal.Enabled = False
        Else
            tprecio.Text = tpreciol.Text
            tdesc.Text = 0
            tdesc.Enabled = True
            ttotal.Enabled = True
            calcular()
        End If


    End Sub


End Class