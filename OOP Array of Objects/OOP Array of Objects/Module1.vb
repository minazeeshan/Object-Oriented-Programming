Module Module1

    Sub Main()
        Dim MyID As Integer
        Dim MyName As String

        'Array of objects
        Dim AllStudents(0 To 3) As Person

        'input data into array
        For index = 0 To 3
            Console.WriteLine("enter ID and Name")
            MyID = Console.ReadLine()
            MyName = Console.ReadLine()
            AllStudents(index) = New Person(MyID, MyName)
        Next

        'setters
        AllStudents(2).SetName("Tina")
        AllStudents(2).SetID(123)

        'getters
        For i = 0 To 3
            Console.WriteLine(AllStudents(i).GetName)
            Console.WriteLine(AllStudents(i).GetID)
        Next
        Console.ReadKey()
    End Sub

    Class Person
        Private ID As Integer    'attributes
        Private Name As String

        Public Sub New(ByRef I As Integer, ByRef N As String) 'constructor
            ID = I
            Name = N
        End Sub

        Public Sub SetName(ByVal N) 'setter - name
            Name = N
        End Sub

        Public Function GetName() As String 'getter - name
            Return (Name)
        End Function

        Public Sub SetID(ByVal I) 'setter ID
            ID = I
        End Sub

        Public Function GetID() As Integer 'getter ID
            Return (ID)
        End Function
    End Class

End Module
