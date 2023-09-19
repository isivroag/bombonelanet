Imports MySql.Data.MySqlClient
Public Class frmcntaprodbodega
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_paquete
    Dim tabla As New DataTable
    Public flag As Integer
    Dim color As Integer
    Public almacen As Integer
    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select id_prod,clave_prod,nom_prod,nom_marca,costo_prod,cant_prod,nom_unidad,id_almacen,nom_almacen from vinventario where id_almacen='" & almacen & "' and cant_prod>0 order by id_prod")

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
                conn.consulta(grdatos, "Select * from vinventario where id_prod='" & tnombre.Text & "' order by id_prod")
            Case "CLAVE"
                conn.consulta(grdatos, "Select * from vinventario where clave_prod like '%" & tnombre.Text & "%' order by id_prod")
            Case "NOMBRE"
                conn.consulta(grdatos, "Select * from vinventario where nom_prod like '%" & tnombre.Text & "%' order by id_prod")
            Case "PRECIO"
                conn.consulta(grdatos, "Select * from vinventario where precio_prod='" & tnombre.Text & "' order by id_prod")
            Case "EXISTENCIA"
                conn.consulta(grdatos, "Select * from vinventario where cant_prod='" & tnombre.Text & "' order by id_prod")
            Case "MARCA"
                conn.consulta(grdatos, "Select * from vinventario where nom_marca like '%" & tnombre.Text & "%' order by id_prod")
            Case "TODOS"
                conn.consulta(grdatos, "Select * from vinventario where estado_prod=1 order by id_prod")
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


        conn.consultadinamica(grdatos, "Select id_prod,clave_prod,nom_prod,nom_marca,costo_prod,cant_prod,nom_unidad,id_almacen,nom_almacen from vinventario where id_almacen='" & almacen & "' and cant_prod>0 And (clave_prod like '%" & tnombre.Text & "%' or" &
                              " id_prod like '%" & tnombre.Text & "%' or nom_marca like '%" & tnombre.Text & "%' or nom_prod like '%" & tnombre.Text & "%' or costo_prod like '%" & tnombre.Text & "%' ) order by id_prod")

        ' If grdatos.RowCount > 0 Then
        formatogrid()
        ' End If

    End Sub


    Private Sub formatogrid()
        DoubleBuffered = True

        grdatos.Columns(0).HeaderText = "ID PROD"
        grdatos.Columns(1).HeaderText = "CLAVE"
        grdatos.Columns(2).HeaderText = "CONCEPTO"
        'CAMBIO ACTUALIZACION

        grdatos.Columns(3).HeaderText = "MARCA"

        grdatos.Columns(4).HeaderText = "COSTO"
        grdatos.Columns(5).HeaderText = "EXISTENCIAS"

        grdatos.Columns(6).HeaderText = "UNIDAD"
        grdatos.Columns(7).HeaderText = "ID ALMACEN"
        grdatos.Columns(8).HeaderText = "ALMACEN"



        grdatos.AutoResizeColumns()
        grdatos.Columns(3).Width = 250

        grdatos.Columns(7).Visible = False


    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick

        Dim registro As New c_transfer_detalle
        Dim existencias As Double

        registro.Id_prod = Convert.ToInt64(grdatos.CurrentRow().Cells(0).Value)
        registro.Clave_prod = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        registro.Concepto = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        registro.Unidad = Convert.ToString(grdatos.CurrentRow().Cells(6).Value)
        'CAMBIO ACTUALIZACION


        registro.Costo = Convert.ToDouble(grdatos.CurrentRow().Cells(4).Value)
        existencias = Convert.ToDouble(grdatos.CurrentRow().Cells(5).Value)









        frmauxbodega.Show()
        frmauxbodega.almacen = almacen
        frmauxbodega.bproducto(registro, existencias)
        Dispose()



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

        consultatxt2()

    End Sub
    Private Sub frmcntaprodbodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE PRODUCTOS")

        ExtendedMethods.DoubleBuffered(grdatos, True)



        color = 0
    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub
End Class