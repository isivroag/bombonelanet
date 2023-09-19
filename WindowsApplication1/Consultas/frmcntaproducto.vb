Imports MySql.Data.MySqlClient

Public Class frmcntaproducto
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_paquete
    Dim tabla As New DataTable
    Public flag As Integer
    Dim color As Integer
    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from producto where estado_prod=1 order by id_prod")

        formatogrid()
    End Sub

    Public Sub consultavendible()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from producto where estado_prod=1 and vendible_prod=1 order by id_prod")

        formatogrid()
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
                conn.consulta(grdatos, "Select * from producto where estado_prod=1 And id_prod='" & tnombre.Text & "' order by id_prod")
            Case "CLAVE"
                conn.consulta(grdatos, "Select * from producto where estado_prod=1 And clave_prod like '%" & tnombre.Text & "%' order by id_prod")
            Case "NOMBRE"
                conn.consulta(grdatos, "Select * from producto where estado_prod=1 And nom_prod like '%" & tnombre.Text & "%' order by id_prod")
            Case "PRECIO"
                conn.consulta(grdatos, "Select * from producto where estado_prod=1 And precio_prod='" & tnombre.Text & "' order by id_prod")
            Case "EXISTENCIA"
                conn.consulta(grdatos, "Select * from producto where estado_prod=1 And cant_prod='" & tnombre.Text & "' order by id_prod")
            Case "MARCA"
                conn.consulta(grdatos, "Select * from producto where estado_prod=1 And nom_marca like '%" & tnombre.Text & "%' order by id_prod")
            Case "TODOS"
                conn.consulta(grdatos, "Select * from producto where estado_prod=1 order by id_prod")
        End Select

        If grdatos.RowCount > 0 Then
            formatogrid()
        End If

    End Sub

    Public Sub consultavendibletxt()
        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()
        conn = New c_mysqlconn

        Select Case ccampo.Text
            Case "ID"
                conn.consulta(grdatos, "Select * from producto where estado_prod=1 and vendible_prod=1 And id_prod='" & tnombre.Text & "' order by id_prod")
            Case "CLAVE"
                conn.consulta(grdatos, "Select * from producto where estado_prod=1 and vendible_prod=1 And clave_prod like '%" & tnombre.Text & "%' order by id_prod")
            Case "NOMBRE"
                conn.consulta(grdatos, "Select * from producto where estado_prod=1 and vendible_prod=1 And nom_prod like '%" & tnombre.Text & "%' order by id_prod")
            Case "PRECIO"
                conn.consulta(grdatos, "Select * from producto where estado_prod=1 and vendible_prod=1 And precio_prod='" & tnombre.Text & "' order by id_prod")
            Case "EXISTENCIA"
                conn.consulta(grdatos, "Select * from producto where estado_prod=1 and vendible_prod=1 And cant_prod='" & tnombre.Text & "' order by id_prod")
            Case "MARCA"
                conn.consulta(grdatos, "Select * from producto where estado_prod=1 And vendible_prod=1 and nom_marca like '%" & tnombre.Text & "%' order by id_prod")
            Case "TODOS"
                conn.consulta(grdatos, "Select * from producto where estado_prod=1 And vendible_prod=1 order by id_prod")

        End Select
        If grdatos.RowCount > 0 Then
            formatogrid()
        End If


    End Sub

    Public Sub consultatxt2()
        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()
        conn = New c_mysqlconn
        If tnombre.Text = "INTRODUZCA EL VALOR BUSCADO" Then
            tnombre.Text = ""
        End If


        conn.consultadinamica(grdatos, "Select * from producto where estado_prod=1 And (clave_prod like '%" & tnombre.Text & "%' or" &
                              " id_prod like '%" & tnombre.Text & "%' or nom_marca like '%" & tnombre.Text & "%' or nom_prod like '%" & tnombre.Text & "%' or precio_prod like '%" & tnombre.Text & "%' ) order by id_prod")

        ' If grdatos.RowCount > 0 Then
        formatogrid()
        ' End If

    End Sub

    Public Sub consultavendibletxt2()
        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()
        conn = New c_mysqlconn


        conn.consultadinamica(grdatos, "Select * from producto where estado_prod=1 and vendible_prod=1 And (clave_prod like '%" & tnombre.Text & "%' or" &
                              " id_prod like '%" & tnombre.Text & "%' or nom_marca like '%" & tnombre.Text & "%' or nom_prod like '%" & tnombre.Text & "%' or precio_prod like '%" & tnombre.Text & "%' ) order by id_prod")

        '  If grdatos.RowCount > 0 Then
        formatogrid()
        '  End If


    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID PROD"
        grdatos.Columns(1).HeaderText = "CLAVE"
        grdatos.Columns(2).HeaderText = "DESCRIPCION"
        'CAMBIO ACTUALIZACION

        grdatos.Columns(3).HeaderText = "MARCA"

        grdatos.Columns(4).HeaderText = "PRECIO"
        grdatos.Columns(5).HeaderText = "EXISTENCIAS"
        grdatos.Columns(6).HeaderText = "MINIMO"
        grdatos.Columns(7).HeaderText = "UNIDAD"
        grdatos.Columns(8).HeaderText = "ESTADO"
        grdatos.Columns(9).HeaderText = "VENDIBLE"
        grdatos.Columns(10).HeaderText = "COSTO"

        grdatos.AutoResizeColumns()
        grdatos.Columns(2).Width = 250
        grdatos.Columns(8).Visible = False


    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmproducto.Show()
        frmproducto.flag = 1
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick

        Dim registro As New c_producto


        registro.Id_prod = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
        registro.Clave_prod = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        registro.Nom_prod = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        'CAMBIO ACTUALIZACION
        registro.nom_marca = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)

        registro.Precio_prod = Convert.ToDouble(grdatos.CurrentRow().Cells(4).Value)
        registro.Cant_prod = Convert.ToDouble(grdatos.CurrentRow().Cells(5).Value)
        registro.Min_prod = Convert.ToDouble(grdatos.CurrentRow().Cells(6).Value)
        registro.Unidad_prod = Convert.ToString(grdatos.CurrentRow().Cells(7).Value)
        registro.Estado_prod = Convert.ToBoolean(grdatos.CurrentRow().Cells(8).Value)
        registro.Vendible_prod = Convert.ToBoolean(grdatos.CurrentRow().Cells(9).Value)
        registro.Costo_prod = Convert.ToDouble(grdatos.CurrentRow().Cells(10).Value)






        Select Case flag
            Case 1
                'frmcliente.MdiParent = frmprincipal
                frmproducto.Show()
                frmproducto.mostrar(registro)
                frmproducto.flag = 2

            Case 2
                frminventario.mostrarp(registro)

                Dispose()
            Case 3
                frmauxcobranza.Show()
                frmauxcobranza.bproducto(registro)
                Dispose()
            Case 4

                Dispose()
        End Select

    End Sub
    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click
        Dim registro As New c_producto

        registro.Id_prod = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
        registro.Clave_prod = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        registro.Nom_prod = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        'CAMBIO ACTUALIZACION
        registro.Nom_marca = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)

        registro.Precio_prod = Convert.ToDouble(grdatos.CurrentRow().Cells(4).Value)
        registro.Cant_prod = Convert.ToDouble(grdatos.CurrentRow().Cells(5).Value)
        registro.Min_prod = Convert.ToDouble(grdatos.CurrentRow().Cells(6).Value)
        registro.Unidad_prod = Convert.ToString(grdatos.CurrentRow().Cells(7).Value)
        registro.Estado_prod = Convert.ToBoolean(grdatos.CurrentRow().Cells(8).Value)
        registro.Vendible_prod = Convert.ToBoolean(grdatos.CurrentRow().Cells(9).Value)
        registro.Costo_prod = Convert.ToDouble(grdatos.CurrentRow().Cells(10).Value)

        frmproducto.Show()
        frmproducto.mostrar(registro)
        frmproducto.flag = 2


    End Sub

    Private Sub frmcntaproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE PRODUCTOS")

        ExtendedMethods.DoubleBuffered(grdatos, True)
        If flag <> 3 Then
            consulta()
        Else
            consultavendible()
        End If
        color = 0

        If globalrol = 1 Then
            For Each men As ToolStripButton In menuclientes.Items
                If men.Name = "mncSALIR" Then
                    men.Visible = True
                Else
                    men.Visible = False
                End If
            Next
        End If
    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub

    Private Sub tnombre_TextChanged(sender As Object, e As EventArgs) Handles tnombre.TextChanged
        If color = 0 Then
            tnombre.ForeColor = SystemColors.InactiveCaption

        Else

            tnombre.ForeColor = Drawing.Color.Black

        End If
    End Sub

    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs) Handles tnombre.LostFocus
        If Len(tnombre.Text) = 0 Then

            tnombre.Text = "INTRODUZCA EL VALOR BUSCADO"
            tnombre.ForeColor = SystemColors.InactiveCaption
            color = 0
        Else
            color = 1

        End If
    End Sub

    Private Sub tnombre_GotFocus(sender As Object, e As EventArgs) Handles tnombre.GotFocus
        If tnombre.Text = "INTRODUZCA EL VALOR BUSCADO" Then
            tnombre.Text = ""
            tnombre.ForeColor = Drawing.Color.Black
            color = 1
        End If

    End Sub

    Private Sub bbuscar_Click(sender As Object, e As EventArgs) Handles bbuscar.Click
        If flag <> 3 Then
            consultatxt2()
        Else
            consultavendibletxt2()
        End If
    End Sub

    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        ExportarDatosExcel2(grdatos, "CATALOGO DE PRODUCTOS")
    End Sub

    Private Sub mncELIMINAR_Click(sender As Object, e As EventArgs) Handles mncELIMINAR.Click
        If MsgBox("DESEA ELIMINAR ESTE REGISTRO", vbYesNo + vbQuestion, "ELIMINAR") = vbYes Then
            Dim clave As String
            clave = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
            conn = New c_mysqlconn
            If conn.eliminarprod(clave) = True Then

                MsgBox("REGISTRO ELIMINADO", vbInformation + vbOKOnly, "ELIMINAR")
                If flag <> 3 Then
                    consulta()
                Else
                    consultavendible()
                End If
            End If

        End If
    End Sub

    Private Sub mncinventario_Click(sender As Object, e As EventArgs) Handles mncinventario.Click
        Dim registro As New c_producto

        registro.Id_prod = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
        registro.Clave_prod = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        registro.Nom_prod = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        'CAMBIO ACTUALIZACION
        registro.Nom_marca = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)

        registro.Precio_prod = Convert.ToDouble(grdatos.CurrentRow().Cells(4).Value)
        registro.Cant_prod = Convert.ToDouble(grdatos.CurrentRow().Cells(5).Value)
        registro.Min_prod = Convert.ToDouble(grdatos.CurrentRow().Cells(6).Value)
        registro.Unidad_prod = Convert.ToString(grdatos.CurrentRow().Cells(7).Value)
        registro.Estado_prod = Convert.ToBoolean(grdatos.CurrentRow().Cells(8).Value)
        registro.Vendible_prod = Convert.ToBoolean(grdatos.CurrentRow().Cells(9).Value)
        registro.Costo_prod = Convert.ToDouble(grdatos.CurrentRow().Cells(10).Value)

        frminventario.Show()
        frminventario.mostrarp(registro)


    End Sub

    Private Sub tnombre_MouseClick(sender As Object, e As MouseEventArgs) Handles tnombre.MouseClick

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles mncVerificar.Click
        frmcntainventarioprod.Show()
        frmcntainventarioprod.BringToFront()


    End Sub
End Class


