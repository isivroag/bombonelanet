Imports MySql.Data.MySqlClient
Public Class frmaux
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_producto
    Dim tabla As New DataTable

    Public Sub actualizarproducto()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from vinventario_prod order by id_prod")
        bbar.Value = 0
        bbar.Maximum = tabla.Rows.Count

        For Each row As DataRow In tabla.Rows

            datos = New c_producto
            datos.Id_prod = row("id_prod")
            datos.Cant_prod = row("cant_inv")

            conn = New c_mysqlconn
            conn.actualizarproducto(datos.Id_prod, datos.Cant_prod)
            bbar.Value += 1
        Next row
        Me.Dispose()

    End Sub
    Private Sub frmaux_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class