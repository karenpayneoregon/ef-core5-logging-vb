Imports SchoolLibrary.Classes
Imports SchoolLibrary.Models

Module Program
	Sub Main()
        Operations.DemonstrationLoggingTask()
    End Sub
    ''' <summary>
    ''' Simple example for reading people with Include and ThenInclude for navigation Course and Student Grade
    ''' </summary>
    Private Sub DisplayPeople()
        Dim people = Operations.People()
        For Each person As Person In people
            Debug.WriteLine(person)
        Next
    End Sub
End Module
