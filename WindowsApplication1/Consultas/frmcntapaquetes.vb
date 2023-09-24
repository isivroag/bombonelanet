Imports MySql.Data.MySqlClient
Public Class frmcntapaquetes
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_paquete
    Dim tabla As New DataTable
    Public flag As Integer
    Public id_serv As Integer
    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select paquete.id_serv,paquete.id_pqt,paquete.clave_pqt,servicio.nom_serv,paquete.desc_pqt,paquete.sesiones_pqt,paquete.precio_pqt,paquete.estado_pqt" &
                               " from paquete join servicio on paquete.id_serv = servicio.id_serv where servicio.estado_serv =1 and paquete.estado_pqt=1 and paquete.id_serv='" & id_serv & "' order by servicio.id_serv,paquete.id_pqt")
        formatogrid()
    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID_SERV"
        grdatos.Columns(1).HeaderText = "ID_PQT"
        grdatos.Columns(2).HeaderText = "CLAVE"
        grdatos.Columns(3).HeaderText = "SERVICIO"
        grdatos.Columns(4).HeaderText = "DESCRIPCION"
        grdatos.Columns(5).HeaderText = "SESIONES"
        grdatos.Columns(6).HeaderText = "PRECIO"

        grdatos.Columns(7).HeaderText = "ESTADO"


        grdatos.AutoResizeColumns()
        grdatos.Columns(3).Width = 200
        grdatos.Columns(4).Width = 200
        grdatos.Columns(0).Visible = False
        grdatos.Columns(1).Visible = False

        grdatos.Columns(7).Visible = False


    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmpaquete.Show()
        frmpaquete.flag = 1
        frmpaquete.id_serv = id_serv
        frmpaquete.buscarservicio()
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick

        Dim registro As New c_paquete


        registro.Id_serv = Convert.ToInt64(grdatos.Rows(e.RowIndex).Cells(0).Value)
        registro.Id_pqt = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
        registro.Clave_pqt = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
        registro.Desc_pqt = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value)
        registro.Sesiones_pqt = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(5).Value)
        registro.Precio_pqt = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(6).Value)

        registro.Estado_pqt = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(7).Value)





        Select Case flag
            Case 1
                'frmcliente.MdiParent = frmprincipal
                frmpaquete.Show()
                frmpaquete.mostrar(registro)
                frmpaquete.flag = 2

            Case 2
                frmauxcobranza.Show()
                frmauxcobranza.datos(registro)


                Dispose()
            Case 3

                Dispose()
            Case 4

                Dispose()
        End Select

    End Sub
    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click
        Dim registro As New c_paquete

        registro.Id_serv = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
        registro.Id_pqt = Convert.ToInt64(grdatos.CurrentRow().Cells(1).Value)
        registro.Clave_pqt = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        registro.Desc_pqt = Convert.ToString(grdatos.CurrentRow().Cells(4).Value)
        registro.Sesiones_pqt = Convert.ToInt64(grdatos.CurrentRow().Cells(5).Value)
        registro.Precio_pqt = Convert.ToDouble(grdatos.CurrentRow().Cells(6).Value)

        registro.Estado_pqt = Convert.ToString(grdatos.CurrentRow().Cells(7).Value)



        'frmcliente.MdiParent = frmprincipal
        frmpaquete.Show()
        frmpaquete.mostrar(registro)
        frmpaquete.flag = 2

    End Sub
    Private Sub frmcntapaquetes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE PAQUETES")

        ExtendedMethods.DoubleBuffered(grdatos, True)
        If globalrol = 1 Then
            For Each men As ToolStripButton In menuclientes.Items
                If men.Name = "mncSALIR" Then
                    men.Visible = True
                Else
                    men.Visible = False
                End If
            Next
        End If
    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub
End Class