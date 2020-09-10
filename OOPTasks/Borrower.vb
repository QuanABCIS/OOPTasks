Public Class Borrower
    Private BorrowerName As String
    Private EmailAddress As String
    Private BorrowerID As Integer
    Private ItemsOnLoan As Integer

    Public Sub New(ByVal b As String, ByVal e As String, ByVal i As Integer)
        ItemsOnLoan = 0
        BorrowerName = b
        EmailAddress = e
        BorrowerID = i
    End Sub

    Public Function GetBorrowerName()
        Return BorrowerName
    End Function

    Public Function GetEmailAddress()
        Return EmailAddress
    End Function

    Public Function GetBorrowerID()
        Return BorrowerID
    End Function

    Public Function GetItemsOnLoan()
        Return ItemsOnLoan
    End Function

    Public Sub UpdateItemsOnLoan(ByVal i As Integer)
        ItemsOnLoan = i
    End Sub

    Public Sub PrintDetails()
        Console.WriteLine(BorrowerName & "; " & EmailAddress & "; " & BorrowerID & "; " & ItemsOnLoan)
    End Sub

End Class
