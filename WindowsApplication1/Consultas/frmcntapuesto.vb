Imports MySql.Data.MySqlClient
Public Class frmcntapuesto
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_puesto
    Dim tabla As New DataTable
    Public flag As Integer

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from puesto order by id_puesto")
        formatogrid()
    End Sub
    Private Sub formatogrid()

        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID"
        grdatos.Columns(1).HeaderText = "PUESTO"
        grdatos.Columns(2).HeaderText = "ESTADO"

        grdatos.AutoResizeColumns()
        grdatos.Columns(0).Width = 50
        grdatos.Columns(1).Width = 250
        grdatos.Columns(2).Width = 0

        grdatos.Columns(2).Visible = False



    End Sub


    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmpuesto.Show()
        frmpuesto.BringToFront()
        frmpuesto.flag = 1
    End Sub

    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click

        datos.Id_puesto = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
        datos.Nom_puesto = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)




        frmpuesto.Show()
        frmpuesto.BringToFront()
        frmpuesto.mostrar(datos)
        frmpuesto.flag = 2
    End Sub

    Private Sub mncELIMINAR_Click(sender As Object, e As EventArgs) Handles mncELIMINAR.Click
        If MsgBox("Desea Eliminar Este Puesto", vbYesNo + vbQuestion,) = vbYes Then
            Dim registro As New c_puesto
            registro.Id_puesto = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
            conn = New c_mysqlconn
            'conn.eliminar(proyecto, proyecto.Clave_proyecto.ToString)
            consulta()
        End If
    End Sub

    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick
        If e.RowIndex >= 0 Then
            datos.Id_puesto = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(0).Value)
            datos.Nom_puesto = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
            frmpuesto.Show()
            frmpuesto.BringToFront()
            frmpuesto.mostrar(datos)
            frmpuesto.flag = 2
        End If
    End Sub

    Private Sub frmcntapuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE PUESTOS")
        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)
    End Sub

    Private Sub grdatos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grdatos.CellFormatting

    End Sub
End Class