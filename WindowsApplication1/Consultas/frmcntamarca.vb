Imports MySql.Data.MySqlClient

Public Class frmcntamarca
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_marca
    Dim tabla As New DataTable
    Public flag As Integer

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from marca order by id_marca")
        formatogrid()
    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "CLAVE"
        grdatos.Columns(1).HeaderText = "MARCA"
        grdatos.Columns(2).HeaderText = "ESTADO"



        grdatos.AutoResizeColumns()
        grdatos.Columns(1).Width = 300
        grdatos.Columns(2).Visible = False



    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmmarca.Show()
        frmmarca.flag = 1
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick

        Dim registro As New c_marca


        registro.Id_marca = Convert.ToInt64(grdatos.Rows(e.RowIndex).Cells(0).Value)
        registro.Nom_marca = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
        registro.Estado_marca = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)






        Select Case flag
            Case 1
                'frmcliente.MdiParent = frmprincipal
                frmmarca.Show()
                frmmarca.mostrar(registro)
                frmmarca.flag = 2

            Case 2

                Dispose()
            Case 3

                Dispose()
            Case 4

                Dispose()
        End Select

    End Sub
    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click
        Dim registro As New c_marca

        registro.Id_marca = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
        registro.Nom_marca = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        registro.Estado_marca = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)




        'frmcliente.MdiParent = frmprincipal
        frmmarca.Show()
        frmmarca.mostrar(registro)
        frmmarca.flag = 2

    End Sub
    Private Sub frmcntamarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE MARCAS")
        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)
    End Sub
End Class