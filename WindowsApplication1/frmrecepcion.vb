Imports MySql.Data.MySqlClient

Public Class frmrecepcion
    Dim conn As c_mysqlconn
    Dim table As DataTable
    Dim acolores As New List(Of String)
    Dim dia As Integer
    Dim sql As String
    Dim sqlcab As String
    Dim sqltxt As String
    Public Sub consulta()

        conn = New c_mysqlconn
        table = New DataTable
        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()
        sql = "Select cita.folio,convert(TIME_FORMAT(cita.fecha, '%H:%i'),char) as entrada,convert(TIME_FORMAT(cita.fecha_final, '%H:%i'),char) as salida,cita.nombre,if(cita.tipo_persona,'CLIENTE','PROSPECTO') as tipo_cliente,cita.id_serv,servicio.nom_serv,cita.id_cabina,cabina.nom_cabina,cabina.color_cabina " &
        "from cita join cabina on cita.id_cabina=cabina.id_cabina join servicio on cita.id_serv=servicio.id_serv where cita.estado=1 And cabina.estado_cabina=1 " & sqlcab & " and cita.nombre like '%" & tbuscar.Text & "%' And date(cita.fecha)= '" & Format(dtfecha.Value, "yyyy-MM-dd") & "' order by cita.fecha,cita.id_cabina"

        'conn.consulta(grdatos, "select * from cita where date(fecha)='" & Format(dtfecha.Text, "yyyy-MM-dd") & "' order by fecha,id_cabina")
        conn.consulta(grdatos, sql)
        If grdatos.Rows.Count = 0 Then

            grdatos.DataSource = Nothing
            grdatos.Rows.Clear()
            grdatos.Columns.Clear()
            grdatos.ColumnCount = 10
        End If
        formatogrid()
    End Sub

    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "FOLIO"
        grdatos.Columns(1).HeaderText = "ENTRADA"
        grdatos.Columns(2).HeaderText = "SALIDA"
        grdatos.Columns(3).HeaderText = "VISITANTE"
        grdatos.Columns(4).HeaderText = "TIPO VISITANTE"
        grdatos.Columns(5).HeaderText = "ID SERVICIO"
        grdatos.Columns(6).HeaderText = "SERVICIO"
        grdatos.Columns(7).HeaderText = "ID CABINA"
        grdatos.Columns(8).HeaderText = "CABINA"
        grdatos.Columns(9).HeaderText = "COLOR"


        grdatos.Columns(5).Visible = False
        grdatos.Columns(7).Visible = False
        grdatos.Columns(9).Visible = False
        grdatos.AutoResizeColumns()


    End Sub
    Private Sub combo()
        conn = New c_mysqlconn
        table = New DataTable
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

    'Private Sub combohora()
    '    chora.Items.Clear()



    '    conn = New c_mysqlconn
    '    table = New DataTable
    '    table = conn.consulta("select * from horagral where dia='" & dia & "'")
    '    If table.Rows.Count > 0 Then
    '        Dim entrada As DateTime
    '        Dim salida As DateTime
    '        entrada = Convert.ToString(table.Rows(0).Item("entrada"))
    '        salida = Convert.ToString(table.Rows(0).Item("salida"))

    '        While entrada <> salida
    '            chora.Items.Add(Format(entrada, "HH:mm"))

    '            entrada = entrada.AddMinutes(15)

    '        End While



    '    End If
    'End Sub
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
    Private Sub frmrecepcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtendedMethods.DoubleBuffered(grdatos, True)
        combo()
        dtfecha.Value = Now
        sqlcab = ""
        dia = dtfecha.Value.DayOfWeek
        tbuscar.Text = ""
        consulta()
    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub

    Private Sub grdatos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grdatos.CellFormatting
        Dim row As DataGridViewRow = grdatos.Rows(e.RowIndex)


        row.DefaultCellStyle.BackColor = Color.FromArgb(row.Cells(9).Value.ToString)
        e.CellStyle.SelectionBackColor = Color.FromArgb(row.Cells(9).Value.ToString)
        e.CellStyle.SelectionForeColor = Color.White



    End Sub

    Private Sub ccabina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ccabina.SelectedIndexChanged
        If ccabina.Text = "TODOS" Then
            sqlcab = ""
        Else
            sqlcab = "and cita.id_cabina='" & sacarclave(ccabina.Text) & "'"
        End If
        consulta()
    End Sub

    Private Sub tbuscar_TextChanged(sender As Object, e As EventArgs) Handles tbuscar.TextChanged
        consulta()
    End Sub

    Private Sub dtfecha_ValueChanged(sender As Object, e As EventArgs) Handles dtfecha.ValueChanged
        consulta()
    End Sub

    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick
        frmvisita.Show()
        frmvisita.id_cita = grdatos.CurrentRow.Cells(0).Value
        frmvisita.buscarcita()
        frmvisita.flag = 1
        frmvisita.flagorigen = 1
        frmvisita.bentrar.Visible = True
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles bnuevo.Click

        frmvisita.Show()
        frmvisita.flagorigen = 2
        frmvisita.nuevavisita()
        frmvisita.bentrar.Visible = True
    End Sub


    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub
End Class