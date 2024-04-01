Imports System.Windows
Public Class Form1
    Dim total As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalLabel.Text = 524.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        totalLabel.Text = 810.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        totalLabel.Text = 1182.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button5.Visible = True
        Button6.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        totalLabel.Text = total + 82.61.ToString("c2")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button8.Visible = True
        Button9.Visible = True
        Button10.Visible = True
        Button11.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        totalLabel.Text = total + 10.23
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        totalLabel.Text = total + 82.61
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        totalLabel.Text = total + 93.04
    End Sub

    Private Sub totalLabel_Click(sender As Object, e As EventArgs) Handles totalLabel.Click
        totalLabel.Text = total.ToString("c2")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Button15.Visible = True
        Button14.Visible = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Button17.Visible = True
        Button16.Visible = True
    End Sub
End Class