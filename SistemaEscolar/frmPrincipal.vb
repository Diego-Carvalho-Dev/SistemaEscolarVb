Public Class frmPrincipal
    Private Sub btn_alunos_Click(sender As Object, e As EventArgs) Handles btn_alunos.Click
        Dim form = New frmAlunos
        form.ShowDialog()
    End Sub

    Private Sub btn_professores_Click(sender As Object, e As EventArgs) Handles btn_professores.Click
        Dim form = New frmProfessores
        form.ShowDialog()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class