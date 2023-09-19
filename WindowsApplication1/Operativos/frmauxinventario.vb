Imports MySql.Data.MySqlClient
Public Class frmauxinventario
    Dim conn As New c_mysqlconn
    Dim texto As String
    Public producto As New c_producto
    Public medida As String
    Public movimiento As New c_movimiento
    Dim tabla As New DataTable
    Dim datos As New c_producto
    Public flag As Integer
    Public existencia As Double
    Public cantgral As Double
    Public almacen As Int64
    Private Sub combo()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from tipomov order by id_tipomov")
        ctipo.Items.Clear()
        For Each row As DataRow In tabla.Rows
            ctipo.Items.Add(row("id_tipomov") & " " & row("tipomov"))
        Next row

        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from almacen where estado_almacen=1 order by id_almacen")
        calmacen.Items.Clear()
        For Each row As DataRow In tabla.Rows
            calmacen.Items.Add(row("id_almacen") & " " & row("nom_almacen"))
        Next row
    End Sub

    Public Sub mostrar(ByVal insumo As c_producto)
        datos = insumo
        tid.Text = insumo.Id_prod
        tnombre.Text = insumo.Nom_prod

    End Sub
    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click

        'REVISAR CUANDO EXISTE UN MOVIMIENTO DE INVENTARIO INICIAL POR QUE SE SOBREESCRIBE LA CANTIDAD GENERAL
        movimiento.Id_producto = datos.Id_prod
        movimiento.Fecha_mov = Date.Today.Date.ToString
        movimiento.Tipo_mov = sacarclave(ctipo.Text)
        movimiento.Ini_mov = existencia
        movimiento.Unidad_mov = datos.Unidad_prod
        movimiento.Cant_mov = Convert.ToDouble(tcantidad.Text)
        movimiento.Id_almacen = sacarclave(calmacen.Text)


        Select Case sacarclave(ctipo.Text)
            Case 1
                movimiento.Fin_mov = Convert.ToDouble(tcantidad.Text)
                cantgral = Convert.ToDouble(tcantidad.Text)
            Case 2
                movimiento.Fin_mov = Convert.ToDouble(existencia) + Convert.ToDouble(tcantidad.Text)
                cantgral = cantgral + Convert.ToDouble(tcantidad.Text)
            Case 3
                movimiento.Fin_mov = Convert.ToDouble(existencia) - Convert.ToDouble(tcantidad.Text)
                cantgral = cantgral - Convert.ToDouble(tcantidad.Text)
            Case 4
                movimiento.Fin_mov = Convert.ToDouble(existencia) - Convert.ToDouble(tcantidad.Text)
                cantgral = cantgral - Convert.ToDouble(tcantidad.Text)
            Case 5
                movimiento.Fin_mov = Convert.ToDouble(existencia) + Convert.ToDouble(tcantidad.Text)
                cantgral = cantgral + Convert.ToDouble(tcantidad.Text)
        End Select

        movimiento.Obs_mov = tobs.Text
        producto.Cant_prod = movimiento.Fin_mov

        'conn = New c_mysqlconn
        'If conn.insertarmov(movimiento) Then
        '    conn = New c_mysqlconn
        '    conn.actualizarproducto(producto.Id_prod, producto.Cant_prod)

        '    MessageBox.Show("Datos Guardados")
        '    frminventario.mostrarp(producto)


        '    Me.Dispose()

        'Else
        '    MessageBox.Show("Datos No Guardados")
        'End If



        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from inventario where id_PROD='" & datos.Id_prod & "' and id_almacen='" & sacarclave(calmacen.Text) & "'")
        Dim registroe As Integer = 0
        If tabla.Rows.Count > 0 Then
            registroe = 1
        End If

        If conn.insertarmov(movimiento) Then
            conn = New c_mysqlconn
            If registroe = 1 Then
                conn.actualizarproducto(movimiento.Id_producto, cantgral)
                conn = New c_mysqlconn
                conn.actualizarinv(movimiento.Id_producto, movimiento.Id_almacen, movimiento.Fin_mov)
            Else
                conn.actualizarproducto(movimiento.Id_producto, cantgral)
                conn = New c_mysqlconn
                conn.primerinv(movimiento.Id_producto, movimiento.Id_almacen, movimiento.Fin_mov, movimiento.Unidad_mov)
            End If
            frminventario.consultaprod()
            frminventario.consulta()

            MessageBox.Show("Datos Guardados")
            'If flag = 2 Then
            '    frmkardex.mostrar(datos)
            'Else
            '    frncntainventario.consulta()
            'End If



            Me.Dispose()

        Else
            MessageBox.Show("Datos No Guardados")
        End If

    End Sub

    Private Sub frmauxinventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "MOVIMIENTOS DE INVENTARIO")
        combo()
    End Sub

    Public Sub buscar()
        conn = New c_mysqlconn
        tabla.Clear()
        existencia = conn.Obtener_dato("select cant_prod as dato from inventario where id_prod='" & datos.Id_prod & "' and id_almacen='" & sacarclave(calmacen.Text) & "'")

        texistencia.Text = existencia
        conn = New c_mysqlconn
        cantgral = conn.Obtener_dato("select cant_prod as dato from producto where id_prod='" & datos.Id_prod & "'")

    End Sub


    Private Sub calmacen_MouseUp(sender As Object, e As MouseEventArgs) Handles calmacen.MouseUp
        buscar()
    End Sub

    Private Sub calmacen_TextChanged(sender As Object, e As EventArgs) Handles calmacen.TextChanged
        buscar()
    End Sub

    Private Sub tcantidad_TextChanged(sender As Object, e As EventArgs) Handles tcantidad.TextChanged

    End Sub

    Private Sub tcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcantidad.KeyPress
        solonumeros(sender, e)
    End Sub

    Private Sub ctipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ctipo.SelectedIndexChanged

    End Sub
End Class