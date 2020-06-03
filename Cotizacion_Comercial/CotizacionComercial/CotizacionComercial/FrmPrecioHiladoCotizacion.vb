Public Class FrmPrecioHiladoCotizacion
    Dim HiladoCotizacion As New PrecioHiladoCotizacion(cCONNECT)
    Dim TipoBusqueda As String
    Private Sub FrmPrecioHiladoCotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OptTodos.Checked = True
    End Sub

    Private Sub BtnBuscarComparar_Click(sender As Object, e As EventArgs) Handles btnBuscarComparar.Click
        Try

            If TipoBusqueda = "2" And String.IsNullOrEmpty(TxtValor.Text) Then
                MessageBox.Show("Ingrese Codigo de Hilado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If TipoBusqueda = "3" And String.IsNullOrEmpty(TxtCodigo.Text) Then
                MessageBox.Show("Seleccione Titulo de Hilado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If TipoBusqueda = "4" And String.IsNullOrEmpty(TxtCodigo.Text) Then
                MessageBox.Show("Seleccione Tipo Hilado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            CargaDatos(TipoBusqueda)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargaDatos(ByVal vlOpcion As String)
        Try
            'Dim oCondFormat As Janus.Windows.GridEX.GridEXFormatCondition
            Dim Parametros(0 To 5 - 1) As Object
            Parametros(0) = "COTIZACIONES_PRODUCTO_HILADOS_CRUDO_GENERA_INFORMACION"
            Parametros(1) = vlOpcion
            Parametros(2) = TxtValor.Text
            Parametros(3) = TxtCodigo.Text
            Parametros(4) = TxtCodigo.Text
            Dim DT As DataTable = HiladoCotizacion.MuestraDatos(Parametros)
            If DT.Rows.Count > 0 Then
                GridEX1.DataSource = DT
                CheckLayoutGridEx(GridEX1)
                GridEX1.Row = 1
                With GridEX1.RootTable
                    With .Columns("KGS_COMPRADOS")
                        .Visible = True
                        '.CellStyle.BackColor = Color.AliceBlue
                        .CellStyle.ForeColor = Color.Blue
                        .FormatString = "#,##0.##"
                    End With
                    With .Columns("IMPORTE_ULTIMAS_COMPRAS")
                        Visible = True
                        '.CellStyle.BackColor = Color.AliceBlue
                        .CellStyle.ForeColor = Color.Blue
                        .FormatString = "#,##0.##"
                    End With

                End With
            Else
                'GridEX1.RootTable.Columns.Clear()
                GridEX1.DataSource = Nothing
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OptHilado_CheckedChanged(sender As Object, e As EventArgs) Handles OptHilado.CheckedChanged
        TipoBusqueda = "2"
        TxtValor.Text = String.Empty
        TxtCodigo.Text = String.Empty
        TxtDescripcion.Text = String.Empty

        TxtValor.Visible = True
        TxtCodigo.Visible = False
        TxtDescripcion.Visible = False

        Label1.Visible = True
    End Sub

    Private Sub OptVencidoxVencer_CheckedChanged(sender As Object, e As EventArgs) Handles OptVencidoxVencer.CheckedChanged
        TipoBusqueda = "6"
        TxtValor.Text = String.Empty
        TxtCodigo.Text = String.Empty
        TxtDescripcion.Text = String.Empty

        TxtValor.Visible = False
        TxtCodigo.Visible = False
        TxtDescripcion.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub OptConCompra_CheckedChanged(sender As Object, e As EventArgs) Handles OptConCompra.CheckedChanged
        TipoBusqueda = "5"
        TxtValor.Text = String.Empty
        TxtCodigo.Text = String.Empty
        TxtDescripcion.Text = String.Empty

        TxtValor.Visible = False
        TxtCodigo.Visible = False
        TxtDescripcion.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub OptSinPrecio_CheckedChanged(sender As Object, e As EventArgs) Handles OptSinPrecio.CheckedChanged
        TipoBusqueda = "7"
        TxtValor.Text = String.Empty
        TxtCodigo.Text = String.Empty
        TxtDescripcion.Text = String.Empty

        TxtValor.Visible = False
        TxtCodigo.Visible = False
        TxtDescripcion.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles OptTitulo.CheckedChanged
        TipoBusqueda = "3"
        TxtValor.Text = String.Empty
        TxtValor.Visible = False
        Label1.Visible = True

        TxtCodigo.Text = String.Empty
        TxtDescripcion.Text = String.Empty
        TxtCodigo.Visible = True
        TxtDescripcion.Visible = True
    End Sub

    Private Sub OptTipoHilado_CheckedChanged(sender As Object, e As EventArgs) Handles OptTipoHilado.CheckedChanged
        TipoBusqueda = "4"
        TxtValor.Text = String.Empty
        TxtValor.Visible = False
        Label1.Visible = True

        TxtCodigo.Text = String.Empty
        TxtDescripcion.Text = String.Empty
        TxtCodigo.Visible = True
        TxtDescripcion.Visible = True
    End Sub

    Private Sub OptTodos_CheckedChanged(sender As Object, e As EventArgs) Handles OptTodos.CheckedChanged
        TipoBusqueda = "1"
        TxtValor.Text = String.Empty
        TxtCodigo.Text = String.Empty

        TxtValor.Visible = False
        TxtCodigo.Visible = False
        TxtDescripcion.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub TxtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim frmx As New FrmBusqueda
            If TipoBusqueda = "3" Then
                vlVal1 = ""
                vlVal2 = ""
                frmx.Cadena = "exec hi_muestra_titulos_hilados ''"
                frmx.CargaDatos()
                frmx.ShowDialog()
                TxtCodigo.Text = vlVal1
                TxtDescripcion.Text = vlVal2
            End If

            If TipoBusqueda = "4" Then
                vlVal1 = ""
                vlVal2 = ""
                frmx.Cadena = "select Cod_TipoHilado Codigo,Descripcion from Hi_TipoHilado"
                frmx.CargaDatos()
                frmx.ShowDialog()
                TxtCodigo.Text = vlVal1
                TxtDescripcion.Text = vlVal2
            End If

        End If
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONAR"
                    If GridEX1.RowCount > 0 Then
                        Dim frm As New FrmPrecioHiladoCotizacion_Add
                        frm.vlAccion = "I"
                        frm.vlCodHilado = GridEX1.GetValue(GridEX1.RootTable.Columns(0).Index)
                        frm.vlHilo = GridEX1.GetValue(GridEX1.RootTable.Columns(1).Index)
                        frm.vlfecha = IIf(GridEX1.GetValue(GridEX1.RootTable.Columns("FECHA_VIGENCIA_ULTIMO").Index) Is DBNull.Value, Date.Now, GridEX1.GetValue(GridEX1.RootTable.Columns("FECHA_VIGENCIA_ULTIMO").Index))
                        frm.ShowDialog()
                        btnBuscarComparar.PerformClick()
                    End If
                'Case "MODIFICAR"
                '    If GridEX1.RowCount > 0 Then
                '        Dim frm As New FrmPrecioHiladoCotizacion_Add
                '        frm.vlAccion = "U"
                '        frm.vlCodHilado = GridEX1.GetValue(GridEX1.RootTable.Columns(0).Index)
                '        frm.vlHilo = GridEX1.GetValue(GridEX1.RootTable.Columns(1).Index)
                '        frm.vlfecha = IIf(GridEX1.GetValue(GridEX1.RootTable.Columns("FECHA_VIGENCIA_ULTIMO").Index) Is DBNull.Value, Date.Now, GridEX1.GetValue(GridEX1.RootTable.Columns("FECHA_VIGENCIA_ULTIMO").Index))
                '        frm.TxtPrecio.Text = IIf(GridEX1.GetValue(GridEX1.RootTable.Columns("PRECIO_ULTIMO").Index) Is DBNull.Value, "0.00", GridEX1.GetValue(GridEX1.RootTable.Columns("PRECIO_ULTIMO").Index))
                '        frm.ShowDialog()
                '    End If
                'Case "ELIMINAR"
                Case "DETALLE"
                    If GridEX1.RowCount > 0 Then
                        Dim frm As New FrmPrecioHiladoCotizacion_Detalle
                        frm.vlCodHilado = GridEX1.GetValue(GridEX1.RootTable.Columns(0).Index)
                        frm.ShowDialog()
                        btnBuscarComparar.PerformClick()
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GenerarNuevoRangoDeFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarNuevoRangoDeFechaToolStripMenuItem.Click
        If GridEX1.RowCount > 0 Then
            Dim frm As New FrmPrecioHiladoCotizacion_Add
            frm.vlAccion = "I"
            frm.vlCodHilado = GridEX1.GetValue(GridEX1.RootTable.Columns(0).Index)
            frm.vlHilo = GridEX1.GetValue(GridEX1.RootTable.Columns(1).Index)
            frm.vlfecha = IIf(GridEX1.GetValue(GridEX1.RootTable.Columns("FECHA_VIGENCIA_ULTIMO").Index) Is DBNull.Value, Date.Now, GridEX1.GetValue(GridEX1.RootTable.Columns("FECHA_VIGENCIA_ULTIMO").Index))
            frm.ShowDialog()
            btnBuscarComparar.PerformClick()
        End If
    End Sub

    Private Sub DetallePrecioHiladoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetallePrecioHiladoToolStripMenuItem.Click
        If GridEX1.RowCount > 0 Then
            Dim frm As New FrmPrecioHiladoCotizacion_Detalle
            frm.vlCodHilado = GridEX1.GetValue(GridEX1.RootTable.Columns(0).Index)
            frm.ShowDialog()
            btnBuscarComparar.PerformClick()
        End If
    End Sub

    Private Sub TxtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim frmx As New FrmBusqueda
            If TipoBusqueda = "3" Then
                vlVal1 = ""
                vlVal2 = ""
                frmx.Cadena = "exec hi_muestra_titulos_hilados ''"
                frmx.CargaDatos()
                frmx.ShowDialog()
                TxtCodigo.Text = vlVal1
                TxtDescripcion.Text = vlVal2
            End If

            If TipoBusqueda = "4" Then
                vlVal1 = ""
                vlVal2 = ""
                frmx.Cadena = "select Cod_TipoHilado Codigo,Descripcion from Hi_TipoHilado"
                frmx.CargaDatos()
                frmx.ShowDialog()
                TxtCodigo.Text = vlVal1
                TxtDescripcion.Text = vlVal2
            End If

        End If
    End Sub

End Class