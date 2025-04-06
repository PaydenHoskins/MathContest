<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContestForm
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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.MathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.FisrtNumberLabel = New System.Windows.Forms.Label()
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.MathProblemTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.ControlsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummeryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Number1Label = New System.Windows.Forms.Label()
        Me.Number2Label = New System.Windows.Forms.Label()
        Me.MathProblemGroupBox.SuspendLayout()
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.MathProblemTypeGroupBox.SuspendLayout()
        Me.ControlsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(6, 51)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(165, 20)
        Me.NameTextBox.TabIndex = 0
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(6, 128)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(150, 20)
        Me.StudentAnswerTextBox.TabIndex = 3
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(228, 51)
        Me.AgeTextBox.MaxLength = 2
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(39, 20)
        Me.AgeTextBox.TabIndex = 4
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(307, 51)
        Me.GradeTextBox.MaxLength = 1
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(36, 20)
        Me.GradeTextBox.TabIndex = 5
        '
        'MathProblemGroupBox
        '
        Me.MathProblemGroupBox.Controls.Add(Me.Number2Label)
        Me.MathProblemGroupBox.Controls.Add(Me.Number1Label)
        Me.MathProblemGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.FisrtNumberLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.MathProblemGroupBox.Location = New System.Drawing.Point(54, 153)
        Me.MathProblemGroupBox.Name = "MathProblemGroupBox"
        Me.MathProblemGroupBox.Size = New System.Drawing.Size(164, 198)
        Me.MathProblemGroupBox.TabIndex = 6
        Me.MathProblemGroupBox.TabStop = False
        Me.MathProblemGroupBox.Text = "Current Math Problem"
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(6, 112)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(82, 13)
        Me.StudentAnswerLabel.TabIndex = 13
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(6, 62)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(65, 13)
        Me.SecondNumberLabel.TabIndex = 12
        Me.SecondNumberLabel.Text = "2nd Number"
        '
        'FisrtNumberLabel
        '
        Me.FisrtNumberLabel.AutoSize = True
        Me.FisrtNumberLabel.Location = New System.Drawing.Point(6, 18)
        Me.FisrtNumberLabel.Name = "FisrtNumberLabel"
        Me.FisrtNumberLabel.Size = New System.Drawing.Size(61, 13)
        Me.FisrtNumberLabel.TabIndex = 11
        Me.FisrtNumberLabel.Text = "1st Number"
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(54, 36)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(391, 77)
        Me.StudentInfoGroupBox.TabIndex = 7
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Info"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(304, 35)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(36, 13)
        Me.GradeLabel.TabIndex = 10
        Me.GradeLabel.Text = "Grade"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(232, 35)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(26, 13)
        Me.AgeLabel.TabIndex = 9
        Me.AgeLabel.Text = "Age"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 35)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "Name"
        '
        'MathProblemTypeGroupBox
        '
        Me.MathProblemTypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathProblemTypeGroupBox.Location = New System.Drawing.Point(260, 153)
        Me.MathProblemTypeGroupBox.Name = "MathProblemTypeGroupBox"
        Me.MathProblemTypeGroupBox.Size = New System.Drawing.Size(184, 198)
        Me.MathProblemTypeGroupBox.TabIndex = 8
        Me.MathProblemTypeGroupBox.TabStop = False
        Me.MathProblemTypeGroupBox.Text = "Math Problem Type"
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(22, 103)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(22, 80)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(58, 17)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multipy"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(22, 57)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(22, 34)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(44, 17)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'ControlsGroupBox
        '
        Me.ControlsGroupBox.Controls.Add(Me.ExitButton)
        Me.ControlsGroupBox.Controls.Add(Me.SummeryButton)
        Me.ControlsGroupBox.Controls.Add(Me.ClearButton)
        Me.ControlsGroupBox.Controls.Add(Me.SubmitButton)
        Me.ControlsGroupBox.Location = New System.Drawing.Point(493, 44)
        Me.ControlsGroupBox.Name = "ControlsGroupBox"
        Me.ControlsGroupBox.Size = New System.Drawing.Size(264, 307)
        Me.ControlsGroupBox.TabIndex = 9
        Me.ControlsGroupBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(31, 226)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(206, 42)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummeryButton
        '
        Me.SummeryButton.Location = New System.Drawing.Point(31, 161)
        Me.SummeryButton.Name = "SummeryButton"
        Me.SummeryButton.Size = New System.Drawing.Size(206, 42)
        Me.SummeryButton.TabIndex = 2
        Me.SummeryButton.Text = "Summery"
        Me.SummeryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(30, 95)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(207, 42)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(29, 30)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(209, 45)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit "
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'Number1Label
        '
        Me.Number1Label.AutoSize = True
        Me.Number1Label.Location = New System.Drawing.Point(6, 38)
        Me.Number1Label.Name = "Number1Label"
        Me.Number1Label.Size = New System.Drawing.Size(0, 13)
        Me.Number1Label.TabIndex = 10
        '
        'Number2Label
        '
        Me.Number2Label.AutoSize = True
        Me.Number2Label.Location = New System.Drawing.Point(6, 84)
        Me.Number2Label.Name = "Number2Label"
        Me.Number2Label.Size = New System.Drawing.Size(0, 13)
        Me.Number2Label.TabIndex = 14
        '
        'ContestForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(789, 372)
        Me.Controls.Add(Me.ControlsGroupBox)
        Me.Controls.Add(Me.MathProblemTypeGroupBox)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Controls.Add(Me.MathProblemGroupBox)
        Me.Name = "ContestForm"
        Me.Text = "Form1"
        Me.MathProblemGroupBox.ResumeLayout(False)
        Me.MathProblemGroupBox.PerformLayout()
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.MathProblemTypeGroupBox.ResumeLayout(False)
        Me.MathProblemTypeGroupBox.PerformLayout()
        Me.ControlsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents MathProblemGroupBox As GroupBox
    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents GradeLabel As Label
    Friend WithEvents FisrtNumberLabel As Label
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents MathProblemTypeGroupBox As GroupBox
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents ControlsGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummeryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents Number2Label As Label
    Friend WithEvents Number1Label As Label
End Class
