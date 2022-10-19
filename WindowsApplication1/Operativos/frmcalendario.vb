Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.Calendar
Imports System.Xml.Serialization
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frmcalendario
    Private _items As List(Of CalendarItem) = New List(Of CalendarItem)()
    Private contextItem As CalendarItem = Nothing
    Dim calendarioinicio As DateTime
    Dim calendariofin As DateTime
    Public dia As DateTime
    Dim inicio As DateTime
    Dim fin As DateTime
    Dim texto As String
    Dim folio As String
    Dim table As DataTable
    Dim conn As New c_mysqlconn
    Dim cita As CalendarItem
    Dim c As Color
    Dim sql As String
    Dim acolores As New List(Of String)
    Dim id_cita As String

    Public Sub buscarcita()
        conn = New c_mysqlconn
        table = New DataTable
        table = conn.consulta("SELECT cita.folio,cita.id_persona,cita.tipo_persona,cita.nombre,cita.fecha,cita.fecha_final,cita.id_cabina,cabina.nom_cabina,cita.id_serv,servicio.nom_serv,cita.id_col,colaborador.nom_col,cita.tel,cita.cel " &
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
            tcel.Text = table.Rows(0).Item("cel")
            ttel.Text = table.Rows(0).Item("tel")
        End If

    End Sub

    Public Sub consulta()
        If ccabina.Text = "TODOS" Then
            sql = "Select cita.folio,cita.fecha,cita.fecha_final,cita.nombre,cita.id_cabina,cabina.color_cabina " &
            "from cita join cabina on cita.id_cabina=cabina.id_cabina where cita.estado=1 and cabina.estado_cabina=1 and cita.fecha >= '" &
            Format(calendarioinicio, "yyyy-MM-dd 00:00:00") & "' and cita.fecha <= '" & Format(calendariofin, "yyyy-MM-dd 23:59:59") & "' and estado='1' order by cita.folio"

        Else
            sql = "Select cita.folio,cita.fecha,cita.fecha_final,cita.nombre,cita.id_cabina,cabina.color_cabina " &
            "from cita join cabina on cita.id_cabina=cabina.id_cabina where cita.estado=1 And cabina.estado_cabina=1 And cita.fecha >= '" &
            Format(calendarioinicio, "yyyy-MM-dd 00:00:00") & "' and cita.fecha <= '" & Format(calendariofin, "yyyy-MM-dd 23:59:59") & "' and cita.id_cabina='" & sacarclave(ccabina.Text) & "' and estado='1' order by cita.folio"
        End If
    End Sub
    Private Sub frmcalendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CALENDARIO DE CITAS")
        vmes.ArrowsColor = CalendarColorTable.FromHex("#77A1D3")
        vmes.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52")
        vmes.DaySelectedTextColor = vmes.ForeColor
        'Calendar1.SetViewRange(MonthView1.SelectionStart, MonthView1.SelectionEnd)

        dia = DateTime.Now
        vmes.SelectionStart = dia
        vmes.SelectionEnd = dia
        semana()
        calendarioinicio = New DateTime(calendarioinicio.Year, calendarioinicio.Month, calendarioinicio.Day, 8, 0, 0).ToString("yyyy-MM-dd hh:mm:ss")
        calendariofin = New DateTime(calendariofin.Year, calendariofin.Month, calendariofin.Day, 21, 0, 0)

        sql = "Select cita.folio,cita.fecha,cita.fecha_final,cita.nombre,cita.id_cabina,cabina.color_cabina " &
        "from cita join cabina on cita.id_cabina=cabina.id_cabina where cita.estado=1 And cabina.estado_cabina=1 And cita.fecha >= '" &
        Format(calendarioinicio, "yyyy-MM-dd 00:00:00") & "' and cita.fecha <= '" & Format(calendariofin, "yyyy-MM-dd 23:59:59") & "' and estado='1' order by cita.folio"
        Calendar1.TimeScale = CalendarTimeScale.FifteenMinutes
        Calendar1.TimeUnitsOffset = -34
        Calendar1.SetViewRange(calendarioinicio, calendariofin)

        cargaritems()
        combo()
    End Sub
    Private Sub combo()
        conn = New c_mysqlconn
        table.Clear()
        table = conn.consulta("select * from cabina order by id_cabina")
        ccabina.DrawMode = DrawMode.OwnerDrawFixed
        ccabina.Items.Clear()
        ccabina.Items.Add("TODOS")
        acolores.Clear()


        acolores.Add("-1")
        For Each row As DataRow In table.Rows

            ccabina.Items.Add(row("id_cabina") & " " & row("nom_cabina"))
            acolores.Add(If(IsDBNull(row("color_cabina")), "-1", row("color_Cabina")))
        Next row
    End Sub
    Public Sub semana()
        Select Case dia.DayOfWeek
            Case DayOfWeek.Sunday
                calendarioinicio = dia
                calendariofin = dia.AddDays(6)
            Case DayOfWeek.Monday
                calendarioinicio = dia.AddDays(-1)
                calendariofin = dia.AddDays(5)
            Case DayOfWeek.Tuesday
                calendarioinicio = dia.AddDays(-2)
                calendariofin = dia.AddDays(4)
            Case DayOfWeek.Wednesday
                calendarioinicio = dia.AddDays(-3)
                calendariofin = dia.AddDays(3)
            Case DayOfWeek.Thursday
                calendarioinicio = dia.AddDays(-4)
                calendariofin = dia.AddDays(2)
            Case DayOfWeek.Friday
                calendarioinicio = dia.AddDays(-5)
                calendariofin = dia.AddDays(1)
            Case DayOfWeek.Saturday
                calendarioinicio = dia.AddDays(-6)
                calendariofin = dia
        End Select

        LMES.Text = "DEL " & Format(calendarioinicio, "dd") & " " & UCase(Format(calendarioinicio, "MMMM")) & " DE " & Format(calendarioinicio, "yyyy") & " AL " & Format(calendariofin, "dd") & " " & UCase(Format(calendariofin, "MMMM")) & " DE " & Format(calendariofin, "yyyy")
    End Sub


    Private Sub vmes_SelectionChanged(sender As Object, e As EventArgs) Handles vmes.SelectionChanged
        dia = vmes.SelectionStart
        semana()

        Calendar1.SetViewRange(calendarioinicio, calendariofin)
        consulta()
        cargaritems()


    End Sub
    Public Sub nuevacita()
        vmes.SelectionStart = dia
        semana()

        Calendar1.SetViewRange(calendarioinicio, calendariofin)
        consulta()
        cargaritems()
    End Sub

    Public Sub cargaritems()
        table = New DataTable
        conn = New c_mysqlconn

        _items.Clear()
        Calendar1.Items.Clear()

        table = conn.consulta(sql)

        For Each row As DataRow In table.Rows


            inicio = row("fecha")
            cita = New CalendarItem(Calendar1, inicio, Convert.ToDateTime(row("fecha_final")), "CITA: " & row("folio") & " " & row("nombre"), row("folio"))



            cita.Locked = True

            cita.BackgroundColor = Color.FromArgb(row("color_cabina"))
            _items.Add(cita)
        Next row
        PlaceItems()
    End Sub


    Private Sub PlaceItems()
        For Each item As CalendarItem In _items

            If Calendar1.ViewIntersects(item) Then
                Calendar1.Items.Add(item)
                'item.ApplyColor(Color.Red)
                Calendar1.Invalidate(item)
            End If
        Next

        'For Each item In Calendar1.GetSelectedItems()

        '    item.ApplyColor(Color.Red)
        '    Calendar1.Invalidate(item)
        'Next
    End Sub








    Private Sub Calendar1_ItemDoubleClick(sender As Object, e As CalendarItemEventArgs) Handles Calendar1.ItemDoubleClick

        id_cita = e.Item.Folio
        buscarcita()


    End Sub





    Private Sub ccabina_SelectedValueChanged(sender As Object, e As EventArgs) Handles ccabina.SelectedValueChanged
        dia = vmes.SelectionStart
        semana()

        Calendar1.SetViewRange(calendarioinicio, calendariofin)
        consulta()
        cargaritems()
    End Sub



    Private Sub Calendar1_DayHeaderClick(sender As Object, e As CalendarDayEventArgs) Handles Calendar1.DayHeaderClick

        Calendar1.SetViewRange(e.CalendarDay.Date, e.CalendarDay.Date)
        cargaritems()
    End Sub

    Private Sub bnuevo_Click(sender As Object, e As EventArgs) Handles bnuevo.Click
        frmcita.Show()
        frmcita.BringToFront()

        frmcita.flag = 1
        frmcita.dtfecha.Value = vmes.SelectionStart

    End Sub

    Private Sub ccabina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ccabina.SelectedIndexChanged

    End Sub

    Private Sub ccabina_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ccabina.DrawItem
        If e.Index < 0 Then
            Return
        End If

        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        Dim cb As ComboBox = TryCast(sender, ComboBox)
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(New SolidBrush(Color.Turquoise), e.Bounds)
        Else
            e.Graphics.FillRectangle(New SolidBrush(ccabina.BackColor), e.Bounds)
        End If
        e.Graphics.DrawString(cb.Items(e.Index).ToString(), e.Font, New SolidBrush(cb.ForeColor), New Point(e.Bounds.X, e.Bounds.Y))
        e.DrawFocusRectangle()

        Dim colBrush As Brush = New SolidBrush(Color.FromArgb(acolores.Item(e.Index)))
        'Drawing rectangles for the color values
        e.Graphics.DrawRectangle(New Pen(Brushes.Black), e.Bounds.Right - 50, e.Bounds.Top + 2, 30, e.Bounds.Height - 5)
        e.Graphics.FillRectangle(colBrush, e.Bounds.Right - 49, e.Bounds.Top + 3, 29, e.Bounds.Height - 6)
        'Draw the name of the color
        'e.Graphics.DrawString(DirectCast(cb.Items(e.Index), String), cb.Font, Brushes.Black, 35, e.Bounds.Top + 2)
    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        If id_cita <> 0 Then

            If MsgBox("¿DESEA CANCELAR ESTA CITA?", vbQuestion + vbYesNo, "CALENDARIO DE CITAS") = MsgBoxResult.Yes Then
                conn = New c_mysqlconn
                If conn.eliminarcita(id_cita) Then
                    MsgBox("CITA CANCELADA CON EXITO", vbInformation + vbOKOnly, "CALENDARIO DE CITAS")
                    consulta()
                    cargaritems()
                End If
            End If
        Else
            MsgBox("ES NECESARIO ELEGIR LA CITA QUE DESEA CANCELAR", vbInformation + vbOKOnly, "CALENDARIO DE CITAS")
        End If
    End Sub

    Private Sub b_modificar_click(sender As Object, e As EventArgs) Handles bmodificar.Click
        If id_cita <> 0 Then
            frmauxcita.Show()
            frmauxcita.BringToFront()
            frmauxcita.id_cita = id_cita
            frmauxcita.buscarcita()








        Else
            MsgBox("ES NECESARIO ELEGIR LA CITA QUE DESEA CANCELAR", vbInformation + vbOKOnly, "CALENDARIO DE CITAS")
        End If
    End Sub

    Private Sub Calendar1_LoadItems(sender As Object, e As CalendarLoadEventArgs) Handles Calendar1.LoadItems

    End Sub
End Class