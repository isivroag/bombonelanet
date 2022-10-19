Imports MySql.Data.MySqlClient

Public Class frmegresos
    Public flag As Integer
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Dim table As DataTable
    Public id_prov As Int64
    Dim id_partida As Int64
    Dim registro As New c_egreso


    Public Sub buscar(ByVal folio As Integer)
        conn = New c_mysqlconn

        table = New DataTable
        table = conn.consulta("select * from vegresos where id_egr='" & folio & "'")
        If table.Rows.Count > 0 Then

            registro.Id_egr = table.Rows(0).Item("id_egr")
            tfolio.Text = table.Rows(0).Item("id_egr")

            registro.Fecha_egr = table.Rows(0).Item("fecha_egr")
            tfecha.Text = table.Rows(0).Item("fecha_egr")

            registro.Facturado = table.Rows(0).Item("facturado")
            cfact.Checked = table.Rows(0).Item("facturado")

            registro.Ref_egr = table.Rows(0).Item("ref_egr")
            tfact.Text = table.Rows(0).Item("ref_egr")

            registro.Id_prov = table.Rows(0).Item("id_prov")
            tid_prov.Text = table.Rows(0).Item("id_prov")

            tnombre.Text = table.Rows(0).Item("nom_prov")

            registro.Id_partida = table.Rows(0).Item("id_partida")
            cpartida.Text = table.Rows(0).Item("id_partida") & " " & table.Rows(0).Item("nom_partida")

            registro.Id_subpartida = table.Rows(0).Item("id_subpartida")
            csubpartida.Text = table.Rows(0).Item("id_subpartida") & " " & table.Rows(0).Item("nom_subpartida")

            registro.Concepto_egr = table.Rows(0).Item("concepto_egr")
            tdesc.Text = table.Rows(0).Item("concepto_egr")

            registro.Metodo_egr = table.Rows(0).Item("metodo_egr")
            cmetodo.Text = table.Rows(0).Item("metodo_egr")

            registro.Total_egr = table.Rows(0).Item("total_egr")
            ttotal.Text = table.Rows(0).Item("total_egr")

        Else
            tnombre.Text = ""
        End If
    End Sub

    Public Sub buscarproveedor()
        conn = New c_mysqlconn

        tabla = New DataTable

        tabla = conn.consulta("select * from proveedor where id_prov='" & id_prov & "'")
        If tabla.Rows.Count > 0 Then
            tnombre.Text = tabla.Rows(0).Item("nom_prov")
            tid_prov.Text = id_prov
        Else
            tnombre.Text = ""
        End If

    End Sub
    Public Sub combo()
        Dim sql As String

        sql = "SELECT id_partida,nom_partida FROM partida where estado_partida='1' ORDER BY id_partida "

        tabla = New DataTable

        conn = New c_mysqlconn

        cpartida.Items.Clear()

        tabla = conn.consulta(sql)
        For Each row As DataRow In tabla.Rows
            cpartida.Items.Add(row("id_partida") & " " & row("nom_partida"))
        Next


    End Sub

    Public Sub subcombo()
        Dim sql As String

        sql = "SELECT id_subpartida,nom_subpartida FROM subpartida where estado_subpartida='1' and id_partida='" & id_partida & "' ORDER BY id_subpartida "
        tabla = New DataTable
        conn = New c_mysqlconn

        csubpartida.Items.Clear()
        csubpartida.Text = ""

        tabla = conn.consulta(sql)
        For Each row As DataRow In tabla.Rows
            csubpartida.Items.Add(row("id_subpartida") & " " & row("nom_subpartida"))
        Next


    End Sub

    Private Sub frmegresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "EGRESOS")

        limpiar()

        combo()

    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub
    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmcntaproveedor.Show()
        frmcntaproveedor.BringToFront()
        frmcntaproveedor.flag = 2
    End Sub
    Private Sub limpiar()
        tfolio.Text = ""
        cfact.Checked = False
        tfact.Text = ""
        tfecha.Text = Format(Now, "yyyy-MM-dd")
        cpartida.Text = ""
        csubpartida.Text = ""
        tdesc.Text = ""
        tid_prov.Text = ""
        tnombre.Text = ""
        ttotal.Text = "0.00"
        cmetodo.Text = ""




    End Sub






    Private Sub cpartida_TextChanged(sender As Object, e As EventArgs) Handles cpartida.TextChanged
        If Len(cpartida.Text) > 0 Then
            id_partida = sacarclave(cpartida.Text)
            subcombo()
        End If

    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Len(tid_prov.Text) = 0 Or Len(tdesc.Text) = 0 Or Len(ttotal.Text) = 0 Or Len(cpartida.Text) = 0 Or Len(csubpartida.Text) = 0 Or Len(cmetodo.Text) = 0 Then
            MsgBox("NO ES POSIBLE REGISTRAR EL EGRESO, ES NECESARIA MAS INFORMACIÓN", vbInformation + vbOKOnly, "EGRESOS")
            Exit Sub
        End If

        If CDbl(ttotal.Text) <= 0 Then
            MsgBox("NO ES POSIBLE REGISTRAR EL EGRESO, EL TOTAL NO PUEDE SER 0 O MENOR", vbInformation + vbOKOnly, "EGRESOS")
            Exit Sub
        End If




        registro.Fecha_egr = CDate(tfecha.Text)
        registro.Facturado = cfact.CheckState
        registro.Ref_egr = tfact.Text
        registro.Id_prov = tid_prov.Text
        registro.Id_partida = sacarclave(cpartida.Text)
        registro.Id_subpartida = sacarclave(csubpartida.Text)
        registro.Concepto_egr = tdesc.Text
        registro.Metodo_egr = cmetodo.Text
        registro.Total_egr = CDbl(ttotal.Text)

        conn = New c_mysqlconn
        If flag = 1 Then
            conn = New c_mysqlconn
            If conn.insertarnuevo(registro) Then
                MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                frmcntaegresos.consulta()
                Me.Dispose()
            Else
                MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            conn = New c_mysqlconn
            If conn.modificar(registro, registro.Id_egr.ToString) Then
                MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmcntaegresos.consulta()
                Me.Dispose()
            Else
                MessageBox.Show("Datos No Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub mayusculas(sender As Object, e As EventArgs) Handles tdesc.LostFocus
        mayus(sender)
    End Sub


End Class