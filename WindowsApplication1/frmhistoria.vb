Imports MySql.Data.MySqlClient
Public Class frmhistoria
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Dim historia As c_historia
    Public id_clie As Int64
    Public nom_clie As String
    Dim indice As Integer
    Dim registros As Integer
    Dim idcol As Int64
    Dim opc As String
    Dim opc2 As String
    Dim tablaaux As DataTable


    Public Sub combocol()
        Dim sql As String

        sql = "SELECT id_col,colaborador.nom_col FROM colaborador ORDER BY id_col "
        tabla = New DataTable
        conn = New c_mysqlconn

        tcolaborador.Items.Clear()

        tabla = conn.consulta(sql)
        For Each row As DataRow In tabla.Rows
            tcolaborador.Items.Add(row("id_col") & " " & row("nom_col"))
        Next


    End Sub
    Public Sub consulta()
        conn = New c_mysqlconn
        tabla = New DataTable
        historia = New c_historia
        tabla = conn.consulta("select * from historia where id_clie='" & id_clie & "' order by id_his")
        If tabla.Rows.Count > 0 Then
            registros = tabla.Rows.Count - 1
            indice = tabla.Rows.Count - 1
            mostrar()
            MsgBox("ESTE ES EL ULTIMO REGISTRO DE ESTE VISITANTE", vbInformation + vbOKOnly, "RECEPCION")
        End If
    End Sub
    Public Sub mostrar()
        tid.Text = tabla(indice).Item("id_his")
        tid_clie.Text = tabla(indice).Item("id_clie")
        tfecha.Text = tabla(indice).Item("fecha_his")

        idcol = tabla(indice).Item("atendio_his")
        cemb.Text = tabla(indice).Item("emb_his")
        clac.Text = tabla(indice).Item("lact_his")
        cdep.Text = tabla(indice).Item("dep_his")
        cbron.Text = tabla(indice).Item("bron_his")
        tdepotro.Text = ""
        opc = tabla(indice).Item("metdep_his")
        Select Case tabla(indice).Item("metdep_his")
            Case "RASTRILLO"

                chdep1.Checked = True

            Case "CREMA"

                chdep2.Checked = True
            Case "CERA"

                chdep3.Checked = True
            Case "MAQ. ELECTRICA"

                chdep4.Checked = True
            Case Else

                chdep5.Checked = True
                tdepotro.Text = tabla(indice).Item("metdep_his")

        End Select

        tbronotro.Text = ""
        opc2 = tabla(indice).Item("metbron_his")
        Select Case tabla(indice).Item("metbron_his")
            Case "SOL"
                chbron1.Checked = True

            Case "RAYOS UVA"
                chbron2.Checked = True
            Case "CAÑA DE AZUCAR"
                chbron3.Checked = True
            Case "PINT. CORPORAL"

                chbron4.Checked = True
            Case Else
                chbron5.Checked = True
                tbronotro.Text = tabla(indice).Item("metbron_his")
        End Select

        chqueloides.CheckState = tabla(indice).Item("queloides_his")
        chhormonas.CheckState = tabla(indice).Item("hormonas_his")
        chcutaneas.CheckState = tabla(indice).Item("cutaneas_his")
        chvello.CheckState = tabla(indice).Item("vello_his")
        chepilepsia.CheckState = tabla(indice).Item("epilepsia_his")
        chtatuajes.CheckState = tabla(indice).Item("tatuajes_his")
        chsangre.CheckState = tabla(indice).Item("sangre_his")
        chherpes.CheckState = tabla(indice).Item("herpes_his")
        chalergias.CheckState = tabla(indice).Item("alergias_his")
        chdisp.CheckState = tabla(indice).Item("dispositivos_his")
        cmedicamento.Text = tabla(indice).Item("medicacion_his")

        tdetcutaneas.Text = tabla(indice).Item("descutaneas_his")
        tdetvello.Text = tabla(indice).Item("desvello_his")
        tdettatuajes.Text = tabla(indice).Item("zonatatu_his")
        tdetcoagulacion.Text = tabla(indice).Item("dessangre_his")
        tdetcutaneas.Text = tabla(indice).Item("descutaneas_his")
        tdetcutaneas.Text = tabla(indice).Item("descutaneas_his")
        tdetcutaneas.Text = tabla(indice).Item("descutaneas_his")
        cherpes.Text = tabla(indice).Item("zovirax_his")
        tdetalergias.Text = tabla(indice).Item("desalergias_his")
        tdisp.Text = tabla(indice).Item("desdispositivos_his")

        buscardet()

    End Sub
    Private Sub buscardet()
        conn = New c_mysqlconn
        tablaaux = New DataTable
        tablaaux = conn.consulta("select * from colaborador where id_col='" & idcol & "'")
        If tablaaux.Rows.Count > 0 Then
            tcolaborador.Text = tablaaux(0).Item("id_col") & " " & tablaaux(0).Item("nom_col")
        End If

        conn = New c_mysqlconn
        tablaaux = New DataTable
        tablaaux = conn.consulta("select * from cliente where id_clie='" & tid_clie.Text & "'")
        If tablaaux.Rows.Count > 0 Then
            tnombre.Text = tablaaux(0).Item("nom_clie")
        End If

    End Sub
    Private Sub frmhistoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combocol()
        tfecha.Text = Now
        opc = ""
        opc2 = ""


    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click

        If Len(tid_clie.Text) > 0 Then
            conn = New c_mysqlconn
            historia = New c_historia

            historia.Id_clie = tid_clie.Text
            historia.Fecha_his = tfecha.Text
            historia.Atendio_his = sacarclave(tcolaborador.Text)
            historia.Emb_his = cemb.Text
            historia.Lact_his = clac.Text
            historia.Dep_his = cdep.Text
            historia.Metdep_his = opc
            historia.Bron_his = cbron.Text
            historia.Metbron_his = opc2
            historia.Queloides_his = chqueloides.CheckState
            historia.Hormonas_his = chhormonas.CheckState
            historia.Cutaneas_his = chcutaneas.CheckState
            historia.Descuetaneas_his = tdetcutaneas.Text
            historia.Vello_his = chvello.CheckState
            historia.Desvello = tdetvello.Text
            historia.Tatuajes_his = chtatuajes.CheckState
            historia.Zonatatu_his = tdettatuajes.Text
            historia.Sangre_his = chsangre.CheckState
            historia.Dessangre_his = tdetcoagulacion.Text
            historia.Herpes_his = chherpes.CheckState
            historia.Zovirax_his = cherpes.Text
            historia.Alergias_his = chalergias.CheckState
            historia.Desalergias_his = tdetalergias.Text
            historia.Dispositivo_his = chdisp.CheckState
            historia.Desdispositivo_his = tdisp.Text
            historia.Medicacion_his = cmedicamento.Text
            conn.insertarnuevo(historia)
            conn = New c_mysqlconn
            tid.Text = conn.Obtener_ID("select max(id_his) as max_id from historia where id_clie='" & tid_clie.Text & "'")
            MsgBox("HISTORIA CLINICA GUARDADA CON EXITO", vbInformation + vbOKOnly, "RECEPCION")
        End If
    End Sub

    Private Sub chdep1_CheckedChanged(sender As Object, e As EventArgs) Handles chdep1.CheckedChanged
        If chdep1.Checked = True Then
            opc = chdep1.Text
        End If
    End Sub

    Private Sub chdep2_CheckedChanged(sender As Object, e As EventArgs) Handles chdep2.CheckedChanged
        If chdep2.Checked = True Then
            opc = chdep2.Text
        End If
    End Sub

    Private Sub chdep3_CheckedChanged(sender As Object, e As EventArgs) Handles chdep3.CheckedChanged
        If chdep3.Checked = True Then
            opc = chdep3.Text
        End If
    End Sub

    Private Sub chdep4_CheckedChanged(sender As Object, e As EventArgs) Handles chdep4.CheckedChanged
        If chdep4.Checked = True Then
            opc = chdep4.Text
        End If
    End Sub

    Private Sub chdep5_CheckedChanged(sender As Object, e As EventArgs) Handles chdep5.CheckedChanged
        If chdep1.Checked = True Then
            opc = tdepotro.Text
        End If
    End Sub

    Private Sub chbron1_CheckedChanged(sender As Object, e As EventArgs) Handles chbron1.CheckedChanged
        If chbron1.Checked = True Then
            opc2 = chbron1.Text
        End If
    End Sub

    Private Sub chbron2_CheckedChanged(sender As Object, e As EventArgs) Handles chbron2.CheckedChanged
        If chbron2.Checked = True Then
            opc2 = chbron2.Text
        End If
    End Sub

    Private Sub chbron3_CheckedChanged(sender As Object, e As EventArgs) Handles chbron3.CheckedChanged
        If chbron3.Checked = True Then
            opc2 = chbron3.Text
        End If
    End Sub

    Private Sub chbron4_CheckedChanged(sender As Object, e As EventArgs) Handles chbron4.CheckedChanged
        If chbron4.Checked = True Then
            opc2 = chbron4.Text
        End If
    End Sub

    Private Sub chbron5_CheckedChanged(sender As Object, e As EventArgs) Handles chbron5.CheckedChanged
        If chbron5.Checked = True Then
            opc2 = tbronotro.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If indice <> 0 Then
            indice = indice - 1
            mostrar()
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        If indice < registros Then
            indice += 1
            mostrar()
        End If
    End Sub
End Class