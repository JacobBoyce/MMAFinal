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
        Me.IncomeDataGrid = New System.Windows.Forms.DataGridView()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Due = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Frequency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.DueTextBox = New System.Windows.Forms.TextBox()
        Me.FrequencyListBox = New System.Windows.Forms.ListBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.DueLabel = New System.Windows.Forms.Label()
        Me.FrequencyButton = New System.Windows.Forms.Label()
        CType(Me.IncomeDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenuButton
        '
        Me.MainMenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuButton.Location = New System.Drawing.Point(12, 12)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(313, 70)
        Me.MainMenuButton.TabIndex = 0
        Me.MainMenuButton.Text = "Main Menu"
        Me.MainMenuButton.UseVisualStyleBackColor = True
        '
        'IncomeLabel
        '
        Me.IncomeLabel.AutoSize = True
        Me.IncomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncomeLabel.Location = New System.Drawing.Point(646, 186)
        Me.IncomeLabel.Name = "IncomeLabel"
        Me.IncomeLabel.Size = New System.Drawing.Size(257, 78)
        Me.IncomeLabel.TabIndex = 3
        Me.IncomeLabel.Text = "Income"
        '
        'IncomeDataGrid
        '
        Me.IncomeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IncomeDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Name, Me.Amount, Me.Due, Me.Frequency})
        Me.IncomeDataGrid.Location = New System.Drawing.Point(12, 426)
        Me.IncomeDataGrid.Name = "IncomeDataGrid"
        Me.IncomeDataGrid.RowTemplate.Height = 40
        Me.IncomeDataGrid.Size = New System.Drawing.Size(1672, 645)
        Me.IncomeDataGrid.TabIndex = 8
        '
        'Name
        '
        Me.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Name.HeaderText = "Name"
        Me.Name.Name = "Name"
        '
        'Amount
        '
        Me.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'Due
        '
        Me.Due.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Due.HeaderText = "Due"
        Me.Due.Name = "Due"
        '
        'Frequency
        '
        Me.Frequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Frequency.HeaderText = "Frequency"
        Me.Frequency.Name = "Frequency"
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(51, 359)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(408, 61)
        Me.NameTextBox.TabIndex = 10
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.Location = New System.Drawing.Point(465, 359)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(400, 61)
        Me.AmountTextBox.TabIndex = 11
        '
        'DueTextBox
        '
        Me.DueTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DueTextBox.Location = New System.Drawing.Point(871, 359)
        Me.DueTextBox.Name = "DueTextBox"
        Me.DueTextBox.Size = New System.Drawing.Size(402, 61)
        Me.DueTextBox.TabIndex = 12
        '
        'FrequencyListBox
        '
        Me.FrequencyListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrequencyListBox.FormattingEnabled = True
        Me.FrequencyListBox.ItemHeight = 54
        Me.FrequencyListBox.Items.AddRange(New Object() {"Weekly", "Bi-Weekly", "Semi-Monthly", "Monthly"})
        Me.FrequencyListBox.Location = New System.Drawing.Point(1279, 362)
        Me.FrequencyListBox.Name = "FrequencyListBox"
        Me.FrequencyListBox.Size = New System.Drawing.Size(404, 58)
        Me.FrequencyListBox.TabIndex = 13
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(41, 301)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(153, 55)
        Me.NameLabel.TabIndex = 14
        Me.NameLabel.Text = "Name"
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountLabel.Location = New System.Drawing.Point(455, 301)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(190, 55)
        Me.AmountLabel.TabIndex = 15
        Me.AmountLabel.Text = "Amount"
        '
        'DueLabel
        '
        Me.DueLabel.AutoSize = True
        Me.DueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DueLabel.Location = New System.Drawing.Point(861, 301)
        Me.DueLabel.Name = "DueLabel"
        Me.DueLabel.Size = New System.Drawing.Size(113, 55)
        Me.DueLabel.TabIndex = 16
        Me.DueLabel.Text = "Due"
        '
        'FrequencyButton
        '
        Me.FrequencyButton.AutoSize = True
        Me.FrequencyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrequencyButton.Location = New System.Drawing.Point(1269, 304)
        Me.FrequencyButton.Name = "FrequencyButton"
        Me.FrequencyButton.Size = New System.Drawing.Size(252, 55)
        Me.FrequencyButton.TabIndex = 17
        Me.FrequencyButton.Text = "Frequency"
        '
        'Income
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1696, 1083)
        Me.Controls.Add(Me.FrequencyButton)
        Me.Controls.Add(Me.DueLabel)
        Me.Controls.Add(Me.AmountLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.FrequencyListBox)
        Me.Controls.Add(Me.DueTextBox)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.IncomeDataGrid)
        Me.Controls.Add(Me.IncomeLabel)
        Me.Controls.Add(Me.MainMenuButton)
        Me.MaximumSize = New System.Drawing.Size(1728, 1171)
        Me.MinimumSize = New System.Drawing.Size(1728, 1171)
        Me.Name = "Income"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MMA - Income"
        CType(Me.IncomeDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainMenuButton As Button
    Friend WithEvents IncomeLabel As Label
    Friend WithEvents IncomeDataGrid As DataGridView
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Due As DataGridViewTextBoxColumn
    Friend WithEvents Frequency As DataGridViewTextBoxColumn
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents DueTextBox As TextBox
    Friend WithEvents FrequencyListBox As ListBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents AmountLabel As Label
    Friend WithEvents DueLabel As Label
    Friend WithEvents FrequencyButton As Label
End Class
