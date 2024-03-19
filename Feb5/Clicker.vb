Public Class Clicker
    Public Property Count As Integer
    Public Property increment As Integer = 1
    Public Sub click()
        Count = Count + increment
    End Sub
    Public Sub Reset()
        Count = 0
    End Sub
End Class
