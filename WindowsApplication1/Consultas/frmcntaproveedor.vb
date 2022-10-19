Imports MySql.Data.MySqlClient
Public Class frmcntaproveedor
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_proveedor
    Dim tabla As New DataTable
    Public flag As Integer
    Dim color As Integer

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from proveedor where estado_prov =1 order by id_prov")
        formatogrid()
    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "CLAVE"
        grdatos.Columns(1).HeaderText = "RFC"
        grdatos.Columns(2).HeaderText = "NOMBRE"
        grdatos.Columns(3).HeaderText = "DIRECCION"
        grdatos.Columns(4).HeaderText = "TEL"
        grdatos.Columns(5).HeaderText = "CEL"
        grdatos.Columns(6).HeaderText = "CORREO"
        grdatos.Columns(7).HeaderText = "ESTADO"

        grdatos.AutoResizeColumns()
        grdatos.Columns(7).Visible = False



    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmproveedor.Show()
        frmproveedor.flag = 1
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick

        Dim registro As New c_proveedor


        registro.Id_prov = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
        registro.Rfc = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
        registro.Nom_prov = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
        registro.Direccion = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(3).Value)
        registro.Tel = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value)
        registro.Cel = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(5).Value)
        registro.Correo = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(6).Value)






        Select Case flag
            Case 1
                'frmcliente.MdiParent = frmprincipal
                frmproveedor.Show()
                frmproveedor.mostrar(registro)
                frmproveedor.flag = 2

            Case 2

                frmegresos.id_prov = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmegresos.buscarproveedor()
                Dispose()
            Case 3

                Dispose()
            Case 4

                Dispose()
        End Select

    End Sub
    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click
        Dim registro As New c_proveedor

        registro.Id_prov = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
        registro.Rfc = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        registro.Nom_prov = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        registro.Direccion = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)
        registro.Tel = Convert.ToString(grdatos.CurrentRow().Cells(4).Value)
        registro.Cel = Convert.ToString(grdatos.CurrentRow().Cells(5).Value)
        registro.Correo = Convert.ToString(grdatos.CurrentRow().Cells(6).Value)






        'frmcliente.MdiParent = frmprincipal
        frmproveedor.Show()
        frmproveedor.mostrar(registro)
        frmproveedor.flag = 2

    End Sub
    Private Sub frmcntaproveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE PROVEEDORES")
        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)
        color = 0
    End Sub

    Private Sub tnombre_TextChanged(sender As Object, e As EventArgs) Handles tnombre.TextChanged
        If Color = 0 Then
            tnombre.ForeColor = SystemColors.InactiveCaption

        Else

            tnombre.ForeColor = Drawing.Color.Black

        End If
    End Sub
    Private Sub tnombre_GotFocus(sender As Object, e As EventArgs) Handles tnombre.GotFocus
        tnombre.Text = ""
        tnombre.ForeColor = Drawing.Color.Black
        color = 1
    End Sub
    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs) Handles tnombre.LostFocus
        If Len(tnombre.Text) = 0 Then

            tnombre.Text = "INTRODUZCA EL VALOR BUSCADO"
            tnombre.ForeColor = SystemColors.InactiveCaption
            Color = 0
        Else
            Color = 1

        End If
    End Sub

    Private Sub bbuscar_Click(sender As Object, e As EventArgs) Handles bbuscar.Click

        consultatxt()


    End Sub

    Public Sub consultatxt()
        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()
        conn = New c_mysqlconn
        If tnombre.Text = "INTRODUZCA EL VALOR BUSCADO" Then
            tnombre.Text = ""
        End If


        Select Case ccampo.Text
            Case "ID"
                conn.consulta(grdatos, "Select * from proveedor where estado_prov=1 And id_prov='" & tnombre.Text & "' order by id_prov")
            Case "NOMBRE"
                conn.consulta(grdatos, "Select * from proveedor where estado_prov=1 And nom_prov like '%" & tnombre.Text & "%' order by id_prov")
            Case "RFC"
                conn.consulta(grdatos, "Select * from proveedor where estado_prov=1 And rfc like '%" & tnombre.Text & "%' order by id_prov")
            Case "TODOS"
                conn.consulta(grdatos, "Select * from proveedor where estado_prov=1 order by id_prov")
        End Select

        If grdatos.RowCount > 0 Then
            formatogrid()
        End If

    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub
End Class