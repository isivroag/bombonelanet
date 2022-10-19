Imports MySql.Data.MySqlClient

Public Class frmdet_col
    Dim conn As New c_mysqlconn
    Dim texto As String

    Dim tabla As New DataTable

    Public flag As Integer
    Public id_col As Integer
    Public colaborador As String

    Public Sub buscaritems()
        conn = New c_mysqlconn
        tabla = conn.consulta("select id_tipo from det_col where id_col='" & id_col & "' order by id_tipo")

        For Each row As DataRow In tabla.Rows

            For idx As Integer = 1 To chtipos.Items.Count - 1
                If sacarclave(chtipos.Items(idx).ToString) = row("id_tipo") Then
                    chtipos.SetItemCheckState(idx, CheckState.Checked)
                End If
            Next

        Next row
    End Sub
    Private Sub combo()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select id_tipo,nom_tipo from tipo_servicio order by id_tipo")
        chtipos.Items.Clear()
        chtipos.Items.Add("MARCAR/DESMARCAR TODOS")
        For Each row As DataRow In tabla.Rows
            chtipos.Items.Add(row("id_tipo") & " " & row("nom_tipo"))

        Next row
    End Sub
    Private Sub frmdet_col_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtendedMethods.DoubleBuffered(chtipos, True)
        combo()
    End Sub
    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        conn = New c_mysqlconn
        Dim reg As Integer
        Dim guar As Integer

        If conn.eliminardetalle(id_col, 2) = True Then
            reg = 0
            guar = 0
            Dim i As Integer

            For i = 1 To chtipos.Items.Count - 1
                If (chtipos.GetItemChecked(i)) Then
                    conn = New c_mysqlconn
                    reg = reg + 1
                    If conn.agregardetalle(id_col, sacarclave(chtipos.Items(i).ToString), 2) = True Then
                        guar = guar + 1
                    End If
                End If
            Next
            If reg = guar Then
                MsgBox("SE REGISTRARON TODOS LOS SERVICIOS ELEGIDOS A ESTE COLABORADOR", vbInformation + vbOKOnly, "DETALLE GUARDADO")
            Else
                MsgBox("SOLO SE REGISTRARON" & guar & "/" & reg & "SERVICIOS A ESTE COLABORADOR", vbInformation + vbOKOnly, "DETALLE GUARDADO")
            End If
        End If
    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()

    End Sub
End Class