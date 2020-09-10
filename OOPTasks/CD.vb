Public Class CD
    Inherits LibraryItem
    Private Genre As String
    Public Sub New(ByVal t As String, ByVal a As String, ByVal i As Integer)
        MyBase.New(t, a, i)
    End Sub

    Public Sub SetGenre(ByVal g As String)
        Genre = g
    End Sub

    Public Function GetGenre()
        Return Genre
    End Function

    Public Overrides Sub PrintDetails()
        Console.WriteLine(Title & "; " & ItemID & "; " & OnLoan & "; " & DueDate & "; " & Genre)
    End Sub

End Class
