Public Class Form1
    ' Declare global variables
    Dim intPoints As Integer
    Dim intBooks As Integer
    Dim intReaders As Integer
    Dim intTotal As Integer

    Private Function calcPoints(ByVal br As Integer) As Integer
        'Calculates number of bonus points earned based on user input

        If br <= 3 Then
            calcPoints = 10 * br
        ElseIf br <= 6 Then
            calcPoints = (10 * 3) + 15 * (br - 3)
        Else
            calcPoints = (10 * 3) + (15 * 3) + 20 * (br - 6)
        End If
    End Function

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exit the program

        Me.Close()
    End Sub

    Private Sub PointsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PointsToolStripMenuItem.Click
        ' Adds number of books read, number of readers, and number of bonus points, and calculates the total number of readers
        intBooks += Val(Integer.Parse(BooksReadTextBox.Text))
        intReaders += 1
        intTotal = (intBooks / intReaders)
        intPoints = calcPoints(Val(Integer.Parse(BooksReadTextBox.Text)))
        BonusPointsTextBox.Text = intPoints.ToString("N")
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        ' Allows user to change color of BonusPointsTextBox

        ColorDialog1.Color = BonusPointsTextBox.ForeColor

        With ColorDialog1
            .ShowDialog()
            BonusPointsTextBox.ForeColor = .Color
        End With

    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clears user's Name, books read, bonus points, and resets focus

        With uNameTextBox
            .Clear()
            .Focus()
        End With
        BooksReadTextBox.Clear()
        BonusPointsTextBox.Clear()

    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        ' Allows user to change font attributes of BonusPointsTextBox

        FontDialog1.Font = BonusPointsTextBox.Font

        With FontDialog1
            .ShowDialog()
            BonusPointsTextBox.Font = .Font
        End With
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ' Displays message when user clicks "About" in Help menu

        MessageBox.Show("Programmer: Nathaniel Ledford", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Calculates average number of books read and displays number to user
        If intBooks = 0 Then
            MessageBox.Show("Number of books has not been entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Number of books read: " & intTotal & " per reader.", "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intReaders = 0
        intBooks = 0
    End Sub
End Class
