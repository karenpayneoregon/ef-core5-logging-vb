
'
' DO NOT Change this namespace
'
Namespace Models
	Partial Public Class Person
		Public ReadOnly Property FullName() As String
			Get
				Return $"{FirstName} {LastName}"
			End Get
		End Property
	End Class
End Namespace
