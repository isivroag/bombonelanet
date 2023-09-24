Imports MySql.Data.MySqlClient
Public Class frmcntainventario

    Dim conn As New c_mysqlconn
    Dim tabla As New DataTable
    Dim datos As New c_producto
    Public flag As Integer
    Public almacen As Int64



    Private Sub consulta()
        conn = New c_mysqlconn
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()

        conn.consulta(grdetalle, "SELECT id_prod,clave_prod,nom_prod,cant_prod,nom_unidad FROM vinventario WHERE id_almacen=" & sacarclave(calmacen.Text) & " and cant_prod>=1 and estado_prod=1 order by id_prod")

        formatogrid()
    End Sub

    Private Sub formatogrid()

        grdetalle.Columns(0).HeaderText = "ID PROD"
        grdetalle.Columns(1).HeaderText = "CLAVE PROD"
        grdetalle.Columns(2).HeaderText = "DESCRIPCION"
        grdetalle.Columns(3).HeaderText = "CANTIDAD"
        grdetalle.Columns(4).HeaderText = "UNIDAD"


        grdetalle.AutoResizeColumns()
        'grdetalle.Columns(3).Width = 200
        'grdetalle.Columns(2).Width = 70


        'grdetalle.Columns(0).Visible = False
        'grdetalle.Columns(1).Visible = False
        'grdetalle.Columns(7).Visible = False

    End Sub
    Private Sub combo()


        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from almacen where estado_almacen=1 order by id_almacen")
        calmacen.Items.Clear()
        For Each row As DataRow In tabla.Rows
            calmacen.Items.Add(row("id_almacen") & " " & row("nom_almacen"))
        Next row
    End Sub
    Private Sub frmcntainventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE INVENTARIO")
        combo()
    End Sub

    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        ExportarDatosExcel2(grdetalle, "REPORTE DE INVENTARIOS DEL ALMACEN " & contenido(calmacen.Text) & " AL " & Format(Date.Now, "yyyy-MM-dd"))
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (Len(calmacen.Text) > 0) Then
            consulta()

        End If



    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
End Class