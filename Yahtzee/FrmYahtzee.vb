Option Strict On
Option Explicit On
'Program:       Yahtzee
'               Final Project  - Yahtzee Game (Alternative)
'Programmers:   Ryan Isaacson / Github: Munchinator6354 & Kenneth Young
'Updated:       December 11, 2020
'Description    This program will allow the user to play the classic game Yahtzee. The player will
'               roll 5 dice up to a maximum of 3 times. The user can keep dice from rolling again
'               by changing it's border to green. If the border is red, the dice will roll again.

Public Class FrmYahtzee
    'Global roll count variable
    Dim intCurrentRollCount As Integer
    'Global array of dice buttons
    Dim BtnArray(4) As Button

    Public Sub FrmYahtzee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the remaining roll count initially to 3
        intCurrentRollCount = 3

        'Displays the remaining roll count to the player
        lblRollCounter.Text = "You have " & intCurrentRollCount & " rolls remaining"

        'This creates an array to hold dice images
        Dim imgDiceImagesArr(5) As Image

        'This creates an array to hold integer values for the dice
        Dim intDieValueArr() As Integer = {6, 6, 6, 6, 6}

        'This creates an array to hold kept dice values when turned green
        Dim intKeptDiceValuesArr(4) As Integer

        'This displays the Yahtzee banner/title image
        picYahtzeeBanner.Image = Image.FromFile("..\Images\yahtzeeBanner.jpg")
        picYahtzeeBanner.SizeMode = PictureBoxSizeMode.StretchImage

        'This adds a dice image to each index of imgDiceArr(5)
        imgDiceImagesArr(0) = Image.FromFile("..\Images\dice1.jpg")
        imgDiceImagesArr(1) = Image.FromFile("..\Images\dice2.jpg")
        imgDiceImagesArr(2) = Image.FromFile("..\Images\dice3.jpg")
        imgDiceImagesArr(3) = Image.FromFile("..\Images\dice4.jpg")
        imgDiceImagesArr(4) = Image.FromFile("..\Images\dice5.jpg")
        imgDiceImagesArr(5) = Image.FromFile("..\Images\dice6.jpg")

        'Establishing values for the button aray to iterate through later
        BtnArray(0) = BtnDice1
        BtnArray(1) = BtnDice2
        BtnArray(2) = BtnDice3
        BtnArray(3) = BtnDice4
        BtnArray(4) = BtnDice5

        'This loop sets up how each die appears to the player
        For i = 0 To BtnArray.Length - 1
            'First it sets the button style to the Flatstyle
            BtnArray(i).FlatStyle = FlatStyle.Flat
            'Second it sets the buttons Flatstyle BorderColor to Red
            BtnArray(i).FlatAppearance.BorderColor = Color.Red
            'Third it sets the button's BackgroundImage to desired Array Index
            BtnArray(i).BackgroundImage = imgDiceImagesArr(5)
            'Last it sets the BackgroundImageLayout to Stretch to take up the whole button
            BtnArray(i).BackgroundImageLayout = ImageLayout.Stretch
            'Changes the users' cursor to a hand when hovering over the button
            BtnArray(i).Cursor = Cursors.Hand
        Next

        'This code block sets up how the 1st die looks
        'First it sets the button style to the Flatstyle
        'BtnDice1.FlatStyle = FlatStyle.Flat
        'Second it sets the buttons Flatstyle BorderColor to Red
        'BtnDice1.FlatAppearance.BorderColor = Color.Red
        'Third it sets the button's BackgroundImage to desired Array Index
        'BtnDice1.BackgroundImage = imgDiceImagesArr(5)
        'Last it sets the BackgroundImageLayout to Stretch to take up the whole button
        'BtnDice1.BackgroundImageLayout = ImageLayout.Stretch
        'Changes the users' cursor to a hand when hovering over the button
        'BtnDice1.Cursor = Cursors.Hand

        'This code block sets up how the 2nd die looks
        'BtnDice2.FlatStyle = FlatStyle.Flat
        'BtnDice2.FlatAppearance.BorderColor = Color.Red
        'BtnDice2.BackgroundImage = imgDiceImagesArr(5)
        'BtnDice2.BackgroundImageLayout = ImageLayout.Stretch
        'BtnDice2.Cursor = Cursors.Hand

        'This code block sets up how the 3rd die looks
        'BtnDice3.FlatStyle = FlatStyle.Flat
        'BtnDice3.FlatAppearance.BorderColor = Color.Red
        'BtnDice3.BackgroundImage = imgDiceImagesArr(5)
        'BtnDice3.BackgroundImageLayout = ImageLayout.Stretch
        'BtnDice3.Cursor = Cursors.Hand

        'This code block sets up how the 4th die looks
        'BtnDice4.FlatStyle = FlatStyle.Flat
        'BtnDice4.FlatAppearance.BorderColor = Color.Red
        'BtnDice4.BackgroundImage = imgDiceImagesArr(5)
        'BtnDice4.BackgroundImageLayout = ImageLayout.Stretch
        'BtnDice4.Cursor = Cursors.Hand

        'This code block sets up how the 5th die looks
        'BtnDice5.FlatStyle = FlatStyle.Flat
        'BtnDice5.FlatAppearance.BorderColor = Color.Red
        'BtnDice5.BackgroundImage = imgDiceImagesArr(5)
        'BtnDice5.BackgroundImageLayout = ImageLayout.Stretch
        'BtnDice5.Cursor = Cursors.Hand

    End Sub

    Public Sub BtnRollTheDice_Click(sender As Object, e As EventArgs) Handles BtnRollTheDice.Click
        'Decreases the remaining dice rolls by 1
        intCurrentRollCount -= 1

        'Checks to qualify if the player has more dice rolls left
        If intCurrentRollCount >= 0 Then

            'Displays the current roll count to the screen
            lblRollCounter.Text = "You have " & intCurrentRollCount & " rolls remaining"

            'Set up a new Random Object in memory
            Dim rand As New Random

            'Generates a new array of random numbers to associate with the dice
            Dim intDieValueArr(4) As Integer
            intDieValueArr(0) = GenerateRandomDiceNum(rand)
            intDieValueArr(1) = GenerateRandomDiceNum(rand)
            intDieValueArr(2) = GenerateRandomDiceNum(rand)
            intDieValueArr(3) = GenerateRandomDiceNum(rand)
            intDieValueArr(4) = GenerateRandomDiceNum(rand)

            'This block of code changes the appearence of each die button depending on it's dice value
            For i = 0 To intDieValueArr.Length - 1
                If intDieValueArr(i) = 1 Then
                    BtnArray(i).BackgroundImage = Image.FromFile("..\Images\dice1.jpg")
                ElseIf intDieValueArr(i) = 2 Then
                    BtnArray(i).BackgroundImage = Image.FromFile("..\Images\dice2.jpg")
                ElseIf intDieValueArr(i) = 3 Then
                    BtnArray(i).BackgroundImage = Image.FromFile("..\Images\dice3.jpg")
                ElseIf intDieValueArr(i) = 4 Then
                    BtnArray(i).BackgroundImage = Image.FromFile("..\Images\dice4.jpg")
                ElseIf intDieValueArr(i) = 5 Then
                    BtnArray(i).BackgroundImage = Image.FromFile("..\Images\dice5.jpg")
                ElseIf intDieValueArr(i) = 6 Then
                    BtnArray(i).BackgroundImage = Image.FromFile("..\Images\dice6.jpg")
                End If
            Next

            'This block will change the picture of die 1 based on the value of it inside intDieValueArr()
            'If intDieValueArr(0) = 1 Then
            '        BtnDice1.BackgroundImage = Image.FromFile("..\Images\dice1.jpg")
            '    ElseIf intDieValueArr(0) = 2 Then
            '        BtnDice1.BackgroundImage = Image.FromFile("..\Images\dice2.jpg")
            '    ElseIf intDieValueArr(0) = 3 Then
            '        BtnDice1.BackgroundImage = Image.FromFile("..\Images\dice3.jpg")
            '    ElseIf intDieValueArr(0) = 4 Then
            '        BtnDice1.BackgroundImage = Image.FromFile("..\Images\dice4.jpg")
            '    ElseIf intDieValueArr(0) = 5 Then
            '        BtnDice1.BackgroundImage = Image.FromFile("..\Images\dice5.jpg")
            '    ElseIf intDieValueArr(0) = 6 Then
            '        BtnDice1.BackgroundImage = Image.FromFile("..\Images\dice6.jpg")
            'End If

            'This block will change the picture of die 2 based on the value of it inside intDieValueArr()
            'If intDieValueArr(1) = 1 Then
            '    BtnDice2.BackgroundImage = Image.FromFile("..\Images\dice1.jpg")
            'ElseIf intDieValueArr(1) = 2 Then
            '    BtnDice2.BackgroundImage = Image.FromFile("..\Images\dice2.jpg")
            'ElseIf intDieValueArr(1) = 3 Then
            '    BtnDice2.BackgroundImage = Image.FromFile("..\Images\dice3.jpg")
            'ElseIf intDieValueArr(1) = 4 Then
            '    BtnDice2.BackgroundImage = Image.FromFile("..\Images\dice4.jpg")
            'ElseIf intDieValueArr(1) = 5 Then
            '    BtnDice2.BackgroundImage = Image.FromFile("..\Images\dice5.jpg")
            'ElseIf intDieValueArr(1) = 6 Then
            '    BtnDice2.BackgroundImage = Image.FromFile("..\Images\dice6.jpg")
            'End If

            'This block will change the picture of die 3 based on the value of it inside intDieValueArr()
            'If intDieValueArr(2) = 1 Then
            '    BtnDice3.BackgroundImage = Image.FromFile("..\Images\dice1.jpg")
            'ElseIf intDieValueArr(1) = 2 Then
            '    BtnDice3.BackgroundImage = Image.FromFile("..\Images\dice2.jpg")
            'ElseIf intDieValueArr(1) = 3 Then
            '    BtnDice3.BackgroundImage = Image.FromFile("..\Images\dice3.jpg")
            'ElseIf intDieValueArr(1) = 4 Then
            '    BtnDice3.BackgroundImage = Image.FromFile("..\Images\dice4.jpg")
            'ElseIf intDieValueArr(1) = 5 Then
            '    BtnDice3.BackgroundImage = Image.FromFile("..\Images\dice5.jpg")
            'ElseIf intDieValueArr(1) = 6 Then
            '    BtnDice3.BackgroundImage = Image.FromFile("..\Images\dice6.jpg")
            'End If

            'This block will change the picture of die 4 based on the value of it inside intDieValueArr()
            'If intDieValueArr(3) = 1 Then
            '    BtnDice4.BackgroundImage = Image.FromFile("..\Images\dice1.jpg")
            'ElseIf intDieValueArr(1) = 2 Then
            '    BtnDice4.BackgroundImage = Image.FromFile("..\Images\dice2.jpg")
            'ElseIf intDieValueArr(1) = 3 Then
            '    BtnDice4.BackgroundImage = Image.FromFile("..\Images\dice3.jpg")
            'ElseIf intDieValueArr(1) = 4 Then
            '    BtnDice4.BackgroundImage = Image.FromFile("..\Images\dice4.jpg")
            'ElseIf intDieValueArr(1) = 5 Then
            '    BtnDice4.BackgroundImage = Image.FromFile("..\Images\dice5.jpg")
            'ElseIf intDieValueArr(1) = 6 Then
            '    BtnDice4.BackgroundImage = Image.FromFile("..\Images\dice6.jpg")
            'End If

            'This block will change the picture of die 5 based on the value of it inside intDieValueArr()
            '    If intDieValueArr(4) = 1 Then
            '        BtnDice5.BackgroundImage = Image.FromFile("..\Images\dice1.jpg")
            '    ElseIf intDieValueArr(1) = 2 Then
            '        BtnDice5.BackgroundImage = Image.FromFile("..\Images\dice2.jpg")
            '    ElseIf intDieValueArr(1) = 3 Then
            '        BtnDice5.BackgroundImage = Image.FromFile("..\Images\dice3.jpg")
            '    ElseIf intDieValueArr(1) = 4 Then
            '        BtnDice5.BackgroundImage = Image.FromFile("..\Images\dice4.jpg")
            '    ElseIf intDieValueArr(1) = 5 Then
            '        BtnDice5.BackgroundImage = Image.FromFile("..\Images\dice5.jpg")
            '    ElseIf intDieValueArr(1) = 6 Then
            '        BtnDice5.BackgroundImage = Image.FromFile("..\Images\dice6.jpg")
            '    End If
        Else
            MsgBox("You are out of rolls")

        End If

    End Sub


    '================================================================================================================
    'Functions & Subroutines
    '================================================================================================================
    Private Sub BtnDice1_Click(sender As Object, e As EventArgs) Handles BtnDice1.Click
        'If dice border color is red, make it green
        If BtnDice1.FlatAppearance.BorderColor = Color.Red Then
            BtnDice1.FlatAppearance.BorderColor = Color.Green
            'if dice border color is green, make it red
        ElseIf BtnDice1.FlatAppearance.BorderColor = Color.Green Then
            BtnDice1.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub

    Private Sub BtnDice2_Click(sender As Object, e As EventArgs) Handles BtnDice2.Click
        'If dice border color is red, make it green
        If BtnDice2.FlatAppearance.BorderColor = Color.Red Then
            BtnDice2.FlatAppearance.BorderColor = Color.Green
            'if dice border color is green, make it red
        ElseIf BtnDice2.FlatAppearance.BorderColor = Color.Green Then
            BtnDice2.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub

    Private Sub BtnDice3_Click(sender As Object, e As EventArgs) Handles BtnDice3.Click
        'If dice border color is red, make it green
        If BtnDice3.FlatAppearance.BorderColor = Color.Red Then
            BtnDice3.FlatAppearance.BorderColor = Color.Green
            'if dice border color is green, make it red
        ElseIf BtnDice3.FlatAppearance.BorderColor = Color.Green Then
            BtnDice3.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub

    Private Sub BtnDice4_Click(sender As Object, e As EventArgs) Handles BtnDice4.Click
        'If dice border color is red, make it green
        If BtnDice4.FlatAppearance.BorderColor = Color.Red Then
            BtnDice4.FlatAppearance.BorderColor = Color.Green
            'if dice border color is green, make it red
        ElseIf BtnDice4.FlatAppearance.BorderColor = Color.Green Then
            BtnDice4.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub

    Private Sub BtnDice5_Click(sender As Object, e As EventArgs) Handles BtnDice5.Click
        'If dice border color is red, make it green
        If BtnDice5.FlatAppearance.BorderColor = Color.Red Then
            BtnDice5.FlatAppearance.BorderColor = Color.Green
            'if dice border color is green, make it red
        ElseIf BtnDice5.FlatAppearance.BorderColor = Color.Green Then
            BtnDice5.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub



    Public Function GenerateRandomDiceNum(random As Random) As Integer
        Dim intDieValue As Integer = random.Next(1, 7)
        Return intDieValue
    End Function

    Public Function IncreaseRollCount(currentRollCount As Integer) As Integer
        Dim intRollCounter As Integer
        intRollCounter += currentRollCount
    End Function





    'Public Function GenerateRandomDieNum(ByRef blnKeptDiceArr() As Boolean) As Integer

    'Dim blnKeptDiceArray(4) As Boolean
    'Sets up variable To store a random die Integer 1-6
    'Dim intDieValue As Integer
    'Set up an array To pass back With the dice numbers
    'Dim intDiceValuesArr(4) As Integer

    'Puts the array value passed In As blnKeptDiceArr into blnKeptDiceArray To be iterated through
    'blnKeptDiceArray = blnKeptDiceArr

    'For i = 0 To UBound(blnKeptDiceArray)

    'If blnKeptDiceArray(i) = True Then
    'blnKeptDiceArray(i) = True

    'ElseIf blnKeptDiceArray(i) = False Then

    'System.Diagnostics.Debug.WriteLine(blnKeptDiceArray + "blnKeptDiceArray")

    'End Function

    Private Sub BtnRestartGame_Click(sender As Object, e As EventArgs) Handles BtnRestartGame.Click
        'Clears all the controls on the Form
        Controls.Clear()
        'Reinitializes all components
        InitializeComponent()
        'Reloads controls onto form and performs load event
        FrmYahtzee_Load(e, e)
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        'Closes Program
        Close()
    End Sub

End Class

