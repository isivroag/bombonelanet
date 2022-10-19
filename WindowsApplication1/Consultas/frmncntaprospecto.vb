Imports MySql.Data.MySqlClient

Public Class frmncntaprospecto
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_bdprospecto
    Dim tabla As New DataTable
    Public flag As Integer
    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from dbprospecto order by id")
        formatogrid()
    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID"
        grdatos.Columns(1).HeaderText = "NOMBRE"
        grdatos.Columns(2).HeaderText = "CALLE"
        grdatos.Columns(3).HeaderText = "NUM"
        grdatos.Columns(4).HeaderText = "COLONIA"
        grdatos.Columns(5).HeaderText = "MUNICIPIO"
        grdatos.Columns(6).HeaderText = "ESTADO"
        grdatos.Columns(7).HeaderText = "CP"
        grdatos.Columns(8).HeaderText = "TEL"
        grdatos.Columns(9).HeaderText = "CEL"
        grdatos.Columns(10).HeaderText = "CORREO"
        grdatos.Columns(11).HeaderText = "FECHA NAC"
        grdatos.Columns(12).HeaderText = "GENERO"
        grdatos.Columns(13).HeaderText = "FOTOTIPO"
        grdatos.Columns(14).HeaderText = "REFERENCIA"



        grdatos.AutoResizeColumns()

        grdatos.Columns(2).Visible = False
        grdatos.Columns(3).Visible = False
        grdatos.Columns(4).Visible = False
        grdatos.Columns(5).Visible = False
        grdatos.Columns(6).Visible = False
        grdatos.Columns(7).Visible = False
        grdatos.Columns(11).Visible = False
        grdatos.Columns(12).Visible = False
        grdatos.Columns(13).Visible = False
        grdatos.Columns(14).Visible = False



    End Sub
    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick

        Dim registro As New c_bdprospecto


        registro.Id = Convert.ToInt64(grdatos.CurrentRow.Cells(0).Value)
        registro.Nombre = Convert.ToString(grdatos.CurrentRow.Cells(1).Value)
        registro.Calle = Convert.ToString(grdatos.CurrentRow.Cells(2).Value)
        registro.Num = Convert.ToString(grdatos.CurrentRow.Cells(3).Value)
        registro.Col = Convert.ToString(grdatos.CurrentRow.Cells(4).Value)
        registro.Mun = Convert.ToString(grdatos.CurrentRow.Cells(5).Value)
        registro.Edo = Convert.ToString(grdatos.CurrentRow.Cells(6).Value)
        registro.Cdp = Convert.ToString(grdatos.CurrentRow.Cells(7).Value)
        registro.Tel = Convert.ToString(grdatos.CurrentRow.Cells(8).Value)
        registro.Cel = Convert.ToString(grdatos.CurrentRow.Cells(9).Value)
        registro.Correo = Convert.ToString(grdatos.CurrentRow.Cells(10).Value)
        registro.Fecha = Convert.ToString(grdatos.CurrentRow.Cells(11).Value)
        registro.Genero = Convert.ToString(grdatos.CurrentRow.Cells(12).Value)
        registro.Fototipo = Convert.ToString(grdatos.CurrentRow.Cells(13).Value)
        registro.Conocio = Convert.ToString(grdatos.CurrentRow.Cells(14).Value)





        Select Case flag
            Case 1
                'frmcliente.MdiParent = frmprincipal
                frmnprospecto.Show()
                frmnprospecto.mostrar(registro)
                frmnprospecto.flag = 2

            Case 2


                Dispose()
            Case 3

                Dispose()
            Case 4

                Dispose()
        End Select

    End Sub
    Private Sub frmncntaprospecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)

    End Sub
End Class