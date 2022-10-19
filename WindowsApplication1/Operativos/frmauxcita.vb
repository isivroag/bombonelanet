Imports MySql.Data.MySqlClient

Public Class frmauxcita
    Dim conn As New c_mysqlconn
    Public flag As Integer
    Public id_serv As Integer
    Public id_tipo As Integer
    Dim tabla As New DataTable
    Dim dia As Integer
    Public tipo_persona As Integer
    Public id_persona As Integer
    Public duracion As Integer
    Dim fini As DateTime
    Dim ffinal As DateTime
    Dim cita As c_cita
    Dim dispcabina As Integer
    Dim dispcol As Integer
    Public id_cita As Integer


    Public Sub buscarcita()
        conn = New c_mysqlconn
        tabla = New DataTable
        tabla = conn.consulta("SELECT cita.folio,cita.id_persona,cita.tipo_persona,cita.nombre,cita.fecha,cita.fecha_final,cita.duracion,cita.id_cabina,cabina.nom_cabina,cita.id_serv,servicio.nom_serv,cita.id_col,colaborador.nom_col,cita.tel,cita.cel " &
                                "FROM cita JOIN servicio ON cita.id_serv=servicio.id_serv JOIN cabina ON cita.id_cabina=cabina.id_cabina JOIN colaborador ON cita.id_col=colaborador.id_col" &
                                "  where cita.folio='" & id_cita & "'")
        If tabla.Rows.Count > 0 Then
            tid_clie.Text = tabla.Rows(0).Item("id_persona")
            tclie.Text = tabla.Rows(0).Item("nombre")

            tid_serv.Text = tabla.Rows(0).Item("id_serv")
            id_serv = tabla.Rows(0).Item("id_serv")

            tserv.Text = tabla.Rows(0).Item("nom_serv")
            dtfecha.Value = tabla.Rows(0).Item("fecha")
            chora.Text = Format(tabla.Rows(0).Item("fecha"), "HH:mm")
            chora2.Text = Format(tabla.Rows(0).Item("fecha_final"), "HH:mm")
            duracion = tabla.Rows(0).Item("duracion")
            ccabina.Text = tabla.Rows(0).Item("id_cabina") & " " & tabla.Rows(0).Item("nom_cabina")
            ccol.Text = tabla.Rows(0).Item("id_col") & " " & tabla.Rows(0).Item("nom_col")
            chora.Text = Format(tabla.Rows(0).Item("fecha"), "h:mm")

            conn = New c_mysqlconn
            tabla = New DataTable
            tabla = conn.consulta("select id_tipo from servicio where id_serv='" & id_serv & "'")

            If tabla.Rows.Count > 0 Then
                id_tipo = tabla.Rows(0).Item("id_tipo")
            Else
                id_tipo = 0
            End If

            buscarcabina()
            buscarcol()

        End If
    End Sub
    Public Sub buscarcabina()
        Dim sql As String

        sql = "SELECT det_cabina.id_cabina,cabina.nom_cabina,det_cabina.id_tipo FROM det_cabina JOIN cabina ON det_cabina.id_cabina=cabina.id_cabina where det_cabina.id_tipo='" & id_tipo & "' ORDER BY det_cabina.id_cabina "
        tabla = New DataTable
        conn = New c_mysqlconn

        ccabinan.Items.Clear()

        tabla = conn.consulta(sql)
        For Each row As DataRow In tabla.Rows
            ccabinan.Items.Add(row("id_cabina") & " " & row("nom_cabina"))
        Next


    End Sub
    Public Sub buscarcol()
        Dim sql As String

        sql = "SELECT det_col.id_col,colaborador.nom_col,det_col.id_tipo FROM det_col JOIN colaborador ON det_col.id_col=colaborador.id_col where det_col.id_tipo='" & id_tipo & "' ORDER BY det_col.id_col "
        tabla = New DataTable
        conn = New c_mysqlconn

        ccoln.Items.Clear()

        tabla = conn.consulta(sql)
        For Each row As DataRow In tabla.Rows
            ccoln.Items.Add(row("id_col") & " " & row("nom_col"))
        Next


    End Sub
    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()

    End Sub
    Private Sub combohora()
        choran.Items.Clear()
        chora2n.Items.Clear()
        ccabinan.Text = ""
        ccoln.Text = ""
        conn = New c_mysqlconn
        tabla = New DataTable
        tabla = conn.consulta("select * from horagral where dia='" & dia & "'")
        If tabla.Rows.Count > 0 Then
            Dim entrada As DateTime
            Dim salida As DateTime
            entrada = Convert.ToString(tabla.Rows(0).Item("entrada"))
            salida = Convert.ToString(tabla.Rows(0).Item("salida"))

            While entrada <> salida
                choran.Items.Add(Format(entrada, "HH:mm"))
                chora2n.Items.Add(Format(entrada, "HH:mm"))
                entrada = entrada.AddMinutes(15)

            End While



        End If
    End Sub



    Private Sub dtfecha_ValueChanged(sender As Object, e As EventArgs) Handles dtfechan.ValueChanged
        dia = CInt(dtfechan.Value.DayOfWeek)
        ccabinan.Text = ""
        ccoln.Text = ""
        combohora()

    End Sub

    Private Sub frmauxcita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "RECALENDARIZACION DE CITA")
        dtfechan.Value = Now
    End Sub

    Private Sub ccabinan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ccabinan.SelectedIndexChanged
        cabinadisponible()
    End Sub
    Private Sub cabinadisponible()
        conn = New c_mysqlconn
        tabla = New DataTable
        fini = New DateTime(dtfechan.Value.Year, dtfechan.Value.Month, dtfechan.Value.Day, Convert.ToDateTime(choran.Text).Hour, Convert.ToDateTime(choran.Text).Minute, Convert.ToDateTime(choran.Text).Second)
        ffinal = New DateTime(dtfechan.Value.Year, dtfechan.Value.Month, dtfechan.Value.Day, Convert.ToDateTime(chora2n.Text).Hour, Convert.ToDateTime(chora2n.Text).Minute, Convert.ToDateTime(chora2n.Text).Second)

        'tabla = conn.consulta("SELECT * FROM cita WHERE  ('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "' >= fecha AND '" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "' < fecha_final and id_cabina='" & sacarclave(ccabinan.Text) & "' and folio<>'" & id_cita & "' and estado='1') or ('" &
        'Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "' > fecha AND '" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "'<= fecha_final and id_cabina='" & sacarclave(ccabinan.Text) & "' and folio <>'" & id_cita & "' and estado='1')")

        'tabla = conn.consulta(" SELECT * FROM cita WHERE " &
        '    "((fecha <= '" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "' AND fecha_final >= '" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "')  " &
        '     "Or ('" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "' > fecha AND '" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "'<= fecha_final) " &
        '      "Or ('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "' BETWEEN  fecha AND fecha_final)) and id_cabina='" & sacarclave(ccabinan.Text) & "' and folio <>'" & id_cita & "' and estado='1'")

        tabla = conn.consulta("CALL spdisp('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "','" & id_cita & "','" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "','" & sacarclave(ccabinan.Text) & "',3)")


        If tabla.Rows.Count = 0 Then

            dispcabina = 1
        Else
            MsgBox("AREA NO DISPONIBLE", vbExclamation + vbOKOnly, "AREA OCUPADA")
            dispcabina = 0
        End If
    End Sub

    Private Sub coldisponible()
        dispcol = 0

        conn = New c_mysqlconn
        tabla = New DataTable

        tabla = conn.consulta("Select * from horariocol where id_col='" & sacarclave(ccoln.Text) & "' and id_dia='" & dtfechan.Value.DayOfWeek & "' AND '" & choran.Text & "' >= entrada AND '" & choran.Text & "'< salida and '" & chora2n.Text & "' > entrada and '" & chora2n.Text & "' <=salida")
        If tabla.Rows.Count <> 0 Then



            conn = New c_mysqlconn
            tabla = New DataTable
            fini = New DateTime(dtfechan.Value.Year, dtfechan.Value.Month, dtfechan.Value.Day, Convert.ToDateTime(choran.Text).Hour, Convert.ToDateTime(choran.Text).Minute, Convert.ToDateTime(choran.Text).Second)
            ffinal = New DateTime(dtfechan.Value.Year, dtfechan.Value.Month, dtfechan.Value.Day, Convert.ToDateTime(chora2n.Text).Hour, Convert.ToDateTime(chora2n.Text).Minute, Convert.ToDateTime(chora2n.Text).Second)
            'tabla = conn.consulta("SELECT * FROM cita WHERE ('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "' >= fecha AND '" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "' < fecha_final and id_col='" & sacarclave(ccoln.Text) & "' and folio<>'" & id_cita & "' and estado='1') or ('" &
            'Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "' > fecha AND '" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "'<= fecha_final and id_col='" & sacarclave(ccoln.Text) & "' and folio<>'" & id_cita & "' and estado='1')")

            tabla = conn.consulta("CALL spdisp('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "','" & id_cita & "','" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "','" & sacarclave(ccoln.Text) & "',4)")
            If tabla.Rows.Count = 0 Then

                dispcol = 1
            Else
                MsgBox("COLABORADOR NO DISPONIBLE", vbExclamation + vbOKOnly, "COLABORADOR NO DISPONIBLE")
                dispcol = 0
            End If

        Else
            MsgBox("COLABORADOR FUERA DE HORARIO DE TRABAJO", vbExclamation + vbOKOnly, "COLABORADOR NO DISPONIBLE")
            dispcol = 0
        End If



    End Sub



    Private Sub chora_SelectedValueChanged(sender As Object, e As EventArgs) Handles choran.SelectedValueChanged
        chora2n.Text = Format(Convert.ToDateTime(choran.Text).AddMinutes(duracion), "HH:mm")
        ccabinan.Text = ""
        ccoln.Text = ""
    End Sub



    Private Sub ccoln_SelectedValueChanged(sender As Object, e As EventArgs) Handles ccoln.SelectedValueChanged
        coldisponible()
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If dispcabina = 1 Then
            If dispcol = 1 Then
                conn = New c_mysqlconn
                cita = New c_cita

                cita.Fecha = fini
                cita.Id_cabina = sacarclave(ccabina.Text)
                cita.Fecha_final = ffinal


                cita.Id_col = sacarclave(ccol.Text)


                If conn.modificarcita(cita, id_cita) Then
                    MsgBox("CITA MODIFICADA CON EXITO", vbInformation + vbOKOnly, "CITA REGISTRADA")
                    frmcalendario.dia = fini
                    frmcalendario.nuevacita()
                    Dispose()
                End If
            Else
                MsgBox("NO ES POSIBLE GUARDAR LA CITA" & Chr(13) & "EL COLABORADOR NO ESTA DISPONIBLE", vbExclamation + vbOKOnly, "CITA NO REGISTRADA")
            End If


        Else
            MsgBox("NO ES POSIBLE GUARDAR LA CITA" & Chr(13) & "EL AREA NO ESTA DISPONIBLE", vbExclamation + vbOKOnly, "CITA NO REGISTRADA")
        End If

    End Sub
End Class