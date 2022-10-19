Imports MySql.Data.MySqlClient
Public Class frmkardex
    Dim conn As New c_mysqlconn
    Dim texto As String
    Public producto As New c_producto
    Public medida As String
    Public movimiento As New c_movimiento
    Public almacen As Int64
    Dim tabla As New DataTable
    Dim inventario As Double

    Private Sub combo()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from almacen where estado_almacen=1 order by id_almacen")
        calmacen.Items.Clear()
        'calmacen.Items.Add("TODOS")
        For Each row As DataRow In tabla.Rows
            calmacen.Items.Add(row("id_almacen") & " " & row("nom_almacen"))
        Next row
    End Sub
    Public Sub consulta()
        grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select movimiento.id_tipomov,tipomov.tipomov,movimiento.fecha_mov,movimiento.ini_mov,movimiento.cant_mov,movimiento.unidad_mov," &
                          "movimiento.fin_mov,movimiento.obs_mov from movimiento join tipomov on movimiento.id_tipomov=tipomov.id_tipomov where movimiento.id_prod='" _
                          & producto.Id_prod.ToString & "' and movimiento.id_almacen='" & almacen.ToString & "' order by movimiento.id_mov")
        conn = New c_mysqlconn

        inventario = conn.Obtener_dato("select cant_prod as dato from inventario where id_prod='" & producto.Id_prod & "' and id_almacen='" & almacen.ToString & "'")
        tcant.Text = inventario
        formatogrid()
    End Sub

    Public Sub mostrarp(ByVal dato As c_producto)
        producto = dato
        tid.Text = dato.Id_prod
        tclave.Text = dato.Clave_prod
        tnombre.Text = dato.Nom_prod


        lmedida.Text = dato.Unidad_prod
        ' consulta()

    End Sub
    Private Sub formatogrid()

        grdatos.Columns(0).HeaderText = "ID_TIPOMOV"
        grdatos.Columns(1).HeaderText = "TIPO"
        grdatos.Columns(2).HeaderText = "FECHA"

        grdatos.Columns(3).HeaderText = "INV INI"
        grdatos.Columns(4).HeaderText = "CANTIDAD"
        grdatos.Columns(5).HeaderText = "UNIDAD"
        grdatos.Columns(6).HeaderText = "INV FIN"
        grdatos.Columns(7).HeaderText = "OBSERVACIONES"

        grdatos.AutoResizeColumns()
        'grdatos.Columns(0).Width = 50
        'grdatos.Columns(1).Width = 300
        grdatos.Columns(0).Visible = False
        grdatos.Columns(5).Visible = False


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        almacen = sacarclave(calmacen.Text)
        consulta()

    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmauxinventario.Show()
        frmauxinventario.mostrar(producto)
        frmauxinventario.almacen = sacarclave(calmacen.Text)
        frmauxinventario.calmacen.Text = calmacen.Text
        frmauxinventario.buscar()
        'frmauxinventario.lmedida.Text = producto.Unidad_prod.ToString
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        ExportarDatosExcel2(grdatos, "MOVIMIENTOS DE INVENTARIO DE " & tnombre.Text)
    End Sub
    Private Sub frmkardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "KARDEX DE PRODUCTO")
        ExtendedMethods.DoubleBuffered(grdatos, True)
        combo()
    End Sub
End Class