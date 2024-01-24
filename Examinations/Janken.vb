Public Class Janken
    Private Sub Janken(playerChoice As String)

        Dim choices() As String = {"🏔️", "📜", "💇"}
        Dim computerChoice As String = choices(random.Next(choices.Length))

        LabelUser.Text = playerChoice
        LabelComputer.Text = computerChoice

        Winner(playerChoice, computerChoice)
    End Sub

    Private Sub Winner(playerChoice As String, computerChoice As String)

        If playerChoice = computerChoice Then
            Results.Text = "It's a TIE!"
            ButtonScissor.Enabled = False
            ButtonRock.Enabled = False
            ButtonPaper.Enabled = False

        ElseIf (playerChoice = "🏔️" AndAlso computerChoice = "💇") OrElse
               (playerChoice = "💇" AndAlso computerChoice = "📜") OrElse
               (playerChoice = "📜" AndAlso computerChoice = "🏔️") Then

            Results.Text = "You WIN!"
            ButtonScissor.Enabled = False
            ButtonRock.Enabled = False
            ButtonPaper.Enabled = False

        Else

            Results.Text = "You LOSE!"
            ButtonScissor.Enabled = False
            ButtonRock.Enabled = False
            ButtonPaper.Enabled = False

        End If

    End Sub

    Private random As New Random()

    Private Sub ButtonRock_Click(sender As Object, e As EventArgs) Handles ButtonRock.Click
        Janken("🏔️")
    End Sub

    Private Sub ButtonPaper_Click(sender As Object, e As EventArgs) Handles ButtonPaper.Click
        Janken("📜")
    End Sub

    Private Sub ButtonScissor_Click(sender As Object, e As EventArgs) Handles ButtonScissor.Click
        Janken("💇")
    End Sub

    Private Sub ButtonTryAgain_Click(sender As Object, e As EventArgs) Handles ButtonTry.Click

        LabelUser.Text = ""
        LabelComputer.Text = ""
        Results.Text = ""

        ButtonScissor.Enabled = True
        ButtonRock.Enabled = True
        ButtonPaper.Enabled = True

    End Sub

    Private Sub ButtonUser_Click(sender As Object, e As EventArgs)
        MessageBox.Show("ERROR: Choose Between the 3 choices below.")
    End Sub

    Private Sub ButtonComputer_Click(sender As Object, e As EventArgs)
        MessageBox.Show("ERROR: Choose Between the 3 choices below.")

    End Sub

    Private Sub Janken_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class