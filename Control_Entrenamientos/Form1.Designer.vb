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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Manejo = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.EntVencidos = New System.Windows.Forms.TabPage()
        Me.DGVEntVencidos = New System.Windows.Forms.DataGridView()
        Me.EntProximos = New System.Windows.Forms.TabPage()
        Me.DGVEntProximos = New System.Windows.Forms.DataGridView()
        Me.Reportes = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.EntrenamientosRealizados = New System.Windows.Forms.TabPage()
        Me.LblCodigoEntrenamiento = New System.Windows.Forms.Label()
        Me.DGVEntrenamientos = New System.Windows.Forms.DataGridView()
        Me.CmbBxCodigoEntrenamiento = New System.Windows.Forms.ComboBox()
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.BtnFiltrarFechas = New System.Windows.Forms.Button()
        Me.LblFechaInicio = New System.Windows.Forms.Label()
        Me.FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.LblNEntrenamientos = New System.Windows.Forms.Label()
        Me.LblFechaFin = New System.Windows.Forms.Label()
        Me.LblNumeroEntrenamientos = New System.Windows.Forms.Label()
        Me.EntNoRealizados = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGVEntNoRealizados = New System.Windows.Forms.DataGridView()
        Me.CmbBxCodigoEnt2 = New System.Windows.Forms.ComboBox()
        Me.FechaInicio2 = New System.Windows.Forms.DateTimePicker()
        Me.BtnFiltrar2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FechaFin2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.DGVToWord = New System.Windows.Forms.Button()
        Me.DGVtoExcel = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Manejo.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.EntVencidos.SuspendLayout()
        CType(Me.DGVEntVencidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EntProximos.SuspendLayout()
        CType(Me.DGVEntProximos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Reportes.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.EntrenamientosRealizados.SuspendLayout()
        CType(Me.DGVEntrenamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EntNoRealizados.SuspendLayout()
        CType(Me.DGVEntNoRealizados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Administracion.SuspendLayout()
        Me.PanelAdmin.SuspendLayout()
        Me.GroupBoxControlesTablas.SuspendLayout()
        CType(Me.DGVAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Reportes
        '
        Me.Reportes.BackColor = System.Drawing.SystemColors.Control
        Me.Reportes.Controls.Add(Me.TabControl3)
        Me.Reportes.Location = New System.Drawing.Point(23, 4)
        Me.Reportes.Name = "Reportes"
        Me.Reportes.Padding = New System.Windows.Forms.Padding(3)
        Me.Reportes.Size = New System.Drawing.Size(1050, 542)
        Me.Reportes.TabIndex = 0
        Me.Reportes.Text = "Reportes"
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.EntrenamientosRealizados)
        Me.TabControl3.Controls.Add(Me.EntNoRealizados)
        Me.TabControl3.Location = New System.Drawing.Point(0, -2)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1050, 546)
        Me.TabControl3.TabIndex = 37
        '
        'EntrenamientosRealizados
        '
        Me.EntrenamientosRealizados.BackColor = System.Drawing.SystemColors.Control
        Me.EntrenamientosRealizados.Controls.Add(Me.LblCodigoEntrenamiento)
        Me.EntrenamientosRealizados.Controls.Add(Me.DGVEntrenamientos)
        Me.EntrenamientosRealizados.Controls.Add(Me.CmbBxCodigoEntrenamiento)
        Me.EntrenamientosRealizados.Controls.Add(Me.FechaInicio)
        Me.EntrenamientosRealizados.Controls.Add(Me.BtnFiltrarFechas)
        Me.EntrenamientosRealizados.Controls.Add(Me.LblFechaInicio)
        Me.EntrenamientosRealizados.Controls.Add(Me.FechaFin)
        Me.EntrenamientosRealizados.Controls.Add(Me.LblNEntrenamientos)
        Me.EntrenamientosRealizados.Controls.Add(Me.LblFechaFin)
        Me.EntrenamientosRealizados.Controls.Add(Me.LblNumeroEntrenamientos)
        Me.EntrenamientosRealizados.Location = New System.Drawing.Point(4, 22)
        Me.EntrenamientosRealizados.Name = "EntrenamientosRealizados"
        Me.EntrenamientosRealizados.Padding = New System.Windows.Forms.Padding(3)
        Me.EntrenamientosRealizados.Size = New System.Drawing.Size(1042, 520)
        Me.EntrenamientosRealizados.TabIndex = 0
        Me.EntrenamientosRealizados.Text = "Entrenamientos Realizados"
        '
        'LblCodigoEntrenamiento
        '
        Me.LblCodigoEntrenamiento.AutoSize = True
        Me.LblCodigoEntrenamiento.Location = New System.Drawing.Point(335, 16)
        Me.LblCodigoEntrenamiento.Name = "LblCodigoEntrenamiento"
        Me.LblCodigoEntrenamiento.Size = New System.Drawing.Size(111, 13)
        Me.LblCodigoEntrenamiento.TabIndex = 36
        Me.LblCodigoEntrenamiento.Text = "Codigo Entrenamiento"
        '
        'DGVEntrenamientos
        '
        Me.DGVEntrenamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVEntrenamientos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVEntrenamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEntrenamientos.Location = New System.Drawing.Point(11, 58)
        Me.DGVEntrenamientos.Name = "DGVEntrenamientos"
        Me.DGVEntrenamientos.Size = New System.Drawing.Size(1013, 446)
        Me.DGVEntrenamientos.TabIndex = 33
        '
        'CmbBxCodigoEntrenamiento
        '
        Me.CmbBxCodigoEntrenamiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbBxCodigoEntrenamiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBxCodigoEntrenamiento.FormattingEnabled = True
        Me.CmbBxCodigoEntrenamiento.Location = New System.Drawing.Point(338, 32)
        Me.CmbBxCodigoEntrenamiento.Name = "CmbBxCodigoEntrenamiento"
        Me.CmbBxCodigoEntrenamiento.Size = New System.Drawing.Size(142, 21)
        Me.CmbBxCodigoEntrenamiento.TabIndex = 35
        '
        'FechaInicio
        '
        Me.FechaInicio.Location = New System.Drawing.Point(11, 32)
        Me.FechaInicio.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(146, 20)
        Me.FechaInicio.TabIndex = 27
        Me.FechaInicio.Value = New Date(2017, 9, 14, 10, 3, 34, 0)
        '
        'BtnFiltrarFechas
        '
        Me.BtnFiltrarFechas.Location = New System.Drawing.Point(952, 16)
        Me.BtnFiltrarFechas.Name = "BtnFiltrarFechas"
        Me.BtnFiltrarFechas.Size = New System.Drawing.Size(75, 36)
        Me.BtnFiltrarFechas.TabIndex = 34
        Me.BtnFiltrarFechas.Text = "Filtrar"
        Me.BtnFiltrarFechas.UseVisualStyleBackColor = True
        '
        'LblFechaInicio
        '
        Me.LblFechaInicio.AutoSize = True
        Me.LblFechaInicio.Location = New System.Drawing.Point(8, 16)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(68, 13)
        Me.LblFechaInicio.TabIndex = 28
        Me.LblFechaInicio.Text = "Fecha Inicio:"
        '
        'FechaFin
        '
        Me.FechaFin.Location = New System.Drawing.Point(176, 32)
        Me.FechaFin.Name = "FechaFin"
        Me.FechaFin.Size = New System.Drawing.Size(146, 20)
        Me.FechaFin.TabIndex = 29
        Me.FechaFin.Value = New Date(2017, 9, 14, 10, 3, 34, 0)
        '
        'LblNEntrenamientos
        '
        Me.LblNEntrenamientos.AutoSize = True
        Me.LblNEntrenamientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.LblNEntrenamientos.ForeColor = System.Drawing.Color.Red
        Me.LblNEntrenamientos.Location = New System.Drawing.Point(586, 32)
        Me.LblNEntrenamientos.Name = "LblNEntrenamientos"
        Me.LblNEntrenamientos.Size = New System.Drawing.Size(21, 20)
        Me.LblNEntrenamientos.TabIndex = 32
        Me.LblNEntrenamientos.Text = "N"
        Me.LblNEntrenamientos.Visible = False
        '
        'LblFechaFin
        '
        Me.LblFechaFin.AutoSize = True
        Me.LblFechaFin.Location = New System.Drawing.Point(173, 16)
        Me.LblFechaFin.Name = "LblFechaFin"
        Me.LblFechaFin.Size = New System.Drawing.Size(57, 13)
        Me.LblFechaFin.TabIndex = 30
        Me.LblFechaFin.Text = "Fecha Fin:"
        '
        'LblNumeroEntrenamientos
        '
        Me.LblNumeroEntrenamientos.AutoSize = True
        Me.LblNumeroEntrenamientos.Location = New System.Drawing.Point(586, 16)
        Me.LblNumeroEntrenamientos.Name = "LblNumeroEntrenamientos"
        Me.LblNumeroEntrenamientos.Size = New System.Drawing.Size(277, 13)
        Me.LblNumeroEntrenamientos.TabIndex = 31
        Me.LblNumeroEntrenamientos.Text = "Numero de entrenamientos realizados entre estas fechas:"
        Me.LblNumeroEntrenamientos.Visible = False
        '
        'EntNoRealizados
        '
        Me.EntNoRealizados.BackColor = System.Drawing.SystemColors.Control
        Me.EntNoRealizados.Controls.Add(Me.Label6)
        Me.EntNoRealizados.Controls.Add(Me.DGVEntNoRealizados)
        Me.EntNoRealizados.Controls.Add(Me.CmbBxCodigoEnt2)
        Me.EntNoRealizados.Controls.Add(Me.FechaInicio2)
        Me.EntNoRealizados.Controls.Add(Me.BtnFiltrar2)
        Me.EntNoRealizados.Controls.Add(Me.Label7)
        Me.EntNoRealizados.Controls.Add(Me.FechaFin2)
        Me.EntNoRealizados.Controls.Add(Me.Label9)
        Me.EntNoRealizados.Location = New System.Drawing.Point(4, 22)
        Me.EntNoRealizados.Name = "EntNoRealizados"
        Me.EntNoRealizados.Padding = New System.Windows.Forms.Padding(3)
        Me.EntNoRealizados.Size = New System.Drawing.Size(1042, 520)
        Me.EntNoRealizados.TabIndex = 1
        Me.EntNoRealizados.Text = "Entrenamientos No Realizados"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(339, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Codigo Entrenamiento"
        '
        'DGVEntNoRealizados
        '
        Me.DGVEntNoRealizados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVEntNoRealizados.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVEntNoRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEntNoRealizados.Location = New System.Drawing.Point(15, 58)
        Me.DGVEntNoRealizados.Name = "DGVEntNoRealizados"
        Me.DGVEntNoRealizados.Size = New System.Drawing.Size(1013, 446)
        Me.DGVEntNoRealizados.TabIndex = 43
        '
        'CmbBxCodigoEnt2
        '
        Me.CmbBxCodigoEnt2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbBxCodigoEnt2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBxCodigoEnt2.FormattingEnabled = True
        Me.CmbBxCodigoEnt2.Location = New System.Drawing.Point(342, 32)
        Me.CmbBxCodigoEnt2.Name = "CmbBxCodigoEnt2"
        Me.CmbBxCodigoEnt2.Size = New System.Drawing.Size(142, 21)
        Me.CmbBxCodigoEnt2.TabIndex = 45
        '
        'FechaInicio2
        '
        Me.FechaInicio2.Location = New System.Drawing.Point(15, 32)
        Me.FechaInicio2.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.FechaInicio2.Name = "FechaInicio2"
        Me.FechaInicio2.Size = New System.Drawing.Size(146, 20)
        Me.FechaInicio2.TabIndex = 37
        Me.FechaInicio2.Value = New Date(2017, 9, 14, 10, 3, 34, 0)
        '
        'BtnFiltrar2
        '
        Me.BtnFiltrar2.Location = New System.Drawing.Point(956, 16)
        Me.BtnFiltrar2.Name = "BtnFiltrar2"
        Me.BtnFiltrar2.Size = New System.Drawing.Size(75, 36)
        Me.BtnFiltrar2.TabIndex = 44
        Me.BtnFiltrar2.Text = "Filtrar"
        Me.BtnFiltrar2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Fecha Inicio:"
        '
        'FechaFin2
        '
        Me.FechaFin2.Location = New System.Drawing.Point(180, 32)
        Me.FechaFin2.Name = "FechaFin2"
        Me.FechaFin2.Size = New System.Drawing.Size(146, 20)
        Me.FechaFin2.TabIndex = 39
        Me.FechaFin2.Value = New Date(2017, 9, 14, 10, 3, 34, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(177, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Fecha Fin:"
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
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DGVAdmin.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVAdmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVAdmin.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Coral
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVAdmin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
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
        'DGVToWord
        '
        Me.DGVToWord.Location = New System.Drawing.Point(1083, 34)
        Me.DGVToWord.Name = "DGVToWord"
        Me.DGVToWord.Size = New System.Drawing.Size(197, 54)
        Me.DGVToWord.TabIndex = 1
        Me.DGVToWord.Text = "Exportar a Word"
        Me.DGVToWord.UseVisualStyleBackColor = True
        '
        'DGVtoExcel
        '
        Me.DGVtoExcel.Location = New System.Drawing.Point(1083, 96)
        Me.DGVtoExcel.Name = "DGVtoExcel"
        Me.DGVtoExcel.Size = New System.Drawing.Size(197, 54)
        Me.DGVtoExcel.TabIndex = 2
        Me.DGVtoExcel.Text = "Exportar a Excel"
        Me.DGVtoExcel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1287, 573)
        Me.Controls.Add(Me.DGVtoExcel)
        Me.Controls.Add(Me.DGVToWord)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.Manejo.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.EntVencidos.ResumeLayout(False)
        CType(Me.DGVEntVencidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EntProximos.ResumeLayout(False)
        CType(Me.DGVEntProximos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Reportes.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.EntrenamientosRealizados.ResumeLayout(False)
        Me.EntrenamientosRealizados.PerformLayout()
        CType(Me.DGVEntrenamientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EntNoRealizados.ResumeLayout(False)
        Me.EntNoRealizados.PerformLayout()
        CType(Me.DGVEntNoRealizados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Administracion.ResumeLayout(False)
        Me.PanelAdmin.ResumeLayout(False)
        Me.PanelAdmin.PerformLayout()
        Me.GroupBoxControlesTablas.ResumeLayout(False)
        CType(Me.DGVAdmin, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents DGVToWord As Button
    Friend WithEvents DGVtoExcel As Button
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents EntrenamientosRealizados As TabPage
    Friend WithEvents EntNoRealizados As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents DGVEntNoRealizados As DataGridView
    Friend WithEvents CmbBxCodigoEnt2 As ComboBox
    Friend WithEvents FechaInicio2 As DateTimePicker
    Friend WithEvents BtnFiltrar2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents FechaFin2 As DateTimePicker
    Friend WithEvents Label9 As Label
End Class
