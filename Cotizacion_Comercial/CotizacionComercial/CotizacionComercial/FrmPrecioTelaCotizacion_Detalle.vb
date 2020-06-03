Public Class FrmPrecioTelaCotizacion_Detalle
    Dim TelaCotizacion As New PrecioTelaCotizacion(cCONNECT)
    Public vlCodTela As String
    Dim vlTipo As String
    Private Sub FrmPrecioTelaCotizacion_Detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MuestraDetalle()
    End Sub

    Sub MuestraDetalle()
        Try
            Dim Parametros(0 To 8 - 1) As Object
            Parametros(0) = "up_man_Tj_Telas_Precios_Cotizacion"
            Parametros(1) = "V"
            Parametros(2) = vlCodTela
            Parametros(3) = 0
            Parametros(4) = DBNull.Value
            Parametros(5) = DBNull.Value
            Parametros(6) = vusu
            Parametros(7) = 0
            Dim DT As DataTable = TelaCotizacion.MuestraDetallePrecios(Parametros)
            If DT.Rows.Count > 0 Then
                GridEX1.DataSource = DT
                CheckLayoutGridEx(GridEX1)
                'GridEX1.FrozenColumns = 9
            Else
                GridEX1.RootTable.Columns.Clear()
                GridEX1.DataSource = Nothing
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONAR"
                    If GridEX1.RowCount > 0 Then
                        Label1.Text = "Registro de Precio y Rango de Fecha"
                        Limpiar()
                        vlTipo = "I"
                        PnlPrecio.Visible = True
                    End If
                Case "MODIFICAR"
                    If GridEX1.RowCount > 0 Then
                        Label1.Text = "Actualización de Precio y Rango de Fecha"
                        Limpiar()
                        vlTipo = "U"
                        PnlPrecio.Visible = True
                    End If
                Case "ELIMINAR"
                    If GridEX1.RowCount = 0 Then
                        Exit Sub
                    End If

                    If (MessageBox.Show("¿Desea Eliminar el Precio?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then
                        Exit Sub
                    Else
                        EliminarPrecio()
                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub EliminarPrecio()
        Try
            Dim Parametros(0 To 8 - 1) As Object
            Parametros(0) = "up_man_Tj_Telas_Precios_Cotizacion"
            Parametros(1) = "D"
            Parametros(2) = vlCodTela
            Parametros(3) = GridEX1.GetValue(GridEX1.RootTable.Columns("SECUENCIA").Index)
            Parametros(4) = DBNull.Value
            Parametros(5) = DtpFecha.Value
            Parametros(6) = vusu
            Parametros(7) = 0
            Dim Rs As Boolean = TelaCotizacion.RegistraPrecio_Tela(Parametros)
            If Rs = True Then
                MessageBox.Show("Precio Eliminado Correctamente..!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MuestraDetalle()
            Else
                MessageBox.Show("Error al Eliminar Precio..!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MuestraDetalle()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Limpiar()
        DtpFecha.Value = Date.Now
        TxtPrecio.Text = ""
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

    Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecio.KeyPress
        NumerosyDecimal(TxtPrecio, e)
    End Sub

    Private Sub BtnAceptaGrupo_Click(sender As Object, e As EventArgs) Handles BtnAceptaGrupo.Click
        Try
            If String.IsNullOrEmpty(TxtPrecio.Text) Or TxtPrecio.Text = "0" Or TxtPrecio.Text = "0.00" Then
                MessageBox.Show("Ingrese Precio Correcto > 0.00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim Parametros(0 To 8 - 1) As Object
            Parametros(0) = "up_man_Tj_Telas_Precios_Cotizacion"
            Parametros(1) = vlTipo
            Parametros(2) = vlCodTela
            Parametros(3) = IIf(vlTipo = "I", 0, GridEX1.GetValue(GridEX1.RootTable.Columns("SECUENCIA").Index))
            Parametros(4) = DBNull.Value
            Parametros(5) = DtpFecha.Value
            Parametros(6) = vusu
            Parametros(7) = CDbl(TxtPrecio.Text)
            Dim Rs As Boolean = TelaCotizacion.RegistraPrecio_Tela(Parametros)
            If Rs = True Then
                MessageBox.Show(IIf(vlTipo = "I", "Precio Registrado Correctamente..!!", "Precio Actualizado Correctamente..!!"), "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MuestraDetalle()
                BtnCancelaGrupo.PerformClick()
            Else
                MessageBox.Show(IIf(vlTipo = "I", "Error al Registrar Precio..!!", "Error al Actualizar Precio..!!"), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MuestraDetalle()
                BtnCancelaGrupo.PerformClick()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelaGrupo_Click(sender As Object, e As EventArgs) Handles BtnCancelaGrupo.Click
        PnlPrecio.Visible = False
        Limpiar()
    End Sub
End Class