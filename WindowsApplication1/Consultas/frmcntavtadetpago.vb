Imports MySql.Data.MySqlClient
Public Class frmcntavtadetpago
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Public folio As String
    Dim fecha As DateTime
    Public sql As String
    Public Sub consulta()
        conn = New c_mysqlconn
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()

        conn.consulta(grdetalle, "SELECT * FROM vincidencia_vta_det_pago WHERE date(fecha_pago)= '" & Format(fecha, "yyyy-MM-dd") & "' order by folio_pago")

        formatogrid()

    End Sub
    Private Sub formatogrid()

        grdetalle.Columns(0).HeaderText = "FOLIO PAGO"
        grdetalle.Columns(1).HeaderText = "FOLIO VTA"
        grdetalle.Columns(2).HeaderText = "FECHA"
        grdetalle.Columns(3).HeaderText = "PAGO"
        grdetalle.Columns(4).HeaderText = "METODO"
        grdetalle.Columns(5).HeaderText = "COLABORADOR"
        grdetalle.Columns(6).HeaderText = "CLAVE"
        grdetalle.Columns(7).HeaderText = "DESCRIPCION DETALLE"
        grdetalle.Columns(8).HeaderText = "IMPORTE DETALLE"
        grdetalle.Columns(9).HeaderText = "INCIDENCIA"
        grdetalle.Columns(10).HeaderText = "PAGO DETALLE"


        grdetalle.AutoResizeColumns()
        'grdetalle.Columns(3).Width = 200
        'grdetalle.Columns(2).Width = 70
        grdetalle.Columns(3).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        grdetalle.Columns(8).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdetalle.Columns(10).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'grdetalle.Columns(0).Visible = False
        'grdetalle.Columns(1).Visible = False
        'grdetalle.Columns(7).Visible = False

    End Sub
    Private Sub frmcntavtadetpago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA VTA-DETALLE-PAGO")
        ExtendedMethods.DoubleBuffered(grdetalle, True)
        fecha = (New Date(dtFecha.Value.Year, dtFecha.Value.Month, dtFecha.Value.Day, 0, 0, 0))


        consulta()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        fecha = (New Date(dtFecha.Value.Year, dtFecha.Value.Month, dtFecha.Value.Day, 0, 0, 0))
        consulta()
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        ExportarDatosExcel2(grdetalle, "REPORTE DE VENTAS-DETALLE DEL " & dtFecha.Text)
    End Sub
End Class