Imports MySql.Data.MySqlClient
Public Class frmcntacorte
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

        conn.consulta(grdetalle, "SELECT folio_pago,folio_fis,fecha_pago,folio_cxc,importe_pago,nom_metodo,nom_col,if(tipo_pago='1','FACTURADO','PENDIENTE') AS facturado FROM pago where estado_pago=1 and fecha_pago between '" & Format(fecha, "yyyy-MM-dd HH:mm:ss") & "' and '" & Format(fecha, "yyyy-MM-dd HH:mm:ss") & "' order by date(fecha_pago),folio_pago")

        formatogrid()

    End Sub
    Private Sub formatogrid()

        grdetalle.Columns(0).HeaderText = "FOLIO"
        grdetalle.Columns(1).HeaderText = "F FIS"
        grdetalle.Columns(2).HeaderText = "FECHA"
        grdetalle.Columns(3).HeaderText = "FOLIO CXC"
        grdetalle.Columns(4).HeaderText = "IMPORTE"
        grdetalle.Columns(5).HeaderText = "METODO"
        grdetalle.Columns(6).HeaderText = "COBRADOR"
        grdetalle.Columns(7).HeaderText = "TIPO"


        grdetalle.AutoResizeColumns()
        'grdetalle.Columns(3).Width = 200
        'grdetalle.Columns(2).Width = 70
        grdetalle.Columns(4).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        'grdetalle.Columns(0).Visible = False
        'grdetalle.Columns(1).Visible = False
        'grdetalle.Columns(7).Visible = False

    End Sub
    Private Sub frmcntacorte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CORTE DIARIO")
        ExtendedMethods.DoubleBuffered(grdetalle, True)
        fecha = (New Date(dtFecha.Value.Year, dtFecha.Value.Month, dtFecha.Value.Day, 0, 0, 0))


        consulta()
    End Sub
End Class