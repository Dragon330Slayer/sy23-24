Public Class ClickerControl
    Public Property increment As Integer = 1
    Dim a As New Clicker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a.increment = increment
        a.click()
        TextBox1.Text = a.Count
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a.Reset()
        TextBox1.Text = a.Count
    End Sub
End Class
