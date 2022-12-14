Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login_estudiante.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login_aspirantes.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        login_maestros.Show()
        Me.Hide()
    End Sub

    Private Sub Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mostrar.Click
        If MsgBox("¿Estás seguro de salir de plataforma?", vbQuestion + vbYesNo, "Advertencia") Then
            End
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        login_admi.Show()
        Me.Hide()
    End Sub
End Class
