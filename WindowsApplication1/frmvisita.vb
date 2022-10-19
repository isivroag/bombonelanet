Imports MySql.Data.MySqlClient

Public Class frmvisita
    Dim conn As c_mysqlconn
    Dim table As DataTable
    Dim tabla As DataTable
    Public id_cita As String
    Public tipo As Integer
    Public idpersona As String
    Dim fini As DateTime
    Dim ffinal As DateTime

    Dim id_col As Int64
    Dim id_cabina As Int64
    Public foliovis As Int64
    Public flag As Integer
    Dim dia As Integer
    Public id_serv As Int64
    Public id_tipo As Integer
    Public flagorigen As Integer
    Public duracion As Integer
    Dim dispcabina As Integer
    Dim dispcol As Integer
    Dim foliocont As Int64

    Public Sub buscarcabina()
        Dim sql As String

        sql = "SELECT det_cabina.id_cabina,cabina.nom_cabina,det_cabina.id_tipo FROM det_cabina JOIN cabina ON det_cabina.id_cabina=cabina.id_cabina where det_cabina.id_tipo='" & id_tipo & "' ORDER BY det_cabina.id_cabina "
        tabla = New DataTable
        conn = New c_mysqlconn

        tcabina.Items.Clear()

        tabla = conn.consulta(sql)
        For Each row As DataRow In tabla.Rows
            tcabina.Items.Add(row("id_cabina") & " " & row("nom_cabina"))
        Next


    End Sub
    Public Sub buscarcol()
        Dim sql As String

        sql = "SELECT det_col.id_col,colaborador.nom_col,det_col.id_tipo FROM det_col JOIN colaborador ON det_col.id_col=colaborador.id_col where det_col.id_tipo='" & id_tipo & "' ORDER BY det_col.id_col "
        tabla = New DataTable
        conn = New c_mysqlconn

        tcol.Items.Clear()

        tabla = conn.consulta(sql)
        For Each row As DataRow In tabla.Rows
            tcol.Items.Add(row("id_col") & " " & row("nom_col"))
        Next


    End Sub

    Public Sub buscarvisita()
        conn = New c_mysqlconn
        table = New DataTable
        table = conn.consulta("SELECT visita.folio_vis,visita.id_clie,visita.fecha,visita.fecha_final,visita.nombre,visita.entrada,visita.salida,visita.id_cabina,cabina.nom_cabina,visita.id_serv,servicio.nom_serv,visita.id_col,colaborador.nom_col,visita.obs,visita.folio_cita " &
                                "FROM visita JOIN servicio ON visita.id_serv=servicio.id_serv JOIN cabina ON visita.id_cabina=cabina.id_cabina JOIN colaborador ON visita.id_col=colaborador.id_col" &
                                "  where visita.folio_vis='" & foliovis & "'")
        If table.Rows.Count > 0 Then
            tvis.Text = table.Rows(0).Item("folio_vis")
            tfolio.Text = table.Rows(0).Item("folio_cita")
            tclie.Text = table.Rows(0).Item("nombre")
            tserv.Text = table.Rows(0).Item("nom_serv")
            tcol.Text = table.Rows(0).Item("nom_col")
            tcabina.Text = table.Rows(0).Item("nom_cabina")
            dtfecha.Value = table.Rows(0).Item("entrada")
            chora.Text = Format(table.Rows(0).Item("fecha"), "HH:mm")
            chora2.Text = Format(table.Rows(0).Item("fecha_final"), "HH:mm")


            id_serv = table.Rows(0).Item("id_serv")
            id_col = table.Rows(0).Item("id_col")
            id_cabina = table.Rows(0).Item("id_cabina")
            tobs.Text = table.Rows(0).Item("obs")

            tid_clie.Text = table.Rows(0).Item("id_clie")

        End If

    End Sub

    Private Sub buscarcontrato()
        conn = New c_mysqlconn
        foliocont = 0
        foliocont = conn.Obtener_dato("select id_cont as dato from paquete_cont where id_clie='" & tid_clie.Text & "' and id_serv='" & id_serv & "' and restante_s> 0 and estado_serv='VIGENTE' and estado='1'")





    End Sub
    Public Sub buscarcita()
        conn = New c_mysqlconn
        table = New DataTable
        table = conn.consulta("SELECT cita.folio,cita.id_persona,cita.tipo_persona,cita.nombre,cita.fecha,cita.fecha_final,cita.id_cabina,cabina.nom_cabina,cita.id_serv,servicio.nom_serv,cita.id_col,colaborador.nom_col,cita.obs " &
                                "FROM cita JOIN servicio ON cita.id_serv=servicio.id_serv JOIN cabina ON cita.id_cabina=cabina.id_cabina JOIN colaborador ON cita.id_col=colaborador.id_col" &
                                "  where cita.folio='" & id_cita & "'")
        If table.Rows.Count > 0 Then
            tfolio.Text = table.Rows(0).Item("folio")
            tclie.Text = table.Rows(0).Item("nombre")
            tserv.Text = table.Rows(0).Item("nom_serv")
            tcol.Text = table.Rows(0).Item("nom_col")
            tcabina.Text = table.Rows(0).Item("nom_cabina")
            dtfecha.Value = table.Rows(0).Item("fecha")
            chora.Text = Format(table.Rows(0).Item("fecha"), "HH:mm")
            chora2.Text = Format(table.Rows(0).Item("fecha_final"), "HH:mm")
            tipo = table.Rows(0).Item("tipo_persona")
            idpersona = table.Rows(0).Item("id_persona")
            id_serv = table.Rows(0).Item("id_serv")
            id_col = table.Rows(0).Item("id_col")
            id_cabina = table.Rows(0).Item("id_cabina")
            tobs.Text = table.Rows(0).Item("obs")
            If tipo = 1 Then
                tid_clie.Text = table.Rows(0).Item("id_persona")
            Else
                tid_clie.Text = 0
            End If
        End If

    End Sub

    Public Sub nuevavisita()

        tfolio.Text = "S/C"
        dtfecha.Value = Now
        chora.Text = TimeValue(Now)
        chora2.Text = TimeValue(Now)
        tid_clie.Text = ""
        tclie.Text = ""
        tserv.Text = ""
        tcabina.Text = ""
        tcol.Text = ""
        tobs.Text = ""
        combohora()
    End Sub
    Private Sub chora_SelectedValueChanged(sender As Object, e As EventArgs) Handles chora.SelectedValueChanged
        chora2.Text = Format(Convert.ToDateTime(chora.Text).AddMinutes(duracion), "HH:mm")
        tcabina.Text = ""
        tcol.Text = ""
    End Sub
    Private Sub cabinadisponible()

        fini = New DateTime(dtfecha.Value.Year, dtfecha.Value.Month, dtfecha.Value.Day, Convert.ToDateTime(chora.Text).Hour, Convert.ToDateTime(chora.Text).Minute, Convert.ToDateTime(chora.Text).Second)
        ffinal = New DateTime(dtfecha.Value.Year, dtfecha.Value.Month, dtfecha.Value.Day, Convert.ToDateTime(chora2.Text).Hour, Convert.ToDateTime(chora2.Text).Minute, Convert.ToDateTime(chora2.Text).Second)

        ' tabla = conn.consulta("SELECT * FROM cita WHERE  ('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "' >= fecha AND '" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "' < fecha_final and id_cabina='" & sacarclave(ccabina.Text) & "' and estado='1') or ('" &
        ' Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "' > fecha AND '" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "'< fecha_final and id_cabina='" & sacarclave(ccabina.Text) & "' and estado='1')")
        conn = New c_mysqlconn
        tabla = New DataTable
        tabla = conn.consulta("CALL spdisp('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "','0','" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "','" & sacarclave(tcabina.Text) & "',1)")

        If tabla.Rows.Count = 0 Then

            dispcabina = 1
        Else
            MsgBox("AREA NO DISPONIBLE, PUEDE CANCERLAR CITAS PROGRAMADAS EN EL MODULO DE CALENDARIO", vbExclamation + vbOKOnly, "AREA OCUPADA")

            dispcabina = 0
            Exit Sub
        End If


        conn = New c_mysqlconn
        tabla = New DataTable
        tabla = conn.consulta("CALL spdisp('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "','0','" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "','" & sacarclave(tcabina.Text) & "',5)")

        If tabla.Rows.Count = 0 Then

            dispcabina = 1
        Else
            MsgBox("AREA NO DISPONIBLE, SE ENCUENTA EN SERVICIO ", vbExclamation + vbOKOnly, "AREA OCUPADA")

            dispcabina = 0
        End If

    End Sub

    Private Sub coldisponible()
        dispcol = 0

        conn = New c_mysqlconn
        tabla = New DataTable
        Dim sq As String
        sq = "select * from horariocol where id_col='" & sacarclave(tcol.Text) & "' and id_dia='" & dtfecha.Value.DayOfWeek & "' AND '" & chora.Text & "' >= entrada AND '" & chora.Text & "'< salida and '" & chora2.Text & "' > entrada and '" & chora2.Text & "' <=salida"
        tabla = conn.consulta(sq)
        If tabla.Rows.Count <> 0 Then




            fini = New DateTime(dtfecha.Value.Year, dtfecha.Value.Month, dtfecha.Value.Day, Convert.ToDateTime(chora.Text).Hour, Convert.ToDateTime(chora.Text).Minute, Convert.ToDateTime(chora.Text).Second)
            ffinal = New DateTime(dtfecha.Value.Year, dtfecha.Value.Month, dtfecha.Value.Day, Convert.ToDateTime(chora2.Text).Hour, Convert.ToDateTime(chora2.Text).Minute, Convert.ToDateTime(chora2.Text).Second)
            'tabla = conn.consulta("SELECT * FROM cita WHERE ('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "' >= fecha AND '" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "' < fecha_final and id_col='" & sacarclave(ccol.Text) & "' and estado='1') or ('" &
            ' Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "' > fecha AND '" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "'< fecha_final and id_col='" & sacarclave(ccol.Text) & "' and estado='1')")
            conn = New c_mysqlconn
            tabla = New DataTable
            tabla = conn.consulta("CALL spdisp('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "','0','" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "','" & sacarclave(tcol.Text) & "',2)")

            If tabla.Rows.Count = 0 Then

                dispcol = 1
            Else
                MsgBox("COLABORADOR NO DISPONIBLE,PUEDE CANCERLAR CITAS PROGRAMADAS EN EL MODULO DE CALENDARIO", vbExclamation + vbOKOnly, "COLABORADOR NO DISPONIBLE")
                dispcol = 0
                Exit Sub
            End If

            conn = New c_mysqlconn
            tabla = New DataTable
            tabla = conn.consulta("CALL spdisp('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "','0','" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "','" & sacarclave(tcol.Text) & "',6)")

            If tabla.Rows.Count = 0 Then

                dispcol = 1
            Else
                MsgBox("COLABORADOR NO DISPONIBLE,SE ENCUENTRA EN SERVICIO", vbExclamation + vbOKOnly, "COLABORADOR NO DISPONIBLE")
                dispcol = 0
            End If


        Else
            MsgBox("COLABORADOR FUERA DE HORARIO DE TRABAJO", vbExclamation + vbOKOnly, "COLABORADOR NO DISPONIBLE")
            dispcol = 0
        End If



    End Sub
    Private Sub bentrar_Click(sender As Object, e As EventArgs) Handles bentrar.Click
        Select Case flagorigen
            Case 1
                If flag = 1 Then
                    If tipo = 0 Then
                        MsgBox("ES NECESARIO RECOLECTAR INFORMACION DEL PROSPECTO", vbInformation + vbOKOnly, "RECEPCIÓN")
                        frmcliente.Show()
                        frmcliente.flag = 3
                        frmcliente.prospecto = idpersona
                        frmcliente.buscarprospecto()
                    Else

                        fini = New DateTime(dtfecha.Value.Year, dtfecha.Value.Month, dtfecha.Value.Day, Convert.ToDateTime(chora.Text).Hour, Convert.ToDateTime(chora.Text).Minute, Convert.ToDateTime(chora.Text).Second)
                        ffinal = New DateTime(dtfecha.Value.Year, dtfecha.Value.Month, dtfecha.Value.Day, Convert.ToDateTime(chora2.Text).Hour, Convert.ToDateTime(chora2.Text).Minute, Convert.ToDateTime(chora2.Text).Second)
                        conn = New c_mysqlconn
                        Dim visita As New c_visita
                        visita.Id_clie = tid_clie.Text
                        visita.Nombre = tclie.Text
                        visita.Fecha = fini
                        visita.Fecha_final = ffinal
                        visita.Id_cabina = id_cabina
                        visita.Id_serv = id_serv
                        visita.Id_col = id_col
                        visita.Obs = tobs.Text
                        visita.Folio_cita = tfolio.Text
                        visita.Entrada = Now

                        If conn.insertarvisita(visita) = True Then
                            MsgBox("DATOS REGISTRADOS CORRECTAMENTE", vbInformation + vbOKOnly, "RECEPCIÓN")

                            conn = New c_mysqlconn
                            foliovis = conn.Obtener_ID("select max(folio_vis) as max_id from visita")
                            tvis.Text = foliovis
                            conn = New c_mysqlconn
                            conn.citavisita(tfolio.Text, foliovis)


                            'frmhistoria.Show()
                            'frmhistoria.id_clie = tid_clie.Text
                            'frmhistoria.nom_clie = tclie.Text
                            'frmhistoria.tid_clie.Text = tid_clie.Text
                            'frmhistoria.tnombre.Text = tclie.Text
                            'frmhistoria.consulta()
                            frmrecepcion.consulta()
                            Dispose()
                        End If
                    End If
                Else
                    frmcobranza.Show()
                    frmcobranza.id_clie = tid_clie.Text
                    frmcobranza.folio_vis = foliovis
                    frmcobranza.buscarcliente()
                    frmcntapaquetes.Show()
                    frmcntapaquetes.flag = 2
                    frmcntapaquetes.id_serv = id_serv
                    frmcntapaquetes.consulta()
                    Dispose()
                End If
            Case 2
                If dispcabina = 1 And dispcol = 1 Then
                    fini = New DateTime(dtfecha.Value.Year, dtfecha.Value.Month, dtfecha.Value.Day, Convert.ToDateTime(chora.Text).Hour, Convert.ToDateTime(chora.Text).Minute, Convert.ToDateTime(chora.Text).Second)
                    ffinal = New DateTime(dtfecha.Value.Year, dtfecha.Value.Month, dtfecha.Value.Day, Convert.ToDateTime(chora2.Text).Hour, Convert.ToDateTime(chora2.Text).Minute, Convert.ToDateTime(chora2.Text).Second)
                    conn = New c_mysqlconn
                    Dim visita As New c_visita
                    visita.Id_clie = tid_clie.Text
                    visita.Nombre = tclie.Text
                    visita.Fecha = fini
                    visita.Fecha_final = ffinal
                    visita.Id_cabina = sacarclave(tcabina.Text)
                    visita.Id_serv = id_serv
                    visita.Id_col = sacarclave(tcol.Text)
                    visita.Obs = tobs.Text
                    visita.Folio_cita = tfolio.Text
                    visita.Entrada = Now

                    If conn.insertarvisita(visita) = True Then
                        MsgBox("DATOS REGISTRADOS CORRECTAMENTE" & Chr(13) & " A CONTINUACION PUEDE REGISTRAR LA HISTORIA CLINICA DEL VISITANTE", vbInformation + vbOKOnly, "RECEPCIÓN")
                        conn = New c_mysqlconn
                        foliovis = conn.Obtener_ID("select max(folio_vis) as max_id from visita")
                        tvis.Text = foliovis
                        Dispose()
                        'frmhistoria.Show()
                        'frmhistoria.id_clie = tid_clie.Text
                        'frmhistoria.nom_clie = tclie.Text
                        'frmhistoria.tid_clie.Text = tid_clie.Text
                        'frmhistoria.tnombre.Text = tclie.Text
                        'frmhistoria.consulta()
                    End If
                Else
                    MsgBox("NO ES POSIBLE REGISTRAR EL SERVICIO" & Chr(13) & "LA CABINA Y/O EL COLABORADOR NO ESTAN DISPONIBLES", vbExclamation + vbOKOnly, "RECEPCIÓN")
                End If
        End Select





    End Sub

    Private Sub combohora()
        chora.Items.Clear()
        chora2.Items.Clear()
        tcabina.Text = ""
        tcol.Text = ""
        conn = New c_mysqlconn
        tabla = New DataTable
        tabla = conn.consulta("select * from horagral where dia='" & dia & "'")
        If tabla.Rows.Count > 0 Then
            Dim entrada As DateTime
            Dim salida As DateTime
            entrada = Convert.ToString(tabla.Rows(0).Item("entrada"))
            salida = Convert.ToString(tabla.Rows(0).Item("salida"))

            While entrada <> salida
                chora.Items.Add(Format(entrada, "HH:mm"))
                chora2.Items.Add(Format(entrada, "HH:mm"))
                entrada = entrada.AddMinutes(15)

            End While



        End If
    End Sub
    Private Sub bbcliente_Click(sender As Object, e As EventArgs) Handles bbcliente.Click
        frmcntacliente.Show()
        frmcntacliente.flag = 3
    End Sub

    Private Sub BBSERVICIO_Click(sender As Object, e As EventArgs) Handles BBSERVICIO.Click
        frmcntaservicios.Show()
        frmcntaservicios.flag = 4
    End Sub

    Private Sub tcabina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcabina.SelectedIndexChanged
        cabinadisponible()
    End Sub
    Private Sub tcol_SelectedValueChanged(sender As Object, e As EventArgs) Handles tcol.SelectedValueChanged
        coldisponible()
    End Sub

    Private Sub frmvisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        buscarcontrato()
        If foliocont <> 0 Then

            If MsgBox("El cliente cuenta con un paquete de Sesiones" & Chr(13) & "¿Desea descontar este servicio de una de las sesiones del paquete?", vbQuestion + vbYesNo, "SALIDA") = MsgBoxResult.Yes Then
                ' si el cliene tiene un paquete y desea descontar una sesion
                conn = New c_mysqlconn
                conn.visitacontrato(foliocont)

                conn = New c_mysqlconn
                conn.darsalida(foliovis, foliocont)
                frmsalida.consulta()
                Dispose()

                Exit Sub

            End If
            ' si el cliene tiene un paquete y no desea descontar una sesion
            frmcobranza.Show()
            frmcobranza.bnuevo_Click(sender, e)
            frmcobranza.id_clie = tid_clie.Text
            frmcobranza.folio_vis = foliovis
            frmcobranza.buscarcliente()
            frmcntapaquetes.Show()
            frmcntapaquetes.flag = 2
            frmcntapaquetes.id_serv = id_serv
            frmcntapaquetes.consulta()
            Dispose()

        Else
            ' si el cliene no tiene un paquete
            frmcobranza.Show()
            frmcobranza.bnuevo_Click(sender, e)
            frmcobranza.id_clie = tid_clie.Text
            frmcobranza.folio_vis = foliovis
            frmcobranza.buscarcliente()
            frmcntapaquetes.Show()
            frmcntapaquetes.flag = 2
            frmcntapaquetes.id_serv = id_serv
            frmcntapaquetes.consulta()
            Dispose()
        End If
    End Sub
End Class