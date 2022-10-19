Imports MySql.Data.MySqlClient
Public Class frmcntavtadet

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

        conn.consulta(grdetalle, "SELECT * FROM v_incidencia_vta_rpt WHERE fecha_cxc= '" & Format(fecha, "yyyy-MM-dd") & "' order by folio_cxc")

        formatogrid()

    End Sub
    Private Sub formatogrid()

        grdetalle.Columns(0).HeaderText = "FOLIO"
        grdetalle.Columns(1).HeaderText = "FECHA"
        grdetalle.Columns(2).HeaderText = "CLIENTE"
        grdetalle.Columns(3).HeaderText = "COLABORADOR"
        grdetalle.Columns(4).HeaderText = "TIPO DETALLE"
        grdetalle.Columns(5).HeaderText = "CLAVE"
        grdetalle.Columns(6).HeaderText = "DESCRIPCION DETALLE"
        grdetalle.Columns(7).HeaderText = "SUBTOTAL"
        grdetalle.Columns(8).HeaderText = "INCIDENCIA"
        grdetalle.Columns(9).HeaderText = "TOTAL"


        grdetalle.AutoResizeColumns()
        'grdetalle.Columns(3).Width = 200
        'grdetalle.Columns(2).Width = 70
        grdetalle.Columns(7).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        grdetalle.Columns(9).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        'grdetalle.Columns(0).Visible = False
        'grdetalle.Columns(1).Visible = False
        'grdetalle.Columns(7).Visible = False

    End Sub
    Private Sub frmcntavtadet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA VTA-DETALLE")
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