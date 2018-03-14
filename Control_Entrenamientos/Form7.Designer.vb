<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.ImagenHuella = New System.Windows.Forms.PictureBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtBxNombre = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LblHuella = New System.Windows.Forms.Label()
        Me.CBActivo = New System.Windows.Forms.CheckBox()
        CType(Me.ImagenHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImagenHuella
        '
        Me.ImagenHuella.Location = New System.Drawing.Point(16, 24)
        Me.ImagenHuella.Name = "ImagenHuella"
        Me.ImagenHuella.Size = New System.Drawing.Size(280, 296)
        Me.ImagenHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenHuella.TabIndex = 1
        Me.ImagenHuella.TabStop = False
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(312, 24)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 7
        Me.LblNombre.Text = "Nombre:"
        '
        'TxtBxNombre
        '
        Me.TxtBxNombre.Enabled = False
        Me.TxtBxNombre.Location = New System.Drawing.Point(312, 40)
        Me.TxtBxNombre.Name = "TxtBxNombre"
        Me.TxtBxNombre.Size = New System.Drawing.Size(272, 20)
        Me.TxtBxNombre.TabIndex = 6
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Location = New System.Drawing.Point(496, 272)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(88, 48)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LblHuella
        '
        Me.LblHuella.AutoSize = True
        Me.LblHuella.Location = New System.Drawing.Point(24, 320)
        Me.LblHuella.Name = "LblHuella"
        Me.LblHuella.Size = New System.Drawing.Size(0, 13)
        Me.LblHuella.TabIndex = 8
        '
        'CBActivo
        '
        Me.CBActivo.AutoSize = True
        Me.CBActivo.Checked = True
        Me.CBActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBActivo.Location = New System.Drawing.Point(528, 64)
        Me.CBActivo.Name = "CBActivo"
        Me.CBActivo.Size = New System.Drawing.Size(56, 17)
        Me.CBActivo.TabIndex = 9
        Me.CBActivo.Text = "Activo"
        Me.CBActivo.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 339)
        Me.Controls.Add(Me.CBActivo)
        Me.Controls.Add(Me.LblHuella)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TxtBxNombre)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.ImagenHuella)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form7"
        Me.Text = "Registrar Usuario"
        CType(Me.ImagenHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImagenHuella As PictureBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtBxNombre As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents LblHuella As Label
    Friend WithEvents CBActivo As CheckBox
End Class
