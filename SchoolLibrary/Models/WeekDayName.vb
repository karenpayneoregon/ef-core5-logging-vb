Namespace Models
	Partial Public Class WeekDayName
		Public Sub New()
			CourseDays = New HashSet(Of CourseDay)()
		End Sub

		Public Property WeekId() As Integer
		Public Property DayName() As String

		Public Overridable Property CourseDays() As ICollection(Of CourseDay)
	End Class
End Namespace