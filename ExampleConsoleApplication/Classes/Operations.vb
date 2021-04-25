
Imports ExampleConsoleApplication.Context

Namespace Classes
	Public Class Operations

		Public Shared Function DemonstrationLoggingTask() As Task

			Using context As New SchoolContext()

				context.People.FirstOrDefault()

			End Using

			Return Nothing

		End Function

	End Class
End Namespace
