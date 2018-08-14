<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RedCar
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
        Me.Background = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RoadBlock2 = New System.Windows.Forms.PictureBox
        Me.RoadBlock1 = New System.Windows.Forms.PictureBox
        Me.Clock = New System.Windows.Forms.Timer(Me.components)
        Me.LblClock = New System.Windows.Forms.Label
        Me.LblScore = New System.Windows.Forms.Label
        Me.ScoreClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblComments = New System.Windows.Forms.Label
        Me.timerComment = New System.Windows.Forms.Timer(Me.components)
        Me.roadblock3 = New System.Windows.Forms.PictureBox
        Me.Tree1 = New System.Windows.Forms.PictureBox
        Me.Tree2 = New System.Windows.Forms.PictureBox
        Me.Tree3 = New System.Windows.Forms.PictureBox
        Me.Tree5 = New System.Windows.Forms.PictureBox
        Me.Tree4 = New System.Windows.Forms.PictureBox
        CType(Me.Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoadBlock2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoadBlock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roadblock3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tree1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tree2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tree3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tree5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tree4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Car
        '
        Me.Car.BackColor = System.Drawing.Color.Transparent
        Me.Car.Image = Global.Racing_car_game.My.Resources.Resources.car11
        Me.Car.Location = New System.Drawing.Point(303, 179)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(64, 32)
        Me.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Car.TabIndex = 0
        Me.Car.TabStop = False
        '
        'Background
        '
        Me.Background.Image = Global.Racing_car_game.My.Resources.Resources.road2
        Me.Background.Location = New System.Drawing.Point(-2, -1)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(382, 369)
        Me.Background.TabIndex = 1
        Me.Background.TabStop = False
        '
        'Timer1
        '
        '
        'RoadBlock2
        '
        Me.RoadBlock2.Image = Global.Racing_car_game.My.Resources.Resources.car31
        Me.RoadBlock2.Location = New System.Drawing.Point(-200, 239)
        Me.RoadBlock2.Name = "RoadBlock2"
        Me.RoadBlock2.Size = New System.Drawing.Size(63, 44)
        Me.RoadBlock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.RoadBlock2.TabIndex = 3
        Me.RoadBlock2.TabStop = False
        '
        'RoadBlock1
        '
        Me.RoadBlock1.Image = Global.Racing_car_game.My.Resources.Resources.car21
        Me.RoadBlock1.Location = New System.Drawing.Point(-200, 98)
        Me.RoadBlock1.Name = "RoadBlock1"
        Me.RoadBlock1.Size = New System.Drawing.Size(63, 44)
        Me.RoadBlock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.RoadBlock1.TabIndex = 4
        Me.RoadBlock1.TabStop = False
        '
        'Clock
        '
        '
        'LblClock
        '
        Me.LblClock.AutoSize = True
        Me.LblClock.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClock.Location = New System.Drawing.Point(337, 371)
        Me.LblClock.Name = "LblClock"
        Me.LblClock.Size = New System.Drawing.Size(43, 20)
        Me.LblClock.TabIndex = 6
        Me.LblClock.Text = "Time"
        '
        'LblScore
        '
        Me.LblScore.AutoSize = True
        Me.LblScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScore.Location = New System.Drawing.Point(329, 391)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(51, 20)
        Me.LblScore.TabIndex = 7
        Me.LblScore.Text = "Score"
        '
        'ScoreClock
        '
        '
        'lblComments
        '
        Me.lblComments.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblComments.Location = New System.Drawing.Point(-2, 371)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(382, 57)
        Me.lblComments.TabIndex = 8
        '
        'timerComment
        '
        '
        'roadblock3
        '
        Me.roadblock3.Image = Global.Racing_car_game.My.Resources.Resources.car41
        Me.roadblock3.Location = New System.Drawing.Point(400, 170)
        Me.roadblock3.Name = "roadblock3"
        Me.roadblock3.Size = New System.Drawing.Size(77, 38)
        Me.roadblock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.roadblock3.TabIndex = 10
        Me.roadblock3.TabStop = False
        '
        'Tree1
        '
        Me.Tree1.Image = Global.Racing_car_game.My.Resources.Resources.tree
        Me.Tree1.Location = New System.Drawing.Point(-429, 35)
        Me.Tree1.Name = "Tree1"
        Me.Tree1.Size = New System.Drawing.Size(37, 34)
        Me.Tree1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Tree1.TabIndex = 11
        Me.Tree1.TabStop = False
        '
        'Tree2
        '
        Me.Tree2.Image = Global.Racing_car_game.My.Resources.Resources.tree
        Me.Tree2.Location = New System.Drawing.Point(82, -1)
        Me.Tree2.Name = "Tree2"
        Me.Tree2.Size = New System.Drawing.Size(37, 34)
        Me.Tree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Tree2.TabIndex = 12
        Me.Tree2.TabStop = False
        '
        'Tree3
        '
        Me.Tree3.Image = Global.Racing_car_game.My.Resources.Resources.tree
        Me.Tree3.Location = New System.Drawing.Point(-172, 35)
        Me.Tree3.Name = "Tree3"
        Me.Tree3.Size = New System.Drawing.Size(37, 34)
        Me.Tree3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Tree3.TabIndex = 13
        Me.Tree3.TabStop = False
        '
        'Tree5
        '
        Me.Tree5.Image = Global.Racing_car_game.My.Resources.Resources.tree
        Me.Tree5.Location = New System.Drawing.Point(258, 334)
        Me.Tree5.Name = "Tree5"
        Me.Tree5.Size = New System.Drawing.Size(37, 34)
        Me.Tree5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Tree5.TabIndex = 14
        Me.Tree5.TabStop = False
        '
        'Tree4
        '
        Me.Tree4.Image = Global.Racing_car_game.My.Resources.Resources.tree
        Me.Tree4.Location = New System.Drawing.Point(-129, 319)
        Me.Tree4.Name = "Tree4"
        Me.Tree4.Size = New System.Drawing.Size(37, 34)
        Me.Tree4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Tree4.TabIndex = 15
        Me.Tree4.TabStop = False
        '
        'RedCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Racing_car_game.My.Resources.Resources.road1
        Me.ClientSize = New System.Drawing.Size(379, 421)
        Me.Controls.Add(Me.Car)
        Me.Controls.Add(Me.Tree4)
        Me.Controls.Add(Me.Tree5)
        Me.Controls.Add(Me.Tree3)
        Me.Controls.Add(Me.Tree2)
        Me.Controls.Add(Me.Tree1)
        Me.Controls.Add(Me.LblScore)
        Me.Controls.Add(Me.LblClock)
        Me.Controls.Add(Me.roadblock3)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.RoadBlock1)
        Me.Controls.Add(Me.RoadBlock2)
        Me.Controls.Add(Me.Background)
        Me.KeyPreview = True
        Me.Name = "RedCar"
        Me.Text = "Form1"
        CType(Me.Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoadBlock2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoadBlock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roadblock3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tree1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tree2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tree3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tree5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tree4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Car As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RoadBlock2 As System.Windows.Forms.PictureBox
    Friend WithEvents RoadBlock1 As System.Windows.Forms.PictureBox
    Friend WithEvents Background As System.Windows.Forms.PictureBox
    Friend WithEvents Clock As System.Windows.Forms.Timer
    Friend WithEvents LblClock As System.Windows.Forms.Label
    Friend WithEvents LblScore As System.Windows.Forms.Label
    Friend WithEvents ScoreClock As System.Windows.Forms.Timer
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents timerComment As System.Windows.Forms.Timer
    Friend WithEvents roadblock3 As System.Windows.Forms.PictureBox
    Friend WithEvents Tree1 As System.Windows.Forms.PictureBox
    Friend WithEvents Tree2 As System.Windows.Forms.PictureBox
    Friend WithEvents Tree3 As System.Windows.Forms.PictureBox
    Friend WithEvents Tree5 As System.Windows.Forms.PictureBox
    Friend WithEvents Tree4 As System.Windows.Forms.PictureBox

End Class
