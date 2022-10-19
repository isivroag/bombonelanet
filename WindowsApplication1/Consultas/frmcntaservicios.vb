Imports MySql.Data.MySqlClient
Public Class frmcntaservicios
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_servicio
    Dim tabla As New DataTable
    Public flag As Integer
    Dim color As Integer

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select servicio.id_serv,servicio.nom_serv,servicio.desc_serv,servicio.id_tipo,tipo_servicio.nom_tipo,servicio.dur_serv,servicio.estado_serv" &
                               " from servicio left join tipo_servicio on servicio.id_tipo = tipo_servicio.id_tipo where servicio.estado_serv =1 order by servicio.id_serv")
        formatogrid()
    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "CLAVE"
        grdatos.Columns(1).HeaderText = "SERVICIO"
        grdatos.Columns(2).HeaderText = "DESCRIPCION"
        grdatos.Columns(3).HeaderText = "ID IPO"
        grdatos.Columns(4).HeaderText = "CLASIFICACION"
        grdatos.Columns(5).HeaderText = "DURACION"
        grdatos.Columns(6).HeaderText = "ESTADO"


        grdatos.AutoResizeColumns()
        grdatos.Columns(3).Visible = False
        grdatos.Columns(6).Visible = False


    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmservicio.Show()
        frmservicio.flag = 1
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick

        Dim registro As New c_servicio


        registro.Id_serv = Convert.ToInt64(grdatos.Rows(e.RowIndex).Cells(0).Value)
        registro.Nom_serv = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
        registro.Desc_serv = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
        registro.Id_tipo = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(3).Value)
        registro.Duracion = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(5).Value)
        registro.Estado_serv = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(6).Value)





        Select Case flag
            Case 1
                'frmcliente.MdiParent = frmprincipal
                frmservicio.Show()
                frmservicio.mostrar(registro)
                frmservicio.flag = 2

            Case 2
                frmcita.ID_SERV = Convert.ToInt64(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmcita.id_tipo = Convert.ToInt64(grdatos.Rows(e.RowIndex).Cells(3).Value)
                frmcita.tid_serv.Text = Convert.ToInt64(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmcita.tserv.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
                frmcita.duracion = Convert.ToInt32(grdatos.Rows(e.RowIndex).Cells(5).Value)
                frmcita.buscarcabina()
                frmcita.buscarcol()

                Dispose()
            Case 3
                frmcntapaquetes.Show()
                frmcntapaquetes.id_serv = registro.Id_serv
                frmcntapaquetes.consulta()
                frmcntapaquetes.flag = 2
                Dispose()
            Case 4
                frmvisita.id_serv = Convert.ToInt64(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmvisita.id_tipo = Convert.ToInt64(grdatos.Rows(e.RowIndex).Cells(3).Value)
                frmvisita.tserv.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
                frmvisita.duracion = Convert.ToInt32(grdatos.Rows(e.RowIndex).Cells(5).Value)
                frmvisita.buscarcabina()
                frmvisita.buscarcol()

                Dispose()
            Case 5
                'Desde cobranza venta nueva
                frmcntapaquetes.Show()
                frmcntapaquetes.id_serv = registro.Id_serv
                frmcntapaquetes.consulta()
                frmcntapaquetes.flag = 2
                Dispose()
        End Select

    End Sub
    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click
        Dim registro As New c_servicio

        registro.Id_serv = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
        registro.Nom_serv = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        registro.Desc_serv = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        registro.Id_tipo = Convert.ToInt64(grdatos.CurrentRow().Cells(3).Value)

        registro.Duracion = Convert.ToString(grdatos.CurrentRow().Cells(5).Value)
        registro.Estado_serv = Convert.ToString(grdatos.CurrentRow().Cells(6).Value)



        'frmcliente.MdiParent = frmprincipal
        frmservicio.Show()
        frmservicio.mostrar(registro)
        frmservicio.flag = 2

    End Sub
    Private Sub frmcntaservicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE SERVICIOS")

        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)
    End Sub

    Private Sub mncpaquetes_Click(sender As Object, e As EventArgs) Handles mncpaquetes.Click
        frmcntapaquetes.Show()
        frmcntapaquetes.BringToFront()
        frmcntapaquetes.flag = 1
        frmcntapaquetes.id_serv = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
        frmcntapaquetes.consulta()
    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub

    Private Sub tnombre_TextChanged(sender As Object, e As EventArgs) Handles tnombre.TextChanged
        If Color = 0 Then
            tnombre.ForeColor = SystemColors.InactiveCaption

        Else

            tnombre.ForeColor = Drawing.Color.Black

        End If
    End Sub

    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs) Handles tnombre.LostFocus
        If Len(tnombre.Text) = 0 Then

            tnombre.Text = "INTRODUZCA EL VALOR BUSCADO"
            tnombre.ForeColor = SystemColors.InactiveCaption
            Color = 0
        Else
            Color = 1

        End If
    End Sub

    Private Sub tnombre_GotFocus(sender As Object, e As EventArgs) Handles tnombre.GotFocus
        tnombre.Text = ""
        tnombre.ForeColor = Drawing.Color.Black
        Color = 1
    End Sub

    Private Sub bbuscar_Click(sender As Object, e As EventArgs) Handles bbuscar.Click
        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consultadinamica(grdatos, "select servicio.id_serv,servicio.nom_serv,servicio.desc_serv,servicio.id_tipo,tipo_servicio.nom_tipo,servicio.dur_serv,servicio.estado_serv" &
                               " from servicio left join tipo_servicio on servicio.id_tipo = tipo_servicio.id_tipo where servicio.estado_serv =1 and" &
                               " (servicio.nom_serv like '%" & tnombre.Text & "%' or servicio.desc_serv like '%" & tnombre.Text & "%' or tipo_servicio.nom_tipo like '%" & tnombre.Text & "%') order by servicio.id_serv")
        formatogrid()
    End Sub
End Class