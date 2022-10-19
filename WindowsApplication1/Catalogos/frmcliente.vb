Imports MySql.Data.MySqlClient

Public Class frmcliente
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_cliente
    Dim tabla As New DataTable
    Public flag As Integer
    Public prospecto As String


    Public Sub buscarprospecto()
        conn = New c_mysqlconn
        tabla = New DataTable
        tabla = conn.consulta("select * from prospecto where id_pros='" & prospecto & "'")
        If tabla.Rows.Count > 0 Then
            tnombre.Text = tabla.Rows(0).Item("nom_pros")
            tcel.Text = tabla.Rows(0).Item("cel_pros")
            ttel.Text = tabla.Rows(0).Item("tel_pros")
            temail.Text = tabla.Rows(0).Item("correo_pros")
        End If

    End Sub
    Public Sub mostrar(ByVal registro As c_cliente)
        datos = registro
        tid.Text = datos.Id_clie
        trfc.Text = datos.Rfc_clie
        tnombre.Text = datos.Nom_clie
        tcalle.Text = datos.Calle_clie
        tnum.Text = datos.Num_clie
        tcol.Text = datos.Col_clie
        tcp.Text = datos.Cp_clie
        tmun.Text = datos.Mun_clie
        tedo.Text = datos.Edo_clie
        tcel.Text = datos.Cel_clie
        ttel.Text = datos.Tel_clie
        tnac.Text = datos.Nac_clie
        ttipoid.Text = datos.Doc_clie
        tnumid.Text = datos.Docid_clie
        temail.Text = datos.Correo_clie
        tpiel.Text = datos.Piel_clie
        tojos.Text = datos.Ojos_clie
        tpelo.Text = datos.Pelo_clie

        cgenero.Text = datos.Gen_clie
        cnivel.Text = datos.Niv_clie
        tocupacion.Text = datos.Ocupacion_clie

        cestado.Text = datos.Ecivil_clie
        dtaniv.Value = datos.Aniv_clie
        thijos.Text = datos.Hijos_clie

        tfb.Text = datos.Fb_clie
        ttw.Text = datos.Tw_clie
        tinsta.Text = datos.Insta_clie
    End Sub
    Private Sub limpiar()
        tid.Text = ""
        trfc.Text = ""
        tnombre.Text = ""
        tcalle.Text = ""
        tcol.Text = ""
        tcp.Text = ""
        tmun.Text = ""
        tedo.Text = ""
        tnum.Text = ""
        tnac.Value = Format(Now, "yyyy-MM-dd")
        ttipoid.Text = ""
        tnumid.Text = ""
        tcel.Text = ""
        ttel.Text = ""
        temail.Text = ""
        tojos.Text = ""
        tpiel.Text = ""
        tpelo.Text = ""

        cgenero.Text = ""
        cnivel.Text = ""
        tocupacion.Text = ""

        cestado.Text = ""
        dtaniv.Value = New Date("1900", "01", "01")
        thijos.Text = ""

        tfb.Text = ""
        ttw.Text = ""
        tinsta.Text = ""

    End Sub
    Private Sub frmcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CATALOGO DE VISITANTES")
        limpiar()
    End Sub
    Private Sub bcancelar_Click_1(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()

    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 And Strings.Len(tcel.Text) > 0 Then

            datos.Rfc_clie = trfc.Text
            datos.Nom_clie = tnombre.Text
            datos.Calle_clie = tcalle.Text
            datos.Num_clie = tnum.Text
            datos.Col_clie = tcol.Text
            datos.Cp_clie = tcp.Text
            datos.Mun_clie = tmun.Text
            datos.Edo_clie = tedo.Text
            datos.Cel_clie = tcel.Text
            datos.Tel_clie = ttel.Text
            datos.Correo_clie = temail.Text
            datos.Docid_clie = tnumid.Text
            datos.Doc_clie = ttipoid.Text
            datos.Nac_clie = Format(tnac.Value, "yyyy-MM-dd")
            datos.Piel_clie = tpiel.Text
            datos.Ojos_clie = tojos.Text
            datos.Pelo_clie = tpelo.Text


            datos.Gen_clie = cgenero.Text
            datos.Niv_clie = cnivel.Text
            datos.Ocupacion_clie = tocupacion.Text

            datos.Ecivil_clie = cestado.Text
            datos.Aniv_clie = Format(dtaniv.Value, "yyyy-MM-dd")
            datos.Hijos_clie = thijos.Text

            datos.Fb_clie = tfb.Text
            datos.Tw_clie = ttw.Text
            datos.Insta_clie = tinsta.Text


            If flag = 1 Or flag = 3 Then
                conn = New c_mysqlconn
                datos.Alta_clie = Format(Now, "yyyy-MM-dd")
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If flag = 1 Then
                        frmcntacliente.consulta()
                        Me.Dispose()
                    Else
                        conn = New c_mysqlconn
                        Dim clave As String
                        clave = conn.Obtener_ID("select max(id_clie) as max_id from cliente")
                        frmvisita.tid_clie.Text = clave

                        frmvisita.idpersona = clave
                        frmvisita.tipo = 1
                        Dispose()

                    End If

                    If prospecto <> 0 Then
                        conn = New c_mysqlconn
                        conn.actualizarprospecto(prospecto)

                    End If

                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_clie.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntacliente.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        Else
            MessageBox.Show("¡Verifique Sus Datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub



    Private Sub sinfoco(sender As Object, e As EventArgs) Handles trfc.LostFocus, tcol.LostFocus, tnombre.LostFocus, tcalle.LostFocus, tmun.LostFocus, tedo.LostFocus, ttipoid.LostFocus, tnumid.LostFocus, tojos.LostFocus, tpelo.LostFocus, tocupacion.LostFocus
        mayus(sender)
    End Sub

    Private Sub temail_TextChanged(sender As Object, e As EventArgs) Handles temail.TextChanged

    End Sub

    Private Sub tpelo_TextChanged(sender As Object, e As EventArgs) Handles tpelo.TextChanged

    End Sub
End Class