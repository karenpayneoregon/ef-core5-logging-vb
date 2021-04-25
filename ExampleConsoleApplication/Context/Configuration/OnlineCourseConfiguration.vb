Imports ExampleConsoleApplication.Models
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata.Builders

Namespace Context.Configuration
	Public Class OnlineCourseConfiguration
		Implements IEntityTypeConfiguration(Of OnlineCourse)

		Public Sub Configure(ByVal entity As EntityTypeBuilder(Of OnlineCourse)) Implements IEntityTypeConfiguration(Of OnlineCourse).Configure
			entity.HasKey(Function(e) e.CourseID)
			entity.ToTable("OnlineCourse")
			entity.Property(Function(e) e.CourseID).ValueGeneratedNever()
			entity.Property(Function(e) e.URL).IsRequired().HasMaxLength(100)
			entity.HasOne(Function(d) d.Course).WithOne(Function(p) p.OnlineCourse).HasForeignKey(Of OnlineCourse)(Function(d) d.CourseID).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_OnlineCourse_Course")
		End Sub
	End Class
End Namespace
