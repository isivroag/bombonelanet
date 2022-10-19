Imports MySql.Data.MySqlClient
Public Class frmprospecto
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_prospecto
    Dim tabla As New DataTable

    Public flag As Integer
    Dim alta_col As Date


    Public Sub mostrar(ByVal registro As c_prospecto)
        datos = registro
        tid.Text = registro.Id_pros
        tnombre.Text = registro.Nom_pros

        ttel.Text = registro.Tel_pros
        tcel.Text = registro.Cel_pros
        tcorreo.Text = registro.Correo_pros

        alta_col = registro.Alta_pros

    End Sub

    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""

        ttel.Text = ""
        tcel.Text = ""
        tcorreo.Text = ""

        alta_col = Nothing

    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 Then
            datos.Nom_pros = tnombre.Text

            datos.Tel_pros = ttel.Text
            datos.Cel_pros = tcel.Text
            datos.Correo_pros = tcorreo.Text



            'revisar
            If flag = 1 Then
                datos.Alta_pros = Format(Now, "yyyy-MM-dd")
                conn = New c_mysqlconn
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntaprospectos.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_pros.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntaprospectos.consulta()
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
    Private Sub frmprospecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class