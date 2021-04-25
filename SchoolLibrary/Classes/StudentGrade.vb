Imports System.Linq.Expressions
Imports SchoolLibrary.Classes

Namespace Models
    ''' <summary>
    ''' Data Transfer Object
    ''' </summary>
    Partial Public Class StudentGrade

        Public Shared ReadOnly Property Projection() As Expression(Of Func(Of StudentGrade, StudentEntity))
            Get
                Return Function(student) New StudentEntity() With {
                        .PersonID = student.StudentID,
                        .CourseID = student.CourseID,
                        .FirstName = student.Student.FirstName,
                        .LastName = student.Student.LastName,
                        .Grade = student.Grade
                    }
            End Get
        End Property

    End Class
End Namespace

