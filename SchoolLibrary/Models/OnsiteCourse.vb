Namespace Models
	Partial Public Class OnsiteCourse
		Public Property CourseID() As Integer
		Public Property Location() As String
		Public Property Days() As String
		Public Property Time() As DateTime

		Public Overridable Property Course() As Course
	End Class
End Namespace