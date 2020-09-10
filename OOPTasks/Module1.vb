Module Module1

    Sub Main()
        Dim books(9) As Book
        Dim CDs(9) As CD
        Dim borrowers(9) As Borrower
        Dim userInput As Integer
        Dim endInput As Boolean = False
        Dim numberOfBooks As Integer = 0
        Dim numberOfCDs As Integer = 0
        Dim numberOfBorrowers As Integer = 0

        Do
            Console.WriteLine("1 - Add a new borrower")
            Console.WriteLine("2 - Add a new book")
            Console.WriteLine("3 - Add a new CD")
            Console.WriteLine("4 - Borrow a book")
            Console.WriteLine("5 - Return a book")
            Console.WriteLine("6 - Borrow a CD")
            Console.WriteLine("7 - Return a CD")
            Console.WriteLine("8 - Request a book")
            Console.WriteLine("9 - Print all details")
            Console.WriteLine("99 - Exit")

            userInput = Console.ReadLine

            Select Case userInput
                Case 1
                    Console.WriteLine("Enter borrower's name:")
                    Dim name As String = Console.ReadLine
                    Console.WriteLine("Enter email")
                    Dim email As String = Console.ReadLine
                    borrowers(numberOfBorrowers) = New Borrower(name, email, numberOfBorrowers)
                    numberOfBorrowers += 1
                Case 2
                    Console.WriteLine("Enter Title")
                    Dim title As String = Console.ReadLine
                    Console.WriteLine("Enter author")
                    Dim author As String = Console.ReadLine
                    books(numberOfBooks) = New Book(title, author, numberOfBooks)
                    numberOfBooks += 1
                Case 3
                    Console.WriteLine("Enter Title")
                    Dim title As String = Console.ReadLine
                    Console.WriteLine("Enter artist")
                    Dim artist As String = Console.ReadLine
                    books(numberOfCDs) = New Book(title, artist, numberOfCDs)
                    numberOfCDs += 1
                Case 4
                    Console.WriteLine("Enter book ID")
                    Dim bookID As Integer = Console.ReadLine
                    Console.WriteLine("Enter borrower ID")
                    Dim borrowerID As Integer = Console.ReadLine
                    books(bookID).Borrowing(borrowerID, borrowers)
                Case 5
                    Console.WriteLine("Enter book ID")
                    Dim bookID As Integer = Console.ReadLine
                    books(bookID).Returning(borrowers)
                Case 6
                    Console.WriteLine("Enter CD ID")
                    Dim CDID As Integer = Console.ReadLine
                    Console.WriteLine("Enter borrower ID")
                    Dim borrowerID As Integer = Console.ReadLine
                    CDs(CDID).Borrowing(borrowerID, borrowers)
                Case 7
                    Console.WriteLine("Enter CD ID")
                    Dim CDID As Integer = Console.ReadLine
                    CDs(CDID).Returning(borrowers)
                Case 8
                    Console.WriteLine("Enter Book ID")
                    Dim BookID As Integer = Console.ReadLine
                    Console.WriteLine("Enter requester ID")
                    Dim requesterID As Integer = Console.ReadLine
                    books(BookID).RequestBook(requesterID)
                Case 9
                    Dim i As Integer = 0
                    While IsNothing(books(i)) Or i > 9
                        books(i).PrintDetails()
                        i += 1
                    End While
                    i = 0
                    While IsNothing(CDs(i)) Or i > 9
                        CDs(i).PrintDetails()
                        i += 1
                    End While
                    i = 0
                    While IsNothing(borrowers(i)) Or i > 9
                        borrowers(i).PrintDetails()
                        i += 1
                    End While
                Case Else
                    endInput = True

            End Select
        Loop Until endInput
    End Sub

End Module
