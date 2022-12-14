Public Class grupos_disponibles
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub grupos_disponibles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PlataformaDataSetMaterias.Materias_horarios' Puede moverla o quitarla según sea necesario.
        Me.Materias_horariosTableAdapter.Fill(Me.PlataformaDataSetMaterias.Materias_horarios)

    End Sub

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Menu_estudiante.Show()
        Me.Hide()
    End Sub
End Class