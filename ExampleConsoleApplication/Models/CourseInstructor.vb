Namespace Models
	Partial Public Class CourseInstructor
		Public Property CourseID() As Integer
		Public Property PersonID() As Integer

		Public Overridable Property Course() As Course
		Public Overridable Property Person() As Person
	End Class
End Namespace