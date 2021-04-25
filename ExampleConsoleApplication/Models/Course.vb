
Namespace Models
	Partial Public Class Course
		Public Sub New()
			CourseInstructors = New HashSet(Of CourseInstructor)()
			StudentGrades = New HashSet(Of StudentGrade)()
		End Sub

		Public Property CourseID() As Integer
		Public Property Title() As String
		Public Property Credits() As Integer
		Public Property DepartmentID() As Integer

		Public Overridable Property Department() As Department
		Public Overridable Property OnlineCourse() As OnlineCourse
		Public Overridable Property OnsiteCourse() As OnsiteCourse
		Public Overridable Property CourseInstructors() As ICollection(Of CourseInstructor)
		Public Overridable Property StudentGrades() As ICollection(Of StudentGrade)
	End Class
End Namespace