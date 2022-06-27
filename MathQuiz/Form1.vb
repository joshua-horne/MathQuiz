
Public Class Form1

    ' Create a Random object called randomizer 
    ' to generate random numbers.

    Private randomizer As New Random

    ' These integer variables store the numbers 
    ' for the addition problem. 

    Private addend1 As Integer
    Private addend2 As Integer

    ' These integer variables store the numbers 
    ' for the subtraction problem. 

    Private minuend As Integer
    Private subtrahend As Integer

    ' These integer variables store the numbers 
    ' for the multiplication problem. 

    Private multiplicand As Integer
    Private multiplier As Integer

    ' These integer variables store the numbers 
    ' for the division problem. 

    Private dividend As Integer
    Private diviser As Integer

    ' This variable displays the seconds left

    Private timeLeft As Integer

    Public Sub StartTheQuiz()

        ' Fill in the addition problem.
        ' Generate two random numbers to add.
        ' Store the values in the variables 'addend1' and 'addend2'.

        addend1 = randomizer.Next(51)
        addend2 = randomizer.Next(51)

        ' Convert the two randomly generated numbers
        ' into strings so that they can be displayed
        ' in the label controls.

        plusLeftlabel.Text = addend1.ToString()
        plusRightlabel.Text = addend2.ToString()

        ' 'sum' is the name of the NumericUpDown control.
        ' This step makes sure its value is zero before
        ' adding any values to it.

        sum.Value = 0

        ' Fill in the subtraction problem.

        minuend = randomizer.Next(1, 101)
        subtrahend = randomizer.Next(1, minuend)
        minusLeftlabel.Text = minuend.ToString()
        minusRightLabel.Text = subtrahend.ToString()
        difference.Value = 0

        ' Fill in the multiplication problem.

        multiplicand = randomizer.Next(2, 11)
        multiplier = randomizer.Next(2, 11)
        timesLeftLabel.Text = multiplicand.ToString()
        timesRightLabel.Text = multiplier.ToString()
        product.Value = 0

        ' Fill in the division problem.

        diviser = randomizer.Next(2, 11)
        Dim temporaryQoutient As Integer = randomizer.Next(2, 11)
        dividend = temporaryQoutient * diviser
        dividedLeftLabel.Text = dividend.ToString()
        dividedRightLabel.Text = diviser.ToString()
        quotient.Value = 0

        ' Start the timer.

        timeLeft = 30
        timeLabel.Text = timeLeft & "seconds"
        Timer1.Start()


    End Sub

    Public Function CheckTheAnswer() As Boolean

        'Check that the answers of each question are correct

        If addend1 + addend2 = sum.Value AndAlso
                minuend - subtrahend = difference.Value AndAlso
                multiplicand * multiplier = product.Value AndAlso
                dividend / diviser = quotient.Value Then

            Return True

        Else Return False

        End If

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click

        ' Call the StartTheQuiz() method and enable
        ' the Start button.

        StartTheQuiz()
        startButton.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If CheckTheAnswer() Then

            ' If CheckTheAnswer() returns true, then the user 
            ' got the answer right. Stop the timer  
            ' and show a MessageBox.

            Timer1.Stop()
            MessageBox.Show("You got all the answers right! Congratulations!")
            startButton.Enabled = True

        ElseIf timeLeft > 0 Then

            ' If CheckTheAnswer() returns false, keep counting
            ' down. Decrease the time left by one second and 
            ' display the new time left by updating the 
            ' Time Left label.

            timeLeft -= 1
            timeLabel.Text = timeLeft & "seconds"

            If timeLeft < 5 Then

                'Change background colour of time label to red when less than 5 seconds left

                timeLabel.BackColor = Color.Red
            Else timeLabel.BackColor = Nothing

            End If

        Else

            ' If the user ran out of time, stop the timer, show
            ' a MessageBox, and fill in the answers.

            Timer1.Stop()
            timeLabel.Text = "Time's Up!"
            MessageBox.Show("You didn't finish in time.", "Sorry!")
            sum.Value = addend1 + addend2
            difference.Value = minuend - subtrahend
            product.Value = multiplicand * multiplier
            quotient.Value = dividend / diviser
            startButton.Enabled = True

        End If
    End Sub

    Private Sub answer_Enter(sender As Object, e As EventArgs) Handles sum.Enter, quotient.Enter, product.Enter, difference.Enter

        ' Select the whole answer in the NumericUpDown control.

        Dim answerBox = TryCast(sender, NumericUpDown)

        If answerBox IsNot Nothing Then
            Dim lengthOfAnswer = answerBox.Value.ToString().Length
            answerBox.Select(0, lengthOfAnswer)
        End If

    End Sub

    Private Sub correct_sum(sender As Object, e As EventArgs) Handles sum.ValueChanged

        If sum.Value = addend1 + addend2 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
        End If

    End Sub

    Private Sub correct_difference(sender As Object, e As EventArgs) Handles difference.ValueChanged

        'Play sound effect if answeer is correct

        If difference.Value = minuend - subtrahend Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
        End If
    End Sub

    Private Sub correct_product(sender As Object, e As EventArgs) Handles product.ValueChanged

        'Play sound effect if answeer is correct

        If product.Value = multiplicand * multiplier Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
        End If
    End Sub

    Private Sub correct_quotient(sender As Object, e As EventArgs) Handles quotient.ValueChanged

        'Play sound effect if answeer is correct

        If quotient.Value = dividend / diviser Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
        End If
    End Sub
End Class
