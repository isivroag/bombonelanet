Imports MySql.Data.MySqlClient
Public Class frmrptcaja
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Public fecha As DateTime
    Public sql As String
    Dim caja As New c_caja
    Dim montoini As Double
    Dim efectivo As Double
    Dim tcredito As Double
    Dim tdebito As Double
    Dim amex As Double
    Dim deposito As Double
    Dim otro As Double
    Dim transfer As Double
    Dim ingreso As Double
    Dim flujobruto As Double
    Dim gasto As Double
    Dim retiro As Double
    Dim flujoneto As Double
    Dim idcaja As Int64
    Dim opc As Int32

    Public Sub consulta()

        sql = "select * from caja where fecha='" & Format(fecha, "yyyy-MM-dd") & "'and estado_caja<>0"
        tabla = New DataTable
        conn = New c_mysqlconn
        tabla = conn.consulta(sql)

        If tabla.Rows.Count = 0 Then
            MsgBox("NO EXISTE INFORMACION DE CAJA PARA ESTA FECHA", vbCritical + vbOKOnly, "REPORTE DE CAJA")
            montoini = 0
            opc = 1
            idcaja = 0

        Else
            montoini = tabla.Rows(0).Item("inicial")
            idcaja = tabla.Rows(0).Item("id_caja")
            opc = 2
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

        sql = "select sum(monto) as monto from vpagometodo where fecha='" & Format(fecha, "yyyy-MM-dd") & "' and id_metodo='02' group by fecha "
        tabla = New DataTable
        conn = New c_mysqlconn
        tabla = conn.consulta(sql)

        If tabla.Rows.Count = 0 Then
            deposito = 0
        Else
            deposito = tabla.Rows(0).Item("monto")
        End If


        sql = "select sum(monto) as monto from vpagometodo where fecha='" & Format(fecha, "yyyy-MM-dd") & "' and id_metodo='03' group by fecha "
        tabla = New DataTable
        conn = New c_mysqlconn
        tabla = conn.consulta(sql)

        If tabla.Rows.Count = 0 Then
            transfer = 0
        Else
            transfer = tabla.Rows(0).Item("monto")
        End If

        sql = "select sum(monto) as monto from vpagometodo where fecha='" & Format(fecha, "yyyy-MM-dd") & "' and id_metodo='04' group by fecha "
        tabla = New DataTable
        conn = New c_mysqlconn
        tabla = conn.consulta(sql)

        If tabla.Rows.Count = 0 Then
            tcredito = 0
        Else
            tcredito = tabla.Rows(0).Item("monto")
        End If

        sql = "select sum(monto) as monto from vpagometodo where fecha='" & Format(fecha, "yyyy-MM-dd") & "' and id_metodo='28' group by fecha "
        tabla = New DataTable
        conn = New c_mysqlconn
        tabla = conn.consulta(sql)

        If tabla.Rows.Count = 0 Then
            tdebito = 0
        Else
            tdebito = tabla.Rows(0).Item("monto")
        End If

        sql = "select sum(monto) as monto from vpagometodo where fecha='" & Format(fecha, "yyyy-MM-dd") & "' and id_metodo='98' group by fecha "
        tabla = New DataTable
        conn = New c_mysqlconn
        tabla = conn.consulta(sql)

        If tabla.Rows.Count = 0 Then
            amex = 0
        Else
            amex = tabla.Rows(0).Item("monto")
        End If

        sql = "select sum(monto) as monto from vpagometodo where fecha='" & Format(fecha, "yyyy-MM-dd") & "' and id_metodo='99' group by fecha "
        tabla = New DataTable
        conn = New c_mysqlconn
        tabla = conn.consulta(sql)

        If tabla.Rows.Count = 0 Then
            otro = 0
        Else
            otro = tabla.Rows(0).Item("monto")
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

        ingreso = efectivo + otro + transfer + tcredito + tdebito + amex + deposito
        flujobruto = efectivo + montoini

        flujoneto = flujobruto - (gasto + retiro)
        ttdebito.Text = tdebito
        ttcredito.Text = tcredito
        tdeposito.Text = deposito
        ttransfer.Text = transfer
        tamex.Text = amex

        tinicial.Text = montoini
        tefectivo.Text = efectivo
        tingresos.Text = ingreso
        tflujobruto.Text = flujobruto
        totros.Text = otro
        tgastos.Text = gasto
        tretiros.Text = retiro
        tflujoneto.Text = flujoneto

    End Sub
    Private Sub frmrptcaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        inicial(sender, e, "REPORTE DE CAJA")
        dtFecha.Value = Format(Now, "yyyy-MM-dd")
        fecha = (New Date(dtFecha.Value.Year, dtFecha.Value.Month, dtFecha.Value.Day, 0, 0, 0))
        'consulta()
    End Sub


    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()


    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        conn = New c_mysqlconn

        caja = New c_caja
        caja.Id_caja = idcaja
        caja.Inicial = CDbl(tinicial.Text())
        caja.Fecha = Format(dtFecha.Value, "yyyy-MM-dd")

        caja.Efectivo = CDbl(tefectivo.Text())
        caja.Deposito = CDbl(tdeposito.Text())
        caja.Tcredito = CDbl(ttcredito.Text())
        caja.Tdebito = CDbl(ttdebito.Text())
        caja.Transferencia = CDbl(ttransfer.Text())
        caja.Amex = CDbl(tamex.Text())
        caja.Otros = CDbl(totros.Text())
        caja.Gastos = CDbl(tgastos.Text())
        caja.Retiros = CDbl(tretiros.Text())
        caja.Final = CDbl(tflujoneto.Text())


        If opc = 2 Then
            If (MsgBox("YA EXISTEN DATOS PARA ESTE DIA" + Environment.NewLine + "¿DESEA MODIFICARLOS?", vbQuestion + vbYesNo, "REPORTE DE CAJA") = vbYes) Then
                If conn.actualizarcaja(caja) Then
                    MsgBox("CAJA ACTUALIZADA", vbInformation + vbOKOnly, "REPORTE DE CAJA")
                Else
                    MsgBox("CAJA NO ACTUALIZADA", vbCritical + vbOKOnly, "REPORTE DE CAJA")
                End If
            End If

        Else





            If conn.insertarnuevo(caja) Then
                MsgBox("CAJA REGISTRADA", vbInformation + vbOKOnly, "REPORTE DE CAJA")
            Else
                MsgBox("CAJA NO REGISTRADO", vbCritical + vbOKOnly, "REPORTE DE CAJA")
            End If
        End If

    End Sub

    Private Sub bretiro_Click(sender As Object, e As EventArgs) Handles bretiro.Click
        frmretiro.ShowDialog()
        frmretiro.dtFecha.Value = dtFecha.Value
        frmretiro.BringToFront()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        imprimir()

    End Sub

    Private Sub imprimir()
        'frmrepo.nombre = "CHEJERE.RptTicket.rdlc"
        'frmrepo.folio_cob = folio_cob

        '  frmrepo.Show()
        ' frmrepo.ticket()



        Dim x As New frmreportecaja
        x.folio = idcaja
        x.caja()

        x.ShowDialog()



    End Sub

    Private Sub dtFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtFecha.ValueChanged
        fecha = (New Date(dtFecha.Value.Year, dtFecha.Value.Month, dtFecha.Value.Day, 0, 0, 0))
        consulta()
    End Sub

    Private Sub dtFecha_Click(sender As Object, e As EventArgs) Handles dtFecha.Click

    End Sub

    Private Sub dtFecha_LostFocus(sender As Object, e As EventArgs) Handles dtFecha.LostFocus

    End Sub

    Private Sub ttransfer_TextChanged(sender As Object, e As EventArgs) Handles ttransfer.TextChanged

    End Sub
End Class