Imports MySql.Data.MySqlClient
Public Class frmpago
    Public folio_cxc As Int64
    Public total As Double
    Public saldo As Double
    Dim tabla As DataTable
    Dim conn As c_mysqlconn
    Dim pago As c_pago
    Public flagorg As Integer
    Public foliopago As Int64

    Public Sub combo()
        Dim sql As String

        sql = "SELECT id_col,nom_col FROM colaborador where estado_col='1' ORDER BY id_col "
        tabla = New DataTable
        conn = New c_mysqlconn

        ccol.Items.Clear()

        tabla = conn.consulta(sql)
        For Each row As DataRow In tabla.Rows
            ccol.Items.Add(row("id_col") & " " & row("nom_col"))
        Next

        sql = "SELECT * FROM metodo ORDER BY id_metodo "
        tabla = New DataTable
        conn = New c_mysqlconn

        cmetodo.Items.Clear()

        tabla = conn.consulta(sql)
        For Each row As DataRow In tabla.Rows
            cmetodo.Items.Add(row("id_metodo") & " " & row("nom_metodo"))
        Next

    End Sub
    Private Sub frmpago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "PAGO")
        combo()
        Me.Size = New Size(441, 445)
    End Sub
    Private Sub tmonto_TextChanged(sender As Object, e As EventArgs) Handles tmonto.TextChanged
        LLETRAS1.Text = EnLetras(sender.text)
        If cmetodo.Text <> "01 Efectivo" Then
            tpago.Text = tmonto.Text
        End If
    End Sub
    Private Sub cmetodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmetodo.SelectedIndexChanged

    End Sub

    Private Sub cmetodo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmetodo.SelectedValueChanged
        tmonto.Text = tsaldo.Text
        If cmetodo.Text = "01 Efectivo" Then


            Me.Size = New Size(441, 555)
            GEFECTIVO.Visible = True
            tpago.Text = "0.00"
        Else
            Me.Size = New Size(441, 445)

            tpago.Text = tmonto.Text
            tcambio.Text = "0.00"
            cfact.CheckState = CheckState.Checked
            GEFECTIVO.Visible = False

        End If




    End Sub

    Private Sub tpago_TextChanged(sender As Object, e As EventArgs) Handles tpago.TextChanged
        calcular()
    End Sub

    Private Sub tpago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tpago.KeyPress
        solonumeros(sender, e)
    End Sub
    Private Sub calcular()
        If Len(tpago.Text) > 0 And Len(tmonto.Text) > 0 Then
            If CDbl(tpago.Text) > CDbl(tmonto.Text) Then
                tcambio.Text = tpago.Text - tmonto.Text
            Else
                tcambio.Text = "0.00"
            End If
        Else
            tcambio.Text = "0.00"
        End If

    End Sub
    Private Sub imprimir()
        'frmrepo.nombre = "CHEJERE.RptTicket.rdlc"
        'frmrepo.folio_cob = folio_cob

        '  frmrepo.Show()
        ' frmrepo.ticket()
        Dim sucursal As String
        sucursal = My.Settings.sucursal
        Select Case (sucursal)
            Case 1
                Dim x As New frmreporte
                x.folio = foliopago
                x.CAJA()
                x.ShowDialog()
            Case 2
                Dim x As New frmreporte2
                x.folio = foliopago
                x.CAJA()
                x.ShowDialog()
            Case 3
                Dim x As New frmreporte3
                x.folio = foliopago
                x.CAJA()
                x.ShowDialog()
            Case 4
                Dim x As New frmreporte4
                x.folio = foliopago
                x.CAJA()
                x.ShowDialog()
            Case 5
                Dim x As New frmreporte5
                x.folio = foliopago
                x.CAJA()
                x.ShowDialog()
            Case 6
                Dim x As New frmreporte6
                x.folio = foliopago
                x.CAJA()
                x.ShowDialog()
            Case Else
                Dim x As New frmreporte
                x.folio = foliopago
                x.CAJA()
                x.ShowDialog()

        End Select


    End Sub
    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Len(tpago.Text) > 0 And Len(tmonto.Text) > 0 Then
            If CDbl(tpago.Text) > 0 And CDbl(tmonto.Text) > 0 Then
                If CDbl(tmonto.Text) > CDbl(tsaldo.Text) Then
                    MsgBox("NO ES POSIBLE REGISTRAR EL PAGO" & Chr(13) & "EL MONTO A PAGAR ES MAYOR AL SALDO DE LA CUENTA", vbExclamation + vbOKOnly, "PAGOS")
                    Exit Sub
                End If

                If CDbl(tpago.Text) < CDbl(tmonto.Text) Then
                    MsgBox("NO ES POSIBLE REGISTRAR EL PAGO" & Chr(13) & "EL PAGO RECIBIDO ES INFERIOR AL MONTO A PAGAR", vbExclamation + vbOKOnly, "PAGOS")
                    Exit Sub
                End If

                pago = New c_pago

                If cfact.CheckState = CheckState.Checked Then
                    conn = New c_mysqlconn
                    pago.Folio_fis = conn.Obtener_ID("select max(folio_fis) as max_id from pago")
                    pago.Folio_fis += 1
                Else
                    pago.Folio_fis = 0
                End If

                If Len(ccol.Text) = 0 Then
                    MsgBox("NO ES POSIBLE REGISTRAR EL PAGO" & Chr(13) & "DEBE ELEGIR EL COLABORADOR QUE REALIZA EL COBRO", vbExclamation + vbOKOnly, "PAGOS")
                    Exit Sub
                End If



                pago.Folio_cxc = folio_cxc
                '  tfecha.Value = (Format(tfecha.Value, "yyyy-MM-dd") + Now.TimeOfDay.ToString)
                pago.Fecha_pago = Format(tfecha.Value, "yyyy-MM-dd HH:mm:ss")
                pago.Importe_pago = CDbl(tmonto.Text)
                pago.Id_metodo = sacarclave(cmetodo.Text)
                pago.Nom_metodo = contenido(cmetodo.Text)
                pago.Dinero_pago = CDbl(tpago.Text)
                pago.Cambio_pago = CDbl(tcambio.Text)
                pago.Id_col = sacarclave(ccol.Text)
                pago.Nom_col = contenido(ccol.Text)

                pago.Tipo_pago = cfact.CheckState
                pago.Saldoini_cxc = CDbl(tsaldo.Text)

                pago.Saldofin_cxc = CDbl(tsaldo.Text) - CDbl(tmonto.Text)



                pago.Letra_pago = LLETRAS1.Text



                conn = New c_mysqlconn
                conn.nuevopago(pago)

                conn = New c_mysqlconn
                foliopago = conn.Obtener_ID("select max(folio_pago) as max_id from pago")
                tfolio.Text = foliopago

                conn = New c_mysqlconn
                conn.actualizar_saldo(folio_cxc, pago.Importe_pago, 1)

                conn = New c_mysqlconn
                Dim foliocont As Int64 = conn.Obtener_dato("select id_cont as dato from cxc where folio_cxc='" & folio_cxc & "'")

                'If foliocont <> 0 Then
                'conn = New c_mysqlconn
                ' conn.pagocontrato(foliocont, pago.Importe_pago)
                'End If

                MsgBox("PAGO REGISTRO EXITOSAMENTE", vbInformation + vbOKOnly, "PAGOS")

                    If flagorg = 2 Then

                        frmcntacuentas.consulta()

                    End If


                    imprimir()
                    'Dispose()
                    tsaldo.Text = pago.Saldofin_cxc
                    limpiar()

                Else
                    MsgBox("DEBE CAPTURAR EL MONTO DEL PAGO", vbExclamation + vbOKOnly, "CAJA")
            End If
        End If


    End Sub
    Private Sub limpiar()

        tfolio.Text = ""
        cfact.CheckState = CheckState.Unchecked
        cmetodo.Text = ""
        ccol.Text = ""
        tmonto.Text = "0.00"
        tpago.Text = "0.00"
        tcambio.Text = "0.00"

    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class