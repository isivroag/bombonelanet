Imports MySql.Data.MySqlClient
Public Class frmverpagos
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Public folio As String
    Dim fechaini As DateTime
    Dim fechafin As DateTime
    Public sql As String
    Public folio_cxc As Int64
    Dim foliopago As Int64
    Public Sub consulta()
        conn = New c_mysqlconn
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()

        conn.consulta(grdetalle, "SELECT folio_pago,folio_fis,fecha_pago,folio_cxc,importe_pago,nom_metodo,nom_col,if(tipo_pago='1','FACTURADO','PENDIENTE') AS facturado FROM pago where estado_pago=1 and folio_cxc='" & folio_cxc & "'")

        formatogrid()

    End Sub
    Private Sub formatogrid()

        grdetalle.Columns(0).HeaderText = "FOLIO"
        grdetalle.Columns(1).HeaderText = "F FIS"
        grdetalle.Columns(2).HeaderText = "FECHA"
        grdetalle.Columns(3).HeaderText = "FOLIO VENTA"
        grdetalle.Columns(4).HeaderText = "IMPORTE"
        grdetalle.Columns(5).HeaderText = "METODO"
        grdetalle.Columns(6).HeaderText = "COBRADOR"
        grdetalle.Columns(7).HeaderText = "TIPO"


        grdetalle.AutoResizeColumns()
        'grdetalle.Columns(3).Width = 200
        'grdetalle.Columns(2).Width = 70
        grdetalle.Columns(4).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        'grdetalle.Columns(0).Visible = False
        'grdetalle.Columns(1).Visible = False
        'grdetalle.Columns(7).Visible = False

    End Sub
    Private Sub frmverpagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "DETALLE DE PAGOS")

        ExtendedMethods.DoubleBuffered(grdetalle, True)
    End Sub
    Private Sub imprimir()
        'frmrepo.nombre = "CHEJERE.RptTicket.rdlc"
        'frmrepo.folio_cob = folio_cob

        '  frmrepo.Show()
        ' frmrepo.ticket()
        foliopago = grdetalle.CurrentRow().Cells(0).Value

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
            Case Else
                Dim x As New frmreporte
                x.folio = foliopago
                x.CAJA()
                x.ShowDialog()

        End Select


    End Sub



    'Private Sub grdetalle_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdetalle.CellMouseClick
    '    If (e.Button = MouseButtons.Right) Then


    '        grdetalle.CurrentCell = grdetalle.Rows(e.RowIndex).Cells(e.ColumnIndex)

    '        Dim Menu As ContextMenuStrip = New ContextMenuStrip

    '        Menu.Items.Add("imprimir").Name = "IMPRIMIR"
    '        AddHandler Menu.Items("imprimir").Click, New System.EventHandler(AddressOf imprimir)




    '        Dim coordenada As Rectangle = grdetalle.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
    '        Dim anchoCelda As Integer = coordenada.Location.X
    '        Dim altoCelda As Integer = coordenada.Location.Y


    '        Dim X As Integer = grdetalle.Location.X
    '        Dim Y As Integer = grdetalle.Location.Y

    '        Menu.Show(grdetalle, New Point(X, Y))
    '    End If
    ' End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        imprimir()
    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub mncancelar_Click(sender As Object, e As EventArgs) Handles mncancelar.Click
        If MsgBox("¿Esta seguro de Cancelar el registro?", vbQuestion + vbYesNo, "Cancelar") = vbYes Then

            Dim folio As String
            folio = grdetalle.CurrentRow.Cells(0).Value


            frmcancelar.Show()
            frmcancelar.tfolio.Text = folio
            frmcancelar.ttipo.Text = "2 PAGO"
            frmcancelar.tfecha.Value = Now
            frmcancelar.ltitulo.Text = "CANCELAR PAGO"



        End If
    End Sub
End Class