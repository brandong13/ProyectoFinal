Public Class datos_alumnos
    Private Sub datos_alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PlataformaDataSetAlu.Estudiantes' Puede moverla o quitarla según sea necesario.
        Me.EstudiantesTableAdapter.Fill(Me.PlataformaDataSetAlu.Estudiantes)

    End Sub

    Private Sub Mostrar_Click(sender As Object, e As EventArgs) Handles Mostrar.Click
        Me.EstudiantesTableAdapter.bu
        no_control_a.Text = DataGridViewAlumnos.CurrentRow.Cells.Item(0).Value.ToString
        nombre_a.Text = DataGridViewAlumnos.CurrentRow.Cells.Item(1).Value.ToString
        Paterno_a.Text = DataGridViewAlumnos.CurrentRow.Cells.Item(2).Value.ToString
        materno_a.Text = DataGridViewAlumnos.CurrentRow.Cells.Item(3).Value.ToString
        genero_a.Text = DataGridViewAlumnos.CurrentRow.Cells.Item(4).Value.ToString
        direccion_a.Text = DataGridViewAlumnos.CurrentRow.Cells.Item(5).Value.ToString
        telefono_a.Text = DataGridViewAlumnos.CurrentRow.Cells.Item(6).Value.ToString
        correo_a.Text = DataGridViewAlumnos.CurrentRow.Cells.Item(7).Value.ToString
        date_a.Text = DataGridViewAlumnos.CurrentRow.Cells.Item(8).Value.ToString
        contraseña_a.Text = DataGridViewAlumnos.CurrentRow.Cells.Item(9).Value.ToString
        especialidad_a.Text = DataGridViewAlumnos.CurrentRow.Cells.Item(10).Value.ToString
    End Sub

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Menu_estudiante.Show()
        Me.Hide()
    End Sub

    Private Sub no_control_a_TextChanged(sender As Object, e As EventArgs) Handles no_control_a.TextChanged
        login_estudiante.no_control.Text = Me.no_control_a.Text
    End Sub
End Class