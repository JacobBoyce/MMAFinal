<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Income
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
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.IncomeLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.DueTextBox = New System.Windows.Forms.TextBox()
        Me.FrequencyListBox = New System.Windows.Forms.ListBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.DueLabel = New System.Windows.Forms.Label()
        Me.FrequencyButton = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MainMenuButton
        '
        Me.MainMenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuButton.Location = New System.Drawing.Point(4, 5)
        Me.MainMenuButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(117, 29)
        Me.MainMenuButton.TabIndex = 0
        Me.MainMenuButton.Text = "Main Menu"
        Me.MainMenuButton.UseVisualStyleBackColor = True
        '
        'IncomeLabel
        '
        Me.IncomeLabel.AutoSize = True
        Me.IncomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncomeLabel.Location = New System.Drawing.Point(242, 78)
        Me.IncomeLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.IncomeLabel.Name = "IncomeLabel"
        Me.IncomeLabel.Size = New System.Drawing.Size(103, 31)
        Me.IncomeLabel.TabIndex = 3
        Me.IncomeLabel.Text = "Income"
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(19, 151)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(156, 29)
        Me.NameTextBox.TabIndex = 10
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.Location = New System.Drawing.Point(174, 151)
        Me.AmountTextBox.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(152, 29)
        Me.AmountTextBox.TabIndex = 11
        '
        'DueTextBox
        '
        Me.DueTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DueTextBox.Location = New System.Drawing.Point(327, 151)
        Me.DueTextBox.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.DueTextBox.Name = "DueTextBox"
        Me.DueTextBox.Size = New System.Drawing.Size(153, 29)
        Me.DueTextBox.TabIndex = 12
        '
        'FrequencyListBox
        '
        Me.FrequencyListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrequencyListBox.FormattingEnabled = True
        Me.FrequencyListBox.ItemHeight = 24
        Me.FrequencyListBox.Items.AddRange(New Object() {"Weekly", "Bi-Weekly", "Semi-Monthly", "Monthly"})
        Me.FrequencyListBox.Location = New System.Drawing.Point(480, 152)
        Me.FrequencyListBox.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.FrequencyListBox.Name = "FrequencyListBox"
        Me.FrequencyListBox.Size = New System.Drawing.Size(154, 28)
        Me.FrequencyListBox.TabIndex = 13
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(15, 126)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(61, 24)
        Me.NameLabel.TabIndex = 14
        Me.NameLabel.Text = "Name"
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountLabel.Location = New System.Drawing.Point(171, 126)
        Me.AmountLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(76, 24)
        Me.AmountLabel.TabIndex = 15
        Me.AmountLabel.Text = "Amount"
        '
        'DueLabel
        '
        Me.DueLabel.AutoSize = True
        Me.DueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DueLabel.Location = New System.Drawing.Point(323, 126)
        Me.DueLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.DueLabel.Name = "DueLabel"
        Me.DueLabel.Size = New System.Drawing.Size(45, 24)
        Me.DueLabel.TabIndex = 16
        Me.DueLabel.Text = "Due"
        '
        'FrequencyButton
        '
        Me.FrequencyButton.AutoSize = True
        Me.FrequencyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrequencyButton.Location = New System.Drawing.Point(476, 127)
        Me.FrequencyButton.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.FrequencyButton.Name = "FrequencyButton"
        Me.FrequencyButton.Size = New System.Drawing.Size(102, 24)
        Me.FrequencyButton.TabIndex = 17
        Me.FrequencyButton.Text = "Frequency"
        '
        'Income
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(642, 445)
        Me.Controls.Add(Me.FrequencyButton)
        Me.Controls.Add(Me.DueLabel)
        Me.Controls.Add(Me.AmountLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.FrequencyListBox)
        Me.Controls.Add(Me.DueTextBox)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.IncomeLabel)
        Me.Controls.Add(Me.MainMenuButton)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.MaximumSize = New System.Drawing.Size(658, 514)
        Me.MinimumSize = New System.Drawing.Size(658, 458)
        Me.Name = "Income"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MMA - Income"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainMenuButton As Button
    Friend WithEvents IncomeLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents DueTextBox As TextBox
    Friend WithEvents FrequencyListBox As ListBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents AmountLabel As Label
    Friend WithEvents DueLabel As Label
    Friend WithEvents FrequencyButton As Label
End Class
