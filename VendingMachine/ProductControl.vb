﻿Public Class ProductControl
    Public Property ProductName As String
    Public Property ProductID As String
    Public Property ProductPrice As Decimal
    Public Property ProductImage As Image
    Public Property ProductCount As Integer
    Public Event DispenseProduct(p As Image)
    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = ProductImage
        IDLabel.Text = ProductID
        PriceLabel.Text = ProductPrice.ToString("c2")
    End Sub
    Public Sub Buy()
        If ProductCount > 0 Then
            ProductCount = ProductCount - 1
            RaiseEvent DispenseProduct(ProductImage)
        End If
        If ProductCount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
