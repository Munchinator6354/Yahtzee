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
    '================================================================================================================
    'Global Space
    'Programmer: Ryan Isaacson / Github: Munchinator6354 
    'Updated: December 07, 2020
    'Description: Space to declare globally accessible variables, arrays, etc.
    '================================================================================================================
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

    '================================================================================================================
    'Yahtzee Form On Load Subroutine
    'Subroutine:    FrmYahtzee_Load
    'Programmer:    Ryan Isaacson / Github: Munchinator6354 
    'Updated:       December 07, 2020
    'Description:   Determines what happens when the Yahtzee Form is loaded.
    '================================================================================================================
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

        'Establishing values for the button array to iterate through later
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

        'This block of code makes the initially loaded dice on game start not clickable
        If intCurrentRollCount = 3 Then
            For i = 0 To BtnArray.Length - 1
                BtnArray(i).Enabled = False
            Next
        End If
    End Sub

    '================================================================================================================
    'Roll The Dice Button Click Subroutine
    'Subroutines:   BtnRollTheDice_Click
    'Programmer:    Ryan Isaacson / Github: Munchinator6354 
    'Updated:       December 07, 2020
    'Description:   Handles the clciking of the Roll The Dice Button including Round Counter and  Dice Values.
    '================================================================================================================
    Public Sub BtnRollTheDice_Click(sender As Object, e As EventArgs) Handles BtnRollTheDice.Click
        'Decreases the remaining dice rolls by 1
        intCurrentRollCount -= 1

        'Makes the dice clickable again as long as the intCurrentRollCount is less than or equal to 2
        If intCurrentRollCount <= 2 Then
            For i = 0 To BtnArray.Length - 1
                BtnArray(i).Enabled = True
            Next
        End If

        'Checks to qualify if the player has more dice rolls left
        If intCurrentRollCount >= 0 Then

            'Displays the current roll count to the screen
            lblRollCounter.Text = "You have " & intCurrentRollCount & " rolls remaining"

            'This block of code will check if a dice has been held/kept. If it has not been kept, it will reroll the dice.
            For i = 0 To blnKeptDiceArray.Length - 1
                If blnKeptDiceArray(i) = False Then
                    intDieValueArr(i) = GenerateRandomDiceNum(rand)
                    BtnArray(i).BackgroundImage = imgDiceImagesArr(intDieValueArr(i) - 1)
                End If
            Next

            'This block of code changes the appearence of each die button depending on it's dice value
            'For i = 0 To intDieValueArr.Length - 1
            'If intDieValueArr(i) = 1 Then
            'BtnArray(i).BackgroundImage = Image.FromFile("..\Images\dice1.jpg")
            'ElseIf intDieValueArr(i) = 2 Then
            'BtnArray(i).BackgroundImage = Image.FromFile("..\Images\dice2.jpg")
            'ElseIf intDieValueArr(i) = 3 Then
            'BtnArray(i).BackgroundImage = Image.FromFile("..\Images\dice3.jpg")
            'ElseIf intDieValueArr(i) = 4 Then
            'BtnArray(i).BackgroundImage = Image.FromFile("..\Images\dice4.jpg")
            'ElseIf intDieValueArr(i) = 5 Then
            'BtnArray(i).BackgroundImage = Image.FromFile("..\Images\dice5.jpg")
            'ElseIf intDieValueArr(i) = 6 Then
            'BtnArray(i).BackgroundImage = Image.FromFile("..\Images\dice6.jpg")
            'End If
            'Next

            'This block of code executes when the current roll count is 0. It converts all dice to being held/kept, and then adds them into a total score variable.
            'Then it presents the total to the screen to the player and displays a message box to the player in case they didn't see the text.
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
    'Dice Click Subroutines
    'Subroutines:   BtnDice1_Click, BtnDice2_Click, BtnDice3_Click, BtnDice4_Click, BtnDice5_Click
    'Programmer:    Ryan Isaacson / Github: Munchinator6354 
    'Updated:       December 07, 2020
    'Description:   Changes the appearance of dice when clicked and whether or not they are added as kept/held dice.
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

    '================================================================================================================
    'Functions Available to Call
    'Function:      GenerateRandomDiceNum & IncreaseRollCount
    'Programmer:    Ryan Isaacson / Github: Munchinator6354 
    'Updated:       December 07, 2020
    'Description:   GenerateRandomDiceNum generates a random number from 1-6 
    '               Increase Roll Count increases the intRollCounter by 1
    '================================================================================================================
    Public Function GenerateRandomDiceNum(random As Random) As Integer
        Dim intDieValue As Integer = random.Next(1, 7)
        Return intDieValue
    End Function

    Public Function IncreaseRollCount(currentRollCount As Integer) As Integer
        Dim intRollCounter As Integer
        intRollCounter += currentRollCount
    End Function

    '================================================================================================================
    'Restart and Exit Game
    'Subroutines:   Restart Game Button & Exit Program Button
    'Programmer:    Ryan Isaacson / Github: Munchinator6354 
    'Updated:       December 07, 2020
    'Description:   BtnRestartGame_Click clears all controls, reinitializes all components, reloads controls, and reloads the form.
    '               BtnExit_Click, simply exits the program.
    '================================================================================================================
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