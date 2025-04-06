Public Class ContestForm
    Sub AllowSubmit()
        Static age As Boolean = False
        Static grade As Boolean = False
        Static name As Boolean = False
        If NameTextBox.Text <> "" Then
            name = True
        ElseIf NameTextBox.Text = "" Then
            name = False
        End If
        If GradeTextBox.Text <> "" Then
            grade = True
        ElseIf GradeTextBox.Text = "" Then
            grade = False
        End If
        If AgeTextBox.Text <> "" Then
            age = True
        ElseIf AgeTextBox.Text = "" Then
            age = False
        End If
        If age = True And grade = True And name = True Then
            SubmitButton.Enabled = True
        ElseIf age <> True Or grade <> True Or name <> True Then
            SubmitButton.Enabled = False
        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        End
    End Sub

    Private Sub SubmitButton_Enter(sender As Object, e As EventArgs) Handles SubmitButton.Enter

    End Sub

    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged
        AllowSubmit()
    End Sub
    Private Sub GradeTextBox_TextChanged(sender As Object, e As EventArgs) Handles GradeTextBox.TextChanged
        AllowSubmit()
    End Sub
    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        AllowSubmit()
    End Sub

    Private Sub ContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SubmitButton.Enabled = False
        MathProblemTypeGroupBox.Enabled = False
    End Sub
End Class
