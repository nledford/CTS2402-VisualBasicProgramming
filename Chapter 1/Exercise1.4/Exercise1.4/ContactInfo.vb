' Project:      Exercise 1.4
' Programmer:   Nate Ledford
' Date:         9/1/2011
' Description: This project displays contact information for a company.
Public Class ContactInfo

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        ' Allows user to print form

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' Exit the program

        Me.Close()
    End Sub

    Private Sub ContactName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactName.Click
        ' Displays a name when button is clicked

        NameLabel.Text = "Bob Smith"
    End Sub

    Private Sub ContactDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactDepartment.Click
        ' Displays a department when button is clicked

        DepartmentLabel.Text = "Department of Redundancy Department"
    End Sub

    Private Sub ContactPhone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactPhone.Click
        ' Display a phone number when button is clicked

        PhoneLabel.Text = "(555) 555-2112"
    End Sub
End Class
