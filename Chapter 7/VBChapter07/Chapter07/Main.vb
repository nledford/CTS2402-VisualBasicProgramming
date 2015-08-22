Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button6_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonExit.Click
        ' Exit the program
        Me.Close()
    End Sub

    Private Sub buttonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAdd.Click
        ' Add a new bagel type to the list
        With comboBoxBagels
            If .Text <> "" Then
                ' Make sure item is not already on the list
                Dim ItemFound_boolean As Boolean
                Dim ItemIndex_integer As Integer
                Do Until ItemFound_boolean Or ItemIndex_integer = .Items.Count
                    If .Text.ToUpper = .Items(ItemIndex_integer).ToString.ToUpper Then
                        ItemFound_boolean = True
                        Exit Do
                    Else
                        ItemIndex_integer += 1
                    End If
                Loop
                If ItemFound_boolean Then
                    MessageBox.Show("Duplicate item.", "Add Failed", _
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    ' If it's not in the list, add it.
                    .Items.Add(.Text)
                    .Text = ""
                End If
            Else
                MessageBox.Show("Enter a bagel type to add", _
                    "Missing Data", MessageBoxButtons.OK, _
                    MessageBoxIcon.Exclamation)
            End If
            .Focus()
        End With
    End Sub

    Private Sub buttonRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonRemove.Click
        ' Remove the selected bagel type fron the list
        With comboBoxBagels
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("First select the bagel type to remove", _
                    "No selection made", MessageBoxButtons.OK, _
                    MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub buttonClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonClearList.Click
        ' Clear the bagel type list
        Dim ResponseDialogResult As DialogResult
        ResponseDialogResult = MessageBox.Show("Clear the bagel type list", _
            "Clear bagle type list", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ResponseDialogResult = DialogResult.Yes Then
            comboBoxBagels.Items.Clear()
        End If
    End Sub

    Private Sub buttonDisplayCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonDisplayCount.Click
        If comboBoxBagels.Items.Count > 0 Then
            MessageBox.Show("There are " & comboBoxBagels.Items.Count & " bagel types listed", _
                "Item List Count", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("There are no items in the list", _
                "Item List Count", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub buttonPrintList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonPrintList.Click
        ' Begin the print process to print all items
        PrintPreviewDialog1.Document = PrintAllPrintDocument
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintAllPrintDocument_PrintPage(ByVal sender As Object, _
        ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
        Handles PrintAllPrintDocument.PrintPage
        ' Handle printing and print previews when printing all
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeight_single As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocation_single As Single = e.MarginBounds.Left
        Dim VerticalPrintLocation_single As Single = e.MarginBounds.Top
        Dim PrintLing_string As String

        ' Print the heading
        Using HeadingFont As New Font("Arial", 14, FontStyle.Bold)
            e.Graphics.DrawString("Bagel Types", HeadingFont, _
                Brushes.Black, HorizontalPrintLocation_single, _
                VerticalPrintLocation_single)
        End Using

        ' Loop through the entire list
        For ListIndex_integer As Integer = 0 To comboBoxBagels.Items.Count - 1
            ' Increment the Y position for the next line
            VerticalPrintLocation_single += LineHeight_single

            ' Set up a line.
            PrintLing_string = comboBoxBagels.Items(ListIndex_integer).ToString
            ' Send the line to the graphics page object.
            e.Graphics.DrawString(PrintLing_string, PrintFont, _
                Brushes.Black, HorizontalPrintLocation_single, VerticalPrintLocation_single)

        Next ListIndex_integer
    End Sub

End Class
