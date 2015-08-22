<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeatherReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WeatherReport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WeatherSelection = New System.Windows.Forms.GroupBox()
        Me.RadioSunny = New System.Windows.Forms.RadioButton()
        Me.RadioSnowy = New System.Windows.Forms.RadioButton()
        Me.RadioRainy = New System.Windows.Forms.RadioButton()
        Me.RadioCloudy = New System.Windows.Forms.RadioButton()
        Me.ImageRainy = New System.Windows.Forms.PictureBox()
        Me.ImageSnowy = New System.Windows.Forms.PictureBox()
        Me.ImageCloudy = New System.Windows.Forms.PictureBox()
        Me.ImageSunny = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintWeather = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.WeatherSelection.SuspendLayout()
        CType(Me.ImageRainy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageSnowy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCloudy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageSunny, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Enter your name here:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(316, 203)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(316, 174)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 2
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Print the Weather Report")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Programmed by: Nathaniel Ledford"
        '
        'WeatherSelection
        '
        Me.WeatherSelection.Controls.Add(Me.RadioCloudy)
        Me.WeatherSelection.Controls.Add(Me.RadioRainy)
        Me.WeatherSelection.Controls.Add(Me.RadioSnowy)
        Me.WeatherSelection.Controls.Add(Me.RadioSunny)
        Me.WeatherSelection.Location = New System.Drawing.Point(16, 39)
        Me.WeatherSelection.Name = "WeatherSelection"
        Me.WeatherSelection.Size = New System.Drawing.Size(108, 129)
        Me.WeatherSelection.TabIndex = 5
        Me.WeatherSelection.TabStop = False
        Me.WeatherSelection.Text = "Choose"
        '
        'RadioSunny
        '
        Me.RadioSunny.AutoSize = True
        Me.RadioSunny.Location = New System.Drawing.Point(7, 20)
        Me.RadioSunny.Name = "RadioSunny"
        Me.RadioSunny.Size = New System.Drawing.Size(55, 17)
        Me.RadioSunny.TabIndex = 0
        Me.RadioSunny.TabStop = True
        Me.RadioSunny.Text = "&Sunny"
        Me.ToolTip1.SetToolTip(Me.RadioSunny, "Select if the weather is sunny")
        Me.RadioSunny.UseVisualStyleBackColor = True
        '
        'RadioSnowy
        '
        Me.RadioSnowy.AutoSize = True
        Me.RadioSnowy.Location = New System.Drawing.Point(7, 44)
        Me.RadioSnowy.Name = "RadioSnowy"
        Me.RadioSnowy.Size = New System.Drawing.Size(57, 17)
        Me.RadioSnowy.TabIndex = 1
        Me.RadioSnowy.TabStop = True
        Me.RadioSnowy.Text = "S&nowy"
        Me.ToolTip1.SetToolTip(Me.RadioSnowy, "Select if the weather is snowy")
        Me.RadioSnowy.UseVisualStyleBackColor = True
        '
        'RadioRainy
        '
        Me.RadioRainy.AutoSize = True
        Me.RadioRainy.Location = New System.Drawing.Point(7, 68)
        Me.RadioRainy.Name = "RadioRainy"
        Me.RadioRainy.Size = New System.Drawing.Size(52, 17)
        Me.RadioRainy.TabIndex = 2
        Me.RadioRainy.TabStop = True
        Me.RadioRainy.Text = "&Rainy"
        Me.ToolTip1.SetToolTip(Me.RadioRainy, "Select if the weather is rainy")
        Me.RadioRainy.UseVisualStyleBackColor = True
        '
        'RadioCloudy
        '
        Me.RadioCloudy.AutoSize = True
        Me.RadioCloudy.Location = New System.Drawing.Point(7, 91)
        Me.RadioCloudy.Name = "RadioCloudy"
        Me.RadioCloudy.Size = New System.Drawing.Size(57, 17)
        Me.RadioCloudy.TabIndex = 3
        Me.RadioCloudy.TabStop = True
        Me.RadioCloudy.Text = "&Cloudy"
        Me.ToolTip1.SetToolTip(Me.RadioCloudy, "Select if the weather is cloudy")
        Me.RadioCloudy.UseVisualStyleBackColor = True
        '
        'ImageRainy
        '
        Me.ImageRainy.Image = Global.Excercise2._3.My.Resources.Resources.Rain
        Me.ImageRainy.Location = New System.Drawing.Point(159, 106)
        Me.ImageRainy.Name = "ImageRainy"
        Me.ImageRainy.Size = New System.Drawing.Size(79, 62)
        Me.ImageRainy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageRainy.TabIndex = 9
        Me.ImageRainy.TabStop = False
        Me.ImageRainy.Visible = False
        '
        'ImageSnowy
        '
        Me.ImageSnowy.Image = Global.Excercise2._3.My.Resources.Resources.Snow
        Me.ImageSnowy.Location = New System.Drawing.Point(244, 39)
        Me.ImageSnowy.Name = "ImageSnowy"
        Me.ImageSnowy.Size = New System.Drawing.Size(79, 61)
        Me.ImageSnowy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageSnowy.TabIndex = 8
        Me.ImageSnowy.TabStop = False
        Me.ImageSnowy.Visible = False
        '
        'ImageCloudy
        '
        Me.ImageCloudy.Image = Global.Excercise2._3.My.Resources.Resources.Cloud
        Me.ImageCloudy.Location = New System.Drawing.Point(244, 107)
        Me.ImageCloudy.Name = "ImageCloudy"
        Me.ImageCloudy.Size = New System.Drawing.Size(79, 61)
        Me.ImageCloudy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageCloudy.TabIndex = 7
        Me.ImageCloudy.TabStop = False
        Me.ImageCloudy.Visible = False
        '
        'ImageSunny
        '
        Me.ImageSunny.Image = Global.Excercise2._3.My.Resources.Resources.Sun
        Me.ImageSunny.Location = New System.Drawing.Point(159, 39)
        Me.ImageSunny.Name = "ImageSunny"
        Me.ImageSunny.Size = New System.Drawing.Size(79, 61)
        Me.ImageSunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageSunny.TabIndex = 6
        Me.ImageSunny.TabStop = False
        Me.ImageSunny.Visible = False
        '
        'PrintWeather
        '
        Me.PrintWeather.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrintWeather.Location = New System.Drawing.Point(12, 191)
        Me.PrintWeather.Name = "PrintWeather"
        Me.PrintWeather.Size = New System.Drawing.Size(294, 23)
        Me.PrintWeather.TabIndex = 10
        Me.PrintWeather.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(131, 13)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(259, 20)
        Me.NameTextBox.TabIndex = 11
        '
        'WeatherReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(402, 273)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.PrintWeather)
        Me.Controls.Add(Me.ImageRainy)
        Me.Controls.Add(Me.ImageSnowy)
        Me.Controls.Add(Me.ImageCloudy)
        Me.Controls.Add(Me.ImageSunny)
        Me.Controls.Add(Me.WeatherSelection)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WeatherReport"
        Me.Text = "Weather Report"
        Me.WeatherSelection.ResumeLayout(False)
        Me.WeatherSelection.PerformLayout()
        CType(Me.ImageRainy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageSnowy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCloudy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageSunny, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WeatherSelection As System.Windows.Forms.GroupBox
    Friend WithEvents RadioCloudy As System.Windows.Forms.RadioButton
    Friend WithEvents RadioRainy As System.Windows.Forms.RadioButton
    Friend WithEvents RadioSnowy As System.Windows.Forms.RadioButton
    Friend WithEvents RadioSunny As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSunny As System.Windows.Forms.PictureBox
    Friend WithEvents ImageCloudy As System.Windows.Forms.PictureBox
    Friend WithEvents ImageSnowy As System.Windows.Forms.PictureBox
    Friend WithEvents ImageRainy As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintWeather As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox

End Class
