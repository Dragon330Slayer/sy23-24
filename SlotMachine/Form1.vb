Public Class Form1
    Dim WithEvents CS As New CoinSlot
    Private Sub SpinButton(sender As Object, e As EventArgs) Handles SpinnerButton.Click
        ReelControl1.Spin()
        ReelControl2.Spin()
        ReelControl3.Spin()
        Label2.Text = ReelControl1.itemValue
        Label3.Text = ReelControl2.itemValue
        Label4.Text = ReelControl3.itemValue

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = ReelControl1.itemValue
        Label3.Text = ReelControl2.itemValue
        Label4.Text = ReelControl3.itemValue
        Timer1.Enabled = True
        Timer1.Enabled = False
    End Sub
End Class
