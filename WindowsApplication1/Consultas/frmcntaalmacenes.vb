Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmcntaalmacenes
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_almacen
    Dim tabla As New DataTable
    Public flag As Integer

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from almacen where estado_almacen=1 order by id_almacen")
        formatogrid()
    End Sub
    Private Sub formatogrid()

        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID"
        grdatos.Columns(1).HeaderText = "ALMACEN"
        grdatos.Columns(2).HeaderText = "ESTADO"
        grdatos.AutoResizeColumns()
        grdatos.Columns(0).Width = 50
        grdatos.Columns(1).Width = 250
        grdatos.Columns(2).Width = 100


        grdatos.Columns(2).Visible = False

    End Sub
    Private Sub frmcntaalmacenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE ALMACENES")
        ExtendedMethods.DoubleBuffered(grdatos, True)
        consulta()
    End Sub

    Private Sub bcambiar_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click
        datos.Id_almacen = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
        datos.Nom_almacen = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)


        frmalmacen.Show()
        frmalmacen.mostrar(datos)
        frmalmacen.flag = 2
    End Sub

    Private Sub bnuevo_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmalmacen.Show()
        frmalmacen.flag = 1
    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles mncELIMINAR.Click
        If MsgBox("DESEA ELIMINAR ESTE REGISTRO", vbYesNo + vbQuestion, "ELIMINAR") = vbYes Then
            Dim clave As String
            clave = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
            conn = New c_mysqlconn
            If conn.eliminar(clave, 5) = True Then
                consulta()
                MsgBox("REGISTRO ELIMINADO", vbInformation + vbOKOnly, "ELIMINAR")
            End If

        End If
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
End Class