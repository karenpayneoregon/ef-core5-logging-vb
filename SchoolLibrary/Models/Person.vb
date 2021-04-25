Imports Newtonsoft.Json

Namespace Models
	Partial Public Class Person
		Public Sub New()
			CourseInstructors = New HashSet(Of CourseInstructor)()
			StudentGrades = New HashSet(Of StudentGrade)()
		End Sub

		Public Property PersonID() As Integer
		Public Property LastName() As String
		Public Property FirstName() As String
		Public Property HireDate() As DateTime?
		Public Property EnrollmentDate() As DateTime?
		Public Property Discriminator() As String

		Public Overridable Property OfficeAssignment() As OfficeAssignment
		<JsonIgnore>
		Public Overridable Property CourseInstructors() As ICollection(Of CourseInstructor)
		<JsonIgnore>
		Public Overridable Property StudentGrades() As ICollection(Of StudentGrade)
	End Class
End Namespace