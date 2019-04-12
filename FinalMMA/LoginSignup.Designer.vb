<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginB
        '
        Me.LoginB.Location = New System.Drawing.Point(303, 320)
        Me.LoginB.Name = "LoginB"
        Me.LoginB.Size = New System.Drawing.Size(75, 36)
        Me.LoginB.TabIndex = 0
        Me.LoginB.Text = "Login"
        Me.LoginB.UseVisualStyleBackColor = True
        '
        'SignupB
        '
        Me.SignupB.Location = New System.Drawing.Point(292, 408)
        Me.SignupB.Name = "SignupB"
        Me.SignupB.Size = New System.Drawing.Size(100, 37)
        Me.SignupB.TabIndex = 1
        Me.SignupB.Text = "Sign Up"
        Me.SignupB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(176, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Money Management App"
        '
        'LoginUsernameBox
        '
        Me.LoginUsernameBox.Location = New System.Drawing.Point(294, 252)
        Me.LoginUsernameBox.Name = "LoginUsernameBox"
        Me.LoginUsernameBox.Size = New System.Drawing.Size(100, 20)
        Me.LoginUsernameBox.TabIndex = 3
        '
        'LoginPasswordBox
        '
        Me.LoginPasswordBox.Location = New System.Drawing.Point(294, 286)
        Me.LoginPasswordBox.Name = "LoginPasswordBox"
        Me.LoginPasswordBox.Size = New System.Drawing.Size(100, 20)
        Me.LoginPasswordBox.TabIndex = 4
        '
        'UsernameL
        '
        Me.UsernameL.AutoSize = True
        Me.UsernameL.BackColor = System.Drawing.Color.Black
        Me.UsernameL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameL.ForeColor = System.Drawing.Color.White
        Me.UsernameL.Location = New System.Drawing.Point(201, 252)
        Me.UsernameL.Name = "UsernameL"
        Me.UsernameL.Size = New System.Drawing.Size(87, 20)
        Me.UsernameL.TabIndex = 5
        Me.UsernameL.Text = "Username:"
        '
        'PasswordL
        '
        Me.PasswordL.AutoSize = True
        Me.PasswordL.BackColor = System.Drawing.Color.Black
        Me.PasswordL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordL.ForeColor = System.Drawing.Color.White
        Me.PasswordL.Location = New System.Drawing.Point(201, 286)
        Me.PasswordL.Name = "PasswordL"
        Me.PasswordL.Size = New System.Drawing.Size(82, 20)
        Me.PasswordL.TabIndex = 6
        Me.PasswordL.Text = "Password:"
        '
        'LoginL
        '
        Me.LoginL.AutoSize = True
        Me.LoginL.BackColor = System.Drawing.Color.Black
        Me.LoginL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginL.ForeColor = System.Drawing.Color.White
        Me.LoginL.Location = New System.Drawing.Point(318, 184)
        Me.LoginL.Name = "LoginL"
        Me.LoginL.Size = New System.Drawing.Size(48, 20)
        Me.LoginL.TabIndex = 7
        Me.LoginL.Text = "Login"
        '
        'ErrorMessage
        '
        Me.ErrorMessage.AutoSize = True
        Me.ErrorMessage.BackColor = System.Drawing.Color.Black
        Me.ErrorMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.ErrorMessage.Location = New System.Drawing.Point(296, 215)
        Me.ErrorMessage.Name = "ErrorMessage"
        Me.ErrorMessage.Size = New System.Drawing.Size(96, 16)
        Me.ErrorMessage.TabIndex = 10
        Me.ErrorMessage.Text = "error message"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(231, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Dont have account? Sign up!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.FinalMMA.My.Resources.Resources.glove2
        Me.PictureBox1.Location = New System.Drawing.Point(312, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(152, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 353)
        Me.Panel1.TabIndex = 13
        '
        'Login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.FinalMMA.My.Resources.Resources.glove3
        Me.ClientSize = New System.Drawing.Size(690, 472)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ErrorMessage)
        Me.Controls.Add(Me.LoginL)
        Me.Controls.Add(Me.PasswordL)
        Me.Controls.Add(Me.UsernameL)
        Me.Controls.Add(Me.LoginPasswordBox)
        Me.Controls.Add(Me.LoginUsernameBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SignupB)
        Me.Controls.Add(Me.LoginB)
        Me.Controls.Add(Me.Panel1)
        Me.Location = New System.Drawing.Point(-200, -200)
        Me.MaximumSize = New System.Drawing.Size(2000, 2000)
        Me.MinimumSize = New System.Drawing.Size(100, 100)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MMA - Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
