Imports MySql.Data.MySqlClient

Public Class frmcntacliente
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_cliente
    Dim tabla As New DataTable
    Public flag As Integer
    Dim color As Integer

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from cliente where estado_clie =1 order by id_clie")

        formatogrid()
    End Sub

    Public Sub consultatxt()
        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()
        conn = New c_mysqlconn
        Select Case ccampo.Text
            Case "ID"
                conn.consulta(grdatos, "Select * from cliente where estado_clie=1 And id_clie='" & tnombre.Text & "' order by id_clie")
            Case "RFC"
                conn.consulta(grdatos, "Select * from cliente where estado_clie=1 And rfc_clie like '%" & tnombre.Text & "%' order by id_clie")
            Case "NOMBRE"
                conn.consulta(grdatos, "Select * from cliente where estado_clie=1 And nom_clie like '%" & tnombre.Text & "%' order by id_clie")

        End Select

        If grdatos.RowCount > 0 Then
            formatogrid()
        End If

    End Sub

    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "CLAVE"
        grdatos.Columns(1).HeaderText = "RFC"
        grdatos.Columns(2).HeaderText = "NOMBRE"
        grdatos.Columns(3).HeaderText = "CALLE"
        grdatos.Columns(4).HeaderText = "NUMERO"
        grdatos.Columns(5).HeaderText = "COLONIA"
        grdatos.Columns(6).HeaderText = "MUNICIPIO"
        grdatos.Columns(7).HeaderText = "ESTADO"
        grdatos.Columns(8).HeaderText = "CP"
        grdatos.Columns(9).HeaderText = "TELEFONO"
        grdatos.Columns(10).HeaderText = "CELULAR"
        grdatos.Columns(11).HeaderText = "CORREO"
        grdatos.Columns(12).HeaderText = "FECHA NAC"
        grdatos.Columns(13).HeaderText = "IDENTIFICACION"
        grdatos.Columns(14).HeaderText = "NUM IDENTIFICACION"

        grdatos.Columns(15).HeaderText = "FOTOTIPO DE PIEL"
        grdatos.Columns(16).HeaderText = "COLOR DE OJOS"
        grdatos.Columns(17).HeaderText = "COLOR DE PELO"

        grdatos.Columns(18).HeaderText = "FECHA ALTA"

        grdatos.Columns(19).HeaderText = "ESTADO"

        grdatos.Columns(20).HeaderText = "GENERO"
        grdatos.Columns(21).HeaderText = "E. CIVIL"
        grdatos.Columns(22).HeaderText = "ANIVERSARIO"

        grdatos.Columns(23).HeaderText = "HIJOS"
        grdatos.Columns(24).HeaderText = "FACEBOOK"
        grdatos.Columns(25).HeaderText = "TWITTER"

        grdatos.Columns(26).HeaderText = "INSTAGRAM"
        grdatos.Columns(27).HeaderText = "NIVEL EST."
        grdatos.Columns(28).HeaderText = "OCUPACION"
        grdatos.AutoResizeColumns()
        grdatos.Columns(19).Visible = False


    End Sub

    Private Sub frmcntacliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE VISITANTES")
        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)

    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmcliente.Show()
        frmcliente.flag = 1
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick

        Dim cliente As New c_cliente


        cliente.Id_clie = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
        cliente.Rfc_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
        cliente.Nom_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
        cliente.Calle_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(3).Value)

        cliente.Num_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value)
        cliente.Col_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(5).Value)

        cliente.Mun_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(6).Value)
        cliente.Edo_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(7).Value)
        cliente.Cp_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(8).Value)

        cliente.Tel_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(9).Value)
        cliente.Cel_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(10).Value)
        cliente.Correo_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(11).Value)
        cliente.Nac_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(12).Value)
        cliente.Doc_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(13).Value)
        cliente.Docid_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(14).Value)

        cliente.Piel_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(15).Value)
        cliente.Ojos_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(16).Value)
        cliente.Pelo_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(17).Value)


        cliente.Alta_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(18).Value)
        cliente.Estado_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(19).Value)



        cliente.Gen_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(20).Value)
        cliente.Ecivil_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(21).Value)
        cliente.Aniv_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(22).Value)
        cliente.Hijos_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(23).Value)

        cliente.Fb_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(24).Value)
        cliente.Tw_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(25).Value)

        cliente.Insta_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(26).Value)
        cliente.Niv_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(27).Value)
        cliente.Ocupacion_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(28).Value)

        Select Case flag
            Case 1
                'frmcliente.MdiParent = frmprincipal
                frmcliente.Show()
                frmcliente.mostrar(cliente)
                frmcliente.flag = 2
                frmcliente.tnombre.Enabled = False
                frmcliente.tid.Enabled = False
            Case 2
                frmcita.id_persona = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmcita.tid_clie.Text = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmcita.tclie.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
                frmcita.ttel.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(9).Value)
                frmcita.tcel.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(10).Value)
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
        Dim cliente As New c_cliente
        cliente.Id_clie = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
        cliente.Rfc_clie = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        cliente.Nom_clie = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        cliente.Calle_clie = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)

        cliente.Num_clie = Convert.ToString(grdatos.CurrentRow().Cells(4).Value)
        cliente.Col_clie = Convert.ToString(grdatos.CurrentRow().Cells(5).Value)

        cliente.Mun_clie = Convert.ToString(grdatos.CurrentRow().Cells(6).Value)
        cliente.Edo_clie = Convert.ToString(grdatos.CurrentRow().Cells(7).Value)
        cliente.Cp_clie = Convert.ToString(grdatos.CurrentRow().Cells(8).Value)

        cliente.Tel_clie = Convert.ToString(grdatos.CurrentRow().Cells(9).Value)
        cliente.Cel_clie = Convert.ToString(grdatos.CurrentRow().Cells(10).Value)
        cliente.Correo_clie = Convert.ToString(grdatos.CurrentRow().Cells(11).Value)
        cliente.Nac_clie = Convert.ToString(grdatos.CurrentRow().Cells(12).Value)
        cliente.Doc_clie = Convert.ToString(grdatos.CurrentRow().Cells(13).Value)
        cliente.Docid_clie = Convert.ToString(grdatos.CurrentRow().Cells(14).Value)

        cliente.Piel_clie = Convert.ToString(grdatos.CurrentRow().Cells(15).Value)
        cliente.Ojos_clie = Convert.ToString(grdatos.CurrentRow().Cells(16).Value)
        cliente.Pelo_clie = Convert.ToString(grdatos.CurrentRow().Cells(17).Value)


        cliente.Alta_clie = Convert.ToString(grdatos.CurrentRow().Cells(18).Value)
        cliente.Estado_clie = Convert.ToString(grdatos.CurrentRow().Cells(19).Value)


        cliente.Gen_clie = Convert.ToString(grdatos.CurrentRow().Cells(20).Value)
        cliente.Ecivil_clie = Convert.ToString(grdatos.CurrentRow().Cells(21).Value)
        cliente.Aniv_clie = Convert.ToString(grdatos.CurrentRow().Cells(22).Value)
        cliente.Hijos_clie = Convert.ToString(grdatos.CurrentRow().Cells(23).Value)

        cliente.Fb_clie = Convert.ToString(grdatos.CurrentRow().Cells(24).Value)
        cliente.Tw_clie = Convert.ToString(grdatos.CurrentRow().Cells(25).Value)

        cliente.Insta_clie = Convert.ToString(grdatos.CurrentRow().Cells(26).Value)
        cliente.Niv_clie = Convert.ToString(grdatos.CurrentRow().Cells(27).Value)
        cliente.Ocupacion_clie = Convert.ToString(grdatos.CurrentRow().Cells(28).Value)

        'frmcliente.MdiParent = frmprincipal
        frmcliente.Show()
        frmcliente.mostrar(cliente)
        frmcliente.flag = 2
        frmcliente.tnombre.Enabled = False
        frmcliente.tid.Enabled = False
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
End Class