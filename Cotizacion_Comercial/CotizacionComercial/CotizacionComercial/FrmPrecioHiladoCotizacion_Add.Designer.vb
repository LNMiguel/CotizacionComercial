<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrecioHiladoCotizacion_Add
    Inherits System.Windows.Forms.Form

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
        Dim BarraOpciones_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim BarraOpciones_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrecioHiladoCotizacion_Add))
        Dim BarraOpciones_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodHilo = New System.Windows.Forms.TextBox()
        Me.TxtHilo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpUltFecha = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label7.Size = New System.Drawing.Size(521, 29)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "REGISTRO DE RANGO DE FECHA "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DtpUltFecha)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtHilo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtCodHilo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(521, 82)
        Me.Panel1.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Hilo:"
        '
        'TxtCodHilo
        '
        Me.TxtCodHilo.AcceptsReturn = True
        Me.TxtCodHilo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtCodHilo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCodHilo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtCodHilo.Location = New System.Drawing.Point(106, 11)
        Me.TxtCodHilo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodHilo.MaxLength = 0
        Me.TxtCodHilo.Name = "TxtCodHilo"
        Me.TxtCodHilo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCodHilo.Size = New System.Drawing.Size(160, 22)
        Me.TxtCodHilo.TabIndex = 140
        '
        'TxtHilo
        '
        Me.TxtHilo.AcceptsReturn = True
        Me.TxtHilo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtHilo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtHilo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtHilo.Location = New System.Drawing.Point(68, 41)
        Me.TxtHilo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtHilo.MaxLength = 0
        Me.TxtHilo.Name = "TxtHilo"
        Me.TxtHilo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtHilo.Size = New System.Drawing.Size(439, 22)
        Me.TxtHilo.TabIndex = 142
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Hilado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(273, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Ultima Fecha:"
        '
        'DtpUltFecha
        '
        Me.DtpUltFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpUltFecha.Location = New System.Drawing.Point(386, 11)
        Me.DtpUltFecha.Name = "DtpUltFecha"
        Me.DtpUltFecha.Size = New System.Drawing.Size(119, 22)
        Me.DtpUltFecha.TabIndex = 144
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightYellow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DtpFecha)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtPrecio)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(521, 82)
        Me.Panel2.TabIndex = 118
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(208, 11)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(134, 22)
        Me.DtpFecha.TabIndex = 144
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(140, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Fecha:"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.AcceptsReturn = True
        Me.TxtPrecio.BackColor = System.Drawing.Color.LightYellow
        Me.TxtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtPrecio.Location = New System.Drawing.Point(208, 41)
        Me.TxtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrecio.MaxLength = 0
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPrecio.Size = New System.Drawing.Size(134, 22)
        Me.TxtPrecio.TabIndex = 142
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(140, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "Precio:"
        '
        'BarraOpciones
        '
        Me.BarraOpciones.Dock = System.Windows.Forms.DockStyle.Bottom
        BarraOpciones_Item_0_0.Image = CType(resources.GetObject("BarraOpciones_Item_0_0.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_0.Key = "GRABAR"
        BarraOpciones_Item_0_0.Text = "&Grabar"
        BarraOpciones_Item_0_0.ToolTipText = "Grabar"
        BarraOpciones_Item_0_1.Image = CType(resources.GetObject("BarraOpciones_Item_0_1.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_1.Key = "SALIR"
        BarraOpciones_Item_0_1.Text = "&Salir"
        BarraOpciones_Item_0_1.ToolTipText = "Salir"
        BarraOpciones_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {BarraOpciones_Item_0_0, BarraOpciones_Item_0_1})
        BarraOpciones_Group_0.Key = "Group1"
        BarraOpciones_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.BarraOpciones.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {BarraOpciones_Group_0})
        Me.BarraOpciones.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.BarraOpciones.LargeImageSize = New System.Drawing.Size(30, 30)
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 199)
        Me.BarraOpciones.Margin = New System.Windows.Forms.Padding(4)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(521, 31)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 121
        Me.BarraOpciones.Text = "ButtonBar1"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'FrmPrecioHiladoCotizacion_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(521, 230)
        Me.Controls.Add(Me.BarraOpciones)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmPrecioHiladoCotizacion_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Nuevo Rango de Fecha"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Public WithEvents TxtCodHilo As TextBox
    Friend WithEvents DtpUltFecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Public WithEvents TxtHilo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Public WithEvents TxtPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
End Class
