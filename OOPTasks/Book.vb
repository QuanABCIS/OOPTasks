Public Class Book
    Inherits LibraryItem
    Public Sub New(ByVal t As String, ByVal a As String, ByVal i As Integer)
        MyBase.New(t, a, i)
    End Sub

    Private IsRequested As Boolean
    Private RequestedBy As Integer

    Public Sub RequestBook(ByVal bID As Integer)
        RequestedBy = bID
        IsRequested = True
    End Sub

    Public Function GetIsRequested()
        Return IsRequested
    End Function

    Public Overrides Sub PrintDetails()
        Console.WriteLine(Title & "; " & ItemID & "; " & OnLoan & "; " & DueDate & "; " & IsRequested)
    End Sub

End Class
