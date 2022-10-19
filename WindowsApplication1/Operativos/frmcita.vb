Imports MySql.Data.MySqlClient

Public Class frmcita
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




    Public Sub buscarcabina()
        Dim sql As String

        sql = "SELECT det_cabina.id_cabina,cabina.nom_cabina,det_cabina.id_tipo FROM det_cabina JOIN cabina ON det_cabina.id_cabina=cabina.id_cabina where det_cabina.id_tipo='" & id_tipo & "' ORDER BY det_cabina.id_cabina "
        tabla = New DataTable
        conn = New c_mysqlconn

        ccabina.Items.Clear()

        tabla = conn.consulta(sql)
        For Each row As DataRow In tabla.Rows
            ccabina.Items.Add(row("id_cabina") & " " & row("nom_cabina"))
        Next


    End Sub
    Public Sub buscarcol()
        Dim sql As String

        sql = "SELECT det_col.id_col,colaborador.nom_col,det_col.id_tipo FROM det_col JOIN colaborador ON det_col.id_col=colaborador.id_col where det_col.id_tipo='" & id_tipo & "' ORDER BY det_col.id_col "
        tabla = New DataTable
        conn = New c_mysqlconn

        ccol.Items.Clear()

        tabla = conn.consulta(sql)
        For Each row As DataRow In tabla.Rows
            ccol.Items.Add(row("id_col") & " " & row("nom_col"))
        Next


    End Sub


    Private Sub bnuevo_Click(sender As Object, e As EventArgs) Handles bbservicio.Click
        frmcntaservicios.Show()
        frmcntaservicios.flag = 2

    End Sub


    Private Sub combohora()
        chora.Items.Clear()
        chora2.Items.Clear()
        ccabina.Text = ""
        ccol.Text = ""
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



    Private Sub dtfecha_ValueChanged(sender As Object, e As EventArgs) Handles dtfecha.ValueChanged
        dia = CInt(dtfecha.Value.DayOfWeek)
        ccabina.Text = ""
        ccol.Text = ""
        combohora()

    End Sub

    Private Sub frmcita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CITAS")
        dtfecha.Value = Now

    End Sub

    Private Sub bbcliente_Click(sender As Object, e As EventArgs) Handles bbcliente.Click
        frmcntacliente.Show()
        frmcntacliente.flag = 2

    End Sub

    Private Sub bbprospecto_Click(sender As Object, e As EventArgs) Handles bbprospecto.Click
        frmcntaprospectos.Show()
        frmcntaprospectos.flag = 2
    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub ccabina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ccabina.SelectedIndexChanged
        cabinadisponible
    End Sub
    Private Sub ccol_SelectedValueChanged(sender As Object, e As EventArgs) Handles ccol.SelectedValueChanged
        coldisponible()
    End Sub
    Private Sub cabinadisponible()
        conn = New c_mysqlconn
        tabla = New DataTable
        fini = New DateTime(dtfecha.Value.Year, dtfecha.Value.Month, dtfecha.Value.Day, Convert.ToDateTime(chora.Text).Hour, Convert.ToDateTime(chora.Text).Minute, Convert.ToDateTime(chora.Text).Second)
        ffinal = New DateTime(dtfecha.Value.Year, dtfecha.Value.Month, dtfecha.Value.Day, Convert.ToDateTime(chora2.Text).Hour, Convert.ToDateTime(chora2.Text).Minute, Convert.ToDateTime(chora2.Text).Second)

        ' tabla = conn.consulta("SELECT * FROM cita WHERE  ('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "' >= fecha AND '" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "' < fecha_final and id_cabina='" & sacarclave(ccabina.Text) & "' and estado='1') or ('" &
        ' Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "' > fecha AND '" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "'< fecha_final and id_cabina='" & sacarclave(ccabina.Text) & "' and estado='1')")

        tabla = conn.consulta("CALL spdisp('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "','0','" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "','" & sacarclave(ccabina.Text) & "',1)")

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

        tabla = conn.consulta("select * from horariocol where id_col='" & sacarclave(ccol.Text) & "' and id_dia='" & dtfecha.Value.DayOfWeek & "' AND '" & chora.Text & "' >= entrada AND '" & chora.Text & "'< salida and '" & chora2.Text & "' > entrada and '" & chora2.Text & "' <=salida")
        If tabla.Rows.Count <> 0 Then



            conn = New c_mysqlconn
            tabla = New DataTable
            fini = New DateTime(dtfecha.Value.Year, dtfecha.Value.Month, dtfecha.Value.Day, Convert.ToDateTime(chora.Text).Hour, Convert.ToDateTime(chora.Text).Minute, Convert.ToDateTime(chora.Text).Second)
            ffinal = New DateTime(dtfecha.Value.Year, dtfecha.Value.Month, dtfecha.Value.Day, Convert.ToDateTime(chora2.Text).Hour, Convert.ToDateTime(chora2.Text).Minute, Convert.ToDateTime(chora2.Text).Second)
            'tabla = conn.consulta("SELECT * FROM cita WHERE ('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "' >= fecha AND '" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "' < fecha_final and id_col='" & sacarclave(ccol.Text) & "' and estado='1') or ('" &
            ' Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "' > fecha AND '" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "'< fecha_final and id_col='" & sacarclave(ccol.Text) & "' and estado='1')")
            tabla = conn.consulta("CALL spdisp('" & Format(fini, "yyyy-MM-dd HH:mm:ss") & "','0','" & Format(ffinal, "yyyy-MM-dd HH:mm:ss") & "','" & sacarclave(ccol.Text) & "',2)")

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



    Private Sub chora_SelectedValueChanged(sender As Object, e As EventArgs) Handles chora.SelectedValueChanged
        chora2.Text = Format(Convert.ToDateTime(chora.Text).AddMinutes(duracion), "HH:mm")
        Dim fcita As DateTime = New DateTime(dtfecha.Value.Year, dtfecha.Value.Month, dtfecha.Value.Day, Convert.ToDateTime(chora.Text).Hour, Convert.ToDateTime(chora.Text).Minute, Convert.ToDateTime(chora.Text).Second)
        If fcita < Now Then
            MsgBox("LA FECHA Y HORA DE ENTRADA DE LA CITA NO PUEDE SER MENOR A LA FECHA Y HORA ACTUAL", vbCritical + vbOKOnly, "COLABORADOR NO DISPONIBLE")
            Exit Sub
        End If

        ccabina.Text = ""
        ccol.Text = ""
    End Sub





    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If dispcabina = 1 Then
            If dispcol = 1 Then
                conn = New c_mysqlconn
                cita = New c_cita
                cita.Id_persona = id_persona
                cita.Tipo_persona = tipo_persona
                cita.Nombre = tclie.Text
                cita.Fecha = fini
                cita.Id_cabina = sacarclave(ccabina.Text)
                cita.Fecha_final = ffinal
                cita.Duracion = duracion
                cita.Id_serv = id_serv
                cita.Id_col = sacarclave(ccol.Text)
                cita.Obs = tobs.Text
                cita.Cel = tcel.Text
                cita.Tel = ttel.Text

                If conn.insertarnuevo(cita) Then
                    MsgBox("CITA REGISTRADA CON EXITO", vbInformation + vbOKOnly, "CITA REGISTRADA")
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

    Private Sub tserv_TextChanged(sender As Object, e As EventArgs) Handles tserv.TextChanged

    End Sub

    Private Sub chora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chora.SelectedIndexChanged

    End Sub
End Class