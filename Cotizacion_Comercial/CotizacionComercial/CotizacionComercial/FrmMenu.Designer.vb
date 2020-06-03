<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits ProyectoBase.frmBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UiButton3 = New Janus.Windows.EditControls.UIButton()
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton()
        Me.SuspendLayout()
        '
        'UiButton3
        '
        Me.UiButton3.Location = New System.Drawing.Point(13, 13)
        Me.UiButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.UiButton3.Name = "UiButton3"
        Me.UiButton3.Size = New System.Drawing.Size(117, 41)
        Me.UiButton3.TabIndex = 22
        Me.UiButton3.Text = "Precios Hilado Cotizacion"
        Me.UiButton3.ToolTipText = "Precios Hilado Cotizacion"
        Me.UiButton3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'UiButton1
        '
        Me.UiButton1.Location = New System.Drawing.Point(13, 62)
        Me.UiButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(117, 41)
        Me.UiButton1.TabIndex = 23
        Me.UiButton1.Text = "Precios Tela Cotizacion"
        Me.UiButton1.ToolTipText = "Precios Hilado Cotizacion"
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 628)
        Me.Controls.Add(Me.UiButton1)
        Me.Controls.Add(Me.UiButton3)
        Me.Name = "FrmMenu"
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents UiButton3 As Janus.Windows.EditControls.UIButton
    Private WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
End Class
