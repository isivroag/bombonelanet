Imports MySql.Data.MySqlClient

Public Class frmproducto
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_producto
    Dim tabla As New DataTable
    Dim id_producto As Integer
    Public flag As Integer

    Private Sub combo()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from marca order by id_marca")
        cmarca.Items.Clear()
        For Each row As DataRow In tabla.Rows
            cmarca.Items.Add(row("nom_marca"))
        Next row


    End Sub
    Public Sub mostrar(ByVal registro As c_producto)
        datos = registro
        tid.Text = registro.Id_prod
        tclave.Text = registro.Clave_prod
        tnombre.Text = registro.Nom_prod
        cunidad.Text = registro.Unidad_prod
        tprecio.Text = registro.Precio_prod
        tmin.Text = registro.Min_prod
        cvend.Checked = registro.Vendible_prod
        tcosto.text = registro.Costo_prod
        cmarca.Text = registro.Nom_marca

    End Sub

    Private Sub limpiar()
        tid.Text = ""
        tclave.Text = ""
        tnombre.Text = ""
        cunidad.Text = ""
        tprecio.Text = ""
        tmin.Text = ""
        tcosto.text = ""
        cvend.Checked = False
        cmarca.Text = ""
        id_producto = Nothing


    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 And Len(tprecio.Text) > 0 Then
            datos.Clave_prod = tclave.Text
            datos.Nom_prod = tnombre.Text
            datos.Unidad_prod = cunidad.Text
            datos.Precio_prod = tprecio.Text
            datos.Min_prod = tmin.Text
            datos.Vendible_prod = cvend.Checked
            datos.Costo_prod = tcosto.Text
            datos.Nom_marca = cmarca.Text



            'revisar
            If flag = 1 Then

                conn = New c_mysqlconn
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntaproducto.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_prod.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntaproducto.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("¡Verifique Sus Datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs) Handles tnombre.LostFocus, tclave.LostFocus
        mayus(sender)
    End Sub
    Private Sub frmproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        combo()
    End Sub



End Class