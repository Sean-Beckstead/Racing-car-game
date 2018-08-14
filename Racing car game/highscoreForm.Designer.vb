<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class highscoreForm
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
        Me.LstHighScores = New System.Windows.Forms.ListBox
        Me.BtnNewGame = New System.Windows.Forms.Button
        Me.BtnResumeGame = New System.Windows.Forms.Button
        Me.UpdateTmr = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LstHighScores
        '
        Me.LstHighScores.Dock = System.Windows.Forms.DockStyle.Top
        Me.LstHighScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstHighScores.FormattingEnabled = True
        Me.LstHighScores.ItemHeight = 24
        Me.LstHighScores.Location = New System.Drawing.Point(0, 0)
        Me.LstHighScores.Name = "LstHighScores"
        Me.LstHighScores.Size = New System.Drawing.Size(472, 316)
        Me.LstHighScores.TabIndex = 0
        '
        'BtnNewGame
        '
        Me.BtnNewGame.Location = New System.Drawing.Point(0, 314)
        Me.BtnNewGame.Name = "BtnNewGame"
        Me.BtnNewGame.Size = New System.Drawing.Size(116, 53)
        Me.BtnNewGame.TabIndex = 1
        Me.BtnNewGame.Text = "New Game"
        Me.BtnNewGame.UseVisualStyleBackColor = True
        '
        'BtnResumeGame
        '
        Me.BtnResumeGame.Location = New System.Drawing.Point(360, 314)
        Me.BtnResumeGame.Name = "BtnResumeGame"
        Me.BtnResumeGame.Size = New System.Drawing.Size(112, 53)
        Me.BtnResumeGame.TabIndex = 2
        Me.BtnResumeGame.Text = "Resume Game"
        Me.BtnResumeGame.UseVisualStyleBackColor = True
        '
        'UpdateTmr
        '
        '
        'highscoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(472, 364)
        Me.Controls.Add(Me.BtnResumeGame)
        Me.Controls.Add(Me.BtnNewGame)
        Me.Controls.Add(Me.LstHighScores)
        Me.Name = "highscoreForm"
        Me.Text = "highscoreForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LstHighScores As System.Windows.Forms.ListBox
    Friend WithEvents BtnNewGame As System.Windows.Forms.Button
    Friend WithEvents BtnResumeGame As System.Windows.Forms.Button
    Friend WithEvents UpdateTmr As System.Windows.Forms.Timer
End Class
