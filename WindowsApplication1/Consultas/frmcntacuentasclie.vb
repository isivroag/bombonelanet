Imports MySql.Data.MySqlClient
Public Class frmcntacuentasclie
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Dim ini As Date
    Dim fin As Date
    Public id_clie As Int64

    Public Sub consulta()
        conn = New c_mysqlconn
        tabla = New DataTable

        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()

        conn.consulta(grdatos, "select folio_cxc,fecha_cxc,id_clie,nom_clie,total_cxc,saldo_cxc,nom_col,estado_cxc,concepto_cxc from vcxc where estado_cxc=1 and id_clie='" & id_clie & "' order by fecha_cxc")
        If grdatos.Rows.Count = 0 Then

            grdatos.DataSource = Nothing
            grdatos.Rows.Clear()
            grdatos.Columns.Clear()
            grdatos.ColumnCount = 9
        End If
        formatogrid()

    End Sub

    Public Sub buscarcliente()
        conn = New c_mysqlconn
        tabla = New DataTable
        tabla = conn.consulta("select * from cliente where id_clie='" & id_clie & "'")
        If tabla.Rows.Count > 0 Then
            tnombre.Text = tabla.Rows(0).Item("nom_clie")
            tid_clie.Text = id_clie
        Else
            tnombre.Text = ""
        End If
        consulta()
    End Sub
    Private Sub formatogrid()

        grdatos.Columns(0).HeaderText = "FOLIO"
        grdatos.Columns(1).HeaderText = "FECHA"
        grdatos.Columns(2).HeaderText = "ID VIS"
        grdatos.Columns(3).HeaderText = "VISITANTE"
        grdatos.Columns(4).HeaderText = "IMPORTE"
        grdatos.Columns(5).HeaderText = "SALDO"
        grdatos.Columns(6).HeaderText = "COLABORADOR"
        grdatos.Columns(7).HeaderText = "ESTADO"
        grdatos.Columns(8).HeaderText = "CONCEPTO"


        grdatos.AutoResizeColumns()
        grdatos.Columns(3).Width = 200
        grdatos.Columns(6).Width = 200
        grdatos.AutoResizeRows()
        'grdetalle.Columns(2).Width = 70
        grdatos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdatos.Columns(4).DefaultCellStyle.Format = "C2"
        grdatos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdatos.Columns(5).DefaultCellStyle.Format = "C2"
        grdatos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        grdatos.Columns(7).Visible = False



    End Sub
    Private Sub mncpagar_Click(sender As Object, e As EventArgs) Handles mncpagar.Click

        frmpago.Show()
        frmpago.folio_cxc = grdatos.CurrentRow.Cells(0).Value
        frmpago.total = grdatos.CurrentRow.Cells(4).Value
        frmpago.saldo = grdatos.CurrentRow.Cells(5).Value
        frmpago.tsaldo.Text = grdatos.CurrentRow.Cells(5).Value
        frmpago.flagorg = 2
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncdetalle_Click(sender As Object, e As EventArgs) Handles mncdetalle.Click
        frmcobranza.Show()
        frmcobranza.folio_cxc = grdatos.CurrentRow.Cells(0).Value
        frmcobranza.bnuevo.Visible = False
        If grdatos.CurrentRow.Cells(5).Value > 0 Then
            frmcobranza.bpagar.Visible = True
        Else
            frmcobranza.bpagar.Visible = False
        End If
        frmcobranza.mostrar()
    End Sub

    Private Sub MNVER_Click(sender As Object, e As EventArgs) Handles MNVER.Click
        frmverpagos.Show()
        frmverpagos.folio_cxc = grdatos.CurrentRow.Cells(0).Value
        frmverpagos.consulta()
    End Sub
    Private Sub fmcntacuentasclie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE CUENTAS POR PAGAR")
        ExtendedMethods.DoubleBuffered(grdatos, True)
        grdatos.ColumnCount = 9
        formatogrid()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmcntacliente.Show()
        frmcntacliente.BringToFront()
        frmcntacliente.flag = 5
    End Sub

    Private Sub mncancelar_Click(sender As Object, e As EventArgs) Handles mncancelar.Click
        If MsgBox("¿Esta seguro de Cancelar el registro?", vbQuestion + vbYesNo, "CANCELACION") = vbYes Then
            Dim total As Double
            Dim saldo As Double
            Dim folio As String
            folio = grdatos.CurrentRow.Cells(0).Value
            total = grdatos.CurrentRow.Cells(4).Value
            saldo = grdatos.CurrentRow.Cells(5).Value

            If saldo = total Then

                frmlogincancel.Show()
                frmlogincancel.folio = folio
                frmlogincancel.tipo = 1
                'frmcancelar.Show()
                'frmcancelar.tfolio.Text = folio
                'frmcancelar.ttipo.Text = "1 VENTA"
                'frmcancelar.tfecha.Value = Now
                'frmcancelar.ltitulo.Text = "CANCELAR VENTA"

            Else
                MsgBox("El Registro ya tiene operaciones, es necesario cancelar los pagos antes de cancelar la venta", vbExclamation + vbOKOnly, "CANCELACION")
            End If

        End If
    End Sub

    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        ExportarDatosExcel2(grdatos, "CONSULTA DE CUENTAS")
    End Sub
End Class