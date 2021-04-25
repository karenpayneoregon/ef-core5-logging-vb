Imports SchoolLibrary.Models

Namespace Classes

    Public Class PersonEntity
        Public Property PersonID() As Integer
        Public Property FirstName() As String
        Public Property LastName() As String
        Public ReadOnly Property FullName() As String
            Get
                Return $"{FirstName} {LastName}"
            End Get
        End Property
        Public Property Grades() As ICollection(Of StudentGrade)
    End Class
End Namespace