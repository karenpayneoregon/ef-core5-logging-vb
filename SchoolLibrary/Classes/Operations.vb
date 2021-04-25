Imports Microsoft.EntityFrameworkCore
Imports SchoolLibrary.Context
Imports SchoolLibrary.Models

Namespace Classes
    ''' <summary>
    ''' This is where all operations are to be placed, call from client.
    ''' At present we are here to demonstrate setup logging
    ''' </summary>
    Public Class Operations

        Public Shared Function DemonstrationLoggingTask() As Task

            Using context As New SchoolContext()

                context.People.FirstOrDefault()

            End Using

            Return Nothing

        End Function
        ''' <summary>
        ''' Get all people with includes for course and student grades asynchronously 
        ''' </summary>
        ''' <returns>List of <see cref="Person"/></returns>
        Public Shared Async Function PeopleTask() As Task(Of List(Of Person))

            Return Await Task.Run(Async Function() As Task(Of List(Of Person))

                                      Using context As New SchoolContext()

                                          Dim results = Await context.People.
                                                  Include(Function(person As Person) person.StudentGrades).
                                                  ThenInclude(Function(person As StudentGrade) person.Course).
                                                  Select(Function(person) person).
                                                  ToListAsync()

                                          Return results

                                      End Using

                                  End Function)

        End Function
        ''' <summary>
        ''' Get all people with includes for course and student grades synchronously 
        ''' </summary>
        ''' <returns>List of <see cref="Person"/></returns>
        Public Shared Function People() As List(Of Person)

            Using context As New SchoolContext()

                Dim results = context.People.
                        Include(Function(person As Person) person.StudentGrades).
                        ThenInclude(Function(person As StudentGrade) person.Course).
                        Select(Function(person) person).
                        ToList()

                Return results
            End Using


        End Function
    End Class
End Namespace
