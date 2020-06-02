Public Class clsForm
#Region " Codigo Comun en los [FORMULARIOS BASE] "


    Private mConnect As String
    Private mConnectVB6 As String
    Private mConnectSeguridadVB60 As String

    Public Property Language() As Integer
        Get
            Language = iLanguage
        End Get
        Set(ByVal value As Integer)
            iLanguage = value
        End Set
    End Property

    'Public Property Parent1() As Object
    '    Get
    '        Parent1 = oMDIParent
    '    End Get
    '    Set(ByVal value As Object)
    '        oMDIParent = value
    '        If IsNumeric(oMDIParent.Tag) Then
    '            AnoPeriodoContableVigente = oMDIParent.Tag
    '        End If
    '    End Set
    'End Property

    Public Property AnoPeriodoContableVigente() As String
        Get
            AnoPeriodoContableVigente = sAnoPeriodoContableVigente
        End Get
        Set(ByVal value As String)
            sAnoPeriodoContableVigente = value
            sAnoContableVigente = Mid(sAnoPeriodoContableVigente, 1, 4)
            sPeriodoContableVigente = Mid(sAnoPeriodoContableVigente, 5, 2)

        End Set
    End Property

    Public Property Rutas() As String
        Get
            Rutas = vRuta
        End Get
        Set(ByVal value As String)
            vRuta = value
        End Set
    End Property

    Public Property Cod_Empresa() As String
        Get
            Cod_Empresa = vemp
        End Get
        Set(ByVal value As String)
            vemp = value
            vemp1 = value
            bCargaConexion = True
        End Set
    End Property

    Public Property Cod_Perfil() As String
        Get
            Cod_Perfil = vper
        End Get
        Set(ByVal value As String)
            vper = value

        End Set
    End Property

    Public Property Cod_Opcion() As String
        Get
            Cod_Opcion = gsCod_Opcion
        End Get
        Set(ByVal value As String)
            gsCod_Opcion = value
        End Set
    End Property

    Public Property Nom_Empresa() As String
        Get
            Nom_Empresa = ""
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property Nom_Aplicacion() As String
        Get
            Nom_Aplicacion = ""
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property Nom_Opcion() As String
        Get
            Nom_Opcion = ""
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property UserName() As String
        Get
            UserName = vusu
        End Get
        Set(ByVal value As String)
            vusu = value
        End Set
    End Property

    Public Property ConnectEmpresa() As String
        Get
            ConnectEmpresa = mConnect
        End Get
        Set(ByVal value As String)
            mConnect = value
            cCONNECT = mConnect
        End Set
    End Property

    Public Property ConnectSeguridad() As String
        Get
            ConnectSeguridad = cSEGURIDAD
        End Get
        Set(ByVal value As String)
            cSEGURIDAD = value
        End Set
    End Property

    Public Property ConnectVB60() As String
        Get
            ConnectVB60 = mConnectVB6
        End Get
        Set(ByVal value As String)
            mConnectVB6 = value
            cCONNECTVB6 = mConnectVB6
        End Set
    End Property

    Public Property ConnectSeguridadVB60() As String
        Get
            ConnectSeguridadVB60 = cSEGURIDADVB6
        End Get
        Set(ByVal value As String)
            mConnectSeguridadVB60 = value
            cSEGURIDADVB6 = mConnectSeguridadVB60
        End Set
    End Property

    Public Function GetForm(ByVal sClassName As String) As Form
        ' Get the your application's application domain.
        Dim currentDomain As AppDomain = AppDomain.CurrentDomain

        ' Define a handler for unhandled exceptions.
        AddHandler currentDomain.UnhandledException, AddressOf MYExHandler

        ' Define a handler for unhandled exceptions for threads behind forms.
        AddHandler Application.ThreadException, AddressOf MYThreadHandler


        Select Case sClassName.ToUpper
            Case "FRMMENU"
                Return New FrmMenu
            Case "FRMPRECIOHILADOCOTIZACION"
                Return New FrmPrecioHiladoCotizacion
            Case Else
                Return Nothing
        End Select
    End Function

    Private Sub MYExHandler(ByVal sender As Object,
 ByVal e As UnhandledExceptionEventArgs)
        Dim EX As Exception
        EX = e.ExceptionObject
        Console.WriteLine(EX.StackTrace)
    End Sub

    Private Sub MYThreadHandler(ByVal sender As Object,
      ByVal e As Threading.ThreadExceptionEventArgs)
        Console.WriteLine(e.Exception.StackTrace)
    End Sub

    Public Property ConnectOracle() As String
        Get
            ConnectOracle = cConexionORACLE
        End Get
        Set(ByVal Value As String)
            mConnectOracle = Value
            cConexionORACLE = mConnectOracle
        End Set
    End Property

    Private mConnectOracle As String

#End Region

End Class
