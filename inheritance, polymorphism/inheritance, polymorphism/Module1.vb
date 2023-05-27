Module Module1
    Sub Main()
        Dim Title, Author As String
        Dim ItemId As Integer

        Console.WriteLine("Enter Tile, Author, ItemId")
        Title = Console.ReadLine()
        Author = Console.ReadLine()
        ItemId = Console.ReadLine()

        Dim ThisBook As New Book(True, Title, Author, ItemId)
        ThisBook.PrintDetails()
        Console.WriteLine("Updated print details")
        ThisBook.borrowing()
        ThisBook.PrintDetails()
        Console.ReadKey()
    End Sub
    Class LibraryItem
        Private Title As String
        Private Author As String
        Private ItemID As Integer
        Private OnLoan As Boolean = False
        Private DueDate As Date = #8/2/2024#
        Private IssueDate As Date = Today
        Public Sub New(ByVal t As String, ByVal a As String, ByVal i As Integer)    'constructor
            Title = t
            Author = a
            ItemID = i
        End Sub
        Public Sub borrowing()
            OnLoan = True
            DueDate = DateAdd(DateInterval.Day, 21, Today()) 'date is 21 days from today 
        End Sub
        Public Function GetTitle()
            Return (Title)
        End Function
        Public Function GetAuthor()
            Return (Author)
        End Function
        Public Function GetItemID()
            Return (ItemID)
        End Function
        Public Function GetOnLoan()
            Return (OnLoan)
        End Function
        Public Function GetDueDate()
            Return (DueDate)
        End Function
        Public Function GetIssueDate()
            Return (IssueDate)
        End Function
        Overridable Sub PrintDetails()
            Console.WriteLine(Title & ";" & Author & ";" & ItemID & ";" & OnLoan & ";" & DueDate & ";" & IssueDate)    'polymorphism
        End Sub
    End Class
    Class Book
        Inherits LibraryItem                                                                                           'inheritance
        Private isRequested As Boolean
        Public Sub New(ByVal R As Boolean, ByVal t As String, ByVal a As String, ByVal i As Integer)
            MyBase.New(t, a, i)                                                                                        'inheritance 
            isRequested = R
        End Sub
        Public Sub SetIsRequested(ByVal inputIsReq As Boolean)
            isRequested = inputIsReq
        End Sub
        Public Function GetIsRequested()
            Return (isRequested)
        End Function
        Public Overrides Sub PrintDetails()                                                                            'polymorphism
            MyBase.PrintDetails()
            Console.WriteLine(";" & isRequested)

        End Sub
    End Class


End Module
