Public Class Form1
    Dim WithEvents CS As New CoinSlot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.insertnickel()
        Label1.Text = CS.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.insertdime()
        Label1.Text = CS.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.insertquarter()
        Label1.Text = CS.total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.insertdollar()
        Label1.Text = CS.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.coinreturn()
        Label1.Text = CS.total.ToString("c2")
    End Sub

    Private Sub CS_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles CS.coinreturnevent
        If q > 0 Then
            QuarterPictureBox.Visible = True
        Else
            QuarterPictureBox.Visible = False
        End If
        If d > 0 Then
            DollarPictureBox.Visible = True
        Else
            DollarPictureBox.Visible = False
        End If
        If di > 0 Then
            DimePictureBox.Visible = True
        Else
            DimePictureBox.Visible = False
        End If
        If n > 0 Then
            NickelPictureBox.Visible = True
        Else
            NickelPictureBox.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        Select Case IDTextBox.Text
            Case ProductControl1.ProductID
                CS.buy(ProductControl1)
            Case ProductControl2.ProductID
                CS.buy(ProductControl2)
            Case ProductControl3.ProductID
                CS.buy(ProductControl3)
            Case ProductControl4.ProductID
                CS.buy(ProductControl4)
            Case ProductControl5.ProductID
                CS.buy(ProductControl5)
            Case ProductControl6.ProductID
                CS.buy(ProductControl6)
            Case ProductControl7.ProductID
                CS.buy(ProductControl7)
            Case ProductControl8.ProductID
                CS.buy(ProductControl8)
            Case ProductControl9.ProductID
                CS.buy(ProductControl9)
            Case ProductControl10.ProductID
                CS.buy(ProductControl10)
            Case ProductControl11.ProductID
                CS.buy(ProductControl11)
            Case ProductControl12.ProductID
                CS.buy(ProductControl12)
            Case ProductControl13.ProductID
                CS.buy(ProductControl13)
            Case ProductControl14.ProductID
                CS.buy(ProductControl14)
            Case ProductControl15.ProductID
                CS.buy(ProductControl15)
            Case ProductControl16.ProductID
                CS.buy(ProductControl16)
        End Select
        Label1.Text = CS.total.ToString("c2")
    End Sub

    Private Sub ProductControl1_DispenseProduct(p As Image) Handles ProductControl1.DispenseProduct, ProductControl2.DispenseProduct, ProductControl3.DispenseProduct, ProductControl4.DispenseProduct, ProductControl5.DispenseProduct, ProductControl6.DispenseProduct, ProductControl7.DispenseProduct, ProductControl8.DispenseProduct, ProductControl9.DispenseProduct, ProductControl10.DispenseProduct, ProductControl11.DispenseProduct, ProductControl12.DispenseProduct, ProductControl13.DispenseProduct, ProductControl14.DispenseProduct, ProductControl15.DispenseProduct, ProductControl16.DispenseProduct
        ProductPicturebox.Image = p
    End Sub
End Class
