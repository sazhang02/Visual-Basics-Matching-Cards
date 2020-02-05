Public Class Form1
    'Samantha Zhang
    Shared myForm2 As New Form2
    Private myForm1 As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrAnimation.Enabled = True
        'The animation should be playing when the application begins
    End Sub

    Private Sub TmrAnimation_Tick(sender As Object, e As EventArgs) Handles TmrAnimation.Tick
        Dim strarray(9) As String
        Static intcount As Integer
        strarray(0) = "doge1.bmp"
        strarray(1) = "doge2.bmp"
        strarray(2) = "doge3.bmp"
        strarray(3) = "doge4.bmp"
        strarray(4) = "doge5.bmp"
        strarray(5) = "doge6.bmp"
        strarray(6) = "doge7.bmp"
        strarray(7) = "doge8.bmp"
        strarray(8) = "doge9.bmp"
        strarray(9) = "doge10.bmp"
        'Pictures for the animation are set into the array

        PicMem.Image = Image.FromFile(strarray(intcount))
        'Picture box is set to array at an incount #

        If intcount = 9 Then
            intcount = 0
        Else
            intcount = intcount + 1
        End If
        'intcount increases by one so each picture is shown in the animation. It resets once doge10.bmp is played
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Me.Hide()
        myForm2.Show()
        'Hides Form 1 and then shows Form 2

    End Sub

End Class
