<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class datos_alumnos
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
        Me.components = New System.ComponentModel.Container()
        Dim Label10 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Id_claveLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim PaternoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Me.Mostrar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewAlumnos = New System.Windows.Forms.DataGridView()
        Me.NocontrolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechanacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstudiantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlataformaDataSetAlu = New PlaformaEstudiantil.PlataformaDataSetAlu()
        Me.PlataformaDataAlumnos = New PlaformaEstudiantil.PlataformaDataAlumnos()
        Me.PlataformaDataAlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstudiantesTableAdapter = New PlaformaEstudiantil.PlataformaDataSetAluTableAdapters.EstudiantesTableAdapter()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.no_control_a = New System.Windows.Forms.TextBox()
        Me.nombre_a = New System.Windows.Forms.TextBox()
        Me.Paterno_a = New System.Windows.Forms.TextBox()
        Me.materno_a = New System.Windows.Forms.TextBox()
        Me.genero_a = New System.Windows.Forms.TextBox()
        Me.direccion_a = New System.Windows.Forms.TextBox()
        Me.telefono_a = New System.Windows.Forms.TextBox()
        Me.correo_a = New System.Windows.Forms.TextBox()
        Me.date_a = New System.Windows.Forms.TextBox()
        Me.contraseña_a = New System.Windows.Forms.TextBox()
        Me.especialidad_a = New System.Windows.Forms.TextBox()
        Label10 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Id_claveLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        PaternoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlataformaDataSetAlu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlataformaDataAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlataformaDataAlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label10.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label10.Location = New System.Drawing.Point(128, 391)
        Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(90, 25)
        Label10.TabIndex = 270
        Label10.Text = "Genero:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label4.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label4.Location = New System.Drawing.Point(738, 361)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(141, 25)
        Label4.TabIndex = 265
        Label4.Text = "Especialidad:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label8.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label8.Location = New System.Drawing.Point(128, 342)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(191, 25)
        Label8.TabIndex = 256
        Label8.Text = "Apellido Materno:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label5.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label5.Location = New System.Drawing.Point(738, 290)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(130, 25)
        Label5.TabIndex = 255
        Label5.Text = "Contraseña:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label6.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label6.Location = New System.Drawing.Point(738, 245)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(223, 25)
        Label6.TabIndex = 254
        Label6.Text = "Fecha de nacimiento:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label7.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label7.Location = New System.Drawing.Point(128, 454)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(108, 25)
        Label7.TabIndex = 253
        Label7.Text = "Direccion:"
        '
        'Id_claveLabel
        '
        Id_claveLabel.AutoSize = True
        Id_claveLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Id_claveLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_claveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Id_claveLabel.Location = New System.Drawing.Point(128, 247)
        Id_claveLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_claveLabel.Name = "Id_claveLabel"
        Id_claveLabel.Size = New System.Drawing.Size(132, 25)
        Id_claveLabel.TabIndex = 248
        Id_claveLabel.Text = "No. Control:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        NombreLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NombreLabel.Location = New System.Drawing.Point(128, 279)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(107, 25)
        NombreLabel.TabIndex = 249
        NombreLabel.Text = "Nombres:"
        '
        'PaternoLabel
        '
        PaternoLabel.AutoSize = True
        PaternoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        PaternoLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaternoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        PaternoLabel.Location = New System.Drawing.Point(128, 311)
        PaternoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PaternoLabel.Name = "PaternoLabel"
        PaternoLabel.Size = New System.Drawing.Size(187, 25)
        PaternoLabel.TabIndex = 250
        PaternoLabel.Text = "Apellido Paterno:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        TelefonoLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TelefonoLabel.Location = New System.Drawing.Point(128, 485)
        TelefonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(105, 25)
        TelefonoLabel.TabIndex = 251
        TelefonoLabel.Text = "Telefono:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        CorreoLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CorreoLabel.Location = New System.Drawing.Point(128, 516)
        CorreoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(85, 25)
        CorreoLabel.TabIndex = 252
        CorreoLabel.Text = "Correo:"
        '
        'Mostrar
        '
        Me.Mostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Mostrar.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mostrar.ForeColor = System.Drawing.Color.White
        Me.Mostrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Mostrar.Location = New System.Drawing.Point(670, 666)
        Me.Mostrar.Name = "Mostrar"
        Me.Mostrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Mostrar.Size = New System.Drawing.Size(148, 33)
        Me.Mostrar.TabIndex = 268
        Me.Mostrar.Text = "Mostrar"
        Me.Mostrar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(233, 487)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 31)
        Me.Label9.TabIndex = 247
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Location = New System.Drawing.Point(852, 666)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(148, 33)
        Me.Button1.TabIndex = 246
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.PlaformaEstudiantil.My.Resources.Resources.Opciones_removebg_preview
        Me.PictureBox5.Location = New System.Drawing.Point(0, 106)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(113, 94)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 245
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PlaformaEstudiantil.My.Resources.Resources._2018_why_chevrolet_08_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(0, 229)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 244
        Me.PictureBox2.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Gold
        Me.Button4.Location = New System.Drawing.Point(1186, 666)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(194, 46)
        Me.Button4.TabIndex = 243
        Me.Button4.Text = "Contactanos"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(855, 501)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 40)
        Me.Label3.TabIndex = 242
        Me.Label3.Text = "¡Bienvenidos!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PlaformaEstudiantil.My.Resources.Resources.Logo_Cbtis
        Me.PictureBox1.Location = New System.Drawing.Point(47, 630)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 241
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(558, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 31)
        Me.Label2.TabIndex = 240
        Me.Label2.Text = "¡Avanza y Construye tu Futuro!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(160, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1131, 44)
        Me.Label1.TabIndex = 239
        Me.Label1.Text = "Centro de Bachillerato Tecnológico Industrial y de Servicios N° 236"
        '
        'DataGridViewAlumnos
        '
        Me.DataGridViewAlumnos.AutoGenerateColumns = False
        Me.DataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NocontrolDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.PaternoDataGridViewTextBoxColumn, Me.MaternoDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.GeneroDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn, Me.EspecialidadDataGridViewTextBoxColumn, Me.FechanacimientoDataGridViewTextBoxColumn})
        Me.DataGridViewAlumnos.DataSource = Me.EstudiantesBindingSource
        Me.DataGridViewAlumnos.Location = New System.Drawing.Point(1495, 581)
        Me.DataGridViewAlumnos.Name = "DataGridViewAlumnos"
        Me.DataGridViewAlumnos.RowTemplate.Height = 24
        Me.DataGridViewAlumnos.Size = New System.Drawing.Size(94, 42)
        Me.DataGridViewAlumnos.TabIndex = 271
        '
        'NocontrolDataGridViewTextBoxColumn
        '
        Me.NocontrolDataGridViewTextBoxColumn.DataPropertyName = "No_control"
        Me.NocontrolDataGridViewTextBoxColumn.HeaderText = "No_control"
        Me.NocontrolDataGridViewTextBoxColumn.Name = "NocontrolDataGridViewTextBoxColumn"
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        '
        'PaternoDataGridViewTextBoxColumn
        '
        Me.PaternoDataGridViewTextBoxColumn.DataPropertyName = "Paterno"
        Me.PaternoDataGridViewTextBoxColumn.HeaderText = "Paterno"
        Me.PaternoDataGridViewTextBoxColumn.Name = "PaternoDataGridViewTextBoxColumn"
        '
        'MaternoDataGridViewTextBoxColumn
        '
        Me.MaternoDataGridViewTextBoxColumn.DataPropertyName = "Materno"
        Me.MaternoDataGridViewTextBoxColumn.HeaderText = "Materno"
        Me.MaternoDataGridViewTextBoxColumn.Name = "MaternoDataGridViewTextBoxColumn"
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'GeneroDataGridViewTextBoxColumn
        '
        Me.GeneroDataGridViewTextBoxColumn.DataPropertyName = "Genero"
        Me.GeneroDataGridViewTextBoxColumn.HeaderText = "Genero"
        Me.GeneroDataGridViewTextBoxColumn.Name = "GeneroDataGridViewTextBoxColumn"
        '
        'ContraseñaDataGridViewTextBoxColumn
        '
        Me.ContraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.Name = "ContraseñaDataGridViewTextBoxColumn"
        '
        'EspecialidadDataGridViewTextBoxColumn
        '
        Me.EspecialidadDataGridViewTextBoxColumn.DataPropertyName = "Especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.Name = "EspecialidadDataGridViewTextBoxColumn"
        '
        'FechanacimientoDataGridViewTextBoxColumn
        '
        Me.FechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_nacimiento"
        Me.FechanacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha_nacimiento"
        Me.FechanacimientoDataGridViewTextBoxColumn.Name = "FechanacimientoDataGridViewTextBoxColumn"
        '
        'EstudiantesBindingSource
        '
        Me.EstudiantesBindingSource.DataMember = "Estudiantes"
        Me.EstudiantesBindingSource.DataSource = Me.PlataformaDataSetAlu
        '
        'PlataformaDataSetAlu
        '
        Me.PlataformaDataSetAlu.DataSetName = "PlataformaDataSetAlu"
        Me.PlataformaDataSetAlu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlataformaDataAlumnos
        '
        Me.PlataformaDataAlumnos.DataSetName = "PlataformaDataAlumnos"
        Me.PlataformaDataAlumnos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlataformaDataAlumnosBindingSource
        '
        Me.PlataformaDataAlumnosBindingSource.DataSource = Me.PlataformaDataAlumnos
        Me.PlataformaDataAlumnosBindingSource.Position = 0
        '
        'EstudiantesTableAdapter
        '
        Me.EstudiantesTableAdapter.ClearBeforeFill = True
        '
        'Regresar
        '
        Me.Regresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Regresar.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.White
        Me.Regresar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Regresar.Location = New System.Drawing.Point(482, 666)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Regresar.Size = New System.Drawing.Size(148, 33)
        Me.Regresar.TabIndex = 272
        Me.Regresar.Text = "Regresar"
        Me.Regresar.UseVisualStyleBackColor = False
        '
        'no_control_a
        '
        Me.no_control_a.Enabled = False
        Me.no_control_a.Location = New System.Drawing.Point(349, 252)
        Me.no_control_a.Name = "no_control_a"
        Me.no_control_a.Size = New System.Drawing.Size(245, 22)
        Me.no_control_a.TabIndex = 274
        '
        'nombre_a
        '
        Me.nombre_a.Enabled = False
        Me.nombre_a.Location = New System.Drawing.Point(349, 284)
        Me.nombre_a.Name = "nombre_a"
        Me.nombre_a.Size = New System.Drawing.Size(245, 22)
        Me.nombre_a.TabIndex = 275
        '
        'Paterno_a
        '
        Me.Paterno_a.Enabled = False
        Me.Paterno_a.Location = New System.Drawing.Point(349, 316)
        Me.Paterno_a.Name = "Paterno_a"
        Me.Paterno_a.Size = New System.Drawing.Size(245, 22)
        Me.Paterno_a.TabIndex = 276
        '
        'materno_a
        '
        Me.materno_a.Enabled = False
        Me.materno_a.Location = New System.Drawing.Point(349, 347)
        Me.materno_a.Name = "materno_a"
        Me.materno_a.Size = New System.Drawing.Size(245, 22)
        Me.materno_a.TabIndex = 277
        '
        'genero_a
        '
        Me.genero_a.Enabled = False
        Me.genero_a.Location = New System.Drawing.Point(349, 396)
        Me.genero_a.Name = "genero_a"
        Me.genero_a.Size = New System.Drawing.Size(245, 22)
        Me.genero_a.TabIndex = 278
        '
        'direccion_a
        '
        Me.direccion_a.Location = New System.Drawing.Point(349, 459)
        Me.direccion_a.Name = "direccion_a"
        Me.direccion_a.Size = New System.Drawing.Size(245, 22)
        Me.direccion_a.TabIndex = 279
        '
        'telefono_a
        '
        Me.telefono_a.Location = New System.Drawing.Point(349, 490)
        Me.telefono_a.Name = "telefono_a"
        Me.telefono_a.Size = New System.Drawing.Size(245, 22)
        Me.telefono_a.TabIndex = 280
        '
        'correo_a
        '
        Me.correo_a.Enabled = False
        Me.correo_a.Location = New System.Drawing.Point(349, 521)
        Me.correo_a.Name = "correo_a"
        Me.correo_a.Size = New System.Drawing.Size(245, 22)
        Me.correo_a.TabIndex = 281
        '
        'date_a
        '
        Me.date_a.Enabled = False
        Me.date_a.Location = New System.Drawing.Point(1007, 252)
        Me.date_a.Name = "date_a"
        Me.date_a.Size = New System.Drawing.Size(245, 22)
        Me.date_a.TabIndex = 282
        '
        'contraseña_a
        '
        Me.contraseña_a.Location = New System.Drawing.Point(1007, 295)
        Me.contraseña_a.Name = "contraseña_a"
        Me.contraseña_a.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contraseña_a.Size = New System.Drawing.Size(245, 22)
        Me.contraseña_a.TabIndex = 283
        '
        'especialidad_a
        '
        Me.especialidad_a.Enabled = False
        Me.especialidad_a.Location = New System.Drawing.Point(1007, 366)
        Me.especialidad_a.Name = "especialidad_a"
        Me.especialidad_a.Size = New System.Drawing.Size(245, 22)
        Me.especialidad_a.TabIndex = 284
        '
        'datos_alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1426, 765)
        Me.Controls.Add(Me.especialidad_a)
        Me.Controls.Add(Me.contraseña_a)
        Me.Controls.Add(Me.date_a)
        Me.Controls.Add(Me.correo_a)
        Me.Controls.Add(Me.telefono_a)
        Me.Controls.Add(Me.direccion_a)
        Me.Controls.Add(Me.genero_a)
        Me.Controls.Add(Me.materno_a)
        Me.Controls.Add(Me.Paterno_a)
        Me.Controls.Add(Me.nombre_a)
        Me.Controls.Add(Me.no_control_a)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.DataGridViewAlumnos)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.Mostrar)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Id_claveLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(PaternoLabel)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "datos_alumnos"
        Me.Text = "datos_alumnos"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlataformaDataSetAlu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlataformaDataAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlataformaDataAlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mostrar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewAlumnos As DataGridView
    Friend WithEvents PlataformaDataAlumnosBindingSource As BindingSource
    Friend WithEvents PlataformaDataAlumnos As PlataformaDataAlumnos
    Friend WithEvents PlataformaDataSetAlu As PlataformaDataSetAlu
    Friend WithEvents EstudiantesBindingSource As BindingSource
    Friend WithEvents EstudiantesTableAdapter As PlataformaDataSetAluTableAdapters.EstudiantesTableAdapter
    Friend WithEvents NocontrolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaternoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaternoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeneroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspecialidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechanacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Regresar As Button
    Friend WithEvents no_control_a As TextBox
    Friend WithEvents nombre_a As TextBox
    Friend WithEvents Paterno_a As TextBox
    Friend WithEvents materno_a As TextBox
    Friend WithEvents genero_a As TextBox
    Friend WithEvents direccion_a As TextBox
    Friend WithEvents telefono_a As TextBox
    Friend WithEvents correo_a As TextBox
    Friend WithEvents date_a As TextBox
    Friend WithEvents contraseña_a As TextBox
    Friend WithEvents especialidad_a As TextBox
End Class
