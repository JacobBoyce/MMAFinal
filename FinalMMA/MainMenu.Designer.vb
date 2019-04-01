<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.ExpensesButton = New System.Windows.Forms.Button()
        Me.IncomeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExpensesButton
        '
        Me.ExpensesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpensesButton.Location = New System.Drawing.Point(140, 176)
        Me.ExpensesButton.Name = "ExpensesButton"
        Me.ExpensesButton.Size = New System.Drawing.Size(377, 71)
        Me.ExpensesButton.TabIndex = 0
        Me.ExpensesButton.Text = "Expenses"
        Me.ExpensesButton.UseVisualStyleBackColor = True
        '
        'IncomeButton
        '
        Me.IncomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncomeButton.Location = New System.Drawing.Point(523, 176)
        Me.IncomeButton.Name = "IncomeButton"
        Me.IncomeButton.Size = New System.Drawing.Size(377, 71)
        Me.IncomeButton.TabIndex = 1
        Me.IncomeButton.Text = "Income"
        Me.IncomeButton.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1696, 1083)
        Me.Controls.Add(Me.IncomeButton)
        Me.Controls.Add(Me.ExpensesButton)
        Me.MaximumSize = New System.Drawing.Size(1728, 1171)
        Me.MinimumSize = New System.Drawing.Size(1728, 1171)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MMA - Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExpensesButton As Button
    Friend WithEvents IncomeButton As Button
End Class
