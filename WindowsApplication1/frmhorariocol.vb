Imports MySql.Data.MySqlClient

Public Class frmhorariocol
    Dim conn As c_mysqlconn
    Public id_col As Integer


    Public Sub consulta()
        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from horariocol where id_col='" & id_col & "' order by id_dia")
        formatogrid

    End Sub

    Private Sub formatogrid()

        grdatos.Columns(0).HeaderText = "ID"
        grdatos.Columns(1).HeaderText = "ID_DIA"
        grdatos.Columns(2).HeaderText = "ID_COL"
        grdatos.Columns(3).HeaderText = "DIA"
        grdatos.Columns(4).HeaderText = "ENTRADA"
        grdatos.Columns(5).HeaderText = "SALIDA"

        grdatos.Columns(0).Visible = False
        grdatos.Columns(1).Visible = False
        grdatos.Columns(2).Visible = False

        grdatos.AutoResizeColumns()



    End Sub

    Private Sub frmhorariocol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtendedMethods.DoubleBuffered(grdatos, True)
    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmauxhorario.Show()
        frmauxhorario.BringToFront()
        frmauxhorario.flag = 1
        frmauxhorario.id_col = id_col
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub



    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick
        Dim registro As New c_horariocol


        registro.Id_reg = Convert.ToInt64(grdatos.Rows(e.RowIndex).Cells(0).Value)
        registro.Id_dia = Convert.ToInt64(grdatos.Rows(e.RowIndex).Cells(1).Value)
        registro.Id_col = Convert.ToInt64(grdatos.Rows(e.RowIndex).Cells(2).Value)
        registro.Dia = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(3).Value)
        registro.Entrada = grdatos.Rows(e.RowIndex).Cells(4).Value
        registro.Salida = grdatos.Rows(e.RowIndex).Cells(5).Value

        frmauxhorario.Show()
        frmauxhorario.BringToFront()
        frmauxhorario.flag = 2
        frmauxhorario.mostrar(registro)

    End Sub
End Class