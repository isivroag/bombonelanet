Imports MySql.Data.MySqlClient

Public Class frmcntaprospectos
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_prospecto
    Dim tabla As New DataTable
    Public flag As Integer

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from prospecto where estado_pros=1")
        formatogrid()
    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID"
        grdatos.Columns(1).HeaderText = "NOMBRE"

        grdatos.Columns(2).HeaderText = "TEL"
        grdatos.Columns(3).HeaderText = "CEL"
        grdatos.Columns(4).HeaderText = "CORREO"

        grdatos.Columns(5).HeaderText = "ALTA"
        grdatos.Columns(6).HeaderText = "ESTADO"

        grdatos.AutoResizeColumns()

        grdatos.Columns(6).Visible = False


    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmprospecto.Show()
        frmprospecto.flag = 1
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick

        Dim registro As New c_prospecto


        registro.Id_pros = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
        registro.Nom_pros = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
        registro.Cel_pros = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
        registro.Tel_pros = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(3).Value)

        registro.Correo_pros = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value)

        registro.Alta_pros = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(5).Value)
        registro.Estado_pros = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(6).Value)




        Select Case flag
            Case 1
                'frmcliente.MdiParent = frmprincipal
                frmprospecto.Show()
                frmprospecto.mostrar(registro)
                frmprospecto.flag = 2

            Case 2
                frmcita.id_persona = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmcita.tid_clie.Text = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmcita.tclie.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
                frmcita.ttel.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(3).Value)
                frmcita.tcel.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
                frmcita.tipo_persona = 0
                frmcita.ttipop.Text = "PROSPECTO"

                Dispose()
            Case 3

                Dispose()
            Case 4

                Dispose()
        End Select

    End Sub
    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click
        Dim registro As New c_prospecto

        registro.Id_pros = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
        registro.Nom_pros = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)


        registro.Cel_pros = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        registro.Tel_pros = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)
        registro.Correo_pros = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)

        registro.Alta_pros = Convert.ToString(grdatos.CurrentRow().Cells(5).Value)
        registro.Estado_pros = Convert.ToString(grdatos.CurrentRow().Cells(6).Value)



        'frmcliente.MdiParent = frmprincipal
        frmprospecto.Show()
        frmprospecto.mostrar(registro)
        frmprospecto.flag = 2


    End Sub
    Private Sub frmcntaprospectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE PROSPECTOS")
        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)

    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub
End Class