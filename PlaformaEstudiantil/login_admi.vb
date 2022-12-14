Public Class login_admi
    Private Sub login_admi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirLogin()
    End Sub

    Private Sub Sesion_Click(sender As Object, e As EventArgs) Handles Sesion.Click
        Try
            If admi_clave(clave_admi.Text) = True Then
                Dim contrase As String = admi_contra(contraseña_admi.Text)
                If contrase.Equals(contraseña_admi.Text) = True Then
                    'se manda a llamar el siguiente formulario
                    menu_admi.ShowDialog()
                    Me.Hide()
                    clave_admi.Text = ""
                    contraseña_admi.Text = ""
                Else
                    MsgBox("Contraseña Invalida")
                    clave_admi.Text = ""
                    contraseña_admi.Text = ""
                End If
            Else
                MsgBox("El Usuario: " + clave_admi.Text + " no se encuentra registrado")
                clave_admi.Text = ""
                contraseña_admi.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class