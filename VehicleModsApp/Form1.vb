Imports System.Windows
Public Class Form1
    Dim _total As Decimal
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Label16.Text = Label16.ToString("c2")
    End Sub
End Class