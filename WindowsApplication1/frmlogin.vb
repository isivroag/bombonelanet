Imports MySql.Data.MySqlClient
Public Class frmlogin
    Dim conn As New c_mysqlconn
    Dim usuario As String
    Dim contraseña As String
    Dim consulta As String
    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btaceptar_Click(sender As Object, e As EventArgs) Handles btaceptar.Click
        consulta = "select * from usuario where login='" & tlogin.Text & "' and password='" & tpassword.Text & "'"
        conn = New c_mysqlconn

        If conn.entrar(consulta) = True Then
            globalusuario = tlogin.Text
            MsgBox("BIENVENIDO", vbOKOnly + vbInformation, "INGRESO SISTEMA BOMBONELA")
            'MessageBox.Show("BIENVENIDO", "INGRESO SISTEMA BOMBONELA", MessageBoxButtons.O, MessageBoxIcon.Information)
            Me.Hide()
            frmprincipal.Show()

        Else
            MsgBox("ACCESO DENEGADO", vbOKOnly + vbInformation, "ENTRAR")
        End If
    End Sub
End Class