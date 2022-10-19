Imports MySql.Data.MySqlClient
Public Class frmcntawcliente


    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_wcliente
    Dim tabla As New DataTable
    Public flag As Integer
    Dim color As Integer

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from wcliente where estado_clie =1 order by id_clie")

        formatogrid()
    End Sub

    Public Sub consultatxt()
        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()
        conn = New c_mysqlconn
        Dim valor As String = ""
        If tnombre.Text <> "INTRODUZCA EL VALOR BUSCADO" Then
            valor = tnombre.Text
        Else
            valor = ""
        End If

        conn.consulta(grdatos, "Select * from wcliente where estado_clie=1 And (id_clie like '%" & valor & "%' or rfc_clie like '%" & valor & "%' or nom_clie like '%" & valor & "%' )order by id_clie")


        If grdatos.RowCount > 0 Then
            formatogrid()
        End If

    End Sub

    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID"
        grdatos.Columns(1).HeaderText = "NOMBRE"
        grdatos.Columns(2).HeaderText = "CURP"
        grdatos.Columns(3).HeaderText = "RFC"

        grdatos.Columns(4).HeaderText = "GENERO"
        grdatos.Columns(5).HeaderText = "FECHA NAC"
        grdatos.Columns(6).HeaderText = "DIRECCION"
        grdatos.Columns(7).HeaderText = "CORREO"

        grdatos.Columns(8).HeaderText = "TELEFONO"

        grdatos.Columns(9).HeaderText = "WHATSAPP/CEL"

        grdatos.Columns(10).HeaderText = "OCUPACION"
        grdatos.Columns(11).HeaderText = "NIV. EST."
        grdatos.Columns(12).HeaderText = "EDO CIV."



        grdatos.Columns(13).HeaderText = "ALTA"
        grdatos.Columns(14).HeaderText = "ESTADO"
        grdatos.Columns(15).HeaderText = "MEDIO"
        grdatos.AutoResizeColumns()
        grdatos.Columns(4).Visible = False
        grdatos.Columns(6).Visible = False
        grdatos.Columns(10).Visible = False
        grdatos.Columns(11).Visible = False
        grdatos.Columns(12).Visible = False
        grdatos.Columns(13).Visible = False
        grdatos.Columns(14).Visible = False


    End Sub

    Private Sub frmcntawcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE CLIENTES")
        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)

    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmwcliente.Show()
        frmwcliente.flag = 1
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick

        Dim cliente As New c_wcliente


        cliente.Id_clie = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
        cliente.Nom_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
        cliente.Curp_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
        cliente.Rfc_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(3).Value)
        cliente.Gen_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value)
        cliente.Nac_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(5).Value)

        cliente.Dir_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(6).Value)
        cliente.Correo_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(7).Value)

        cliente.Tel_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(8).Value)
        cliente.Ws_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(9).Value)
        cliente.Ocupacion_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(10).Value)
        cliente.Niv_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(11).Value)
        cliente.Ecivil_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(12).Value)
        cliente.Alta_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(13).Value)
        cliente.Estado_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(14).Value)
        cliente.Medio_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(15).Value)











        Select Case flag
            Case 1
                'frmcliente.MdiParent = frmprincipal
                frmwcliente.Show()
                frmwcliente.mostrar(cliente)
                frmwcliente.flag = 2
                frmwcliente.tnombre.Enabled = False
                frmwcliente.tid.Enabled = False
            Case 2
                frmcita.id_persona = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmcita.tid_clie.Text = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmcita.tclie.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
                frmcita.ttel.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(8).Value)
                frmcita.tcel.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(9).Value)
                frmcita.tipo_persona = 1
                frmcita.ttipop.Text = "CLIENTE"
                Dispose()
            Case 3
                frmvisita.idpersona = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmvisita.tid_clie.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmvisita.tclie.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
                Dispose()
            Case 4
                frmcobranza.id_clie = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmcobranza.buscarcliente()
                Dispose()
            Case 5
                frmcntacuentasclie.id_clie = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmcntacuentasclie.buscarcliente()
                Dispose()


        End Select

    End Sub
    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click
        Dim cliente As New c_wcliente
        cliente.Id_clie = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
        cliente.Rfc_clie = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        cliente.Nom_clie = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        cliente.Dir_clie = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)


        cliente.Tel_clie = Convert.ToString(grdatos.CurrentRow().Cells(4).Value)
        cliente.Ws_clie = Convert.ToString(grdatos.CurrentRow().Cells(5).Value)
        cliente.Correo_clie = Convert.ToString(grdatos.CurrentRow().Cells(6).Value)
        cliente.Nac_clie = Convert.ToString(grdatos.CurrentRow().Cells(7).Value)


        cliente.Alta_clie = Convert.ToString(grdatos.CurrentRow().Cells(8).Value)
        cliente.Estado_clie = Convert.ToString(grdatos.CurrentRow().Cells(9).Value)


        cliente.Gen_clie = Convert.ToString(grdatos.CurrentRow().Cells(10).Value)
        cliente.Ecivil_clie = Convert.ToString(grdatos.CurrentRow().Cells(11).Value)

        cliente.Niv_clie = Convert.ToString(grdatos.CurrentRow().Cells(12).Value)
        cliente.Ocupacion_clie = Convert.ToString(grdatos.CurrentRow().Cells(13).Value)
        cliente.Medio_clie = Convert.ToString(grdatos.CurrentRow().Cells(15).Value)

        'frmcliente.MdiParent = frmprincipal
        frmwcliente.Show()
        frmwcliente.mostrar(cliente)
        frmwcliente.flag = 2
        frmwcliente.tnombre.Enabled = False
        frmwcliente.tid.Enabled = False
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles mncHISTORIA.Click
        frmhistoria.Show()

    End Sub

    Private Sub tnombre_TextChanged(sender As Object, e As EventArgs) Handles tnombre.TextChanged
        If color = 0 Then
            tnombre.ForeColor = SystemColors.InactiveCaption

        Else

            tnombre.ForeColor = Drawing.Color.Black

        End If
    End Sub

    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs) Handles tnombre.LostFocus
        If Len(tnombre.Text) = 0 Then

            tnombre.Text = "INTRODUZCA EL VALOR BUSCADO"
            tnombre.ForeColor = SystemColors.InactiveCaption
            color = 0
        Else
            color = 1

        End If
    End Sub

    Private Sub tnombre_GotFocus(sender As Object, e As EventArgs) Handles tnombre.GotFocus
        tnombre.Text = ""
        tnombre.ForeColor = Drawing.Color.Black
        color = 1
    End Sub

    Private Sub bbuscar_Click(sender As Object, e As EventArgs) Handles bbuscar.Click
        consultatxt()

    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub



    Private Sub mncIMPRIMIR_Click_1(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        ExportarDatosExcel2(grdatos, "CATALOGO DE CLIENTES")
    End Sub
End Class