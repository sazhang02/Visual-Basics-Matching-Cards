Public Class Form2
    'Samantha Zhang
    Shared myForm1 As New Form1
    Dim int1 As Integer
    Dim int2 As Integer
    Dim intboard(23) As Integer
    Dim intloop As Integer
    Dim intpoints As Integer
    Dim intwrong As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pic1.Image = Image.FromFile("BackCard.jpg")
        Pic2.Image = Image.FromFile("BackCard.jpg")
        Pic3.Image = Image.FromFile("BackCard.jpg")
        Pic4.Image = Image.FromFile("BackCard.jpg")
        Pic5.Image = Image.FromFile("BackCard.jpg")
        Pic6.Image = Image.FromFile("BackCard.jpg")
        Pic7.Image = Image.FromFile("BackCard.jpg")
        Pic8.Image = Image.FromFile("BackCard.jpg")
        Pic9.Image = Image.FromFile("BackCard.jpg")
        Pic10.Image = Image.FromFile("BackCard.jpg")
        Pic11.Image = Image.FromFile("BackCard.jpg")
        Pic12.Image = Image.FromFile("BackCard.jpg")
        Pic13.Image = Image.FromFile("BackCard.jpg")
        Pic14.Image = Image.FromFile("BackCard.jpg")
        Pic15.Image = Image.FromFile("BackCard.jpg")
        Pic16.Image = Image.FromFile("BackCard.jpg")
        Pic17.Image = Image.FromFile("BackCard.jpg")
        Pic18.Image = Image.FromFile("BackCard.jpg")
        Pic19.Image = Image.FromFile("BackCard.jpg")
        Pic20.Image = Image.FromFile("BackCard.jpg")
        Pic21.Image = Image.FromFile("BackCard.jpg")
        Pic22.Image = Image.FromFile("BackCard.jpg")
        Pic23.Image = Image.FromFile("BackCard.jpg")
        Pic24.Image = Image.FromFile("BackCard.jpg")
        'Loads in the picture boxes as the back of card (Backcard.jpg is the same picture).



        Randomize()

        For intloop = 0 To 23
            intboard(intloop) = 0

        Next intloop
        'The for-loop resets the intboard array to 0 before the array is filled (Eliminates problem of keeping the same array after the reset button is clicked)

        For intloop = 1 To 12
            Do
                int1 = Int(Rnd() * 24)
            Loop While (intboard(int1) <> 0)
            intboard(int1) = intloop

            Do
                int2 = Int(Rnd() * 24)
            Loop While intboard(int2) <> 0
            intboard(int2) = intloop

        Next intloop
        'The for-loop assigns a # from 1-12 (the intloop aka "placement #s") in pairs to two places(int1 and int2) in the intboard array



        'Dummy listbox

        'For intloop = 0 To 23
        'lstTest.Items.Add(intloop & vbTab & intboard(intloop))

        'Next intloop

        'The for-loop loops 24 times, adding the card # and picture # for each loop into a dummy listbox with the answers (Used to check code And accuracy of picture placement).

    End Sub

    Private Sub Pic_Click(sender As Object, e As EventArgs) Handles Pic1.Click, Pic2.Click, Pic3.Click, Pic4.Click, Pic5.Click, Pic6.Click, Pic7.Click, Pic8.Click, Pic9.Click, Pic10.Click, Pic11.Click, Pic12.Click, Pic13.Click, Pic14.Click, Pic15.Click, Pic16.Click, Pic17.Click, Pic18.Click, Pic19.Click, Pic20.Click, Pic21.Click, Pic22.Click, Pic23.Click, Pic24.Click
        Dim PicClicked As PictureBox = sender
        Dim IntClicked = Val(PicClicked.Tag) - 1
        Static intCount As Integer
        Static intOld As Integer
        Static picOld As PictureBox


        intCount = intCount + 1
        'Counter to determine how may cards have been clicked
        Call ShowPic(PicClicked, IntClicked)
        'Calls the sub procedure ShowPic to show the correct picture
        If intCount = 1 Then
            intOld = IntClicked
            picOld = PicClicked
            'First card is clicked: the tag (intclicked is saved into intold) and the picturebox (picclicked is saved into picold)
        Else
            intCount = 0
            'The Second card is clicked and the counter is reset to work for the next time a card is clicked
            If intboard(IntClicked) = intboard(intOld) And IntClicked <> intOld Then
                MessageBox.Show("Match!")
                picOld.Enabled = False
                PicClicked.Enabled = False
                intpoints = intpoints + 1
                'This if statement plays if the first card is the same picture as the second card(the array # is the same)
                'Since this is a match, the message box informs the player, the point counter is increased by 1 (next card is the second card), and the pictures are disabled so the player can't click/match on them anymore
            ElseIf IntClicked = intOld Then
                MessageBox.Show("Pick a different card")
                intCount = 1
                'If the same card is clicked it, a message box informs the player to choose a different card since it cannot match with the same card. The counter is set so the next card clicked is the second card (reset it back as if the first card has just been clicked)
            Else
                MessageBox.Show("Not a match")
                PicClicked.Image = Image.FromFile("BackCard.jpg")
                picOld.Image = Image.FromFile("backcard.jpg")
                intwrong = intwrong + 1
                Lblwrong.Text = "Wrong: " & intwrong
                'Cards don't match
                'The card is flipped to its backside and the wrong counter increased by one
            End If

        End If



        If intpoints = 12 Then
            MessageBox.Show("Winner")
            'Once the point counter reaches 12 (12 matches/most matches possible) it informs the player that they won
        End If

    End Sub
    Sub ShowPic(ByRef pic As PictureBox, ByVal int As Integer)
        If (intboard(int) = 1) Then
            pic.Image = Image.FromFile("dogmatch1.jpg")
        ElseIf (intboard(int) = 2) Then
            pic.Image = Image.FromFile("dogmatch2.jpg")
        ElseIf (intboard(int) = 3) Then
            pic.Image = Image.FromFile("dogmatch3.jpg")
        ElseIf (intboard(int) = 4) Then
            pic.Image = Image.FromFile("dogmatch4.jpg")
        ElseIf (intboard(int) = 5) Then
            pic.Image = Image.FromFile("dogmatch5.jpg")
        ElseIf (intboard(int) = 6) Then
            pic.Image = Image.FromFile("dogmatch6.jpg")
        ElseIf (intboard(int) = 7) Then
            pic.Image = Image.FromFile("dogmatch7.jpg")
        ElseIf (intboard(int) = 8) Then
            pic.Image = Image.FromFile("dogmatch8.jpg")
        ElseIf (intboard(int) = 9) Then
            pic.Image = Image.FromFile("dogmatch9.jpg")
        ElseIf (intboard(int) = 10) Then
            pic.Image = Image.FromFile("dogmatch10.jpg")
        ElseIf (intboard(int) = 11) Then
            pic.Image = Image.FromFile("dogmatch11.jpg")
        ElseIf (intboard(int) = 12) Then
            pic.Image = Image.FromFile("dogmatch12.jpg")
            'The card picture is pulled out to be revealed when a player flips a card

        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        'Resets everything 
        int1 = 0
        int2 = 0
        intloop = 0
        intpoints = 0
        intwrong = 0
        Lblwrong.Text = "Wrong: "

        'For intloop = 0 To 23
        'lstTest.Items.Clear()
        'Next intloop
        'Clears dummy listbox

        Pic1.Enabled = True
        Pic2.Enabled = True
        Pic3.Enabled = True
        Pic4.Enabled = True
        Pic5.Enabled = True
        Pic6.Enabled = True
        Pic7.Enabled = True
        Pic8.Enabled = True
        Pic9.Enabled = True
        Pic10.Enabled = True
        Pic11.Enabled = True
        Pic12.Enabled = True
        Pic13.Enabled = True
        Pic14.Enabled = True
        Pic15.Enabled = True
        Pic16.Enabled = True
        Pic17.Enabled = True
        Pic18.Enabled = True
        Pic19.Enabled = True
        Pic20.Enabled = True
        Pic21.Enabled = True
        Pic22.Enabled = True
        Pic23.Enabled = True
        Pic24.Enabled = True
        'All cards are enabled so they can be matched again

        Call Form2_Load(sender, e)
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
        'Ends application
    End Sub
End Class