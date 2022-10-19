Imports MySql.Data.MySqlClient
Public Class frmsubpartida
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_subpartida
    Dim tabla As New DataTable
    Public id_partida As Int64
    Dim partida As String
    Public flag As Integer

    Private Sub combo()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from partida order by id_partida")
        cpartida.Items.Clear()
        For Each row As DataRow In tabla.Rows
            cpartida.Items.Add(row("id_partida") & " " & row("nom_partida"))
        Next row


    End Sub

    Public Sub mostrar(ByVal registro As c_subpartida)
        datos = registro
        tid.Text = registro.Id_subpartida
        id_partida = registro.Id_partida
        tnombre.Text = registro.Nom_subpartida



    End Sub

    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""

    End Sub


    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 Then
            datos.Nom_subpartida = UCase(tnombre.Text)
            datos.Id_partida = sacarclave(cpartida.Text)


            If flag = 1 Then
                conn = New c_mysqlconn
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntasubpartida.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_subpartida.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntasubpartida.consulta()
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

    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs) Handles tnombre.LostFocus
        mayus(sender)
    End Sub
    Private Sub frmsubpartida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class