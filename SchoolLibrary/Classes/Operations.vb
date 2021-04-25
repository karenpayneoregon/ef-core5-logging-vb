Imports Microsoft.EntityFrameworkCore
Imports SchoolLibrary.Context
Imports SchoolLibrary.Models
Imports SchoolLibrary.Extensions

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

                                          Dim peopleList = Await context.People.
                                                  Include(Function(person As Person) person.StudentGrades).
                                                  ThenInclude(Function(person As StudentGrade) person.Course).
                                                  Select(Function(person) person).
                                                  ToListAsync()

                                          Return peopleList

                                      End Using

                                  End Function)

        End Function
        ''' <summary>
        ''' Get all people with includes for course and student grades synchronously 
        ''' </summary>
        ''' <returns>List of <see cref="Person"/></returns>
        Public Shared Function People() As List(Of Person)

            Using context As New SchoolContext()

                Dim peopleList = context.People.
                        Include(Function(person As Person) person.StudentGrades).
                        ThenInclude(Function(person As StudentGrade) person.Course).
                        Select(Function(person) person).
                        ToList()

                Return peopleList
            End Using


        End Function

        Public Delegate Sub OnIteratePersonGrades(ByVal personData As PersonGrades)
        Public Shared Event OnIteratePersonGradesEvent As OnIteratePersonGrades
        ''' <summary>
        ''' - Get students grades for a specific class by course identifier, return a list of <see cref="StudentEntity"/>
        ''' - Use an event to listeners for displaying student details.
        ''' </summary>
        ''' <param name="courseIdentifier">Course identifier</param>
        ''' <returns><see cref="List(Of StudentEntity)"/></returns>
        Public Shared Function GradesForPeople(Optional courseIdentifier As Integer = 2021) As List(Of StudentEntity)

            Using context As New SchoolContext()

                Dim studentEntities As List(Of StudentEntity) = context.StudentGrades.
                        Include(Function(studentEntity) studentEntity.Student).
                        Select(StudentGrade.Projection).
                        Where(Function(studentEntity) studentEntity.CourseID = courseIdentifier).
                        ToList()

                For Each studentEntity As StudentEntity In studentEntities

                    Dim letterGrade = ""

                    Select Case studentEntity.Grade
                        Case studentEntity.Grade.Value.Between(1, 2)
                            letterGrade = "F"
                        Case 2.5
                            letterGrade = "C"
                        Case 3.0
                            letterGrade = "B"
                        Case 3.5
                            letterGrade = "A"
                        Case 4.0
                            letterGrade = "A+"
                        Case Else
                            letterGrade = "F"
                    End Select

                    RaiseEvent OnIteratePersonGradesEvent(
                        New PersonGrades() With {
                                                     .PersonID = studentEntity.PersonID,
                                                     .FirstName = studentEntity.FirstName,
                                                     .LastName = studentEntity.LastName,
                                                     .Grade = studentEntity.Grade,
                                                     .GradeLetter = letterGrade
                        })

                Next

                Return studentEntities

            End Using

        End Function
    End Class
End Namespace
