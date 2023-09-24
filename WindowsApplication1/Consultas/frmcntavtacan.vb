Imports MySql.Data.MySqlClient
Public Class frmcntavtacan

    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Dim ini As Date
    Dim fin As Date
    Dim opc As Integer
    Dim color As Integer
    Dim fechaini As Date
    Dim fechafin As Date
    Public Sub consulta()
        conn = New c_mysqlconn
        tabla = New DataTable

        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()

        fechaini = (New Date(DtInicio.Value.Year, DtInicio.Value.Month, DtInicio.Value.Day, 0, 0, 0))
        fechafin = (New Date(DtFin.Value.Year, DtFin.Value.Month, DtFin.Value.Day, 0, 0, 0))

        Select Case ccampo.Text
            Case "FECHA"
                conn.consulta(grdetalle, "select folio_cxc,fecha_cxc,nom_clie,total_cxc,saldo_cxc,nom_col,if(estado_cxc=1,'VIGENTE','CANCELADA'),fecha_can,usuario_can,col_can,motivo_can from vcxc where estado_cxc=0 and fecha_cxc between '" & Format(fechaini, "yyyy-MM-dd") & "' and '" & Format(fechafin, "yyyy-MM-dd") & "' order by fecha_cxc")
            Case = "FOLIO VENTA"
                conn.consulta(grdetalle, "select folio_cxc,fecha_cxc,nom_clie,total_cxc,saldo_cxc,nom_col,if(estado_cxc=1,'VIGENTE','CANCELADA'),fecha_can,usuario_can,col_can,motivo_can from vcxc where estado_cxc=0 and folio_cxc='" & tnombre.Text & "'  order by fecha_cxc")
            Case = "CLIENTE"
                conn.consulta(grdetalle, "select folio_cxc,fecha_cxc,nom_clie,total_cxc,saldo_cxc,nom_col,if(estado_cxc=1,'VIGENTE','CANCELADA'),fecha_can,usuario_can,col_can,motivo_can from vcxc where estado_cxc=0 and nom_clie like'%" & tnombre.Text & "%' order by fecha_cxc")

        End Select

        'conn.consulta(grdetalle, "select folio_cxc,fecha_cxc,id_clie,nom_clie,total_cxc,saldo_cxc,nom_col,estado_cxc,concepto_cxc from vcxc where estado_cxc=1 order by fecha_cxc")
        If grdetalle.Rows.Count = 0 Then

            grdetalle.DataSource = Nothing
            grdetalle.Rows.Clear()
            grdetalle.Columns.Clear()
            grdetalle.ColumnCount = 11
        End If
        formatogrid()

    End Sub

    Private Sub formatogrid()

        grdetalle.Columns(0).HeaderText = "FOLIO"
        grdetalle.Columns(1).HeaderText = "FECHA"
        grdetalle.Columns(2).HeaderText = "VISITANTE"
        grdetalle.Columns(3).HeaderText = "IMPORTE"
        grdetalle.Columns(4).HeaderText = "SALDO"
        grdetalle.Columns(5).HeaderText = "COLABORADOR"
        grdetalle.Columns(6).HeaderText = "ESTADO"
        grdetalle.Columns(7).HeaderText = "FECHA CAN"
        grdetalle.Columns(8).HeaderText = "CANCELADO POR"
        grdetalle.Columns(9).HeaderText = "SOLICITADO POR"
        grdetalle.Columns(10).HeaderText = "MOTIVO CAN"





        grdetalle.AutoResizeColumns()
        grdetalle.Columns(3).Width = 200
        grdetalle.Columns(6).Width = 200
        grdetalle.AutoResizeRows()
        'grdetalle.Columns(2).Width = 70
        grdetalle.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdetalle.Columns(4).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdetalle.Columns(5).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'grdetalle.Columns(7).Visible = False



    End Sub
    Private Sub frmcntavtacan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE VENTAS CANCELADAS")

        ExtendedMethods.DoubleBuffered(grdetalle, True)
        DtInicio.Value = Now
        DtFin.Value = Now
        fechaini = (New Date(DtInicio.Value.Year, DtInicio.Value.Month, DtInicio.Value.Day, 0, 0, 0))
        fechafin = (New Date(DtFin.Value.Year, DtFin.Value.Month, DtFin.Value.Day, 23, 59, 59))

        consulta()
        Me.KeyPreview = True
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncdetalle_Click(sender As Object, e As EventArgs) Handles mncdetalle.Click
        frmcobranza.Show()
        frmcobranza.folio_cxc = grdetalle.CurrentRow.Cells(0).Value
        frmcobranza.bnuevo.Visible = False

        frmcobranza.bpagar.Visible = False

        frmcobranza.mostrar()
    End Sub

    Private Sub mnver_Click(sender As Object, e As EventArgs) Handles mnver.Click
        frmverpagos.Show()
        frmverpagos.folio_cxc = grdetalle.CurrentRow.Cells(0).Value
        frmverpagos.consulta()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        consulta()
    End Sub

    Private Sub frmcntacuentas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.F5 Then
            consulta()
        End If
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

    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        ExportarDatosExcel2(grdetalle, "CONSULTA DE VENTAS CANCELADAS")
    End Sub
End Class