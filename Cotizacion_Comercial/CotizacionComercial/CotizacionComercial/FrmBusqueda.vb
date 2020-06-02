Public Class FrmBusqueda
    Dim Buscar As New Busqueda(cCONNECT)
    Public Cadena As String
    Private Sub FrmBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub CargaDatos()
        Dim DT As New DataTable
        DT = Buscar.ObtenerDataTable(Cadena)
        If DT.Rows.Count > 0 Then
            GridEX1.DataSource = DT
            CheckLayoutGridEx(GridEX1)
        Else
            MessageBox.Show("No se encontro registros..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub GridEX1_DoubleClick(sender As Object, e As EventArgs) Handles GridEX1.DoubleClick
        If GridEX1.RowCount > 0 Then

            If GridEX1.RootTable.Columns.Count = 2 Then
                vlVal1 = GridEX1.GetValue(GridEX1.RootTable.Columns(0).Index).ToString
                vlVal2 = GridEX1.GetValue(GridEX1.RootTable.Columns(1).Index).ToString
                Me.Close()
            End If

            If GridEX1.RootTable.Columns.Count = 3 Then
                vlVal1 = GridEX1.GetValue(GridEX1.RootTable.Columns(0).Index).ToString
                vlVal2 = GridEX1.GetValue(GridEX1.RootTable.Columns(1).Index).ToString
                vlVal3 = GridEX1.GetValue(GridEX1.RootTable.Columns(2).Index).ToString
                Me.Close()
            End If
        End If
    End Sub
End Class