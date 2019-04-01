<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.LoginB = New System.Windows.Forms.Button()
        Me.SignupB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoginUsernameBox = New System.Windows.Forms.TextBox()
        Me.LoginPasswordBox = New System.Windows.Forms.TextBox()
        Me.UsernameL = New System.Windows.Forms.Label()
        Me.PasswordL = New System.Windows.Forms.Label()
        Me.LoginL = New System.Windows.Forms.Label()
        Me.userPass = New System.Windows.Forms.Label()
        Me.input = New System.Windows.Forms.Label()
        Me.ErrorMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LoginB
        '
        Me.LoginB.Location = New System.Drawing.Point(717, 746)
        Me.LoginB.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.LoginB.Name = "LoginB"
        Me.LoginB.Size = New System.Drawing.Size(200, 55)
        Me.LoginB.TabIndex = 0
        Me.LoginB.Text = "Login"
        Me.LoginB.UseVisualStyleBackColor = True
        '
        'SignupB
        '
        Me.SignupB.Location = New System.Drawing.Point(717, 844)
        Me.SignupB.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.SignupB.Name = "SignupB"
        Me.SignupB.Size = New System.Drawing.Size(200, 55)
        Me.SignupB.TabIndex = 1
        Me.SignupB.Text = "Sign Up"
        Me.SignupB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 200)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(794, 78)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Money Management App"
        '
        'LoginUsernameBox
        '
        Me.LoginUsernameBox.Location = New System.Drawing.Point(688, 527)
        Me.LoginUsernameBox.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.LoginUsernameBox.Name = "LoginUsernameBox"
        Me.LoginUsernameBox.Size = New System.Drawing.Size(260, 38)
        Me.LoginUsernameBox.TabIndex = 3
        '
        'LoginPasswordBox
        '
        Me.LoginPasswordBox.Location = New System.Drawing.Point(688, 658)
        Me.LoginPasswordBox.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.LoginPasswordBox.Name = "LoginPasswordBox"
        Me.LoginPasswordBox.Size = New System.Drawing.Size(260, 38)
        Me.LoginPasswordBox.TabIndex = 4
        '
        'UsernameL
        '
        Me.UsernameL.AutoSize = True
        Me.UsernameL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameL.Location = New System.Drawing.Point(440, 527)
        Me.UsernameL.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.UsernameL.Name = "UsernameL"
        Me.UsernameL.Size = New System.Drawing.Size(214, 46)
        Me.UsernameL.TabIndex = 5
        Me.UsernameL.Text = "Username:"
        '
        'PasswordL
        '
        Me.PasswordL.AutoSize = True
        Me.PasswordL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordL.Location = New System.Drawing.Point(440, 658)
        Me.PasswordL.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.PasswordL.Name = "PasswordL"
        Me.PasswordL.Size = New System.Drawing.Size(207, 46)
        Me.PasswordL.TabIndex = 6
        Me.PasswordL.Text = "Password:"
        '
        'LoginL
        '
        Me.LoginL.AutoSize = True
        Me.LoginL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginL.Location = New System.Drawing.Point(651, 348)
        Me.LoginL.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.LoginL.Name = "LoginL"
        Me.LoginL.Size = New System.Drawing.Size(311, 46)
        Me.LoginL.TabIndex = 7
        Me.LoginL.Text = "Login or Sign up"
        '
        'userPass
        '
        Me.userPass.AutoSize = True
        Me.userPass.Location = New System.Drawing.Point(1443, 391)
        Me.userPass.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.userPass.Name = "userPass"
        Me.userPass.Size = New System.Drawing.Size(102, 32)
        Me.userPass.TabIndex = 8
        Me.userPass.Text = "Label2"
        '
        'input
        '
        Me.input.AutoSize = True
        Me.input.Location = New System.Drawing.Point(1451, 575)
        Me.input.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(102, 32)
        Me.input.TabIndex = 9
        Me.input.Text = "Label3"
        '
        'ErrorMessage
        '
        Me.ErrorMessage.AutoSize = True
        Me.ErrorMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.ErrorMessage.Location = New System.Drawing.Point(680, 434)
        Me.ErrorMessage.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.ErrorMessage.Name = "ErrorMessage"
        Me.ErrorMessage.Size = New System.Drawing.Size(228, 38)
        Me.ErrorMessage.TabIndex = 10
        Me.ErrorMessage.Text = "error message"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1696, 1083)
        Me.Controls.Add(Me.ErrorMessage)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.userPass)
        Me.Controls.Add(Me.LoginL)
        Me.Controls.Add(Me.PasswordL)
        Me.Controls.Add(Me.UsernameL)
        Me.Controls.Add(Me.LoginPasswordBox)
        Me.Controls.Add(Me.LoginUsernameBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SignupB)
        Me.Controls.Add(Me.LoginB)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MaximumSize = New System.Drawing.Size(1728, 1171)
        Me.MinimumSize = New System.Drawing.Size(1728, 1171)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MMA - Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginB As Button
    Friend WithEvents SignupB As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginUsernameBox As TextBox
    Friend WithEvents LoginPasswordBox As TextBox
    Friend WithEvents UsernameL As Label
    Friend WithEvents PasswordL As Label
    Friend WithEvents LoginL As Label
    Friend WithEvents userPass As Label
    Friend WithEvents input As Label
    Friend WithEvents ErrorMessage As Label
End Class
