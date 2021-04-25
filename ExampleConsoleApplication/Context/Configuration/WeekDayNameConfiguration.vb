Imports ExampleConsoleApplication.Models
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata.Builders

Namespace Context.Configuration
	Public Class WeekDayNameConfiguration
		Implements IEntityTypeConfiguration(Of WeekDayName)

		Public Sub Configure(ByVal entity As EntityTypeBuilder(Of WeekDayName)) Implements IEntityTypeConfiguration(Of WeekDayName).Configure

			entity.HasKey(Function(e) e.WeekId).
				HasName("PK_WeekDay")

			entity.ToTable("WeekDayName")

			entity.Property(Function(e) e.DayName).
				IsRequired()

		End Sub


	End Class
End Namespace
