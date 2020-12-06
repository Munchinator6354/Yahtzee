Option Strict On
Option Explicit On
'Program:       Yahtzee
'               Final Project  - Yahtzee Game (Alternative)
'Programmers:   Ryan Isaacson / Github:Munchinator6354 & Kenneth Young
'Updated:       December 11, 2020
'Description    This program will allow the user to play the classic game Yahtzee. The player will
'               roll 5 dice up to a maximum of 3 times. The user can keep dice from rolling again
'               by changing it's border to green. If the border is red, the dice will roll again.

Public Class FrmYahtzee
    Public Sub FrmYahtzee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This creates an array to hold dice images
        Dim imgDiceImagesArr(5) As Image

        'This creates an array to hold integer values for the dice
        Dim intDieValueArr() As Integer = {6, 6, 6, 6, 6}

        'This creates an array to hold kept dice values when turned green
        Dim intKeptDiceValuesArr(4) As Integer

        'This adds a dice image to each index of imgDiceArr(5)
        imgDiceImagesArr(0) = Image.FromFile("..\Images\dice1.jpg")
        imgDiceImagesArr(1) = Image.FromFile("..\Images\dice2.jpg")
        imgDiceImagesArr(2) = Image.FromFile("..\Images\dice3.jpg")
        imgDiceImagesArr(3) = Image.FromFile("..\Images\dice4.jpg")
        imgDiceImagesArr(4) = Image.FromFile("..\Images\dice5.jpg")
        imgDiceImagesArr(5) = Image.FromFile("..\Images\dice6.jpg")

        'This code block sets up how the 1st die looks
        'First it sets the button style to the Flatstyle
        BtnDice1.FlatStyle = FlatStyle.Flat
        'Second it sets the buttons Flatstyle BorderColor to Red
        BtnDice1.FlatAppearance.BorderColor = Color.Red
        'Third it sets the button's BackgroundImage to desired Array Index
        BtnDice1.BackgroundImage = imgDiceImagesArr(5)
        'Last it sets the BackgroundImageLayout to Stretch to take up the whole button
        BtnDice1.BackgroundImageLayout = ImageLayout.Stretch

        'This code block sets up how the 2nd die looks
        BtnDice2.FlatStyle = FlatStyle.Flat
        BtnDice2.FlatAppearance.BorderColor = Color.Red
        BtnDice2.BackgroundImage = imgDiceImagesArr(5)
        BtnDice2.BackgroundImageLayout = ImageLayout.Stretch

        'This code block sets up how the 3rd die looks
        BtnDice3.FlatStyle = FlatStyle.Flat
        BtnDice3.FlatAppearance.BorderColor = Color.Red
        BtnDice3.BackgroundImage = imgDiceImagesArr(5)
        BtnDice3.BackgroundImageLayout = ImageLayout.Stretch

        'This code block sets up how the 4th die looks
        BtnDice4.FlatStyle = FlatStyle.Flat
        BtnDice4.FlatAppearance.BorderColor = Color.Red
        BtnDice4.BackgroundImage = imgDiceImagesArr(5)
        BtnDice4.BackgroundImageLayout = ImageLayout.Stretch

        'This code block sets up how the 5th die looks
        BtnDice5.FlatStyle = FlatStyle.Flat
        BtnDice5.FlatAppearance.BorderColor = Color.Red
        BtnDice5.BackgroundImage = imgDiceImagesArr(5)
        BtnDice5.BackgroundImageLayout = ImageLayout.Stretch
    End Sub



    Public Sub BtnRollTheDice_Click(sender As Object, e As EventArgs) Handles BtnRollTheDice.Click
        Dim rand As New Random
        Dim intDieValueArr(4) As Integer
        intDieValueArr(0) = GenerateRandomDiceNum(rand)
        intDieValueArr(1) = GenerateRandomDiceNum(rand)
        intDieValueArr(2) = GenerateRandomDiceNum(rand)
        intDieValueArr(3) = GenerateRandomDiceNum(rand)
        intDieValueArr(4) = GenerateRandomDiceNum(rand)

        'This block will change the picture of die 1 based on the value of it inside intDieValueArr()
        If intDieValueArr(0) = 1 Then
            BtnDice1.BackgroundImage = Image.FromFile("..\Images\dice1.jpg")
        ElseIf intDieValueArr(0) = 2 Then
            BtnDice1.BackgroundImage = Image.FromFile("..\Images\dice2.jpg")
        ElseIf intDieValueArr(0) = 3 Then
            BtnDice1.BackgroundImage = Image.FromFile("..\Images\dice3.jpg")
        ElseIf intDieValueArr(0) = 4 Then
            BtnDice1.BackgroundImage = Image.FromFile("..\Images\dice4.jpg")
        ElseIf intDieValueArr(0) = 5 Then
            BtnDice1.BackgroundImage = Image.FromFile("..\Images\dice5.jpg")
        ElseIf intDieValueArr(0) = 6 Then
            BtnDice1.BackgroundImage = Image.FromFile("..\Images\dice6.jpg")
        End If

        'This block will change the picture of die 2 based on the value of it inside intDieValueArr()
        If intDieValueArr(1) = 1 Then
            BtnDice2.BackgroundImage = Image.FromFile("..\Images\dice1.jpg")
        ElseIf intDieValueArr(1) = 2 Then
            BtnDice2.BackgroundImage = Image.FromFile("..\Images\dice2.jpg")
        ElseIf intDieValueArr(1) = 3 Then
            BtnDice2.BackgroundImage = Image.FromFile("..\Images\dice3.jpg")
        ElseIf intDieValueArr(1) = 4 Then
            BtnDice2.BackgroundImage = Image.FromFile("..\Images\dice4.jpg")
        ElseIf intDieValueArr(1) = 5 Then
            BtnDice2.BackgroundImage = Image.FromFile("..\Images\dice5.jpg")
        ElseIf intDieValueArr(1) = 6 Then
            BtnDice2.BackgroundImage = Image.FromFile("..\Images\dice6.jpg")
        End If

        'This block will change the picture of die 3 based on the value of it inside intDieValueArr()
        If intDieValueArr(2) = 1 Then
            BtnDice3.BackgroundImage = Image.FromFile("..\Images\dice1.jpg")
        ElseIf intDieValueArr(1) = 2 Then
            BtnDice3.BackgroundImage = Image.FromFile("..\Images\dice2.jpg")
        ElseIf intDieValueArr(1) = 3 Then
            BtnDice3.BackgroundImage = Image.FromFile("..\Images\dice3.jpg")
        ElseIf intDieValueArr(1) = 4 Then
            BtnDice3.BackgroundImage = Image.FromFile("..\Images\dice4.jpg")
        ElseIf intDieValueArr(1) = 5 Then
            BtnDice3.BackgroundImage = Image.FromFile("..\Images\dice5.jpg")
        ElseIf intDieValueArr(1) = 6 Then
            BtnDice3.BackgroundImage = Image.FromFile("..\Images\dice6.jpg")
        End If

        'This block will change the picture of die 4 based on the value of it inside intDieValueArr()
        If intDieValueArr(3) = 1 Then
            BtnDice4.BackgroundImage = Image.FromFile("..\Images\dice1.jpg")
        ElseIf intDieValueArr(1) = 2 Then
            BtnDice4.BackgroundImage = Image.FromFile("..\Images\dice2.jpg")
        ElseIf intDieValueArr(1) = 3 Then
            BtnDice4.BackgroundImage = Image.FromFile("..\Images\dice3.jpg")
        ElseIf intDieValueArr(1) = 4 Then
            BtnDice4.BackgroundImage = Image.FromFile("..\Images\dice4.jpg")
        ElseIf intDieValueArr(1) = 5 Then
            BtnDice4.BackgroundImage = Image.FromFile("..\Images\dice5.jpg")
        ElseIf intDieValueArr(1) = 6 Then
            BtnDice4.BackgroundImage = Image.FromFile("..\Images\dice6.jpg")
        End If

        'This block will change the picture of die 5 based on the value of it inside intDieValueArr()
        If intDieValueArr(4) = 1 Then
            BtnDice5.BackgroundImage = Image.FromFile("..\Images\dice1.jpg")
        ElseIf intDieValueArr(1) = 2 Then
            BtnDice5.BackgroundImage = Image.FromFile("..\Images\dice2.jpg")
        ElseIf intDieValueArr(1) = 3 Then
            BtnDice5.BackgroundImage = Image.FromFile("..\Images\dice3.jpg")
        ElseIf intDieValueArr(1) = 4 Then
            BtnDice5.BackgroundImage = Image.FromFile("..\Images\dice4.jpg")
        ElseIf intDieValueArr(1) = 5 Then
            BtnDice5.BackgroundImage = Image.FromFile("..\Images\dice5.jpg")
        ElseIf intDieValueArr(1) = 6 Then
            BtnDice5.BackgroundImage = Image.FromFile("..\Images\dice6.jpg")
        End If

        System.Diagnostics.Debug.WriteLine(intDieValueArr(0) & " " & intDieValueArr(1) & " " & intDieValueArr(2) & " " & intDieValueArr(3) & " " & intDieValueArr(4))



        'If BtnDice1.FlatAppearance.BorderColor = Color.Green Then

        'End If
        'if true, kept, if false ready to roll
        ' Dim blnKeptDiceArr() As Boolean {False, False, False, False, False}
        'Dim intDiceNumbersArr(4) As Integer


        'intVar1 = GenerateRandomDieNum(blnKeptDice(i))

        'System.Diagnostics.Debug.Write(intVar2 & " intVar2 ")

        'Loop through the intDieNumbers array and give each index(die) a random number
        'For i = 0 To intDice.Length - 1
        'intVar1 = GenerateRandomDieNum()



        'picComputerPicture.Image = Image.FromFile("..\Images\dwayneJohnsonRock.jpg")







        'Next

        'For each die, give it it's own random number, from 1-6



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



    'Dim intDieValue As Integer
    'Dim rand As New Random
    'intDieValue = rand.Next(1, 7)
    'Return intDieValue
    'End Function




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


    'Creates a New Random object in memory
    'Dim rand As New Random

    'Generates new random integer from 1-6 inside intDieValue
    'intDieValue = rand.Next(1, 7)

    'End If





    'Puts intDie
    'Next

    'System.Diagnostics.Debug.WriteLine(blnKeptDiceArray + "blnKeptDiceArray")






    'Returns intRandomDieSide, a random integer from 1-6
    'Return intRandomDieSide()
    'End Function


    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub


End Class

