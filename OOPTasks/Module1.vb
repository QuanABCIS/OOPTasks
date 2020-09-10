Module Module1

    Sub Main()
        Dim books(9) As Book
        Dim CDs(9) As CD
        Dim borrowers(9) As Borrower
        Dim numberOfBooks As Integer = 0
        Dim numberOfCDs As Integer = 0
        Dim numberOfBorrowers As Integer = 0

        books(0) = New Book("Title", "Author", numberOfBooks)
        borrowers(0) = New Borrower("Quan", "email@email.com", numberOfBorrowers)

        books(0).Borrowing(0, borrowers)
        borrowers(0).PrintDetails()
        books(0).Returning(borrowers)
        borrowers(0).PrintDetails()

    End Sub

End Module
