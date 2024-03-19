Public Class Mover
    Public Property speed As Integer = 10
    Public Property interval As Integer = 500
    Public Property sprite As PictureBox
    Dim xDir As Integer = 1
    Dim yDir As Integer = 0
    Private Sub Mover_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = interval
        Timer1.Enabled = True
        If Not sprite Is Nothing Then
            sprite.Left = Me.Left
            sprite.Top = Me.Top
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not sprite Is Nothing Then
            sprite.Left += xDir * speed
            sprite.Top += yDir * speed
            If sprite.Left > Me.Left + Me.Width And xDir = 1 Then
                xDir = 0
                yDir = 1
            End If
            If sprite.Left < Me.Left And xDir = -1 Then
                xDir = 0
                yDir = -1
            End If
            If sprite.Top > Me.Top + Me.Height And yDir = 1 Then
                yDir = 0
                xDir = -1
            End If
            If sprite.Top < Me.Top And yDir = -1 Then
                yDir = 0
                xDir = 1
            End If
        End If
    End Sub
End Class
