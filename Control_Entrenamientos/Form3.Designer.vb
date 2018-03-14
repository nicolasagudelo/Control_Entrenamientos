<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form3
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form3))
        Me.ImagenHuellaEntrenado = New System.Windows.Forms.PictureBox()
        CType(Me.ImagenHuellaEntrenado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImagenHuellaEntrenado
        '
        Me.ImagenHuellaEntrenado.Location = New System.Drawing.Point(26, 10)
        Me.ImagenHuellaEntrenado.Name = "ImagenHuellaEntrenado"
        Me.ImagenHuellaEntrenado.Size = New System.Drawing.Size(224, 240)
        Me.ImagenHuellaEntrenado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenHuellaEntrenado.TabIndex = 1
        Me.ImagenHuellaEntrenado.TabStop = False
        '
        'form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 261)
        Me.Controls.Add(Me.ImagenHuellaEntrenado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "form3"
        Me.Text = "Registrar Asistencia"
        CType(Me.ImagenHuellaEntrenado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImagenHuellaEntrenado As PictureBox
End Class
