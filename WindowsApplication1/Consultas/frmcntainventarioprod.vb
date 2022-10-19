Imports MySql.Data.MySqlClient

Public Class frmcntainventarioprod
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_paquete
    Dim tabla As New DataTable
    Public flag As Integer


    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from vinventario_prod order by id_prod")

        formatogrid()
    End Sub

    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID PROD"
        grdatos.Columns(1).HeaderText = "CLAVE"
        grdatos.Columns(2).HeaderText = "DESCRIPCION"
        grdatos.Columns(3).HeaderText = "MARCA"
        grdatos.Columns(4).HeaderText = "CANTIDAD PRODUCTO"
        grdatos.Columns(5).HeaderText = "CANTIDAD INVENTARIO"
        grdatos.Columns(6).HeaderText = "DIFERENCIA"
        grdatos.Columns(7).HeaderText = "UNIDAD"


        grdatos.AutoResizeColumns()
        grdatos.Columns(2).Width = 250

        Dim dgv As DataGridView = Me.grdatos

        For i As Integer = 0 To dgv.Rows.Count - 1

            If dgv.Rows(i).Cells(6).Value <> 0 Then

                dgv.Rows(i).Cells(6).Style.BackColor = Color.Red

            End If

        Next

    End Sub
    Private Sub frmcntainventarioprod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "VERIFICACION INVENTARIO")

        ExtendedMethods.DoubleBuffered(grdatos, True)

        consulta()


    End Sub

    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        ExportarDatosExcel2(grdatos, "VERIFIFACION DE INVENTARIO")
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncVerificar_Click(sender As Object, e As EventArgs) Handles mncVerificar.Click
        frmaux.Show()
        frmaux.BringToFront()
        frmaux.actualizarproducto()
    End Sub
End Class