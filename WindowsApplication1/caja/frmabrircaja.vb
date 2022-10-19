Imports MySql.Data.MySqlClient

Public Class frmabrircaja
    Dim conn As c_mysqlconn
    Dim tabla As DataTable
    Public fecha As DateTime
    Public sql As String
    Dim caja As New c_caja
    Dim montoini As Double
    Dim opc As Int32

    Public Sub consulta()

        sql = "select * from caja where fecha='" & Format(fecha, "yyyy-MM-dd") & "'and estado_caja<>0"
        tabla = New DataTable
        conn = New c_mysqlconn


        tabla = conn.consulta(sql)

        If tabla.Rows.Count = 0 Then
            MsgBox("No Existe Registro de Apertura de Caja", vbCritical + vbOKOnly, "APERTURA DE CAJA")
            montoini = 0
            opc = 1
        Else
            montoini = tabla.Rows(0).Item("inicial")
            opc = 2
        End If

        tinicial.Text = montoini
    End Sub
    Private Sub frmabrircaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "APERTURA DE CAJA")
        dtFecha.Value = Format(Now, "yyyy-MM-dd")
        fecha = (New Date(dtFecha.Value.Year, dtFecha.Value.Month, dtFecha.Value.Day, 0, 0, 0))
        consulta()
    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()


    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        conn = New c_mysqlconn
        If opc = 2 Then
            If (MsgBox("YA EXISTE UN MONTO DE APERTURA PARA ESTE DIA" + Environment.NewLine + "¿DESEA MODIFICARL?", vbQuestion + vbYesNo, "APERTURA DE CAJA") = vbYes) Then
                If conn.modificarapertura(CDbl(tinicial.Text), Format(dtFecha.Value, "yyyy-MM-dd")) Then
                    MsgBox("MONTO DE APERTURA ACTUALIZADO", vbInformation + vbOKOnly, "APERTURA DE CAJA")
                Else
                    MsgBox("MONTO DE APERTURA NO ACTUALIZADO", vbCritical + vbOKOnly, "APERTURA DE CAJA")
                End If
            End If

        Else

            caja = New c_caja
            caja.Inicial = CDbl(tinicial.Text())
            caja.Fecha = Format(dtFecha.Value, "yyyy-MM-dd")


            If conn.insertarnuevo(caja) Then
                MsgBox("MONTO DE APERTURA REGISTRADO", vbInformation + vbOKOnly, "APERTURA DE CAJA")
            Else
                MsgBox("MONTO DE APERTURA NO REGISTRADO", vbCritical + vbOKOnly, "APERTURA DE CAJA")
            End If
        End If

    End Sub
End Class