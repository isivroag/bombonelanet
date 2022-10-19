Imports System.IO
Imports System.Math
Imports Microsoft.Office.Interop
Module principal
    Public globalusuario As String
    Public Function sacarclave(texto As String) As String
        Dim i As Integer
        Dim p As Integer
        If texto <> "" Then
            For i = 1 To Len(texto)
                If Mid(texto, i, 1) = " " Then
                    p = i
                    i = Len(texto)
                End If
            Next
            sacarclave = Left(texto, p - 1)
        Else
            sacarclave = ""
        End If

    End Function

    Public Function contenido(texto As String) As String
        contenido = Mid(texto, Len(sacarclave(texto)) + 2, Len(texto) - Len(sacarclave(texto)) + 1)

    End Function

    Public Function EnLetras(tyCantidad As Decimal) As String
        Dim lyCantidad As Decimal, lyCentavos As Decimal, lnDigito As Byte, lnPrimerDigito As Byte, lnSegundoDigito As Byte, lnTercerDigito As Byte, lcBloque As String, lnNumeroBloques As Byte, lnBloqueCero As Decimal
        tyCantidad = Round(tyCantidad, 2)
        lyCantidad = Int(tyCantidad)
        lyCentavos = (tyCantidad - lyCantidad) * 100
        Dim laUnidades As String()
        laUnidades = {"UN", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISEIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE", "VEINTE", "VEINTIUN", "VEINTIDOS", "VEINTITRES", "VEINTICUATRO", "VEINTICINCO", "VEINTISEIS", "VEINTISIETE", "VEINTIOCHO", "VEINTINUEVE"}
        Dim laDecenas As String()
        laDecenas = {"DIEZ", "VEINTE", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA"}
        Dim laCentenas As String()
        laCentenas = {"CIENTO", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS", "OCHOCIENTOS", "NOVECIENTOS"}
        lnNumeroBloques = 1
        Do
            lnPrimerDigito = 0
            lnSegundoDigito = 0
            lnTercerDigito = 0
            lcBloque = ""
            lnBloqueCero = 0
            For i = 1 To 3
                lnDigito = lyCantidad Mod 10
                If lnDigito <> 0 Then
                    Select Case i
                        Case 1
                            lcBloque = " " & laUnidades(lnDigito - 1)
                            lnPrimerDigito = lnDigito
                        Case 2
                            If lnDigito <= 2 Then
                                lcBloque = " " & laUnidades((lnDigito * 10) + lnPrimerDigito - 1)
                            Else
                                lcBloque = " " & laDecenas(lnDigito - 1) & IIf(lnPrimerDigito <> 0, " Y", Nothing) & lcBloque
                            End If
                            lnSegundoDigito = lnDigito
                        Case 3
                            lcBloque = " " & IIf(lnDigito = 1 And lnPrimerDigito = 0 And lnSegundoDigito = 0, "CIEN", laCentenas(lnDigito - 1)) & lcBloque
                            lnTercerDigito = lnDigito
                    End Select
                Else
                    lnBloqueCero = lnBloqueCero + 1
                End If
                lyCantidad = Int(lyCantidad / 10)
                If lyCantidad = 0 Then
                    Exit For
                End If
            Next i
            Select Case lnNumeroBloques
                Case 1
                    EnLetras = lcBloque
                Case 2
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
                    EnLetras = lcBloque & IIf(lnBloqueCero = 3, Nothing, " MIL") & EnLetras
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
                Case 3
                    EnLetras = lcBloque & IIf(lnPrimerDigito = 1 And lnSegundoDigito = 0 And lnTercerDigito = 0, " MILLON", " MILLONES") & EnLetras
            End Select
            lnNumeroBloques = lnNumeroBloques + 1
        Loop Until lyCantidad = 0
        EnLetras = "(" & EnLetras & IIf(tyCantidad > 1, " PESOS ", " PESO ") & Format(lyCentavos, "00") & "/100 M.N. )"
    End Function


    Public Function formatomoneda(ByVal Tabla As DataGridView, ByVal num As Integer, ByVal pesos As Boolean) As Integer
        If pesos = True Then
            Tabla.Columns(num).DefaultCellStyle.Format = "c2"
        Else
            'Tabla.Columns(num).DefaultCellStyle.Format = "D2"
        End If
        Tabla.Columns(num).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Return 0
    End Function


    Public Function solonumeros(ByVal sender As Object, ByVal e As KeyPressEventArgs) As Integer
        Dim cadena As String
        Dim i As Integer
        Dim at As Integer

        cadena = "0123456789." + Chr(8)
        If Strings.InStr(cadena, e.KeyChar.ToString) = 0 Then
            e.KeyChar = ""
        End If

        Do While i < Strings.Len(sender.Text)
            If Mid(sender.Text, i + 1, 1) = "." Then
                at = 1
            End If
            i = i + 1
        Loop

        If at = 1 And e.KeyChar = Chr(46) Then
            e.KeyChar = ""
        End If
        Return 0
    End Function

    Public Function mayus(ByVal cuadro As TextBox) As Integer
        cuadro.Text = UCase(cuadro.Text)
        cuadro.SelectionStart = cuadro.TextLength + 1
        Return 0
    End Function

    Public Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    Public Function directorio(ByVal carpeta As String) As Boolean

        If Directory.Exists(carpeta) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function creardirectorio(ByVal carpeta As String) As Boolean

        If Directory.Exists(carpeta) Then
            Return False
        Else
            My.Computer.FileSystem.CreateDirectory(carpeta)
            Return True
        End If
    End Function
    Public Function archivo(ByVal arc As String) As Boolean

        If My.Computer.FileSystem.FileExists(arc) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function copiararchivo(ByVal origen As String, ByVal destino As String) As Boolean
        My.Computer.FileSystem.CopyFile(
    origen,
    destino,
    Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
    Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        Return 1
    End Function
    Public Sub ExportarDatosExcel2(ByVal DataGridView1 As DataGridView, ByVal titulo As String)
        Dim m_Excel As New Excel.Application
        m_Excel.Cursor = Excel.XlMousePointer.xlWait
        m_Excel.Visible = True
        Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
        Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        With objHojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            'Encabezado  


            Const primeraLetra As Char = "A"
            Const primerNumero As Short = 3
            Dim Letra As Char, UltimaLetra As Char
            Dim Numero As Integer, UltimoNumero As Integer
            Dim cod_letra As Byte = Asc(primeraLetra) - 1
            Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
            Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
            'Establecer formatos de las columnas de la hoja de cálculo  
            Dim strColumna As String = ""
            Dim LetraIzq As String = ""
            Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
            Letra = primeraLetra
            Numero = primerNumero
            Dim objCelda As Excel.Range
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        cod_LetraIzq += 1
                        LetraIzq = Chr(cod_LetraIzq)
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                    strColumna = LetraIzq + Letra + Numero.ToString
                    objCelda = .Range(strColumna, Type.Missing)
                    objCelda.Value = c.HeaderText
                    objCelda.EntireColumn.Font.Size = 8
                    objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format
                    If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                        objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"

                    End If
                End If
            Next

            Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
            objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            UltimaLetra = Letra
            Dim UltimaLetraIzq As String = LetraIzq




            'CARGA DE DATOS  
            Dim i As Integer = Numero + 1
            Dim f As Integer = Numero + 1

            For Each reg As DataGridViewRow In DataGridView1.Rows
                LetraIzq = ""
                cod_LetraIzq = Asc(primeraLetra) - 1
                Letra = primeraLetra
                cod_letra = Asc(primeraLetra) - 1
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Chr(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + Letra
                        ' acá debería realizarse la carga  
                        If c.ValueType Is GetType(Date) Then
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", Format(reg.Cells(c.Index).Value, "yyyy-MM-dd"))
                        Else
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value.ToString())
                        End If


                        '.Cells(i, strColumna) = IIf(IsDBNull(reg.(c.DataPropertyName)), c.DefaultCellStyle.NullValue, reg(c.DataPropertyName))  
                        '.Range(strColumna + i, strColumna + i).In()  

                    End If
                Next
                Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                objRangoReg.Rows.BorderAround()
                objRangoReg.Select()
                i += 1
            Next
            UltimoNumero = i

            'Dibujar las líneas de las columnas  
            LetraIzq = ""
            cod_LetraIzq = Asc("A")
            cod_letra = Asc(primeraLetra)
            Letra = primeraLetra
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                    objCelda.BorderAround()
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        LetraIzq = Chr(cod_LetraIzq)
                        cod_LetraIzq += 1
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                End If
            Next

            'Dibujar el border exterior grueso  
            .Range(primeraLetra + "1", UltimaLetraIzq + UltimaLetra + "1").Merge()
            .Range(primeraLetra + "1", UltimaLetraIzq + UltimaLetra + "1").Value = "SISTEMA DE CONTROL"
            .Range(primeraLetra + "1", UltimaLetraIzq + UltimaLetra + "1").Font.Bold = True
            .Range(primeraLetra + "1", UltimaLetraIzq + UltimaLetra + "1").Font.Size = 15
            'Copete  
            .Range(primeraLetra + "2", UltimaLetraIzq + UltimaLetra + "2").Merge()
            .Range(primeraLetra + "2", UltimaLetraIzq + UltimaLetra + "2").Value = titulo
            .Range(primeraLetra + "2", UltimaLetraIzq + UltimaLetra + "2").Font.Bold = True
            .Range(primeraLetra + "2", UltimaLetraIzq + UltimaLetra + "2").Font.Size = 12
            .Range(primeraLetra + "3", UltimaLetraIzq + UltimaLetra + "3").Font.Bold = True
            .Range(primeraLetra + "3", UltimaLetraIzq + UltimaLetra + "3").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)

            objRango.Select()

            objRango.Columns.AutoFit()
            objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        End With

        m_Excel.Cursor = Excel.XlMousePointer.xlDefault
        m_Excel = Nothing
    End Sub

    Public Sub inicial(ByVal sender As Object, ByVal e As EventArgs, ByVal texto As String)

        Dim forma As Form = TryCast(sender, Form)
        forma.Text = "BOMBONELA: " & texto
        forma.MaximizeBox = False
        forma.MinimizeBox = False

        forma.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub
End Module