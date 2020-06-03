<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrecioTelaCotizacion
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
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrecioTelaCotizacion))
        Dim BarraOpciones_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim BarraOpciones_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.CM_MenuGrilla = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GenerarNuevoRangoDeFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetallePrecioHiladoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.OptTodos = New System.Windows.Forms.RadioButton()
        Me.OptTipoHilado = New System.Windows.Forms.RadioButton()
        Me.OptTitulo = New System.Windows.Forms.RadioButton()
        Me.btnBuscarComparar = New Janus.Windows.EditControls.UIButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OptSinPrecio = New System.Windows.Forms.RadioButton()
        Me.OptConCompra = New System.Windows.Forms.RadioButton()
        Me.OptVencidoxVencer = New System.Windows.Forms.RadioButton()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.OptTela = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM_MenuGrilla.SuspendLayout()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.ContextMenuStrip = Me.CM_MenuGrilla
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(210, 31)
        Me.GridEX1.Margin = New System.Windows.Forms.Padding(4)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GridEX1.Size = New System.Drawing.Size(1144, 544)
        Me.GridEX1.TabIndex = 124
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'CM_MenuGrilla
        '
        Me.CM_MenuGrilla.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CM_MenuGrilla.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarNuevoRangoDeFechaToolStripMenuItem, Me.DetallePrecioHiladoToolStripMenuItem})
        Me.CM_MenuGrilla.Name = "CM_MenuGrilla"
        Me.CM_MenuGrilla.Size = New System.Drawing.Size(292, 84)
        '
        'GenerarNuevoRangoDeFechaToolStripMenuItem
        '
        Me.GenerarNuevoRangoDeFechaToolStripMenuItem.Image = Global.CotizacionComercial.My.Resources.Resources.edit_16x16
        Me.GenerarNuevoRangoDeFechaToolStripMenuItem.Name = "GenerarNuevoRangoDeFechaToolStripMenuItem"
        Me.GenerarNuevoRangoDeFechaToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.GenerarNuevoRangoDeFechaToolStripMenuItem.Text = "Generar Nuevo Rango de Fecha"
        '
        'DetallePrecioHiladoToolStripMenuItem
        '
        Me.DetallePrecioHiladoToolStripMenuItem.Image = Global.CotizacionComercial.My.Resources.Resources.ic_dispatch_order_edit_48x48
        Me.DetallePrecioHiladoToolStripMenuItem.Name = "DetallePrecioHiladoToolStripMenuItem"
        Me.DetallePrecioHiladoToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.DetallePrecioHiladoToolStripMenuItem.Text = "Detalle - Precio Tela"
        '
        'BarraOpciones
        '
        Me.BarraOpciones.Dock = System.Windows.Forms.DockStyle.Top
        BarraOpciones_Item_0_0.Image = CType(resources.GetObject("BarraOpciones_Item_0_0.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_0.Key = "ADICIONAR"
        BarraOpciones_Item_0_0.Text = "&Adicionar"
        BarraOpciones_Item_0_0.ToolTipText = "Adicionar"
        BarraOpciones_Item_0_1.Image = CType(resources.GetObject("BarraOpciones_Item_0_1.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_1.Key = "MODIFICAR"
        BarraOpciones_Item_0_1.Text = "&Modificar"
        BarraOpciones_Item_0_1.ToolTipText = "Modificar"
        BarraOpciones_Item_0_1.Visible = False
        BarraOpciones_Item_0_2.Image = CType(resources.GetObject("BarraOpciones_Item_0_2.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_2.Key = "ELIMINAR"
        BarraOpciones_Item_0_2.Text = "&Eliminar"
        BarraOpciones_Item_0_2.ToolTipText = "Eliminar"
        BarraOpciones_Item_0_2.Visible = False
        BarraOpciones_Item_0_3.Image = CType(resources.GetObject("BarraOpciones_Item_0_3.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_3.Key = "DETALLE"
        BarraOpciones_Item_0_3.Text = "Detalle - Precio Tela"
        BarraOpciones_Item_0_3.ToolTipText = "Detalle - Precio Tela"
        BarraOpciones_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {BarraOpciones_Item_0_0, BarraOpciones_Item_0_1, BarraOpciones_Item_0_2, BarraOpciones_Item_0_3})
        BarraOpciones_Group_0.Key = "Group1"
        BarraOpciones_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.BarraOpciones.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {BarraOpciones_Group_0})
        Me.BarraOpciones.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.BarraOpciones.LargeImageSize = New System.Drawing.Size(30, 30)
        Me.BarraOpciones.Location = New System.Drawing.Point(210, 0)
        Me.BarraOpciones.Margin = New System.Windows.Forms.Padding(4)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(1144, 31)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 123
        Me.BarraOpciones.Text = "ButtonBar1"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtDescripcion)
        Me.Panel1.Controls.Add(Me.TxtCodigo)
        Me.Panel1.Controls.Add(Me.OptTodos)
        Me.Panel1.Controls.Add(Me.OptTipoHilado)
        Me.Panel1.Controls.Add(Me.OptTitulo)
        Me.Panel1.Controls.Add(Me.btnBuscarComparar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.OptSinPrecio)
        Me.Panel1.Controls.Add(Me.OptConCompra)
        Me.Panel1.Controls.Add(Me.OptVencidoxVencer)
        Me.Panel1.Controls.Add(Me.TxtValor)
        Me.Panel1.Controls.Add(Me.OptTela)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 575)
        Me.Panel1.TabIndex = 122
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.AcceptsReturn = True
        Me.TxtDescripcion.BackColor = System.Drawing.Color.LightYellow
        Me.TxtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDescripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtDescripcion.Location = New System.Drawing.Point(70, 455)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescripcion.MaxLength = 0
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDescripcion.Size = New System.Drawing.Size(134, 22)
        Me.TxtDescripcion.TabIndex = 149
        Me.TxtDescripcion.Visible = False
        '
        'TxtCodigo
        '
        Me.TxtCodigo.AcceptsReturn = True
        Me.TxtCodigo.BackColor = System.Drawing.Color.LightYellow
        Me.TxtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCodigo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtCodigo.Location = New System.Drawing.Point(4, 455)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodigo.MaxLength = 0
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCodigo.Size = New System.Drawing.Size(64, 22)
        Me.TxtCodigo.TabIndex = 148
        Me.TxtCodigo.Visible = False
        '
        'OptTodos
        '
        Me.OptTodos.AutoSize = True
        Me.OptTodos.BackColor = System.Drawing.Color.LightCyan
        Me.OptTodos.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTodos.ForeColor = System.Drawing.Color.Black
        Me.OptTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OptTodos.Location = New System.Drawing.Point(4, 47)
        Me.OptTodos.Margin = New System.Windows.Forms.Padding(4)
        Me.OptTodos.Name = "OptTodos"
        Me.OptTodos.Size = New System.Drawing.Size(65, 18)
        Me.OptTodos.TabIndex = 147
        Me.OptTodos.Text = "Todos"
        Me.OptTodos.UseVisualStyleBackColor = False
        '
        'OptTipoHilado
        '
        Me.OptTipoHilado.AutoSize = True
        Me.OptTipoHilado.BackColor = System.Drawing.Color.LightCyan
        Me.OptTipoHilado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTipoHilado.ForeColor = System.Drawing.Color.Black
        Me.OptTipoHilado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OptTipoHilado.Location = New System.Drawing.Point(4, 157)
        Me.OptTipoHilado.Margin = New System.Windows.Forms.Padding(4)
        Me.OptTipoHilado.Name = "OptTipoHilado"
        Me.OptTipoHilado.Size = New System.Drawing.Size(103, 21)
        Me.OptTipoHilado.TabIndex = 146
        Me.OptTipoHilado.Text = "Por Familia"
        Me.OptTipoHilado.UseVisualStyleBackColor = False
        '
        'OptTitulo
        '
        Me.OptTitulo.AutoSize = True
        Me.OptTitulo.BackColor = System.Drawing.Color.LightCyan
        Me.OptTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTitulo.ForeColor = System.Drawing.Color.Black
        Me.OptTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OptTitulo.Location = New System.Drawing.Point(4, 99)
        Me.OptTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.OptTitulo.Name = "OptTitulo"
        Me.OptTitulo.Size = New System.Drawing.Size(96, 21)
        Me.OptTitulo.TabIndex = 145
        Me.OptTitulo.Text = "Por Titulo"
        Me.OptTitulo.UseVisualStyleBackColor = False
        '
        'btnBuscarComparar
        '
        Me.btnBuscarComparar.Image = Global.CotizacionComercial.My.Resources.Resources.search_48x48
        Me.btnBuscarComparar.Location = New System.Drawing.Point(36, 508)
        Me.btnBuscarComparar.Name = "btnBuscarComparar"
        Me.btnBuscarComparar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnBuscarComparar.Size = New System.Drawing.Size(131, 43)
        Me.btnBuscarComparar.TabIndex = 144
        Me.btnBuscarComparar.Text = "&Realizar Búsqueda"
        Me.btnBuscarComparar.ToolTipText = "Buscar "
        Me.btnBuscarComparar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 422)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(197, 29)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "Ingrese Valor de Búsqueda"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'OptSinPrecio
        '
        Me.OptSinPrecio.BackColor = System.Drawing.Color.LightCyan
        Me.OptSinPrecio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptSinPrecio.ForeColor = System.Drawing.Color.Black
        Me.OptSinPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OptSinPrecio.Location = New System.Drawing.Point(4, 234)
        Me.OptSinPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.OptSinPrecio.Name = "OptSinPrecio"
        Me.OptSinPrecio.Size = New System.Drawing.Size(188, 55)
        Me.OptSinPrecio.TabIndex = 142
        Me.OptSinPrecio.Text = "Por Tela Con Precios Pendientes en Cotizaciones"
        Me.OptSinPrecio.UseVisualStyleBackColor = False
        '
        'OptConCompra
        '
        Me.OptConCompra.AutoSize = True
        Me.OptConCompra.BackColor = System.Drawing.Color.LightCyan
        Me.OptConCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptConCompra.ForeColor = System.Drawing.Color.Black
        Me.OptConCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OptConCompra.Location = New System.Drawing.Point(4, 128)
        Me.OptConCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.OptConCompra.Name = "OptConCompra"
        Me.OptConCompra.Size = New System.Drawing.Size(176, 21)
        Me.OptConCompra.TabIndex = 141
        Me.OptConCompra.Text = "Por Tela Con Compra"
        Me.OptConCompra.UseVisualStyleBackColor = False
        '
        'OptVencidoxVencer
        '
        Me.OptVencidoxVencer.BackColor = System.Drawing.Color.LightCyan
        Me.OptVencidoxVencer.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptVencidoxVencer.ForeColor = System.Drawing.Color.Black
        Me.OptVencidoxVencer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OptVencidoxVencer.Location = New System.Drawing.Point(4, 186)
        Me.OptVencidoxVencer.Margin = New System.Windows.Forms.Padding(4)
        Me.OptVencidoxVencer.Name = "OptVencidoxVencer"
        Me.OptVencidoxVencer.Size = New System.Drawing.Size(175, 40)
        Me.OptVencidoxVencer.TabIndex = 140
        Me.OptVencidoxVencer.Text = "Por Tela Con Precio Vencido - Por Vencer (10 días)"
        Me.OptVencidoxVencer.UseVisualStyleBackColor = False
        '
        'TxtValor
        '
        Me.TxtValor.AcceptsReturn = True
        Me.TxtValor.BackColor = System.Drawing.Color.LightCyan
        Me.TxtValor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtValor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtValor.Location = New System.Drawing.Point(4, 455)
        Me.TxtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValor.MaxLength = 0
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtValor.Size = New System.Drawing.Size(188, 22)
        Me.TxtValor.TabIndex = 139
        Me.TxtValor.Visible = False
        '
        'OptTela
        '
        Me.OptTela.AutoSize = True
        Me.OptTela.BackColor = System.Drawing.Color.LightCyan
        Me.OptTela.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTela.ForeColor = System.Drawing.Color.Black
        Me.OptTela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OptTela.Location = New System.Drawing.Point(4, 73)
        Me.OptTela.Margin = New System.Windows.Forms.Padding(4)
        Me.OptTela.Name = "OptTela"
        Me.OptTela.Size = New System.Drawing.Size(77, 18)
        Me.OptTela.TabIndex = 138
        Me.OptTela.Text = "Por Tela"
        Me.OptTela.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gold
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(208, 29)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "FILTROS DE BÚSQUEDA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmPrecioTelaCotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1354, 575)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.BarraOpciones)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmPrecioTelaCotizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Precios - Tela para Cotización"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM_MenuGrilla.ResumeLayout(False)
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents CM_MenuGrilla As ContextMenuStrip
    Friend WithEvents GenerarNuevoRangoDeFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetallePrecioHiladoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents Panel1 As Panel
    Public WithEvents TxtDescripcion As TextBox
    Public WithEvents TxtCodigo As TextBox
    Friend WithEvents OptTodos As RadioButton
    Friend WithEvents OptTipoHilado As RadioButton
    Friend WithEvents OptTitulo As RadioButton
    Friend WithEvents btnBuscarComparar As Janus.Windows.EditControls.UIButton
    Public WithEvents Label1 As Label
    Friend WithEvents OptSinPrecio As RadioButton
    Friend WithEvents OptConCompra As RadioButton
    Friend WithEvents OptVencidoxVencer As RadioButton
    Public WithEvents TxtValor As TextBox
    Friend WithEvents OptTela As RadioButton
    Public WithEvents Label7 As Label
End Class
