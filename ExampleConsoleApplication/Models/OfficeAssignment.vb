Namespace Models
	Partial Public Class OfficeAssignment
		Public Property InstructorID() As Integer
		Public Property Location() As String
		Public Property Timestamp() As Byte()

		Public Overridable Property Instructor() As Person
	End Class
End Namespace