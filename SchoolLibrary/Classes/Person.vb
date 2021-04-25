
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

		Public Overrides Function ToString() As String
			Return $"{PersonID,-5:D2}{FullName,-20}{If(HireDate.HasValue, HireDate.Value.ToShortDateString(), "(null)")}"
		End Function
	End Class
End Namespace
