Public Class datos_per_docente
    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Menu_maestros.Show()
        Me.Hide()
    End Sub

    Private Sub MaestrosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MaestrosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PlataformaDataSetMaestros)

    End Sub

    Private Sub datos_per_docente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PlataformaDataSetMaestros.Maestros' Puede moverla o quitarla según sea necesario.
        Me.MaestrosTableAdapter.Fill(Me.PlataformaDataSetMaestros.Maestros)

    End Sub

    Private Sub Mostrar_Click(sender As Object, e As EventArgs) Handles Mostrar.Click

    End Sub
End Class