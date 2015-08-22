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
        Me.DiscountGroup = New System.Windows.Forms.GroupBox()
        Me.NoneRadio = New System.Windows.Forms.RadioButton()
        Me.TwentyPercentRadio = New System.Windows.Forms.RadioButton()
        Me.TenPercentRadio = New System.Windows.Forms.RadioButton()
        Me.ServiceGroup = New System.Windows.Forms.GroupBox()
        Me.RadioMakeup = New System.Windows.Forms.RadioButton()
        Me.RadioManicure = New System.Windows.Forms.RadioButton()
        Me.RadioHair = New System.Windows.Forms.RadioButton()
        Me.RadioMakeover = New System.Windows.Forms.RadioButton()
        Me.GroupCost = New System.Windows.Forms.GroupBox()
        Me.TotalCost = New System.Windows.Forms.TextBox()
        Me.ServiceCost = New System.Windows.Forms.TextBox()
        Me.TotalCostLabel = New System.Windows.Forms.Label()
        Me.ServiceCostLabel = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.NextPatronButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.DiscountGroup.SuspendLayout()
        Me.ServiceGroup.SuspendLayout()
        Me.GroupCost.SuspendLayout()
        Me.SuspendLayout()
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(13, 13)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 0
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(13, 42)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clea&r"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(12, 129)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 2
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(13, 158)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DiscountGroup
        '
        Me.DiscountGroup.Controls.Add(Me.NoneRadio)
        Me.DiscountGroup.Controls.Add(Me.TwentyPercentRadio)
        Me.DiscountGroup.Controls.Add(Me.TenPercentRadio)
        Me.DiscountGroup.Location = New System.Drawing.Point(105, 13)
        Me.DiscountGroup.Name = "DiscountGroup"
        Me.DiscountGroup.Size = New System.Drawing.Size(106, 110)
        Me.DiscountGroup.TabIndex = 4
        Me.DiscountGroup.TabStop = False
        Me.DiscountGroup.Text = "Select Discount"
        '
        'NoneRadio
        '
        Me.NoneRadio.AutoSize = True
        Me.NoneRadio.Location = New System.Drawing.Point(7, 66)
        Me.NoneRadio.Name = "NoneRadio"
        Me.NoneRadio.Size = New System.Drawing.Size(51, 17)
        Me.NoneRadio.TabIndex = 2
        Me.NoneRadio.TabStop = True
        Me.NoneRadio.Text = "None"
        Me.NoneRadio.UseVisualStyleBackColor = True
        '
        'TwentyPercentRadio
        '
        Me.TwentyPercentRadio.AutoSize = True
        Me.TwentyPercentRadio.Location = New System.Drawing.Point(7, 43)
        Me.TwentyPercentRadio.Name = "TwentyPercentRadio"
        Me.TwentyPercentRadio.Size = New System.Drawing.Size(45, 17)
        Me.TwentyPercentRadio.TabIndex = 1
        Me.TwentyPercentRadio.TabStop = True
        Me.TwentyPercentRadio.Text = "20%"
        Me.TwentyPercentRadio.UseVisualStyleBackColor = True
        '
        'TenPercentRadio
        '
        Me.TenPercentRadio.AutoSize = True
        Me.TenPercentRadio.Location = New System.Drawing.Point(7, 20)
        Me.TenPercentRadio.Name = "TenPercentRadio"
        Me.TenPercentRadio.Size = New System.Drawing.Size(45, 17)
        Me.TenPercentRadio.TabIndex = 0
        Me.TenPercentRadio.TabStop = True
        Me.TenPercentRadio.Text = "10%"
        Me.TenPercentRadio.UseVisualStyleBackColor = True
        '
        'ServiceGroup
        '
        Me.ServiceGroup.Controls.Add(Me.RadioMakeup)
        Me.ServiceGroup.Controls.Add(Me.RadioManicure)
        Me.ServiceGroup.Controls.Add(Me.RadioHair)
        Me.ServiceGroup.Controls.Add(Me.RadioMakeover)
        Me.ServiceGroup.Location = New System.Drawing.Point(217, 13)
        Me.ServiceGroup.Name = "ServiceGroup"
        Me.ServiceGroup.Size = New System.Drawing.Size(169, 110)
        Me.ServiceGroup.TabIndex = 5
        Me.ServiceGroup.TabStop = False
        Me.ServiceGroup.Text = "Select Service"
        '
        'RadioMakeup
        '
        Me.RadioMakeup.AutoSize = True
        Me.RadioMakeup.Location = New System.Drawing.Point(7, 87)
        Me.RadioMakeup.Name = "RadioMakeup"
        Me.RadioMakeup.Size = New System.Drawing.Size(118, 17)
        Me.RadioMakeup.TabIndex = 3
        Me.RadioMakeup.TabStop = True
        Me.RadioMakeup.Text = "Permanent Makeup"
        Me.RadioMakeup.UseVisualStyleBackColor = True
        '
        'RadioManicure
        '
        Me.RadioManicure.AutoSize = True
        Me.RadioManicure.Location = New System.Drawing.Point(7, 64)
        Me.RadioManicure.Name = "RadioManicure"
        Me.RadioManicure.Size = New System.Drawing.Size(69, 17)
        Me.RadioManicure.TabIndex = 2
        Me.RadioManicure.TabStop = True
        Me.RadioManicure.Text = "Manicure"
        Me.RadioManicure.UseVisualStyleBackColor = True
        '
        'RadioHair
        '
        Me.RadioHair.AutoSize = True
        Me.RadioHair.Location = New System.Drawing.Point(7, 43)
        Me.RadioHair.Name = "RadioHair"
        Me.RadioHair.Size = New System.Drawing.Size(78, 17)
        Me.RadioHair.TabIndex = 1
        Me.RadioHair.TabStop = True
        Me.RadioHair.Text = "Hair Styling"
        Me.RadioHair.UseVisualStyleBackColor = True
        '
        'RadioMakeover
        '
        Me.RadioMakeover.AutoSize = True
        Me.RadioMakeover.Location = New System.Drawing.Point(7, 20)
        Me.RadioMakeover.Name = "RadioMakeover"
        Me.RadioMakeover.Size = New System.Drawing.Size(67, 17)
        Me.RadioMakeover.TabIndex = 0
        Me.RadioMakeover.TabStop = True
        Me.RadioMakeover.Text = "Makover"
        Me.RadioMakeover.UseVisualStyleBackColor = True
        '
        'GroupCost
        '
        Me.GroupCost.Controls.Add(Me.TotalCost)
        Me.GroupCost.Controls.Add(Me.ServiceCost)
        Me.GroupCost.Controls.Add(Me.TotalCostLabel)
        Me.GroupCost.Controls.Add(Me.ServiceCostLabel)
        Me.GroupCost.Location = New System.Drawing.Point(105, 130)
        Me.GroupCost.Name = "GroupCost"
        Me.GroupCost.Size = New System.Drawing.Size(281, 101)
        Me.GroupCost.TabIndex = 6
        Me.GroupCost.TabStop = False
        '
        'TotalCost
        '
        Me.TotalCost.Location = New System.Drawing.Point(101, 58)
        Me.TotalCost.Name = "TotalCost"
        Me.TotalCost.Size = New System.Drawing.Size(100, 20)
        Me.TotalCost.TabIndex = 4
        '
        'ServiceCost
        '
        Me.ServiceCost.Location = New System.Drawing.Point(101, 26)
        Me.ServiceCost.Name = "ServiceCost"
        Me.ServiceCost.Size = New System.Drawing.Size(100, 20)
        Me.ServiceCost.TabIndex = 3
        '
        'TotalCostLabel
        '
        Me.TotalCostLabel.AutoSize = True
        Me.TotalCostLabel.Location = New System.Drawing.Point(6, 61)
        Me.TotalCostLabel.Name = "TotalCostLabel"
        Me.TotalCostLabel.Size = New System.Drawing.Size(34, 13)
        Me.TotalCostLabel.TabIndex = 2
        Me.TotalCostLabel.Text = "Total:"
        '
        'ServiceCostLabel
        '
        Me.ServiceCostLabel.AutoSize = True
        Me.ServiceCostLabel.Location = New System.Drawing.Point(6, 26)
        Me.ServiceCostLabel.Name = "ServiceCostLabel"
        Me.ServiceCostLabel.Size = New System.Drawing.Size(88, 13)
        Me.ServiceCostLabel.TabIndex = 0
        Me.ServiceCostLabel.Text = "Cost For Service:"
        Me.ServiceCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'NextPatronButton
        '
        Me.NextPatronButton.Location = New System.Drawing.Point(12, 71)
        Me.NextPatronButton.Name = "NextPatronButton"
        Me.NextPatronButton.Size = New System.Drawing.Size(75, 23)
        Me.NextPatronButton.TabIndex = 7
        Me.NextPatronButton.Text = "&Next Patron"
        Me.NextPatronButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(12, 100)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(75, 23)
        Me.SummaryButton.TabIndex = 8
        Me.SummaryButton.Text = "&Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 240)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.NextPatronButton)
        Me.Controls.Add(Me.GroupCost)
        Me.Controls.Add(Me.ServiceGroup)
        Me.Controls.Add(Me.DiscountGroup)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Name = "Form1"
        Me.Text = "Rifle Image Consulting"
        Me.DiscountGroup.ResumeLayout(False)
        Me.DiscountGroup.PerformLayout()
        Me.ServiceGroup.ResumeLayout(False)
        Me.ServiceGroup.PerformLayout()
        Me.GroupCost.ResumeLayout(False)
        Me.GroupCost.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents DiscountGroup As System.Windows.Forms.GroupBox
    Friend WithEvents NoneRadio As System.Windows.Forms.RadioButton
    Friend WithEvents TwentyPercentRadio As System.Windows.Forms.RadioButton
    Friend WithEvents TenPercentRadio As System.Windows.Forms.RadioButton
    Friend WithEvents ServiceGroup As System.Windows.Forms.GroupBox
    Friend WithEvents GroupCost As System.Windows.Forms.GroupBox
    Friend WithEvents ServiceCostLabel As System.Windows.Forms.Label
    Friend WithEvents TotalCostLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents TotalCost As System.Windows.Forms.TextBox
    Friend WithEvents ServiceCost As System.Windows.Forms.TextBox
    Friend WithEvents RadioMakeover As System.Windows.Forms.RadioButton
    Friend WithEvents RadioMakeup As System.Windows.Forms.RadioButton
    Friend WithEvents RadioManicure As System.Windows.Forms.RadioButton
    Friend WithEvents RadioHair As System.Windows.Forms.RadioButton
    Friend WithEvents SummaryButton As System.Windows.Forms.Button
    Friend WithEvents NextPatronButton As System.Windows.Forms.Button

End Class
