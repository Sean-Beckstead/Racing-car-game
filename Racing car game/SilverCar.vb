Imports System.IO

Public Class CarFrm
    Dim Seconds As Integer
    Dim minutes As Integer
    Public score As Integer
    Public highscorename As String
    Public highscorename2 As String
    Public highscorename3 As String
    Public highscorename4 As String
    Public highscorename5 As String
    Public highscore As Integer
    Public highscore2 As Integer
    Public highscore3 As Integer
    Public highscore4 As Integer
    Public highscore5 As Integer
    Public movespeed As Integer
    Public turnspeed As Integer


    Sub treesmove()

        'trees speed
        Tree1.Left += movespeed + 8
        Tree2.Left += movespeed + 8
        Tree3.Left += movespeed + 8
        tree4.Left += movespeed + 8
        Tree5.Left += movespeed + 8

        'reset trees
        If Tree1.Right >= Me.Width Then Tree1.Left = randnum()
        If Tree2.Right >= Me.Width Then Tree2.Left = randnum()
        If Tree3.Right >= Me.Width Then Tree3.Left = randnum()
        If tree4.Right >= Me.Width Then tree4.Left = randnum()
        If Tree5.Right >= Me.Width Then Tree5.Left = randnum()




    End Sub

    Sub RoadBlock()

        'roadblock cars speed
        RoadBlock1.Left += movespeed
        RoadBlock2.Left += movespeed

        'reset roadblock cars
        If RoadBlock1.Right >= Me.Width Then RoadBlock1.Left = randnum()
        If RoadBlock2.Right >= Me.Width Then RoadBlock2.Left = randnum()

        'Reset bad driver
        roadblock3.Left += 10
        If Seconds = 15 Then roadblock3.Left = randnum()
        If Seconds = 30 Then roadblock3.Left = randnum()
        If Seconds = 45 Then roadblock3.Left = randnum()

        'collision
        If Car.Left <= RoadBlock1.Right And Car.Top <= RoadBlock1.Bottom And Car.Bottom >= RoadBlock1.Top And Car.Right >= RoadBlock1.Right Then
            RoadBlock1.Left = randnum()
            RoadBlock2.Left = randnum()
            roadblock3.Left = 400
            Timer1.Stop()
            clock.Stop()
            Scoreclock.Stop()
            highscores()

        End If
        If Car.Left <= RoadBlock2.Right And Car.Top <= RoadBlock2.Bottom And Car.Bottom >= RoadBlock2.Top And Car.Right >= RoadBlock2.Right Then
            RoadBlock1.Left = randnum()
            RoadBlock2.Left = randnum()
            roadblock3.Left = 400
            Timer1.Stop()
            clock.Stop()
            Scoreclock.Stop()
            highscores()

        End If
        If Car.Left <= roadblock3.Right And Car.Top <= roadblock3.Bottom And Car.Bottom >= roadblock3.Top And Car.Right >= roadblock3.Right Then
            RoadBlock1.Left = randnum()
            RoadBlock2.Left = randnum()
            roadblock3.Left = 400
            Timer1.Stop()
            clock.Stop()
            Scoreclock.Stop()
            highscores()

        End If
    End Sub

    Private Sub CarFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Static Dim Move As Char
        Move = e.KeyChar

        Select Case Move
            Case "w"
                Car.Top -= turnspeed
            Case "s"
                Car.Top += turnspeed
            Case "e"
                Timer1.Start()
                clock.Start()
                Scoreclock.Start()
                TimerComment.Start()
                score = 0
                minutes = 0
                Seconds = 0
        End Select

        'car boundaries
        If Car.Top <= 0 Then Car.Top += 10
        If Car.Bottom >= Me.Height - 90 Then Car.Top -= 10
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static Dim frame As Integer
        frame += 1

        Timer1.Interval = 60

        Select Case frame
            Case 1 : Background.Image = My.Resources.road1
            Case 2 : Background.Image = My.Resources.road2
                frame = 0
            Case Else : MsgBox("oops")
        End Select
        RoadBlock()
        treesmove()
    End Sub

    Sub Clock_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles clock.Tick
        clock.Interval = 900
        clocktick()

    End Sub

    Function randnum()
        Return Int(Rnd() * -300)
    End Function

    Sub clocktick()

        'sets the clock to count
        Seconds += 1
        If Seconds = 60 Then
            minutes += 1
            Seconds = 0
        End If
        LblClock.Text = minutes & ":" & Seconds


    End Sub

    Public Sub ScoreClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Scoreclock.Tick
        Scoreclock.Interval = 800

        'speed score bonuses
        If movespeed <= 10 Then
            If Car.Top <= RoadBlock1.Bottom And Car.Bottom >= RoadBlock1.Top And Car.Right >= RoadBlock1.Right Then score += 2
        End If
        If movespeed <= 20 Then
            If Car.Top <= RoadBlock2.Bottom And Car.Bottom >= RoadBlock2.Top And Car.Right >= RoadBlock2.Right Then score += 2
        End If
        If movespeed >= 10 And movespeed <= 12 Then
            If Car.Top <= RoadBlock1.Bottom And Car.Bottom >= RoadBlock1.Top And Car.Right >= RoadBlock1.Right Then score += 5
        End If
        If movespeed >= 10 And movespeed <= 12 Then
            If Car.Top <= RoadBlock2.Bottom And Car.Bottom >= RoadBlock2.Top And Car.Right >= RoadBlock2.Right Then score += 5
        End If
        If movespeed >= 12 Then
            If Car.Top <= RoadBlock1.Bottom And Car.Bottom >= RoadBlock1.Top And Car.Right >= RoadBlock1.Right Then score += 10
        End If
        If movespeed >= 12 Then
            If Car.Top <= RoadBlock2.Bottom And Car.Bottom >= RoadBlock2.Top And Car.Right >= RoadBlock2.Right Then score += 10
        End If

        'score for going infront of traffic
        If Car.Top <= RoadBlock1.Bottom And Car.Bottom >= RoadBlock1.Top And Car.Right >= RoadBlock1.Right Then score += 10
        If Car.Top <= RoadBlock2.Bottom And Car.Bottom >= RoadBlock2.Top And Car.Right >= RoadBlock2.Right Then score += 10

        'score loss for driving on grass
        If Car.Bottom >= 320 Then score -= 6
        If Car.Top <= 75 Then score -= 6

        'Bad driver score bonus
        If roadblock3.Left >= 0 And roadblock3.Left <= Me.Width And Car.Top <= roadblock3.Bottom And Car.Bottom >= roadblock3.Top And Car.Right >= roadblock3.Right Then score += 35

        'show score
        LblScore.Text = "" & score

    End Sub

    Sub comments1()

        'on coming traffic warning
        If Car.Top <= RoadBlock1.Bottom And Car.Bottom >= RoadBlock1.Top And Car.Right >= RoadBlock1.Right Then
            lblComments.Text = "On Coming Traffic!"
        End If
        If Car.Top <= RoadBlock2.Bottom And Car.Bottom >= RoadBlock2.Top And Car.Right >= RoadBlock2.Right Then
            lblComments.Text = "On Coming Traffic!"
        End If

        'no comments 
        If Car.Top >= RoadBlock1.Bottom And Car.Bottom <= RoadBlock2.Top And Car.Right >= RoadBlock1.Right Then lblComments.Text = ""
        If Car.Top >= RoadBlock2.Bottom Then lblComments.Text = ""
        If Car.Bottom <= RoadBlock1.Top Then lblComments.Text = ""

        'bad driver comment
        If roadblock3.Left <= Me.Width Then lblComments.Text = "INCOMING BAD DRIVER"

    End Sub

    Private Sub timerComment_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerComment.Tick
        comments1()
    End Sub

    Private Sub BtnControls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnControls.Click

        'show controls
        MsgBox("E to start the game," & vbCrLf & "W to go up," & vbCrLf & "S to go up")
    End Sub

    Private Sub BtnNewCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCar.Click

        'Change cars
        RoadBlock1.Left = randnum()
        RoadBlock2.Left = randnum()
        roadblock3.Left = 400
        Timer1.Stop()
        clock.Stop()
        Scoreclock.Stop()
        mainform.Show()
        Me.Hide()
    End Sub

    Private Sub btnHighscore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHighscore.Click
        Me.Hide()
        RoadBlock1.Left = randnum()
        RoadBlock2.Left = randnum()
        roadblock3.Left = 400
        Timer1.Stop()
        clock.Stop()
        Scoreclock.Stop()
        highscoreForm.Show()
        highscoreForm.UpdateTmr.Start()
    End Sub

    Sub highscores()
        Dim fs As New FileStream(highscoreForm.filename, FileMode.Append, FileAccess.Write)
        Dim textfile As New StreamWriter(fs)

        If score >= highscore Then
            highscore5 = highscore4
            highscore4 = highscore3
            highscore3 = highscore2
            highscore2 = highscore
            highscore = score
            highscorename5 = highscorename4
            highscorename4 = highscorename3
            highscorename3 = highscorename2
            highscorename2 = highscorename
            highscorename = InputBox("name")
            textfile.WriteLine(highscorename)
            textfile.WriteLine(vbTab & Me.highscore)
            textfile.WriteLine(highscorename2)
            textfile.WriteLine(vbTab & Me.highscore2)
            textfile.WriteLine(highscorename3)
            textfile.WriteLine(vbTab & Me.highscore3)
            textfile.WriteLine(highscorename4)
            textfile.WriteLine(vbTab & Me.highscore4)
            textfile.WriteLine(highscorename5)
            textfile.WriteLine(vbTab & Me.highscore5)
        ElseIf score <= highscore And score >= highscore2 Then
            highscore5 = highscore4
            highscore4 = highscore3
            highscore3 = highscore2
            highscore2 = score
            highscorename5 = highscorename4
            highscorename4 = highscorename3
            highscorename3 = highscorename2
            highscorename2 = InputBox("Name")
            textfile.WriteLine(highscorename)
            textfile.WriteLine(vbTab & Me.highscore)
            textfile.WriteLine(highscorename2)
            textfile.WriteLine(vbTab & Me.highscore2)
            textfile.WriteLine(highscorename3)
            textfile.WriteLine(vbTab & Me.highscore3)
            textfile.WriteLine(highscorename4)
            textfile.WriteLine(vbTab & Me.highscore4)
            textfile.WriteLine(highscorename5)
            textfile.WriteLine(vbTab & Me.highscore5)
        ElseIf score <= highscore2 And score >= highscore3 Then
            highscore5 = highscore4
            highscore4 = highscore3
            highscore3 = score
            highscorename5 = highscorename4
            highscorename4 = highscorename3
            highscorename3 = InputBox("Name")
            textfile.WriteLine(highscorename)
            textfile.WriteLine(vbTab & Me.highscore)
            textfile.WriteLine(highscorename2)
            textfile.WriteLine(vbTab & Me.highscore2)
            textfile.WriteLine(highscorename3)
            textfile.WriteLine(vbTab & Me.highscore3)
            textfile.WriteLine(highscorename4)
            textfile.WriteLine(vbTab & Me.highscore4)
            textfile.WriteLine(highscorename5)
            textfile.WriteLine(vbTab & Me.highscore5)
        ElseIf score <= highscore3 And score >= highscore4 Then
            highscore5 = highscore4
            highscore4 = score
            highscorename5 = highscorename4
            highscorename4 = InputBox("Name")
            textfile.WriteLine(highscorename)
            textfile.WriteLine(vbTab & Me.highscore)
            textfile.WriteLine(highscorename2)
            textfile.WriteLine(vbTab & Me.highscore2)
            textfile.WriteLine(highscorename3)
            textfile.WriteLine(vbTab & Me.highscore3)
            textfile.WriteLine(highscorename4)
            textfile.WriteLine(vbTab & Me.highscore4)
            textfile.WriteLine(highscorename5)
            textfile.WriteLine(vbTab & Me.highscore5)
        ElseIf score <= highscore4 And score >= highscore5 Then
            highscore5 = score
            highscorename5 = InputBox("Name")
            textfile.WriteLine(highscorename)
            textfile.WriteLine(vbTab & Me.highscore)
            textfile.WriteLine(highscorename2)
            textfile.WriteLine(vbTab & Me.highscore2)
            textfile.WriteLine(highscorename3)
            textfile.WriteLine(vbTab & Me.highscore3)
            textfile.WriteLine(highscorename4)
            textfile.WriteLine(vbTab & Me.highscore4)
            textfile.WriteLine(highscorename5)
            textfile.WriteLine(vbTab & Me.highscore5)
        ElseIf score <= highscore5 Then
            textfile.WriteLine(highscorename)
            textfile.WriteLine(vbTab & Me.highscore)
            textfile.WriteLine(highscorename2)
            textfile.WriteLine(vbTab & Me.highscore2)
            textfile.WriteLine(highscorename3)
            textfile.WriteLine(vbTab & Me.highscore3)
            textfile.WriteLine(highscorename4)
            textfile.WriteLine(vbTab & Me.highscore4)
            textfile.WriteLine(highscorename5)
            textfile.WriteLine(vbTab & Me.highscore5)
        End If


        textfile.Close()
        fs.Close()
    End Sub
End Class