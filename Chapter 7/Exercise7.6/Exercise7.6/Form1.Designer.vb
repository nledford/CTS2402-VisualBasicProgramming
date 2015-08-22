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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BagelListCombo = New System.Windows.Forms.ComboBox()
        Me.AddBagelType = New System.Windows.Forms.Button()
        Me.RemoveBagelType = New System.Windows.Forms.Button()
        Me.ClearBagelList = New System.Windows.Forms.Button()
        Me.PrintBagelList = New System.Windows.Forms.Button()
        Me.DisplayTypeCount = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'BagelListCombo
        '
        Me.BagelListCombo.FormattingEnabled = True
        Me.BagelListCombo.Items.AddRange(New Object() {"Poppy Seed", "Sesame Seed", "Banana Nut", "Blueberry"})
        Me.BagelListCombo.Location = New System.Drawing.Point(13, 13)
        Me.BagelListCombo.Name = "BagelListCombo"
        Me.BagelListCombo.Size = New System.Drawing.Size(159, 21)
        Me.BagelListCombo.TabIndex = 0
        '
        'AddBagelType
        '
        Me.AddBagelType.Location = New System.Drawing.Point(178, 13)
        Me.AddBagelType.Name = "AddBagelType"
        Me.AddBagelType.Size = New System.Drawing.Size(114, 23)
        Me.AddBagelType.TabIndex = 1
        Me.AddBagelType.Text = "&Add Bagel Type"
        Me.AddBagelType.UseVisualStyleBackColor = True
        '
        'RemoveBagelType
        '
        Me.RemoveBagelType.Location = New System.Drawing.Point(178, 42)
        Me.RemoveBagelType.Name = "RemoveBagelType"
        Me.RemoveBagelType.Size = New System.Drawing.Size(114, 23)
        Me.RemoveBagelType.TabIndex = 2
        Me.RemoveBagelType.Text = "&Remove Bagel Type"
        Me.RemoveBagelType.UseVisualStyleBackColor = True
        '
        'ClearBagelList
        '
        Me.ClearBagelList.Location = New System.Drawing.Point(178, 71)
        Me.ClearBagelList.Name = "ClearBagelList"
        Me.ClearBagelList.Size = New System.Drawing.Size(114, 23)
        Me.ClearBagelList.TabIndex = 3
        Me.ClearBagelList.Text = "&Clear List"
        Me.ClearBagelList.UseVisualStyleBackColor = True
        '
        'PrintBagelList
        '
        Me.PrintBagelList.Location = New System.Drawing.Point(178, 100)
        Me.PrintBagelList.Name = "PrintBagelList"
        Me.PrintBagelList.Size = New System.Drawing.Size(114, 23)
        Me.PrintBagelList.TabIndex = 4
        Me.PrintBagelList.Text = "&Print List"
        Me.PrintBagelList.UseVisualStyleBackColor = True
        '
        'DisplayTypeCount
        '
        Me.DisplayTypeCount.Location = New System.Drawing.Point(178, 130)
        Me.DisplayTypeCount.Name = "DisplayTypeCount"
        Me.DisplayTypeCount.Size = New System.Drawing.Size(114, 23)
        Me.DisplayTypeCount.TabIndex = 5
        Me.DisplayTypeCount.Text = "&Display Type Count"
        Me.DisplayTypeCount.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(178, 159)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(113, 23)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 194)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DisplayTypeCount)
        Me.Controls.Add(Me.PrintBagelList)
        Me.Controls.Add(Me.ClearBagelList)
        Me.Controls.Add(Me.RemoveBagelType)
        Me.Controls.Add(Me.AddBagelType)
        Me.Controls.Add(Me.BagelListCombo)
        Me.Name = "Form1"
        Me.Text = "Bradley's Bagels"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BagelListCombo As System.Windows.Forms.ComboBox
    Friend WithEvents AddBagelType As System.Windows.Forms.Button
    Friend WithEvents RemoveBagelType As System.Windows.Forms.Button
    Friend WithEvents ClearBagelList As System.Windows.Forms.Button
    Friend WithEvents PrintBagelList As System.Windows.Forms.Button
    Friend WithEvents DisplayTypeCount As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog

End Class
