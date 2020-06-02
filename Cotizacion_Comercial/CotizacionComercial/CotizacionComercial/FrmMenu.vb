Public Class FrmMenu
    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cCONNECT = "Initial Catalog=sige_stn;Data Source=192.168.30.55;uid=SGPusuarios;pwd=G3n3sysD@t@2O19$"
        cSEGURIDAD = "Initial Catalog=Seguridad;Data Source=192.168.30.55;uid=SGPusuarios;pwd=G3n3sysD@t@2O19$"

        cCONNECTVB6 = "Provider=SQLOLEDB.1;Initial Catalog=sige_stn;Data Source=192.168.30.55;uid=SGPusuarios;pwd=G3n3sysD@t@2O19$"
        cSEGURIDADVB6 = "Provider=SQLOLEDB.1;Initial Catalog=Seguridad;Data Source=192.168.30.55;uid=SGPusuarios;pwd=G3n3sysD@t@2O19$"


        'cCONNECT = "Initial Catalog=sige_stn;Data Source=(local);uid=SGPusuarios;pwd=SGPusuarios"
        'cSEGURIDAD = "Initial Catalog=Seguridad;Data Source=(local);uid=SGPusuarios;pwd=SGPusuarios"

        'cCONNECTVB6 = "Provider=SQLOLEDB.1;Initial Catalog=sige_stn;Data Source=(local);uid=SGPusuarios;pwd=SGPusuarios"
        'cSEGURIDADVB6 = "Provider=SQLOLEDB.1;Initial Catalog=Seguridad;Data Source=(local);uid=SGPusuarios;pwd=SGPusuarios"

        'IP SORACHINCHA: 131.107.34.100, IP ORADESA01: 131.107.32.220
        cConexionORACLE = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=131.107.32.220)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=tdvdb)));User ID=gptdv;password=erp2014;Enlist=True;"

        vusu = "ecardenas"
        vper = "0001"
        vemp = "01"
        vRuta = Application.StartupPath
    End Sub

    Private Sub UiButton3_Click(sender As Object, e As EventArgs) Handles UiButton3.Click
        Dim xFrm As New FrmPrecioHiladoCotizacion
        With xFrm
            .Show()
            '.Dispose()
        End With
    End Sub
End Class
