Imports System.IO

Public Class highscoreForm

    Public filename As String = "Highscore.txt"


    Sub ShowFileContents()
        Dim fs As New FileStream(filename, FileMode.Open, FileAccess.Read)
        Dim textfile As New StreamReader(fs)
        Dim lineOfText As String

        Do While textfile.Peek > -1
            lineOfText = textfile.ReadLine()
            LstHighScores.Items.Add(lineOfText)

        Loop

        textfile.Close()
        fs.Close()
    End Sub

    Private Sub highscoreForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub highscoreForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ShowFileContents()
    End Sub

    Private Sub BtnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewGame.Click
        mainform.Show()
        Me.Hide()
    End Sub

    Private Sub BtnResumeGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResumeGame.Click
        CarFrm.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateTmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles UpdateTmr.Tick
        LstHighScores.Items.Clear()

        LstHighScores.Items.Add("1st  " & CarFrm.highscorename)
        LstHighScores.Items.Add(vbTab & CarFrm.highscore)
        LstHighScores.Items.Add("2nd  " & CarFrm.highscorename2)
        LstHighScores.Items.Add(vbTab & CarFrm.highscore2)
        LstHighScores.Items.Add("3rd  " & CarFrm.highscorename3)
        LstHighScores.Items.Add(vbTab & CarFrm.highscore3)
        LstHighScores.Items.Add("4th  " & CarFrm.highscorename4)
        LstHighScores.Items.Add(vbTab & CarFrm.highscore4)
        LstHighScores.Items.Add("5th  " & CarFrm.highscorename5)
        LstHighScores.Items.Add(vbTab & CarFrm.highscore5)
    End Sub
End Class