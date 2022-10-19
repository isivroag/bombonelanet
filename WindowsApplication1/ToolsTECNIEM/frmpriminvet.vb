Imports MySql.Data.MySqlClient

Public Class frmpriminvet
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_inventario
    Dim tabla As New DataTable


    Private Sub procesar()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from producto where cant_prod>0 order by id_prod")
        bbar.Value = 0
        bbar.Maximum = tabla.Rows.Count

        For Each row As DataRow In tabla.Rows

            datos = New c_inventario
            datos.Id_prod = row("id_prod")
            datos.Cant_prod = row("cant_prod")
            datos.Nom_unidad = row("unidad_prod")
            conn = New c_mysqlconn
            conn.primerinv(datos.Id_prod, "1", datos.Cant_prod, datos.Nom_unidad)
            bbar.Value += 1
        Next row


    End Sub
    Private Sub frmpriminvet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        procesar()
    End Sub
End Class