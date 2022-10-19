Imports MySql.Data.MySqlClient

Public Class frmgastoscaja
    Public flag As Integer
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Dim table As DataTable
    Dim registro As New c_gasto

    Public Sub buscar(ByVal folio As Integer)
        conn = New c_mysqlconn

        table = New DataTable
        table = conn.consulta("select * from gasto where id_gasto='" & folio & "'")
        If table.Rows.Count > 0 Then

            registro.Id_gasto = table.Rows(0).Item("id_gasto")
            tfolio.Text = registro.Id_gasto

            registro.Fecha = table.Rows(0).Item("fecha")
            tfecha.Text = registro.Fecha

            registro.Facturado = table.Rows(0).Item("facturado")
            cfact.Checked = table.Rows(0).Item("facturado")

            registro.Referencia = table.Rows(0).Item("referencia")
            tfact.Text = registro.Referencia


            registro.Concepto = table.Rows(0).Item("concepto")
            tdesc.Text = registro.Concepto



            registro.Monto = table.Rows(0).Item("monto")
            ttotal.Text = table.Rows(0).Item("monto")

        Else

        End If
    End Sub


    Private Sub frmgastoscaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "GASTOS DE CAJA")

        limpiar()


    End Sub
    Private Sub bsalir_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub
    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub
    Private Sub limpiar()
        tfolio.Text = ""
        cfact.Checked = False
        tfact.Text = ""
        tfecha.Text = Format(Now, "yyyy-MM-dd")

        tdesc.Text = ""

        ttotal.Text = "0.00"

    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Len(tdesc.Text) = 0 Or Len(ttotal.Text) = 0 Then
            MsgBox("NO ES POSIBLE REGISTRAR EL EGRESO, ES NECESARIA MAS INFORMACIÓN", vbInformation + vbOKOnly, "EGRESOS")
            Exit Sub
        End If

        If CDbl(ttotal.Text) <= 0 Then
            MsgBox("NO ES POSIBLE REGISTRAR EL EGRESO, EL TOTAL NO PUEDE SER 0 O MENOR", vbInformation + vbOKOnly, "EGRESOS")
            Exit Sub
        End If




        registro.Fecha = CDate(tfecha.Text)
        registro.Facturado = cfact.CheckState
        registro.Referencia = tfact.Text

        registro.Concepto = tdesc.Text

        registro.Monto = CDbl(ttotal.Text)

        conn = New c_mysqlconn
        If flag = 1 Then
            conn = New c_mysqlconn
            If conn.insertarnuevo(registro) Then
                MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                frmcntagasto.consulta()
                Me.Dispose()
            Else
                MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            conn = New c_mysqlconn
            If conn.modificar(registro, registro.Id_gasto.ToString) Then
                MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmcntagasto.consulta()
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