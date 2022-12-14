Public Class alumnos_maestros
    Private Sub alumnos_maestros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PlataformaDataAlumnos.Estudiantes' Puede moverla o quitarla según sea necesario.
        Me.EstudiantesTableAdapter.Fill(Me.PlataformaDataAlumnos.Estudiantes)

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Menu_maestros.Show()
        Me.Hide()
    End Sub
End Class