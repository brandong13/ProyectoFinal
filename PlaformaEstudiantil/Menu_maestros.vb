Public Class Menu_maestros
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        login_maestros.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        alumnos_maestros.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        captura_calif.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles datos_per.Click
        datos_per_docente.Show()
        Me.Hide()
    End Sub
End Class