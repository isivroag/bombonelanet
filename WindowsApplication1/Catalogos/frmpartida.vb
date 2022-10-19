Imports MySql.Data.MySqlClient
Public Class frmpartida
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_partida
    Dim tabla As New DataTable
    Public flag As Integer

    Public Sub mostrar(ByVal registro As c_partida)
        datos = registro
        tid.Text = registro.Id_partida
        tnombre.Text = registro.Nom_partida
    End Sub

    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""

    End Sub


    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 Then
            datos.Nom_partida = UCase(tnombre.Text)


            If flag = 1 Then
                conn = New c_mysqlconn
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntapartida.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_partida.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntapartida.consulta()
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
    Private Sub frmpartida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CATALOGO DE PARTIDAS")
        limpiar()
    End Sub
End Class