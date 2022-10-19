Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmalmacen

    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_almacen
    Dim tabla As New DataTable
    Public flag As Integer
    Dim id_tipo As Integer

    Public Sub mostrar(ByVal registro As c_almacen)
        datos = registro
        tid.Text = registro.Id_almacen
        tnombre.Text = registro.Nom_almacen



    End Sub


    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""


    End Sub
    Private Sub frmalmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "ALMACEN")
        limpiar()

    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 Then

            datos.Nom_almacen = UCase(tnombre.Text)

            If flag = 1 Then
                conn = New c_mysqlconn
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntaalmacenes.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_almacen.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntaalmacenes.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Else
            MessageBox.Show("¡Verifique Sus Datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub
End Class