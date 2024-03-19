Public Class Spin
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Timer1.Enabled = Not Timer1.Enabled
    End Sub
    Public Sub spin()
        Dim Rand As New Random
        Dim r As Integer
        r = Rand.Next(ImageList1.Images.Count)
        PictureBox1.Image = ImageList1.Images(r)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        spin()
    End Sub
End Class
