Imports MySql.Data.MySqlClient
Public Class frmcntacabina
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_cabina
    Dim tabla As New DataTable
    Public flag As Integer

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from cabina order by id_cabina")
        formatogrid()
    End Sub
    Private Sub formatogrid()

        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID"
        grdatos.Columns(1).HeaderText = "CABINA"
        grdatos.Columns(2).HeaderText = "COLOR"
        grdatos.Columns(3).HeaderText = "ESTADO"

        grdatos.AutoResizeColumns()

        grdatos.Columns(2).Visible = False
        grdatos.Columns(3).Visible = False


    End Sub


    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmcabina.Show()
        frmcabina.BringToFront()
        frmcabina.flag = 1
    End Sub

    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click

        datos.Id_cabina = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
        datos.Nom_cabina = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        datos.Color_cabina = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)



        frmcabina.Show()
        frmcabina.BringToFront()
        frmcabina.mostrar(datos)
        frmcabina.flag = 2
    End Sub

    Private Sub mncELIMINAR_Click(sender As Object, e As EventArgs) Handles mncELIMINAR.Click
        If MsgBox("Desea Eliminar Este Puesto", vbYesNo + vbQuestion,) = vbYes Then
            Dim registro As New c_cabina
            registro.Id_cabina = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
            conn = New c_mysqlconn
            'conn.eliminar(proyecto, proyecto.Clave_proyecto.ToString)
            consulta()
        End If
    End Sub

    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick
        If e.RowIndex >= 0 Then
            datos.Id_cabina = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(0).Value)
            datos.Nom_cabina = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
            datos.Color_cabina = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
            frmcabina.Show()
            frmcabina.BringToFront()
            frmcabina.mostrar(datos)
            frmcabina.flag = 2
        End If
    End Sub

    Private Sub grdatos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grdatos.CellFormatting


        Dim row As DataGridViewRow = grdatos.Rows(e.RowIndex)
        If Convert.ToString(row.Cells(2).Value) <> "" Then

            row.DefaultCellStyle.BackColor = Color.FromArgb(row.Cells(2).Value)

        End If


    End Sub
    Private Sub frmcntacabina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE AREAS")
        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)
    End Sub

    Private Sub mncdetalle_Click(sender As Object, e As EventArgs) Handles mncdetalle.Click
        frmdet_cabina.Show()
        frmdet_cabina.BringToFront()
        frmdet_cabina.id_cabina = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
        frmdet_cabina.cabina = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        frmdet_cabina.LCABINA.Text = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        frmdet_cabina.buscaritems()
    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub
End Class