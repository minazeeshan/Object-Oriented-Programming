Module Module1

    Sub Main()
        Dim Stu1 As Object              'one way
        Stu1 = New Person(212, "Jack")

        Dim Stu2 As Object = New Person(123, "Harry") 'another way


        'setters
        Stu1.SetName("John")
        Stu2.SetName("Jerry")

        Stu1.SetID(111)

        'getters
        Console.WriteLine(Stu1.GetName())
        Console.WriteLine(Stu2.GetName())

        Console.WriteLine(Stu1.GetID())
        Console.WriteLine(Stu2.GetID())


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

        Public Function GetName() As String 'getter name
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
