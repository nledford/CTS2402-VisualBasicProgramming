<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContactInfo))
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContactName = New System.Windows.Forms.Button()
        Me.ContactDepartment = New System.Windows.Forms.Button()
        Me.ContactPhone = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.DepartmentLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(12, 177)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 0
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(93, 177)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(266, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nate Ledford"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContactName
        '
        Me.ContactName.Location = New System.Drawing.Point(13, 49)
        Me.ContactName.Name = "ContactName"
        Me.ContactName.Size = New System.Drawing.Size(75, 23)
        Me.ContactName.TabIndex = 3
        Me.ContactName.Text = "Name"
        Me.ContactName.UseVisualStyleBackColor = True
        '
        'ContactDepartment
        '
        Me.ContactDepartment.Location = New System.Drawing.Point(13, 78)
        Me.ContactDepartment.Name = "ContactDepartment"
        Me.ContactDepartment.Size = New System.Drawing.Size(75, 23)
        Me.ContactDepartment.TabIndex = 4
        Me.ContactDepartment.Text = "Department"
        Me.ContactDepartment.UseVisualStyleBackColor = True
        '
        'ContactPhone
        '
        Me.ContactPhone.Location = New System.Drawing.Point(13, 107)
        Me.ContactPhone.Name = "ContactPhone"
        Me.ContactPhone.Size = New System.Drawing.Size(75, 23)
        Me.ContactPhone.TabIndex = 5
        Me.ContactPhone.Text = "Phone"
        Me.ContactPhone.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameLabel.Location = New System.Drawing.Point(94, 49)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(234, 23)
        Me.NameLabel.TabIndex = 6
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DepartmentLabel
        '
        Me.DepartmentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DepartmentLabel.Location = New System.Drawing.Point(94, 78)
        Me.DepartmentLabel.Name = "DepartmentLabel"
        Me.DepartmentLabel.Size = New System.Drawing.Size(234, 23)
        Me.DepartmentLabel.TabIndex = 7
        Me.DepartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PhoneLabel
        '
        Me.PhoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PhoneLabel.Location = New System.Drawing.Point(94, 107)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(234, 23)
        Me.PhoneLabel.TabIndex = 8
        Me.PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContactInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 209)
        Me.Controls.Add(Me.PhoneLabel)
        Me.Controls.Add(Me.DepartmentLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.ContactPhone)
        Me.Controls.Add(Me.ContactDepartment)
        Me.Controls.Add(Me.ContactName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Name = "ContactInfo"
        Me.Text = "Company Contact Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContactPhone As System.Windows.Forms.Button
    Friend WithEvents ContactDepartment As System.Windows.Forms.Button
    Friend WithEvents ContactName As System.Windows.Forms.Button
    Friend WithEvents PhoneLabel As System.Windows.Forms.Label
    Friend WithEvents DepartmentLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label

End Class
