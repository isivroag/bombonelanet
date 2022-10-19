Imports MySql.Data.MySqlClient
Public Class frmcabina
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_cabina
    Dim tabla As New DataTable
    Public flag As Integer
    Dim col As Color
    Public Sub mostrar(ByVal registro As c_cabina)
        datos = registro
        tid.Text = registro.Id_cabina
        tnombre.Text = registro.Nom_cabina
        If registro.Color_cabina <> "" Then
            tcolor.BackColor = Color.FromArgb(registro.Color_cabina)
        Else
            tcolor.BackColor = Color.White
        End If


    End Sub

    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""
        tcolor.BackColor = Color.White
        col = Color.White
    End Sub


    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 Then
            datos.Nom_cabina = UCase(tnombre.Text)
            datos.Color_cabina = col.ToArgb

            If flag = 1 Then
                conn = New c_mysqlconn
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntacabina.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_cabina.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntacabina.consulta()
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

    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs) Handles tnombre.LostFocus
        mayus(sender)
    End Sub
    Private Sub frmcabina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then

            col = ColorDialog.Color
            'tcolor.BackColor = Color.FromArgb(color.ToArgb)

            tcolor.BackColor = col
        End If
    End Sub

End Class