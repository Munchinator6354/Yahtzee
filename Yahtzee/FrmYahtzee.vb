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
    'Globally sets up a new Random Object in memory
    Dim rand As New Random

    'Global variable of remaining roll count
    Dim intCurrentRollCount As Integer

    'Global variable holding total for the round of dice rolls
    Dim intRollRoundTotal As Integer

    'Global array of dice buttons
    Dim BtnArray(4) As Button

    'Global array of kept/held dice
    Dim blnKeptDiceArray() As Boolean = {False, False, False, False, False}

    'Global array to hold dice images
    Dim imgDiceImagesArr(5) As Image

    'Global array to hold integer values for the dice
    Dim intDieValueArr() As Integer = {6, 6, 6, 6, 6}

    Public Sub FrmYahtzee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On second game playthrough this allows blnKeptDiceArray to refresh all elements as "False"
        For i = 0 To blnKeptDiceArray.Length - 1
            blnKeptDiceArray(i) = False
        Next

        'On second game playthrough this allows intRollRoundTotal to refresh at 0
        intRollRoundTotal = 0

        'Sets the remaining roll count initially to 3
        intCurrentRollCount = 3

        'Displays the remaining roll count to the player
        lblRollCounter.Text = "You have " & intCurrentRollCount & " rolls remaining"

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

    End Sub

    Public Sub BtnRollTheDice_Click(sender As Object, e As EventArgs) Handles BtnRollTheDice.Click
        'Decreases the remaining dice rolls by 1
        intCurrentRollCount -= 1

        'Checks to qualify if the player has more dice rolls left
        If intCurrentRollCount >= 0 Then

            'Displays the current roll count to the screen
            lblRollCounter.Text = "You have " & intCurrentRollCount & " rolls remaining"


            'Establishes a new array to hold dice values in
            Dim intDieValueArr(4) As Integer

            'This block of code will check if a dice has been held/kept. If it has it will not re-roll the dice
            For i = 0 To blnKeptDiceArray.Length - 1
                If blnKeptDiceArray(i) = True Then
                    intDieValueArr(i) = intDieValueArr(i)
                ElseIf blnKeptDiceArray(i) = False Then
                    intDieValueArr(i) = GenerateRandomDiceNum(rand)
                End If
            Next
            ' System.Diagnostics.Debug.WriteLine("intDieValueArr Here:" & intDieValueArr(0) & intDieValueArr(1) & intDieValueArr(2) & intDieValueArr(3) & intDieValueArr(4))
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

            If intCurrentRollCount = 0 Then
                For i = 0 To intDieValueArr.Length - 1
                    blnKeptDiceArray(i) = True
                    intRollRoundTotal += intDieValueArr(i)
                Next
                lblScoreCounter.Text = "This round's score is " & intRollRoundTotal & vbCrLf & "Select a category to add this score to."
                MsgBox("You rolled a score of " & intRollRoundTotal & vbCrLf & "Please apply it to a score tile")
            End If
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
            'And switch it's kept/held value to True
            blnKeptDiceArray(0) = True

            'If dice border color is green, make it red
        ElseIf BtnDice1.FlatAppearance.BorderColor = Color.Green Then
            BtnDice1.FlatAppearance.BorderColor = Color.Red
            'And switch it's kept/held value to False
            blnKeptDiceArray(0) = False
        End If

    End Sub

    Private Sub BtnDice2_Click(sender As Object, e As EventArgs) Handles BtnDice2.Click
        'If dice border color is red, make it green
        If BtnDice2.FlatAppearance.BorderColor = Color.Red Then
            BtnDice2.FlatAppearance.BorderColor = Color.Green
            'And switch it's kept/held value to True
            blnKeptDiceArray(1) = True

            'If dice border color is green, make it red
        ElseIf BtnDice2.FlatAppearance.BorderColor = Color.Green Then
            BtnDice2.FlatAppearance.BorderColor = Color.Red
            'And switch it's kept/held value to False
            blnKeptDiceArray(1) = False
        End If
    End Sub

    Private Sub BtnDice3_Click(sender As Object, e As EventArgs) Handles BtnDice3.Click
        'If dice border color is red, make it green
        If BtnDice3.FlatAppearance.BorderColor = Color.Red Then
            BtnDice3.FlatAppearance.BorderColor = Color.Green
            'And switch it's kept/held value to True
            blnKeptDiceArray(2) = True

            'If dice border color is green, make it red
        ElseIf BtnDice3.FlatAppearance.BorderColor = Color.Green Then
            BtnDice3.FlatAppearance.BorderColor = Color.Red
            'And switch it's kept/held value to False
            blnKeptDiceArray(2) = False
        End If
    End Sub

    Private Sub BtnDice4_Click(sender As Object, e As EventArgs) Handles BtnDice4.Click
        'If dice border color is red, make it green
        If BtnDice4.FlatAppearance.BorderColor = Color.Red Then
            BtnDice4.FlatAppearance.BorderColor = Color.Green
            'And switch it's kept/held value to True
            blnKeptDiceArray(3) = True

            'If dice border color is green, make it red
        ElseIf BtnDice4.FlatAppearance.BorderColor = Color.Green Then
            BtnDice4.FlatAppearance.BorderColor = Color.Red
            'And switch it's kept/held value to False
            blnKeptDiceArray(3) = False

        End If
    End Sub

    Private Sub BtnDice5_Click(sender As Object, e As EventArgs) Handles BtnDice5.Click
        'If dice border color is red, make it green
        If BtnDice5.FlatAppearance.BorderColor = Color.Red Then
            BtnDice5.FlatAppearance.BorderColor = Color.Green
            'And switch it's kept/held value to True
            blnKeptDiceArray(4) = True

            'If dice border color is green, make it red
        ElseIf BtnDice5.FlatAppearance.BorderColor = Color.Green Then
            BtnDice5.FlatAppearance.BorderColor = Color.Red
            'And switch it's kept/held value to False
            blnKeptDiceArray(4) = False

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

