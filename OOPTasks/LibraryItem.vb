Public Class LibraryItem
    Friend Title As String
    Friend Author_Artist As String
    Friend ItemID As Integer
    Friend OnLoan As Boolean = False
    Friend DueDate As Date = Today
    Friend BorrowerID As Integer

    Public Sub New(ByVal t As String, ByVal a As String, ByVal i As Integer)
        Title = t
        Author_Artist = a
        ItemID = i
    End Sub

    Public Function GetTitle() As String
        Return Title
    End Function

    Public Function GetAuthorArtist() As String
        Return Author_Artist
    End Function

    Public Function GetID() As Integer
        Return ItemID
    End Function
    Public Function GetOnLoant() As Boolean
        Return OnLoan
    End Function
    Public Function GetDueDate() As Date
        Return DueDate
    End Function

    Public Sub Borrowing(ByVal bID As Integer, ByRef borrowerArray() As Borrower)
        OnLoan = True
        BorrowerID = bID
        borrowerArray(BorrowerID).UpdateItemsOnLoan(borrowerArray(BorrowerID).GetItemsOnLoan + 1)
    End Sub

    Public Sub Returning(ByRef borrowerArray() As Borrower)
        OnLoan = False
        borrowerArray(BorrowerID).UpdateItemsOnLoan(borrowerArray(BorrowerID).GetItemsOnLoan - 1)
        BorrowerID = Nothing
    End Sub

    Public Overridable Sub PrintDetails()
        Console.WriteLine(Title & "; " & ItemID & "; " & OnLoan & "; " & DueDate)
    End Sub

End Class
