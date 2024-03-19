Public Class frm2dplatformer
    Dim movespeed As Integer = 10
    Dim isjumping As Boolean
    Dim score As Integer
    Dim coins As Integer

    Private Sub frm2dplatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isjumping = True
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        PicPlayer.Left += movespeed
    End Sub

    Private Sub frm2dplatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isjumping = False
        End Select
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        PicPlayer.Left -= movespeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        PicPlayer.Top -= movespeed
    End Sub

    Private Sub frm2dplatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If PicPlayer.Bounds.IntersectsWith(PicAir.Bounds) Then
            If isjumping = False Then
                tmrGravity.Start()
            End If
        ElseIf PicPlayer.Bounds.IntersectsWith(picground.bounds) Then
            tmrGravity.Stop()
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "Bound" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
            End If
        Next
        For Each c As Control In Me.Controls
            If c.Tag = "coin" Then
                If c.Visible And PicPlayer.Bounds.IntersectsWith(c.Bounds) Then
                    c.Visible = False
                    coins += 1
                    ScoreLabel.Text = coins
                End If
            End If
        Next
    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        PicPlayer.Top += movespeed
    End Sub

    Private Sub ScoreLabel_Click(sender As Object, e As EventArgs) Handles ScoreLabel.Click
        score = score + 1
        ScoreLabel.Text = score
    End Sub
End Class
