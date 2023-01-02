Imports MySql.Data.MySqlClient

Public Class frmretiro
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Public fecha As DateTime
    Public sql As String
    Dim registro As New c_retiro
    Dim efectivo As Double
    Dim retiro As Double
    Dim montoini As Double
    Dim flujobruto As Double
    Dim gasto As Double
    Dim opc As Int32
    Dim idretiro As Int64

    Public Sub consulta()

        sql = "select * from caja where fecha='" & Format(fecha, "yyyy-MM-dd") & "'and estado_caja<>0"
        tabla = New DataTable
        conn = New c_mysqlconn
        tabla = conn.consulta(sql)

        If tabla.Rows.Count = 0 Then

            montoini = 0
        Else
            montoini = tabla.Rows(0).Item("inicial")

        End If

        sql = "select monto from vpagometodo where fecha='" & Format(fecha, "yyyy-MM-dd") & "' and id_metodo='01' "
        tabla = New DataTable
        conn = New c_mysqlconn
        tabla = conn.consulta(sql)

        If tabla.Rows.Count = 0 Then
            efectivo = 0
        Else
            efectivo = tabla.Rows(0).Item("monto")
        End If

        sql = "select sum(monto) as monto from gasto where fecha='" & Format(fecha, "yyyy-MM-dd") & "' group by fecha "
        tabla = New DataTable
        conn = New c_mysqlconn
        tabla = conn.consulta(sql)

        If tabla.Rows.Count = 0 Then
            gasto = 0
        Else
            gasto = tabla.Rows(0).Item("monto")
        End If


        sql = "select sum(monto) as monto from retiro where fecha='" & Format(fecha, "yyyy-MM-dd") & "' group by fecha "
        tabla = New DataTable
        conn = New c_mysqlconn
        tabla = conn.consulta(sql)

        If tabla.Rows.Count = 0 Then
            retiro = 0
        Else
            retiro = tabla.Rows(0).Item("monto")
        End If


        flujobruto = (efectivo + montoini) - (gasto + retiro)



        tdisponible.Text = flujobruto



    End Sub
    Private Sub frmretiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "RETIRO DE CAJA")

        fecha = (New Date(dtFecha.Value.Year, dtFecha.Value.Month, dtFecha.Value.Day, 0, 0, 0))
        consulta()
    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()


    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        conn = New c_mysqlconn


        registro = New c_retiro
        registro.Montoant = CDbl(tdisponible.Text())
        registro.Monto = CDbl(tmonto.Text())
        registro.Montodesp = CDbl(tdisponible.Text()) - CDbl(tmonto.Text())
        registro.Fecha = Format(dtFecha.Value, "yyyy-MM-dd")
        registro.Fechaop = Format(Now, "yyyy-MM-dd HH:mm:ss tt")


        If conn.insertarnuevo(registro) Then
            MsgBox("RETIRO REGISTRADO", vbInformation + vbOKOnly, "RETIRO DE CAJA")
            conn = New c_mysqlconn
            idretiro = conn.Obtener_dato("select id_retiro as dato from retiro order by id_retiro desc limit 1")
            imprimir()
            frmrptcaja.consulta()
            Dispose()
        Else
            MsgBox("RETIRO NO REGISTRADO", vbCritical + vbOKOnly, "RETIRO DE CAJA")
        End If


    End Sub

    Private Sub imprimir()

        Dim x As New frmreporteretiro
        x.folio = idretiro
        x.retiro()

        x.ShowDialog()
    End Sub
End Class