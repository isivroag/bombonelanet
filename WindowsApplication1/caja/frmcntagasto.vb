Imports MySql.Data.MySqlClient
Public Class frmcntagasto

    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Dim datos As c_gasto
    Public folio As String
    Dim fechaini As DateTime
    Dim fechafin As DateTime
    Public sql As String
    Public Sub consulta()
        conn = New c_mysqlconn
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()

        conn.consulta(grdetalle, "SELECT id_gasto,fecha,referencia,concepto,monto,if(facturado='1','FACTURADO','NO FACTURADO') AS edofact FROM gasto where estado_gasto=1 and fecha between '" & Format(fechaini, "yyyy-MM-dd") & "' and '" & Format(fechafin, "yyyy-MM-dd") & "' order by id_gasto")

        formatogrid()

    End Sub
    Private Sub formatogrid()

        grdetalle.Columns(0).HeaderText = "FOLIO"
        grdetalle.Columns(1).HeaderText = "FECHA"
        grdetalle.Columns(2).HeaderText = "# FACT/REF"
        grdetalle.Columns(3).HeaderText = "CONCEPTO"
        grdetalle.Columns(4).HeaderText = "IMPORTE"
        grdetalle.Columns(5).HeaderText = "ESTADO"


        grdetalle.AutoResizeColumns()
        grdetalle.Columns(3).Width = 400
        'grdetalle.Columns(2).Width = 70
        grdetalle.Columns(4).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        'grdetalle.Columns(0).Visible = False
        'grdetalle.Columns(1).Visible = False
        'grdetalle.Columns(7).Visible = False

    End Sub
    Private Sub frmcntagasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtendedMethods.DoubleBuffered(grdetalle, True)
        fechaini = (New Date(DtInicio.Value.Year, DtInicio.Value.Month, DtInicio.Value.Day, 0, 0, 0))
        fechafin = (New Date(DtFin.Value.Year, DtFin.Value.Month, DtFin.Value.Day, 23, 59, 59))

        consulta()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        fechaini = (New Date(DtInicio.Value.Year, DtInicio.Value.Month, DtInicio.Value.Day, 0, 0, 0))
        fechafin = (New Date(DtFin.Value.Year, DtFin.Value.Month, DtFin.Value.Day, 23, 59, 59))

        consulta()
    End Sub



    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click
        frmgastoscaja.Show()
        frmgastoscaja.BringToFront()
        frmgastoscaja.buscar(grdetalle.CurrentRow().Cells(0).Value)
        frmgastoscaja.flag = 2


    End Sub

    Private Sub grdetalle_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdetalle.CellContentDoubleClick
        If e.RowIndex >= 0 Then


            frmgastoscaja.Show()
            frmgastoscaja.BringToFront()
            frmgastoscaja.buscar(grdetalle.Rows(e.RowIndex).Cells(0).Value)
            frmgastoscaja.flag = 2

        End If
    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmgastoscaja.Show()
        frmgastoscaja.BringToFront()
        frmgastoscaja.flag = 1

    End Sub

    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        ExportarDatosExcel2(grdetalle, "REPORTE DE GASTOS DE CAJA DEL " & DtInicio.Text & " AL " & DtFin.Text)
    End Sub
End Class