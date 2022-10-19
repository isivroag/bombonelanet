Imports MySql.Data.MySqlClient
Public Class frmproveedor
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_proveedor
    Dim tabla As New DataTable
    Public flag As Integer
    Dim alta_col As Date

    Public Sub mostrar(ByVal registro As c_proveedor)
        datos = registro
        tid.Text = registro.Id_prov
        tnombre.Text = registro.Nom_prov
        tdir.Text = registro.Direccion
        ttel.Text = registro.Tel
        tcel.Text = registro.Cel
        tcorreo.Text = registro.Correo
        trfc.Text = registro.Rfc

    End Sub

    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""
        tdir.Text = ""
        ttel.Text = ""
        tcel.Text = ""
        tcorreo.Text = ""
        trfc.Text = ""


    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 Then
            datos.Nom_prov = tnombre.Text
            datos.Direccion = tdir.Text
            datos.Tel = ttel.Text
            datos.Cel = tcel.Text
            datos.Correo = tcorreo.Text
            datos.Rfc = trfc.Text


            'revisar
            If flag = 1 Then

                conn = New c_mysqlconn
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntaproveedor.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_prov.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntaproveedor.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("¡Verifique Sus Datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub frmproveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CATALOGO DE PROVEEDORES")
        limpiar()

    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs) Handles tnombre.LostFocus, tdir.LostFocus, trfc.LostFocus
        mayus(sender)
    End Sub



End Class