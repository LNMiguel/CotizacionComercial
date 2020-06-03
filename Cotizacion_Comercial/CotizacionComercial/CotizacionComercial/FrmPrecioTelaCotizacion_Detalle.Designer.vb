<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrecioTelaCotizacion_Detalle
    Inherits ProyectoBase.frmBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim BarraOpciones_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim BarraOpciones_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrecioTelaCotizacion_Detalle))
        Me.PnlPrecio = New System.Windows.Forms.Panel()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCancelaGrupo = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptaGrupo = New Janus.Windows.EditControls.UIButton()
        Me.PnlPrecio.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlPrecio
        '
        Me.PnlPrecio.BackColor = System.Drawing.Color.LightCyan
        Me.PnlPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPrecio.Controls.Add(Me.DtpFecha)
        Me.PnlPrecio.Controls.Add(Me.Label4)
        Me.PnlPrecio.Controls.Add(Me.TxtPrecio)
        Me.PnlPrecio.Controls.Add(Me.Label5)
        Me.PnlPrecio.Controls.Add(Me.BtnCancelaGrupo)
        Me.PnlPrecio.Controls.Add(Me.BtnAceptaGrupo)
        Me.PnlPrecio.Controls.Add(Me.Label1)
        Me.PnlPrecio.Location = New System.Drawing.Point(244, 32)
        Me.PnlPrecio.Name = "PnlPrecio"
        Me.PnlPrecio.Size = New System.Drawing.Size(311, 190)
        Me.PnlPrecio.TabIndex = 128
        Me.PnlPrecio.Visible = False
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(117, 44)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(134, 22)
        Me.DtpFecha.TabIndex = 155
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Fecha:"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.AcceptsReturn = True
        Me.TxtPrecio.BackColor = System.Drawing.Color.LightYellow
        Me.TxtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtPrecio.Location = New System.Drawing.Point(117, 74)
        Me.TxtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrecio.MaxLength = 0
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPrecio.Size = New System.Drawing.Size(134, 22)
        Me.TxtPrecio.TabIndex = 153
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Precio:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(309, 29)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Registro de Precio y Rango de Fecha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.AlternatingColors = True
        GridEX1_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 29)
        Me.GridEX1.Margin = New System.Windows.Forms.Padding(4)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GridEX1.Size = New System.Drawing.Size(862, 390)
        Me.GridEX1.TabIndex = 127
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'BarraOpciones
        '
        Me.BarraOpciones.Dock = System.Windows.Forms.DockStyle.Bottom
        BarraOpciones_Item_0_0.Image = CType(resources.GetObject("BarraOpciones_Item_0_0.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_0.Key = "ADICIONAR"
        BarraOpciones_Item_0_0.Text = "&Adicionar"
        BarraOpciones_Item_0_0.ToolTipText = "Adicionar"
        BarraOpciones_Item_0_1.Image = CType(resources.GetObject("BarraOpciones_Item_0_1.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_1.Key = "MODIFICAR"
        BarraOpciones_Item_0_1.Text = "&Modificar"
        BarraOpciones_Item_0_1.ToolTipText = "Modificar"
        BarraOpciones_Item_0_2.Image = CType(resources.GetObject("BarraOpciones_Item_0_2.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_2.Key = "ELIMINAR"
        BarraOpciones_Item_0_2.Text = "&Eliminar"
        BarraOpciones_Item_0_2.ToolTipText = "Eliminar"
        BarraOpciones_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {BarraOpciones_Item_0_0, BarraOpciones_Item_0_1, BarraOpciones_Item_0_2})
        BarraOpciones_Group_0.Key = "Group1"
        BarraOpciones_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.BarraOpciones.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {BarraOpciones_Group_0})
        Me.BarraOpciones.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.BarraOpciones.LargeImageSize = New System.Drawing.Size(30, 30)
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 419)
        Me.BarraOpciones.Margin = New System.Windows.Forms.Padding(4)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(862, 31)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 126
        Me.BarraOpciones.Text = "ButtonBar1"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gold
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(862, 29)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "DETALLE DE PRECIOS DE TELA POR RANGO DE FECHA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancelaGrupo
        '
        Me.BtnCancelaGrupo.Image = CType(resources.GetObject("BtnCancelaGrupo.Image"), System.Drawing.Image)
        Me.BtnCancelaGrupo.ImageIndex = 31
        Me.BtnCancelaGrupo.Location = New System.Drawing.Point(216, 143)
        Me.BtnCancelaGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelaGrupo.Name = "BtnCancelaGrupo"
        Me.BtnCancelaGrupo.Size = New System.Drawing.Size(89, 36)
        Me.BtnCancelaGrupo.TabIndex = 151
        Me.BtnCancelaGrupo.Text = "&Cancelar"
        Me.BtnCancelaGrupo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'BtnAceptaGrupo
        '
        Me.BtnAceptaGrupo.Image = CType(resources.GetObject("BtnAceptaGrupo.Image"), System.Drawing.Image)
        Me.BtnAceptaGrupo.ImageIndex = 31
        Me.BtnAceptaGrupo.Location = New System.Drawing.Point(4, 143)
        Me.BtnAceptaGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAceptaGrupo.Name = "BtnAceptaGrupo"
        Me.BtnAceptaGrupo.Size = New System.Drawing.Size(89, 36)
        Me.BtnAceptaGrupo.TabIndex = 150
        Me.BtnAceptaGrupo.Text = "&Aceptar"
        Me.BtnAceptaGrupo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'FrmPrecioTelaCotizacion_Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 450)
        Me.Controls.Add(Me.PnlPrecio)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.BarraOpciones)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmPrecioTelaCotizacion_Detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Precio x Tela"
        Me.PnlPrecio.ResumeLayout(False)
        Me.PnlPrecio.PerformLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlPrecio As Panel
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Public WithEvents TxtPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnCancelaGrupo As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptaGrupo As Janus.Windows.EditControls.UIButton
    Public WithEvents Label1 As Label
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
    Public WithEvents Label7 As Label
End Class
