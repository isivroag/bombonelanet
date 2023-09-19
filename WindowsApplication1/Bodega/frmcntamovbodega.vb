Imports MySql.Data.MySqlClient
Public Class frmcntamovbodega
    Dim conn As New c_mysqlconn
    Dim fechaini As Date
    Dim fechafin As Date

    Public Sub consulta()
        conn = New c_mysqlconn
        If chcancelados.Checked Then
            conn.consulta(grdetalle, "select * from transfer where fecha_trans between '" & Format(fechaini, "yyyy-MM-dd") & "' and '" & Format(fechafin, "yyyy-MM-dd") & "' order by folio_trans")
        Else
            conn.consulta(grdetalle, "select * from transfer where estado_trans=1 and fecha_trans between '" & Format(fechaini, "yyyy-MM-dd") & "' and '" & Format(fechafin, "yyyy-MM-dd") & "' order by folio_trans")

        End If


        formatogrid()
    End Sub

    Private Sub formatogrid()
        DoubleBuffered = True

        grdetalle.Columns(0).HeaderText = "FOLIO"
        grdetalle.Columns(1).HeaderText = "ID ORIGEN"
        grdetalle.Columns(2).HeaderText = "ORIGEN"
        'CAMBIO ACTUALIZACION

        grdetalle.Columns(3).HeaderText = "ID DESTINO"

        grdetalle.Columns(4).HeaderText = "DESTINO"
        grdetalle.Columns(5).HeaderText = "FECHA"

        grdetalle.Columns(6).HeaderText = "OBSERVACIONES"
        grdetalle.Columns(7).HeaderText = "IMPORTE"




        grdetalle.AutoResizeColumns()
        grdetalle.Columns(6).Width = 250
        grdetalle.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdetalle.Columns(7).DefaultCellStyle.Format = "C2"

        grdetalle.Columns(1).Visible = False
        grdetalle.Columns(3).Visible = False
        grdetalle.Columns(8).Visible = False
        grdetalle.Columns(9).Visible = False

        grdetalle.Columns(10).Visible = False
        grdetalle.Columns(11).Visible = False


    End Sub
    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmmovalmacenp.Show()
        frmmovalmacenp.BringToFront()
        frmmovalmacenp.flag = 1

    End Sub

    Private Sub grdetalle_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdetalle.CellDoubleClick

        Dim folio As Int64

        folio = Convert.ToInt64(grdetalle.CurrentRow().Cells(0).Value)




        frmmovalmacenp.Show()
        frmmovalmacenp.BringToFront()
        frmmovalmacenp.flag = 2
        frmmovalmacenp.folio = folio
        frmmovalmacenp.buscar(folio)


    End Sub

    Private Sub frmcntamovbodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "MOVIMIENTOS BODEGA PRINCIPAL")
        Dim primerDia As DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        Dim ultimoDia As DateTime = primerDia.AddMonths(1).AddDays(-1)
        DtInicio.Value = primerDia
        DtFin.Value = ultimoDia
        ExtendedMethods.DoubleBuffered(grdetalle, True)
        consulta()
        fechaini = (New Date(DtInicio.Value.Year, DtInicio.Value.Month, DtInicio.Value.Day, 0, 0, 0))
        fechafin = (New Date(DtFin.Value.Year, DtFin.Value.Month, DtFin.Value.Day, 23, 59, 59))
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        fechaini = (New Date(DtInicio.Value.Year, DtInicio.Value.Month, DtInicio.Value.Day, 0, 0, 0))
        fechafin = (New Date(DtFin.Value.Year, DtFin.Value.Month, DtFin.Value.Day, 23, 59, 59))
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()
        conn = New c_mysqlconn

        consulta()

        formatogrid()
    End Sub

    Private Sub grdetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdetalle.CellContentClick

    End Sub

    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click
        Dim folio As Int64

        folio = Convert.ToInt64(grdetalle.CurrentRow().Cells(0).Value)




        frmmovalmacenp.Show()
        frmmovalmacenp.BringToFront()
        frmmovalmacenp.flag = 2
        frmmovalmacenp.folio = folio
        frmmovalmacenp.buscar(folio)
    End Sub

    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        ExportarDatosExcel2(grdetalle, "REPORTE DE MOVIMIENTOS DE BODEGA DE " & DtInicio.Text & " AL " & DtFin.Text)
    End Sub

    Private Sub mncELIMINAR_Click(sender As Object, e As EventArgs) Handles mncELIMINAR.Click
        If MsgBox("DESEA ELIMINAR ESTE REGISTRO", vbYesNo + vbQuestion, "ELIMINAR") = vbYes Then
            Dim clave As String
            clave = Convert.ToDouble(grdetalle.CurrentRow().Cells(0).Value)
            frmauxcancelar.Show()
            frmauxcancelar.folio = clave
            frmauxcancelar.tipo = 3
        End If
    End Sub
End Class