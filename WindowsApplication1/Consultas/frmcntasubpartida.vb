Imports MySql.Data.MySqlClient
Public Class frmcntasubpartida
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_subpartida
    Dim tabla As New DataTable
    Public flag As Integer
    Public id_partida As Int64

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select id_subpartida,nom_subpartida,estado_subpartida from subpartida where id_partida='" & id_partida & "' order by id_subpartida")
        formatogrid()
    End Sub

    Private Sub combo()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from partida order by id_partida")
        cpartida.Items.Clear()
        For Each row As DataRow In tabla.Rows
            cpartida.Items.Add(row("id_partida") & " " & row("nom_partida"))
        Next row


    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "CLAVE"
        grdatos.Columns(1).HeaderText = "NOMBRE"
        grdatos.Columns(2).HeaderText = "ESTADO"



        grdatos.AutoResizeColumns()
        grdatos.Columns(1).Width = 280
        grdatos.Columns(2).Visible = False



    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmsubpartida.Show()
        frmsubpartida.flag = 1
        frmsubpartida.cpartida.Text = cpartida.Text
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick

        Dim registro As New c_subpartida

        registro.Id_partida = sacarclave(cpartida.Text)
        registro.Id_subpartida = Convert.ToInt64(grdatos.Rows(e.RowIndex).Cells(0).Value)
        registro.Nom_subpartida = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
        registro.Estado_subpartida = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)


        Select Case flag
            Case 1
                'frmcliente.MdiParent = frmprincipal
                frmsubpartida.Show()
                frmsubpartida.mostrar(registro)
                frmsubpartida.cpartida.Text = cpartida.Text
                frmsubpartida.flag = 2

            Case 2

                Dispose()
            Case 3

                Dispose()
            Case 4

                Dispose()
        End Select

    End Sub
    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click
        Dim registro As New c_subpartida
        registro.Id_partida = sacarclave(cpartida.Text)
        registro.Id_subpartida = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
        registro.Nom_subpartida = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        registro.Estado_subpartida = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)


        frmsubpartida.Show()
        frmsubpartida.mostrar(registro)
        frmsubpartida.cpartida.Text = cpartida.Text
        frmsubpartida.flag = 2

    End Sub
    Private Sub cntasubpartida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE SUBPARTIDAS")
        combo()

        ExtendedMethods.DoubleBuffered(grdatos, True)

    End Sub

    Private Sub cpartida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cpartida.SelectedIndexChanged

    End Sub

    Private Sub cpartida_Click(sender As Object, e As EventArgs) Handles cpartida.Click
        id_partida = sacarclave(cpartida.Text)
        consulta()
    End Sub

    Private Sub cpartida_MouseClick(sender As Object, e As MouseEventArgs) Handles cpartida.MouseClick
        id_partida = sacarclave(cpartida.Text)
        consulta()
    End Sub

    Private Sub cpartida_SelectedValueChanged(sender As Object, e As EventArgs) Handles cpartida.SelectedValueChanged
        id_partida = sacarclave(cpartida.Text)
        consulta()
    End Sub
End Class