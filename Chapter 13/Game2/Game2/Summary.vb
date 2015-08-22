Public Class Summary

    Private numGuesses = Form1.numGuesses
    Private correctGuess = Form1.correctGuess
    Private wrongGuess = Form1.wrongGuess

    Private Sub Summary_Click(sender As Object, e As System.EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Private Sub Summary_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        TotalGuesses.Text = "Number of guesses: " + CStr(numGuesses)
        CorrectGuesses.Text = "Correct: " + CStr(FormatNumber((correctGuess / numGuesses) * 100)) + "%"
        IncorrectGuesses.Text = "Incorrect: " + CStr(FormatNumber((wrongGuess / numGuesses) * 100)) + "%"
    End Sub

    Private Sub Summary_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim xCenterInteger As Integer = 150
        Dim yCenterInteger As Integer = 15
        Dim ClearBrush As New SolidBrush(Summary.DefaultBackColor)

        Dim CorrectGuessesInteger As Integer =
            Convert.ToInt32(correctGuess / numGuesses * 360)
        e.Graphics.FillPie(Brushes.Blue, xCenterInteger, yCenterInteger, 100, 100, 0, CorrectGuessesInteger)
        Dim IncorrectGuessesInteger As Integer =
            Convert.ToInt32(wrongGuess / numGuesses * 360)
        e.Graphics.FillPie(Brushes.Red, xCenterInteger, yCenterInteger, 100, 100, CorrectGuessesInteger, IncorrectGuessesInteger)
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class