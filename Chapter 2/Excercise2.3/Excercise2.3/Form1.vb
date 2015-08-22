Public Class WeatherReport

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' Exit the program.

        Me.Close()
    End Sub

    Private Sub RadioSunny_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioSunny.CheckedChanged
        ' Displays ImageSunny and a message if selected.

        PrintWeather.Text = "Looks like the weather will be sunny today, " & NameTextBox.Text
        ImageSunny.Visible = True

        ' Hides other images
        ImageSnowy.Visible = False
        ImageRainy.Visible = False
        ImageCloudy.Visible = False
    End Sub

    Private Sub RadioSnowy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioSnowy.CheckedChanged
        ' Displays ImageSnowy and a message if selected.

        PrintWeather.Text = "Looks like the weather will be snowy today, " & NameTextBox.Text
        ImageSnowy.Visible = True

        ' Hides other images
        ImageSunny.Visible = False
        ImageRainy.Visible = False
        ImageCloudy.Visible = False
    End Sub

    Private Sub RadioRainy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioRainy.CheckedChanged
        ' Displays ImageRainy and a message if selected.

        PrintWeather.Text = "Looks like the weather will be rainy today, " & NameTextBox.Text
        ImageRainy.Visible = True

        ' Hides other images
        ImageSunny.Visible = False
        ImageSnowy.Visible = False
        ImageCloudy.Visible = False
    End Sub

    Private Sub RadioCloudy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioCloudy.CheckedChanged
        ' Displays ImageCloudy and a message if selected.

        PrintWeather.Text = "Looks like the weather will be cloudy today, " & NameTextBox.Text
        ImageCloudy.Visible = True

        ' Hides other images
        ImageSunny.Visible = False
        ImageSnowy.Visible = False
        ImageRainy.Visible = False
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        ' Print the Weather Report

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
