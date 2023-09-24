Imports MySql.Data.MySqlClient
Public Class frmticketscan

    Dim conn As c_mysqlconn
    Dim tabla As DataTable

    Public folio As String
    Dim fechaini As DateTime
    Dim fechafin As DateTime
    Public sql As String
    Public Sub consulta()
        conn = New c_mysqlconn
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()

        Select Case ccampo.Text
            Case "FECHA"

                conn.consulta(grdetalle, "SELECT folio_pago,folio_cxc,fecha_pago,nom_clie,importe_pago,nom_metodo,nom_col,estado,fecha_can,usuario_can,col_can,motivo_can FROM vticket where date(fecha_pago) between '" & Format(fechaini, "yyyy-MM-dd") & "' and '" & Format(fechafin, "yyyy-MM-dd") & "' and estado='CANCELADO' group by folio_pago order by folio_pago")
            Case "FOLIO TICKET"
                conn.consulta(grdetalle, "SELECT folio_pago,folio_cxc,fecha_pago,nom_clie,importe_pago,nom_metodo,nom_col,estado,fecha_can,usuario_can,col_can,motivo_can FROM vticket where folio_pago='" & tnombre.Text & " and estado='CANCELADO'' group by folio_pago order by folio_pago")
            Case "FOLIO VENTA"
                conn.consulta(grdetalle, "SELECT folio_pago,folio_cxc,fecha_pago,nom_clie,importe_pago,nom_metodo,nom_col,estado,fecha_can,usuario_can,col_can,motivo_can FROM vticket where folio_cxc='" & tnombre.Text & "' and estado='CANCELADO' group by folio_pago order by folio_pago")
        End Select



        formatogrid()

    End Sub
    Private Sub formatogrid()

        grdetalle.Columns(0).HeaderText = "FOLIO TICKET"
        grdetalle.Columns(1).HeaderText = "FOLIO VENTA"
        grdetalle.Columns(2).HeaderText = "FECHA"
        grdetalle.Columns(3).HeaderText = "CLIENTE"
        grdetalle.Columns(4).HeaderText = "IMPORTE"
        grdetalle.Columns(5).HeaderText = "METODO"
        grdetalle.Columns(6).HeaderText = "COBRADOR"
        grdetalle.Columns(7).HeaderText = "ESTADO"

        grdetalle.Columns(8).HeaderText = "FECHA CAN"
        grdetalle.Columns(9).HeaderText = "CANCELADO POR"
        grdetalle.Columns(10).HeaderText = "SOLICITADO POR"
        grdetalle.Columns(11).HeaderText = "MOTIVO CAN"



        grdetalle.AutoResizeColumns()

        'grdetalle.Columns(2).Width = 70
        grdetalle.Columns(4).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        'grdetalle.Columns(0).Visible = False
        'grdetalle.Columns(1).Visible = False
        'grdetalle.Columns(7).Visible = False

    End Sub
    Private Sub frmticketscan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtendedMethods.DoubleBuffered(grdetalle, True)
        fechaini = (New Date(DtInicio.Value.Year, DtInicio.Value.Month, DtInicio.Value.Day, 0, 0, 0))
        fechafin = (New Date(DtFin.Value.Year, DtFin.Value.Month, DtFin.Value.Day, 23, 59, 59))
        inicial(sender, e, "CONSULTA DE TICKETS CANCELADOS")
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

    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        ExportarDatosExcel2(grdetalle, "REPORTE DE TICKETS CANCELADOS")
    End Sub

    Private Sub ccampo_TextChanged(sender As Object, e As EventArgs) Handles ccampo.TextChanged
        If ccampo.Text = "FECHA" Then
            DtInicio.Visible = True
            DtFin.Visible = True
            l1.Visible = True
            l2.Visible = True
            l3.Visible = False
            tnombre.Visible = False
            DtInicio.Value = Now
            DtFin.Value = Now
        Else
            DtInicio.Visible = False
            DtFin.Visible = False
            l1.Visible = False
            l2.Visible = False
            l3.Visible = True
            tnombre.Visible = True
            tnombre.Text = ""
        End If
    End Sub

    Private Sub mncdetalle_Click(sender As Object, e As EventArgs) Handles mncdetalle.Click
        frmcobranza.Show()
        frmcobranza.folio_cxc = grdetalle.CurrentRow.Cells(1).Value
        frmcobranza.bnuevo.Visible = False

        frmcobranza.bpagar.Visible = False

        frmcobranza.mostrar()
    End Sub

    Private Sub mnver_Click(sender As Object, e As EventArgs) Handles mnver.Click
        frmverpagos.Show()
        frmverpagos.folio_cxc = grdetalle.CurrentRow.Cells(1).Value
        frmverpagos.consulta()
    End Sub
End Class