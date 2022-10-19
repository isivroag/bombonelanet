Imports MySql.Data.MySqlClient

Public Class frmcntacuentas
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Dim ini As Date
    Dim fin As Date


    Public Sub consulta()
        conn = New c_mysqlconn
        tabla = New DataTable

        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()

        conn.consulta(grdatos, "select * from vcxc where estado_cxc=1 and saldo_cxc>0 order by fecha_cxc")
        If grdatos.Rows.Count = 0 Then

            grdatos.DataSource = Nothing
            grdatos.Rows.Clear()
            grdatos.Columns.Clear()
            grdatos.ColumnCount = 8
        End If
        formatogrid()

    End Sub
    Private Sub formatogrid()

        grdatos.Columns(0).HeaderText = "FOLIO"
        grdatos.Columns(1).HeaderText = "FECHA"
        grdatos.Columns(2).HeaderText = "ID_CLIE"
        grdatos.Columns(3).HeaderText = "VISITANTE"
        grdatos.Columns(4).HeaderText = "IMPORTE"
        grdatos.Columns(5).HeaderText = "SALDO"
        grdatos.Columns(6).HeaderText = "VENDIDO POR"
        grdatos.Columns(7).HeaderText = "ESTADO"


        grdatos.AutoResizeColumns()
        'grdatos.Columns(4).Width = 200
        grdatos.AutoResizeRows()
        'grdetalle.Columns(2).Width = 70
        grdatos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdatos.Columns(4).DefaultCellStyle.Format = "C2"
        grdatos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdatos.Columns(5).DefaultCellStyle.Format = "C2"
        grdatos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        grdatos.Columns(7).Visible = False


    End Sub
    Private Sub frmcntacuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "DETALLE DE CUENTAS POR PAGAR")

        ExtendedMethods.DoubleBuffered(grdatos, True)
        consulta()
        Me.KeyPreview = True
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

    Private Sub mnver_Click(sender As Object, e As EventArgs) Handles mnver.Click
        frmverpagos.Show()
        frmverpagos.folio_cxc = grdatos.CurrentRow.Cells(0).Value
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

    Private Sub mncancelar_Click(sender As Object, e As EventArgs) Handles mncancelar.Click
        If MsgBox("¿Esta seguro de Cancelar el registro?", vbQuestion + vbYesNo, "Cancelar") = vbYes Then
            frmcancelar.Show()
            frmcancelar.tmotivo.Text = globalusuario

        End If
    End Sub


End Class