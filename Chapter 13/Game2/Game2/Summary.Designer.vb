<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Summary
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
        Me.TotalGuesses = New System.Windows.Forms.Label()
        Me.CorrectGuesses = New System.Windows.Forms.Label()
        Me.IncorrectGuesses = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TotalGuesses
        '
        Me.TotalGuesses.AutoSize = True
        Me.TotalGuesses.Location = New System.Drawing.Point(13, 13)
        Me.TotalGuesses.Name = "TotalGuesses"
        Me.TotalGuesses.Size = New System.Drawing.Size(103, 13)
        Me.TotalGuesses.TabIndex = 0
        Me.TotalGuesses.Text = "Number of Guesses:"
        '
        'CorrectGuesses
        '
        Me.CorrectGuesses.AutoSize = True
        Me.CorrectGuesses.Location = New System.Drawing.Point(13, 41)
        Me.CorrectGuesses.Name = "CorrectGuesses"
        Me.CorrectGuesses.Size = New System.Drawing.Size(55, 13)
        Me.CorrectGuesses.TabIndex = 1
        Me.CorrectGuesses.Text = "% Correct:"
        '
        'IncorrectGuesses
        '
        Me.IncorrectGuesses.AutoSize = True
        Me.IncorrectGuesses.Location = New System.Drawing.Point(13, 71)
        Me.IncorrectGuesses.Name = "IncorrectGuesses"
        Me.IncorrectGuesses.Size = New System.Drawing.Size(63, 13)
        Me.IncorrectGuesses.TabIndex = 2
        Me.IncorrectGuesses.Text = "% Incorrect:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Click to close"
        '
        'Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 145)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IncorrectGuesses)
        Me.Controls.Add(Me.CorrectGuesses)
        Me.Controls.Add(Me.TotalGuesses)
        Me.Name = "Summary"
        Me.Text = "Game Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TotalGuesses As System.Windows.Forms.Label
    Friend WithEvents CorrectGuesses As System.Windows.Forms.Label
    Friend WithEvents IncorrectGuesses As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
