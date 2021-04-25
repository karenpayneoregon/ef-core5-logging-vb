Imports System.Diagnostics
Imports System.IO
Imports Configurations
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Diagnostics
Imports Microsoft.Extensions.Logging

Namespace Context
	Partial Public Class SchoolContext

		''' <summary>
		''' For logging to file via .LogTo
		''' </summary>
		Private ReadOnly _logStream As New StreamWriter(Helper.LogFileName(), append:=True)

		Private Shared Sub NoLogging(ByVal optionsBuilder As DbContextOptionsBuilder)
			optionsBuilder.UseSqlServer(Helper.ConnectionString())
		End Sub
		''' <summary>
		''' Log information to Visual Studio's Output window
		''' </summary>
		''' <param name="optionsBuilder"></param>
		Private Shared Sub LogQueryInfoToDebugOutputWindow(ByVal optionsBuilder As DbContextOptionsBuilder)
			optionsBuilder.UseSqlServer(Helper.ConnectionString()).EnableSensitiveDataLogging().LogTo(Sub(message) Debug.WriteLine(message))
		End Sub

		''' <summary>
		''' Log information to file
		''' </summary>
		''' <param name="optionsBuilder"></param>
		Private Sub LogQueryInfoToFile(optionsBuilder As DbContextOptionsBuilder)
			optionsBuilder.UseSqlServer(Helper.ConnectionString()).
				EnableSensitiveDataLogging().LogTo(Sub(message) _logStream.WriteLine(message), LogLevel.Information, DbContextLoggerOptions.Category)
		End Sub
		''' <summary>
		''' Log when Includes are done
		''' </summary>
		''' <param name="optionsBuilder"></param>
		Private Sub LogIncludesInfoToFile(ByVal optionsBuilder As DbContextOptionsBuilder)
			optionsBuilder.UseSqlServer(Helper.ConnectionString()).EnableSensitiveDataLogging().LogTo(AddressOf _logStream.WriteLine, {CoreEventId.NavigationBaseIncluded})
		End Sub

		Private Sub LogQueryInfoToFIle1(ByVal optionsBuilder As DbContextOptionsBuilder)
			optionsBuilder.UseSqlServer(Helper.ConnectionString()).EnableSensitiveDataLogging().LogTo(Sub(message) _logStream.WriteLine(message), LogLevel.Information)
		End Sub

		'Public Sub IDisposable_Dispose() Implements IDisposable.Dispose
		'	_logStream.Dispose()
		'End Sub
		Public Overrides Sub Dispose()
			MyBase.Dispose()
			_logStream.Dispose()
		End Sub
	End Class
End Namespace
