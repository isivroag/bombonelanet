Imports MySql.Data.MySqlClient

Public Class frmauxhorario
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Dim dia As Integer
    Public flag As Integer
    Dim datos As c_horariocol
    Public id_col As Integer
    Public id_reg As Integer


    Public Sub mostrar(registro As c_horariocol)
        datos = registro
        id_reg = datos.Id_reg
        cdia.SelectedIndex = datos.Id_dia
        cdia.Text = datos.Dia
        chora.Text = datos.Entrada.ToString
        chora2.Text = datos.Salida.ToString


    End Sub
    Private Sub combohora()
        chora.Items.Clear()
        chora2.Items.Clear()
        conn = New c_mysqlconn
        tabla = New DataTable
        tabla = conn.consulta("select * from horagral where dia='" & dia & "'")
        If tabla.Rows.Count > 0 Then
            Dim entrada As DateTime
            Dim salida As DateTime
            entrada = Convert.ToString(tabla.Rows(0).Item("entrada"))
            salida = Convert.ToString(tabla.Rows(0).Item("salida"))

            While entrada <= salida
                chora.Items.Add(Format(entrada, "HH:mm"))
                chora2.Items.Add(Format(entrada, "HH:mm"))
                entrada = entrada.AddMinutes(15)

            End While



        End If
    End Sub

    Private Sub combodia()
        conn = New c_mysqlconn
        tabla = New DataTable
        tabla = conn.consulta("select * from dia order by id_dia")
        For Each row As DataRow In tabla.Rows
            'cdia.Items.Add(Convert.ToInt32(row.Item("id_dia")) + 1 & " " & row.Item("nom_dia"))
            cdia.Items.Add(row.Item("nom_dia"))

        Next
    End Sub
    Private Sub frmauxhorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "DETALLE HORARIO")
        combodia()
    End Sub



    Private Sub cdia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cdia.SelectedValueChanged
        dia = cdia.SelectedIndex
        combohora()
    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(cdia.Text) > 0 Then
            datos = New c_horariocol

            datos.Id_col = id_col

            datos.Id_dia = cdia.SelectedIndex
            datos.Dia = cdia.Text
            datos.Entrada = TimeSpan.Parse(chora.Text)
            datos.Salida = TimeSpan.Parse(chora2.Text)



            'revisar
            If flag = 1 Then

                conn = New c_mysqlconn
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmhorariocol.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, id_reg) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmhorariocol.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("¡Verifique Sus Datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class