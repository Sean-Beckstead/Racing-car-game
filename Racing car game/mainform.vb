Imports System.IO

Public Class mainform

    Private Sub PbxSilverCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxSilverCar.Click
        CarFrm.Car.Image = My.Resources.car11
        CarFrm.turnspeed = 10
        CarFrm.movespeed = 8
        CarFrm.Show()
        Me.Hide()
    End Sub

    Private Sub PbxYellowCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxYellowCar.Click
        CarFrm.Car.Image = My.Resources.car21
        CarFrm.turnspeed = 11
        CarFrm.movespeed = 11
        CarFrm.Show()
        Me.Hide()
    End Sub

    Private Sub PbxRedCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxRedCar.Click
        CarFrm.Car.Image = My.Resources.car31
        CarFrm.turnspeed = 10
        CarFrm.movespeed = 14
        CarFrm.Show()
        Me.Hide()
    End Sub

    Private Sub mainform_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub mainform_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Checktextfile()

        setscores()

    End Sub

    Sub setscores()

        Dim fs As New FileStream(highscoreForm.filename, FileMode.Open, FileAccess.ReadWrite)
        Dim textfile As New StreamReader(fs)

        Do While textfile.Peek > -1

            CarFrm.highscorename = textfile.ReadLine
            CarFrm.highscore = textfile.ReadLine
            CarFrm.highscorename2 = textfile.ReadLine
            CarFrm.highscore2 = textfile.ReadLine
            CarFrm.highscorename3 = textfile.ReadLine
            CarFrm.highscore3 = textfile.ReadLine
            CarFrm.highscorename4 = textfile.ReadLine
            CarFrm.highscore4 = textfile.ReadLine
            CarFrm.highscorename5 = textfile.ReadLine
            CarFrm.highscore5 = textfile.ReadLine
        Loop
        textfile.Close()
        fs.Close()


    End Sub

    Sub add_defaults()
        Dim fs As New FileStream(highscoreForm.filename, FileMode.Append, FileAccess.Write)
        Dim textfile As New StreamWriter(fs)

        textfile.WriteLine("")
        textfile.WriteLine("0")
        textfile.WriteLine("")
        textfile.WriteLine("0")
        textfile.WriteLine("")
        textfile.WriteLine("0")
        textfile.WriteLine("")
        textfile.WriteLine("0")
        textfile.WriteLine("")
        textfile.WriteLine("0")

        textfile.Close()
        fs.Close()

    End Sub

    Sub Checktextfile()
        Dim fs As New FileStream(highscoreForm.filename, FileMode.Open, FileAccess.Read)
        Dim textfile As New StreamReader(fs)

        If textfile.ReadToEnd = "" Then
            textfile.Close()
            fs.Close()

            add_defaults()
        End If
        textfile.Close()
        fs.Close()

    End Sub
End Class