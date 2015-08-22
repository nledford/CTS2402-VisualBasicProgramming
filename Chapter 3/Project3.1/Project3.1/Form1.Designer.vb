<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FatLabel = New System.Windows.Forms.Label()
        Me.FatTextBox = New System.Windows.Forms.TextBox()
        Me.CarbohydrateLabel = New System.Windows.Forms.Label()
        Me.CarbohydrateTextBox = New System.Windows.Forms.TextBox()
        Me.ProteinLabel = New System.Windows.Forms.Label()
        Me.ProteinTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCalories = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.AccumulatedTotal = New System.Windows.Forms.Label()
        Me.AccumulatedTextBox = New System.Windows.Forms.TextBox()
        Me.ItemCount = New System.Windows.Forms.Label()
        Me.ItemTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(12, 12)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 0
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calculate the calories!")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(12, 41)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear the form and start over from scratch")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(12, 70)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 2
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Print the form")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(12, 99)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'FatLabel
        '
        Me.FatLabel.AutoSize = True
        Me.FatLabel.Location = New System.Drawing.Point(135, 12)
        Me.FatLabel.Name = "FatLabel"
        Me.FatLabel.Size = New System.Drawing.Size(111, 13)
        Me.FatLabel.TabIndex = 4
        Me.FatLabel.Text = "Enter the grams of fat:"
        '
        'FatTextBox
        '
        Me.FatTextBox.Location = New System.Drawing.Point(138, 29)
        Me.FatTextBox.Name = "FatTextBox"
        Me.FatTextBox.Size = New System.Drawing.Size(132, 20)
        Me.FatTextBox.TabIndex = 5
        '
        'CarbohydrateLabel
        '
        Me.CarbohydrateLabel.AutoSize = True
        Me.CarbohydrateLabel.Location = New System.Drawing.Point(135, 52)
        Me.CarbohydrateLabel.Name = "CarbohydrateLabel"
        Me.CarbohydrateLabel.Size = New System.Drawing.Size(166, 13)
        Me.CarbohydrateLabel.TabIndex = 6
        Me.CarbohydrateLabel.Text = "Enter the grams of carbohydrates:"
        '
        'CarbohydrateTextBox
        '
        Me.CarbohydrateTextBox.Location = New System.Drawing.Point(138, 68)
        Me.CarbohydrateTextBox.Name = "CarbohydrateTextBox"
        Me.CarbohydrateTextBox.Size = New System.Drawing.Size(132, 20)
        Me.CarbohydrateTextBox.TabIndex = 7
        '
        'ProteinLabel
        '
        Me.ProteinLabel.AutoSize = True
        Me.ProteinLabel.Location = New System.Drawing.Point(135, 91)
        Me.ProteinLabel.Name = "ProteinLabel"
        Me.ProteinLabel.Size = New System.Drawing.Size(131, 13)
        Me.ProteinLabel.TabIndex = 8
        Me.ProteinLabel.Text = "Enter the grams of protein:"
        '
        'ProteinTextBox
        '
        Me.ProteinTextBox.Location = New System.Drawing.Point(138, 107)
        Me.ProteinTextBox.Name = "ProteinTextBox"
        Me.ProteinTextBox.Size = New System.Drawing.Size(132, 20)
        Me.ProteinTextBox.TabIndex = 9
        '
        'TotalCalories
        '
        Me.TotalCalories.AutoSize = True
        Me.TotalCalories.Location = New System.Drawing.Point(348, 12)
        Me.TotalCalories.Name = "TotalCalories"
        Me.TotalCalories.Size = New System.Drawing.Size(74, 13)
        Me.TotalCalories.TabIndex = 10
        Me.TotalCalories.Text = "Total Calories:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(351, 28)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 11
        '
        'AccumulatedTotal
        '
        Me.AccumulatedTotal.AutoSize = True
        Me.AccumulatedTotal.Location = New System.Drawing.Point(351, 51)
        Me.AccumulatedTotal.Name = "AccumulatedTotal"
        Me.AccumulatedTotal.Size = New System.Drawing.Size(99, 13)
        Me.AccumulatedTotal.TabIndex = 12
        Me.AccumulatedTotal.Text = "Accumulated Total:"
        '
        'AccumulatedTextBox
        '
        Me.AccumulatedTextBox.Location = New System.Drawing.Point(351, 68)
        Me.AccumulatedTextBox.Name = "AccumulatedTextBox"
        Me.AccumulatedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AccumulatedTextBox.TabIndex = 13
        '
        'ItemCount
        '
        Me.ItemCount.AutoSize = True
        Me.ItemCount.Location = New System.Drawing.Point(351, 91)
        Me.ItemCount.Name = "ItemCount"
        Me.ItemCount.Size = New System.Drawing.Size(125, 13)
        Me.ItemCount.TabIndex = 14
        Me.ItemCount.Text = "Number of items entered:"
        '
        'ItemTextBox
        '
        Me.ItemTextBox.Location = New System.Drawing.Point(351, 108)
        Me.ItemTextBox.Name = "ItemTextBox"
        Me.ItemTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ItemTextBox.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 148)
        Me.Controls.Add(Me.ItemTextBox)
        Me.Controls.Add(Me.ItemCount)
        Me.Controls.Add(Me.AccumulatedTextBox)
        Me.Controls.Add(Me.AccumulatedTotal)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.TotalCalories)
        Me.Controls.Add(Me.ProteinTextBox)
        Me.Controls.Add(Me.ProteinLabel)
        Me.Controls.Add(Me.CarbohydrateTextBox)
        Me.Controls.Add(Me.CarbohydrateLabel)
        Me.Controls.Add(Me.FatTextBox)
        Me.Controls.Add(Me.FatLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Name = "Form1"
        Me.Text = "Calorie Counter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FatLabel As System.Windows.Forms.Label
    Friend WithEvents FatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CarbohydrateLabel As System.Windows.Forms.Label
    Friend WithEvents ProteinLabel As System.Windows.Forms.Label
    Friend WithEvents CarbohydrateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProteinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCalories As System.Windows.Forms.Label
    Friend WithEvents AccumulatedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccumulatedTotal As System.Windows.Forms.Label
    Friend WithEvents ItemCount As System.Windows.Forms.Label
    Friend WithEvents ItemTextBox As System.Windows.Forms.TextBox

End Class
