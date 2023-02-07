Imports MySql.Data.MySqlClient
Public Class frmcntaretiros
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Dim datos As c_retiro
    Public folio As String
    Dim fechaini As DateTime
    Dim fechafin As DateTime
    Public sql As String
    Public Sub consulta()
        conn = New c_mysqlconn
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()

        conn.consulta(grdetalle, "SELECT id_retiro,fecha,monto FROM retiro where estado_retiro=1 and fecha between '" & Format(fechaini, "yyyy-MM-dd") & "' and '" & Format(fechafin, "yyyy-MM-dd") & "' order by fecha,id_retiro")

        formatogrid()

    End Sub
    Private Sub formatogrid()

        grdetalle.Columns(0).HeaderText = "FOLIO"
        grdetalle.Columns(1).HeaderText = "FECHA"

        grdetalle.Columns(2).HeaderText = "IMPORTE"



        grdetalle.AutoResizeColumns()

        'grdetalle.Columns(2).Width = 70
        grdetalle.Columns(2).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        'grdetalle.Columns(0).Visible = False
        'grdetalle.Columns(1).Visible = False
        'grdetalle.Columns(7).Visible = False

    End Sub
    Private Sub cntaretiros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE RETIROS")
        ExtendedMethods.DoubleBuffered(grdetalle, True)
        fechaini = (New Date(DtInicio.Value.Year, DtInicio.Value.Month, DtInicio.Value.Day, 0, 0, 0))
        fechafin = (New Date(DtFin.Value.Year, DtFin.Value.Month, DtFin.Value.Day, 23, 59, 59))

        consulta()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        fechaini = (New Date(DtInicio.Value.Year, DtInicio.Value.Month, DtInicio.Value.Day, 0, 0, 0))
        fechafin = (New Date(DtFin.Value.Year, DtFin.Value.Month, DtFin.Value.Day, 23, 59, 59))

        consulta()
    End Sub



    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub









    Private Sub mncELIMINAR_Click(sender As Object, e As EventArgs) Handles mncELIMINAR.Click
        If MsgBox("DESEA ELIMINAR ESTE REGISTRO", vbYesNo + vbQuestion, "ELIMINAR") = vbYes Then
            Dim clave As String
            clave = Convert.ToDouble(grdetalle.CurrentRow().Cells(0).Value)
            frmauxcancelar.Show()
            frmauxcancelar.folio = clave
            frmauxcancelar.tipo = 2
        End If
    End Sub
End Class