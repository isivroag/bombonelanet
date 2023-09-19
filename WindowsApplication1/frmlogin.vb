Imports MySql.Data.MySqlClient
Public Class frmlogin
    Dim conn As New c_mysqlconn
    Dim usuario As String
    Dim contraseña As String
    Dim consulta As String
    Dim username As String
    Dim rol As Int32
    Dim nrol As String
    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btaceptar_Click(sender As Object, e As EventArgs) Handles btaceptar.Click
        consulta = "select * from usuario where login='" & tlogin.Text & "' and password='" & tpassword.Text & "'"
        conn = New c_mysqlconn

        If conn.entrar(consulta) = True Then
            conn = New c_mysqlconn
            username = conn.Obtener_dato("select nombre as dato from usuario where login='" & tlogin.Text & "' and password='" & tpassword.Text & "'")
            globalusuario = username

            conn = New c_mysqlconn
            rol = conn.Obtener_dato("select rol_usuario as dato from usuario where login='" & tlogin.Text & "' and password='" & tpassword.Text & "'")
            globalrol = rol

            conn = New c_mysqlconn
            nrol = conn.Obtener_dato("select rol as dato from vusuario where login='" & tlogin.Text & "' and password='" & tpassword.Text & "'")
            globalnrol = UCase(nrol)

            MsgBox("BIENVENIDO", vbOKOnly + vbInformation, "INGRESO SISTEMA BOMBONELA")
            'MessageBox.Show("BIENVENIDO", "INGRESO SISTEMA BOMBONELA", MessageBoxButtons.O, MessageBoxIcon.Information)
            Me.Hide()
            frmprincipal.username = username
            frmprincipal.rol = rol
            frmprincipal.nrol = UCase(nrol)
            frmprincipal.barra()
            frmprincipal.permisos()
            frmprincipal.Show()






        Else
            MsgBox("ACCESO DENEGADO", vbOKOnly + vbInformation, "ENTRAR")
        End If
    End Sub
End Class