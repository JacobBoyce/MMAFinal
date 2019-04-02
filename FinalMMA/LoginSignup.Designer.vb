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
        Me.ErrorMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LoginB
        '
        Me.LoginB.Location = New System.Drawing.Point(269, 313)
        Me.LoginB.Name = "LoginB"
        Me.LoginB.Size = New System.Drawing.Size(75, 23)
        Me.LoginB.TabIndex = 0
        Me.LoginB.Text = "Login"
        Me.LoginB.UseVisualStyleBackColor = True
        '
        'SignupB
        '
        Me.SignupB.Location = New System.Drawing.Point(269, 354)
        Me.SignupB.Name = "SignupB"
        Me.SignupB.Size = New System.Drawing.Size(75, 23)
        Me.SignupB.TabIndex = 1
        Me.SignupB.Text = "Sign Up"
        Me.SignupB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Money Management App"
        '
        'LoginUsernameBox
        '
        Me.LoginUsernameBox.Location = New System.Drawing.Point(258, 221)
        Me.LoginUsernameBox.Name = "LoginUsernameBox"
        Me.LoginUsernameBox.Size = New System.Drawing.Size(100, 20)
        Me.LoginUsernameBox.TabIndex = 3
        '
        'LoginPasswordBox
        '
        Me.LoginPasswordBox.Location = New System.Drawing.Point(258, 276)
        Me.LoginPasswordBox.Name = "LoginPasswordBox"
        Me.LoginPasswordBox.Size = New System.Drawing.Size(100, 20)
        Me.LoginPasswordBox.TabIndex = 4
        '
        'UsernameL
        '
        Me.UsernameL.AutoSize = True
        Me.UsernameL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameL.Location = New System.Drawing.Point(165, 221)
        Me.UsernameL.Name = "UsernameL"
        Me.UsernameL.Size = New System.Drawing.Size(87, 20)
        Me.UsernameL.TabIndex = 5
        Me.UsernameL.Text = "Username:"
        '
        'PasswordL
        '
        Me.PasswordL.AutoSize = True
        Me.PasswordL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordL.Location = New System.Drawing.Point(165, 276)
        Me.PasswordL.Name = "PasswordL"
        Me.PasswordL.Size = New System.Drawing.Size(82, 20)
        Me.PasswordL.TabIndex = 6
        Me.PasswordL.Text = "Password:"
        '
        'LoginL
        '
        Me.LoginL.AutoSize = True
        Me.LoginL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginL.Location = New System.Drawing.Point(244, 146)
        Me.LoginL.Name = "LoginL"
        Me.LoginL.Size = New System.Drawing.Size(124, 20)
        Me.LoginL.TabIndex = 7
        Me.LoginL.Text = "Login or Sign up"
        '
        'ErrorMessage
        '
        Me.ErrorMessage.AutoSize = True
        Me.ErrorMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.ErrorMessage.Location = New System.Drawing.Point(255, 182)
        Me.ErrorMessage.Name = "ErrorMessage"
        Me.ErrorMessage.Size = New System.Drawing.Size(96, 16)
        Me.ErrorMessage.TabIndex = 10
        Me.ErrorMessage.Text = "error message"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(642, 445)
        Me.Controls.Add(Me.ErrorMessage)
        Me.Controls.Add(Me.LoginL)
        Me.Controls.Add(Me.PasswordL)
        Me.Controls.Add(Me.UsernameL)
        Me.Controls.Add(Me.LoginPasswordBox)
        Me.Controls.Add(Me.LoginUsernameBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SignupB)
        Me.Controls.Add(Me.LoginB)
        Me.MaximumSize = New System.Drawing.Size(658, 514)
        Me.MinimumSize = New System.Drawing.Size(658, 458)
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
    Friend WithEvents ErrorMessage As Label
End Class
