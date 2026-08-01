Imports System.Reflection.Metadata
Imports System.Windows.Controls
Imports System.Windows.Media
Imports System.Windows.Shapes
Imports System.Windows.Threading

Class MainWindow
    ' Game Physics & Speed
    Private ballSpeedX As Integer = 5
    Private ballSpeedY As Integer = -5
    Private paddleSpeed As Integer = 20

    ' Game State
    Private score As Integer = 0
    Private gameover As Boolean = False
    Private gameTimer As DispatcherTimer

    ' This runs automatically when your game window opens
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        ' Set up the game loop timer (60 FPS)
        gameTimer = New DispatcherTimer()
        gameTimer.Interval = TimeSpan.FromMilliseconds(16)
        AddHandler gameTimer.Tick, AddressOf Gameloop
        gameTimer.Start()

        ' Ensure your game window can capture keyboard controls
        Me.Focus()
    End Sub

    ' The Core Game Loop (Runs 60 times per second)
    Private Sub Gameloop(sender As Object, e As EventArgs)
        If gameover Then Exit Sub

        ' Move the ball
        Dim currentTop As Double = Canvas.GetTop(ball)
        Dim currentLeft As Double = Canvas.GetLeft(ball)

        Canvas.SetTop(ball, currentTop + ballSpeedY)
        Canvas.SetLeft(ball, currentLeft + ballSpeedX)

        ' Wall Collisions
        If Canvas.GetLeft(ball) <= 0 OrElse (Canvas.GetLeft(ball) + ball.Width) >= GameCanvas.ActualWidth Then
            ballSpeedX = -ballSpeedX
        End If

        If Canvas.GetTop(ball) <= 0 Then
            ballSpeedY = -ballSpeedY
        End If

        ' Bottom wall collision (Game Over)
        If (Canvas.GetTop(ball) + ball.Height) >= GameCanvas.ActualHeight Then
            gameTimer.Stop()
            gameover = True
            MessageBox.Show("Game Over! Your Score: " & score)
        End If

        ' Paddle Collision
        Dim ballRect As New Rect(Canvas.GetLeft(ball), Canvas.GetTop(ball), ball.Width, ball.Height)
        Dim paddleRect As New Rect(Canvas.GetLeft(paddle), Canvas.GetTop(paddle), paddle.Width, paddle.Height)

        If ballRect.IntersectsWith(paddleRect) Then
            Canvas.SetTop(ball, Canvas.GetTop(paddle) - ball.Height)
            ballSpeedY = -ballSpeedY
        End If
    End Sub

    ' Handles Paddle Keyboard Controls (Left and Right arrows)
    Private Sub MainWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If gameover Then Exit Sub

        Dim paddleLeft As Double = Canvas.GetLeft(paddle)

        If e.Key = Key.Left AndAlso paddleLeft > 0 Then
            Canvas.SetLeft(paddle, paddleLeft - paddleSpeed)
        ElseIf e.Key = Key.Right AndAlso (paddleLeft + paddle.Width) < GameCanvas.ActualWidth Then
            Canvas.SetLeft(paddle, paddleLeft + paddleSpeed)
        End If
    End Sub
End Class