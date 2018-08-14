<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarFrm
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
        Me.components = New System.ComponentModel.Container
        Me.Car = New System.Windows.Forms.PictureBox
        Me.Tree5 = New System.Windows.Forms.PictureBox
        Me.Tree2 = New System.Windows.Forms.PictureBox
        Me.LblScore = New System.Windows.Forms.Label
        Me.LblClock = New System.Windows.Forms.Label
        Me.lblComments = New System.Windows.Forms.Label
        Me.RoadBlock1 = New System.Windows.Forms.PictureBox
        Me.RoadBlock2 = New System.Windows.Forms.PictureBox
        Me.roadblock3 = New System.Windows.Forms.PictureBox
        Me.Tree1 = New System.Windows.Forms.PictureBox
        Me.Tree3 = New System.Windows.Forms.PictureBox
        Me.tree4 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.clock = New System.Windows.Forms.Timer(Me.components)
        Me.Scoreclock = New System.Windows.Forms.Timer(Me.components)
        Me.TimerComment = New System.Windows.Forms.Timer(Me.components)
        Me.Background = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnNewCar = New System.Windows.Forms.Button
        Me.BtnControls = New System.Windows.Forms.Button
        Me.btnHighscore = New System.Windows.Forms.Button
        CType(Me.Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tree5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tree2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoadBlock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoadBlock2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roadblock3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tree1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tree3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tree4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Car
        '
        Me.Car.BackColor = System.Drawing.Color.Transparent
        Me.Car.Image = Global.Racing_car_game.My.Resources.Resources.car11
        Me.Car.Location = New System.Drawing.Point(303, 176)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(64, 32)
        Me.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Car.TabIndex = 15
        Me.Car.TabStop = False
        '
        'Tree5
        '
        Me.Tree5.Image = Global.Racing_car_game.My.Resources.Resources.tree
        Me.Tree5.Location = New System.Drawing.Point(258, 331)
        Me.Tree5.Name = "Tree5"
        Me.Tree5.Size = New System.Drawing.Size(37, 34)
        Me.Tree5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Tree5.TabIndex = 20
        Me.Tree5.TabStop = False
        '
        'Tree2
        '
        Me.Tree2.Image = Global.Racing_car_game.My.Resources.Resources.tree
        Me.Tree2.Location = New System.Drawing.Point(74, 2)
        Me.Tree2.Name = "Tree2"
        Me.Tree2.Size = New System.Drawing.Size(37, 34)
        Me.Tree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Tree2.TabIndex = 19
        Me.Tree2.TabStop = False
        '
        'LblScore
        '
        Me.LblScore.AutoSize = True
        Me.LblScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScore.Location = New System.Drawing.Point(386, 176)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(51, 20)
        Me.LblScore.TabIndex = 17
        Me.LblScore.Text = "Score"
        '
        'LblClock
        '
        Me.LblClock.AutoSize = True
        Me.LblClock.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClock.Location = New System.Drawing.Point(394, 144)
        Me.LblClock.Name = "LblClock"
        Me.LblClock.Size = New System.Drawing.Size(43, 20)
        Me.LblClock.TabIndex = 16
        Me.LblClock.Text = "Time"
        '
        'lblComments
        '
        Me.lblComments.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblComments.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblComments.Location = New System.Drawing.Point(0, 364)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(443, 57)
        Me.lblComments.TabIndex = 18
        '
        'RoadBlock1
        '
        Me.RoadBlock1.Image = Global.Racing_car_game.My.Resources.Resources.car11
        Me.RoadBlock1.Location = New System.Drawing.Point(-202, 91)
        Me.RoadBlock1.Name = "RoadBlock1"
        Me.RoadBlock1.Size = New System.Drawing.Size(64, 32)
        Me.RoadBlock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.RoadBlock1.TabIndex = 21
        Me.RoadBlock1.TabStop = False
        '
        'RoadBlock2
        '
        Me.RoadBlock2.Image = Global.Racing_car_game.My.Resources.Resources.car31
        Me.RoadBlock2.Location = New System.Drawing.Point(-303, 252)
        Me.RoadBlock2.Name = "RoadBlock2"
        Me.RoadBlock2.Size = New System.Drawing.Size(63, 44)
        Me.RoadBlock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.RoadBlock2.TabIndex = 22
        Me.RoadBlock2.TabStop = False
        '
        'roadblock3
        '
        Me.roadblock3.Image = Global.Racing_car_game.My.Resources.Resources.car41
        Me.roadblock3.Location = New System.Drawing.Point(450, 176)
        Me.roadblock3.Name = "roadblock3"
        Me.roadblock3.Size = New System.Drawing.Size(77, 38)
        Me.roadblock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.roadblock3.TabIndex = 23
        Me.roadblock3.TabStop = False
        '
        'Tree1
        '
        Me.Tree1.Image = Global.Racing_car_game.My.Resources.Resources.tree
        Me.Tree1.Location = New System.Drawing.Point(137, 34)
        Me.Tree1.Name = "Tree1"
        Me.Tree1.Size = New System.Drawing.Size(37, 34)
        Me.Tree1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Tree1.TabIndex = 24
        Me.Tree1.TabStop = False
        '
        'Tree3
        '
        Me.Tree3.Image = Global.Racing_car_game.My.Resources.Resources.tree
        Me.Tree3.Location = New System.Drawing.Point(163, 320)
        Me.Tree3.Name = "Tree3"
        Me.Tree3.Size = New System.Drawing.Size(37, 34)
        Me.Tree3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Tree3.TabIndex = 25
        Me.Tree3.TabStop = False
        '
        'tree4
        '
        Me.tree4.Image = Global.Racing_car_game.My.Resources.Resources.tree
        Me.tree4.Location = New System.Drawing.Point(194, 2)
        Me.tree4.Name = "tree4"
        Me.tree4.Size = New System.Drawing.Size(37, 34)
        Me.tree4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.tree4.TabIndex = 26
        Me.tree4.TabStop = False
        '
        'Timer1
        '
        '
        'clock
        '
        '
        'Scoreclock
        '
        '
        'TimerComment
        '
        '
        'Background
        '
        Me.Background.Image = Global.Racing_car_game.My.Resources.Resources.road1
        Me.Background.Location = New System.Drawing.Point(0, 0)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(380, 388)
        Me.Background.TabIndex = 27
        Me.Background.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(373, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 365)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'BtnNewCar
        '
        Me.BtnNewCar.Location = New System.Drawing.Point(373, 70)
        Me.BtnNewCar.Name = "BtnNewCar"
        Me.BtnNewCar.Size = New System.Drawing.Size(70, 59)
        Me.BtnNewCar.TabIndex = 29
        Me.BtnNewCar.Text = "New Car"
        Me.BtnNewCar.UseVisualStyleBackColor = True
        '
        'BtnControls
        '
        Me.BtnControls.Location = New System.Drawing.Point(373, 5)
        Me.BtnControls.Name = "BtnControls"
        Me.BtnControls.Size = New System.Drawing.Size(70, 59)
        Me.BtnControls.TabIndex = 30
        Me.BtnControls.Text = "Controls"
        Me.BtnControls.UseVisualStyleBackColor = True
        '
        'btnHighscore
        '
        Me.btnHighscore.Location = New System.Drawing.Point(373, 259)
        Me.btnHighscore.Name = "btnHighscore"
        Me.btnHighscore.Size = New System.Drawing.Size(70, 59)
        Me.btnHighscore.TabIndex = 32
        Me.btnHighscore.Text = "Highscores"
        Me.btnHighscore.UseVisualStyleBackColor = True
        '
        'CarFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Racing_car_game.My.Resources.Resources.road1
        Me.ClientSize = New System.Drawing.Size(443, 421)
        Me.Controls.Add(Me.btnHighscore)
        Me.Controls.Add(Me.LblScore)
        Me.Controls.Add(Me.LblClock)
        Me.Controls.Add(Me.BtnControls)
        Me.Controls.Add(Me.BtnNewCar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tree4)
        Me.Controls.Add(Me.Tree3)
        Me.Controls.Add(Me.Tree1)
        Me.Controls.Add(Me.roadblock3)
        Me.Controls.Add(Me.RoadBlock2)
        Me.Controls.Add(Me.RoadBlock1)
        Me.Controls.Add(Me.Car)
        Me.Controls.Add(Me.Tree5)
        Me.Controls.Add(Me.Tree2)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.Background)
        Me.KeyPreview = True
        Me.Name = "CarFrm"
        Me.Text = "SilverCar"
        CType(Me.Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tree5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tree2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoadBlock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoadBlock2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roadblock3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tree1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tree3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tree4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Car As System.Windows.Forms.PictureBox
    Friend WithEvents Tree5 As System.Windows.Forms.PictureBox
    Friend WithEvents Tree2 As System.Windows.Forms.PictureBox
    Friend WithEvents LblScore As System.Windows.Forms.Label
    Friend WithEvents LblClock As System.Windows.Forms.Label
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents RoadBlock1 As System.Windows.Forms.PictureBox
    Friend WithEvents RoadBlock2 As System.Windows.Forms.PictureBox
    Friend WithEvents roadblock3 As System.Windows.Forms.PictureBox
    Friend WithEvents Tree1 As System.Windows.Forms.PictureBox
    Friend WithEvents Tree3 As System.Windows.Forms.PictureBox
    Friend WithEvents tree4 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents clock As System.Windows.Forms.Timer
    Friend WithEvents Scoreclock As System.Windows.Forms.Timer
    Friend WithEvents TimerComment As System.Windows.Forms.Timer
    Friend WithEvents Background As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnNewCar As System.Windows.Forms.Button
    Friend WithEvents BtnControls As System.Windows.Forms.Button
    Friend WithEvents btnHighscore As System.Windows.Forms.Button
End Class
