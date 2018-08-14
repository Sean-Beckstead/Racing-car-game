<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.PbxRedCar = New System.Windows.Forms.PictureBox
        Me.PbxYellowCar = New System.Windows.Forms.PictureBox
        Me.PbxSilverCar = New System.Windows.Forms.PictureBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        CType(Me.PbxRedCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxYellowCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxSilverCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pick your car"
        '
        'PbxRedCar
        '
        Me.PbxRedCar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PbxRedCar.Image = Global.Racing_car_game.My.Resources.Resources.car31
        Me.PbxRedCar.Location = New System.Drawing.Point(12, 64)
        Me.PbxRedCar.Name = "PbxRedCar"
        Me.PbxRedCar.Size = New System.Drawing.Size(63, 42)
        Me.PbxRedCar.TabIndex = 1
        Me.PbxRedCar.TabStop = False
        '
        'PbxYellowCar
        '
        Me.PbxYellowCar.Image = Global.Racing_car_game.My.Resources.Resources.car21
        Me.PbxYellowCar.Location = New System.Drawing.Point(12, 132)
        Me.PbxYellowCar.Name = "PbxYellowCar"
        Me.PbxYellowCar.Size = New System.Drawing.Size(63, 45)
        Me.PbxYellowCar.TabIndex = 2
        Me.PbxYellowCar.TabStop = False
        '
        'PbxSilverCar
        '
        Me.PbxSilverCar.Image = Global.Racing_car_game.My.Resources.Resources.car11
        Me.PbxSilverCar.Location = New System.Drawing.Point(12, 202)
        Me.PbxSilverCar.Name = "PbxSilverCar"
        Me.PbxSilverCar.Size = New System.Drawing.Size(63, 34)
        Me.PbxSilverCar.TabIndex = 3
        Me.PbxSilverCar.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"  Speed" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "     Difficulty", "", "-----------------------------------------------------", "       3" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "   Advanced", "-----------------------------------------------------", "", "-----------------------------------------------------", "       2  " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & " Intermediate", "-----------------------------------------------------", "", "-----------------------------------------------------", "       1                                     Beginner", "-----------------------------------------------------"})
        Me.ListBox1.Location = New System.Drawing.Point(81, 31)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(218, 228)
        Me.ListBox1.TabIndex = 4
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(311, 266)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PbxSilverCar)
        Me.Controls.Add(Me.PbxYellowCar)
        Me.Controls.Add(Me.PbxRedCar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "mainform"
        Me.Text = "mainform"
        CType(Me.PbxRedCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxYellowCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxSilverCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PbxRedCar As System.Windows.Forms.PictureBox
    Friend WithEvents PbxYellowCar As System.Windows.Forms.PictureBox
    Friend WithEvents PbxSilverCar As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
