Imports MySql.Data.MySqlClient
Public Class frminventario
    Dim conn As New c_mysqlconn
    Dim texto As String
    Public producto As New c_producto
    Public medida As String
    Public movimiento As New c_movimiento
    Dim tabla As New DataTable


    Public Sub consultaprod()

        conn = New c_mysqlconn
        producto = New c_producto
        tabla = New DataTable
        tabla.Clear()
        tabla = conn.consulta("select * from producto where id_prod='" & tid.Text & "'")





        For Each row As DataRow In tabla.Rows

            producto.Id_prod = row("id_prod")
            producto.Clave_prod = row("clave_prod")
            producto.Nom_prod = row("nom_prod")
            producto.Cant_prod = row("cant_prod")
            producto.Min_prod = row("min_prod")
            producto.Precio_prod = row("precio_prod")
            producto.Unidad_prod = row("unidad_prod")

        Next


        mostrarp(producto)
        formatogrid()
    End Sub
    Public Sub consulta()
        grdatos.Columns.Clear()
        conn = New c_mysqlconn
        'conn.consulta(grdatos, "")
        conn.consulta(grdatos, "select id_almacen,nom_almacen,cant_prod,nom_unidad from vinventario where id_prod='" & producto.Id_prod.ToString & "' order by id_almacen")


        formatogrid()
    End Sub

    Public Sub mostrarp(ByVal dato As c_producto)
        producto = dato
        tid.Text = dato.Id_prod
        tclave.Text = dato.Clave_prod
        tnombre.Text = dato.Nom_prod
        tcant.Text = dato.Cant_prod
        tmin.Text = dato.Min_prod
        tprecio.Text = dato.Precio_prod
        lmedida.Text = dato.Unidad_prod
        consulta()

    End Sub
    Private Sub formatogrid()

        grdatos.Columns(0).HeaderText = "ID ALMACEN"
        grdatos.Columns(1).HeaderText = "ALMACEN"
        grdatos.Columns(2).HeaderText = "CANTIDAD"

        grdatos.Columns(3).HeaderText = "UNIDAD"


        'grdatos.AutoResizeColumns()
        grdatos.Columns(0).Width = 80
        grdatos.Columns(1).Width = 230
        grdatos.Columns(2).Width = 80
        grdatos.Columns(3).Width = 90
        'grdatos.Columns(0).Visible = False



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmcntaproducto.Show()
        frmcntaproducto.flag = 2

    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        If grdatos.CurrentRow IsNot Nothing And producto.Id_prod <> 0 Then
            frmkardex.Show()
            frmkardex.mostrarp(producto)

            frmkardex.almacen = grdatos.CurrentRow.Cells(0).Value
            frmkardex.calmacen.Text = grdatos.CurrentRow.Cells(0).Value & " " & grdatos.CurrentRow.Cells(1).Value
            frmkardex.consulta()
        Else
            MsgBox("Es necesario seleccionar un registro de almacen para mostrar los movimientos de este producto", vbInformation + vbOKOnly, "OPERACION NO PERMITIDA")
        End If

        'frmkardex.consulta()
        'frmauxinventario.lmedida.Text = producto.Unidad_prod.ToString
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        ExportarDatosExcel2(grdatos, "MOVIMIENTOS DE INVENTARIO DE " & tnombre.Text)
    End Sub
    Private Sub frminventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "INVENTARIO")
        ExtendedMethods.DoubleBuffered(grdatos, True)

    End Sub

    Private Sub mncmov_Click(sender As Object, e As EventArgs) Handles mncmov.Click
        frmauxinventario.Show()
        frmauxinventario.mostrar(producto)


    End Sub

    Private Sub mncTransferir_Click(sender As Object, e As EventArgs) Handles mncTransferir.Click
        frmtransferencia.Show()
        frmtransferencia.flag = 1
        frmtransferencia.mostrar(producto)
    End Sub
End Class