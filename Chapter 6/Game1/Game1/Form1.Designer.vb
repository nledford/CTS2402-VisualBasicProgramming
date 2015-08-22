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
        Me.Block3 = New System.Windows.Forms.Label()
        Me.BlockPlayer = New System.Windows.Forms.Label()
        Me.Block1 = New System.Windows.Forms.Label()
        Me.Block4 = New System.Windows.Forms.Label()
        Me.Block2 = New System.Windows.Forms.Label()
        Me.TimerMovement = New System.Windows.Forms.Timer(Me.components)
        Me.WallBottom = New System.Windows.Forms.Label()
        Me.WallTop = New System.Windows.Forms.Label()
        Me.WallLeft = New System.Windows.Forms.Label()
        Me.WallRight = New System.Windows.Forms.Label()
        Me.GameOverMessage = New System.Windows.Forms.Label()
        Me.ButtonGamePlay = New System.Windows.Forms.Button()
        Me.ButtonQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Block3
        '
        Me.Block3.BackColor = System.Drawing.Color.Red
        Me.Block3.Location = New System.Drawing.Point(16, 338)
        Me.Block3.Name = "Block3"
        Me.Block3.Size = New System.Drawing.Size(60, 60)
        Me.Block3.TabIndex = 0
        '
        'BlockPlayer
        '
        Me.BlockPlayer.BackColor = System.Drawing.Color.Navy
        Me.BlockPlayer.Location = New System.Drawing.Point(241, 177)
        Me.BlockPlayer.Name = "BlockPlayer"
        Me.BlockPlayer.Size = New System.Drawing.Size(60, 60)
        Me.BlockPlayer.TabIndex = 1
        '
        'Block1
        '
        Me.Block1.BackColor = System.Drawing.Color.Red
        Me.Block1.Location = New System.Drawing.Point(458, 19)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(60, 60)
        Me.Block1.TabIndex = 2
        '
        'Block4
        '
        Me.Block4.BackColor = System.Drawing.Color.Red
        Me.Block4.Location = New System.Drawing.Point(458, 338)
        Me.Block4.Name = "Block4"
        Me.Block4.Size = New System.Drawing.Size(60, 60)
        Me.Block4.TabIndex = 3
        '
        'Block2
        '
        Me.Block2.BackColor = System.Drawing.Color.Red
        Me.Block2.Location = New System.Drawing.Point(16, 19)
        Me.Block2.Name = "Block2"
        Me.Block2.Size = New System.Drawing.Size(60, 60)
        Me.Block2.TabIndex = 4
        '
        'TimerMovement
        '
        Me.TimerMovement.Enabled = True
        Me.TimerMovement.Interval = 10
        '
        'WallBottom
        '
        Me.WallBottom.BackColor = System.Drawing.Color.Black
        Me.WallBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WallBottom.Location = New System.Drawing.Point(0, 407)
        Me.WallBottom.Name = "WallBottom"
        Me.WallBottom.Size = New System.Drawing.Size(534, 10)
        Me.WallBottom.TabIndex = 5
        '
        'WallTop
        '
        Me.WallTop.BackColor = System.Drawing.Color.Black
        Me.WallTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.WallTop.Location = New System.Drawing.Point(0, 0)
        Me.WallTop.Name = "WallTop"
        Me.WallTop.Size = New System.Drawing.Size(534, 10)
        Me.WallTop.TabIndex = 6
        Me.WallTop.Text = "Label1"
        '
        'WallLeft
        '
        Me.WallLeft.BackColor = System.Drawing.Color.Black
        Me.WallLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.WallLeft.Location = New System.Drawing.Point(0, 10)
        Me.WallLeft.Name = "WallLeft"
        Me.WallLeft.Size = New System.Drawing.Size(10, 397)
        Me.WallLeft.TabIndex = 7
        Me.WallLeft.Text = "Label1"
        '
        'WallRight
        '
        Me.WallRight.BackColor = System.Drawing.Color.Black
        Me.WallRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.WallRight.Location = New System.Drawing.Point(524, 10)
        Me.WallRight.Name = "WallRight"
        Me.WallRight.Size = New System.Drawing.Size(10, 397)
        Me.WallRight.TabIndex = 8
        Me.WallRight.Text = "Label1"
        '
        'GameOverMessage
        '
        Me.GameOverMessage.BackColor = System.Drawing.Color.Transparent
        Me.GameOverMessage.Dock = System.Windows.Forms.DockStyle.Top
        Me.GameOverMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameOverMessage.Location = New System.Drawing.Point(10, 10)
        Me.GameOverMessage.Name = "GameOverMessage"
        Me.GameOverMessage.Size = New System.Drawing.Size(514, 22)
        Me.GameOverMessage.TabIndex = 9
        Me.GameOverMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonGamePlay
        '
        Me.ButtonGamePlay.Location = New System.Drawing.Point(187, 35)
        Me.ButtonGamePlay.Name = "ButtonGamePlay"
        Me.ButtonGamePlay.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGamePlay.TabIndex = 10
        Me.ButtonGamePlay.Text = "&Play"
        Me.ButtonGamePlay.UseVisualStyleBackColor = True
        '
        'ButtonQuit
        '
        Me.ButtonQuit.Location = New System.Drawing.Point(268, 35)
        Me.ButtonQuit.Name = "ButtonQuit"
        Me.ButtonQuit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuit.TabIndex = 11
        Me.ButtonQuit.Text = "E&xit"
        Me.ButtonQuit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 417)
        Me.Controls.Add(Me.ButtonQuit)
        Me.Controls.Add(Me.ButtonGamePlay)
        Me.Controls.Add(Me.GameOverMessage)
        Me.Controls.Add(Me.WallRight)
        Me.Controls.Add(Me.WallLeft)
        Me.Controls.Add(Me.WallTop)
        Me.Controls.Add(Me.WallBottom)
        Me.Controls.Add(Me.Block2)
        Me.Controls.Add(Me.Block4)
        Me.Controls.Add(Me.Block1)
        Me.Controls.Add(Me.BlockPlayer)
        Me.Controls.Add(Me.Block3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attack of the Killer Boxes!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Block3 As System.Windows.Forms.Label
    Friend WithEvents BlockPlayer As System.Windows.Forms.Label
    Friend WithEvents Block1 As System.Windows.Forms.Label
    Friend WithEvents Block4 As System.Windows.Forms.Label
    Friend WithEvents Block2 As System.Windows.Forms.Label
    Friend WithEvents TimerMovement As System.Windows.Forms.Timer
    Friend WithEvents WallBottom As System.Windows.Forms.Label
    Friend WithEvents WallTop As System.Windows.Forms.Label
    Friend WithEvents WallLeft As System.Windows.Forms.Label
    Friend WithEvents WallRight As System.Windows.Forms.Label
    Friend WithEvents GameOverMessage As System.Windows.Forms.Label
    Friend WithEvents ButtonGamePlay As System.Windows.Forms.Button
    Friend WithEvents ButtonQuit As System.Windows.Forms.Button

End Class
