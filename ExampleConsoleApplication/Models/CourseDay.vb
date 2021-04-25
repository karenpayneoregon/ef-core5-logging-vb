Namespace Models
	Partial Public Class CourseDay
		Public Property id() As Integer
		Public Property CourseID() As Integer?
		Public Property DayIndex() As Integer?
		Public Property Offered() As Boolean?

		Public Overridable Property DayIndexNavigation() As WeekDayName
	End Class
End Namespace