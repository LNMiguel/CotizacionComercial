Imports Janus.Windows.GridEX
Imports System.Runtime.InteropServices.Marshal
Imports ADODB
Imports LibraryVB
Module mdlGeneral
#If DEBUG Then
    Public ReadOnly IsDebugMode As Boolean = True
#Else
        Public ReadOnly IsDebugMode As Boolean = FALSE
#End If

#Region " Variables Publicas "

    Public cCONNECT As String
    Public cSEGURIDAD As String
    Public cCONNECTVB6 As String
    Public cSEGURIDADVB6 As String

    Public cCONNECT_Prueba As String = "Initial Catalog=sige_stn;Data Source=192.168.30.58;uid=SGPusuarios;pwd=SGPusuarios"
    Public cSEGURIDAD_Prueba As String = "Initial Catalog=Seguridad;Data Source=192.168.30.58;uid=SGPusuarios;pwd=SGPusuarios"
    Public cCONNECTVB6_Prueba As String = "Provider=SQLOLEDB.1;Initial Catalog=sige_stn;Data Source=192.168.30.58;uid=SGPusuarios;pwd=SGPusuarios"
    Public cSEGURIDADVB6_Prueba As String = "Provider=SQLOLEDB.1;Initial Catalog=Seguridad;Data Source=192.168.30.58;uid=SGPusuarios;pwd=SGPusuarios"

    Public cConexionORACLE As String
    Public sStoredProcedureSQL As String
    Public sStoredProcedureORACLE As String

    Public vusu As String
    Public vemp As String
    Public vRuta As String
    Public vper As String

    Public vemp1 As String
    Public vpas As String
    Public vNomFor As String
    Public gsCod_Opcion As String
    Public bCargaConexion As Boolean

    Public oMDIParent As Object
    Public iLanguage As Integer
    Public oParent As Object
    Public sAnoPeriodoContableVigente As String
    Public sAnoContableVigente As String
    Public sPeriodoContableVigente As String

    'Public frmRegistroPO_Man_Adicionar_Estilo As New frmRegistroPO_Man_Adicionar_Estilo

#End Region

    Public Const CONS_MENSAJE_CONFIRMACION_ELIMINAR As String = "¿Seguro que desea eliminar?"
    Public Const CONS_FORMATO_KGS As String = "######.00"
    Public Declare Function Captura2 Lib "CommLib32.dll" () As Long

#Region " Procedimientos y Funciones Generales "

#Region " Verificar Columnas de un DataSource para una grilla Janus "

    Public Sub CheckLayoutGridEx(ByRef poGrid As Janus.Windows.GridEX.GridEX)
        Dim oDataSet As DataSet
        Dim oDataTable As DataTable
        Dim oColumnGrid As Janus.Windows.GridEX.GridEXColumn
        Dim bFound As Boolean

        If poGrid.DataSource Is Nothing Then Return
        If poGrid.RootTable Is Nothing Then Return

        poGrid.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        poGrid.HideSelection = HideSelection.Highlight

        If TypeOf poGrid.DataSource Is DataSet Then
            oDataSet = CType(poGrid.DataSource, DataSet)
            oDataTable = oDataSet.Tables(0)
        Else
            oDataTable = CType(poGrid.DataSource, DataTable)
        End If


        '// first check if there are columns removed from the source
        'For Each oGridEXColum As Janus.Windows.GridEX.GridEXColumn In poGrid.RootTable.Columns()
        '    bFound = False
        '    If oGridEXColum.FormatString = "c" Then
        '        oGridEXColum.FormatString = ""
        '        oGridEXColum.TextAlignment = TextAlignment.Far
        '        oGridEXColum.Trimming = Trimming.NoTrimming
        '    End If

        '    For Each oDataColumn As DataColumn In oDataTable.Columns
        '        If oDataColumn.ColumnName = oGridEXColum.Key Then
        '            bFound = True
        '            Exit For
        '        End If
        '    Next

        '    'If Not bFound Then
        '    '    Try
        '    '        poGrid.Layouts.Remove(poGrid.CurrentLayout)
        '    '    Catch
        '    '    End Try
        '    '    poGrid.RetrieveStructure()
        '    '    Exit For
        '    'End If
        'Next

        '// then check if there are new columns in the source and add them to the layout
        For Each oDataColumn As DataColumn In oDataTable.Columns
            bFound = False
            For Each oGridEXColum As Janus.Windows.GridEX.GridEXColumn In poGrid.RootTable.Columns()
                With oGridEXColum
                    If .FormatString = "c" Then
                        .FormatString = ""
                        .TextAlignment = TextAlignment.Far
                        .Trimming = Trimming.NoTrimming
                    End If
                End With
                If oDataColumn.ColumnName.ToString.Trim.ToUpper = oGridEXColum.Key.ToString.Trim.ToUpper Then
                    bFound = True
                    Exit For
                End If
            Next

            'If Not bFound Then
            If bFound = False Then
                oColumnGrid = New GridEXColumn(oDataColumn.Caption, Janus.Windows.GridEX.ColumnType.Text)
                With oColumnGrid
                    If .FormatString = "c" Then
                        .FormatString = ""
                        .TextAlignment = TextAlignment.Far
                        .Trimming = Trimming.NoTrimming
                    End If
                End With
                poGrid.RootTable.Columns.Insert(oDataColumn.Ordinal, oColumnGrid)
            End If
        Next

        With poGrid
            .AlternatingColors = False
            .VisualStyle = VisualStyle.Office2010
            .OfficeColorScheme = OfficeColorScheme.Blue
            .RootTable.PreviewRowFormatStyle = New Janus.Windows.GridEX.GridEXFormatStyle With {.ForeColor = Color.Blue,
                                                                                                .FontItalic = TriState.True,
                                                                                                .BackColor = Color.LightYellow}
            .RootTable.GroupRowFormatStyle = New Janus.Windows.GridEX.GridEXFormatStyle With {.ForeColor = Color.Blue,
                                                                                              .FontName = "TAHOMA",
                                                                                              .FontSize = 8,
                                                                                              .FontBold = TriState.True}

            .RootTable.HeaderFormatStyle = New Janus.Windows.GridEX.GridEXFormatStyle With {.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center,
                                                                                            .FontBold = TriState.True,
                                                                                            .FontSize = 7,
                                                                                            .FontName = "VERDANA"}

            .RootTable.RowFormatStyle = New Janus.Windows.GridEX.GridEXFormatStyle With {.FontName = "tahoma",
                                                                                         .FontSize = 8}

            .RootTable.TotalRowFormatStyle = New Janus.Windows.GridEX.GridEXFormatStyle With {.FontName = "tahoma",
                                                                                              .FontSize = 8,
                                                                                              .FontBold = TriState.True}
            For Each oGridEXColumn As Janus.Windows.GridEX.GridEXColumn In poGrid.RootTable.Columns
                With oGridEXColumn
                    .Caption = oGridEXColumn.Caption.Trim.ToUpper
                End With
            Next
        End With
    End Sub

#End Region
    Public Function get_botones1(ByVal f As Form, ByVal Vcod_perfil As Object, ByVal vcod_empresa As Object, ByVal fname As Object)
        On Error GoTo hand
        Dim oCn As New ADODB.Connection
        Dim RS1 As ADODB.Recordset
        RS1 = New ADODB.Recordset
        Dim SQuery As String
        SQuery = "SEG_MUESTRA_ACCESOS_FORMULARIOS_FUNCION '" & Vcod_perfil & "','" & vcod_empresa & "','" & fname & "'"

        Dim oDa As New SqlClient.SqlDataAdapter(SQuery, cSEGURIDAD)
        Dim oDt As New DataTable
        oDa.Fill(oDt)

        RS1 = ConvertToRecordset(oDt)



        Dim Scad As String = ""
        Dim ICONT As Integer
        If Not (RS1.BOF And RS1.EOF) Then
            'For j = 1 To rs1.RecordCount
            ICONT = 1
            RS1.MoveFirst()
            While Not RS1.EOF
                If ICONT = 1 Then
                    Scad = LTrim(RTrim(RS1.Fields("nom_corto").Value))
                Else
                    Scad = Scad + "/" + LTrim(RTrim(RS1.Fields("nom_corto").Value))
                End If
                RS1.MoveNext()
                ICONT = ICONT + 1
            End While
        End If
        get_botones1 = Scad
        Exit Function
hand:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Function

#Region " Obtener DataRow de GridEx "

    Function ObtenerDr_DeGridEx(ByVal xGridEx As GridEX) As DataRow
        Try
            If (CType(xGridEx.DataSource, DataTable) Is Nothing) OrElse
               (CType(xGridEx.DataSource, DataTable).Rows.Count = 0) Then
                Return Nothing
            Else
                Dim oDrGrx As GridEXRow = xGridEx.GetRow
                Dim oDrV As DataRowView = oDrGrx.DataRow
                Dim oDr As DataRow = Nothing
                If Not (oDrV Is Nothing) Then oDr = oDrV.Row

                Return oDr
            End If
        Catch xErr As Exception
            Dim oDr As DataRow = Nothing
            MsgBox(xErr.Message, MsgBoxStyle.Critical)
            Return oDr
        End Try
    End Function

#End Region

#Region " Convertir Datatable a Recordset "
    Function ConvertToRecordset(ByVal inTable As DataTable) As ADODB.Recordset

        Try
            Dim result As New ADODB.Recordset()
            result.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            Dim resultFields As ADODB.Fields = result.Fields
            Dim inColumns As System.Data.DataColumnCollection = inTable.Columns

            For Each inColumn As DataColumn In inColumns
                resultFields.Append(inColumn.ColumnName, TranslateType(inColumn.DataType), inColumn.MaxLength, IIf(inColumn.AllowDBNull,
                     ADODB.FieldAttributeEnum.adFldIsNullable, ADODB.FieldAttributeEnum.adFldUnspecified), Nothing)
            Next

            result.Open(System.Reflection.Missing.Value, System.Reflection.Missing.Value, ADODB.CursorTypeEnum.adOpenStatic,
                     ADODB.LockTypeEnum.adLockOptimistic, 0)

            For Each dr As DataRow In inTable.Rows
                result.AddNew(System.Reflection.Missing.Value, System.Reflection.Missing.Value)
                For columnIndex As Integer = 0 To inColumns.Count - 1
                    resultFields(columnIndex).Value = dr(columnIndex)
                Next
            Next
            Return result
        Catch xErr As Exception
            Dim result As ADODB.Recordset = Nothing
            MsgBox(xErr.Message, MsgBoxStyle.Critical)
            Return result 'DBNull.Value   'CAR  DECIA result
        End Try
    End Function

    Function TranslateType(ByVal columnType As Type) As ADODB.DataTypeEnum
        Select Case columnType.UnderlyingSystemType.ToString()
            Case "System.Boolean"
                Return ADODB.DataTypeEnum.adBoolean
            Case "System.Byte"
                Return ADODB.DataTypeEnum.adUnsignedTinyInt
            Case "System.Char"
                Return ADODB.DataTypeEnum.adChar
            Case "System.DateTime"
                Return ADODB.DataTypeEnum.adDate
            Case "System.TimeSpan"
                Return ADODB.DataTypeEnum.adDate
            Case "System.Decimal"
                Return ADODB.DataTypeEnum.adCurrency
            Case "System.Double"
                Return ADODB.DataTypeEnum.adDouble
            Case "System.Int16"
                Return ADODB.DataTypeEnum.adSmallInt
            Case "System.Int32"
                Return ADODB.DataTypeEnum.adInteger
            Case "System.Int64"
                Return ADODB.DataTypeEnum.adBigInt
            Case "System.SByte"
                Return ADODB.DataTypeEnum.adTinyInt
            Case "System.Single"
                Return ADODB.DataTypeEnum.adSingle
            Case "System.UInt16"
                Return ADODB.DataTypeEnum.adUnsignedSmallInt
            Case "System.UInt32"
                Return ADODB.DataTypeEnum.adUnsignedInt
            Case "System.UInt64"
                Return ADODB.DataTypeEnum.adUnsignedBigInt
            Case "System.String"
                Return ADODB.DataTypeEnum.adVarChar
            Case Else
                Return ADODB.DataTypeEnum.adVarChar
        End Select
    End Function
#End Region

    'Function SoloNumeros(ByVal Keyascii As Short) As Short
    '    If InStr("1234567890", Chr(Keyascii)) = 0 Then
    '        SoloNumeros = 0
    '    Else
    '        SoloNumeros = Keyascii
    '    End If
    '    Select Case Keyascii
    '        Case 8
    '            SoloNumeros = Keyascii
    '        Case 13
    '            SoloNumeros = Keyascii
    '    End Select
    'End Function

    Function CompletarTextoConCaracter(ByVal strTexto As String, ByVal strCaracter As String, ByVal intLongitud As Integer, ByVal Alinear As LeftRightAlignment) As String
        Dim strTextoAutoCompletado As String = ""
        Dim strTextoRelleno As String = ""

        For i As Integer = 1 To intLongitud
            strTextoRelleno += strCaracter
        Next
        If Alinear = LeftRightAlignment.Left Then
            strTextoAutoCompletado = Right(strTextoRelleno + strTexto.Trim(), intLongitud)
        End If
        If Alinear = LeftRightAlignment.Right Then
            strTextoAutoCompletado = Left(strTexto.Trim() + strTextoRelleno, intLongitud)
        End If
        Return strTextoAutoCompletado
    End Function


#End Region

    Public Sub Mensaje(ByVal oMESSAGECODE As MESSAGECODE)

        'Dim amensaje As clsMessages
        'amensaje = New clsMessages

        'amensaje.Codigo = oMESSAGECODE
        'amensaje.ShowMesage(iLanguage)

    End Sub
    Public Enum MESSAGECODE
        kMESSAGE_ERR_NOTEMPTY = 401
        kMESSAGE_ERR_FOUND = 402
        kMESSAGE_ERR_NOTFOUND = 403
        kMESSAGE_ERR_USERCONNECTFAIL = 405
        kMESSAGE_ERR_CODIGO_YA_REGISTRADO = 406
        kMESSAGE_ERR_HA_OCURRIDO_IMPREVISTO = 407
        kMESSAGE_ERR_REGISTRO_TIENE_TRANSAC_RELACIONADAS = 408
        kMESSAGE_ERR_FILE_NOT_FOUND = 409
        kMESSAGE_ERR_PROCESS_INSATISFACT = 410
        kMESSAGE_ERR_LOTEST_CLOSED = 456
        kMESSAGE_ERR_STYLE_HAVE_MORE_ESTPRO = 458
        kMESSAGE_INF_PROCESS_SATISFACTO = 102
        kMESSAGE_INF_NO_INIT_SEARCH = 103
        kMESSAGE_INF_DATA_NOTFOUND = 411
        kMESSAGE_INF_FILE_PRINT_OK = 104
        kMESSAGE_INF_NEW_CODIGO = 106
        kMESSAGE_INF_DATA_SAVE = 107
        kMESSAGE_INF_DATA_DELETE = 108

        kMESSAGE_WAR_ENABLED_DELETED = 301
        kMESSAGE_WAR_CONFIR_CHANGES = 302

        kMESSAGE_ASK_PRINT_FILE = 201
        kMESSAGE_ASK_EXIT_SYSTEM = 202
        kMESSAGE_ASK_PROCESS = 203
        kMESSAGE_ASK_MAILING_FILE = 204
        kMESSAGE_ASK_DELETE_PURORD = 207
        kMESSAGE_ASK_DELETE_LOTEST = 208


        kMESSAGE_ERR_VALIDA_COD_CLIENTE = 413
        kMESSAGE_ERR_VALIDA_NOM_CLIENTE = 414
        kMESSAGE_ERR_VALIDA_DES_CLIENTE = 415
        kMESSAGE_ERR_VALIDA_DES_DIVISION = 416
        kMESSAGE_ERR_VALIDA_COD_DIVISION = 417
        kMESSAGE_ERR_VALIDA_DES_COLOR = 418
        kMESSAGE_ERR_VALIDA_COD_COLOR = 419
        kMESSAGE_ERR_VALIDA_COD_ESTCLI = 420
        kMESSAGE_ERR_VALIDA_NOM_ESTCLI = 421
        kMESSAGE_ERR_VALIDA_TIP_ESTCLI = 422
        kMESSAGE_ASK_NUEVO_ESTCLI = 205
        kMESSAGE_ASK_NUEVO_PURORD = 206

        kMESSAGE_ERR_VALIDA_COD_COMI = 423
        kMESSAGE_ERR_VALIDA_DES_COMI = 424

        kMESSAGE_ERR_VALIDA_COD_DESTINO = 425
        kMESSAGE_ERR_VALIDA_DES_DESTINO = 426
        kMESSAGE_ERR_VALIDA_COD_FABRICA = 427
        kMESSAGE_ERR_VALIDA_ABR_FABRICA = 428
        kMESSAGE_ERR_VALIDA_NOM_FABRICA = 429
        kMESSAGE_ERR_VALIDA_DES_FABRICA = 430
        kMESSAGE_ERR_VALIDA_DIR_FABRICA = 431
        kMESSAGE_ERR_VALIDA_TEL_FABRICA = 432

        kMESSAGE_ERR_VALIDA_COD_MONEDA = 433
        kMESSAGE_ERR_VALIDA_DES_MONEDA = 434

        kMESSAGE_ERR_VALIDA_COD_ORGANIZ = 435
        kMESSAGE_ERR_VALIDA_DES_ORGANIZ = 436

        kMESSAGE_ERR_VALIDA_COD_PAGO = 437
        kMESSAGE_ERR_VALIDA_DES_PAGO = 438

        kMESSAGE_ERR_VALIDA_COD_FABRES = 439
        kMESSAGE_ERR_VALIDA_COD_CLIRES = 440
        kMESSAGE_ERR_VALIDA_RES_CLIENTE = 441

        kMESSAGE_ERR_VALIDA_COD_TEMP = 442
        kMESSAGE_ERR_VALIDA_DES_TEMP = 443


        kMESSAGE_ERR_VALIDA_PORC_CLIENTE = 444

        kMESSAGE_ERR_VALIDA_COD_TIPEMB = 445
        kMESSAGE_ERR_VALIDA_DES_TIPEMB = 446

        kMESSAGE_ERR_VALIDA_COD_TIPPRE = 447
        kMESSAGE_ERR_VALIDA_DES_TIPPRE = 448

        kMESSAGE_ERR_VALIDA_COD_UM = 449
        kMESSAGE_ERR_VALIDA_DES_UM = 450

        kMESSAGE_ERR_VALIDA_ANO_MES = 451

        kMESSAGE_ERR_VALIDA_SERIE = 452

        kMESSAGE_ERR_VALIDA_FACTURA = 453
        kMESSAGE_ERR_ASIGN_STYLE_TEMCLI = 457
        kMESSAGE_ERR_EXIST_CLIENT = 459
        kMESSAGE_ERR_NOT_RIGHT_OPTION = 460
        kMESSAGE_ERR_INVALID_SELECC = 461

    End Enum

    Public Function DevuelveCampo(ByRef pQuerySql As String, ByRef pConexion As String) As Object
        On Error GoTo DevuelveCampoError
        Dim rstBuscaCampo As New ADODB.Recordset
        rstBuscaCampo.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rstBuscaCampo.Open(pQuerySql, pConexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        If rstBuscaCampo.RecordCount > 0 Then
            DevuelveCampo = rstBuscaCampo.Fields(0).Value
        Else
            DevuelveCampo = ""
        End If
        rstBuscaCampo = Nothing
        Exit Function
DevuelveCampoError:
        ErrorHandler(Err, "Funcion DevuelveCampo")
        Err.Clear()
        DevuelveCampo = ""
        rstBuscaCampo = Nothing
    End Function

    Public Sub ErrorHandler(ByVal pErr As ErrObject, ByVal pProcedure As String)
        Dim sMsg As String

        'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        sMsg = pProcedure & " : " & Chr(13) & Chr(10) & "Descripción : " & Err.Description

        MsgBox(sMsg, MsgBoxStyle.Exclamation, My.Application.Info.Title)

        Err.Clear()
    End Sub

    'Sub main()
    '    If IsDebugMode Then
    '        Dim x As New frmMenuPrincipal
    '        x.ShowDialog()
    '    End If
    'End Sub

    'Public Sub LaunchForm()
    '    ' Run a standard application message loop on the current thread.
    '    Application.Run(New frmMenuPrincipal())
    'End Sub
End Module
