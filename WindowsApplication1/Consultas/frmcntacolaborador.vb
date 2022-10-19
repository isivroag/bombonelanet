Imports MySql.Data.MySqlClient
Public Class frmcntacolaborador
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_colaborador
    Dim tabla As New DataTable
    Public flag As Integer

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select colaborador.id_col,colaborador.nom_col,colaborador.dir_col," &
                                "colaborador.tel_col,colaborador.cel_col,colaborador.correo_col," &
                                "colaborador.id_puesto,puesto.nom_puesto,colaborador.alta_col,colaborador.estado_col " &
                                "from colaborador left join puesto on colaborador.id_puesto = puesto.id_puesto where colaborador.estado_col =1 order by colaborador.id_col")
        formatogrid()
    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "CLAVE"
        grdatos.Columns(1).HeaderText = "NOMBRE"
        grdatos.Columns(2).HeaderText = "DIRECCION"
        grdatos.Columns(3).HeaderText = "TEL"
        grdatos.Columns(4).HeaderText = "CEL"
        grdatos.Columns(5).HeaderText = "CORREO"
        grdatos.Columns(6).HeaderText = "ID PUESTO"
        grdatos.Columns(7).HeaderText = "PUESTO"
        grdatos.Columns(8).HeaderText = "ALTA"
        grdatos.Columns(9).HeaderText = "ESTADO"

        grdatos.AutoResizeColumns()
        grdatos.Columns(9).Visible = False
        grdatos.Columns(6).Visible = False


    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmcolaborador.Show()
        frmcolaborador.flag = 1
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick

        Dim registro As New c_colaborador


        registro.Id_col = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
        registro.Nom_col = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
        registro.Dir_col = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
        registro.Tel_col = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(3).Value)
        registro.Cel_col = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value)
        registro.Correo_col = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(5).Value)
        registro.Id_puesto = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(6).Value)
        registro.Alta_col = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(8).Value)
        registro.Estado_col = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(9).Value)




        Select Case flag
            Case 1
                'frmcliente.MdiParent = frmprincipal
                frmcolaborador.Show()
                frmcolaborador.mostrar(registro)
                frmcolaborador.flag = 2

            Case 2

                Dispose()
            Case 3

                Dispose()
            Case 4

                Dispose()
        End Select

    End Sub
    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click
        Dim registro As New c_colaborador

        registro.Id_col = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
        registro.Nom_col = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        registro.Dir_col = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        registro.Tel_col = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)
        registro.Cel_col = Convert.ToString(grdatos.CurrentRow().Cells(4).Value)
        registro.Correo_col = Convert.ToString(grdatos.CurrentRow().Cells(5).Value)
        registro.Id_puesto = Convert.ToString(grdatos.CurrentRow().Cells(6).Value)
        registro.Alta_col = Convert.ToString(grdatos.CurrentRow().Cells(8).Value)
        registro.Estado_col = Convert.ToString(grdatos.CurrentRow().Cells(9).Value)



        'frmcliente.MdiParent = frmprincipal
        frmcolaborador.Show()
        frmcolaborador.mostrar(registro)
        frmcolaborador.flag = 2

    End Sub

    Private Sub frmcntacolaborador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE ANFITRIONES")
        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)
    End Sub

    Private Sub mncdetalle_Click(sender As Object, e As EventArgs) Handles mncdetalle.Click
        frmdet_col.Show()
        frmdet_col.BringToFront()
        frmdet_col.id_col = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
        frmdet_col.colaborador = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        frmdet_col.LCOL.Text = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        frmdet_col.buscaritems()
    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub

    Private Sub mncHORARIO_Click(sender As Object, e As EventArgs) Handles mncHORARIO.Click
        frmhorariocol.Show()
        frmhorariocol.BringToFront()
        frmhorariocol.id_col = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
        'frmhorariocol.colaborador = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        frmhorariocol.lcol.Text = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        frmhorariocol.consulta()

        'frmhorariocol.buscarhorario()
    End Sub
End Class