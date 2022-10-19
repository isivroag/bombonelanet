Imports MySql.Data.MySqlClient
Public Class frmcntaegresos
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Dim datos As c_egreso
    Public folio As String
    Dim fechaini As DateTime
    Dim fechafin As DateTime
    Public sql As String
    Public Sub consulta()
        conn = New c_mysqlconn
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()

        conn.consulta(grdetalle, "SELECT id_egr,fecha_egr,ref_egr,nom_prov,nom_partida,nom_subpartida,concepto_egr,metodo_egr,total_egr,if(facturado='1','FACTURADO','NO FACTURADO') AS edofact FROM vegresos where estado_egr=1 and fecha_egr between '" & Format(fechaini, "yyyy-MM-dd HH:mm:ss") & "' and '" & Format(fechafin, "yyyy-MM-dd HH:mm:ss") & "' order by id_egr")

        formatogrid()

    End Sub
    Private Sub formatogrid()

        grdetalle.Columns(0).HeaderText = "FOLIO"
        grdetalle.Columns(1).HeaderText = "FECHA"
        grdetalle.Columns(2).HeaderText = "# FACT/REF"
        grdetalle.Columns(3).HeaderText = "PROVEEDOR"
        grdetalle.Columns(4).HeaderText = "PARTIDA"
        grdetalle.Columns(5).HeaderText = "SUBPARTIDA"
        grdetalle.Columns(6).HeaderText = "CONCEPTO"
        grdetalle.Columns(7).HeaderText = "METODO"
        grdetalle.Columns(8).HeaderText = "IMPORTE"
        grdetalle.Columns(9).HeaderText = "ESTADO"


        grdetalle.AutoResizeColumns()
        'grdetalle.Columns(3).Width = 200
        'grdetalle.Columns(2).Width = 70
        grdetalle.Columns(8).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        'grdetalle.Columns(0).Visible = False
        'grdetalle.Columns(1).Visible = False
        'grdetalle.Columns(7).Visible = False

    End Sub
    Private Sub frmcntaegresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        frmegresos.Show()
        frmegresos.BringToFront()
        frmegresos.buscar(grdetalle.CurrentRow().Cells(0).Value)
        frmegresos.flag = 2


    End Sub

    Private Sub grdetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdetalle.CellContentClick

    End Sub

    Private Sub grdetalle_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdetalle.CellContentDoubleClick
        If e.RowIndex >= 0 Then


            frmegresos.Show()
            frmegresos.BringToFront()
            frmegresos.buscar(grdetalle.Rows(e.RowIndex).Cells(0).Value)
            frmegresos.flag = 2

        End If
    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmegresos.Show()
        frmegresos.BringToFront()
        frmegresos.flag = 1

    End Sub

    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        ExportarDatosExcel2(grdetalle, "REPORTE DE EGRESOS DEL " & DtInicio.Text & " AL " & DtFin.Text)
    End Sub
End Class