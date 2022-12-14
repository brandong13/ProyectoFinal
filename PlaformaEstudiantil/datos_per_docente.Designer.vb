<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class datos_per_docente
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
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Id_claveLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim PaternoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Me.genero_maes = New System.Windows.Forms.ComboBox()
        Me.date_maes = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.contraseña_maes = New System.Windows.Forms.TextBox()
        Me.correo_maes = New System.Windows.Forms.TextBox()
        Me.telefono_maes = New System.Windows.Forms.TextBox()
        Me.direccion_maes = New System.Windows.Forms.TextBox()
        Me.materno_maes = New System.Windows.Forms.TextBox()
        Me.paterno_maes = New System.Windows.Forms.TextBox()
        Me.nombre_maes = New System.Windows.Forms.TextBox()
        Me.matricula_maes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Actualizar_doc = New System.Windows.Forms.Button()
        Me.PlataformaDataSetMaestros = New PlaformaEstudiantil.PlataformaDataSetMaestros()
        Me.MaestrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaestrosTableAdapter = New PlaformaEstudiantil.PlataformaDataSetMaestrosTableAdapters.MaestrosTableAdapter()
        Me.TableAdapterManager = New PlaformaEstudiantil.PlataformaDataSetMaestrosTableAdapters.TableAdapterManager()
        Me.MaestrosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mostrar = New System.Windows.Forms.Button()
        Label9 = New System.Windows.Forms.Label()
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
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlataformaDataSetMaestros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaestrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaestrosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label9.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label9.Location = New System.Drawing.Point(114, 421)
        Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(90, 25)
        Label9.TabIndex = 275
        Label9.Text = "Genero:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label8.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label8.Location = New System.Drawing.Point(114, 358)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(191, 25)
        Label8.TabIndex = 274
        Label8.Text = "Apellido Materno:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label5.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label5.Location = New System.Drawing.Point(724, 297)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(130, 25)
        Label5.TabIndex = 273
        Label5.Text = "Contraseña:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label6.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label6.Location = New System.Drawing.Point(724, 261)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(223, 25)
        Label6.TabIndex = 272
        Label6.Text = "Fecha de nacimiento:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label7.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label7.Location = New System.Drawing.Point(114, 495)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(108, 25)
        Label7.TabIndex = 271
        Label7.Text = "Direccion:"
        '
        'Id_claveLabel
        '
        Id_claveLabel.AutoSize = True
        Id_claveLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Id_claveLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_claveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Id_claveLabel.Location = New System.Drawing.Point(114, 263)
        Id_claveLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_claveLabel.Name = "Id_claveLabel"
        Id_claveLabel.Size = New System.Drawing.Size(111, 25)
        Id_claveLabel.TabIndex = 266
        Id_claveLabel.Text = "Matricula:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        NombreLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NombreLabel.Location = New System.Drawing.Point(114, 295)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(107, 25)
        NombreLabel.TabIndex = 267
        NombreLabel.Text = "Nombres:"
        '
        'PaternoLabel
        '
        PaternoLabel.AutoSize = True
        PaternoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        PaternoLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaternoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        PaternoLabel.Location = New System.Drawing.Point(114, 327)
        PaternoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PaternoLabel.Name = "PaternoLabel"
        PaternoLabel.Size = New System.Drawing.Size(187, 25)
        PaternoLabel.TabIndex = 268
        PaternoLabel.Text = "Apellido Paterno:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        TelefonoLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TelefonoLabel.Location = New System.Drawing.Point(114, 526)
        TelefonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(105, 25)
        TelefonoLabel.TabIndex = 269
        TelefonoLabel.Text = "Telefono:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        CorreoLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CorreoLabel.Location = New System.Drawing.Point(114, 557)
        CorreoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(85, 25)
        CorreoLabel.TabIndex = 270
        CorreoLabel.Text = "Correo:"
        '
        'genero_maes
        '
        Me.genero_maes.FormattingEnabled = True
        Me.genero_maes.Location = New System.Drawing.Point(361, 420)
        Me.genero_maes.Name = "genero_maes"
        Me.genero_maes.Size = New System.Drawing.Size(245, 24)
        Me.genero_maes.TabIndex = 292
        '
        'date_maes
        '
        Me.date_maes.Location = New System.Drawing.Point(971, 264)
        Me.date_maes.Name = "date_maes"
        Me.date_maes.Size = New System.Drawing.Size(269, 22)
        Me.date_maes.TabIndex = 290
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gold
        Me.Label12.Location = New System.Drawing.Point(640, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(220, 40)
        Me.Label12.TabIndex = 286
        Me.Label12.Text = "¡Bienvenidos!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(571, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 31)
        Me.Label2.TabIndex = 285
        Me.Label2.Text = "¡Avanza y Construye tu Futuro!"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(146, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1131, 44)
        Me.Label11.TabIndex = 284
        Me.Label11.Text = "Centro de Bachillerato Tecnológico Industrial y de Servicios N° 236"
        '
        'contraseña_maes
        '
        Me.contraseña_maes.Location = New System.Drawing.Point(971, 300)
        Me.contraseña_maes.Name = "contraseña_maes"
        Me.contraseña_maes.Size = New System.Drawing.Size(245, 22)
        Me.contraseña_maes.TabIndex = 283
        '
        'correo_maes
        '
        Me.correo_maes.Location = New System.Drawing.Point(361, 560)
        Me.correo_maes.Name = "correo_maes"
        Me.correo_maes.Size = New System.Drawing.Size(245, 22)
        Me.correo_maes.TabIndex = 282
        '
        'telefono_maes
        '
        Me.telefono_maes.Location = New System.Drawing.Point(361, 529)
        Me.telefono_maes.Name = "telefono_maes"
        Me.telefono_maes.Size = New System.Drawing.Size(245, 22)
        Me.telefono_maes.TabIndex = 281
        '
        'direccion_maes
        '
        Me.direccion_maes.Location = New System.Drawing.Point(361, 498)
        Me.direccion_maes.Name = "direccion_maes"
        Me.direccion_maes.Size = New System.Drawing.Size(245, 22)
        Me.direccion_maes.TabIndex = 280
        '
        'materno_maes
        '
        Me.materno_maes.BackColor = System.Drawing.Color.White
        Me.materno_maes.Location = New System.Drawing.Point(361, 361)
        Me.materno_maes.Name = "materno_maes"
        Me.materno_maes.Size = New System.Drawing.Size(245, 22)
        Me.materno_maes.TabIndex = 279
        '
        'paterno_maes
        '
        Me.paterno_maes.BackColor = System.Drawing.Color.White
        Me.paterno_maes.Location = New System.Drawing.Point(361, 330)
        Me.paterno_maes.Name = "paterno_maes"
        Me.paterno_maes.Size = New System.Drawing.Size(245, 22)
        Me.paterno_maes.TabIndex = 278
        '
        'nombre_maes
        '
        Me.nombre_maes.BackColor = System.Drawing.Color.White
        Me.nombre_maes.Location = New System.Drawing.Point(361, 298)
        Me.nombre_maes.Name = "nombre_maes"
        Me.nombre_maes.Size = New System.Drawing.Size(245, 22)
        Me.nombre_maes.TabIndex = 277
        '
        'matricula_maes
        '
        Me.matricula_maes.BackColor = System.Drawing.Color.White
        Me.matricula_maes.Location = New System.Drawing.Point(361, 266)
        Me.matricula_maes.Name = "matricula_maes"
        Me.matricula_maes.Size = New System.Drawing.Size(245, 22)
        Me.matricula_maes.TabIndex = 276
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(219, 528)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 31)
        Me.Label4.TabIndex = 265
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(524, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 44)
        Me.Label1.TabIndex = 261
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.PlaformaEstudiantil.My.Resources.Resources.Opciones_removebg_preview
        Me.PictureBox5.Location = New System.Drawing.Point(0, 107)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(113, 94)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 288
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PlaformaEstudiantil.My.Resources.Resources._2018_why_chevrolet_08_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(0, 230)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 287
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PlaformaEstudiantil.My.Resources.Resources.Logo_Cbtis
        Me.PictureBox1.Location = New System.Drawing.Point(28, 649)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 264
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.PlaformaEstudiantil.My.Resources.Resources.LogoMakr_2Fs8pJ_300x300
        Me.PictureBox4.Location = New System.Drawing.Point(1309, 570)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(67, 61)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 263
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PlaformaEstudiantil.My.Resources.Resources.fb701f7e475d00d5038f9b904875ca40_removebg_preview
        Me.PictureBox3.Location = New System.Drawing.Point(1299, 637)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(91, 83)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 262
        Me.PictureBox3.TabStop = False
        '
        'Regresar
        '
        Me.Regresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Regresar.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Regresar.Location = New System.Drawing.Point(697, 684)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(166, 36)
        Me.Regresar.TabIndex = 339
        Me.Regresar.Text = "Regresar"
        Me.Regresar.UseVisualStyleBackColor = False
        '
        'Actualizar_doc
        '
        Me.Actualizar_doc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Actualizar_doc.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Actualizar_doc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Actualizar_doc.Location = New System.Drawing.Point(930, 684)
        Me.Actualizar_doc.Name = "Actualizar_doc"
        Me.Actualizar_doc.Size = New System.Drawing.Size(166, 36)
        Me.Actualizar_doc.TabIndex = 340
        Me.Actualizar_doc.Text = "Actualizar"
        Me.Actualizar_doc.UseVisualStyleBackColor = False
        '
        'PlataformaDataSetMaestros
        '
        Me.PlataformaDataSetMaestros.DataSetName = "PlataformaDataSetMaestros"
        Me.PlataformaDataSetMaestros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaestrosBindingSource
        '
        Me.MaestrosBindingSource.DataMember = "Maestros"
        Me.MaestrosBindingSource.DataSource = Me.PlataformaDataSetMaestros
        '
        'MaestrosTableAdapter
        '
        Me.MaestrosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MaestrosTableAdapter = Me.MaestrosTableAdapter
        Me.TableAdapterManager.UpdateOrder = PlaformaEstudiantil.PlataformaDataSetMaestrosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaestrosDataGridView
        '
        Me.MaestrosDataGridView.AutoGenerateColumns = False
        Me.MaestrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaestrosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.MaestrosDataGridView.DataSource = Me.MaestrosBindingSource
        Me.MaestrosDataGridView.Location = New System.Drawing.Point(1483, 508)
        Me.MaestrosDataGridView.Name = "MaestrosDataGridView"
        Me.MaestrosDataGridView.RowTemplate.Height = 24
        Me.MaestrosDataGridView.Size = New System.Drawing.Size(49, 23)
        Me.MaestrosDataGridView.TabIndex = 341
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "matricula_maes"
        Me.DataGridViewTextBoxColumn1.HeaderText = "matricula_maes"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre_maes"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre_maes"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "paterno_maes"
        Me.DataGridViewTextBoxColumn3.HeaderText = "paterno_maes"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "materno_maes"
        Me.DataGridViewTextBoxColumn4.HeaderText = "materno_maes"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "genero_maes"
        Me.DataGridViewTextBoxColumn5.HeaderText = "genero_maes"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "telefono_maes"
        Me.DataGridViewTextBoxColumn6.HeaderText = "telefono_maes"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "correo_maes"
        Me.DataGridViewTextBoxColumn7.HeaderText = "correo_maes"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "nacimiento_maes"
        Me.DataGridViewTextBoxColumn8.HeaderText = "nacimiento_maes"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "contraseña_maes"
        Me.DataGridViewTextBoxColumn9.HeaderText = "contraseña_maes"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Mostrar
        '
        Me.Mostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Mostrar.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Mostrar.Location = New System.Drawing.Point(463, 684)
        Me.Mostrar.Name = "Mostrar"
        Me.Mostrar.Size = New System.Drawing.Size(166, 36)
        Me.Mostrar.TabIndex = 342
        Me.Mostrar.Text = "Mostrar"
        Me.Mostrar.UseVisualStyleBackColor = False
        '
        'datos_per_docente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1423, 769)
        Me.Controls.Add(Me.Mostrar)
        Me.Controls.Add(Me.MaestrosDataGridView)
        Me.Controls.Add(Me.Actualizar_doc)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.genero_maes)
        Me.Controls.Add(Me.date_maes)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.contraseña_maes)
        Me.Controls.Add(Me.correo_maes)
        Me.Controls.Add(Me.telefono_maes)
        Me.Controls.Add(Me.direccion_maes)
        Me.Controls.Add(Me.materno_maes)
        Me.Controls.Add(Me.paterno_maes)
        Me.Controls.Add(Me.nombre_maes)
        Me.Controls.Add(Me.matricula_maes)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Id_claveLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(PaternoLabel)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "datos_per_docente"
        Me.Text = "datos_per_docente"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlataformaDataSetMaestros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaestrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaestrosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents genero_maes As ComboBox
    Friend WithEvents date_maes As DateTimePicker
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents contraseña_maes As TextBox
    Friend WithEvents correo_maes As TextBox
    Friend WithEvents telefono_maes As TextBox
    Friend WithEvents direccion_maes As TextBox
    Friend WithEvents materno_maes As TextBox
    Friend WithEvents paterno_maes As TextBox
    Friend WithEvents nombre_maes As TextBox
    Friend WithEvents matricula_maes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Regresar As Button
    Friend WithEvents Actualizar_doc As Button
    Friend WithEvents PlataformaDataSetMaestros As PlataformaDataSetMaestros
    Friend WithEvents MaestrosBindingSource As BindingSource
    Friend WithEvents MaestrosTableAdapter As PlataformaDataSetMaestrosTableAdapters.MaestrosTableAdapter
    Friend WithEvents TableAdapterManager As PlataformaDataSetMaestrosTableAdapters.TableAdapterManager
    Friend WithEvents MaestrosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Mostrar As Button
End Class
