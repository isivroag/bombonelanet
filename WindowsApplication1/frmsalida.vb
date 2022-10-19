Imports MySql.Data.MySqlClient
Public Class frmsalida
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
        sql = "Select visita.folio_vis,convert(TIME_FORMAT(visita.fecha, '%H:%i'),char) as citaentrada,convert(TIME_FORMAT(visita.entrada, '%H:%i'),char) as entrada,visita.nombre,visita.id_serv,servicio.nom_serv,visita.id_cabina,cabina.nom_cabina,visita.id_col,colaborador.nom_col,cabina.color_cabina " &
        "from visita join cabina on visita.id_cabina=cabina.id_cabina join servicio on visita.id_serv=servicio.id_serv join colaborador on visita.id_col=colaborador.id_col where visita.estado=1 And cabina.estado_cabina=1 " & sqlcab & " and visita.nombre like '%" & tbuscar.Text & "%' And date(visita.fecha)= '" & Format(dtfecha.Value, "yyyy-MM-dd") & "' order by visita.fecha,visita.id_cabina"

        'conn.consulta(grdatos, "select * from cita where date(fecha)='" & Format(dtfecha.Text, "yyyy-MM-dd") & "' order by fecha,id_cabina")
        conn.consulta(grdatos, sql)
        If grdatos.Rows.Count = 0 Then

            grdatos.DataSource = Nothing
            grdatos.Rows.Clear()
            grdatos.Columns.Clear()
            grdatos.ColumnCount = 11
        End If
        formatogrid()
    End Sub

    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "FOLIO"

        grdatos.Columns(1).HeaderText = "ENTRADA CITA"
        grdatos.Columns(2).HeaderText = "LLEGADA"
        grdatos.Columns(3).HeaderText = "VISITANTE"
        grdatos.Columns(4).HeaderText = "ID SERVICIO"
        grdatos.Columns(5).HeaderText = "SERVICIO"
        grdatos.Columns(6).HeaderText = "ID CABINA"
        grdatos.Columns(7).HeaderText = "CABINA"
        grdatos.Columns(8).HeaderText = "ID COL"
        grdatos.Columns(9).HeaderText = "COLABORADOR"
        grdatos.Columns(10).HeaderText = "COLOR"


        grdatos.Columns(4).Visible = False
        grdatos.Columns(6).Visible = False
        grdatos.Columns(8).Visible = False
        grdatos.Columns(10).Visible = False
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

    Private Sub grdatos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grdatos.CellFormatting
        Dim row As DataGridViewRow = grdatos.Rows(e.RowIndex)


        row.DefaultCellStyle.BackColor = Color.FromArgb(row.Cells(10).Value.ToString)
        e.CellStyle.SelectionBackColor = Color.FromArgb(row.Cells(10).Value.ToString)
        e.CellStyle.SelectionForeColor = Color.White



    End Sub

    Private Sub ccabina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ccabina.SelectedIndexChanged
        If ccabina.Text = "TODOS" Then
            sqlcab = ""
        Else
            sqlcab = "And visita.id_cabina='" & sacarclave(ccabina.Text) & "'"
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
        frmvisita.foliovis = grdatos.CurrentRow.Cells(0).Value
        frmvisita.buscarvisita()
        frmvisita.flagorigen = 1
        frmvisita.flag = 2
        frmvisita.bsalir.Visible = True


    End Sub
    Private Sub frmsalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()

    End Sub

    Private Sub bnuevo_Click(sender As Object, e As EventArgs) Handles bnuevo.Click
        frmvisita.Show()
        frmvisita.foliovis = grdatos.CurrentRow.Cells(0).Value
        frmvisita.buscarvisita()
        frmvisita.flagorigen = 1
        frmvisita.flag = 2
        frmvisita.bsalir.Visible = True
    End Sub
End Class