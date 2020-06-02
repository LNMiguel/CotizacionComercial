Public Class FrmPrecioHiladoCotizacion_Add
    Dim HiladoCotizacion As New PrecioHiladoCotizacion(cCONNECT)
    Public vlCodHilado As String
    Public vlHilo As String
    Public vlfecha As Date
    Public vlAccion As String
    Private Sub FrmPrecioHiladoCotizacion_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = "REGISTRO DE RANGO DE FECHA - [" & vlCodHilado.Trim & "]"
        DtpFecha.Value = Date.Now
        TxtCodHilo.Text = vlCodHilado
        TxtHilo.Text = vlHilo
        DtpUltFecha.Value = vlfecha
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "GRABAR"
                    If String.IsNullOrEmpty(TxtPrecio.Text) Or TxtPrecio.Text = "0" Or TxtPrecio.Text = "0.00" Then
                        MessageBox.Show("Ingrese Precio Correcto > 0.00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Grabar()
                Case "SALIR"
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Grabar()
        Try
            Dim Parametros(0 To 8 - 1) As Object
            Parametros(0) = "up_man_Hi_Hilados_Precios_Cotizacion"
            Parametros(1) = vlAccion
            Parametros(2) = TxtCodHilo.Text
            Parametros(3) = 0
            Parametros(4) = DBNull.Value
            Parametros(5) = DtpFecha.Value
            Parametros(6) = vusu
            Parametros(7) = TxtPrecio.Text
            Dim Rs As Boolean = HiladoCotizacion.RegistraPrecio_Hilado(Parametros)
            If Rs = False Then
                MessageBox.Show("Error al Registrar Precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Precio Registrado..!!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Modificar()
        Try
            Dim Parametros(0 To 8 - 1) As Object
            Parametros(0) = "up_man_Hi_Hilados_Precios_Cotizacion"
            Parametros(1) = vlAccion
            Parametros(2) = TxtCodHilo.Text
            Parametros(3) = 0
            Parametros(4) = DBNull.Value
            Parametros(5) = DtpFecha.Value
            Parametros(6) = vusu
            Parametros(7) = TxtPrecio.Text
            Dim Rs As Boolean = HiladoCotizacion.RegistraPrecio_Hilado(Parametros)
            If Rs = False Then
                MessageBox.Show("Error al Registrar Precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Precio Registrado..!!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecio.KeyPress
        NumerosyDecimal(TxtPrecio, e)
    End Sub

    Public Sub NumerosyDecimal(ByVal CajaTexto As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class