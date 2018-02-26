<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Manejo = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.EntVencidos = New System.Windows.Forms.TabPage()
        Me.DGVEntVencidos = New System.Windows.Forms.DataGridView()
        Me.EntProximos = New System.Windows.Forms.TabPage()
        Me.Reportes = New System.Windows.Forms.TabPage()
        Me.LblCodigoEntrenamiento = New System.Windows.Forms.Label()
        Me.CmbBxCodigoEntrenamiento = New System.Windows.Forms.ComboBox()
        Me.BtnFiltrarFechas = New System.Windows.Forms.Button()
        Me.DGVEntrenamientos = New System.Windows.Forms.DataGridView()
        Me.LblNEntrenamientos = New System.Windows.Forms.Label()
        Me.LblNumeroEntrenamientos = New System.Windows.Forms.Label()
        Me.LblFechaFin = New System.Windows.Forms.Label()
        Me.FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaInicio = New System.Windows.Forms.Label()
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Administracion = New System.Windows.Forms.TabPage()
        Me.PanelAdmin = New System.Windows.Forms.Panel()
        Me.CmbBxCargos = New System.Windows.Forms.ComboBox()
        Me.CmbBxPruebas = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.CmbBxFrecuencia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbBxTipoEntrenamiento = New System.Windows.Forms.ComboBox()
        Me.TxtBxCodigoEntrenamiento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxControlesTablas = New System.Windows.Forms.GroupBox()
        Me.BtnEliminarRegistro = New System.Windows.Forms.Button()
        Me.BtnModificarRegistro = New System.Windows.Forms.Button()
        Me.BtnNuevoRegistro = New System.Windows.Forms.Button()
        Me.DGVAdmin = New System.Windows.Forms.DataGridView()
        Me.CmbBxTablas = New System.Windows.Forms.ComboBox()
        Me.DGVEntProximos = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.Manejo.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.EntVencidos.SuspendLayout()
        CType(Me.DGVEntVencidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EntProximos.SuspendLayout()
        Me.Reportes.SuspendLayout()
        CType(Me.DGVEntrenamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Administracion.SuspendLayout()
        Me.PanelAdmin.SuspendLayout()
        Me.GroupBoxControlesTablas.SuspendLayout()
        CType(Me.DGVAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVEntProximos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Manejo)
        Me.TabControl1.Controls.Add(Me.Reportes)
        Me.TabControl1.Controls.Add(Me.Administracion)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1077, 550)
        Me.TabControl1.TabIndex = 0
        '
        'Manejo
        '
        Me.Manejo.BackColor = System.Drawing.SystemColors.Control
        Me.Manejo.Controls.Add(Me.TabControl2)
        Me.Manejo.Location = New System.Drawing.Point(23, 4)
        Me.Manejo.Name = "Manejo"
        Me.Manejo.Size = New System.Drawing.Size(1050, 542)
        Me.Manejo.TabIndex = 2
        Me.Manejo.Text = "Manejo"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.EntVencidos)
        Me.TabControl2.Controls.Add(Me.EntProximos)
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1050, 546)
        Me.TabControl2.TabIndex = 0
        '
        'EntVencidos
        '
        Me.EntVencidos.BackColor = System.Drawing.SystemColors.Control
        Me.EntVencidos.Controls.Add(Me.DGVEntVencidos)
        Me.EntVencidos.Location = New System.Drawing.Point(4, 22)
        Me.EntVencidos.Name = "EntVencidos"
        Me.EntVencidos.Padding = New System.Windows.Forms.Padding(3)
        Me.EntVencidos.Size = New System.Drawing.Size(1042, 520)
        Me.EntVencidos.TabIndex = 0
        Me.EntVencidos.Text = "Entrenamientos Vencidos"
        '
        'DGVEntVencidos
        '
        Me.DGVEntVencidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVEntVencidos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVEntVencidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVEntVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEntVencidos.Location = New System.Drawing.Point(3, 3)
        Me.DGVEntVencidos.Name = "DGVEntVencidos"
        Me.DGVEntVencidos.Size = New System.Drawing.Size(1033, 511)
        Me.DGVEntVencidos.TabIndex = 0
        '
        'EntProximos
        '
        Me.EntProximos.BackColor = System.Drawing.SystemColors.Control
        Me.EntProximos.Controls.Add(Me.DGVEntProximos)
        Me.EntProximos.Location = New System.Drawing.Point(4, 22)
        Me.EntProximos.Name = "EntProximos"
        Me.EntProximos.Padding = New System.Windows.Forms.Padding(3)
        Me.EntProximos.Size = New System.Drawing.Size(1042, 520)
        Me.EntProximos.TabIndex = 1
        Me.EntProximos.Text = "Entrenamientos Proximos"
        '
        'Reportes
        '
        Me.Reportes.BackColor = System.Drawing.SystemColors.Control
        Me.Reportes.Controls.Add(Me.LblCodigoEntrenamiento)
        Me.Reportes.Controls.Add(Me.CmbBxCodigoEntrenamiento)
        Me.Reportes.Controls.Add(Me.BtnFiltrarFechas)
        Me.Reportes.Controls.Add(Me.DGVEntrenamientos)
        Me.Reportes.Controls.Add(Me.LblNEntrenamientos)
        Me.Reportes.Controls.Add(Me.LblNumeroEntrenamientos)
        Me.Reportes.Controls.Add(Me.LblFechaFin)
        Me.Reportes.Controls.Add(Me.FechaFin)
        Me.Reportes.Controls.Add(Me.LblFechaInicio)
        Me.Reportes.Controls.Add(Me.FechaInicio)
        Me.Reportes.Location = New System.Drawing.Point(23, 4)
        Me.Reportes.Name = "Reportes"
        Me.Reportes.Padding = New System.Windows.Forms.Padding(3)
        Me.Reportes.Size = New System.Drawing.Size(1050, 542)
        Me.Reportes.TabIndex = 0
        Me.Reportes.Text = "Reportes"
        '
        'LblCodigoEntrenamiento
        '
        Me.LblCodigoEntrenamiento.AutoSize = True
        Me.LblCodigoEntrenamiento.Location = New System.Drawing.Point(355, 29)
        Me.LblCodigoEntrenamiento.Name = "LblCodigoEntrenamiento"
        Me.LblCodigoEntrenamiento.Size = New System.Drawing.Size(111, 13)
        Me.LblCodigoEntrenamiento.TabIndex = 36
        Me.LblCodigoEntrenamiento.Text = "Codigo Entrenamiento"
        '
        'CmbBxCodigoEntrenamiento
        '
        Me.CmbBxCodigoEntrenamiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbBxCodigoEntrenamiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBxCodigoEntrenamiento.FormattingEnabled = True
        Me.CmbBxCodigoEntrenamiento.Location = New System.Drawing.Point(358, 45)
        Me.CmbBxCodigoEntrenamiento.Name = "CmbBxCodigoEntrenamiento"
        Me.CmbBxCodigoEntrenamiento.Size = New System.Drawing.Size(142, 21)
        Me.CmbBxCodigoEntrenamiento.TabIndex = 35
        '
        'BtnFiltrarFechas
        '
        Me.BtnFiltrarFechas.Location = New System.Drawing.Point(951, 29)
        Me.BtnFiltrarFechas.Name = "BtnFiltrarFechas"
        Me.BtnFiltrarFechas.Size = New System.Drawing.Size(75, 36)
        Me.BtnFiltrarFechas.TabIndex = 34
        Me.BtnFiltrarFechas.Text = "Filtrar"
        Me.BtnFiltrarFechas.UseVisualStyleBackColor = True
        '
        'DGVEntrenamientos
        '
        Me.DGVEntrenamientos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVEntrenamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEntrenamientos.Location = New System.Drawing.Point(31, 71)
        Me.DGVEntrenamientos.Name = "DGVEntrenamientos"
        Me.DGVEntrenamientos.Size = New System.Drawing.Size(995, 391)
        Me.DGVEntrenamientos.TabIndex = 33
        '
        'LblNEntrenamientos
        '
        Me.LblNEntrenamientos.AutoSize = True
        Me.LblNEntrenamientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.LblNEntrenamientos.ForeColor = System.Drawing.Color.Red
        Me.LblNEntrenamientos.Location = New System.Drawing.Point(606, 45)
        Me.LblNEntrenamientos.Name = "LblNEntrenamientos"
        Me.LblNEntrenamientos.Size = New System.Drawing.Size(21, 20)
        Me.LblNEntrenamientos.TabIndex = 32
        Me.LblNEntrenamientos.Text = "N"
        Me.LblNEntrenamientos.Visible = False
        '
        'LblNumeroEntrenamientos
        '
        Me.LblNumeroEntrenamientos.AutoSize = True
        Me.LblNumeroEntrenamientos.Location = New System.Drawing.Point(606, 29)
        Me.LblNumeroEntrenamientos.Name = "LblNumeroEntrenamientos"
        Me.LblNumeroEntrenamientos.Size = New System.Drawing.Size(277, 13)
        Me.LblNumeroEntrenamientos.TabIndex = 31
        Me.LblNumeroEntrenamientos.Text = "Numero de entrenamientos realizados entre estas fechas:"
        Me.LblNumeroEntrenamientos.Visible = False
        '
        'LblFechaFin
        '
        Me.LblFechaFin.AutoSize = True
        Me.LblFechaFin.Location = New System.Drawing.Point(193, 29)
        Me.LblFechaFin.Name = "LblFechaFin"
        Me.LblFechaFin.Size = New System.Drawing.Size(57, 13)
        Me.LblFechaFin.TabIndex = 30
        Me.LblFechaFin.Text = "Fecha Fin:"
        '
        'FechaFin
        '
        Me.FechaFin.Location = New System.Drawing.Point(196, 45)
        Me.FechaFin.Name = "FechaFin"
        Me.FechaFin.Size = New System.Drawing.Size(146, 20)
        Me.FechaFin.TabIndex = 29
        Me.FechaFin.Value = New Date(2017, 9, 14, 10, 3, 34, 0)
        '
        'LblFechaInicio
        '
        Me.LblFechaInicio.AutoSize = True
        Me.LblFechaInicio.Location = New System.Drawing.Point(28, 29)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(68, 13)
        Me.LblFechaInicio.TabIndex = 28
        Me.LblFechaInicio.Text = "Fecha Inicio:"
        '
        'FechaInicio
        '
        Me.FechaInicio.Location = New System.Drawing.Point(31, 45)
        Me.FechaInicio.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(146, 20)
        Me.FechaInicio.TabIndex = 27
        Me.FechaInicio.Value = New Date(2017, 9, 14, 10, 3, 34, 0)
        '
        'Administracion
        '
        Me.Administracion.BackColor = System.Drawing.SystemColors.Control
        Me.Administracion.Controls.Add(Me.PanelAdmin)
        Me.Administracion.Controls.Add(Me.GroupBoxControlesTablas)
        Me.Administracion.Controls.Add(Me.DGVAdmin)
        Me.Administracion.Controls.Add(Me.CmbBxTablas)
        Me.Administracion.Location = New System.Drawing.Point(23, 4)
        Me.Administracion.Name = "Administracion"
        Me.Administracion.Padding = New System.Windows.Forms.Padding(3)
        Me.Administracion.Size = New System.Drawing.Size(1050, 542)
        Me.Administracion.TabIndex = 1
        Me.Administracion.Text = "Administracion"
        '
        'PanelAdmin
        '
        Me.PanelAdmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAdmin.Controls.Add(Me.CmbBxCargos)
        Me.PanelAdmin.Controls.Add(Me.CmbBxPruebas)
        Me.PanelAdmin.Controls.Add(Me.Label5)
        Me.PanelAdmin.Controls.Add(Me.RichTextBox1)
        Me.PanelAdmin.Controls.Add(Me.Label4)
        Me.PanelAdmin.Controls.Add(Me.BtnAgregar)
        Me.PanelAdmin.Controls.Add(Me.CmbBxFrecuencia)
        Me.PanelAdmin.Controls.Add(Me.Label3)
        Me.PanelAdmin.Controls.Add(Me.Label2)
        Me.PanelAdmin.Controls.Add(Me.CmbBxTipoEntrenamiento)
        Me.PanelAdmin.Controls.Add(Me.TxtBxCodigoEntrenamiento)
        Me.PanelAdmin.Controls.Add(Me.Label1)
        Me.PanelAdmin.Location = New System.Drawing.Point(545, 400)
        Me.PanelAdmin.Name = "PanelAdmin"
        Me.PanelAdmin.Size = New System.Drawing.Size(494, 142)
        Me.PanelAdmin.TabIndex = 5
        Me.PanelAdmin.Visible = False
        '
        'CmbBxCargos
        '
        Me.CmbBxCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBxCargos.FormattingEnabled = True
        Me.CmbBxCargos.Location = New System.Drawing.Point(156, 24)
        Me.CmbBxCargos.Name = "CmbBxCargos"
        Me.CmbBxCargos.Size = New System.Drawing.Size(121, 21)
        Me.CmbBxCargos.TabIndex = 11
        '
        'CmbBxPruebas
        '
        Me.CmbBxPruebas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBxPruebas.FormattingEnabled = True
        Me.CmbBxPruebas.Location = New System.Drawing.Point(15, 24)
        Me.CmbBxPruebas.Name = "CmbBxPruebas"
        Me.CmbBxPruebas.Size = New System.Drawing.Size(121, 21)
        Me.CmbBxPruebas.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(321, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "0/150"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(156, 64)
        Me.RichTextBox1.MaxLength = 150
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(207, 57)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(399, 82)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(85, 39)
        Me.BtnAgregar.TabIndex = 6
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'CmbBxFrecuencia
        '
        Me.CmbBxFrecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBxFrecuencia.FormattingEnabled = True
        Me.CmbBxFrecuencia.Location = New System.Drawing.Point(156, 24)
        Me.CmbBxFrecuencia.Name = "CmbBxFrecuencia"
        Me.CmbBxFrecuencia.Size = New System.Drawing.Size(121, 21)
        Me.CmbBxFrecuencia.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'CmbBxTipoEntrenamiento
        '
        Me.CmbBxTipoEntrenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBxTipoEntrenamiento.FormattingEnabled = True
        Me.CmbBxTipoEntrenamiento.Location = New System.Drawing.Point(15, 64)
        Me.CmbBxTipoEntrenamiento.Name = "CmbBxTipoEntrenamiento"
        Me.CmbBxTipoEntrenamiento.Size = New System.Drawing.Size(121, 21)
        Me.CmbBxTipoEntrenamiento.TabIndex = 2
        '
        'TxtBxCodigoEntrenamiento
        '
        Me.TxtBxCodigoEntrenamiento.Location = New System.Drawing.Point(15, 25)
        Me.TxtBxCodigoEntrenamiento.Name = "TxtBxCodigoEntrenamiento"
        Me.TxtBxCodigoEntrenamiento.Size = New System.Drawing.Size(121, 20)
        Me.TxtBxCodigoEntrenamiento.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'GroupBoxControlesTablas
        '
        Me.GroupBoxControlesTablas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxControlesTablas.Controls.Add(Me.BtnEliminarRegistro)
        Me.GroupBoxControlesTablas.Controls.Add(Me.BtnModificarRegistro)
        Me.GroupBoxControlesTablas.Controls.Add(Me.BtnNuevoRegistro)
        Me.GroupBoxControlesTablas.Location = New System.Drawing.Point(225, 459)
        Me.GroupBoxControlesTablas.Name = "GroupBoxControlesTablas"
        Me.GroupBoxControlesTablas.Size = New System.Drawing.Size(290, 68)
        Me.GroupBoxControlesTablas.TabIndex = 5
        Me.GroupBoxControlesTablas.TabStop = False
        Me.GroupBoxControlesTablas.Visible = False
        '
        'BtnEliminarRegistro
        '
        Me.BtnEliminarRegistro.Enabled = False
        Me.BtnEliminarRegistro.Location = New System.Drawing.Point(201, 17)
        Me.BtnEliminarRegistro.Name = "BtnEliminarRegistro"
        Me.BtnEliminarRegistro.Size = New System.Drawing.Size(84, 39)
        Me.BtnEliminarRegistro.TabIndex = 4
        Me.BtnEliminarRegistro.Text = "Eliminar Registro"
        Me.BtnEliminarRegistro.UseVisualStyleBackColor = True
        '
        'BtnModificarRegistro
        '
        Me.BtnModificarRegistro.Enabled = False
        Me.BtnModificarRegistro.Location = New System.Drawing.Point(106, 17)
        Me.BtnModificarRegistro.Name = "BtnModificarRegistro"
        Me.BtnModificarRegistro.Size = New System.Drawing.Size(89, 39)
        Me.BtnModificarRegistro.TabIndex = 3
        Me.BtnModificarRegistro.Text = "Modificar Registro"
        Me.BtnModificarRegistro.UseVisualStyleBackColor = True
        '
        'BtnNuevoRegistro
        '
        Me.BtnNuevoRegistro.Enabled = False
        Me.BtnNuevoRegistro.Location = New System.Drawing.Point(11, 17)
        Me.BtnNuevoRegistro.Name = "BtnNuevoRegistro"
        Me.BtnNuevoRegistro.Size = New System.Drawing.Size(89, 39)
        Me.BtnNuevoRegistro.TabIndex = 2
        Me.BtnNuevoRegistro.Text = "Nuevo Registro"
        Me.BtnNuevoRegistro.UseVisualStyleBackColor = True
        '
        'DGVAdmin
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DGVAdmin.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVAdmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVAdmin.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVAdmin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVAdmin.GridColor = System.Drawing.Color.DarkRed
        Me.DGVAdmin.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DGVAdmin.Location = New System.Drawing.Point(16, 30)
        Me.DGVAdmin.Name = "DGVAdmin"
        Me.DGVAdmin.Size = New System.Drawing.Size(1023, 356)
        Me.DGVAdmin.TabIndex = 4
        Me.DGVAdmin.TabStop = False
        '
        'CmbBxTablas
        '
        Me.CmbBxTablas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbBxTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBxTablas.FormattingEnabled = True
        Me.CmbBxTablas.Location = New System.Drawing.Point(16, 484)
        Me.CmbBxTablas.Name = "CmbBxTablas"
        Me.CmbBxTablas.Size = New System.Drawing.Size(184, 21)
        Me.CmbBxTablas.TabIndex = 0
        '
        'DGVEntProximos
        '
        Me.DGVEntProximos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVEntProximos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVEntProximos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVEntProximos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEntProximos.Location = New System.Drawing.Point(5, 5)
        Me.DGVEntProximos.Name = "DGVEntProximos"
        Me.DGVEntProximos.Size = New System.Drawing.Size(1033, 511)
        Me.DGVEntProximos.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1287, 573)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.Manejo.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.EntVencidos.ResumeLayout(False)
        CType(Me.DGVEntVencidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EntProximos.ResumeLayout(False)
        Me.Reportes.ResumeLayout(False)
        Me.Reportes.PerformLayout()
        CType(Me.DGVEntrenamientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Administracion.ResumeLayout(False)
        Me.PanelAdmin.ResumeLayout(False)
        Me.PanelAdmin.PerformLayout()
        Me.GroupBoxControlesTablas.ResumeLayout(False)
        CType(Me.DGVAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVEntProximos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Reportes As TabPage
    Friend WithEvents BtnFiltrarFechas As Button
    Friend WithEvents DGVEntrenamientos As DataGridView
    Friend WithEvents LblNEntrenamientos As Label
    Friend WithEvents LblNumeroEntrenamientos As Label
    Friend WithEvents LblFechaFin As Label
    Friend WithEvents FechaFin As DateTimePicker
    Friend WithEvents LblFechaInicio As Label
    Friend WithEvents FechaInicio As DateTimePicker
    Friend WithEvents Administracion As TabPage
    Friend WithEvents LblCodigoEntrenamiento As Label
    Friend WithEvents CmbBxCodigoEntrenamiento As ComboBox
    Friend WithEvents GroupBoxControlesTablas As GroupBox
    Friend WithEvents BtnEliminarRegistro As Button
    Friend WithEvents BtnModificarRegistro As Button
    Friend WithEvents BtnNuevoRegistro As Button
    Friend WithEvents DGVAdmin As DataGridView
    Friend WithEvents CmbBxTablas As ComboBox
    Friend WithEvents PanelAdmin As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbBxTipoEntrenamiento As ComboBox
    Friend WithEvents TxtBxCodigoEntrenamiento As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbBxFrecuencia As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbBxPruebas As ComboBox
    Friend WithEvents CmbBxCargos As ComboBox
    Friend WithEvents Manejo As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents EntVencidos As TabPage
    Friend WithEvents DGVEntVencidos As DataGridView
    Friend WithEvents EntProximos As TabPage
    Friend WithEvents DGVEntProximos As DataGridView
End Class
