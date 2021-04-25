Namespace Models
	Partial Public Class Department
		Public Sub New()
			Courses = New HashSet(Of Course)()
		End Sub

		Public Property DepartmentID() As Integer
		Public Property Name() As String
		Public Property Budget() As Decimal
		Public Property StartDate() As DateTime
		Public Property Administrator() As Integer?

		Public Overridable Property Courses() As ICollection(Of Course)
	End Class
End Namespace