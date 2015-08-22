Public Class Form1

    Private Block1dx As Integer = 1
    Private Block1dy As Integer = 1

    Private Block2dx As Integer = 1
    Private Block2dy As Integer = 1

    Private Block3dx As Integer = 1
    Private Block3dy As Integer = 1

    Private Block4dx As Integer = 1
    Private Block4dy As Integer = 1

    Private counter As Integer = 0

    Private Sub TimerMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMovement.Tick
        GameOverMessage.Hide()
        ButtonGamePlay.Hide()
        ButtonQuit.Hide()

        Block1.Left -= Block1dx
        Block1.Top += Block1dy

        If Block1.Bounds.IntersectsWith(WallTop.Bounds) Then
            If Block1dy <= 0 Then
                Block1dy *= -1
            End If
        End If

        If Block1.Bounds.IntersectsWith(WallBottom.Bounds) Then
            If Block1dy >= 0 Then
                Block1dy *= -1
            End If
        End If

        If Block1.Bounds.IntersectsWith(WallLeft.Bounds) Or Block1.Bounds.IntersectsWith(WallRight.Bounds) Then
            Block1dx *= -1
        End If

        Block2.Left += Block2dx
        Block2.Top += Block2dy

        If Block2.Bounds.IntersectsWith(WallBottom.Bounds) Or Block2.Bounds.IntersectsWith(WallTop.Bounds) Then
            Block2dy *= -1
        End If

        If Block2.Bounds.IntersectsWith(WallRight.Bounds) Or Block2.Bounds.IntersectsWith(WallLeft.Bounds) Then
            Block2dx *= -1
        End If

        Block3.Left += Block3dx
        Block3.Top -= Block3dy

        If Block3.Bounds.IntersectsWith(WallTop.Bounds) Or Block3.Bounds.IntersectsWith(WallBottom.Bounds) Then
            Block3dy *= -1
        End If

        If Block3.Bounds.IntersectsWith(WallLeft.Bounds) Or Block3.Bounds.IntersectsWith(WallRight.Bounds) Then
            Block3dx *= -1
        End If

        Block4.Left -= Block4dx
        Block4.Top -= Block4dy

        If Block4.Bounds.IntersectsWith(WallTop.Bounds) Or Block4.Bounds.IntersectsWith(WallBottom.Bounds) Then
            Block4dy *= -1
        End If

        If Block4.Bounds.IntersectsWith(WallLeft.Bounds) Or Block4.Bounds.IntersectsWith(WallRight.Bounds) Then
            Block4dx *= -1
        End If

        If counter = 1000 Or
            counter = 2000 Or
            counter = 3000 Or
            counter = 4000 Or
            counter = 5000 Then
            Block1.Width *= 1.25
            Block1.Height *= 1.25

            Block3.Width *= 1.25
            Block3.Height *= 1.25

            Block2dx *= 2
            Block2dy *= 2

            Block4dx *= 2
            Block4dy *= 2
        End If

        counter += 1
        Me.Text = "Seconds: " & Math.Floor(counter / 100).ToString
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        BlockPlayer.Location = e.Location
    End Sub

    Private Sub BlockPlayer_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BlockPlayer.MouseMove
        BlockPlayer.Left += e.X - (BlockPlayer.Width / 2)
        BlockPlayer.Top += e.Y - (BlockPlayer.Height / 2)
        CheckCollision()
    End Sub

    Private Sub CheckCollision()
        If BlockPlayer.Bounds.IntersectsWith(Block1.Bounds) Or
            BlockPlayer.Bounds.IntersectsWith(Block2.Bounds) Or
            BlockPlayer.Bounds.IntersectsWith(Block3.Bounds) Or
            BlockPlayer.Bounds.IntersectsWith(Block4.Bounds) Then
            Me.Text = "Gamer Over"
            TimerMovement.Stop()

            GameOverMessage.Show()
            GameOverMessage.Text = "You have lost. Click to try again!"

            ButtonGamePlay.Show()
            ButtonGamePlay.Text = "Try Again!"

            ButtonQuit.Show()
        End If
    End Sub

    Private Sub EnemySize_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimerMovement.Stop()
        GameOverMessage.Text = "Click to play!"
    End Sub

    Private Sub ButtonGamePlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGamePlay.Click
        TimerMovement.Start()
        counter = 0

        Block1.Top = 19
        Block1.Left = 458
        Block1.Width = 60
        Block1.Height = 60

        Block2.Left = 16
        Block2.Top = 19
        Block2dx = 1
        Block2dy = 1

        Block3.Left = 16
        Block3.Top = 338
        Block3.Width = 60
        Block3.Height = 60

        Block4.Left = 458
        Block4.Top = 338
        Block4dx = 1
        Block4dy = 1

    End Sub

    Private Sub ButtonQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuit.Click
        Me.Close()
    End Sub
End Class
