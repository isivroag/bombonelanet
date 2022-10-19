Imports MySql.Data.MySqlClient
Public Class frmcolaborador
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_colaborador
    Dim tabla As New DataTable
    Dim id_puesto As Integer
    Public flag As Integer
    Dim alta_col As Date

    Private Sub buscarpuesto()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from puesto where id_puesto='" & id_puesto & "'")
        If tabla.Rows.Count > 0 Then
            cpuesto.Text = Convert.ToString(tabla.Rows(0).Item("id_puesto")) & " " & Convert.ToString(tabla.Rows(0).Item("nom_puesto"))
        End If
    End Sub
    Public Sub mostrar(ByVal registro As c_colaborador)
        datos = registro
        tid.Text = registro.Id_col
        tnombre.Text = registro.Nom_col
        tdir.Text = registro.Dir_col
        ttel.Text = registro.Tel_col
        tcel.Text = registro.Cel_col
        tcorreo.Text = registro.Correo_col
        id_puesto = registro.Id_puesto
        alta_col = registro.Alta_col
        buscarpuesto()
    End Sub

    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""
        tdir.Text = ""
        ttel.Text = ""
        tcel.Text = ""
        tcorreo.Text = ""
        id_puesto = Nothing
        alta_col = Nothing

    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 Then
            datos.Nom_col = tnombre.Text
            datos.Dir_col = tdir.Text
            datos.Tel_col = ttel.Text
            datos.Cel_col = tcel.Text
            datos.Correo_col = tcorreo.Text
            datos.Id_puesto = sacarclave(cpuesto.Text)


            'revisar
            If flag = 1 Then
                datos.Alta_col = Format(Now, "yyyy-MM-dd")
                conn = New c_mysqlconn
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntacolaborador.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_col.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntacolaborador.consulta()
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
        tabla = conn.consulta("select * from puesto order by id_puesto")
        cpuesto.Items.Clear()
        For Each row As DataRow In tabla.Rows
            cpuesto.Items.Add(row("id_puesto") & " " & row("nom_puesto"))
        Next row
    End Sub
    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs) Handles tnombre.LostFocus, tdir.LostFocus
        mayus(sender)
    End Sub

    Private Sub frmcolaborador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CATALOGO DE ANFITRIONES")
        limpiar()
        combo()
    End Sub
End Class