Imports MySql.Data.MySqlClient

Public Class frmpaquete
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_paquete
    Dim tabla As New DataTable
    Public id_serv As Integer
    Public flag As Integer

    Public Sub buscarservicio()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from servicio where id_serv='" & id_serv & "'")
        If tabla.Rows.Count > 0 Then
            tnombre.Text = Convert.ToString(tabla.Rows(0).Item("nom_serv"))
            tid.Text = id_serv
        End If
    End Sub
    Public Sub mostrar(ByVal registro As c_paquete)
        datos = registro
        tid.Text = registro.Id_serv
        id_serv = registro.Id_serv
        tclave.Text = registro.Clave_pqt
        tdesc.Text = registro.Desc_pqt
        tcantidad.Text = registro.Sesiones_pqt
        tprecio.Text = registro.Precio_pqt

        buscarservicio()
    End Sub

    Private Sub limpiar()
        tid.Text = ""
        id_serv = Nothing
        tclave.Text = ""
        tdesc.Text = ""
        tcantidad.Text = ""
        tprecio.Text = ""



    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 And Strings.Len(tclave.Text) > 0 And Strings.Len(tcantidad.Text) > 0 And Strings.Len(tprecio.Text) > 0 Then
            datos.Id_serv = tid.Text
            datos.Clave_pqt = tclave.Text
            datos.Desc_pqt = tdesc.Text
            datos.Sesiones_pqt = tcantidad.Text
            datos.Precio_pqt = tprecio.Text





            'revisar
            If flag = 1 Then

                conn = New c_mysqlconn
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntapaquetes.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_pqt.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntapaquetes.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("¡Verifique Sus Datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs) Handles tnombre.LostFocus, tdesc.LostFocus
        mayus(sender)
    End Sub
    Private Sub frmpaquete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CATALOGO DE PAQT-PRECIOS")
        limpiar()
    End Sub

    Private Sub tprecio_TextChanged(sender As Object, e As EventArgs) Handles tprecio.TextChanged

    End Sub

    Private Sub tcantidad_TextChanged(sender As Object, e As EventArgs) Handles tcantidad.TextChanged

    End Sub

    Private Sub tcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcantidad.KeyPress
        solonumeros(sender, e)
    End Sub

    Private Sub tprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tprecio.KeyPress
        solonumeros(sender, e)
    End Sub
End Class