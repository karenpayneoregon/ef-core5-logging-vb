Imports ExampleConsoleApplication.Models
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata.Builders

Namespace Context.Configuration
	Public Class CourseDayConfiguration
		Implements IEntityTypeConfiguration(Of CourseDay)

		Public Sub Configure(builder As EntityTypeBuilder(Of CourseDay)) Implements IEntityTypeConfiguration(Of CourseDay).Configure
			builder.ToTable("CourseDay")
			builder.Property(Function(e) e.Offered).HasDefaultValueSql("((0))")
			builder.HasOne(Function(d) d.DayIndexNavigation).WithMany(Function(p) p.CourseDays).HasForeignKey(Function(d) d.DayIndex).HasConstraintName("FK_CourseDay_WeekDay")
		End Sub
	End Class
End Namespace
