<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrecioTelaCotizacion_Add
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
        Dim BarraOpciones_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim BarraOpciones_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrecioTelaCotizacion_Add))
        Dim BarraOpciones_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DtpUltFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTela = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodTela = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 197)
        Me.BarraOpciones.Margin = New System.Windows.Forms.Padding(4)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(522, 31)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 125
        Me.BarraOpciones.Text = "ButtonBar1"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
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
        Me.Panel2.Size = New System.Drawing.Size(522, 82)
        Me.Panel2.TabIndex = 124
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DtpUltFecha)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtTela)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtCodTela)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 82)
        Me.Panel1.TabIndex = 123
        '
        'DtpUltFecha
        '
        Me.DtpUltFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpUltFecha.Location = New System.Drawing.Point(386, 11)
        Me.DtpUltFecha.Name = "DtpUltFecha"
        Me.DtpUltFecha.Size = New System.Drawing.Size(119, 22)
        Me.DtpUltFecha.TabIndex = 144
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
        'TxtTela
        '
        Me.TxtTela.AcceptsReturn = True
        Me.TxtTela.BackColor = System.Drawing.Color.LightCyan
        Me.TxtTela.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTela.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtTela.Location = New System.Drawing.Point(68, 41)
        Me.TxtTela.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTela.MaxLength = 0
        Me.TxtTela.Name = "TxtTela"
        Me.TxtTela.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtTela.Size = New System.Drawing.Size(439, 22)
        Me.TxtTela.TabIndex = 142
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
        'TxtCodTela
        '
        Me.TxtCodTela.AcceptsReturn = True
        Me.TxtCodTela.BackColor = System.Drawing.Color.LightCyan
        Me.TxtCodTela.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCodTela.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtCodTela.Location = New System.Drawing.Point(106, 11)
        Me.TxtCodTela.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodTela.MaxLength = 0
        Me.TxtCodTela.Name = "TxtCodTela"
        Me.TxtCodTela.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCodTela.Size = New System.Drawing.Size(160, 22)
        Me.TxtCodTela.TabIndex = 140
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Tela:"
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
        Me.Label7.Size = New System.Drawing.Size(522, 29)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "REGISTRO DE RANGO DE FECHA "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmPrecioTelaCotizacion_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(522, 228)
        Me.Controls.Add(Me.BarraOpciones)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmPrecioTelaCotizacion_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Nuevo Rango de Fecha"
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Public WithEvents TxtPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DtpUltFecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Public WithEvents TxtTela As TextBox
    Friend WithEvents Label2 As Label
    Public WithEvents TxtCodTela As TextBox
    Friend WithEvents Label1 As Label
    Public WithEvents Label7 As Label
End Class
