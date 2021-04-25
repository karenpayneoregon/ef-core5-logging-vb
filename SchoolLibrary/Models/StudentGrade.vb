Namespace Models
	Partial Public Class StudentGrade
		Public Property EnrollmentID() As Integer
		Public Property CourseID() As Integer
		Public Property StudentID() As Integer
		Public Property Grade() As Decimal?

		Public Overridable Property Course() As Course
		Public Overridable Property Student() As Person
	End Class
End Namespace