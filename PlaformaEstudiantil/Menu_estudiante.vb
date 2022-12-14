Public Class Menu_estudiante
    Private Sub Menu_estudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub materias_a_Click(sender As Object, e As EventArgs) Handles materias_a.Click
        grupos_disponibles.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        login_estudiante.Show()
        Me.Hide()
    End Sub

    Private Sub datos_per_Click(sender As Object, e As EventArgs) Handles datos_per.Click
        datos_alumnos.Show()
        Me.Hide()
    End Sub

    Private Sub reinscripcion_a_Click(sender As Object, e As EventArgs) Handles reinscripcion_a.Click
        grupos_disponibles.Show()
        Me.Hide()
    End Sub
End Class