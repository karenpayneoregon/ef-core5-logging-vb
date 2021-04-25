Imports Configurations
Imports ExampleConsoleApplication.Context.Configuration
Imports ExampleConsoleApplication.Models
Imports Microsoft.EntityFrameworkCore

Namespace Context
	Partial Public Class SchoolContext
		Inherits DbContext
		'Implements IDisposable

		Public Sub New()
		End Sub

		Public Sub New(ByVal options As DbContextOptions(Of SchoolContext))
			MyBase.New(options)
		End Sub

		Public Overridable Property Courses() As DbSet(Of Course)
		Public Overridable Property CourseDays() As DbSet(Of CourseDay)
		Public Overridable Property CourseInstructors() As DbSet(Of CourseInstructor)
		Public Overridable Property Departments() As DbSet(Of Department)
		Public Overridable Property OfficeAssignments() As DbSet(Of OfficeAssignment)
		Public Overridable Property OnlineCourses() As DbSet(Of OnlineCourse)
		Public Overridable Property OnsiteCourses() As DbSet(Of OnsiteCourse)
		Public Overridable Property People() As DbSet(Of Models.Person)
		Public Overridable Property StudentGrades() As DbSet(Of StudentGrade)
		Public Overridable Property WeekDayNames() As DbSet(Of WeekDayName)

		Protected Overrides Sub OnConfiguring(ByVal optionsBuilder As DbContextOptionsBuilder)

			If Not optionsBuilder.IsConfigured Then

				Select Case Helper.LoggingDestination()
					Case LoggingDestination.DebugWindow
						LogQueryInfoToDebugOutputWindow(optionsBuilder)
					Case LoggingDestination.LogFile
						LogQueryInfoToFile(optionsBuilder)
					Case LoggingDestination.None
						NoLogging(optionsBuilder)
					Case Else
						Throw New ArgumentOutOfRangeException()
				End Select

			End If

		End Sub

		Protected Overrides Sub OnModelCreating(ByVal modelBuilder As ModelBuilder)

			modelBuilder.ApplyConfiguration(New CourseConfiguration())
			modelBuilder.ApplyConfiguration(New CourseDayConfiguration())
			modelBuilder.ApplyConfiguration(New CourseInstructorConfiguration())
			modelBuilder.ApplyConfiguration(New DepartmentConfiguration())
			modelBuilder.ApplyConfiguration(New OfficeAssignmentConfiguration())
			modelBuilder.ApplyConfiguration(New OnlineCourseConfiguration())
			modelBuilder.ApplyConfiguration(New OnsiteCourseConfiguration())
			modelBuilder.ApplyConfiguration(New PersonConfiguration())
			modelBuilder.ApplyConfiguration(New StudentGradeConfiguration())
			modelBuilder.ApplyConfiguration(New WeekDayNameConfiguration())

			OnModelCreatingPartial(modelBuilder)
		End Sub

		Partial Private Sub OnModelCreatingPartial(ByVal modelBuilder As ModelBuilder)
		End Sub

	End Class
End Namespace
