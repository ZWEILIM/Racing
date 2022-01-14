<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.Car = New System.Windows.Forms.PictureBox()
        Me.LeftMover = New System.Windows.Forms.Timer(Me.components)
        Me.RightMover = New System.Windows.Forms.Timer(Me.components)
        Me.EnemyCar1 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar2 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar3 = New System.Windows.Forms.PictureBox()
        Me.Enemy1Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy2Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy3Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Ending = New System.Windows.Forms.Label()
        Me.Score_text = New System.Windows.Forms.Label()
        Me.Restart = New System.Windows.Forms.Button()
        Me.Speed_Text = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(51, -16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 80)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(149, -16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 80)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(51, 95)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 80)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(149, 95)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 80)
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(51, 193)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 80)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(149, 193)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 80)
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Location = New System.Drawing.Point(51, 291)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 80)
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Location = New System.Drawing.Point(149, 291)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 80)
        Me.PictureBox8.TabIndex = 1
        Me.PictureBox8.TabStop = False
        '
        'RoadMover
        '
        Me.RoadMover.Enabled = True
        Me.RoadMover.Interval = 10
        '
        'Car
        '
        Me.Car.Image = CType(resources.GetObject("Car.Image"), System.Drawing.Image)
        Me.Car.Location = New System.Drawing.Point(92, 274)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(37, 67)
        Me.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Car.TabIndex = 2
        Me.Car.TabStop = False
        '
        'LeftMover
        '
        Me.LeftMover.Interval = 10
        '
        'RightMover
        '
        Me.RightMover.Interval = 10
        '
        'EnemyCar1
        '
        Me.EnemyCar1.Image = CType(resources.GetObject("EnemyCar1.Image"), System.Drawing.Image)
        Me.EnemyCar1.Location = New System.Drawing.Point(8, 133)
        Me.EnemyCar1.Name = "EnemyCar1"
        Me.EnemyCar1.Size = New System.Drawing.Size(37, 67)
        Me.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar1.TabIndex = 3
        Me.EnemyCar1.TabStop = False
        '
        'EnemyCar2
        '
        Me.EnemyCar2.Image = CType(resources.GetObject("EnemyCar2.Image"), System.Drawing.Image)
        Me.EnemyCar2.Location = New System.Drawing.Point(122, -16)
        Me.EnemyCar2.Name = "EnemyCar2"
        Me.EnemyCar2.Size = New System.Drawing.Size(37, 67)
        Me.EnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar2.TabIndex = 4
        Me.EnemyCar2.TabStop = False
        '
        'EnemyCar3
        '
        Me.EnemyCar3.Image = CType(resources.GetObject("EnemyCar3.Image"), System.Drawing.Image)
        Me.EnemyCar3.Location = New System.Drawing.Point(173, 45)
        Me.EnemyCar3.Name = "EnemyCar3"
        Me.EnemyCar3.Size = New System.Drawing.Size(37, 67)
        Me.EnemyCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar3.TabIndex = 5
        Me.EnemyCar3.TabStop = False
        '
        'Enemy1Mover
        '
        Me.Enemy1Mover.Enabled = True
        Me.Enemy1Mover.Interval = 10
        '
        'Enemy2Mover
        '
        Me.Enemy2Mover.Enabled = True
        Me.Enemy2Mover.Interval = 10
        '
        'Enemy3Mover
        '
        Me.Enemy3Mover.Enabled = True
        Me.Enemy3Mover.Interval = 10
        '
        'Ending
        '
        Me.Ending.AutoSize = True
        Me.Ending.BackColor = System.Drawing.Color.White
        Me.Ending.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ending.ForeColor = System.Drawing.Color.Red
        Me.Ending.Location = New System.Drawing.Point(14, 54)
        Me.Ending.Name = "Ending"
        Me.Ending.Size = New System.Drawing.Size(196, 38)
        Me.Ending.TabIndex = 6
        Me.Ending.Text = "Game Over"
        Me.Ending.Visible = False
        '
        'Score_text
        '
        Me.Score_text.AutoSize = True
        Me.Score_text.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Score_text.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Score_text.Location = New System.Drawing.Point(5, 9)
        Me.Score_text.Name = "Score_text"
        Me.Score_text.Size = New System.Drawing.Size(16, 17)
        Me.Score_text.TabIndex = 7
        Me.Score_text.Text = "0"
        '
        'Restart
        '
        Me.Restart.BackColor = System.Drawing.Color.White
        Me.Restart.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Restart.ForeColor = System.Drawing.Color.Red
        Me.Restart.Location = New System.Drawing.Point(68, 150)
        Me.Restart.Name = "Restart"
        Me.Restart.Size = New System.Drawing.Size(75, 37)
        Me.Restart.TabIndex = 8
        Me.Restart.Text = "Restart"
        Me.Restart.UseVisualStyleBackColor = False
        Me.Restart.Visible = False
        '
        'Speed_Text
        '
        Me.Speed_Text.AutoSize = True
        Me.Speed_Text.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Speed_Text.Location = New System.Drawing.Point(162, 9)
        Me.Speed_Text.Name = "Speed_Text"
        Me.Speed_Text.Size = New System.Drawing.Size(61, 17)
        Me.Speed_Text.TabIndex = 9
        Me.Speed_Text.Text = "Speed 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(222, 353)
        Me.Controls.Add(Me.Speed_Text)
        Me.Controls.Add(Me.Restart)
        Me.Controls.Add(Me.Score_text)
        Me.Controls.Add(Me.Ending)
        Me.Controls.Add(Me.EnemyCar3)
        Me.Controls.Add(Me.EnemyCar2)
        Me.Controls.Add(Me.EnemyCar1)
        Me.Controls.Add(Me.Car)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(240, 400)
        Me.MinimumSize = New System.Drawing.Size(240, 400)
        Me.Name = "Form1"
        Me.Text = "RacingGame"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents Car As PictureBox
    Friend WithEvents LeftMover As Timer
    Friend WithEvents RightMover As Timer
    Friend WithEvents EnemyCar1 As PictureBox
    Friend WithEvents EnemyCar2 As PictureBox
    Friend WithEvents EnemyCar3 As PictureBox
    Friend WithEvents Enemy1Mover As Timer
    Friend WithEvents Enemy2Mover As Timer
    Friend WithEvents Enemy3Mover As Timer
    Friend WithEvents Ending As Label
    Friend WithEvents Score_text As Label
    Friend WithEvents Restart As Button
    Friend WithEvents Speed_Text As Label
End Class
