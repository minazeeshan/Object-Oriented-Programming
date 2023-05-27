Module Module1

    Sub Main()
        Dim myCourse As New course
        myCourse.AddAssessment("programming", 100)
        Console.ReadKey()
    End Sub
    Class Assessment
        Private assessmentTitle As String
        Private MaxMarks As Integer
        Public Sub Create(ByVal t As String, ByVal m As Integer)             'containment 
            assessmentTitle = t
            MaxMarks = m
        End Sub
    End Class
    Class course
        Private CourseAssessment As Assessment                               'containment:one class contains objects of another class
        Public Sub AddAssessment(ByVal t As String, ByVal m As Integer)
            CourseAssessment.Create(t, m)                                    'object.method()
        End Sub
    End Class
End Module
