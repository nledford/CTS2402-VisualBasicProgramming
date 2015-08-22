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
        Me.GameMessage = New System.Windows.Forms.Label()
        Me.ButtonHint = New System.Windows.Forms.Button()
        Me.Remainder0 = New System.Windows.Forms.Label()
        Me.Remainder1 = New System.Windows.Forms.Label()
        Me.Remainder2 = New System.Windows.Forms.Label()
        Me.TextRandomNumber = New System.Windows.Forms.TextBox()
        Me.LabelDivision = New System.Windows.Forms.Label()
        Me.List0 = New System.Windows.Forms.ListBox()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.List2 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelCounter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GameMessage
        '
        Me.GameMessage.AutoSize = True
        Me.GameMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameMessage.Location = New System.Drawing.Point(14, 20)
        Me.GameMessage.Name = "GameMessage"
        Me.GameMessage.Size = New System.Drawing.Size(155, 25)
        Me.GameMessage.TabIndex = 0
        Me.GameMessage.Text = "Click To Start"
        Me.GameMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonHint
        '
        Me.ButtonHint.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHint.Location = New System.Drawing.Point(175, 14)
        Me.ButtonHint.Name = "ButtonHint"
        Me.ButtonHint.Size = New System.Drawing.Size(48, 36)
        Me.ButtonHint.TabIndex = 1
        Me.ButtonHint.Text = "?"
        Me.ButtonHint.UseVisualStyleBackColor = True
        '
        'Remainder0
        '
        Me.Remainder0.AutoSize = True
        Me.Remainder0.Location = New System.Drawing.Point(13, 148)
        Me.Remainder0.Name = "Remainder0"
        Me.Remainder0.Size = New System.Drawing.Size(67, 13)
        Me.Remainder0.TabIndex = 2
        Me.Remainder0.Text = "Remainder 0"
        '
        'Remainder1
        '
        Me.Remainder1.AutoSize = True
        Me.Remainder1.Location = New System.Drawing.Point(172, 148)
        Me.Remainder1.Name = "Remainder1"
        Me.Remainder1.Size = New System.Drawing.Size(67, 13)
        Me.Remainder1.TabIndex = 3
        Me.Remainder1.Text = "Remainder 1"
        '
        'Remainder2
        '
        Me.Remainder2.AutoSize = True
        Me.Remainder2.Location = New System.Drawing.Point(324, 148)
        Me.Remainder2.Name = "Remainder2"
        Me.Remainder2.Size = New System.Drawing.Size(67, 13)
        Me.Remainder2.TabIndex = 4
        Me.Remainder2.Text = "Remainder 2"
        '
        'TextRandomNumber
        '
        Me.TextRandomNumber.Location = New System.Drawing.Point(175, 78)
        Me.TextRandomNumber.Name = "TextRandomNumber"
        Me.TextRandomNumber.Size = New System.Drawing.Size(55, 20)
        Me.TextRandomNumber.TabIndex = 5
        '
        'LabelDivision
        '
        Me.LabelDivision.AutoSize = True
        Me.LabelDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDivision.Location = New System.Drawing.Point(236, 76)
        Me.LabelDivision.Name = "LabelDivision"
        Me.LabelDivision.Size = New System.Drawing.Size(30, 20)
        Me.LabelDivision.TabIndex = 6
        Me.LabelDivision.Text = " / 3"
        Me.LabelDivision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'List0
        '
        Me.List0.AllowDrop = True
        Me.List0.FormattingEnabled = True
        Me.List0.Location = New System.Drawing.Point(16, 165)
        Me.List0.Name = "List0"
        Me.List0.Size = New System.Drawing.Size(120, 95)
        Me.List0.TabIndex = 10
        '
        'List1
        '
        Me.List1.AllowDrop = True
        Me.List1.FormattingEnabled = True
        Me.List1.Location = New System.Drawing.Point(175, 165)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(120, 95)
        Me.List1.TabIndex = 11
        '
        'List2
        '
        Me.List2.AllowDrop = True
        Me.List2.FormattingEnabled = True
        Me.List2.Location = New System.Drawing.Point(327, 165)
        Me.List2.Name = "List2"
        Me.List2.Size = New System.Drawing.Size(120, 95)
        Me.List2.TabIndex = 12
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'LabelCounter
        '
        Me.LabelCounter.AutoSize = True
        Me.LabelCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCounter.Location = New System.Drawing.Point(239, 20)
        Me.LabelCounter.Name = "LabelCounter"
        Me.LabelCounter.Size = New System.Drawing.Size(0, 25)
        Me.LabelCounter.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 333)
        Me.Controls.Add(Me.LabelCounter)
        Me.Controls.Add(Me.List2)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.List0)
        Me.Controls.Add(Me.LabelDivision)
        Me.Controls.Add(Me.TextRandomNumber)
        Me.Controls.Add(Me.Remainder2)
        Me.Controls.Add(Me.Remainder1)
        Me.Controls.Add(Me.Remainder0)
        Me.Controls.Add(Me.ButtonHint)
        Me.Controls.Add(Me.GameMessage)
        Me.Name = "Form1"
        Me.Text = "Number Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GameMessage As System.Windows.Forms.Label
    Friend WithEvents ButtonHint As System.Windows.Forms.Button
    Friend WithEvents Remainder0 As System.Windows.Forms.Label
    Friend WithEvents Remainder1 As System.Windows.Forms.Label
    Friend WithEvents Remainder2 As System.Windows.Forms.Label
    Friend WithEvents TextRandomNumber As System.Windows.Forms.TextBox
    Friend WithEvents LabelDivision As System.Windows.Forms.Label
    Friend WithEvents List0 As System.Windows.Forms.ListBox
    Friend WithEvents List1 As System.Windows.Forms.ListBox
    Friend WithEvents List2 As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabelCounter As System.Windows.Forms.Label

End Class
