Public Class Form1
    ' Declare global variables or constants

    Const decTen As Decimal = 0.1
    Const decTwenty As Decimal = 0.2
    Const decMakeover As Decimal = 125D
    Const decHair As Decimal = 60D
    Const decManicure As Decimal = 35D
    Const decMakeup As Decimal = 200D
    Dim intCustomerCount As Integer
    Dim ServiceDecimal, TotalDecimal, TotalAmount As Decimal

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' Exit Program

        Me.Close()
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        ' Print Form

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ' Clears everything on form

        ServiceCost.Clear()
        TotalCost.Clear()
        TenPercentRadio.Checked = True
        RadioMakeover.Checked = True
        TotalDecimal = 0
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TenPercentRadio.Checked = True
        RadioMakeover.Checked = True
    End Sub

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        ' Calculate price for choice made
        If RadioMakeover.Checked Then
            ServiceDecimal = decMakeover
        ElseIf RadioHair.Checked Then
            ServiceDecimal = decHair
        ElseIf RadioManicure.Checked Then
            ServiceDecimal = decManicure
        ElseIf RadioMakeup.Checked Then
            ServiceDecimal = decMakeup
        End If

        ' Calculate price, total, and discounts

        If TenPercentRadio.Checked Then
            ServiceDecimal = ServiceDecimal * (1 - decTen)
        ElseIf TwentyPercentRadio.Checked Then
            ServiceDecimal = ServiceDecimal * (1 - decTwenty)
        End If

        TotalDecimal += ServiceDecimal
        TotalAmount += ServiceDecimal

        ServiceCost.Text = ServiceDecimal.ToString("C")
        TotalCost.Text = TotalDecimal.ToString("C")


    End Sub

    Private Sub RadioMakeover_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioMakeover.CheckedChanged
        If RadioMakeover.Checked Then
            ServiceCost.Text = FormatCurrency(decMakeover)
        End If
    End Sub

    Private Sub RadioHair_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioHair.CheckedChanged
        If RadioHair.Checked Then
            ServiceCost.Text = FormatCurrency(decHair)
        End If
    End Sub

    Private Sub RadioManicure_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioManicure.CheckedChanged
        If RadioManicure.Checked Then
            ServiceCost.Text = FormatCurrency(decManicure)
        End If
    End Sub

    Private Sub RadioMakeup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioMakeup.CheckedChanged
        If RadioMakeup.Checked Then
            ServiceCost.Text = FormatCurrency(decMakeup)
        End If
    End Sub

    Private Sub SummaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryButton.Click
        Dim decTotalAmount As Decimal

        intCustomerCount += 1
        decTotalAmount += TotalAmount

        MessageBox.Show("Number of Patrons: " & intCustomerCount & " Total Amount: " & decTotalAmount.ToString("C"), "Client Information", MessageBoxButtons.OK, MessageBoxIcon.Information
                        )
    End Sub

    Private Sub NextPatronButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextPatronButton.Click
        ' Variable to catch result of user input
        Dim WhichButtonDialogResult As DialogResult

        WhichButtonDialogResult = MessageBox.Show("Are you sure you want to clear the values for this customer?", "Confirm Action", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        If WhichButtonDialogResult = DialogResult.OK Then
            ServiceCost.Clear()
            TotalCost.Clear()
            RadioMakeover.Checked = True
            TenPercentRadio.Checked = True
            TotalDecimal = 0
        End If
    End Sub
End Class
