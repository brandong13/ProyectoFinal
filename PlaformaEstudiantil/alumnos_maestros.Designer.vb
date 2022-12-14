<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alumnos_maestros
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
        Me.Salir = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Buscar_a = New System.Windows.Forms.Button()
        Me.DataGridView_alum_mae = New System.Windows.Forms.DataGridView()
        Me.PlataformaDataAlumnos = New PlaformaEstudiantil.PlataformaDataAlumnos()
        Me.EstudiantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstudiantesTableAdapter = New PlaformaEstudiantil.PlataformaDataAlumnosTableAdapters.EstudiantesTableAdapter()
        Me.NocontrolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_alum_mae, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlataformaDataAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Salir.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Salir.Location = New System.Drawing.Point(647, 587)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(194, 46)
        Me.Salir.TabIndex = 338
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(107, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 27)
        Me.Label11.TabIndex = 336
        Me.Label11.Text = "Usuario"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.PlaformaEstudiantil.My.Resources.Resources.Opciones_removebg_preview
        Me.PictureBox5.Location = New System.Drawing.Point(0, 68)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(113, 94)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 335
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PlaformaEstudiantil.My.Resources.Resources._2018_why_chevrolet_08_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(7, 205)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 334
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PlaformaEstudiantil.My.Resources.Resources.Logo_Cbtis
        Me.PictureBox1.Location = New System.Drawing.Point(51, 621)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 329
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.PlaformaEstudiantil.My.Resources.Resources.LogoMakr_2Fs8pJ_300x300
        Me.PictureBox4.Location = New System.Drawing.Point(1322, 560)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(67, 62)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 328
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PlaformaEstudiantil.My.Resources.Resources.fb701f7e475d00d5038f9b904875ca40_removebg_preview
        Me.PictureBox3.Location = New System.Drawing.Point(1310, 472)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(91, 82)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 327
        Me.PictureBox3.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Gold
        Me.Button4.Location = New System.Drawing.Point(1206, 645)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(195, 46)
        Me.Button4.TabIndex = 326
        Me.Button4.Text = "Contactanos"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(517, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(454, 44)
        Me.Label2.TabIndex = 325
        Me.Label2.Text = "Administrador Academico"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(171, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1131, 44)
        Me.Label1.TabIndex = 324
        Me.Label1.Text = "Centro de Bachillerato Tecnológico Industrial y de Servicios N° 236"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(544, 193)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(385, 22)
        Me.TextBox1.TabIndex = 339
        '
        'Buscar_a
        '
        Me.Buscar_a.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Buscar_a.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar_a.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Buscar_a.Location = New System.Drawing.Point(999, 184)
        Me.Buscar_a.Name = "Buscar_a"
        Me.Buscar_a.Size = New System.Drawing.Size(154, 39)
        Me.Buscar_a.TabIndex = 341
        Me.Buscar_a.Text = "Buscar"
        Me.Buscar_a.UseVisualStyleBackColor = False
        '
        'DataGridView_alum_mae
        '
        Me.DataGridView_alum_mae.AutoGenerateColumns = False
        Me.DataGridView_alum_mae.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView_alum_mae.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_alum_mae.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NocontrolDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.PaternoDataGridViewTextBoxColumn, Me.MaternoDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.EspecialidadDataGridViewTextBoxColumn})
        Me.DataGridView_alum_mae.DataSource = Me.EstudiantesBindingSource
        Me.DataGridView_alum_mae.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView_alum_mae.Location = New System.Drawing.Point(370, 265)
        Me.DataGridView_alum_mae.Name = "DataGridView_alum_mae"
        Me.DataGridView_alum_mae.ReadOnly = True
        Me.DataGridView_alum_mae.RowTemplate.Height = 24
        Me.DataGridView_alum_mae.Size = New System.Drawing.Size(854, 258)
        Me.DataGridView_alum_mae.TabIndex = 342
        '
        'PlataformaDataAlumnos
        '
        Me.PlataformaDataAlumnos.DataSetName = "PlataformaDataAlumnos"
        Me.PlataformaDataAlumnos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudiantesBindingSource
        '
        Me.EstudiantesBindingSource.DataMember = "Estudiantes"
        Me.EstudiantesBindingSource.DataSource = Me.PlataformaDataAlumnos
        '
        'EstudiantesTableAdapter
        '
        Me.EstudiantesTableAdapter.ClearBeforeFill = True
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
        'EspecialidadDataGridViewTextBoxColumn
        '
        Me.EspecialidadDataGridViewTextBoxColumn.DataPropertyName = "Especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.Name = "EspecialidadDataGridViewTextBoxColumn"
        '
        'alumnos_maestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1428, 717)
        Me.Controls.Add(Me.DataGridView_alum_mae)
        Me.Controls.Add(Me.Buscar_a)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "alumnos_maestros"
        Me.Text = "alumnos_maestros"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_alum_mae, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlataformaDataAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Salir As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Buscar_a As Button
    Friend WithEvents DataGridView_alum_mae As DataGridView
    Friend WithEvents PlataformaDataAlumnos As PlataformaDataAlumnos
    Friend WithEvents EstudiantesBindingSource As BindingSource
    Friend WithEvents EstudiantesTableAdapter As PlataformaDataAlumnosTableAdapters.EstudiantesTableAdapter
    Friend WithEvents NocontrolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaternoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaternoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspecialidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
