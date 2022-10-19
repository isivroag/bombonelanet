Imports MySql.Data.MySqlClient
Public Class frmpuesto
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_puesto
    Dim tabla As New DataTable
    Public flag As Integer

    Public Sub mostrar(ByVal registro As c_puesto)
        datos = registro
        tid.Text = registro.Id_puesto
        tnombre.Text = registro.Nom_puesto
    End Sub

    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""

    End Sub


    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 Then
            datos.Nom_puesto = UCase(tnombre.Text)


            If flag = 1 Then
                conn = New c_mysqlconn
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntapuesto.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_puesto.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntapuesto.consulta()
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

    Private Sub frmpuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub
End Class