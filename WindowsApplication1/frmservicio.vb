Imports MySql.Data.MySqlClient
Public Class frmservicio
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_servicio
    Dim tabla As New DataTable
    Dim id_tipo As Integer
    Public flag As Integer

    Private Sub buscartipo()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from tipo_servicio where id_tipo='" & id_tipo & "'")
        If tabla.Rows.Count > 0 Then
            ctipo.Text = Convert.ToString(tabla.Rows(0).Item("id_tipo")) & " " & Convert.ToString(tabla.Rows(0).Item("nom_tipo"))
        End If
    End Sub
    Public Sub mostrar(ByVal registro As c_servicio)
        datos = registro
        tid.Text = registro.Id_serv
        tnombre.Text = registro.Nom_serv
        tdesc.Text = registro.Desc_serv
        tdur.Text = registro.Duracion


        id_tipo = registro.Id_tipo

        buscartipo()
    End Sub

    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""
        tdesc.Text = ""

        tdur.Text = ""
        id_tipo = Nothing


    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 Then
            datos.Nom_serv = tnombre.Text
            datos.Desc_serv = tdesc.Text
            datos.Duracion = tdur.Text

            datos.Id_tipo = sacarclave(ctipo.Text)


            'revisar
            If flag = 1 Then

                conn = New c_mysqlconn
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntaservicios.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_serv.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntaservicios.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("¡Verifique Sus Datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub combo()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from tipo_servicio order by id_tipo")
        ctipo.Items.Clear()
        For Each row As DataRow In tabla.Rows
            ctipo.Items.Add(row("id_tipo") & " " & row("nom_tipo"))
        Next row
    End Sub
    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs) Handles tnombre.LostFocus, tdesc.LostFocus
        mayus(sender)
    End Sub
    Private Sub frmservicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        combo()
    End Sub
End Class