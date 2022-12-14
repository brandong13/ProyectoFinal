Public Class menu_admi
    Private Sub menu_alumno_Click(sender As Object, e As EventArgs) Handles menu_alumno.Click
        Menu_admi_alumno.Show()
        Me.Hide()
    End Sub

    Private Sub menu_aspirante_Click(sender As Object, e As EventArgs) Handles menu_aspirante.Click
        menu_admi_aspirante.Show()
        Me.Hide()
    End Sub

    Private Sub menu_docente_Click(sender As Object, e As EventArgs) Handles menu_docente.Click
        menu_admi_docente.Show()
        Me.Hide()
    End Sub
End Class