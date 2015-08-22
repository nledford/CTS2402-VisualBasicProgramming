Public Class Form1

    Dim count As Integer = 0
    Dim houses() As Household
    Dim total As Integer = 0

    Structure Household
        Dim id As Integer
        Dim size As Integer
        Dim income As Integer
    End Structure


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemExit.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub AllDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllDataToolStripMenuItem.Click
        'Prints all data from information entered
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ExceedsAverageIncomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExceedsAverageIncomeToolStripMenuItem.Click
        'Prints households that exceed average income

    End Sub

    Private Sub BelowPovertyLevelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BelowPovertyLevelToolStripMenuItem.Click
        'Prints households that are below poverty level
    End Sub

    Private Sub menuItemEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemEnter.Click
        houses(count).id = CInt(txtID.Text)
        houses(count).size = CInt(txtFamilySize.Text)
        houses(count).income = CInt(txtIncome.Text)
        total += houses(count).income
        count += 1
        txtID.Text = ""
        txtFamilySize.Text = ""
        txtIncome.Text = ""
    End Sub
End Class
