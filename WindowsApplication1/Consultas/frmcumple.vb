Imports MySql.Data.MySqlClient
Public Class frmcumple
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Public folio As String
    Dim mes As Int32
    Public sql As String

    Public Sub consulta()
        conn = New c_mysqlconn
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()
        conn.consulta(grdetalle, "SELECT nom_clie,nac_clie,correo_clie,tel_clie,ws_clie FROM wcliente where month(nac_clie)='" & sacarclave(cmes.Text) & "' order by nac_clie,nom_clie")
        formatogrid()

    End Sub
    Private Sub formatogrid()

        grdetalle.Columns(0).HeaderText = "NOMBRE"
        grdetalle.Columns(1).HeaderText = "FECHA NAC"

        grdetalle.Columns(2).HeaderText = "CORREO"
        grdetalle.Columns(3).HeaderText = "TELEFONO"
        grdetalle.Columns(4).HeaderText = "WHATSAPP"

        grdetalle.AutoResizeColumns()
        grdetalle.Columns(0).Width = 300
        grdetalle.Columns(2).Width = 150
        grdetalle.Columns(3).Width = 150
        grdetalle.Columns(4).Width = 150


    End Sub
    Private Sub frmcumple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "LISTADO DE CUMPLEAÑEROS")
        Dim fecha As DateTime = DateTime.Now
        Select Case fecha.Month
            Case 1
                cmes.Text = "1 ENERO"
            Case 2
                cmes.Text = "2 FEBRERO"
            Case 3
                cmes.Text = "3 MARZO"
            Case 4
                cmes.Text = "4 ABRIL"
            Case 5
                cmes.Text = "5 MAYO"
            Case 6
                cmes.Text = "6 JUNIO"
            Case 7
                cmes.Text = "7 JULIO"
            Case 8
                cmes.Text = "8 AGOSTO"
            Case 9
                cmes.Text = "9 SEPTIEMBRE"
            Case 10
                cmes.Text = "10 OCTUBRE"
            Case 11
                cmes.Text = "11 NOVIEMBRE"
            Case 12
                cmes.Text = "12 DICIEMBRE"
        End Select
        consulta()

    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()

    End Sub

    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        ExportarDatosExcel2(grdetalle, "LISTADO DE CUMPLEAÑEROS DEL MES DE " & contenido(cmes.Text))
    End Sub

    Private Sub bbuscar_Click(sender As Object, e As EventArgs) Handles bbuscar.Click
        consulta()

    End Sub
End Class