Public Class login_maestros
    Private Sub login_maestros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirLogin()
    End Sub

    Private Sub sesion_maestro_Click(sender As Object, e As EventArgs) Handles sesion_maestro.Click
        Try
            If maestro(usuario.Text) = True Then
                Dim contrasena As String = maestro_contra(contraseña_maestro.Text)
                If contrasena.Equals(contraseña_maestro.Text) = True Then
                    'se manda a llamar el siguiente formulario
                    Menu_maestros.ShowDialog()
                    Me.Hide()
                    usuario.Text = ""
                    contraseña_maestro.Text = ""
                Else
                    MsgBox("Contraseña Invalida")
                    usuario.Text = ""
                    contraseña_maestro.Text = ""
                End If
            Else
                MsgBox("El Usuario: " + usuario.Text + " no se encuentra registrado")
                usuario.Text = ""
                contraseña_maestro.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Login.Show()
        Me.Hide()
        usuario.Text = ""
        contraseña_maestro.Text = ""
    End Sub
End Class