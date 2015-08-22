<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.comboBoxBagels = New System.Windows.Forms.ComboBox
        Me.buttonAdd = New System.Windows.Forms.Button
        Me.buttonRemove = New System.Windows.Forms.Button
        Me.buttonClearList = New System.Windows.Forms.Button
        Me.buttonPrintList = New System.Windows.Forms.Button
        Me.buttonDisplayCount = New System.Windows.Forms.Button
        Me.buttonExit = New System.Windows.Forms.Button
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintAllPrintDocument = New System.Drawing.Printing.PrintDocument
        Me.SuspendLayout()
        '
        'comboBoxBagels
        '
        Me.comboBoxBagels.AllowDrop = True
        Me.comboBoxBagels.AutoCompleteCustomSource.AddRange(New String() {"Plain", "Egg", "Rye", "Salt", "Poppy seed", "Sesame seed", "Banana nut", "Blueberry"})
        Me.comboBoxBagels.FormattingEnabled = True
        Me.comboBoxBagels.Items.AddRange(New Object() {"Banana nut", "Blueberry", "Egg", "Ex-wife arsnic", "Plain", "Poppy seed", "Rye", "Salt", "Sesame seed"})
        Me.comboBoxBagels.Location = New System.Drawing.Point(64, 30)
        Me.comboBoxBagels.Name = "comboBoxBagels"
        Me.comboBoxBagels.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxBagels.Sorted = True
        Me.comboBoxBagels.TabIndex = 0
        '
        'buttonAdd
        '
        Me.buttonAdd.Location = New System.Drawing.Point(275, 26)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(104, 23)
        Me.buttonAdd.TabIndex = 1
        Me.buttonAdd.Text = "&Add Types"
        Me.buttonAdd.UseVisualStyleBackColor = True
        '
        'buttonRemove
        '
        Me.buttonRemove.Location = New System.Drawing.Point(275, 70)
        Me.buttonRemove.Name = "buttonRemove"
        Me.buttonRemove.Size = New System.Drawing.Size(104, 23)
        Me.buttonRemove.TabIndex = 2
        Me.buttonRemove.Text = "&Remove Types"
        Me.buttonRemove.UseVisualStyleBackColor = True
        '
        'buttonClearList
        '
        Me.buttonClearList.Location = New System.Drawing.Point(275, 114)
        Me.buttonClearList.Name = "buttonClearList"
        Me.buttonClearList.Size = New System.Drawing.Size(104, 23)
        Me.buttonClearList.TabIndex = 3
        Me.buttonClearList.Text = "&Clear List"
        Me.buttonClearList.UseVisualStyleBackColor = True
        '
        'buttonPrintList
        '
        Me.buttonPrintList.Location = New System.Drawing.Point(275, 158)
        Me.buttonPrintList.Name = "buttonPrintList"
        Me.buttonPrintList.Size = New System.Drawing.Size(104, 23)
        Me.buttonPrintList.TabIndex = 4
        Me.buttonPrintList.Text = "&Print List"
        Me.buttonPrintList.UseVisualStyleBackColor = True
        '
        'buttonDisplayCount
        '
        Me.buttonDisplayCount.Location = New System.Drawing.Point(275, 202)
        Me.buttonDisplayCount.Name = "buttonDisplayCount"
        Me.buttonDisplayCount.Size = New System.Drawing.Size(104, 23)
        Me.buttonDisplayCount.TabIndex = 5
        Me.buttonDisplayCount.Text = "&Display Count"
        Me.buttonDisplayCount.UseVisualStyleBackColor = True
        '
        'buttonExit
        '
        Me.buttonExit.Location = New System.Drawing.Point(275, 246)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Size = New System.Drawing.Size(104, 23)
        Me.buttonExit.TabIndex = 6
        Me.buttonExit.Text = "E&xit"
        Me.buttonExit.UseVisualStyleBackColor = True
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
        'PrintAllPrintDocument
        '
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 295)
        Me.Controls.Add(Me.buttonExit)
        Me.Controls.Add(Me.buttonDisplayCount)
        Me.Controls.Add(Me.buttonPrintList)
        Me.Controls.Add(Me.buttonClearList)
        Me.Controls.Add(Me.buttonRemove)
        Me.Controls.Add(Me.buttonAdd)
        Me.Controls.Add(Me.comboBoxBagels)
        Me.Name = "Main"
        Me.Text = "Bradley's Bagels"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents comboBoxBagels As System.Windows.Forms.ComboBox
    Friend WithEvents buttonAdd As System.Windows.Forms.Button
    Friend WithEvents buttonRemove As System.Windows.Forms.Button
    Friend WithEvents buttonClearList As System.Windows.Forms.Button
    Friend WithEvents buttonPrintList As System.Windows.Forms.Button
    Friend WithEvents buttonDisplayCount As System.Windows.Forms.Button
    Friend WithEvents buttonExit As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintAllPrintDocument As System.Drawing.Printing.PrintDocument

End Class
