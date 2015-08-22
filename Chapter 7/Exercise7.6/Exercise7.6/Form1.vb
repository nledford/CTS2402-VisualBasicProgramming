Public Class Form1

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub BagelListCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BagelListCombo.SelectedIndexChanged

    End Sub

    Private Sub ClearBagelList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearBagelList.Click
        Dim ClearConfirm As DialogResult
        ClearConfirm = MessageBox.Show("Are you sure you want to clear the list?", _
                                       "Clear bagel types list", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ClearConfirm = DialogResult.Yes Then
            BagelListCombo.Items.Clear()
        End If
    End Sub

    Private Sub DisplayTypeCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayTypeCount.Click
        If (BagelListCombo.Items.Count > 0) Then
            MessageBox.Show("There are currently " & BagelListCombo.Items.Count & " bagel types listed", "Bagel Types Count", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("You have not entered any items into the list", "Bagel Types Count", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RemoveBagelType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveBagelType.Click
        With BagelListCombo
            If (.SelectedIndex <> -1) Then
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("You must first select a bagel type to remove", "No Bagel Selected", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With
    End Sub

    Private Sub AddBagelType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBagelType.Click
        With BagelListCombo
            If (.Text <> "") Then 'First tests for blank input
                Dim BagelBoolean As Boolean 'Set up variable for boolean test
                Dim BagelIndex As Integer ' Set up counter for loop
                Do Until BagelBoolean Or BagelIndex = .Items.Count
                    If (.Text = .Items(BagelIndex).ToString) Then
                        BagelBoolean = True
                        Exit Do
                    Else
                        BagelIndex += 1
                    End If
                Loop
                If BagelBoolean Then
                    MessageBox.Show("Duplicate Item Detected", "Add Failed", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    'If item is not on the list, it will be added
                    .Items.Add(.Text)
                    .Text = ""
                End If
            Else
                MessageBox.Show("Please enter a bagel type", "Missing Data", _
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            .Focus()
        End With
    End Sub

    Private Sub PrintBagelList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBagelList.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim PrintFont As New Font("Arial", 12, FontStyle.Italic)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String

        Using HeadingFont As New Font("Arial", 13, FontStyle.Bold)
            e.Graphics.DrawString("Bagel Types", HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        End Using

        For ListIndexInteger As Integer = 0 To BagelListCombo.Items.Count - 1
            VerticalPrintLocationSingle += LineHeightSingle
            PrintLineString = BagelListCombo.Items(ListIndexInteger).ToString()
            e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        Next ListIndexInteger
    End Sub
End Class