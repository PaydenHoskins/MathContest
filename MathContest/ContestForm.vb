'Payden hoskins
'RCET2265
'Math Contest
'Spring 2026
'https://github.com/PaydenHoskins/MathContest.git

Option Compare Text
Option Explicit On
Option Strict On

Imports System.Windows.Forms.VisualStyles

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
            MsgBox(message, MsgBoxStyle.Exclamation, "Student not eligible to compete.")
        ElseIf ageValid = True And gradeValid = True And nameValid = True Then
            Number1Label.Text = CStr(RandomNumber(1, 10))
            Number2Label.Text = CStr(RandomNumber(1, 10))
        End If
    End Sub
    Function CreateMathAnswer(Optional valid As Boolean = False, Optional mathFunction As Integer = 0) As Double
        Dim firstNumber As Decimal
        Dim SecondNumber As Decimal
        Static selectedCase As Integer = mathFunction
        Dim answer As Decimal
        If valid = True Then
            firstNumber = CDec(Number1Label.Text)
            SecondNumber = CDec(Number2Label.Text)
            If AddRadioButton.Checked Then
                answer = firstNumber + SecondNumber
            ElseIf SubtractRadioButton.Checked Then
                answer = firstNumber - SecondNumber
            ElseIf MultiplyRadioButton.Checked Then
                answer = firstNumber * SecondNumber
            ElseIf DivideRadioButton.checked Then
                answer = firstNumber / SecondNumber
            End If
        End If
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
    Function KeepRightCount(Optional count As Integer = 0) As Integer
        Static number As Integer = 0
        If count = 1 Then
            number += 1
        ElseIf count = 2 Then
            number = 0
        ElseIf count = 0 Then
        End If
        Return number
    End Function
    Function KeepTotalCount(Optional count As Integer = 0) As Integer
        Static number As Integer = 0
        If count = 1 Then
            number += 1
        ElseIf count = 2 Then
            number = 0
        ElseIf count = 0 Then
        End If
        Return number
    End Function
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim correctAnswer As Double
        KeepTotalCount(1)
        correctAnswer = CreateMathAnswer(True)
        If CDec(StudentAnswerTextBox.Text) = correctAnswer Then
            InfoChecker()
            MessageBox.Show("Congradulation's, you got the right Answer")
            KeepRightCount(1)
        Else
            InfoChecker()
            MessageBox.Show($"incorrect answer, right answer was {correctAnswer}")
        End If
        CreateMathAnswer(True)
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
        Dim selected As Integer = 1
        AllowSubmit()
        CreateMathAnswer(, selected)
    End Sub
    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged
        Dim selected As Integer = 2
        AllowSubmit()
        CreateMathAnswer(, selected)
    End Sub
    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyRadioButton.CheckedChanged
        Dim selected As Integer = 3
        AllowSubmit()
        CreateMathAnswer(, selected)
    End Sub
    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.CheckedChanged
        Dim selected As Integer = 4
        AllowSubmit()
        CreateMathAnswer(, selected)
    End Sub
    Private Sub SummeryButton_Click(sender As Object, e As EventArgs) Handles SummeryButton.Click
        Static rightAnswers As Integer
        Static problems As Integer
        rightAnswers = KeepRightCount(0)
        problems = KeepTotalCount(0)
        MessageBox.Show($"{NameTextBox.Text} has got {rightAnswers} right out of {problems}")
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        AddRadioButton.Checked = False
        SubtractRadioButton.Checked = False
        MultiplyRadioButton.Checked = False
        DivideRadioButton.Checked = False
        Number1Label.Text = ""
        Number2Label.Text = ""
        StudentAnswerTextBox.Text = ""
        KeepRightCount(2)
        KeepTotalCount(2)
    End Sub
End Class
