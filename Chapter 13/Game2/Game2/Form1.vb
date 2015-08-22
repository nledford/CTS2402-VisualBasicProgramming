Public Class Form1

    Private counter As Integer
    Public ranNum As Integer
    Public numGuesses As Integer = 0
    Public correctGuess As Integer = 0
    Public wrongGuess As Integer = 0

    Private Sub TextRandomNumber_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextRandomNumber.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            TextRandomNumber.DoDragDrop(TextRandomNumber.Text, DragDropEffects.Copy)
        End If
    End Sub

    Private Sub List0_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles List0.DragDrop
        If (ranNum Mod 3 = 0) Then
            List0.Items.Add(e.Data.GetData(DataFormats.Text).ToString)
            RandomNumber()
            GameMessage.Text = "Correct!"
            My.Computer.Audio.Play(My.Resources.Tada, AudioPlayMode.Background)
            numGuesses += 1
            correctGuess += 1
        Else
            GameMessage.Text = "Try again."
            My.Computer.Audio.Play(My.Resources.Ding, AudioPlayMode.Background)
            numGuesses += 1
            wrongGuess += 1
        End If
    End Sub

    Private Sub List0_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles List0.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub List1_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles List1.DragDrop
        If (ranNum Mod 3 = 1) Then
            List1.Items.Add(e.Data.GetData(DataFormats.Text).ToString)
            RandomNumber()
            GameMessage.Text = "Correct!"
            My.Computer.Audio.Play(My.Resources.Tada, AudioPlayMode.Background)
            numGuesses += 1
            correctGuess += 1
        Else
            GameMessage.Text = "Try Again."
            My.Computer.Audio.Play(My.Resources.Ding, AudioPlayMode.Background)
            numGuesses += 1
            wrongGuess += 1
        End If

    End Sub

    Private Sub List1_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles List1.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub List2_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles List2.DragDrop
        If (ranNum Mod 3 = 2) Then
            List2.Items.Add(e.Data.GetData(DataFormats.Text).ToString)
            RandomNumber()
            GameMessage.Text = "Correct!"
            My.Computer.Audio.Play(My.Resources.Tada, AudioPlayMode.Background)
            numGuesses += 1
            correctGuess += 1
        Else
            GameMessage.Text = "Try Again."
            My.Computer.Audio.Play(My.Resources.Ding, AudioPlayMode.Background)
            numGuesses += 1
            wrongGuess += 1
        End If
    End Sub

    Private Sub List2_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles List2.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub RandomNumber()
        Dim aRandomNum As New Random
        ranNum = aRandomNum.Next(1, 100)
        TextRandomNumber.Text = ranNum
    End Sub

    Private Sub ButtonHint_Click(sender As System.Object, e As System.EventArgs) Handles ButtonHint.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GameMessage.Text = "Click to play!"
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        LabelCounter.Text = counter.ToString
        counter -= 1

        If counter < 0 Then
            GameMessage.Text = "Game Over."
            Timer1.Stop()
            LabelCounter.Text = ""
            TextRandomNumber.Hide()
            Summary.Show()
        End If
    End Sub

    Private Sub GameMessage_Click(sender As System.Object, e As System.EventArgs) Handles GameMessage.Click
        Timer1.Start()
        counter = 20
        RandomNumber()
        TextRandomNumber.Show()
        GameMessage.Text = "Good Luck!"
    End Sub
End Class
