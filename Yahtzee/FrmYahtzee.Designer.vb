<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmYahtzee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmYahtzee))
        Me.BtnRollTheDice = New System.Windows.Forms.Button()
        Me.BtnRestartGame = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.lblScoreCard = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.BtnDice1 = New System.Windows.Forms.Button()
        Me.BtnDice2 = New System.Windows.Forms.Button()
        Me.BtnDice3 = New System.Windows.Forms.Button()
        Me.BtnDice4 = New System.Windows.Forms.Button()
        Me.BtnDice5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picYahtzeeBanner = New System.Windows.Forms.PictureBox()
        Me.lblRollCounter = New System.Windows.Forms.Label()
        Me.lblRuleDescription = New System.Windows.Forms.Label()
        Me.lblScoreCounter = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYahtzeeBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRollTheDice
        '
        Me.BtnRollTheDice.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.BtnRollTheDice.Font = New System.Drawing.Font("Algerian", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRollTheDice.Location = New System.Drawing.Point(120, 538)
        Me.BtnRollTheDice.Name = "BtnRollTheDice"
        Me.BtnRollTheDice.Size = New System.Drawing.Size(206, 77)
        Me.BtnRollTheDice.TabIndex = 0
        Me.BtnRollTheDice.Text = "Roll The Dice"
        Me.BtnRollTheDice.UseVisualStyleBackColor = True
        '
        'BtnRestartGame
        '
        Me.BtnRestartGame.Location = New System.Drawing.Point(28, 684)
        Me.BtnRestartGame.Name = "BtnRestartGame"
        Me.BtnRestartGame.Size = New System.Drawing.Size(192, 63)
        Me.BtnRestartGame.TabIndex = 1
        Me.BtnRestartGame.Text = "Restart Game"
        Me.BtnRestartGame.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(240, 684)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(189, 63)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.Text = "Exit Program"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'lblScoreCard
        '
        Me.lblScoreCard.AutoSize = True
        Me.lblScoreCard.Font = New System.Drawing.Font("Stencil", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreCard.Location = New System.Drawing.Point(641, 37)
        Me.lblScoreCard.Name = "lblScoreCard"
        Me.lblScoreCard.Size = New System.Drawing.Size(253, 47)
        Me.lblScoreCard.TabIndex = 9
        Me.lblScoreCard.Text = "Score Card"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(56, 762)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(335, 17)
        Me.lblID.TabIndex = 11
        Me.lblID.Text = "Programmed by Ryan Isaacson and Kenneth Young"
        '
        'BtnDice1
        '
        Me.BtnDice1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDice1.ForeColor = System.Drawing.Color.Black
        Me.BtnDice1.Location = New System.Drawing.Point(109, 272)
        Me.BtnDice1.Name = "BtnDice1"
        Me.BtnDice1.Size = New System.Drawing.Size(111, 106)
        Me.BtnDice1.TabIndex = 12
        Me.BtnDice1.UseVisualStyleBackColor = True
        '
        'BtnDice2
        '
        Me.BtnDice2.Location = New System.Drawing.Point(242, 272)
        Me.BtnDice2.Name = "BtnDice2"
        Me.BtnDice2.Size = New System.Drawing.Size(111, 106)
        Me.BtnDice2.TabIndex = 13
        Me.BtnDice2.UseVisualStyleBackColor = True
        '
        'BtnDice3
        '
        Me.BtnDice3.Location = New System.Drawing.Point(41, 384)
        Me.BtnDice3.Name = "BtnDice3"
        Me.BtnDice3.Size = New System.Drawing.Size(111, 106)
        Me.BtnDice3.TabIndex = 14
        Me.BtnDice3.UseVisualStyleBackColor = True
        '
        'BtnDice4
        '
        Me.BtnDice4.Location = New System.Drawing.Point(174, 384)
        Me.BtnDice4.Name = "BtnDice4"
        Me.BtnDice4.Size = New System.Drawing.Size(111, 106)
        Me.BtnDice4.TabIndex = 15
        Me.BtnDice4.UseVisualStyleBackColor = True
        '
        'BtnDice5
        '
        Me.BtnDice5.Location = New System.Drawing.Point(305, 384)
        Me.BtnDice5.Name = "BtnDice5"
        Me.BtnDice5.Size = New System.Drawing.Size(111, 106)
        Me.BtnDice5.TabIndex = 16
        Me.BtnDice5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(492, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(570, 675)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'picYahtzeeBanner
        '
        Me.picYahtzeeBanner.Location = New System.Drawing.Point(78, 45)
        Me.picYahtzeeBanner.Name = "picYahtzeeBanner"
        Me.picYahtzeeBanner.Size = New System.Drawing.Size(313, 136)
        Me.picYahtzeeBanner.TabIndex = 18
        Me.picYahtzeeBanner.TabStop = False
        '
        'lblRollCounter
        '
        Me.lblRollCounter.AutoSize = True
        Me.lblRollCounter.Location = New System.Drawing.Point(132, 509)
        Me.lblRollCounter.Name = "lblRollCounter"
        Me.lblRollCounter.Size = New System.Drawing.Size(0, 17)
        Me.lblRollCounter.TabIndex = 19
        '
        'lblRuleDescription
        '
        Me.lblRuleDescription.AutoSize = True
        Me.lblRuleDescription.Location = New System.Drawing.Point(40, 195)
        Me.lblRuleDescription.Name = "lblRuleDescription"
        Me.lblRuleDescription.Size = New System.Drawing.Size(400, 68)
        Me.lblRuleDescription.TabIndex = 20
        Me.lblRuleDescription.Text = resources.GetString("lblRuleDescription.Text")
        Me.lblRuleDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScoreCounter
        '
        Me.lblScoreCounter.AutoSize = True
        Me.lblScoreCounter.Location = New System.Drawing.Point(93, 628)
        Me.lblScoreCounter.Name = "lblScoreCounter"
        Me.lblScoreCounter.Size = New System.Drawing.Size(247, 34)
        Me.lblScoreCounter.TabIndex = 21
        Me.lblScoreCounter.Text = "This round's score is _ " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Select a category to add this score to."
        Me.lblScoreCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmYahtzee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 788)
        Me.Controls.Add(Me.lblScoreCounter)
        Me.Controls.Add(Me.lblRuleDescription)
        Me.Controls.Add(Me.lblRollCounter)
        Me.Controls.Add(Me.picYahtzeeBanner)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnDice5)
        Me.Controls.Add(Me.BtnDice4)
        Me.Controls.Add(Me.BtnDice3)
        Me.Controls.Add(Me.BtnDice2)
        Me.Controls.Add(Me.BtnDice1)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblScoreCard)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnRestartGame)
        Me.Controls.Add(Me.BtnRollTheDice)
        Me.Name = "FrmYahtzee"
        Me.Text = "Yahtzee"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYahtzeeBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRollTheDice As Button
    Friend WithEvents BtnRestartGame As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents lblScoreCard As Label
    Friend WithEvents lblID As Label
    Friend WithEvents BtnDice1 As Button
    Friend WithEvents BtnDice2 As Button
    Friend WithEvents BtnDice3 As Button
    Friend WithEvents BtnDice4 As Button
    Friend WithEvents BtnDice5 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picYahtzeeBanner As PictureBox
    Friend WithEvents lblRollCounter As Label
    Friend WithEvents lblRuleDescription As Label
    Friend WithEvents lblScoreCounter As Label
End Class
