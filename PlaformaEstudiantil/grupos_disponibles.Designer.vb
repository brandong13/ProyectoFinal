<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class grupos_disponibles
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlataformaDataAlumnos1 = New PlaformaEstudiantil.PlataformaDataAlumnos()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MateriashorariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlataformaDataSetMaterias = New PlaformaEstudiantil.PlataformaDataSetMaterias()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Materias_horariosTableAdapter = New PlaformaEstudiantil.PlataformaDataSetMateriasTableAdapters.Materias_horariosTableAdapter()
        Me.Registar = New System.Windows.Forms.Button()
        Me.Mostrar = New System.Windows.Forms.Button()
        Me.MateriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlataformaDataAlumnos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriashorariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlataformaDataSetMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(106, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 27)
        Me.Label11.TabIndex = 320
        Me.Label11.Text = "Usuario"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.PlaformaEstudiantil.My.Resources.Resources.Opciones_removebg_preview
        Me.PictureBox5.Location = New System.Drawing.Point(0, 84)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(113, 94)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 319
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PlaformaEstudiantil.My.Resources.Resources._2018_why_chevrolet_08_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(6, 221)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 318
        Me.PictureBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(640, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 40)
        Me.Label9.TabIndex = 317
        Me.Label9.Text = "¡Bienvenidos!"
        '
        'Regresar
        '
        Me.Regresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Regresar.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Regresar.Location = New System.Drawing.Point(485, 685)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(159, 37)
        Me.Regresar.TabIndex = 316
        Me.Regresar.Text = "Regresar"
        Me.Regresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PlaformaEstudiantil.My.Resources.Resources.Logo_Cbtis
        Me.PictureBox1.Location = New System.Drawing.Point(50, 636)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 315
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Gold
        Me.Button4.Location = New System.Drawing.Point(1205, 661)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(194, 46)
        Me.Button4.TabIndex = 314
        Me.Button4.Text = "Contactanos"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(513, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(454, 44)
        Me.Label2.TabIndex = 313
        Me.Label2.Text = "Administrador Academico"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(170, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1131, 44)
        Me.Label1.TabIndex = 312
        Me.Label1.Text = "Centro de Bachillerato Tecnológico Industrial y de Servicios N° 236"
        '
        'PlataformaDataAlumnos1
        '
        Me.PlataformaDataAlumnos1.DataSetName = "PlataformaDataAlumnos"
        Me.PlataformaDataAlumnos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MateriaDataGridViewTextBoxColumn, Me.Horario})
        Me.DataGridView1.DataSource = Me.MateriashorariosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(297, 303)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(347, 264)
        Me.DataGridView1.TabIndex = 333
        '
        'MateriashorariosBindingSource
        '
        Me.MateriashorariosBindingSource.DataMember = "Materias_horarios"
        Me.MateriashorariosBindingSource.DataSource = Me.PlataformaDataSetMaterias
        '
        'PlataformaDataSetMaterias
        '
        Me.PlataformaDataSetMaterias.DataSetName = "PlataformaDataSetMaterias"
        Me.PlataformaDataSetMaterias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(750, 303)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 22)
        Me.TextBox1.TabIndex = 335
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1019, 303)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 22)
        Me.TextBox2.TabIndex = 336
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(750, 347)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(234, 22)
        Me.TextBox3.TabIndex = 337
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(1019, 347)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(138, 22)
        Me.TextBox4.TabIndex = 338
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(750, 392)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(234, 22)
        Me.TextBox5.TabIndex = 339
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(1019, 392)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(138, 22)
        Me.TextBox6.TabIndex = 340
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(750, 440)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(234, 22)
        Me.TextBox7.TabIndex = 341
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(1019, 440)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(138, 22)
        Me.TextBox8.TabIndex = 342
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(750, 486)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(234, 22)
        Me.TextBox9.TabIndex = 343
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(1019, 486)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(138, 22)
        Me.TextBox10.TabIndex = 344
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(750, 532)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(234, 22)
        Me.TextBox11.TabIndex = 345
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(1019, 532)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(138, 22)
        Me.TextBox12.TabIndex = 346
        '
        'Materias_horariosTableAdapter
        '
        Me.Materias_horariosTableAdapter.ClearBeforeFill = True
        '
        'Registar
        '
        Me.Registar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Registar.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Registar.Location = New System.Drawing.Point(672, 685)
        Me.Registar.Name = "Registar"
        Me.Registar.Size = New System.Drawing.Size(159, 37)
        Me.Registar.TabIndex = 347
        Me.Registar.Text = "Registrar"
        Me.Registar.UseVisualStyleBackColor = False
        '
        'Mostrar
        '
        Me.Mostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Mostrar.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Mostrar.Location = New System.Drawing.Point(855, 685)
        Me.Mostrar.Name = "Mostrar"
        Me.Mostrar.Size = New System.Drawing.Size(159, 37)
        Me.Mostrar.TabIndex = 348
        Me.Mostrar.Text = "Mostrar"
        Me.Mostrar.UseVisualStyleBackColor = False
        '
        'MateriaDataGridViewTextBoxColumn
        '
        Me.MateriaDataGridViewTextBoxColumn.DataPropertyName = "Materia"
        Me.MateriaDataGridViewTextBoxColumn.HeaderText = "Materia"
        Me.MateriaDataGridViewTextBoxColumn.Name = "MateriaDataGridViewTextBoxColumn"
        '
        'Horario
        '
        Me.Horario.DataPropertyName = "Horario"
        Me.Horario.HeaderText = "Horario"
        Me.Horario.Name = "Horario"
        '
        'grupos_disponibles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1470, 755)
        Me.Controls.Add(Me.Mostrar)
        Me.Controls.Add(Me.Registar)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "grupos_disponibles"
        Me.Text = "grupos_disponibles"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlataformaDataAlumnos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriashorariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlataformaDataSetMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Regresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PlataformaDataAlumnos1 As PlataformaDataAlumnos
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents PlataformaDataSetMaterias As PlataformaDataSetMaterias
    Friend WithEvents MateriashorariosBindingSource As BindingSource
    Friend WithEvents Materias_horariosTableAdapter As PlataformaDataSetMateriasTableAdapters.Materias_horariosTableAdapter
    Friend WithEvents HorarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Registar As Button
    Friend WithEvents Mostrar As Button
    Friend WithEvents MateriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Horario As DataGridViewTextBoxColumn
End Class
