'Header

Option Compare Text
Option Explicit On
Option Strict On

Public Class ContestForm
    Private Sub ContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SubmitButton.Enabled = False
        MathProblemTypeGroupBox.Enabled = False
        SummeryButton.Enabled = False
    End Sub
    Sub AllowSubmit()
        Static age As Boolean = False
        Static grade As Boolean = False
        Static name As Boolean = False
        Static mathType As Boolean = False
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
            MathProblemTypeGroupBox.Enabled = True
        ElseIf age <> True And grade <> True And name <> True Then
            MathProblemTypeGroupBox.Enabled = False
        End If
        If AddRadioButton.Checked Or SubtractRadioButton.Checked Or MultiplyRadioButton.Checked Or DivideRadioButton.Checked Then
            mathType = True
        End If
        If age = True And grade = True And name = True And mathType = True Then
            InfoChecker()
            SubmitButton.Enabled = True
            SummeryButton.Enabled = True
        ElseIf age <> True Or grade <> True Or name <> True Then
            SubmitButton.Enabled = False
            SummeryButton.Enabled = False
            MathProblemTypeGroupBox.Enabled = False
        End If

    End Sub
    Sub InfoChecker()
        Dim ageValid As Boolean
        Dim gradeValid As Boolean
        Dim nameValid As Boolean
        Dim message As String

        Select Case AgeTextBox.Text
            Case "4"
                ageValid = True
            Case "5"
                ageValid = True
            Case "6"
                ageValid = True
            Case "7"
                ageValid = True
            Case "8"
                ageValid = True
            Case "9"
                ageValid = True
            Case "10"
                ageValid = True
            Case "11"
                ageValid = True
            Case Else
                ageValid = False
                AgeTextBox.Focus()
                message &= "Please enter a valid age." & vbNewLine
        End Select
        Select Case GradeTextBox.Text
            Case "1"
                gradeValid = True
            Case "2"
                gradeValid = True
            Case "3"
                gradeValid = True
            Case "4"
                gradeValid = True
            Case Else
                gradeValid = False
                GradeTextBox.Focus()
                message &= "Please enter a valid grade." & vbNewLine
        End Select
        If NameTextBox.Text = "" Then
            nameValid = False
            NameTextBox.Focus()
            message &= "Please enter a valid name." & vbNewLine
        ElseIf NameTextBox.Text <> "" Then
            nameValid = True
        End If
        If ageValid = False Or gradeValid = False Or nameValid = False Then
            MsgBox(message, MsgBoxStyle.Exclamation, "User Input Fail!!!!")
        ElseIf ageValid = True And gradeValid = True And nameValid = True Then
            Number1Label.Text = CStr(RandomNumber(1, 10))
            Number2Label.Text = CStr(RandomNumber(1, 10))
        End If
    End Sub
    Function CreateMathAnswer(Optional valid As Boolean = False) As Integer
        Dim firstNumber As Integer
        Dim SecondNumber As Integer
        Dim answer As Integer
        If valid = True Then
            firstNumber = CInt(Number1Label.Text)
            SecondNumber = CInt(Number2Label.Text)
            answer = firstNumber * SecondNumber
        End If
        Me.Text = CStr(answer)
        Return answer
    End Function
    Function RandomNumber(Min As Integer, Max As Integer) As Integer
        'Math.
        Dim Dice As Single
        Randomize()
        Dice = Rnd()
        Dice *= Max - Min
        Dice += Min
        Return CInt(Math.Ceiling(Dice))
    End Function
    Private Sub SubmitButton_Enter(sender As Object, e As EventArgs) Handles SubmitButton.Enter
        Dim correctAnswer As Integer
        correctAnswer = CreateMathAnswer(True)
        If CInt(StudentAnswerTextBox.Text) = correctAnswer Then
            InfoChecker()
            MessageBox.Show("Congradulation's, you got the right Answer")
        Else
            InfoChecker()
            MessageBox.Show("incorrect answer")
        End If
        CreateMathAnswer(True)
    End Sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        InfoChecker()
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
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        End
    End Sub
    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        AllowSubmit()
    End Sub
    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged
        AllowSubmit()
    End Sub
    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyRadioButton.CheckedChanged
        AllowSubmit()
    End Sub
    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.CheckedChanged
        AllowSubmit()
    End Sub

End Class
