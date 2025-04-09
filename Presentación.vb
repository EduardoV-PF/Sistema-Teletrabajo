Public Class Presentación
    Private Sub bttSalirPresent_Click(sender As Object, e As EventArgs) Handles bttSalirPresent.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Información_General.Show()
    End Sub

    Private Sub bttIniciar_Click(sender As Object, e As EventArgs) Handles bttIniciar.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class