Public Class Choices
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCalculator.Click
        Calculator.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonJanken.Click
        Janken.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonGlassgame.Click
        GlassGame.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub
End Class