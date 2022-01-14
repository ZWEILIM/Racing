Public Class Form1

    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8

    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick

        For x As Integer = 0 To 7
            road(x).Top += 2
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
        If score > 5 And score < 20 Then
            speed = 5
        End If
        If score >= 20 And score < 30 Then
            speed = 8
        End If
        If score >= 30 Then
            speed = 10
        End If

        Speed_Text.Text = "Speed " & speed

        If (Car.Bounds.IntersectsWith(EnemyCar1.Bounds)) Then

            gameover()

        End If
        If (Car.Bounds.IntersectsWith(EnemyCar2.Bounds)) Then

            gameover()

        End If
        If (Car.Bounds.IntersectsWith(EnemyCar3.Bounds)) Then

            gameover()

        End If


    End Sub

    Private Sub gameover()
        Restart.Visible = True
        Ending.Visible = True
        RoadMover.Stop()
        Enemy1Mover.Stop()
        Enemy2Mover.Stop()
        Enemy3Mover.Stop()

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Right Then
            RightMover.Start()
        End If
        If e.KeyCode = Keys.Left Then
            LeftMover.Start()
        End If



    End Sub

    Private Sub LeftMover_Tick(sender As Object, e As EventArgs) Handles LeftMover.Tick

        If (Car.Location.X > 0) Then
            Car.Left -= 5
        End If

    End Sub

    Private Sub RightMover_Tick(sender As Object, e As EventArgs) Handles RightMover.Tick

        If (Car.Location.X < 139) Then
            Car.Left += 5
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        RightMover.Stop()
        LeftMover.Stop()
    End Sub

    Private Sub Enemy1Mover_Tick(sender As Object, e As EventArgs) Handles Enemy1Mover.Tick

        EnemyCar1.Top += speed / 2
        If EnemyCar1.Top >= Me.Height Then
            score += 1
            Score_text.Text = score

            EnemyCar1.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + EnemyCar1.Height)
            EnemyCar1.Left = CInt(Math.Ceiling(Rnd() * 50)) + 0
        End If

    End Sub

    Private Sub Enemy2Mover_Tick(sender As Object, e As EventArgs) Handles Enemy2Mover.Tick

        EnemyCar2.Top += speed
        If EnemyCar2.Top >= Me.Height Then
            score += 1
            Score_text.Text = score

            EnemyCar2.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + EnemyCar2.Height)
            EnemyCar2.Left = CInt(Math.Ceiling(Rnd() * 50)) + 50
        End If

    End Sub

    Private Sub Enemy3Mover_Tick(sender As Object, e As EventArgs) Handles Enemy3Mover.Tick

        EnemyCar3.Top += speed / 3 * 2
        If EnemyCar3.Top >= Me.Height Then
            score += 1
            Score_text.Text = score

            EnemyCar3.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + EnemyCar3.Height)
            EnemyCar3.Left = CInt(Math.Ceiling(Rnd() * 40)) + 99
        End If

    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click

        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)

    End Sub
End Class
